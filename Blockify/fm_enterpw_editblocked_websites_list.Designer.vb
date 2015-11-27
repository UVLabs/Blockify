<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_enterpw_editblocked_websites_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_enterpw_editblocked_websites_list))
        Me.btn_enterPw_OK = New System.Windows.Forms.Button()
        Me.tb_enterPw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_enterPw_OK
        '
        Me.btn_enterPw_OK.Location = New System.Drawing.Point(76, 43)
        Me.btn_enterPw_OK.Name = "btn_enterPw_OK"
        Me.btn_enterPw_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_enterPw_OK.TabIndex = 6
        Me.btn_enterPw_OK.Text = "OK"
        Me.btn_enterPw_OK.UseVisualStyleBackColor = True
        '
        'tb_enterPw
        '
        Me.tb_enterPw.Location = New System.Drawing.Point(33, 12)
        Me.tb_enterPw.Name = "tb_enterPw"
        Me.tb_enterPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_enterPw.Size = New System.Drawing.Size(161, 20)
        Me.tb_enterPw.TabIndex = 5
        '
        'fm_enterpw_editblocked_websites_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 79)
        Me.Controls.Add(Me.btn_enterPw_OK)
        Me.Controls.Add(Me.tb_enterPw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(242, 118)
        Me.Name = "fm_enterpw_editblocked_websites_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_enterPw_OK As Button
    Friend WithEvents tb_enterPw As TextBox
End Class
