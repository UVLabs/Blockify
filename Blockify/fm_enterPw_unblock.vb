Imports System.IO
Public Class fm_enterPw_unblock
    Private Sub btn_enterPw_OK_Click(sender As Object, e As EventArgs) Handles btn_enterPw_OK.Click
        Dim pw As String = tb_enterPw.Text
        If pw = My.Settings.Password Then

            Using reader As StreamReader = New StreamReader(fm_main.hosts_bkup_save_path)

                fm_main.writehosts_back = reader.ReadToEnd
            End Using

            Using writer As New StreamWriter(fm_main.hosts_path)
                writer.Write(fm_main.writehosts_back)
                writer.Close()
            End Using

            fm_main.lbl_status.Text = "Blocking off"
            fm_main.block_status = False
            fm_main.pb_status.Image = My.Resources.Circle_Red
            Me.Close()
        Else
            MsgBox("Incorrect Password!", vbInformation)
            tb_enterPw.Clear()
            tb_enterPw.Focus()
        End If
    End Sub


    Private Sub tb_enterPw_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_enterPw.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_enterPw_OK.PerformClick()
        End If
    End Sub

End Class