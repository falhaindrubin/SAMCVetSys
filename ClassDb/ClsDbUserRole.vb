Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbUserRole

    Dim Sb As New StringBuilder
    Dim Cmd As New OdbcCommand
    Dim Da As New OdbcDataAdapter

    Public Function AddNewRole(R As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                '.Append("INSERT INTO samc_user ")
                '.Append("(UserID, EmployeeID, UserPassword, UserRole, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                '.Append("VALUES ")
                '.Append("('" & R.UserID & "', '" & R.EmployeeID & "', '" & USER.UserPassword & "', '" & USER.UserRole & "', ")
                '.Append("'" & USER.Ref.CreatedBy & "', " & CSQLDateTime(USER.Ref.DateCreated) & ", '" & USER.Ref.ModifiedBy & "', '" & CSQLDateTime(USER.Ref.DateModified) & "') ")
                '.Append("ON DUPLICATE KEY UPDATE ")
                '.Append("UserPassword = '" & USER.UserPassword & "', UserRole = '" & USER.UserRole & "', ModifiedBy = '" & USER.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(USER.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUser.AddNewUser()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetUserRole(R As ClsUserRole) As DataTable

        Dim DtUser As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT UserRole, UserRoleDescription, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_userrole ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtUser)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUserRole.GetUserInformation()")
        End Try

        Return DtUser

    End Function

End Class
