﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAppointmentDesc = New System.Windows.Forms.TextBox()
        Me.DtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbVet = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DtpAppointmentTime = New System.Windows.Forms.DateTimePicker()
        Me.TxtAppointmentID = New System.Windows.Forms.TextBox()
        Me.DgvSelectedPet = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvPetListing = New System.Windows.Forms.DataGridView()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.CmbBreed = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DtpPetDOB = New System.Windows.Forms.DateTimePicker()
        Me.CmbSex = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtPetName = New System.Windows.Forms.TextBox()
        Me.CmbAnimalType = New System.Windows.Forms.ComboBox()
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
        Me.CmbSalutation = New System.Windows.Forms.ComboBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TcAppointmentInformation = New System.Windows.Forms.TabControl()
        Me.SelectedPetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedPetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedPetDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedAnimalTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedAnimalTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBreedCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBreedName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedSexCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedSexName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedStatusCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedStatusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.StatusCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.PnlActionBar.SuspendLayout()
        Me.TpAppointmentInformation.SuspendLayout()
        CType(Me.DgvSelectedPet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TcAppointmentInformation.SuspendLayout()
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
        Me.BtnClose.Location = New System.Drawing.Point(653, 6)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 56)
        Me.BtnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(531, 6)
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
        Me.BtnEdit.Location = New System.Drawing.Point(592, 6)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 56)
        Me.BtnEdit.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(470, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 56)
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
        Me.BtnPrint.Location = New System.Drawing.Point(409, 6)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 56)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.BackgroundImage = CType(resources.GetObject("BtnSearch.BackgroundImage"), System.Drawing.Image)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSearch.Location = New System.Drawing.Point(348, 6)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(60, 56)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TpAppointmentInformation
        '
        Me.TpAppointmentInformation.Controls.Add(Me.Label12)
        Me.TpAppointmentInformation.Controls.Add(Me.Label9)
        Me.TpAppointmentInformation.Controls.Add(Me.TxtAppointmentDesc)
        Me.TpAppointmentInformation.Controls.Add(Me.DtpAppointmentDate)
        Me.TpAppointmentInformation.Controls.Add(Me.Label5)
        Me.TpAppointmentInformation.Controls.Add(Me.Label11)
        Me.TpAppointmentInformation.Controls.Add(Me.CmbVet)
        Me.TpAppointmentInformation.Controls.Add(Me.Label14)
        Me.TpAppointmentInformation.Controls.Add(Me.DtpAppointmentTime)
        Me.TpAppointmentInformation.Controls.Add(Me.TxtAppointmentID)
        Me.TpAppointmentInformation.Controls.Add(Me.DgvSelectedPet)
        Me.TpAppointmentInformation.Location = New System.Drawing.Point(4, 23)
        Me.TpAppointmentInformation.Name = "TpAppointmentInformation"
        Me.TpAppointmentInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAppointmentInformation.Size = New System.Drawing.Size(710, 487)
        Me.TpAppointmentInformation.TabIndex = 1
        Me.TpAppointmentInformation.Text = "Appointment Information"
        Me.TpAppointmentInformation.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Pet Issues:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Appointment ID"
        '
        'TxtAppointmentDesc
        '
        Me.TxtAppointmentDesc.BackColor = System.Drawing.Color.White
        Me.TxtAppointmentDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAppointmentDesc.Location = New System.Drawing.Point(98, 180)
        Me.TxtAppointmentDesc.Multiline = True
        Me.TxtAppointmentDesc.Name = "TxtAppointmentDesc"
        Me.TxtAppointmentDesc.Size = New System.Drawing.Size(606, 115)
        Me.TxtAppointmentDesc.TabIndex = 76
        '
        'DtpAppointmentDate
        '
        Me.DtpAppointmentDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpAppointmentDate.Location = New System.Drawing.Point(98, 28)
        Me.DtpAppointmentDate.Name = "DtpAppointmentDate"
        Me.DtpAppointmentDate.Size = New System.Drawing.Size(100, 20)
        Me.DtpAppointmentDate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Selected Pet"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 31)
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
        Me.CmbVet.Location = New System.Drawing.Point(98, 50)
        Me.CmbVet.Name = "CmbVet"
        Me.CmbVet.Size = New System.Drawing.Size(188, 22)
        Me.CmbVet.TabIndex = 74
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 54)
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
        Me.DtpAppointmentTime.Location = New System.Drawing.Point(200, 28)
        Me.DtpAppointmentTime.Name = "DtpAppointmentTime"
        Me.DtpAppointmentTime.ShowUpDown = True
        Me.DtpAppointmentTime.Size = New System.Drawing.Size(84, 20)
        Me.DtpAppointmentTime.TabIndex = 73
        '
        'TxtAppointmentID
        '
        Me.TxtAppointmentID.BackColor = System.Drawing.Color.Beige
        Me.TxtAppointmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAppointmentID.Location = New System.Drawing.Point(98, 7)
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
        Me.DgvSelectedPet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSelectedPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvSelectedPet.BackgroundColor = System.Drawing.Color.White
        Me.DgvSelectedPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSelectedPet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectedPetID, Me.SelectedPetName, Me.SelectedPetDOB, Me.SelectedAnimalTypeCode, Me.SelectedAnimalTypeName, Me.SelectedBreedCode, Me.SelectedBreedName, Me.SelectedSexCode, Me.SelectedSexName, Me.SelectedStatusCode, Me.SelectedStatusName, Me.IsDb})
        Me.DgvSelectedPet.Location = New System.Drawing.Point(98, 74)
        Me.DgvSelectedPet.MultiSelect = False
        Me.DgvSelectedPet.Name = "DgvSelectedPet"
        Me.DgvSelectedPet.ReadOnly = True
        Me.DgvSelectedPet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSelectedPet.Size = New System.Drawing.Size(606, 104)
        Me.DgvSelectedPet.TabIndex = 67
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.CmbStatus)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.CmbBreed)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.DtpPetDOB)
        Me.TabPage3.Controls.Add(Me.CmbSex)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.TxtPetName)
        Me.TabPage3.Controls.Add(Me.CmbAnimalType)
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 154)
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
        Me.DgvPetListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvBtnSelect, Me.PetID, Me.PetName, Me.PetDOB, Me.AnimalTypeCode, Me.AnimalTypeName, Me.BreedCode, Me.BreedName, Me.SexCode, Me.SexName, Me.StatusCode, Me.StatusName})
        Me.DgvPetListing.Location = New System.Drawing.Point(6, 19)
        Me.DgvPetListing.MultiSelect = False
        Me.DgvPetListing.Name = "DgvPetListing"
        Me.DgvPetListing.ReadOnly = True
        Me.DgvPetListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPetListing.Size = New System.Drawing.Size(686, 302)
        Me.DgvPetListing.TabIndex = 67
        '
        'CmbStatus
        '
        Me.CmbStatus.BackColor = System.Drawing.Color.White
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(89, 127)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(183, 22)
        Me.CmbStatus.TabIndex = 13
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 12)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 14)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "Pet Name"
        '
        'CmbBreed
        '
        Me.CmbBreed.BackColor = System.Drawing.Color.White
        Me.CmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBreed.FormattingEnabled = True
        Me.CmbBreed.Location = New System.Drawing.Point(89, 79)
        Me.CmbBreed.Name = "CmbBreed"
        Me.CmbBreed.Size = New System.Drawing.Size(183, 22)
        Me.CmbBreed.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(9, 131)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 14)
        Me.Label30.TabIndex = 61
        Me.Label30.Text = "Status"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 107)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 14)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "Sex"
        '
        'DtpPetDOB
        '
        Me.DtpPetDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPetDOB.Location = New System.Drawing.Point(89, 32)
        Me.DtpPetDOB.Name = "DtpPetDOB"
        Me.DtpPetDOB.Size = New System.Drawing.Size(100, 20)
        Me.DtpPetDOB.TabIndex = 9
        '
        'CmbSex
        '
        Me.CmbSex.BackColor = System.Drawing.Color.White
        Me.CmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSex.FormattingEnabled = True
        Me.CmbSex.Location = New System.Drawing.Point(89, 103)
        Me.CmbSex.Name = "CmbSex"
        Me.CmbSex.Size = New System.Drawing.Size(183, 22)
        Me.CmbSex.TabIndex = 12
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 14)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Breed"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(67, 14)
        Me.Label29.TabIndex = 58
        Me.Label29.Text = "Date of Birth"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 14)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "Type of Animal"
        '
        'TxtPetName
        '
        Me.TxtPetName.BackColor = System.Drawing.Color.Beige
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Location = New System.Drawing.Point(89, 9)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.ReadOnly = True
        Me.TxtPetName.Size = New System.Drawing.Size(183, 20)
        Me.TxtPetName.TabIndex = 8
        '
        'CmbAnimalType
        '
        Me.CmbAnimalType.BackColor = System.Drawing.Color.White
        Me.CmbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnimalType.FormattingEnabled = True
        Me.CmbAnimalType.Location = New System.Drawing.Point(89, 55)
        Me.CmbAnimalType.Name = "CmbAnimalType"
        Me.CmbAnimalType.Size = New System.Drawing.Size(183, 22)
        Me.CmbAnimalType.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtCountry)
        Me.TabPage1.Controls.Add(Me.TxtTelNo)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtCity)
        Me.TabPage1.Controls.Add(Me.TxtAddress3)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TxtState)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtPostcode)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.TxtNRICPassportNo)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.TxtMobileNo)
        Me.TabPage1.Controls.Add(Me.TxtAddress4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtCustomerID)
        Me.TabPage1.Controls.Add(Me.CmbSalutation)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.TxtCustomerName)
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
        Me.Label22.Location = New System.Drawing.Point(9, 371)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Country"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID"
        '
        'TxtCountry
        '
        Me.TxtCountry.BackColor = System.Drawing.Color.Beige
        Me.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCountry.Location = New System.Drawing.Point(94, 368)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.ReadOnly = True
        Me.TxtCountry.Size = New System.Drawing.Size(157, 20)
        Me.TxtCountry.TabIndex = 14
        '
        'TxtTelNo
        '
        Me.TxtTelNo.BackColor = System.Drawing.Color.Beige
        Me.TxtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelNo.Location = New System.Drawing.Point(94, 98)
        Me.TxtTelNo.Name = "TxtTelNo"
        Me.TxtTelNo.ReadOnly = True
        Me.TxtTelNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtTelNo.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 331)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 14)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Name"
        '
        'TxtCity
        '
        Me.TxtCity.BackColor = System.Drawing.Color.Beige
        Me.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCity.Location = New System.Drawing.Point(94, 324)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.ReadOnly = True
        Me.TxtCity.Size = New System.Drawing.Size(157, 20)
        Me.TxtCity.TabIndex = 12
        '
        'TxtAddress3
        '
        Me.TxtAddress3.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress3.Location = New System.Drawing.Point(94, 230)
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.ReadOnly = True
        Me.TxtAddress3.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress3.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 353)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 14)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone (Home)"
        '
        'TxtState
        '
        Me.TxtState.BackColor = System.Drawing.Color.Beige
        Me.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtState.Location = New System.Drawing.Point(94, 346)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.ReadOnly = True
        Me.TxtState.Size = New System.Drawing.Size(157, 20)
        Me.TxtState.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NRIC/Passport"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salutation"
        '
        'TxtPostcode
        '
        Me.TxtPostcode.BackColor = System.Drawing.Color.Beige
        Me.TxtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPostcode.Location = New System.Drawing.Point(94, 302)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.ReadOnly = True
        Me.TxtPostcode.Size = New System.Drawing.Size(157, 20)
        Me.TxtPostcode.TabIndex = 11
        '
        'TxtAddress2
        '
        Me.TxtAddress2.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress2.Location = New System.Drawing.Point(94, 208)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.ReadOnly = True
        Me.TxtAddress2.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress2.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 14)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Email"
        '
        'TxtNRICPassportNo
        '
        Me.TxtNRICPassportNo.BackColor = System.Drawing.Color.Beige
        Me.TxtNRICPassportNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNRICPassportNo.Location = New System.Drawing.Point(94, 76)
        Me.TxtNRICPassportNo.Name = "TxtNRICPassportNo"
        Me.TxtNRICPassportNo.ReadOnly = True
        Me.TxtNRICPassportNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtNRICPassportNo.TabIndex = 3
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Beige
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(94, 142)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(305, 20)
        Me.TxtEmail.TabIndex = 6
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.BackColor = System.Drawing.Color.Beige
        Me.TxtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMobileNo.Location = New System.Drawing.Point(94, 120)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.ReadOnly = True
        Me.TxtMobileNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtMobileNo.TabIndex = 5
        '
        'TxtAddress4
        '
        Me.TxtAddress4.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress4.Location = New System.Drawing.Point(94, 252)
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.ReadOnly = True
        Me.TxtAddress4.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress4.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Phone (Mobile)"
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerID.Location = New System.Drawing.Point(94, 8)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustomerID.TabIndex = 100
        '
        'CmbSalutation
        '
        Me.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSalutation.FormattingEnabled = True
        Me.CmbSalutation.Location = New System.Drawing.Point(94, 30)
        Me.CmbSalutation.Name = "CmbSalutation"
        Me.CmbSalutation.Size = New System.Drawing.Size(100, 22)
        Me.CmbSalutation.TabIndex = 1
        '
        'TxtAddress1
        '
        Me.TxtAddress1.BackColor = System.Drawing.Color.Beige
        Me.TxtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress1.Location = New System.Drawing.Point(94, 186)
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.ReadOnly = True
        Me.TxtAddress1.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress1.TabIndex = 7
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Location = New System.Drawing.Point(94, 54)
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
        'SelectedStatusCode
        '
        Me.SelectedStatusCode.HeaderText = "StatusCode"
        Me.SelectedStatusCode.Name = "SelectedStatusCode"
        Me.SelectedStatusCode.ReadOnly = True
        Me.SelectedStatusCode.Visible = False
        Me.SelectedStatusCode.Width = 88
        '
        'SelectedStatusName
        '
        Me.SelectedStatusName.HeaderText = "Status"
        Me.SelectedStatusName.Name = "SelectedStatusName"
        Me.SelectedStatusName.ReadOnly = True
        Me.SelectedStatusName.Width = 63
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
        'StatusCode
        '
        Me.StatusCode.HeaderText = "StatusCode"
        Me.StatusCode.Name = "StatusCode"
        Me.StatusCode.ReadOnly = True
        Me.StatusCode.Visible = False
        Me.StatusCode.Width = 88
        '
        'StatusName
        '
        Me.StatusName.HeaderText = "Status"
        Me.StatusName.Name = "StatusName"
        Me.StatusName.ReadOnly = True
        Me.StatusName.Width = 63
        '
        'FrmAppointmentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(743, 674)
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
        Me.TpAppointmentInformation.PerformLayout()
        CType(Me.DgvSelectedPet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvPetListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TcAppointmentInformation.ResumeLayout(False)
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
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents CmbBreed As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents DgvPetListing As DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtPetName As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents CmbAnimalType As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents CmbSex As ComboBox
    Friend WithEvents DtpPetDOB As DateTimePicker
    Friend WithEvents Label30 As Label
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
    Friend WithEvents CmbSalutation As ComboBox
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
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtAppointmentDesc As TextBox
    Friend WithEvents Label5 As Label
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
    Friend WithEvents SelectedPetID As DataGridViewTextBoxColumn
    Friend WithEvents SelectedPetName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedPetDOB As DataGridViewTextBoxColumn
    Friend WithEvents SelectedAnimalTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedAnimalTypeName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedBreedCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedBreedName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedSexCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedSexName As DataGridViewTextBoxColumn
    Friend WithEvents SelectedStatusCode As DataGridViewTextBoxColumn
    Friend WithEvents SelectedStatusName As DataGridViewTextBoxColumn
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
    Friend WithEvents StatusCode As DataGridViewTextBoxColumn
    Friend WithEvents StatusName As DataGridViewTextBoxColumn
End Class
