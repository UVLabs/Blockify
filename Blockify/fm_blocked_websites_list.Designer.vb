<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fm_blocked_websites_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_blocked_websites_list))
        Me.lb_blockedSites = New System.Windows.Forms.ListBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_removeSite = New System.Windows.Forms.Button()
        Me.btn_delAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_blockedSites
        '
        Me.lb_blockedSites.FormattingEnabled = True
        Me.lb_blockedSites.Location = New System.Drawing.Point(12, 12)
        Me.lb_blockedSites.MultiColumn = True
        Me.lb_blockedSites.Name = "lb_blockedSites"
        Me.lb_blockedSites.Size = New System.Drawing.Size(293, 134)
        Me.lb_blockedSites.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Enabled = False
        Me.btn_save.Image = Global.Blockify.My.Resources.Resources.Save
        Me.btn_save.Location = New System.Drawing.Point(202, 152)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(43, 43)
        Me.btn_save.TabIndex = 2
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_removeSite
        '
        Me.btn_removeSite.Image = Global.Blockify.My.Resources.Resources.Remove1
        Me.btn_removeSite.Location = New System.Drawing.Point(72, 152)
        Me.btn_removeSite.Name = "btn_removeSite"
        Me.btn_removeSite.Size = New System.Drawing.Size(43, 43)
        Me.btn_removeSite.TabIndex = 1
        Me.btn_removeSite.UseVisualStyleBackColor = True
        '
        'btn_delAll
        '
        Me.btn_delAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delAll.Location = New System.Drawing.Point(121, 152)
        Me.btn_delAll.Name = "btn_delAll"
        Me.btn_delAll.Size = New System.Drawing.Size(75, 43)
        Me.btn_delAll.TabIndex = 3
        Me.btn_delAll.Text = "Delete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All"
        Me.btn_delAll.UseVisualStyleBackColor = True
        '
        'fm_blocked_websites_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 201)
        Me.Controls.Add(Me.btn_delAll)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_removeSite)
        Me.Controls.Add(Me.lb_blockedSites)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(333, 240)
        Me.Name = "fm_blocked_websites_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unblock Websites"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb_blockedSites As ListBox
    Friend WithEvents btn_removeSite As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_delAll As Button
End Class
