Imports SAMCVetSys.ModUtility

Public Class FrmPaymentInformation

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

    Private _InvoiceNo As String
    Public Property InvoiceNo As String
        Get
            Return _InvoiceNo
        End Get
        Set(value As String)
            _InvoiceNo = value
        End Set
    End Property

    Private _InvoiceDate As Date
    Public Property InvoiceDate As Date
        Get
            Return _InvoiceDate
        End Get
        Set(value As Date)
            _InvoiceDate = value
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

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
        End Set
    End Property

    Private _CustomerName As String
    Public Property CustomerName As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
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

    Private _IsShowBtnSearch As Boolean
    Public Property IsShowBtnSearch As Boolean
        Get
            Return _IsShowBtnSearch
        End Get
        Set(value As Boolean)
            _IsShowBtnSearch = value
        End Set
    End Property

#End Region

    Private Sub FrmPaymentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateForm(UserCommand)
        'Me.Text = IIf(FormTitle <> "", FormTitle, Me.Text)
    End Sub

    Private Sub PopulateForm(UserCommand As String)

        Dim DtBill As New DataTable
        Dim ClsBill As New ClsBill

        Try
            If InvoiceNo <> "" Then

                With ClsBill
                    .InvoiceNo = InvoiceNo
                End With

                DtBill = ClsBill.GetBillingInfo(ClsBill)
                If DtBill.Rows.Count > 0 Then

                    'Clear previous information that has been populated into the data grid view; to reload new information
                    If DgvBillListing.Rows.Count > 0 Then
                        DgvBillListing.Rows.Clear()
                    End If

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
                            .Rows(i).Cells("TotalPrice").Value = DtBill.Rows(i).Item("TotalPrice")
                            .Rows(i).Cells("ItemGroupDgv").Value = DtBill.Rows(i).Item("ItemGroup")
                            .Rows(i).Cells("ItemTypeDescriptionDgv").Value = DtBill.Rows(i).Item("ItemTypeDescription")
                            .Rows(i).Cells("ItemTypeCodeDgv").Value = DtBill.Rows(i).Item("ItemTypeCode")
                            .Rows(i).Cells("ChSource").Value = DtBill.Rows(i).Item("ChSource")
                            .Rows(i).Cells("ChSourceName").Value = DtBill.Rows(i).Item("ChSourceName")
                        End With
                    Next

                    TxtInvoiceNo.Text = DtBill.Rows(0).Item("InvoiceNo")
                    TxtVisitID.Text = DtBill.Rows(0).Item("VisitID")
                    'TxtGrossTotal.Text = DtBill.Rows(0).Item("GrossTotal")
                    TxtDiscount.Text = DtBill.Rows(0).Item("Discount")
                    TxtGrandTotal.Text = DtBill.Rows(0).Item("GrandTotal")
                    TxtDeposit.Text = DtBill.Rows(0).Item("Deposit")
                    TxtTotalDue.Text = DtBill.Rows(0).Item("TotalDue")

                    'Customer Information
                    TxtCustomerName.Text = CStrNull(DtBill.Rows(0).Item("CustomerName"))
                    TxtCustomerName.Tag = CStrNull(DtBill.Rows(0).Item("CustomerID"))
                    TxtPetName.Text = CStrNull(DtBill.Rows(0).Item("PetName"))
                    TxtPetName.Tag = CStrNull(DtBill.Rows(0).Item("PetID"))

                    'Payment Status
                    CbPaymentCompleted.Checked = IIf(DtBill.Rows(0).Item("IsPaymentComplete") = "1", True, False)

                    'Payment Type
                    CbCash.Checked = IIf(DtBill.Rows(0).Item("IsCash") = "1", True, False)
                    CbDebitCreditCard.Checked = IIf(DtBill.Rows(0).Item("IsDebitCreditCard") = "1", True, False)
                    CbCheque.Checked = IIf(DtBill.Rows(0).Item("IsCheque") = "1", True, False)

                    TxtCreatedBy.Text = DtBill.Rows(0).Item("CreatedBy")
                    TxtDateCreated.Text = DtBill.Rows(0).Item("DateCreated")
                    TxtModifiedBy.Text = DtBill.Rows(0).Item("ModifiedBy")
                    TxtDateModified.Text = DtBill.Rows(0).Item("DateModified")

                End If

                SetFields(UserCommand)
                BtnSearch.Visible = IIf(IsShowBtnSearch = True, True, False)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub SearchItem()

        Try
            With FrmSearchItem
                .ShowDialog()
                TxtItem.Text = .ItemDescription
                TxtItem.Tag = .ItemCode
                TxtUnitPrice.Text = .UnitPrice
                ItemGroup = .ItemGroup
                ItemTypeCode = .ItemTypeCode
                ItemTypeDescription = .ItemTypeDescription
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnSearchItem_Click")
        End Try

    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        SearchItem()
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
                'TxtTotalPrice.Text = FormatNumber((CDec(TxtUnitPrice.Text) * CDec(TxtQuantity.Text)) - CDec(TxtDiscount.Text), 2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtQuantity_Leave()")
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

                    If CbPaymentCompleted.Checked = True And CbPaymentCompleted.Enabled = False Then

                        'Do nothing if payment is already completed; disable user from deleting items from bill that has been completed e.g. payment completed.
                        Exit Sub
                    Else

                        With DgvBillListing

                            Dim RowIndex As Integer = .Rows(e.RowIndex).Cells("RowNo").Value

                            .Rows.RemoveAt(e.RowIndex)

                            If TxtInvoiceNo.Text <> "" Then

                                If Not DeleteBillItems(RowIndex, TxtInvoiceNo.Text) Then
                                    MsgBox("Failed to delete bill's items(s). Please try again.", MsgBoxStyle.Critical, "Delete Bill Item(s)")
                                End If

                            End If

                            'Re-populate bill items
                            PopulateForm("SHOW_BILLING_INFO")

                            If .Rows.Count = 0 Then
                                .DataSource = Nothing
                                .Show()
                            End If

                        End With
                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvBillListing_CellContentClick()")
        End Try

    End Sub

    Private Function DeleteBillItems(RowNo As Integer, InvoiceNo As String) As Boolean

        Dim ClsBill As New ClsBill
        Dim ClsBillDetail As New ClsBillDetail

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            With ClsBillDetail
                .InvoiceNo = InvoiceNo
                .RowNo = RowNo
            End With

            If Not ClsBillDetail.DeleteBillItems(ClsBillDetail, DbConn, DbTrans) Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Update RowNo in billing items
            Dim GrandTotal As Decimal
            Dim Deposit As Decimal
            Dim Discount As Decimal

            For i As Integer = 0 To DgvBillListing.Rows.Count - 1

                With ClsBillDetail
                    .InvoiceNo = InvoiceNo
                    .RowNo = DgvBillListing.Rows(i).Cells("RowNo").Value
                    .NewRowNo = i + 1

                    If Not ClsBillDetail.UpdateBillRowNo(ClsBillDetail, DbConn, DbTrans) Then
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                End With

                'Recalculate billing amount
                GrandTotal = GrandTotal + DgvBillListing.Rows(i).Cells("TotalPrice").Value

            Next

            Deposit = TxtDeposit.Text
            Discount = TxtDiscount.Text

            'Update grand total amount in the database
            With ClsBill
                .InvoiceNo = InvoiceNo
                .GrandTotal = GrandTotal
                .Deposit = Deposit
                .Discount = Discount
                .TotalDue = (GrandTotal - Deposit) - Discount

                If Not .UpdateBillingAmount(ClsBill, DbConn, DbTrans) Then
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If
            End With

            'TxtGrandTotal.Text = FormatNumber(GrandTotal, 2)

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            MsgBox("Item(s) has been successfully removed.", MsgBoxStyle.Information, "Item(s) Deleted")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DeleteBillItems()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub BtnClearBill_Click(sender As Object, e As EventArgs) Handles BtnClearBill.Click

        Dim UserResponse As MsgBoxResult

        Try
            If TxtInvoiceNo.Text <> "" Then
                Exit Sub
            End If

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





    Private Sub BtnAddBillItem_Click(sender As Object, e As EventArgs) Handles BtnAddBillItem.Click
        AddBillItem()
    End Sub

    Private Sub AddBillItem()

        Dim DtBill As New DataTable
        Dim BtnDeleteItem As New DataGridViewButtonColumn

        Try
            If TxtItem.Tag = "" Then
                Exit Sub
            End If

            DtBill = InitBillItemDt()
            If DgvBillListing.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvBillListing.Rows.Count - 1

                    Dim DgvRow As DataRow = DtBill.NewRow

                    DgvRow("RowNo") = DgvBillListing.Rows(i).Cells("RowNo").Value
                    DgvRow("ItemCode") = DgvBillListing.Rows(i).Cells("ItemCodeDgv").Value
                    DgvRow("ItemDescription") = DgvBillListing.Rows(i).Cells("ItemDescription").Value

                    DgvRow("ItemGroup") = DgvBillListing.Rows(i).Cells("ItemGroupDgv").Value
                    DgvRow("ItemTypeCode") = DgvBillListing.Rows(i).Cells("ItemTypeCodeDgv").Value
                    DgvRow("ItemTypeDescription") = DgvBillListing.Rows(i).Cells("ItemTypeDescriptionDgv").Value

                    DgvRow("Prescription") = DgvBillListing.Rows(i).Cells("Prescription").Value
                    DgvRow("Notes") = DgvBillListing.Rows(i).Cells("Notes").Value
                    DgvRow("UnitPrice") = DgvBillListing.Rows(i).Cells("UnitPrice").Value
                    DgvRow("Quantity") = DgvBillListing.Rows(i).Cells("Quantity").Value
                    DgvRow("TotalPrice") = DgvBillListing.Rows(i).Cells("TotalPrice").Value

                    DtBill.Rows.Add(DgvRow)

                Next

            End If

            'Take pet information from fields, e.g. textboxes
            Dim Row As DataRow = DtBill.NewRow

            Row("RowNo") = IIf(DtBill.Rows.Count = 0, 1, DtBill.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtItem.Text))

            Row("ItemGroup") = ItemGroup 'DgvBillListing.Rows(i).Cells("ItemGroup").Value
            Row("ItemTypeCode") = ItemTypeCode 'DgvBillListing.Rows(i).Cells("ItemTypeCode").Value
            Row("ItemTypeDescription") = ItemTypeDescription 'DgvBillListing.Rows(i).Cells("ItemTypeDescription").Value

            Row("Prescription") = UCase(Trim(TxtPrescription.Text))
            Row("Notes") = UCase(Trim(TxtNotes.Text))
            Row("UnitPrice") = UCase(Trim(TxtUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtQuantity.Text))
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
                        .Rows(i).Cells("UnitPrice").Value = DtBill.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("Quantity").Value = DtBill.Rows(i).Item("Quantity")
                        '.Rows(i).Cells("ItemDiscount").Value = DtBill.Rows(i).Item("ItemDiscount")
                        .Rows(i).Cells("TotalPrice").Value = DtBill.Rows(i).Item("TotalPrice")

                        .Rows(i).Cells("ItemGroupDgv").Value = DtBill.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("ItemTypeCodeDgv").Value = DtBill.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("ItemTypeDescriptionDgv").Value = DtBill.Rows(i).Item("ItemTypeDescription")
                    End With

                    GrossTotal = GrossTotal + DtBill.Rows(i).Item("TotalPrice")
                    'Discount = Discount + DtBill.Rows(i).Item("ItemDiscount")
                    TotalDue = GrandTotal - Discount - Deposit

                Next

                GrandTotal = GrossTotal - Discount
                TotalDue = GrandTotal - Deposit

                TxtGrossTotal.Text = FormatNumber(GrossTotal, 2)
                TxtDiscount.Text = FormatNumber(Discount, 2)
                TxtGrandTotal.Text = FormatNumber(GrandTotal, 2)
                TxtTotalDue.Text = FormatNumber(TotalDue, 2)

            End If

            SetFields("ADD_ITEM")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddBillItem()")
        End Try

    End Sub

    Private Sub SetFields(UserCommand As String)

        Select Case UserCommand
            Case "ADD_ITEM"
                TxtItem.Tag = ""
                TxtItem.Text = ""
                TxtPrescription.Text = ""
                TxtNotes.Text = ""
                TxtQuantity.Text = "1.00"
                TxtUnitPrice.Text = "0.00"
                'TxtDiscount.Text = "0.00"
                TxtTotalPrice.Text = "0.00"

        End Select

    End Sub

    Private Function InitBillItemDt() As DataTable

        Dim DtBill As New DataTable

        Try
            'Initialize datatable
            With DtBill
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
                .Columns.Add("ChSource", GetType(String))
                .Columns.Add("ChSourceName", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitBillItemDt()")
        End Try

        Return DtBill

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CreateBillPayment() Then Exit Sub
    End Sub

    Private Function CreateBillPayment() As Boolean

        Dim GenInvoiceNo As String = ""
        Dim ClsBill As New ClsBill
        Dim ClsBillDetail As New ClsBillDetail

        Try
            'Get customer information
            Dim DtCustomer As New DataTable
            Dim ClsCustomer As New ClsCustomer
            With ClsCustomer
                .CustomerID = CustomerID
                DtCustomer = .GetCustomerInformation(ClsCustomer)
            End With

            'Create Invoice No.
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If Trim(TxtInvoiceNo.Text) <> "" Then
                GenInvoiceNo = Trim(TxtInvoiceNo.Text)
            ElseIf InvoiceNo <> "" Then
                GenInvoiceNo = InvoiceNo
            Else
                If DgvBillListing.Rows.Count > 0 Then
                    GenInvoiceNo = GenerateRunningNo("INV", DbConn, DbTrans)
                Else
                    MsgBox("You are not allow to create billing without item(s).", MsgBoxStyle.Exclamation, "No Bill Item(s) Detected")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    Return False
                End If
            End If

            'Delete existing invoice
            ClsBill = New ClsBill
            With ClsBill
                .InvoiceNo = GenInvoiceNo
                If Not .DeleteBill(ClsBill, DbConn, DbTrans) Then
                    MsgBox("Failed to update bill item(s) entry.", MsgBoxStyle.Exclamation, "Bill Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    Return False
                End If
            End With

            'Create bill header
            TxtInvoiceNo.Tag = GenInvoiceNo
            If GenInvoiceNo = "" Then
                If GenInvoiceNo = "" Then
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    Return False
                End If
            End If

            If DgvBillListing.Rows.Count > 0 Then

                ClsBill = New ClsBill
                With ClsBill
                    .InvoiceNo = GenInvoiceNo
                    .VisitID = VisitID
                    .InvoiceDate = IIf(InvoiceDate <> Nothing, InvoiceDate, Now) 'Now
                    .CustomerID = TxtCustomerName.Tag 'CustomerID
                    .CustomerName = TxtCustomerName.Text 'CustomerName
                    .MobileNo = DtCustomer.Rows(0).Item("MobileNo")
                    .Email = DtCustomer.Rows(0).Item("Email")
                    .PetID = TxtPetName.Tag
                    .PetName = TxtPetName.Text
                    .GrandTotal = CDec(TxtGrandTotal.Text)
                    .Deposit = CDec(TxtDeposit.Text)
                    '.GrossTotal = CDec(TxtGrossTotal.Text)
                    .Discount = CDec(TxtDiscount.Text)
                    .TotalDue = CDec(TxtTotalDue.Text)
                    .IsPaymentComplete = IIf(CbPaymentCompleted.Checked = True, "1", "0")
                    .IsCash = IIf(CbCash.Checked = True, "1", "0")
                    .IsDebitCreditCard = IIf(CbDebitCreditCard.Checked = True, "1", "0")
                    .IsCheque = IIf(CbCheque.Checked = True, "1", "0")
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = IIf(TxtDateCreated.Text <> "", TxtDateCreated.Text, Now)
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
                End With

                If Not ClsBill.AddNewBill(ClsBill, DbConn, DbTrans) Then
                    MsgBox("Failed to create bill header.", MsgBoxStyle.Critical, "Create Bill Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Create bill details
                For i As Integer = 0 To DgvBillListing.Rows.Count - 1

                    ClsBillDetail = New ClsBillDetail
                    With ClsBillDetail
                        .InvoiceNo = GenInvoiceNo
                        .RowNo = DgvBillListing.Rows(i).Cells("RowNo").Value
                        .ItemCode = DgvBillListing.Rows(i).Cells("ItemCodeDgv").Value
                        .ItemDescription = DgvBillListing.Rows(i).Cells("ItemDescription").Value
                        .ItemGroup = CStrNull(DgvBillListing.Rows(i).Cells("ItemGroupDgv").Value)
                        .ItemTypeDescription = CStrNull(DgvBillListing.Rows(i).Cells("ItemTypeDescriptionDgv").Value)
                        .ItemTypeCode = CStrNull(IIf(DgvBillListing.Rows(i).Cells("ItemGroupDgv").Value = "SVC",
                                                     DgvBillListing.Rows(i).Cells("ItemCodeDgv").Value.ToString.Substring(0, 3),
                                                     DgvBillListing.Rows(i).Cells("ItemCodeDgv").Value.ToString.Substring(0, 4)))
                        .Prescription = CStrNull(DgvBillListing.Rows(i).Cells("Prescription").Value)
                        .Notes = CStrNull(DgvBillListing.Rows(i).Cells("Notes").Value)
                        .Quantity = DgvBillListing.Rows(i).Cells("Quantity").Value
                        .UnitPrice = DgvBillListing.Rows(i).Cells("UnitPrice").Value
                        .ItemDiscount = DgvBillListing.Rows(i).Cells("ItemDiscount").Value
                        .TotalPrice = DgvBillListing.Rows(i).Cells("TotalPrice").Value
                        .ChSource = DgvBillListing.Rows(i).Cells("ChSource").Value
                        .ChSourceName = DgvBillListing.Rows(i).Cells("ChSourceName").Value
                    End With

                    If Not ClsBillDetail.AddNewBillDetail(ClsBillDetail, DbConn, DbTrans) Then
                        MsgBox("Failed to create consultation details.", MsgBoxStyle.Critical, "Create Billing Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Next

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            TxtInvoiceNo.Text = GenInvoiceNo

            With ClsBill
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            'SetFields(UserCommand)

            MsgBox("Invoice has been successfully created!", MsgBoxStyle.Information, "Invoice Created")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CreateBill()")
            If DbTrans IsNot Nothing Then
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
            End If
            Return False
        End Try

        Return True

    End Function

    Private Function CalculateBillPayment() As Boolean

        Try
            'Get charges source; specified charges source
            Dim ClsChSource As New ClsChSource
            Dim DtChSource As New DataTable

            With ClsChSource
                DtChSource = .GetChSource(ClsChSource)
                If DtChSource.Rows.Count = 0 Then
                    MsgBox("Failed to initiate charge sources.", MsgBoxStyle.Critical, "Charge Sources Initiation Error")
                    Return False
                End If
            End With

            'Get items by VisitID from:
            'samc_visitcharges, samc_diagnosis, samc_treatment, samc_ward, samc_warddetail, samc_warddiagnosis, samc_warddiagnosisdetail, samc_wardtreatment

            'If re-calculate is checked then clear bill items
            If CbIsRecalculate.Checked = True Then
                If DgvBillListing.Rows.Count > 0 Then
                    DgvBillListing.Rows.Clear()
                End If
            End If

            Dim DtBill As New DataTable
            DtBill = InitBillItemDt()

            'Visit charges
            Dim DtVisitCharges As New DataTable
            Dim ClsVisitCharges As New ClsVisitCharges
            With ClsVisitCharges
                .VisitID = Trim(TxtVisitID.Text)
                DtVisitCharges = .GetVisitCharges(ClsVisitCharges)

                Dim VisitChSource As String = ""
                Dim VisitChSourceName As String = ""

                For i As Integer = 0 To DtChSource.Rows.Count - 1
                    If DtChSource.Rows(i).Item("ChSource") = "1" Then ' 1 = VISIT
                        VisitChSource = DtChSource.Rows(i).Item("ChSource")
                        VisitChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                        Exit For
                    End If
                Next

                If DtVisitCharges.Rows.Count > 0 Then
                    For i As Integer = 0 To DtVisitCharges.Rows.Count - 1
                        With DtBill
                            Dim VisitChargesRow As DataRow = DtBill.NewRow

                            VisitChargesRow("RowNo") = DtVisitCharges.Rows(i).Item("RowNo")
                            VisitChargesRow("ItemCode") = DtVisitCharges.Rows(i).Item("ItemCode")
                            VisitChargesRow("ItemDescription") = DtVisitCharges.Rows(i).Item("ItemDescription")
                            VisitChargesRow("ItemGroup") = DtVisitCharges.Rows(i).Item("ItemGroup")
                            VisitChargesRow("ItemTypeCode") = DtVisitCharges.Rows(i).Item("ItemTypeCode")
                            VisitChargesRow("ItemTypeDescription") = DtVisitCharges.Rows(i).Item("ItemTypeDescription")
                            VisitChargesRow("Prescription") = DtVisitCharges.Rows(i).Item("Prescription")
                            VisitChargesRow("Notes") = DtVisitCharges.Rows(i).Item("Notes")
                            VisitChargesRow("UnitPrice") = DtVisitCharges.Rows(i).Item("UnitPrice")
                            VisitChargesRow("Quantity") = DtVisitCharges.Rows(i).Item("Quantity")
                            VisitChargesRow("TotalPrice") = DtVisitCharges.Rows(i).Item("TotalPrice")

                            VisitChargesRow("ChSource") = VisitChSource
                            VisitChargesRow("ChSourceName") = VisitChSourceName

                            DtBill.Rows.Add(VisitChargesRow)

                        End With
                    Next
                End If

            End With

            'Diagnosis (outpatient)
            Dim DtDiagnosis As New DataTable
            Dim ClsDiagnosis As New ClsDiagnosis

            With ClsDiagnosis
                .VisitID = Trim(TxtVisitID.Text)
                DtDiagnosis = ClsDiagnosis.GetDiagnosisDetail(ClsDiagnosis)

                Dim DiagnosisChSource As String = ""
                Dim DiagnosisChSourceName As String = ""

                For i As Integer = 0 To DtChSource.Rows.Count - 1
                    If DtChSource.Rows(i).Item("ChSource") = "2" Then ' 2 = DIAGNOSIS
                        DiagnosisChSource = DtChSource.Rows(i).Item("ChSource")
                        DiagnosisChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                        Exit For
                    End If
                Next

                If DtDiagnosis.Rows.Count > 0 Then
                    For i As Integer = 0 To DtDiagnosis.Rows.Count - 1
                        With DtBill
                            Dim DiagnosisRow As DataRow = DtBill.NewRow

                            DiagnosisRow("RowNo") = DtDiagnosis.Rows(i).Item("RowNo")
                            DiagnosisRow("ItemCode") = DtDiagnosis.Rows(i).Item("ItemCode")
                            DiagnosisRow("ItemDescription") = DtDiagnosis.Rows(i).Item("ItemDescription") '& "***DIAGNOSIS"
                            DiagnosisRow("ItemGroup") = DtDiagnosis.Rows(i).Item("ItemGroup")
                            DiagnosisRow("ItemTypeCode") = DtDiagnosis.Rows(i).Item("ItemTypeCode")
                            DiagnosisRow("ItemTypeDescription") = DtDiagnosis.Rows(i).Item("ItemTypeDescription")
                            DiagnosisRow("Prescription") = "" 'DtDiagnosis.Rows(i).Item("Prescription")
                            DiagnosisRow("Notes") = "" 'DtDiagnosis.Rows(i).Item("Notes")
                            DiagnosisRow("UnitPrice") = DtDiagnosis.Rows(i).Item("UnitPrice")
                            DiagnosisRow("Quantity") = DtDiagnosis.Rows(i).Item("Quantity")
                            DiagnosisRow("TotalPrice") = DtDiagnosis.Rows(i).Item("TotalPrice")

                            DiagnosisRow("ChSource") = DiagnosisChSource
                            DiagnosisRow("ChSourceName") = DiagnosisChSourceName

                            DtBill.Rows.Add(DiagnosisRow)
                        End With
                    Next
                End If
            End With

#Region "Calculate Treatment (Out-Patient)"

            'Treatment
            Dim DtTreatment As New DataTable
            Dim ClsTreatment As New ClsTreatment
            With ClsTreatment
                .VisitID = Trim(TxtVisitID.Text)
                DtTreatment = ClsTreatment.GetTreatmentDetail(ClsTreatment)

                Dim TreatmentChSource As String = ""
                Dim TreatmentChSourceName As String = ""

                For i As Integer = 0 To DtChSource.Rows.Count - 1
                    If DtChSource.Rows(i).Item("ChSource") = "3" Then ' 3 = TREATMENT
                        TreatmentChSource = DtChSource.Rows(i).Item("ChSource")
                        TreatmentChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                        Exit For
                    End If
                Next

                If DtTreatment.Rows.Count > 0 Then
                    For i As Integer = 0 To DtTreatment.Rows.Count - 1
                        With DtBill
                            Dim TreatmentRow As DataRow = DtBill.NewRow

                            TreatmentRow("RowNo") = DtTreatment.Rows(i).Item("RowNo")
                            TreatmentRow("ItemCode") = DtTreatment.Rows(i).Item("ItemCode")
                            TreatmentRow("ItemDescription") = DtTreatment.Rows(i).Item("ItemDescription") ' & "***TREATMENT"
                            TreatmentRow("ItemGroup") = DtTreatment.Rows(i).Item("ItemGroup")
                            TreatmentRow("ItemTypeCode") = DtTreatment.Rows(i).Item("ItemTypeCode")
                            TreatmentRow("ItemTypeDescription") = DtTreatment.Rows(i).Item("ItemTypeDescription")
                            TreatmentRow("Prescription") = DtTreatment.Rows(i).Item("Prescription")
                            TreatmentRow("Notes") = DtTreatment.Rows(i).Item("Notes")
                            TreatmentRow("UnitPrice") = DtTreatment.Rows(i).Item("UnitPrice")
                            TreatmentRow("Quantity") = DtTreatment.Rows(i).Item("Quantity")
                            TreatmentRow("TotalPrice") = DtTreatment.Rows(i).Item("TotalPrice")

                            TreatmentRow("ChSource") = TreatmentChSource 'DtTreatment.Rows(i).Item("TotalPrice")
                            TreatmentRow("ChSourceName") = TreatmentChSourceName 'DtTreatment.Rows(i).Item("TotalPrice")

                            DtBill.Rows.Add(TreatmentRow)
                        End With
                    Next
                End If
            End With

#End Region

#Region "Calculate Surgery"

            Dim DtSurgeryDischarge As New DataTable
            Dim ClsSurgery As New ClsSurgery
            With ClsSurgery
                .CaseID = ""
                DtSurgeryDischarge = .GetSurgeryDischarge(ClsSurgery)

                Dim SurgeryChSource As String = ""
                Dim SurgeryChSourceName As String = ""

                For i As Integer = 0 To DtChSource.Rows.Count - 1
                    If DtChSource.Rows(i).Item("ChSource") = "4" Then ' 4 = SURGERY
                        SurgeryChSource = DtChSource.Rows(i).Item("ChSource")
                        SurgeryChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                        Exit For
                    End If
                Next

                If DtSurgeryDischarge.Rows.Count > 0 Then

                    For i As Integer = 0 To DtSurgeryDischarge.Rows.Count - 1
                        With DtBill
                            Dim SurgeryDischarge As DataRow = DtBill.NewRow

                            SurgeryDischarge("RowNo") = 0 'DtSurgeryDischarge.Rows(i).Item("RowNo")
                            SurgeryDischarge("ItemCode") = DtSurgeryDischarge.Rows(i).Item("ItemCode")
                            SurgeryDischarge("ItemDescription") = DtSurgeryDischarge.Rows(i).Item("ItemDescription") '& "***WARD-DIAGNOSIS"
                            SurgeryDischarge("ItemGroup") = DtSurgeryDischarge.Rows(i).Item("ItemGroup")
                            SurgeryDischarge("ItemTypeCode") = DtSurgeryDischarge.Rows(i).Item("ItemTypeCode")
                            SurgeryDischarge("ItemTypeDescription") = DtSurgeryDischarge.Rows(i).Item("ItemTypeDescription")
                            SurgeryDischarge("Prescription") = "" 'DtWardDiagnosis.Rows(i).Item("Prescription")
                            SurgeryDischarge("Notes") = "" 'DtWardDiagnosis.Rows(i).Item("Notes")
                            SurgeryDischarge("UnitPrice") = DtSurgeryDischarge.Rows(i).Item("UnitPrice")
                            SurgeryDischarge("Quantity") = DtSurgeryDischarge.Rows(i).Item("Quantity")
                            SurgeryDischarge("TotalPrice") = DtSurgeryDischarge.Rows(i).Item("TotalPrice")

                            SurgeryDischarge("ChSource") = DtSurgeryDischarge 'DtTreatment.Rows(i).Item("TotalPrice")
                            SurgeryDischarge("ChSourceName") = DtSurgeryDischarge 'DtTreatment.Rows(i).Item("TotalPrice")

                        End With
                    Next

                End If

            End With

#End Region

#Region "Calculate Ward"

            'Ward diagnosis
            Dim DtWardDiagnosis As New DataTable
            Dim ClsWardDiagnosis As New ClsWardDiagnosis
            With ClsWardDiagnosis
                .WardID = Trim(TxtVisitID.Text)
                DtWardDiagnosis = .GetWardDiagnosisDetail(ClsWardDiagnosis)

                Dim WardChSource As String = ""
                Dim WardChSourceName As String = ""

                For i As Integer = 0 To DtChSource.Rows.Count - 1
                    If DtChSource.Rows(i).Item("ChSource") = "5" Then ' 5 = WARD DIAGNOSIS
                        WardChSource = DtChSource.Rows(i).Item("ChSource")
                        WardChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                        Exit For
                    End If
                Next

                If DtWardDiagnosis.Rows.Count > 0 Then
                    For i As Integer = 0 To DtWardDiagnosis.Rows.Count - 1
                        With DtBill
                            Dim WardDiagnosisRow As DataRow = DtBill.NewRow

                            WardDiagnosisRow("RowNo") = DtWardDiagnosis.Rows(i).Item("RowNo")
                            WardDiagnosisRow("ItemCode") = DtWardDiagnosis.Rows(i).Item("ItemCode")
                            WardDiagnosisRow("ItemDescription") = DtWardDiagnosis.Rows(i).Item("ItemDescription") '& "***WARD-DIAGNOSIS"
                            WardDiagnosisRow("ItemGroup") = DtWardDiagnosis.Rows(i).Item("ItemGroup")
                            WardDiagnosisRow("ItemTypeCode") = DtWardDiagnosis.Rows(i).Item("ItemTypeCode")
                            WardDiagnosisRow("ItemTypeDescription") = DtWardDiagnosis.Rows(i).Item("ItemTypeDescription")
                            WardDiagnosisRow("Prescription") = "" 'DtWardDiagnosis.Rows(i).Item("Prescription")
                            WardDiagnosisRow("Notes") = "" 'DtWardDiagnosis.Rows(i).Item("Notes")
                            WardDiagnosisRow("UnitPrice") = DtWardDiagnosis.Rows(i).Item("UnitPrice")
                            WardDiagnosisRow("Quantity") = DtWardDiagnosis.Rows(i).Item("Quantity")
                            WardDiagnosisRow("TotalPrice") = DtWardDiagnosis.Rows(i).Item("TotalPrice")

                            WardDiagnosisRow("ChSource") = WardChSource
                            WardDiagnosisRow("ChSourceName") = WardChSourceName

                            If CStrNull(WardDiagnosisRow("ItemCode")) <> "" Then
                                DtBill.Rows.Add(WardDiagnosisRow)
                            End If

                        End With
                    Next
                End If

            End With

            'Ward treatment
            Dim DtWardTreatment As New DataTable
            Dim ClsWardTreatment As New ClsWardTreatment
            With ClsWardTreatment
                .WardID = Trim(TxtVisitID.Text)
                DtWardTreatment = .GetWardTreatmentDetail(ClsWardTreatment)

                Dim WardChSource As String = ""
                Dim WardChSourceName As String = ""

                For i As Integer = 0 To DtChSource.Rows.Count - 1
                    If DtChSource.Rows(i).Item("ChSource") = "6" Then ' 6 = WARD TREATMENT
                        WardChSource = DtChSource.Rows(i).Item("ChSource")
                        WardChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                        Exit For
                    End If
                Next

                If DtWardTreatment.Rows.Count > 0 Then
                    For i As Integer = 0 To DtWardTreatment.Rows.Count - 1
                        With DtBill
                            Dim WardTreatmentRow As DataRow = DtBill.NewRow

                            WardTreatmentRow("RowNo") = DtWardTreatment.Rows(i).Item("RowNo")
                            WardTreatmentRow("ItemCode") = DtWardTreatment.Rows(i).Item("ItemCode")
                            WardTreatmentRow("ItemDescription") = DtWardTreatment.Rows(i).Item("ItemDescription") '& "***WARD-TREATMENT"
                            WardTreatmentRow("ItemGroup") = DtWardTreatment.Rows(i).Item("ItemGroup")
                            WardTreatmentRow("ItemTypeCode") = DtWardTreatment.Rows(i).Item("ItemTypeCode")
                            WardTreatmentRow("ItemTypeDescription") = DtWardTreatment.Rows(i).Item("ItemTypeDescription")
                            WardTreatmentRow("Prescription") = DtWardTreatment.Rows(i).Item("Prescription")
                            WardTreatmentRow("Notes") = DtWardTreatment.Rows(i).Item("Notes")
                            WardTreatmentRow("UnitPrice") = DtWardTreatment.Rows(i).Item("UnitPrice")
                            WardTreatmentRow("Quantity") = DtWardTreatment.Rows(i).Item("Quantity")
                            WardTreatmentRow("TotalPrice") = DtWardTreatment.Rows(i).Item("TotalPrice")

                            WardTreatmentRow("ChSource") = WardChSource 'DtWardTreatment.Rows(i).Item("Quantity")
                            WardTreatmentRow("ChSourceName") = WardChSourceName 'DtWardTreatment.Rows(i).Item("TotalPrice")

                            DtBill.Rows.Add(WardTreatmentRow)
                        End With
                    Next
                End If
            End With

            'Ward Discharge Medication
            Dim ClsWardDischargeMedication As New ClsWardDischargeDetail
            Dim DtWardDiscMed As New DataTable
            With ClsWardDischargeMedication
                .WardID = VisitID
                DtWardDiscMed = .GetWardDischargeMedication(ClsWardDischargeMedication)
                If DtWardDiscMed.Rows.Count > 0 Then

                    Dim WardChSource As String = ""
                    Dim WardChSourceName As String = ""

                    For i As Integer = 0 To DtChSource.Rows.Count - 1
                        If DtChSource.Rows(i).Item("ChSource") = "7" Then ' 7 = WARD DISCHARGE
                            WardChSource = DtChSource.Rows(i).Item("ChSource")
                            WardChSourceName = DtChSource.Rows(i).Item("ChSourceName")
                            Exit For
                        End If
                    Next

                    For i As Integer = 0 To DtWardDiscMed.Rows.Count - 1
                        With DtBill
                            Dim WardDiscMedRow As DataRow = DtBill.NewRow

                            WardDiscMedRow("RowNo") = DtWardDiscMed.Rows(i).Item("RowNo")
                            WardDiscMedRow("ItemCode") = DtWardDiscMed.Rows(i).Item("ItemCode")
                            WardDiscMedRow("ItemDescription") = DtWardDiscMed.Rows(i).Item("ItemDescription") '& "***WARD-DISCHARGE-MEDICATION"
                            WardDiscMedRow("ItemGroup") = DtWardDiscMed.Rows(i).Item("ItemGroup")
                            WardDiscMedRow("ItemTypeCode") = DtWardDiscMed.Rows(i).Item("ItemTypeCode")
                            WardDiscMedRow("ItemTypeDescription") = DtWardDiscMed.Rows(i).Item("ItemTypeDescription")
                            WardDiscMedRow("Prescription") = DtWardDiscMed.Rows(i).Item("Prescription")
                            WardDiscMedRow("Notes") = DtWardDiscMed.Rows(i).Item("Notes")
                            WardDiscMedRow("UnitPrice") = DtWardDiscMed.Rows(i).Item("UnitPrice")
                            WardDiscMedRow("Quantity") = DtWardDiscMed.Rows(i).Item("Quantity")
                            WardDiscMedRow("TotalPrice") = DtWardDiscMed.Rows(i).Item("TotalPrice")

                            WardDiscMedRow("ChSource") = WardChSource 'DtWardDiscMed.Rows(i).Item("TotalPrice")
                            WardDiscMedRow("ChSourceName") = WardChSourceName 'DtWardDiscMed.Rows(i).Item("TotalPrice")

                            DtBill.Rows.Add(WardDiscMedRow)
                        End With
                    Next

                End If
            End With

            'Ward
            'Update ward duration
            Dim DtWard As New DataTable
            Dim ClsWard As New ClsWard

            With ClsWard
                .WardID = VisitID
                DtWard = .GetWard(ClsWard)

                If DtWard.Rows.Count > 0 Then

                    If DtBill.Rows.Count > 0 Then

                        'Check rate of hospitalization selected; check by ItemTypeCode
                        For i As Integer = 0 To DtBill.Rows.Count - 1
                            If DtBill.Rows(i).Item("ItemTypeCode") = "100" Then
                                'Set Quantity in bill for hospitalization from WardDuration 
                                DtBill.Rows(i).Item("Quantity") = FormatNumber(DtWard.Rows(0).Item("WardDuration"), 2)
                                DtBill.Rows(i).Item("TotalPrice") = FormatNumber(DtBill.Rows(i).Item("UnitPrice") * DtBill.Rows(i).Item("Quantity"), 2)
                                Exit For
                            End If
                        Next

                    End If

                End If

            End With

#End Region

            'Arrange RowNo for billing
            If DtBill.Rows.Count > 0 Then

                Dim GrandTotal As Decimal
                Dim TotalDue As Decimal

                If DgvBillListing.Rows.Count > 0 Then
                    DgvBillListing.Rows.Clear()
                End If

                'Calculate Total
                For i As Integer = 0 To DtBill.Rows.Count - 1

                    DtBill.Rows(i).Item("RowNo") = i + 1 'Update RowNo
                    GrandTotal = GrandTotal + DtBill.Rows(i).Item("TotalPrice")
                    TotalDue = GrandTotal

                    With DgvBillListing
                        .Rows.Add()
                        .Rows(i).Cells("RowNo").Value = DtBill.Rows(i).Item("RowNo")
                        .Rows(i).Cells("ItemCodeDgv").Value = DtBill.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("ItemDescription").Value = DtBill.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("Prescription").Value = DtBill.Rows(i).Item("Prescription")
                        .Rows(i).Cells("Notes").Value = DtBill.Rows(i).Item("Notes")
                        .Rows(i).Cells("UnitPrice").Value = DtBill.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("Quantity").Value = DtBill.Rows(i).Item("Quantity")
                        .Rows(i).Cells("TotalPrice").Value = DtBill.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("ItemGroupDgv").Value = DtBill.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("ItemTypeCodeDgv").Value = DtBill.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("ItemTypeDescriptionDgv").Value = DtBill.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("ChSource").Value = DtBill.Rows(i).Item("ChSource")
                        .Rows(i).Cells("ChSourceName").Value = DtBill.Rows(i).Item("ChSourceName")
                    End With

                Next

                TxtGrandTotal.Text = FormatNumber(CDec(GrandTotal), 2)
                TxtTotalDue.Text = FormatNumber(CDec(GrandTotal), 2)

            End If

            MsgBox("Your billing has been calculated. Please save new calculated bill to update previous billing.", MsgBoxStyle.Information, "New Billing Calculated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".GenerateInvoice()")
            Return False
        End Try

        Return True

    End Function

    Private Sub PopulateVisit()

        Try
            With FrmSearchVisit
                .Source = ""
                .UserCommand = ""
                .ShowDialog()

                VisitID = .VisitID
                TxtVisitID.Text = .VisitID
                TxtCustomerName.Text = .CustomerName
                TxtPetName.Text = .PetName
                TxtCustomerName.Tag = .CustomerID
                CustomerID = .CustomerID
                TxtPetName.Tag = .PetID

            End With

            'Get invoice number from visit
            Dim DtInvoiceNo As New DataTable
            Dim ClsBill As New ClsBill
            With ClsBill
                .VisitID = VisitID
                DtInvoiceNo = .GetInvoiceByVisitID(ClsBill)
                If DtInvoiceNo.Rows.Count > 0 Then
                    InvoiceNo = DtInvoiceNo.Rows(0).Item("InvoiceNo")
                Else
                    InvoiceNo = ""
                End If

            End With

            If InvoiceNo <> "" Then
                PopulateForm(UserCommand)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnSearch_Click")
        End Try

    End Sub

    Private Sub PrintInvoice()

        Me.Cursor = Cursors.WaitCursor

        Try
            If TxtInvoiceNo.Text = "" Then
                MsgBox("Please select your invoice to print.", MsgBoxStyle.Critical, "No Invoice Loaded")
                Exit Sub
            End If

            Process.Start(My.Application.Info.DirectoryPath & "/Invoice.exe", Trim(TxtInvoiceNo.Text))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PrintInvoice")
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintInvoice()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        PopulateVisit()
    End Sub

    Private Sub BtnGenerateInvoice_Click(sender As Object, e As EventArgs) Handles BtnGenerateInvoice.Click
        If Not CalculateBillPayment() Then Exit Sub
    End Sub

    Private Sub TxtDeposit_TextChanged(sender As Object, e As EventArgs) Handles TxtDeposit.TextChanged

        Try
            Dim GrandTotal As Decimal = CDec(IIf(TxtGrandTotal.Text <> "", TxtGrandTotal.Text, 0.0))
            Dim Deposit As Decimal = CDec(IIf(TxtDeposit.Text <> "", TxtDeposit.Text, 0.0))

            TxtTotalDue.Text = FormatNumber(GrandTotal - Deposit, 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDeposit_TextChanged()")
        End Try

    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged

        Try
            Dim GrandTotal As Decimal = CDec(IIf(TxtGrandTotal.Text <> "", TxtGrandTotal.Text, 0.0))
            Dim Discount As Decimal = CDec(IIf(TxtDiscount.Text <> "", TxtDiscount.Text, 0.0))
            Dim Deposit As Decimal = CDec(IIf(TxtDeposit.Text <> "", TxtDeposit.Text, 0.0))
            Dim TotalDue As Decimal = CDec(IIf(TxtTotalDue.Text <> "", TxtTotalDue.Text, 0.0))

            TxtTotalDue.Text = FormatNumber((GrandTotal - Deposit) - Discount, 2)

            'Dim GrossTotal As Decimal = CDec(IIf(TxtGrossTotal.Text <> "", TxtGrossTotal.Text, 0.0))
            'Dim Discount As Decimal = CDec(IIf(TxtDiscount.Text <> "", TxtDiscount.Text, 0.0))

            'TxtGrandTotal.Text = FormatNumber(GrossTotal - Discount, 2)
            'TxtTotalDue.Text = FormatNumber(GrandTotal - Deposit, 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtDiscount_TextChanged()")
        End Try

    End Sub

End Class