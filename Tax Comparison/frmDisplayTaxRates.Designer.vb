<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayTaxRates
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"France", "20% - 50%"}, -1)
        Me.lsvTaxRates = New System.Windows.Forms.ListView()
        Me.colCountries = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTaxRates = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvTaxRates
        '
        Me.lsvTaxRates.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCountries, Me.colTaxRates})
        Me.lsvTaxRates.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvTaxRates.FullRowSelect = True
        Me.lsvTaxRates.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lsvTaxRates.Location = New System.Drawing.Point(84, 104)
        Me.lsvTaxRates.Name = "lsvTaxRates"
        Me.lsvTaxRates.Size = New System.Drawing.Size(326, 246)
        Me.lsvTaxRates.TabIndex = 0
        Me.lsvTaxRates.UseCompatibleStateImageBehavior = False
        Me.lsvTaxRates.View = System.Windows.Forms.View.Details
        '
        'colCountries
        '
        Me.colCountries.Text = "Country"
        Me.colCountries.Width = 195
        '
        'colTaxRates
        '
        Me.colTaxRates.Text = "Tax Rate"
        Me.colTaxRates.Width = 109
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitle.Location = New System.Drawing.Point(17, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(460, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Tax Rates from Various Countries"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkRed
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(142, 384)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(210, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmDisplayTaxRates
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(495, 454)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lsvTaxRates)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDisplayTaxRates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tax Rates in Various Countries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvTaxRates As ListView
    Friend WithEvents colCountries As ColumnHeader
    Friend WithEvents colTaxRates As ColumnHeader
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
End Class
