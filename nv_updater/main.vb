Imports System.Collections
Imports System.ComponentModel
Imports System.Environment
Imports System.IO
Imports sw.wsc.update
Module main
    Public Sub Main()

        Dim owned As Boolean
        Dim mut As New System.Threading.Mutex(True, "xvcjsdf67AS124436cx544ew#$3", owned)
        If owned Then
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MyContext)
            mut.ReleaseMutex()
        Else
            MessageBox.Show("A previous instance is already running")
        End If
    End Sub
End Module

Public Class MyContext
    Inherits ApplicationContext
    Public WithEvents TrayIcon As New NotifyIcon
    Private WithEvents CMS As New ContextMenuStrip
    Private WithEvents About As New ToolStripMenuItem("About", My.Resources.about16)
    Private WithEvents Help As New ToolStripMenuItem("Help", My.Resources.help16)
    Private WithEvents Sep As New ToolStripSeparator
    Private WithEvents Options As New ToolStripMenuItem("Options", My.Resources.settings16)
    Private WithEvents Update As New ToolStripMenuItem("Check for APP update", My.Resources.updates16)
    Private WithEvents LocalFile As New ToolStripMenuItem("Install a local driver", My.Resources.file16)
    Private WithEvents ExitMenu As New ToolStripMenuItem("Exit", My.Resources.end16)
    Private WithEvents CheckDriver As New System.ComponentModel.BackgroundWorker
    Private DriverBackgroundCheck As BackgroundWorker
    Private UpdateBackgroundCheck As BackgroundWorker
    Public Driver As New ArrayList
    Private uTest As Boolean

    'updatestatus
    Public updState As Boolean = False

    Public Sub New()

        'config-file operations at first start
        If Not Directory.Exists(Settings.AppConfigFolder) Then
            Directory.CreateDirectory(Settings.AppConfigFolder)
            Directory.CreateDirectory(Settings.AppConfigFolder + "\Logs")
            Directory.CreateDirectory(Settings.AppConfigFolder + "\Download")
        End If

        'WSC Updater Config
        Updatelib.FileID = 9
        Updatelib.WSCUrl = "https://www.sys-worx.net"
        Updatelib.FileBasePackageName = "filebase"
        Updatelib.StartArgs = "/SILENT"

        'convert ini to json if not exists // initial create json config
        If Not File.Exists(Settings.AppConfigJson) And File.Exists(AppConfig) Then
            Settings.ConvertIniJson()
            File.Delete(AppConfig)
        ElseIf Not File.Exists(Settings.AppConfigJson) Then
            Settings.Config = Settings.Read()
            Settings.Config.info.installed = Now.ToString()
            Settings.Config.application.autorun = False
            Settings.Config.application.autoupdate = True
            Settings.Config.application.logmode = False
            Settings.Config.application.updatetimer = 21600000
            Settings.Config.application.run = False
            Settings.Config.application.runPath = String.Empty
            Settings.Config.application.runOptions = String.Empty
            Settings.Config.update.ignore = False
            Settings.Config.update.Version = Nothing
            Settings.Config.update.silent = False
            Settings.Config.update.clean = False
            Settings.Config.update.telemetry = False
            Settings.Config.update.rgbfix = False
            Settings.Config.update.dchdriver = True
            Settings.Config.update.rgbtoggle = "Full"
            Settings.Config.update.ShieldWirelessController = False
            Settings.Config.update.DisplayOptimus = False
            Settings.Config.update.ShadowPlay = False
            Settings.Config.update.NvContainer = False
            Settings.Config.update.NvvHCI = False
            Settings.Config.update.PhysX = False
            Settings.Config.update.GFExperience = True
            Settings.Config.update.NvCamera = False
            Settings.Config.update.HDAudio = False
            Settings.Config.update.PPC = False
            Settings.Config.update.DisplayNView = False
            Settings.Config.update.DisplayUpdate = False
            Settings.Config.update.MSVCRT = False
            Settings.Config.update.NGXCore = False
            Settings.Config.update.nodejs = False
            Settings.Config.update.NvAbHub = False
            Settings.Config.update.NvBackend = False
            Settings.Config.update.NvVAD = False
            Settings.Config.update.NvvHCI = False
            Settings.Config.update.NVWMI = False
            Settings.Config.update.UpdateCore = False
            Settings.Config.update.hotfix = False
            Settings.Config.update.studio = False
            Settings.Config.update.FrameViewSDK = False
            Settings.Save(Settings.Config)
            Directory.CreateDirectory(Settings.AppConfigFolder + "\Logs")
            Directory.CreateDirectory(Settings.AppConfigFolder + "\Download")
        End If

        'Read json settings and save for new fields
        Settings.Config = Settings.Read()
        Settings.Save(Settings.Config)

        'set logfile mode
        logMode = Boolean.Parse(Settings.Config.application.logmode)
        Log("Application started...")

        'check for app update if enabled and internet check is ok
        Dim autoupdate As Boolean = Boolean.Parse(Settings.Config.application.autoupdate)
        If autoupdate = True Then
            If CheckForInternetConnection() = True Then
                Dim uTest As Boolean = Updatelib.UpdateCheck()
            Else
                Log("No Internet-Connection found, APP Update check aborted...")
            End If
        End If

        'Set Variables for OS
        Dim OS As ArrayList = OSInfos()
        nvLang = OS(0)
        OSVer = OS(1)
        nvOS = OS(2)

        'Check Win10 light/darkmode
        If OSVer = 10 Or OSVer = 11 Then
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", True)
            Lightmode = regKey.GetValue("SystemUsesLightTheme")
            regKey.Close()
            If Lightmode = True Then
                Log("Windows 10/11 is using light design mode")
            Else
                Log("Windows 10/11 is using dark design mode")
            End If
        End If

        ' create context menu
        If Lightmode = True Then
            TrayIcon.Icon = My.Resources.app
        Else
            TrayIcon.Icon = My.Resources.app_darkmode
        End If
        TrayIcon.Text = "NV Updater (by Sys-worX.net)"
        TrayIcon.Visible = True
        CMS.Items.Add(About)
        CMS.Items.Add(Help)
        CMS.Items.Add(Sep)
        CMS.Items.Add(Update)
        CMS.Items.Add(LocalFile)
        CMS.Items.Add(Options)
        CMS.Items.Add(ExitMenu)
        TrayIcon.ContextMenuStrip = CMS

        'Update Timer 
        AddHandler updateTimer.Tick, AddressOf updateTimerTick
        updateTimer.Interval = Integer.Parse(Settings.Config.application.updatetimer)
        updateTimer.Start()

        'start nvidia check
        DriverBackgroundCheck = New BackgroundWorker With {
            .WorkerReportsProgress = True,
            .WorkerSupportsCancellation = True
        }
        AddHandler DriverBackgroundCheck.DoWork, AddressOf DriverBackgroundCheck_DoWork
        AddHandler DriverBackgroundCheck.RunWorkerCompleted, AddressOf DriverBackgroundCheck_RunWorkerCompleted

        If Not DriverBackgroundCheck.IsBusy Then
            DriverBackgroundCheck.RunWorkerAsync("Auto")
        End If

    End Sub

    Private Sub updateTimerTick(sender As Object, e As EventArgs)
        If Not DriverBackgroundCheck.IsBusy Then
            DriverBackgroundCheck.RunWorkerAsync("Auto")
        End If
    End Sub

    Private Sub CMS_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        ' From this event you can control which menu items appear (visibility or disabled) or 
        ' even cancel the event and prevent the context menu from appearing at all
    End Sub

    Private Sub ExitMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitMenu.Click
        Application.Exit()
    End Sub

    Private Sub LocalFileMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocalFile.Click
        'Opens the local file
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "exe files (*.exe)|*.exe"
        openFile.FilterIndex = 2
        openFile.RestoreDirectory = True

        'do some easy checks and copy the file to temp to prevent long file path errors with 7zip
        If openFile.ShowDialog() = DialogResult.OK Then
            Dim DriverLocation As String = openFile.FileName.ToString
            Dim DriverVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(DriverLocation)
            Dim dFolder As String = GetFolderPath(SpecialFolder.ApplicationData) + "\" + Application.ProductName.ToString + "\Download\"
            Dim FileLocation As String = $"{Environ("temp")}\driver.exe"

            If DriverVersionInfo.ProductName.ToString = "NVIDIA Package Launcher" And DriverVersionInfo.CompanyName.ToString = "NVIDIA Corporation" Then

                If File.Exists(DriverLocation) = True Then
                    If File.Exists(FileLocation) = True Then
                        File.Delete(FileLocation)
                    End If
                    File.Copy(DriverLocation, FileLocation)
                    frm_download.localInstall = True
                    frm_download.localFilePath = FileLocation
                    frm_download.Show()
                End If

            Else
                MessageBox.Show("This seems not to be a NVIDIA Driver Package!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

        End If
    End Sub

    Private Sub OptionsMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Options.Click
        frm_options.Show()
    End Sub

    Private Sub UpdateMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Update.Click
        If CheckForInternetConnection() = True Then
            Dim muTest As Boolean = Updatelib.UpdateCheck()
            If muTest = False Then
                MsgBox("No new version was found, you are already using the latest version!", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("No Internet-Connection found, APP Update check aborted.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub AboutMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles About.Click
        frm_about.Show()
    End Sub

    Private Sub HelpMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Help.Click
        Dim url As String = “https://www.sys-worx.net/nv-updater-faq-en/“
        Process.Start(url)
    End Sub

    Private Sub MyContext_ThreadExit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ThreadExit
        TrayIcon.Visible = False
    End Sub

    Private Sub TrayIconClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrayIcon.DoubleClick
        'manual update check
        If Not DriverBackgroundCheck.IsBusy Then
            DriverBackgroundCheck.RunWorkerAsync("Manual")
            ShowNotification(Me, New NotificationEventArgs("Update Check", "Running a manual update check, please wait...", 3000))
        Else
            ShowNotification(Me, New NotificationEventArgs("Update Check", "A update check task is already in progress, please wait...", 3000))
        End If
    End Sub

    Private Sub ShowNotification(sender As Object, e As NotificationEventArgs)
        TrayIcon.BalloonTipTitle = e.Title
        TrayIcon.BalloonTipText = e.Text
        TrayIcon.ShowBalloonTip(e.Duration)
    End Sub

    Public Function CheckForDriver(ByVal mode As String) As ArrayList
        Driver.Add(mode)

        'clear the Array
        If (OnlineInfo IsNot Nothing AndAlso OnlineInfo.Count > 0) Then
            OnlineInfo.Clear()
        End If

        'Log the Driver settings
        Dim DrvDCH As Boolean = Boolean.Parse(Settings.Config.update.dchdriver)
        Dim DrvStudio As Boolean = Boolean.Parse(Settings.Config.update.studio)
        Dim DrvHotfix As Boolean = Boolean.Parse(Settings.Config.update.hotfix)

        'create nvidia link and check online drivers
        If CheckForInternetConnection() = True Then
            log("NVIDIA Update-Check started...")
            log($"Driver Mode Hotfix = {DrvHotfix.ToString}")
            log($"Driver Mode DCH = {DrvDCH.ToString}")
            log($"Driver Mode Studio = {DrvStudio.ToString}")
            Dim nvGfxLink As String = ProcessDriverLink()
            log("NVIDIA Link: " + nvGfxLink)
            OnlineInfo = GetOnlineVersion(nvGfxLink)
            log("Installed Driver: " + GraphicsInfo(7))
            log("Online Driver: " + OnlineInfo(0) + " (" + OnlineInfo(4) + " MB)")
            log("Release-Date: " + OnlineInfo(1))
            log("NVIDIA Downloadlink: " + OnlineInfo(3))

            'version check
            If OnlineInfo(0) > GraphicsInfo(7) Then
                'check if verion is ignored by user
                If Settings.Config.update.ignore = True And Settings.Config.update.Version = OnlineInfo(0) Then
                    Log("NVIDIA Update-Check: Update found but user choose to ignore")
                    Driver.Add("NoDriver")
                    Driver.Add(GraphicsInfo(7))                                         '2: Installed Driver
                    Driver.Add(OnlineInfo(0) + " (" + OnlineInfo(4) + "MB) [ignored]")  '3: Online Version + Size
                    Driver.Add(OnlineInfo(2))                                           '4: Release Notes
                    Driver.Add(OnlineInfo(0))
                Else
                    updateTimer.Stop()
                    log("NVIDIA Update-Check: Update found")

                    'Set Results
                    Driver.Add("Normal")                                            '1: New Version available
                    Driver.Add(GraphicsInfo(7))                                     '2: Installed Driver
                    Driver.Add(OnlineInfo(0) + " (" + OnlineInfo(4) + "MB)")        '3: Online Version + Size
                    Driver.Add(OnlineInfo(2))                                       '4: Release Notes
                    Driver.Add(OnlineInfo(0))                                       '5: Online Version
                End If
            Else
                'Check for hotfix
                Dim HotfixCheck As Boolean = DrvHotfix
                If HotfixCheck = True Then
                    Try
                        Dim Hotfix As ArrayList = getHotfix()
                        Dim DownloadSize As Double
                        Dim HotfixFound As Boolean = False

                        If Hotfix(0) = True Then

                            'get downloadsize of the file
                            Dim r As Net.WebRequest = Net.WebRequest.Create(Hotfix(4))
                            r.Method = Net.WebRequestMethods.Http.Head
                            Using rsp = r.GetResponse()
                                DownloadSize = (rsp.ContentLength / 1024) / 1024
                            End Using
                            Dim FileSize As String = Format(DownloadSize, "###,###,##0.00")

                            If Settings.Config.update.ignore = True And Settings.Config.update.Version = Hotfix(1) Then
                                Log("NVIDIA Hotfix-Check: Hotfix found but user choose to ignore")
                                Driver.Add("NoDriver")
                                Driver.Add(GraphicsInfo(7))                                         '2: Installed Driver
                                Driver.Add(OnlineInfo(0) + " (" + OnlineInfo(4) + "MB) [ignored]")  '3: Online Version + Size
                                Driver.Add(OnlineInfo(2))                                           '4: Release Notes
                                Driver.Add(OnlineInfo(0))                                           '5: Online Version
                            Else
                                If Hotfix(1) > GraphicsInfo(7) Then
                                    updateTimer.Stop()
                                    HotfixFound = True

                                    Driver.Add("Hotfix")                                            '1: New Version available
                                    Driver.Add(GraphicsInfo(7))                                     '2: Installed Driver
                                    Driver.Add(Hotfix(1) + " [HOTFIX] (" + FileSize + "MB)")        '3: Online Version + Size
                                    Driver.Add(Hotfix(3))                                           '4: Release Notes
                                    Driver.Add(Hotfix(1))                                           '5: Online Version
                                    Driver.Add(Hotfix(4))                                           '6: HotFixURL

                                    log($"NVIDIA Update-Check: Hotfix found")
                                    log("Installed Driver: " + GraphicsInfo(7))
                                    log("Online Driver: " + Hotfix(1) + " [HOTFIX] (" + FileSize + "MB)")
                                    log("NVIDIA Downloadlink: " + Hotfix(4))
                                End If
                                log($"NVIDIA Update-Check: Old hotfix found ({Hotfix(1)})")
                            End If
                        End If

                        If HotfixFound = False Then
                            Driver.Add("NoDriver")                                          '1: New Version available
                            Driver.Add(GraphicsInfo(7))                                     '2: Installed Driver
                            Driver.Add(OnlineInfo(0) + " (" + OnlineInfo(4) + "MB)")        '3: Online Version + Size
                            Driver.Add(OnlineInfo(2))                                       '4: Release Notes
                            Driver.Add(OnlineInfo(0))                                       '5: Online Version
                        End If

                    Catch ex As Exception
                        MsgBox("There was an error at Hotfix-Check! Error was saved to Logfile" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
                        LogHelper.Errorlog("There was an Error at Hotfix-Check" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
                    End Try
                Else
                    log("Hotfix Check is disabled")
                    Driver.Add("NoDriver")                                          '1: New Version available
                    Driver.Add(GraphicsInfo(7))                                     '2: Installed Driver
                    Driver.Add(OnlineInfo(0) + " (" + OnlineInfo(4) + "MB)")        '3: Online Version + Size
                    Driver.Add(OnlineInfo(2))                                       '4: Release Notes
                    Driver.Add(OnlineInfo(0))                                       '5: Online Version
                End If

            End If
        Else
            'log("No Internet-Connection found, Nvidia Update check aborted...")
            Driver.Add("NoInternet")
        End If
    End Function


    Private Sub DriverBackgroundCheck_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        CheckForDriver(e.Argument)
    End Sub

    Private Sub DriverBackgroundCheck_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        'Log the update mode
        Log($"NVIDIA Update-Check Mode: {Driver(0)} / {Driver(1)}")

        'if no update write to log
        If Driver(1) = "NoDriver" Then
            log("NVIDIA Update-Check: no Update found")
        End If

        'if no internet write to log
        If Driver(1) = "NoInternet" Then
            log("NVIDIA Update-Check: No Internet-Connection found, Nvidia Update check aborted...")
            ShowNotification(Me, New NotificationEventArgs("Update Check", "No Internet-Connection was found, update check aborted...", 3000))
        End If

        If Driver(0) = "Auto" And Driver(1) = "Hotfix" Then
            updateTimer.Stop()

            'This is needed to show notifications through the main sub
            frm_download.Enabled = True
            AddHandler frm_download.ShowNotification, AddressOf ShowNotification

            'set some labels and show the form
            frm_update.llbl_Install.Enabled = True
            frm_update.lbl_instVersion.Text = "Driver Version: " + Driver(2)
            frm_update.lbl_avVersion.Text = "Available Version: " + Driver(3)
            frm_update.ReleaseNotes = Driver(4)
            frm_update.Version = Driver(5)
            frm_download.HotfixUrl = Driver(6)
            frm_update.Show()

        End If

        If Driver(0) = "Auto" And Driver(1) = "Normal" Then
            updateTimer.Stop()

            'This is needed to show notifications through the main sub
            frm_download.Enabled = True
            AddHandler frm_download.ShowNotification, AddressOf ShowNotification

            'set some labels and show the form
            frm_update.llbl_Install.Enabled = True
            frm_update.lbl_instVersion.Text = "Driver Version: " + Driver(2)
            frm_update.lbl_avVersion.Text = "Available Version: " + Driver(3)
            frm_update.ReleaseNotes = Driver(4)
            frm_update.Version = Driver(5)
            frm_update.Show()

        End If

        If Driver(0) = "Manual" And Driver(1) = "Normal" Then
            updateTimer.Stop()

            'This is needed to show notifications through the main sub
            frm_download.Enabled = True
            AddHandler frm_download.ShowNotification, AddressOf ShowNotification

            'set some labels and show the form
            frm_update.llbl_Install.Enabled = True
            frm_update.lbl_instVersion.Text = "Driver Version: " + Driver(2)
            frm_update.lbl_avVersion.Text = "Available Version: " + Driver(3)
            frm_update.ReleaseNotes = Driver(4)
            frm_update.Version = Driver(5)

            frm_update.llbl_Install.Enabled = True
            frm_update.Show()

        End If

        If Driver(0) = "Manual" And Driver(1) = "Hotfix" Then
            updateTimer.Stop()

            'This is needed to show notifications through the main sub
            frm_download.Enabled = True
            AddHandler frm_download.ShowNotification, AddressOf ShowNotification

            'set some labels and show the form
            frm_update.llbl_Install.Enabled = True
            frm_update.lbl_instVersion.Text = "Driver Version: " + Driver(2)
            frm_update.lbl_avVersion.Text = "Available Version: " + Driver(3)
            frm_update.ReleaseNotes = Driver(4)
            frm_update.Version = Driver(5)
            frm_download.HotfixUrl = Driver(6)

            frm_update.llbl_Install.Enabled = True
            frm_update.Show()

        End If

        If Driver(0) = "Manual" And Driver(1) = "NoDriver" Then
            updateTimer.Stop()

            'This is needed to show notifications through the main sub
            frm_download.Enabled = True
            AddHandler frm_download.ShowNotification, AddressOf ShowNotification

            'set some labels and show the form
            frm_update.llbl_Install.Enabled = True
            frm_update.lbl_title.Text = "No new NVIDIA Driver available "
            frm_update.lbl_instVersion.Text = "Driver Version: " + Driver(2)
            frm_update.lbl_avVersion.Text = "Available Version: " + Driver(3)
            frm_update.ReleaseNotes = Driver(4)
            frm_update.Version = Driver(5)

            frm_update.llbl_Install.Enabled = False
            frm_update.Show()

        End If

        'Clear the lists
        Driver.Clear()

    End Sub

End Class