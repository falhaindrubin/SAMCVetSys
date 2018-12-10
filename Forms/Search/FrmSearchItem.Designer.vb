<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSearchItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearchItem))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbItemTypeDescription = New System.Windows.Forms.ComboBox()
        Me.RbProducts = New System.Windows.Forms.RadioButton()
        Me.RbServices = New System.Windows.Forms.RadioButton()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.DgvSearchResult = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(743, 68)
        Me.PnlActionBar.TabIndex = 73
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(162, 32)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Search Item"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(679, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(550, 63)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbItemTypeDescription)
        Me.GroupBox1.Controls.Add(Me.RbProducts)
        Me.GroupBox1.Controls.Add(Me.RbServices)
        Me.GroupBox1.Controls.Add(Me.TxtSearchText)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 131)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'CmbItemTypeDescription
        '
        Me.CmbItemTypeDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemTypeDescription.FormattingEnabled = True
        Me.CmbItemTypeDescription.Location = New System.Drawing.Point(15, 53)
        Me.CmbItemTypeDescription.Name = "CmbItemTypeDescription"
        Me.CmbItemTypeDescription.Size = New System.Drawing.Size(268, 22)
        Me.CmbItemTypeDescription.TabIndex = 5
        '
        'RbProducts
        '
        Me.RbProducts.AutoSize = True
        Me.RbProducts.Location = New System.Drawing.Point(95, 31)
        Me.RbProducts.Name = "RbProducts"
        Me.RbProducts.Size = New System.Drawing.Size(68, 18)
        Me.RbProducts.TabIndex = 4
        Me.RbProducts.Text = "Products"
        Me.RbProducts.UseVisualStyleBackColor = True
        '
        'RbServices
        '
        Me.RbServices.AutoSize = True
        Me.RbServices.Checked = True
        Me.RbServices.Location = New System.Drawing.Point(15, 31)
        Me.RbServices.Name = "RbServices"
        Me.RbServices.Size = New System.Drawing.Size(68, 18)
        Me.RbServices.TabIndex = 3
        Me.RbServices.TabStop = True
        Me.RbServices.Text = "Services"
        Me.RbServices.UseVisualStyleBackColor = True
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BackColor = System.Drawing.Color.White
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(15, 81)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(529, 25)
        Me.TxtSearchText.TabIndex = 1
        '
        'DgvSearchResult
        '
        Me.DgvSearchResult.AllowUserToAddRows = False
        Me.DgvSearchResult.AllowUserToOrderColumns = True
        Me.DgvSearchResult.AllowUserToResizeRows = False
        Me.DgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvSearchResult.BackgroundColor = System.Drawing.Color.White
        Me.DgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSearchResult.Location = New System.Drawing.Point(12, 221)
        Me.DgvSearchResult.MultiSelect = False
        Me.DgvSearchResult.Name = "DgvSearchResult"
        Me.DgvSearchResult.ReadOnly = True
        Me.DgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSearchResult.Size = New System.Drawing.Size(743, 386)
        Me.DgvSearchResult.TabIndex = 74
        '
        'FrmSearchItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 619)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvSearchResult)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmSearchItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Item"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents DgvSearchResult As DataGridView
    Friend WithEvents RbProducts As RadioButton
    Friend WithEvents RbServices As RadioButton
    Friend WithEvents CmbItemTypeDescription As ComboBox
    Friend WithEvents Label25 As Label
End Class
