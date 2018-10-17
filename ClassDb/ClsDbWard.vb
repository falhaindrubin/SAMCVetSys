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
                .Append("(WardID, VisitID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, PetCase, IsDischarged, DischargeDate, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', '" & W.VisitID & "', " & CSQLDate(W.AdmissionDate) & ", '" & W.CustomerID & "', '" & W.CustomerName & "', '" & W.PetID & "', '" & W.PetName & "', '" & W.PetCase & "', '" & W.IsDischarged & "', " & CSQLDateTime(W.DischargeDate) & ", ")
                .Append("'" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("IsDischarged = '" & W.IsDischarged & "', DischargeDate = " & CSQLDateTime(W.DischargeDate) & ", ModifiedBy = '" & W.Ref.DateModified & "', DateModified = " & CSQLDateTime(W.Ref.DateModified) & " ")
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
                .Append("(WardID, WardDate, Appetite, Bowel, Urine, Vomit, Food, IsFasting, FastingDescription, DailyNotes) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.WardDate) & ", '" & W.Appetite & "', '" & W.Bowel & "', '" & W.Urine & "', '" & W.Vomit & "', '" & W.Food & "', '" & W.IsFasting & "', '" & W.FastingDescription & "', '" & CSQLQuote(W.DailyNotes) & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("Appetite = '" & W.Appetite & "', Bowel = '" & W.Bowel & "', Urine = '" & W.Urine & "', Vomit = '" & W.Vomit & "', Food = '" & W.Food & "', IsFasting = '" & W.IsFasting & "', FastingDescription = '" & W.FastingDescription & "', DailyNotes = '" & CSQLQuote(W.DailyNotes) & "' ")
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
                .Append("(WardID, VisitID, PetID, PetName, Diagnosis, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', '" & W.VisitID & "', '" & W.PetID & "', '" & W.PetName & "', '" & CSQLQuote(W.Diagnosis) & "', '" & W.Ref.CreatedBy & "', " & CSQLDateTime(W.Ref.DateCreated) & ", '" & W.Ref.ModifiedBy & "', " & CSQLDateTime(W.Ref.DateModified) & ") ")
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
                .Append("(WardID, DiagnoseDate, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', " & CSQLDate(W.DiagnoseDate) & ", '" & W.RowNo & "', '" & W.ItemCode & "', '" & W.ItemDescription & "', '" & W.ItemGroup & "', '" & W.ItemTypeCode & "', '" & W.ItemTypeDescription & "', '" & W.UnitPrice & "', '" & W.Quantity & "', '" & W.TotalPrice & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & W.ItemCode & "', ItemDescription = '" & W.ItemDescription & "', ItemGroup = '" & W.ItemGroup & "', ItemTypeCode = '" & W.ItemTypeCode & "', ItemTypeDescription = '" & W.ItemTypeDescription & "', UnitPrice = '" & W.UnitPrice & "', Quantity = '" & W.Quantity & "', TotalPrice = '" & W.TotalPrice & "' ")
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
                .Append("(WardID, VisitID, TreatmentDate, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & W.WardID & "', '" & W.VisitID & "', " & CSQLDate(W.TreatmentDate) & ", '" & W.RowNo & "', '" & W.ItemCode & "', '" & W.ItemDescription & "', '" & W.ItemGroup & "', '" & W.ItemTypeCode & "', '" & W.ItemTypeDescription & "', '" & CSQLQuote(W.Prescription) & "', '" & CSQLQuote(W.Notes) & "', '" & W.UnitPrice & "', '" & W.Quantity & "', '" & W.TotalPrice & "', ")
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
                .Append("SELECT a.WardID, VisitID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, PetCase, IsDischarged, DischargeDate, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
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

    Public Function GetWardDetail(W As ClsWard) As DataTable

        Dim DtWard As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.WardID, VisitID, AdmissionDate, CustomerID, CustomerName, PetID, PetName, PetCase, IsDischarged, DischargeDate, ")
                .Append("WardDate, Appetite, Bowel, Urine, Vomit, Food, IsFasting, FastingDescription, DailyNotes, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_ward a ")
                .Append("INNER JOIN samc_warddetail b ON a.WardID = b.WardID ")
                If W.WardID <> "" Then
                    .Append("WHERE a.WardID = '" & W.WardID & "' ")
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

End Class
