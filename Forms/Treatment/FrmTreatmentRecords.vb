Public Class FrmTreatmentRecords

    Private Sub FrmTreatmentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateIncompleteVisit()
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        With FrmTreatmentEntry
            .UserCommand = "ADD_NEW_TREATMENT"
            .ShowDialog()
        End With
    End Sub

    Private Sub PopulateIncompleteVisit()

        Dim DtIncompleteVisit As New DataTable
        Dim ClsVisit As New ClsVisit

        Try
            DtIncompleteVisit = ClsVisit.GetIncompleteVisitListing(ClsVisit)
            If DtIncompleteVisit.Rows.Count > 0 Then
                DgvTreatmentListing.DataSource = DtIncompleteVisit
                DgvTreatmentListing.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateIncompleteVisit()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateIncompleteVisit()
    End Sub

    Private Sub DgvTreatmentListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTreatmentListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmTreatmentEntry With {
                        .UserCommand = "SHOW_TREATMENT_INFO",
                        .CustomerID = DgvTreatmentListing.Rows(e.RowIndex).Cells("CustomerID").Value,
                        .VisitID = DgvTreatmentListing.Rows(e.RowIndex).Cells("VisitID").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvCustomerListing_CellDoubleClick()")
        End Try

    End Sub
End Class
