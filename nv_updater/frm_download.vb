Imports System.ComponentModel
Imports System.Environment
Imports System.Net
Imports System.IO
Imports System.Xml
Imports Microsoft.Win32
Imports System.Security.Principal

Public Class frm_download
    Public Event ShowNotification As EventHandler(Of NotificationEventArgs)
    'only download mode
    Public onlyDownload As Boolean
    Public localInstall As Boolean
    Public localFilePath As String
    Public setupOk As Boolean = True
    Public HotfixUrl As String
    Dim rgbtoggled As Boolean

    'install options
    Dim silent As Boolean = Settings.Config.update.silent
    Dim clean As Boolean = Settings.Config.update.clean
    Dim dch As Boolean = Settings.Config.update.dchdriver
    Dim telemetry As Boolean = Settings.Config.update.telemetry
    Dim rgbfix As Boolean = Settings.Config.update.rgbfix
    Dim rgbtoggle As String = Settings.Config.update.rgbtoggle
    Dim HotfixCheck As Boolean = Settings.Config.update.hotfix
    Dim runApp As Boolean = Settings.Config.application.run
    Dim runAppPath As String = Settings.Config.application.runPath
    Dim runAppOptions As String = Settings.Config.application.runOptions

    Dim ShieldWirelessController As Boolean = Settings.Config.update.ShieldWirelessController
    Dim DisplayOptimus As Boolean = Settings.Config.update.DisplayOptimus
    Dim ShadowPlay As Boolean = Settings.Config.update.ShadowPlay
    Dim NvContainer As Boolean = Settings.Config.update.NvContainer
    Dim NvvHCI As Boolean = Settings.Config.update.NvvHCI
    Dim PhysX As Boolean = Settings.Config.update.PhysX
    Dim GFExperience As Boolean = Settings.Config.update.GFExperience

    Dim NvCamera As Boolean = Settings.Config.update.NvCamera
    Dim HDAudio As Boolean = Settings.Config.update.HDAudio
    Dim PPC As Boolean = Settings.Config.update.PPC
    Dim DisplayNView As Boolean = Settings.Config.update.DisplayNView
    Dim DisplayUpdate As Boolean = Settings.Config.update.DisplayUpdate
    Dim MSVCRT As Boolean = Settings.Config.update.MSVCRT
    Dim NGXCore As Boolean = Settings.Config.update.NGXCore
    Dim nodejs As Boolean = Settings.Config.update.nodejs
    Dim NvAbHub As Boolean = Settings.Config.update.NvAbHub
    Dim NvBackend As Boolean = Settings.Config.update.NvBackend
    Dim NvVAD As Boolean = Settings.Config.update.NvVAD
    Dim NVWMI As Boolean = Settings.Config.update.NVWMI
    Dim UpdateCore As Boolean = Settings.Config.update.UpdateCore

    Dim FrameViewSDK As Boolean = Settings.Config.update.FrameViewSDK
    Dim NVModuleTracker As Boolean = Settings.Config.update.NVModuleTracker
    Dim NVPCF As Boolean = Settings.Config.update.NVPCF

    'set downloadfolder and filename
    Dim dFolder As String = GetFolderPath(SpecialFolder.ApplicationData) + "\" + Application.ProductName.ToString + "\Download\"
    Dim dFilename As String = OnlineInfo(3).SubString(OnlineInfo(3).LastIndexOf("/") + 1)
    Dim savePath As String = dFolder + dFilename
    Dim url As String = OnlineInfo(3)

    'check admin mode
    Dim identity = WindowsIdentity.GetCurrent()
    Dim principal = New WindowsPrincipal(identity)
    Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)

    ' Time variable for downloadspeed
    Dim startTime As DateTime

    Private Sub Frm_download_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Light/DarkMode
        If Lightmode = True Then
            Me.Icon = My.Resources.app
        Else
            Me.Icon = My.Resources.app_darkmode
        End If

        'set the form bottom right
        Me.Location = New Point(SystemInformation.WorkingArea.Right - Me.Width, SystemInformation.WorkingArea.Bottom - Me.Height)

        'downloadhandling
        If dch = True And String.IsNullOrEmpty(HotfixUrl) Then
            'url = Replace(OnlineInfo(3), "-whql.exe", "-dch-whql.exe")
            dFilename = url.Substring(OnlineInfo(3).LastIndexOf("/") + 1)
            savePath = dFolder + dFilename
            log("DCH Driver Mode activated")
        ElseIf dch = True And Not String.IsNullOrEmpty(HotfixUrl) Then
            url = HotfixUrl
            dFilename = url.Substring(HotfixUrl.LastIndexOf("/") + 1)
            savePath = dFolder + dFilename
        ElseIf Not String.IsNullOrEmpty(HotfixUrl) Then
            url = HotfixUrl
            dFilename = url.Substring(HotfixUrl.LastIndexOf("/") + 1)
            savePath = dFolder + dFilename
        End If

        Dim download As New WebClient()
        AddHandler download.DownloadProgressChanged, AddressOf Download_ProgressChanged
        AddHandler download.DownloadFileCompleted, AddressOf Download_Complete

        'delete file if exists
        EmptyDirectory(Settings.AppConfigFolder & "Download")

        'clearDownload()

        'start download
        If onlyDownload = False And localInstall = False Then
            log("Starting Download to: " + savePath)
            startTime = DateTime.Now
            download.DownloadFileAsync(New Uri(url), savePath)
        ElseIf onlyDownload = True And localInstall = False Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "exe files (*.exe)|*.exe"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            saveFileDialog1.FileName = dFilename

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                savePath = saveFileDialog1.FileName
                startTime = DateTime.Now
                download.DownloadFileAsync(New Uri(url), savePath)
                log("Starting Download (no install): " + savePath)
            Else
                updateTimer.Start()
                Me.Close()
                Return
            End If
        ElseIf localInstall = True Then
            localInstaller()
            log("Starting local install: " + savePath)
        End If

    End Sub

    Private Async Sub Download_Complete(sender As Object, e As AsyncCompletedEventArgs)

        'remove downloadspeed
        lbl_speed.Text = String.Empty

        'check if download is ok
        If e.Error IsNot Nothing Then
            log("Download Error: " + e.Error.ToString)
            MsgBox("The driver could not be downloaded correctly or the download was aborted! Please check your internet connection.", MsgBoxStyle.Critical)
            Me.Close()
            Return
        Else
            log("Download complete")
        End If

        If onlyDownload = False Then
            'unzip the package
            pb_download.Image = My.Resources.ok
            pb_extract.Visible = True
            lbl_extract.Visible = True
            log("Starting extracting")
            Dim zip7 As ProcessResult = Await RunProcessAsync(Application.StartupPath.ToString + "\helper\7za.exe", "x " + savePath, 3000000, dFolder, False, True)

            'extract is complete
            If zip7.ExitCode = 0 Then
                log("Extracting complete: 7-Zip Code " + zip7.ExitCode.ToString + " (" + dFolder + ")")
            Else
                log("Extracting failed: 7-Zip Code " + zip7.ExitCode.ToString)
                RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver installation", "The installation was aborted with a extracting error: " + zip7.ExitCode.ToString, 3000))
                Me.Close()
                Return
            End If
            pb_extract.Image = My.Resources.ok
            pb_install.Visible = True
            lbl_install.Visible = True

            'manipulating installer and starting
            Try
                Dim xmlDocument As XmlDocument = New XmlDocument()
                Dim setupFile As String = dFolder + "setup.cfg"
                xmlDocument.Load(setupFile)
                Dim LinesToDelete As String() = {"${{EulaHtmlFile}}", "${{FunctionalConsentFile}}", "${{PrivacyPolicyFile}}"}

                For Each line As String In LinesToDelete
                    Dim node As XmlElement = CType(xmlDocument.DocumentElement.SelectSingleNode("/setup/manifest/file[@name=""" & line & """]"), XmlElement)

                    If node IsNot Nothing Then
                        node.ParentNode.RemoveChild(node)
                    End If
                Next
                xmlDocument.Save(setupFile)
                log("Manipulating Installer: OK")
            Catch ex As Exception
                log("Manipulating Installer: Failed: " + ex.Message.ToString)
                MsgBox("Manipulating Installer: Failed: " + ex.Message.ToString)
                Application.Exit()
            End Try

            'delete driver packages (future enhancement)
            Await Task.Run(AddressOf packageDelete)

            'start setup
            Await Task.Run(AddressOf nvSetup)

            'setup aborted somehow
            If setupOk = False Then
                EmptyDirectory(Settings.AppConfigFolder & "Download")
                updateTimer.Start()
                RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver installation", "The installation was aborted!", 3000))
                Me.Close()
                Return
            End If

            pb_install.Image = My.Resources.ok
            log("New Driver installed")

            'Custom APP 
            If runApp = True Then
                Dim unused = Task.Run(AddressOf CustomApp)
            End If

            'Show Notification
            RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver installation", "The new driver was successfully installed!", 3000))

            'rgb fix
            If rgbfix = True Then
                If isElevated Then
                    log("NV Updater runs in admin mode")
                    If rgbtoggle = "Full" Then
                        log("Set RGB fix in full mode")
                        setFull(Registry.LocalMachine.OpenSubKey("SYSTEM"), Nothing, "")
                        rgbtoggled = True
                    End If

                    If rgbtoggle = "Half" Then
                        log("Set RGB fix in limited mode")
                        setLimited(Registry.LocalMachine.OpenSubKey("SYSTEM"), Nothing, "")
                        rgbtoggled = True
                    End If
                Else
                    log("NV Updater does not run in admin mode, RGB fix skipped")
                    MsgBox("NV Updater does not run in admin mode, RGB fix skipped! Please run NV Updater with administrator rights, if you want to use the RGB Fix.", MsgBoxStyle.Information)
                    rgbtoggled = False
                End If
            End If

            'start updatetimer and close
            updateTimer.Start()

            'delete file if exists
            EmptyDirectory(Settings.AppConfigFolder & "Download")

            'Notify about restart after RGB Toggle
            If rgbtoggled = True Then
                MsgBox("The PC must be restarted to accept the RGB settings!", MsgBoxStyle.Information)
            End If

            'closing form and start timer again
            updateTimer.Start()
            Me.Close()
        Else
            'closing form and start timer again
            RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver download", "The driver was successfully downloaded!", 3000))
            updateTimer.Start()
            Me.Close()
        End If
    End Sub

    Private Async Sub localInstaller()

        'local file install
        savePath = localFilePath
        log($"Local File will be used: {localFilePath}")

        'set some label details
        ProgressBar1.Value = 100
        lbl_progress.Text = "local File (not downloaded...)"

        If onlyDownload = False Then
            'unzip the package
            pb_download.Image = My.Resources.ok
            pb_extract.Visible = True
            lbl_extract.Visible = True
            log("Starting extracting")
            Dim zip7 As ProcessResult = Await RunProcessAsync(Application.StartupPath.ToString + "\helper\7za.exe", "x " + savePath, 3000000, dFolder, False, True)

            'extract is complete
            If zip7.ExitCode = 0 Then
                log("Extracting complete: 7-Zip Code " + zip7.ExitCode.ToString + " (" + dFolder + ")")
            Else
                log("Extracting failed: 7-Zip Code " + zip7.ExitCode.ToString)
                RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver installation", "The installation was aborted with a extracting error: " + zip7.ExitCode.ToString, 3000))
                Me.Close()
                Return
            End If
            pb_extract.Image = My.Resources.ok
            pb_install.Visible = True
            lbl_install.Visible = True

            'manipulating installer and starting
            Try
                Dim xmlDocument As XmlDocument = New XmlDocument()
                Dim setupFile As String = dFolder + "setup.cfg"
                xmlDocument.Load(setupFile)
                Dim LinesToDelete As String() = {"${{EulaHtmlFile}}", "${{FunctionalConsentFile}}", "${{PrivacyPolicyFile}}"}

                For Each line As String In LinesToDelete
                    Dim node As XmlElement = CType(xmlDocument.DocumentElement.SelectSingleNode("/setup/manifest/file[@name=""" & line & """]"), XmlElement)

                    If node IsNot Nothing Then
                        node.ParentNode.RemoveChild(node)
                    End If
                Next
                xmlDocument.Save(setupFile)
                log("Manipulating Installer: OK")
            Catch ex As Exception
                log("Manipulating Installer: Failed: " + ex.Message.ToString)
                MsgBox("Manipulating Installer: Failed: " + ex.Message.ToString)
                Application.Exit()
            End Try

            'delete driver packages (future enhancement)
            Await Task.Run(AddressOf packageDelete)

            'start setup
            Await Task.Run(AddressOf nvSetup)

            'setup aborted somehow
            If setupOk = False Then
                EmptyDirectory(Settings.AppConfigFolder & "Download")
                If File.Exists(localFilePath) = True Then
                    File.Delete(localFilePath)
                End If
                updateTimer.Start()
                RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver installation", "The installation was aborted!", 3000))
                Me.Close()
                Return
            End If

            pb_install.Image = My.Resources.ok
            Log("New Driver installed")

            'Custom APP 
            If runApp = True Then
                Dim unused = Task.Run(AddressOf CustomApp)
            End If

            'Show Notification
            RaiseEvent ShowNotification(Me, New NotificationEventArgs("NVIDIA driver installation", "The new driver was successfully installed!", 3000))

            'rgb fix
            If rgbfix = True Then
                If isElevated Then
                    log("NV Updater runs in admin mode")
                    If rgbtoggle = "Full" Then
                        log("Set RGB fix in full mode")
                        setFull(Registry.LocalMachine.OpenSubKey("SYSTEM"), Nothing, "")
                        rgbtoggled = True
                    End If

                    If rgbtoggle = "Half" Then
                        log("Set RGB fix in limited mode")
                        setLimited(Registry.LocalMachine.OpenSubKey("SYSTEM"), Nothing, "")
                        rgbtoggled = True
                    End If
                Else
                    log("NV Updater does not run in admin mode, RGB fix skipped")
                    MsgBox("NV Updater does not run in admin mode, RGB fix skipped! Please run NV Updater with administrator rights, if you want to use the RGB Fix.", MsgBoxStyle.Information)
                    rgbtoggled = False
                End If
            End If

            'start updatetimer and close
            updateTimer.Start()

            'delete file if exists
            EmptyDirectory(Settings.AppConfigFolder & "Download")
            If File.Exists(localFilePath) = True Then
                File.Delete(localFilePath)
            End If

            'Notify about restart after RGB Toggle
            If rgbtoggled = True Then
                MsgBox("The PC must be restarted to accept the RGB settings!", MsgBoxStyle.Information)
            End If

            'closing form and start timer again
            updateTimer.Start()
            Me.Close()
        Else
            'closing form and start timer again
            updateTimer.Start()
            Me.Close()
        End If
    End Sub

    Public Sub Download_ProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)

        Try
            ProgressBar1.Value = CInt(Math.Round((e.BytesReceived / e.TotalBytesToReceive) * 100, 0, MidpointRounding.AwayFromZero))
            Dim speedInBytesPerSecond As Double = e.BytesReceived / (DateTime.Now - startTime).TotalSeconds
            Dim speedInMegabytesPerSecond As Double = speedInBytesPerSecond / (1024 * 1024)
            lbl_progress.Text = ($"{ProgressBar1.Value.ToString} %")
            lbl_speed.Text = ($"({String.Format("{0:0.0} MB/s", speedInMegabytesPerSecond)})")
        Catch ex As Exception
            Debug.Print(ex.ToString)
            log("Download-Error: " + ex.ToString)
        End Try
    End Sub

    Private Sub nvSetup()
        Dim setupOptions As String = "/noeula /noreboot"

        If silent = True Then
            setupOptions = setupOptions + " /s"
        End If

        If clean = True Then
            setupOptions = setupOptions + " /clean"
        End If

        log("Setup-Options: " + setupOptions)
        log("Starting Setup...")

        Try
            Process.Start(dFolder + "setup.exe", setupOptions).WaitForExit()
        Catch ex As Exception
            log("The setup could not be started for the following reason: " + ex.Message + " The operation is canceled!")
            MsgBox("The setup could not be started for the following reason: " + ex.Message + " The operation is canceled!", MsgBoxStyle.Critical)
            setupOk = False
        End Try
    End Sub

    Private Sub CustomApp()
        Log("Custom APP Path: " + runAppPath)
        Log("Custom APP Options: " + runAppOptions)
        Log("Starting Custom App...")

        Try
            Process.Start(runAppPath, runAppOptions)
        Catch ex As Exception
            Log("The custom app could not be started for the following reason: " + ex.Message + " The operation is canceled!")
            MsgBox("The custom app could not be started for the following reason: " + ex.Message + " The operation is canceled!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub packageDelete()

        'delete optional driver packages
        If GFExperience = True Then
            DeleteDirectory("GFExperience")
            DeleteDirectory("GFExperience.NvStreamSrv")
        End If

        If telemetry = True Then
            DeleteDirectory("NvTelemetry")
        End If

        If ShieldWirelessController = True Then
            DeleteDirectory("ShieldWirelessController")
        End If

        If DisplayOptimus = True Then
            DeleteDirectory("Display.Optimus")
        End If

        If ShadowPlay = True Then
            DeleteDirectory("ShadowPlay")
        End If

        If NvContainer = True Then
            DeleteDirectory("NvContainer")
        End If

        If NvvHCI = True Then
            DeleteDirectory("NvvHCI")
        End If

        If PhysX = True Then
            DeleteDirectory("PhysX")
        End If

        If NvCamera = True Then
            DeleteDirectory("NvCamera")
        End If

        If HDAudio = True Then
            DeleteDirectory("HDAudio")
        End If

        If PPC = True Then
            DeleteDirectory("PPC")
        End If

        If DisplayNView = True Then
            DeleteDirectory("Display.NView")
        End If

        If DisplayUpdate = True Then
            DeleteDirectory("Display.Update")
        End If

        If MSVCRT = True Then
            DeleteDirectory("MSVCRT")
        End If

        If NGXCore = True Then
            DeleteDirectory("NGXCore")
        End If

        If nodejs = True Then
            DeleteDirectory("nodejs")
        End If

        If NvAbHub = True Then
            DeleteDirectory("NvAbHub")
        End If

        If NvBackend = True Then
            DeleteDirectory("NvBackend")
        End If

        If NvVAD = True Then
            DeleteDirectory("NvVAD")
        End If

        If NVWMI = True Then
            DeleteDirectory("NVWMI")
        End If

        If UpdateCore = True Then
            DeleteDirectory("Update.Core")
        End If

        If FrameViewSDK = True Then
            DeleteDirectory("FrameViewSDK")
        End If

        If NVModuleTracker = True Then
            DeleteDirectory("NvModuleTracker")
        End If

        If NVPCF = True Then
            DeleteDirectory("NVPCF")
        End If

    End Sub

    Private Sub frm_download_close(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        updateTimer.Start()
    End Sub
    Private Sub setFull(ByVal key As RegistryKey, ByVal parent As RegistryKey, ByVal name As String)
        Try
            For Each [sub] As String In key.GetSubKeyNames()
                setFull(key.OpenSubKey([sub]), key, [sub])
            Next
            Try

                If key.GetValue("SetDefaultFullRGBRangeOnHDMI") IsNot Nothing OrElse key.GetValue("MonitorCapabilityList") IsNot Nothing Then
                    key.Dispose()
                    key = parent.OpenSubKey(name, True)
                    key.SetValue("SetDefaultFullRGBRangeOnHDMI", 1, RegistryValueKind.DWord)
                    log(key.ToString())
                End If

            Catch ex As System.Security.SecurityException
                log("ERROR: Could not access values on key " + key.ToString() + " (Security Exception)")
            End Try

        Catch ex As System.Security.SecurityException
        End Try

        key.Dispose()
    End Sub

    Private Sub SetLimited(ByVal key As RegistryKey, ByVal parent As RegistryKey, ByVal name As String)
        Try

            For Each [sub] As String In key.GetSubKeyNames()
                SetLimited(key.OpenSubKey([sub]), key, [sub])
            Next

            Try

                If key.GetValue("SetDefaultFullRGBRangeOnHDMI") IsNot Nothing Then
                    key.Dispose()
                    key = parent.OpenSubKey(name, True)
                    key.SetValue("SetDefaultFullRGBRangeOnHDMI", 0, RegistryValueKind.DWord)
                    log(key.ToString())
                End If
            Catch ex As System.Security.SecurityException
                log("ERROR: Could not access values on key " & key.ToString() & " (Security Exception)")
            End Try

        Catch ex As System.Security.SecurityException
        End Try

        key.Dispose()
    End Sub

    Public Function EmptyDirectory(ByVal directoryPath As String) As DirectoryInfo
        Dim dir = Directory.CreateDirectory(directoryPath)

        For Each file In dir.EnumerateFiles()
            file.Delete()
        Next

        For Each subdirectory In dir.EnumerateDirectories()
            subdirectory.Delete(True)
        Next
        log("Directory cleaned: " + directoryPath)
        Return dir
    End Function


    Public Function DeleteDirectory(ByVal Folder As String) As Boolean
        Dim Result As Boolean
        If IO.Directory.Exists(dFolder + Folder) Then
            Directory.Delete(dFolder + Folder, True)
            log($"Manipulating Installer: Delete {Folder}")
            Result = True
        Else
            log($"Manipulating Installer: Warning! Directory {Folder} does not exist, maybe you use the DCH/Studio package or your driver version does not contain this component")
            Result = False
        End If
        Return Result
    End Function

End Class

Public Class NotificationEventArgs : Inherits EventArgs
    Public ReadOnly Property Title As String
    Public ReadOnly Property Text As String
    Public ReadOnly Property Duration As Integer
    Public Sub New(title As String, text As String, duration As Integer)
        Me.Title = title
        Me.Text = text
        Me.Duration = duration
    End Sub
End Class