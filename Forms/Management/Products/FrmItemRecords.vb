Imports System.Text

Public Class FrmItemRecords

    Private _ItemGroup As String
    Public Property ItemGroup As String
        Get
            Return _ItemGroup
        End Get
        Set(value As String)
            _ItemGroup = value
        End Set
    End Property

    Private Sub FrmItemManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateItemType()
        PopulateItemList()
        Application.DoEvents()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PopulateItemType()

        If RbServices.Checked = True Then

            PopulateServiceItemType()

        ElseIf RbProducts.Checked = True Then

            PopulateProductItemType()

        End If

    End Sub

    Private Sub PopulateItemList()

        If RbServices.Checked = True Then

            PopulateServices()

        ElseIf RbProducts.Checked = True Then

            PopulateProducts()

        End If

        'CmbItemTypeDescription.SelectedValue = ItemTypeCode

    End Sub

    Private Sub PopulateServiceItemType()

        Dim CmbSource As New Dictionary(Of String, String)
        Dim ClsServices As New ClsServices
        Dim DtServiceType As New DataTable

        Try
            ClsServices = New ClsServices
            With ClsServices
                DtServiceType = .GetServiceTypeList(ClsServices)
            End With

            If DtServiceType.Rows.Count > 0 Then

                'CmbSource.Add("", "")

                For i As Integer = 0 To DtServiceType.Rows.Count - 1
                    CmbSource.Add(DtServiceType.Rows(i).Item("ItemTypeCode"), DtServiceType.Rows(i).Item("ItemTypeDescription"))
                Next

                If CmbItemTypeCode.Items.Count > 0 Then
                    CmbItemTypeCode.DataSource = Nothing
                    CmbItemTypeCode.Items.Clear()
                End If

                CmbItemTypeCode.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemTypeCode.DisplayMember = "Value"
                CmbItemTypeCode.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateServiceType()")
        End Try

    End Sub

    Private Sub PopulateProductItemType()

        Dim CmbSource As New Dictionary(Of String, String)
        Dim ClsProducts As New ClsProducts
        Dim DtProductType As New DataTable

        Try
            ClsProducts = New ClsProducts
            With ClsProducts
                DtProductType = .GetProductTypeList(ClsProducts)
            End With

            If DtProductType.Rows.Count > 0 Then

                'CmbSource.Add("", "")

                For i As Integer = 0 To DtProductType.Rows.Count - 1
                    CmbSource.Add(DtProductType.Rows(i).Item("ItemTypeCode"), DtProductType.Rows(i).Item("ItemTypeDescription"))
                Next

                If CmbItemTypeCode.Items.Count > 0 Then
                    CmbItemTypeCode.DataSource = Nothing
                    CmbItemTypeCode.Items.Clear()
                End If

                CmbItemTypeCode.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemTypeCode.DisplayMember = "Value"
                CmbItemTypeCode.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateProductType()")
        End Try

    End Sub

    Private Sub PopulateServiceProductListing()

        Dim DtItemListing As New DataTable
        Dim DtServiceType As New DataTable
        Dim DtProductType As New DataTable
        Dim DtServices As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbServices.Checked = True Then

                PopulateServices()

            ElseIf RbProducts.Checked = True Then

                PopulateProducts()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateServiceProductListing()")
        End Try

    End Sub

    Private Sub PopulateServices()

        Dim DtServiceType As New DataTable
        Dim DtServices As New DataTable
        Dim ClsServices As New ClsServices
        Dim CmbSource As New Dictionary(Of String, String)
        Dim StrOp As String = "WHERE"

        Try
            ClsServices = New ClsServices
            With ClsServices
                .SQLQueryCondition = FilterSQL(StrOp)
                DtServices = .GetServiceList(ClsServices)
            End With

            If DtServices.Rows.Count > 0 Then

                With DgvItemListing

                    .Rows.Clear()

                    For i As Integer = 0 To DtServices.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("DgvListItemCode").Value = DtServices.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("DgvListItemDescription").Value = DtServices.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("DgvListItemGroup").Value = DtServices.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("DgvListItemTypeCode").Value = DtServices.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("DgvListItemTypeDescription").Value = DtServices.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("DgvListUnitPrice").Value = DtServices.Rows(i).Item("UnitPrice")
                    Next

                End With
            Else
                With DgvItemListing
                    .Rows.Clear()
                End With

            End If

            LblRecordCount.Text = "Record found:  " & DtServices.Rows.Count & ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateServices()")
        End Try

    End Sub

    Private Sub PopulateProducts()

        Dim DtProductType As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsProducts As New ClsProducts
        Dim CmbSource As New Dictionary(Of String, String)
        Dim StrOp As String = "WHERE"

        Try
            ClsProducts = New ClsProducts
            With ClsProducts
                .SQLQueryCondition = FilterSQL(StrOp)
                'DtProductType = .GetProductTypeList(ClsProducts)
                DtProducts = .GetProductList(ClsProducts)
            End With

            If DtProducts.Rows.Count > 0 Then

                With DgvItemListing

                    .Rows.Clear()

                    For i As Integer = 0 To DtProducts.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("DgvListItemCode").Value = DtProducts.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("DgvListItemDescription").Value = DtProducts.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("DgvListItemGroup").Value = DtProducts.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("DgvListItemTypeCode").Value = DtProducts.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("DgvListItemTypeDescription").Value = DtProducts.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("DgvListUnitPrice").Value = DtProducts.Rows(i).Item("UnitPrice")
                    Next

                End With

            Else
                With DgvItemListing
                    .Rows.Clear()
                End With

            End If

            LblRecordCount.Text = "Record found:  " & DtProducts.Rows.Count & ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateProducts()")
        End Try

    End Sub

    Private Function InitDtItemList() As DataTable

        Dim DtItemList As New DataTable

        Try
            With DtItemList
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("ItemGroup", GetType(String))
                .Columns.Add("ItemTypeCode", GetType(String))
                .Columns.Add("ItemTypeDescription", GetType(String))
                .Columns.Add("UnitPrice", GetType(String))
                .Columns.Add("CreatedBy", GetType(String))
                .Columns.Add("DateCreated", GetType(String))
                .Columns.Add("ModifiedBy", GetType(String))
                .Columns.Add("DateModified", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitDtItemList()")
        End Try

        Return DtItemList

    End Function

    Private Function FilterSQL(ByVal strOP As String) As String

        Dim SQLCondition As String = ""
        Dim sb As New StringBuilder
        Dim SearchQuery As String

        Try
            Dim ItemTypeCode As String = DirectCast(CmbItemTypeCode.SelectedItem, KeyValuePair(Of String, String)).Key.ToString

            sb = New StringBuilder
            With sb

                SearchQuery = Trim(TxtSearchText.Text)

                If ItemTypeCode <> "" Then

                    .Append("" & GetOP(strOP) & " ItemTypeCode = '" & ItemTypeCode & "' ") ' AND ItemGroup = '" & ItemGroup & "' ")

                End If

                If Trim(TxtSearchText.Text) <> "" Then

                    .Append("" & GetOP(strOP) & " ItemCode LIKE '%" & SearchQuery & "%' OR ItemDescription LIKE '%" & SearchQuery & "%' ")

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".FilterSQLCondition()")
        End Try

        SQLCondition = sb.ToString
        Return SQLCondition

    End Function

    Private Function GetOP(ByRef strOP As String) As String

        If strOP = "WHERE" Then
            strOP = "AND"
            GetOP = "WHERE"
        Else
            GetOP = strOP
        End If

    End Function

    Private Sub PrintItem()

        Try
            'If TxtVisitID.Text = "" Then
            '    MsgBox("Please select your surgery to print.", MsgBoxStyle.Critical, "No Surgery Loaded")
            '    Exit Sub
            'End If

            '            Process.Start(My.Application.Info.DirectoryPath & "/Reports/Surgery.exe", Trim(TxtVisitID.Text))
            Process.Start(My.Application.Info.DirectoryPath & "/Reports/Surgery.exe")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PrintSurgery")
        End Try

    End Sub

    Private Sub DgvItemListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItemListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    'ItemCode = DgvItemListing.Rows(e.RowIndex).Cells("ItemCode").Value
                    Dim Frm As New FrmItemInformation With {
                        .UserCommand = "SHOW_ITEM_INFO",
                        .ItemCode = DgvItemListing.Rows(e.RowIndex).Cells("DgvListItemCode").Value,
                        .ItemGroup = DgvItemListing.Rows(e.RowIndex).Cells("DgvListItemGroup").Value
                    }
                    Frm.Show()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvCustomerListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub TxtSearchText_KeyDown(sender As Object, e As EventArgs) Handles TxtSearchText.KeyDown

        Dim EnterKey As System.Windows.Forms.KeyEventArgs = e

        Try
            If EnterKey.KeyCode = Keys.Enter Then
                EnterKey.SuppressKeyPress = True
                PopulateItemList()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RbServices_Click(sender As Object, e As EventArgs) Handles RbServices.Click
        'PopulateServiceProductListing()
        PopulateItemType()
        PopulateItemList()
    End Sub

    Private Sub RbProducts_Click(sender As Object, e As EventArgs) Handles RbProducts.Click
        'PopulateServiceProductListing()
        PopulateItemType()
        PopulateItemList()
    End Sub

    Private Sub CmbItemTypeCode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbItemTypeCode.SelectionChangeCommitted
        PopulateItemList()
    End Sub

    Private Sub BtnAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAddNewItem.Click
        FrmItemInformation.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        'PopulateServiceProductListing()
        PopulateItemList()
    End Sub

    Private Sub RbServices_CheckedChanged(sender As Object, e As EventArgs) Handles RbServices.CheckedChanged
        If RbServices.Checked = True Then
            ItemGroup = "SVC"
        Else
            ItemGroup = "PRD"
        End If
    End Sub

    Private Sub RbProducts_CheckedChanged(sender As Object, e As EventArgs) Handles RbProducts.CheckedChanged
        If RbProducts.Checked = True Then
            ItemGroup = "PRD"
        Else
            ItemGroup = "SVC"
        End If
    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        PopulateItemList()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintItem()
    End Sub

End Class