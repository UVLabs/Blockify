
Imports System.IO

Public Class fm_blockSites


    Private Sub btn_block_Click(sender As Object, e As EventArgs) Handles btn_block.Click
        Try
            Dim website_to_block As String = tb_blockSite.Text
            If website_to_block = "" Then
                MsgBox("Please enter a website to block!", vbCritical, "")

            Else
                Dim blockurl As String = tb_blockSite.Text

                'remove http:// from url for hosts file
                If blockurl.Contains("http://") Then
                    blockurl = blockurl.Replace("http://", "")
                End If

                'check for www and none www, add both to hosts file for maximum effectiveness. 

                If blockurl.Contains("www.") Then
                    blockurl = blockurl & Environment.NewLine & blockurl.Replace("www.", "")
                Else
                    blockurl = blockurl & Environment.NewLine & "www." & blockurl
                End If

                Using writer As StreamWriter = File.AppendText(fm_main.sites_save_path)
                    writer.Write(blockurl & Environment.NewLine)
                    ' writer.Close() 'might be redundant
                End Using
                    MsgBox("Website added to block list.", vbInformation, "")
                    tb_blockSite.Clear()
                    tb_blockSite.Focus()
                    update_mainfm_blockedwebsites() 'update mainform list of blocked sites
                End If

        Catch ex As Exception
            MsgBox("An unexpected error occured, please close the window and tried again.", vbCritical, "")
        End Try

    End Sub

    Private Sub tb_blockSite_Click(sender As Object, e As EventArgs) Handles tb_blockSite.Click
        tb_blockSite.Clear()
    End Sub




    Public Sub update_mainfm_blockedwebsites()
        Dim blocked_websites As String
        Using reader As StreamReader = New StreamReader(fm_main.sites_save_path)
            blocked_websites = reader.ReadToEnd
        End Using
        fm_main.tb_blockedSites.Text = blocked_websites
    End Sub


    Private Sub tb_blockSite_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_blockSite.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_block.PerformClick()
        End If
    End Sub
End Class