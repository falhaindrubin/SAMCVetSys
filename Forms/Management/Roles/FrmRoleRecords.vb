Public Class FrmRoleRecords

    Private Sub FrmRoleRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateRoles()
        Application.DoEvents()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNewRole_Click(sender As Object, e As EventArgs) Handles BtnAddNewRole.Click
        FrmRoleInformation.ShowDialog()
    End Sub

    Private Sub PopulateRoles()

        Try
            Dim ClsUserRole As New ClsUserRole
            Dim DtRole As New DataTable
            With ClsUserRole
                DtRole = .GetUserRole(ClsUserRole)
                If DtRole.Rows.Count > 0 Then
                    DgvRoleListing.DataSource = DtRole
                    DgvRoleListing.Show()
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateRoles()")
        End Try

    End Sub

End Class