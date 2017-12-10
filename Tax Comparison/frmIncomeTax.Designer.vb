<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeTax
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.btnDisplayTaxRange = New System.Windows.Forms.Button()
        Me.picTax = New System.Windows.Forms.PictureBox()
        Me.lblTaxRangeLabel = New System.Windows.Forms.Label()
        Me.lblTaxRange = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayTaxForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitle.Location = New System.Drawing.Point(23, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(513, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Personal Income Tax Rate by Country"
        '
        'lstCountries
        '
        Me.lstCountries.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.ItemHeight = 22
        Me.lstCountries.Items.AddRange(New Object() {"France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Spain", "South Afica", "United Kingdom"})
        Me.lstCountries.Location = New System.Drawing.Point(159, 89)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(241, 224)
        Me.lstCountries.TabIndex = 1
        '
        'btnDisplayTaxRange
        '
        Me.btnDisplayTaxRange.BackColor = System.Drawing.Color.DarkRed
        Me.btnDisplayTaxRange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayTaxRange.ForeColor = System.Drawing.Color.White
        Me.btnDisplayTaxRange.Location = New System.Drawing.Point(174, 319)
        Me.btnDisplayTaxRange.Name = "btnDisplayTaxRange"
        Me.btnDisplayTaxRange.Size = New System.Drawing.Size(210, 35)
        Me.btnDisplayTaxRange.TabIndex = 2
        Me.btnDisplayTaxRange.Text = "Display Tax Range"
        Me.btnDisplayTaxRange.UseVisualStyleBackColor = False
        '
        'picTax
        '
        Me.picTax.Image = Global.Tax_Comparison.My.Resources.Resources.Tax
        Me.picTax.Location = New System.Drawing.Point(264, 329)
        Me.picTax.Name = "picTax"
        Me.picTax.Size = New System.Drawing.Size(295, 152)
        Me.picTax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTax.TabIndex = 3
        Me.picTax.TabStop = False
        '
        'lblTaxRangeLabel
        '
        Me.lblTaxRangeLabel.AutoSize = True
        Me.lblTaxRangeLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxRangeLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTaxRangeLabel.Location = New System.Drawing.Point(38, 396)
        Me.lblTaxRangeLabel.Name = "lblTaxRangeLabel"
        Me.lblTaxRangeLabel.Size = New System.Drawing.Size(168, 24)
        Me.lblTaxRangeLabel.TabIndex = 4
        Me.lblTaxRangeLabel.Text = "Tax Rate Range"
        Me.lblTaxRangeLabel.Visible = False
        '
        'lblTaxRange
        '
        Me.lblTaxRange.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxRange.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTaxRange.Location = New System.Drawing.Point(41, 432)
        Me.lblTaxRange.Name = "lblTaxRange"
        Me.lblTaxRange.Size = New System.Drawing.Size(159, 21)
        Me.lblTaxRange.TabIndex = 5
        Me.lblTaxRange.Text = "20% - 56% tax"
        Me.lblTaxRange.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayTaxForm, Me.mnuClear, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplayTaxForm
        '
        Me.mnuDisplayTaxForm.Name = "mnuDisplayTaxForm"
        Me.mnuDisplayTaxForm.Size = New System.Drawing.Size(287, 22)
        Me.mnuDisplayTaxForm.Text = "&Display Tax Rates from Various Countries"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(287, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(284, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(287, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'frmIncomeTax
        '
        Me.AcceptButton = Me.btnDisplayTaxRange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 493)
        Me.Controls.Add(Me.lstCountries)
        Me.Controls.Add(Me.btnDisplayTaxRange)
        Me.Controls.Add(Me.lblTaxRange)
        Me.Controls.Add(Me.lblTaxRangeLabel)
        Me.Controls.Add(Me.picTax)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmIncomeTax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparison of Individual Tax Rates by Country"
        CType(Me.picTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents btnDisplayTaxRange As Button
    Friend WithEvents picTax As PictureBox
    Friend WithEvents lblTaxRangeLabel As Label
    Friend WithEvents lblTaxRange As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplayTaxForm As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
