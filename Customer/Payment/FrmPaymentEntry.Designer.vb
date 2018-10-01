<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPaymentEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaymentEntry))
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
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CbPaymentCompleted = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TxtTotalPrice = New System.Windows.Forms.TextBox()
        Me.TxtTotalDue = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtLumpSumDiscount = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TxtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TxtDeposit = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TxtGrossTotal = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.BtnClearPrescription = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BtnClearItem = New System.Windows.Forms.Button()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.DgvBillListing = New System.Windows.Forms.DataGridView()
        Me.BtnClearBill = New System.Windows.Forms.Button()
        Me.BtnAddBillItem = New System.Windows.Forms.Button()
        Me.BtnDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvBillListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(710, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 56)
        Me.BtnSave.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateModified.Location = New System.Drawing.Point(145, 33)
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
        Me.BtnEdit.Location = New System.Drawing.Point(832, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 56)
        Me.BtnEdit.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 9)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 13)
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
        Me.TxtDateCreated.Location = New System.Drawing.Point(145, 9)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 36)
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
        Me.BtnCancel.Location = New System.Drawing.Point(771, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 56)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(893, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 56)
        Me.BtnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(588, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.BtnSearch)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(957, 61)
        Me.PnlActionBar.TabIndex = 84
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(649, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 56)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 33)
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
        Me.Panel3.Location = New System.Drawing.Point(16, 722)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(953, 61)
        Me.Panel3.TabIndex = 85
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(961, 635)
        Me.TabControl1.TabIndex = 83
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CbPaymentCompleted)
        Me.TabPage4.Controls.Add(Me.Label44)
        Me.TabPage4.Controls.Add(Me.TxtTotalPrice)
        Me.TabPage4.Controls.Add(Me.TxtTotalDue)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.TxtLumpSumDiscount)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.TxtGrandTotal)
        Me.TabPage4.Controls.Add(Me.Label45)
        Me.TabPage4.Controls.Add(Me.TxtDeposit)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.TxtGrossTotal)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.Label38)
        Me.TabPage4.Controls.Add(Me.TxtInvoiceNo)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.TxtDiscount)
        Me.TabPage4.Controls.Add(Me.TxtItem)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.TxtPrescription)
        Me.TabPage4.Controls.Add(Me.BtnClearPrescription)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.BtnClearItem)
        Me.TabPage4.Controls.Add(Me.TxtNotes)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.TxtQuantity)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.TxtUnitPrice)
        Me.TabPage4.Controls.Add(Me.BtnSearchItem)
        Me.TabPage4.Controls.Add(Me.DgvBillListing)
        Me.TabPage4.Controls.Add(Me.BtnClearBill)
        Me.TabPage4.Controls.Add(Me.BtnAddBillItem)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(953, 608)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Billing & Payment"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CbPaymentCompleted
        '
        Me.CbPaymentCompleted.AutoSize = True
        Me.CbPaymentCompleted.Location = New System.Drawing.Point(246, 19)
        Me.CbPaymentCompleted.Name = "CbPaymentCompleted"
        Me.CbPaymentCompleted.Size = New System.Drawing.Size(120, 18)
        Me.CbPaymentCompleted.TabIndex = 168
        Me.CbPaymentCompleted.Text = "Payment Completed"
        Me.CbPaymentCompleted.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 288)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 14)
        Me.Label44.TabIndex = 166
        Me.Label44.Text = "Total Price"
        '
        'TxtTotalPrice
        '
        Me.TxtTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPrice.Location = New System.Drawing.Point(84, 285)
        Me.TxtTotalPrice.Name = "TxtTotalPrice"
        Me.TxtTotalPrice.ReadOnly = True
        Me.TxtTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTotalPrice.TabIndex = 167
        Me.TxtTotalPrice.Text = "0.00"
        Me.TxtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalDue
        '
        Me.TxtTotalDue.BackColor = System.Drawing.Color.Beige
        Me.TxtTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalDue.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDue.Location = New System.Drawing.Point(787, 577)
        Me.TxtTotalDue.Name = "TxtTotalDue"
        Me.TxtTotalDue.ReadOnly = True
        Me.TxtTotalDue.Size = New System.Drawing.Size(156, 21)
        Me.TxtTotalDue.TabIndex = 165
        Me.TxtTotalDue.Text = "0.00"
        Me.TxtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(704, 580)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 14)
        Me.Label32.TabIndex = 164
        Me.Label32.Text = "Total Due (RM)"
        '
        'TxtLumpSumDiscount
        '
        Me.TxtLumpSumDiscount.BackColor = System.Drawing.Color.Beige
        Me.TxtLumpSumDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLumpSumDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLumpSumDiscount.Location = New System.Drawing.Point(787, 511)
        Me.TxtLumpSumDiscount.Name = "TxtLumpSumDiscount"
        Me.TxtLumpSumDiscount.ReadOnly = True
        Me.TxtLumpSumDiscount.Size = New System.Drawing.Size(156, 21)
        Me.TxtLumpSumDiscount.TabIndex = 163
        Me.TxtLumpSumDiscount.Text = "0.00"
        Me.TxtLumpSumDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(706, 514)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(75, 14)
        Me.Label40.TabIndex = 162
        Me.Label40.Text = "Discount (RM)"
        '
        'TxtGrandTotal
        '
        Me.TxtGrandTotal.BackColor = System.Drawing.Color.Beige
        Me.TxtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGrandTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrandTotal.Location = New System.Drawing.Point(787, 533)
        Me.TxtGrandTotal.Name = "TxtGrandTotal"
        Me.TxtGrandTotal.ReadOnly = True
        Me.TxtGrandTotal.Size = New System.Drawing.Size(156, 21)
        Me.TxtGrandTotal.TabIndex = 161
        Me.TxtGrandTotal.Text = "0.00"
        Me.TxtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(693, 536)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(88, 14)
        Me.Label45.TabIndex = 160
        Me.Label45.Text = "Grand Total (RM)"
        '
        'TxtDeposit
        '
        Me.TxtDeposit.BackColor = System.Drawing.Color.White
        Me.TxtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDeposit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeposit.Location = New System.Drawing.Point(787, 555)
        Me.TxtDeposit.Name = "TxtDeposit"
        Me.TxtDeposit.Size = New System.Drawing.Size(156, 21)
        Me.TxtDeposit.TabIndex = 159
        Me.TxtDeposit.Text = "0.00"
        Me.TxtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(712, 558)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(69, 14)
        Me.Label42.TabIndex = 158
        Me.Label42.Text = "Deposit (RM)"
        '
        'TxtGrossTotal
        '
        Me.TxtGrossTotal.BackColor = System.Drawing.Color.Beige
        Me.TxtGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGrossTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrossTotal.Location = New System.Drawing.Point(787, 489)
        Me.TxtGrossTotal.Name = "TxtGrossTotal"
        Me.TxtGrossTotal.ReadOnly = True
        Me.TxtGrossTotal.Size = New System.Drawing.Size(156, 21)
        Me.TxtGrossTotal.TabIndex = 157
        Me.TxtGrossTotal.Text = "0.00"
        Me.TxtGrossTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(693, 492)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(88, 14)
        Me.Label39.TabIndex = 156
        Me.Label39.Text = "Gross Total (RM)"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 21)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 14)
        Me.Label38.TabIndex = 154
        Me.Label38.Text = "Invoice No."
        '
        'TxtInvoiceNo
        '
        Me.TxtInvoiceNo.BackColor = System.Drawing.Color.Beige
        Me.TxtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInvoiceNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvoiceNo.Location = New System.Drawing.Point(84, 18)
        Me.TxtInvoiceNo.Name = "TxtInvoiceNo"
        Me.TxtInvoiceNo.ReadOnly = True
        Me.TxtInvoiceNo.Size = New System.Drawing.Size(156, 21)
        Me.TxtInvoiceNo.TabIndex = 155
        Me.TxtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 45)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(26, 14)
        Me.Label33.TabIndex = 130
        Me.Label33.Text = "Item"
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.White
        Me.TxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiscount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(84, 263)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(52, 21)
        Me.TxtDiscount.TabIndex = 153
        Me.TxtDiscount.Text = "0.00"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtItem
        '
        Me.TxtItem.BackColor = System.Drawing.Color.Beige
        Me.TxtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem.Location = New System.Drawing.Point(84, 42)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.Size = New System.Drawing.Size(416, 21)
        Me.TxtItem.TabIndex = 131
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 266)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(49, 14)
        Me.Label43.TabIndex = 152
        Me.Label43.Text = "Discount"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 69)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 132
        Me.Label34.Text = "Prescription"
        '
        'TxtPrescription
        '
        Me.TxtPrescription.BackColor = System.Drawing.Color.White
        Me.TxtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescription.Location = New System.Drawing.Point(84, 66)
        Me.TxtPrescription.Multiline = True
        Me.TxtPrescription.Name = "TxtPrescription"
        Me.TxtPrescription.Size = New System.Drawing.Size(416, 64)
        Me.TxtPrescription.TabIndex = 133
        '
        'BtnClearPrescription
        '
        Me.BtnClearPrescription.Location = New System.Drawing.Point(538, 66)
        Me.BtnClearPrescription.Name = "BtnClearPrescription"
        Me.BtnClearPrescription.Size = New System.Drawing.Size(51, 25)
        Me.BtnClearPrescription.TabIndex = 150
        Me.BtnClearPrescription.Text = "Clear"
        Me.BtnClearPrescription.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 133)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 14)
        Me.Label35.TabIndex = 134
        Me.Label35.Text = "Notes"
        '
        'BtnClearItem
        '
        Me.BtnClearItem.Location = New System.Drawing.Point(538, 40)
        Me.BtnClearItem.Name = "BtnClearItem"
        Me.BtnClearItem.Size = New System.Drawing.Size(51, 25)
        Me.BtnClearItem.TabIndex = 149
        Me.BtnClearItem.Text = "Clear"
        Me.BtnClearItem.UseVisualStyleBackColor = True
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(84, 133)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(416, 83)
        Me.TxtNotes.TabIndex = 135
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 222)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 14)
        Me.Label36.TabIndex = 136
        Me.Label36.Text = "Quantity"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.White
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(84, 219)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtQuantity.TabIndex = 137
        Me.TxtQuantity.Text = "1.00"
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 244)
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
        Me.TxtUnitPrice.Location = New System.Drawing.Point(84, 241)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.ReadOnly = True
        Me.TxtUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtUnitPrice.TabIndex = 139
        Me.TxtUnitPrice.Text = "0.00"
        Me.TxtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(502, 40)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 144
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'DgvBillListing
        '
        Me.DgvBillListing.AllowUserToAddRows = False
        Me.DgvBillListing.AllowUserToDeleteRows = False
        Me.DgvBillListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBillListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnDeleteItem, Me.RowNo, Me.ItemCodeDgv, Me.ItemDescription, Me.Prescription, Me.Notes, Me.Remark, Me.Quantity, Me.UnitPrice, Me.ItemDiscount, Me.TotalPrice})
        Me.DgvBillListing.Location = New System.Drawing.Point(6, 346)
        Me.DgvBillListing.MultiSelect = False
        Me.DgvBillListing.Name = "DgvBillListing"
        Me.DgvBillListing.ReadOnly = True
        Me.DgvBillListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBillListing.Size = New System.Drawing.Size(936, 137)
        Me.DgvBillListing.TabIndex = 140
        '
        'BtnClearBill
        '
        Me.BtnClearBill.Location = New System.Drawing.Point(182, 313)
        Me.BtnClearBill.Name = "BtnClearBill"
        Me.BtnClearBill.Size = New System.Drawing.Size(95, 25)
        Me.BtnClearBill.TabIndex = 143
        Me.BtnClearBill.Text = "Clear Bill"
        Me.BtnClearBill.UseVisualStyleBackColor = True
        '
        'BtnAddBillItem
        '
        Me.BtnAddBillItem.Location = New System.Drawing.Point(84, 313)
        Me.BtnAddBillItem.Name = "BtnAddBillItem"
        Me.BtnAddBillItem.Size = New System.Drawing.Size(95, 25)
        Me.BtnAddBillItem.TabIndex = 142
        Me.BtnAddBillItem.Text = "Add Item.."
        Me.BtnAddBillItem.UseVisualStyleBackColor = True
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
        Me.ItemCodeDgv.HeaderText = "ItemCode"
        Me.ItemCodeDgv.Name = "ItemCodeDgv"
        Me.ItemCodeDgv.ReadOnly = True
        '
        'ItemDescription
        '
        Me.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ItemDescription.HeaderText = "ItemDescription"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.ReadOnly = True
        Me.ItemDescription.Width = 105
        '
        'Prescription
        '
        Me.Prescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Prescription.HeaderText = "Prescription"
        Me.Prescription.Name = "Prescription"
        Me.Prescription.ReadOnly = True
        Me.Prescription.Width = 89
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'Remark
        '
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
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
        'FrmPaymentEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 796)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPaymentEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing & Payment"
        Me.PnlActionBar.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DgvBillListing, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtLumpSumDiscount As TextBox
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
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents BtnClearPrescription As Button
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
    Friend WithEvents BtnDeleteItem As DataGridViewButtonColumn
    Friend WithEvents RowNo As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDgv As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents Prescription As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents ItemDiscount As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
End Class
