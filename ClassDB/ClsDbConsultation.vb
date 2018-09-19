Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbConsultation

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewConsultation(CONS As ClsConsultation, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_consultation ")
                .Append("(ConsultationID, EmployeeID, EmployeeName, CustomerID, CustomerName, ConsultationTime, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & CONS.ConsultationID & "', '" & CONS.EmployeeID & "', '" & CONS.EmployeeName & "', '" & CONS.CustomerID & "', '" & CONS.CustomerName & "', " & CSQLDateTime(CONS.ConsultationTime) & ", ")
                .Append("'" & CONS.Ref.CreatedBy & "', " & CSQLDateTime(CONS.Ref.DateCreated) & ", '" & CONS.Ref.ModifiedBy & "', " & CSQLDateTime(CONS.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("EmployeeID = '" & CONS.EmployeeID & "', EmployeeName = '" & CONS.EmployeeName & "', ConsultationTime = " & CSQLDateTime(CONS.ConsultationTime) & ", ModifiedBy = '" & CONS.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(CONS.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbConsultation.AddNewConsultation()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewConsultationDetail(CONSD As ClsConsultationDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_consultationdetail ")
                .Append("(ConsultationID, PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, ConsultationDesc, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & CONSD.ConsultationID & "', '" & CONSD.PetID & "', '" & CONSD.PetName & "', " & CSQLDate(CONSD.PetDOB) & ", '" & CONSD.SexCode & "', '" & CONSD.SexName & "', ")
                .Append("'" & CONSD.AnimalTypeCode & "', '" & CONSD.AnimalTypeName & "', '" & CONSD.BreedCode & "', ")
                .Append("'" & CONSD.BreedName & "', '" & CONSD.StatusCode & "', '" & CONSD.StatusName & "', '" & CONSD.ConsultationDesc & "', ")
                .Append("'" & CONSD.Ref.CreatedBy & "', " & CSQLDateTime(CONSD.Ref.DateCreated) & ", '" & CONSD.Ref.ModifiedBy & "', " & CSQLDateTime(CONSD.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ConsultationDesc = '" & CONSD.ConsultationDesc & "', ModifiedBy = '" & CONSD.Ref.ModifiedBy & "',  DateModified = " & CSQLDateTime(CONSD.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbConsultation.AddNewConsultationDetail()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetConsultationListing(CONS As ClsConsultation) As DataTable

        Dim DtConsultation As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ConsultationID, EmployeeID, EmployeeName, CustomerID, CustomerName, ConsultationTime, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_consultation ")

                If CONS.CustomerID <> "" Then
                    .Append("WHERE CustomerID = '" & CONS.CustomerID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtConsultation)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbConsultation.GetConsultationListing()")
        End Try

        Return DtConsultation

    End Function

    Public Function UpdateIsCompleted(CS As ClsConsultation, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_consultation ")
                .Append("SET IsCompleted = '" & CS.IsCompleted & "' ")
                .Append("WHERE ConsultationID = '" & CS.ConsultationID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbConsultation.UpdateIsCompleted()")
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

    Public Function GetConsultationDetail(CONS As ClsConsultation) As DataTable

        Dim DtConsultation As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.ConsultationID, EmployeeID, EmployeeName, CustomerID, CustomerName, ConsultationTime, IsCompleted, ")
                .Append("PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, ConsultationDesc, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_consultation a ")
                .Append("INNER JOIN samc_consultationdetail b ON a.ConsultationID = b.ConsultationID ")

                If CONS.ConsultationID <> "" Then
                    .Append("WHERE a.ConsultationID = '" & CONS.ConsultationID & "' ")
                End If

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtConsultation)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbConsultation.GetConsultationDetail()")
        End Try

        Return DtConsultation

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
