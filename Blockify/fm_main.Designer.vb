<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_main))
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockSitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockedWebsitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pb_status = New System.Windows.Forms.PictureBox()
        Me.btn_unblock = New System.Windows.Forms.Button()
        Me.btn_savePw = New System.Windows.Forms.Button()
        Me.lbl_enterPw = New System.Windows.Forms.Label()
        Me.tb_savePw = New System.Windows.Forms.TextBox()
        Me.btn_block = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tb_blockedSites = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pb_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(140, 8)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Status"
        Me.lbl_status.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(317, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlockSitesToolStripMenuItem, Me.ToolStripMenuItem1, Me.BlockedWebsitesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FileToolStripMenuItem.Text = "&Actions"
        '
        'BlockSitesToolStripMenuItem
        '
        Me.BlockSitesToolStripMenuItem.Name = "BlockSitesToolStripMenuItem"
        Me.BlockSitesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BlockSitesToolStripMenuItem.Text = "Block a website"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem1.Text = "Edit block list"
        '
        'BlockedWebsitesToolStripMenuItem
        '
        Me.BlockedWebsitesToolStripMenuItem.Name = "BlockedWebsitesToolStripMenuItem"
        Me.BlockedWebsitesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BlockedWebsitesToolStripMenuItem.Text = "Change password"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(317, 177)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pb_status)
        Me.TabPage1.Controls.Add(Me.btn_unblock)
        Me.TabPage1.Controls.Add(Me.btn_savePw)
        Me.TabPage1.Controls.Add(Me.lbl_enterPw)
        Me.TabPage1.Controls.Add(Me.tb_savePw)
        Me.TabPage1.Controls.Add(Me.btn_block)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(309, 151)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Block"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pb_status
        '
        Me.pb_status.Image = Global.Blockify.My.Resources.Resources.Circle_Red
        Me.pb_status.Location = New System.Drawing.Point(14, 15)
        Me.pb_status.Name = "pb_status"
        Me.pb_status.Size = New System.Drawing.Size(32, 32)
        Me.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_status.TabIndex = 21
        Me.pb_status.TabStop = False
        '
        'btn_unblock
        '
        Me.btn_unblock.Image = Global.Blockify.My.Resources.Resources.unlock
        Me.btn_unblock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_unblock.Location = New System.Drawing.Point(161, 6)
        Me.btn_unblock.Name = "btn_unblock"
        Me.btn_unblock.Size = New System.Drawing.Size(76, 53)
        Me.btn_unblock.TabIndex = 20
        Me.btn_unblock.Text = "Unblock"
        Me.btn_unblock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_unblock.UseVisualStyleBackColor = True
        '
        'btn_savePw
        '
        Me.btn_savePw.Enabled = False
        Me.btn_savePw.Location = New System.Drawing.Point(108, 114)
        Me.btn_savePw.Name = "btn_savePw"
        Me.btn_savePw.Size = New System.Drawing.Size(106, 26)
        Me.btn_savePw.TabIndex = 17
        Me.btn_savePw.Text = "Save"
        Me.btn_savePw.UseVisualStyleBackColor = True
        Me.btn_savePw.Visible = False
        '
        'lbl_enterPw
        '
        Me.lbl_enterPw.AutoSize = True
        Me.lbl_enterPw.Location = New System.Drawing.Point(86, 72)
        Me.lbl_enterPw.Name = "lbl_enterPw"
        Me.lbl_enterPw.Size = New System.Drawing.Size(143, 13)
        Me.lbl_enterPw.TabIndex = 15
        Me.lbl_enterPw.Text = "Enter Initial Password Below:"
        Me.lbl_enterPw.Visible = False
        '
        'tb_savePw
        '
        Me.tb_savePw.Location = New System.Drawing.Point(78, 88)
        Me.tb_savePw.Name = "tb_savePw"
        Me.tb_savePw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_savePw.Size = New System.Drawing.Size(159, 20)
        Me.tb_savePw.TabIndex = 13
        Me.tb_savePw.Visible = False
        '
        'btn_block
        '
        Me.btn_block.Image = Global.Blockify.My.Resources.Resources.lock
        Me.btn_block.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_block.Location = New System.Drawing.Point(78, 6)
        Me.btn_block.Name = "btn_block"
        Me.btn_block.Size = New System.Drawing.Size(76, 53)
        Me.btn_block.TabIndex = 10
        Me.btn_block.Text = "Block"
        Me.btn_block.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_block.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tb_blockedSites)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(309, 151)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Blocked Websites"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tb_blockedSites
        '
        Me.tb_blockedSites.Cursor = System.Windows.Forms.Cursors.Default
        Me.tb_blockedSites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_blockedSites.Location = New System.Drawing.Point(3, 3)
        Me.tb_blockedSites.Multiline = True
        Me.tb_blockedSites.Name = "tb_blockedSites"
        Me.tb_blockedSites.ReadOnly = True
        Me.tb_blockedSites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_blockedSites.Size = New System.Drawing.Size(303, 145)
        Me.tb_blockedSites.TabIndex = 0
        '
        'fm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 201)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(333, 240)
        Me.MinimumSize = New System.Drawing.Size(333, 170)
        Me.Name = "fm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blockify"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pb_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_status As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlockSitesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlockedWebsitesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbl_enterPw As Label
    Friend WithEvents tb_savePw As TextBox
    Friend WithEvents btn_block As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tb_blockedSites As TextBox
    Friend WithEvents btn_savePw As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_unblock As Button
    Friend WithEvents pb_status As PictureBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
