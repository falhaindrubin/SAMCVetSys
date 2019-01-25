Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbChSource

    Dim Sb As New StringBuilder
    Dim Cmd As New OdbcCommand
    Dim Da As New OdbcDataAdapter

    Public Function AddNewUser(USER As ClsUser, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_user ")
                .Append("(UserID, EmployeeID, EmployeeName, UserPassword, UserRole, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & USER.UserID & "', '" & USER.EmployeeID & "', '" & USER.EmployeeName & "', '" & USER.UserPassword & "', '" & USER.UserRole & "', ")
                .Append("'" & USER.Ref.CreatedBy & "', " & CSQLDateTime(USER.Ref.DateCreated) & ", '" & USER.Ref.ModifiedBy & "', " & CSQLDateTime(USER.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("UserPassword = '" & USER.UserPassword & "', UserRole = '" & USER.UserRole & "', ModifiedBy = '" & USER.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(USER.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUser.AddNewUser()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetUser(U As ClsUser) As DataTable

        Dim DtUser As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT UserID, EmployeeID, EmployeeName, UserPassword, UserRole, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_user ")

                If U.UserID <> "" Then
                    .Append("WHERE UserID = '" & U.UserID & "' ")
                End If

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtUser)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUser.GetUser()")
        End Try

        Return DtUser

    End Function

    Public Function GetChSource(CS As ClsChSource) As DataTable

        Dim DtChSource As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ChSource, ChSourceName, ChSourceDescription, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_chsource ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtChSource)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsChSource.GetChSource()")
        End Try

        Return DtChSource

    End Function

End Class
