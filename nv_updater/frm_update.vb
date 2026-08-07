Imports System.Globalization
Imports System.IO
Imports System.Xml
Imports MetroSuite
Public Class frm_update
    Inherits MetroSuite.MetroForm
    Public vResult As String = Nothing
    Public ReleaseNotes As String
    Public DownloadURL As String
    Public Version As String

    Private Sub Frm_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Metro Form Control Box
        Dim area As New MetroSuite.MetroControlBoxArea(MetroSuite.MetroControlBoxArea.ControlBoxAreaType.Close, MetroSuite.Design.Style.Light, "close")
        MetroFormControl.Areas.Add(area)

        'set the form bottom right
        Me.Location = New Point(SystemInformation.WorkingArea.Right - Me.Width, SystemInformation.WorkingArea.Bottom - Me.Height)

        'Light/DarkMode
        If Lightmode = True Then
            Me.Icon = My.Resources.app
        Else
            Me.Icon = My.Resources.app_darkmode
        End If

    End Sub

    Private Sub lbl_changelog(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_changelog.LinkClicked
        frm_releasenotes.browser.DocumentText = ReleaseNotes
        frm_releasenotes.Show()
    End Sub

    Private Sub lbl_dontremind(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_DontRemind.LinkClicked
        'set the version to ignore
        Settings.Config.update.ignore = True
        Settings.Config.update.Version = Version
        Settings.Save(Settings.Config)
        updateTimer.Start()
        Me.Close()
    End Sub

    Private Sub Llbl_Result_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start(vResult)
    End Sub

    Private Sub Llbl_Install_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_Install.LinkClicked
        Me.Close()
        frm_download.Show()
    End Sub

    Private Sub frm_update_close(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        updateTimer.Start()
    End Sub

    Private Sub llbl_download_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_download.LinkClicked
        Me.Close()
        frm_download.onlyDownload = True
        frm_download.Show()
    End Sub

    Private Sub llbl_reinstall_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_reinstall.LinkClicked
        Me.Close()
        frm_download.onlyDownload = False
        frm_download.Show()
    End Sub

    Private Sub MetroControlBox1_AreaClicked(sender As Object, e As MetroControlBox.MetroControlBoxEventArgs) Handles MetroFormControl.AreaClicked
        Me.Close()
    End Sub

End Class