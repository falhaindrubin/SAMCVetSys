Public Class FrmRoleRecords

    Private Sub FrmRoleRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateRoles()
        Application.DoEvents()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PopulateRoles()

        Try
            Dim ClsUserRole As New ClsUserRole
            Dim DtRole As New DataTable

            With ClsUserRole

                DtRole = .GetRole(ClsUserRole)

                If DtRole.Rows.Count > 0 Then

                    With DgvRoleListing

                        .Rows.Clear()

                        For i As Integer = 0 To DtRole.Rows.Count - 1
                            .Rows.Add()
                            .Rows(i).Cells("RoleCode").Value = DtRole.Rows(i).Item("RoleCode")
                            .Rows(i).Cells("RoleName").Value = DtRole.Rows(i).Item("RoleName")
                        Next

                    End With

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateRoles()")
        End Try

    End Sub

    Private Sub DgvRoleListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRoleListing.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmRoleInformation With {
                        .RoleCode = DgvRoleListing.Rows(e.RowIndex).Cells("RoleCode").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvRoleListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNewRole_Click(sender As Object, e As EventArgs) Handles BtnAddNewRole.Click
        FrmRoleInformation.ShowDialog()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateRoles()
    End Sub

    Private Sub DgvRoleListing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRoleListing.CellContentClick

        Dim UserResponse As MsgBoxResult
        Dim RoleCode As String

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Item?")
                    If UserResponse = MsgBoxResult.Yes Then

                        RoleCode = DgvRoleListing.Rows(e.RowIndex).Cells("RoleCode").Value

                        If DeleteRole(RoleCode) = True Then
                            DgvRoleListing.Rows.RemoveAt(e.RowIndex)
                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvRoleListing_CellContentClick()")
        End Try

    End Sub

    Private Function DeleteRole(RoleCode As String) As Boolean

        Try
            Dim ClsUserRole As New ClsUserRole

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            With ClsUserRole

                .RoleCode = RoleCode

                If Not .DeleteRole(ClsUserRole, DbConn, DbTrans) Then
                    MsgBox("Failed to update role.", MsgBoxStyle.Critical, FORM_NAME & "Role Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                If Not .DeleteAccessRight(ClsUserRole, DbConn, DbTrans) Then
                    MsgBox("Failed to update role access right.", MsgBoxStyle.Critical, FORM_NAME & "Role Access Right Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            MsgBox("Role has been removed.", MsgBoxStyle.Information, "Role Removed")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DeleteRole()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function


End Class