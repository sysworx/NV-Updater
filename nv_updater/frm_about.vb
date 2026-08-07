Option Strict On
Imports System.Collections

Public NotInheritable Class frm_about

    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim GFXInfo As ArrayList = GraphicsInfo()
        Me.lbl_Version.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString)
        pb_donation.Cursor = Cursors.Hand

        rtb_DriverInfo.AppendText("Graphics Card: " + GFXInfo(3).ToString + vbNewLine)
        rtb_DriverInfo.AppendText("Driver Version: " + GFXInfo(7).ToString + vbNewLine)
        rtb_DriverInfo.AppendText("Device ID: " & GFXInfo(4).ToString + vbNewLine)
        rtb_DriverInfo.AppendText("Adadapter RAM: " + GFXInfo(5).ToString + vbNewLine)
        rtb_DriverInfo.AppendText("VideoMemory Type: " + GFXInfo(11).ToString + vbNewLine)
        rtb_DriverInfo.AppendText("Adadapter DAC: " & GFXInfo(6).ToString & vbNewLine)
        rtb_DriverInfo.AppendText("Video Architecture: " + GFXInfo(9).ToString + vbNewLine)
        rtb_DriverInfo.AppendText("PNP Device ID: " + GFXInfo(10).ToString + vbNewLine)

        'Light/DarkMode
        If Lightmode = True Then
            Me.Icon = My.Resources.app
        Else
            Me.Icon = My.Resources.app_darkmode
        End If

    End Sub

    Private Sub Btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.Close()
    End Sub

    Private Sub Lbl_licenceLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_licenceLink.LinkClicked
        Dim url As String = “https://creativecommons.org/licenses/by-nc-nd/4.0/“
        Process.Start(url)
    End Sub

    Private Sub Lbl_icons8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_icons8.LinkClicked
        Dim url As String = “https://icons8.de/“
        Process.Start(url)
    End Sub

    Private Sub Lbl_nUpdate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 
        Dim url As String = “https://www.nupdate.net/“
        Process.Start(url)
    End Sub

    Private Sub Lbl_htmlpack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_htmlpack.LinkClicked
        Dim url As String = “https://html-agility-pack.net/“
        Process.Start(url)
    End Sub

    Private Sub Btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        Process.Start(Settings.AppConfigFolder)
    End Sub

    Private Sub lbl_7zip_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_7zip.LinkClicked
        Dim url As String = “https://www.7-zip.org/“
        Process.Start(url)
    End Sub

    Private Sub lbl_tnuc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_tnuc.LinkClicked
        Dim url As String = “https://github.com/ElPumpo/TinyNvidiaUpdateChecker“
        Process.Start(url)
    End Sub

    Private Sub lbl_nvslim_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_nvslim.LinkClicked
        Dim url As String = “https://forums.guru3d.com/threads/nvslimmer-nvidia-driver-slimming-utility.423072/“
        Process.Start(url)
    End Sub

    Private Sub llbl_sysworx_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_sysworx.LinkClicked
        Dim url As String = “https://www.sys-worx.net/“
        Process.Start(url)
    End Sub

    Private Sub pb_donation_Click(sender As Object, e As EventArgs) Handles pb_donation.Click
        Dim url As String = “https://www.buymeacoffee.com/sysworx“
        Process.Start(url)
    End Sub

    Private Sub btn_graphic_Click(sender As Object, e As EventArgs) Handles btn_graphic.Click
        frm_graphicinfo.Show()
    End Sub

    Private Sub lbl_metrosuite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_metrosuite.LinkClicked
        Dim url As String = “https://www.vb-paradise.de/index.php/Thread/81271-UPDATE-20-10-2020-MetroSuite-2-0-Holt-euch-den-modernen-Windows-10-Style/?pageNo=1“
        Process.Start(url)
    End Sub
End Class
