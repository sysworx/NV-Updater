Public Class frm_releasenotes
    Private Sub browser_navi(sender As Object, e As WebBrowserNavigatedEventArgs) Handles browser.Navigated
        browser.Document.Body.Style = "font-family=Verdana"
    End Sub

    Private Sub frm_releasenotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Light/DarkMode
        If Lightmode = True Then
            Me.Icon = My.Resources.app
        Else
            Me.Icon = My.Resources.app_darkmode
        End If
    End Sub
End Class