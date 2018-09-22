Public Class FrmItemEntry

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private Sub FrmItemEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateItemType()
        PopulateForm(UserCommand)
    End Sub

    Private Sub PopulateForm(UserCommand As String)

        Try
            If UserCommand <> "" Then

                If UserCommand = "SHOW_ITEM_INFO" Then

                    Select Case ItemType
                        Case "SVC"

                            DtServices = ClsServices.GetServiceInformation(ClsServices)
                            RbServices.Checked = True
                            CmbItemType.SelectedValue = ItemTypeCode
                            TxtItemCode.Text = ItemCode
                            TxtItemDescription.Text = ItemDescription
                            TxtPrice.Text = Price
                            TxtCreatedBy.Text = ""
                            TxtDateCreated.Text = ""
                            TxtModifiedBy.Text = ""
                            TxtDateModified.Text = ""

                        Case "PRD"


                    End Select

                    'Get customer and pet information from database
                    ClsCustomer = New ClsCustomer
                    With ClsCustomer
                        .CustomerID = CustomerID
                    End With

                    ClsPet = New ClsPet
                    With ClsPet
                        .CustomerID = CustomerID
                    End With

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
                        TxtCreatedBy.Text = DtCustomer.Rows(0).Item("CreatedBy")
                        TxtDateCreated.Text = DtCustomer.Rows(0).Item("DateCreated")
                        TxtModifiedBy.Text = DtCustomer.Rows(0).Item("ModifiedBy")
                        TxtDateModified.Text = DtCustomer.Rows(0).Item("DateModified")

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

                            With BtnEdit
                                .HeaderText = "Edit"
                                .Text = "Edit"
                                .Name = "BtnEdit"
                                .UseColumnTextForButtonValue = True
                                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                                .DisplayIndex = 0
                            End With

                            With BtnDelete
                                .HeaderText = "Delete"
                                .Text = "Delete"
                                .Name = "BtnDelete"
                                .UseColumnTextForButtonValue = True
                                .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                                .DisplayIndex = 1
                            End With

                            'Add IsDB indicator here
                            With DtPet
                                .Columns.Add("IsDB", GetType(String))
                                .Columns.Add("CustomerName", GetType(String)).SetOrdinal(1)
                            End With

                            For i As Integer = 0 To DtPet.Rows.Count - 1
                                DtPet.Rows(i).Item("IsDb") = "1"
                                DtPet.Rows(i).Item("CustomerName") = DtCustomer.Rows(0).Item("CustomerName")
                            Next

                            With DgvPetListing
                                .Columns.Add(BtnEdit)
                                .Columns.Add(BtnDelete)
                                .DataSource = DtPet
                                .Columns("IsDB").Visible = False
                                .Show()
                            End With

                        End If

                    End If

                    SetFields(UserCommand)

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveItemToDb()
    End Sub

    Private Sub SaveItemToDb()

        Try
            If Not CheckUserInput(UserCommand) Then Exit Sub
            If Not AddNewItem() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveItemToDb()")
        End Try

    End Sub

    Private Function CheckUserInput(UserCommand As String) As Boolean

        Try

        Catch ex As Exception

        End Try

        Return True

    End Function

    Private Function AddNewItem() As Boolean

        Dim ItemCode As String = ""
        Dim ItemType As String = ""
        Dim ItemTypeCode As String = ""
        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If RbServices.Checked = True Then
                ItemType = "SVC"
            ElseIf RbProducts.Checked = True Then
                ItemType = "PRD"
            End If

            ItemTypeCode = DirectCast(CmbItemType.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
            ItemCode = GenerateItemRunningNo(ItemTypeCode, ItemType, DbConn, DbTrans)

            If ItemCode = "" Then
                MsgBox("Failed to generated item code.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewItem()")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            Select Case ItemType
                Case "SVC"
                    If Not AddNewService(ItemType, ItemTypeCode, ItemCode, DbConn, DbTrans) Then
                        MsgBox("Failed to add new service.", MsgBoxStyle.Critical, "Add New Service Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Case "PRD"

            End Select

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewItem()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function AddNewService(ItemType As String, ItemTypeCode As String, ItemCode As String, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim ClsServices As New ClsServices

        Try
            ClsServices = New ClsServices
            With ClsServices
                .ItemType = ItemType
                .ItemTypeCode = ItemTypeCode
                .ItemCode = ItemCode
                .ItemDescription = UCase(Trim(TxtItemDescription.Text))
                .Price = CDec(Trim(TxtPrice.Text))
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsServices.AddNewService(ClsServices, DbConn, DbTrans) Then Return False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewService()")
            Return False
        End Try

        Return True

    End Function

    Private Function AddNewProduct() As Boolean

        Try

        Catch ex As Exception

        End Try

    End Function

    Private Sub PopulateItemType()

        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts
        Dim DtItem As New DataTable
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbServices.Checked = True Then
                DtItem = ClsServices.GetServiceTypeList(ClsServices)

            ElseIf RbProducts.Checked = True Then
                DtItem = ClsProducts.GetProductTypeList(ClsProducts)

            End If

            If DtItem.Rows.Count > 0 Then
                For i As Integer = 0 To DtItem.Rows.Count - 1
                    CmbSource.Add(DtItem.Rows(i).Item("ItemTypeCode"), DtItem.Rows(i).Item("ItemTypeDescription"))
                Next
            End If

            If CmbItemType.Items.Count > 0 Then
                CmbItemType.DataSource = Nothing
                CmbItemType.Items.Clear()
            End If

            CmbItemType.DataSource = New BindingSource(CmbSource, Nothing)
            CmbItemType.DisplayMember = "Value"
            CmbItemType.ValueMember = "Key"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateItemType()")
        End Try

    End Sub

    Private Sub RbServices_Click(sender As Object, e As EventArgs) Handles RbServices.Click

        Dim ClsServices As New ClsServices
        Dim DtItem As New DataTable
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbServices.Checked = True Then

                DtItem = ClsServices.GetServiceTypeList(ClsServices)
                If DtItem.Rows.Count > 0 Then
                    For i As Integer = 0 To DtItem.Rows.Count - 1
                        CmbSource.Add(DtItem.Rows(i).Item("ItemTypeCode"), DtItem.Rows(i).Item("ItemTypeDescription"))
                    Next
                End If

                If CmbItemType.Items.Count > 0 Then
                    CmbItemType.DataSource = Nothing
                    CmbItemType.Items.Clear()
                End If

                CmbItemType.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemType.DisplayMember = "Value"
                CmbItemType.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".RbServices_Click()")
        End Try

    End Sub

    Private Sub RbProducts_Click(sender As Object, e As EventArgs) Handles RbProducts.Click

        Dim ClsProducts As New ClsProducts
        Dim DtItem As New DataTable
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbProducts.Checked = True Then

                DtItem = ClsProducts.GetProductTypeList(ClsProducts)
                If DtItem.Rows.Count > 0 Then
                    For i As Integer = 0 To DtItem.Rows.Count - 1
                        CmbSource.Add(DtItem.Rows(i).Item("ItemTypeCode"), DtItem.Rows(i).Item("ItemTypeDescription"))
                    Next
                End If

                If CmbItemType.Items.Count > 0 Then
                    CmbItemType.DataSource = Nothing
                    CmbItemType.Items.Clear()
                End If

                CmbItemType.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemType.DisplayMember = "Value"
                CmbItemType.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".RbProducts_Click()")
        End Try

    End Sub

End Class