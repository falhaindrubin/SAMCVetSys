<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAppointmentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAppointmentInformation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCreatedBy = New System.Windows.Forms.TextBox()
        Me.TxtDateModified = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDateCreated = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtModifiedBy = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TpAppointmentInformation = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAppointmentDesc = New System.Windows.Forms.TextBox()
        Me.DtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbVet = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DtpAppointmentTime = New System.Windows.Forms.DateTimePicker()
        Me.TxtAppointmentID = New System.Windows.Forms.TextBox()
        Me.DgvSelectedPet = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvPetListing = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.TxtTelNo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPostcode = New System.Windows.Forms.TextBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtNRICPassportNo = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtMobileNo = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TcAppointmentInformation = New System.Windows.Forms.TabControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
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
        Me.TxtSalutation = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.TpAppointmentInformation.SuspendLayout()
        CType(Me.DgvSelectedPet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TcAppointmentInformation.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel3.Location = New System.Drawing.Point(12, 603)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(714, 61)
        Me.Panel3.TabIndex = 82
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 9)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Location = New System.Drawing.Point(142, 30)
        Me.TxtDateModified.Name = "TxtDateModified"
        Me.TxtDateModified.ReadOnly = True
        Me.TxtDateModified.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateModified.TabIndex = 78
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Created By"
        '
        'TxtDateCreated
        '
        Me.TxtDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateCreated.Location = New System.Drawing.Point(142, 9)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 14)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Modified By"
        '
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 30)
        Me.TxtModifiedBy.Name = "TxtModifiedBy"
        Me.TxtModifiedBy.ReadOnly = True
        Me.TxtModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtModifiedBy.TabIndex = 76
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(653, 4)
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
        Me.BtnCancel.Location = New System.Drawing.Point(531, 4)
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
        Me.BtnEdit.Location = New System.Drawing.Point(592, 4)
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
        Me.BtnSave.Location = New System.Drawing.Point(470, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 60)
        Me.BtnSave.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.Label13)
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnSearch)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 13)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(718, 68)
        Me.PnlActionBar.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(310, 32)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Appointment Information"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(409, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 60)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(348, 4)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 60)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TpAppointmentInformation
        '
        Me.TpAppointmentInformation.Controls.Add(Me.GroupBox4)
        Me.TpAppointmentInformation.Controls.Add(Me.GroupBox5)
        Me.TpAppointmentInformation.Controls.Add(Me.GroupBox3)
        Me.TpAppointmentInformation.Location = New System.Drawing.Point(4, 23)
        Me.TpAppointmentInformation.Name = "TpAppointmentInformation"
        Me.TpAppointmentInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAppointmentInformation.Size = New System.Drawing.Size(710, 487)
        Me.TpAppointmentInformation.TabIndex = 1
        Me.TpAppointmentInformation.Text = "Appointment Information"
        Me.TpAppointmentInformation.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Appointment ID"
        '
        'TxtAppointmentDesc
        '
        Me.TxtAppointmentDesc.BackColor = System.Drawing.Color.White
        Me.TxtAppointmentDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAppointmentDesc.Location = New System.Drawing.Point(6, 19)
        Me.TxtAppointmentDesc.Multiline = True
        Me.TxtAppointmentDesc.Name = "TxtAppointmentDesc"
        Me.TxtAppointmentDesc.Size = New System.Drawing.Size(680, 140)
        Me.TxtAppointmentDesc.TabIndex = 76
        '
        'DtpAppointmentDate
        '
        Me.DtpAppointmentDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpAppointmentDate.Location = New System.Drawing.Point(108, 48)
        Me.DtpAppointmentDate.Name = "DtpAppointmentDate"
        Me.DtpAppointmentDate.Size = New System.Drawing.Size(100, 20)
        Me.DtpAppointmentDate.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 14)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Appointment Time"
        '
        'CmbVet
        '
        Me.CmbVet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVet.FormattingEnabled = True
        Me.CmbVet.Location = New System.Drawing.Point(108, 70)
        Me.CmbVet.Name = "CmbVet"
        Me.CmbVet.Size = New System.Drawing.Size(188, 22)
        Me.CmbVet.TabIndex = 74
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 14)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Appointment Vet"
        '
        'DtpAppointmentTime
        '
        Me.DtpAppointmentTime.CustomFormat = "HH:mm:ss"
        Me.DtpAppointmentTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpAppointmentTime.Location = New System.Drawing.Point(210, 48)
        Me.DtpAppointmentTime.Name = "DtpAppointmentTime"
        Me.DtpAppointmentTime.ShowUpDown = True
        Me.DtpAppointmentTime.Size = New System.Drawing.Size(84, 20)
        Me.DtpAppointmentTime.TabIndex = 73
        '
        'TxtAppointmentID
        '
        Me.TxtAppointmentID.BackColor = System.Drawing.Color.Beige
        Me.TxtAppointmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAppointmentID.Location = New System.Drawing.Point(108, 27)
        Me.TxtAppointmentID.Name = "TxtAppointmentID"
        Me.TxtAppointmentID.ReadOnly = True
        Me.TxtAppointmentID.Size = New System.Drawing.Size(188, 20)
        Me.TxtAppointmentID.TabIndex = 69
        '
        'DgvSelectedPet
        '
        Me.DgvSelectedPet.AllowUserToAddRows = False
        Me.DgvSelectedPet.AllowUserToOrderColumns = True
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
        Me.DgvSelectedPet.Size = New System.Drawing.Size(692, 112)
        Me.DgvSelectedPet.TabIndex = 67
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(710, 487)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pet Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvPetListing)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 327)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pet List"
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
        Me.DgvPetListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvBtnSelect, Me.PetID, Me.PetName, Me.PetDOB, Me.AnimalTypeCode, Me.AnimalTypeName, Me.BreedCode, Me.BreedName, Me.SexCode, Me.SexName, Me.NeuterCode, Me.NeuterName})
        Me.DgvPetListing.Location = New System.Drawing.Point(6, 19)
        Me.DgvPetListing.MultiSelect = False
        Me.DgvPetListing.Name = "DgvPetListing"
        Me.DgvPetListing.ReadOnly = True
        Me.DgvPetListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPetListing.Size = New System.Drawing.Size(686, 302)
        Me.DgvPetListing.TabIndex = 67
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(710, 487)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 390)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Country"
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
        'TxtCountry
        '
        Me.TxtCountry.BackColor = System.Drawing.Color.Beige
        Me.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCountry.Location = New System.Drawing.Point(102, 387)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.ReadOnly = True
        Me.TxtCountry.Size = New System.Drawing.Size(157, 20)
        Me.TxtCountry.TabIndex = 14
        '
        'TxtTelNo
        '
        Me.TxtTelNo.BackColor = System.Drawing.Color.Beige
        Me.TxtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelNo.Location = New System.Drawing.Point(102, 111)
        Me.TxtTelNo.Name = "TxtTelNo"
        Me.TxtTelNo.ReadOnly = True
        Me.TxtTelNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtTelNo.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 348)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 14)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "City"
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
        'TxtCity
        '
        Me.TxtCity.BackColor = System.Drawing.Color.Beige
        Me.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCity.Location = New System.Drawing.Point(102, 345)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.ReadOnly = True
        Me.TxtCity.Size = New System.Drawing.Size(157, 20)
        Me.TxtCity.TabIndex = 12
        '
        'TxtAddress3
        '
        Me.TxtAddress3.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress3.Location = New System.Drawing.Point(102, 250)
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.ReadOnly = True
        Me.TxtAddress3.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress3.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 369)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 14)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone (Home)"
        '
        'TxtState
        '
        Me.TxtState.BackColor = System.Drawing.Color.Beige
        Me.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtState.Location = New System.Drawing.Point(102, 366)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.ReadOnly = True
        Me.TxtState.Size = New System.Drawing.Size(157, 20)
        Me.TxtState.TabIndex = 13
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 327)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Postcode"
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
        'TxtPostcode
        '
        Me.TxtPostcode.BackColor = System.Drawing.Color.Beige
        Me.TxtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPostcode.Location = New System.Drawing.Point(102, 324)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.ReadOnly = True
        Me.TxtPostcode.Size = New System.Drawing.Size(157, 20)
        Me.TxtPostcode.TabIndex = 11
        '
        'TxtAddress2
        '
        Me.TxtAddress2.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress2.Location = New System.Drawing.Point(102, 229)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.ReadOnly = True
        Me.TxtAddress2.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress2.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 14)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Email"
        '
        'TxtNRICPassportNo
        '
        Me.TxtNRICPassportNo.BackColor = System.Drawing.Color.Beige
        Me.TxtNRICPassportNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNRICPassportNo.Location = New System.Drawing.Point(102, 90)
        Me.TxtNRICPassportNo.Name = "TxtNRICPassportNo"
        Me.TxtNRICPassportNo.ReadOnly = True
        Me.TxtNRICPassportNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtNRICPassportNo.TabIndex = 3
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Beige
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(102, 153)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(305, 20)
        Me.TxtEmail.TabIndex = 6
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.BackColor = System.Drawing.Color.Beige
        Me.TxtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMobileNo.Location = New System.Drawing.Point(102, 132)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.ReadOnly = True
        Me.TxtMobileNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtMobileNo.TabIndex = 5
        '
        'TxtAddress4
        '
        Me.TxtAddress4.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress4.Location = New System.Drawing.Point(102, 271)
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.ReadOnly = True
        Me.TxtAddress4.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress4.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
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
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerID.Location = New System.Drawing.Point(102, 27)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustomerID.TabIndex = 100
        '
        'TxtAddress1
        '
        Me.TxtAddress1.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress1.Location = New System.Drawing.Point(102, 208)
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.ReadOnly = True
        Me.TxtAddress1.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress1.TabIndex = 7
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Location = New System.Drawing.Point(102, 69)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(305, 20)
        Me.TxtCustomerName.TabIndex = 2
        '
        'TcAppointmentInformation
        '
        Me.TcAppointmentInformation.Controls.Add(Me.TabPage1)
        Me.TcAppointmentInformation.Controls.Add(Me.TabPage3)
        Me.TcAppointmentInformation.Controls.Add(Me.TpAppointmentInformation)
        Me.TcAppointmentInformation.Location = New System.Drawing.Point(12, 87)
        Me.TcAppointmentInformation.Name = "TcAppointmentInformation"
        Me.TcAppointmentInformation.SelectedIndex = 0
        Me.TcAppointmentInformation.Size = New System.Drawing.Size(718, 514)
        Me.TcAppointmentInformation.TabIndex = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSalutation)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox2.Controls.Add(Me.TxtAddress1)
        Me.GroupBox2.Controls.Add(Me.TxtCountry)
        Me.GroupBox2.Controls.Add(Me.TxtTelNo)
        Me.GroupBox2.Controls.Add(Me.TxtCustomerID)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.TxtAddress4)
        Me.GroupBox2.Controls.Add(Me.TxtAddress3)
        Me.GroupBox2.Controls.Add(Me.TxtMobileNo)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TxtEmail)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNRICPassportNo)
        Me.GroupBox2.Controls.Add(Me.TxtState)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtAddress2)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TxtPostcode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(722, 418)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtAppointmentID)
        Me.GroupBox3.Controls.Add(Me.DtpAppointmentTime)
        Me.GroupBox3.Controls.Add(Me.DtpAppointmentDate)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.CmbVet)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(698, 117)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Appointment Details"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DgvSelectedPet)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 129)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(698, 131)
        Me.GroupBox5.TabIndex = 81
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Selected Pet For Appointment"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtAppointmentDesc)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(692, 165)
        Me.GroupBox4.TabIndex = 82
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Appointment Description / Details"
        '
        'SelectedPetID
        '
        Me.SelectedPetID.HeaderText = "Pet ID"
        Me.SelectedPetID.Name = "SelectedPetID"
        Me.SelectedPetID.ReadOnly = True
        Me.SelectedPetID.Width = 59
        '
        'SelectedPetName
        '
        Me.SelectedPetName.HeaderText = "Pet Name"
        Me.SelectedPetName.Name = "SelectedPetName"
        Me.SelectedPetName.ReadOnly = True
        Me.SelectedPetName.Width = 77
        '
        'SelectedPetDOB
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SelectedPetDOB.DefaultCellStyle = DataGridViewCellStyle1
        Me.SelectedPetDOB.HeaderText = "DOB"
        Me.SelectedPetDOB.Name = "SelectedPetDOB"
        Me.SelectedPetDOB.ReadOnly = True
        Me.SelectedPetDOB.Width = 54
        '
        'SelectedAnimalTypeCode
        '
        Me.SelectedAnimalTypeCode.HeaderText = "AnimalTypeCode"
        Me.SelectedAnimalTypeCode.Name = "SelectedAnimalTypeCode"
        Me.SelectedAnimalTypeCode.ReadOnly = True
        Me.SelectedAnimalTypeCode.Visible = False
        Me.SelectedAnimalTypeCode.Width = 112
        '
        'SelectedAnimalTypeName
        '
        Me.SelectedAnimalTypeName.HeaderText = "Animal Type"
        Me.SelectedAnimalTypeName.Name = "SelectedAnimalTypeName"
        Me.SelectedAnimalTypeName.ReadOnly = True
        Me.SelectedAnimalTypeName.Width = 90
        '
        'SelectedBreedCode
        '
        Me.SelectedBreedCode.HeaderText = "BreedCode"
        Me.SelectedBreedCode.Name = "SelectedBreedCode"
        Me.SelectedBreedCode.ReadOnly = True
        Me.SelectedBreedCode.Visible = False
        Me.SelectedBreedCode.Width = 86
        '
        'SelectedBreedName
        '
        Me.SelectedBreedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SelectedBreedName.HeaderText = "Breed"
        Me.SelectedBreedName.Name = "SelectedBreedName"
        Me.SelectedBreedName.ReadOnly = True
        '
        'SelectedSexCode
        '
        Me.SelectedSexCode.HeaderText = "SexCode"
        Me.SelectedSexCode.Name = "SelectedSexCode"
        Me.SelectedSexCode.ReadOnly = True
        Me.SelectedSexCode.Visible = False
        Me.SelectedSexCode.Width = 76
        '
        'SelectedSexName
        '
        Me.SelectedSexName.HeaderText = "Sex"
        Me.SelectedSexName.Name = "SelectedSexName"
        Me.SelectedSexName.ReadOnly = True
        Me.SelectedSexName.Width = 51
        '
        'SelectedNeuterCode
        '
        Me.SelectedNeuterCode.HeaderText = "StatusCode"
        Me.SelectedNeuterCode.Name = "SelectedNeuterCode"
        Me.SelectedNeuterCode.ReadOnly = True
        Me.SelectedNeuterCode.Visible = False
        Me.SelectedNeuterCode.Width = 88
        '
        'SelectedNeuterName
        '
        Me.SelectedNeuterName.HeaderText = "Status"
        Me.SelectedNeuterName.Name = "SelectedNeuterName"
        Me.SelectedNeuterName.ReadOnly = True
        Me.SelectedNeuterName.Width = 63
        '
        'IsDb
        '
        Me.IsDb.HeaderText = "IsDb"
        Me.IsDb.Name = "IsDb"
        Me.IsDb.ReadOnly = True
        Me.IsDb.Visible = False
        Me.IsDb.Width = 53
        '
        'DgvBtnSelect
        '
        Me.DgvBtnSelect.HeaderText = "Select Pet"
        Me.DgvBtnSelect.Name = "DgvBtnSelect"
        Me.DgvBtnSelect.ReadOnly = True
        Me.DgvBtnSelect.Text = "Select"
        Me.DgvBtnSelect.UseColumnTextForButtonValue = True
        Me.DgvBtnSelect.Width = 61
        '
        'PetID
        '
        Me.PetID.HeaderText = "Pet ID"
        Me.PetID.Name = "PetID"
        Me.PetID.ReadOnly = True
        Me.PetID.Visible = False
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
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PetDOB.DefaultCellStyle = DataGridViewCellStyle2
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
        'TxtSalutation
        '
        Me.TxtSalutation.BackColor = System.Drawing.Color.Beige
        Me.TxtSalutation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalutation.Location = New System.Drawing.Point(102, 48)
        Me.TxtSalutation.Name = "TxtSalutation"
        Me.TxtSalutation.ReadOnly = True
        Me.TxtSalutation.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalutation.TabIndex = 111
        '
        'FrmAppointmentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(742, 674)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.TcAppointmentInformation)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmAppointmentInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment Information"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnlActionBar.ResumeLayout(False)
        Me.PnlActionBar.PerformLayout()
        Me.TpAppointmentInformation.ResumeLayout(False)
        CType(Me.DgvSelectedPet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TcAppointmentInformation.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtCreatedBy As TextBox
    Friend WithEvents TxtDateModified As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDateCreated As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtModifiedBy As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents PnlActionBar As Panel
    Friend WithEvents TpAppointmentInformation As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvPetListing As DataGridView
    Friend WithEvents TabPage1 As TabPage
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtMobileNo As TextBox
    Friend WithEvents TxtNRICPassportNo As TextBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelNo As TextBox
    Friend WithEvents TcAppointmentInformation As TabControl
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents TxtAppointmentDesc As TextBox
    Friend WithEvents CmbVet As ComboBox
    Friend WithEvents DtpAppointmentTime As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents DgvSelectedPet As DataGridView
    Friend WithEvents TxtAppointmentID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DtpAppointmentDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
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
    Friend WithEvents TxtSalutation As TextBox
End Class
