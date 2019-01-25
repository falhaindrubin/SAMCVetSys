<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPharmacyRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPharmacyRequest))
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvPharmacyRequest = New System.Windows.Forms.DataGridView()
        Me.DgvBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DgvBtnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RqRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqPrescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RqItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbIsCompleted = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApprovalDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtInCharge = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRequestID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtVisitID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRequestDate = New System.Windows.Forms.TextBox()
        Me.TxtVet = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblRowNo = New System.Windows.Forms.Label()
        Me.TxtTotalPrice = New System.Windows.Forms.TextBox()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.BtnClearItem = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.BtnCancelRequest = New System.Windows.Forms.Button()
        Me.PnlActionBar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvPharmacyRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(984, 68)
        Me.PnlActionBar.TabIndex = 85
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(246, 32)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Pharmacy Request"
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(676, 4)
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
        Me.BtnClose.Location = New System.Drawing.Point(920, 4)
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
        Me.BtnCancel.Location = New System.Drawing.Point(798, 4)
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
        Me.BtnEdit.Location = New System.Drawing.Point(859, 4)
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
        Me.BtnSave.Location = New System.Drawing.Point(737, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvPharmacyRequest)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 438)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 272)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item(s) Requested"
        '
        'DgvPharmacyRequest
        '
        Me.DgvPharmacyRequest.AllowUserToAddRows = False
        Me.DgvPharmacyRequest.AllowUserToDeleteRows = False
        Me.DgvPharmacyRequest.BackgroundColor = System.Drawing.Color.White
        Me.DgvPharmacyRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPharmacyRequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvBtnDelete, Me.DgvBtnUpdate, Me.RqRowNo, Me.RqItemCode, Me.RqItemDescription, Me.RqPrescription, Me.RqNotes, Me.RqUnitPrice, Me.RqQuantity, Me.RqTotalPrice, Me.RqItemGroup, Me.RqItemTypeCode, Me.RqItemTypeDescription})
        Me.DgvPharmacyRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPharmacyRequest.Location = New System.Drawing.Point(3, 16)
        Me.DgvPharmacyRequest.Name = "DgvPharmacyRequest"
        Me.DgvPharmacyRequest.ReadOnly = True
        Me.DgvPharmacyRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPharmacyRequest.Size = New System.Drawing.Size(978, 253)
        Me.DgvPharmacyRequest.TabIndex = 154
        '
        'DgvBtnDelete
        '
        Me.DgvBtnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvBtnDelete.HeaderText = "Delete?"
        Me.DgvBtnDelete.Name = "DgvBtnDelete"
        Me.DgvBtnDelete.ReadOnly = True
        Me.DgvBtnDelete.Text = "Delete"
        Me.DgvBtnDelete.UseColumnTextForButtonValue = True
        Me.DgvBtnDelete.Visible = False
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
        'RqRowNo
        '
        Me.RqRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RqRowNo.HeaderText = "No."
        Me.RqRowNo.Name = "RqRowNo"
        Me.RqRowNo.ReadOnly = True
        Me.RqRowNo.Width = 48
        '
        'RqItemCode
        '
        Me.RqItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RqItemCode.HeaderText = "Item Code"
        Me.RqItemCode.Name = "RqItemCode"
        Me.RqItemCode.ReadOnly = True
        Me.RqItemCode.Width = 79
        '
        'RqItemDescription
        '
        Me.RqItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RqItemDescription.HeaderText = "Item Description"
        Me.RqItemDescription.Name = "RqItemDescription"
        Me.RqItemDescription.ReadOnly = True
        Me.RqItemDescription.Width = 108
        '
        'RqPrescription
        '
        Me.RqPrescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RqPrescription.HeaderText = "Prescription"
        Me.RqPrescription.Name = "RqPrescription"
        Me.RqPrescription.ReadOnly = True
        '
        'RqNotes
        '
        Me.RqNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RqNotes.HeaderText = "Notes"
        Me.RqNotes.Name = "RqNotes"
        Me.RqNotes.ReadOnly = True
        '
        'RqUnitPrice
        '
        Me.RqUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RqUnitPrice.HeaderText = "Unit Price"
        Me.RqUnitPrice.Name = "RqUnitPrice"
        Me.RqUnitPrice.ReadOnly = True
        Me.RqUnitPrice.Visible = False
        '
        'RqQuantity
        '
        Me.RqQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RqQuantity.HeaderText = "Quantity"
        Me.RqQuantity.Name = "RqQuantity"
        Me.RqQuantity.ReadOnly = True
        Me.RqQuantity.Width = 72
        '
        'RqTotalPrice
        '
        Me.RqTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RqTotalPrice.HeaderText = "Total Price"
        Me.RqTotalPrice.Name = "RqTotalPrice"
        Me.RqTotalPrice.ReadOnly = True
        Me.RqTotalPrice.Visible = False
        '
        'RqItemGroup
        '
        Me.RqItemGroup.HeaderText = "Item Group"
        Me.RqItemGroup.Name = "RqItemGroup"
        Me.RqItemGroup.ReadOnly = True
        Me.RqItemGroup.Visible = False
        '
        'RqItemTypeCode
        '
        Me.RqItemTypeCode.HeaderText = "Item Type Code"
        Me.RqItemTypeCode.Name = "RqItemTypeCode"
        Me.RqItemTypeCode.ReadOnly = True
        Me.RqItemTypeCode.Visible = False
        '
        'RqItemTypeDescription
        '
        Me.RqItemTypeDescription.HeaderText = "Item Type Description"
        Me.RqItemTypeDescription.Name = "RqItemTypeDescription"
        Me.RqItemTypeDescription.ReadOnly = True
        Me.RqItemTypeDescription.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCancelRequest)
        Me.GroupBox1.Controls.Add(Me.CbIsCompleted)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtApprovalDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtInCharge)
        Me.GroupBox1.Location = New System.Drawing.Point(603, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pharmacy Information"
        '
        'CbIsCompleted
        '
        Me.CbIsCompleted.AutoSize = True
        Me.CbIsCompleted.Location = New System.Drawing.Point(88, 70)
        Me.CbIsCompleted.Name = "CbIsCompleted"
        Me.CbIsCompleted.Size = New System.Drawing.Size(76, 18)
        Me.CbIsCompleted.TabIndex = 155
        Me.CbIsCompleted.Text = "Completed"
        Me.CbIsCompleted.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 14)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Approval Date"
        '
        'TxtApprovalDate
        '
        Me.TxtApprovalDate.BackColor = System.Drawing.Color.Beige
        Me.TxtApprovalDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApprovalDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApprovalDate.Location = New System.Drawing.Point(88, 48)
        Me.TxtApprovalDate.Name = "TxtApprovalDate"
        Me.TxtApprovalDate.ReadOnly = True
        Me.TxtApprovalDate.Size = New System.Drawing.Size(148, 20)
        Me.TxtApprovalDate.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "In-Charge"
        '
        'TxtInCharge
        '
        Me.TxtInCharge.BackColor = System.Drawing.Color.Beige
        Me.TxtInCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInCharge.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInCharge.Location = New System.Drawing.Point(88, 27)
        Me.TxtInCharge.Name = "TxtInCharge"
        Me.TxtInCharge.ReadOnly = True
        Me.TxtInCharge.Size = New System.Drawing.Size(148, 20)
        Me.TxtInCharge.TabIndex = 152
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TxtRequestID)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtVisitID)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TxtRequestDate)
        Me.GroupBox4.Controls.Add(Me.TxtVet)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(585, 100)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Request Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Request ID"
        '
        'TxtRequestID
        '
        Me.TxtRequestID.BackColor = System.Drawing.Color.Beige
        Me.TxtRequestID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRequestID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRequestID.Location = New System.Drawing.Point(71, 69)
        Me.TxtRequestID.Name = "TxtRequestID"
        Me.TxtRequestID.ReadOnly = True
        Me.TxtRequestID.Size = New System.Drawing.Size(125, 20)
        Me.TxtRequestID.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Visit ID"
        '
        'TxtVisitID
        '
        Me.TxtVisitID.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitID.Location = New System.Drawing.Point(71, 48)
        Me.TxtVisitID.Name = "TxtVisitID"
        Me.TxtVisitID.ReadOnly = True
        Me.TxtVisitID.Size = New System.Drawing.Size(125, 20)
        Me.TxtVisitID.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Request Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 14)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Vet"
        '
        'TxtRequestDate
        '
        Me.TxtRequestDate.BackColor = System.Drawing.Color.Beige
        Me.TxtRequestDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRequestDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRequestDate.Location = New System.Drawing.Point(465, 27)
        Me.TxtRequestDate.Name = "TxtRequestDate"
        Me.TxtRequestDate.ReadOnly = True
        Me.TxtRequestDate.Size = New System.Drawing.Size(114, 20)
        Me.TxtRequestDate.TabIndex = 156
        Me.TxtRequestDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtVet
        '
        Me.TxtVet.BackColor = System.Drawing.Color.Beige
        Me.TxtVet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVet.Location = New System.Drawing.Point(71, 27)
        Me.TxtVet.Name = "TxtVet"
        Me.TxtVet.ReadOnly = True
        Me.TxtVet.Size = New System.Drawing.Size(267, 20)
        Me.TxtVet.TabIndex = 154
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.LblRowNo)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPrice)
        Me.GroupBox5.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TxtUnitPrice)
        Me.GroupBox5.Controls.Add(Me.BtnClearItem)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.TxtItem)
        Me.GroupBox5.Controls.Add(Me.TxtQuantity)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.BtnAddItem)
        Me.GroupBox5.Controls.Add(Me.TxtNotes)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.TxtPrescription)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(984, 239)
        Me.GroupBox5.TabIndex = 179
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Item"
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
        Me.LblRowNo.Location = New System.Drawing.Point(133, 178)
        Me.LblRowNo.Name = "LblRowNo"
        Me.LblRowNo.Size = New System.Drawing.Size(43, 14)
        Me.LblRowNo.TabIndex = 177
        Me.LblRowNo.Text = "RowNo"
        Me.LblRowNo.Visible = False
        '
        'TxtTotalPrice
        '
        Me.TxtTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPrice.Location = New System.Drawing.Point(75, 178)
        Me.TxtTotalPrice.Name = "TxtTotalPrice"
        Me.TxtTotalPrice.ReadOnly = True
        Me.TxtTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTotalPrice.TabIndex = 176
        Me.TxtTotalPrice.Text = "0.00"
        Me.TxtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(499, 25)
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
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitPrice.Location = New System.Drawing.Point(75, 136)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.ReadOnly = True
        Me.TxtUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtUnitPrice.TabIndex = 172
        Me.TxtUnitPrice.Text = "0.00"
        Me.TxtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnClearItem
        '
        Me.BtnClearItem.Location = New System.Drawing.Point(533, 25)
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
        'TxtItem
        '
        Me.TxtItem.BackColor = System.Drawing.Color.Beige
        Me.TxtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem.Location = New System.Drawing.Point(75, 27)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.Size = New System.Drawing.Size(424, 20)
        Me.TxtItem.TabIndex = 150
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.White
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(75, 157)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtQuantity.TabIndex = 160
        Me.TxtQuantity.Text = "1.00"
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'BtnAddItem
        '
        Me.BtnAddItem.Location = New System.Drawing.Point(75, 205)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddItem.TabIndex = 154
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(75, 92)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(424, 43)
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
        Me.TxtPrescription.Size = New System.Drawing.Size(424, 43)
        Me.TxtPrescription.TabIndex = 156
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtCreatedBy)
        Me.Panel3.Controls.Add(Me.TxtDateModified)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.TxtDateCreated)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.TxtModifiedBy)
        Me.Panel3.Location = New System.Drawing.Point(15, 716)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(981, 57)
        Me.Panel3.TabIndex = 181
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 8)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateModified.Location = New System.Drawing.Point(142, 29)
        Me.TxtDateModified.Name = "TxtDateModified"
        Me.TxtDateModified.ReadOnly = True
        Me.TxtDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateModified.TabIndex = 78
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
        'TxtDateCreated
        '
        Me.TxtDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateCreated.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateCreated.Location = New System.Drawing.Point(142, 8)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
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
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 29)
        Me.TxtModifiedBy.Name = "TxtModifiedBy"
        Me.TxtModifiedBy.ReadOnly = True
        Me.TxtModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtModifiedBy.TabIndex = 76
        '
        'BtnCancelRequest
        '
        Me.BtnCancelRequest.Location = New System.Drawing.Point(242, 26)
        Me.BtnCancelRequest.Name = "BtnCancelRequest"
        Me.BtnCancelRequest.Size = New System.Drawing.Size(130, 23)
        Me.BtnCancelRequest.TabIndex = 156
        Me.BtnCancelRequest.Text = "Cancel Request"
        Me.BtnCancelRequest.UseVisualStyleBackColor = True
        '
        'FrmPharmacyRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 785)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmPharmacyRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy Request Information"
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvPharmacyRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents LblRowNo As Label
    Friend WithEvents TxtTotalPrice As TextBox
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtUnitPrice As TextBox
    Friend WithEvents BtnClearItem As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents DgvPharmacyRequest As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInCharge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtVet As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRequestDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApprovalDate As TextBox
    Friend WithEvents CbIsCompleted As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRequestID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtVisitID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtModifiedBy As TextBox
    Friend WithEvents DgvBtnDelete As DataGridViewButtonColumn
    Friend WithEvents DgvBtnUpdate As DataGridViewButtonColumn
    Friend WithEvents RqRowNo As DataGridViewTextBoxColumn
    Friend WithEvents RqItemCode As DataGridViewTextBoxColumn
    Friend WithEvents RqItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents RqPrescription As DataGridViewTextBoxColumn
    Friend WithEvents RqNotes As DataGridViewTextBoxColumn
    Friend WithEvents RqUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents RqQuantity As DataGridViewTextBoxColumn
    Friend WithEvents RqTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents RqItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents RqItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents RqItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelRequest As Button
End Class
