﻿Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbPEFindings

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
#Disable Warning IDE0044 ' Add readonly modifier
    Dim Da As OdbcDataAdapter
#Enable Warning IDE0044 ' Add readonly modifier

    Public Function AddNewFindings(PEF As ClsPEFindings, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_pefindings ")
                .Append("(VisitID, PetID, PetName, Temperature, TemperamentCode, TemperamentName, BodyScoreCode, BodyScoreName, PEFindings, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & PEF.VisitID & "', '" & PEF.PetID & "', '" & PEF.PetName & "', '" & PEF.Temperature & "', '" & PEF.TemperamentCode & "', '" & PEF.TemperamentName & "', ")
                .Append("'" & PEF.BodyScoreCode & "', '" & PEF.BodyScoreName & "', '" & CSQLQuote(PEF.PEFindings) & "', ")
                .Append("'" & PEF.Ref.CreatedBy & "', " & CSQLDateTime(PEF.Ref.DateCreated) & ", '" & PEF.Ref.ModifiedBy & "', " & CSQLDateTime(PEF.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("VisitID = '" & PEF.VisitID & "', Temperature = '" & PEF.Temperature & "', TemperamentCode = '" & PEF.TemperamentCode & "', TemperamentName = '" & PEF.TemperamentName & "', ")
                .Append("BodyScoreCode = '" & PEF.BodyScoreCode & "', BodyScoreName = '" & PEF.BodyScoreName & "', PEFindings = '" & CSQLQuote(PEF.PEFindings) & "', ")
                .Append("ModifiedBy = '" & PEF.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(PEF.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbPEFindings.AddNewFindings()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function


End Class
