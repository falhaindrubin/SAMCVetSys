Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbWard

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewWard(W As ClsWard, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_ward ")
                .Append("(WardID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, ")
                .Append("TelNo, MobileNo, SexCode, SexName, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, IsNeutered, ")
                .Append("PetCase, IsDischarged, DischargeDate, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDateTime(W.AdmissionDate) & ", '" & W.CustomerID & "', '" & W.CustomerName & "', '" & W.PetID & "', '" & W.PetName & "', ")
                .Append("'" & W.TelNo & "', '" & W.MobileNo & "', '" & W.SexCode & "', '" & W.SexName & "', '" & W.AnimalTypeCode & "', '" & W.AnimalTypeName & "', '" & W.BreedCode & "', '" & W.BreedName & "', '" & W.IsNeutered & "', ")
                .Append("'" & W.PetCase & "', '" & W.IsDischarged & "', " & CSQLDateTime(W.DischargeDate) & ", ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("PetCase = '" & CSQLQuote(W.PetCase) & "', IsDischarged = '" & W.IsDischarged & "', DischargeDate = " & CSQLDateTime(W.DischargeDate) & ", ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWard()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewWardDetail(W As ClsWardDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_warddetail ")
                .Append("(WardID, WardDate, EmployeeID, EmployeeName, Appetite, AppetiteDescription, Bowel, BowelDescription, Urine, UrineDescription, Vomit, VomitDescription, Food, IsFasting, FastingDescription, DailyNotes, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.WardDate) & ", '" & W.EmployeeID & "', '" & W.EmployeeName & "', '" & W.Appetite & "', '" & W.AppetiteDescription & "', '" & W.Bowel & "', '" & W.BowelDescription & "', '" & W.Urine & "', '" & W.UrineDescription & "', '" & W.Vomit & "', '" & W.VomitDescription & "', '" & W.Food & "', '" & W.IsFasting & "', '" & W.FastingDescription & "', '" & CSQLQuote(W.DailyNotes) & "', ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("EmployeeID = '" & W.EmployeeID & "', EmployeeName = '" & W.EmployeeName & "', Appetite = '" & W.Appetite & "', AppetiteDescription = '" & W.AppetiteDescription & "', Bowel = '" & W.Bowel & "', BowelDescription = '" & W.BowelDescription & "', Urine = '" & W.Urine & "', UrineDescription = '" & W.UrineDescription & "', Vomit = '" & W.Vomit & "', VomitDescription = '" & W.VomitDescription & "', Food = '" & W.Food & "', IsFasting = '" & W.IsFasting & "', FastingDescription = '" & W.FastingDescription & "', DailyNotes = '" & CSQLQuote(W.DailyNotes) & "', ")
                .Append("ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardDetail()")
        End Try

        Return True

    End Function

    Public Function AddNewWardDiagnosis(W As ClsWardDiagnosis, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_ward_diagnosis ")
                .Append("(WardID, WardDate, PetID, PetName, Diagnosis, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.WardDate) & ", '" & W.PetID & "', '" & W.PetName & "', '" & CSQLQuote(W.Diagnosis) & "', '" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("Diagnosis= '" & CSQLQuote(W.Diagnosis) & "', ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardDiagnosis()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewWardDiagnosisDetail(W As ClsWardDiagnosisDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_ward_diagnosisdetail ")
                .Append("(WardID, WardDate, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.WardDate) & ", '" & W.RowNo & "', '" & W.ItemCode & "', '" & W.ItemDescription & "', '" & W.ItemGroup & "', '" & W.ItemTypeCode & "', '" & W.ItemTypeDescription & "', '" & W.UnitPrice & "', '" & W.Quantity & "', '" & W.TotalPrice & "', ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & W.ItemCode & "', ItemDescription = '" & W.ItemDescription & "', ItemGroup = '" & W.ItemGroup & "', ItemTypeCode = '" & W.ItemTypeCode & "', ItemTypeDescription = '" & W.ItemTypeDescription & "', UnitPrice = '" & W.UnitPrice & "', Quantity = '" & W.Quantity & "', TotalPrice = '" & W.TotalPrice & "', ")
                .Append("ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardDiagnosisDetail()")
            Return False
        End Try

        Return True

    End Function

    Public Function AddNewWardTreatment(W As ClsWardTreatment, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_ward_treatment ")
                .Append("(WardID, WardDate, PhRequestID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.WardDate) & ", '" & W.PhRequestID & "', '" & W.RowNo & "', '" & W.ItemCode & "', '" & W.ItemDescription & "', '" & W.ItemGroup & "', '" & W.ItemTypeCode & "', '" & W.ItemTypeDescription & "', '" & CSQLQuote(W.Prescription) & "', '" & CSQLQuote(W.Notes) & "', '" & W.UnitPrice & "', '" & W.Quantity & "', '" & W.TotalPrice & "', ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & W.ItemCode & "', ItemDescription = '" & W.ItemDescription & "', ItemGroup = '" & W.ItemGroup & "', ItemTypeCode = '" & W.ItemTypeCode & "', ItemTypeDescription = '" & W.ItemTypeDescription & "', Prescription = '" & CSQLQuote(W.Prescription) & "', Notes = '" & CSQLQuote(W.Notes) & "', UnitPrice = '" & W.UnitPrice & "', Quantity = '" & W.Quantity & "', TotalPrice = '" & W.TotalPrice & "', ")
                .Append("ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardTreatment()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetWardListing(W As ClsWard) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.WardID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, PetCase, IsDischarged, DischargeDate, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_ward a ")
                .Append("INNER JOIN samc_warddetail b ON a.WardID = b.WardID ")
                .Append("GROUP BY a.WardID ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardListing()")
        End Try

        Return DtWard

    End Function

    Public Function GetWard(W As ClsWard) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT WardID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, PetCase, IsDischarged, DischargeDate, WardDuration, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_ward ")
                .Append("WHERE ")
                If W.WardID <> "" Then
                    .Append("WardID = '" & W.WardID & "' ")
                ElseIf W.VisitID <> "" Then
                    .Append("VisitID = '" & W.VisitID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWard()")
        End Try

        Return DtWard

    End Function

    Public Function GetWardDetail(W As ClsWard) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.WardID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, PetCase, IsDischarged, DischargeDate, WardDuration, ")
                .Append("WardDate, Appetite, AppetiteDescription, Bowel, BowelDescription, Urine, UrineDescription, Vomit, VomitDescription, Food, IsFasting, FastingDescription, DailyNotes, ")
                .Append("Diagnosis, ")

                If W.GetTodayVet = "1" Then
                    .Append("b.CreatedBy, b.DateCreated, b.ModifiedBy, b.DateModified ")
                Else
                    .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                End If

                .Append("FROM samc_ward a ")
                .Append("INNER JOIN samc_warddetail b ON a.WardID = b.WardID ")
                If W.WardID <> "" Then
                    .Append("WHERE a.WardID = '" & W.WardID & "' ")
                    If W.WardDate <> Nothing Then
                        .Append("AND WardDate = " & CSQLDate(W.WardDate) & " ")
                    End If

                ElseIf W.VisitID <> "" Then
                    '.Append("WHERE a.VisitID = '" & W.VisitID & "' ")
                    'If W.WardDate <> Nothing Then
                    '    .Append("AND WardDate = " & CSQLDate(W.WardDate) & " ")
                    'End If

                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardDetail()")
        End Try

        Return DtWard

    End Function


    Public Function GetWardDiagnosis(D As ClsWardDiagnosis) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT WardID, WardDate, PetID, PetName, Diagnosis, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_ward_diagnosis ")
                If D.WardID <> "" Then
                    .Append("WHERE WardID = '" & D.WardID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardDiagnosis()")
        End Try

        Return DtWard

    End Function

    Public Function GetWardDiagnosisDetail(D As ClsWardDiagnosis) As DataTable

        Dim DtWardDiagnosisDetail As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                If D.WardID <> "" Then

                    .Append("SELECT WardID, WardDate, EmployeeID, EmployeeName, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                    .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                    .Append("FROM samc_ward_diagnosisdetail ")

                    If D.WardID <> "" Then
                        .Append("WHERE WardID = '" & D.WardID & "' ")
                        If D.WardDate <> Nothing Then
                            .Append("AND WardDate = " & CSQLDate(D.WardDate) & " ")
                        End If
                    End If

                    '.Append("SELECT a.WardID, PetID, PetName, Diagnosis, a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified, ")
                    '.Append("WardDate, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice ")
                    '.Append("FROM samc_ward_diagnosis a ")
                    '.Append("LEFT JOIN samc_ward_diagnosisdetail b ON a.WardID = b.WardID ")

                    'If D.WardID <> "" Then
                    '    .Append("WHERE a.WardID = '" & D.WardID & "' ")
                    '    If D.WardDate <> Nothing Then
                    '        .Append("AND WardDate = " & CSQLDate(D.WardDate) & " ")
                    '    End If
                    'End If

                    '.Append("GROUP BY RowNo ")

                    Cmd = New OdbcCommand(Sb.ToString, DbConn)
                    Da = New OdbcDataAdapter(Cmd)
                    Da.Fill(DtWardDiagnosisDetail)

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardDiagnosisDetail()")
        End Try

        Return DtWardDiagnosisDetail

    End Function

    Public Function GetWardTreatmentDetail(T As ClsWardTreatment) As DataTable

        Dim DtWardTreatment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT WardID, WardDate, PhRequestID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_ward_treatment ")
                If T.WardID <> "" Then
                    .Append("WHERE WardID = '" & T.WardID & "' ")
                End If
                If T.WardDate <> Nothing Then
                    .Append("AND WardDate = " & CSQLDate(T.WardDate) & " ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWardTreatment)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardTreatmentDetail()")
        End Try

        Return DtWardTreatment

    End Function

    Public Function DischargePet(W As ClsWard, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_ward ")
                .Append("SET IsDischarged = '" & W.IsDischarged & "', ")
                .Append("DischargeDate = " & CSQLDateTime(W.DischargeDate) & ", ")
                .Append("WardDuration = '" & W.WardDuration & "', ")
                .Append("ModifiedBy = '" & W.Ref.ModifiedBy & "', ")
                .Append("DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
                .Append("WHERE WardID = '" & W.WardID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.DischargePet()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetVisitCharges(C As ClsVisitCharges) As DataTable

        Dim DtVisit As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT VisitID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_visitcharges ")
                If C.VisitID <> "" Then
                    .Append("WHERE VisitID = '" & C.VisitID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVisit)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetVisitCharges()")
        End Try

        Return DtVisit

    End Function

    Public Function AddNewWardHourly(W As ClsWardHourly, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_wardhourly ")
                .Append("(WardID, RowNo, WardDate, EmployeeID, EmployeeName, HourlyNotes, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', '" & W.RowNo & "', " & CSQLDateTime(W.WardDate) & ", '" & W.EmployeeID & "', '" & W.EmployeeName & "', '" & CSQLQuote(W.HourlyNotes) & "', ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("HourlyNotes = '" & CSQLQuote(W.HourlyNotes) & "', ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardHourly()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetWardHourly(W As ClsWardHourly) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT WardID, WardDate, EmployeeID, EmployeeName, HourlyNotes, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_wardhourly ")

                If W.WardID <> "" Then
                    .Append("WHERE WardID = '" & W.WardID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardHourly()")
        End Try

        Return DtWard

    End Function

    Public Function AddNewWardDischarge(W As ClsWardDischarge, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_ward_discharge ")
                .Append("(WardID, DischargeDate, AdmitIssue, AdmitDiagnosis, TreatmentSummary, DischargeCondition, DischargeReason, PossibleComplications, AdditionalInstruction, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDateTime(W.DischargeDate) & ", '" & CSQLQuote(W.AdmitIssue) & "', '" & CSQLQuote(W.AdmitDiagnosis) & "', '" & CSQLQuote(W.TreatmentSummary) & "', '" & CSQLQuote(W.DischargeCondition) & "', '" & CSQLQuote(W.DischargeReason) & "', '" & CSQLQuote(W.PossibleComplications) & "', '" & CSQLQuote(W.AdditionalInstruction) & "', ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("AdmitIssue = '" & CSQLQuote(W.AdmitIssue) & "', AdmitDiagnosis = '" & CSQLQuote(W.AdmitDiagnosis) & "', TreatmentSummary = '" & CSQLQuote(W.TreatmentSummary) & "', DischargeCondition = '" & CSQLQuote(W.DischargeCondition) & "', DischargeReason = '" & CSQLQuote(W.DischargeReason) & "', PossibleComplications = '" & CSQLQuote(W.PossibleComplications) & "', AdditionalInstruction = '" & CSQLQuote(W.AdditionalInstruction) & "', ")
                .Append("ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardDischarge()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewWardDischargeMedication(W As ClsWardDischargeDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_ward_dischargedetail ")
                .Append("(WardID, DischargeDate, PhRequestID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, ")
                .Append("Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.DischargeDate) & ", '" & W.PhRequestID & "', '" & W.RowNo & "', '" & W.ItemCode & "', '" & CSQLQuote(W.ItemDescription) & "', '" & W.ItemGroup & "', '" & W.ItemTypeCode & "', '" & W.ItemTypeDescription & "', ")
                .Append("'" & CSQLQuote(W.Prescription) & "', '" & CSQLQuote(W.Notes) & "', '" & W.UnitPrice & "', '" & W.Quantity & "', '" & W.TotalPrice & "', ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("Prescription = '" & CSQLQuote(W.Prescription) & "', Notes = '" & CSQLQuote(W.Notes) & "', ModifiedBy = '" & W.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.AddNewWardDischargeMedication()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetWardDischarge(W As ClsWardDischarge) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT WardID, DischargeDate, AdmitIssue, AdmitDiagnosis, DischargeCondition, DischargeReason, PossibleComplications, AdditionalInstruction, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_ward_discharge ")
                If W.WardID <> "" Then
                    .Append("WHERE WardID = '" & W.WardID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardDischarge()")
        End Try

        Return DtWard

    End Function

    Public Function GetWardDischargeMedication(W As ClsWardDischargeDetail) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT WardID, DischargeDate, PhRequestID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_ward_dischargedetail ")
                If W.WardID <> "" Then
                    .Append("WHERE WardID = '" & W.WardID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtWard)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbWard.GetWardDischargeMedication()")
        End Try

        Return DtWard

    End Function

    Public Function UpdateWardTxPhRequestID(W As ClsWardTreatment, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_ward_treatment ")
                .Append("SET PhRequestID = '" & W.PhRequestID & "' ")
                .Append("WHERE WardID = '" & W.WardID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("",, "")
            Return False
        End Try

        Return True

    End Function

End Class
