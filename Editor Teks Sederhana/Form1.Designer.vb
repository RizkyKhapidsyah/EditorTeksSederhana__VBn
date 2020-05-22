<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBaru = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileBuka = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSimpan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSimpanSbg = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpTentang = New System.Windows.Forms.ToolStripMenuItem()
        Me.teksDokumen = New System.Windows.Forms.TextBox()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBaru, Me.mnuFileBuka, Me.mnuSimpan, Me.mnuSimpanSbg, Me.ToolStripSeparator1, Me.mnuKeluar})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuBaru
        '
        Me.mnuBaru.Name = "mnuBaru"
        Me.mnuBaru.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBaru.Size = New System.Drawing.Size(174, 22)
        Me.mnuBaru.Text = "&Baru"
        '
        'mnuFileBuka
        '
        Me.mnuFileBuka.Name = "mnuFileBuka"
        Me.mnuFileBuka.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuFileBuka.Size = New System.Drawing.Size(174, 22)
        Me.mnuFileBuka.Text = "B&uka"
        '
        'mnuSimpan
        '
        Me.mnuSimpan.Name = "mnuSimpan"
        Me.mnuSimpan.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSimpan.Size = New System.Drawing.Size(174, 22)
        Me.mnuSimpan.Text = "&Simpan"
        '
        'mnuSimpanSbg
        '
        Me.mnuSimpanSbg.Name = "mnuSimpanSbg"
        Me.mnuSimpanSbg.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuSimpanSbg.Size = New System.Drawing.Size(174, 22)
        Me.mnuSimpanSbg.Text = "S&impan Sbg"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'mnuKeluar
        '
        Me.mnuKeluar.Name = "mnuKeluar"
        Me.mnuKeluar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuKeluar.Size = New System.Drawing.Size(174, 22)
        Me.mnuKeluar.Text = "&Keluar"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpTentang})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpTentang
        '
        Me.mnuHelpTentang.Name = "mnuHelpTentang"
        Me.mnuHelpTentang.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpTentang.Text = "&Tentang"
        '
        'teksDokumen
        '
        Me.teksDokumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.teksDokumen.Location = New System.Drawing.Point(8, 28)
        Me.teksDokumen.Multiline = True
        Me.teksDokumen.Name = "teksDokumen"
        Me.teksDokumen.Size = New System.Drawing.Size(453, 307)
        Me.teksDokumen.TabIndex = 1
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        Me.ofdOpenFile.Filter = "File Teks (*.txt)| *.txt"
        Me.ofdOpenFile.Title = "Buka File"
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Filter = "File Teks (*.txt)| *.txt"
        Me.sfdSaveFile.Title = "Simpan File"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 337)
        Me.Controls.Add(Me.teksDokumen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Editor Teks Sederhana"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBaru As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileBuka As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSimpan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSimpanSbg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpTentang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents teksDokumen As System.Windows.Forms.TextBox
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog

End Class
