Public Class fm_about
    Private Sub llvisitWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llvisitWebsite.LinkClicked
        Process.Start("http://www.uriahsvictor.com")
    End Sub
End Class