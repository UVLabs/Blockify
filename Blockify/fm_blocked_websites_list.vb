Imports System.ComponentModel
Imports System.IO
Public Class fm_blocked_websites_list

    Dim sites As String
    Dim save_clicked As Boolean

    Private Sub fm_blocked_websites_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim sr As New StreamReader(fm_main.sites_save_path)


            Do Until sr.Peek = -1
                sites = sr.ReadLine()
                lb_blockedSites.Items.Add(sites)
            Loop
            sr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_removeSite_Click(sender As Object, e As EventArgs) Handles btn_removeSite.Click
        lb_blockedSites.Items.Remove(lb_blockedSites.SelectedItem) 'remove current selected network
        btn_save.Enabled = True
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try

            Using writer As New StreamWriter(fm_main.sites_save_path)
                Dim i As Integer
                For i = 0 To lb_blockedSites.Items.Count - 1
                    writer.WriteLine(lb_blockedSites.Items.Item(i))
                Next
                save_clicked = True

            End Using

            fm_blockSites.update_mainfm_blockedwebsites() 'update main form window

            If lb_blockedSites.Items.Count = 0 And save_clicked = True Then 'check if save button was clicked so accidental deletion doesnt happen
                File.Delete(fm_main.sites_save_path)
                fm_main.tb_blockedSites.Text = "No websites are currently being blocked."
                fm_main.lbl_status.Text = "" 'change blocking status text
                fm_main.pb_status.Image = My.Resources.Circle_Red

                'restore backup hostsfile because all sites cleared.

                Using reader As StreamReader = New StreamReader(fm_main.hosts_bkup_save_path)
                    fm_main.writehosts_back = reader.ReadToEnd
                End Using

                Using writer As New StreamWriter(fm_main.hosts_path)
                    writer.Write(fm_main.writehosts_back)
                    writer.Close()
                End Using
                save_clicked = False 'reset bool
            End If
            MsgBox("Changes Saved!", vbInformation, "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub fm_blocked_websites_list_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'If lb_blockedSites.Items.Count = 0 And save_clicked = True Then 'check if save button was clicked so accidental deletion doesnt happen
        '    File.Delete(fm_main.sites_save_path)
        '    fm_main.tb_blockedSites.Text = "No websites are currently being blocked."
        '    fm_main.lbl_status.Text = "" ' hide blocking status text
        '    fm_main.pb_status.Image = My.Resources.Circle_Red

        '    'restore backup hostsfile because all sites cleared.

        '    Using reader As StreamReader = New StreamReader(fm_main.hosts_bkup_save_path)

        '        fm_main.writehosts_back = reader.ReadToEnd
        '    End Using

        '    Using writer As New StreamWriter(fm_main.hosts_path)
        '        writer.Write(fm_main.writehosts_back)
        '        writer.Close()
        '    End Using
        'End If

    End Sub

    Private Sub btn_delAll_Click(sender As Object, e As EventArgs) Handles btn_delAll.Click
        lb_blockedSites.Items.Clear()
        btn_save.Enabled = True
    End Sub
End Class