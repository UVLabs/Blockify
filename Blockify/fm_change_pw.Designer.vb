<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_change_pw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_change_pw))
        Me.tb_newPw = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.tb_currentPw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_newPw
        '
        Me.tb_newPw.Location = New System.Drawing.Point(24, 86)
        Me.tb_newPw.Name = "tb_newPw"
        Me.tb_newPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_newPw.Size = New System.Drawing.Size(190, 20)
        Me.tb_newPw.TabIndex = 3
        '
        'btn_save
        '
        Me.btn_save.Image = Global.Blockify.My.Resources.Resources.Save
        Me.btn_save.Location = New System.Drawing.Point(95, 116)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(43, 32)
        Me.btn_save.TabIndex = 4
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'tb_currentPw
        '
        Me.tb_currentPw.Location = New System.Drawing.Point(24, 35)
        Me.tb_currentPw.Name = "tb_currentPw"
        Me.tb_currentPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_currentPw.Size = New System.Drawing.Size(190, 20)
        Me.tb_currentPw.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New password"
        '
        'fm_change_pw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 158)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_currentPw)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tb_newPw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(252, 197)
        Me.Name = "fm_change_pw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_newPw As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents tb_currentPw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
