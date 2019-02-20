Public Class FrmTreatmentRecords

    Private Sub FrmTreatmentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateIncompleteVisit()
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        With FrmTreatmentInformation
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
                With DgvTreatmentListing
                    .Rows.Clear()

                    For i As Integer = 0 To DtIncompleteVisit.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("VisitID").Value = DtIncompleteVisit.Rows(i).Item("VisitID")
                        .Rows(i).Cells("CustomerName").Value = DtIncompleteVisit.Rows(i).Item("CustomerName")
                        .Rows(i).Cells("CustomerID").Value = DtIncompleteVisit.Rows(i).Item("CustomerID")
                        .Rows(i).Cells("PetName").Value = DtIncompleteVisit.Rows(i).Item("PetName")
                        .Rows(i).Cells("EmployeeID").Value = DtIncompleteVisit.Rows(i).Item("EmployeeID")
                        .Rows(i).Cells("EmployeeName").Value = "DR. " & DtIncompleteVisit.Rows(i).Item("EmployeeName")
                        .Rows(i).Cells("VisitTime").Value = DtIncompleteVisit.Rows(i).Item("VisitTime")
                        .Rows(i).Cells("IsVisitCompleted").Value = IIf(DtIncompleteVisit.Rows(i).Item("IsCompleted") = "1", "COMPLETED", "ON-GOING")
                    Next
                End With
                'DgvTreatmentListing.DataSource = DtIncompleteVisit
                'DgvTreatmentListing.Show()
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
                    Dim Frm As New FrmTreatmentInformation With {
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
