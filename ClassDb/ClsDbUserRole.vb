Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbUserRole

    Dim Sb As New StringBuilder
    Dim Cmd As New OdbcCommand
    Dim Da As New OdbcDataAdapter

    Public Function AddRole(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_userrole ")
                .Append("(RoleCode, RoleName, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & R.RoleCode & "', '" & CSQLQuote(R.RoleName) & "', ")
                .Append("'" & R.Ref.CreatedBy & "',  " & CSQLDateTime(R.Ref.DateCreated) & ", '" & R.Ref.ModifiedBy & "', " & CSQLDateTime(R.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("RoleName = '" & R.RoleName & "', ")
                .Append("ModifiedBy = '" & R.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(R.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.AddNewRole()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddRoleAccessRight(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_userrole_accessright ")
                .Append("(RoleCode, RoleName, AccessTag, HasAccess, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & R.RoleCode & "', '" & CSQLQuote(R.RoleName) & "', '" & R.AccessTag & "', '" & R.HasAccess & "', ")
                .Append("'" & R.Ref.CreatedBy & "', " & CSQLDateTime(R.Ref.DateCreated) & ", '" & R.Ref.ModifiedBy & "', " & CSQLDateTime(R.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("RoleName = '" & CSQLQuote(R.RoleName) & "', AccessTag = '" & R.AccessTag & "', ")
                .Append("ModifiedBy = '" & R.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(R.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.AddNewRoleAccessRight()")
            Return False
        End Try

        'Return IIf(Ret = 0, False, True)
        Return True

    End Function

    Public Function AddUserAccessRight(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_user_accessright ")
                .Append("(EmployeeID, RoleCode, RoleName, AccessTag, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & R.EmployeeID & "', '" & R.RoleCode & "', '" & R.RoleName & "', '" & R.AccessTag & "', ")
                .Append("'" & R.Ref.CreatedBy & "', " & CSQLDateTime(R.Ref.DateCreated) & ", '" & R.Ref.ModifiedBy & "', " & CSQLDateTime(R.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("RoleCode = '" & R.RoleCode & "', RoleName = '" & R.RoleName & "', AccessTag = '" & R.AccessTag & "', ")
                .Append("ModifiedBy = '" & R.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(R.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.AddUserAccessRight()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function DeleteRole(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_userrole ")
                .Append("WHERE RoleCode = '" & R.RoleCode & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.DeleteRole()")
            Return False
        End Try

        Return True

    End Function

    Public Function DeleteAccessRight(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_userrole_accessright ")
                .Append("WHERE ")
                .Append("RoleCode = '" & R.RoleCode & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.DeleteAccessRight()")
            Return False
        End Try

        Return True

    End Function

    Public Function DeleteUserAccessRight(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_user_accessright ")
                .Append("WHERE ")
                .Append("EmployeeID = '" & R.EmployeeID & "' AND RoleCode = '" & R.RoleCode & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.DeleteUserAccessRight()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetRole(R As ClsUserRole) As DataTable

        Dim DtUser As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT RoleCode, RoleName, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_userrole ")

                If R.RoleCode <> "" Then
                    .Append("WHERE RoleCode = '" & R.RoleCode & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtUser)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.GetUserInformation()")
        End Try

        Return DtUser

    End Function

    Public Function GetRoleAccessRight(R As ClsUserRole) As DataTable

        Dim DtAccessRight As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT RoleCode, RoleName, AccessTag, HasAccess, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_userrole_accessright ")

                If R.RoleCode <> "" Then
                    .Append("WHERE RoleCode  = '" & R.RoleCode & "' ")
                End If

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAccessRight)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.GetRoleAccessRight()")
        End Try

        Return DtAccessRight

    End Function

    Public Function GetUserAccessRight(R As ClsUserRole) As DataTable

        Dim DtUserAccessRight As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT EmployeeID, RoleCode, RoleName, AccessTag, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_user_accessright ")
                .Append("WHERE EmployeeID = '" & R.EmployeeID & "' AND RoleCode = '" & R.RoleCode & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtUserAccessRight)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.GetRoleAccessRight()")
        End Try

        Return DtUserAccessRight

    End Function

End Class
