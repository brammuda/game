<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tampilanUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.timerMa = New System.Windows.Forms.Timer(Me.components)
        Me.timerMund = New System.Windows.Forms.Timer(Me.components)
        Me.tombolMain = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PermainanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturUlangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaraMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermainanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mund = New System.Windows.Forms.PictureBox()
        Me.ma = New System.Windows.Forms.PictureBox()
        Me.latar = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.latar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 320)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(1028, 22)
        Me.HScrollBar1.TabIndex = 0
        '
        'timerMa
        '
        Me.timerMa.Interval = 10
        '
        'timerMund
        '
        Me.timerMund.Interval = 10
        '
        'tombolMain
        '
        Me.tombolMain.Location = New System.Drawing.Point(324, 360)
        Me.tombolMain.Name = "tombolMain"
        Me.tombolMain.Size = New System.Drawing.Size(190, 63)
        Me.tombolMain.TabIndex = 31
        Me.tombolMain.Text = "acak"
        Me.tombolMain.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermainanToolStripMenuItem, Me.TentangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PermainanToolStripMenuItem
        '
        Me.PermainanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AturUlangToolStripMenuItem})
        Me.PermainanToolStripMenuItem.Name = "PermainanToolStripMenuItem"
        Me.PermainanToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.PermainanToolStripMenuItem.Text = "Permainan"
        '
        'AturUlangToolStripMenuItem
        '
        Me.AturUlangToolStripMenuItem.Name = "AturUlangToolStripMenuItem"
        Me.AturUlangToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AturUlangToolStripMenuItem.Text = "Atur Ulang"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaraMainToolStripMenuItem, Me.PermainanToolStripMenuItem1, Me.ProgrammerToolStripMenuItem})
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'CaraMainToolStripMenuItem
        '
        Me.CaraMainToolStripMenuItem.Name = "CaraMainToolStripMenuItem"
        Me.CaraMainToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CaraMainToolStripMenuItem.Text = "Cara main"
        '
        'PermainanToolStripMenuItem1
        '
        Me.PermainanToolStripMenuItem1.Name = "PermainanToolStripMenuItem1"
        Me.PermainanToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.PermainanToolStripMenuItem1.Text = "About Program"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ProgrammerToolStripMenuItem.Text = "Profile"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(324, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 76)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'mund
        '
        Me.mund.Image = Global.WindowsApplication1.My.Resources.Resources.mund
        Me.mund.Location = New System.Drawing.Point(20, 245)
        Me.mund.Name = "mund"
        Me.mund.Size = New System.Drawing.Size(42, 41)
        Me.mund.TabIndex = 14
        Me.mund.TabStop = False
        '
        'ma
        '
        Me.ma.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ma.Image = Global.WindowsApplication1.My.Resources.Resources.ma
        Me.ma.Location = New System.Drawing.Point(20, 148)
        Me.ma.Name = "ma"
        Me.ma.Size = New System.Drawing.Size(42, 42)
        Me.ma.TabIndex = 9
        Me.ma.TabStop = False
        Me.ma.UseWaitCursor = True
        '
        'latar
        '
        Me.latar.BackColor = System.Drawing.Color.Transparent
        Me.latar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.latar.Image = Global.WindowsApplication1.My.Resources.Resources.bg3_ASLI
        Me.latar.Location = New System.Drawing.Point(0, 117)
        Me.latar.Name = "latar"
        Me.latar.Size = New System.Drawing.Size(2823, 200)
        Me.latar.TabIndex = 0
        Me.latar.TabStop = False
        '
        'tampilanUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ggt_copy
        Me.ClientSize = New System.Drawing.Size(1028, 582)
        Me.Controls.Add(Me.tombolMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.mund)
        Me.Controls.Add(Me.ma)
        Me.Controls.Add(Me.latar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "tampilanUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Petualangan Mamund"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.latar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents latar As System.Windows.Forms.PictureBox
    Friend WithEvents ma As System.Windows.Forms.PictureBox
    Friend WithEvents mund As System.Windows.Forms.PictureBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents timerMa As System.Windows.Forms.Timer
    Friend WithEvents timerMund As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tombolMain As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PermainanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AturUlangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaraMainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermainanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgrammerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
