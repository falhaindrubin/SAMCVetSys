Imports System.Data.Odbc
Imports System.Text

Public Class ClsDbLogin

    Dim sb As StringBuilder
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter

    Public Function GetUser(ByRef USER As ClsLogin, ByRef DBConn As OdbcConnection) As DataTable

        Dim DtUser As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT UserID, EmployeeID, EmployeeName, UserPassword, RoleCode, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_user ")
                .Append("WHERE UserID = '" & USER.UserID & "' AND UserPassword = '" & USER.Password & "'; ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtUser)

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ClsDbLogin.GetUserLoginInfo()")
        End Try

        Return DtUser

    End Function

End Class
