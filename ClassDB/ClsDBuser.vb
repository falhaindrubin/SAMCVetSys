Imports System.Text

Public Class ClsDBUser

    Dim Sb As New StringBuilder
    Dim Cmd As New OdbcCommand
    Dim Da As New OdbcDataAdapter

    Public Function AddNewUser(USER As ClsUser, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUser.AddNewUser()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetUserInformation(U As ClsUser) As DataTable

        Dim DtUser As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.EmployeeID, EmployeeName, SaluteCode, SaluteName, NRICPassportNo, SexCode, SexName, EmployeeDOB, EmployeePOB, Nationality, ")
                .Append("AddressLine1, AddressLine2, AddressLine3, AddressLine4, Race, Religion, MaritalStatusCode, MaritalStatusName, ")
                .Append("PositionCode, PositionName, Qualification, Institution, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_employee a ")
                .Append("INNER JOIN samc_user b ON a.EmployeeID = b.EmployeeID ")
                .Append("WHERE b.UserID = '" & U.UserID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtUser)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUser.GetUserInformation()")
        End Try

        Return DtUser

    End Function

End Class
