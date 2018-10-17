Public Class FrmItemManagement

    Private Sub BtnAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAddNewItem.Click
        FrmItemEntry.ShowDialog()
    End Sub

    Private Sub FrmItemManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateServiceProductListing()
        Application.DoEvents()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateServiceProductListing()
    End Sub

    Private Sub PopulateServiceProductListing()

        Dim DtItemListing As New DataTable
        Dim DtServices As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts

        Try
            If RbServices.Checked = True Then
                DtServices = ClsServices.GetServiceList(ClsServices)
                If DtServices.Rows.Count > 0 Then
                    DgvItemListing.DataSource = DtServices
                    DgvItemListing.Show()
                Else
                    DgvItemListing.DataSource = Nothing
                    DgvItemListing.Show()
                End If

            ElseIf RbProducts.Checked = True Then
                DtProducts = ClsProducts.GetProductList(ClsProducts)
                If DtProducts.Rows.Count > 0 Then
                    DgvItemListing.DataSource = DtProducts
                    DgvItemListing.Show()
                Else
                    DgvItemListing.DataSource = Nothing
                    DgvItemListing.Show()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateServiceProductListing()")
        End Try

    End Sub

    Private Sub DgvItemListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItemListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    'ItemCode = DgvItemListing.Rows(e.RowIndex).Cells("ItemCode").Value
                    Dim Frm As New FrmItemEntry With {
                        .UserCommand = "SHOW_ITEM_INFO",
                        .ItemCode = DgvItemListing.Rows(e.RowIndex).Cells("ItemCode").Value,
                        .ItemGroup = DgvItemListing.Rows(e.RowIndex).Cells("ItemGroup").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvCustomerListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub RbServices_Click(sender As Object, e As EventArgs) Handles RbServices.Click
        PopulateServiceProductListing()
    End Sub

    Private Sub RbProducts_Click(sender As Object, e As EventArgs) Handles RbProducts.Click
        PopulateServiceProductListing()
    End Sub

End Class