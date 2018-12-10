Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbSurgery

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewSurgery(SX As ClsSurgery, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_surgery ")
                .Append("(CaseID, CustomerID, CustomerName, NRICPassportNo, TelNo, MobileNo, PetID, PetName, PetAge, SexCode, SexName, ")
                .Append("AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, NeuterCode, NeuterName, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & SX.CaseID & "', '" & SX.CustomerID & "', '" & CSQLQuote(SX.CustomerName) & "', '" & SX.NRICPassportNo & "', '" & SX.TelNo & "', '" & SX.MobileNo & "', ")
                .Append("'" & SX.PetID & "', '" & SX.PetName & "', '" & SX.PetAge & "', '" & SX.SexCode & "', '" & SX.SexName & "', ")
                .Append("'" & SX.AnimalTypeCode & "', '" & SX.AnimalTypeName & "', '" & SX.BreedCode & "', '" & SX.BreedName & "', '" & SX.NeuterCode & "', '" & SX.NeuterName & "', ")
                .Append("'" & SX.Ref.CreatedBy & "', " & CSQLDateTime(SX.Ref.DateCreated) & ", '" & SX.Ref.ModifiedBy & "', " & CSQLDateTime(SX.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SX.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.AddNewSurgery()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewSurgeryDetail(SX As ClsSurgeryDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_surgerydetail ")
                .Append("(CaseID, EvaluationDate, EmployeeID, EmployeeName, BodyWeight, BodyScoreCode, BodyScoreName, Temperature, TemperamentCode, TemperamentName, Pulse, RespiratoryRate, SurgeryDiagnosis, IsFasting, FastingDescription, ")
                .Append("IsVaccine, VaccineDescription, HasVaccineDueDate, VaccineNextDueDate, GeneralAppearance, GeneralAppearanceDescription, Hydration, HydrationDescription, ")
                .Append("MucousMembrane, MucousMembraneDescription, Capillary, CapillaryDescription, Respiratory, RespiratoryDescription, LungSound, LungSoundDescription, ")
                .Append("HeartRate, HeartRateDescription, HeartRateReading, HeartRhythm, HeartRhythmDescription, HeartSound, HeartSoundDescription, OtherFindings, ")
                .Append("LevelOfRisk, LevelOfRiskDescription, SurgeonComments, SurgicalPlan, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & SX.CaseID & "', " & CSQLDate(SX.EvaluationDate) & ", '" & SX.EmployeeID & "', '" & SX.EmployeeName & "', '" & SX.BodyWeight & "', '" & SX.BodyScoreCode & "', '" & SX.BodyScoreName & "', '" & SX.Temperature & "', '" & SX.TemperamentCode & "', '" & SX.TemperamentName & "', '" & SX.Pulse & "', ")
                .Append("'" & SX.RespiratoryRate & "', '" & CSQLQuote(SX.SurgeryDiagnosis) & "', '" & SX.IsFasting & "', '" & CSQLQuote(SX.FastingDescription) & "', ")
                .Append("'" & SX.IsVaccine & "', '" & SX.VaccineDescription & "', '" & SX.HasVaccineDueDate & "', " & CSQLDate(SX.VaccineNextDueDate) & ", '" & SX.GeneralAppearance & "', '" & SX.GeneralAppearanceDescription & "', ")
                .Append("'" & SX.Hydration & "', '" & SX.HydrationDescription & "', '" & SX.MucousMembrane & "', '" & SX.MucousMembraneDescription & "', '" & SX.Capillary & "', '" & SX.CapillaryDescription & "', ")
                .Append("'" & SX.Respiratory & "', '" & SX.RespiratoryDescription & "', '" & SX.LungSound & "', '" & SX.LungSoundDescription & "', '" & SX.HeartRate & "', '" & SX.HeartRateDescription & "', '" & SX.HeartRateReading & "', ")
                .Append("'" & SX.HeartRhythm & "', '" & SX.HeartRhythmDescription & "', '" & SX.HeartSound & "', '" & SX.HeartSoundDescription & "', '" & CSQLQuote(SX.OtherFindings) & "', ")
                .Append("'" & SX.LevelOfRisk & "', '" & SX.LevelOfRiskDescription & "', '" & CSQLQuote(SX.SurgeonComments) & "', '" & CSQLQuote(SX.SurgicalPlan) & "', ")
                .Append("'" & SX.Ref.CreatedBy & "', " & CSQLDateTime(SX.Ref.DateCreated) & ", '" & SX.Ref.ModifiedBy & "', " & CSQLDateTime(SX.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("BodyWeight = '" & SX.BodyWeight & "', BodyScoreCode = '" & SX.BodyScoreCode & "', BodyScoreName = '" & SX.BodyScoreName & "', Temperature = '" & SX.Temperature & "', ")
                .Append("TemperamentCode = '" & SX.TemperamentCode & "', TemperamentName = '" & SX.TemperamentName & "', Pulse = '" & SX.Pulse & "', RespiratoryRate = '" & SX.RespiratoryRate & "', ")
                .Append("SurgeryDiagnosis = '" & CSQLQuote(SX.SurgeryDiagnosis) & "', IsFasting = '" & SX.IsFasting & "', FastingDescription = '" & CSQLQuote(SX.FastingDescription) & "', ")
                .Append("IsVaccine = '" & SX.IsVaccine & "', VaccineDescription = '" & SX.VaccineDescription & "', HasVaccineDueDate = '" & SX.HasVaccineDueDate & "', VaccineNextDueDate = " & CSQLDate(SX.VaccineNextDueDate) & ", ")
                .Append("GeneralAppearance = '" & SX.GeneralAppearance & "', GeneralAppearanceDescription = '" & SX.GeneralAppearanceDescription & "', Hydration = '" & SX.Hydration & "', HydrationDescription = '" & SX.HydrationDescription & "', ")
                .Append("MucousMembrane = '" & SX.MucousMembrane & "', MucousMembraneDescription = '" & SX.MucousMembraneDescription & "', Capillary = '" & SX.Capillary & "', CapillaryDescription = '" & SX.CapillaryDescription & "', ")
                .Append("Respiratory = '" & SX.Respiratory & "', RespiratoryDescription = '" & SX.RespiratoryDescription & "', LungSound = '" & SX.LungSound & "', LungSoundDescription = '" & SX.LungSoundDescription & "', ")
                .Append("HeartRate = '" & SX.HeartRate & "', HeartRateDescription = '" & SX.HeartRateDescription & "', HeartRateReading = '" & SX.HeartRateReading & "', ")
                .Append("HeartRhythm = '" & SX.HeartRhythm & "', HeartRhythmDescription = '" & SX.HeartRhythmDescription & "', HeartSound = '" & SX.HeartSound & "', HeartSoundDescription = '" & SX.HeartSoundDescription & "', ")
                .Append("OtherFindings = '" & CSQLQuote(SX.OtherFindings) & "', ")
                .Append("LevelOfRisk = '" & SX.LevelOfRisk & "', LevelOfRiskDescription = '" & SX.LevelOfRiskDescription & "', SurgeonComments = '" & CSQLQuote(SX.SurgeonComments) & "', SurgicalPlan = '" & CSQLQuote(SX.SurgicalPlan) & "', ")
                .Append("ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SX.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.AddNewSurgeryDetail()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetSurgeryListing(SX As ClsSurgery) As DataTable

        Dim DtSurgery As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.CaseID, EvaluationDate, CustomerID, CustomerName, NRICPassportNo, PetName, TelNo, MobileNo, PetID, PetAge, SexCode, SexName, AnimalTypeCode, AnimalTypeName, ")
                .Append("BreedCode, BreedName, NeuterCode, NeuterName, ")
                .Append("a.CreatedBy, a.DateCreated, a.ModifiedBy, a.DateModified ")
                .Append("FROM samc_surgery a ")
                .Append("INNER JOIN samc_surgerydetail b ON a.CaseID = b.CaseID ")
                .Append("GROUP BY a.CaseID ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSurgery)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.AddNewSurgeryDetail()")
        End Try

        Return DtSurgery

    End Function

    Public Function GetSurgeryHeader(SX As ClsSurgery) As DataTable

        Dim DtSxHeader As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT CaseID, CustomerID, CustomerName, NRICPassportNo, TelNo, MobileNo, PetID, PetName, PetAge, SexCode, SexName, ")
                .Append("AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, NeuterCode, NeuterName, IsCompleted, IsCancelled, IsDelayed, IsOnGoing, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_surgery ")
                If SX.CaseID <> "" Then
                    .Append("WHERE CaseID = '" & SX.CaseID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSxHeader)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetSurgeryHeader()")
        End Try

        Return DtSxHeader

    End Function

    Public Function GetSurgeryDetail(SX As ClsSurgery) As DataTable

        Dim DtSurgeryDetail As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT CaseID, EvaluationDate, EmployeeID, EmployeeName, BodyWeight, BodyScoreCode, BodyScoreName, Temperature, TemperamentCode, TemperamentName, Pulse, RespiratoryRate, ")
                .Append("SurgeryDiagnosis, IsFasting, FastingDescription, IsVaccine, VaccineDescription, HasVaccineDueDate, VaccineNextDueDate, GeneralAppearance, GeneralAppearanceDescription, ")
                .Append("Hydration, HydrationDescription, MucousMembrane, MucousMembraneDescription, Capillary, CapillaryDescription, Respiratory, RespiratoryDescription, ")
                .Append("LungSound, LungSoundDescription, HeartRate, HeartRateDescription, HeartRateReading, HeartRhythm, HeartRhythmDescription, HeartSound, HeartSoundDescription, ")
                .Append("OtherFindings, LevelOfRisk, LevelOfRiskDescription, SurgeonComments, SurgicalPlan, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_surgerydetail ")
                If SX.CaseID <> "" Then
                    .Append("WHERE CaseID = '" & SX.CaseID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSurgeryDetail)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetSurgeryDetail()")
        End Try

        Return DtSurgeryDetail

    End Function

    Public Function GetSurgeryMaterials(SX As ClsSurgery) As DataTable

        Dim DtSx As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT CaseID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_surgerymaterial ")
                If SX.CaseID <> "" Then
                    .Append("WHERE CaseID = '" & SX.CaseID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSx)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetSurgeryMaterials()")
        End Try

        Return DtSx

    End Function

    Public Function AddNewSurgeryMaterial(SX As ClsSurgeryMaterial, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_surgerymaterial ")
                .Append("(CaseID, SurgeryDate, EmployeeID, EmployeeName, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & SX.CaseID & "', " & CSQLDate(SX.SurgeryDate) & ", '" & SX.EmployeeID & "', '" & SX.EmployeeName & "', '" & SX.RowNo & "', '" & SX.ItemCode & "', '" & SX.ItemDescription & "', '" & SX.ItemGroup & "', '" & SX.ItemTypeCode & "', '" & SX.ItemTypeDescription & "', '" & SX.UnitPrice & "', ")
                .Append("'" & SX.Quantity & "', '" & SX.TotalPrice & "', ")
                .Append("'" & SX.Ref.CreatedBy & "', " & CSQLDateTime(SX.Ref.DateCreated) & ", '" & SX.Ref.ModifiedBy & "', " & CSQLDateTime(SX.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SX.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.AddNewSurgeryMaterial()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function DeleteSurgeryItem(SX As ClsSurgeryMaterial, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_surgerymaterial ")
                .Append("WHERE CaseID = '" & SX.CaseID & "' AND RowNo = '" & SX.RowNo & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.AddNewSurgeryMaterial()")
            Return False
        End Try

        Return True

    End Function

    Public Function AddNewSurgeryDischarge(SX As ClsSurgeryDischarge, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        'Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_surgerydischarge ")
                .Append("(CaseID, SurgeryDate, EmployeeID, EmployeeName, SpecificInstruction, MedicationPrescribe, ")
                .Append("ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("DischargeDate, ReviewDate, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & SX.CaseID & "', " & CSQLDate(SX.SurgeryDate) & ", '" & SX.EmployeeID & "', '" & SX.EmployeeName & "', '" & CSQLQuote(SX.SpecificInstruction) & "', '" & CSQLQuote(SX.MedicationPrescribe) & "', ")
                .Append("'" & SX.ItemCode & "', '" & SX.ItemDescription & "', '" & SX.ItemGroup & "', '" & SX.ItemTypeCode & "', '" & SX.ItemTypeDescription & "', '" & SX.UnitPrice & "', '" & SX.Quantity & "', '" & SX.TotalPrice & "', ")
                .Append("" & CSQLDate(SX.DischargeDate) & ", " & CSQLDate(SX.ReviewDate) & ", ")
                .Append("'" & SX.Ref.CreatedBy & "', " & CSQLDateTime(SX.Ref.DateCreated) & ", '" & SX.Ref.ModifiedBy & "', " & CSQLDateTime(SX.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("SpecificInstruction = '" & CSQLQuote(SX.SpecificInstruction) & "', MedicationPrescribe = '" & CSQLQuote(SX.MedicationPrescribe) & "', ")
                .Append("ItemCode = '" & SX.ItemCode & "', ItemDescription = '" & SX.ItemDescription & "', ItemGroup = '" & SX.ItemGroup & "', ItemTypeCode = '" & SX.ItemTypeCode & "', ItemTypeDescription = '" & SX.ItemTypeDescription & "', UnitPrice = '" & SX.UnitPrice & "', Quantity = '" & SX.Quantity & "', TotalPrice = '" & SX.TotalPrice & "', ")
                .Append("ReviewDate = " & CSQLDate(SX.ReviewDate) & ", ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SX.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.AddNewSurgeryDischarge()")
            Return False
        End Try

        Return True

    End Function

    Public Function UpdateSurgeryStatus(SX As ClsSurgery, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_surgery ")
                .Append("SET IsDelayed = '" & SX.IsDelayed & "', IsCancelled = '" & SX.IsDelayed & "', IsCompleted = '" & SX.IsCompleted & "', IsOnGoing = '" & SX.IsOnGoing & "', ")
                .Append("ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SX.Ref.DateModified) & " ")
                .Append("WHERE CaseID = '" & SX.CaseID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.UpdateSurgeryStatus()")
            Return False
        End Try

        Return True

    End Function

    Public Function UpdateSurgeryOperation(SX As ClsSurgery, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_surgery ")
                .Append("SET ItemCode = '" & SX.ItemCode & "', ItemDescription = '" & SX.ItemDescription & "', ItemGroup = '" & SX.ItemGroup & "', ItemTypeCode = '" & SX.ItemTypeCode & "', ")
                .Append("ItemTypeDescription = '" & SX.ItemTypeDescription & "', UnitPrice = '" & SX.UnitPrice & "', Quantity = '" & SX.Quantity & "', TotalPrice = '" & SX.TotalPrice & "', ")
                .Append("ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified =  " & CSQLDateTime(SX.Ref.DateModified) & " ")
                .Append("WHERE CaseID = '" & SX.CaseID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.UpdateSurgeryOperation()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetSurgeryDischarge(SX As ClsSurgery) As DataTable

        Dim DtSxDischarge As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT CaseID, SurgeryDate, EmployeeID, EmployeeName, SpecificInstruction, MedicationPrescribe, ")
                .Append("ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("DischargeDate, HasReviewDate, ReviewDate, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_surgerydischarge ")
                If SX.CaseID <> "" Then
                    .Append("WHERE CaseID = '" & SX.CaseID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSxDischarge)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetSurgeryDischarge()")
        End Try

        Return DtSxDischarge

    End Function

#Region "SurgeryDiagnosis"

    Public Function GetFastingStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_fasting ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetFastingStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetVaccineStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_vaccine ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetVaccineStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetGeneralAppearanceStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_generalappearance ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetGeneralAppearanceStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetHydrationStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_hydration ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetHydrationStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetMucousMembraneStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_mucousmembrane ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetMucousMembraneStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetCapillaryStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_capillary ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetCapillaryStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetRespiratoryStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_respiratory ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetRespiratoryStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetLungSoundStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_lungsound ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetLungSoundStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetHeartRateStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_heartrate ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetHeartRateStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetHeartRhythmStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_heartrhythm ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetHeartRhythmStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetHeartSoundStatus(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_heartsound ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetHeartSoundStatus()")
        End Try

        Return Dt

    End Function

    Public Function GetLevelOfRisk(ClsSurgery As ClsSurgery) As DataTable

        Dim Dt As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT StatusCode, StatusDescription ")
                .Append("FROM samc_sx_levelofrisk ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(Dt)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbSurgery.GetLevelOfRisk()")
        End Try

        Return Dt

    End Function

#End Region

End Class

