Public Class FrmUserRecords

    Private Sub PopulateUsers()

        Try
            Dim ClsUser As New ClsUser
            Dim DtUser As New DataTable
            With ClsUser
                .UserID = ""
                DtUser = .GetUser(ClsUser)
                If DtUser.Rows.Count > 0 Then
                    DgvUserListing.DataSource = DtUser
                    DgvUserListing.Show()
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateUsers()")
        End Try

    End Sub

    Private Sub FrmUserRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateUsers()
    End Sub

    Private Sub BtnAddNewUser_Click(sender As Object, e As EventArgs) Handles BtnAddNewUser.Click
        FrmUserInformation.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateUsers()
    End Sub

    Private Sub DgvUserListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUserListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmUserInformation With {
                        .UserID = DgvUserListing.Rows(e.RowIndex).Cells("UserID").Value,
                        .EmployeeID = DgvUserListing.Rows(e.RowIndex).Cells("EmployeeID").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvEmployeeListing_CellDoubleClick()")
        End Try

    End Sub

End Class