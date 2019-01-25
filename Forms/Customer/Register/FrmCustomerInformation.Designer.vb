<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerInformation
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerInformation))
        Me.CmbSalutation = New System.Windows.Forms.ComboBox()
        Me.TxtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTelNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TxtNRICPassportNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelEdit = New System.Windows.Forms.Button()
        Me.BtnClearPet = New System.Windows.Forms.Button()
        Me.BtnAddPet = New System.Windows.Forms.Button()
        Me.CmbSex = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DtpPetDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbAnimalType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DgvPetListing = New System.Windows.Forms.DataGridView()
        Me.DgvBtnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DgvBtnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnimalTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnimalTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreedCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreedName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeuterCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NeuterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtState = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtPostcode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LblPetRowIndex = New System.Windows.Forms.Label()
        Me.CmbNeuterStatus = New System.Windows.Forms.ComboBox()
        Me.CmbBreed = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvVisitHistory = New System.Windows.Forms.DataGridView()
        Me.VisitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsVisitCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvVisitHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbSalutation
        '
        Me.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSalutation.FormattingEnabled = True
        Me.CmbSalutation.Location = New System.Drawing.Point(94, 37)
        Me.CmbSalutation.Name = "CmbSalutation"
        Me.CmbSalutation.Size = New System.Drawing.Size(157, 22)
        Me.CmbSalutation.TabIndex = 1
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMobileNo.Location = New System.Drawing.Point(94, 124)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtMobileNo.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Phone (Mobile)"
        '
        'TxtAddress2
        '
        Me.TxtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress2.Location = New System.Drawing.Point(94, 216)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress2.TabIndex = 8
        '
        'TxtAddress3
        '
        Me.TxtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress3.Location = New System.Drawing.Point(94, 237)
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress3.TabIndex = 9
        '
        'TxtAddress4
        '
        Me.TxtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress4.Location = New System.Drawing.Point(94, 258)
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress4.TabIndex = 10
        '
        'TxtAddress1
        '
        Me.TxtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress1.Location = New System.Drawing.Point(94, 195)
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
        '
        'TxtTelNo
        '
        Me.TxtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelNo.Location = New System.Drawing.Point(94, 103)
        Me.TxtTelNo.Name = "TxtTelNo"
        Me.TxtTelNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtTelNo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone (Home)"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Location = New System.Drawing.Point(94, 61)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(305, 20)
        Me.TxtCustomerName.TabIndex = 2
        '
        'TxtNRICPassportNo
        '
        Me.TxtNRICPassportNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNRICPassportNo.Location = New System.Drawing.Point(94, 82)
        Me.TxtNRICPassportNo.Name = "TxtNRICPassportNo"
        Me.TxtNRICPassportNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtNRICPassportNo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NRIC/Passport"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salutation"
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerID.Location = New System.Drawing.Point(94, 9)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(157, 20)
        Me.TxtCustomerID.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID"
        '
        'BtnCancelEdit
        '
        Me.BtnCancelEdit.Location = New System.Drawing.Point(301, 155)
        Me.BtnCancelEdit.Name = "BtnCancelEdit"
        Me.BtnCancelEdit.Size = New System.Drawing.Size(100, 25)
        Me.BtnCancelEdit.TabIndex = 16
        Me.BtnCancelEdit.Text = "Cancel Edit"
        Me.BtnCancelEdit.UseVisualStyleBackColor = True
        Me.BtnCancelEdit.Visible = False
        '
        'BtnClearPet
        '
        Me.BtnClearPet.Location = New System.Drawing.Point(198, 155)
        Me.BtnClearPet.Name = "BtnClearPet"
        Me.BtnClearPet.Size = New System.Drawing.Size(100, 25)
        Me.BtnClearPet.TabIndex = 15
        Me.BtnClearPet.Text = "Clear"
        Me.BtnClearPet.UseVisualStyleBackColor = True
        '
        'BtnAddPet
        '
        Me.BtnAddPet.Location = New System.Drawing.Point(95, 155)
        Me.BtnAddPet.Name = "BtnAddPet"
        Me.BtnAddPet.Size = New System.Drawing.Size(100, 25)
        Me.BtnAddPet.TabIndex = 14
        Me.BtnAddPet.Text = "Add Pet"
        Me.BtnAddPet.UseVisualStyleBackColor = True
        '
        'CmbSex
        '
        Me.CmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSex.FormattingEnabled = True
        Me.CmbSex.Location = New System.Drawing.Point(95, 99)
        Me.CmbSex.Name = "CmbSex"
        Me.CmbSex.Size = New System.Drawing.Size(183, 22)
        Me.CmbSex.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 14)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 14)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Sex"
        '
        'DtpPetDOB
        '
        Me.DtpPetDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPetDOB.Location = New System.Drawing.Point(95, 29)
        Me.DtpPetDOB.Name = "DtpPetDOB"
        Me.DtpPetDOB.Size = New System.Drawing.Size(183, 20)
        Me.DtpPetDOB.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 14)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Date of Birth"
        '
        'CmbAnimalType
        '
        Me.CmbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnimalType.FormattingEnabled = True
        Me.CmbAnimalType.Location = New System.Drawing.Point(95, 51)
        Me.CmbAnimalType.Name = "CmbAnimalType"
        Me.CmbAnimalType.Size = New System.Drawing.Size(183, 22)
        Me.CmbAnimalType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Pet Name"
        '
        'TxtPetName
        '
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Location = New System.Drawing.Point(95, 8)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.Size = New System.Drawing.Size(183, 20)
        Me.TxtPetName.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Type of Animal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 14)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Breed"
        '
        'DgvPetListing
        '
        Me.DgvPetListing.AllowUserToAddRows = False
        Me.DgvPetListing.AllowUserToOrderColumns = True
        Me.DgvPetListing.AllowUserToResizeRows = False
        Me.DgvPetListing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPetListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvPetListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvPetListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPetListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvBtnEdit, Me.DgvBtnDelete, Me.PetID, Me.PetName, Me.PetDOB, Me.AnimalTypeCode, Me.AnimalTypeName, Me.BreedCode, Me.BreedName, Me.SexCode, Me.SexName, Me.NeuterCode, Me.NeuterName, Me.IsDb})
        Me.DgvPetListing.Location = New System.Drawing.Point(8, 187)
        Me.DgvPetListing.MultiSelect = False
        Me.DgvPetListing.Name = "DgvPetListing"
        Me.DgvPetListing.ReadOnly = True
        Me.DgvPetListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPetListing.Size = New System.Drawing.Size(836, 233)
        Me.DgvPetListing.TabIndex = 67
        '
        'DgvBtnEdit
        '
        Me.DgvBtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvBtnEdit.HeaderText = "Edit"
        Me.DgvBtnEdit.Name = "DgvBtnEdit"
        Me.DgvBtnEdit.ReadOnly = True
        Me.DgvBtnEdit.Text = "Edit"
        Me.DgvBtnEdit.UseColumnTextForButtonValue = True
        Me.DgvBtnEdit.Width = 30
        '
        'DgvBtnDelete
        '
        Me.DgvBtnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DgvBtnDelete.HeaderText = "Delete?"
        Me.DgvBtnDelete.Name = "DgvBtnDelete"
        Me.DgvBtnDelete.ReadOnly = True
        Me.DgvBtnDelete.Text = "Delete"
        Me.DgvBtnDelete.UseColumnTextForButtonValue = True
        Me.DgvBtnDelete.Width = 49
        '
        'PetID
        '
        Me.PetID.HeaderText = "Pet ID"
        Me.PetID.Name = "PetID"
        Me.PetID.ReadOnly = True
        Me.PetID.Width = 59
        '
        'PetName
        '
        Me.PetName.HeaderText = "Pet Name"
        Me.PetName.Name = "PetName"
        Me.PetName.ReadOnly = True
        Me.PetName.Width = 77
        '
        'PetDOB
        '
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PetDOB.DefaultCellStyle = DataGridViewCellStyle10
        Me.PetDOB.HeaderText = "DOB"
        Me.PetDOB.Name = "PetDOB"
        Me.PetDOB.ReadOnly = True
        Me.PetDOB.Width = 54
        '
        'AnimalTypeCode
        '
        Me.AnimalTypeCode.HeaderText = "AnimalTypeCode"
        Me.AnimalTypeCode.Name = "AnimalTypeCode"
        Me.AnimalTypeCode.ReadOnly = True
        Me.AnimalTypeCode.Visible = False
        Me.AnimalTypeCode.Width = 112
        '
        'AnimalTypeName
        '
        Me.AnimalTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AnimalTypeName.HeaderText = "Animal Type"
        Me.AnimalTypeName.Name = "AnimalTypeName"
        Me.AnimalTypeName.ReadOnly = True
        Me.AnimalTypeName.Width = 90
        '
        'BreedCode
        '
        Me.BreedCode.HeaderText = "BreedCode"
        Me.BreedCode.Name = "BreedCode"
        Me.BreedCode.ReadOnly = True
        Me.BreedCode.Visible = False
        Me.BreedCode.Width = 86
        '
        'BreedName
        '
        Me.BreedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BreedName.HeaderText = "Breed"
        Me.BreedName.Name = "BreedName"
        Me.BreedName.ReadOnly = True
        '
        'SexCode
        '
        Me.SexCode.HeaderText = "SexCode"
        Me.SexCode.Name = "SexCode"
        Me.SexCode.ReadOnly = True
        Me.SexCode.Visible = False
        Me.SexCode.Width = 76
        '
        'SexName
        '
        Me.SexName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SexName.HeaderText = "Sex"
        Me.SexName.Name = "SexName"
        Me.SexName.ReadOnly = True
        Me.SexName.Width = 51
        '
        'NeuterCode
        '
        Me.NeuterCode.HeaderText = "StatusCode"
        Me.NeuterCode.Name = "NeuterCode"
        Me.NeuterCode.ReadOnly = True
        Me.NeuterCode.Visible = False
        Me.NeuterCode.Width = 88
        '
        'NeuterName
        '
        Me.NeuterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NeuterName.HeaderText = "Status"
        Me.NeuterName.Name = "NeuterName"
        Me.NeuterName.ReadOnly = True
        Me.NeuterName.Width = 63
        '
        'IsDb
        '
        Me.IsDb.HeaderText = "IsDb"
        Me.IsDb.Name = "IsDb"
        Me.IsDb.ReadOnly = True
        Me.IsDb.Visible = False
        Me.IsDb.Width = 53
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(860, 453)
        Me.TabControl1.TabIndex = 68
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.TxtCountry)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.TxtTelNo)
        Me.TabPage1.Controls.Add(Me.TxtCity)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.TxtAddress3)
        Me.TabPage1.Controls.Add(Me.TxtState)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtPostcode)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.TxtNRICPassportNo)
        Me.TabPage1.Controls.Add(Me.TxtMobileNo)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TxtAddress4)
        Me.TabPage1.Controls.Add(Me.TxtCustomerID)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.CmbSalutation)
        Me.TabPage1.Controls.Add(Me.TxtCustomerName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(852, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 368)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCountry.Location = New System.Drawing.Point(94, 365)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(157, 20)
        Me.TxtCountry.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 326)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 14)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "City"
        '
        'TxtCity
        '
        Me.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCity.Location = New System.Drawing.Point(94, 323)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(157, 20)
        Me.TxtCity.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 347)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 14)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "State"
        '
        'TxtState
        '
        Me.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtState.Location = New System.Drawing.Point(94, 344)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.Size = New System.Drawing.Size(157, 20)
        Me.TxtState.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 305)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Postcode"
        '
        'TxtPostcode
        '
        Me.TxtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPostcode.Location = New System.Drawing.Point(94, 302)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.Size = New System.Drawing.Size(157, 20)
        Me.TxtPostcode.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 14)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(94, 145)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(305, 20)
        Me.TxtEmail.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LblPetRowIndex)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.DtpPetDOB)
        Me.TabPage2.Controls.Add(Me.CmbSex)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.CmbNeuterStatus)
        Me.TabPage2.Controls.Add(Me.BtnAddPet)
        Me.TabPage2.Controls.Add(Me.CmbBreed)
        Me.TabPage2.Controls.Add(Me.CmbAnimalType)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.BtnClearPet)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.BtnCancelEdit)
        Me.TabPage2.Controls.Add(Me.DgvPetListing)
        Me.TabPage2.Controls.Add(Me.TxtPetName)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(852, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pet Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LblPetRowIndex
        '
        Me.LblPetRowIndex.AutoSize = True
        Me.LblPetRowIndex.Location = New System.Drawing.Point(282, 10)
        Me.LblPetRowIndex.Name = "LblPetRowIndex"
        Me.LblPetRowIndex.Size = New System.Drawing.Size(56, 14)
        Me.LblPetRowIndex.TabIndex = 68
        Me.LblPetRowIndex.Text = "RowIndex"
        Me.LblPetRowIndex.Visible = False
        '
        'CmbNeuterStatus
        '
        Me.CmbNeuterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNeuterStatus.FormattingEnabled = True
        Me.CmbNeuterStatus.Location = New System.Drawing.Point(95, 123)
        Me.CmbNeuterStatus.Name = "CmbNeuterStatus"
        Me.CmbNeuterStatus.Size = New System.Drawing.Size(183, 22)
        Me.CmbNeuterStatus.TabIndex = 13
        '
        'CmbBreed
        '
        Me.CmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBreed.FormattingEnabled = True
        Me.CmbBreed.Location = New System.Drawing.Point(95, 75)
        Me.CmbBreed.Name = "CmbBreed"
        Me.CmbBreed.Size = New System.Drawing.Size(183, 22)
        Me.CmbBreed.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvVisitHistory)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(852, 426)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Visit History"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvVisitHistory
        '
        Me.DgvVisitHistory.AllowUserToAddRows = False
        Me.DgvVisitHistory.AllowUserToDeleteRows = False
        Me.DgvVisitHistory.AllowUserToOrderColumns = True
        Me.DgvVisitHistory.BackgroundColor = System.Drawing.Color.White
        Me.DgvVisitHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVisitHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitID, Me.VisitTime, Me.VisitDescription, Me.EmployeeName, Me.IsVisitCompleted})
        Me.DgvVisitHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVisitHistory.GridColor = System.Drawing.SystemColors.Control
        Me.DgvVisitHistory.Location = New System.Drawing.Point(3, 3)
        Me.DgvVisitHistory.Name = "DgvVisitHistory"
        Me.DgvVisitHistory.ReadOnly = True
        Me.DgvVisitHistory.Size = New System.Drawing.Size(846, 420)
        Me.DgvVisitHistory.TabIndex = 0
        '
        'VisitID
        '
        Me.VisitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VisitID.HeaderText = "Visit ID"
        Me.VisitID.Name = "VisitID"
        Me.VisitID.ReadOnly = True
        Me.VisitID.Width = 60
        '
        'VisitTime
        '
        Me.VisitTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VisitTime.HeaderText = "Visit Time"
        Me.VisitTime.Name = "VisitTime"
        Me.VisitTime.ReadOnly = True
        Me.VisitTime.Width = 72
        '
        'VisitDescription
        '
        Me.VisitDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VisitDescription.HeaderText = "Visit Description"
        Me.VisitDescription.Name = "VisitDescription"
        Me.VisitDescription.ReadOnly = True
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EmployeeName.HeaderText = "Vet"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 48
        '
        'IsVisitCompleted
        '
        Me.IsVisitCompleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IsVisitCompleted.HeaderText = "Status"
        Me.IsVisitCompleted.Name = "IsVisitCompleted"
        Me.IsVisitCompleted.ReadOnly = True
        Me.IsVisitCompleted.Width = 63
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.BtnReload)
        Me.PnlActionBar.Controls.Add(Me.Label25)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(860, 68)
        Me.PnlActionBar.TabIndex = 69
        '
        'BtnReload
        '
        Me.BtnReload.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReload.BackgroundImage = CType(resources.GetObject("BtnReload.BackgroundImage"), System.Drawing.Image)
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReload.Location = New System.Drawing.Point(490, 4)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(60, 60)
        Me.BtnReload.TabIndex = 80
        Me.BtnReload.UseVisualStyleBackColor = False
        Me.BtnReload.Visible = False
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
        Me.Label25.Text = "Customer Information"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(552, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 60)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        Me.BtnPrint.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(796, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 60)
        Me.BtnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(674, 4)
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
        Me.BtnEdit.Location = New System.Drawing.Point(735, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 60)
        Me.BtnEdit.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(613, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 7)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Created By"
        '
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 29)
        Me.TxtModifiedBy.Name = "TxtModifiedBy"
        Me.TxtModifiedBy.ReadOnly = True
        Me.TxtModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtModifiedBy.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 14)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Modified By"
        '
        'TxtDateCreated
        '
        Me.TxtDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateCreated.Location = New System.Drawing.Point(143, 7)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Location = New System.Drawing.Point(143, 29)
        Me.TxtDateModified.Name = "TxtDateModified"
        Me.TxtDateModified.ReadOnly = True
        Me.TxtDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateModified.TabIndex = 78
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
        Me.Panel3.Location = New System.Drawing.Point(12, 545)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(856, 56)
        Me.Panel3.TabIndex = 79
        '
        'FrmCustomerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(884, 610)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmCustomerInformation"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer & Pet Information"
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvVisitHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbSalutation As ComboBox
    Friend WithEvents TxtMobileNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTelNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents TxtNRICPassportNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvPetListing As DataGridView
    Friend WithEvents BtnCancelEdit As Button
    Friend WithEvents BtnClearPet As Button
    Friend WithEvents BtnAddPet As Button
    Friend WithEvents CmbSex As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DtpPetDOB As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents CmbAnimalType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPetName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents CmbBreed As ComboBox
    Friend WithEvents CmbNeuterStatus As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtModifiedBy As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtPostcode As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtState As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvVisitHistory As DataGridView
    Friend WithEvents VisitID As DataGridViewTextBoxColumn
    Friend WithEvents VisitTime As DataGridViewTextBoxColumn
    Friend WithEvents VisitDescription As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents IsVisitCompleted As DataGridViewTextBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnReload As Button
    Friend WithEvents LblPetRowIndex As Label
    Friend WithEvents DgvBtnEdit As DataGridViewButtonColumn
    Friend WithEvents DgvBtnDelete As DataGridViewButtonColumn
    Friend WithEvents PetID As DataGridViewTextBoxColumn
    Friend WithEvents PetName As DataGridViewTextBoxColumn
    Friend WithEvents PetDOB As DataGridViewTextBoxColumn
    Friend WithEvents AnimalTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents AnimalTypeName As DataGridViewTextBoxColumn
    Friend WithEvents BreedCode As DataGridViewTextBoxColumn
    Friend WithEvents BreedName As DataGridViewTextBoxColumn
    Friend WithEvents SexCode As DataGridViewTextBoxColumn
    Friend WithEvents SexName As DataGridViewTextBoxColumn
    Friend WithEvents NeuterCode As DataGridViewTextBoxColumn
    Friend WithEvents NeuterName As DataGridViewTextBoxColumn
    Friend WithEvents IsDb As DataGridViewTextBoxColumn
End Class
