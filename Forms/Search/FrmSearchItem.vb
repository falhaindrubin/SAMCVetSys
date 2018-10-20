Public Class FrmSearchItem

#Region "FormProperty"
    Private _ItemCode As String
    Public Property ItemCode As String
        Get
            Return _ItemCode
        End Get
        Set(value As String)
            _ItemCode = value
        End Set
    End Property

    Private _ItemDescription As String
    Public Property ItemDescription As String
        Get
            Return _ItemDescription
        End Get
        Set(value As String)
            _ItemDescription = value
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

    Private _UnitPrice As Decimal
    Public Property UnitPrice As Decimal
        Get
            Return _UnitPrice
        End Get
        Set(value As Decimal)
            _UnitPrice = value
        End Set
    End Property

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property
#End Region

    Private Sub FrmSearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        If RbServices.Checked = True Then
            PopulateServiceTypeListing()
        ElseIf RbProducts.Checked = True Then
            PopulateProductTypeListing()
        End If

        PopulateItemListing()
        TxtSearchText.Select()
    End Sub

    Private Sub PopulateItemListing()

        Try
            If RbServices.Checked = True Then
                PopulateServiceListing()

            ElseIf RbProducts.Checked = True Then
                PopulateProductListing()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateItemListing()")
        End Try

    End Sub

    Private Sub PopulateServiceTypeListing()

        Dim DtServicesType As New DataTable
        Dim DtServices As New DataTable
        Dim ClsServices As New ClsServices
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtServicesType = ClsServices.GetServiceTypeList(ClsServices)
            If DtServicesType.Rows.Count > 0 Then
                CmbSource.Clear()
                For i As Integer = 0 To DtServicesType.Rows.Count - 1
                    CmbSource.Add(DtServicesType.Rows(i).Item("ItemTypeCode"), DtServicesType.Rows(i).Item("ItemTypeDescription"))
                Next
                RbServices.Tag = DtServicesType.Rows(0).Item("ItemGroup").ToString
            End If

            If CmbItemTypeDescription.Items.Count > 0 Then
                CmbItemTypeDescription.DataSource = Nothing
                CmbItemTypeDescription.Items.Clear()
            End If

            CmbItemTypeDescription.DataSource = New BindingSource(CmbSource, Nothing)
            CmbItemTypeDescription.DisplayMember = "Value"
            CmbItemTypeDescription.ValueMember = "Key"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateServiceTypeListing()")
        End Try

    End Sub

    Private Sub PopulateProductTypeListing()

        Dim DtProductsType As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsProducts As New ClsProducts
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtProductsType = ClsProducts.GetProductTypeList(ClsProducts)
            If DtProductsType.Rows.Count > 0 Then
                CmbSource.Clear()
                For i As Integer = 0 To DtProductsType.Rows.Count - 1
                    CmbSource.Add(DtProductsType.Rows(i).Item("ItemTypeCode"), DtProductsType.Rows(i).Item("ItemTypeDescription"))
                Next
                RbProducts.Tag = DtProductsType.Rows(0).Item("ItemGroup").ToString
            End If

            If CmbItemTypeDescription.Items.Count > 0 Then
                CmbItemTypeDescription.DataSource = Nothing
                CmbItemTypeDescription.Items.Clear()
            End If

            CmbItemTypeDescription.DataSource = New BindingSource(CmbSource, Nothing)
            CmbItemTypeDescription.DisplayMember = "Value"
            CmbItemTypeDescription.ValueMember = "Key"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateProductTypeListing()")
        End Try

    End Sub

    Private Sub PopulateServiceListing()

        Dim DtServicesType As New DataTable
        Dim DtServices As New DataTable
        Dim ClsServices As New ClsServices
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtServices = ClsServices.GetServiceList(ClsServices)
            If DtServices.Rows.Count > 0 Then

                Dim DvServices As New DataView
                Dim DtSelectedServices As New DataTable
                DvServices = DtServices.DefaultView
                DvServices.RowFilter = "ItemTypeCode = '" & DirectCast(CmbItemTypeDescription.SelectedItem, KeyValuePair(Of String, String)).Key.ToString & "'"
                With DtSelectedServices
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

                For i As Integer = 0 To DvServices.Count - 1
                    DtSelectedServices.Rows.Add(
                        DvServices(i)("ItemCode").ToString,
                        DvServices(i)("ItemDescription").ToString,
                        DvServices(i)("ItemGroup").ToString,
                        DvServices(i)("ItemTypeCode").ToString,
                        DvServices(i)("ItemTypeDescription").ToString,
                        DvServices(i)("UnitPrice").ToString,
                        DvServices(i)("CreatedBy").ToString,
                        DvServices(i)("DateCreated").ToString,
                        DvServices(i)("ModifiedBy").ToString,
                        DvServices(i)("DateModified").ToString)
                Next

                With DgvSearchResult
                    .DataSource = DtSelectedServices
                    .Columns("ItemDescription").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns("ItemTypeDescription").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                    .Columns("ItemGroup").Visible = False
                    .Columns("ItemTypeCode").Visible = False
                    .Columns("CreatedBy").Visible = False
                    .Columns("DateCreated").Visible = False
                    .Columns("ModifiedBy").Visible = False
                    .Columns("DateModified").Visible = False
                    .Show()
                End With

            Else
                DgvSearchResult.DataSource = Nothing
                DgvSearchResult.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateServiceListing()")
        End Try

    End Sub

    Private Sub PopulateProductListing()

        Dim DtProductsType As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsProducts As New ClsProducts
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtProducts = ClsProducts.GetProductList(ClsProducts)

            If DtProducts.Rows.Count > 0 Then

                Dim DvProducts As New DataView
                Dim DtSelectedProducts As New DataTable
                DvProducts = DtProducts.DefaultView
                DvProducts.RowFilter = "ItemTypeCode = '" & DirectCast(CmbItemTypeDescription.SelectedItem, KeyValuePair(Of String, String)).Key.ToString & "'"
                With DtSelectedProducts
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

                For i As Integer = 0 To DvProducts.Count - 1
                    DtSelectedProducts.Rows.Add(
                        DvProducts(i)("ItemCode").ToString,
                        DvProducts(i)("ItemDescription").ToString,
                        DvProducts(i)("ItemGroup").ToString,
                        DvProducts(i)("ItemTypeCode").ToString,
                        DvProducts(i)("ItemTypeDescription").ToString,
                        DvProducts(i)("UnitPrice").ToString,
                        DvProducts(i)("CreatedBy").ToString,
                        DvProducts(i)("DateCreated").ToString,
                        DvProducts(i)("ModifiedBy").ToString,
                        DvProducts(i)("DateModified").ToString)
                Next

                With DgvSearchResult
                    .DataSource = DtSelectedProducts
                    .Columns("ItemDescription").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns("ItemTypeDescription").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                    .Columns("ItemGroup").Visible = False
                    .Columns("ItemTypeCode").Visible = False
                    .Columns("CreatedBy").Visible = False
                    .Columns("DateCreated").Visible = False
                    .Columns("ModifiedBy").Visible = False
                    .Columns("DateModified").Visible = False
                    .Show()
                End With
            Else
                DgvSearchResult.DataSource = Nothing
                DgvSearchResult.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateItemListing()")
        End Try

    End Sub

    Private Sub DgvSearchResult_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSearchResult.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    ItemCode = DgvSearchResult.Rows(e.RowIndex).Cells("ItemCode").Value
                    ItemDescription = DgvSearchResult.Rows(e.RowIndex).Cells("ItemDescription").Value
                    UnitPrice = DgvSearchResult.Rows(e.RowIndex).Cells("UnitPrice").Value
                    ItemGroup = DgvSearchResult.Rows(e.RowIndex).Cells("ItemGroup").Value
                    ItemTypeCode = DgvSearchResult.Rows(e.RowIndex).Cells("ItemTypeCode").Value
                    ItemTypeDescription = IIf(IsDBNull(DgvSearchResult.Rows(e.RowIndex).Cells("ItemTypeDescription").Value), "", DgvSearchResult.Rows(e.RowIndex).Cells("ItemTypeDescription").Value)
                End If
            End If

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSearchResult_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub RbProducts_Click(sender As Object, e As EventArgs) Handles RbProducts.Click
        PopulateProductTypeListing()
        PopulateItemListing()
    End Sub

    Private Sub RbServices_Click(sender As Object, e As EventArgs) Handles RbServices.Click
        PopulateServiceTypeListing()
        PopulateItemListing()
    End Sub

    Private Sub CmbItemTypeDescription_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbItemTypeDescription.SelectionChangeCommitted
        PopulateItemListing()
    End Sub

End Class