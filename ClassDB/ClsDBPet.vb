﻿Imports System.Text
Imports System.Data.Odbc
Imports SAMCVetSys.ModUtility

Public Class ClsDBPet

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewPet(ByVal PET As ClsPet, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            sb = New StringBuilder
            With sb
                .Append("INSERT INTO samc_pet ")
                .Append("(CustomerID, PetID, PetName, PetDOB, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, SexCode, SexName, NeuterCode, NeuterName, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & PET.CustomerID & "', '" & PET.PetID & "', '" & PET.PetName & "', " & CSQLDate(PET.PetDOB) & ", '" & PET.AnimalTypeCode & "', '" & PET.AnimalTypeName & "', ")
                .Append("'" & PET.BreedCode & "', '" & PET.BreedName & "', '" & PET.SexCode & "', '" & PET.SexName & "', '" & PET.NeuterCode & "', '" & PET.NeuterName & "', ")
                .Append("'" & PET.Ref.CreatedBy & "', " & CSQLDateTime(PET.Ref.DateCreated) & ", '" & PET.Ref.ModifiedBy & "', " & CSQLDateTime(PET.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("PetName = '" & PET.PetName & "', PetDOB = " & CSQLDate(PET.PetDOB) & ", AnimalTypeCode = '" & PET.AnimalTypeCode & "', AnimalTypeName = '" & PET.AnimalTypeName & "', ")
                .Append("BreedCode = '" & PET.BreedCode & "', BreedName = '" & PET.BreedName & "', SexCode = '" & PET.SexCode & "', SexName = '" & PET.SexName & "', NeuterCode ='" & PET.NeuterCode & "', NeuterName = '" & PET.NeuterName & "', ")
                .Append("ModifiedBy = '" & PET.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(PET.Ref.DateModified) & " ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
            Ret = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBPet.AddNewPet()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function UpdatePet(ByVal PET As ClsPet, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Try
            sb = New StringBuilder
            With sb
                .Append("INSERT INTO samc_pet ")
                .Append("(CustomerID, PetID, PetName, PetDOB, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, SexCode, SexName, NeuterCode, NeuterName, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & PET.CustomerID & "', '" & PET.PetID & "', '" & PET.PetName & "', " & CSQLDate(PET.PetDOB) & ", '" & PET.AnimalTypeCode & "', '" & PET.AnimalTypeName & "', ")
                .Append("'" & PET.BreedCode & "', '" & PET.BreedName & "', '" & PET.SexCode & "', '" & PET.SexName & "', '" & PET.NeuterCode & "', '" & PET.NeuterName & "', ")
                .Append("'" & PET.Ref.CreatedBy & "', " & CSQLDateTime(PET.Ref.DateCreated) & ", '" & PET.Ref.ModifiedBy & "', " & CSQLDateTime(PET.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("CustomerID = '" & PET.CustomerID & "', PetID = '" & PET.PetID & "', PetName = '" & PET.PetName & "', PetDOB = " & CSQLDate(PET.PetDOB) & ", ")
                .Append("AnimalTypeCode = '" & PET.AnimalTypeCode & "', AnimalTypeName = '" & PET.AnimalTypeName & "', BreedCode = '" & PET.BreedCode & "', BreedName = '" & PET.BreedName & "', ")
                .Append("SexCode = '" & PET.SexCode & "', SexName = '" & PET.SexName & "', NeuterCode = '" & PET.NeuterCode & "', NeuterName = '" & PET.NeuterName & "', ")
                .Append("CreatedBy = '" & PET.Ref.CreatedBy & "', DateCreated = " & CSQLDateTime(PET.Ref.DateCreated) & ", ")
                .Append("ModifiedBy = '" & PET.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(PET.Ref.DateModified) & " ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBPet.UpdatePet()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetPetListing(ByVal PET As ClsPet) As DataTable

        Dim DtPetListing As New DataTable

        Try
            sb = New StringBuilder
            With Sb
                .Append("Select a.CustomerID, PetID, PetName, PetDOB, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, SexCode, SexName, NeuterCode, NeuterName, ")
                .Append("b.CreatedBy, b.DateCreated, b.ModifiedBy, b.DateModified ")
                .Append("FROM samc_pet a ")
                .Append("INNER JOIN samc_customer b On a.CustomerID = b.CustomerID ")
                .Append("WHERE a.CustomerID = '" & PET.CustomerID & "' ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtPetListing)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBPet.GetPetListing()")
        End Try

        Return DtPetListing

    End Function

    Public Function GetAnimalType(PET As ClsPet) As DataTable

        Dim DtAnimalType As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT AnimalTypeCode, AnimalTypeName ")
                .Append("FROM samc_animaltype ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtAnimalType)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBPet.GetAnimalType()")
        End Try

        Return DtAnimalType

    End Function

    Public Function GetPetBreed(PET As ClsPet) As DataTable

        Dim DtBreed As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT AnimalTypeCode, BreedCode, BreedName ")
                .Append("FROM samc_breed ")

                If PET.AnimalTypeCode <> "" Then
                    .Append("WHERE AnimalTypeCode = '" & PET.AnimalTypeCode & "' ")
                End If

                .Append("ORDER BY BreedName ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtBreed)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBPet.GetBreed()")
        End Try

        Return DtBreed

    End Function

    Public Function GetNeuterStatus(PET As ClsPet) As DataTable

        Dim DtPetStatus As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT NeuterCode, NeuterName ")
                .Append("FROM samc_neuter ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtPetStatus)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBPet.GetNeuterStatus()")
        End Try

        Return DtPetStatus

    End Function

    Public Function GetPetSex(PET As ClsPet) As DataTable

        Dim DtPetSex As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT SexCode, SexName ")
                .Append("FROM samc_sex ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtPetSex)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "ClsDBPet.GetPetSex()")
        End Try

        Return DtPetSex

    End Function

    Public Function GetPetTemperament(PET As ClsPet) As DataTable

        Dim DtPetTemperament As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT TemperamentCode, TemperamentName ")
                .Append("FROM samc_temperament ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtPetTemperament)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "ClsDBPet.GetPetTemperament()")
        End Try

        Return DtPetTemperament

    End Function

    Public Function GetPetBodyScore(PET As ClsPet) As DataTable

        Dim DtPetBodyScore As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT BodyScoreCode, BodyScoreName ")
                .Append("FROM samc_bodyscore ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtPetBodyScore)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "ClsDBPet.GetPetBodyScore()")
        End Try

        Return DtPetBodyScore

    End Function

End Class
