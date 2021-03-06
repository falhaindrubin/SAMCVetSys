﻿Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class FrmVisitInformation

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

    Private _ItemCode As String
    Public Property ItemCode As String
        Get
            Return _ItemCode
        End Get
        Set(value As String)
            _ItemCode = value
        End Set
    End Property

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _InvoiceNo As String
    Public Property InvoiceNo As String
        Get
            Return _InvoiceNo
        End Get
        Set(value As String)
            _InvoiceNo = value
        End Set
    End Property

    Private _ItemGroup As String
    Public Property ItemGroup As String
        Get
            Return _ItemGroup
        End Get
        Set(value As String)
            _ItemGroup = value
        End Set
    End Property

    Private _ItemTypeCode As String
    Public Property ItemTypeCode As String
        Get
            Return _ItemTypeCode
        End Get
        Set(value As String)
            _ItemTypeCode = value
        End Set
    End Property

    Private _ItemTypeDescription As String
    Public Property ItemTypeDescription As String
        Get
            Return _ItemTypeDescription
        End Get
        Set(value As String)
            _ItemTypeDescription = value
        End Set
    End Property

    Private _FormTitle As String
    Public Property FormTitle As String
        Get
            Return _FormTitle
        End Get
        Set(value As String)
            _FormTitle = value
        End Set
    End Property

