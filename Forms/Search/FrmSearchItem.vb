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
        PopulateItemListing()
        TxtSearchText.Select()
    End Sub

    Private Sub PopulateItemListing()

        Dim DtItemListing As New DataTable
        Dim DtServices As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts
        Dim CmbSource As New Dictionary(Of String, String)
        Dim DtServicesType As New DataTable
        Dim DtProductsType As New DataTable

        Try
            If RbServices.Checked = True Then
                DtServicesType = ClsServices.GetServiceTypeList(ClsServices)
                DtServices = ClsServices.GetServiceList(ClsServices)

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

                If DtServices.Rows.Count > 0 Then
                    DgvSearchResult.DataSource = DtServices
                    DgvSearchResult.Show()
                Else
                    DgvSearchResult.DataSource = Nothing
                    DgvSearchResult.Show()
                End If

            ElseIf RbProducts.Checked = True Then
                DtProductsType = ClsProducts.GetProductTypeList(ClsProducts)
                DtProducts = ClsProducts.GetProductList(ClsProducts)

                If DtProductsType.Rows.Count > 0 Then
                    CmbSource.Clear()
                    For i As Integer = 0 To DtProductsType.Rows.Count - 1
                        CmbSource.Add(DtProductsType.Rows(i).Item("ItemTypeCode"), DtProductsType.Rows(i).Item("ItemTypeDescription"))
                    Next
                    RbProducts.Tag = DtProducts.Rows(0).Item("ItemGroup").ToString
                End If

                If CmbItemTypeDescription.Items.Count > 0 Then
                    CmbItemTypeDescription.DataSource = Nothing
                    CmbItemTypeDescription.Items.Clear()
                End If

                CmbItemTypeDescription.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemTypeDescription.DisplayMember = "Value"
                CmbItemTypeDescription.ValueMember = "Key"

                If DtProducts.Rows.Count > 0 Then
                    DgvSearchResult.DataSource = DtProducts
                    DgvSearchResult.Show()
                Else
                    DgvSearchResult.DataSource = Nothing
                    DgvSearchResult.Show()
                End If

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
        PopulateItemListing()
    End Sub

    Private Sub RbServices_Click(sender As Object, e As EventArgs) Handles RbServices.Click
        PopulateItemListing()
    End Sub

End Class