Imports MetroSuite
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_options
    'Inherits System.Windows.Forms.Form
    Inherits MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_options))
        Me.cb_logmode = New System.Windows.Forms.CheckBox()
        Me.cb_autorun = New System.Windows.Forms.CheckBox()
        Me.cb_autoupdate = New System.Windows.Forms.CheckBox()
        Me.cb_studio = New System.Windows.Forms.CheckBox()
        Me.cb_hotfix = New System.Windows.Forms.CheckBox()
        Me.cb_dch = New System.Windows.Forms.CheckBox()
        Me.cb_ignore = New System.Windows.Forms.CheckBox()
        Me.tb_version = New System.Windows.Forms.TextBox()
        Me.lbl_checkDriverTimer = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.cb_NVModuleTracker = New System.Windows.Forms.CheckBox()
        Me.cb_FrameViewSDK = New System.Windows.Forms.CheckBox()
        Me.cb_NVWMI = New System.Windows.Forms.CheckBox()
        Me.cb_UpdateCore = New System.Windows.Forms.CheckBox()
        Me.cb_NvVAD = New System.Windows.Forms.CheckBox()
        Me.cb_NvBackend = New System.Windows.Forms.CheckBox()
        Me.cb_NvAbHub = New System.Windows.Forms.CheckBox()
        Me.cb_nodejs = New System.Windows.Forms.CheckBox()
        Me.cb_MSVCRT = New System.Windows.Forms.CheckBox()
        Me.cb_NGXCore = New System.Windows.Forms.CheckBox()
        Me.cb_DisplayUpdate = New System.Windows.Forms.CheckBox()
        Me.cb_DisplayNView = New System.Windows.Forms.CheckBox()
        Me.cb_PPC = New System.Windows.Forms.CheckBox()
        Me.cb_HDAudio = New System.Windows.Forms.CheckBox()
        Me.cb_NvCamera = New System.Windows.Forms.CheckBox()
        Me.cb_GFExperience = New System.Windows.Forms.CheckBox()
        Me.cb_ShadowPlay = New System.Windows.Forms.CheckBox()
        Me.cb_NvvHCI = New System.Windows.Forms.CheckBox()
        Me.cb_DisplayOptimus = New System.Windows.Forms.CheckBox()
        Me.cb_ShieldWirelessController = New System.Windows.Forms.CheckBox()
        Me.cb_PhysX = New System.Windows.Forms.CheckBox()
        Me.cb_NvContainer = New System.Windows.Forms.CheckBox()
        Me.cb_telemetry = New System.Windows.Forms.CheckBox()
        Me.cb_clean = New System.Windows.Forms.CheckBox()
        Me.cb_silent = New System.Windows.Forms.CheckBox()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.cb_rgb = New System.Windows.Forms.CheckBox()
        Me.ToolTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.cb_NVPCF = New System.Windows.Forms.CheckBox()
        Me.cb_run = New System.Windows.Forms.CheckBox()
        Me.MetroTabControl1 = New MetroSuite.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroPanelCategory2 = New MetroSuite.MetroPanelCategory()
        Me.tb_runOptions = New MetroSuite.MetroTextbox()
        Me.btn_chooseApp = New MetroSuite.MetroButton()
        Me.tb_runPath = New MetroSuite.MetroTextbox()
        Me.MetroTrackbar4 = New MetroSuite.MetroTrackbar()
        Me.hea_Settings = New MetroSuite.MetroLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroPanelCategory1 = New MetroSuite.MetroPanelCategory()
        Me.MetroTrackbar2 = New MetroSuite.MetroTrackbar()
        Me.MetroTrackbar1 = New MetroSuite.MetroTrackbar()
        Me.hea_DriverOptions = New MetroSuite.MetroLabel()
        Me.hea_Setup = New MetroSuite.MetroLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MetroPanelCategory3 = New MetroSuite.MetroPanelCategory()
        Me.cob_intervall = New MetroSuite.MetroComboBox()
        Me.MetroTrackbar3 = New MetroSuite.MetroTrackbar()
        Me.hea_Schedule = New MetroSuite.MetroLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MetroPanelCategory4 = New MetroSuite.MetroPanelCategory()
        Me.cob_rgb = New MetroSuite.MetroComboBox()
        Me.MetroTrackbar5 = New MetroSuite.MetroTrackbar()
        Me.heaFixes = New MetroSuite.MetroLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MetroFormControl = New MetroSuite.MetroControlBox()
        Me.btn_runTest = New MetroSuite.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MetroPanelCategory2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MetroPanelCategory1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MetroPanelCategory3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MetroPanelCategory4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_logmode
        '
        Me.cb_logmode.AutoSize = True
        Me.cb_logmode.Location = New System.Drawing.Point(15, 112)
        Me.cb_logmode.Name = "cb_logmode"
        Me.cb_logmode.Size = New System.Drawing.Size(112, 19)
        Me.cb_logmode.TabIndex = 2
        Me.cb_logmode.Text = "Enable Log-Files"
        Me.ToolTipHelp.SetToolTip(Me.cb_logmode, "NV Updater creates log files, this may be required to identify errors." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.cb_logmode.UseVisualStyleBackColor = True
        '
        'cb_autorun
        '
        Me.cb_autorun.AutoSize = True
        Me.cb_autorun.Location = New System.Drawing.Point(15, 87)
        Me.cb_autorun.Name = "cb_autorun"
        Me.cb_autorun.Size = New System.Drawing.Size(239, 19)
        Me.cb_autorun.TabIndex = 1
        Me.cb_autorun.Text = "Autorun NV Updater at Windows startup"
        Me.ToolTipHelp.SetToolTip(Me.cb_autorun, "Starts NV Updater with Windows.")
        Me.cb_autorun.UseVisualStyleBackColor = True
        '
        'cb_autoupdate
        '
        Me.cb_autoupdate.AutoSize = True
        Me.cb_autoupdate.Location = New System.Drawing.Point(15, 62)
        Me.cb_autoupdate.Name = "cb_autoupdate"
        Me.cb_autoupdate.Size = New System.Drawing.Size(298, 19)
        Me.cb_autoupdate.TabIndex = 0
        Me.cb_autoupdate.Text = "Check for own application updates at program start"
        Me.ToolTipHelp.SetToolTip(Me.cb_autoupdate, "NV Updater checks for own program updates at startup.")
        Me.cb_autoupdate.UseVisualStyleBackColor = True
        '
        'cb_studio
        '
        Me.cb_studio.AutoSize = True
        Me.cb_studio.Location = New System.Drawing.Point(15, 87)
        Me.cb_studio.Name = "cb_studio"
        Me.cb_studio.Size = New System.Drawing.Size(116, 19)
        Me.cb_studio.TabIndex = 9
        Me.cb_studio.Text = "Use Studio Driver"
        Me.ToolTipHelp.SetToolTip(Me.cb_studio, "Installs the studio drivers instead of the normal GameReady drivers.")
        Me.cb_studio.UseVisualStyleBackColor = True
        '
        'cb_hotfix
        '
        Me.cb_hotfix.AutoSize = True
        Me.cb_hotfix.Location = New System.Drawing.Point(15, 112)
        Me.cb_hotfix.Name = "cb_hotfix"
        Me.cb_hotfix.Size = New System.Drawing.Size(237, 19)
        Me.cb_hotfix.TabIndex = 8
        Me.cb_hotfix.Text = "Check for Hotfix releases (experimental)"
        Me.ToolTipHelp.SetToolTip(Me.cb_hotfix, "Check for hotfix GameReady drivers, this can't be used with studio drivers")
        Me.cb_hotfix.UseVisualStyleBackColor = True
        '
        'cb_dch
        '
        Me.cb_dch.AutoSize = True
        Me.cb_dch.Location = New System.Drawing.Point(15, 62)
        Me.cb_dch.Name = "cb_dch"
        Me.cb_dch.Size = New System.Drawing.Size(542, 19)
        Me.cb_dch.TabIndex = 7
        Me.cb_dch.Text = "Use DCH Driver (Recommended from version 496.13 there is no standard driver packa" &
    "ge anymore)"
        Me.ToolTipHelp.SetToolTip(Me.cb_dch, "Installs the DCH drivers instead of the normal NVIDIA drivers, these are pre-inst" &
        "alled by some manufacturers.")
        Me.cb_dch.UseVisualStyleBackColor = True
        '
        'cb_ignore
        '
        Me.cb_ignore.AutoSize = True
        Me.cb_ignore.Location = New System.Drawing.Point(16, 87)
        Me.cb_ignore.Name = "cb_ignore"
        Me.cb_ignore.Size = New System.Drawing.Size(101, 19)
        Me.cb_ignore.TabIndex = 6
        Me.cb_ignore.Text = "Ignore Version"
        Me.ToolTipHelp.SetToolTip(Me.cb_ignore, "Ignores a specific version.")
        Me.cb_ignore.UseVisualStyleBackColor = True
        '
        'tb_version
        '
        Me.tb_version.BackColor = System.Drawing.Color.White
        Me.tb_version.Enabled = False
        Me.tb_version.Location = New System.Drawing.Point(188, 85)
        Me.tb_version.Name = "tb_version"
        Me.tb_version.ReadOnly = True
        Me.tb_version.Size = New System.Drawing.Size(131, 23)
        Me.tb_version.TabIndex = 5
        '
        'lbl_checkDriverTimer
        '
        Me.lbl_checkDriverTimer.AutoSize = True
        Me.lbl_checkDriverTimer.Location = New System.Drawing.Point(13, 59)
        Me.lbl_checkDriverTimer.Name = "lbl_checkDriverTimer"
        Me.lbl_checkDriverTimer.Size = New System.Drawing.Size(162, 15)
        Me.lbl_checkDriverTimer.TabIndex = 3
        Me.lbl_checkDriverTimer.Text = "Check for driver update every"
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.White
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_ok.Location = New System.Drawing.Point(392, 481)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_ok.Size = New System.Drawing.Size(122, 27)
        Me.btn_ok.TabIndex = 4
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'cb_NVModuleTracker
        '
        Me.cb_NVModuleTracker.AutoSize = True
        Me.cb_NVModuleTracker.Location = New System.Drawing.Point(15, 349)
        Me.cb_NVModuleTracker.Name = "cb_NVModuleTracker"
        Me.cb_NVModuleTracker.Size = New System.Drawing.Size(242, 19)
        Me.cb_NVModuleTracker.TabIndex = 31
        Me.cb_NVModuleTracker.Text = "Remove Process and module monitoring"
        Me.ToolTipHelp.SetToolTip(Me.cb_NVModuleTracker, "NvModuleTracker is a service that monitors components of the driver (further info" &
        "rmation is not known)")
        Me.cb_NVModuleTracker.UseVisualStyleBackColor = True
        '
        'cb_FrameViewSDK
        '
        Me.cb_FrameViewSDK.AutoSize = True
        Me.cb_FrameViewSDK.Location = New System.Drawing.Point(538, 322)
        Me.cb_FrameViewSDK.Name = "cb_FrameViewSDK"
        Me.cb_FrameViewSDK.Size = New System.Drawing.Size(154, 19)
        Me.cb_FrameViewSDK.TabIndex = 30
        Me.cb_FrameViewSDK.Text = "Remove FrameView SDK"
        Me.ToolTipHelp.SetToolTip(Me.cb_FrameViewSDK, resources.GetString("cb_FrameViewSDK.ToolTip"))
        Me.cb_FrameViewSDK.UseVisualStyleBackColor = True
        '
        'cb_NVWMI
        '
        Me.cb_NVWMI.AutoSize = True
        Me.cb_NVWMI.Location = New System.Drawing.Point(302, -63)
        Me.cb_NVWMI.Name = "cb_NVWMI"
        Me.cb_NVWMI.Size = New System.Drawing.Size(113, 19)
        Me.cb_NVWMI.TabIndex = 29
        Me.cb_NVWMI.Text = "Remove NVWMI"
        Me.ToolTipHelp.SetToolTip(Me.cb_NVWMI, resources.GetString("cb_NVWMI.ToolTip"))
        Me.cb_NVWMI.UseVisualStyleBackColor = True
        '
        'cb_UpdateCore
        '
        Me.cb_UpdateCore.AutoSize = True
        Me.cb_UpdateCore.Location = New System.Drawing.Point(325, 323)
        Me.cb_UpdateCore.Name = "cb_UpdateCore"
        Me.cb_UpdateCore.Size = New System.Drawing.Size(138, 19)
        Me.cb_UpdateCore.TabIndex = 28
        Me.cb_UpdateCore.Text = "Remove Update.Core"
        Me.ToolTipHelp.SetToolTip(Me.cb_UpdateCore, "Removes the NVIDIA Update.Core component from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a up" &
        "dater component which tries do display a notification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when a new driver is avai" &
        "lable (similar to GF Experience)")
        Me.cb_UpdateCore.UseVisualStyleBackColor = True
        '
        'cb_NvVAD
        '
        Me.cb_NvVAD.AutoSize = True
        Me.cb_NvVAD.Location = New System.Drawing.Point(538, 295)
        Me.cb_NvVAD.Name = "cb_NvVAD"
        Me.cb_NvVAD.Size = New System.Drawing.Size(109, 19)
        Me.cb_NvVAD.TabIndex = 26
        Me.cb_NvVAD.Text = "Remove NvVAD"
        Me.ToolTipHelp.SetToolTip(Me.cb_NvVAD, "Removes the NVIDIA Virtual Audio Driver from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NVIDIA Virtua" &
        "l Audio Driver is used to push audio to NVIDIA Shield products")
        Me.cb_NvVAD.UseVisualStyleBackColor = True
        '
        'cb_NvBackend
        '
        Me.cb_NvBackend.AutoSize = True
        Me.cb_NvBackend.Location = New System.Drawing.Point(538, 268)
        Me.cb_NvBackend.Name = "cb_NvBackend"
        Me.cb_NvBackend.Size = New System.Drawing.Size(132, 19)
        Me.cb_NvBackend.TabIndex = 25
        Me.cb_NvBackend.Text = "Remove NvBackend"
        Me.ToolTipHelp.SetToolTip(Me.cb_NvBackend, "Removes the NVIDIA GeForce Experience Backend from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NVIDIA " &
        "GeForce Experience Backend is a part of the GeForce Experience Software")
        Me.cb_NvBackend.UseVisualStyleBackColor = True
        '
        'cb_NvAbHub
        '
        Me.cb_NvAbHub.AutoSize = True
        Me.cb_NvAbHub.Location = New System.Drawing.Point(538, 243)
        Me.cb_NvAbHub.Name = "cb_NvAbHub"
        Me.cb_NvAbHub.Size = New System.Drawing.Size(125, 19)
        Me.cb_NvAbHub.TabIndex = 24
        Me.cb_NvAbHub.Text = "Remove NvAbHub"
        Me.ToolTipHelp.SetToolTip(Me.cb_NvAbHub, "Removes the NVIDIA NvAbHub from the driver package.")
        Me.cb_NvAbHub.UseVisualStyleBackColor = True
        '
        'cb_nodejs
        '
        Me.cb_nodejs.AutoSize = True
        Me.cb_nodejs.Location = New System.Drawing.Point(538, 215)
        Me.cb_nodejs.Name = "cb_nodejs"
        Me.cb_nodejs.Size = New System.Drawing.Size(107, 19)
        Me.cb_nodejs.TabIndex = 23
        Me.cb_nodejs.Text = "Remove nodejs"
        Me.ToolTipHelp.SetToolTip(Me.cb_nodejs, "Removes the Node.js component from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Node.js is a JavaScript" &
        " runtime built on Chrome's V8 JavaScript engine")
        Me.cb_nodejs.UseVisualStyleBackColor = True
        '
        'cb_MSVCRT
        '
        Me.cb_MSVCRT.AutoSize = True
        Me.cb_MSVCRT.Location = New System.Drawing.Point(325, 348)
        Me.cb_MSVCRT.Name = "cb_MSVCRT"
        Me.cb_MSVCRT.Size = New System.Drawing.Size(140, 19)
        Me.cb_MSVCRT.TabIndex = 22
        Me.cb_MSVCRT.Text = "Remove MSVCRT Libs"
        Me.ToolTipHelp.SetToolTip(Me.cb_MSVCRT, "Removes the Microsoft Visual C++ Runtime from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.cb_MSVCRT.UseVisualStyleBackColor = True
        '
        'cb_NGXCore
        '
        Me.cb_NGXCore.AutoSize = True
        Me.cb_NGXCore.Location = New System.Drawing.Point(538, 190)
        Me.cb_NGXCore.Name = "cb_NGXCore"
        Me.cb_NGXCore.Size = New System.Drawing.Size(121, 19)
        Me.cb_NGXCore.TabIndex = 21
        Me.cb_NGXCore.Text = "Remove NGXCore"
        Me.ToolTipHelp.SetToolTip(Me.cb_NGXCore, resources.GetString("cb_NGXCore.ToolTip"))
        Me.cb_NGXCore.UseVisualStyleBackColor = True
        '
        'cb_DisplayUpdate
        '
        Me.cb_DisplayUpdate.AutoSize = True
        Me.cb_DisplayUpdate.Location = New System.Drawing.Point(515, -63)
        Me.cb_DisplayUpdate.Name = "cb_DisplayUpdate"
        Me.cb_DisplayUpdate.Size = New System.Drawing.Size(151, 19)
        Me.cb_DisplayUpdate.TabIndex = 20
        Me.cb_DisplayUpdate.Text = "Remove Display.Update"
        Me.ToolTipHelp.SetToolTip(Me.cb_DisplayUpdate, "Removes the NVIDIA Display.Update component from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is a" &
        " updater component which tries do display a notification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when a new driver is a" &
        "vailable (similar to GF Experience)")
        Me.cb_DisplayUpdate.UseVisualStyleBackColor = True
        '
        'cb_DisplayNView
        '
        Me.cb_DisplayNView.AutoSize = True
        Me.cb_DisplayNView.Location = New System.Drawing.Point(325, 296)
        Me.cb_DisplayNView.Name = "cb_DisplayNView"
        Me.cb_DisplayNView.Size = New System.Drawing.Size(147, 19)
        Me.cb_DisplayNView.TabIndex = 19
        Me.cb_DisplayNView.Text = "Remove Display.NView"
        Me.ToolTipHelp.SetToolTip(Me.cb_DisplayNView, "Removes the NVIDIA NView from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NView is a virtual desktop m" &
        "anager tool")
        Me.cb_DisplayNView.UseVisualStyleBackColor = True
        '
        'cb_PPC
        '
        Me.cb_PPC.AutoSize = True
        Me.cb_PPC.Location = New System.Drawing.Point(325, 270)
        Me.cb_PPC.Name = "cb_PPC"
        Me.cb_PPC.Size = New System.Drawing.Size(166, 19)
        Me.cb_PPC.TabIndex = 18
        Me.cb_PPC.Text = "Remove USB Type-C driver"
        Me.ToolTipHelp.SetToolTip(Me.cb_PPC, "Removes the NVIDIA USB Type-C driver from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The NVIDIA USB T" &
        "ype-C Port Policy Controller Driver is used for display " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the picture via USB-C " &
        "port")
        Me.cb_PPC.UseVisualStyleBackColor = True
        '
        'cb_HDAudio
        '
        Me.cb_HDAudio.AutoSize = True
        Me.cb_HDAudio.Location = New System.Drawing.Point(325, 243)
        Me.cb_HDAudio.Name = "cb_HDAudio"
        Me.cb_HDAudio.Size = New System.Drawing.Size(121, 19)
        Me.cb_HDAudio.TabIndex = 17
        Me.cb_HDAudio.Text = "Remove HDAudio"
        Me.ToolTipHelp.SetToolTip(Me.cb_HDAudio, "Removes the NVIDIA HDAudio from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HD Audio driver allows vid" &
        "eo card to pass sound through HDMI cable")
        Me.cb_HDAudio.UseVisualStyleBackColor = True
        '
        'cb_NvCamera
        '
        Me.cb_NvCamera.AutoSize = True
        Me.cb_NvCamera.Location = New System.Drawing.Point(325, 217)
        Me.cb_NvCamera.Name = "cb_NvCamera"
        Me.cb_NvCamera.Size = New System.Drawing.Size(101, 19)
        Me.cb_NvCamera.TabIndex = 16
        Me.cb_NvCamera.Text = "Remove Ansel"
        Me.ToolTipHelp.SetToolTip(Me.cb_NvCamera, resources.GetString("cb_NvCamera.ToolTip"))
        Me.cb_NvCamera.UseVisualStyleBackColor = True
        '
        'cb_GFExperience
        '
        Me.cb_GFExperience.AutoSize = True
        Me.cb_GFExperience.Location = New System.Drawing.Point(15, 190)
        Me.cb_GFExperience.Name = "cb_GFExperience"
        Me.cb_GFExperience.Size = New System.Drawing.Size(252, 19)
        Me.cb_GFExperience.TabIndex = 15
        Me.cb_GFExperience.Text = "Remove Geforce Experience (Recommend)"
        Me.ToolTipHelp.SetToolTip(Me.cb_GFExperience, resources.GetString("cb_GFExperience.ToolTip"))
        Me.cb_GFExperience.UseVisualStyleBackColor = True
        '
        'cb_ShadowPlay
        '
        Me.cb_ShadowPlay.AutoSize = True
        Me.cb_ShadowPlay.Location = New System.Drawing.Point(15, 270)
        Me.cb_ShadowPlay.Name = "cb_ShadowPlay"
        Me.cb_ShadowPlay.Size = New System.Drawing.Size(136, 19)
        Me.cb_ShadowPlay.TabIndex = 14
        Me.cb_ShadowPlay.Text = "Remove ShadowPlay"
        Me.ToolTipHelp.SetToolTip(Me.cb_ShadowPlay, resources.GetString("cb_ShadowPlay.ToolTip"))
        Me.cb_ShadowPlay.UseVisualStyleBackColor = True
        '
        'cb_NvvHCI
        '
        Me.cb_NvvHCI.AutoSize = True
        Me.cb_NvvHCI.Location = New System.Drawing.Point(538, 349)
        Me.cb_NvvHCI.Name = "cb_NvvHCI"
        Me.cb_NvvHCI.Size = New System.Drawing.Size(113, 19)
        Me.cb_NvvHCI.TabIndex = 13
        Me.cb_NvvHCI.Text = "Remove NvvHCI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTipHelp.SetToolTip(Me.cb_NvvHCI, "Removes the NVIDIA Virtual Host Controller Interface Driver from the driver packa" &
        "ge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It's a Virtual USB Host Controller driver for interaction with the usb po" &
        "rts on a shield device.")
        Me.cb_NvvHCI.UseVisualStyleBackColor = True
        '
        'cb_DisplayOptimus
        '
        Me.cb_DisplayOptimus.AutoSize = True
        Me.cb_DisplayOptimus.Location = New System.Drawing.Point(15, 242)
        Me.cb_DisplayOptimus.Name = "cb_DisplayOptimus"
        Me.cb_DisplayOptimus.Size = New System.Drawing.Size(192, 19)
        Me.cb_DisplayOptimus.TabIndex = 12
        Me.cb_DisplayOptimus.Text = "Remove Display Optimus driver"
        Me.ToolTipHelp.SetToolTip(Me.cb_DisplayOptimus, resources.GetString("cb_DisplayOptimus.ToolTip"))
        Me.cb_DisplayOptimus.UseVisualStyleBackColor = True
        '
        'cb_ShieldWirelessController
        '
        Me.cb_ShieldWirelessController.AutoSize = True
        Me.cb_ShieldWirelessController.Location = New System.Drawing.Point(15, 296)
        Me.cb_ShieldWirelessController.Name = "cb_ShieldWirelessController"
        Me.cb_ShieldWirelessController.Size = New System.Drawing.Size(236, 19)
        Me.cb_ShieldWirelessController.TabIndex = 11
        Me.cb_ShieldWirelessController.Text = "Remove ShieldWireless Controller driver"
        Me.ToolTipHelp.SetToolTip(Me.cb_ShieldWirelessController, "Removes the NVIDIA ShieldWireless Controller from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contains" &
        " the driver package that is needed for the NVIDIA Wireless Shield Controller.")
        Me.cb_ShieldWirelessController.UseVisualStyleBackColor = True
        '
        'cb_PhysX
        '
        Me.cb_PhysX.AutoSize = True
        Me.cb_PhysX.Location = New System.Drawing.Point(325, 190)
        Me.cb_PhysX.Name = "cb_PhysX"
        Me.cb_PhysX.Size = New System.Drawing.Size(141, 19)
        Me.cb_PhysX.TabIndex = 10
        Me.cb_PhysX.Text = "Remove Nvidia PhysX"
        Me.ToolTipHelp.SetToolTip(Me.cb_PhysX, "Removes the NVIDIA PhysiX from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PhysX is an open-source rea" &
        "ltime physics engine middleware SDK developed " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by Nvidia as a part of Nvidia Ga" &
        "meWorks software suite.")
        Me.cb_PhysX.UseVisualStyleBackColor = True
        '
        'cb_NvContainer
        '
        Me.cb_NvContainer.AutoSize = True
        Me.cb_NvContainer.Location = New System.Drawing.Point(15, 323)
        Me.cb_NvContainer.Name = "cb_NvContainer"
        Me.cb_NvContainer.Size = New System.Drawing.Size(142, 19)
        Me.cb_NvContainer.TabIndex = 9
        Me.cb_NvContainer.Text = "Remove NvContainer "
        Me.ToolTipHelp.SetToolTip(Me.cb_NvContainer, resources.GetString("cb_NvContainer.ToolTip"))
        Me.cb_NvContainer.UseVisualStyleBackColor = True
        '
        'cb_telemetry
        '
        Me.cb_telemetry.AutoSize = True
        Me.cb_telemetry.Location = New System.Drawing.Point(15, 217)
        Me.cb_telemetry.Name = "cb_telemetry"
        Me.cb_telemetry.Size = New System.Drawing.Size(160, 19)
        Me.cb_telemetry.TabIndex = 8
        Me.cb_telemetry.Text = "Remove Nvidia Telemetry"
        Me.ToolTipHelp.SetToolTip(Me.cb_telemetry, resources.GetString("cb_telemetry.ToolTip"))
        Me.cb_telemetry.UseVisualStyleBackColor = True
        '
        'cb_clean
        '
        Me.cb_clean.AutoSize = True
        Me.cb_clean.Location = New System.Drawing.Point(110, 136)
        Me.cb_clean.Name = "cb_clean"
        Me.cb_clean.Size = New System.Drawing.Size(90, 19)
        Me.cb_clean.TabIndex = 7
        Me.cb_clean.Text = "Clean install"
        Me.ToolTipHelp.SetToolTip(Me.cb_clean, "Performs a clean driver installation, all settings are lost.")
        Me.cb_clean.UseVisualStyleBackColor = True
        '
        'cb_silent
        '
        Me.cb_silent.AutoSize = True
        Me.cb_silent.Location = New System.Drawing.Point(15, 137)
        Me.cb_silent.Name = "cb_silent"
        Me.cb_silent.Size = New System.Drawing.Size(89, 19)
        Me.cb_silent.TabIndex = 6
        Me.cb_silent.Text = "Silent install"
        Me.ToolTipHelp.SetToolTip(Me.cb_silent, "Executes the driver installation in the background, no setup window or progress i" &
        "s displayed. No user interaction required.")
        Me.cb_silent.UseVisualStyleBackColor = True
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_admin.ForeColor = System.Drawing.Color.Red
        Me.lbl_admin.Location = New System.Drawing.Point(578, 398)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(161, 13)
        Me.lbl_admin.TabIndex = 8
        Me.lbl_admin.Text = "Works only in Admin Mode!"
        '
        'cb_rgb
        '
        Me.cb_rgb.AutoSize = True
        Me.cb_rgb.Location = New System.Drawing.Point(15, 62)
        Me.cb_rgb.Name = "cb_rgb"
        Me.cb_rgb.Size = New System.Drawing.Size(145, 19)
        Me.cb_rgb.TabIndex = 6
        Me.cb_rgb.Text = "RGB Full/limited range"
        Me.ToolTipHelp.SetToolTip(Me.cb_rgb, "Nvidia RGB Full/limited range Toggle (only needed if you have problems with your " &
        "RGB settings after driver installation.")
        Me.cb_rgb.UseVisualStyleBackColor = True
        '
        'cb_NVPCF
        '
        Me.cb_NVPCF.AutoSize = True
        Me.cb_NVPCF.Location = New System.Drawing.Point(15, 374)
        Me.cb_NVPCF.Name = "cb_NVPCF"
        Me.cb_NVPCF.Size = New System.Drawing.Size(246, 19)
        Me.cb_NVPCF.TabIndex = 36
        Me.cb_NVPCF.Text = "Remove Platform Controllers/ Framework"
        Me.ToolTipHelp.SetToolTip(Me.cb_NVPCF, "Removes the NVIDIA Plattform Controllers and Framework from the driver package." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It's a driver for some laptops like Acer and mostly not needed")
        Me.cb_NVPCF.UseVisualStyleBackColor = True
        '
        'cb_run
        '
        Me.cb_run.AutoSize = True
        Me.cb_run.Location = New System.Drawing.Point(15, 137)
        Me.cb_run.Name = "cb_run"
        Me.cb_run.Size = New System.Drawing.Size(192, 19)
        Me.cb_run.TabIndex = 36
        Me.cb_run.Text = "Start a custom app after update"
        Me.ToolTipHelp.SetToolTip(Me.cb_run, "NV Updater creates log files, this may be required to identify errors." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.cb_run.UseVisualStyleBackColor = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.AnimationSpeed = 1
        Me.MetroTabControl1.Appearance = System.Windows.Forms.Appearance.Normal
        Me.MetroTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTabControl1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Controls.Add(Me.TabPage3)
        Me.MetroTabControl1.Controls.Add(Me.TabPage4)
        Me.MetroTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroTabControl1.ForeColor = System.Drawing.Color.Black
        Me.MetroTabControl1.HasAnimation = False
        Me.MetroTabControl1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.MetroTabControl1.HeaderItemColor = System.Drawing.Color.White
        Me.MetroTabControl1.HotTrack = True
        Me.MetroTabControl1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.HoverColor = System.Drawing.Color.White
        Me.MetroTabControl1.ImageList = Me.ImageList1
        Me.MetroTabControl1.ImageWidth = 32
        Me.MetroTabControl1.ItemColor = System.Drawing.Color.White
        Me.MetroTabControl1.ItemForeColor = System.Drawing.Color.Black
        Me.MetroTabControl1.ItemSize = New System.Drawing.Size(45, 120)
        Me.MetroTabControl1.Location = New System.Drawing.Point(14, 39)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.SelectedForeColor = System.Drawing.Color.White
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.SelectedItemColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.SelectedItemLineColor = System.Drawing.Color.Black
        Me.MetroTabControl1.Size = New System.Drawing.Size(882, 436)
        Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroTabControl1.TabContainerColor = System.Drawing.Color.White
        Me.MetroTabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MetroPanelCategory2)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(754, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        '
        'MetroPanelCategory2
        '
        Me.MetroPanelCategory2.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroPanelCategory2.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanelCategory2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanelCategory2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroPanelCategory2.Controls.Add(Me.btn_runTest)
        Me.MetroPanelCategory2.Controls.Add(Me.tb_runOptions)
        Me.MetroPanelCategory2.Controls.Add(Me.btn_chooseApp)
        Me.MetroPanelCategory2.Controls.Add(Me.tb_runPath)
        Me.MetroPanelCategory2.Controls.Add(Me.cb_run)
        Me.MetroPanelCategory2.Controls.Add(Me.MetroTrackbar4)
        Me.MetroPanelCategory2.Controls.Add(Me.hea_Settings)
        Me.MetroPanelCategory2.Controls.Add(Me.cb_autoupdate)
        Me.MetroPanelCategory2.Controls.Add(Me.cb_autorun)
        Me.MetroPanelCategory2.Controls.Add(Me.cb_logmode)
        Me.MetroPanelCategory2.DefaultColor = System.Drawing.Color.White
        Me.MetroPanelCategory2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroPanelCategory2.ForeColor = System.Drawing.Color.Black
        Me.MetroPanelCategory2.GradientColor = System.Drawing.Color.White
        Me.MetroPanelCategory2.GradientPointA = New System.Drawing.Point(0, 0)
        Me.MetroPanelCategory2.GradientPointB = New System.Drawing.Point(742, 416)
        Me.MetroPanelCategory2.LineGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroPanelCategory2.Location = New System.Drawing.Point(6, 6)
        Me.MetroPanelCategory2.Name = "MetroPanelCategory2"
        Me.MetroPanelCategory2.Size = New System.Drawing.Size(742, 416)
        Me.MetroPanelCategory2.TabIndex = 3
        '
        'tb_runOptions
        '
        Me.tb_runOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_runOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tb_runOptions.DefaultColor = System.Drawing.Color.White
        Me.tb_runOptions.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tb_runOptions.ForeColor = System.Drawing.Color.Black
        Me.tb_runOptions.HideSelection = False
        Me.tb_runOptions.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tb_runOptions.Location = New System.Drawing.Point(30, 191)
        Me.tb_runOptions.Name = "tb_runOptions"
        Me.tb_runOptions.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_runOptions.Size = New System.Drawing.Size(615, 23)
        Me.tb_runOptions.TabIndex = 39
        Me.tb_runOptions.Watermark = "Start arguments"
        '
        'btn_chooseApp
        '
        Me.btn_chooseApp.BackColor = System.Drawing.Color.Transparent
        Me.btn_chooseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_chooseApp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_chooseApp.DefaultColor = System.Drawing.Color.White
        Me.btn_chooseApp.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_chooseApp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_chooseApp.ForeColor = System.Drawing.Color.Black
        Me.btn_chooseApp.HoverColor = System.Drawing.Color.White
        Me.btn_chooseApp.Location = New System.Drawing.Point(651, 162)
        Me.btn_chooseApp.Name = "btn_chooseApp"
        Me.btn_chooseApp.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_chooseApp.RoundingArc = 23
        Me.btn_chooseApp.Size = New System.Drawing.Size(75, 23)
        Me.btn_chooseApp.TabIndex = 38
        Me.btn_chooseApp.Text = "Choose"
        '
        'tb_runPath
        '
        Me.tb_runPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tb_runPath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tb_runPath.DefaultColor = System.Drawing.Color.White
        Me.tb_runPath.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tb_runPath.ForeColor = System.Drawing.Color.Black
        Me.tb_runPath.HideSelection = False
        Me.tb_runPath.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tb_runPath.Location = New System.Drawing.Point(30, 162)
        Me.tb_runPath.Name = "tb_runPath"
        Me.tb_runPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_runPath.Size = New System.Drawing.Size(615, 23)
        Me.tb_runPath.TabIndex = 37
        Me.tb_runPath.Watermark = "Path to executable"
        '
        'MetroTrackbar4
        '
        Me.MetroTrackbar4.BackColor = System.Drawing.Color.Transparent
        Me.MetroTrackbar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTrackbar4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroTrackbar4.Enabled = False
        Me.MetroTrackbar4.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroTrackbar4.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar4.LeftColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTrackbar4.Location = New System.Drawing.Point(16, 33)
        Me.MetroTrackbar4.Name = "MetroTrackbar4"
        Me.MetroTrackbar4.RailWidth = 1
        Me.MetroTrackbar4.RegionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar4.RightColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MetroTrackbar4.Size = New System.Drawing.Size(723, 23)
        Me.MetroTrackbar4.SliderColor = System.Drawing.Color.White
        Me.MetroTrackbar4.SliderWidth = 5
        Me.MetroTrackbar4.TabIndex = 35
        Me.MetroTrackbar4.Value = 100
        '
        'hea_Settings
        '
        Me.hea_Settings.AutoSize = True
        Me.hea_Settings.BackColor = System.Drawing.Color.Transparent
        Me.hea_Settings.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hea_Settings.ForeColor = System.Drawing.Color.SteelBlue
        Me.hea_Settings.Location = New System.Drawing.Point(646, 0)
        Me.hea_Settings.Name = "hea_Settings"
        Me.hea_Settings.Size = New System.Drawing.Size(93, 30)
        Me.hea_Settings.TabIndex = 33
        Me.hea_Settings.Text = "Settings"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.MetroPanelCategory1)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(754, 428)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Driver Options"
        '
        'MetroPanelCategory1
        '
        Me.MetroPanelCategory1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroPanelCategory1.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanelCategory1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanelCategory1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NVPCF)
        Me.MetroPanelCategory1.Controls.Add(Me.MetroTrackbar2)
        Me.MetroPanelCategory1.Controls.Add(Me.MetroTrackbar1)
        Me.MetroPanelCategory1.Controls.Add(Me.hea_DriverOptions)
        Me.MetroPanelCategory1.Controls.Add(Me.hea_Setup)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NVModuleTracker)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_studio)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_hotfix)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_nodejs)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_dch)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_FrameViewSDK)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_silent)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NVWMI)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_clean)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_UpdateCore)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_telemetry)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NvVAD)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NvContainer)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NvBackend)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_PhysX)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NvAbHub)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_ShieldWirelessController)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_DisplayOptimus)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_MSVCRT)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NvvHCI)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NGXCore)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_ShadowPlay)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_DisplayUpdate)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_GFExperience)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_DisplayNView)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_NvCamera)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_PPC)
        Me.MetroPanelCategory1.Controls.Add(Me.cb_HDAudio)
        Me.MetroPanelCategory1.DefaultColor = System.Drawing.Color.White
        Me.MetroPanelCategory1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroPanelCategory1.ForeColor = System.Drawing.Color.Black
        Me.MetroPanelCategory1.GradientColor = System.Drawing.Color.White
        Me.MetroPanelCategory1.GradientPointA = New System.Drawing.Point(0, 0)
        Me.MetroPanelCategory1.GradientPointB = New System.Drawing.Point(742, 416)
        Me.MetroPanelCategory1.LineGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroPanelCategory1.Location = New System.Drawing.Point(6, 6)
        Me.MetroPanelCategory1.Name = "MetroPanelCategory1"
        Me.MetroPanelCategory1.Size = New System.Drawing.Size(742, 416)
        Me.MetroPanelCategory1.TabIndex = 10
        '
        'MetroTrackbar2
        '
        Me.MetroTrackbar2.BackColor = System.Drawing.Color.Transparent
        Me.MetroTrackbar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTrackbar2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroTrackbar2.Enabled = False
        Me.MetroTrackbar2.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroTrackbar2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar2.LeftColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTrackbar2.Location = New System.Drawing.Point(15, 161)
        Me.MetroTrackbar2.Name = "MetroTrackbar2"
        Me.MetroTrackbar2.RailWidth = 1
        Me.MetroTrackbar2.RegionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar2.RightColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MetroTrackbar2.Size = New System.Drawing.Size(723, 23)
        Me.MetroTrackbar2.SliderColor = System.Drawing.Color.White
        Me.MetroTrackbar2.SliderWidth = 5
        Me.MetroTrackbar2.TabIndex = 35
        Me.MetroTrackbar2.Value = 100
        '
        'MetroTrackbar1
        '
        Me.MetroTrackbar1.BackColor = System.Drawing.Color.Transparent
        Me.MetroTrackbar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTrackbar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroTrackbar1.Enabled = False
        Me.MetroTrackbar1.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroTrackbar1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar1.LeftColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTrackbar1.Location = New System.Drawing.Point(16, 33)
        Me.MetroTrackbar1.Name = "MetroTrackbar1"
        Me.MetroTrackbar1.RailWidth = 1
        Me.MetroTrackbar1.RegionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar1.RightColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MetroTrackbar1.Size = New System.Drawing.Size(723, 23)
        Me.MetroTrackbar1.SliderColor = System.Drawing.Color.White
        Me.MetroTrackbar1.SliderWidth = 5
        Me.MetroTrackbar1.TabIndex = 34
        Me.MetroTrackbar1.Value = 100
        '
        'hea_DriverOptions
        '
        Me.hea_DriverOptions.AutoSize = True
        Me.hea_DriverOptions.BackColor = System.Drawing.Color.Transparent
        Me.hea_DriverOptions.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hea_DriverOptions.ForeColor = System.Drawing.Color.SteelBlue
        Me.hea_DriverOptions.Location = New System.Drawing.Point(583, 0)
        Me.hea_DriverOptions.Name = "hea_DriverOptions"
        Me.hea_DriverOptions.Size = New System.Drawing.Size(156, 30)
        Me.hea_DriverOptions.TabIndex = 33
        Me.hea_DriverOptions.Text = "Driver Options"
        '
        'hea_Setup
        '
        Me.hea_Setup.AutoSize = True
        Me.hea_Setup.BackColor = System.Drawing.Color.Transparent
        Me.hea_Setup.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hea_Setup.ForeColor = System.Drawing.Color.SteelBlue
        Me.hea_Setup.Location = New System.Drawing.Point(498, 128)
        Me.hea_Setup.Name = "hea_Setup"
        Me.hea_Setup.Size = New System.Drawing.Size(240, 30)
        Me.hea_Setup.TabIndex = 32
        Me.hea_Setup.Text = "Setup Package Options"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.MetroPanelCategory3)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(124, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(754, 428)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Schedule"
        '
        'MetroPanelCategory3
        '
        Me.MetroPanelCategory3.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroPanelCategory3.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanelCategory3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanelCategory3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroPanelCategory3.Controls.Add(Me.cob_intervall)
        Me.MetroPanelCategory3.Controls.Add(Me.MetroTrackbar3)
        Me.MetroPanelCategory3.Controls.Add(Me.hea_Schedule)
        Me.MetroPanelCategory3.Controls.Add(Me.lbl_checkDriverTimer)
        Me.MetroPanelCategory3.Controls.Add(Me.tb_version)
        Me.MetroPanelCategory3.Controls.Add(Me.cb_ignore)
        Me.MetroPanelCategory3.DefaultColor = System.Drawing.Color.White
        Me.MetroPanelCategory3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroPanelCategory3.ForeColor = System.Drawing.Color.Black
        Me.MetroPanelCategory3.GradientColor = System.Drawing.Color.White
        Me.MetroPanelCategory3.GradientPointA = New System.Drawing.Point(0, 0)
        Me.MetroPanelCategory3.GradientPointB = New System.Drawing.Point(742, 416)
        Me.MetroPanelCategory3.LineGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroPanelCategory3.Location = New System.Drawing.Point(6, 6)
        Me.MetroPanelCategory3.Name = "MetroPanelCategory3"
        Me.MetroPanelCategory3.Size = New System.Drawing.Size(742, 416)
        Me.MetroPanelCategory3.TabIndex = 7
        '
        'cob_intervall
        '
        Me.cob_intervall.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cob_intervall.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.cob_intervall.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.cob_intervall.DefaultColor = System.Drawing.Color.White
        Me.cob_intervall.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cob_intervall.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cob_intervall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cob_intervall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cob_intervall.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cob_intervall.ForeColor = System.Drawing.Color.Black
        Me.cob_intervall.FormattingEnabled = True
        Me.cob_intervall.Items.AddRange(New Object() {"1 hour", "2 hours", "6 hours", "10 hours", "1 day"})
        Me.cob_intervall.Location = New System.Drawing.Point(188, 56)
        Me.cob_intervall.Name = "cob_intervall"
        Me.cob_intervall.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cob_intervall.Size = New System.Drawing.Size(131, 24)
        Me.cob_intervall.TabIndex = 36
        '
        'MetroTrackbar3
        '
        Me.MetroTrackbar3.BackColor = System.Drawing.Color.Transparent
        Me.MetroTrackbar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTrackbar3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroTrackbar3.Enabled = False
        Me.MetroTrackbar3.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroTrackbar3.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar3.LeftColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTrackbar3.Location = New System.Drawing.Point(16, 33)
        Me.MetroTrackbar3.Name = "MetroTrackbar3"
        Me.MetroTrackbar3.RailWidth = 1
        Me.MetroTrackbar3.RegionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar3.RightColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MetroTrackbar3.Size = New System.Drawing.Size(723, 23)
        Me.MetroTrackbar3.SliderColor = System.Drawing.Color.White
        Me.MetroTrackbar3.SliderWidth = 5
        Me.MetroTrackbar3.TabIndex = 35
        Me.MetroTrackbar3.Value = 100
        '
        'hea_Schedule
        '
        Me.hea_Schedule.AutoSize = True
        Me.hea_Schedule.BackColor = System.Drawing.Color.Transparent
        Me.hea_Schedule.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hea_Schedule.ForeColor = System.Drawing.Color.SteelBlue
        Me.hea_Schedule.Location = New System.Drawing.Point(637, 0)
        Me.hea_Schedule.Name = "hea_Schedule"
        Me.hea_Schedule.Size = New System.Drawing.Size(102, 30)
        Me.hea_Schedule.TabIndex = 33
        Me.hea_Schedule.Text = "Schedule"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.MetroPanelCategory4)
        Me.TabPage4.ImageIndex = 3
        Me.TabPage4.Location = New System.Drawing.Point(124, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(754, 428)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Fixes"
        '
        'MetroPanelCategory4
        '
        Me.MetroPanelCategory4.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroPanelCategory4.BackColor = System.Drawing.Color.Transparent
        Me.MetroPanelCategory4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanelCategory4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroPanelCategory4.Controls.Add(Me.cob_rgb)
        Me.MetroPanelCategory4.Controls.Add(Me.MetroTrackbar5)
        Me.MetroPanelCategory4.Controls.Add(Me.heaFixes)
        Me.MetroPanelCategory4.Controls.Add(Me.lbl_admin)
        Me.MetroPanelCategory4.Controls.Add(Me.cb_rgb)
        Me.MetroPanelCategory4.DefaultColor = System.Drawing.Color.White
        Me.MetroPanelCategory4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroPanelCategory4.ForeColor = System.Drawing.Color.Black
        Me.MetroPanelCategory4.GradientColor = System.Drawing.Color.White
        Me.MetroPanelCategory4.GradientPointA = New System.Drawing.Point(0, 0)
        Me.MetroPanelCategory4.GradientPointB = New System.Drawing.Point(742, 416)
        Me.MetroPanelCategory4.LineGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroPanelCategory4.Location = New System.Drawing.Point(6, 6)
        Me.MetroPanelCategory4.Name = "MetroPanelCategory4"
        Me.MetroPanelCategory4.Size = New System.Drawing.Size(742, 416)
        Me.MetroPanelCategory4.TabIndex = 8
        '
        'cob_rgb
        '
        Me.cob_rgb.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cob_rgb.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.cob_rgb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.cob_rgb.DefaultColor = System.Drawing.Color.White
        Me.cob_rgb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cob_rgb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cob_rgb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cob_rgb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cob_rgb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cob_rgb.ForeColor = System.Drawing.Color.Black
        Me.cob_rgb.FormattingEnabled = True
        Me.cob_rgb.Items.AddRange(New Object() {"Full RGB Range", "Limited RGB Range"})
        Me.cob_rgb.Location = New System.Drawing.Point(166, 60)
        Me.cob_rgb.Name = "cob_rgb"
        Me.cob_rgb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cob_rgb.Size = New System.Drawing.Size(121, 24)
        Me.cob_rgb.TabIndex = 36
        '
        'MetroTrackbar5
        '
        Me.MetroTrackbar5.BackColor = System.Drawing.Color.Transparent
        Me.MetroTrackbar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTrackbar5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroTrackbar5.Enabled = False
        Me.MetroTrackbar5.GradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.MetroTrackbar5.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar5.LeftColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTrackbar5.Location = New System.Drawing.Point(16, 33)
        Me.MetroTrackbar5.Name = "MetroTrackbar5"
        Me.MetroTrackbar5.RailWidth = 1
        Me.MetroTrackbar5.RegionColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroTrackbar5.RightColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MetroTrackbar5.Size = New System.Drawing.Size(723, 23)
        Me.MetroTrackbar5.SliderColor = System.Drawing.Color.White
        Me.MetroTrackbar5.SliderWidth = 5
        Me.MetroTrackbar5.TabIndex = 35
        Me.MetroTrackbar5.Value = 100
        '
        'heaFixes
        '
        Me.heaFixes.AutoSize = True
        Me.heaFixes.BackColor = System.Drawing.Color.Transparent
        Me.heaFixes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heaFixes.ForeColor = System.Drawing.Color.SteelBlue
        Me.heaFixes.Location = New System.Drawing.Point(677, 0)
        Me.heaFixes.Name = "heaFixes"
        Me.heaFixes.Size = New System.Drawing.Size(62, 30)
        Me.heaFixes.TabIndex = 33
        Me.heaFixes.Text = "Fixes"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-settings-48.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-video-card-48.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-überstunden-48.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-support-48.png")
        '
        'MetroFormControl
        '
        Me.MetroFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroFormControl.LoadDefaultAreas = False
        Me.MetroFormControl.Location = New System.Drawing.Point(842, 1)
        Me.MetroFormControl.Name = "MetroFormControl"
        Me.MetroFormControl.Size = New System.Drawing.Size(64, 32)
        Me.MetroFormControl.TabIndex = 9
        '
        'btn_runTest
        '
        Me.btn_runTest.BackColor = System.Drawing.Color.Transparent
        Me.btn_runTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_runTest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_runTest.DefaultColor = System.Drawing.Color.White
        Me.btn_runTest.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_runTest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_runTest.ForeColor = System.Drawing.Color.Black
        Me.btn_runTest.HoverColor = System.Drawing.Color.White
        Me.btn_runTest.Location = New System.Drawing.Point(651, 191)
        Me.btn_runTest.Name = "btn_runTest"
        Me.btn_runTest.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_runTest.RoundingArc = 23
        Me.btn_runTest.Size = New System.Drawing.Size(75, 23)
        Me.btn_runTest.TabIndex = 40
        Me.btn_runTest.Text = "Test"
        '
        'frm_options
        '
        Me.AllowResize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 521)
        Me.Controls.Add(Me.MetroFormControl)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainControlBox = Me.MetroFormControl
        Me.Name = "frm_options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.State = MetroSuite.MetroForm.FormState.Normal
        Me.Style = MetroSuite.Design.Style.Light
        Me.Text = "NV Updater | Options"
        Me.ToolTipHelp.SetToolTip(Me, "Updates the DCH driver package pre-installed by some manufacturers.")
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MetroPanelCategory2.ResumeLayout(False)
        Me.MetroPanelCategory2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.MetroPanelCategory1.ResumeLayout(False)
        Me.MetroPanelCategory1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.MetroPanelCategory3.ResumeLayout(False)
        Me.MetroPanelCategory3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.MetroPanelCategory4.ResumeLayout(False)
        Me.MetroPanelCategory4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_autoupdate As CheckBox
    Friend WithEvents cb_logmode As CheckBox
    Friend WithEvents cb_autorun As CheckBox
    Friend WithEvents lbl_checkDriverTimer As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents cb_ignore As CheckBox
    Friend WithEvents tb_version As TextBox
    Friend WithEvents cb_silent As CheckBox
    Friend WithEvents cb_clean As CheckBox
    Friend WithEvents cb_telemetry As CheckBox
    Friend WithEvents cb_rgb As CheckBox
    Friend WithEvents lbl_admin As Label
    Friend WithEvents cb_dch As CheckBox
    Friend WithEvents ToolTipHelp As ToolTip
    Friend WithEvents cb_ShadowPlay As CheckBox
    Friend WithEvents cb_NvvHCI As CheckBox
    Friend WithEvents cb_DisplayOptimus As CheckBox
    Friend WithEvents cb_ShieldWirelessController As CheckBox
    Friend WithEvents cb_PhysX As CheckBox
    Friend WithEvents cb_NvContainer As CheckBox
    Friend WithEvents cb_GFExperience As CheckBox
    Friend WithEvents cb_NVWMI As CheckBox
    Friend WithEvents cb_UpdateCore As CheckBox
    Friend WithEvents cb_NvVAD As CheckBox
    Friend WithEvents cb_NvBackend As CheckBox
    Friend WithEvents cb_NvAbHub As CheckBox
    Friend WithEvents cb_nodejs As CheckBox
    Friend WithEvents cb_MSVCRT As CheckBox
    Friend WithEvents cb_NGXCore As CheckBox
    Friend WithEvents cb_DisplayUpdate As CheckBox
    Friend WithEvents cb_DisplayNView As CheckBox
    Friend WithEvents cb_PPC As CheckBox
    Friend WithEvents cb_HDAudio As CheckBox
    Friend WithEvents cb_NvCamera As CheckBox
    Friend WithEvents cb_hotfix As CheckBox
    Friend WithEvents cb_studio As CheckBox
    Friend WithEvents cb_FrameViewSDK As CheckBox
    Friend WithEvents cb_NVModuleTracker As CheckBox
    Friend WithEvents MetroTabControl1 As MetroSuite.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents MetroFormControl As MetroControlBox
    Friend WithEvents MetroPanelCategory1 As MetroPanelCategory
    Friend WithEvents MetroPanelCategory2 As MetroPanelCategory
    Friend WithEvents MetroPanelCategory3 As MetroPanelCategory
    Friend WithEvents hea_Setup As MetroLabel
    Friend WithEvents hea_Settings As MetroLabel
    Friend WithEvents hea_Schedule As MetroLabel
    Friend WithEvents hea_DriverOptions As MetroLabel
    Friend WithEvents MetroTrackbar1 As MetroTrackbar
    Friend WithEvents MetroTrackbar2 As MetroTrackbar
    Friend WithEvents MetroTrackbar4 As MetroTrackbar
    Friend WithEvents MetroTrackbar3 As MetroTrackbar
    Friend WithEvents MetroPanelCategory4 As MetroPanelCategory
    Friend WithEvents MetroTrackbar5 As MetroTrackbar
    Friend WithEvents heaFixes As MetroLabel
    Friend WithEvents cob_intervall As MetroComboBox
    Friend WithEvents cob_rgb As MetroComboBox
    Friend WithEvents cb_NVPCF As CheckBox
    Friend WithEvents cb_run As CheckBox
    Friend WithEvents tb_runPath As MetroTextbox
    Friend WithEvents btn_chooseApp As MetroButton
    Friend WithEvents tb_runOptions As MetroTextbox
    Friend WithEvents btn_runTest As MetroButton
End Class
