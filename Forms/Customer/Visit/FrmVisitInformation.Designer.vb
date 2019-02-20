<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVisitInformation
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisitInformation))
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgvPetListing = New System.Windows.Forms.DataGridView()
        Me.DgvBtnSelect = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTelNo = New System.Windows.Forms.TextBox()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMobileNo = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.TxtNRICPassportNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TpVisitInformation = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TxtVisitDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DgvSelectedPet = New System.Windows.Forms.DataGridView()
        Me.SelectedPetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedPetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedPetDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedAnimalTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedAnimalTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBreedCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBreedName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedSexCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedSexName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedNeuterCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedNeuterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtVet = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.DtpConsultationDate = New System.Windows.Forms.DateTimePicker()
        Me.DtpConsultationTime = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtVisitID = New System.Windows.Forms.TextBox()
        Me.TcVisitInformation = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtPEFindings = New System.Windows.Forms.TextBox()
        Me.CmbBodyScore = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CmbTemperament = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtTemperature = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtBodyWeight = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DgvSelectedItem = New System.Windows.Forms.DataGridView()
        Me.BtnChargesDeleteItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ChargesRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesPrescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesItemGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesItemTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargesItemTypeDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsChargeDb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.BtnSearchItem = New System.Windows.Forms.Button()
        Me.TxtPrescription = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.TxtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBillPayment = New System.Windows.Forms.Button()
        Me.CbIsAdmittedToWard = New System.Windows.Forms.CheckBox()
        Me.CbIsVisitCompleted = New System.Windows.Forms.CheckBox()
        Me.TxtSalutation = New System.Windows.Forms.TextBox()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.TpVisitInformation.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvSelectedPet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TcVisitInformation.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DgvSelectedItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 357)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCountry.Location = New System.Drawing.Point(101, 354)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(157, 20)
        Me.TxtCountry.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 320)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 14)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "City"
        '
        'TxtCity
        '
        Me.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCity.Location = New System.Drawing.Point(101, 312)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(157, 20)
        Me.TxtCity.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 337)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 14)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "State"
        '
        'TxtState
        '
        Me.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtState.Location = New System.Drawing.Point(101, 333)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.Size = New System.Drawing.Size(157, 20)
        Me.TxtState.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 294)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Postcode"
        '
        'TxtPostcode
        '
        Me.TxtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPostcode.Location = New System.Drawing.Point(101, 291)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.Size = New System.Drawing.Size(157, 20)
        Me.TxtPostcode.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 157)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 14)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(101, 153)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(305, 20)
        Me.TxtEmail.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(840, 467)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pet Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgvPetListing)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(828, 259)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pet List"
        '
        'DgvPetListing
        '
        Me.DgvPetListing.AllowUserToAddRows = False
        Me.DgvPetListing.AllowUserToOrderColumns = True
        Me.DgvPetListing.AllowUserToResizeRows = False
        Me.DgvPetListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvPetListing.BackgroundColor = System.Drawing.Color.White
        Me.DgvPetListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPetListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvBtnSelect, Me.PetID, Me.PetName, Me.PetDOB, Me.AnimalTypeCode, Me.AnimalTypeName, Me.BreedCode, Me.BreedName, Me.SexCode, Me.SexName, Me.NeuterCode, Me.NeuterName})
        Me.DgvPetListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPetListing.Location = New System.Drawing.Point(3, 16)
        Me.DgvPetListing.MultiSelect = False
        Me.DgvPetListing.Name = "DgvPetListing"
        Me.DgvPetListing.ReadOnly = True
        Me.DgvPetListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPetListing.Size = New System.Drawing.Size(822, 240)
        Me.DgvPetListing.TabIndex = 67
        '
        'DgvBtnSelect
        '
        Me.DgvBtnSelect.HeaderText = "Select Pet"
        Me.DgvBtnSelect.Name = "DgvBtnSelect"
        Me.DgvBtnSelect.ReadOnly = True
        Me.DgvBtnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBtnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DgvBtnSelect.Text = "Select"
        Me.DgvBtnSelect.UseColumnTextForButtonValue = True
        Me.DgvBtnSelect.Width = 80
        '
        'PetID
        '
        Me.PetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PetID.HeaderText = "Pet ID"
        Me.PetID.Name = "PetID"
        Me.PetID.ReadOnly = True
        Me.PetID.Width = 59
        '
        'PetName
        '
        Me.PetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PetName.HeaderText = "Pet Name"
        Me.PetName.Name = "PetName"
        Me.PetName.ReadOnly = True
        Me.PetName.Width = 77
        '
        'PetDOB
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PetDOB.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.AnimalTypeName.HeaderText = "Animal Name"
        Me.AnimalTypeName.Name = "AnimalTypeName"
        Me.AnimalTypeName.ReadOnly = True
        Me.AnimalTypeName.Width = 94
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
        Me.BreedName.HeaderText = "BreedName"
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
        Me.NeuterName.HeaderText = "Status"
        Me.NeuterName.Name = "NeuterName"
        Me.NeuterName.ReadOnly = True
        Me.NeuterName.Width = 63
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtCreatedBy)
        Me.Panel3.Controls.Add(Me.TxtDateModified)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TxtDateCreated)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.TxtModifiedBy)
        Me.Panel3.Location = New System.Drawing.Point(12, 618)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(848, 61)
        Me.Panel3.TabIndex = 82
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
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(540, 4)
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
        Me.BtnClose.Location = New System.Drawing.Point(784, 4)
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
        Me.BtnCancel.Location = New System.Drawing.Point(662, 4)
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
        Me.BtnEdit.Location = New System.Drawing.Point(723, 4)
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
        Me.BtnSave.Location = New System.Drawing.Point(601, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(840, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtSalutation)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox3.Controls.Add(Me.TxtCountry)
        Me.GroupBox3.Controls.Add(Me.TxtAddress1)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtTelNo)
        Me.GroupBox3.Controls.Add(Me.TxtCustomerID)
        Me.GroupBox3.Controls.Add(Me.TxtCity)
        Me.GroupBox3.Controls.Add(Me.TxtAddress4)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TxtMobileNo)
        Me.GroupBox3.Controls.Add(Me.TxtAddress3)
        Me.GroupBox3.Controls.Add(Me.TxtNRICPassportNo)
        Me.GroupBox3.Controls.Add(Me.TxtState)
        Me.GroupBox3.Controls.Add(Me.TxtEmail)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtAddress2)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtPostcode)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(828, 455)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Location = New System.Drawing.Point(101, 69)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(305, 20)
        Me.TxtCustomerName.TabIndex = 2
        '
        'TxtAddress1
        '
        Me.TxtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress1.Location = New System.Drawing.Point(101, 191)
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Phone (Mobile)"
        '
        'TxtTelNo
        '
        Me.TxtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelNo.Location = New System.Drawing.Point(101, 111)
        Me.TxtTelNo.Name = "TxtTelNo"
        Me.TxtTelNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtTelNo.TabIndex = 4
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerID.Location = New System.Drawing.Point(101, 27)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(157, 20)
        Me.TxtCustomerID.TabIndex = 100
        '
        'TxtAddress4
        '
        Me.TxtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress4.Location = New System.Drawing.Point(101, 254)
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress4.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMobileNo.Location = New System.Drawing.Point(101, 132)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtMobileNo.TabIndex = 5
        '
        'TxtAddress3
        '
        Me.TxtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress3.Location = New System.Drawing.Point(101, 233)
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress3.TabIndex = 9
        '
        'TxtNRICPassportNo
        '
        Me.TxtNRICPassportNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNRICPassportNo.Location = New System.Drawing.Point(101, 90)
        Me.TxtNRICPassportNo.Name = "TxtNRICPassportNo"
        Me.TxtNRICPassportNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtNRICPassportNo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone (Home)"
        '
        'TxtAddress2
        '
        Me.TxtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress2.Location = New System.Drawing.Point(101, 212)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NRIC/Passport"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salutation"
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
        Me.PnlActionBar.Size = New System.Drawing.Size(848, 68)
        Me.PnlActionBar.TabIndex = 81
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(209, 32)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Visit Information"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(479, 4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TpVisitInformation
        '
        Me.TpVisitInformation.Controls.Add(Me.GroupBox7)
        Me.TpVisitInformation.Controls.Add(Me.GroupBox6)
        Me.TpVisitInformation.Controls.Add(Me.GroupBox5)
        Me.TpVisitInformation.Location = New System.Drawing.Point(4, 23)
        Me.TpVisitInformation.Name = "TpVisitInformation"
        Me.TpVisitInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.TpVisitInformation.Size = New System.Drawing.Size(840, 467)
        Me.TpVisitInformation.TabIndex = 2
        Me.TpVisitInformation.Text = "Visit Information"
        Me.TpVisitInformation.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtVisitDescription)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 278)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(828, 183)
        Me.GroupBox7.TabIndex = 94
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Visit Information"
        '
        'TxtVisitDescription
        '
        Me.TxtVisitDescription.BackColor = System.Drawing.Color.White
        Me.TxtVisitDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitDescription.Location = New System.Drawing.Point(6, 19)
        Me.TxtVisitDescription.Multiline = True
        Me.TxtVisitDescription.Name = "TxtVisitDescription"
        Me.TxtVisitDescription.Size = New System.Drawing.Size(816, 158)
        Me.TxtVisitDescription.TabIndex = 91
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DgvSelectedPet)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 89)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(828, 186)
        Me.GroupBox6.TabIndex = 93
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Current Visit Selected Pet"
        '
        'DgvSelectedPet
        '
        Me.DgvSelectedPet.AllowUserToAddRows = False
        Me.DgvSelectedPet.AllowUserToResizeRows = False
        Me.DgvSelectedPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvSelectedPet.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedPet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectedPetID, Me.SelectedPetName, Me.SelectedPetDOB, Me.SelectedAnimalTypeCode, Me.SelectedAnimalTypeName, Me.SelectedBreedCode, Me.SelectedBreedName, Me.SelectedSexCode, Me.SelectedSexName, Me.SelectedNeuterCode, Me.SelectedNeuterName, Me.IsDb})
        Me.DgvSelectedPet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSelectedPet.Location = New System.Drawing.Point(3, 16)
        Me.DgvSelectedPet.MultiSelect = False
        Me.DgvSelectedPet.Name = "DgvSelectedPet"
        Me.DgvSelectedPet.ReadOnly = True
        Me.DgvSelectedPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSelectedPet.Size = New System.Drawing.Size(822, 167)
        Me.DgvSelectedPet.TabIndex = 84
        '
        'SelectedPetID
        '
        Me.SelectedPetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedPetID.HeaderText = "Pet ID"
        Me.SelectedPetID.Name = "SelectedPetID"
        Me.SelectedPetID.ReadOnly = True
        Me.SelectedPetID.Visible = False
        '
        'SelectedPetName
        '
        Me.SelectedPetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedPetName.HeaderText = "Pet Name"
        Me.SelectedPetName.Name = "SelectedPetName"
        Me.SelectedPetName.ReadOnly = True
        Me.SelectedPetName.Width = 77
        '
        'SelectedPetDOB
        '
        Me.SelectedPetDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedPetDOB.HeaderText = "DOB"
        Me.SelectedPetDOB.Name = "SelectedPetDOB"
        Me.SelectedPetDOB.ReadOnly = True
        Me.SelectedPetDOB.Width = 54
        '
        'SelectedAnimalTypeCode
        '
        Me.SelectedAnimalTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedAnimalTypeCode.HeaderText = "Animal Type Code"
        Me.SelectedAnimalTypeCode.Name = "SelectedAnimalTypeCode"
        Me.SelectedAnimalTypeCode.ReadOnly = True
        Me.SelectedAnimalTypeCode.Visible = False
        '
        'SelectedAnimalTypeName
        '
        Me.SelectedAnimalTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedAnimalTypeName.HeaderText = "Animal Type"
        Me.SelectedAnimalTypeName.Name = "SelectedAnimalTypeName"
        Me.SelectedAnimalTypeName.ReadOnly = True
        Me.SelectedAnimalTypeName.Width = 90
        '
        'SelectedBreedCode
        '
        Me.SelectedBreedCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedBreedCode.HeaderText = "Breed Code"
        Me.SelectedBreedCode.Name = "SelectedBreedCode"
        Me.SelectedBreedCode.ReadOnly = True
        Me.SelectedBreedCode.Visible = False
        '
        'SelectedBreedName
        '
        Me.SelectedBreedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SelectedBreedName.HeaderText = "Breed Name"
        Me.SelectedBreedName.Name = "SelectedBreedName"
        Me.SelectedBreedName.ReadOnly = True
        '
        'SelectedSexCode
        '
        Me.SelectedSexCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedSexCode.HeaderText = "Sex Code"
        Me.SelectedSexCode.Name = "SelectedSexCode"
        Me.SelectedSexCode.ReadOnly = True
        Me.SelectedSexCode.Visible = False
        '
        'SelectedSexName
        '
        Me.SelectedSexName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedSexName.HeaderText = "Sex "
        Me.SelectedSexName.Name = "SelectedSexName"
        Me.SelectedSexName.ReadOnly = True
        Me.SelectedSexName.Width = 51
        '
        'SelectedNeuterCode
        '
        Me.SelectedNeuterCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedNeuterCode.HeaderText = "Status Code"
        Me.SelectedNeuterCode.Name = "SelectedNeuterCode"
        Me.SelectedNeuterCode.ReadOnly = True
        Me.SelectedNeuterCode.Visible = False
        '
        'SelectedNeuterName
        '
        Me.SelectedNeuterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SelectedNeuterName.HeaderText = "Status"
        Me.SelectedNeuterName.Name = "SelectedNeuterName"
        Me.SelectedNeuterName.ReadOnly = True
        Me.SelectedNeuterName.Width = 63
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
        Me.GroupBox5.Controls.Add(Me.TxtVet)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.DtpConsultationDate)
        Me.GroupBox5.Controls.Add(Me.DtpConsultationTime)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(828, 77)
        Me.GroupBox5.TabIndex = 92
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Visit Details"
        '
        'TxtVet
        '
        Me.TxtVet.BackColor = System.Drawing.Color.Beige
        Me.TxtVet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVet.ForeColor = System.Drawing.Color.Black
        Me.TxtVet.Location = New System.Drawing.Point(98, 48)
        Me.TxtVet.Name = "TxtVet"
        Me.TxtVet.ReadOnly = True
        Me.TxtVet.Size = New System.Drawing.Size(188, 20)
        Me.TxtVet.TabIndex = 90
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(10, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 14)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "Visit Time"
        '
        'DtpConsultationDate
        '
        Me.DtpConsultationDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpConsultationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpConsultationDate.Location = New System.Drawing.Point(98, 27)
        Me.DtpConsultationDate.Name = "DtpConsultationDate"
        Me.DtpConsultationDate.Size = New System.Drawing.Size(100, 20)
        Me.DtpConsultationDate.TabIndex = 82
        '
        'DtpConsultationTime
        '
        Me.DtpConsultationTime.CustomFormat = "HH:mm:ss"
        Me.DtpConsultationTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpConsultationTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpConsultationTime.Location = New System.Drawing.Point(200, 27)
        Me.DtpConsultationTime.Name = "DtpConsultationTime"
        Me.DtpConsultationTime.ShowUpDown = True
        Me.DtpConsultationTime.Size = New System.Drawing.Size(86, 20)
        Me.DtpConsultationTime.TabIndex = 88
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(10, 51)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(85, 14)
        Me.Label30.TabIndex = 87
        Me.Label30.Text = "Consultation Vet"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 94)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 14)
        Me.Label29.TabIndex = 85
        Me.Label29.Text = "Visit ID"
        '
        'TxtVisitID
        '
        Me.TxtVisitID.BackColor = System.Drawing.Color.Beige
        Me.TxtVisitID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVisitID.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVisitID.Location = New System.Drawing.Point(55, 91)
        Me.TxtVisitID.Name = "TxtVisitID"
        Me.TxtVisitID.ReadOnly = True
        Me.TxtVisitID.Size = New System.Drawing.Size(195, 20)
        Me.TxtVisitID.TabIndex = 86
        '
        'TcVisitInformation
        '
        Me.TcVisitInformation.Controls.Add(Me.TabPage1)
        Me.TcVisitInformation.Controls.Add(Me.TabPage2)
        Me.TcVisitInformation.Controls.Add(Me.TpVisitInformation)
        Me.TcVisitInformation.Controls.Add(Me.TabPage4)
        Me.TcVisitInformation.Controls.Add(Me.TabPage5)
        Me.TcVisitInformation.Controls.Add(Me.TabPage3)
        Me.TcVisitInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcVisitInformation.Location = New System.Drawing.Point(12, 118)
        Me.TcVisitInformation.Name = "TcVisitInformation"
        Me.TcVisitInformation.SelectedIndex = 0
        Me.TcVisitInformation.Size = New System.Drawing.Size(848, 494)
        Me.TcVisitInformation.TabIndex = 80
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(840, 467)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Physical Examination Findings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.TxtPEFindings)
        Me.GroupBox2.Controls.Add(Me.CmbBodyScore)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.CmbTemperament)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.TxtTemperature)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.TxtBodyWeight)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(828, 302)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Physical Examination"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(10, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(67, 14)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "Temperature"
        '
        'TxtPEFindings
        '
        Me.TxtPEFindings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPEFindings.Location = New System.Drawing.Point(83, 133)
        Me.TxtPEFindings.Multiline = True
        Me.TxtPEFindings.Name = "TxtPEFindings"
        Me.TxtPEFindings.Size = New System.Drawing.Size(602, 163)
        Me.TxtPEFindings.TabIndex = 22
        '
        'CmbBodyScore
        '
        Me.CmbBodyScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBodyScore.FormattingEnabled = True
        Me.CmbBodyScore.Location = New System.Drawing.Point(83, 71)
        Me.CmbBodyScore.Name = "CmbBodyScore"
        Me.CmbBodyScore.Size = New System.Drawing.Size(121, 22)
        Me.CmbBodyScore.TabIndex = 26
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(10, 133)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 55)
        Me.Label35.TabIndex = 18
        Me.Label35.Text = "Write Up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/Case Hisory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/PE Findings:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(10, 52)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(71, 14)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Temperament"
        '
        'CmbTemperament
        '
        Me.CmbTemperament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTemperament.FormattingEnabled = True
        Me.CmbTemperament.Location = New System.Drawing.Point(83, 48)
        Me.CmbTemperament.Name = "CmbTemperament"
        Me.CmbTemperament.Size = New System.Drawing.Size(121, 22)
        Me.CmbTemperament.TabIndex = 25
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(10, 75)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 14)
        Me.Label36.TabIndex = 17
        Me.Label36.Text = "Body Score"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(206, 99)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(18, 14)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "kg"
        '
        'TxtTemperature
        '
        Me.TxtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTemperature.Location = New System.Drawing.Point(83, 27)
        Me.TxtTemperature.Name = "TxtTemperature"
        Me.TxtTemperature.Size = New System.Drawing.Size(121, 20)
        Me.TxtTemperature.TabIndex = 19
        Me.TxtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(206, 30)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(19, 14)
        Me.Label33.TabIndex = 23
        Me.Label33.Text = "ºC"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 97)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(68, 14)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Body Weight"
        '
        'TxtBodyWeight
        '
        Me.TxtBodyWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBodyWeight.Location = New System.Drawing.Point(83, 94)
        Me.TxtBodyWeight.Name = "TxtBodyWeight"
        Me.TxtBodyWeight.Size = New System.Drawing.Size(121, 20)
        Me.TxtBodyWeight.TabIndex = 21
        Me.TxtBodyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox9)
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(840, 467)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Consultation / Medication / Ward Charges"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DgvSelectedItem)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 241)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(828, 220)
        Me.GroupBox9.TabIndex = 193
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Consultation / Medication / Ward Charge List"
        '
        'DgvSelectedItem
        '
        Me.DgvSelectedItem.AllowUserToAddRows = False
        Me.DgvSelectedItem.AllowUserToDeleteRows = False
        Me.DgvSelectedItem.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BtnChargesDeleteItem, Me.ChargesRowNo, Me.ChargesItemCode, Me.ChargesItemDescription, Me.ChargesPrescription, Me.ChargesNotes, Me.ChargesUnitPrice, Me.ChargesQuantity, Me.ChargesTotalPrice, Me.ChargesItemGroup, Me.ChargesItemTypeCode, Me.ChargesItemTypeDescription, Me.IsChargeDb})
        Me.DgvSelectedItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSelectedItem.Location = New System.Drawing.Point(3, 16)
        Me.DgvSelectedItem.Name = "DgvSelectedItem"
        Me.DgvSelectedItem.ReadOnly = True
        Me.DgvSelectedItem.Size = New System.Drawing.Size(822, 201)
        Me.DgvSelectedItem.TabIndex = 171
        '
        'BtnChargesDeleteItem
        '
        Me.BtnChargesDeleteItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BtnChargesDeleteItem.HeaderText = "Delete?"
        Me.BtnChargesDeleteItem.Name = "BtnChargesDeleteItem"
        Me.BtnChargesDeleteItem.ReadOnly = True
        Me.BtnChargesDeleteItem.Text = "Delete"
        Me.BtnChargesDeleteItem.UseColumnTextForButtonValue = True
        Me.BtnChargesDeleteItem.Width = 49
        '
        'ChargesRowNo
        '
        Me.ChargesRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesRowNo.HeaderText = "No."
        Me.ChargesRowNo.Name = "ChargesRowNo"
        Me.ChargesRowNo.ReadOnly = True
        Me.ChargesRowNo.Width = 48
        '
        'ChargesItemCode
        '
        Me.ChargesItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesItemCode.HeaderText = "Item Code"
        Me.ChargesItemCode.Name = "ChargesItemCode"
        Me.ChargesItemCode.ReadOnly = True
        Me.ChargesItemCode.Width = 79
        '
        'ChargesItemDescription
        '
        Me.ChargesItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChargesItemDescription.HeaderText = "Item Description"
        Me.ChargesItemDescription.Name = "ChargesItemDescription"
        Me.ChargesItemDescription.ReadOnly = True
        '
        'ChargesPrescription
        '
        Me.ChargesPrescription.HeaderText = "Prescription"
        Me.ChargesPrescription.Name = "ChargesPrescription"
        Me.ChargesPrescription.ReadOnly = True
        '
        'ChargesNotes
        '
        Me.ChargesNotes.HeaderText = "Notes"
        Me.ChargesNotes.Name = "ChargesNotes"
        Me.ChargesNotes.ReadOnly = True
        '
        'ChargesUnitPrice
        '
        Me.ChargesUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesUnitPrice.HeaderText = "Unit Price"
        Me.ChargesUnitPrice.Name = "ChargesUnitPrice"
        Me.ChargesUnitPrice.ReadOnly = True
        Me.ChargesUnitPrice.Width = 77
        '
        'ChargesQuantity
        '
        Me.ChargesQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesQuantity.HeaderText = "Quantity"
        Me.ChargesQuantity.Name = "ChargesQuantity"
        Me.ChargesQuantity.ReadOnly = True
        Me.ChargesQuantity.Width = 72
        '
        'ChargesTotalPrice
        '
        Me.ChargesTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesTotalPrice.HeaderText = "Total Price"
        Me.ChargesTotalPrice.Name = "ChargesTotalPrice"
        Me.ChargesTotalPrice.ReadOnly = True
        Me.ChargesTotalPrice.Width = 81
        '
        'ChargesItemGroup
        '
        Me.ChargesItemGroup.HeaderText = "Item Group"
        Me.ChargesItemGroup.Name = "ChargesItemGroup"
        Me.ChargesItemGroup.ReadOnly = True
        Me.ChargesItemGroup.Visible = False
        '
        'ChargesItemTypeCode
        '
        Me.ChargesItemTypeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesItemTypeCode.HeaderText = "Item Type Code"
        Me.ChargesItemTypeCode.Name = "ChargesItemTypeCode"
        Me.ChargesItemTypeCode.ReadOnly = True
        Me.ChargesItemTypeCode.Visible = False
        '
        'ChargesItemTypeDescription
        '
        Me.ChargesItemTypeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ChargesItemTypeDescription.HeaderText = "Item Type Description"
        Me.ChargesItemTypeDescription.Name = "ChargesItemTypeDescription"
        Me.ChargesItemTypeDescription.ReadOnly = True
        Me.ChargesItemTypeDescription.Visible = False
        '
        'IsChargeDb
        '
        Me.IsChargeDb.HeaderText = "IsChargeDb"
        Me.IsChargeDb.Name = "IsChargeDb"
        Me.IsChargeDb.ReadOnly = True
        Me.IsChargeDb.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TxtItem)
        Me.GroupBox8.Controls.Add(Me.Label41)
        Me.GroupBox8.Controls.Add(Me.BtnSearchItem)
        Me.GroupBox8.Controls.Add(Me.TxtPrescription)
        Me.GroupBox8.Controls.Add(Me.Label39)
        Me.GroupBox8.Controls.Add(Me.Label42)
        Me.GroupBox8.Controls.Add(Me.Button3)
        Me.GroupBox8.Controls.Add(Me.TxtNotes)
        Me.GroupBox8.Controls.Add(Me.TxtUnitPrice)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.TxtQuantity)
        Me.GroupBox8.Controls.Add(Me.Label40)
        Me.GroupBox8.Controls.Add(Me.BtnAddItem)
        Me.GroupBox8.Controls.Add(Me.TxtTotalPrice)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(828, 229)
        Me.GroupBox8.TabIndex = 192
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Select Consultation / Treatment / Medication / Ward Charges"
        '
        'TxtItem
        '
        Me.TxtItem.BackColor = System.Drawing.Color.Beige
        Me.TxtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem.Location = New System.Drawing.Point(75, 27)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.Size = New System.Drawing.Size(416, 21)
        Me.TxtItem.TabIndex = 177
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(10, 49)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(64, 14)
        Me.Label41.TabIndex = 188
        Me.Label41.Text = "Prescription"
        '
        'BtnSearchItem
        '
        Me.BtnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearchItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchItem.Location = New System.Drawing.Point(491, 25)
        Me.BtnSearchItem.Name = "BtnSearchItem"
        Me.BtnSearchItem.Size = New System.Drawing.Size(35, 25)
        Me.BtnSearchItem.TabIndex = 178
        Me.BtnSearchItem.Text = "..."
        Me.BtnSearchItem.UseVisualStyleBackColor = True
        '
        'TxtPrescription
        '
        Me.TxtPrescription.BackColor = System.Drawing.Color.White
        Me.TxtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrescription.Location = New System.Drawing.Point(75, 49)
        Me.TxtPrescription.Multiline = True
        Me.TxtPrescription.Name = "TxtPrescription"
        Me.TxtPrescription.Size = New System.Drawing.Size(416, 40)
        Me.TxtPrescription.TabIndex = 189
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
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(10, 90)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(35, 14)
        Me.Label42.TabIndex = 190
        Me.Label42.Text = "Notes"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(525, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 25)
        Me.Button3.TabIndex = 179
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtNotes
        '
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNotes.Location = New System.Drawing.Point(75, 90)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(416, 40)
        Me.TxtNotes.TabIndex = 191
        '
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitPrice.Location = New System.Drawing.Point(75, 131)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.ReadOnly = True
        Me.TxtUnitPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtUnitPrice.TabIndex = 175
        Me.TxtUnitPrice.Text = "0.00"
        Me.TxtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 178)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 14)
        Me.Label23.TabIndex = 182
        Me.Label23.Text = "Total Price"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.White
        Me.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQuantity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(75, 153)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(52, 21)
        Me.TxtQuantity.TabIndex = 181
        Me.TxtQuantity.Text = "1.00"
        Me.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(10, 134)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(52, 14)
        Me.Label40.TabIndex = 174
        Me.Label40.Text = "Unit Price"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Location = New System.Drawing.Point(74, 200)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(121, 23)
        Me.BtnAddItem.TabIndex = 172
        Me.BtnAddItem.Text = "Add Item..."
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'TxtTotalPrice
        '
        Me.TxtTotalPrice.BackColor = System.Drawing.Color.Beige
        Me.TxtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPrice.Location = New System.Drawing.Point(75, 175)
        Me.TxtTotalPrice.Name = "TxtTotalPrice"
        Me.TxtTotalPrice.ReadOnly = True
        Me.TxtTotalPrice.Size = New System.Drawing.Size(52, 21)
        Me.TxtTotalPrice.TabIndex = 183
        Me.TxtTotalPrice.Text = "0.00"
        Me.TxtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 156)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 14)
        Me.Label24.TabIndex = 180
        Me.Label24.Text = "Quantity"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(840, 467)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Text = "Visit Status"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBillPayment)
        Me.GroupBox1.Controls.Add(Me.CbIsAdmittedToWard)
        Me.GroupBox1.Controls.Add(Me.CbIsVisitCompleted)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 90)
        Me.GroupBox1.TabIndex = 188
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visit Status"
        '
        'BtnBillPayment
        '
        Me.BtnBillPayment.Location = New System.Drawing.Point(635, 51)
        Me.BtnBillPayment.Name = "BtnBillPayment"
        Me.BtnBillPayment.Size = New System.Drawing.Size(187, 25)
        Me.BtnBillPayment.TabIndex = 185
        Me.BtnBillPayment.Text = "Bill && Payment..."
        Me.BtnBillPayment.UseVisualStyleBackColor = True
        Me.BtnBillPayment.Visible = False
        '
        'CbIsAdmittedToWard
        '
        Me.CbIsAdmittedToWard.AutoSize = True
        Me.CbIsAdmittedToWard.Location = New System.Drawing.Point(10, 49)
        Me.CbIsAdmittedToWard.Name = "CbIsAdmittedToWard"
        Me.CbIsAdmittedToWard.Size = New System.Drawing.Size(96, 18)
        Me.CbIsAdmittedToWard.TabIndex = 186
        Me.CbIsAdmittedToWard.Text = "Admit To Ward"
        Me.CbIsAdmittedToWard.UseVisualStyleBackColor = True
        '
        'CbIsVisitCompleted
        '
        Me.CbIsVisitCompleted.AutoSize = True
        Me.CbIsVisitCompleted.Location = New System.Drawing.Point(10, 30)
        Me.CbIsVisitCompleted.Name = "CbIsVisitCompleted"
        Me.CbIsVisitCompleted.Size = New System.Drawing.Size(100, 18)
        Me.CbIsVisitCompleted.TabIndex = 184
        Me.CbIsVisitCompleted.Text = "Visit Completed"
        Me.CbIsVisitCompleted.UseVisualStyleBackColor = True
        '
        'TxtSalutation
        '
        Me.TxtSalutation.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSalutation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalutation.Location = New System.Drawing.Point(101, 48)
        Me.TxtSalutation.Name = "TxtSalutation"
        Me.TxtSalutation.Size = New System.Drawing.Size(157, 20)
        Me.TxtSalutation.TabIndex = 112
        '
        'FrmVisitInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 689)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.TcVisitInformation)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtVisitID)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmVisitInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visit Information"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.TpVisitInformation.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DgvSelectedPet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TcVisitInformation.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DgvSelectedItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtState As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtPostcode As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DgvPetListing As DataGridView
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtModifiedBy As TextBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTelNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtNRICPassportNo As TextBox
    Friend WithEvents TxtMobileNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents TpVisitInformation As TabPage
    Friend WithEvents TcVisitInformation As TabControl
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtVisitDescription As TextBox
    Friend WithEvents DtpConsultationTime As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents DgvSelectedPet As DataGridView
    Friend WithEvents TxtVisitID As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents DtpConsultationDate As DateTimePicker
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CmbBodyScore As ComboBox
    Friend WithEvents CmbTemperament As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtPEFindings As TextBox
    Friend WithEvents TxtBodyWeight As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtTemperature As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label23 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents TxtTotalPrice As TextBox
    Friend WithEvents DgvSelectedItem As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents TxtUnitPrice As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BtnSearchItem As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents TxtPrescription As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBillPayment As Button
    Friend WithEvents CbIsAdmittedToWard As CheckBox
    Friend WithEvents CbIsVisitCompleted As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TxtVet As TextBox
    Friend WithEvents DgvBtnSelect As DataGridViewButtonColumn
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
    Friend WithEvents SelectedPetID As DataGridViewTextBoxColumn
    Friend WithEvents SelectedPetName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedPetDOB As DataGridViewTextBoxColumn
    Friend WithEvents SelectedAnimalTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedAnimalTypeName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedBreedCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedBreedName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedSexCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedSexName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedNeuterCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedNeuterName As DataGridViewTextBoxColumn
    Friend WithEvents IsDb As DataGridViewTextBoxColumn
    Friend WithEvents BtnChargesDeleteItem As DataGridViewButtonColumn
    Friend WithEvents ChargesRowNo As DataGridViewTextBoxColumn
    Friend WithEvents ChargesItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ChargesItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents ChargesPrescription As DataGridViewTextBoxColumn
    Friend WithEvents ChargesNotes As DataGridViewTextBoxColumn
    Friend WithEvents ChargesUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents ChargesQuantity As DataGridViewTextBoxColumn
    Friend WithEvents ChargesTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents ChargesItemGroup As DataGridViewTextBoxColumn
    Friend WithEvents ChargesItemTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents ChargesItemTypeDescription As DataGridViewTextBoxColumn
    Friend WithEvents IsChargeDb As DataGridViewTextBoxColumn
    Friend WithEvents TxtSalutation As TextBox
End Class
