Public Class FrmPharmacyRecords

    Private Sub FrmPharmacyRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulatePharmacyRequest()
    End Sub

    Private Sub PopulatePharmacyRequest()

        Try
            Dim DtRequest As New DataTable
            Dim ClsPharmacy As New ClsPharmacy

            With ClsPharmacy
                DtRequest = .GetPharmacyRequest(ClsPharmacy)

                If DtRequest.Rows.Count > 0 Then

                    With DgvPharmacyRecords
                        .Rows.Clear()

                        For i As Integer = 0 To DtRequest.Rows.Count - 1
                            .Rows.Add()
                            .Rows(i).Cells("VisitID").Value = DtRequest.Rows(i).Item("VisitID")
                            .Rows(i).Cells("RequestID").Value = DtRequest.Rows(i).Item("RequestID")
                            .Rows(i).Cells("RequestDate").Value = DtRequest.Rows(i).Item("RequestDate")
                            .Rows(i).Cells("RqEmpID").Value = DtRequest.Rows(i).Item("RqEmpID")
                            .Rows(i).Cells("RqEmpName").Value = DtRequest.Rows(i).Item("RqEmpName")
                            .Rows(i).Cells("PhEmpID").Value = DtRequest.Rows(i).Item("PhEmpID")
                            .Rows(i).Cells("PhEmpName").Value = DtRequest.Rows(i).Item("PhEmpName")
                            .Rows(i).Cells("ApprovalDate").Value = DtRequest.Rows(i).Item("ApprovalDate")
                            .Rows(i).Cells("IsCompleted").Value = IIf(DtRequest.Rows(i).Item("IsCompleted") = "1", "COMPLETED", "PENDING")
                        Next

                    End With

                    'DgvPharmacyRecords.DataSource = DtRequest
                    'DgvPharmacyRecords.Show()
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulatePharmacyRequest()")
        End Try

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulatePharmacyRequest()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DgvPharmacyRecords_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPharmacyRecords.CellDoubleClick

        Dim VisitID As String
        Dim RequestID As String

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    VisitID = DgvPharmacyRecords.Rows(e.RowIndex).Cells("VisitID").Value
                    RequestID = DgvPharmacyRecords.Rows(e.RowIndex).Cells("RequestID").Value
                    Dim Frm As New FrmPharmacyRequest With {
                        .VisitID = VisitID,
                        .RequestID = RequestID
                    }
                    Frm.ShowDialog()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvPharmacyRecords_CellDoubleClick()")
        End Try

    End Sub



End Class