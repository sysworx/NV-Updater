<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_graphicinfo
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_graphicinfo))
        Me.lv_info = New System.Windows.Forms.ListView()
        Me.cl_desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cl_val = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lv_info
        '
        Me.lv_info.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lv_info.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cl_desc, Me.cl_val})
        Me.lv_info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_info.HideSelection = False
        Me.lv_info.Location = New System.Drawing.Point(12, 12)
        Me.lv_info.MultiSelect = False
        Me.lv_info.Name = "lv_info"
        Me.lv_info.Size = New System.Drawing.Size(975, 562)
        Me.lv_info.TabIndex = 0
        Me.lv_info.UseCompatibleStateImageBehavior = False
        Me.lv_info.View = System.Windows.Forms.View.Details
        '
        'cl_desc
        '
        Me.cl_desc.Text = "Description"
        Me.cl_desc.Width = 250
        '
        'cl_val
        '
        Me.cl_val.Text = "Value"
        Me.cl_val.Width = 700
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(462, 580)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(912, 580)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(75, 23)
        Me.btn_export.TabIndex = 2
        Me.btn_export.Text = "Export"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'frm_graphicinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(999, 615)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.lv_info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_graphicinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NV Updater | Graphics Info "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lv_info As ListView
    Friend WithEvents cl_desc As ColumnHeader
    Friend WithEvents cl_val As ColumnHeader
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_export As Button
End Class
