Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbVisit

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewVisit(VS As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_visit ")
                .Append("(VisitID, EmployeeID, EmployeeName, CustomerID, CustomerName, VisitTime, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & VS.VisitID & "', '" & VS.EmployeeID & "', '" & VS.EmployeeName & "', '" & VS.CustomerID & "', '" & VS.CustomerName & "', " & CSQLDateTime(VS.VisitTime) & ", ")
                .Append("'" & VS.Ref.CreatedBy & "', " & CSQLDateTime(VS.Ref.DateCreated) & ", '" & VS.Ref.ModifiedBy & "', " & CSQLDateTime(VS.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("EmployeeID = '" & VS.EmployeeID & "', EmployeeName = '" & VS.EmployeeName & "', VisitTime = " & CSQLDateTime(VS.VisitTime) & ", ")
                .Append("ModifiedBy = '" & VS.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(VS.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.AddNewVisit()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewVisitDetail(VS As ClsVisitDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_visitdetail ")
                .Append("(VisitID, PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, VisitDescription) ")
                .Append("VALUES ")
                .Append("('" & VS.VisitID & "', '" & VS.PetID & "', '" & VS.PetName & "', " & CSQLDate(VS.PetDOB) & ", '" & VS.SexCode & "', '" & VS.SexName & "', ")
                .Append("'" & VS.AnimalTypeCode & "', '" & VS.AnimalTypeName & "', '" & VS.BreedCode & "', ")
                .Append("'" & VS.BreedName & "', '" & VS.StatusCode & "', '" & VS.StatusName & "', '" & VS.VisitDescription & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("VisitDescription = '" & VS.VisitDescription & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.AddNewVisitDetail()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetVisitListing(VS As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, CustomerName, PetName, EmployeeName, CustomerID, EmployeeID, VisitTime, ")
                .Append("PetID, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_visit a ")
                .Append("INNER JOIN samc_visitdetail b ON a.VisitID = b.VisitID ")
                .Append(" ")
                .Append("WHERE IsCompleted = '0' ")

                If VS.CustomerID <> "" Then
                    .Append("AND CustomerID = '" & VS.CustomerID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.GetVisitListing()")
        End Try

        Return DtVisit

    End Function

    Public Function UpdateIsCompleted(CS As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_Visit ")
                .Append("SET IsCompleted = '" & CS.IsCompleted & "' ")
                .Append("WHERE VisitID = '" & CS.VisitID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.UpdateIsCompleted()")
        End Try

        Return True

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

    Public Function GetVisitDetail(CONS As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, EmployeeID, EmployeeName, CustomerID, CustomerName, VisitTime, IsCompleted, ")
                .Append("PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, VisitDesc, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_Visit a ")
                .Append("INNER JOIN samc_Visitdetail b ON a.VisitID = b.VisitID ")

                If CONS.VisitID <> "" Then
                    .Append("WHERE a.VisitID = '" & CONS.VisitID & "' ")
                End If

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.GetVisitDetail()")
        End Try

        Return DtVisit

    End Function

    Public Function GetAppointmentReport(APP As ClsAppointment) As DataTable

        Dim DtAppointment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, AppointmentTime, ")
                .Append("PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, AppointmentDesc, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_appointment a ")
                .Append("INNER JOIN samc_appointmentdetail b ON a.AppointmentID = b.AppointmentID ")
                .Append("WHERE a.AppointmentID = '" & APP.AppointmentID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
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
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, a.CustomerID, a.CustomerName, a.PetID, a.PetName, SexName, PetDOB, b.AnimalTypeName, b.BreedName, b.StatusName, AppointmentTime, AppointmentDesc AS 'PetIssue' ")
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
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, PetID, PetName, AppointmentTime, AppointmentDesc, ")
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
                .Append("SELECT AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName, PetID, PetName, AppointmentTime, AppointmentDesc ")
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

    'Public Function GetAppointmentListing(APP As ClsAppointment) As DataTable

    '    Dim DtAppointment As New DataTable

    '    Try
    '        Sb = New StringBuilder
    '        With Sb
    '            .Append("SELECT AppointmentID, EmployeeID, EmployeeName, CustomerID, CustomerName,AppointmentTime, CreatedBy, DateCreated, ModifiedBy, DateModified ")
    '            .Append("FROM samc_appointment ")

    '            If APP.CustomerID <> "" Then
    '                .Append("WHERE CustomerID = '" & APP.CustomerID & "' ")
    '            End If
    '        End With

    '        Cmd = New OdbcCommand(Sb.ToString, DbConn)
    '        Da = New OdbcDataAdapter(Cmd)
    '        Da.Fill(DtAppointment)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBAppointment.GetAppointmentListing()")
    '    End Try

    '    Return DtAppointment

    'End Function



End Class
