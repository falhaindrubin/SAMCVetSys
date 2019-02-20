Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbEmployee

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewEmployee(EMP As ClsEmployee, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_employee ")
                .Append("(EmployeeID, EmployeeName, SaluteCode, SaluteName, NRICPassportNo, SexCode, SexName, EmployeeDOB, EmployeePOB, Nationality, MobileNo, TelNo, Email, ")
                .Append("AddressLine1, AddressLine2, AddressLine3, AddressLine4, Postcode, City, State, Country, ")
                .Append("Race, Religion, ")
                .Append("MaritalStatusCode, MaritalStatusName, PositionCode, PositionName, Qualification, Institution, IsActive, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & EMP.EmployeeID & "', '" & EMP.EmployeeName & "', '" & EMP.SaluteCode & "', '" & EMP.SaluteName & "', '" & EMP.NRICPassportNo & "', '" & EMP.SexCode & "', '" & EMP.SexName & "', " & CSQLDate(EMP.EmployeeDOB) & ", '" & CSQLQuote(EMP.EmployeePOB) & "', '" & CSQLQuote(EMP.Nationality) & "', ")
                .Append("'" & EMP.MobileNo & "', '" & EMP.TelNo & "', '" & EMP.Email & "', ")
                .Append("'" & CSQLQuote(EMP.AddressLine1) & "', '" & CSQLQuote(EMP.AddressLine2) & "', '" & CSQLQuote(EMP.AddressLine3) & "', '" & CSQLQuote(EMP.AddressLine4) & "', ")
                .Append("'" & EMP.Postcode & "', '" & EMP.City & "', '" & EMP.State & "', '" & EMP.Country & "', ")
                .Append("'" & CSQLQuote(EMP.Race) & "', '" & CSQLQuote(EMP.Religion) & "', ")
                .Append("'" & EMP.MaritalStatusCode & "', '" & EMP.MaritalStatusName & "', '" & EMP.PositionCode & "', '" & EMP.PositionName & "', '" & CSQLQuote(EMP.Qualification) & "', '" & CSQLQuote(EMP.Institution) & "', '" & EMP.IsActive & "', ")
                .Append("'" & EMP.Ref.CreatedBy & "', " & CSQLDateTime(EMP.Ref.DateCreated) & ", '" & EMP.Ref.ModifiedBy & "', " & CSQLDateTime(EMP.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("EmployeeName = '" & EMP.EmployeeName & "', SaluteCode = '" & EMP.SaluteCode & "', SaluteName = '" & EMP.SaluteName & "', NRICPassportNo = '" & EMP.NRICPassportNo & "', SexCode = '" & EMP.SexCode & "', SexName = '" & EMP.SexName & "', ")
                .Append("EmployeeDOB = " & CSQLDate(EMP.EmployeeDOB) & ", EmployeePOB = '" & EMP.EmployeePOB & "', Nationality = '" & EMP.Nationality & "', ")
                .Append("MobileNo = '" & EMP.MobileNo & "', TelNo = '" & EMP.TelNo & "', Email = '" & EMP.Email & "', ")
                .Append("AddressLine1 = '" & EMP.AddressLine1 & "', AddressLine2 = '" & EMP.AddressLine2 & "', AddressLine3 = '" & EMP.AddressLine3 & "', AddressLine4 = '" & EMP.AddressLine4 & "', ")
                .Append("Postcode = '" & EMP.Postcode & "', City = '" & EMP.City & "', State = '" & EMP.State & "', Country = '" & EMP.Country & "', ")
                .Append("Race = '" & EMP.Race & "', Religion = '" & EMP.Religion & "', ")
                .Append("MaritalStatusCode = '" & EMP.MaritalStatusCode & "', MaritalStatusName = '" & EMP.MaritalStatusName & "', PositionCode = '" & EMP.PositionCode & "', PositionName = '" & EMP.PositionName & "', Qualification = '" & EMP.Qualification & "', Institution = '" & EMP.Institution & "', IsActive = '" & EMP.IsActive & "', ")
                .Append("ModifiedBy = '" & EMP.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(EMP.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbEmployee.AddNewEmployee()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetEmployee(EMP As ClsEmployee) As DataTable

        Dim DtEmp As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT EmployeeID, EmployeeName, NRICPassportNo, SaluteCode, SaluteName, SexCode, SexName, EmployeeDOB, EmployeePOB, ")
                .Append("Nationality, MobileNo, TelNo, Email, AddressLine1, AddressLine2, AddressLine3, AddressLine4, Postcode, City, State, Country, ")
                .Append("Race, Religion, MaritalStatusCode, MaritalStatusName, ")
                .Append("PositionCode, PositionName, Qualification, Institution, ")
                .Append("IsActive, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_employee ")

                If EMP.EmployeeID <> "" Then
                    .Append("WHERE EmployeeID = '" & EMP.EmployeeID & "' ")
                End If

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtEmp)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbEmployee.GetEmployee()")
        End Try

        Return DtEmp

    End Function

    Public Function GetVet(ByVal EMP As ClsEmployee) As DataTable

        Dim DtVet As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT * ")
                .Append("FROM samc_employee ")
                .Append("WHERE PositionCode = '01' ")
                .Append("ORDER BY EmployeeName ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
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

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
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

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
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

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSex)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.GetSex()")
        End Try

        Return DtSex

    End Function

End Class
