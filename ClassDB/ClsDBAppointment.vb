Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDBAppointment

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewAppointment(ByVal APP As ClsAppointment, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_appointment ")
                .Append("(AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, AppointmentTime, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & APP.AppointmentID & "', '" & APP.EmpID & "', '" & APP.EmpName & "', '" & APP.CustomerID & "', '" & APP.CustomerName & "', " & CSQLDateTime(APP.AppointmentTime) & ", ")
                .Append("'" & APP.Ref.CreatedBy & "', " & CSQLDateTime(APP.Ref.DateCreated) & ", '" & APP.Ref.ModifiedBy & "', " & CSQLDateTime(APP.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("EmployeeID = '" & APP.EmpID & "', EmployeeName = '" & APP.EmpName & "', AppointmentTime = " & CSQLDateTime(APP.AppointmentTime) & ", ModifiedBy = '" & APP.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(APP.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.AddNewAppointment()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewAppointmentDetail(APPD As ClsAppointmentDetail, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_appointmentdetail ")
                .Append("(AppointmentID, PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, NeuterCode, NeuterName, AppointmentDescription, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & APPD.AppointmentID & "', '" & APPD.PetID & "', '" & APPD.PetName & "', " & CSQLDate(APPD.PetDOB) & ", '" & APPD.SexCode & "', '" & APPD.SexName & "', ")
                .Append("'" & APPD.AnimalTypeCode & "', '" & APPD.AnimalTypeName & "', '" & APPD.BreedCode & "', ")
                .Append("'" & APPD.BreedName & "', '" & APPD.NeuterCode & "', '" & APPD.NeuterName & "', '" & APPD.AppointmentDescription & "', ")
                .Append("'" & APPD.Ref.CreatedBy & "', " & CSQLDateTime(APPD.Ref.DateCreated) & ", '" & APPD.Ref.ModifiedBy & "', " & CSQLDateTime(APPD.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("AppointmentDescription = '" & APPD.AppointmentDescription & "', ModifiedBy = '" & APPD.Ref.ModifiedBy & "',  DateModified = " & CSQLDateTime(APPD.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.AddNewAppointmentDetail()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function UpdateAppointment(APP As ClsAppointment, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            With Sb
                .Append("UPDATE samc_appointment ")
                .Append("SET ModifiedBy = '" & APP.Ref.ModifiedBy & "', DateModified = '" & CSQLDateTime(APP.Ref.DateModified) & "' ")
                .Append("WHERE AppointmentID = '" & APP.AppointmentID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.UpdateAppointment()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function RemovePetAppointment(APP As ClsAppointment, APPD As ClsAppointmentDetail, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_appointmentdetail ")
                .Append("WHERE ")
                .Append("AppointmentID = '" & APPD.AppointmentID & "' AND PetID = '" & APPD.PetID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.RemovePetAppointment()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetAppointmentDetail(APP As ClsAppointment) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, AppointmentTime, ")
                .Append("PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, NeuterCode, NeuterName, AppointmentDescription, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_appointment a ")
                .Append("INNER JOIN samc_appointmentdetail b ON a.AppointmentID = b.AppointmentID ")

                If APP.AppointmentID <> "" Then
                    .Append("WHERE a.AppointmentID = '" & APP.AppointmentID & "' ")
                End If

            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAppointment)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.GetAppointmentDetail()")
        End Try

        Return DtAppointment

    End Function

    Public Function GetAppointmentReport(APP As ClsAppointment) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, AppointmentTime, ")
                .Append("PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, NeuterCode, NeuterName, AppointmentDescription, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_appointment a ")
                .Append("INNER JOIN samc_appointmentdetail b ON a.AppointmentID = b.AppointmentID ")
                .Append("WHERE a.AppointmentID = '" & APP.AppointmentID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAppointment)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.GetAppointmentReport")
        End Try

        Return DtAppointment

    End Function

    Public Function GetAppointmentSummary(ByVal APP As ClsAppointment, ByRef DBConn As OdbcConnection) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, a.CustomerID, a.CustomerName, a.PetID, a.PetName, SexName, PetDOB, b.AnimalTypeName, b.BreedName, b.StatusName, AppointmentTime, AppointmentDescription AS 'PetIssue' ")
                .Append("FROM samc_appointment a ")
                .Append("INNER JOIN samc_pet b ON a.CustomerID = b.CustomerID AND a.PetID = b.PetID ")
                .Append("WHERE a.CustomerID = @CustomerID AND DATE(a.AppointmentTime) = DATE(@AppointmentTime) ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            With Cmd.Parameters
                .AddWithValue("@CustomerID", APP.CustomerID)
                .AddWithValue("@AppointmentTime", APP.AppointmentTime)
            End With

            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAppointment)

        Catch ex As Exception
            'WriteErrLog("ClsDBAppointment.GetAppointmentSummary()", ex.Message)
        End Try

        Return DtAppointment

    End Function

    Public Function CheckExistingAppointment(ByVal APP As ClsAppointment, ByRef DBConn As OdbcConnection) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, PetID, PetName, AppointmentTime, AppointmentDescription, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_appointment ")
                .Append("WHERE CustomerID = @CustomerID AND DATE(AppointmentTime) = DATE(@AppointmentTime) ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            With Cmd.Parameters
                .AddWithValue("@CustomerID", APP.CustomerID)
                .AddWithValue("@AppointmentTime", APP.AppointmentTime)
            End With

            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAppointment)

        Catch ex As Exception
            'WriteErrLog("ClsDBAppointment.GetAppointmentSummary()", ex.Message)
        End Try

        Return DtAppointment

    End Function

    Public Function GetAppointmentHistory(APP As ClsAppointment, DBConn As OdbcConnection) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, PetID, PetName, AppointmentTime, AppointmentDescription ")
                .Append("FROM samc_appointment ")
                .Append("WHERE CustomerID = @CustomerID ")
                .Append("ORDER BY AppointmentTime DESC ")
                .Append("LIMIT 5 ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            With Cmd.Parameters
                .AddWithValue("@CustomerID", APP.CustomerID)
            End With

            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAppointment)

        Catch ex As Exception

        End Try

        Return DtAppointment

    End Function

    Public Function GetAppointmentListing(APP As ClsAppointment) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName,AppointmentTime, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_appointment ")

                If APP.SQLQueryCondition <> "" Then
                    .Append("" & APP.SQLQueryCondition & " ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtAppointment)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.GetAppointmentListing()")
        End Try

        Return DtAppointment

    End Function



End Class
