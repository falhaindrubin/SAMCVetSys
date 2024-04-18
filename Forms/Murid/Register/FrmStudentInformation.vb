Public Class FrmStudentInformation

#Region "FormProperty"

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
        End Set
    End Property

    Private _AddPetOnly As Boolean
    Public Property AddPetOnly As Boolean
        Get
            Return _AddPetOnly
        End Get
        Set(value As Boolean)
            _AddPetOnly = value
        End Set
    End Property

#End Region

    Private Sub FrmAddNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateSalutation()
        PopulateAnimalType()
        PopulateBreed()
        PopulatePetSex()
        PopulateNeuterStatus()
        PopulateForm(UserCommand)
    End Sub

    Private Sub PopulateSalutation()

        Dim DtSalute As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtSalute = ClsCustomer.GetSalutation(ClsCustomer)
            If DtSalute.Rows.Count > 0 Then

                For i As Integer = 0 To DtSalute.Rows.Count - 1
                    CmbSource.Add(DtSalute.Rows(i).Item("SaluteCode"), DtSalute.Rows(i).Item("SaluteName"))
                Next

                'If CmbSalutation.Items.Count > 0 Then
                '    CmbSalutation.DataSource = Nothing
                '    CmbSalutation.Items.Clear()
                'End If

                'CmbSalutation.DataSource = New BindingSource(CmbSource, Nothing)
                'CmbSalutation.DisplayMember = "Value"
                'CmbSalutation.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulateSalutation()")
        End Try

    End Sub

    Private Sub PopulateAnimalType()

        Dim DtAnimalType As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtAnimalType = ClsPet.GetAnimalType(ClsPet)
            If DtAnimalType.Rows.Count > 0 Then

                For i As Integer = 0 To DtAnimalType.Rows.Count - 1
                    CmbSource.Add(DtAnimalType.Rows(i).Item("AnimalTypeCode"), DtAnimalType.Rows(i).Item("AnimalTypeName"))
                Next

                If CmbAnimalType.Items.Count > 0 Then
                    CmbAnimalType.DataSource = Nothing
                    CmbAnimalType.Items.Clear()
                End If

                CmbAnimalType.DataSource = New BindingSource(CmbSource, Nothing)
                CmbAnimalType.DisplayMember = "Value"
                CmbAnimalType.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulateAnimalType()")
        End Try

    End Sub

    Private Sub PopulateBreed()

        Dim DtBreed As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            ClsPet.AnimalTypeCode = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString

            DtBreed = ClsPet.GetPetBreed(ClsPet)
            If DtBreed.Rows.Count > 0 Then

                For i As Integer = 0 To DtBreed.Rows.Count - 1
                    CmbSource.Add(DtBreed.Rows(i).Item("BreedCode"), DtBreed.Rows(i).Item("BreedName"))
                Next

                If CmbBreed.Items.Count > 0 Then
                    CmbBreed.DataSource = Nothing
                    CmbBreed.Items.Clear()
                End If

                CmbBreed.DataSource = New BindingSource(CmbSource, Nothing)
                CmbBreed.DisplayMember = "Value"
                CmbBreed.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateBreed()")
        End Try

    End Sub

    Private Sub PopulatePetSex()

        Dim DtPetSex As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtPetSex = ClsPet.GetPetSex(ClsPet)
            If DtPetSex.Rows.Count > 0 Then

                For i As Integer = 0 To DtPetSex.Rows.Count - 1
                    CmbSource.Add(DtPetSex.Rows(i).Item("SexCode"), DtPetSex.Rows(i).Item("SexName"))
                Next

                If CmbSex.Items.Count > 0 Then
                    CmbSex.DataSource = Nothing
                    CmbSex.Items.Clear()
                End If

                CmbSex.DataSource = New BindingSource(CmbSource, Nothing)
                CmbSex.DisplayMember = "Value"
                CmbSex.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulatePetSex()")
        End Try

    End Sub

    Private Sub PopulateNeuterStatus()

        Dim DtPetStatus As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtPetStatus = ClsPet.GetNeuterStatus(ClsPet)
            If DtPetStatus.Rows.Count > 0 Then

                For i As Integer = 0 To DtPetStatus.Rows.Count - 1
                    CmbSource.Add(DtPetStatus.Rows(i).Item("NeuterCode"), DtPetStatus.Rows(i).Item("NeuterName"))
                Next

                If CmbNeuterStatus.Items.Count > 0 Then
                    CmbNeuterStatus.DataSource = Nothing
                    CmbNeuterStatus.Items.Clear()
                End If

                CmbNeuterStatus.DataSource = New BindingSource(CmbSource, Nothing)
                CmbNeuterStatus.DisplayMember = "Value"
                CmbNeuterStatus.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulateNeuterStatus()")
        End Try

    End Sub

    Private Sub PopulateForm(ByVal UserCommand As String)

        'Dim BtnDelete As New DataGridViewButtonColumn
        'Dim BtnEdit As New DataGridViewButtonColumn
        Dim DtCustomer As New DataTable
        Dim DtPet As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim ClsPet As New ClsPet

        Try
            If CustomerID <> "" Then 'UserCommand

                'If UserCommand = "SHOW_CUSTOMER_INFO" Then

                'Get customer information 
                ClsCustomer = New ClsCustomer
                With ClsCustomer
                    .CustomerID = CustomerID
                    DtCustomer = .GetCustomerInformation(ClsCustomer)
                End With

                'Get pet information
                ClsPet = New ClsPet
                With ClsPet
                    .CustomerID = CustomerID
                    DtPet = .GetPetListing(ClsPet)
                End With

                If DtCustomer.Rows.Count > 0 Then

                    'Set fields using Customer information retrieved from database
                    TxtCustomerID.Text = DtCustomer.Rows(0).Item("CustomerID")
                    'CmbSalutation.Text = DtCustomer.Rows(0).Item("SaluteName")
                    'TxtCustomerName.Text = DtCustomer.Rows(0).Item("CustomerName")
                    TxtNRICPassportNo.Text = DtCustomer.Rows(0).Item("NRICPassportNo")
                    TxtAddress1.Text = DtCustomer.Rows(0).Item("AddressLine1")
                    TxtAddress2.Text = DtCustomer.Rows(0).Item("AddressLine2")
                    TxtAddress3.Text = DtCustomer.Rows(0).Item("AddressLine3")
                    TxtAddress4.Text = DtCustomer.Rows(0).Item("AddressLine4")
                    'TxtTelNo.Text = DtCustomer.Rows(0).Item("TelNo")
                    'TxtMobileNo.Text = DtCustomer.Rows(0).Item("MobileNo")
                    'TxtEmail.Text = DtCustomer.Rows(0).Item("Email")
                    'TxtPostcode.Text = DtCustomer.Rows(0).Item("Postcode")
                    'TxtCity.Text = DtCustomer.Rows(0).Item("City")
                    'TxtState.Text = DtCustomer.Rows(0).Item("State")
                    'TxtCountry.Text = DtCustomer.Rows(0).Item("Country")
                    'TxtCreatedBy.Text = DtCustomer.Rows(0).Item("CreatedBy")
                    'TxtDateCreated.Text = DtCustomer.Rows(0).Item("DateCreated")
                    'TxtModifiedBy.Text = DtCustomer.Rows(0).Item("ModifiedBy")
                    'TxtDateModified.Text = DtCustomer.Rows(0).Item("DateModified")

                    If DtPet.Rows.Count > 0 Then

                        TxtPetName.Text = DtPet.Rows(0).Item("PetName")
                        DtpPetDOB.Value = CDate(DtPet.Rows(0).Item("PetDOB")).Date
                        CmbAnimalType.SelectedValue = CStr(DtPet.Rows(0).Item("AnimalTypeCode"))
                        CmbBreed.SelectedValue = CStr(DtPet.Rows(0).Item("BreedCode"))
                        CmbSex.SelectedValue = CStr(DtPet.Rows(0).Item("SexCode"))
                        CmbNeuterStatus.SelectedValue = CStr(DtPet.Rows(0).Item("NeuterCode"))

                        With DgvPetListing

                            If DgvPetListing.Rows.Count > 0 Then
                                DgvPetListing.Rows.Clear()
                            End If

                            For i As Integer = 0 To DtPet.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells("PetID").Value = DtPet.Rows(i).Item("PetID")
                                .Rows(i).Cells("PetName").Value = DtPet.Rows(i).Item("PetName")
                                .Rows(i).Cells("PetDOB").Value = CDate(DtPet.Rows(i).Item("PetDOB")).ToShortDateString
                                .Rows(i).Cells("AnimalTypeCode").Value = DtPet.Rows(i).Item("AnimalTypeCode")
                                .Rows(i).Cells("AnimalTypeName").Value = DtPet.Rows(i).Item("AnimalTypeName")
                                .Rows(i).Cells("BreedCode").Value = DtPet.Rows(i).Item("BreedCode")
                                .Rows(i).Cells("BreedName").Value = DtPet.Rows(i).Item("BreedName")
                                .Rows(i).Cells("SexCode").Value = DtPet.Rows(i).Item("SexCode")
                                .Rows(i).Cells("SexName").Value = DtPet.Rows(i).Item("SexName")
                                .Rows(i).Cells("NeuterCode").Value = DtPet.Rows(i).Item("NeuterCode")
                                .Rows(i).Cells("NeuterName").Value = DtPet.Rows(i).Item("NeuterName")
                                .Rows(i).Cells("IsDb").Value = "1"
                            Next

                        End With

                    End If

                    'Show previous visits
                    Dim ClsVisit As New ClsVisit
                    Dim DtVisit As New DataTable
                    With ClsVisit
                        .CustomerID = CustomerID
                        DtVisit = .GetVisitListing(ClsVisit)
                        If DtVisit.Rows.Count > 0 Then

                            With DgvVisitHistory
                                .Rows.Clear()
                                For i As Integer = 0 To DtVisit.Rows.Count - 1
                                    With DgvVisitHistory
                                        .Rows.Add()
                                        .Rows(i).Cells("VisitID").Value = DtVisit.Rows(i).Item("VisitID")
                                        .Rows(i).Cells("VisitTime").Value = DtVisit.Rows(i).Item("VisitTime")
                                        .Rows(i).Cells("VisitDescription").Value = DtVisit.Rows(i).Item("VisitDescription")
                                        .Rows(i).Cells("EmployeeName").Value = "DR. " & DtVisit.Rows(i).Item("EmployeeName")
                                        .Rows(i).Cells("IsVisitCompleted").Value = IIf(DtVisit.Rows(i).Item("IsVisitCompleted") = "1", "COMPLETED", "ON-GOING")
                                    End With
                                Next
                            End With

                            'If DgvVisitHistory.Rows.Count > 0 Then
                            '    DgvVisitHistory.Rows.Clear()
                            'End If

                        End If
                    End With

                End If

                SetFields(UserCommand)

                'End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub SetFields(ByVal ClearCommand As String, Optional ByVal Param1 As String = "")

        Try
            Select Case ClearCommand
                Case "SET_PET_FIELDS"

                    'TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    CmbAnimalType.SelectedIndex = 0
                    CmbBreed.SelectedIndex = 0
                    CmbNeuterStatus.SelectedIndex = 0
                    CmbSex.SelectedIndex = 0

                Case "ADD_NEW_CUSTOMER"

                    'Customer information
                    'CmbSalutation.Enabled = False
                    TxtCustomerName.ReadOnly = True
                    TxtNRICPassportNo.ReadOnly = True
                    TxtAddress1.ReadOnly = True
                    TxtAddress2.ReadOnly = True
                    TxtAddress3.ReadOnly = True
                    TxtAddress4.ReadOnly = True
                    'TxtTelNo.ReadOnly = True
                    'TxtMobileNo.ReadOnly = True
                    TxtEmail.ReadOnly = True
                    TxtCustomerID.Text = UCase(TxtCustomerID.Tag)
                    TxtCustomerName.Text = UCase(TxtCustomerName.Text)
                    TxtNRICPassportNo.Text = UCase(TxtNRICPassportNo.Text)
                    TxtAddress1.Text = UCase(TxtAddress1.Text)
                    TxtAddress2.Text = UCase(TxtAddress2.Text)
                    TxtAddress3.Text = UCase(TxtAddress3.Text)
                    TxtAddress4.Text = UCase(TxtAddress4.Text)
                    'TxtPostcode.Text = UCase(TxtPostcode.Text)
                    'TxtPostcode.ReadOnly = True
                    'TxtCity.Text = UCase(TxtCity.Text)
                    'TxtCity.ReadOnly = True
                    'TxtState.Text = UCase(TxtState.Text)
                    'TxtState.ReadOnly = True
                    'TxtCountry.Text = UCase(TxtCountry.Text)
                    'TxtCountry.ReadOnly = True

                    'Pet information from customer information
                    'TxtCustomerIDPI.Text = UCase(TxtCustomerID.Tag)
                    'TxtCustomerNamePI.Text = UCase(TxtCustomerName.Text)
                    'TxtPetID.Text = UCase(TxtPetID.Tag)
                    TxtPetName.Text = UCase(TxtPetName.Text)

                Case "CLEAR_PET_FIELDS"
                    'TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    CmbAnimalType.SelectedIndex = 0
                    CmbBreed.SelectedIndex = 0
                    CmbSex.SelectedIndex = 0
                    CmbNeuterStatus.SelectedIndex = 0

                Case "SHOW_CUSTOMER_INFO", "CANCELEDIT_CUSTOMER_INFO"

                    BtnSave.Enabled = False

                    'CmbSalutation.Enabled = False
                    'TxtCustomerName.ReadOnly = True
                    'TxtNRICPassportNo.ReadOnly = True
                    'TxtTelNo.ReadOnly = True
                    'TxtMobileNo.ReadOnly = True
                    'TxtEmail.ReadOnly = True
                    'TxtAddress1.ReadOnly = True
                    'TxtAddress2.ReadOnly = True
                    'TxtAddress3.ReadOnly = True
                    'TxtAddress4.ReadOnly = True
                    'TxtPostcode.ReadOnly = True
                    'TxtCity.ReadOnly = True
                    'TxtState.ReadOnly = True
                    'TxtCountry.ReadOnly = True

                    TxtPetName.ReadOnly = True
                    DtpPetDOB.Enabled = False
                    CmbAnimalType.Enabled = False
                    CmbBreed.Enabled = False
                    CmbSex.Enabled = False
                    CmbNeuterStatus.Enabled = False
                    BtnAddPet.Enabled = False
                    BtnClearPet.Enabled = False
                    DgvPetListing.Enabled = False

                Case "EDIT_CUSTOMER_INFO"

                    BtnSave.Enabled = True

                    'CmbSalutation.Enabled = True
                    'TxtCustomerName.ReadOnly = False
                    'TxtNRICPassportNo.ReadOnly = False
                    'TxtTelNo.ReadOnly = False
                    'TxtMobileNo.ReadOnly = False
                    'TxtEmail.ReadOnly = False
                    'TxtAddress1.ReadOnly = False
                    'TxtAddress2.ReadOnly = False
                    'TxtAddress3.ReadOnly = False
                    'TxtAddress4.ReadOnly = False
                    'TxtPostcode.ReadOnly = False
                    'TxtCity.ReadOnly = False
                    'TxtState.ReadOnly = False
                    'TxtCountry.ReadOnly = False

                    'TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    TxtPetName.ReadOnly = False
                    DtpPetDOB.Enabled = True
                    CmbAnimalType.Enabled = True
                    CmbBreed.Enabled = True
                    CmbSex.Enabled = True
                    CmbNeuterStatus.Enabled = True
                    BtnAddPet.Enabled = True
                    BtnClearPet.Enabled = True
                    DgvPetListing.Enabled = True

                Case "EDIT_PET"
                    BtnAddPet.Text = "Update Pet"
                    BtnAddPet.Tag = "UPDATE_PET"
                    BtnCancelEdit.Visible = True

                Case "CANCEL_EDIT_PET", "EDITED_PET"
                    BtnAddPet.Text = "Add Pet"
                    BtnAddPet.Tag = ""
                    BtnCancelEdit.Visible = False
                    'TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    DtpPetDOB.Value = Now
                    CmbAnimalType.SelectedIndex = 0
                    CmbBreed.SelectedIndex = 0
                    CmbSex.SelectedIndex = 0
                    CmbNeuterStatus.SelectedIndex = 0

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SetFields()")
        End Try

    End Sub

    Private Function UpdateCustomer() As Boolean

        Dim ClsCustomer As ClsCustomer
        Dim ClsPet As ClsPet
        Dim PetID As String = ""

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            ClsCustomer = New ClsCustomer
            With ClsCustomer
                .CustomerID = UCase(Trim(TxtCustomerID.Text))
                '.SaluteCode = DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Key.ToString '(DirectCast(CmbSalutation.Items(0), DataRowView).Row(CmbSalutation.ValueMember)).ToString() 'UCase(Trim(CmbSalutation.Text))
                '.SaluteName = DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Value.ToString '(DirectCast(CmbSalutation.Items(0), DataRowView).Row(CmbSalutation.ValueMember)).ToString() 'UCase(Trim(CmbSalutation.Text))
                .CustomerName = UCase(Trim(TxtCustomerName.Text))
                .NRICPassportNo = UCase(Trim(TxtNRICPassportNo.Text))
                .AddressLine1 = UCase(Trim(TxtAddress1.Text))
                .AddressLine2 = UCase(Trim(TxtAddress2.Text))
                .AddressLine3 = UCase(Trim(TxtAddress3.Text))
                .AddressLine4 = UCase(Trim(TxtAddress4.Text))
                '.TelNo = UCase(Trim(TxtTelNo.Text))
                '.MobileNo = UCase(Trim(TxtMobileNo.Text))
                .Email = UCase(Trim(TxtEmail.Text))
                '.Postcode = UCase(Trim(TxtPostcode.Text))
                '.City = UCase(Trim(TxtCity.Text))
                '.State = UCase(Trim(TxtState.Text))
                '.Country = UCase(Trim(TxtCountry.Text))
                .Ref.ModifiedBy = UCase(CURR_USER)
                .Ref.DateModified = Now
            End With

            If Not ClsCustomer.UpdateCustomer(ClsCustomer, DbConn, DbTrans) Then
                DbTrans.Rollback()
                MsgBox("Failed to update customer.", MsgBoxStyle.Critical, FORM_NAME & ".UpdateCustomer()")
                Return False
            End If

            'Update or add new pet
            If DgvPetListing.Rows.Count > 0 Then

                'Get customer registered pet count, and use it as PetID last number
                '== Code goes here
                Dim PetCount As Integer

                For h As Integer = 0 To DgvPetListing.Rows.Count - 1
                    If DgvPetListing.Rows(h).Cells("PetID").Value <> "" Then
                        PetCount += 1
                    End If
                Next

                For i As Integer = 0 To DgvPetListing.Rows.Count - 1

                    If DgvPetListing.Rows(i).Cells("PetID").Value = "" Then

                        PetID = GenerateRunningNo("PT", DbConn, DbTrans, CStr(PetCount))
                        If PetID = "" Then
                            MsgBox("Failed to generate pet ID.", MsgBoxStyle.Critical, FORM_NAME & ".UpdateCustomer()")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            Return False
                        End If

                    End If

                    ClsPet = New ClsPet
                    With ClsPet
                        .CustomerID = UCase(Trim(TxtCustomerID.Text))
                        .PetID = IIf(PetID = "", DgvPetListing.Rows(i).Cells("PetID").Value, PetID)
                        .PetName = DgvPetListing.Rows(i).Cells("PetName").Value
                        .PetDOB = DgvPetListing.Rows(i).Cells("PetDOB").Value
                        .AnimalTypeCode = DgvPetListing.Rows(i).Cells("AnimalTypeCode").Value
                        .AnimalTypeName = DgvPetListing.Rows(i).Cells("AnimalTypeName").Value
                        .BreedCode = DgvPetListing.Rows(i).Cells("BreedCode").Value
                        .BreedName = DgvPetListing.Rows(i).Cells("BreedName").Value
                        .SexCode = DgvPetListing.Rows(i).Cells("SexCode").Value
                        .SexName = DgvPetListing.Rows(i).Cells("SexName").Value
                        .NeuterCode = DgvPetListing.Rows(i).Cells("NeuterCode").Value
                        .NeuterName = DgvPetListing.Rows(i).Cells("NeuterName").Value
                        .Ref.DateCreated = Now
                        .Ref.CreatedBy = UCase(CURR_USER)
                        .Ref.DateModified = Now
                        .Ref.ModifiedBy = UCase(CURR_USER)
                    End With

                    If Not ClsPet.UpdatePet(ClsPet, DbConn, DbTrans) Then
                        DbTrans.Rollback()
                        MsgBox("Failed to update pet information.", MsgBoxStyle.Critical, FORM_NAME & ".UpdateCustomer()")
                        Return False
                    End If

                Next

            End If

            If Not ResetPetIDRunningNo("PT", DbConn, DbTrans) Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                MsgBox("Failed to update Pet ID.", MsgBoxStyle.Critical, "Failed to reset Pet ID.")
                Return False
            End If

            DbTrans.Commit()
            ShowPetListing()
            MsgBox("Customer and pet information has been successfully updated!", MsgBoxStyle.Information, "Customer Update Succeeded!")

        Catch ex As Exception
            DbTrans.Rollback()
            DbTrans.Dispose()
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateCustomer()")
            Return False
        End Try

        Return True

    End Function

    Private Function CheckUserInput(UserCommand As String) As Boolean

        Dim NRICPassport As String
        Dim CustomerName As String

        Try
            NRICPassport = TxtNRICPassportNo.Text
            CustomerName = TxtCustomerName.Text

            If NRICPassport = "" Or CustomerName = "" Then
                MsgBox("Please enter customer's name and NRIC/Passport number.", MsgBoxStyle.Exclamation, "Enter customer's information.")
                Return False
            End If

            If UserCommand = "ADD_PET" Then
                'If TxtPetID.Text <> "" Then
                '    For i As Integer = 0 To DgvPetListing.Rows.Count - 1
                '        If TxtPetID.Text = DgvPetListing.Rows(i).Cells("PetID").Value Then
                '            MsgBox("Unable to add pet. The pet has been registered.", MsgBoxStyle.Critical, "Duplicate Pet.")
                '            Return False
                '        End If
                '    Next
                'End If
                If TxtPetName.Text = "" Then
                    MsgBox("Please enter your pet's name.", MsgBoxStyle.Exclamation, "Enter Pet's Name.")
                    Return False
                End If
            Else
                If DgvPetListing.Rows.Count = 0 Then
                    MsgBox("Please enter pet's information.", MsgBoxStyle.Exclamation, "Enter pet's information.")
                    Return False
                End If
            End If

            If Not CheckExistingCustomer(UserCommand) Then Return False

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Return True

    End Function

    Private Function CheckExistingCustomer(UserCommand As String) As Boolean

        'Check existing client in the system by using NRIC
        Dim NRICPassportNo As String
        Dim ClsCustomer As New ClsCustomer
        Dim DtCustomer As New DataTable

        Try
            NRICPassportNo = Trim(TxtNRICPassportNo.Text)

            If NRICPassportNo <> "" Then

                Select Case UserCommand
                    Case "EDIT_CUSTOMER_INFO"
                        Return True
                    Case "ADD_PET"
                        Return True
                End Select

                ClsCustomer.NRICPassportNo = Trim(TxtNRICPassportNo.Text)
                DtCustomer = ClsCustomer.CheckExistingCustomer(ClsCustomer)

                If DtCustomer.Rows.Count > 0 Then

                    'Check if customer missed to register pet
                    If DgvPetListing.Rows.Count > 1 Then

                        For i As Integer = 0 To DgvPetListing.Rows.Count - 1

                            If DgvPetListing.Rows(i).Cells("PetID").Value = "" Then
                                AddPetOnly = True
                                Return True
                            End If

                        Next

                    End If

                    If DtCustomer.Rows(0).Item("NRICPassportNo") = NRICPassportNo Then
                        MsgBox("" & NRICPassportNo & " has already registered under name " & DtCustomer.Rows(0).Item("CustomerName") & ".",
                                   MsgBoxStyle.Information, "Add New Customer")
                        Return False
                    End If

                End If

            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckExistingCustomer()")
        End Try

        Return True

    End Function

    Private Function AddNewCustomer() As Boolean

        Dim ClsCustomer As ClsCustomer
        Dim CustomerID As String
        Dim CustomerInitial As String
        Dim DtCustomer As New DataTable

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            CustomerInitial = UCase(Trim(TxtCustomerName.Text)).Substring(0, 1)
            CustomerID = GenerateRunningNo("CT", DbConn, DbTrans, CustomerInitial)
            TxtCustomerID.Tag = CustomerID

            If CustomerID = "" Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                Return False
            End If

            ClsCustomer = New ClsCustomer
            With ClsCustomer
                .CustomerID = CustomerID
                .CustomerName = UCase(Trim(TxtCustomerName.Text))
                '.SaluteCode = DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                '.SaluteName = DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .NRICPassportNo = UCase(Trim(TxtNRICPassportNo.Text))
                '.TelNo = UCase(Trim(TxtTelNo.Text))
                '.MobileNo = UCase(Trim(TxtMobileNo.Text))
                .Email = Trim(TxtEmail.Text)
                .AddressLine1 = UCase(Trim(TxtAddress1.Text))
                .AddressLine2 = UCase(Trim(TxtAddress2.Text))
                .AddressLine3 = UCase(Trim(TxtAddress3.Text))
                .AddressLine4 = UCase(Trim(TxtAddress4.Text))
                '.Postcode = UCase(Trim(TxtPostcode.Text))
                '.City = UCase(Trim(TxtCity.Text))
                '.State = UCase(Trim(TxtState.Text))
                '.Country = UCase(Trim(TxtCountry.Text))
                .Ref.DateCreated = Now
                .Ref.CreatedBy = CURR_USER
                .Ref.DateModified = Now
                .Ref.ModifiedBy = CURR_USER
            End With

            If Not ClsCustomer.AddNewCustomer(ClsCustomer, DbConn, DbTrans) Then
                MsgBox("Failed to add new customer. Please try again.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewCustomer()")
                DbTrans.Rollback()
                Return False
            End If

            If Not AddNewPet() Then
                MsgBox("Failed to add new pet. Please try again.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewCustomer()")
            End If

            If DbTrans IsNot Nothing Then
                DbTrans.Commit()
                DbTrans.Dispose()
                DbTrans = Nothing
            End If

            'Change customer information tab page to readonly
            SetFields("ADD_NEW_CUSTOMER", CustomerID)
            MsgBox("New customer has been successfully saved!", MsgBoxStyle.Information, "New Customer Added!")
            'Set view to pet information
            'GoToPetInformation()

        Catch ex As Exception
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewCustomer()")
        End Try

        Return True

    End Function

    Private Function AddNewPet() As Boolean

        Dim ClsPet As ClsPet
        Dim PetID As String = ""

        Try
            If DbTrans Is Nothing Then
                DbTrans = DbConn.BeginTransaction
            End If

            'Take value from data grid view, loop data grid view
            If DgvPetListing.Rows.Count > 0 Then

                Dim PetIDLastNo As Integer = 0
                Dim Param As String = ""

                For i As Integer = 0 To DgvPetListing.Rows.Count - 1

                    If DgvPetListing.Rows(i).Cells("PetID").Value = "" Then

                        If PetIDLastNo = 0 Then
                            Param = ""
                        Else
                            Param = CStr(PetIDLastNo)
                        End If

                        PetID = GenerateRunningNo("PT", DbConn, DbTrans, Param)
                        TxtPetName.Tag = PetID

                        If PetID = "" Then
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                        ClsPet = New ClsPet
                        With ClsPet
                            .CustomerID = IIf(TxtCustomerID.Text <> "", UCase(TxtCustomerID.Text), UCase(TxtCustomerID.Tag))
                            .PetID = PetID
                            .PetName = DgvPetListing.Rows(i).Cells("PetName").Value
                            .PetDOB = DgvPetListing.Rows(i).Cells("PetDOB").Value
                            .AnimalTypeCode = DgvPetListing.Rows(i).Cells("AnimalTypeCode").Value
                            .AnimalTypeName = DgvPetListing.Rows(i).Cells("AnimalTypeName").Value
                            .BreedCode = DgvPetListing.Rows(i).Cells("BreedCode").Value
                            .BreedName = DgvPetListing.Rows(i).Cells("BreedName").Value
                            .SexCode = DgvPetListing.Rows(i).Cells("SexCode").Value
                            .SexName = DgvPetListing.Rows(i).Cells("SexName").Value
                            .NeuterCode = DgvPetListing.Rows(i).Cells("NeuterCode").Value
                            .NeuterName = DgvPetListing.Rows(i).Cells("NeuterName").Value
                            .Ref.DateCreated = Now
                            .Ref.CreatedBy = UCase(CURR_USER)
                            .Ref.DateModified = Now
                            .Ref.ModifiedBy = UCase(CURR_USER)
                        End With

                        If Not ClsPet.AddNewPet(ClsPet, DbConn, DbTrans) Then
                            MsgBox("Failed to add new pet. Please try again.", MsgBoxStyle.Critical, "FrmAddNewCustomer.AddNewPet()")
                            DbTrans.Rollback()
                            Return False
                        End If

                    Else
                        'Count pet that has PetID, then use number of count as PetID last used number.
                        PetIDLastNo += 1

                    End If

                Next

            End If

            If Not ResetPetIDRunningNo("PT", DbConn, DbTrans) Then Throw New Exception("Failed to update Pet ID number.")
            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            'Show keyed in pet information to data grid view
            ShowPetListing()

        Catch ex As Exception
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "FrmAddNewCustomer.AddNewPet()")
            Return False
        End Try

        Return True

    End Function

    Private Sub ShowPetListing()

        Dim DtPetListing As New DataTable
        Dim ClsPet As New ClsPet

        Try
            'ClsPet.CustomerID = IIf(TxtCustomerID.Tag = "", TxtCustomerID.Text, TxtCustomerID.Tag)
            'DtPetListing = ClsPet.GetPetListing(ClsPet)

            With DtPetListing

                If .Rows.Count > 0 Then

                    .Columns.Add("IsDB", GetType(String))

                    For i As Integer = 0 To DtPetListing.Rows.Count - 1
                        .Rows(i).Item("IsDB") = "1"
                    Next

                    DgvPetListing.DataSource = DtPetListing
                    DgvPetListing.Show()

                    TxtCreatedBy.Text = UCase(DtPetListing.Rows(0).Item("CreatedBy"))
                    TxtDateCreated.Text = UCase(DtPetListing.Rows(0).Item("DateCreated"))
                    TxtModifiedBy.Text = UCase(DtPetListing.Rows(0).Item("ModifiedBy"))
                    TxtDateModified.Text = UCase(DtPetListing.Rows(0).Item("DateModified"))

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ShowPetListing()")
        End Try

    End Sub

    Private Sub BtnAddPet_Click(sender As Object, e As EventArgs) Handles BtnAddPet.Click

        'Add pet information to data grid first, then store to database after user click 'Save'
        Try
            If BtnAddPet.Tag = "UPDATE_PET" Then
                UserCommand = "UPDATE_PET"
                If Not UpdatePetInDgv(UserCommand) Then
                    MsgBox("Failed to update pet information.", MsgBoxStyle.Exclamation, "Updating Pet Failed.")
                End If
                UserCommand = "EDIT_CUSTOMER_INFO"
                Exit Sub
            Else
                UserCommand = "ADD_PET"
            End If

            If Not CheckUserInput(UserCommand) Then Exit Sub 'PT = PET, Check user input from pet information
            If Not AddPetToDgv() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnAddPet_Click()")
        End Try

    End Sub

    Private Function UpdatePetInDgv(UserCommand As String) As Boolean

        Try
            Dim RowIndex As Integer = CInt(LblPetRowIndex.Text)
            With DgvPetListing
                .Rows(RowIndex).Cells("PetName").Value = UCase(Trim(TxtPetName.Text))
                .Rows(RowIndex).Cells("PetDOB").Value = DtpPetDOB.Value
                .Rows(RowIndex).Cells("AnimalTypeCode").Value = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .Rows(RowIndex).Cells("AnimalTypeName").Value = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .Rows(RowIndex).Cells("BreedCode").Value = DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .Rows(RowIndex).Cells("BreedName").Value = DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .Rows(RowIndex).Cells("SexCode").Value = DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .Rows(RowIndex).Cells("SexName").Value = DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .Rows(RowIndex).Cells("NeuterCode").Value = DirectCast(CmbNeuterStatus.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .Rows(RowIndex).Cells("NeuterName").Value = DirectCast(CmbNeuterStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            End With

            SetFields("EDITED_PET")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdatePetInDgv()")
            Return False
        End Try

        Return True

    End Function

    Private Function InitPetDatatable() As DataTable

        Dim DtPet As New DataTable

        Try
            'Initialize datatable
            With DtPet
                .Columns.Add("CustomerID", GetType(String))
                .Columns.Add("CustomerName", GetType(String))
                .Columns.Add("PetID", GetType(String))
                .Columns.Add("PetName", GetType(String))
                .Columns.Add("PetDOB", GetType(Date))
                .Columns.Add("AnimalTypeCode", GetType(String))
                .Columns.Add("AnimalTypeName", GetType(String))
                .Columns.Add("BreedCode", GetType(String))
                .Columns.Add("BreedName", GetType(String))
                .Columns.Add("SexCode", GetType(String))
                .Columns.Add("SexName", GetType(String))
                .Columns.Add("NeuterCode", GetType(String))
                .Columns.Add("NeuterName", GetType(String))
                .Columns.Add("IsDB", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitPetDatatable()")
        End Try

        Return DtPet

    End Function

    Private Function AddPetToDgv() As Boolean

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim DtPet As New DataTable

        Try
            DtPet = InitPetDatatable()

            If DgvPetListing.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvPetListing.Rows.Count - 1

                    Dim DgvRow As DataRow = DtPet.NewRow

                    'DgvRow("CustomerID") = DgvPetListing.Rows(i).Cells("CustomerID").Value
                    'DgvRow("CustomerName") = DgvPetListing.Rows(i).Cells("CustomerName").Value

                    DgvRow("PetID") = DgvPetListing.Rows(i).Cells("PetID").Value
                    DgvRow("PetName") = DgvPetListing.Rows(i).Cells("PetName").Value
                    DgvRow("PetDOB") = DgvPetListing.Rows(i).Cells("PetDOB").Value
                    DgvRow("AnimalTypeCode") = DgvPetListing.Rows(i).Cells("AnimalTypeCode").Value
                    DgvRow("AnimalTypeName") = DgvPetListing.Rows(i).Cells("AnimalTypeName").Value
                    DgvRow("BreedCode") = DgvPetListing.Rows(i).Cells("BreedCode").Value
                    DgvRow("BreedName") = DgvPetListing.Rows(i).Cells("BreedName").Value
                    DgvRow("SexCode") = DgvPetListing.Rows(i).Cells("SexCode").Value
                    DgvRow("SexName") = DgvPetListing.Rows(i).Cells("SexName").Value
                    DgvRow("NeuterCode") = DgvPetListing.Rows(i).Cells("NeuterCode").Value
                    DgvRow("NeuterName") = DgvPetListing.Rows(i).Cells("NeuterName").Value
                    DgvRow("IsDB") = DgvPetListing.Rows(i).Cells("IsDB").Value

                    DtPet.Rows.Add(DgvRow)

                Next

            End If

            'Take pet information from fields, e.g. textboxes
            Dim Row As DataRow = DtPet.NewRow

            'Row("CustomerID") = UCase(Trim(TxtCustomerID.Text))
            'Row("CustomerName") = UCase(Trim(TxtCustomerName.Text))
            Row("PetID") = UCase(Trim(TxtPetName.Tag))
            Row("PetName") = UCase(Trim(TxtPetName.Text))
            Row("PetDOB") = DtpPetDOB.Value
            Row("AnimalTypeCode") = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("AnimalTypeName") = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("BreedCode") = DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("BreedName") = DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("SexCode") = DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("SexName") = DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("NeuterCode") = DirectCast(CmbNeuterStatus.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("NeuterName") = DirectCast(CmbNeuterStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("IsDB") = "0"

            DtPet.Rows.Add(Row)

            If DtPet.Rows.Count > 0 Then

                If DgvPetListing.Rows.Count > 0 Then
                    DgvPetListing.Rows.Clear()
                End If

                For i As Integer = 0 To DtPet.Rows.Count - 1

                    With DgvPetListing
                        .Rows.Add()
                        .Rows(i).Cells("PetID").Value = DtPet.Rows(i).Item("PetID")
                        .Rows(i).Cells("PetName").Value = DtPet.Rows(i).Item("PetName")
                        .Rows(i).Cells("PetDOB").Value = CDate(DtPet.Rows(i).Item("PetDOB")).ToShortDateString
                        .Rows(i).Cells("AnimalTypeCode").Value = DtPet.Rows(i).Item("AnimalTypeCode")
                        .Rows(i).Cells("AnimalTypeName").Value = DtPet.Rows(i).Item("AnimalTypeName")
                        .Rows(i).Cells("BreedCode").Value = DtPet.Rows(i).Item("BreedCode")
                        .Rows(i).Cells("BreedName").Value = DtPet.Rows(i).Item("BreedName")
                        .Rows(i).Cells("SexCode").Value = DtPet.Rows(i).Item("SexCode")
                        .Rows(i).Cells("SexName").Value = DtPet.Rows(i).Item("SexName")
                        .Rows(i).Cells("NeuterCode").Value = DtPet.Rows(i).Item("NeuterCode")
                        .Rows(i).Cells("NeuterName").Value = DtPet.Rows(i).Item("NeuterName")
                    End With

                Next

            End If

            MsgBox("Your pet has been successfully added!", MsgBoxStyle.Information, "New Pet Added")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddPetToDGV()")
        End Try

        Return True

    End Function

    Private Sub BtnClearPet_Click(sender As Object, e As EventArgs) Handles BtnClearPet.Click
        SetFields("CLEAR_PET_FIELDS")
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckUserInput(UserCommand) Then Exit Sub
        If Not SaveCustomerToDb(UserCommand) Then Exit Sub
        'If Not SaveCustomerToDb(UserCommand) Then Exit Sub
    End Sub

    Private Function SaveCustomerToDb(UserCommand As String) As Boolean

        Try
            Dim ClsCustomer As ClsCustomer
            Dim ClsPet As ClsPet
            Dim CustomerID As String
            Dim PetID As String
            Dim CustomerInitial As String
            Dim DtCustomer As New DataTable

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If TxtCustomerID.Text <> "" Then
                CustomerID = TxtCustomerID.Text
            Else
                CustomerInitial = UCase(Trim(TxtCustomerName.Text)).Substring(0, 1)
                CustomerID = GenerateRunningNo("CT", DbConn, DbTrans, CustomerInitial)
            End If

            If CustomerID = "" Then
                MsgBox("Failed to generate customer ID.", MsgBoxStyle.Critical, "Customer ID Generation Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                Return False
            End If

            ClsCustomer = New ClsCustomer
            With ClsCustomer
                .CustomerID = CustomerID
                .CustomerName = UCase(Trim(TxtCustomerName.Text))
                '.SaluteCode = DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                '.SaluteName = DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .NRICPassportNo = UCase(Trim(TxtNRICPassportNo.Text))
                '.TelNo = UCase(Trim(TxtTelNo.Text))
                '.MobileNo = UCase(Trim(TxtMobileNo.Text))
                .Email = Trim(TxtEmail.Text)
                .AddressLine1 = UCase(Trim(TxtAddress1.Text))
                .AddressLine2 = UCase(Trim(TxtAddress2.Text))
                .AddressLine3 = UCase(Trim(TxtAddress3.Text))
                .AddressLine4 = UCase(Trim(TxtAddress4.Text))
                '.Postcode = UCase(Trim(TxtPostcode.Text))
                '.City = UCase(Trim(TxtCity.Text))
                '.State = UCase(Trim(TxtState.Text))
                '.Country = UCase(Trim(TxtCountry.Text))
                .Ref.DateCreated = Now
                .Ref.CreatedBy = CURR_USER
                .Ref.DateModified = Now
                .Ref.ModifiedBy = CURR_USER

                If Not .AddNewCustomer(ClsCustomer, DbConn, DbTrans) Then
                    MsgBox("Failed to add new customer. Please try again.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewCustomer()")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            'Add pet
            Dim PetIDLastNo As Integer = 0
            Dim Param As String = ""

            If DgvPetListing.Rows.Count > 0 Then

                For i As Integer = 0 To DgvPetListing.Rows.Count - 1

                    If DgvPetListing.Rows(i).Cells("PetID").Value <> "" Then
                        PetID = DgvPetListing.Rows(i).Cells("PetID").Value
                        PetIDLastNo += 1
                    Else
                        If PetIDLastNo = 0 Then
                            Param = ""
                        Else
                            Param = CStr(PetIDLastNo)
                        End If

                        PetID = GenerateRunningNo("PT", DbConn, DbTrans, Param)
                        If PetID = "" Then
                            MsgBox("Failed to generate Pet ID.", MsgBoxStyle.Critical, "Pet ID Generation Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End If

                    ClsPet = New ClsPet
                    With ClsPet
                        .CustomerID = IIf(TxtCustomerID.Text <> "", UCase(TxtCustomerID.Text), CustomerID)
                        .PetID = PetID
                        .PetName = DgvPetListing.Rows(i).Cells("PetName").Value
                        .PetDOB = DgvPetListing.Rows(i).Cells("PetDOB").Value
                        .AnimalTypeCode = DgvPetListing.Rows(i).Cells("AnimalTypeCode").Value
                        .AnimalTypeName = DgvPetListing.Rows(i).Cells("AnimalTypeName").Value
                        .BreedCode = DgvPetListing.Rows(i).Cells("BreedCode").Value
                        .BreedName = DgvPetListing.Rows(i).Cells("BreedName").Value
                        .SexCode = DgvPetListing.Rows(i).Cells("SexCode").Value
                        .SexName = DgvPetListing.Rows(i).Cells("SexName").Value
                        .NeuterCode = DgvPetListing.Rows(i).Cells("NeuterCode").Value
                        .NeuterName = DgvPetListing.Rows(i).Cells("NeuterName").Value
                        .Ref.DateCreated = Now
                        .Ref.CreatedBy = UCase(CURR_USER)
                        .Ref.DateModified = Now
                        .Ref.ModifiedBy = UCase(CURR_USER)

                        If Not .AddNewPet(ClsPet, DbConn, DbTrans) Then
                            MsgBox("Failed to add new pet. Please try again.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewCustomer()")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

                If Not ResetPetIDRunningNo("PT", DbConn, DbTrans) Then Throw New Exception("Failed to update Pet ID sequence.")

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            SetFields("ADD_NEW_CUSTOMER", CustomerID)

            'Update indicator in the data grid to identify pets that already registered in he database
            For i As Integer = 0 To DgvPetListing.Rows.Count - 1
                DgvPetListing.Rows(i).Cells("IsDb").Value = "1"
            Next

            TxtCustomerID.Text = CustomerID
            TxtCustomerID.Tag = CustomerID

            With ClsCustomer
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            MsgBox("Customer information has been successfully saved!", MsgBoxStyle.Information, "Customer Information Saved")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveCustomerToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub CmbAnimalType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbAnimalType.SelectionChangeCommitted

        Dim DtBreed As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            ClsPet.AnimalTypeCode = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString

            DtBreed = ClsPet.GetPetBreed(ClsPet)
            If DtBreed.Rows.Count > 0 Then

                For i As Integer = 0 To DtBreed.Rows.Count - 1
                    CmbSource.Add(DtBreed.Rows(i).Item("BreedCode"), DtBreed.Rows(i).Item("BreedName"))
                Next

                If CmbBreed.Items.Count > 0 Then
                    CmbBreed.DataSource = Nothing
                    CmbBreed.Items.Clear()
                End If

                CmbBreed.DataSource = New BindingSource(CmbSource, Nothing)
                CmbBreed.DisplayMember = "Value"
                CmbBreed.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CmbAnimalType_SelectedIndexChanged()")
        End Try

    End Sub

    Private Sub DgvPetListing_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles DgvPetListing.CellContentClick

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Edit' button
                If e.ColumnIndex = 0 Then

                    'TxtPetID.Tag = e.RowIndex
                    'TxtPetID.Text = DgvPetListing.Rows(e.RowIndex).Cells("PetID").Value
                    LblPetRowIndex.Text = e.RowIndex
                    TxtPetName.Text = DgvPetListing.Rows(e.RowIndex).Cells("PetName").Value
                    DtpPetDOB.Value = DgvPetListing.Rows(e.RowIndex).Cells("PetDOB").Value
                    CmbAnimalType.SelectedValue = DgvPetListing.Rows(e.RowIndex).Cells("AnimalTypeCode").Value
                    CmbBreed.SelectedValue = DgvPetListing.Rows(e.RowIndex).Cells("BreedCode").Value
                    CmbSex.SelectedValue = DgvPetListing.Rows(e.RowIndex).Cells("SexCode").Value
                    CmbNeuterStatus.SelectedValue = DgvPetListing.Rows(e.RowIndex).Cells("NeuterCode").Value

                    SetFields("EDIT_PET")

                ElseIf e.ColumnIndex = 1 Then

                    UserResponse = MsgBox("Are sure you want to delete this pet?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Pet?")
                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvPetListing

                            For Each Row As DataGridViewRow In .SelectedRows

                                If Row.Cells("IsDB").Value = "0" Then
                                    .Rows.Remove(Row)
                                Else
                                    MsgBox("You cannot delete pet that has been registered into the database.", MsgBoxStyle.Critical, "Unable to delete pet.")
                                    Exit For
                                End If

                            Next

                            If .Rows.Count = 0 Then
                                .DataSource = Nothing
                                .Columns.Clear()
                                .Show()
                            End If

                        End With

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvPetListing()")
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Try
            SetFields("CANCELEDIT_CUSTOMER_INFO")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnCancel_Click()")
        End Try

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        UserCommand = "EDIT_CUSTOMER_INFO"
        SetFields(UserCommand)
    End Sub

    Private Sub BtnCancelEdit_Click(sender As Object, e As EventArgs) Handles BtnCancelEdit.Click

        Try
            SetFields("CANCEL_EDIT_PET")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnCancelEdit_Click()")
        End Try

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'Dim Frm As New FrmCustomerReport
        'With Frm
        '    .CustomerID = Trim(TxtCustomerID.Text)
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateForm("SHOW_CUSTOMER_INFO")
    End Sub


End Class