<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerEntry))
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
        Me.TxtPetID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCustomerIDPI = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCustomerNamePI = New System.Windows.Forms.TextBox()
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
        Me.TxtPetAllergy = New System.Windows.Forms.TextBox()
        Me.TxtPetDiet = New System.Windows.Forms.TextBox()
        Me.TxtPetWeight = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.CmbBreed = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvConsultationHistory = New System.Windows.Forms.DataGridView()
        Me.PnlActionBar = New System.Windows.Forms.Panel()
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
        CType(Me.DgvConsultationHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActionBar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbSalutation
        '
        Me.CmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSalutation.FormattingEnabled = True
        Me.CmbSalutation.Location = New System.Drawing.Point(94, 34)
        Me.CmbSalutation.Name = "CmbSalutation"
        Me.CmbSalutation.Size = New System.Drawing.Size(58, 22)
        Me.CmbSalutation.TabIndex = 1
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMobileNo.Location = New System.Drawing.Point(94, 135)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtMobileNo.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Phone (Mobile)"
        '
        'TxtAddress2
        '
        Me.TxtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress2.Location = New System.Drawing.Point(94, 220)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress2.TabIndex = 8
        '
        'TxtAddress3
        '
        Me.TxtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress3.Location = New System.Drawing.Point(94, 244)
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(305, 20)
        Me.TxtAddress3.TabIndex = 9
        '
        'TxtAddress4
        '
        Me.TxtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress4.Location = New System.Drawing.Point(94, 268)
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
        Me.TxtTelNo.Location = New System.Drawing.Point(94, 110)
        Me.TxtTelNo.Name = "TxtTelNo"
        Me.TxtTelNo.Size = New System.Drawing.Size(305, 20)
        Me.TxtTelNo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 113)
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
        Me.TxtNRICPassportNo.Location = New System.Drawing.Point(94, 86)
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
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NRIC/Passport"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 38)
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
        Me.TxtCustomerID.Size = New System.Drawing.Size(100, 20)
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
        'TxtPetID
        '
        Me.TxtPetID.BackColor = System.Drawing.Color.Beige
        Me.TxtPetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetID.Location = New System.Drawing.Point(95, 58)
        Me.TxtPetID.Name = "TxtPetID"
        Me.TxtPetID.ReadOnly = True
        Me.TxtPetID.Size = New System.Drawing.Size(100, 20)
        Me.TxtPetID.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 14)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Customer ID"
        '
        'TxtCustomerIDPI
        '
        Me.TxtCustomerIDPI.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerIDPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerIDPI.Location = New System.Drawing.Point(95, 6)
        Me.TxtCustomerIDPI.Name = "TxtCustomerIDPI"
        Me.TxtCustomerIDPI.ReadOnly = True
        Me.TxtCustomerIDPI.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustomerIDPI.TabIndex = 69
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 14)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Customer Name"
        '
        'TxtCustomerNamePI
        '
        Me.TxtCustomerNamePI.BackColor = System.Drawing.Color.Beige
        Me.TxtCustomerNamePI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerNamePI.Location = New System.Drawing.Point(95, 31)
        Me.TxtCustomerNamePI.Name = "TxtCustomerNamePI"
        Me.TxtCustomerNamePI.ReadOnly = True
        Me.TxtCustomerNamePI.Size = New System.Drawing.Size(306, 20)
        Me.TxtCustomerNamePI.TabIndex = 71
        '
        'BtnCancelEdit
        '
        Me.BtnCancelEdit.Location = New System.Drawing.Point(301, 286)
        Me.BtnCancelEdit.Name = "BtnCancelEdit"
        Me.BtnCancelEdit.Size = New System.Drawing.Size(100, 25)
        Me.BtnCancelEdit.TabIndex = 16
        Me.BtnCancelEdit.Text = "Cancel Edit"
        Me.BtnCancelEdit.UseVisualStyleBackColor = True
        Me.BtnCancelEdit.Visible = False
        '
        'BtnClearPet
        '
        Me.BtnClearPet.Location = New System.Drawing.Point(198, 286)
        Me.BtnClearPet.Name = "BtnClearPet"
        Me.BtnClearPet.Size = New System.Drawing.Size(100, 25)
        Me.BtnClearPet.TabIndex = 15
        Me.BtnClearPet.Text = "Clear"
        Me.BtnClearPet.UseVisualStyleBackColor = True
        '
        'BtnAddPet
        '
        Me.BtnAddPet.Location = New System.Drawing.Point(95, 286)
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
        Me.CmbSex.Location = New System.Drawing.Point(95, 156)
        Me.CmbSex.Name = "CmbSex"
        Me.CmbSex.Size = New System.Drawing.Size(183, 22)
        Me.CmbSex.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 14)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 14)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Sex"
        '
        'DtpPetDOB
        '
        Me.DtpPetDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPetDOB.Location = New System.Drawing.Point(95, 83)
        Me.DtpPetDOB.Name = "DtpPetDOB"
        Me.DtpPetDOB.Size = New System.Drawing.Size(183, 20)
        Me.DtpPetDOB.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 14)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Date of Birth"
        '
        'CmbAnimalType
        '
        Me.CmbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAnimalType.FormattingEnabled = True
        Me.CmbAnimalType.Location = New System.Drawing.Point(95, 106)
        Me.CmbAnimalType.Name = "CmbAnimalType"
        Me.CmbAnimalType.Size = New System.Drawing.Size(183, 22)
        Me.CmbAnimalType.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Pet Name"
        '
        'TxtPetName
        '
        Me.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetName.Location = New System.Drawing.Point(198, 58)
        Me.TxtPetName.Name = "TxtPetName"
        Me.TxtPetName.Size = New System.Drawing.Size(203, 20)
        Me.TxtPetName.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Type of Animal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 135)
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
        Me.DgvPetListing.Location = New System.Drawing.Point(8, 317)
        Me.DgvPetListing.MultiSelect = False
        Me.DgvPetListing.Name = "DgvPetListing"
        Me.DgvPetListing.ReadOnly = True
        Me.DgvPetListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPetListing.Size = New System.Drawing.Size(588, 161)
        Me.DgvPetListing.TabIndex = 67
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 511)
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
        Me.TabPage1.Size = New System.Drawing.Size(604, 484)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 344)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 14)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCountry.Location = New System.Drawing.Point(94, 341)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(157, 20)
        Me.TxtCountry.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(222, 296)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 14)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "City"
        '
        'TxtCity
        '
        Me.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCity.Location = New System.Drawing.Point(250, 293)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(149, 20)
        Me.TxtCity.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 320)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 14)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "State"
        '
        'TxtState
        '
        Me.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtState.Location = New System.Drawing.Point(94, 317)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.Size = New System.Drawing.Size(157, 20)
        Me.TxtState.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 296)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 104
        Me.Label19.Text = "Postcode"
        '
        'TxtPostcode
        '
        Me.TxtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPostcode.Location = New System.Drawing.Point(94, 293)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.Size = New System.Drawing.Size(58, 20)
        Me.TxtPostcode.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 14)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(94, 160)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(305, 20)
        Me.TxtEmail.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtPetAllergy)
        Me.TabPage2.Controls.Add(Me.TxtPetDiet)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtPetWeight)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.DtpPetDOB)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.CmbSex)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.CmbStatus)
        Me.TabPage2.Controls.Add(Me.BtnAddPet)
        Me.TabPage2.Controls.Add(Me.CmbBreed)
        Me.TabPage2.Controls.Add(Me.CmbAnimalType)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.BtnClearPet)
        Me.TabPage2.Controls.Add(Me.TxtPetID)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.BtnCancelEdit)
        Me.TabPage2.Controls.Add(Me.DgvPetListing)
        Me.TabPage2.Controls.Add(Me.TxtPetName)
        Me.TabPage2.Controls.Add(Me.TxtCustomerIDPI)
        Me.TabPage2.Controls.Add(Me.TxtCustomerNamePI)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(604, 484)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pet Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtPetAllergy
        '
        Me.TxtPetAllergy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetAllergy.Location = New System.Drawing.Point(95, 209)
        Me.TxtPetAllergy.Name = "TxtPetAllergy"
        Me.TxtPetAllergy.Size = New System.Drawing.Size(183, 20)
        Me.TxtPetAllergy.TabIndex = 78
        '
        'TxtPetDiet
        '
        Me.TxtPetDiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetDiet.Location = New System.Drawing.Point(95, 234)
        Me.TxtPetDiet.Name = "TxtPetDiet"
        Me.TxtPetDiet.Size = New System.Drawing.Size(183, 20)
        Me.TxtPetDiet.TabIndex = 77
        '
        'TxtPetWeight
        '
        Me.TxtPetWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPetWeight.Location = New System.Drawing.Point(95, 184)
        Me.TxtPetWeight.Name = "TxtPetWeight"
        Me.TxtPetWeight.Size = New System.Drawing.Size(73, 20)
        Me.TxtPetWeight.TabIndex = 76
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(10, 237)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(25, 14)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "Diet"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 212)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 14)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "Allergy"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 186)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 14)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Weight"
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(95, 260)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(183, 22)
        Me.CmbStatus.TabIndex = 13
        '
        'CmbBreed
        '
        Me.CmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBreed.FormattingEnabled = True
        Me.CmbBreed.Location = New System.Drawing.Point(95, 131)
        Me.CmbBreed.Name = "CmbBreed"
        Me.CmbBreed.Size = New System.Drawing.Size(183, 22)
        Me.CmbBreed.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvConsultationHistory)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(604, 484)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Visit History"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvConsultationHistory
        '
        Me.DgvConsultationHistory.AllowUserToAddRows = False
        Me.DgvConsultationHistory.AllowUserToDeleteRows = False
        Me.DgvConsultationHistory.AllowUserToOrderColumns = True
        Me.DgvConsultationHistory.BackgroundColor = System.Drawing.Color.White
        Me.DgvConsultationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultationHistory.GridColor = System.Drawing.SystemColors.Control
        Me.DgvConsultationHistory.Location = New System.Drawing.Point(3, 3)
        Me.DgvConsultationHistory.Name = "DgvConsultationHistory"
        Me.DgvConsultationHistory.ReadOnly = True
        Me.DgvConsultationHistory.Size = New System.Drawing.Size(598, 478)
        Me.DgvConsultationHistory.TabIndex = 0
        '
        'PnlActionBar
        '
        Me.PnlActionBar.BackColor = System.Drawing.SystemColors.Control
        Me.PnlActionBar.Controls.Add(Me.BtnPrint)
        Me.PnlActionBar.Controls.Add(Me.BtnClose)
        Me.PnlActionBar.Controls.Add(Me.BtnCancel)
        Me.PnlActionBar.Controls.Add(Me.BtnEdit)
        Me.PnlActionBar.Controls.Add(Me.BtnSave)
        Me.PnlActionBar.Location = New System.Drawing.Point(12, 12)
        Me.PnlActionBar.Name = "PnlActionBar"
        Me.PnlActionBar.Size = New System.Drawing.Size(612, 57)
        Me.PnlActionBar.TabIndex = 69
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPrint.Location = New System.Drawing.Point(303, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(60, 52)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.BackgroundImage = CType(resources.GetObject("BtnClose.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClose.Location = New System.Drawing.Point(547, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 52)
        Me.BtnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancel.Location = New System.Drawing.Point(425, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 52)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.Location = New System.Drawing.Point(486, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(60, 52)
        Me.BtnEdit.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Edit")
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSave.Location = New System.Drawing.Point(364, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 52)
        Me.BtnSave.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Save")
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtCreatedBy
        '
        Me.TxtCreatedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCreatedBy.Location = New System.Drawing.Point(76, 5)
        Me.TxtCreatedBy.Name = "TxtCreatedBy"
        Me.TxtCreatedBy.ReadOnly = True
        Me.TxtCreatedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtCreatedBy.TabIndex = 74
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 14)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Created By"
        '
        'TxtModifiedBy
        '
        Me.TxtModifiedBy.BackColor = System.Drawing.Color.Beige
        Me.TxtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtModifiedBy.Location = New System.Drawing.Point(76, 27)
        Me.TxtModifiedBy.Name = "TxtModifiedBy"
        Me.TxtModifiedBy.ReadOnly = True
        Me.TxtModifiedBy.Size = New System.Drawing.Size(65, 20)
        Me.TxtModifiedBy.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 14)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Modified By"
        '
        'TxtDateCreated
        '
        Me.TxtDateCreated.BackColor = System.Drawing.Color.Beige
        Me.TxtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateCreated.Location = New System.Drawing.Point(145, 5)
        Me.TxtDateCreated.Name = "TxtDateCreated"
        Me.TxtDateCreated.ReadOnly = True
        Me.TxtDateCreated.Size = New System.Drawing.Size(132, 20)
        Me.TxtDateCreated.TabIndex = 77
        '
        'TxtDateModified
        '
        Me.TxtDateModified.BackColor = System.Drawing.Color.Beige
        Me.TxtDateModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateModified.Location = New System.Drawing.Point(145, 27)
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
        Me.Panel3.Location = New System.Drawing.Point(12, 587)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(612, 57)
        Me.Panel3.TabIndex = 79
        '
        'FrmCustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(636, 653)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PnlActionBar)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmCustomerEntry"
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
        CType(Me.DgvConsultationHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActionBar.ResumeLayout(False)
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
    Friend WithEvents TxtPetID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCustomerIDPI As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCustomerNamePI As TextBox
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
    Friend WithEvents CmbStatus As ComboBox
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
    Friend WithEvents DgvConsultationHistory As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtPetAllergy As TextBox
    Friend WithEvents TxtPetDiet As TextBox
    Friend WithEvents TxtPetWeight As TextBox
End Class
