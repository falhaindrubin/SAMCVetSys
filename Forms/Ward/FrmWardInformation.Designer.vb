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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.BtnSendToPharmacyWardTx = New System.Windows.Forms.Button()
        Me.DgvSelectedTreatment = New System.Windows.Forms.DataGridView()
        Me.BtnTreatmentDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnTreatmentEditItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TreatmentRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentPhRequestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblTreatmentRowNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.TxtTreatmentTotalPrice = New System.Windows.Forms.TextBox()
        Me.BtnClearTreatment = New System.Windows.Forms.Button()
        Me.TxtTreatmentUnitPrice = New System.Windows.Forms.TextBox()
        Me.BtnTreatmentItem = New System.Windows.Forms.Button()
        Me.TxtTreatmentQuantity = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtTreatmentPrescription = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtTreatmentNotes = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtTreatmentItem = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAddTest = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnSearchTestItem = New System.Windows.Forms.Button()
        Me.TxtTestTotalPrice = New System.Windows.Forms.TextBox()
        Me.BtnClearTest = New System.Windows.Forms.Button()
        Me.TxtTestQuantity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTestItem = New System.Windows.Forms.TextBox()
        Me.TxtTestUnitPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TxtDiagnosis = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.CmbFood = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CmbFasting = New System.Windows.Forms.ComboBox()
        Me.TxtFastingDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TxtDailyNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TxtWardDate = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CmbVomit = New System.Windows.Forms.ComboBox()
        Me.TxtVomitDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CmbUrine = New System.Windows.Forms.ComboBox()
        Me.TxtUrineDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbBowel = New System.Windows.Forms.ComboBox()
        Me.TxtBowelDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtAppetiteDescription = New System.Windows.Forms.TextBox()
        Me.CmbAppetite = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgvHourlyList = New System.Windows.Forms.DataGridView()
        Me.HourlyWardID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyEmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyWardTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyEmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyHourlyNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyDateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyModifiedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyDateModified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnAddHourlyNotes = New System.Windows.Forms.Button()
        Me.TxtHourlyNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNewWardTime = New System.Windows.Forms.Button()
        Me.TxtVet = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtWardHourlyTime = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvWardSummary = New System.Windows.Forms.DataGridView()
        Me.WardDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Appetite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bowel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Urine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vomit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.TxtAdditionalInstructions = New System.Windows.Forms.TextBox()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.TxtPossibleComplications = New System.Windows.Forms.TextBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.TxtDischargeReason = New System.Windows.Forms.TextBox()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.TxtDischargeCondition = New System.Windows.Forms.TextBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.TxtTreatmentSummary = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.TxtAdmitDiagnosis = New System.Windows.Forms.TextBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.TxtAdmitIssue = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.BtnDischargePet = New System.Windows.Forms.Button()
        Me.BtnSendToPharmacyWardDc = New System.Windows.Forms.Button()
        Me.DgvDischargeMedication = New System.Windows.Forms.DataGridView()
        Me.BtnDeleteSelectedMedication = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnUpdateSelectedMedication = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DiscMedRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedPhRequestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedPrescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscMedItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDiscMedDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.LblDiscMedRowNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSearchDiscMediItem = New System.Windows.Forms.Button()
        Me.TxtDischargeTotalPrice = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtDischargeUnitPrice = New System.Windows.Forms.TextBox()
        Me.BtnAddDischargeItem = New System.Windows.Forms.Button()
        Me.TxtDischargeQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDischargePrescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDischargeNotes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDischargeItem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.TxtDischargeDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbIsDischarged = New System.Windows.Forms.CheckBox()
        Me.TxtCase = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgvHourlyList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvWardSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        CType(Me.DgvDischargeMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
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
        Me.Panel3.Size = New System.Drawing.Size(1056, 57)
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
        Me.TxtPetName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPetName.Location = New System.Drawing.Point(439, 42)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.ReadOnly = True
        Me.TxtPetName.Size = New System.Drawing.Size(226, 20)
        Me.TxtPetName.TabIndex = 108
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(356, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 14)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Pet Name"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(439, 21)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(226, 20)
        Me.TxtCustomerName.TabIndex = 105
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(356, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 14)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Customer Name"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 14)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Ward ID"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.PnlActionBar.Size = New System.Drawing.Size(1056, 68)
        Me.PnlActionBar.TabIndex = 110
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(4, 18)
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
        Me.BtnReload.Location = New System.Drawing.Point(748, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 6
        Me.BtnReload.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(626, 4)
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
        Me.BtnPrint.Location = New System.Drawing.Point(687, 4)
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
        Me.BtnClose.Location = New System.Drawing.Point(992, 4)
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
        Me.BtnCancel.Location = New System.Drawing.Point(870, 4)
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
        Me.BtnEdit.Location = New System.Drawing.Point(931, 4)
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
        Me.BtnSave.Location = New System.Drawing.Point(809, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtWardID
        '
        Me.TxtWardID.BackColor = System.Drawing.Color.Beige
        Me.TxtWardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWardID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWardID.Location = New System.Drawing.Point(101, 21)
        Me.TxtWardID.Name = "TxtWardID"
        Me.TxtWardID.ReadOnly = True
        Me.TxtWardID.Size = New System.Drawing.Size(155, 20)
        Me.TxtWardID.TabIndex = 111
        '
        'TxtAdmissionDate
        '
        Me.TxtAdmissionDate.BackColor = System.Drawing.Color.Beige
        Me.TxtAdmissionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdmissionDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmissionDate.Location = New System.Drawing.Point(101, 42)
        Me.TxtAdmissionDate.Name = "TxtAdmissionDate"
        Me.TxtAdmissionDate.ReadOnly = True
        Me.TxtAdmissionDate.Size = New System.Drawing.Size(155, 20)
        Me.TxtAdmissionDate.TabIndex = 113
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 14)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Date of Admission"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox17)
        Me.TabPage3.Controls.Add(Me.GroupBox16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Treatment & Medication"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.BtnSendToPharmacyWardTx)
        Me.GroupBox17.Controls.Add(Me.DgvSelectedTreatment)
        Me.GroupBox17.Location = New System.Drawing.Point(502, 6)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(544, 412)
        Me.GroupBox17.TabIndex = 178
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Selected Treatment/Medication"
        '
        'BtnSendToPharmacyWardTx
        '
        Me.BtnSendToPharmacyWardTx.Location = New System.Drawing.Point(388, 377)
        Me.BtnSendToPharmacyWardTx.Name = "BtnSendToPharmacyWardTx"
        Me.BtnSendToPharmacyWardTx.Size = New System.Drawing.Size(150, 29)
        Me.BtnSendToPharmacyWardTx.TabIndex = 178
        Me.BtnSendToPharmacyWardTx.Text = "Send To Pharmacy..."
        Me.BtnSendToPharmacyWardTx.UseVisualStyleBackColor = True
        '
        'DgvSelectedTreatment
        '
        Me.DgvSelectedTreatment.AllowUserToAddRows = False
        Me.DgvSelectedTreatment.AllowUserToDeleteRows = False
        Me.DgvSelectedTreatment.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTreatment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTreatmentDeleteItem, Me.BtnTreatmentEditItem, Me.TreatmentRowNo, Me.TreatmentPhRequestID, Me.TreatmentItemCode, Me.TreatmentItemDescription, Me.TreatmentPrescription, Me.TreatmentNotes, Me.TreatmentUnitPrice, Me.TreatmentQuantity, Me.TreatmentTotalPrice, Me.TreatmentItemGroup, Me.TreatmentItemTypeCode, Me.TreatmentItemTypeDescription})
        Me.DgvSelectedTreatment.Location = New System.Drawing.Point(3, 19)
        Me.DgvSelectedTreatment.Name = "DgvSelectedTreatment"
        Me.DgvSelectedTreatment.ReadOnly = True
        Me.DgvSelectedTreatment.Size = New System.Drawing.Size(536, 352)
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
        'BtnTreatmentEditItem
        '
        Me.BtnTreatmentEditItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnTreatmentEditItem.HeaderText = "Edit"
        Me.BtnTreatmentEditItem.Name = "BtnTreatmentEditItem"
        Me.BtnTreatmentEditItem.ReadOnly = True
        Me.BtnTreatmentEditItem.Text = "Edit"
        Me.BtnTreatmentEditItem.ToolTipText = "Edit"
        Me.BtnTreatmentEditItem.UseColumnTextForButtonValue = True
        Me.BtnTreatmentEditItem.Width = 30
        '
        'TreatmentRowNo
        '
        Me.TreatmentRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentRowNo.HeaderText = "No."
        Me.TreatmentRowNo.Name = "TreatmentRowNo"
        Me.TreatmentRowNo.ReadOnly = True
        Me.TreatmentRowNo.Width = 48
        '
        'TreatmentPhRequestID
        '
        Me.TreatmentPhRequestID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TreatmentPhRequestID.HeaderText = "PhRequestID"
        Me.TreatmentPhRequestID.Name = "TreatmentPhRequestID"
        Me.TreatmentPhRequestID.ReadOnly = True
        Me.TreatmentPhRequestID.Width = 93
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
        Me.TreatmentItemDescription.HeaderText = "Item Description"
        Me.TreatmentItemDescription.Name = "TreatmentItemDescription"
        Me.TreatmentItemDescription.ReadOnly = True
        Me.TreatmentItemDescription.Width = 300
        '
        'TreatmentPrescription
        '
        Me.TreatmentPrescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TreatmentPrescription.HeaderText = "Prescription"
        Me.TreatmentPrescription.Name = "TreatmentPrescription"
        Me.TreatmentPrescription.ReadOnly = True
        '
        'TreatmentNotes
        '
        Me.TreatmentNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TreatmentNotes.HeaderText = "Notes"
        Me.TreatmentNotes.Name = "TreatmentNotes"
        Me.TreatmentNotes.ReadOnly = True
        '
        'TreatmentUnitPrice
        '
        Me.TreatmentUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TreatmentUnitPrice.HeaderText = "Unit Price"
        Me.TreatmentUnitPrice.Name = "TreatmentUnitPrice"
        Me.TreatmentUnitPrice.ReadOnly = True
        Me.TreatmentUnitPrice.Visible = False
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
        Me.TreatmentTotalPrice.Visible = False
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
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Button1)
        Me.GroupBox16.Controls.Add(Me.LblTreatmentRowNo)
        Me.GroupBox16.Controls.Add(Me.Label12)
        Me.GroupBox16.Controls.Add(Me.Label18)
        Me.GroupBox16.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox16.Controls.Add(Me.TxtTreatmentTotalPrice)
        Me.GroupBox16.Controls.Add(Me.BtnClearTreatment)
        Me.GroupBox16.Controls.Add(Me.TxtTreatmentUnitPrice)
        Me.GroupBox16.Controls.Add(Me.BtnTreatmentItem)
        Me.GroupBox16.Controls.Add(Me.TxtTreatmentQuantity)
        Me.GroupBox16.Controls.Add(Me.Label35)
        Me.GroupBox16.Controls.Add(Me.TxtTreatmentPrescription)
        Me.GroupBox16.Controls.Add(Me.Label34)
        Me.GroupBox16.Controls.Add(Me.TxtTreatmentNotes)
        Me.GroupBox16.Controls.Add(Me.Label36)
        Me.GroupBox16.Controls.Add(Me.TxtTreatmentItem)
        Me.GroupBox16.Controls.Add(Me.Label20)
        Me.GroupBox16.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(490, 412)
        Me.GroupBox16.TabIndex = 177
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Select Treatment/Medication"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 29)
        Me.Button1.TabIndex = 179
        Me.Button1.Text = "New Pharmacy Request..."
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'LblTreatmentRowNo
        '
        Me.LblTreatmentRowNo.AutoSize = True
        Me.LblTreatmentRowNo.Location = New System.Drawing.Point(196, 208)
        Me.LblTreatmentRowNo.Name = "LblTreatmentRowNo"
        Me.LblTreatmentRowNo.Size = New System.Drawing.Size(105, 14)
        Me.LblTreatmentRowNo.TabIndex = 177
        Me.LblTreatmentRowNo.Text = "LblTreatmentRowNo"
        Me.LblTreatmentRowNo.Visible = False
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
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(373, 25)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 151
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'TxtTreatmentTotalPrice
        '
        Me.TxtTreatmentTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentTotalPrice.Location = New System.Drawing.Point(73, 178)
        Me.TxtTreatmentTotalPrice.Name = "TxtTreatmentTotalPrice"
        Me.TxtTreatmentTotalPrice.ReadOnly = True
        Me.TxtTreatmentTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTreatmentTotalPrice.TabIndex = 176
        Me.TxtTreatmentTotalPrice.Text = "0.00"
        Me.TxtTreatmentTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnClearTreatment
        '
        Me.BtnClearTreatment.Location = New System.Drawing.Point(407, 25)
        Me.BtnClearTreatment.Name = "BtnClearTreatment"
        Me.BtnClearTreatment.Size = New System.Drawing.Size(77, 25)
        Me.BtnClearTreatment.TabIndex = 152
        Me.BtnClearTreatment.Text = "Clear"
        Me.BtnClearTreatment.UseVisualStyleBackColor = True
        '
        'TxtTreatmentUnitPrice
        '
        Me.TxtTreatmentUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTreatmentUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentUnitPrice.Location = New System.Drawing.Point(73, 136)
        Me.TxtTreatmentUnitPrice.Name = "TxtTreatmentUnitPrice"
        Me.TxtTreatmentUnitPrice.ReadOnly = True
        Me.TxtTreatmentUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTreatmentUnitPrice.TabIndex = 172
        Me.TxtTreatmentUnitPrice.Text = "0.00"
        Me.TxtTreatmentUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnTreatmentItem
        '
        Me.BtnTreatmentItem.Location = New System.Drawing.Point(73, 204)
        Me.BtnTreatmentItem.Name = "BtnTreatmentItem"
        Me.BtnTreatmentItem.Size = New System.Drawing.Size(121, 23)
        Me.BtnTreatmentItem.TabIndex = 154
        Me.BtnTreatmentItem.Text = "Add Item..."
        Me.BtnTreatmentItem.UseVisualStyleBackColor = True
        '
        'TxtTreatmentQuantity
        '
        Me.TxtTreatmentQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTreatmentQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentQuantity.Location = New System.Drawing.Point(73, 157)
        Me.TxtTreatmentQuantity.Name = "TxtTreatmentQuantity"
        Me.TxtTreatmentQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtTreatmentQuantity.TabIndex = 160
        Me.TxtTreatmentQuantity.Text = "1.00"
        Me.TxtTreatmentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'TxtTreatmentPrescription
        '
        Me.TxtTreatmentPrescription.BackColor = System.Drawing.Color.White
        Me.TxtTreatmentPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentPrescription.Location = New System.Drawing.Point(73, 48)
        Me.TxtTreatmentPrescription.Multiline = True
        Me.TxtTreatmentPrescription.Name = "TxtTreatmentPrescription"
        Me.TxtTreatmentPrescription.Size = New System.Drawing.Size(300, 43)
        Me.TxtTreatmentPrescription.TabIndex = 156
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
        'TxtTreatmentNotes
        '
        Me.TxtTreatmentNotes.BackColor = System.Drawing.Color.White
        Me.TxtTreatmentNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentNotes.Location = New System.Drawing.Point(73, 92)
        Me.TxtTreatmentNotes.Multiline = True
        Me.TxtTreatmentNotes.Name = "TxtTreatmentNotes"
        Me.TxtTreatmentNotes.Size = New System.Drawing.Size(300, 43)
        Me.TxtTreatmentNotes.TabIndex = 158
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
        Me.TxtTreatmentItem.Location = New System.Drawing.Point(73, 27)
        Me.TxtTreatmentItem.Name = "TxtTreatmentItem"
        Me.TxtTreatmentItem.ReadOnly = True
        Me.TxtTreatmentItem.Size = New System.Drawing.Size(300, 20)
        Me.TxtTreatmentItem.TabIndex = 150
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox15)
        Me.TabPage2.Controls.Add(Me.GroupBox14)
        Me.TabPage2.Controls.Add(Me.GroupBox13)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Diagnosis & Tests"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.DgvSelectedTest)
        Me.GroupBox15.Location = New System.Drawing.Point(502, 6)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(544, 412)
        Me.GroupBox15.TabIndex = 173
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Selected Test(s)"
        '
        'DgvSelectedTest
        '
        Me.DgvSelectedTest.AllowUserToAddRows = False
        Me.DgvSelectedTest.AllowUserToDeleteRows = False
        Me.DgvSelectedTest.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedTest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnTestDeleteItem, Me.TestRowNo, Me.TestItemCode, Me.TestItemDescription, Me.TestUnitPrice, Me.TestQuantity, Me.TestTotalPrice, Me.TestItemGroup, Me.TestItemTypeCode, Me.TestItemTypeDescription})
        Me.DgvSelectedTest.Location = New System.Drawing.Point(3, 19)
        Me.DgvSelectedTest.Name = "DgvSelectedTest"
        Me.DgvSelectedTest.ReadOnly = True
        Me.DgvSelectedTest.Size = New System.Drawing.Size(538, 390)
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
        Me.TestRowNo.Visible = False
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
        Me.TestTotalPrice.Visible = False
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
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Label9)
        Me.GroupBox14.Controls.Add(Me.BtnAddTest)
        Me.GroupBox14.Controls.Add(Me.Label13)
        Me.GroupBox14.Controls.Add(Me.Label17)
        Me.GroupBox14.Controls.Add(Me.BtnSearchTestItem)
        Me.GroupBox14.Controls.Add(Me.TxtTestTotalPrice)
        Me.GroupBox14.Controls.Add(Me.BtnClearTest)
        Me.GroupBox14.Controls.Add(Me.TxtTestQuantity)
        Me.GroupBox14.Controls.Add(Me.Label10)
        Me.GroupBox14.Controls.Add(Me.TxtTestItem)
        Me.GroupBox14.Controls.Add(Me.TxtTestUnitPrice)
        Me.GroupBox14.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(490, 143)
        Me.GroupBox14.TabIndex = 172
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Search Test"
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
        'BtnAddTest
        '
        Me.BtnAddTest.Location = New System.Drawing.Point(73, 113)
        Me.BtnAddTest.Name = "BtnAddTest"
        Me.BtnAddTest.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddTest.TabIndex = 19
        Me.BtnAddTest.Text = "Add Test"
        Me.BtnAddTest.UseVisualStyleBackColor = True
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
        Me.BtnSearchTestItem.Location = New System.Drawing.Point(373, 25)
        Me.BtnSearchTestItem.Name = "BtnSearchTestItem"
        Me.BtnSearchTestItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchTestItem.TabIndex = 165
        Me.BtnSearchTestItem.Text = "..."
        Me.BtnSearchTestItem.UseVisualStyleBackColor = True
        '
        'TxtTestTotalPrice
        '
        Me.TxtTestTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestTotalPrice.Location = New System.Drawing.Point(73, 90)
        Me.TxtTestTotalPrice.Name = "TxtTestTotalPrice"
        Me.TxtTestTotalPrice.ReadOnly = True
        Me.TxtTestTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTestTotalPrice.TabIndex = 170
        Me.TxtTestTotalPrice.Text = "0.00"
        Me.TxtTestTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnClearTest
        '
        Me.BtnClearTest.Location = New System.Drawing.Point(407, 25)
        Me.BtnClearTest.Name = "BtnClearTest"
        Me.BtnClearTest.Size = New System.Drawing.Size(77, 25)
        Me.BtnClearTest.TabIndex = 166
        Me.BtnClearTest.Text = "Clear"
        Me.BtnClearTest.UseVisualStyleBackColor = True
        '
        'TxtTestQuantity
        '
        Me.TxtTestQuantity.BackColor = System.Drawing.Color.White
        Me.TxtTestQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestQuantity.Location = New System.Drawing.Point(73, 69)
        Me.TxtTestQuantity.Name = "TxtTestQuantity"
        Me.TxtTestQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtTestQuantity.TabIndex = 168
        Me.TxtTestQuantity.Text = "1.00"
        Me.TxtTestQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'TxtTestItem
        '
        Me.TxtTestItem.BackColor = System.Drawing.Color.Beige
        Me.TxtTestItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestItem.Location = New System.Drawing.Point(73, 27)
        Me.TxtTestItem.Name = "TxtTestItem"
        Me.TxtTestItem.ReadOnly = True
        Me.TxtTestItem.Size = New System.Drawing.Size(300, 20)
        Me.TxtTestItem.TabIndex = 164
        '
        'TxtTestUnitPrice
        '
        Me.TxtTestUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTestUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTestUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTestUnitPrice.Location = New System.Drawing.Point(73, 48)
        Me.TxtTestUnitPrice.Name = "TxtTestUnitPrice"
        Me.TxtTestUnitPrice.ReadOnly = True
        Me.TxtTestUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtTestUnitPrice.TabIndex = 162
        Me.TxtTestUnitPrice.Text = "0.00"
        Me.TxtTestUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.TxtDiagnosis)
        Me.GroupBox13.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(490, 263)
        Me.GroupBox13.TabIndex = 171
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Diagnosis && Planning"
        '
        'TxtDiagnosis
        '
        Me.TxtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiagnosis.Location = New System.Drawing.Point(6, 19)
        Me.TxtDiagnosis.Multiline = True
        Me.TxtDiagnosis.Name = "TxtDiagnosis"
        Me.TxtDiagnosis.Size = New System.Drawing.Size(478, 238)
        Me.TxtDiagnosis.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox12)
        Me.TabPage1.Controls.Add(Me.GroupBox11)
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Daily Ward Update"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.CmbFood)
        Me.GroupBox12.Location = New System.Drawing.Point(251, 219)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(240, 150)
        Me.GroupBox12.TabIndex = 125
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Food"
        '
        'CmbFood
        '
        Me.CmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFood.FormattingEnabled = True
        Me.CmbFood.Location = New System.Drawing.Point(6, 19)
        Me.CmbFood.Name = "CmbFood"
        Me.CmbFood.Size = New System.Drawing.Size(190, 22)
        Me.CmbFood.TabIndex = 16
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CmbFasting)
        Me.GroupBox11.Controls.Add(Me.TxtFastingDescription)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 219)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(240, 150)
        Me.GroupBox11.TabIndex = 124
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Fasting"
        '
        'CmbFasting
        '
        Me.CmbFasting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFasting.FormattingEnabled = True
        Me.CmbFasting.Location = New System.Drawing.Point(6, 19)
        Me.CmbFasting.Name = "CmbFasting"
        Me.CmbFasting.Size = New System.Drawing.Size(190, 22)
        Me.CmbFasting.TabIndex = 18
        '
        'TxtFastingDescription
        '
        Me.TxtFastingDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFastingDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFastingDescription.Location = New System.Drawing.Point(6, 47)
        Me.TxtFastingDescription.Multiline = True
        Me.TxtFastingDescription.Name = "TxtFastingDescription"
        Me.TxtFastingDescription.Size = New System.Drawing.Size(228, 97)
        Me.TxtFastingDescription.TabIndex = 19
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TxtDailyNotes)
        Me.GroupBox10.Location = New System.Drawing.Point(497, 219)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(486, 150)
        Me.GroupBox10.TabIndex = 123
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Daily Notes/Observation && Update"
        '
        'TxtDailyNotes
        '
        Me.TxtDailyNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDailyNotes.Location = New System.Drawing.Point(6, 19)
        Me.TxtDailyNotes.Multiline = True
        Me.TxtDailyNotes.Name = "TxtDailyNotes"
        Me.TxtDailyNotes.Size = New System.Drawing.Size(474, 125)
        Me.TxtDailyNotes.TabIndex = 14
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TxtWardDate)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 54)
        Me.GroupBox9.TabIndex = 122
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Ward Date"
        '
        'TxtWardDate
        '
        Me.TxtWardDate.BackColor = System.Drawing.Color.Beige
        Me.TxtWardDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWardDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWardDate.Location = New System.Drawing.Point(6, 20)
        Me.TxtWardDate.Name = "TxtWardDate"
        Me.TxtWardDate.Size = New System.Drawing.Size(228, 20)
        Me.TxtWardDate.TabIndex = 108
        Me.TxtWardDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CmbVomit)
        Me.GroupBox8.Controls.Add(Me.TxtVomitDescription)
        Me.GroupBox8.Location = New System.Drawing.Point(743, 66)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(240, 150)
        Me.GroupBox8.TabIndex = 121
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Vomit"
        '
        'CmbVomit
        '
        Me.CmbVomit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVomit.FormattingEnabled = True
        Me.CmbVomit.Location = New System.Drawing.Point(6, 19)
        Me.CmbVomit.Name = "CmbVomit"
        Me.CmbVomit.Size = New System.Drawing.Size(190, 22)
        Me.CmbVomit.TabIndex = 7
        '
        'TxtVomitDescription
        '
        Me.TxtVomitDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVomitDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVomitDescription.Location = New System.Drawing.Point(6, 47)
        Me.TxtVomitDescription.Multiline = True
        Me.TxtVomitDescription.Name = "TxtVomitDescription"
        Me.TxtVomitDescription.Size = New System.Drawing.Size(228, 97)
        Me.TxtVomitDescription.TabIndex = 112
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CmbUrine)
        Me.GroupBox7.Controls.Add(Me.TxtUrineDescription)
        Me.GroupBox7.Location = New System.Drawing.Point(251, 66)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(240, 150)
        Me.GroupBox7.TabIndex = 120
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Urine"
        '
        'CmbUrine
        '
        Me.CmbUrine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUrine.FormattingEnabled = True
        Me.CmbUrine.Location = New System.Drawing.Point(6, 19)
        Me.CmbUrine.Name = "CmbUrine"
        Me.CmbUrine.Size = New System.Drawing.Size(190, 22)
        Me.CmbUrine.TabIndex = 3
        '
        'TxtUrineDescription
        '
        Me.TxtUrineDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUrineDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUrineDescription.Location = New System.Drawing.Point(6, 46)
        Me.TxtUrineDescription.Multiline = True
        Me.TxtUrineDescription.Name = "TxtUrineDescription"
        Me.TxtUrineDescription.Size = New System.Drawing.Size(228, 97)
        Me.TxtUrineDescription.TabIndex = 111
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmbBowel)
        Me.GroupBox6.Controls.Add(Me.TxtBowelDescription)
        Me.GroupBox6.Location = New System.Drawing.Point(497, 66)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(240, 150)
        Me.GroupBox6.TabIndex = 119
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bowel"
        '
        'CmbBowel
        '
        Me.CmbBowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBowel.FormattingEnabled = True
        Me.CmbBowel.Location = New System.Drawing.Point(6, 19)
        Me.CmbBowel.Name = "CmbBowel"
        Me.CmbBowel.Size = New System.Drawing.Size(190, 22)
        Me.CmbBowel.TabIndex = 5
        '
        'TxtBowelDescription
        '
        Me.TxtBowelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBowelDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBowelDescription.Location = New System.Drawing.Point(6, 47)
        Me.TxtBowelDescription.Multiline = True
        Me.TxtBowelDescription.Name = "TxtBowelDescription"
        Me.TxtBowelDescription.Size = New System.Drawing.Size(228, 97)
        Me.TxtBowelDescription.TabIndex = 110
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtAppetiteDescription)
        Me.GroupBox5.Controls.Add(Me.CmbAppetite)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(240, 150)
        Me.GroupBox5.TabIndex = 118
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Appetite"
        '
        'TxtAppetiteDescription
        '
        Me.TxtAppetiteDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAppetiteDescription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAppetiteDescription.Location = New System.Drawing.Point(6, 47)
        Me.TxtAppetiteDescription.Multiline = True
        Me.TxtAppetiteDescription.Name = "TxtAppetiteDescription"
        Me.TxtAppetiteDescription.Size = New System.Drawing.Size(228, 97)
        Me.TxtAppetiteDescription.TabIndex = 109
        '
        'CmbAppetite
        '
        Me.CmbAppetite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAppetite.FormattingEnabled = True
        Me.CmbAppetite.Location = New System.Drawing.Point(6, 19)
        Me.CmbAppetite.Name = "CmbAppetite"
        Me.CmbAppetite.Size = New System.Drawing.Size(190, 22)
        Me.CmbAppetite.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(12, 203)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1060, 451)
        Me.TabControl1.TabIndex = 99
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Ward Hourly Check/Medication"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgvHourlyList)
        Me.GroupBox4.Location = New System.Drawing.Point(503, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(543, 277)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ward Hourly Summary"
        '
        'DgvHourlyList
        '
        Me.DgvHourlyList.AllowUserToAddRows = False
        Me.DgvHourlyList.AllowUserToDeleteRows = False
        Me.DgvHourlyList.BackgroundColor = System.Drawing.Color.White
        Me.DgvHourlyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHourlyList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HourlyWardID, Me.HourlyEmployeeID, Me.HourlyRowNo, Me.HourlyWardTime, Me.HourlyEmployeeName, Me.HourlyHourlyNotes, Me.HourlyCreatedBy, Me.HourlyDateCreated, Me.HourlyModifiedBy, Me.HourlyDateModified})
        Me.DgvHourlyList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvHourlyList.Location = New System.Drawing.Point(3, 16)
        Me.DgvHourlyList.Name = "DgvHourlyList"
        Me.DgvHourlyList.ReadOnly = True
        Me.DgvHourlyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvHourlyList.Size = New System.Drawing.Size(537, 258)
        Me.DgvHourlyList.TabIndex = 0
        '
        'HourlyWardID
        '
        Me.HourlyWardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HourlyWardID.HeaderText = "WardID"
        Me.HourlyWardID.Name = "HourlyWardID"
        Me.HourlyWardID.ReadOnly = True
        Me.HourlyWardID.Visible = False
        '
        'HourlyEmployeeID
        '
        Me.HourlyEmployeeID.HeaderText = "EmployeeID"
        Me.HourlyEmployeeID.Name = "HourlyEmployeeID"
        Me.HourlyEmployeeID.ReadOnly = True
        Me.HourlyEmployeeID.Visible = False
        '
        'HourlyRowNo
        '
        Me.HourlyRowNo.HeaderText = "No."
        Me.HourlyRowNo.Name = "HourlyRowNo"
        Me.HourlyRowNo.ReadOnly = True
        Me.HourlyRowNo.Visible = False
        '
        'HourlyWardTime
        '
        Me.HourlyWardTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HourlyWardTime.HeaderText = "Ward Time"
        Me.HourlyWardTime.Name = "HourlyWardTime"
        Me.HourlyWardTime.ReadOnly = True
        Me.HourlyWardTime.Width = 83
        '
        'HourlyEmployeeName
        '
        Me.HourlyEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HourlyEmployeeName.HeaderText = "Vet"
        Me.HourlyEmployeeName.Name = "HourlyEmployeeName"
        Me.HourlyEmployeeName.ReadOnly = True
        Me.HourlyEmployeeName.Width = 48
        '
        'HourlyHourlyNotes
        '
        Me.HourlyHourlyNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HourlyHourlyNotes.HeaderText = "Notes"
        Me.HourlyHourlyNotes.Name = "HourlyHourlyNotes"
        Me.HourlyHourlyNotes.ReadOnly = True
        '
        'HourlyCreatedBy
        '
        Me.HourlyCreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HourlyCreatedBy.HeaderText = "Created By"
        Me.HourlyCreatedBy.Name = "HourlyCreatedBy"
        Me.HourlyCreatedBy.ReadOnly = True
        Me.HourlyCreatedBy.Visible = False
        '
        'HourlyDateCreated
        '
        Me.HourlyDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HourlyDateCreated.HeaderText = "Date Created"
        Me.HourlyDateCreated.Name = "HourlyDateCreated"
        Me.HourlyDateCreated.ReadOnly = True
        Me.HourlyDateCreated.Visible = False
        '
        'HourlyModifiedBy
        '
        Me.HourlyModifiedBy.HeaderText = "Modified By"
        Me.HourlyModifiedBy.Name = "HourlyModifiedBy"
        Me.HourlyModifiedBy.ReadOnly = True
        Me.HourlyModifiedBy.Visible = False
        '
        'HourlyDateModified
        '
        Me.HourlyDateModified.HeaderText = "Date Modified"
        Me.HourlyDateModified.Name = "HourlyDateModified"
        Me.HourlyDateModified.ReadOnly = True
        Me.HourlyDateModified.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAddHourlyNotes)
        Me.GroupBox3.Controls.Add(Me.TxtHourlyNotes)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 277)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ward Hourly Notes"
        '
        'BtnAddHourlyNotes
        '
        Me.BtnAddHourlyNotes.Location = New System.Drawing.Point(356, 247)
        Me.BtnAddHourlyNotes.Name = "BtnAddHourlyNotes"
        Me.BtnAddHourlyNotes.Size = New System.Drawing.Size(129, 23)
        Me.BtnAddHourlyNotes.TabIndex = 119
        Me.BtnAddHourlyNotes.Text = "Add Hourly Notes..."
        Me.BtnAddHourlyNotes.UseVisualStyleBackColor = True
        '
        'TxtHourlyNotes
        '
        Me.TxtHourlyNotes.BackColor = System.Drawing.Color.White
        Me.TxtHourlyNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHourlyNotes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHourlyNotes.Location = New System.Drawing.Point(6, 19)
        Me.TxtHourlyNotes.Multiline = True
        Me.TxtHourlyNotes.Name = "TxtHourlyNotes"
        Me.TxtHourlyNotes.Size = New System.Drawing.Size(479, 222)
        Me.TxtHourlyNotes.TabIndex = 118
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNewWardTime)
        Me.GroupBox2.Controls.Add(Me.TxtVet)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.TxtWardHourlyTime)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1040, 80)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ward Hourly Infomation"
        '
        'BtnNewWardTime
        '
        Me.BtnNewWardTime.Location = New System.Drawing.Point(252, 25)
        Me.BtnNewWardTime.Name = "BtnNewWardTime"
        Me.BtnNewWardTime.Size = New System.Drawing.Size(118, 25)
        Me.BtnNewWardTime.TabIndex = 153
        Me.BtnNewWardTime.Text = "New Ward Time..."
        Me.BtnNewWardTime.UseVisualStyleBackColor = True
        '
        'TxtVet
        '
        Me.TxtVet.BackColor = System.Drawing.Color.Beige
        Me.TxtVet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVet.Location = New System.Drawing.Point(73, 48)
        Me.TxtVet.Name = "TxtVet"
        Me.TxtVet.ReadOnly = True
        Me.TxtVet.Size = New System.Drawing.Size(175, 20)
        Me.TxtVet.TabIndex = 117
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(10, 51)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(23, 14)
        Me.Label32.TabIndex = 116
        Me.Label32.Text = "Vet"
        '
        'TxtWardHourlyTime
        '
        Me.TxtWardHourlyTime.BackColor = System.Drawing.Color.Beige
        Me.TxtWardHourlyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWardHourlyTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWardHourlyTime.Location = New System.Drawing.Point(73, 27)
        Me.TxtWardHourlyTime.Name = "TxtWardHourlyTime"
        Me.TxtWardHourlyTime.ReadOnly = True
        Me.TxtWardHourlyTime.Size = New System.Drawing.Size(175, 20)
        Me.TxtWardHourlyTime.TabIndex = 115
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(10, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(58, 14)
        Me.Label31.TabIndex = 114
        Me.Label31.Text = "Ward Time"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvWardSummary)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Ward Progress/Report/Summary"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvWardSummary
        '
        Me.DgvWardSummary.AllowUserToAddRows = False
        Me.DgvWardSummary.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvWardSummary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvWardSummary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvWardSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvWardSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WardDate, Me.DailyNotes, Me.Appetite, Me.Bowel, Me.Urine, Me.Vomit})
        Me.DgvWardSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvWardSummary.Location = New System.Drawing.Point(3, 3)
        Me.DgvWardSummary.Name = "DgvWardSummary"
        Me.DgvWardSummary.ReadOnly = True
        Me.DgvWardSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvWardSummary.Size = New System.Drawing.Size(1046, 418)
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
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox26)
        Me.TabPage6.Controls.Add(Me.GroupBox25)
        Me.TabPage6.Controls.Add(Me.GroupBox23)
        Me.TabPage6.Controls.Add(Me.GroupBox22)
        Me.TabPage6.Controls.Add(Me.GroupBox21)
        Me.TabPage6.Controls.Add(Me.GroupBox20)
        Me.TabPage6.Controls.Add(Me.GroupBox19)
        Me.TabPage6.Controls.Add(Me.GroupBox18)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage6.TabIndex = 6
        Me.TabPage6.Text = "Ward Discharge Details"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.TxtAdditionalInstructions)
        Me.GroupBox26.Location = New System.Drawing.Point(508, 318)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(538, 100)
        Me.GroupBox26.TabIndex = 8
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Additional Instructions"
        '
        'TxtAdditionalInstructions
        '
        Me.TxtAdditionalInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAdditionalInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdditionalInstructions.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdditionalInstructions.Location = New System.Drawing.Point(6, 16)
        Me.TxtAdditionalInstructions.Multiline = True
        Me.TxtAdditionalInstructions.Name = "TxtAdditionalInstructions"
        Me.TxtAdditionalInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAdditionalInstructions.Size = New System.Drawing.Size(526, 75)
        Me.TxtAdditionalInstructions.TabIndex = 18
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.TxtPossibleComplications)
        Me.GroupBox25.Location = New System.Drawing.Point(508, 212)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(538, 100)
        Me.GroupBox25.TabIndex = 7
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Possible Complications"
        '
        'TxtPossibleComplications
        '
        Me.TxtPossibleComplications.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPossibleComplications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPossibleComplications.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPossibleComplications.Location = New System.Drawing.Point(6, 16)
        Me.TxtPossibleComplications.Multiline = True
        Me.TxtPossibleComplications.Name = "TxtPossibleComplications"
        Me.TxtPossibleComplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtPossibleComplications.Size = New System.Drawing.Size(526, 75)
        Me.TxtPossibleComplications.TabIndex = 18
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.TxtDischargeReason)
        Me.GroupBox23.Location = New System.Drawing.Point(508, 112)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(538, 100)
        Me.GroupBox23.TabIndex = 5
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Reason For Discharge"
        '
        'TxtDischargeReason
        '
        Me.TxtDischargeReason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDischargeReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeReason.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeReason.Location = New System.Drawing.Point(6, 19)
        Me.TxtDischargeReason.Multiline = True
        Me.TxtDischargeReason.Name = "TxtDischargeReason"
        Me.TxtDischargeReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDischargeReason.Size = New System.Drawing.Size(526, 75)
        Me.TxtDischargeReason.TabIndex = 17
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.TxtDischargeCondition)
        Me.GroupBox22.Location = New System.Drawing.Point(508, 6)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(538, 100)
        Me.GroupBox22.TabIndex = 4
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Diagnosis && Condition At Discharge"
        '
        'TxtDischargeCondition
        '
        Me.TxtDischargeCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDischargeCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeCondition.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeCondition.Location = New System.Drawing.Point(6, 19)
        Me.TxtDischargeCondition.Multiline = True
        Me.TxtDischargeCondition.Name = "TxtDischargeCondition"
        Me.TxtDischargeCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDischargeCondition.Size = New System.Drawing.Size(525, 75)
        Me.TxtDischargeCondition.TabIndex = 17
        '
        'GroupBox21
        '
        Me.GroupBox21.Location = New System.Drawing.Point(6, 318)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(493, 100)
        Me.GroupBox21.TabIndex = 3
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Test(s) Summary"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.TxtTreatmentSummary)
        Me.GroupBox20.Location = New System.Drawing.Point(6, 212)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(493, 100)
        Me.GroupBox20.TabIndex = 2
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Treatment Summary"
        '
        'TxtTreatmentSummary
        '
        Me.TxtTreatmentSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTreatmentSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTreatmentSummary.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTreatmentSummary.Location = New System.Drawing.Point(6, 16)
        Me.TxtTreatmentSummary.Multiline = True
        Me.TxtTreatmentSummary.Name = "TxtTreatmentSummary"
        Me.TxtTreatmentSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtTreatmentSummary.Size = New System.Drawing.Size(480, 75)
        Me.TxtTreatmentSummary.TabIndex = 18
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.TxtAdmitDiagnosis)
        Me.GroupBox19.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(493, 100)
        Me.GroupBox19.TabIndex = 1
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Diagnosis At Admittance"
        '
        'TxtAdmitDiagnosis
        '
        Me.TxtAdmitDiagnosis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAdmitDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdmitDiagnosis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmitDiagnosis.Location = New System.Drawing.Point(6, 19)
        Me.TxtAdmitDiagnosis.Multiline = True
        Me.TxtAdmitDiagnosis.Name = "TxtAdmitDiagnosis"
        Me.TxtAdmitDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAdmitDiagnosis.Size = New System.Drawing.Size(480, 75)
        Me.TxtAdmitDiagnosis.TabIndex = 17
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.TxtAdmitIssue)
        Me.GroupBox18.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(493, 100)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Problem At Admittance"
        '
        'TxtAdmitIssue
        '
        Me.TxtAdmitIssue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAdmitIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdmitIssue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdmitIssue.Location = New System.Drawing.Point(6, 19)
        Me.TxtAdmitIssue.Multiline = True
        Me.TxtAdmitIssue.Name = "TxtAdmitIssue"
        Me.TxtAdmitIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAdmitIssue.Size = New System.Drawing.Size(480, 75)
        Me.TxtAdmitIssue.TabIndex = 17
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox24)
        Me.TabPage7.Controls.Add(Me.GroupBox27)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1052, 424)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "Discharge Medication"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.BtnDischargePet)
        Me.GroupBox24.Controls.Add(Me.BtnSendToPharmacyWardDc)
        Me.GroupBox24.Controls.Add(Me.DgvDischargeMedication)
        Me.GroupBox24.Location = New System.Drawing.Point(502, 6)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(544, 412)
        Me.GroupBox24.TabIndex = 180
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Selected Medication"
        '
        'BtnDischargePet
        '
        Me.BtnDischargePet.Location = New System.Drawing.Point(232, 377)
        Me.BtnDischargePet.Name = "BtnDischargePet"
        Me.BtnDischargePet.Size = New System.Drawing.Size(150, 29)
        Me.BtnDischargePet.TabIndex = 180
        Me.BtnDischargePet.Text = "Discharge Pet..."
        Me.BtnDischargePet.UseVisualStyleBackColor = True
        '
        'BtnSendToPharmacyWardDc
        '
        Me.BtnSendToPharmacyWardDc.Location = New System.Drawing.Point(388, 377)
        Me.BtnSendToPharmacyWardDc.Name = "BtnSendToPharmacyWardDc"
        Me.BtnSendToPharmacyWardDc.Size = New System.Drawing.Size(150, 29)
        Me.BtnSendToPharmacyWardDc.TabIndex = 179
        Me.BtnSendToPharmacyWardDc.Text = "Send To Pharmacy..."
        Me.BtnSendToPharmacyWardDc.UseVisualStyleBackColor = True
        '
        'DgvDischargeMedication
        '
        Me.DgvDischargeMedication.AllowUserToAddRows = False
        Me.DgvDischargeMedication.AllowUserToDeleteRows = False
        Me.DgvDischargeMedication.BackgroundColor = System.Drawing.Color.White
        Me.DgvDischargeMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDischargeMedication.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnDeleteSelectedMedication, Me.BtnUpdateSelectedMedication, Me.DiscMedRowNo, Me.DiscMedPhRequestID, Me.DiscMedItemCode, Me.DiscMedItemDescription, Me.DiscMedPrescription, Me.DiscMedNotes, Me.DiscMedUnitPrice, Me.DiscMedQuantity, Me.DiscMedTotalPrice, Me.DiscMedItemGroup, Me.DiscMedItemTypeCode, Me.DiscMedItemTypeDescription, Me.IsDiscMedDb})
        Me.DgvDischargeMedication.Location = New System.Drawing.Point(3, 16)
        Me.DgvDischargeMedication.Name = "DgvDischargeMedication"
        Me.DgvDischargeMedication.ReadOnly = True
        Me.DgvDischargeMedication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDischargeMedication.Size = New System.Drawing.Size(535, 355)
        Me.DgvDischargeMedication.TabIndex = 153
        '
        'BtnDeleteSelectedMedication
        '
        Me.BtnDeleteSelectedMedication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnDeleteSelectedMedication.HeaderText = "Delete?"
        Me.BtnDeleteSelectedMedication.Name = "BtnDeleteSelectedMedication"
        Me.BtnDeleteSelectedMedication.ReadOnly = True
        Me.BtnDeleteSelectedMedication.Text = "Delete"
        Me.BtnDeleteSelectedMedication.UseColumnTextForButtonValue = True
        Me.BtnDeleteSelectedMedication.Width = 49
        '
        'BtnUpdateSelectedMedication
        '
        Me.BtnUpdateSelectedMedication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnUpdateSelectedMedication.HeaderText = "Update"
        Me.BtnUpdateSelectedMedication.Name = "BtnUpdateSelectedMedication"
        Me.BtnUpdateSelectedMedication.ReadOnly = True
        Me.BtnUpdateSelectedMedication.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BtnUpdateSelectedMedication.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BtnUpdateSelectedMedication.Text = "Update"
        Me.BtnUpdateSelectedMedication.ToolTipText = "Update Discharge Medication Item"
        Me.BtnUpdateSelectedMedication.UseColumnTextForButtonValue = True
        Me.BtnUpdateSelectedMedication.Width = 66
        '
        'DiscMedRowNo
        '
        Me.DiscMedRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DiscMedRowNo.HeaderText = "No."
        Me.DiscMedRowNo.Name = "DiscMedRowNo"
        Me.DiscMedRowNo.ReadOnly = True
        Me.DiscMedRowNo.Width = 48
        '
        'DiscMedPhRequestID
        '
        Me.DiscMedPhRequestID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DiscMedPhRequestID.HeaderText = "PhRequestID"
        Me.DiscMedPhRequestID.Name = "DiscMedPhRequestID"
        Me.DiscMedPhRequestID.ReadOnly = True
        Me.DiscMedPhRequestID.Visible = False
        '
        'DiscMedItemCode
        '
        Me.DiscMedItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DiscMedItemCode.HeaderText = "Item Code"
        Me.DiscMedItemCode.Name = "DiscMedItemCode"
        Me.DiscMedItemCode.ReadOnly = True
        Me.DiscMedItemCode.Width = 79
        '
        'DiscMedItemDescription
        '
        Me.DiscMedItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiscMedItemDescription.HeaderText = "Item Description"
        Me.DiscMedItemDescription.Name = "DiscMedItemDescription"
        Me.DiscMedItemDescription.ReadOnly = True
        '
        'DiscMedPrescription
        '
        Me.DiscMedPrescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiscMedPrescription.HeaderText = "Prescription"
        Me.DiscMedPrescription.Name = "DiscMedPrescription"
        Me.DiscMedPrescription.ReadOnly = True
        Me.DiscMedPrescription.Visible = False
        '
        'DiscMedNotes
        '
        Me.DiscMedNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiscMedNotes.HeaderText = "Notes"
        Me.DiscMedNotes.Name = "DiscMedNotes"
        Me.DiscMedNotes.ReadOnly = True
        Me.DiscMedNotes.Visible = False
        '
        'DiscMedUnitPrice
        '
        Me.DiscMedUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DiscMedUnitPrice.HeaderText = "Unit Price"
        Me.DiscMedUnitPrice.Name = "DiscMedUnitPrice"
        Me.DiscMedUnitPrice.ReadOnly = True
        Me.DiscMedUnitPrice.Visible = False
        '
        'DiscMedQuantity
        '
        Me.DiscMedQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DiscMedQuantity.HeaderText = "Quantity"
        Me.DiscMedQuantity.Name = "DiscMedQuantity"
        Me.DiscMedQuantity.ReadOnly = True
        Me.DiscMedQuantity.Width = 72
        '
        'DiscMedTotalPrice
        '
        Me.DiscMedTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DiscMedTotalPrice.HeaderText = "Total Price"
        Me.DiscMedTotalPrice.Name = "DiscMedTotalPrice"
        Me.DiscMedTotalPrice.ReadOnly = True
        Me.DiscMedTotalPrice.Visible = False
        '
        'DiscMedItemGroup
        '
        Me.DiscMedItemGroup.HeaderText = "Item Group"
        Me.DiscMedItemGroup.Name = "DiscMedItemGroup"
        Me.DiscMedItemGroup.ReadOnly = True
        Me.DiscMedItemGroup.Visible = False
        '
        'DiscMedItemTypeCode
        '
        Me.DiscMedItemTypeCode.HeaderText = "Item Type Code"
        Me.DiscMedItemTypeCode.Name = "DiscMedItemTypeCode"
        Me.DiscMedItemTypeCode.ReadOnly = True
        Me.DiscMedItemTypeCode.Visible = False
        '
        'DiscMedItemTypeDescription
        '
        Me.DiscMedItemTypeDescription.HeaderText = "Item Type Description"
        Me.DiscMedItemTypeDescription.Name = "DiscMedItemTypeDescription"
        Me.DiscMedItemTypeDescription.ReadOnly = True
        Me.DiscMedItemTypeDescription.Visible = False
        '
        'IsDiscMedDb
        '
        Me.IsDiscMedDb.HeaderText = "IsDb"
        Me.IsDiscMedDb.Name = "IsDiscMedDb"
        Me.IsDiscMedDb.ReadOnly = True
        Me.IsDiscMedDb.Visible = False
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.LblDiscMedRowNo)
        Me.GroupBox27.Controls.Add(Me.Label1)
        Me.GroupBox27.Controls.Add(Me.Label2)
        Me.GroupBox27.Controls.Add(Me.BtnSearchDiscMediItem)
        Me.GroupBox27.Controls.Add(Me.TxtDischargeTotalPrice)
        Me.GroupBox27.Controls.Add(Me.Button2)
        Me.GroupBox27.Controls.Add(Me.TxtDischargeUnitPrice)
        Me.GroupBox27.Controls.Add(Me.BtnAddDischargeItem)
        Me.GroupBox27.Controls.Add(Me.TxtDischargeQuantity)
        Me.GroupBox27.Controls.Add(Me.Label3)
        Me.GroupBox27.Controls.Add(Me.TxtDischargePrescription)
        Me.GroupBox27.Controls.Add(Me.Label4)
        Me.GroupBox27.Controls.Add(Me.TxtDischargeNotes)
        Me.GroupBox27.Controls.Add(Me.Label5)
        Me.GroupBox27.Controls.Add(Me.TxtDischargeItem)
        Me.GroupBox27.Controls.Add(Me.Label6)
        Me.GroupBox27.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(490, 412)
        Me.GroupBox27.TabIndex = 179
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Select Medication"
        '
        'LblDiscMedRowNo
        '
        Me.LblDiscMedRowNo.AutoSize = True
        Me.LblDiscMedRowNo.Location = New System.Drawing.Point(200, 208)
        Me.LblDiscMedRowNo.Name = "LblDiscMedRowNo"
        Me.LblDiscMedRowNo.Size = New System.Drawing.Size(98, 14)
        Me.LblDiscMedRowNo.TabIndex = 178
        Me.LblDiscMedRowNo.Text = "LblDiscMedRowNo"
        Me.LblDiscMedRowNo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 14)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Total Price"
        '
        'BtnSearchDiscMediItem
        '
        Me.BtnSearchDiscMediItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchDiscMediItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchDiscMediItem.Location = New System.Drawing.Point(373, 25)
        Me.BtnSearchDiscMediItem.Name = "BtnSearchDiscMediItem"
        Me.BtnSearchDiscMediItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchDiscMediItem.TabIndex = 151
        Me.BtnSearchDiscMediItem.Text = "..."
        Me.BtnSearchDiscMediItem.UseVisualStyleBackColor = True
        '
        'TxtDischargeTotalPrice
        '
        Me.TxtDischargeTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtDischargeTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeTotalPrice.Location = New System.Drawing.Point(73, 178)
        Me.TxtDischargeTotalPrice.Name = "TxtDischargeTotalPrice"
        Me.TxtDischargeTotalPrice.ReadOnly = True
        Me.TxtDischargeTotalPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtDischargeTotalPrice.TabIndex = 176
        Me.TxtDischargeTotalPrice.Text = "0.00"
        Me.TxtDischargeTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 25)
        Me.Button2.TabIndex = 152
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtDischargeUnitPrice
        '
        Me.TxtDischargeUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtDischargeUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeUnitPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeUnitPrice.Location = New System.Drawing.Point(73, 136)
        Me.TxtDischargeUnitPrice.Name = "TxtDischargeUnitPrice"
        Me.TxtDischargeUnitPrice.ReadOnly = True
        Me.TxtDischargeUnitPrice.Size = New System.Drawing.Size(52, 20)
        Me.TxtDischargeUnitPrice.TabIndex = 172
        Me.TxtDischargeUnitPrice.Text = "0.00"
        Me.TxtDischargeUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAddDischargeItem
        '
        Me.BtnAddDischargeItem.Location = New System.Drawing.Point(73, 204)
        Me.BtnAddDischargeItem.Name = "BtnAddDischargeItem"
        Me.BtnAddDischargeItem.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddDischargeItem.TabIndex = 154
        Me.BtnAddDischargeItem.Text = "Add Item..."
        Me.BtnAddDischargeItem.UseVisualStyleBackColor = True
        '
        'TxtDischargeQuantity
        '
        Me.TxtDischargeQuantity.BackColor = System.Drawing.Color.White
        Me.TxtDischargeQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeQuantity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeQuantity.Location = New System.Drawing.Point(73, 157)
        Me.TxtDischargeQuantity.Name = "TxtDischargeQuantity"
        Me.TxtDischargeQuantity.Size = New System.Drawing.Size(52, 20)
        Me.TxtDischargeQuantity.TabIndex = 160
        Me.TxtDischargeQuantity.Text = "1.00"
        Me.TxtDischargeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 14)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Notes"
        '
        'TxtDischargePrescription
        '
        Me.TxtDischargePrescription.BackColor = System.Drawing.Color.White
        Me.TxtDischargePrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargePrescription.Location = New System.Drawing.Point(73, 48)
        Me.TxtDischargePrescription.Multiline = True
        Me.TxtDischargePrescription.Name = "TxtDischargePrescription"
        Me.TxtDischargePrescription.Size = New System.Drawing.Size(300, 43)
        Me.TxtDischargePrescription.TabIndex = 156
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Prescription"
        '
        'TxtDischargeNotes
        '
        Me.TxtDischargeNotes.BackColor = System.Drawing.Color.White
        Me.TxtDischargeNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeNotes.Location = New System.Drawing.Point(73, 92)
        Me.TxtDischargeNotes.Multiline = True
        Me.TxtDischargeNotes.Name = "TxtDischargeNotes"
        Me.TxtDischargeNotes.Size = New System.Drawing.Size(300, 43)
        Me.TxtDischargeNotes.TabIndex = 158
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Quantity"
        '
        'TxtDischargeItem
        '
        Me.TxtDischargeItem.BackColor = System.Drawing.Color.Beige
        Me.TxtDischargeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeItem.Location = New System.Drawing.Point(73, 27)
        Me.TxtDischargeItem.Name = "TxtDischargeItem"
        Me.TxtDischargeItem.ReadOnly = True
        Me.TxtDischargeItem.Size = New System.Drawing.Size(300, 20)
        Me.TxtDischargeItem.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 14)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Unit Price"
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.TxtDischargeDate)
        Me.GroupBox28.Controls.Add(Me.Label8)
        Me.GroupBox28.Controls.Add(Me.CbIsDischarged)
        Me.GroupBox28.Location = New System.Drawing.Point(692, 86)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(376, 111)
        Me.GroupBox28.TabIndex = 1
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "Ward Status"
        '
        'TxtDischargeDate
        '
        Me.TxtDischargeDate.BackColor = System.Drawing.Color.Beige
        Me.TxtDischargeDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDischargeDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDischargeDate.Location = New System.Drawing.Point(116, 46)
        Me.TxtDischargeDate.Name = "TxtDischargeDate"
        Me.TxtDischargeDate.ReadOnly = True
        Me.TxtDischargeDate.Size = New System.Drawing.Size(155, 20)
        Me.TxtDischargeDate.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 14)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Date of Discharge"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbIsDischarged
        '
        Me.CbIsDischarged.AutoSize = True
        Me.CbIsDischarged.Location = New System.Drawing.Point(24, 28)
        Me.CbIsDischarged.Name = "CbIsDischarged"
        Me.CbIsDischarged.Size = New System.Drawing.Size(81, 18)
        Me.CbIsDischarged.TabIndex = 115
        Me.CbIsDischarged.Text = "Discharged"
        Me.CbIsDischarged.UseVisualStyleBackColor = True
        '
        'TxtCase
        '
        Me.TxtCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCase.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCase.Location = New System.Drawing.Point(101, 63)
        Me.TxtCase.Multiline = True
        Me.TxtCase.Name = "TxtCase"
        Me.TxtCase.Size = New System.Drawing.Size(253, 42)
        Me.TxtCase.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 14)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "Case"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtCase)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtAdmissionDate)
        Me.GroupBox1.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtWardID)
        Me.GroupBox1.Controls.Add(Me.TxtPetName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 111)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Visit Details"
        '
        'FrmWardInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 729)
        Me.Controls.Add(Me.GroupBox28)
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
        Me.GroupBox17.ResumeLayout(False)
        CType(Me.DgvSelectedTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.DgvSelectedTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DgvHourlyList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvWardSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        CType(Me.DgvDischargeMedication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
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
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label15 As Label
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
    Friend WithEvents TxtTreatmentPrescription As TextBox
    Friend WithEvents TxtTreatmentNotes As TextBox
    Friend WithEvents TxtTreatmentItem As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents BtnTreatmentItem As Button
    Friend WithEvents DgvSelectedTreatment As DataGridView
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
    Friend WithEvents BtnAddTest As Button
    Friend WithEvents DgvSelectedTest As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtDailyNotes As TextBox
    Friend WithEvents CmbVomit As ComboBox
    Friend WithEvents CmbBowel As ComboBox
    Friend WithEvents CmbUrine As ComboBox
    Friend WithEvents CmbAppetite As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TxtCase As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents DgvWardSummary As DataGridView
    Friend WithEvents CmbFood As ComboBox
    Friend WithEvents CmbFasting As ComboBox
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
    Friend WithEvents TxtVomitDescription As TextBox
    Friend WithEvents TxtUrineDescription As TextBox
    Friend WithEvents TxtBowelDescription As TextBox
    Friend WithEvents TxtAppetiteDescription As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtWardHourlyTime As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TxtVet As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DgvHourlyList As DataGridView
    Friend WithEvents TxtHourlyNotes As TextBox
    Friend WithEvents BtnAddHourlyNotes As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
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
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TxtDischargeReason As TextBox
    Friend WithEvents TxtDischargeCondition As TextBox
    Friend WithEvents TxtAdmitDiagnosis As TextBox
    Friend WithEvents TxtAdmitIssue As TextBox
    Friend WithEvents TxtAdditionalInstructions As TextBox
    Friend WithEvents TxtPossibleComplications As TextBox
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents DgvDischargeMedication As DataGridView
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSearchDiscMediItem As Button
    Friend WithEvents TxtDischargeTotalPrice As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtDischargeUnitPrice As TextBox
    Friend WithEvents BtnAddDischargeItem As Button
    Friend WithEvents TxtDischargeQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDischargePrescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDischargeNotes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDischargeItem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents CbIsDischarged As CheckBox
    Friend WithEvents TxtDischargeDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HourlyWardID As DataGridViewTextBoxColumn
    Friend WithEvents HourlyEmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRowNo As DataGridViewTextBoxColumn
    Friend WithEvents HourlyWardTime As DataGridViewTextBoxColumn
    Friend WithEvents HourlyEmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents HourlyHourlyNotes As DataGridViewTextBoxColumn
    Friend WithEvents HourlyCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents HourlyDateCreated As DataGridViewTextBoxColumn
    Friend WithEvents HourlyModifiedBy As DataGridViewTextBoxColumn
    Friend WithEvents HourlyDateModified As DataGridViewTextBoxColumn
    Friend WithEvents LblTreatmentRowNo As Label
    Friend WithEvents BtnNewWardTime As Button
    Friend WithEvents TxtTreatmentSummary As TextBox
    Friend WithEvents BtnSendToPharmacyWardTx As Button
    Friend WithEvents BtnSendToPharmacyWardDc As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnTreatmentDeleteItem As DataGridViewButtonColumn
    Friend WithEvents BtnTreatmentEditItem As DataGridViewButtonColumn
    Friend WithEvents TreatmentRowNo As DataGridViewTextBoxColumn
    Friend WithEvents TreatmentPhRequestID As DataGridViewTextBoxColumn
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
    Friend WithEvents LblDiscMedRowNo As Label
    Friend WithEvents BtnDischargePet As Button
    Friend WithEvents BtnDeleteSelectedMedication As DataGridViewButtonColumn
    Friend WithEvents BtnUpdateSelectedMedication As DataGridViewButtonColumn
    Friend WithEvents DiscMedRowNo As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedPhRequestID As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedItemCode As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedPrescription As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedNotes As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedQuantity As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents DiscMedItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents IsDiscMedDb As DataGridViewTextBoxColumn
End Class
