Public Class FrmSurgeryManagement

#Region "FormProperty"

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

    Private Sub FrmSurgeryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateSxMaterials()
    End Sub

    Private Sub PopulateSxMaterials()

        Try
            Dim ClsSurgeryMaterial As New ClsSurgeryMaterial
            Dim DtSxMaterials As New DataTable

            With ClsSurgeryMaterial

                DtSxMaterials = .GetSurgeryMaterialsMgmt(ClsSurgeryMaterial)
                If DtSxMaterials.Rows.Count > 0 Then

                    For i As Integer = 0 To DtSxMaterials.Rows.Count - 1
                        With DgvFixedSxMaterials
                            .Rows.Add()
                            .Rows(i).Cells("SxMaterialsRowNo").Value = DtSxMaterials.Rows(i).Item("RowNo")
                            .Rows(i).Cells("SxMaterialsItemCode").Value = DtSxMaterials.Rows(i).Item("ItemCode")
                            .Rows(i).Cells("SxMaterialsItemDescription").Value = DtSxMaterials.Rows(i).Item("ItemDescription")
                            .Rows(i).Cells("SxMaterialsUnitPrice").Value = DtSxMaterials.Rows(i).Item("UnitPrice")
                            .Rows(i).Cells("SxMaterialsQuantity").Value = DtSxMaterials.Rows(i).Item("Quantity")
                            .Rows(i).Cells("SxMaterialsTotalPrice").Value = DtSxMaterials.Rows(i).Item("TotalPrice")
                            .Rows(i).Cells("SxMaterialsItemGroup").Value = DtSxMaterials.Rows(i).Item("ItemGroup")
                            .Rows(i).Cells("SxMaterialsItemTypeCode").Value = DtSxMaterials.Rows(i).Item("ItemTypeCode")
                            .Rows(i).Cells("SxMaterialsItemTypeDescription").Value = DtSxMaterials.Rows(i).Item("ItemTypeDescription")
                            .Rows(i).Cells("SxMaterialsPrescription").Value = DtSxMaterials.Rows(i).Item("Prescription")
                            .Rows(i).Cells("SxMaterialsNotes").Value = DtSxMaterials.Rows(i).Item("Notes")
                        End With
                    Next

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateSxMaterials()")
        End Try

    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click

        With FrmSearchItem
            .ShowDialog()
            TxtMaterialItem.Tag = .ItemCode
            TxtMaterialItem.Text = .ItemDescription
            TxtMaterialUnitPrice.Text = .UnitPrice
            TxtMaterialTotalPrice.Text = FormatNumber(.UnitPrice * TxtMaterialQuantity.Text, 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With

    End Sub

    Private Sub BtnAddMaterialItem_Click(sender As Object, e As EventArgs) Handles BtnAddMaterialItem.Click
        If BtnAddMaterialItem.Tag = "" Then
            AddSxMaterials()
            'ElseIf BtnAddMaterialItem.Tag = "UPDATE" Then
            'UpdateMaterialItem()
        End If
    End Sub

    Private Sub AddSxMaterials()

        Dim DtSurgeryMaterials As New DataTable

        Try
            'Check user input; fields validity
            If Not CheckFields() Then Exit Sub

            DtSurgeryMaterials = InitSurgeryItemDt()
            If DgvFixedSxMaterials.Rows.Count > 0 Then

                For i As Integer = 0 To DgvFixedSxMaterials.Rows.Count - 1

                    Dim DgvRow As DataRow = DtSurgeryMaterials.NewRow

                    DgvRow("RowNo") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsRowNo").Value
                    DgvRow("ItemCode") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemCode").Value
                    DgvRow("ItemDescription") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemDescription").Value
                    DgvRow("Prescription") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsPrescription").Value
                    DgvRow("Notes") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsNotes").Value
                    DgvRow("Quantity") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsQuantity").Value
                    DgvRow("UnitPrice") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsUnitPrice").Value
                    DgvRow("TotalPrice") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsTotalPrice").Value
                    DgvRow("ItemGroup") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemTypeDescription").Value

                    DtSurgeryMaterials.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtSurgeryMaterials.NewRow

            Row("RowNo") = IIf(DtSurgeryMaterials.Rows.Count = 0, 1, DtSurgeryMaterials.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtMaterialItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtMaterialItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtMaterialUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtMaterialQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtMaterialTotalPrice.Text) * CDec(TxtMaterialQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode
            Row("Prescription") = Trim(TxtMaterialPrescription.Text)
            Row("Notes") = Trim(TxtMaterialNotes.Text)

            DtSurgeryMaterials.Rows.Add(Row)

            If DtSurgeryMaterials.Rows.Count > 0 Then

                DgvFixedSxMaterials.Rows.Clear()

                For i As Integer = 0 To DtSurgeryMaterials.Rows.Count - 1
                    With DgvFixedSxMaterials
                        .Rows.Add()
                        .Rows(i).Cells("SxMaterialsRowNo").Value = DtSurgeryMaterials.Rows(i).Item("RowNo")
                        .Rows(i).Cells("SxMaterialsItemCode").Value = DtSurgeryMaterials.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("SxMaterialsItemDescription").Value = DtSurgeryMaterials.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("SxMaterialsUnitPrice").Value = DtSurgeryMaterials.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("SxMaterialsQuantity").Value = DtSurgeryMaterials.Rows(i).Item("Quantity")
                        .Rows(i).Cells("SxMaterialsTotalPrice").Value = DtSurgeryMaterials.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("SxMaterialsItemGroup").Value = DtSurgeryMaterials.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("SxMaterialsItemTypeCode").Value = DtSurgeryMaterials.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("SxMaterialsItemTypeDescription").Value = DtSurgeryMaterials.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("SxMaterialsPrescription").Value = DtSurgeryMaterials.Rows(i).Item("Prescription")
                        .Rows(i).Cells("SxMaterialsNotes").Value = DtSurgeryMaterials.Rows(i).Item("Notes")
                    End With
                Next

            End If

            TxtMaterialItem.Tag = ""
            TxtMaterialItem.Text = ""
            TxtMaterialUnitPrice.Text = FormatNumber("0.00", 2)
            TxtMaterialQuantity.Text = FormatNumber("1.00", 2)
            TxtMaterialTotalPrice.Text = FormatNumber("0.00", 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddSurgeryItem()")
        End Try

    End Sub

    Private Function InitSurgeryItemDt() As DataTable

        Dim DtItem As New DataTable

        Try
            With DtItem
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitSurgeryItemDt()")
        End Try

        Return DtItem

    End Function

    Private Function CheckFields(Optional FieldSource As String = "") As Boolean

        Try
            If TxtMaterialItem.Text = "" Then
                MsgBox("Please select item.", MsgBoxStyle.Exclamation, "No Item Selected")
                Return False
            End If

            For i As Integer = 0 To DgvFixedSxMaterials.Rows.Count - 1

                If TxtMaterialItem.Tag = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemCode").Value Then
                    MsgBox("You are trying to add same item(s) to the list. Update selected item quantity's instead.", MsgBoxStyle.Exclamation, "Duplicate Item")
                    Return False
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckFields()")
            Return False
        End Try

        Return True

    End Function

    Private Function SaveSxMaterialsToDb() As Boolean

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Add surgery materials
            Dim ClsSurgeryMaterial As New ClsSurgeryMaterial
            If DgvFixedSxMaterials.Rows.Count > 0 Then

                For i As Integer = 0 To DgvFixedSxMaterials.Rows.Count - 1

                    With ClsSurgeryMaterial
                        .RowNo = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsRowNo").Value
                        .ItemCode = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemCode").Value
                        .ItemDescription = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemDescription").Value
                        .ItemGroup = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemGroup").Value
                        .ItemTypeCode = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemTypeCode").Value
                        .ItemTypeDescription = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemTypeDescription").Value
                        .UnitPrice = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsUnitPrice").Value
                        .Quantity = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsQuantity").Value
                        .TotalPrice = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsTotalPrice").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewSurgeryMaterialMgmt(ClsSurgeryMaterial, DbConn, DbTrans) Then
                            MsgBox("Failed to add surgery materials information.", MsgBoxStyle.Critical, "Add Surgery Materials Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            MsgBox("Surgery information has been successfully added.", MsgBoxStyle.Information, "Surgery Information Added")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveSxMaterialsToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not SaveSxMaterialsToDb() Then Exit Sub
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class