Public Class FrmSearchItem

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

    Private _Price As Decimal
    Public Property Price As Decimal
        Get
            Return _Price
        End Get
        Set(value As Decimal)
            _Price = value
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

    Private Sub FrmSearchItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
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

        Try
            If RbServices.Checked = True Then
                DtServices = ClsServices.GetServiceList(ClsServices)
                If DtServices.Rows.Count > 0 Then
                    DgvSearchResult.DataSource = DtServices
                    DgvSearchResult.Show()
                Else
                    DgvSearchResult.DataSource = Nothing
                    DgvSearchResult.Show()
                End If

            ElseIf RbProducts.Checked = True Then
                DtProducts = ClsProducts.GetProductList(ClsProducts)
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
                    Price = DgvSearchResult.Rows(e.RowIndex).Cells("Price").Value
                End If
            End If

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateItemListing()")
        End Try

    End Sub

End Class