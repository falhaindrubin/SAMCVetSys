<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSurgeryManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSurgeryManagement))
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.DgvFixedSxMaterials = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMaterialPrescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtMaterialNotes = New System.Windows.Forms.TextBox()
        Me.LblRowNo = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BtnAddMaterialItem = New System.Windows.Forms.Button()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtMaterialUnitPrice = New System.Windows.Forms.TextBox()
        Me.TxtMaterialItem = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtMaterialQuantity = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtMaterialTotalPrice = New System.Windows.Forms.TextBox()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvCbSelectItem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SxMaterialsRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsPrescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SxMaterialsItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox34.SuspendLayout()
        CType(Me.DgvFixedSxMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox34
        '
        Me.GroupBox34.Controls.Add(Me.DgvFixedSxMaterials)
        Me.GroupBox34.Location = New System.Drawing.Point(573, 6)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(589, 566)
        Me.GroupBox34.TabIndex = 196
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "Surgery Materials"
        '
        'DgvFixedSxMaterials
        '
        Me.DgvFixedSxMaterials.AllowUserToAddRows = False
        Me.DgvFixedSxMaterials.AllowUserToDeleteRows = False
        Me.DgvFixedSxMaterials.BackgroundColor = System.Drawing.Color.White
        Me.DgvFixedSxMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFixedSxMaterials.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvCbSelectItem, Me.DataGridViewButtonColumn1, Me.DataGridViewButtonColumn2, Me.SxMaterialsRowNo, Me.SxMaterialsItemCode, Me.SxMaterialsItemDescription, Me.SxMaterialsPrescription, Me.SxMaterialsNotes, Me.SxMaterialsUnitPrice, Me.SxMaterialsQuantity, Me.SxMaterialsTotalPrice, Me.SxMaterialsItemGroup, Me.SxMaterialsItemTypeCode, Me.SxMaterialsItemTypeDescription})
        Me.DgvFixedSxMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFixedSxMaterials.Location = New System.Drawing.Point(3, 16)
        Me.DgvFixedSxMaterials.Name = "DgvFixedSxMaterials"
        Me.DgvFixedSxMaterials.ReadOnly = True
        Me.DgvFixedSxMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFixedSxMaterials.Size = New System.Drawing.Size(583, 547)
        Me.DgvFixedSxMaterials.TabIndex = 172
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtMaterialPrescription)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtMaterialNotes)
        Me.GroupBox1.Controls.Add(Me.LblRowNo)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.BtnAddMaterialItem)
        Me.GroupBox1.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TxtMaterialUnitPrice)
        Me.GroupBox1.Controls.Add(Me.TxtMaterialItem)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TxtMaterialQuantity)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.TxtMaterialTotalPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 566)
        Me.GroupBox1.TabIndex = 195
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Prescription"
        '
        'TxtMaterialPrescription
        '
        Me.TxtMaterialPrescription.BackColor = System.Drawing.Color.White
        Me.TxtMaterialPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMaterialPrescription.Enabled = False
        Me.TxtMaterialPrescription.Location = New System.Drawing.Point(75, 50)
        Me.TxtMaterialPrescription.Multiline = True
        Me.TxtMaterialPrescription.Name = "TxtMaterialPrescription"
        Me.TxtMaterialPrescription.Size = New System.Drawing.Size(370, 46)
        Me.TxtMaterialPrescription.TabIndex = 194
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 14)
        Me.Label10.TabIndex = 195
        Me.Label10.Text = "Notes"
        '
        'TxtMaterialNotes
        '
        Me.TxtMaterialNotes.BackColor = System.Drawing.Color.White
        Me.TxtMaterialNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMaterialNotes.Location = New System.Drawing.Point(75, 97)
        Me.TxtMaterialNotes.Multiline = True
        Me.TxtMaterialNotes.Name = "TxtMaterialNotes"
        Me.TxtMaterialNotes.Size = New System.Drawing.Size(370, 49)
        Me.TxtMaterialNotes.TabIndex = 196
        '
        'LblRowNo
        '
        Me.LblRowNo.AutoSize = True
        Me.LblRowNo.Location = New System.Drawing.Point(133, 151)
        Me.LblRowNo.Name = "LblRowNo"
        Me.LblRowNo.Size = New System.Drawing.Size(43, 14)
        Me.LblRowNo.TabIndex = 192
        Me.LblRowNo.Text = "RowNo"
        Me.LblRowNo.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(10, 30)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(26, 14)
        Me.Label39.TabIndex = 176
        Me.Label39.Text = "Item"
        '
        'BtnAddMaterialItem
        '
        Me.BtnAddMaterialItem.Location = New System.Drawing.Point(75, 213)
        Me.BtnAddMaterialItem.Name = "BtnAddMaterialItem"
        Me.BtnAddMaterialItem.Size = New System.Drawing.Size(121, 27)
        Me.BtnAddMaterialItem.TabIndex = 172
        Me.BtnAddMaterialItem.Text = "Add Item..."
        Me.BtnAddMaterialItem.UseVisualStyleBackColor = True
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(445, 26)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 29)
        Me.BtnSearchItem.TabIndex = 178
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(479, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 29)
        Me.Button3.TabIndex = 179
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtMaterialUnitPrice
        '
        Me.TxtMaterialUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtMaterialUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMaterialUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterialUnitPrice.Location = New System.Drawing.Point(75, 147)
        Me.TxtMaterialUnitPrice.Name = "TxtMaterialUnitPrice"
        Me.TxtMaterialUnitPrice.ReadOnly = True
        Me.TxtMaterialUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtMaterialUnitPrice.TabIndex = 175
        Me.TxtMaterialUnitPrice.Text = "0.00"
        Me.TxtMaterialUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMaterialItem
        '
        Me.TxtMaterialItem.BackColor = System.Drawing.Color.Beige
        Me.TxtMaterialItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMaterialItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterialItem.Location = New System.Drawing.Point(75, 29)
        Me.TxtMaterialItem.Name = "TxtMaterialItem"
        Me.TxtMaterialItem.ReadOnly = True
        Me.TxtMaterialItem.Size = New System.Drawing.Size(370, 20)
        Me.TxtMaterialItem.TabIndex = 177
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 192)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 14)
        Me.Label23.TabIndex = 182
        Me.Label23.Text = "Total Price"
        '
        'TxtMaterialQuantity
        '
        Me.TxtMaterialQuantity.BackColor = System.Drawing.Color.White
        Me.TxtMaterialQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMaterialQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterialQuantity.Location = New System.Drawing.Point(75, 168)
        Me.TxtMaterialQuantity.Name = "TxtMaterialQuantity"
        Me.TxtMaterialQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtMaterialQuantity.TabIndex = 181
        Me.TxtMaterialQuantity.Text = "1.00"
        Me.TxtMaterialQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(10, 150)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(52, 14)
        Me.Label40.TabIndex = 174
        Me.Label40.Text = "Unit Price"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 172)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 14)
        Me.Label24.TabIndex = 180
        Me.Label24.Text = "Quantity"
        '
        'TxtMaterialTotalPrice
        '
        Me.TxtMaterialTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtMaterialTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMaterialTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterialTotalPrice.Location = New System.Drawing.Point(75, 189)
        Me.TxtMaterialTotalPrice.Name = "TxtMaterialTotalPrice"
        Me.TxtMaterialTotalPrice.ReadOnly = True
        Me.TxtMaterialTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtMaterialTotalPrice.TabIndex = 183
        Me.TxtMaterialTotalPrice.Text = "0.00"
        Me.TxtMaterialTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnSearch)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(1176, 68)
        Me.PnlActionBar.TabIndex = 197
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(276, 32)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Surgery Management"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(807, 4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(868, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 60)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(1112, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(990, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 60)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Location = New System.Drawing.Point(1051, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 60)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(929, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 87)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1176, 605)
        Me.TabControl1.TabIndex = 198
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox34)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1168, 578)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Surgery Materials"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DgvCbSelectItem
        '
        Me.DgvCbSelectItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvCbSelectItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DgvCbSelectItem.HeaderText = ""
        Me.DgvCbSelectItem.Name = "DgvCbSelectItem"
        Me.DgvCbSelectItem.ReadOnly = True
        Me.DgvCbSelectItem.ToolTipText = "Select Item"
        Me.DgvCbSelectItem.Visible = False
        Me.DgvCbSelectItem.Width = 5
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewButtonColumn1.HeaderText = "Delete?"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Delete"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 49
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewButtonColumn2.HeaderText = "Edit"
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.ReadOnly = True
        Me.DataGridViewButtonColumn2.Text = "Edit"
        Me.DataGridViewButtonColumn2.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn2.Visible = False
        Me.DataGridViewButtonColumn2.Width = 30
        '
        'SxMaterialsRowNo
        '
        Me.SxMaterialsRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsRowNo.HeaderText = "No."
        Me.SxMaterialsRowNo.Name = "SxMaterialsRowNo"
        Me.SxMaterialsRowNo.ReadOnly = True
        Me.SxMaterialsRowNo.Width = 48
        '
        'SxMaterialsItemCode
        '
        Me.SxMaterialsItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsItemCode.HeaderText = "Item Code"
        Me.SxMaterialsItemCode.Name = "SxMaterialsItemCode"
        Me.SxMaterialsItemCode.ReadOnly = True
        Me.SxMaterialsItemCode.Width = 79
        '
        'SxMaterialsItemDescription
        '
        Me.SxMaterialsItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SxMaterialsItemDescription.HeaderText = "Item Description"
        Me.SxMaterialsItemDescription.Name = "SxMaterialsItemDescription"
        Me.SxMaterialsItemDescription.ReadOnly = True
        '
        'SxMaterialsPrescription
        '
        Me.SxMaterialsPrescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SxMaterialsPrescription.HeaderText = "Prescription"
        Me.SxMaterialsPrescription.Name = "SxMaterialsPrescription"
        Me.SxMaterialsPrescription.ReadOnly = True
        Me.SxMaterialsPrescription.Visible = False
        '
        'SxMaterialsNotes
        '
        Me.SxMaterialsNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SxMaterialsNotes.HeaderText = "Notes"
        Me.SxMaterialsNotes.Name = "SxMaterialsNotes"
        Me.SxMaterialsNotes.ReadOnly = True
        Me.SxMaterialsNotes.Visible = False
        '
        'SxMaterialsUnitPrice
        '
        Me.SxMaterialsUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsUnitPrice.HeaderText = "Unit Price"
        Me.SxMaterialsUnitPrice.Name = "SxMaterialsUnitPrice"
        Me.SxMaterialsUnitPrice.ReadOnly = True
        Me.SxMaterialsUnitPrice.Visible = False
        Me.SxMaterialsUnitPrice.Width = 77
        '
        'SxMaterialsQuantity
        '
        Me.SxMaterialsQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsQuantity.HeaderText = "Quantity"
        Me.SxMaterialsQuantity.Name = "SxMaterialsQuantity"
        Me.SxMaterialsQuantity.ReadOnly = True
        Me.SxMaterialsQuantity.Visible = False
        Me.SxMaterialsQuantity.Width = 72
        '
        'SxMaterialsTotalPrice
        '
        Me.SxMaterialsTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsTotalPrice.HeaderText = "Total Price"
        Me.SxMaterialsTotalPrice.Name = "SxMaterialsTotalPrice"
        Me.SxMaterialsTotalPrice.ReadOnly = True
        Me.SxMaterialsTotalPrice.Visible = False
        Me.SxMaterialsTotalPrice.Width = 81
        '
        'SxMaterialsItemGroup
        '
        Me.SxMaterialsItemGroup.HeaderText = "Item Group"
        Me.SxMaterialsItemGroup.Name = "SxMaterialsItemGroup"
        Me.SxMaterialsItemGroup.ReadOnly = True
        Me.SxMaterialsItemGroup.Visible = False
        '
        'SxMaterialsItemTypeCode
        '
        Me.SxMaterialsItemTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsItemTypeCode.HeaderText = "Item Type Code"
        Me.SxMaterialsItemTypeCode.Name = "SxMaterialsItemTypeCode"
        Me.SxMaterialsItemTypeCode.ReadOnly = True
        Me.SxMaterialsItemTypeCode.Visible = False
        Me.SxMaterialsItemTypeCode.Width = 105
        '
        'SxMaterialsItemTypeDescription
        '
        Me.SxMaterialsItemTypeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SxMaterialsItemTypeDescription.HeaderText = "Item Type Description"
        Me.SxMaterialsItemTypeDescription.Name = "SxMaterialsItemTypeDescription"
        Me.SxMaterialsItemTypeDescription.ReadOnly = True
        Me.SxMaterialsItemTypeDescription.Visible = False
        Me.SxMaterialsItemTypeDescription.Width = 134
        '
        'FrmSurgeryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 704)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmSurgeryManagement"
        Me.Text = "Surgery Management"
        Me.GroupBox34.ResumeLayout(False)
        CType(Me.DgvFixedSxMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox34 As GroupBox
    Friend WithEvents DgvFixedSxMaterials As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMaterialPrescription As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtMaterialNotes As TextBox
    Friend WithEvents LblRowNo As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents BtnAddMaterialItem As Button
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtMaterialUnitPrice As TextBox
    Friend WithEvents TxtMaterialItem As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtMaterialQuantity As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtMaterialTotalPrice As TextBox
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DgvCbSelectItem As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents SxMaterialsRowNo As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsItemCode As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsPrescription As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsNotes As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsQuantity As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents SxMaterialsItemTypeDescription As DataGridViewTextBoxColumn
End Class
