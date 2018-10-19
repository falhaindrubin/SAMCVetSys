Public Class FrmWardRecords

    Private Sub FrmWardRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateWardListing()
    End Sub

    Private Sub PopulateWardListing()

        Dim DtWard As New DataTable
        Dim ClsWard As New ClsWard

        Try
            DtWard = ClsWard.GetWardListing(ClsWard)
            If DtWard.Rows.Count > 0 Then
                DgvWardListing.DataSource = DtWard
                DgvWardListing.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateWardListing()")
        End Try

    End Sub

    Private Sub DgvWardListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvWardListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmWardInformation With {
                        .UserCommand = "SHOW_WARD_INFO",
                        .WardID = DgvWardListing.Rows(e.RowIndex).Cells("WardID").Value,
                        .CustomerID = DgvWardListing.Rows(e.RowIndex).Cells("CustomerID").Value,
                        .VisitID = DgvWardListing.Rows(e.RowIndex).Cells("VisitID").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvCustomerListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateWardListing()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnAddNewWard_Click(sender As Object, e As EventArgs) Handles BtnAddNewWard.Click
        With FrmWardInformation
            .ShowDialog()
        End With
    End Sub
End Class