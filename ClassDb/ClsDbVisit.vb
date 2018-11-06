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
                .Append("(VisitID, PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, VisitDescription, ")
                .Append("Temperature, TemperamentCode, TemperamentName, BodyScoreCode, BodyScoreName, BodyWeight, PEFindings) ")
                .Append("VALUES ")
                .Append("('" & VS.VisitID & "', '" & VS.PetID & "', '" & VS.PetName & "', " & CSQLDate(VS.PetDOB) & ", '" & VS.SexCode & "', '" & VS.SexName & "', ")
                .Append("'" & VS.AnimalTypeCode & "', '" & VS.AnimalTypeName & "', '" & VS.BreedCode & "', ")
                .Append("'" & VS.BreedName & "', '" & VS.StatusCode & "', '" & VS.StatusName & "', '" & VS.VisitDescription & "', ")
                .Append("'" & VS.Temperature & "', '" & VS.TemperamentCode & "', '" & VS.TemperamentName & "', '" & VS.BodyScoreCode & "', '" & VS.BodyScoreName & "', '" & VS.BodyWeight & "', '" & CSQLQuote(VS.PEFindings) & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("VisitDescription = '" & CSQLQuote(VS.VisitDescription) & "', Temperature = '" & VS.Temperature & "', TemperamentCode = '" & VS.TemperamentCode & "', TemperamentName = '" & VS.TemperamentName & "', BodyScoreCode = '" & VS.BodyScoreCode & "', BodyScoreName = '" & VS.BodyScoreName & "', BodyWeight = '" & VS.BodyWeight & "', ")
                .append("PEFindings = '" & CSQLQuote(VS.PEFindings) & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.AddNewVisitDetail()")
        End Try

        Return True

    End Function

    Public Function GetVisitListing(VS As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, CustomerName, PetName, EmployeeName, CustomerID, EmployeeID, VisitTime, ")
                .Append("PetID, IsVisitCompleted, VisitDescription, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_visit a ")
                .Append("INNER JOIN samc_visitdetail b ON a.VisitID = b.VisitID ")

                If VS.CustomerID <> "" Then
                    .Append("WHERE CustomerID = '" & VS.CustomerID & "' ")
                End If

                .Append("GROUP BY a.VisitID ")
                .Append("ORDER BY a.VisitID ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.GetVisitListing()")
        End Try

        Return DtVisit

    End Function

    Public Function GetWardedVisitListing(VS As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, CustomerName, PetName, EmployeeName, CustomerID, EmployeeID, VisitTime, PetID, ")
                .Append("IsVisitCompleted, IsOngoingTreatment, IsAdmittedToWard, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_visit a ")
                .Append("INNER JOIN samc_visitdetail b ON a.VisitID = b.VisitID ")
                '.Append("WHERE IsVisitCompleted = '" & VS.IsVisitCompleted & "' AND IsOngoingTreatment = '" & VS.IsOngoingTreatment & "' AND IsAdmittedToWard = '" & VS.IsAdmittedToWard & "' ")
                If VS.CustomerID <> "" Then
                    .Append("WHERE CustomerID = '" & VS.CustomerID & "' ")
                    '.Append("AND CustomerID = '" & VS.CustomerID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.GetWardedVisitListing()")
        End Try

        Return DtVisit

    End Function

    Public Function GetUnassignedVisitListing(VS As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, CustomerName, PetName, EmployeeName, CustomerID, EmployeeID, VisitTime, PetID, ")
                .Append("IsVisitCompleted, IsOngoingTreatment, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_visit a ")
                .Append("INNER JOIN samc_visitdetail b ON a.VisitID = b.VisitID ")
                .Append("WHERE IsVisitCompleted = '" & VS.IsVisitCompleted & "' AND IsOngoingTreatment = '" & VS.IsOngoingTreatment & "' ")
                If VS.CustomerID <> "" Then
                    .Append("AND CustomerID = '" & VS.CustomerID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.GetUnassignedVisitListing()")
        End Try

        Return DtVisit

    End Function

    Public Function GetIncompleteVisitListing(VS As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, CustomerName, PetName, EmployeeName, CustomerID, EmployeeID, VisitTime, PetID, ")
                .Append("IsVisitCompleted, IsOngoingTreatment, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_visit a ")
                .Append("INNER JOIN samc_visitdetail b ON a.VisitID = b.VisitID ")
                .Append("WHERE IsVisitCompleted = '0' ")

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

    Public Function UpdateIsVisitCompleted(CS As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_visit ")
                .Append("SET IsVisitCompleted = '" & CS.IsVisitCompleted & "' ")
                .Append("WHERE VisitID = '" & CS.VisitID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.UpdateIsVisitCompleted()")
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

    Public Function GetVisitDetail(V As ClsVisit) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, EmployeeID, EmployeeName, CustomerID, CustomerName, VisitTime, IsVisitCompleted, IsOngoingTreatment, ")
                .Append("PetID, PetName, PetDOB, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, StatusCode, StatusName, VisitDescription, ")
                .Append("Temperature, TemperamentCode, TemperamentName, BodyScoreCode, BodyScoreName, BodyWeight, PEFindings, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_visit a ")
                .Append("INNER JOIN samc_visitdetail b ON a.VisitID = b.VisitID ")

                If V.VisitID <> "" Then
                    .Append("WHERE a.VisitID = '" & V.VisitID & "' ")
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

    Public Function UpdateTreatmentStatus(V As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_visit ")
                .Append("SET IsOngoingTreatment = '" & V.IsOngoingTreatment & "', ")
                .Append("ModifiedBy = '" & V.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(V.Ref.DateModified) & " ")
                .Append("WHERE VisitID = '" & V.VisitID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.UpdateTreatmentStatus()")
            Return False
        End Try

        Return True

    End Function

    Public Function UpdateWardAdmission(V As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_visit ")
                .Append("SET IsAdmittedToWard = '" & V.IsAdmittedToWard & "', IsOngoingTreatment = '" & V.IsOngoingTreatment & "', ")
                .Append("ModifiedBy = '" & V.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(V.Ref.DateModified) & " ")
                .Append("WHERE VisitID = '" & V.VisitID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.UpdateWardAdmission()")
            Return False
        End Try

        Return True

    End Function

    Public Function AddNewVisitCharges(V As ClsVisitCharges, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_visitcharges ")
                .Append("(VisitID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & V.VisitID & "', '" & V.RowNo & "', '" & V.ItemCode & "', '" & CSQLQuote(V.ItemDescription) & "', '" & V.ItemGroup & "', '" & V.ItemTypeCode & "', '" & CSQLQuote(V.ItemTypeDescription) & "', '" & CSQLQuote(V.Prescription) & "', '" & CSQLQuote(V.Notes) & "', '" & V.UnitPrice & "', '" & V.Quantity & "', '" & V.TotalPrice & "', ")
                .Append("'" & V.Ref.CreatedBy & "', " & CSQLDateTime(V.Ref.DateCreated) & ", '" & V.Ref.ModifiedBy & "', " & CSQLDateTime(V.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & V.ItemCode & "', ItemDescription = '" & CSQLQuote(V.ItemDescription) & "', ItemGroup = '" & V.ItemGroup & "', ItemTypeCode = '" & V.ItemTypeCode & "', ItemTypeDescription = '" & CSQLQuote(V.ItemTypeDescription) & "', Prescription = '" & CSQLQuote(V.Prescription) & "', Notes = '" & CSQLQuote(V.Notes) & "', ")
                .Append("UnitPrice = '" & V.UnitPrice & "', Quantity = '" & V.Quantity & "', TotalPrice = '" & V.TotalPrice & "', ")
                .Append("ModifiedBy = '" & V.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(V.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.AddNewVisitCharges()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetVisitCharges(C As ClsVisitCharges) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_visitcharges a ")
                .Append("INNER JOIN samc_visit b ON a.VisitID = b.VisitID ")
                .Append("WHERE a.VisitID = '" & C.VisitID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVisit.GetVisitCharges()")
        End Try

        Return DtVisit

    End Function


End Class
