Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDBEmployee

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewEmployee(EMP As ClsEmployee, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_employee ")
                .Append("(EmployeeID, EmployeeName, SaluteCode, SaluteName, NRICPassportNo, SexCode, SexName, EmployeeDOB, EmployeePOB, Nationality, ")
                .Append("AddressLine1, AddressLine2, AddressLine3, AddressLine4, Race, Religion, ")
                .Append("MaritalStatusCode, MaritalStatusName, PositionCode, PositionName, Qualification, Institution, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("ON KEY DUPLICATE UPDATE ")
                .Append("('" & EMP.EmployeeID & "', '" & EMP.EmployeeName & "', '" & EMP.SaluteCode & "', '" & EMP.SaluteName & "', '" & EMP.NRICPassportNo & "', '" & EMP.SexCode & "', '" & EMP.SexName & "', ")
                .Append("" & CSQLDate(EMP.EmployeeDOB) & ", '" & EMP.EmployeePOB & "', '" & EMP.Nationality & "', ")
                .Append("'" & EMP.AddressLine1 & "', '" & EMP.AddressLine2 & "', '" & EMP.AddressLine3 & "', '" & EMP.AddressLine4 & "', '" & EMP.Race & "', '" & EMP.Religion & "', ")
                .Append("'" & EMP.MaritalStatusCode & "', '" & EMP.MaritalStatusName & "', '" & EMP.PositionCode & "', '" & EMP.PositionName & "', '" & EMP.Qualification & "', '" & EMP.Institution & "', ")
                .Append("'" & EMP.Ref.CreatedBy & "', " & CSQLDateTime(EMP.Ref.DateCreated) & ", '" & EMP.Ref.ModifiedBy & "', " & CSQLDate(EMP.Ref.DateModified) & ") ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.AddNewEmployee()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetVet(ByVal EMP As ClsEmployee) As DataTable

        Dim DtVet As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT * ")
                .Append("FROM samc_employee ")
                .Append("WHERE PositionCode = '01' ")
                .Append("ORDER BY EmpName ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVet)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.GetVet()")
        End Try

        Return DtVet

    End Function

    Public Function GetPosition(ClsEmployee) As DataTable

        Dim DtPosition As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT PositionCode, PositionName FROM samc_position ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtPosition)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.GetPosition()")
        End Try

        Return DtPosition

    End Function

    Public Function GetMaritalStatus(EMP As ClsEmployee) As DataTable

        Dim DtMaritalStatus As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT * FROM samc_maritalstatus ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtMaritalStatus)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.GetMaritalStatus()")
        End Try

        Return DtMaritalStatus

    End Function


    Public Function GetSex(EMP As ClsEmployee) As DataTable

        Dim DtSex As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT SexCode, SexName ")
                .Append("FROM samc_sex ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSex)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.GetSex()")
        End Try

        Return DtSex

    End Function

End Class
