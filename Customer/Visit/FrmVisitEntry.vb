﻿Imports System.Text

Public Class FrmVisitEntry

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

    Private _ConsultationID As String
    Public Property ConsultationID As String
        Get
            Return _ConsultationID
        End Get
        Set(value As String)
            _ConsultationID = value
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

    Private _FormTitle As String
    Public Property FormTitle As String
        Get
            Return _FormTitle
        End Get
        Set(value As String)
            _FormTitle = value
        End Set
    End Property

    Private Sub FrmConsultationEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        Me.Text = IIf(FormTitle <> "", FormTitle, Me.Text)
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateSalutation()
        PopulateAnimalType()
        PopulateBreed()
        PopulatePetStatus()
        PopulatePetSex()
        PopulateVet()

        If UserCommand = "ADD_NEW_CONSULTATION" Then
            Exit Sub
        Else
            PopulateForm(UserCommand)
        End If

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

                If CmbSalutation.Items.Count > 0 Then
                    CmbSalutation.DataSource = Nothing
                    CmbSalutation.Items.Clear()
                End If

                CmbSalutation.DataSource = New BindingSource(CmbSource, Nothing)
                CmbSalutation.DisplayMember = "Value"
                CmbSalutation.ValueMember = "Key"

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

    Private Sub PopulatePetStatus()

        Dim DtPetStatus As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtPetStatus = ClsPet.GetPetStatus(ClsPet)
            If DtPetStatus.Rows.Count > 0 Then

                For i As Integer = 0 To DtPetStatus.Rows.Count - 1
                    CmbSource.Add(DtPetStatus.Rows(i).Item("StatusCode"), DtPetStatus.Rows(i).Item("StatusName"))
                Next

                If CmbStatus.Items.Count > 0 Then
                    CmbStatus.DataSource = Nothing
                    CmbStatus.Items.Clear()
                End If

                CmbStatus.DataSource = New BindingSource(CmbSource, Nothing)
                CmbStatus.DisplayMember = "Value"
                CmbStatus.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulatePetStatus()")
        End Try

    End Sub

    Private Sub PopulateVet()

        Dim DtVet As New DataTable
        Dim ClsEmployee As New ClsEmployee
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtVet = ClsEmployee.GetVet(ClsEmployee)
            If DtVet.Rows.Count > 0 Then

                For i As Integer = 0 To DtVet.Rows.Count - 1
                    CmbSource.Add(DtVet.Rows(i).Item("EmployeeID"), DtVet.Rows(i).Item("EmployeeName"))
                Next

                If CmbVet.Items.Count > 0 Then
                    CmbVet.DataSource = Nothing
                    CmbVet.Items.Clear()
                End If

                CmbVet.DataSource = New BindingSource(CmbSource, Nothing)
                CmbVet.DisplayMember = "Value"
                CmbVet.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateVet()")
        End Try

    End Sub

    Private Sub PopulateForm(Optional UserCommand As String = Nothing)

        Dim BtnDelete As New DataGridViewButtonColumn
        Dim BtnSelect As New DataGridViewButtonColumn
        Dim DtCustomer As New DataTable
        Dim DtPet As New DataTable
        Dim DtConsultation As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim ClsPet As New ClsPet
        Dim ClsConsultation As New ClsVisit
        Dim StrOp As String = "WHERE"

        Try
            'Get customer and pet information from database
            If UserCommand = "POPULATE_CUSTOMER_INFO" Then
                Me.Text = "Create New Consultation"

            ElseIf UserCommand = "SHOW_CUSTOMER_CONSULTATION" Then
                Me.Text = "Customer Visit Details"
                ClsConsultation.ConsultationID = ConsultationID
                DtConsultation = ClsConsultation.GetConsultationDetail(ClsConsultation)

            End If

            ClsCustomer.SQLQueryCondition = FilterSQL(StrOp, CustomerID, UserCommand)
            ClsPet.CustomerID = CustomerID

            DtCustomer = ClsCustomer.GetCustomerListing(ClsCustomer)
            DtPet = ClsPet.GetPetListing(ClsPet)

            If DtCustomer.Rows.Count > 0 Then

                'Set fields using Customer information retrieved from database
                TxtCustomerID.Text = DtCustomer.Rows(0).Item("CustomerID")
                CmbSalutation.Text = DtCustomer.Rows(0).Item("SaluteName")
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

            If DtPet.Rows.Count > 0 Then

                TxtCustomerIDPI.Text = DtCustomer.Rows(0).Item("CustomerID")
                TxtCustomerNamePI.Text = DtCustomer.Rows(0).Item("CustomerName")
                TxtPetID.Text = DtPet.Rows(0).Item("PetID")
                TxtPetName.Text = DtPet.Rows(0).Item("PetName")
                DtpPetDOB.Value = CDate(DtPet.Rows(0).Item("PetDOB")).Date
                CmbAnimalType.SelectedValue = CStr(DtPet.Rows(0).Item("AnimalTypeCode"))
                CmbBreed.SelectedValue = CStr(DtPet.Rows(0).Item("BreedCode"))
                CmbSex.SelectedValue = CStr(DtPet.Rows(0).Item("SexCode"))
                CmbStatus.SelectedValue = CStr(DtPet.Rows(0).Item("StatusCode"))

                With BtnSelect
                    .HeaderText = "Select"
                    .Text = "Select"
                    .Name = "BtnSelect"
                    .UseColumnTextForButtonValue = True
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .DisplayIndex = 0
                End With

                'Add IsDB indicator here
                With DtPet
                    '.Columns.Add("IsDB", GetType(String))
                    .Columns.Add("CustomerName", GetType(String)).SetOrdinal(1)
                End With

                For i As Integer = 0 To DtPet.Rows.Count - 1
                    'DtPet.Rows(i).Item("IsDb") = "1"
                    DtPet.Rows(i).Item("CustomerName") = DtCustomer.Rows(0).Item("CustomerName")
                Next

                With DgvPetListing
                    .Columns.Add(BtnSelect)
                    .DataSource = DtPet
                    .Show()
                End With

            End If

            If DtConsultation.Rows.Count > 0 Then

                Dim DtSelectedPet As New DataTable

                TxtVisitID.Text = DtConsultation.Rows(0).Item("ConsultationID")
                DtpConsultationDate.Value = CDate(DtConsultation.Rows(0).Item("ConsultationTime"))
                DtpConsultationTime.Value = CDate(DtConsultation.Rows(0).Item("ConsultationTime"))
                CmbVet.SelectedValue = CStr(DtConsultation.Rows(0).Item("EmployeeID"))

                DtSelectedPet = InitPetDatatable()
                For i As Integer = 0 To DtConsultation.Rows.Count - 1

                    Dim DgvRow As DataRow = DtSelectedPet.NewRow
                    DgvRow("CustomerID") = DtConsultation.Rows(i).Item("CustomerID")
                    DgvRow("CustomerName") = DtConsultation.Rows(i).Item("CustomerName")
                    DgvRow("PetID") = DtConsultation.Rows(i).Item("PetID")
                    DgvRow("PetName") = DtConsultation.Rows(i).Item("PetName")
                    DgvRow("PetDOB") = DtConsultation.Rows(i).Item("PetDOB")
                    DgvRow("AnimalTypeCode") = DtConsultation.Rows(i).Item("AnimalTypeCode")
                    DgvRow("AnimalTypeName") = DtConsultation.Rows(i).Item("AnimalTypeName")
                    DgvRow("BreedCode") = DtConsultation.Rows(i).Item("BreedCode")
                    DgvRow("BreedName") = DtConsultation.Rows(i).Item("BreedName")
                    DgvRow("SexCode") = DtConsultation.Rows(i).Item("SexCode")
                    DgvRow("SexName") = DtConsultation.Rows(i).Item("SexName")
                    DgvRow("StatusCode") = DtConsultation.Rows(i).Item("StatusCode")
                    DgvRow("StatusName") = DtConsultation.Rows(i).Item("StatusName")
                    DgvRow("ConsultationDesc") = DtConsultation.Rows(i).Item("ConsultationDesc")
                    DgvRow("IsDB") = "1"

                    DtSelectedPet.Rows.Add(DgvRow)

                Next

                With BtnDelete
                    .HeaderText = "Delete"
                    .Text = "Delete"
                    .Name = "BtnDelete"
                    .UseColumnTextForButtonValue = True
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .DisplayIndex = 0
                End With

                With DgvSelectedPet
                    .Columns.Add(BtnDelete)
                    .DataSource = DtSelectedPet
                    .Columns("IsDB").Visible = False
                    .Show()
                End With

                TxtCreatedBy.Text = DtConsultation.Rows(0).Item("CreatedBy")
                TxtDateCreated.Text = DtConsultation.Rows(0).Item("DateCreated")
                TxtModifiedBy.Text = DtConsultation.Rows(0).Item("ModifiedBy")
                TxtDateModified.Text = DtConsultation.Rows(0).Item("DateModified")

                If Not IsDBNull(DtConsultation.Rows(0).Item("IsCompleted")) = "1" Then
                    CbIsCompleted.Checked = True
                    CbIsCompleted.Enabled = False
                End If

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
                .Columns.Add("StatusCode", GetType(String))
                .Columns.Add("StatusName", GetType(String))
                .Columns.Add("ConsultationDesc", GetType(String))
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
                    If Trim(Param1) <> "" Then 'Param1 = CustomerID
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

    Private Sub SetFields(ByVal ClearCommand As String, Optional ByVal Param1 As String = "")

        Try
            Select Case ClearCommand
                Case "SET_PET_FIELDS"

                    TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    CmbAnimalType.SelectedIndex = 0
                    CmbBreed.SelectedIndex = 0
                    CmbStatus.SelectedIndex = 0
                    CmbSex.SelectedIndex = 0

                Case "ADD_NEW_CUSTOMER", "ADD_NEW_APPOINTMENT"

                    'Customer information
                    CmbSalutation.Enabled = False
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
                    TxtCustomerIDPI.Text = UCase(TxtCustomerID.Tag)
                    TxtCustomerNamePI.Text = UCase(TxtCustomerName.Text)
                    TxtPetID.Text = UCase(TxtPetID.Tag)
                    TxtPetName.Text = UCase(TxtPetName.Text)

                Case "CLEAR_PET_FIELDS"
                    TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    CmbAnimalType.SelectedIndex = 0
                    CmbBreed.SelectedIndex = 0
                    CmbSex.SelectedIndex = 0
                    CmbStatus.SelectedIndex = 0

                Case "SHOW_CUSTOMER_INFO", "CANCELEDIT_CUSTOMER_INFO", "POPULATE_CUSTOMER_INFO", "SHOW_CUSTOMER_CONSULTATION"

                    'BtnSave.Enabled = False
                    CmbSalutation.Enabled = False
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

                    TxtPetName.ReadOnly = True
                    DtpPetDOB.Enabled = False
                    CmbAnimalType.Enabled = False
                    CmbBreed.Enabled = False
                    CmbSex.Enabled = False
                    CmbStatus.Enabled = False
                    BtnAddPet.Enabled = False
                    BtnClearPet.Enabled = False
                    'DgvPetListing.Enabled = False

                Case "EDIT_CUSTOMER_INFO"

                    BtnSave.Enabled = True

                    CmbSalutation.Enabled = True
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

                    TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    TxtPetName.ReadOnly = False
                    DtpPetDOB.Enabled = True
                    CmbAnimalType.Enabled = True
                    CmbBreed.Enabled = True
                    CmbSex.Enabled = True
                    CmbStatus.Enabled = True
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
                    TxtPetID.Text = ""
                    TxtPetName.Text = ""
                    DtpPetDOB.Value = Now
                    CmbAnimalType.SelectedIndex = 0
                    CmbBreed.SelectedIndex = 0
                    CmbSex.SelectedIndex = 0
                    CmbStatus.SelectedIndex = 0

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

                        If Not AddPetToDgv(e.RowIndex) Then
                            MsgBox("Failed to select pet for appointment.", MsgBoxStyle.Critical, "Select Pet Failed")
                            Exit Sub
                        End If

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

                LblPetName.Tag = DgvSelectedPet.Rows(e.RowIndex).Cells("PetID").Value
                LblPetName.Text = DgvSelectedPet.Rows(e.RowIndex).Cells("PetName").Value
                TxtConsultationDesc.Text = DgvSelectedPet.Rows(e.RowIndex).Cells("ConsultationDesc").Value

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

    Private Function AddPetToDgv(Optional RowIndex As Integer = Nothing) As Boolean

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim DtPet As New DataTable

        Try
            DtPet = InitPetDatatable()

            If DgvSelectedPet.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1

                    Dim DgvRow As DataRow = DtPet.NewRow

                    DgvRow("CustomerID") = DgvSelectedPet.Rows(i).Cells("CustomerID").Value
                    DgvRow("CustomerName") = DgvSelectedPet.Rows(i).Cells("CustomerName").Value
                    DgvRow("PetID") = DgvSelectedPet.Rows(i).Cells("PetID").Value
                    DgvRow("PetName") = DgvSelectedPet.Rows(i).Cells("PetName").Value
                    DgvRow("PetDOB") = DgvSelectedPet.Rows(i).Cells("PetDOB").Value
                    DgvRow("AnimalTypeCode") = DgvSelectedPet.Rows(i).Cells("AnimalTypeCode").Value
                    DgvRow("AnimalTypeName") = DgvSelectedPet.Rows(i).Cells("AnimalTypeName").Value
                    DgvRow("BreedCode") = DgvSelectedPet.Rows(i).Cells("BreedCode").Value
                    DgvRow("BreedName") = DgvSelectedPet.Rows(i).Cells("BreedName").Value
                    DgvRow("SexCode") = DgvSelectedPet.Rows(i).Cells("SexCode").Value
                    DgvRow("SexName") = DgvSelectedPet.Rows(i).Cells("SexName").Value
                    DgvRow("StatusCode") = DgvSelectedPet.Rows(i).Cells("StatusCode").Value
                    DgvRow("StatusName") = DgvSelectedPet.Rows(i).Cells("StatusName").Value
                    DgvRow("ConsultationDesc") = DgvSelectedPet.Rows(i).Cells("ConsultationDesc").Value

                    DtPet.Rows.Add(DgvRow)

                Next

            End If

            'Check if user trying to select same pet
            If DtPet.Rows.Count > 0 Then
                For i As Integer = 0 To DtPet.Rows.Count - 1
                    If DtPet.Rows(i).Item("PetID") = DgvPetListing.Rows(RowIndex).Cells("PetID").Value Then
                        MsgBox("You are trying to add same pet into the consultation.", MsgBoxStyle.Exclamation, "Duplicate Pet")
                        Return True
                    End If
                Next
            End If

            'Take pet information from fields, e.g. textboxes
            Dim Row As DataRow = DtPet.NewRow

            Row("CustomerID") = DgvPetListing.Rows(RowIndex).Cells("CustomerID").Value 'UCase(Trim(TxtCustomerID.Text))
            Row("CustomerName") = DgvPetListing.Rows(RowIndex).Cells("CustomerName").Value  'UCase(Trim(TxtCustomerName.Text))
            Row("PetID") = DgvPetListing.Rows(RowIndex).Cells("PetID").Value 'UCase(Trim(TxtPetID.Text))
            Row("PetName") = DgvPetListing.Rows(RowIndex).Cells("PetName").Value 'UCase(Trim(TxtPetName.Text))
            Row("PetDOB") = DgvPetListing.Rows(RowIndex).Cells("PetDOB").Value 'DtpPetDOB.Value
            Row("AnimalTypeCode") = DgvPetListing.Rows(RowIndex).Cells("AnimalTypeCode").Value 'DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("AnimalTypeName") = DgvPetListing.Rows(RowIndex).Cells("AnimalTypeName").Value 'DirectCast(CmbAnimalType.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("BreedCode") = DgvPetListing.Rows(RowIndex).Cells("BreedCode").Value 'DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("BreedName") = DgvPetListing.Rows(RowIndex).Cells("BreedName").Value 'DirectCast(CmbBreed.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("SexCode") = DgvPetListing.Rows(RowIndex).Cells("SexCode").Value 'DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("SexName") = DgvPetListing.Rows(RowIndex).Cells("SexName").Value 'DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("StatusCode") = DgvPetListing.Rows(RowIndex).Cells("StatusCode").Value 'DirectCast(CmbStatus.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            Row("StatusName") = DgvPetListing.Rows(RowIndex).Cells("StatusName").Value 'DirectCast(CmbStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
            Row("ConsultationDesc") = "" 'DirectCast(CmbStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString

            DtPet.Rows.Add(Row)

            With BtnDeletePet
                .HeaderText = "Delete"
                .Text = "Delete"
                .Name = "BtnDeletePet"
                .UseColumnTextForButtonValue = True
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .DisplayIndex = 0
            End With

            With DgvSelectedPet

                If .Rows.Count = 0 Then
                    .DataSource = Nothing
                    .Columns.Add(BtnDeletePet)
                End If

                .DataSource = DtPet
                .Columns("CustomerID").Visible = False
                .Columns("CustomerName").Visible = False
                .Columns("AnimalTypeCode").Visible = False
                .Columns("BreedCode").Visible = False
                .Columns("SexCode").Visible = False
                .Columns("StatusCode").Visible = False
                .Show()

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddPetToDGV()")
        End Try

        Return True

    End Function

    Private Sub AddUpdatePetIssues()

        Try
            For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1
                If LblPetName.Tag = DgvSelectedPet.Rows(i).Cells("PetID").Value Then
                    DgvSelectedPet.Rows(i).Cells("ConsultationDesc").Value = Trim(TxtConsultationDesc.Text)
                    MsgBox("Pet issues has been successfully saved!", MsgBoxStyle.Information, "Pet Issues Saved")
                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddUpdatePetIssues()")
        End Try

    End Sub

    Private Sub SaveConsultationToDb()

        Try
            If Not CheckUserInput(UserCommand) Then Exit Sub
            If Not AddNewConsultation() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveConsultationToDb()")
        End Try

    End Sub

    Private Function CheckUserInput(UserCommand As String) As Boolean

        'Dim AppointmentTime As DateTime
        Dim DtConsultation As New DataTable
        Dim ClsConsultation As New ClsVisit

        Try
            If DgvSelectedPet.Rows.Count = 0 Then
                MsgBox("Please select your pet for the consultation.", MsgBoxStyle.Exclamation, "No Pet Selected")
                Return False
            End If

            'Check appointment issues/description/complaints for each pets selected for the appontment
            For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1
                If DgvSelectedPet.Rows(i).Cells("ConsultationDesc").Value = "" Then
                    MsgBox("Please specify pet's issue/problem/complaint for " & DgvSelectedPet.Rows(i).Cells("PetName").Value & ".", MsgBoxStyle.Exclamation, "No Pet Problems Specified")
                    Return False
                End If
            Next

            'Check existing and vet availability on that day for new appointment
            If TxtVisitID.Text = "" Then

                ClsConsultation.CustomerID = Trim(TxtCustomerID.Text)
                DtConsultation = ClsConsultation.GetConsultationListing(ClsConsultation)
                If DtConsultation.Rows.Count > 0 Then

                    Dim EmpID As String = DirectCast(CmbVet.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                    Dim ApDate As String = DtpConsultationDate.Value.Date.ToShortDateString
                    Dim ApTime As String = String.Format("{0:HH:mm:ss}", DtpConsultationTime.Value)
                    Dim ConsultationTime As DateTime = DateTime.ParseExact(ApDate & " " & ApTime, "dd/MM/yyyy HH:mm:ss", Globalization.CultureInfo.InvariantCulture)

                    If TxtCustomerID.Text = DtConsultation.Rows(0).Item("CustomerID") And DtpConsultationDate.Value.Date = CDate(DtConsultation.Rows(0).Item("ConsultationTime")).Date Then

                        MsgBox("You already have an appointment for the selected date.", MsgBoxStyle.Exclamation, "Appointment Already Created")
                        Return False

                    ElseIf EmpID = DtConsultation.Rows(0).Item("EmployeeID") And ConsultationTime = DtConsultation.Rows(0).Item("ConsultationTime") Then

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

    Private Function AddNewConsultation() As Boolean

        Dim ClsConsultation As New ClsVisit
        Dim ClsConsultationDetail As New ClsVisitDetail
        Dim DtConsultation As New DataTable
        Dim ConsultationTime As Date
        Dim GenConsultationID As String

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If ConsultationID <> "" Then
                GenConsultationID = ConsultationID
            Else
                GenConsultationID = GenerateRunningNo("VS", DbConn, DbTrans)
            End If

            TxtVisitID.Tag = GenConsultationID
            If GenConsultationID = "" Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                Return False
            End If

            Dim ApDate As String = DtpConsultationDate.Value.Date.ToShortDateString
            Dim ApTime As String = String.Format("{0:HH:mm:ss}", DtpConsultationTime.Value)

            ConsultationTime = DateTime.ParseExact(ApDate & " " & ApTime, "dd/MM/yyyy HH:mm:ss", Globalization.CultureInfo.InvariantCulture)

            If DgvSelectedPet.Rows.Count > 0 Then

                ClsConsultation = New ClsVisit
                With ClsConsultation
                    .ConsultationID = GenConsultationID
                    .EmployeeID = DirectCast(CmbVet.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                    .EmployeeName = DirectCast(CmbVet.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                    .CustomerID = UCase(Trim(TxtCustomerID.Text))
                    .CustomerName = UCase(Trim(TxtCustomerName.Text))
                    .ConsultationTime = ConsultationTime
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
                End With

                'Consultation header
                If Not ClsConsultation.AddNewConsultation(ClsConsultation, DbConn, DbTrans) Then
                    MsgBox("Failed to create consultation header.", MsgBoxStyle.Critical, "Create Consultation Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Consultation detail
                For i As Integer = 0 To DgvSelectedPet.Rows.Count - 1

                    ClsConsultationDetail = New ClsVisitDetail
                    With ClsConsultationDetail
                        .ConsultationID = GenConsultationID
                        .PetID = DgvSelectedPet.Rows(i).Cells("PetID").Value
                        .PetName = DgvSelectedPet.Rows(i).Cells("PetName").Value
                        .PetDOB = DgvSelectedPet.Rows(i).Cells("PetDOB").Value
                        .AnimalTypeCode = DgvSelectedPet.Rows(i).Cells("AnimalTypeCode").Value
                        .AnimalTypeName = DgvSelectedPet.Rows(i).Cells("AnimalTypeName").Value
                        .BreedCode = DgvSelectedPet.Rows(i).Cells("BreedCode").Value
                        .BreedName = DgvSelectedPet.Rows(i).Cells("BreedName").Value
                        .SexCode = DgvSelectedPet.Rows(i).Cells("SexCode").Value
                        .SexName = DgvSelectedPet.Rows(i).Cells("SexName").Value
                        .StatusCode = DgvSelectedPet.Rows(i).Cells("StatusCode").Value
                        .StatusName = DgvSelectedPet.Rows(i).Cells("StatusName").Value
                        .ConsultationDesc = DgvSelectedPet.Rows(i).Cells("ConsultationDesc").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now
                    End With

                    If Not ClsConsultationDetail.AddNewConsultationDetail(ClsConsultationDetail, DbConn, DbTrans) Then
                        MsgBox("Failed to create consultation details.", MsgBoxStyle.Critical, "Create Consultation Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Next

            End If

            DbTrans.Commit()
            DbTrans = Nothing

            'PopulateCustomerAppointment()

            TxtVisitID.Text = ConsultationID
            TxtCreatedBy.Text = "" 'ClsAppointment.Ref.CreatedBy
            TxtDateCreated.Text = "" 'ClsAppointment.Ref.DateCreated
            TxtModifiedBy.Text = "" 'ClsAppointment.Ref.ModifiedBy
            TxtDateModified.Text = "" 'ClsAppointment.Ref.DateModified

            SetFields(UserCommand)

            MsgBox("Consultation has been successfully created!", MsgBoxStyle.Information, "Consultation Successfully Added")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewConsultation()")
            If DbTrans IsNot Nothing Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
            End If
            Return False
        End Try

        Return True

    End Function



    Private Function IsConsultationCompleted() As Boolean

        Dim UserResponse As MsgBoxResult
        Dim ClsConsultation As New ClsVisit

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

                With ClsConsultation
                    .ConsultationID = Trim(TxtVisitID.Text)
                    .IsCompleted = IIf(CbIsCompleted.Checked = True, "1", "0")
                End With

                If Not ClsConsultation.UpdateIsCompleted(ClsConsultation, DbConn, DbTrans) Then
                    MsgBox("Failed to update consultation completion.", MsgBoxStyle.Critical, "Failed to Update Completion")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                DbTrans.Commit()
                DbTrans.Dispose()
                DbTrans = Nothing

                MsgBox("Your consultation has been successfully completed.", MsgBoxStyle.Information, "Consultation Completed")

                CbIsCompleted.Checked = True
                CbIsCompleted.Enabled = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".IsConsultationCompleted()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub SearchItem()

        Try
            With FrmSearchItem
                .ShowDialog()
                TxtItem.Text = .ItemDescription
                TxtItem.Tag = .ItemCode
                TxtUnitPrice.Text = .Price
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnSearchItem_Click")
        End Try

    End Sub

    Private Sub AddBillItem()

        Dim DtBill As New DataTable
        Dim BtnDeleteItem As New DataGridViewButtonColumn

        Try
            DtBill = InitBillItemDt()
            If DgvBillListing.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvBillListing.Rows.Count - 1

                    Dim DgvRow As DataRow = DtBill.NewRow

                    DgvRow("RowNo") = DgvBillListing.Rows(i).Cells("RowNo").Value
                    DgvRow("ItemCode") = DgvBillListing.Rows(i).Cells("ItemCodeDgv").Value
                    DgvRow("ItemDescription") = DgvBillListing.Rows(i).Cells("ItemDescription").Value
                    DgvRow("Prescription") = DgvBillListing.Rows(i).Cells("Prescription").Value
                    DgvRow("Notes") = DgvBillListing.Rows(i).Cells("Notes").Value
                    DgvRow("Quantity") = DgvBillListing.Rows(i).Cells("Quantity").Value
                    DgvRow("UnitPrice") = DgvBillListing.Rows(i).Cells("UnitPrice").Value
                    DgvRow("Discount") = DgvBillListing.Rows(i).Cells("Discount").Value
                    DgvRow("TotalPrice") = DgvBillListing.Rows(i).Cells("TotalPrice").Value

                    DtBill.Rows.Add(DgvRow)

                Next

            End If

            'Take pet information from fields, e.g. textboxes
            Dim Row As DataRow = DtBill.NewRow

            Row("RowNo") = IIf(DtBill.Rows.Count = 0, 1, DtBill.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtItem.Text))
            Row("Prescription") = UCase(Trim(TxtPrescription.Text))
            Row("Notes") = UCase(Trim(TxtNotes.Text))
            Row("Quantity") = UCase(Trim(TxtQuantity.Text))
            Row("UnitPrice") = UCase(Trim(TxtUnitPrice.Text))
            Row("Discount") = UCase(Trim(TxtDiscount.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtUnitPrice.Text) * CDec(TxtQuantity.Text), 2)

            DtBill.Rows.Add(Row)

            Dim GrossTotal As Decimal
            Dim Discount As Decimal
            Dim Deposit As Decimal
            Dim GrandTotal As Decimal
            Dim TotalDue As Decimal

            If DtBill.Rows.Count > 0 Then

                DgvBillListing.Rows.Clear()

                For i As Integer = 0 To DtBill.Rows.Count - 1
                    With DgvBillListing
                        .Rows.Add()
                        .Rows(i).Cells("RowNo").Value = DtBill.Rows(i).Item("RowNo")
                        .Rows(i).Cells("ItemCodeDgv").Value = DtBill.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("ItemDescription").Value = DtBill.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("Prescription").Value = DtBill.Rows(i).Item("Prescription")
                        .Rows(i).Cells("Notes").Value = DtBill.Rows(i).Item("Notes")
                        .Rows(i).Cells("Quantity").Value = DtBill.Rows(i).Item("Quantity")
                        .Rows(i).Cells("UnitPrice").Value = DtBill.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("Discount").Value = DtBill.Rows(i).Item("Discount")
                        .Rows(i).Cells("TotalPrice").Value = DtBill.Rows(i).Item("TotalPrice")
                    End With

                    GrossTotal = GrossTotal + DtBill.Rows(i).Item("TotalPrice")
                    Discount = Discount + DtBill.Rows(i).Item("Discount")
                    TotalDue = GrandTotal - Discount - Deposit

                Next

                GrandTotal = GrossTotal - Discount
                TotalDue = GrandTotal - Deposit

                TxtGrossTotal.Text = FormatNumber(GrossTotal, 2)
                TxtDiscount.Text = FormatNumber(Discount, 2)
                TxtGrandTotal.Text = FormatNumber(GrandTotal, 2)
                TxtTotalDue.Text = FormatNumber(TotalDue, 2)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddBillItem()")
        End Try

    End Sub

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

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim Frm As New FrmVisitReport
        With Frm
            .ConsultationID = TxtVisitID.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveConsultationToDb()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

    End Sub

    Private Sub BtnAddPetIssues_Click(sender As Object, e As EventArgs) Handles BtnAddPetIssues.Click
        AddUpdatePetIssues()
    End Sub

    Private Sub CbIsCompleted_Click(sender As Object, e As EventArgs) Handles CbIsCompleted.Click
        If Not IsConsultationCompleted() Then Exit Sub
    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        SearchItem()
    End Sub

    Private Sub BtnAddBillItem_Click(sender As Object, e As EventArgs) Handles BtnAddBillItem.Click
        AddBillItem()
    End Sub

    Private Sub TxtQuantity_KeyDown(sender As Object, e As EventArgs) Handles TxtQuantity.KeyDown

        Try
            'If Trim(TxtQuantity.Text) <> "" Then

            '    If Not IsNumeric(Trim(TxtQuantity.Text)) Then
            '        MsgBox("Please enter numeric character.", MsgBoxStyle.Exclamation, "Non-Numeric Character Input Detected")

            '        Dim LastIndex As Integer
            '        For i As Integer = 0 To TxtQuantity.Text.Length - 1
            '            LastIndex += 1
            '        Next

            '        Dim StrQuantity As String = TxtQuantity.Text
            '        TxtQuantity.Text = FormatNumber(StrQuantity.Replace(StrQuantity.Chars(LastIndex - 1), ""), 2)

            '    End If

            '    TxtQuantity.Text = FormatNumber(CDec(TxtQuantity.Text), 2)

            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtQuantity_TextChanged()")
        End Try

    End Sub

    Private Sub TxtQuantity_Leave(sender As Object, e As EventArgs) Handles TxtQuantity.Leave

        Try
            If Trim(TxtQuantity.Text) = "" Then
                TxtQuantity.Text = FormatNumber(0, 2)
            Else
                If Not IsNumeric(Trim(TxtQuantity.Text)) Then
                    MsgBox("Please enter numeric character.", MsgBoxStyle.Exclamation, "Non-Numeric Character Input Detected")
                    TxtQuantity.Text = FormatNumber(0, 2)
                End If
                TxtQuantity.Text = FormatNumber(CDec(TxtQuantity.Text), 2)
                TxtTotalPrice.Text = FormatNumber((CDec(TxtUnitPrice.Text) * CDec(TxtQuantity.Text)) - CDec(TxtDiscount.Text), 2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtQuantity_Leave()")
        End Try

    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged

        Try
            'If Trim(TxtDiscount.Text) <> "" Then
            '    If Not IsNumeric(Trim(TxtDiscount.Text)) Then
            '        MsgBox("Please enter numeric character.", MsgBoxStyle.Exclamation, "Non-Numeric Character Input Detected")

            '        Dim LastIndex As Integer
            '        For i As Integer = 0 To TxtDiscount.Text.Length - 1
            '            LastIndex += 1
            '        Next

            '        Dim StrDiscount As String = TxtDiscount.Text
            '        TxtDiscount.Text = FormatNumber(StrDiscount.Replace(StrDiscount.Chars(LastIndex - 1), ""), 2)

            '    End If

            '    TxtDiscount.Text = FormatNumber(CDec(TxtDiscount.Text), 2)

            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDiscount_TextChanged()")
        End Try

    End Sub

    Private Sub TxtDiscount_Leave(sender As Object, e As EventArgs) Handles TxtDiscount.Leave

        Try
            If Trim(TxtDiscount.Text) = "" Then
                TxtDiscount.Text = FormatNumber(0, 2)
            Else
                If Not IsNumeric(Trim(TxtDiscount.Text)) Then
                    MsgBox("Please enter numeric character.", MsgBoxStyle.Exclamation, "Non-Numeric Character Input Detected")
                    TxtDiscount.Text = FormatNumber(0, 2)
                End If
                TxtDiscount.Text = FormatNumber(CDec(TxtDiscount.Text), 2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDiscount_Leave()")
        End Try

    End Sub

    Private Sub DgvBillListing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBillListing.CellContentClick

        Dim BtnDeletePet As New DataGridViewButtonColumn
        Dim BtnEditPet As New DataGridViewButtonColumn
        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Edit' button
                UserResponse = MsgBox("Are sure you want to delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Item?")
                If UserResponse = MsgBoxResult.Yes Then

                    With DgvBillListing

                        For Each Row As DataGridViewRow In .SelectedRows

                            If .Rows(e.RowIndex).Cells("RowNo").Value = e.RowIndex + 1 Then
                                .Rows.Remove(Row)
                            End If

                        Next

                        If .Rows.Count = 0 Then
                            .DataSource = Nothing
                            '.Columns.Clear()
                            .Show()
                        End If

                    End With

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvBillListing_CellContentClick()")
        End Try

    End Sub

    Private Sub BtnClearBill_Click(sender As Object, e As EventArgs) Handles BtnClearBill.Click

        Dim UserResponse As MsgBoxResult

        Try
            UserResponse = MsgBox("Are sure you want to DELETE ALL of this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete All Items?")
            If UserResponse = MsgBoxResult.Yes Then
                With DgvBillListing
                    .Rows.Clear()
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnClearBill_Click()")
        End Try

    End Sub

    Private Sub TxtDeposit_TextChanged(sender As Object, e As EventArgs) Handles TxtDeposit.TextChanged

        Try
            TxtTotalDue.Text = FormatNumber(CDec(TxtGrandTotal.Text) - CDec(TxtDeposit.Text), 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDeposit_TextChanged()")
        End Try

    End Sub

    Private Sub BtnGenerateBill_Click(sender As Object, e As EventArgs) Handles BtnGenerateBill.Click
        GenerateBill()
    End Sub

    Private Sub GenerateBill()

        Dim DtBill As New DataTable
        Dim ClsBill As New ClsBill

        Try
            'Check if bill already created
            ClsBill.VisitID = TxtVisitID.Text
            DtBill = ClsBill.CheckExistingBill(ClsBill)

            With FrmPaymentEntry
                .VisitID = TxtVisitID.Text
                .CustomerID = TxtCustomerID.Text
                .CustomerName = TxtCustomerName.Text
                .InvoiceNo = TxtVisitID.Tag
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDeposit_TextChanged()")
        End Try

    End Sub

End Class