#End Region

    Private Sub FrmConsultationEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FORM_NAME = Me.Name
        Me.Text = IIf(FormTitle <> "", FormTitle, Me.Text)
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateTemperament()
        PopulateBodyScore()
        PopulateForm(UserCommand)

    End Sub

    Private Sub PopulateTemperament()

        Dim DtTemperament As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtTemperament = ClsPet.GetPetTemperament(ClsPet)
            If DtTemperament.Rows.Count > 0 Then

                For i As Integer = 0 To DtTemperament.Rows.Count - 1
                    CmbSource.Add(DtTemperament.Rows(i).Item("TemperamentCode"), DtTemperament.Rows(i).Item("TemperamentCode") & " - " & DtTemperament.Rows(i).Item("TemperamentName"))
                Next

                If CmbTemperament.Items.Count > 0 Then
                    CmbTemperament.DataSource = Nothing
                    CmbTemperament.Items.Clear()
                End If

                CmbTemperament.DataSource = New BindingSource(CmbSource, Nothing)
                CmbTemperament.DisplayMember = "Value"
                CmbTemperament.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateTemperament()")
        End Try

    End Sub

    Private Sub PopulateBodyScore()

        Dim DtBodyScore As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtBodyScore = ClsPet.GetPetBodyScore(ClsPet)
            If DtBodyScore.Rows.Count > 0 Then

                For i As Integer = 0 To DtBodyScore.Rows.Count - 1
                    CmbSource.Add(DtBodyScore.Rows(i).Item("BodyScoreCode"), DtBodyScore.Rows(i).Item("BodyScoreCode") & " - " & DtBodyScore.Rows(i).Item("BodyScoreName"))
                Next

                If CmbBodyScore.Items.Count > 0 Then
                    CmbBodyScore.DataSource = Nothing
                    CmbBodyScore.Items.Clear()
                End If

                CmbBodyScore.DataSource = New BindingSource(CmbSource, Nothing)
                CmbBodyScore.DisplayMember = "Value"
                CmbBodyScore.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateBodyScore()")
        End Try

    End Sub

    Private Sub PopulateForm(Optional UserCommand As String = Nothing)

        Dim BtnDelete As New DataGridViewButtonColumn
        Dim BtnSelect As New DataGridViewButtonColumn
        Dim DtCustomer As New DataTable
        Dim DtPet As New DataTable
        Dim DtVisit As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim ClsPet As New ClsPet
        Dim ClsVisit As New ClsVisit
        Dim StrOp As String = "WHERE"
        Dim ClsBill As New ClsBill
        Dim DtBill As New DataTable

        Try
            TxtVet.Tag = CURR_EMPLOYEE_ID
            TxtVet.Text = CURR_EMPLOYEE_NAME

            'Populate customer information
            If CustomerID <> "" Then

                With ClsCustomer
                    .CustomerID = CustomerID
                    DtCustomer = .GetCustomerInformation(ClsCustomer)
                    If DtCustomer.Rows.Count > 0 Then

                        'Set fields using Customer information retrieved from database
                        TxtCustomerID.Text = DtCustomer.Rows(0).Item("CustomerID")
                        TxtSalutation.Tag = DtCustomer.Rows(0).Item("SaluteCode")
                        TxtSalutation.Text = DtCustomer.Rows(0).Item("SaluteName")
                        TxtCustomerName.Text = DtCustomer.Rows(0).Item("CustomerName")
                        TxtNRICPassportNo.Text = DtCustomer.Rows(0).Item("NRICPassportNo")
                        TxtAddress1.Text = DtCustomer.Rows(0).Item("AddressLine1")
                        TxtAddress2.Text = DtCustomer.Rows(0).Item("AddressLine2")
                        TxtAddress3.Text = DtCustomer.Rows(0).Item("AddressLine3")
                        TxtAddress4.Text = DtCustomer.Rows(0).Item("AddressLine4")
                        TxtTelNo.Text = DtCustomer.Rows(0).Item("TelNo")
                        TxtMobileNo.Text = DtCustomer.Rows(0).Item("MobileNo")
                        TxtEmail.Text = DtCustomer.Rows(0).Item("Email")
                        TxtPostcode.Text = DtCustomer.Rows(0).Item("Postcode")
                        TxtCity.Text = DtCustomer.Rows(0).Item("City")
                        TxtState.Text = DtCustomer.Rows(0).Item("State")
                        TxtCountry.Text = DtCustomer.Rows(0).Item("Country")

                    End If
                End With

                'Populate pet list, information and details
                With ClsPet
                    .CustomerID = CustomerID
                    DtPet = .GetPetListing(ClsPet)
                    If DtPet.Rows.Count > 0 Then

                        With DgvPetListing

                            If .Rows.Count > 0 Then
                                .Rows.Clear()
                            End If

                            For i As Integer = 0 To DtPet.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells("PetID").Value = DtPet.Rows(i).Item("PetID")
                                .Rows(i).Cells("PetName").Value = DtPet.Rows(i).Item("PetName")
                                .Rows(i).Cells("PetDOB").Value = DtPet.Rows(i).Item("PetDOB")
                                .Rows(i).Cells("AnimalTypeCode").Value = DtPet.Rows(i).Item("AnimalTypeCode")
                                .Rows(i).Cells("AnimalTypeName").Value = DtPet.Rows(i).Item("AnimalTypeName")
                                .Rows(i).Cells("BreedCode").Value = DtPet.Rows(i).Item("BreedCode")
                                .Rows(i).Cells("BreedName").Value = DtPet.Rows(i).Item("BreedName")
                                .Rows(i).Cells("SexCode").Value = DtPet.Rows(i).Item("SexCode")
                                .Rows(i).Cells("SexName").Value = DtPet.Rows(i).Item("SexName")
                                .Rows(i).Cells("NeuterCode").Value = DtPet.Rows(i).Item("NeuterCode")
                                .Rows(i).Cells("NeuterName").Value = DtPet.Rows(i).Item("NeuterName")
                            Next

                        End With

                    End If
                End With

            End If

            'If VisitID is not empty then populate visit information and details
            If VisitID <> "" Then

                ClsVisit = New ClsVisit
                With ClsVisit
                    .VisitID = VisitID
                    DtVisit = .GetVisitDetail(ClsVisit)

                    If DtVisit.Rows.Count > 0 Then

                        Dim DtSelectedPet As New DataTable

                        TxtVisitID.Text = DtVisit.Rows(0).Item("VisitID")
                        DtpConsultationDate.Value = CDate(DtVisit.Rows(0).Item("VisitTime"))
                        DtpConsultationTime.Value = CDate(DtVisit.Rows(0).Item("VisitTime"))
                        TxtVet.Tag = CStr(DtVisit.Rows(0).Item("EmployeeID"))
                        TxtVet.Text = CStr(DtVisit.Rows(0).Item("EmployeeName"))
                        TxtVisitDescription.Text = CStrNull(DtVisit.Rows(0).Item("VisitDescription"))

                        DtSelectedPet = InitPetDatatable()
                        For i As Integer = 0 To DtVisit.Rows.Count - 1

                            Dim DgvRow As DataRow = DtSelectedPet.NewRow

                            DgvRow("PetID") = DtVisit.Rows(i).Item("PetID")
                            DgvRow("PetName") = DtVisit.Rows(i).Item("PetName")
                            DgvRow("PetDOB") = CDate(DtVisit.Rows(i).Item("PetDOB")).Date
                            DgvRow("AnimalTypeCode") = DtVisit.Rows(i).Item("AnimalTypeCode")
                            DgvRow("AnimalTypeName") = DtVisit.Rows(i).Item("AnimalTypeName")
                            DgvRow("BreedCode") = DtVisit.Rows(i).Item("BreedCode")
                            DgvRow("BreedName") = DtVisit.Rows(i).Item("BreedName")
                            DgvRow("SexCode") = DtVisit.Rows(i).Item("SexCode")
                            DgvRow("SexName") = DtVisit.Rows(i).Item("SexName")
                            DgvRow("NeuterCode") = DtVisit.Rows(i).Item("NeuterCode")
                            DgvRow("NeuterName") = DtVisit.Rows(i).Item("NeuterName")
                            DgvRow("VisitDescription") = DtVisit.Rows(i).Item("VisitDescription")
                            DgvRow("IsDB") = "1"

                            DtSelectedPet.Rows.Add(DgvRow)

                        Next

                        TxtTemperature.Text = CStrNull(DtVisit.Rows(0).Item("Temperature"))
                        CmbTemperament.SelectedValue = CStrNull(DtVisit.Rows(0).Item("TemperamentCode"))
                        CmbBodyScore.SelectedValue = CStrNull(DtVisit.Rows(0).Item("BodyScoreCode"))
                        TxtBodyWeight.Text = CStrNull(DtVisit.Rows(0).Item("BodyWeight"))
                        TxtPEFindings.Text = CStrNull(DtVisit.Rows(0).Item("PEFindings"))

                        If DtSelectedPet.Rows.Count > 0 Then

                            With DgvSelectedPet

                                If .Rows.Count > 0 Then
                                    .Rows.Clear()
                                End If

                                For i As Integer = 0 To DtSelectedPet.Rows.Count - 1

                                    .Rows.Add()
                                    .Rows(i).Cells("SelectedPetID").Value = DtSelectedPet.Rows(i).Item("PetID")
                                    .Rows(i).Cells("SelectedPetName").Value = DtSelectedPet.Rows(i).Item("PetName")
                                    .Rows(i).Cells("SelectedPetDOB").Value = CDate(DtSelectedPet.Rows(i).Item("PetDOB")).Date.ToShortDateString
                                    .Rows(i).Cells("SelectedAnimalTypeCode").Value = DtSelectedPet.Rows(i).Item("AnimalTypeCode")
                                    .Rows(i).Cells("SelectedAnimalTypeName").Value = DtSelectedPet.Rows(i).Item("AnimalTypeName")
                                    .Rows(i).Cells("SelectedBreedCode").Value = DtSelectedPet.Rows(i).Item("BreedCode")
                                    .Rows(i).Cells("SelectedBreedName").Value = DtSelectedPet.Rows(i).Item("BreedName")
                                    .Rows(i).Cells("SelectedSexCode").Value = DtSelectedPet.Rows(i).Item("SexCode")
                                    .Rows(i).Cells("SelectedSexName").Value = DtSelectedPet.Rows(i).Item("SexName")
                                    .Rows(i).Cells("SelectedNeuterCode").Value = DtSelectedPet.Rows(i).Item("NeuterCode")
                                    .Rows(i).Cells("SelectedNeuterName").Value = DtSelectedPet.Rows(i).Item("NeuterName")
                                    .Rows(i).Cells("IsDb").Value = DtSelectedPet.Rows(i).Item("IsDb")

                                Next

                            End With

                        End If

                        'Populate Consultation/Medication charges
                        Dim ClsVisitCharges As New ClsVisitCharges
                        Dim DtVisitCharges As New DataTable
                        With ClsVisitCharges
                            .VisitID = VisitID

                            DtVisitCharges = .GetVisitCharges(ClsVisitCharges)
                            If DtVisitCharges.Rows.Count > 0 Then
                                For i As Integer = 0 To DtVisitCharges.Rows.Count - 1S
                                    With DgvSelectedItem
                                        .Rows.Add()
                                        .Rows(i).Cells("ChargesRowNo").Value = DtVisitCharges.Rows(i).Item("RowNo")
                                        .Rows(i).Cells("ChargesItemCode").Value = DtVisitCharges.Rows(i).Item("ItemCode")
                                        .Rows(i).Cells("ChargesItemDescription").Value = DtVisitCharges.Rows(i).Item("ItemDescription")
                                        .Rows(i).Cells("ChargesPrescription").Value = DtVisitCharges.Rows(i).Item("Prescription")
                                        .Rows(i).Cells("ChargesNotes").Value = DtVisitCharges.Rows(i).Item("Notes")
                                        .Rows(i).Cells("ChargesUnitPrice").Value = DtVisitCharges.Rows(i).Item("UnitPrice")
                                        .Rows(i).Cells("ChargesQuantity").Value = DtVisitCharges.Rows(i).Item("Quantity")
                                        .Rows(i).Cells("ChargesTotalPrice").Value = DtVisitCharges.Rows(i).Item("TotalPrice")
                                        .Rows(i).Cells("ChargesItemGroup").Value = DtVisitCharges.Rows(i).Item("ItemGroup")
                                        .Rows(i).Cells("ChargesItemTypeCode").Value = DtVisitCharges.Rows(i).Item("ItemTypeCode")
                                        .Rows(i).Cells("ChargesItemTypeDescription").Value = DtVisitCharges.Rows(i).Item("ItemTypeDescription")
                                        .Rows(i).Cells("IsChargeDb").Value = "1"
                                    End With
                                Next

                            End If

                        End With

                        'Check if invoice created


                        TxtCreatedBy.Text = DtVisit.Rows(0).Item("CreatedBy")
                        TxtDateCreated.Text = DtVisit.Rows(0).Item("DateCreated")
                        TxtModifiedBy.Text = DtVisit.Rows(0).Item("ModifiedBy")
                        TxtDateModified.Text = DtVisit.Rows(0).Item("DateModified")

                        If DtVisit.Rows(0).Item("IsCompleted") = "1" Then
                            CbIsVisitCompleted.Checked = True
                            CbIsVisitCompleted.Enabled = False
                        End If

                    End If

                End With

            End If

            SetFields(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Function InitPetDatatable() As DataTable

        Dim DtPet As New DataTable

        Try
            'Initialize datatable
            With DtPet
                '.Columns.Add("CustomerID", GetType(String))
                '.Columns.Add("CustomerName", GetType(String))
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
                .Columns.Add("VisitDescription", GetType(String))
                .Columns.Add("IsDB", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitPetDatatable()")
        End Try

        Return DtPet

    End Function

    Private Function FilterSQL(ByVal StrOP As String, Optional Param1 As String = "", Optional Param2 As String = "") As String

        Dim SQLCondition As String = ""
        Dim Sb As New StringBuilder

        Try
            Sb = New StringBuilder
            With Sb
                If Param2 <> "" And Param2 = "POPULATE_CUSTOMER_INFO" Then
                    If Trim(Param1) <> "" Then
                        .Append("" & GetOP(StrOP) & " CustomerID LIKE '%" & Param1 & "%' ")
                    End If
                End If

                If Param2 <> "" And Param2 = "SHOW_CUSTOMER_APPOINTMENT" Then
                    If Trim(Param1) <> "" Then
                        .Append("" & GetOP(StrOP) & " CustomerID = '" & Param1 & "' ")
                    End If
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".FilterSQLCondition()")
        End Try

        SQLCondition = Sb.ToString
        Return SQLCondition

    End Function

    Private Sub SetFields(Optional ClearCommand As String = "", Optional Param1 As String = "")

        Try
            Select Case ClearCommand

                Case "SET_PET_FIELDS"

                    'TxtPetID.Text = ""
                    'TxtPetName.Text = ""
                    'CmbAnimalType.SelectedIndex = 0
                    'CmbBreed.SelectedIndex = 0
                    'CmbStatus.SelectedIndex = 0
                    'CmbSex.SelectedIndex = 0

                Case "ADD_NEW_CUSTOMER", "ADD_NEW_APPOINTMENT"

                    'Customer information
                    'CmbSalutation.Enabled = False
                    TxtSalutation.ReadOnly = True
                    TxtCustomerName.ReadOnly = True
                    TxtNRICPassportNo.ReadOnly = True
                    TxtAddress1.ReadOnly = True
                    TxtAddress2.ReadOnly = True
                    TxtAddress3.ReadOnly = True
                    TxtAddress4.ReadOnly = True
                    TxtTelNo.ReadOnly = True
                    TxtMobileNo.ReadOnly = True
                    TxtEmail.ReadOnly = True
                    TxtCustomerID.Text = UCase(TxtCustomerID.Tag)
                    TxtCustomerName.Text = UCase(TxtCustomerName.Text)
                    TxtNRICPassportNo.Text = UCase(TxtNRICPassportNo.Text)
                    TxtAddress1.Text = UCase(TxtAddress1.Text)
                    TxtAddress2.Text = UCase(TxtAddress2.Text)
                    TxtAddress3.Text = UCase(TxtAddress3.Text)
                    TxtAddress4.Text = UCase(TxtAddress4.Text)
                    TxtPostcode.Text = UCase(TxtPostcode.Text)
                    TxtCity.Text = UCase(TxtCity.Text)
                    TxtState.Text = UCase(TxtState.Text)
                    TxtCountry.Text = UCase(TxtCountry.Text)

                    'Pet information from customer information
                    'TxtCustomerIDPI.Text = UCase(TxtCustomerID.Tag)
                    'TxtCustomerNamePI.Text = UCase(TxtCustomerName.Text)
                    'TxtPetID.Text = UCase(TxtPetID.Tag)
                    'TxtPetName.Text = UCase(TxtPetName.Text)

                Case "CLEAR_PET_FIELDS"
                    'TxtPetID.Text = ""
                    'TxtPetName.Text = ""
                    'CmbAnimalType.SelectedIndex = 0
                    'CmbBreed.SelectedIndex = 0
                    'CmbSex.SelectedIndex = 0
                    'CmbStatus.SelectedIndex = 0

                Case "SHOW_CUSTOMER_INFO", "CANCELEDIT_CUSTOMER_INFO", "POPULATE_CUSTOMER_INFO", "SHOW_CUSTOMER_CONSULTATION"

                    'BtnSave.Enabled = False
                    'CmbSalutation.Enabled = False
                    TxtSalutation.ReadOnly = True
                    TxtCustomerName.ReadOnly = True
                    TxtNRICPassportNo.ReadOnly = True
                    TxtTelNo.ReadOnly = True
                    TxtMobileNo.ReadOnly = True
                    TxtEmail.ReadOnly = True
                    TxtAddress1.ReadOnly = True
                    TxtAddress2.ReadOnly = True
                    TxtAddress3.ReadOnly = True
                    TxtAddress4.ReadOnly = True
                    TxtPostcode.ReadOnly = True
                    TxtCity.ReadOnly = True
                    TxtState.ReadOnly = True
                    TxtCountry.ReadOnly = True

                    'TxtPetName.ReadOnly = True
                    'DtpPetDOB.Enabled = False
                    'CmbAnimalType.Enabled = False
                    'CmbBreed.Enabled = False
                    'CmbSex.Enabled = False
                    'CmbStatus.Enabled = False
                    'BtnAddPet.Enabled = False
                    'BtnClearPet.Enabled = False
                    'DgvPetListing.Enabled = False

                Case "EDIT_CUSTOMER_INFO"

                    BtnSave.Enabled = True

                    'CmbSalutation.Enabled = True
                    TxtCustomerName.ReadOnly = False
                    TxtNRICPassportNo.ReadOnly = False
                    TxtTelNo.ReadOnly = False
                    TxtMobileNo.ReadOnly = False
                    TxtEmail.ReadOnly = False
                    TxtAddress1.ReadOnly = False
                    TxtAddress2.ReadOnly = False
                    TxtAddress3.ReadOnly = False
                    TxtAddress4.ReadOnly = False
                    TxtPostcode.ReadOnly = False
                    TxtCity.ReadOnly = False
                    TxtState.ReadOnly = False
                    TxtCountry.ReadOnly = False

                    'TxtPetID.Text = ""
                    'TxtPetName.Text = ""
                    'TxtPetName.ReadOnly = False
                    'DtpPetDOB.Enabled = True
                    'CmbAnimalType.Enabled = True
                    'CmbBreed.Enabled = True
                    'CmbSex.Enabled = True
                    'CmbStatus.Enabled = True
                    'BtnAddPet.Enabled = True
                    'BtnClearPet.Enabled = True
                    DgvPetListing.Enabled = True

                Case "EDIT_PET"
                    'BtnAddPet.Text = "Update Pet"
                    'BtnAddPet.Tag = "UPDATE_PET"
                    'BtnCancelEdit.Visible = True

                Case "CANCEL_EDIT_PET", "EDITED_PET"
                    'BtnAddPet.Text = "Add Pet"
                    'BtnAddPet.Tag = ""
                    'BtnCancelEdit.Visible = False
                    'TxtPetID.Text = ""
                    'TxtPetName.Text = ""
                    'DtpPetDOB.Value = Now
                    'CmbAnimalType.SelectedIndex = 0
                    'CmbBreed.SelectedIndex = 0
                    'CmbSex.SelectedIndex = 0
                    'CmbStatus.SelectedIndex = 0

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SetFields()")
        End Try

    End Sub

    Private Function GetOP(ByRef strOP As String) As String

        If strOP = "WHERE" Then
            strOP = "AND"
            GetOP = "WHERE"
        Else
            GetOP = strOP
        End If

    End Function

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            With FrmSearchCustomer
                .Source = "CONSULTATION"
                .ShowDialog()
                CustomerID = .CustomerID
                UserCommand = .UserCommand
            End With

            PopulateForm(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnSearch_Click")
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    'Private Sub CmbAnimalType_SelectionChangeCommitted(sender As Object, e As EventArgs)

    '    Dim DtBreed As New DataTable
    '    Dim ClsPet As New ClsPet
    '    Dim CmbSource As New Dictionary(Of String, String)

    '    Try
    '        ClsPet.AnimalTypeCode = DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString

    '        DtBreed = ClsPet.GetPetBreed(ClsPet)
    '        If DtBreed.Rows.Count > 0 Then

    '            For i As Integer = 0 To DtBreed.Rows.Count - 1
    '                CmbSource.Add(DtBreed.Rows(i).Item("BreedCode"), DtBreed.Rows(i).Item("BreedName"))
    '            Next

    '            If CmbBreed.Items.Count > 0 Then
    '                CmbBreed.DataSource = Nothing
    '                CmbBreed.Items.Clear()
    '            End If

    '            CmbBreed.DataSource = New BindingSource(CmbSource, Nothing)
    '            CmbBreed.DisplayMember = "Value"
    '            CmbBreed.ValueMember = "Key"

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CmbAnimalType_SelectedIndexChanged()")
    '    End Try

    'End Sub

    'DgvPetListing_CellContentClick()
    Private Sub DgvPetListing_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles DgvPetListing.CellContentClick

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to select this pet for appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Select Pet?")
                    If UserResponse = MsgBoxResult.Yes Then
                        If Not AddPetToDgv(DgvPetListing.Rows(e.RowIndex).Cells("PetID").Value, e.RowIndex) Then
                            'MsgBox("Failed to select pet for appointment.", MsgBoxStyle.Critical, "Select Pet Failed")
                            Exit Sub
                        End If
                    Else
                        Exit Sub
                    End If

                    'SetFields("EDIT_PET")
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvPetListing_CellContentClick()")
        End Try

    End Sub

    'DgvSelectedPet_CellContentClick()
    Private Sub DgvSelectedPet_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles DgvSelectedPet.CellContentClick

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Delete' button
                If e.ColumnIndex = 0 Then

                    If Not IsDBNull(DgvSelectedPet.Rows(e.RowIndex).Cells("IsDB").Value) Then

                        If DgvSelectedPet.Rows(e.RowIndex).Cells("IsDB").Value = "1" Then
                            UserResponse = MsgBox("Are sure you want to remove this pet from your appointment? (Note: Removing selected pet from appointment will be removed permanently from the database.)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Remove Pet?")
                            If UserResponse = MsgBoxResult.Yes Then
                                With DgvSelectedPet

                                    'Check if user wants to remove all pets from his/her appointment; if so disable user from deleting last pet remaining
                                    If DgvSelectedPet.Rows.Count = 1 Then
                                        MsgBox("You must select at least one pet for appointment.", MsgBoxStyle.Exclamation, "Unable to Remove Pet")
                                        Exit Sub
                                    End If

                                    For Each Row As DataGridViewRow In .SelectedRows
                                        If Not DeletePetFromAppointment(TxtVisitID.Text, DgvSelectedPet.Rows(e.RowIndex).Cells("PetID").Value) Then
                                            MsgBox("Failed to remove pet from appointment.", MsgBoxStyle.Critical, "Failed to Remove Pet")
                                            Exit For
                                        End If
                                        .Rows.Remove(Row)
                                    Next

                                    If .Rows.Count = 0 Then
                                        .DataSource = Nothing
                                        .Columns.Clear()
                                        .Show()
                                    End If

                                End With

                                MsgBox("Your pet has been removed from the appointment.", MsgBoxStyle.Information, "Pet Removed")

                            End If

                        End If

                    Else

                        UserResponse = MsgBox("Are sure you want to remove this pet from your appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Remove Pet?")
                        If UserResponse = MsgBoxResult.Yes Then

                            With DgvSelectedPet

                                For Each Row As DataGridViewRow In .SelectedRows
                                    .Rows.Remove(Row)
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

            Else

                'LblPetName.Tag = DgvSelectedPet.Rows(e.RowIndex).Cells("PetID").Value
                'LblPetName.Text = DgvSelectedPet.Rows(e.RowIndex).Cells("PetName").Value
                'TxtVisitDescription.Text = DgvSelectedPet.Rows(e.RowIndex).Cells("VisitDescription").Value

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSelectedPet_CellContentClick()")
        End Try

    End Sub

    Private Function DeletePetFromAppointment(RemAppointmentID As String, RemPetID As String) As Boolean

        Dim ClsAppointment As New ClsAppointment
        Dim ClsAppointmentDetail As New ClsAppointmentDetail

        Try
            With ClsAppointmentDetail
                .AppointmentID = RemAppointmentID
                .PetID = RemPetID
            End With

            DbTrans = Nothing
            DbTrans = DbConn.BeginTransaction

            If Not ClsAppointment.RemovePetAppointment(ClsAppointment, ClsAppointmentDetail, DbConn, DbTrans) Then
                DbTrans.Rollback()
                DbTrans = Nothing
                Return False
            End If

            DbTrans.Commit()
            DbTrans = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DeletePetFromAppointment()")
            DbTrans.Rollback()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function AddPetToDgv(Optional PetID As String = "", Optional RowIndex As Integer = Nothing) As Boolean

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim DtPet As New DataTable

        Dim UserResponse As MsgBoxResult

        Try
            DtPet = InitPetDatatable()

            If DgvSelectedPet.Rows.Count > 0 Then

                'Check if user trying to add same item
                For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1
                    If DgvSelectedPet.Rows(i).Cells("SelectedPetID").Value = PetID Then
                        MsgBox("You are trying to add same pet into the consultation.", MsgBoxStyle.Exclamation, "Duplicate Pet")
                        Return False
                    End If
                Next

                'Check if user trying to add more than one item
                UserResponse = MsgBox("Are sure you want to select this pet for the current visit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Change Pet?")
                If UserResponse = MsgBoxResult.Yes Then
                    'Skip selecting previously selected pet
                    GoTo ReplaceCurrentPet
                Else
                    Return False
                End If

            End If

            'Loop data grid view
            For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1

                Dim DgvRow As DataRow = DtPet.NewRow

                'DgvRow("CustomerID") = DgvSelectedPet.Rows(i).Cells("CustomerID").Value
                'DgvRow("CustomerName") = DgvSelectedPet.Rows(i).Cells("CustomerName").Value
                DgvRow("PetID") = DgvSelectedPet.Rows(i).Cells("SelectedPetID").Value
                DgvRow("PetName") = DgvSelectedPet.Rows(i).Cells("SelectedPetName").Value
                DgvRow("PetDOB") = CDate(DgvSelectedPet.Rows(i).Cells("SelectedPetDOB").Value).Date
                DgvRow("AnimalTypeCode") = DgvSelectedPet.Rows(i).Cells("SelectedAnimalTypeCode").Value
                DgvRow("AnimalTypeName") = DgvSelectedPet.Rows(i).Cells("SelectedAnimalTypeName").Value
                DgvRow("BreedCode") = DgvSelectedPet.Rows(i).Cells("SelectedBreedCode").Value
                DgvRow("BreedName") = DgvSelectedPet.Rows(i).Cells("SelectedBreedName").Value
                DgvRow("SexCode") = DgvSelectedPet.Rows(i).Cells("SelectedSexCode").Value
                DgvRow("SexName") = DgvSelectedPet.Rows(i).Cells("SelectedSexName").Value
                DgvRow("NeuterCode") = DgvSelectedPet.Rows(i).Cells("SelectedNeuterCode").Value
                DgvRow("NeuterName") = DgvSelectedPet.Rows(i).Cells("SelectedNeuterName").Value
                'DgvRow("VisitDescription") = DgvSelectedPet.Rows(i).Cells("VisitDescription").Value

                DtPet.Rows.Add(DgvRow)

            Next

ReplaceCurrentPet:
            'Take pet information from fields, e.g. textboxes
            Dim Row As DataRow = DtPet.NewRow

            'Row("CustomerID") = DgvPetListing.Rows(RowIndex).Cells("CustomerID").Value 'UCase(Trim(TxtCustomerID.Text))
            'Row("CustomerName") = DgvPetListing.Rows(RowIndex).Cells("CustomerName").Value  'UCase(Trim(TxtCustomerName.Text))
            Row("PetID") = DgvPetListing.Rows(RowIndex).Cells("PetID").Value 'UCase(Trim(TxtPetID.Text))
            Row("PetName") = DgvPetListing.Rows(RowIndex).Cells("PetName").Value 'UCase(Trim(TxtPetName.Text))
            Row("PetDOB") = DgvPetListing.Rows(RowIndex).Cells("PetDOB").Value 'DtpPetDOB.Value
            Row("AnimalTypeCode") = DgvPetListing.Rows(RowIndex).Cells("AnimalTypeCode").Value 'DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("AnimalTypeName") = DgvPetListing.Rows(RowIndex).Cells("AnimalTypeName").Value 'DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("BreedCode") = DgvPetListing.Rows(RowIndex).Cells("BreedCode").Value 'DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("BreedName") = DgvPetListing.Rows(RowIndex).Cells("BreedName").Value 'DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("SexCode") = DgvPetListing.Rows(RowIndex).Cells("SexCode").Value 'DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("SexName") = DgvPetListing.Rows(RowIndex).Cells("SexName").Value 'DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("NeuterCode") = DgvPetListing.Rows(RowIndex).Cells("NeuterCode").Value 'DirectCast(CmbStatus.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("NeuterName") = DgvPetListing.Rows(RowIndex).Cells("NeuterName").Value 'DirectCast(CmbStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            'Row("VisitDescription") = "" 'DirectCast(CmbStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString

            DtPet.Rows.Add(Row)

            With DgvSelectedPet

                If .Rows.Count > 0 Then
                    .Rows.Clear()
                End If

                For i As Integer = 0 To DtPet.Rows.Count - 1

                    .Rows.Add()
                    .Rows(i).Cells("SelectedPetID").Value = DtPet.Rows(i).Item("PetID")
                    .Rows(i).Cells("SelectedPetName").Value = DtPet.Rows(i).Item("PetName")
                    .Rows(i).Cells("SelectedPetDOB").Value = CDate(DtPet.Rows(i).Item("PetDOB")).Date.ToShortDateString
                    .Rows(i).Cells("SelectedAnimalTypeCode").Value = DtPet.Rows(i).Item("AnimalTypeCode")
                    .Rows(i).Cells("SelectedAnimalTypeName").Value = DtPet.Rows(i).Item("AnimalTypeName")
                    .Rows(i).Cells("SelectedBreedCode").Value = DtPet.Rows(i).Item("BreedCode")
                    .Rows(i).Cells("SelectedBreedName").Value = DtPet.Rows(i).Item("BreedName")
                    .Rows(i).Cells("SelectedSexCode").Value = DtPet.Rows(i).Item("SexCode")
                    .Rows(i).Cells("SelectedSexName").Value = DtPet.Rows(i).Item("SexName")
                    .Rows(i).Cells("SelectedNeuterCode").Value = DtPet.Rows(i).Item("NeuterCode")
                    .Rows(i).Cells("SelectedNeuterName").Value = DtPet.Rows(i).Item("NeuterName")

                Next

            End With

            TcVisitInformation.SelectTab("TpVisitInformation")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddPetToDGV()")
        End Try

        Return True

    End Function

    'Private Sub AddUpdatePetIssues()

    '    Try
    '        For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1
    '            If LblPetName.Tag = DgvSelectedPet.Rows(i).Cells("PetID").Value Then
    '                DgvSelectedPet.Rows(i).Cells("VisitDescription").Value = Trim(TxtVisitDescription.Text)
    '                MsgBox("Pet issues has been successfully saved!", MsgBoxStyle.Information, "Pet Issues Saved")
    '                Exit For
    '            End If
    '        Next

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddUpdatePetIssues()")
    '    End Try

    'End Sub

    Private Sub SaveVisitToDb()

        Try
            If Not CheckUserInput(UserCommand) Then Exit Sub
            If Not AddNewVisit() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveVisitToDb()")
        End Try

    End Sub

    Private Function CheckUserInput(UserCommand As String) As Boolean

        Dim DtConsultation As New DataTable
        Dim ClsConsultation As New ClsVisit

        Try
            If DgvSelectedPet.Rows.Count = 0 Then
                MsgBox("Please select your pet for the visit.", MsgBoxStyle.Exclamation, "No Pet Selected")
                Return False
            End If

            'Check appointment issues/description/complaints for each pets selected for the appontment
            'For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1
            '    If DgvSelectedPet.Rows(i).Cells("VisitDescription").Value = "" Then
            '        MsgBox("Please specify pet's issue/problem/complaint for " & DgvSelectedPet.Rows(i).Cells("PetName").Value & ".", MsgBoxStyle.Exclamation, "No Pet Problems Specified")
            '        Return False
            '    End If
            'Next

            'Check existing and vet availability on that day for new appointment
            If TxtVisitID.Text = "" Then

                ClsConsultation.CustomerID = Trim(TxtCustomerID.Text)
                DtConsultation = ClsConsultation.GetVisitListing(ClsConsultation)
                If DtConsultation.Rows.Count > 0 Then

                    Dim EmpID As String = TxtVet.Tag 'DirectCast(CmbVet.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                    Dim ApDate As String = DtpConsultationDate.Value.Date.ToShortDateString
                    Dim ApTime As String = String.Format("{0:HH:mm:ss}", DtpConsultationTime.Value)
                    Dim ConsultationTime As DateTime = DateTime.ParseExact(ApDate & " " & ApTime, "dd/MM/yyyy HH:mm:ss", Globalization.CultureInfo.InvariantCulture)

                    If TxtCustomerID.Text = DtConsultation.Rows(0).Item("CustomerID") And DtpConsultationDate.Value.Date = CDate(DtConsultation.Rows(0).Item("VisitTime")).Date Then

                        MsgBox("You already have an appointment for the selected date.", MsgBoxStyle.Exclamation, "Appointment Already Created")
                        Return False

                    ElseIf EmpID = DtConsultation.Rows(0).Item("EmployeeID") And ConsultationTime = DtConsultation.Rows(0).Item("VisitTime") Then

                        MsgBox("The selected vet is not available for appointment. Please select other date and time.", MsgBoxStyle.Exclamation, "Vet Not Available")
                        Return False

                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckUserInput()")
        End Try

        Return True

    End Function

    Private Function AddNewVisit() As Boolean

        Dim ClsVisit As New ClsVisit
        Dim ClsVisitDetail As New ClsVisitDetail
        Dim ClsVisitCharges As New ClsVisitCharges
        Dim DtVisit As New DataTable
        Dim VisitTime As Date
        Dim GenVisitID As String

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If TxtVisitID.Text <> "" Then
                GenVisitID = TxtVisitID.Text
            Else
                GenVisitID = GenerateRunningNo("VS", DbConn, DbTrans)
            End If

            TxtVisitID.Tag = GenVisitID
            If GenVisitID = "" Then
                MsgBox("Failed to create visit ID.", MsgBoxStyle.Critical, "Create Visit ID Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                Return False
            End If

            Dim ApDate As String = DtpConsultationDate.Value.Date.ToShortDateString
            Dim ApTime As String = String.Format("{0:HH:mm:ss}", DtpConsultationTime.Value)

            VisitTime = DateTime.ParseExact(ApDate & " " & ApTime, "dd/MM/yyyy HH:mm:ss", Globalization.CultureInfo.InvariantCulture)

            If DgvSelectedPet.Rows.Count > 0 Then

                ClsVisit = New ClsVisit
                With ClsVisit
                    .VisitID = GenVisitID
                    .EmployeeID = Trim(TxtVet.Tag) 'DirectCast(CmbVet.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                    .EmployeeName = Trim(TxtVet.Text) 'DirectCast(CmbVet.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                    .CustomerID = UCase(Trim(TxtCustomerID.Text))
                    .CustomerName = UCase(Trim(TxtCustomerName.Text))
                    .TelNo = Trim(TxtTelNo.Text)
                    .MobileNo = Trim(TxtMobileNo.Text)
                    .VisitTime = VisitTime
                    .IsCompleted = IIf(CbIsVisitCompleted.Checked = True, "1", "0")
                    .IsWarded = IIf(CbIsAdmittedToWard.Checked = True, "1", "0")
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
                End With

                'Visit header
                If Not ClsVisit.AddNewVisit(ClsVisit, DbConn, DbTrans) Then
                    MsgBox("Failed to create visit header.", MsgBoxStyle.Critical, "Create Visit Header Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Visit detail
                'Trim TemperamentName and BodyScoreName
                Dim StrTemperamentName As String = DirectCast(CmbTemperament.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                Dim StrBodyScoreName As String = DirectCast(CmbBodyScore.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                Dim TemperamentName As String = Trim(StrTemperamentName.Replace(StrTemperamentName.Substring(0, 4), ""))
                Dim BodyScoreName As String = Trim(StrBodyScoreName.Replace(StrBodyScoreName.Substring(0, 4), ""))

                For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1

                    ClsVisitDetail = New ClsVisitDetail
                    With ClsVisitDetail
                        .VisitID = GenVisitID
                        .PetID = DgvSelectedPet.Rows(i).Cells("SelectedPetID").Value
                        .PetName = DgvSelectedPet.Rows(i).Cells("SelectedPetName").Value
                        .PetDOB = DgvSelectedPet.Rows(i).Cells("SelectedPetDOB").Value
                        .SexCode = DgvSelectedPet.Rows(i).Cells("SelectedSexCode").Value
                        .SexName = DgvSelectedPet.Rows(i).Cells("SelectedSexName").Value
                        .AnimalTypeCode = DgvSelectedPet.Rows(i).Cells("SelectedAnimalTypeCode").Value
                        .AnimalTypeName = DgvSelectedPet.Rows(i).Cells("SelectedAnimalTypeName").Value
                        .BreedCode = DgvSelectedPet.Rows(i).Cells("SelectedBreedCode").Value
                        .BreedName = DgvSelectedPet.Rows(i).Cells("SelectedBreedName").Value
                        .NeuterCode = DgvSelectedPet.Rows(i).Cells("SelectedNeuterCode").Value
                        .NeuterName = DgvSelectedPet.Rows(i).Cells("SelectedNeuterName").Value
                        .VisitDescription = Trim(TxtVisitDescription.Text)
                        .Temperature = IIf(Trim(TxtTemperature.Text) <> "", TxtTemperature.Text, 0.0)
                        .TemperamentCode = DirectCast(CmbTemperament.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                        .TemperamentName = TemperamentName
                        .BodyScoreCode = DirectCast(CmbBodyScore.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                        .BodyScoreName = BodyScoreName
                        .BodyWeight = IIf(TxtBodyWeight.Text <> "", TxtBodyWeight.Text, 0.0)
                        .PEFindings = Trim(TxtPEFindings.Text)
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now
                    End With

                    If Not ClsVisitDetail.AddNewVisitDetail(ClsVisitDetail, DbConn, DbTrans) Then
                        MsgBox("Failed to create visit details.", MsgBoxStyle.Critical, "Create Visit Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Next

            End If

            'Add consultation/medical charges
            If DgvSelectedItem.Rows.Count > 0 Then
                For i As Integer = 0 To DgvSelectedItem.Rows.Count - 1
                    With ClsVisitCharges
                        .VisitID = GenVisitID
                        .RowNo = DgvSelectedItem.Rows(i).Cells("ChargesRowNo").Value
                        .ItemCode = DgvSelectedItem.Rows(i).Cells("ChargesItemCode").Value
                        .ItemDescription = DgvSelectedItem.Rows(i).Cells("ChargesItemDescription").Value
                        .ItemGroup = DgvSelectedItem.Rows(i).Cells("ChargesItemGroup").Value
                        .ItemTypeCode = DgvSelectedItem.Rows(i).Cells("ChargesItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedItem.Rows(i).Cells("ChargesItemTypeDescription").Value
                        .Prescription = DgvSelectedItem.Rows(i).Cells("ChargesPrescription").Value
                        .Notes = DgvSelectedItem.Rows(i).Cells("ChargesNotes").Value
                        .UnitPrice = DgvSelectedItem.Rows(i).Cells("ChargesUnitPrice").Value
                        .Quantity = DgvSelectedItem.Rows(i).Cells("ChargesQuantity").Value
                        .TotalPrice = DgvSelectedItem.Rows(i).Cells("ChargesTotalPrice").Value
                        .ChSource = "1"
                        .ChSourceName = "VISIT"
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewVisitCharges(ClsVisitCharges, DbConn, DbTrans) Then
                            MsgBox("Failed to update consultation/medication charges.", MsgBoxStyle.Critical, "Visit Charges Update Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With
                Next
            End If

            'Add ward admission status
            If CbIsAdmittedToWard.Checked = True Then

                'Pass connection and transaction
                If Not AdmitToWard(DbConn, DbTrans) Then
                    MsgBox("Failed to update ward admission status.", MsgBoxStyle.Critical, "Ward Admissin Status Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End If

            'Add vet sales
            If Not AddVetSales(GenVisitID, DbConn, DbTrans) Then
                MsgBox("Failed to update feature.", MsgBoxStyle.Critical, "Performance Update Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            'Set VisitID, Ref to be displayed right after data entry has been saved
            TxtVisitID.Text = GenVisitID
            With ClsVisit
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            SetFields(UserCommand)

            MsgBox("Visit has been successfully created!", MsgBoxStyle.Information, "Visit Successfully Added")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewVisit()")
            If DbTrans IsNot Nothing Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
            End If
            Return False
        End Try

        Return True

    End Function

    Private Function AddVetSales(VisitID As String, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Dim ClsVetSales As New ClsVetSales

            If CURR_EMPLOYEE_POS <> "01" Then
                Return True
                'Return true to skip updating vet sales
            End If

            If DgvSelectedItem.Rows.Count > 0 Then

                With ClsVetSales

                    For i As Integer = 0 To DgvSelectedItem.Rows.Count - 1

                        .SalesDate = Now 'Save in DateTime
                        .VisitID = VisitID
                        .EmployeeID = CURR_EMPLOYEE_ID
                        .EmployeeName = CURR_EMPLOYEE_NAME
                        .PositionCode = CURR_EMPLOYEE_POS
                        .ChSource = "1" '1 = VISIT
                        .ItemCode = DgvSelectedItem.Rows(i).Cells("ChargesItemCode").Value
                        .ItemDescription = DgvSelectedItem.Rows(i).Cells("ChargesItemDescription").Value
                        .ItemGroup = DgvSelectedItem.Rows(i).Cells("ChargesItemGroup").Value
                        .ItemTypeCode = DgvSelectedItem.Rows(i).Cells("ChargesItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedItem.Rows(i).Cells("ChargesItemTypeDescription").Value
                        .UnitPrice = DgvSelectedItem.Rows(i).Cells("ChargesUnitPrice").Value
                        .Quantity = DgvSelectedItem.Rows(i).Cells("ChargesQuantity").Value
                        .TotalPrice = DgvSelectedItem.Rows(i).Cells("ChargesTotalPrice").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddVetSales(ClsVetSales, DbConn, DbTrans) Then
                            Return False
                        End If

                    Next

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddVetSales()")
            Return False
        End Try

        Return True

    End Function

    Private Function IsVisitCompleted() As Boolean

        Dim UserResponse As MsgBoxResult
        Dim ClsVisit As New ClsVisit

        Try
            If TxtVisitID.Text = "" Then
                Return False
            End If

            UserResponse = MsgBox("Are sure you want to complete this consultation?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Complete Consultation?")
            If UserResponse = MsgBoxResult.Yes Then

                'Update IsCompleted from 0 to 1 if consultation is already completed
                If DbTrans IsNot Nothing Then
                    DbTrans = Nothing
                End If

                DbTrans = DbConn.BeginTransaction

                With ClsVisit
                    .VisitID = Trim(TxtVisitID.Text)
                    .IsCompleted = IIf(CbIsVisitCompleted.Checked = True, "1", "0")
                End With

                If Not ClsVisit.UpdateIsVisitCompleted(ClsVisit, DbConn, DbTrans) Then
                    MsgBox("Failed to update visit completion.", MsgBoxStyle.Critical, "Failed to Update Visit Completion")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                DbTrans.Commit()
                DbTrans.Dispose()
                DbTrans = Nothing

                MsgBox("Your visit has been successfully completed.", MsgBoxStyle.Information, "Visit Completed")

                CbIsVisitCompleted.Checked = True
                CbIsVisitCompleted.Enabled = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".IsVisitCompleted()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function InitBillItemDt() As DataTable

        Dim DtBill As New DataTable

        Try
            'Initialize datatable
            With DtBill
                .Columns.Add("RowNo", GetType(Integer))
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("Discount", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitBillItemDt()")
        End Try

        Return DtBill

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckUserInput(UserCommand) Then Exit Sub
        If Not AddNewVisit() Then Exit Sub
        'SaveVisitToDb()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

    End Sub

    'Private Sub BtnAddPetIssues_Click(sender As Object, e As EventArgs)
    '    AddUpdatePetIssues()
    'End Sub

    Private Sub CbIsCompleted_Click(sender As Object, e As EventArgs)
        If Not IsVisitCompleted() Then Exit Sub
    End Sub

    Private Sub BtnGenerateBill_Click(sender As Object, e As EventArgs)
        GenerateBill()
    End Sub

    Private Sub GenerateBill()

        Dim DtBill As New DataTable
        Dim ClsBill As New ClsBill

        Try
            'Check if bill already created
            If TxtVisitID.Text <> "" Then
                ClsBill.VisitID = TxtVisitID.Text
                DtBill = ClsBill.CheckExistingBill(ClsBill)
            End If

            'Check if bill is already generated for the selected visit
            If DtBill.Rows.Count > 0 Then
                With FrmPaymentInformation
                    .UserCommand = "SHOW_BILLING_INFO"
                    .VisitID = DtBill.Rows(0).Item("VisitID")
                    .CustomerID = DtBill.Rows(0).Item("CustomerID")
                    .CustomerName = DtBill.Rows(0).Item("CustomerName")
                    .InvoiceNo = DtBill.Rows(0).Item("InvoiceNo")
                    .ShowDialog()
                End With
            Else
                With FrmPaymentInformation
                    .UserCommand = "ADD_NEW_BILLING"
                    .VisitID = TxtVisitID.Text
                    .CustomerID = TxtCustomerID.Text
                    .CustomerName = TxtCustomerName.Text
                    .ShowDialog()
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDeposit_TextChanged()")
        End Try

    End Sub

    Private Function AdmitToWard(DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim ClsVisit As New ClsVisit
        'Dim Message As String

        Try
            'If DbTrans IsNot Nothing Then
            '    DbTrans = Nothing
            'End If

            'DbTrans = DbConn.BeginTransaction

            With ClsVisit
                'If CbIsAdmittedToWard.Checked = True Then
                '    .IsAdmittedToWard = "1"
                '    Message = "Pet has been added to ward admission."
                'Else
                '    .IsAdmittedToWard = "0"
                '    Message = "Pet has been removed from ward admission."
                'End If

                .VisitID = Trim(TxtVisitID.Text)
                .IsWarded = IIf(CbIsAdmittedToWard.Checked = True, "1", "0")
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .UpdateWardAdmission(ClsVisit, DbConn, DbTrans) Then
                    'MsgBox("Failed to update ward admission.", MsgBoxStyle.Critical, "Update Ward Admission Error")
                    'DbTrans.Rollback()
                    'DbTrans.Dispose()
                    'DbTrans = Nothing
                    Return False
                End If

            End With

            'DbTrans.Commit()
            'DbTrans.Dispose()
            'DbTrans = Nothing

            'MsgBox(Message, MsgBoxStyle.Information, "Ward Admission")

        Catch ex As Exception
            'MsgBox("Failed to update ward admission.", MsgBoxStyle.Critical, FORM_NAME & ".AdmitToWard()")
            'DbTrans.Rollback()
            'DbTrans.Dispose()
            'DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub AddItem()

        Dim DtItem As New DataTable

        Try
            If TxtItem.Tag = "" Then
                Exit Sub
            End If

            DtItem = InitSelectedItemDt()
            If DgvSelectedItem.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvSelectedItem.Rows.Count - 1

                    Dim DgvRow As DataRow = DtItem.NewRow

                    DgvRow("RowNo") = DgvSelectedItem.Rows(i).Cells("ChargesRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedItem.Rows(i).Cells("ChargesItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedItem.Rows(i).Cells("ChargesItemDescription").Value

                    DgvRow("Prescription") = DgvSelectedItem.Rows(i).Cells("ChargesPrescription").Value
                    DgvRow("Notes") = DgvSelectedItem.Rows(i).Cells("ChargesNotes").Value

                    DgvRow("Quantity") = DgvSelectedItem.Rows(i).Cells("ChargesQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedItem.Rows(i).Cells("ChargesUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedItem.Rows(i).Cells("ChargesTotalPrice").Value
                    DgvRow("ItemGroup") = DgvSelectedItem.Rows(i).Cells("ChargesItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvSelectedItem.Rows(i).Cells("ChargesItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvSelectedItem.Rows(i).Cells("ChargesItemTypeDescription").Value

                    DgvRow("IsChargeDb") = DgvSelectedItem.Rows(i).Cells("IsChargeDb").Value

                    DtItem.Rows.Add(DgvRow)

                Next

            End If

            'Check if user trying to add duplicate items; instead tell user to update quantity
            If AddItemToBill(DtItem, TxtItem.Tag) Then

                Dim Row As DataRow = DtItem.NewRow

                Row("RowNo") = IIf(DtItem.Rows.Count = 0, 1, DtItem.Rows.Count + 1)
                Row("ItemCode") = UCase(Trim(TxtItem.Tag))
                Row("ItemDescription") = UCase(Trim(TxtItem.Text))
                Row("Prescription") = UCase(Trim(TxtPrescription.Text))
                Row("Notes") = UCase(Trim(TxtNotes.Text))
                Row("UnitPrice") = UCase(Trim(TxtUnitPrice.Text))
                Row("Quantity") = UCase(Trim(TxtQuantity.Text))
                Row("TotalPrice") = FormatNumber(CDec(TxtTotalPrice.Text) * CDec(TxtQuantity.Text), 2)
                Row("ItemGroup") = ItemGroup
                Row("ItemTypeCode") = ItemTypeCode
                Row("ItemTypeDescription") = ItemTypeDescription
                Row("IsChargeDb") = "0"

                DtItem.Rows.Add(Row)

            End If

            If DtItem.Rows.Count > 0 Then

                DgvSelectedItem.Rows.Clear()

                For i As Integer = 0 To DtItem.Rows.Count - 1
                    With DgvSelectedItem
                        .Rows.Add()
                        .Rows(i).Cells("ChargesRowNo").Value = DtItem.Rows(i).Item("RowNo")
                        .Rows(i).Cells("ChargesItemCode").Value = DtItem.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("ChargesItemDescription").Value = DtItem.Rows(i).Item("ItemDescription")

                        .Rows(i).Cells("ChargesPrescription").Value = DtItem.Rows(i).Item("Prescription")
                        .Rows(i).Cells("ChargesNotes").Value = DtItem.Rows(i).Item("Notes")

                        .Rows(i).Cells("ChargesUnitPrice").Value = DtItem.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("ChargesQuantity").Value = DtItem.Rows(i).Item("Quantity")
                        .Rows(i).Cells("ChargesTotalPrice").Value = DtItem.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("ChargesItemGroup").Value = DtItem.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("ChargesItemTypeCode").Value = DtItem.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("ChargesItemTypeDescription").Value = DtItem.Rows(i).Item("ItemTypeDescription")

                        .Rows(i).Cells("IsChargeDb").Value = DtItem.Rows(i).Item("IsChargeDb")
                    End With
                Next

            End If

            TxtItem.Tag = ""
            TxtItem.Text = ""
            TxtUnitPrice.Text = ""
            'TxtTestQuantity.Text = ""
            TxtTotalPrice.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTest()")
        End Try

    End Sub

    Private Function AddItemToBill(DtPayment As DataTable, ItemCode As String, Optional ItemDate As Date = Nothing) As Boolean

        Try
            If DtPayment.Rows.Count > 0 Then
                For i As Integer = 0 To DtPayment.Rows.Count - 1
                    If ItemCode = DtPayment.Rows(i).Item("ItemCode") Then
                        MsgBox("You are trying to add duplicate item. Please update your item quantity.", MsgBoxStyle.Exclamation, "Duplicate Item Detected")
                        Return False
                    End If
                Next
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddItemToBill()")
            Return False
        End Try

        Return True

    End Function

    Private Function InitSelectedItemDt() As DataTable

        Dim DtTreatment As New DataTable

        Try
            With DtTreatment
                .Columns.Add("RowNo", GetType(Integer))
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("ItemGroup", GetType(String))
                .Columns.Add("ItemTypeCode", GetType(String))
                .Columns.Add("ItemTypeDescription", GetType(String))
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
                .Columns.Add("IsChargeDb", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitTreatmentDt()")
        End Try

        Return DtTreatment

    End Function

    Private Sub CbAdmitToWard_Click(sender As Object, e As EventArgs)
        'If Not AdmitToWard() Then Exit Sub
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        AddItem()
    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtItem.Tag = .ItemCode
            TxtItem.Text = .ItemDescription
            TxtUnitPrice.Text = .UnitPrice
            TxtTotalPrice.Text = FormatNumber(.UnitPrice * TxtQuantity.Text, 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnBillPayment_Click(sender As Object, e As EventArgs)
        With FrmPaymentInformation
            .InvoiceNo = BtnBillPayment.Tag
            .UserCommand = "SHOW_BILLING_INFO"
            .ShowDialog()
        End With
    End Sub

    Private Sub CbIsAdmittedToWard_Click(sender As Object, e As EventArgs) Handles CbIsAdmittedToWard.Click
        'If Not AdmitToWard() Then Exit Sub
    End Sub

    Private Sub DgvSelectedItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedItem.CellContentClick

        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Item?")

                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvSelectedItem

                            If .Rows(e.RowIndex).Cells("IsChargeDb").Value = "1" Then
                                MsgBox("Unable to delete item that has been saved into the database.", MsgBoxStyle.Exclamation, "Read-Only Item")
                            Else
                                .Rows.RemoveAt(e.RowIndex)
                            End If

                            'TxtTreatmentItem.Text = ""
                            'TxtTreatmentItem.Tag = ""
                            'TxtTreatmentPrescription.Text = ""
                            'TxtTreatmentNotes.Text = ""
                            'TxtTreatmentUnitPrice.Text = "0.00"
                            'TxtTreatmentQuantity.Text = "1.00"
                            'TxtTreatmentTotalPrice.Text = "0.00"

                        End With

                    Else
                        Exit Sub

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & "DgvSelectedItem_CellContentClick()")
        End Try

    End Sub

End Class