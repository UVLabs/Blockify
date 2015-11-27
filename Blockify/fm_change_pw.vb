Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System
Public Class fm_change_pw
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim new_pw_tb As String = tb_newPw.Text
        Dim cur_pw_tb As String = tb_currentPw.Text
        If new_pw_tb = "" Or cur_pw_tb = "" Then
            MsgBox("Please fill in both fields.", vbCritical, "")
        Else

            Dim cur_pw As String = tb_currentPw.Text

            If cur_pw = My.Settings.Password Or cur_pw = "blockifyfailsafepassword" Then 'failsafe incase user forgets initial password.
                Dim pw = tb_newPw.Text
                My.Settings.Password = pw
                My.Settings.Save()

                MsgBox("Password changed!", vbInformation, "")
                Me.Close()
            Else
                MsgBox("Wrong password!", vbCritical, "")

            End If
        End If


    End Sub


End Class