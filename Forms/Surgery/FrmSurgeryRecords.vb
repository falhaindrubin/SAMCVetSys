Public Class FrmSurgeryRecords

    Private Sub FrmSurgeryRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateSurgeryListing()
    End Sub

    Private Sub PopulateSurgeryListing()

        Try
            Dim ClsSurgery As New ClsSurgery
            Dim DtSurgery As New DataTable
            With ClsSurgery
                DtSurgery = .GetSurgeryListing(ClsSurgery)
                If DtSurgery.Rows.Count > 0 Then

                    DgvSurgeryListing.DataSource = DtSurgery
                    DgvSurgeryListing.Show()

                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSurgeryListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub DgvSurgeryListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSurgeryListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmSurgeryInformation With {
                        .UserCommand = "SHOW_TREATMENT_INFO",
                        .CustomerID = DgvSurgeryListing.Rows(e.RowIndex).Cells("CustomerID").Value,
                        .CaseID = DgvSurgeryListing.Rows(e.RowIndex).Cells("CaseID").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSurgeryListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnAddNewSurgery_Click(sender As Object, e As EventArgs) Handles BtnAddNewSurgery.Click
        FrmSurgeryInformation.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateSurgeryListing()
    End Sub
End Class