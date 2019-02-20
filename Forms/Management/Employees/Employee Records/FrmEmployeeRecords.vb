Public Class FrmEmployeeRecords

    Private Sub PopulateEmployees()

        Try
            Dim DtEmp As New DataTable
            Dim ClsEmployee As New ClsEmployee

            With ClsEmployee
                DtEmp = .GetEmployee(ClsEmployee)

                If DtEmp.Rows.Count > 0 Then

                    With DgvEmployeeListing
                        .Rows.Clear()
                        For i As Integer = 0 To DtEmp.Rows.Count - 1
                            .Rows.Add()
                            .Rows(i).Cells("EmployeeID").Value = DtEmp.Rows(i).Item("EmployeeID")
                            .Rows(i).Cells("EmployeeName").Value = DtEmp.Rows(i).Item("EmployeeName")
                            .Rows(i).Cells("NRICPassportNo").Value = DtEmp.Rows(i).Item("NRICPassportNo")
                            .Rows(i).Cells("PositionName").Value = DtEmp.Rows(i).Item("PositionName")
                            .Rows(i).Cells("IsActive").Value = IIf(DtEmp.Rows(i).Item("IsActive") = "1", "ACTIVE", "INACTIVE")
                            .Rows(i).Cells("CreatedBy").Value = DtEmp.Rows(i).Item("CreatedBy")
                            .Rows(i).Cells("DateCreated").Value = DtEmp.Rows(i).Item("DateCreated")
                        Next

                    End With
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateEmployees()")
        End Try

    End Sub

    Private Sub FrmEmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateEmployees()
    End Sub

    Private Sub BtnAddNewAppointment_Click(sender As Object, e As EventArgs) Handles BtnAddNewEmployee.Click
        FrmEmployeeInformation.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateEmployees()
    End Sub

    Private Sub DgvEmployeeListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmployeeListing.CellDoubleClick

        Dim EmployeeID As String

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    EmployeeID = DgvEmployeeListing.Rows(e.RowIndex).Cells("EmployeeID").Value
                    'VisitID = DgvEmployeeListing.Rows(e.RowIndex).Cells("VisitID").Value
                    Dim Frm As New FrmEmployeeInformation With {
                        .UserCommand = "SHOW_CUSTOMER_CONSULTATION",
                        .EmployeeID = EmployeeID
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvEmployeeListing_CellDoubleClick()")
        End Try

    End Sub

End Class