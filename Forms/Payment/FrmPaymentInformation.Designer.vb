<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPaymentInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaymentInformation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxtGrossTotal = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TxtTotalDue = New System.Windows.Forms.TextBox()
        Me.TxtDeposit = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DgvBillListing = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.TxtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnClearItem = New System.Windows.Forms.Button()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.BtnAddBillItem = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.BtnClearBill = New System.Windows.Forms.Button()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbCheque = New System.Windows.Forms.CheckBox()
        Me.CbDebitCreditCard = New System.Windows.Forms.CheckBox()
        Me.CbCash = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbPaymentCompleted = New System.Windows.Forms.CheckBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.TxtVisitID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGenerateInvoice = New System.Windows.Forms.Button()
        Me.CbIsRecalculate = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChSourceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemGroupDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemTypeCodeDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemTypeDescriptionDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvBillListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(736, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateModified.Location = New System.Drawing.Point(142, 31)
        Me.TxtDateModified.Name = "TxtDateModified"
        Me.TxtDateModified.ReadOnly = True
        Me.TxtDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateModified.TabIndex = 78
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Location = New System.Drawing.Point(858, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 60)
        Me.BtnEdit.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 10)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Created By"
        '
        'TxtDateCreated
        '
        Me.TxtDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateCreated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateCreated.Location = New System.Drawing.Point(142, 10)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 14)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Modified By"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(797, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 60)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(919, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(614, 4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.UseVisualStyleBackColor = False
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
        Me.PnlActionBar.Size = New System.Drawing.Size(984, 68)
        Me.PnlActionBar.TabIndex = 84
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(370, 32)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Billing && Payment Information"
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(675, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 60)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 31)
        Me.TxtModifiedBy.Name = "TxtModifiedBy"
        Me.TxtModifiedBy.ReadOnly = True
        Me.TxtModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtModifiedBy.TabIndex = 76
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtCreatedBy)
        Me.Panel3.Controls.Add(Me.TxtDateModified)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TxtDateCreated)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.TxtModifiedBy)
        Me.Panel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(12, 817)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 61)
        Me.Panel3.TabIndex = 85
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 171)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 640)
        Me.TabControl1.TabIndex = 83
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(976, 613)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Billing & Payment"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtGrossTotal)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.Label42)
        Me.GroupBox7.Controls.Add(Me.TxtTotalDue)
        Me.GroupBox7.Controls.Add(Me.TxtDeposit)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.Label45)
        Me.GroupBox7.Controls.Add(Me.TxtDiscount)
        Me.GroupBox7.Controls.Add(Me.TxtGrandTotal)
        Me.GroupBox7.Controls.Add(Me.Label40)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 511)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(964, 96)
        Me.GroupBox7.TabIndex = 168
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Amount"
        '
        'TxtGrossTotal
        '
        Me.TxtGrossTotal.BackColor = System.Drawing.Color.Beige
        Me.TxtGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGrossTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrossTotal.Location = New System.Drawing.Point(546, 19)
        Me.TxtGrossTotal.Name = "TxtGrossTotal"
        Me.TxtGrossTotal.ReadOnly = True
        Me.TxtGrossTotal.Size = New System.Drawing.Size(156, 21)
        Me.TxtGrossTotal.TabIndex = 157
        Me.TxtGrossTotal.Text = "0.00"
        Me.TxtGrossTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGrossTotal.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(710, 22)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(88, 14)
        Me.Label39.TabIndex = 156
        Me.Label39.Text = "Grand Total (RM)"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(729, 44)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(69, 14)
        Me.Label42.TabIndex = 158
        Me.Label42.Text = "Deposit (RM)"
        '
        'TxtTotalDue
        '
        Me.TxtTotalDue.BackColor = System.Drawing.Color.Beige
        Me.TxtTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalDue.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDue.Location = New System.Drawing.Point(802, 63)
        Me.TxtTotalDue.Name = "TxtTotalDue"
        Me.TxtTotalDue.ReadOnly = True
        Me.TxtTotalDue.Size = New System.Drawing.Size(156, 21)
        Me.TxtTotalDue.TabIndex = 165
        Me.TxtTotalDue.Text = "0.00"
        Me.TxtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDeposit
        '
        Me.TxtDeposit.BackColor = System.Drawing.Color.White
        Me.TxtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDeposit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposit.Location = New System.Drawing.Point(802, 41)
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(156, 21)
        Me.TxtDeposit.TabIndex = 159
        Me.TxtDeposit.Text = "0.00"
        Me.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(721, 66)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 14)
        Me.Label32.TabIndex = 164
        Me.Label32.Text = "Total Due (RM)"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(452, 22)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(88, 14)
        Me.Label45.TabIndex = 160
        Me.Label45.Text = "Gross Total (RM)"
        Me.Label45.Visible = False
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.White
        Me.TxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(546, 63)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(156, 21)
        Me.TxtDiscount.TabIndex = 163
        Me.TxtDiscount.Text = "0.00"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGrandTotal
        '
        Me.TxtGrandTotal.BackColor = System.Drawing.Color.Beige
        Me.TxtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGrandTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrandTotal.Location = New System.Drawing.Point(802, 19)
        Me.TxtGrandTotal.Name = "TxtGrandTotal"
        Me.TxtGrandTotal.ReadOnly = True
        Me.TxtGrandTotal.Size = New System.Drawing.Size(156, 21)
        Me.TxtGrandTotal.TabIndex = 161
        Me.TxtGrandTotal.Text = "0.00"
        Me.TxtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(465, 66)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(75, 14)
        Me.Label40.TabIndex = 162
        Me.Label40.Text = "Discount (RM)"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DgvBillListing)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 245)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(964, 260)
        Me.GroupBox6.TabIndex = 167
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Item List"
        '
        'DgvBillListing
        '
        Me.DgvBillListing.AllowUserToAddRows = False
        Me.DgvBillListing.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvBillListing.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBillListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBillListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnDeleteItem, Me.RowNo, Me.ItemCodeDgv, Me.ItemDescription, Me.ChSource, Me.ChSourceName, Me.Prescription, Me.Notes, Me.Remark, Me.Quantity, Me.UnitPrice, Me.ItemDiscount, Me.TotalPrice, Me.ItemGroupDgv, Me.ItemTypeCodeDgv, Me.ItemTypeDescriptionDgv})
        Me.DgvBillListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBillListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvBillListing.MultiSelect = False
        Me.DgvBillListing.Name = "DgvBillListing"
        Me.DgvBillListing.ReadOnly = True
        Me.DgvBillListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBillListing.Size = New System.Drawing.Size(958, 241)
        Me.DgvBillListing.TabIndex = 140
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.TxtPrescription)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPrice)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.BtnClearItem)
        Me.GroupBox5.Controls.Add(Me.TxtItem)
        Me.GroupBox5.Controls.Add(Me.TxtNotes)
        Me.GroupBox5.Controls.Add(Me.BtnAddBillItem)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.BtnClearBill)
        Me.GroupBox5.Controls.Add(Me.TxtQuantity)
        Me.GroupBox5.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.TxtUnitPrice)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(964, 233)
        Me.GroupBox5.TabIndex = 166
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Item"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(10, 174)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 14)
        Me.Label44.TabIndex = 166
        Me.Label44.Text = "Total Price"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(10, 26)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(26, 14)
        Me.Label33.TabIndex = 130
        Me.Label33.Text = "Item"
        '
        'TxtPrescription
        '
        Me.TxtPrescription.BackColor = System.Drawing.Color.White
        Me.TxtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescription.Location = New System.Drawing.Point(73, 45)
        Me.TxtPrescription.Multiline = True
        Me.TxtPrescription.Name = "TxtPrescription"
        Me.TxtPrescription.Size = New System.Drawing.Size(416, 40)
        Me.TxtPrescription.TabIndex = 133
        '
        'TxtTotalPrice
        '
        Me.TxtTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPrice.Location = New System.Drawing.Point(73, 171)
        Me.TxtTotalPrice.Name = "TxtTotalPrice"
        Me.TxtTotalPrice.ReadOnly = True
        Me.TxtTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTotalPrice.TabIndex = 167
        Me.TxtTotalPrice.Text = "0.00"
        Me.TxtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 86)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 14)
        Me.Label35.TabIndex = 134
        Me.Label35.Text = "Notes"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 45)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 132
        Me.Label34.Text = "Prescription"
        '
        'BtnClearItem
        '
        Me.BtnClearItem.Location = New System.Drawing.Point(523, 21)
        Me.BtnClearItem.Name = "BtnClearItem"
        Me.BtnClearItem.Size = New System.Drawing.Size(70, 25)
        Me.BtnClearItem.TabIndex = 149
        Me.BtnClearItem.Text = "Clear"
        Me.BtnClearItem.UseVisualStyleBackColor = True
        '
        'TxtItem
        '
        Me.TxtItem.BackColor = System.Drawing.Color.Beige
        Me.TxtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem.Location = New System.Drawing.Point(73, 23)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.Size = New System.Drawing.Size(416, 21)
        Me.TxtItem.TabIndex = 131
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(73, 86)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(416, 40)
        Me.TxtNotes.TabIndex = 135
        '
        'BtnAddBillItem
        '
        Me.BtnAddBillItem.Location = New System.Drawing.Point(73, 196)
        Me.BtnAddBillItem.Name = "BtnAddBillItem"
        Me.BtnAddBillItem.Size = New System.Drawing.Size(95, 25)
        Me.BtnAddBillItem.TabIndex = 142
        Me.BtnAddBillItem.Text = "Add Item.."
        Me.BtnAddBillItem.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(10, 130)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 14)
        Me.Label36.TabIndex = 136
        Me.Label36.Text = "Quantity"
        '
        'BtnClearBill
        '
        Me.BtnClearBill.Location = New System.Drawing.Point(169, 196)
        Me.BtnClearBill.Name = "BtnClearBill"
        Me.BtnClearBill.Size = New System.Drawing.Size(95, 25)
        Me.BtnClearBill.TabIndex = 143
        Me.BtnClearBill.Text = "Clear Bill"
        Me.BtnClearBill.UseVisualStyleBackColor = True
        Me.BtnClearBill.Visible = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.White
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(73, 127)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtQuantity.TabIndex = 137
        Me.TxtQuantity.Text = "1.00"
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(489, 21)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 144
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(10, 152)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 14)
        Me.Label37.TabIndex = 138
        Me.Label37.Text = "Unit Price"
        '
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitPrice.Location = New System.Drawing.Point(73, 149)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.ReadOnly = True
        Me.TxtUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtUnitPrice.TabIndex = 139
        Me.TxtUnitPrice.Text = "0.00"
        Me.TxtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 544)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Payment Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtPetName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(405, 86)
        Me.GroupBox3.TabIndex = 169
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer && Pet Information"
        '
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.Beige
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetName.Location = New System.Drawing.Point(98, 49)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.ReadOnly = True
        Me.TxtPetName.Size = New System.Drawing.Size(296, 21)
        Me.TxtPetName.TabIndex = 177
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Pet Name"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(98, 27)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(296, 21)
        Me.TxtCustomerName.TabIndex = 175
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Customer Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbCheque)
        Me.GroupBox2.Controls.Add(Me.CbDebitCreditCard)
        Me.GroupBox2.Controls.Add(Me.CbCash)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 80)
        Me.GroupBox2.TabIndex = 169
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Type"
        '
        'CbCheque
        '
        Me.CbCheque.AutoSize = True
        Me.CbCheque.Location = New System.Drawing.Point(11, 53)
        Me.CbCheque.Name = "CbCheque"
        Me.CbCheque.Size = New System.Drawing.Size(63, 18)
        Me.CbCheque.TabIndex = 170
        Me.CbCheque.Text = "Cheque"
        Me.CbCheque.UseVisualStyleBackColor = True
        '
        'CbDebitCreditCard
        '
        Me.CbDebitCreditCard.AutoSize = True
        Me.CbDebitCreditCard.Location = New System.Drawing.Point(11, 36)
        Me.CbDebitCreditCard.Name = "CbDebitCreditCard"
        Me.CbDebitCreditCard.Size = New System.Drawing.Size(107, 18)
        Me.CbDebitCreditCard.TabIndex = 169
        Me.CbDebitCreditCard.Text = "Debit/Credit Card"
        Me.CbDebitCreditCard.UseVisualStyleBackColor = True
        '
        'CbCash
        '
        Me.CbCash.AutoSize = True
        Me.CbCash.Location = New System.Drawing.Point(11, 19)
        Me.CbCash.Name = "CbCash"
        Me.CbCash.Size = New System.Drawing.Size(51, 18)
        Me.CbCash.TabIndex = 168
        Me.CbCash.Text = "Cash"
        Me.CbCash.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbPaymentCompleted)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Status"
        '
        'CbPaymentCompleted
        '
        Me.CbPaymentCompleted.AutoSize = True
        Me.CbPaymentCompleted.Location = New System.Drawing.Point(11, 19)
        Me.CbPaymentCompleted.Name = "CbPaymentCompleted"
        Me.CbPaymentCompleted.Size = New System.Drawing.Size(120, 18)
        Me.CbPaymentCompleted.TabIndex = 168
        Me.CbPaymentCompleted.Text = "Payment Completed"
        Me.CbPaymentCompleted.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(10, 51)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 14)
        Me.Label38.TabIndex = 154
        Me.Label38.Text = "Invoice No."
        '
        'TxtInvoiceNo
        '
        Me.TxtInvoiceNo.BackColor = System.Drawing.Color.Beige
        Me.TxtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInvoiceNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvoiceNo.Location = New System.Drawing.Point(77, 48)
        Me.TxtInvoiceNo.Name = "TxtInvoiceNo"
        Me.TxtInvoiceNo.ReadOnly = True
        Me.TxtInvoiceNo.Size = New System.Drawing.Size(134, 20)
        Me.TxtInvoiceNo.TabIndex = 155
        '
        'TxtVisitID
        '
        Me.TxtVisitID.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitID.Location = New System.Drawing.Point(77, 27)
        Me.TxtVisitID.Name = "TxtVisitID"
        Me.TxtVisitID.ReadOnly = True
        Me.TxtVisitID.Size = New System.Drawing.Size(134, 20)
        Me.TxtVisitID.TabIndex = 170
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 14)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Visit ID"
        '
        'BtnGenerateInvoice
        '
        Me.BtnGenerateInvoice.Location = New System.Drawing.Point(217, 25)
        Me.BtnGenerateInvoice.Name = "BtnGenerateInvoice"
        Me.BtnGenerateInvoice.Size = New System.Drawing.Size(169, 25)
        Me.BtnGenerateInvoice.TabIndex = 168
        Me.BtnGenerateInvoice.Text = "Calculate Bill && Payment..."
        Me.BtnGenerateInvoice.UseVisualStyleBackColor = True
        '
        'CbIsRecalculate
        '
        Me.CbIsRecalculate.AutoSize = True
        Me.CbIsRecalculate.Location = New System.Drawing.Point(392, 28)
        Me.CbIsRecalculate.Name = "CbIsRecalculate"
        Me.CbIsRecalculate.Size = New System.Drawing.Size(156, 18)
        Me.CbIsRecalculate.TabIndex = 171
        Me.CbIsRecalculate.Text = "Re-calculate Bill && Payment"
        Me.CbIsRecalculate.UseVisualStyleBackColor = True
        Me.CbIsRecalculate.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.CbIsRecalculate)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.BtnGenerateInvoice)
        Me.GroupBox4.Controls.Add(Me.TxtInvoiceNo)
        Me.GroupBox4.Controls.Add(Me.TxtVisitID)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(984, 79)
        Me.GroupBox4.TabIndex = 172
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'BtnDeleteItem
        '
        Me.BtnDeleteItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnDeleteItem.HeaderText = "Delete?"
        Me.BtnDeleteItem.Name = "BtnDeleteItem"
        Me.BtnDeleteItem.ReadOnly = True
        Me.BtnDeleteItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BtnDeleteItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BtnDeleteItem.Text = "Delete"
        Me.BtnDeleteItem.ToolTipText = "Delete Item?"
        Me.BtnDeleteItem.UseColumnTextForButtonValue = True
        Me.BtnDeleteItem.Width = 68
        '
        'RowNo
        '
        Me.RowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RowNo.HeaderText = "No."
        Me.RowNo.Name = "RowNo"
        Me.RowNo.ReadOnly = True
        Me.RowNo.Width = 48
        '
        'ItemCodeDgv
        '
        Me.ItemCodeDgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ItemCodeDgv.HeaderText = "Item Code"
        Me.ItemCodeDgv.Name = "ItemCodeDgv"
        Me.ItemCodeDgv.ReadOnly = True
        Me.ItemCodeDgv.Width = 79
        '
        'ItemDescription
        '
        Me.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemDescription.HeaderText = "Item Description"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.ReadOnly = True
        '
        'ChSource
        '
        Me.ChSource.HeaderText = "ChSource"
        Me.ChSource.Name = "ChSource"
        Me.ChSource.ReadOnly = True
        Me.ChSource.Visible = False
        Me.ChSource.Width = 67
        '
        'ChSourceName
        '
        Me.ChSourceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChSourceName.HeaderText = "Source"
        Me.ChSourceName.Name = "ChSourceName"
        Me.ChSourceName.ReadOnly = True
        Me.ChSourceName.Visible = False
        Me.ChSourceName.Width = 67
        '
        'Prescription
        '
        Me.Prescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Prescription.HeaderText = "Prescription"
        Me.Prescription.Name = "Prescription"
        Me.Prescription.ReadOnly = True
        Me.Prescription.Visible = False
        Me.Prescription.Width = 89
        '
        'Notes
        '
        Me.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Visible = False
        Me.Notes.Width = 60
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        Me.Remark.Visible = False
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 72
        '
        'UnitPrice
        '
        Me.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 77
        '
        'ItemDiscount
        '
        Me.ItemDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ItemDiscount.HeaderText = "Discount"
        Me.ItemDiscount.Name = "ItemDiscount"
        Me.ItemDiscount.ReadOnly = True
        Me.ItemDiscount.Visible = False
        Me.ItemDiscount.Width = 74
        '
        'TotalPrice
        '
        Me.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 81
        '
        'ItemGroupDgv
        '
        Me.ItemGroupDgv.HeaderText = "ItemGroup"
        Me.ItemGroupDgv.Name = "ItemGroupDgv"
        Me.ItemGroupDgv.ReadOnly = True
        Me.ItemGroupDgv.Visible = False
        '
        'ItemTypeCodeDgv
        '
        Me.ItemTypeCodeDgv.HeaderText = "ItemTypeCode"
        Me.ItemTypeCodeDgv.Name = "ItemTypeCodeDgv"
        Me.ItemTypeCodeDgv.ReadOnly = True
        Me.ItemTypeCodeDgv.Visible = False
        '
        'ItemTypeDescriptionDgv
        '
        Me.ItemTypeDescriptionDgv.HeaderText = "ItemTypeDescription"
        Me.ItemTypeDescriptionDgv.Name = "ItemTypeDescriptionDgv"
        Me.ItemTypeDescriptionDgv.ReadOnly = True
        Me.ItemTypeDescriptionDgv.Visible = False
        '
        'FrmPaymentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 890)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPaymentInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing & Payment"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DgvBillListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnPrint As Button
    Friend WithEvents TxtModifiedBy As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label44 As Label
    Friend WithEvents TxtTotalPrice As TextBox
    Friend WithEvents TxtTotalDue As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents TxtGrandTotal As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TxtDeposit As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents TxtGrossTotal As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TxtInvoiceNo As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents BtnClearItem As Button
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents TxtUnitPrice As TextBox
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents DgvBillListing As DataGridView
    Friend WithEvents BtnClearBill As Button
    Friend WithEvents BtnAddBillItem As Button
    Friend WithEvents CbPaymentCompleted As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtVisitID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbCheque As CheckBox
    Friend WithEvents CbDebitCreditCard As CheckBox
    Friend WithEvents CbCash As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnGenerateInvoice As Button
    Friend WithEvents CbIsRecalculate As CheckBox
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPetName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnDeleteItem As DataGridViewButtonColumn
    Friend WithEvents RowNo As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDgv As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents ChSource As DataGridViewTextBoxColumn
    Friend WithEvents ChSourceName As DataGridViewTextBoxColumn
    Friend WithEvents Prescription As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents ItemDiscount As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents ItemGroupDgv As DataGridViewTextBoxColumn
    Friend WithEvents ItemTypeCodeDgv As DataGridViewTextBoxColumn
    Friend WithEvents ItemTypeDescriptionDgv As DataGridViewTextBoxColumn
End Class
