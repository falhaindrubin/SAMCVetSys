<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTreatmentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTreatmentInformation))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtDxCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtDxDateModified = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtDxDateCreated = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtDxModifiedBy = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvSelectedTest = New System.Windows.Forms.DataGridView()
        Me.BtnTestDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TestRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnSearchTestItem = New System.Windows.Forms.Button()
        Me.BtnAddTest = New System.Windows.Forms.Button()
        Me.TxtTestTotalPrice = New System.Windows.Forms.TextBox()
        Me.TxtTestUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTestQuantity = New System.Windows.Forms.TextBox()
        Me.TxtTestItem = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtTxCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtTxDateModified = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTxDateCreated = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTxModifiedBy = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DgvSelectedTreatment = New System.Windows.Forms.DataGridView()
        Me.BtnTreatmentDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DgvBtnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TreatmentPhRequestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentPrescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnSendToPharmacy = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblRowNo = New System.Windows.Forms.Label()
        Me.TxtTreatmentTotalPrice = New System.Windows.Forms.TextBox()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtTreatmentUnitPrice = New System.Windows.Forms.TextBox()
        Me.BtnClearItem = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtTreatmentItem = New System.Windows.Forms.TextBox()
        Me.TxtTreatmentQuantity = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnAddTreatment = New System.Windows.Forms.Button()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.TxtVisitID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBillPayment = New System.Windows.Forms.Button()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtVet = New System.Windows.Forms.TextBox()
        Me.LblInvoiceNo = New System.Windows.Forms.Label()
        Me.CbIsAdmittedToWard = New System.Windows.Forms.CheckBox()
        Me.TxtVisitTime = New System.Windows.Forms.TextBox()
        Me.PnlActionBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(750, 68)
        Me.PnlActionBar.TabIndex = 85
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(280, 32)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Treatment Information"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(381, 4)
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
        Me.BtnPrint.Location = New System.Drawing.Point(442, 4)
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
        Me.BtnClose.Location = New System.Drawing.Point(686, 4)
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
        Me.BtnCancel.Location = New System.Drawing.Point(564, 4)
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
        Me.BtnEdit.Location = New System.Drawing.Point(625, 4)
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
        Me.BtnSave.Location = New System.Drawing.Point(503, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 189)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 535)
        Me.TabControl1.TabIndex = 86
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Diagnosis & Tests"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtDxCreatedBy)
        Me.Panel3.Controls.Add(Me.TxtDxDateModified)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.TxtDxDateCreated)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.TxtDxModifiedBy)
        Me.Panel3.Location = New System.Drawing.Point(6, 443)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 57)
        Me.Panel3.TabIndex = 174
        '
        'TxtDxCreatedBy
        '
        Me.TxtDxCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtDxCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDxCreatedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDxCreatedBy.Location = New System.Drawing.Point(76, 8)
        Me.TxtDxCreatedBy.Name = "TxtDxCreatedBy"
        Me.TxtDxCreatedBy.ReadOnly = True
        Me.TxtDxCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtDxCreatedBy.TabIndex = 74
        '
        'TxtDxDateModified
        '
        Me.TxtDxDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDxDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDxDateModified.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDxDateModified.Location = New System.Drawing.Point(142, 29)
        Me.TxtDxDateModified.Name = "TxtDxDateModified"
        Me.TxtDxDateModified.ReadOnly = True
        Me.TxtDxDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtDxDateModified.TabIndex = 78
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 14)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Created By"
        '
        'TxtDxDateCreated
        '
        Me.TxtDxDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDxDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDxDateCreated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDxDateCreated.Location = New System.Drawing.Point(142, 8)
        Me.TxtDxDateCreated.Name = "TxtDxDateCreated"
        Me.TxtDxDateCreated.ReadOnly = True
        Me.TxtDxDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDxDateCreated.TabIndex = 77
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 14)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Modified By"
        '
        'TxtDxModifiedBy
        '
        Me.TxtDxModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtDxModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDxModifiedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDxModifiedBy.Location = New System.Drawing.Point(76, 29)
        Me.TxtDxModifiedBy.Name = "TxtDxModifiedBy"
        Me.TxtDxModifiedBy.ReadOnly = True
        Me.TxtDxModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtDxModifiedBy.TabIndex = 76
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtDiagnosis)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 312)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(730, 125)
        Me.GroupBox4.TabIndex = 173
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Diagnosis/Planning"
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosis.Location = New System.Drawing.Point(3, 19)
        Me.TxtDiagnosis.Multiline = True
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(721, 100)
        Me.TxtDiagnosis.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvSelectedTest)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(730, 146)
        Me.GroupBox3.TabIndex = 172
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selected Test(s)"
        '
        'DgvSelectedTest
        '
        Me.DgvSelectedTest.AllowUserToAddRows = False
        Me.DgvSelectedTest.AllowUserToDeleteRows = False
        Me.DgvSelectedTest.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTestDeleteItem, Me.TestRowNo, Me.TestItemCode, Me.TestItemDescription, Me.TestUnitPrice, Me.TestQuantity, Me.TestTotalPrice, Me.TestItemGroup, Me.TestItemTypeCode, Me.TestItemTypeDescription})
        Me.DgvSelectedTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSelectedTest.Location = New System.Drawing.Point(3, 16)
        Me.DgvSelectedTest.Name = "DgvSelectedTest"
        Me.DgvSelectedTest.ReadOnly = True
        Me.DgvSelectedTest.Size = New System.Drawing.Size(724, 127)
        Me.DgvSelectedTest.TabIndex = 18
        '
        'BtnTestDeleteItem
        '
        Me.BtnTestDeleteItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnTestDeleteItem.HeaderText = "Delete?"
        Me.BtnTestDeleteItem.Name = "BtnTestDeleteItem"
        Me.BtnTestDeleteItem.ReadOnly = True
        Me.BtnTestDeleteItem.Text = "Delete"
        Me.BtnTestDeleteItem.UseColumnTextForButtonValue = True
        Me.BtnTestDeleteItem.Width = 49
        '
        'TestRowNo
        '
        Me.TestRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestRowNo.HeaderText = "No."
        Me.TestRowNo.Name = "TestRowNo"
        Me.TestRowNo.ReadOnly = True
        Me.TestRowNo.Width = 48
        '
        'TestItemCode
        '
        Me.TestItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestItemCode.HeaderText = "Item Code"
        Me.TestItemCode.Name = "TestItemCode"
        Me.TestItemCode.ReadOnly = True
        Me.TestItemCode.Width = 79
        '
        'TestItemDescription
        '
        Me.TestItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TestItemDescription.HeaderText = "Item Description"
        Me.TestItemDescription.Name = "TestItemDescription"
        Me.TestItemDescription.ReadOnly = True
        '
        'TestUnitPrice
        '
        Me.TestUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestUnitPrice.HeaderText = "Unit Price"
        Me.TestUnitPrice.Name = "TestUnitPrice"
        Me.TestUnitPrice.ReadOnly = True
        Me.TestUnitPrice.Width = 77
        '
        'TestQuantity
        '
        Me.TestQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestQuantity.HeaderText = "Quantity"
        Me.TestQuantity.Name = "TestQuantity"
        Me.TestQuantity.ReadOnly = True
        Me.TestQuantity.Width = 72
        '
        'TestTotalPrice
        '
        Me.TestTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestTotalPrice.HeaderText = "Total Price"
        Me.TestTotalPrice.Name = "TestTotalPrice"
        Me.TestTotalPrice.ReadOnly = True
        Me.TestTotalPrice.Width = 81
        '
        'TestItemGroup
        '
        Me.TestItemGroup.HeaderText = "Item Group"
        Me.TestItemGroup.Name = "TestItemGroup"
        Me.TestItemGroup.ReadOnly = True
        Me.TestItemGroup.Visible = False
        '
        'TestItemTypeCode
        '
        Me.TestItemTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestItemTypeCode.HeaderText = "Item Type Code"
        Me.TestItemTypeCode.Name = "TestItemTypeCode"
        Me.TestItemTypeCode.ReadOnly = True
        Me.TestItemTypeCode.Visible = False
        '
        'TestItemTypeDescription
        '
        Me.TestItemTypeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TestItemTypeDescription.HeaderText = "Item Type Description"
        Me.TestItemTypeDescription.Name = "TestItemTypeDescription"
        Me.TestItemTypeDescription.ReadOnly = True
        Me.TestItemTypeDescription.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.BtnSearchTestItem)
        Me.GroupBox2.Controls.Add(Me.BtnAddTest)
        Me.GroupBox2.Controls.Add(Me.TxtTestTotalPrice)
        Me.GroupBox2.Controls.Add(Me.TxtTestUnitPrice)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtTestQuantity)
        Me.GroupBox2.Controls.Add(Me.TxtTestItem)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 148)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Test"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 14)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Item"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(481, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 25)
        Me.Button3.TabIndex = 166
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 14)
        Me.Label17.TabIndex = 169
        Me.Label17.Text = "Total Price"
        '
        'BtnSearchTestItem
        '
        Me.BtnSearchTestItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchTestItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchTestItem.Location = New System.Drawing.Point(446, 25)
        Me.BtnSearchTestItem.Name = "BtnSearchTestItem"
        Me.BtnSearchTestItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchTestItem.TabIndex = 165
        Me.BtnSearchTestItem.Text = "..."
        Me.BtnSearchTestItem.UseVisualStyleBackColor = True
        '
        'BtnAddTest
        '
        Me.BtnAddTest.Location = New System.Drawing.Point(75, 116)
        Me.BtnAddTest.Name = "BtnAddTest"
        Me.BtnAddTest.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddTest.TabIndex = 19
        Me.BtnAddTest.Text = "Add Test"
        Me.BtnAddTest.UseVisualStyleBackColor = True
        '
        'TxtTestTotalPrice
        '
        Me.TxtTestTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestTotalPrice.Location = New System.Drawing.Point(75, 90)
        Me.TxtTestTotalPrice.Name = "TxtTestTotalPrice"
        Me.TxtTestTotalPrice.ReadOnly = True
        Me.TxtTestTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTestTotalPrice.TabIndex = 170
        Me.TxtTestTotalPrice.Text = "0.00"
        Me.TxtTestTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTestUnitPrice
        '
        Me.TxtTestUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestUnitPrice.Location = New System.Drawing.Point(75, 48)
        Me.TxtTestUnitPrice.Name = "TxtTestUnitPrice"
        Me.TxtTestUnitPrice.ReadOnly = True
        Me.TxtTestUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTestUnitPrice.TabIndex = 162
        Me.TxtTestUnitPrice.Text = "0.00"
        Me.TxtTestUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 14)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "Unit Price"
        '
        'TxtTestQuantity
        '
        Me.TxtTestQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTestQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestQuantity.Location = New System.Drawing.Point(75, 69)
        Me.TxtTestQuantity.Name = "TxtTestQuantity"
        Me.TxtTestQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtTestQuantity.TabIndex = 168
        Me.TxtTestQuantity.Text = "1.00"
        Me.TxtTestQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTestItem
        '
        Me.TxtTestItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTestItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestItem.Location = New System.Drawing.Point(75, 27)
        Me.TxtTestItem.Name = "TxtTestItem"
        Me.TxtTestItem.ReadOnly = True
        Me.TxtTestItem.Size = New System.Drawing.Size(370, 20)
        Me.TxtTestItem.TabIndex = 164
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(742, 508)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Treatment & Medication"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.TxtTxCreatedBy)
        Me.Panel1.Controls.Add(Me.TxtTxDateModified)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtTxDateCreated)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtTxModifiedBy)
        Me.Panel1.Location = New System.Drawing.Point(6, 443)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 57)
        Me.Panel1.TabIndex = 180
        '
        'TxtTxCreatedBy
        '
        Me.TxtTxCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtTxCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTxCreatedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTxCreatedBy.Location = New System.Drawing.Point(76, 8)
        Me.TxtTxCreatedBy.Name = "TxtTxCreatedBy"
        Me.TxtTxCreatedBy.ReadOnly = True
        Me.TxtTxCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtTxCreatedBy.TabIndex = 74
        '
        'TxtTxDateModified
        '
        Me.TxtTxDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtTxDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTxDateModified.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTxDateModified.Location = New System.Drawing.Point(142, 29)
        Me.TxtTxDateModified.Name = "TxtTxDateModified"
        Me.TxtTxDateModified.ReadOnly = True
        Me.TxtTxDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtTxDateModified.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Created By"
        '
        'TxtTxDateCreated
        '
        Me.TxtTxDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtTxDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTxDateCreated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTxDateCreated.Location = New System.Drawing.Point(142, 8)
        Me.TxtTxDateCreated.Name = "TxtTxDateCreated"
        Me.TxtTxDateCreated.ReadOnly = True
        Me.TxtTxDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtTxDateCreated.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Modified By"
        '
        'TxtTxModifiedBy
        '
        Me.TxtTxModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtTxModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTxModifiedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTxModifiedBy.Location = New System.Drawing.Point(76, 29)
        Me.TxtTxModifiedBy.Name = "TxtTxModifiedBy"
        Me.TxtTxModifiedBy.ReadOnly = True
        Me.TxtTxModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtTxModifiedBy.TabIndex = 76
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DgvSelectedTreatment)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 249)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(730, 188)
        Me.GroupBox6.TabIndex = 179
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Selected Medication(s)"
        '
        'DgvSelectedTreatment
        '
        Me.DgvSelectedTreatment.AllowUserToAddRows = False
        Me.DgvSelectedTreatment.AllowUserToDeleteRows = False
        Me.DgvSelectedTreatment.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTreatment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTreatmentDeleteItem, Me.DgvBtnUpdate, Me.TreatmentPhRequestID, Me.TreatmentRowNo, Me.TreatmentItemCode, Me.TreatmentItemDescription, Me.TreatmentPrescription, Me.TreatmentNotes, Me.TreatmentUnitPrice, Me.TreatmentQuantity, Me.TreatmentTotalPrice, Me.TreatmentItemGroup, Me.TreatmentItemTypeCode, Me.TreatmentItemTypeDescription, Me.IsDb})
        Me.DgvSelectedTreatment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSelectedTreatment.Location = New System.Drawing.Point(3, 16)
        Me.DgvSelectedTreatment.Name = "DgvSelectedTreatment"
        Me.DgvSelectedTreatment.ReadOnly = True
        Me.DgvSelectedTreatment.Size = New System.Drawing.Size(724, 169)
        Me.DgvSelectedTreatment.TabIndex = 153
        '
        'BtnTreatmentDeleteItem
        '
        Me.BtnTreatmentDeleteItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnTreatmentDeleteItem.HeaderText = "Delete?"
        Me.BtnTreatmentDeleteItem.Name = "BtnTreatmentDeleteItem"
        Me.BtnTreatmentDeleteItem.ReadOnly = True
        Me.BtnTreatmentDeleteItem.Text = "Delete"
        Me.BtnTreatmentDeleteItem.UseColumnTextForButtonValue = True
        Me.BtnTreatmentDeleteItem.Width = 49
        '
        'DgvBtnUpdate
        '
        Me.DgvBtnUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvBtnUpdate.HeaderText = "Update"
        Me.DgvBtnUpdate.Name = "DgvBtnUpdate"
        Me.DgvBtnUpdate.ReadOnly = True
        Me.DgvBtnUpdate.Text = "Update"
        Me.DgvBtnUpdate.UseColumnTextForButtonValue = True
        Me.DgvBtnUpdate.Width = 47
        '
        'TreatmentPhRequestID
        '
        Me.TreatmentPhRequestID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentPhRequestID.HeaderText = "PhRequestID"
        Me.TreatmentPhRequestID.Name = "TreatmentPhRequestID"
        Me.TreatmentPhRequestID.ReadOnly = True
        Me.TreatmentPhRequestID.Width = 93
        '
        'TreatmentRowNo
        '
        Me.TreatmentRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentRowNo.HeaderText = "No."
        Me.TreatmentRowNo.Name = "TreatmentRowNo"
        Me.TreatmentRowNo.ReadOnly = True
        Me.TreatmentRowNo.Width = 48
        '
        'TreatmentItemCode
        '
        Me.TreatmentItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentItemCode.HeaderText = "Item Code"
        Me.TreatmentItemCode.Name = "TreatmentItemCode"
        Me.TreatmentItemCode.ReadOnly = True
        Me.TreatmentItemCode.Width = 79
        '
        'TreatmentItemDescription
        '
        Me.TreatmentItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TreatmentItemDescription.HeaderText = "Item Description"
        Me.TreatmentItemDescription.Name = "TreatmentItemDescription"
        Me.TreatmentItemDescription.ReadOnly = True
        '
        'TreatmentPrescription
        '
        Me.TreatmentPrescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentPrescription.HeaderText = "Prescription"
        Me.TreatmentPrescription.Name = "TreatmentPrescription"
        Me.TreatmentPrescription.ReadOnly = True
        Me.TreatmentPrescription.Visible = False
        '
        'TreatmentNotes
        '
        Me.TreatmentNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentNotes.HeaderText = "Notes"
        Me.TreatmentNotes.Name = "TreatmentNotes"
        Me.TreatmentNotes.ReadOnly = True
        Me.TreatmentNotes.Visible = False
        '
        'TreatmentUnitPrice
        '
        Me.TreatmentUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentUnitPrice.HeaderText = "Unit Price"
        Me.TreatmentUnitPrice.Name = "TreatmentUnitPrice"
        Me.TreatmentUnitPrice.ReadOnly = True
        Me.TreatmentUnitPrice.Width = 77
        '
        'TreatmentQuantity
        '
        Me.TreatmentQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentQuantity.HeaderText = "Quantity"
        Me.TreatmentQuantity.Name = "TreatmentQuantity"
        Me.TreatmentQuantity.ReadOnly = True
        Me.TreatmentQuantity.Width = 72
        '
        'TreatmentTotalPrice
        '
        Me.TreatmentTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentTotalPrice.HeaderText = "Total Price"
        Me.TreatmentTotalPrice.Name = "TreatmentTotalPrice"
        Me.TreatmentTotalPrice.ReadOnly = True
        Me.TreatmentTotalPrice.Width = 81
        '
        'TreatmentItemGroup
        '
        Me.TreatmentItemGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentItemGroup.HeaderText = "Item Group"
        Me.TreatmentItemGroup.Name = "TreatmentItemGroup"
        Me.TreatmentItemGroup.ReadOnly = True
        Me.TreatmentItemGroup.Visible = False
        '
        'TreatmentItemTypeCode
        '
        Me.TreatmentItemTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentItemTypeCode.HeaderText = "Item Type Code"
        Me.TreatmentItemTypeCode.Name = "TreatmentItemTypeCode"
        Me.TreatmentItemTypeCode.ReadOnly = True
        Me.TreatmentItemTypeCode.Visible = False
        '
        'TreatmentItemTypeDescription
        '
        Me.TreatmentItemTypeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentItemTypeDescription.HeaderText = "Item Type Description"
        Me.TreatmentItemTypeDescription.Name = "TreatmentItemTypeDescription"
        Me.TreatmentItemTypeDescription.ReadOnly = True
        Me.TreatmentItemTypeDescription.Visible = False
        '
        'IsDb
        '
        Me.IsDb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IsDb.HeaderText = "IsDb"
        Me.IsDb.Name = "IsDb"
        Me.IsDb.ReadOnly = True
        Me.IsDb.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSendToPharmacy)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.LblRowNo)
        Me.GroupBox5.Controls.Add(Me.TxtTreatmentTotalPrice)
        Me.GroupBox5.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TxtTreatmentUnitPrice)
        Me.GroupBox5.Controls.Add(Me.BtnClearItem)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.TxtTreatmentItem)
        Me.GroupBox5.Controls.Add(Me.TxtTreatmentQuantity)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.BtnAddTreatment)
        Me.GroupBox5.Controls.Add(Me.TxtNotes)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.TxtPrescription)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(730, 237)
        Me.GroupBox5.TabIndex = 178
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Conducted Treatment/Medication"
        '
        'BtnSendToPharmacy
        '
        Me.BtnSendToPharmacy.Location = New System.Drawing.Point(531, 205)
        Me.BtnSendToPharmacy.Name = "BtnSendToPharmacy"
        Me.BtnSendToPharmacy.Size = New System.Drawing.Size(186, 23)
        Me.BtnSendToPharmacy.TabIndex = 100
        Me.BtnSendToPharmacy.Text = "Send To Pharmacy..."
        Me.BtnSendToPharmacy.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Item"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 14)
        Me.Label18.TabIndex = 175
        Me.Label18.Text = "Total Price"
        '
        'LblRowNo
        '
        Me.LblRowNo.AutoSize = True
        Me.LblRowNo.Location = New System.Drawing.Point(576, 30)
        Me.LblRowNo.Name = "LblRowNo"
        Me.LblRowNo.Size = New System.Drawing.Size(43, 14)
        Me.LblRowNo.TabIndex = 177
        Me.LblRowNo.Text = "RowNo"
        Me.LblRowNo.Visible = False
        '
        'TxtTreatmentTotalPrice
        '
        Me.TxtTreatmentTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentTotalPrice.Location = New System.Drawing.Point(75, 178)
        Me.TxtTreatmentTotalPrice.Name = "TxtTreatmentTotalPrice"
        Me.TxtTreatmentTotalPrice.ReadOnly = True
        Me.TxtTreatmentTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTreatmentTotalPrice.TabIndex = 176
        Me.TxtTreatmentTotalPrice.Text = "0.00"
        Me.TxtTreatmentTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(446, 25)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 151
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 14)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Unit Price"
        '
        'TxtTreatmentUnitPrice
        '
        Me.TxtTreatmentUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentUnitPrice.Location = New System.Drawing.Point(75, 136)
        Me.TxtTreatmentUnitPrice.Name = "TxtTreatmentUnitPrice"
        Me.TxtTreatmentUnitPrice.ReadOnly = True
        Me.TxtTreatmentUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTreatmentUnitPrice.TabIndex = 172
        Me.TxtTreatmentUnitPrice.Text = "0.00"
        Me.TxtTreatmentUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnClearItem
        '
        Me.BtnClearItem.Location = New System.Drawing.Point(481, 25)
        Me.BtnClearItem.Name = "BtnClearItem"
        Me.BtnClearItem.Size = New System.Drawing.Size(77, 25)
        Me.BtnClearItem.TabIndex = 152
        Me.BtnClearItem.Text = "Clear"
        Me.BtnClearItem.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(10, 160)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 14)
        Me.Label36.TabIndex = 159
        Me.Label36.Text = "Quantity"
        '
        'TxtTreatmentItem
        '
        Me.TxtTreatmentItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentItem.Location = New System.Drawing.Point(75, 27)
        Me.TxtTreatmentItem.Name = "TxtTreatmentItem"
        Me.TxtTreatmentItem.ReadOnly = True
        Me.TxtTreatmentItem.Size = New System.Drawing.Size(370, 20)
        Me.TxtTreatmentItem.TabIndex = 150
        '
        'TxtTreatmentQuantity
        '
        Me.TxtTreatmentQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTreatmentQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentQuantity.Location = New System.Drawing.Point(75, 157)
        Me.TxtTreatmentQuantity.Name = "TxtTreatmentQuantity"
        Me.TxtTreatmentQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtTreatmentQuantity.TabIndex = 160
        Me.TxtTreatmentQuantity.Text = "1.00"
        Me.TxtTreatmentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 155
        Me.Label34.Text = "Prescription"
        '
        'BtnAddTreatment
        '
        Me.BtnAddTreatment.Location = New System.Drawing.Point(75, 205)
        Me.BtnAddTreatment.Name = "BtnAddTreatment"
        Me.BtnAddTreatment.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddTreatment.TabIndex = 154
        Me.BtnAddTreatment.Text = "Add Item"
        Me.BtnAddTreatment.UseVisualStyleBackColor = True
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(75, 92)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(370, 43)
        Me.TxtNotes.TabIndex = 158
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 92)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 14)
        Me.Label35.TabIndex = 157
        Me.Label35.Text = "Notes"
        '
        'TxtPrescription
        '
        Me.TxtPrescription.BackColor = System.Drawing.Color.White
        Me.TxtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescription.Location = New System.Drawing.Point(75, 48)
        Me.TxtPrescription.Multiline = True
        Me.TxtPrescription.Name = "TxtPrescription"
        Me.TxtPrescription.Size = New System.Drawing.Size(370, 43)
        Me.TxtPrescription.TabIndex = 156
        '
        'TxtVisitID
        '
        Me.TxtVisitID.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitID.Location = New System.Drawing.Point(88, 17)
        Me.TxtVisitID.Name = "TxtVisitID"
        Me.TxtVisitID.ReadOnly = True
        Me.TxtVisitID.Size = New System.Drawing.Size(88, 20)
        Me.TxtVisitID.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 14)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Visit ID"
        '
        'BtnBillPayment
        '
        Me.BtnBillPayment.Location = New System.Drawing.Point(558, 58)
        Me.BtnBillPayment.Name = "BtnBillPayment"
        Me.BtnBillPayment.Size = New System.Drawing.Size(186, 23)
        Me.BtnBillPayment.TabIndex = 89
        Me.BtnBillPayment.Text = "Bill && Payment..."
        Me.BtnBillPayment.UseVisualStyleBackColor = True
        Me.BtnBillPayment.Visible = False
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(88, 38)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(224, 20)
        Me.TxtCustomerName.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 14)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Customer Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 14)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Pet Name"
        '
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.Beige
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetName.Location = New System.Drawing.Point(88, 59)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.ReadOnly = True
        Me.TxtPetName.Size = New System.Drawing.Size(224, 20)
        Me.TxtPetName.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtVisitTime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtVet)
        Me.GroupBox1.Controls.Add(Me.LblInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CbIsAdmittedToWard)
        Me.GroupBox1.Controls.Add(Me.TxtVisitID)
        Me.GroupBox1.Controls.Add(Me.BtnBillPayment)
        Me.GroupBox1.Controls.Add(Me.TxtPetName)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 87)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer && Pet Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 14)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Vet"
        '
        'TxtVet
        '
        Me.TxtVet.BackColor = System.Drawing.Color.Beige
        Me.TxtVet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVet.Location = New System.Drawing.Point(446, 17)
        Me.TxtVet.Name = "TxtVet"
        Me.TxtVet.ReadOnly = True
        Me.TxtVet.Size = New System.Drawing.Size(224, 20)
        Me.TxtVet.TabIndex = 101
        '
        'LblInvoiceNo
        '
        Me.LblInvoiceNo.AutoSize = True
        Me.LblInvoiceNo.Location = New System.Drawing.Point(676, 19)
        Me.LblInvoiceNo.Name = "LblInvoiceNo"
        Me.LblInvoiceNo.Size = New System.Drawing.Size(68, 14)
        Me.LblInvoiceNo.TabIndex = 99
        Me.LblInvoiceNo.Text = "LblInvoiceNo"
        '
        'CbIsAdmittedToWard
        '
        Me.CbIsAdmittedToWard.AutoSize = True
        Me.CbIsAdmittedToWard.Location = New System.Drawing.Point(448, 61)
        Me.CbIsAdmittedToWard.Name = "CbIsAdmittedToWard"
        Me.CbIsAdmittedToWard.Size = New System.Drawing.Size(104, 18)
        Me.CbIsAdmittedToWard.TabIndex = 98
        Me.CbIsAdmittedToWard.Text = "Ward Admission"
        Me.CbIsAdmittedToWard.UseVisualStyleBackColor = True
        Me.CbIsAdmittedToWard.Visible = False
        '
        'TxtVisitTime
        '
        Me.TxtVisitTime.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitTime.Location = New System.Drawing.Point(177, 17)
        Me.TxtVisitTime.Name = "TxtVisitTime"
        Me.TxtVisitTime.ReadOnly = True
        Me.TxtVisitTime.Size = New System.Drawing.Size(135, 20)
        Me.TxtVisitTime.TabIndex = 102
        '
        'FrmTreatmentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 732)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmTreatmentInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treatment Information"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TxtVisitID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBillPayment As Button
    Friend WithEvents TxtDiagnosis As TextBox
    Friend WithEvents DgvSelectedTest As DataGridView
    Friend WithEvents BtnAddTest As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTreatmentItem As TextBox
    Friend WithEvents BtnClearItem As Button
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents BtnAddTreatment As Button
    Friend WithEvents DgvSelectedTreatment As DataGridView
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TxtTreatmentQuantity As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtTestUnitPrice As TextBox
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtPetName As TextBox
    Friend WithEvents TxtTestItem As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnSearchTestItem As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtTestTotalPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTestQuantity As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtTreatmentTotalPrice As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtTreatmentUnitPrice As TextBox
    Friend WithEvents BtnTestDeleteItem As DataGridViewButtonColumn
    Friend WithEvents TestRowNo As DataGridViewTextBoxColumn
    Friend WithEvents TestItemCode As DataGridViewTextBoxColumn
    Friend WithEvents TestItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents TestUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TestQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TestTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents TestItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents TestItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents TestItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbIsAdmittedToWard As CheckBox
    Friend WithEvents LblRowNo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LblInvoiceNo As Label
    Friend WithEvents BtnSendToPharmacy As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtDxCreatedBy As TextBox
    Friend WithEvents TxtDxDateModified As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtDxDateCreated As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtDxModifiedBy As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtTxCreatedBy As TextBox
    Friend WithEvents TxtTxDateModified As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTxDateCreated As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTxModifiedBy As TextBox
    Friend WithEvents BtnTreatmentDeleteItem As DataGridViewButtonColumn
    Friend WithEvents DgvBtnUpdate As DataGridViewButtonColumn
    Friend WithEvents TreatmentPhRequestID As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentRowNo As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemCode As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentPrescription As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentNotes As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents IsDb As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtVet As TextBox
    Friend WithEvents TxtVisitTime As TextBox
End Class
