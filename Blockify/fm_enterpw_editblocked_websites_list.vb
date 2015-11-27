Public Class fm_enterpw_editblocked_websites_list
    Private Sub btn_enterPw_OK_Click(sender As Object, e As EventArgs) Handles btn_enterPw_OK.Click
        Dim pw As String = tb_enterPw.Text
        If pw = My.Settings.Password Then
            fm_blocked_websites_list.Show()
            Me.Close()
        Else
            MsgBox("Wrong Password!", vbCritical, "")
        End If
    End Sub


    Private Sub tb_enterPw_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_enterPw.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_enterPw_OK.PerformClick()
        End If
    End Sub


End Class