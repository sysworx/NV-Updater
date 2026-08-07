<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_download
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_download))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pb_update = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_download = New System.Windows.Forms.Label()
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.pb_download = New System.Windows.Forms.PictureBox()
        Me.pb_extract = New System.Windows.Forms.PictureBox()
        Me.lbl_extract = New System.Windows.Forms.Label()
        Me.pb_install = New System.Windows.Forms.PictureBox()
        Me.lbl_install = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_speed = New System.Windows.Forms.Label()
        CType(Me.pb_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_download, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_extract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_install, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(171, 24)
        Me.lbl_title.TabIndex = 16
        Me.lbl_title.Text = "New Driver found"
        '
        'pb_update
        '
        Me.pb_update.Image = Global.nv_updater.My.Resources.Resources.download
        Me.pb_update.Location = New System.Drawing.Point(373, 73)
        Me.pb_update.Name = "pb_update"
        Me.pb_update.Size = New System.Drawing.Size(64, 64)
        Me.pb_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_update.TabIndex = 15
        Me.pb_update.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 47)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(419, 15)
        Me.ProgressBar1.TabIndex = 19
        '
        'lbl_download
        '
        Me.lbl_download.AutoSize = True
        Me.lbl_download.Location = New System.Drawing.Point(38, 70)
        Me.lbl_download.Name = "lbl_download"
        Me.lbl_download.Size = New System.Drawing.Size(69, 13)
        Me.lbl_download.TabIndex = 20
        Me.lbl_download.Text = "Downloading"
        '
        'lbl_progress
        '
        Me.lbl_progress.AutoSize = True
        Me.lbl_progress.Location = New System.Drawing.Point(107, 70)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(13, 13)
        Me.lbl_progress.TabIndex = 21
        Me.lbl_progress.Text = "0"
        '
        'pb_download
        '
        Me.pb_download.Image = Global.nv_updater.My.Resources.Resources.spinner2
        Me.pb_download.Location = New System.Drawing.Point(16, 68)
        Me.pb_download.Name = "pb_download"
        Me.pb_download.Size = New System.Drawing.Size(16, 16)
        Me.pb_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_download.TabIndex = 22
        Me.pb_download.TabStop = False
        '
        'pb_extract
        '
        Me.pb_extract.Image = Global.nv_updater.My.Resources.Resources.spinner2
        Me.pb_extract.Location = New System.Drawing.Point(16, 90)
        Me.pb_extract.Name = "pb_extract"
        Me.pb_extract.Size = New System.Drawing.Size(16, 16)
        Me.pb_extract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_extract.TabIndex = 24
        Me.pb_extract.TabStop = False
        Me.pb_extract.Visible = False
        '
        'lbl_extract
        '
        Me.lbl_extract.AutoSize = True
        Me.lbl_extract.Location = New System.Drawing.Point(38, 92)
        Me.lbl_extract.Name = "lbl_extract"
        Me.lbl_extract.Size = New System.Drawing.Size(54, 13)
        Me.lbl_extract.TabIndex = 23
        Me.lbl_extract.Text = "Extracting"
        Me.lbl_extract.Visible = False
        '
        'pb_install
        '
        Me.pb_install.Image = Global.nv_updater.My.Resources.Resources.spinner2
        Me.pb_install.Location = New System.Drawing.Point(16, 112)
        Me.pb_install.Name = "pb_install"
        Me.pb_install.Size = New System.Drawing.Size(16, 16)
        Me.pb_install.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_install.TabIndex = 26
        Me.pb_install.TabStop = False
        Me.pb_install.Visible = False
        '
        'lbl_install
        '
        Me.lbl_install.AutoSize = True
        Me.lbl_install.Location = New System.Drawing.Point(38, 114)
        Me.lbl_install.Name = "lbl_install"
        Me.lbl_install.Size = New System.Drawing.Size(48, 13)
        Me.lbl_install.TabIndex = 25
        Me.lbl_install.Text = "Installing"
        Me.lbl_install.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 1)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'lbl_speed
        '
        Me.lbl_speed.AutoSize = True
        Me.lbl_speed.Location = New System.Drawing.Point(134, 70)
        Me.lbl_speed.Name = "lbl_speed"
        Me.lbl_speed.Size = New System.Drawing.Size(13, 13)
        Me.lbl_speed.TabIndex = 28
        Me.lbl_speed.Text = "0"
        '
        'frm_download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 146)
        Me.Controls.Add(Me.lbl_speed)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pb_install)
        Me.Controls.Add(Me.lbl_install)
        Me.Controls.Add(Me.pb_extract)
        Me.Controls.Add(Me.lbl_extract)
        Me.Controls.Add(Me.pb_download)
        Me.Controls.Add(Me.lbl_progress)
        Me.Controls.Add(Me.lbl_download)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pb_update)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_download"
        Me.Text = "NV Updater | New Driver Installer"
        CType(Me.pb_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_download, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_extract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_install, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents pb_update As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl_download As Label
    Friend WithEvents lbl_progress As Label
    Friend WithEvents pb_download As PictureBox
    Friend WithEvents pb_extract As PictureBox
    Friend WithEvents lbl_extract As Label
    Friend WithEvents pb_install As PictureBox
    Friend WithEvents lbl_install As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_speed As Label
End Class
