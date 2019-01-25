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

                    With DgvSurgeryListing

                        .Rows.Clear()

                        For i As Integer = 0 To DtSurgery.Rows.Count - 1
                            .Rows.Add()
                            .Rows(i).Cells("CaseID").Value = DtSurgery.Rows(i).Item("CaseID")
                            .Rows(i).Cells("EvaluationDate").Value = DtSurgery.Rows(i).Item("EvaluationDate")
                            .Rows(i).Cells("EmployeeName").Value = "DR. " & DtSurgery.Rows(i).Item("EmployeeName")
                            .Rows(i).Cells("CustomerID").Value = DtSurgery.Rows(i).Item("CustomerID")
                            .Rows(i).Cells("CustomerName").Value = DtSurgery.Rows(i).Item("CustomerName")
                            .Rows(i).Cells("PetName").Value = DtSurgery.Rows(i).Item("PetName")
                            .Rows(i).Cells("SurgeryDiagnosis").Value = DtSurgery.Rows(i).Item("SurgeryDiagnosis")
                            .Rows(i).Cells("AnimalTypeName").Value = DtSurgery.Rows(i).Item("AnimalTypeName")
                            .Rows(i).Cells("BreedName").Value = DtSurgery.Rows(i).Item("BreedName")
                            .Rows(i).Cells("Status").Value = GetSurgeryStatus(DtSurgery, i) 'DtSurgery.Rows(i).Item("BreedName")
                        Next

                    End With

                    'DgvSurgeryListing.DataSource = DtSurgery
                    'DgvSurgeryListing.Show()

                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSurgeryListing_CellDoubleClick()")
        End Try

    End Sub

    Private Function GetSurgeryStatus(DtSurgery As DataTable, i As Integer) As String

        Dim SxStatus As String = ""

        Try
            If DtSurgery.Rows(i).Item("IsDelayed") = "1" Then
                SxStatus = "DELAYED"
            ElseIf DtSurgery.Rows(i).Item("IsOnGoing") = "1" Then
                SxStatus = "ON-GOING"
            ElseIf DtSurgery.Rows(i).Item("IsCancelled") = "1" Then
                SxStatus = "CANCELLED"
            ElseIf DtSurgery.Rows(i).Item("IsCompleted") = "1" Then
                SxStatus = "COMPLETED"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".GetSurgeryStatus()")
        End Try

        Return SxStatus

    End Function

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