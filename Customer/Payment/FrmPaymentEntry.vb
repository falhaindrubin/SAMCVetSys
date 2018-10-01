Public Class FrmPaymentEntry

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

    Private Sub FrmPaymentEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        'Me.Text = IIf(FormTitle <> "", FormTitle, Me.Text)
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
                TxtUnitPrice.Text = .Price
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

    Private Sub BtnAddBillItem_Click(sender As Object, e As EventArgs) Handles BtnAddBillItem.Click
        AddBillItem()
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
                    DgvRow("ItemDiscount") = DgvBillListing.Rows(i).Cells("ItemDiscount").Value
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
            Row("ItemDiscount") = UCase(Trim(TxtDiscount.Text))
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
                        .Rows(i).Cells("ItemDiscount").Value = DtBill.Rows(i).Item("ItemDiscount")
                        .Rows(i).Cells("TotalPrice").Value = DtBill.Rows(i).Item("TotalPrice")
                    End With

                    GrossTotal = GrossTotal + DtBill.Rows(i).Item("TotalPrice")
                    Discount = Discount + DtBill.Rows(i).Item("ItemDiscount")
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
                TxtDiscount.Text = "0.00"
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
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("ItemDiscount", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitBillItemDt()")
        End Try

        Return DtBill

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        CreateBill()
    End Sub

    Private Sub CreateBill()
        If Not CreateBillPayment() Then Exit Sub
    End Sub

    Private Function CreateBillPayment()

        Dim GenInvoiceNo As String
        Dim ClsBill As New ClsBill
        Dim ClsBillDetail As New ClsBillDetail

        Try
            'Create Invoice No.
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If InvoiceNo <> "" Then
                GenInvoiceNo = InvoiceNo
            Else
                GenInvoiceNo = GenerateRunningNo("INV", DbConn, DbTrans)
            End If

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
                    .InvoiceDate = Now
                    .CustomerID = CustomerID
                    .CustomerName = CustomerName
                    .GrossTotal = CDec(TxtGrossTotal.Text)
                    .Discount = CDec(TxtDiscount.Text)
                    .GrandTotal = CDec(TxtGrandTotal.Text)
                    .Deposit = CDec(TxtDeposit.Text)
                    .TotalDue = CDec(TxtTotalDue.Text)
                    .IsPaymentComplete = IIf(CbPaymentCompleted.Checked = True, "1", "0")
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
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
                        .ItemTypeCode = DgvBillListing.Rows(i).Cells("ItemCodeDgv").Value.ToString.Substring(0, 2)
                        .Prescription = DgvBillListing.Rows(i).Cells("Prescription").Value
                        .Notes = DgvBillListing.Rows(i).Cells("Notes").Value
                        .Quantity = DgvBillListing.Rows(i).Cells("Quantity").Value
                        .UnitPrice = DgvBillListing.Rows(i).Cells("UnitPrice").Value
                        .ItemDiscount = DgvBillListing.Rows(i).Cells("ItemDiscount").Value
                        .TotalPrice = DgvBillListing.Rows(i).Cells("TotalPrice").Value
                    End With

                    If Not ClsBillDetail.AddNewBillDetail(ClsBillDetail, DbConn, DbTrans) Then
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

            TxtInvoiceNo.Text = GenInvoiceNo
            TxtCreatedBy.Text = "" 'ClsAppointment.Ref.CreatedBy
            TxtDateCreated.Text = "" 'ClsAppointment.Ref.DateCreated
            TxtModifiedBy.Text = "" 'ClsAppointment.Ref.ModifiedBy
            TxtDateModified.Text = "" 'ClsAppointment.Ref.DateModified

            'SetFields(UserCommand)

            MsgBox("Consultation has been successfully created!", MsgBoxStyle.Information, "Consultation Successfully Added")

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

End Class