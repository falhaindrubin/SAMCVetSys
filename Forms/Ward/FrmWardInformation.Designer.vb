<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWardInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWardInformation))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.TxtPetID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.BtnBillPayment = New System.Windows.Forms.Button()
        Me.TxtVisitID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtWardID = New System.Windows.Forms.TextBox()
        Me.TxtAdmissionDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtTreatmentTotalPrice = New System.Windows.Forms.TextBox()
        Me.TxtTreatmentUnitPrice = New System.Windows.Forms.TextBox()
        Me.TxtTreatmentQuantity = New System.Windows.Forms.TextBox()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtTreatmentItem = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BtnTreatmentItem = New System.Windows.Forms.Button()
        Me.DgvSelectedTreatment = New System.Windows.Forms.DataGridView()
        Me.BtnTreatmentDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TreatmentRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClearTreatment = New System.Windows.Forms.Button()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtTestTotalPrice = New System.Windows.Forms.TextBox()
        Me.TxtTestQuantity = New System.Windows.Forms.TextBox()
        Me.TxtTestItem = New System.Windows.Forms.TextBox()
        Me.TxtTestUnitPrice = New System.Windows.Forms.TextBox()
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnClearTest = New System.Windows.Forms.Button()
        Me.BtnSearchTestItem = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnAddTest = New System.Windows.Forms.Button()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtWardDate = New System.Windows.Forms.TextBox()
        Me.TxtFastingDescription = New System.Windows.Forms.TextBox()
        Me.CmbFasting = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CmbFood = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtDailyNotes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbVomit = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbBowel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbUrine = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbAppetite = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvWardSummary = New System.Windows.Forms.DataGridView()
        Me.WardDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Appetite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bowel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Urine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vomit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CbIsDischarged = New System.Windows.Forms.CheckBox()
        Me.TxtCase = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDD = New System.Windows.Forms.TextBox()
        Me.TxtAD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvWardSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtCreatedBy)
        Me.Panel3.Controls.Add(Me.TxtDateModified)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.TxtDateCreated)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.TxtModifiedBy)
        Me.Panel3.Location = New System.Drawing.Point(12, 660)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 57)
        Me.Panel3.TabIndex = 109
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
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.Beige
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetName.Location = New System.Drawing.Point(205, 87)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.ReadOnly = True
        Me.TxtPetName.Size = New System.Drawing.Size(224, 21)
        Me.TxtPetName.TabIndex = 108
        '
        'TxtPetID
        '
        Me.TxtPetID.BackColor = System.Drawing.Color.Beige
        Me.TxtPetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetID.Location = New System.Drawing.Point(117, 87)
        Me.TxtPetID.Name = "TxtPetID"
        Me.TxtPetID.ReadOnly = True
        Me.TxtPetID.Size = New System.Drawing.Size(87, 21)
        Me.TxtPetID.TabIndex = 107
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 15)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Pet Name"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(205, 65)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(224, 21)
        Me.TxtCustomerName.TabIndex = 105
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 15)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Customer Name"
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerID.Location = New System.Drawing.Point(117, 65)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(87, 21)
        Me.TxtCustomerID.TabIndex = 103
        '
        'BtnBillPayment
        '
        Me.BtnBillPayment.Location = New System.Drawing.Point(558, 20)
        Me.BtnBillPayment.Name = "BtnBillPayment"
        Me.BtnBillPayment.Size = New System.Drawing.Size(186, 23)
        Me.BtnBillPayment.TabIndex = 102
        Me.BtnBillPayment.Text = "Bill && Payment..."
        Me.BtnBillPayment.UseVisualStyleBackColor = True
        '
        'TxtVisitID
        '
        Me.TxtVisitID.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitID.Location = New System.Drawing.Point(117, 21)
        Me.TxtVisitID.Name = "TxtVisitID"
        Me.TxtVisitID.ReadOnly = True
        Me.TxtVisitID.Size = New System.Drawing.Size(87, 21)
        Me.TxtVisitID.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Visit ID / Ward ID"
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Controls.Add(Me.BtnSearch)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(750, 68)
        Me.PnlActionBar.TabIndex = 110
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(5, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(224, 32)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Ward Information"
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(562, 6)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 56)
        Me.BtnReload.TabIndex = 6
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(318, 6)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(379, 6)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 56)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(684, 6)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 56)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(501, 6)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 56)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Location = New System.Drawing.Point(623, 6)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 56)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(440, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 56)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtWardID
        '
        Me.TxtWardID.BackColor = System.Drawing.Color.Beige
        Me.TxtWardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWardID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWardID.Location = New System.Drawing.Point(205, 21)
        Me.TxtWardID.Name = "TxtWardID"
        Me.TxtWardID.ReadOnly = True
        Me.TxtWardID.Size = New System.Drawing.Size(87, 21)
        Me.TxtWardID.TabIndex = 111
        '
        'TxtAdmissionDate
        '
        Me.TxtAdmissionDate.BackColor = System.Drawing.Color.Beige
        Me.TxtAdmissionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdmissionDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmissionDate.Location = New System.Drawing.Point(117, 43)
        Me.TxtAdmissionDate.Name = "TxtAdmissionDate"
        Me.TxtAdmissionDate.ReadOnly = True
        Me.TxtAdmissionDate.Size = New System.Drawing.Size(175, 21)
        Me.TxtAdmissionDate.TabIndex = 113
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 15)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Date of Admission"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentTotalPrice)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentUnitPrice)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentQuantity)
        Me.TabPage3.Controls.Add(Me.TxtPrescription)
        Me.TabPage3.Controls.Add(Me.TxtNotes)
        Me.TabPage3.Controls.Add(Me.TxtTreatmentItem)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.BtnTreatmentItem)
        Me.TabPage3.Controls.Add(Me.DgvSelectedTreatment)
        Me.TabPage3.Controls.Add(Me.BtnClearTreatment)
        Me.TabPage3.Controls.Add(Me.BtnSearchItem)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(742, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Treatment & Medication"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 174)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 14)
        Me.Label18.TabIndex = 175
        Me.Label18.Text = "Total Price"
        '
        'TxtTreatmentTotalPrice
        '
        Me.TxtTreatmentTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentTotalPrice.Location = New System.Drawing.Point(75, 171)
        Me.TxtTreatmentTotalPrice.Name = "TxtTreatmentTotalPrice"
        Me.TxtTreatmentTotalPrice.ReadOnly = True
        Me.TxtTreatmentTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTreatmentTotalPrice.TabIndex = 176
        Me.TxtTreatmentTotalPrice.Text = "0.00"
        Me.TxtTreatmentTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTreatmentUnitPrice
        '
        Me.TxtTreatmentUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentUnitPrice.Location = New System.Drawing.Point(75, 127)
        Me.TxtTreatmentUnitPrice.Name = "TxtTreatmentUnitPrice"
        Me.TxtTreatmentUnitPrice.ReadOnly = True
        Me.TxtTreatmentUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTreatmentUnitPrice.TabIndex = 172
        Me.TxtTreatmentUnitPrice.Text = "0.00"
        Me.TxtTreatmentUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTreatmentQuantity
        '
        Me.TxtTreatmentQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTreatmentQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentQuantity.Location = New System.Drawing.Point(75, 149)
        Me.TxtTreatmentQuantity.Name = "TxtTreatmentQuantity"
        Me.TxtTreatmentQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtTreatmentQuantity.TabIndex = 160
        Me.TxtTreatmentQuantity.Text = "1.00"
        Me.TxtTreatmentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPrescription
        '
        Me.TxtPrescription.BackColor = System.Drawing.Color.White
        Me.TxtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescription.Location = New System.Drawing.Point(75, 39)
        Me.TxtPrescription.Multiline = True
        Me.TxtPrescription.Name = "TxtPrescription"
        Me.TxtPrescription.Size = New System.Drawing.Size(416, 43)
        Me.TxtPrescription.TabIndex = 156
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(75, 83)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(416, 43)
        Me.TxtNotes.TabIndex = 158
        '
        'TxtTreatmentItem
        '
        Me.TxtTreatmentItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentItem.Location = New System.Drawing.Point(75, 17)
        Me.TxtTreatmentItem.Name = "TxtTreatmentItem"
        Me.TxtTreatmentItem.ReadOnly = True
        Me.TxtTreatmentItem.Size = New System.Drawing.Size(416, 21)
        Me.TxtTreatmentItem.TabIndex = 150
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 130)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 14)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Unit Price"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(10, 152)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(47, 14)
        Me.Label36.TabIndex = 159
        Me.Label36.Text = "Quantity"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 39)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 155
        Me.Label34.Text = "Prescription"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 83)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 14)
        Me.Label35.TabIndex = 157
        Me.Label35.Text = "Notes"
        '
        'BtnTreatmentItem
        '
        Me.BtnTreatmentItem.Location = New System.Drawing.Point(75, 196)
        Me.BtnTreatmentItem.Name = "BtnTreatmentItem"
        Me.BtnTreatmentItem.Size = New System.Drawing.Size(121, 23)
        Me.BtnTreatmentItem.TabIndex = 154
        Me.BtnTreatmentItem.Text = "Add Item"
        Me.BtnTreatmentItem.UseVisualStyleBackColor = True
        '
        'DgvSelectedTreatment
        '
        Me.DgvSelectedTreatment.AllowUserToAddRows = False
        Me.DgvSelectedTreatment.AllowUserToDeleteRows = False
        Me.DgvSelectedTreatment.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTreatment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTreatmentDeleteItem, Me.TreatmentRowNo, Me.TreatmentItemCode, Me.TreatmentItemDescription, Me.Prescription, Me.Notes, Me.TreatmentUnitPrice, Me.TreatmentQuantity, Me.TreatmentTotalPrice, Me.TreatmentItemGroup, Me.TreatmentItemTypeCode, Me.TreatmentItemTypeDescription})
        Me.DgvSelectedTreatment.Location = New System.Drawing.Point(9, 225)
        Me.DgvSelectedTreatment.Name = "DgvSelectedTreatment"
        Me.DgvSelectedTreatment.ReadOnly = True
        Me.DgvSelectedTreatment.Size = New System.Drawing.Size(724, 144)
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
        Me.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Width = 60
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
        Me.TreatmentItemGroup.HeaderText = "Item Group"
        Me.TreatmentItemGroup.Name = "TreatmentItemGroup"
        Me.TreatmentItemGroup.ReadOnly = True
        Me.TreatmentItemGroup.Visible = False
        '
        'TreatmentItemTypeCode
        '
        Me.TreatmentItemTypeCode.HeaderText = "Item Type Code"
        Me.TreatmentItemTypeCode.Name = "TreatmentItemTypeCode"
        Me.TreatmentItemTypeCode.ReadOnly = True
        Me.TreatmentItemTypeCode.Visible = False
        '
        'TreatmentItemTypeDescription
        '
        Me.TreatmentItemTypeDescription.HeaderText = "Item Type Description"
        Me.TreatmentItemTypeDescription.Name = "TreatmentItemTypeDescription"
        Me.TreatmentItemTypeDescription.ReadOnly = True
        Me.TreatmentItemTypeDescription.Visible = False
        '
        'BtnClearTreatment
        '
        Me.BtnClearTreatment.Location = New System.Drawing.Point(527, 15)
        Me.BtnClearTreatment.Name = "BtnClearTreatment"
        Me.BtnClearTreatment.Size = New System.Drawing.Size(77, 25)
        Me.BtnClearTreatment.TabIndex = 152
        Me.BtnClearTreatment.Text = "Clear"
        Me.BtnClearTreatment.UseVisualStyleBackColor = True
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(492, 15)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 151
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Item"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.TxtTestTotalPrice)
        Me.TabPage2.Controls.Add(Me.TxtTestQuantity)
        Me.TabPage2.Controls.Add(Me.TxtTestItem)
        Me.TabPage2.Controls.Add(Me.TxtTestUnitPrice)
        Me.TabPage2.Controls.Add(Me.TxtDiagnosis)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.BtnClearTest)
        Me.TabPage2.Controls.Add(Me.BtnSearchTestItem)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.BtnAddTest)
        Me.TabPage2.Controls.Add(Me.DgvSelectedTest)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Diagnosis & Tests"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 14)
        Me.Label17.TabIndex = 169
        Me.Label17.Text = "Total Price"
        '
        'TxtTestTotalPrice
        '
        Me.TxtTestTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestTotalPrice.Location = New System.Drawing.Point(72, 80)
        Me.TxtTestTotalPrice.Name = "TxtTestTotalPrice"
        Me.TxtTestTotalPrice.ReadOnly = True
        Me.TxtTestTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTestTotalPrice.TabIndex = 170
        Me.TxtTestTotalPrice.Text = "0.00"
        Me.TxtTestTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTestQuantity
        '
        Me.TxtTestQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTestQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestQuantity.Location = New System.Drawing.Point(72, 58)
        Me.TxtTestQuantity.Name = "TxtTestQuantity"
        Me.TxtTestQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtTestQuantity.TabIndex = 168
        Me.TxtTestQuantity.Text = "1.00"
        Me.TxtTestQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTestItem
        '
        Me.TxtTestItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTestItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestItem.Location = New System.Drawing.Point(72, 14)
        Me.TxtTestItem.Name = "TxtTestItem"
        Me.TxtTestItem.ReadOnly = True
        Me.TxtTestItem.Size = New System.Drawing.Size(374, 21)
        Me.TxtTestItem.TabIndex = 164
        '
        'TxtTestUnitPrice
        '
        Me.TxtTestUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestUnitPrice.Location = New System.Drawing.Point(72, 36)
        Me.TxtTestUnitPrice.Name = "TxtTestUnitPrice"
        Me.TxtTestUnitPrice.ReadOnly = True
        Me.TxtTestUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTestUnitPrice.TabIndex = 162
        Me.TxtTestUnitPrice.Text = "0.00"
        Me.TxtTestUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosis.Location = New System.Drawing.Point(15, 295)
        Me.TxtDiagnosis.Multiline = True
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(712, 74)
        Me.TxtDiagnosis.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Quantity"
        '
        'BtnClearTest
        '
        Me.BtnClearTest.Location = New System.Drawing.Point(482, 12)
        Me.BtnClearTest.Name = "BtnClearTest"
        Me.BtnClearTest.Size = New System.Drawing.Size(77, 25)
        Me.BtnClearTest.TabIndex = 166
        Me.BtnClearTest.Text = "Clear"
        Me.BtnClearTest.UseVisualStyleBackColor = True
        '
        'BtnSearchTestItem
        '
        Me.BtnSearchTestItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchTestItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchTestItem.Location = New System.Drawing.Point(447, 12)
        Me.BtnSearchTestItem.Name = "BtnSearchTestItem"
        Me.BtnSearchTestItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchTestItem.TabIndex = 165
        Me.BtnSearchTestItem.Text = "..."
        Me.BtnSearchTestItem.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 14)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Item"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 14)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "Unit Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Selected Test(s) :"
        '
        'BtnAddTest
        '
        Me.BtnAddTest.Location = New System.Drawing.Point(72, 106)
        Me.BtnAddTest.Name = "BtnAddTest"
        Me.BtnAddTest.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddTest.TabIndex = 19
        Me.BtnAddTest.Text = "Add Test"
        Me.BtnAddTest.UseVisualStyleBackColor = True
        '
        'DgvSelectedTest
        '
        Me.DgvSelectedTest.AllowUserToAddRows = False
        Me.DgvSelectedTest.AllowUserToDeleteRows = False
        Me.DgvSelectedTest.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTestDeleteItem, Me.TestRowNo, Me.TestItemCode, Me.TestItemDescription, Me.TestUnitPrice, Me.TestQuantity, Me.TestTotalPrice, Me.TestItemGroup, Me.TestItemTypeCode, Me.TestItemTypeDescription})
        Me.DgvSelectedTest.Location = New System.Drawing.Point(15, 153)
        Me.DgvSelectedTest.Name = "DgvSelectedTest"
        Me.DgvSelectedTest.ReadOnly = True
        Me.DgvSelectedTest.Size = New System.Drawing.Size(712, 121)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Diagnosis && Planning :"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtWardDate)
        Me.TabPage1.Controls.Add(Me.TxtFastingDescription)
        Me.TabPage1.Controls.Add(Me.CmbFasting)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.CmbFood)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.TxtDailyNotes)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CmbVomit)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CmbBowel)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CmbUrine)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CmbAppetite)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 375)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Daily Ward Update"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtWardDate
        '
        Me.TxtWardDate.BackColor = System.Drawing.Color.Beige
        Me.TxtWardDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWardDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWardDate.Location = New System.Drawing.Point(76, 14)
        Me.TxtWardDate.Name = "TxtWardDate"
        Me.TxtWardDate.Size = New System.Drawing.Size(121, 21)
        Me.TxtWardDate.TabIndex = 108
        Me.TxtWardDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFastingDescription
        '
        Me.TxtFastingDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFastingDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFastingDescription.Location = New System.Drawing.Point(267, 85)
        Me.TxtFastingDescription.Multiline = True
        Me.TxtFastingDescription.Name = "TxtFastingDescription"
        Me.TxtFastingDescription.Size = New System.Drawing.Size(312, 46)
        Me.TxtFastingDescription.TabIndex = 19
        '
        'CmbFasting
        '
        Me.CmbFasting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFasting.FormattingEnabled = True
        Me.CmbFasting.Location = New System.Drawing.Point(267, 61)
        Me.CmbFasting.Name = "CmbFasting"
        Me.CmbFasting.Size = New System.Drawing.Size(121, 22)
        Me.CmbFasting.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(223, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 14)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Fasting"
        '
        'CmbFood
        '
        Me.CmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFood.FormattingEnabled = True
        Me.CmbFood.Location = New System.Drawing.Point(267, 37)
        Me.CmbFood.Name = "CmbFood"
        Me.CmbFood.Size = New System.Drawing.Size(121, 22)
        Me.CmbFood.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(223, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 14)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Food"
        '
        'TxtDailyNotes
        '
        Me.TxtDailyNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDailyNotes.Location = New System.Drawing.Point(22, 167)
        Me.TxtDailyNotes.Multiline = True
        Me.TxtDailyNotes.Name = "TxtDailyNotes"
        Me.TxtDailyNotes.Size = New System.Drawing.Size(692, 193)
        Me.TxtDailyNotes.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Daily Notes/Observation && Update:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'CmbVomit
        '
        Me.CmbVomit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVomit.FormattingEnabled = True
        Me.CmbVomit.Location = New System.Drawing.Point(76, 109)
        Me.CmbVomit.Name = "CmbVomit"
        Me.CmbVomit.Size = New System.Drawing.Size(121, 22)
        Me.CmbVomit.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vomit"
        '
        'CmbBowel
        '
        Me.CmbBowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBowel.FormattingEnabled = True
        Me.CmbBowel.Location = New System.Drawing.Point(76, 61)
        Me.CmbBowel.Name = "CmbBowel"
        Me.CmbBowel.Size = New System.Drawing.Size(121, 22)
        Me.CmbBowel.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bowel"
        '
        'CmbUrine
        '
        Me.CmbUrine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUrine.FormattingEnabled = True
        Me.CmbUrine.Location = New System.Drawing.Point(76, 85)
        Me.CmbUrine.Name = "CmbUrine"
        Me.CmbUrine.Size = New System.Drawing.Size(121, 22)
        Me.CmbUrine.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Urine"
        '
        'CmbAppetite
        '
        Me.CmbAppetite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAppetite.FormattingEnabled = True
        Me.CmbAppetite.Location = New System.Drawing.Point(76, 37)
        Me.CmbAppetite.Name = "CmbAppetite"
        Me.CmbAppetite.Size = New System.Drawing.Size(121, 22)
        Me.CmbAppetite.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Appetite"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 252)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 402)
        Me.TabControl1.TabIndex = 99
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvWardSummary)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(742, 375)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Ward Progress/Report/Summary"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvWardSummary
        '
        Me.DgvWardSummary.AllowUserToAddRows = False
        Me.DgvWardSummary.AllowUserToDeleteRows = False
        Me.DgvWardSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvWardSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WardDate, Me.DailyNotes, Me.Appetite, Me.Bowel, Me.Urine, Me.Vomit})
        Me.DgvWardSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvWardSummary.Location = New System.Drawing.Point(3, 3)
        Me.DgvWardSummary.Name = "DgvWardSummary"
        Me.DgvWardSummary.ReadOnly = True
        Me.DgvWardSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvWardSummary.Size = New System.Drawing.Size(736, 369)
        Me.DgvWardSummary.TabIndex = 0
        '
        'WardDate
        '
        Me.WardDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.WardDate.HeaderText = "Date"
        Me.WardDate.Name = "WardDate"
        Me.WardDate.ReadOnly = True
        Me.WardDate.Width = 54
        '
        'DailyNotes
        '
        Me.DailyNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DailyNotes.HeaderText = "Notes"
        Me.DailyNotes.Name = "DailyNotes"
        Me.DailyNotes.ReadOnly = True
        '
        'Appetite
        '
        Me.Appetite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Appetite.HeaderText = "Appetite"
        Me.Appetite.Name = "Appetite"
        Me.Appetite.ReadOnly = True
        Me.Appetite.Width = 72
        '
        'Bowel
        '
        Me.Bowel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Bowel.HeaderText = "Bowel"
        Me.Bowel.Name = "Bowel"
        Me.Bowel.ReadOnly = True
        Me.Bowel.Width = 63
        '
        'Urine
        '
        Me.Urine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Urine.HeaderText = "Urine"
        Me.Urine.Name = "Urine"
        Me.Urine.ReadOnly = True
        Me.Urine.Width = 57
        '
        'Vomit
        '
        Me.Vomit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Vomit.HeaderText = "Vomit"
        Me.Vomit.Name = "Vomit"
        Me.Vomit.ReadOnly = True
        Me.Vomit.Width = 58
        '
        'CbIsDischarged
        '
        Me.CbIsDischarged.AutoSize = True
        Me.CbIsDischarged.Location = New System.Drawing.Point(298, 22)
        Me.CbIsDischarged.Name = "CbIsDischarged"
        Me.CbIsDischarged.Size = New System.Drawing.Size(75, 18)
        Me.CbIsDischarged.TabIndex = 114
        Me.CbIsDischarged.Text = "Discharge"
        Me.CbIsDischarged.UseVisualStyleBackColor = True
        '
        'TxtCase
        '
        Me.TxtCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCase.Location = New System.Drawing.Point(117, 109)
        Me.TxtCase.Multiline = True
        Me.TxtCase.Name = "TxtCase"
        Me.TxtCase.Size = New System.Drawing.Size(312, 42)
        Me.TxtCase.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 111)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 15)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "Case"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDD)
        Me.GroupBox1.Controls.Add(Me.TxtAD)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtCase)
        Me.GroupBox1.Controls.Add(Me.TxtVisitID)
        Me.GroupBox1.Controls.Add(Me.BtnBillPayment)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TxtCustomerID)
        Me.GroupBox1.Controls.Add(Me.CbIsDischarged)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtAdmissionDate)
        Me.GroupBox1.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtWardID)
        Me.GroupBox1.Controls.Add(Me.TxtPetID)
        Me.GroupBox1.Controls.Add(Me.TxtPetName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 160)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Visit Details"
        '
        'TxtDD
        '
        Me.TxtDD.BackColor = System.Drawing.Color.Beige
        Me.TxtDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDD.Location = New System.Drawing.Point(558, 76)
        Me.TxtDD.Name = "TxtDD"
        Me.TxtDD.ReadOnly = True
        Me.TxtDD.Size = New System.Drawing.Size(175, 21)
        Me.TxtDD.TabIndex = 118
        '
        'TxtAD
        '
        Me.TxtAD.BackColor = System.Drawing.Color.Beige
        Me.TxtAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAD.Location = New System.Drawing.Point(558, 49)
        Me.TxtAD.Name = "TxtAD"
        Me.TxtAD.ReadOnly = True
        Me.TxtAD.Size = New System.Drawing.Size(175, 21)
        Me.TxtAD.TabIndex = 117
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 23)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Calculate Ward Charge"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmWardInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmWardInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ward Information"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvWardSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents TxtModifiedBy As TextBox
    Friend WithEvents TxtPetName As TextBox
    Friend WithEvents TxtPetID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents BtnBillPayment As Button
    Friend WithEvents TxtVisitID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtWardID As TextBox
    Friend WithEvents TxtAdmissionDate As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtTreatmentTotalPrice As TextBox
    Friend WithEvents TxtTreatmentUnitPrice As TextBox
    Friend WithEvents TxtTreatmentQuantity As TextBox
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents TxtTreatmentItem As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents BtnTreatmentItem As Button
    Friend WithEvents DgvSelectedTreatment As DataGridView
    Friend WithEvents BtnTreatmentDeleteItem As DataGridViewButtonColumn
    Friend WithEvents TreatmentRowNo As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemCode As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents Prescription As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents BtnClearTreatment As Button
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtTestTotalPrice As TextBox
    Friend WithEvents TxtTestQuantity As TextBox
    Friend WithEvents TxtTestItem As TextBox
    Friend WithEvents TxtTestUnitPrice As TextBox
    Friend WithEvents TxtDiagnosis As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnClearTest As Button
    Friend WithEvents BtnSearchTestItem As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnAddTest As Button
    Friend WithEvents DgvSelectedTest As DataGridView
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
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtDailyNotes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbVomit As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbBowel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbUrine As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbAppetite As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CbIsDischarged As CheckBox
    Friend WithEvents TxtCase As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents DgvWardSummary As DataGridView
    Friend WithEvents CmbFood As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CmbFasting As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtFastingDescription As TextBox
    Friend WithEvents WardDate As DataGridViewTextBoxColumn
    Friend WithEvents DailyNotes As DataGridViewTextBoxColumn
    Friend WithEvents Appetite As DataGridViewTextBoxColumn
    Friend WithEvents Bowel As DataGridViewTextBoxColumn
    Friend WithEvents Urine As DataGridViewTextBoxColumn
    Friend WithEvents Vomit As DataGridViewTextBoxColumn
    Friend WithEvents BtnReload As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtWardDate As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtDD As TextBox
    Friend WithEvents TxtAD As TextBox
End Class
