<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_about
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_about))
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_Version = New System.Windows.Forms.Label()
        Me.lbl_copyright = New System.Windows.Forms.Label()
        Me.rtb_DriverInfo = New System.Windows.Forms.RichTextBox()
        Me.gb_gfxInfo = New System.Windows.Forms.GroupBox()
        Me.gb_info = New System.Windows.Forms.GroupBox()
        Me.lbl_metrosuite = New System.Windows.Forms.LinkLabel()
        Me.pb_donation = New System.Windows.Forms.PictureBox()
        Me.rtb_projectInfo = New System.Windows.Forms.RichTextBox()
        Me.lbl_tnuc = New System.Windows.Forms.LinkLabel()
        Me.lbl_nvslim = New System.Windows.Forms.LinkLabel()
        Me.lbl_7zip = New System.Windows.Forms.LinkLabel()
        Me.lbl_htmlpack = New System.Windows.Forms.LinkLabel()
        Me.lbl_icons8 = New System.Windows.Forms.LinkLabel()
        Me.lbl_resources = New System.Windows.Forms.Label()
        Me.lbl_special = New System.Windows.Forms.RichTextBox()
        Me.pb_licence = New System.Windows.Forms.PictureBox()
        Me.lbl_licence = New System.Windows.Forms.Label()
        Me.lbl_licenceLink = New System.Windows.Forms.LinkLabel()
        Me.btn_config = New System.Windows.Forms.Button()
        Me.lbl_beta = New System.Windows.Forms.Label()
        Me.llbl_sysworx = New System.Windows.Forms.LinkLabel()
        Me.btn_graphic = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_gfxInfo.SuspendLayout()
        Me.gb_info.SuspendLayout()
        CType(Me.pb_donation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_licence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.White
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_ok.Location = New System.Drawing.Point(222, 437)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_ok.Size = New System.Drawing.Size(105, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_title.Location = New System.Drawing.Point(82, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(179, 36)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "NV Updater"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_Version
        '
        Me.lbl_Version.AutoSize = True
        Me.lbl_Version.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Version.Location = New System.Drawing.Point(267, 34)
        Me.lbl_Version.Name = "lbl_Version"
        Me.lbl_Version.Size = New System.Drawing.Size(44, 14)
        Me.lbl_Version.TabIndex = 3
        Me.lbl_Version.Text = "Version"
        Me.lbl_Version.UseMnemonic = False
        '
        'lbl_copyright
        '
        Me.lbl_copyright.AutoSize = True
        Me.lbl_copyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_copyright.Location = New System.Drawing.Point(85, 48)
        Me.lbl_copyright.Name = "lbl_copyright"
        Me.lbl_copyright.Size = New System.Drawing.Size(113, 14)
        Me.lbl_copyright.TabIndex = 4
        Me.lbl_copyright.Text = "Copyright (C) 2022 by"
        '
        'rtb_DriverInfo
        '
        Me.rtb_DriverInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_DriverInfo.BackColor = System.Drawing.Color.White
        Me.rtb_DriverInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_DriverInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_DriverInfo.Location = New System.Drawing.Point(6, 19)
        Me.rtb_DriverInfo.Name = "rtb_DriverInfo"
        Me.rtb_DriverInfo.ReadOnly = True
        Me.rtb_DriverInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.rtb_DriverInfo.Size = New System.Drawing.Size(515, 129)
        Me.rtb_DriverInfo.TabIndex = 0
        Me.rtb_DriverInfo.Text = ""
        '
        'gb_gfxInfo
        '
        Me.gb_gfxInfo.Controls.Add(Me.rtb_DriverInfo)
        Me.gb_gfxInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_gfxInfo.Location = New System.Drawing.Point(12, 277)
        Me.gb_gfxInfo.Name = "gb_gfxInfo"
        Me.gb_gfxInfo.Size = New System.Drawing.Size(527, 154)
        Me.gb_gfxInfo.TabIndex = 6
        Me.gb_gfxInfo.TabStop = False
        Me.gb_gfxInfo.Text = "Graphics Card"
        '
        'gb_info
        '
        Me.gb_info.Controls.Add(Me.lbl_metrosuite)
        Me.gb_info.Controls.Add(Me.pb_donation)
        Me.gb_info.Controls.Add(Me.rtb_projectInfo)
        Me.gb_info.Controls.Add(Me.lbl_tnuc)
        Me.gb_info.Controls.Add(Me.lbl_nvslim)
        Me.gb_info.Controls.Add(Me.lbl_7zip)
        Me.gb_info.Controls.Add(Me.lbl_htmlpack)
        Me.gb_info.Controls.Add(Me.lbl_icons8)
        Me.gb_info.Controls.Add(Me.lbl_resources)
        Me.gb_info.Controls.Add(Me.lbl_special)
        Me.gb_info.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_info.Location = New System.Drawing.Point(12, 82)
        Me.gb_info.Name = "gb_info"
        Me.gb_info.Size = New System.Drawing.Size(527, 188)
        Me.gb_info.TabIndex = 7
        Me.gb_info.TabStop = False
        Me.gb_info.Text = "Info"
        '
        'lbl_metrosuite
        '
        Me.lbl_metrosuite.AutoSize = True
        Me.lbl_metrosuite.Location = New System.Drawing.Point(6, 72)
        Me.lbl_metrosuite.Name = "lbl_metrosuite"
        Me.lbl_metrosuite.Size = New System.Drawing.Size(109, 14)
        Me.lbl_metrosuite.TabIndex = 15
        Me.lbl_metrosuite.TabStop = True
        Me.lbl_metrosuite.Text = "MetroSuite by Gather"
        '
        'pb_donation
        '
        Me.pb_donation.Image = CType(resources.GetObject("pb_donation.Image"), System.Drawing.Image)
        Me.pb_donation.Location = New System.Drawing.Point(504, 167)
        Me.pb_donation.Name = "pb_donation"
        Me.pb_donation.Size = New System.Drawing.Size(16, 16)
        Me.pb_donation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_donation.TabIndex = 14
        Me.pb_donation.TabStop = False
        '
        'rtb_projectInfo
        '
        Me.rtb_projectInfo.BackColor = System.Drawing.Color.White
        Me.rtb_projectInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_projectInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_projectInfo.Location = New System.Drawing.Point(9, 154)
        Me.rtb_projectInfo.Name = "rtb_projectInfo"
        Me.rtb_projectInfo.ReadOnly = True
        Me.rtb_projectInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.rtb_projectInfo.Size = New System.Drawing.Size(509, 29)
        Me.rtb_projectInfo.TabIndex = 9
        Me.rtb_projectInfo.Text = "NV Updater is a free project with which I, as always, do not want to generate any" &
    " income. If you would " & Global.Microsoft.VisualBasic.ChrW(10) & "like to donate coffee's, you are welcome to do so with a " &
    "donation for my site." & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_tnuc
        '
        Me.lbl_tnuc.AutoSize = True
        Me.lbl_tnuc.Location = New System.Drawing.Point(6, 114)
        Me.lbl_tnuc.Name = "lbl_tnuc"
        Me.lbl_tnuc.Size = New System.Drawing.Size(244, 14)
        Me.lbl_tnuc.TabIndex = 8
        Me.lbl_tnuc.TabStop = True
        Me.lbl_tnuc.Text = "TinyNvidiaUpdateChecker from Samuel (ElPumpo)"
        '
        'lbl_nvslim
        '
        Me.lbl_nvslim.AutoSize = True
        Me.lbl_nvslim.Location = New System.Drawing.Point(6, 128)
        Me.lbl_nvslim.Name = "lbl_nvslim"
        Me.lbl_nvslim.Size = New System.Drawing.Size(110, 14)
        Me.lbl_nvslim.TabIndex = 7
        Me.lbl_nvslim.TabStop = True
        Me.lbl_nvslim.Text = "NVSlimmer from uKer"
        '
        'lbl_7zip
        '
        Me.lbl_7zip.AutoSize = True
        Me.lbl_7zip.Location = New System.Drawing.Point(6, 58)
        Me.lbl_7zip.Name = "lbl_7zip"
        Me.lbl_7zip.Size = New System.Drawing.Size(109, 14)
        Me.lbl_7zip.TabIndex = 6
        Me.lbl_7zip.TabStop = True
        Me.lbl_7zip.Text = "7Zip from Igor Pavlov"
        '
        'lbl_htmlpack
        '
        Me.lbl_htmlpack.AutoSize = True
        Me.lbl_htmlpack.Location = New System.Drawing.Point(6, 44)
        Me.lbl_htmlpack.Name = "lbl_htmlpack"
        Me.lbl_htmlpack.Size = New System.Drawing.Size(176, 14)
        Me.lbl_htmlpack.TabIndex = 5
        Me.lbl_htmlpack.TabStop = True
        Me.lbl_htmlpack.Text = "HTML Agility Pack from zzzprojects"
        '
        'lbl_icons8
        '
        Me.lbl_icons8.AutoSize = True
        Me.lbl_icons8.Location = New System.Drawing.Point(6, 30)
        Me.lbl_icons8.Name = "lbl_icons8"
        Me.lbl_icons8.Size = New System.Drawing.Size(93, 14)
        Me.lbl_icons8.TabIndex = 3
        Me.lbl_icons8.TabStop = True
        Me.lbl_icons8.Text = "Icons from Icons8"
        '
        'lbl_resources
        '
        Me.lbl_resources.AutoSize = True
        Me.lbl_resources.Location = New System.Drawing.Point(6, 16)
        Me.lbl_resources.Name = "lbl_resources"
        Me.lbl_resources.Size = New System.Drawing.Size(211, 14)
        Me.lbl_resources.TabIndex = 2
        Me.lbl_resources.Text = "NV Updater uses the following resources:"
        '
        'lbl_special
        '
        Me.lbl_special.BackColor = System.Drawing.Color.White
        Me.lbl_special.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_special.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_special.Location = New System.Drawing.Point(6, 99)
        Me.lbl_special.Name = "lbl_special"
        Me.lbl_special.ReadOnly = True
        Me.lbl_special.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.lbl_special.Size = New System.Drawing.Size(509, 14)
        Me.lbl_special.TabIndex = 1
        Me.lbl_special.Text = "Special thanks for inspiration and information to some other great tools:" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pb_licence
        '
        Me.pb_licence.Image = Global.nv_updater.My.Resources.Resources.licence
        Me.pb_licence.Location = New System.Drawing.Point(445, 54)
        Me.pb_licence.Name = "pb_licence"
        Me.pb_licence.Size = New System.Drawing.Size(88, 31)
        Me.pb_licence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_licence.TabIndex = 8
        Me.pb_licence.TabStop = False
        '
        'lbl_licence
        '
        Me.lbl_licence.AutoSize = True
        Me.lbl_licence.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_licence.Location = New System.Drawing.Point(85, 62)
        Me.lbl_licence.Name = "lbl_licence"
        Me.lbl_licence.Size = New System.Drawing.Size(48, 14)
        Me.lbl_licence.TabIndex = 9
        Me.lbl_licence.Text = "Licence:"
        '
        'lbl_licenceLink
        '
        Me.lbl_licenceLink.AutoSize = True
        Me.lbl_licenceLink.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_licenceLink.Location = New System.Drawing.Point(129, 62)
        Me.lbl_licenceLink.Name = "lbl_licenceLink"
        Me.lbl_licenceLink.Size = New System.Drawing.Size(92, 14)
        Me.lbl_licenceLink.TabIndex = 10
        Me.lbl_licenceLink.TabStop = True
        Me.lbl_licenceLink.Text = "CC BY-NC-ND 4.0"
        '
        'btn_config
        '
        Me.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_config.Location = New System.Drawing.Point(445, 437)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(94, 23)
        Me.btn_config.TabIndex = 11
        Me.btn_config.Text = "Config-Folder"
        Me.btn_config.UseVisualStyleBackColor = True
        '
        'lbl_beta
        '
        Me.lbl_beta.AutoSize = True
        Me.lbl_beta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_beta.Location = New System.Drawing.Point(347, 34)
        Me.lbl_beta.Name = "lbl_beta"
        Me.lbl_beta.Size = New System.Drawing.Size(29, 14)
        Me.lbl_beta.TabIndex = 12
        Me.lbl_beta.Text = "Beta"
        Me.lbl_beta.UseMnemonic = False
        '
        'llbl_sysworx
        '
        Me.llbl_sysworx.AutoSize = True
        Me.llbl_sysworx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_sysworx.Location = New System.Drawing.Point(195, 48)
        Me.llbl_sysworx.Name = "llbl_sysworx"
        Me.llbl_sysworx.Size = New System.Drawing.Size(75, 14)
        Me.llbl_sysworx.TabIndex = 13
        Me.llbl_sysworx.TabStop = True
        Me.llbl_sysworx.Text = "Sys-worX.net"
        '
        'btn_graphic
        '
        Me.btn_graphic.Location = New System.Drawing.Point(364, 437)
        Me.btn_graphic.Name = "btn_graphic"
        Me.btn_graphic.Size = New System.Drawing.Size(75, 23)
        Me.btn_graphic.TabIndex = 14
        Me.btn_graphic.Text = "Graphic Info"
        Me.btn_graphic.UseVisualStyleBackColor = True
        '
        'frm_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 467)
        Me.Controls.Add(Me.btn_graphic)
        Me.Controls.Add(Me.llbl_sysworx)
        Me.Controls.Add(Me.lbl_beta)
        Me.Controls.Add(Me.btn_config)
        Me.Controls.Add(Me.lbl_licenceLink)
        Me.Controls.Add(Me.lbl_licence)
        Me.Controls.Add(Me.pb_licence)
        Me.Controls.Add(Me.gb_info)
        Me.Controls.Add(Me.gb_gfxInfo)
        Me.Controls.Add(Me.lbl_copyright)
        Me.Controls.Add(Me.lbl_Version)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_ok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_about"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About NV Updater"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_gfxInfo.ResumeLayout(False)
        Me.gb_info.ResumeLayout(False)
        Me.gb_info.PerformLayout()
        CType(Me.pb_donation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_licence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Version As Label
    Friend WithEvents lbl_copyright As Label
    Friend WithEvents rtb_DriverInfo As RichTextBox
    Friend WithEvents gb_gfxInfo As GroupBox
    Friend WithEvents gb_info As GroupBox
    Friend WithEvents lbl_special As RichTextBox
    Friend WithEvents pb_licence As PictureBox
    Friend WithEvents lbl_licence As Label
    Friend WithEvents lbl_licenceLink As LinkLabel
    Friend WithEvents lbl_resources As Label
    Friend WithEvents lbl_icons8 As LinkLabel
    Friend WithEvents lbl_htmlpack As LinkLabel
    Friend WithEvents btn_config As Button
    Friend WithEvents lbl_beta As Label
    Friend WithEvents lbl_7zip As LinkLabel
    Friend WithEvents lbl_tnuc As LinkLabel
    Friend WithEvents lbl_nvslim As LinkLabel
    Friend WithEvents llbl_sysworx As LinkLabel
    Friend WithEvents pb_donation As PictureBox
    Friend WithEvents rtb_projectInfo As RichTextBox
    Friend WithEvents btn_graphic As Button
    Friend WithEvents lbl_metrosuite As LinkLabel
End Class
