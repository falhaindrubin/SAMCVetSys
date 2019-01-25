Public Class FrmPharmacyRequest

#Region "FormProperty"

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _RequestID As String
    Public Property RequestID As String
        Get
            Return _RequestID
        End Get
        Set(value As String)
            _RequestID = value
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

    Private _ItemTypeDescription As String
    Public Property ItemTypeDescription As String
        Get
            Return _ItemTypeDescription
        End Get
        Set(value As String)
            _ItemTypeDescription = value
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

#End Region

    Private Sub FrmPharmacyRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateForm()
    End Sub

    Private Sub PopulateForm()

        Try
            Dim DtPharmacyRq As New DataTable
            Dim DtPharmacyRqDetail As New DataTable
            Dim ClsPharmacy As New ClsPharmacy

            If VisitID <> "" Then 'RequestID

                With ClsPharmacy

                    .RequestID = RequestID
                    .VisitID = VisitID

                    DtPharmacyRq = .GetPharmacyRequest(ClsPharmacy)
                    DtPharmacyRqDetail = .GetPharmacyRequestDetail(ClsPharmacy)

                    If DtPharmacyRq.Rows.Count > 0 Then

                        'Request information
                        TxtVet.Tag = DtPharmacyRq.Rows(0).Item("RqEmpID")
                        TxtVet.Text = DtPharmacyRq.Rows(0).Item("RqEmpName")
                        TxtVisitID.Text = DtPharmacyRq.Rows(0).Item("VisitID")
                        TxtRequestID.Text = DtPharmacyRq.Rows(0).Item("RequestID")
                        TxtRequestDate.Text = IIf(DtPharmacyRq.Rows(0).Item("RequestDate") = Nothing, "", CDate(DtPharmacyRq.Rows(0).Item("RequestDate")))

                        'Pharmacy information
                        TxtInCharge.Tag = IIf(DtPharmacyRq.Rows(0).Item("PhEmpID") <> "", DtPharmacyRq.Rows(0).Item("PhEmpID"), CURR_EMPLOYEE_ID)
                        TxtInCharge.Text = IIf(DtPharmacyRq.Rows(0).Item("PhEmpName") <> "", DtPharmacyRq.Rows(0).Item("PhEmpName"), CURR_EMPLOYEE_NAME)
                        TxtApprovalDate.Text = IIf(DtPharmacyRq.Rows(0).Item("ApprovalDate") = Nothing, "", CDate(DtPharmacyRq.Rows(0).Item("ApprovalDate")))
                        CbIsCompleted.Checked = IIf(DtPharmacyRq.Rows(0).Item("IsCompleted") = "1", True, False)

                        'CreatedBy
                        TxtCreatedBy.Text = DtPharmacyRq.Rows(0).Item("CreatedBy")
                        TxtDateCreated.Text = DtPharmacyRq.Rows(0).Item("DateCreated")
                        TxtModifiedBy.Text = DtPharmacyRq.Rows(0).Item("ModifiedBy")
                        TxtDateModified.Text = DtPharmacyRq.Rows(0).Item("DateModified")

                    End If

                    If DtPharmacyRqDetail.Rows.Count > 0 Then

                        For i As Integer = 0 To DtPharmacyRqDetail.Rows.Count - 1

                            With DgvPharmacyRequest
                                .Rows.Add()
                                .Rows(i).Cells("RqRowNo").Value = DtPharmacyRqDetail.Rows(i).Item("RowNo")
                                .Rows(i).Cells("RqItemCode").Value = DtPharmacyRqDetail.Rows(i).Item("ItemCode")
                                .Rows(i).Cells("RqItemDescription").Value = DtPharmacyRqDetail.Rows(i).Item("ItemDescription")
                                .Rows(i).Cells("RqItemGroup").Value = DtPharmacyRqDetail.Rows(i).Item("ItemGroup")
                                .Rows(i).Cells("RqItemTypeCode").Value = DtPharmacyRqDetail.Rows(i).Item("ItemTypeCode")
                                .Rows(i).Cells("RqItemTypeDescription").Value = DtPharmacyRqDetail.Rows(i).Item("ItemTypeDescription")
                                .Rows(i).Cells("RqPrescription").Value = DtPharmacyRqDetail.Rows(i).Item("Prescription")
                                .Rows(i).Cells("RqNotes").Value = DtPharmacyRqDetail.Rows(i).Item("Notes")
                                .Rows(i).Cells("RqUnitPrice").Value = DtPharmacyRqDetail.Rows(i).Item("UnitPrice")
                                .Rows(i).Cells("RqQuantity").Value = DtPharmacyRqDetail.Rows(i).Item("Quantity")
                                .Rows(i).Cells("RqTotalPrice").Value = DtPharmacyRqDetail.Rows(i).Item("TotalPrice")
                            End With

                        Next

                    End If

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Function SaveRequestToDb() As Boolean

        Try
            If Not CheckFields() Then Return False

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            Dim ClsPharmacy As New ClsPharmacy
            'Dim ClsPharmacyDetail As New ClsPharmacyDetail

            With ClsPharmacy
                .VisitID = IIf(TxtVisitID.Text <> "", TxtVisitID.Text, VisitID)
                .RequestID = IIf(TxtRequestID.Text <> "", TxtRequestID.Text, RequestID)
                .PhEmpID = IIf(TxtInCharge.Tag <> "", TxtInCharge.Tag, CURR_EMPLOYEE_ID)
                .PhEmpName = IIf(TxtInCharge.Text <> "", TxtInCharge.Text, CURR_EMPLOYEE_NAME)
                .IsCompleted = "1"
                .ApprovalDate = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .UpdatePharmacyRequest(ClsPharmacy, DbConn, DbTrans) Then
                    MsgBox("Failed to update pharmacy request.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            '.Append("SET PhEmpID = '" & P.PhEmpID & "', PhEmpName = '" & P.PhEmpName & "', ApprovalDate = " & CSQLDateTime(P.ApprovalDate) & ", IsCompleted = '" & P.IsCompleted & "', ")
            '.Append("ModifiedBy = '" & P.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(P.Ref.DateModified) & " ")

            'Save/update request header
            'With ClsPharmacy
            '    .RequestID = IIf(TxtRequestID.Text <> "", TxtRequestID.Text, RequestID)
            '    .VisitID = IIf(TxtVisitID.Text <> "", TxtVisitID.Text, VisitID)
            '    .RequestDate = TxtRequestDate.Text
            '    .RqEmpID = TxtVet.Tag
            '    .RqEmpName = TxtVet.Text
            '    .PhEmpID = IIf(TxtInCharge.Tag <> "", TxtInCharge.Tag, CURR_EMPLOYEE_ID)
            '    .PhEmpName = IIf(TxtInCharge.Text <> "", TxtInCharge.Text, CURR_EMPLOYEE_NAME)
            '    .ApprovalDate = Now
            '    .IsCompleted = "1" 'IIf(CbIsCompleted.Checked = True, "1", "0")
            '    .Ref.CreatedBy = CURR_USER
            '    .Ref.DateCreated = Now
            '    .Ref.ModifiedBy = CURR_USER
            '    .Ref.DateModified = Now

            '    If Not .AddNewPharmacyRequest(ClsPharmacy, DbConn, DbTrans) Then
            '        MsgBox("Failed to update pharmacy request.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
            '        DbTrans.Rollback()
            '        DbTrans.Dispose()
            '        DbTrans = Nothing
            '        Return False
            '    End If

            'End With

            'Save/update details
            'If DgvPharmacyRequest.Rows.Count > 0 Then

            '    For i As Integer = 0 To DgvPharmacyRequest.Rows.Count - 1

            '        With ClsPharmacyDetail
            '            .RequestID = IIf(TxtRequestID.Text <> "", TxtRequestID.Text, RequestID)
            '            .VisitID = IIf(TxtVisitID.Text <> "", TxtVisitID.Text, VisitID)
            '            .RowNo = DgvPharmacyRequest.Rows(i).Cells("RqRowNo").Value
            '            .ItemCode = DgvPharmacyRequest.Rows(i).Cells("RqItemCode").Value
            '            .ItemDescription = DgvPharmacyRequest.Rows(i).Cells("RqItemDescription").Value
            '            .ItemGroup = DgvPharmacyRequest.Rows(i).Cells("RqItemGroup").Value
            '            .ItemTypeCode = DgvPharmacyRequest.Rows(i).Cells("RqItemTypeCode").Value
            '            .ItemTypeDescription = DgvPharmacyRequest.Rows(i).Cells("RqItemTypeDescription").Value
            '            .Prescription = DgvPharmacyRequest.Rows(i).Cells("RqPrescription").Value
            '            .Notes = DgvPharmacyRequest.Rows(i).Cells("RqNotes").Value
            '            .UnitPrice = DgvPharmacyRequest.Rows(i).Cells("RqUnitPrice").Value
            '            .Quantity = DgvPharmacyRequest.Rows(i).Cells("RqQuantity").Value
            '            .TotalPrice = DgvPharmacyRequest.Rows(i).Cells("RqTotalPrice").Value
            '            .Ref.CreatedBy = CURR_USER
            '            .Ref.DateCreated = Now
            '            .Ref.ModifiedBy = CURR_USER
            '            .Ref.DateModified = Now

            '            If Not .AddNewPharmacyRequestDetail(ClsPharmacyDetail, DbConn, DbTrans) Then
            '                MsgBox("Failed to update pharmacy request details.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
            '                DbTrans.Rollback()
            '                DbTrans.Dispose()
            '                DbTrans = Nothing
            '                Return False
            '            End If

            '        End With

            '    Next

            'End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            With ClsPharmacy
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
                TxtApprovalDate.Text = .ApprovalDate
            End With

            CbIsCompleted.Checked = True
            CbIsCompleted.Enabled = False

            MsgBox("Your pharmacy request has been successfully updated!", MsgBoxStyle.Information, "Pharmacy Request Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveRequestToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function AddItem() As Boolean

        Dim DtRequest As New DataTable

        Try
            'Check user input; fields validity
            If Not CheckFields() Then Return False

            DtRequest = InitSelectedItemDt()
            If DgvPharmacyRequest.Rows.Count > 0 Then

                For i As Integer = 0 To DgvPharmacyRequest.Rows.Count - 1

                    Dim DgvRow As DataRow = DtRequest.NewRow

                    DgvRow("RowNo") = DgvPharmacyRequest.Rows(i).Cells("RqRowNo").Value
                    DgvRow("ItemCode") = DgvPharmacyRequest.Rows(i).Cells("RqItemCode").Value
                    DgvRow("ItemDescription") = DgvPharmacyRequest.Rows(i).Cells("RqItemDescription").Value
                    DgvRow("Prescription") = DgvPharmacyRequest.Rows(i).Cells("RqPrescription").Value
                    DgvRow("Notes") = DgvPharmacyRequest.Rows(i).Cells("RqNotes").Value
                    DgvRow("Quantity") = DgvPharmacyRequest.Rows(i).Cells("RqQuantity").Value
                    DgvRow("UnitPrice") = DgvPharmacyRequest.Rows(i).Cells("RqUnitPrice").Value
                    DgvRow("TotalPrice") = DgvPharmacyRequest.Rows(i).Cells("RqTotalPrice").Value
                    DgvRow("ItemGroup") = DgvPharmacyRequest.Rows(i).Cells("RqItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvPharmacyRequest.Rows(i).Cells("RqItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvPharmacyRequest.Rows(i).Cells("RqItemTypeDescription").Value

                    DtRequest.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtRequest.NewRow

            Row("RowNo") = IIf(DtRequest.Rows.Count = 0, 1, DtRequest.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTotalPrice.Text) * CDec(TxtTotalPrice.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode
            Row("Prescription") = Trim(TxtPrescription.Text)
            Row("Notes") = Trim(TxtNotes.Text)

            DtRequest.Rows.Add(Row)

            If DtRequest.Rows.Count > 0 Then

                DgvPharmacyRequest.Rows.Clear()

                For i As Integer = 0 To DtRequest.Rows.Count - 1
                    With DgvPharmacyRequest
                        .Rows.Add()
                        .Rows(i).Cells("RqRowNo").Value = DtRequest.Rows(i).Item("RowNo")
                        .Rows(i).Cells("RqItemCode").Value = DtRequest.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("RqItemDescription").Value = DtRequest.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("RqPrescription").Value = DtRequest.Rows(i).Item("Prescription")
                        .Rows(i).Cells("RqNotes").Value = DtRequest.Rows(i).Item("Notes")
                        .Rows(i).Cells("RqUnitPrice").Value = DtRequest.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("RqQuantity").Value = DtRequest.Rows(i).Item("Quantity")
                        .Rows(i).Cells("RqTotalPrice").Value = DtRequest.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("RqItemGroup").Value = DtRequest.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("RqItemTypeCode").Value = DtRequest.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("RqItemTypeDescription").Value = DtRequest.Rows(i).Item("ItemTypeDescription")
                    End With
                Next

            End If

            TxtItem.Text = ""
            TxtItem.Tag = ""
            TxtPrescription.Text = ""
            TxtNotes.Text = ""
            TxtUnitPrice.Text = "0.00"
            TxtQuantity.Text = "1.00"
            TxtTotalPrice.Text = "0.00"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddItem()")
            Return False
        End Try

        Return True

    End Function

    Private Function UpdateItem() As Boolean

        Try
            Dim RowIndex As Integer = CInt(LblRowNo.Text)

            With DgvPharmacyRequest
                .Rows(RowIndex).Cells("RqItemCode").Value = Trim(TxtItem.Tag)
                .Rows(RowIndex).Cells("RqItemDescription").Value = Trim(TxtItem.Text)
                .Rows(RowIndex).Cells("RqPrescription").Value = Trim(TxtPrescription.Text)
                .Rows(RowIndex).Cells("RqNotes").Value = Trim(TxtNotes.Text)
                .Rows(RowIndex).Cells("RqUnitPrice").Value = Trim(TxtUnitPrice.Text)
                .Rows(RowIndex).Cells("RqQuantity").Value = Trim(TxtQuantity.Text)
                .Rows(RowIndex).Cells("RqTotalPrice").Value = Trim(TxtTotalPrice.Text)
            End With

            TxtItem.Text = ""
            TxtItem.Tag = ""
            TxtPrescription.Text = ""
            TxtNotes.Text = ""
            TxtUnitPrice.Text = ""
            TxtQuantity.Text = ""
            TxtTotalPrice.Text = ""

            BtnAddItem.Text = "Add Item"
            BtnAddItem.Tag = ""

            MsgBox("Selected item has been updated!", MsgBoxStyle.Information, "Item Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateTreatment()")
            Return False
        End Try

        Return True

    End Function

    Private Function CheckFields(Optional FieldSource As String = "") As Boolean

        Try
            'Check if visit information is populated
            If TxtVisitID.Text = "" Then
                MsgBox("Please select customer visit.", MsgBoxStyle.Exclamation, "No Customer Visit Selected")
                Return False
            End If

            If DgvPharmacyRequest.Rows.Count > 0 Then

                For i As Integer = 0 To DgvPharmacyRequest.Rows.Count - 1

                    If TxtItem.Tag = DgvPharmacyRequest.Rows(i).Cells("RqItemCode").Value Then
                        MsgBox("You are trying to add same item(s) to the list. Update selected item quantity's instead.", MsgBoxStyle.Exclamation, "Duplicate Item")
                        Return False
                    End If

                Next

            Else
                If TxtItem.Text = "" Or TxtItem.Tag = "" Then
                    MsgBox("Please select item.", MsgBoxStyle.Exclamation, "No Item Selected")
                    Return False
                End If

            End If

            If CbIsCompleted.Checked = True Then
                MsgBox("Your already approved this request.", MsgBoxStyle.Exclamation, "Request Approved")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckFields()")
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
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitTreatmentDt()")
        End Try

        Return DtTreatment

    End Function

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click

        With FrmSearchItem
            .ShowDialog()
            TxtItem.Tag = .ItemCode
            TxtItem.Text = .ItemDescription
            TxtUnitPrice.Text = .UnitPrice
            TxtTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With

    End Sub

    Private Sub DgvPharmacyRequest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPharmacyRequest.CellContentClick

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 1 Then

                    With DgvPharmacyRequest

                        TxtItem.Text = .Rows(e.RowIndex).Cells("RqItemDescription").Value
                        TxtItem.Tag = .Rows(e.RowIndex).Cells("RqItemCode").Value
                        TxtPrescription.Text = .Rows(e.RowIndex).Cells("RqPrescription").Value
                        TxtNotes.Text = .Rows(e.RowIndex).Cells("RqNotes").Value
                        TxtUnitPrice.Text = .Rows(e.RowIndex).Cells("RqUnitPrice").Value
                        TxtQuantity.Text = .Rows(e.RowIndex).Cells("RqQuantity").Value
                        TxtTotalPrice.Text = .Rows(e.RowIndex).Cells("RqTotalPrice").Value

                    End With

                    BtnAddItem.Text = "Update Item"
                    BtnAddItem.Tag = "UPDATE"
                    LblRowNo.Text = e.RowIndex

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvPharmacyRequest_CellContentClick()")
        End Try

    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        If BtnAddItem.Tag = "" Then
            If Not AddItem() Then Exit Sub
        ElseIf BtnAddItem.Tag = "UPDATE" Then
            If Not UpdateItem() Then Exit Sub
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not SaveRequestToDb() Then Exit Sub
    End Sub



End Class