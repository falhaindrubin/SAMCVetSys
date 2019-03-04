<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemRecords))
        Me.DgvItemListing = New System.Windows.Forms.DataGridView()
        Me.DgvListItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvListItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvListItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvListItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvListItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvListUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAddNewItem = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbItemTypeCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RbProducts = New System.Windows.Forms.RadioButton()
        Me.RbServices = New System.Windows.Forms.RadioButton()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.TxtSearchText = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRecordCount = New System.Windows.Forms.Label()
        CType(Me.DgvItemListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvItemListing
        '
        Me.DgvItemListing.AllowUserToAddRows = False
        Me.DgvItemListing.AllowUserToDeleteRows = False
        Me.DgvItemListing.AllowUserToOrderColumns = True
        Me.DgvItemListing.AllowUserToResizeRows = False
        Me.DgvItemListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvItemListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvItemListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvItemListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvListItemCode, Me.DgvListItemDescription, Me.DgvListItemTypeCode, Me.DgvListItemTypeDescription, Me.DgvListItemGroup, Me.DgvListUnitPrice})
        Me.DgvItemListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItemListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvItemListing.Name = "DgvItemListing"
        Me.DgvItemListing.ReadOnly = True
        Me.DgvItemListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvItemListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItemListing.Size = New System.Drawing.Size(979, 518)
        Me.DgvItemListing.TabIndex = 2
        '
        'DgvListItemCode
        '
        Me.DgvListItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvListItemCode.HeaderText = "ItemCode"
        Me.DgvListItemCode.Name = "DgvListItemCode"
        Me.DgvListItemCode.ReadOnly = True
        Me.DgvListItemCode.Width = 76
        '
        'DgvListItemDescription
        '
        Me.DgvListItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DgvListItemDescription.HeaderText = "ItemDescription"
        Me.DgvListItemDescription.Name = "DgvListItemDescription"
        Me.DgvListItemDescription.ReadOnly = True
        '
        'DgvListItemTypeCode
        '
        Me.DgvListItemTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvListItemTypeCode.HeaderText = "ItemTypeCode"
        Me.DgvListItemTypeCode.Name = "DgvListItemTypeCode"
        Me.DgvListItemTypeCode.ReadOnly = True
        Me.DgvListItemTypeCode.Width = 99
        '
        'DgvListItemTypeDescription
        '
        Me.DgvListItemTypeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvListItemTypeDescription.HeaderText = "ItemTypeDescription"
        Me.DgvListItemTypeDescription.Name = "DgvListItemTypeDescription"
        Me.DgvListItemTypeDescription.ReadOnly = True
        Me.DgvListItemTypeDescription.Width = 128
        '
        'DgvListItemGroup
        '
        Me.DgvListItemGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvListItemGroup.HeaderText = "ItemGroup"
        Me.DgvListItemGroup.Name = "DgvListItemGroup"
        Me.DgvListItemGroup.ReadOnly = True
        Me.DgvListItemGroup.Width = 81
        '
        'DgvListUnitPrice
        '
        Me.DgvListUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvListUnitPrice.HeaderText = "UnitPrice"
        Me.DgvListUnitPrice.Name = "DgvListUnitPrice"
        Me.DgvListUnitPrice.ReadOnly = True
        Me.DgvListUnitPrice.Width = 74
        '
        'PnlActionBar
        '
        Me.PnlActionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnAddNewItem)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(985, 68)
        Me.PnlActionBar.TabIndex = 73
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(741, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 60)
        Me.BtnPrint.TabIndex = 18
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(178, 32)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Item Records"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(921, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAddNewItem
        '
        Me.BtnAddNewItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNewItem.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewItem.BackgroundImage = CType(resources.GetObject("BtnAddNewItem.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAddNewItem.Location = New System.Drawing.Point(801, 4)
        Me.BtnAddNewItem.Name = "BtnAddNewItem"
        Me.BtnAddNewItem.Size = New System.Drawing.Size(60, 60)
        Me.BtnAddNewItem.TabIndex = 2
        Me.BtnAddNewItem.UseVisualStyleBackColor = False
        '
        'BtnReload
        '
        Me.BtnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(861, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 1
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbItemTypeCode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RbProducts)
        Me.GroupBox1.Controls.Add(Me.RbServices)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 101)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Products && Services"
        '
        'CmbItemTypeCode
        '
        Me.CmbItemTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemTypeCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbItemTypeCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItemTypeCode.FormattingEnabled = True
        Me.CmbItemTypeCode.Location = New System.Drawing.Point(70, 50)
        Me.CmbItemTypeCode.Name = "CmbItemTypeCode"
        Me.CmbItemTypeCode.Size = New System.Drawing.Size(277, 22)
        Me.CmbItemTypeCode.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Item Type"
        '
        'RbProducts
        '
        Me.RbProducts.AutoSize = True
        Me.RbProducts.Location = New System.Drawing.Point(94, 24)
        Me.RbProducts.Name = "RbProducts"
        Me.RbProducts.Size = New System.Drawing.Size(68, 18)
        Me.RbProducts.TabIndex = 8
        Me.RbProducts.Text = "Products"
        Me.RbProducts.UseVisualStyleBackColor = True
        '
        'RbServices
        '
        Me.RbServices.AutoSize = True
        Me.RbServices.Checked = True
        Me.RbServices.Location = New System.Drawing.Point(13, 24)
        Me.RbServices.Name = "RbServices"
        Me.RbServices.Size = New System.Drawing.Size(68, 18)
        Me.RbServices.TabIndex = 7
        Me.RbServices.TabStop = True
        Me.RbServices.Text = "Services"
        Me.RbServices.UseVisualStyleBackColor = True
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearchItem.BackgroundImage = CType(resources.GetObject("BtnSearchItem.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Location = New System.Drawing.Point(426, 31)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearchItem.TabIndex = 6
        Me.BtnSearchItem.UseVisualStyleBackColor = False
        '
        'TxtSearchText
        '
        Me.TxtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchText.Location = New System.Drawing.Point(19, 48)
        Me.TxtSearchText.Name = "TxtSearchText"
        Me.TxtSearchText.Size = New System.Drawing.Size(401, 26)
        Me.TxtSearchText.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvItemListing)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(985, 537)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service && Product Listing"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtSearchText)
        Me.GroupBox3.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox3.Location = New System.Drawing.Point(380, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 101)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Products && Services"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "e.g. : 01000001, BERENIL"
        '
        'LblRecordCount
        '
        Me.LblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRecordCount.AutoSize = True
        Me.LblRecordCount.Location = New System.Drawing.Point(903, 731)
        Me.LblRecordCount.Name = "LblRecordCount"
        Me.LblRecordCount.Size = New System.Drawing.Size(84, 14)
        Me.LblRecordCount.TabIndex = 78
        Me.LblRecordCount.Text = "LblRecordCount"
        Me.LblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmItemRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1009, 749)
        Me.Controls.Add(Me.LblRecordCount)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmItemRecords"
        Me.Text = "Item Records"
        CType(Me.DgvItemListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvItemListing As DataGridView
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAddNewItem As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents TxtSearchText As TextBox
    Friend WithEvents RbProducts As RadioButton
    Friend WithEvents RbServices As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents CmbItemTypeCode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvListItemCode As DataGridViewTextBoxColumn
    Friend WithEvents DgvListItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents DgvListItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents DgvListItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents DgvListItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents DgvListUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents LblRecordCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPrint As Button
End Class
