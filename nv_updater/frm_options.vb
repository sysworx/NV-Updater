Imports System.IO
Imports System.Security.Policy
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles
Imports MetroSuite


Public Class frm_options : Inherits MetroSuite.MetroForm

    Private Sub Frm_options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Metro Form Control Box
        Dim area As New MetroSuite.MetroControlBoxArea(MetroSuite.MetroControlBoxArea.ControlBoxAreaType.Close, MetroSuite.Design.Style.Light, "close")
        MetroFormControl.Areas.Add(area)

        'Light/DarkMode
        If Lightmode = True Then
            Me.Icon = My.Resources.app
        Else
            Me.Icon = My.Resources.app_darkmode
        End If

        'Set Tooltips
        ToolTipHelp.AutoPopDelay = 30000

        'reload config
        Settings.Config = Settings.Read()

        'check admin mode
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        If isElevated Then
            lbl_admin.Enabled = False
            lbl_admin.Visible = False
            cb_rgb.Enabled = True
            cob_rgb.Enabled = True
        Else
            lbl_admin.Enabled = True
            cb_rgb.Enabled = False
            cob_rgb.Enabled = False
        End If

        'read settings
        Dim autorun As Boolean = Settings.Config.application.autorun
        Dim autoupdate As Boolean = Settings.Config.application.autoupdate
        Dim logmode As Boolean = Settings.Config.application.logmode
        Dim updatetimer As String = Settings.Config.application.updatetimer
        Dim run As Boolean = Settings.Config.application.run
        Dim runPath As String = Settings.Config.application.runPath
        Dim runOptions As String = Settings.Config.application.runOptions

        Dim ignore As Boolean = Settings.Config.update.ignore
        Dim version As String = Settings.Config.update.Version
        Dim silent As Boolean = Settings.Config.update.silent
        Dim clean As Boolean = Settings.Config.update.clean
        Dim telemetry As Boolean = Settings.Config.update.telemetry
        Dim rgbfix As Boolean = Settings.Config.update.rgbfix
        Dim rgbtoggle As String = Settings.Config.update.rgbtoggle
        Dim dch As Boolean = Settings.Config.update.dchdriver
        Dim hotfix As Boolean = Settings.Config.update.hotfix
        Dim studio As Boolean = Settings.Config.update.studio

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
        Dim NVPCF As Boolean = Settings.Config.update.NVPCF

        Dim FrameViewSDK As Boolean = Settings.Config.update.FrameViewSDK
        Dim NVModuleTracker As Boolean = Settings.Config.update.NVModuleTracker

        'set cb to settings 
        cb_autorun.Checked = autorun
        cb_autoupdate.Checked = autoupdate
        cb_logmode.Checked = logmode
        cb_ignore.Checked = ignore
        cb_run.Checked = run
        tb_version.Text = version
        cb_silent.Checked = silent
        cb_clean.Checked = clean
        cb_telemetry.Checked = telemetry
        cb_rgb.Checked = rgbfix
        cb_dch.Checked = dch
        cb_hotfix.Checked = hotfix
        cb_studio.Checked = studio
        cb_ShieldWirelessController.Checked = ShieldWirelessController
        cb_ShadowPlay.Checked = ShadowPlay
        cb_DisplayOptimus.Checked = DisplayOptimus
        cb_NvContainer.Checked = NvContainer
        cb_NvvHCI.Checked = NvvHCI
        cb_PhysX.Checked = PhysX
        cb_GFExperience.Checked = GFExperience

        cb_NvCamera.Checked = NvCamera
        cb_HDAudio.Checked = HDAudio
        cb_PPC.Checked = PPC
        cb_DisplayNView.Checked = DisplayNView
        cb_DisplayUpdate.Checked = DisplayUpdate
        cb_MSVCRT.Checked = MSVCRT
        cb_NGXCore.Checked = NGXCore
        cb_nodejs.Checked = nodejs
        cb_NvAbHub.Checked = NvAbHub
        cb_NvBackend.Checked = NvBackend
        cb_NvVAD.Checked = NvVAD
        cb_NVWMI.Checked = NVWMI
        cb_UpdateCore.Checked = UpdateCore
        cb_FrameViewSDK.Checked = FrameViewSDK
        cb_NVModuleTracker.Checked = NVModuleTracker
        cb_NVPCF.Checked = NVPCF

        'ignore version behavior
        If cb_ignore.Checked = False Then
            cb_ignore.Enabled = False
        Else
            cb_ignore.Enabled = True
        End If

        'run app behavior
        tb_runPath.Text = Settings.Config.application.runPath
        tb_runOptions.Text = Settings.Config.application.runOptions
        If cb_run.Checked = False Then
            tb_runPath.Enabled = False
            tb_runOptions.Enabled = False
            btn_chooseApp.Enabled = False
            btn_runTest.Enabled = False
        Else
            tb_runPath.Enabled = True
            tb_runOptions.Enabled = True
            btn_chooseApp.Enabled = True
            btn_runTest.Enabled = True
        End If

        'set combobox
        If updatetimer = "3600000" Then
            cob_intervall.SelectedIndex = 0
        End If

        If updatetimer = "7200000" Then
            cob_intervall.SelectedIndex = 1
        End If

        If updatetimer = "21600000" Then
            cob_intervall.SelectedIndex = 2
        End If

        If updatetimer = "36000000" Then
            cob_intervall.SelectedIndex = 3
        End If

        If updatetimer = "86400000" Then
            cob_intervall.SelectedIndex = 4
        End If

        If rgbtoggle = "Full" Then
            cob_rgb.SelectedIndex = 0
        End If

        If rgbtoggle = "Half" Then
            cob_rgb.SelectedIndex = 1
        End If

    End Sub

    Private Sub Btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        'auto update
        Settings.Config.application.autoupdate = cb_autoupdate.CheckState


        'autorun + regedit
        Dim applicationName As String = Application.ProductName
        Dim applicationPath As String = Application.ExecutablePath
        If cb_autorun.CheckState = 1 Then
            Settings.Config.application.autorun = cb_autorun.CheckState
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue(applicationName, """" & applicationPath & """")
            regKey.Close()
        Else
            Settings.Config.application.autorun = cb_autorun.CheckState
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.DeleteValue(applicationName, False)
            regKey.Close()
        End If

        'app run options
        Dim enteredPath As String = tb_runPath.Text
        If cb_run.CheckState = 1 Then
            If Directory.Exists(enteredPath) OrElse File.Exists(enteredPath) Then

            Else
                MessageBox.Show("The selected file path for the application that should run after the update is invalid. The file does not exist!", "NV Updater", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Settings.Config.application.run = cb_run.CheckState
        Settings.Config.application.runPath = tb_runPath.Text
        Settings.Config.application.runOptions = tb_runOptions.Text

        'logmode
        Settings.Config.application.logmode = cb_logmode.CheckState

        'run app
        Settings.Config.application.run = cb_run.CheckState

        'ignore
        If cb_ignore.CheckState = 0 Then
            Settings.Config.update.ignore = cb_ignore.CheckState
            Settings.Config.update.Version = Nothing
            tb_version.Text = Nothing
        End If

        'silent
        Settings.Config.update.silent = cb_silent.CheckState

        'clean
        Settings.Config.update.clean = cb_clean.CheckState

        'telemetry
        Settings.Config.update.telemetry = cb_telemetry.CheckState

        'rgbfix
        Settings.Config.update.rgbfix = cb_rgb.CheckState

        'dchdriver
        Settings.Config.update.dchdriver = cb_dch.CheckState

        'hotfix
        Settings.Config.update.hotfix = cb_hotfix.CheckState

        'Studio driver
        Settings.Config.update.studio = cb_studio.CheckState


        'ShieldWirelessController
        Settings.Config.update.ShieldWirelessController = cb_ShieldWirelessController.CheckState

        'DisplayOptimus
        Settings.Config.update.DisplayOptimus = cb_DisplayOptimus.CheckState

        'ShadowPlay
        Settings.Config.update.ShadowPlay = cb_ShadowPlay.CheckState

        'NvContainer
        Settings.Config.update.NvContainer = cb_NvContainer.CheckState

        'NvvHCI
        Settings.Config.update.NvvHCI = cb_NvvHCI.CheckState

        'PhysX
        Settings.Config.update.PhysX = cb_PhysX.CheckState


        'GFExperience
        Settings.Config.update.GFExperience = cb_GFExperience.CheckState

        'timer checkbox handling
        If cob_intervall.Text = "1 hour" Then
            Settings.Config.application.updatetimer = "3600000"
        End If
        If cob_intervall.Text = "2 hours" Then
            Settings.Config.application.updatetimer = "7200000"
        End If
        If cob_intervall.Text = "6 hours" Then
            Settings.Config.application.updatetimer = "21600000"
        End If
        If cob_intervall.Text = "10 hours" Then
            Settings.Config.application.updatetimer = "36000000"
        End If
        If cob_intervall.Text = "1 day" Then
            Settings.Config.application.updatetimer = "86400000"
        End If

        'rgb checkbox handling
        If cob_rgb.Text = "Full RGB Range" Then
            Settings.Config.update.rgbtoggle = "Full"
        End If
        If cob_rgb.Text = "Limited RGB Range" Then
            Settings.Config.update.rgbtoggle = "Half"
        End If

        'NvCamera
        Settings.Config.update.NvCamera = cb_NvCamera.CheckState

        'HDAudio
        Settings.Config.update.HDAudio = cb_HDAudio.CheckState

        'PPC
        Settings.Config.update.PPC = cb_PPC.CheckState

        'Display.NView
        Settings.Config.update.DisplayNView = cb_DisplayNView.CheckState

        'Display.Update
        Settings.Config.update.DisplayUpdate = cb_DisplayUpdate.CheckState


        'MSVCRT
        Settings.Config.update.MSVCRT = cb_MSVCRT.CheckState

        'NGXCore
        Settings.Config.update.NGXCore = cb_NGXCore.CheckState

        'nodejs
        Settings.Config.update.nodejs = cb_nodejs.CheckState

        'NvAbHub
        Settings.Config.update.NvAbHub = cb_NvAbHub.CheckState

        'NvBackend
        Settings.Config.update.NvBackend = cb_NvBackend.CheckState

        'NvVAD
        Settings.Config.update.NvVAD = cb_NvVAD.CheckState

        'NVWMI
        Settings.Config.update.NVWMI = cb_NVWMI.CheckState

        'NVPCF
        Settings.Config.update.NVPCF = cb_NVPCF.CheckState

        'Update.Core
        Settings.Config.update.UpdateCore = cb_UpdateCore.CheckState

        'FrameView SDK
        Settings.Config.update.FrameViewSDK = cb_FrameViewSDK.CheckState

        'NVModuleTracker
        Settings.Config.update.NVModuleTracker = cb_NVModuleTracker.CheckState

        'save settings
        Settings.Save(Settings.Config)

        Me.Close()
    End Sub

    Private Sub cb_dch_change(sender As Object, e As EventArgs) Handles cb_dch.CheckedChanged
        'DCH Package check
        If cb_dch.CheckState = 1 Then
            cb_NGXCore.Checked = False
            cb_NvCamera.Checked = False
            cb_NGXCore.Enabled = False
            cb_NvCamera.Enabled = False
            cb_studio.Checked = False
            cb_studio.Enabled = False
        Else
            cb_NGXCore.Enabled = True
            cb_NvCamera.Enabled = True
            cb_studio.Enabled = True
        End If
    End Sub

    Private Sub cb_run_change(sender As Object, e As EventArgs) Handles cb_run.CheckedChanged
        If cb_run.CheckState = 1 Then
            tb_runPath.Enabled = True
            tb_runOptions.Enabled = True
            btn_chooseApp.Enabled = True
            btn_runTest.Enabled = True
        Else
            tb_runPath.Enabled = False
            tb_runOptions.Enabled = False
            btn_chooseApp.Enabled = False
            btn_runTest.Enabled = False
        End If

    End Sub

    Private Sub cb_studio_change(sender As Object, e As EventArgs) Handles cb_studio.CheckedChanged
        If cb_studio.CheckState = 1 Then
            cb_hotfix.Checked = False
            cb_hotfix.Enabled = False
        Else
            cb_hotfix.Enabled = True
        End If
    End Sub

    Private Sub MetroControlBox1_AreaClicked(sender As Object, e As MetroControlBox.MetroControlBoxEventArgs) Handles MetroFormControl.AreaClicked
        Me.Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Me.Style = Design.Style.Dark
    End Sub

    Private Sub btn_chooseApp_Click(sender As Object, e As EventArgs) Handles btn_chooseApp.Click
        Dim runFile As New OpenFileDialog With {
            .Filter = "Applications (*.exe)|*.exe|All Files (*.*)|*.*",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If runFile.ShowDialog() = DialogResult.OK Then
            tb_runPath.Text = runFile.FileName
        Else
            Return
        End If
    End Sub
    Private Sub CustomApp()
        Try
            Process.Start(tb_runPath.Text, tb_runOptions.Text)
        Catch ex As Exception
            Log("The custom app could not be started for the following reason: " + ex.Message + " The operation is canceled!")
            MsgBox("The custom app could not be started for the following reason: " + ex.Message + " The operation is canceled!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_runTest_Click(sender As Object, e As EventArgs) Handles btn_runTest.Click
        Dim run As Boolean = Settings.Config.application.run
        If run = True Then
            Dim unused = Task.Run(AddressOf CustomApp)
        End If
    End Sub
End Class
