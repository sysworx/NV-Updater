<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_update
    Inherits MetroSuite.MetroForm


    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_update))
        Me.pb_update = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pb_instVersion = New System.Windows.Forms.PictureBox()
        Me.lbl_instVersion = New System.Windows.Forms.Label()
        Me.lbl_avVersion = New System.Windows.Forms.Label()
        Me.pb_avVersion = New System.Windows.Forms.PictureBox()
        Me.llbl_Install = New System.Windows.Forms.LinkLabel()
        Me.llbl_DontRemind = New System.Windows.Forms.LinkLabel()
        Me.lineSep1 = New System.Windows.Forms.Label()
        Me.lineSep2 = New System.Windows.Forms.Label()
        Me.llbl_changelog = New System.Windows.Forms.LinkLabel()
        Me.lineSep3 = New System.Windows.Forms.Label()
        Me.llbl_download = New System.Windows.Forms.LinkLabel()
        Me.lineSep4 = New System.Windows.Forms.Label()
        Me.llbl_reinstall = New System.Windows.Forms.LinkLabel()
        Me.pb_line = New System.Windows.Forms.PictureBox()
        Me.MetroFormControl = New MetroSuite.MetroControlBox()
        CType(Me.pb_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_instVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_avVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_line, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_update
        '
        Me.pb_update.Image = Global.nv_updater.My.Resources.Resources.update
        Me.pb_update.Location = New System.Drawing.Point(497, 109)
        Me.pb_update.Name = "pb_update"
        Me.pb_update.Size = New System.Drawing.Size(64, 64)
        Me.pb_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_update.TabIndex = 0
        Me.pb_update.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(14, 35)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(281, 24)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "New NVIDIA Driver available "
        '
        'pb_instVersion
        '
        Me.pb_instVersion.Image = Global.nv_updater.My.Resources.Resources.info
        Me.pb_instVersion.Location = New System.Drawing.Point(19, 87)
        Me.pb_instVersion.Name = "pb_instVersion"
        Me.pb_instVersion.Size = New System.Drawing.Size(16, 16)
        Me.pb_instVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_instVersion.TabIndex = 2
        Me.pb_instVersion.TabStop = False
        '
        'lbl_instVersion
        '
        Me.lbl_instVersion.AutoSize = True
        Me.lbl_instVersion.Location = New System.Drawing.Point(44, 90)
        Me.lbl_instVersion.Name = "lbl_instVersion"
        Me.lbl_instVersion.Size = New System.Drawing.Size(95, 15)
        Me.lbl_instVersion.TabIndex = 4
        Me.lbl_instVersion.Text = "Installed Version:"
        '
        'lbl_avVersion
        '
        Me.lbl_avVersion.AutoSize = True
        Me.lbl_avVersion.Location = New System.Drawing.Point(44, 115)
        Me.lbl_avVersion.Name = "lbl_avVersion"
        Me.lbl_avVersion.Size = New System.Drawing.Size(99, 15)
        Me.lbl_avVersion.TabIndex = 6
        Me.lbl_avVersion.Text = "Available Version:"
        '
        'pb_avVersion
        '
        Me.pb_avVersion.Image = Global.nv_updater.My.Resources.Resources.load
        Me.pb_avVersion.Location = New System.Drawing.Point(19, 113)
        Me.pb_avVersion.Name = "pb_avVersion"
        Me.pb_avVersion.Size = New System.Drawing.Size(16, 16)
        Me.pb_avVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_avVersion.TabIndex = 5
        Me.pb_avVersion.TabStop = False
        '
        'llbl_Install
        '
        Me.llbl_Install.AutoSize = True
        Me.llbl_Install.Location = New System.Drawing.Point(19, 168)
        Me.llbl_Install.Name = "llbl_Install"
        Me.llbl_Install.Size = New System.Drawing.Size(38, 15)
        Me.llbl_Install.TabIndex = 7
        Me.llbl_Install.TabStop = True
        Me.llbl_Install.Text = "Install"
        Me.llbl_Install.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'llbl_DontRemind
        '
        Me.llbl_DontRemind.AutoSize = True
        Me.llbl_DontRemind.Location = New System.Drawing.Point(83, 168)
        Me.llbl_DontRemind.Name = "llbl_DontRemind"
        Me.llbl_DontRemind.Size = New System.Drawing.Size(104, 15)
        Me.llbl_DontRemind.TabIndex = 8
        Me.llbl_DontRemind.TabStop = True
        Me.llbl_DontRemind.Text = "Ignore this version"
        Me.llbl_DontRemind.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lineSep1
        '
        Me.lineSep1.AutoSize = True
        Me.lineSep1.Location = New System.Drawing.Point(65, 168)
        Me.lineSep1.Name = "lineSep1"
        Me.lineSep1.Size = New System.Drawing.Size(10, 15)
        Me.lineSep1.TabIndex = 9
        Me.lineSep1.Text = "|"
        '
        'lineSep2
        '
        Me.lineSep2.AutoSize = True
        Me.lineSep2.Location = New System.Drawing.Point(198, 168)
        Me.lineSep2.Name = "lineSep2"
        Me.lineSep2.Size = New System.Drawing.Size(10, 15)
        Me.lineSep2.TabIndex = 10
        Me.lineSep2.Text = "|"
        '
        'llbl_changelog
        '
        Me.llbl_changelog.AutoSize = True
        Me.llbl_changelog.Location = New System.Drawing.Point(216, 168)
        Me.llbl_changelog.Name = "llbl_changelog"
        Me.llbl_changelog.Size = New System.Drawing.Size(65, 15)
        Me.llbl_changelog.TabIndex = 11
        Me.llbl_changelog.TabStop = True
        Me.llbl_changelog.Text = "Changelog"
        Me.llbl_changelog.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lineSep3
        '
        Me.lineSep3.AutoSize = True
        Me.lineSep3.Location = New System.Drawing.Point(290, 168)
        Me.lineSep3.Name = "lineSep3"
        Me.lineSep3.Size = New System.Drawing.Size(10, 15)
        Me.lineSep3.TabIndex = 15
        Me.lineSep3.Text = "|"
        '
        'llbl_download
        '
        Me.llbl_download.AutoSize = True
        Me.llbl_download.Location = New System.Drawing.Point(308, 168)
        Me.llbl_download.Name = "llbl_download"
        Me.llbl_download.Size = New System.Drawing.Size(87, 15)
        Me.llbl_download.TabIndex = 16
        Me.llbl_download.TabStop = True
        Me.llbl_download.Text = "Download only"
        Me.llbl_download.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lineSep4
        '
        Me.lineSep4.AutoSize = True
        Me.lineSep4.Location = New System.Drawing.Point(405, 168)
        Me.lineSep4.Name = "lineSep4"
        Me.lineSep4.Size = New System.Drawing.Size(10, 15)
        Me.lineSep4.TabIndex = 17
        Me.lineSep4.Text = "|"
        '
        'llbl_reinstall
        '
        Me.llbl_reinstall.AutoSize = True
        Me.llbl_reinstall.Location = New System.Drawing.Point(422, 168)
        Me.llbl_reinstall.Name = "llbl_reinstall"
        Me.llbl_reinstall.Size = New System.Drawing.Size(51, 15)
        Me.llbl_reinstall.TabIndex = 18
        Me.llbl_reinstall.TabStop = True
        Me.llbl_reinstall.Text = "Reinstall"
        Me.llbl_reinstall.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'pb_line
        '
        Me.pb_line.Image = CType(resources.GetObject("pb_line.Image"), System.Drawing.Image)
        Me.pb_line.Location = New System.Drawing.Point(19, 71)
        Me.pb_line.Name = "pb_line"
        Me.pb_line.Size = New System.Drawing.Size(549, 1)
        Me.pb_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_line.TabIndex = 19
        Me.pb_line.TabStop = False
        '
        'MetroFormControl
        '
        Me.MetroFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroFormControl.LoadDefaultAreas = False
        Me.MetroFormControl.Location = New System.Drawing.Point(521, 1)
        Me.MetroFormControl.Name = "MetroFormControl"
        Me.MetroFormControl.Size = New System.Drawing.Size(64, 32)
        Me.MetroFormControl.TabIndex = 20
        '
        'frm_update
        '
        Me.AllowResize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(586, 198)
        Me.Controls.Add(Me.MetroFormControl)
        Me.Controls.Add(Me.pb_line)
        Me.Controls.Add(Me.llbl_reinstall)
        Me.Controls.Add(Me.lineSep4)
        Me.Controls.Add(Me.llbl_download)
        Me.Controls.Add(Me.lineSep3)
        Me.Controls.Add(Me.llbl_changelog)
        Me.Controls.Add(Me.lineSep2)
        Me.Controls.Add(Me.lineSep1)
        Me.Controls.Add(Me.llbl_DontRemind)
        Me.Controls.Add(Me.llbl_Install)
        Me.Controls.Add(Me.lbl_avVersion)
        Me.Controls.Add(Me.pb_avVersion)
        Me.Controls.Add(Me.lbl_instVersion)
        Me.Controls.Add(Me.pb_instVersion)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pb_update)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainControlBox = Me.MetroFormControl
        Me.Name = "frm_update"
        Me.State = MetroSuite.MetroForm.FormState.Normal
        Me.Style = MetroSuite.Design.Style.Light
        Me.Text = "NV Updater | Notification"
        CType(Me.pb_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_instVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_avVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_line, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_update As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pb_instVersion As PictureBox
    Friend WithEvents lbl_instVersion As Label
    Friend WithEvents lbl_avVersion As Label
    Friend WithEvents pb_avVersion As PictureBox
    Friend WithEvents llbl_Install As LinkLabel
    Friend WithEvents llbl_DontRemind As LinkLabel
    Friend WithEvents lineSep1 As Label
    Friend WithEvents lineSep2 As Label
    Friend WithEvents llbl_changelog As LinkLabel
    Friend WithEvents lineSep3 As Label
    Friend WithEvents llbl_download As LinkLabel
    Friend WithEvents lineSep4 As Label
    Friend WithEvents llbl_reinstall As LinkLabel
    Friend WithEvents pb_line As PictureBox
    Friend WithEvents MetroFormControl As MetroSuite.MetroControlBox
End Class
