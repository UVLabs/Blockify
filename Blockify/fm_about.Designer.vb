<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_about))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDev = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.llvisitWebsite = New System.Windows.Forms.LinkLabel()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blockify Website Blocker"
        '
        'lblDev
        '
        Me.lblDev.AutoSize = True
        Me.lblDev.Location = New System.Drawing.Point(38, 67)
        Me.lblDev.Name = "lblDev"
        Me.lblDev.Size = New System.Drawing.Size(59, 13)
        Me.lblDev.TabIndex = 1
        Me.lblDev.Text = "Developer:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(103, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Uriahs Victor"
        '
        'llvisitWebsite
        '
        Me.llvisitWebsite.AutoSize = True
        Me.llvisitWebsite.Location = New System.Drawing.Point(103, 93)
        Me.llvisitWebsite.Name = "llvisitWebsite"
        Me.llvisitWebsite.Size = New System.Drawing.Size(68, 13)
        Me.llvisitWebsite.TabIndex = 19
        Me.llvisitWebsite.TabStop = True
        Me.llvisitWebsite.Text = "Visit Website"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(38, 93)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(49, 13)
        Me.lblWebsite.TabIndex = 18
        Me.lblWebsite.Text = "Website:"
        '
        'fm_about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(277, 145)
        Me.Controls.Add(Me.llvisitWebsite)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDev)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fm_about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Blockify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDev As Label
    Friend WithEvents lblName As Label
    Friend WithEvents llvisitWebsite As LinkLabel
    Friend WithEvents lblWebsite As Label
End Class
