<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_blockSites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_blockSites))
        Me.tb_blockSite = New System.Windows.Forms.TextBox()
        Me.btn_block = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_blockSite
        '
        Me.tb_blockSite.Location = New System.Drawing.Point(44, 48)
        Me.tb_blockSite.Name = "tb_blockSite"
        Me.tb_blockSite.Size = New System.Drawing.Size(196, 20)
        Me.tb_blockSite.TabIndex = 0
        '
        'btn_block
        '
        Me.btn_block.Location = New System.Drawing.Point(105, 74)
        Me.btn_block.Name = "btn_block"
        Me.btn_block.Size = New System.Drawing.Size(75, 23)
        Me.btn_block.TabIndex = 1
        Me.btn_block.Text = "Block"
        Me.btn_block.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter a website to block then click ""block"":"
        '
        'fm_blockSites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 109)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_block)
        Me.Controls.Add(Me.tb_blockSite)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fm_blockSites"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blockify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_blockSite As TextBox
    Friend WithEvents btn_block As Button
    Friend WithEvents Label1 As Label
End Class
