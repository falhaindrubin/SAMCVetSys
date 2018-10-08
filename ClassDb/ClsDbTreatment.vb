﻿Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbTreatment

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
#Disable Warning IDE0044 ' Add readonly modifier
    Dim Da As OdbcDataAdapter
#Enable Warning IDE0044 ' Add readonly modifier

    Public Function AddNewTreatment(DD As ClsTreatment, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_treatment ")
                .Append("(VisitID, RowNo, ItemCode, ItemDescription, ItemTypeCode, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & DD.VisitID & "', '" & DD.RowNo & "', '" & DD.ItemCode & "', '" & CSQLQuote(DD.ItemDescription) & "', '" & DD.ItemTypeCode & "', '" & CSQLQuote(DD.Prescription) & "', ")
                .Append("'" & DD.Notes & "', '" & DD.UnitPrice & "', '" & DD.Quantity & "', '" & DD.TotalPrice & "', ")
                .Append("'" & DD.Ref.CreatedBy & "', " & CSQLDateTime(DD.Ref.DateCreated) & ", '" & DD.Ref.ModifiedBy & "', " & CSQLDateTime(DD.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("VisitID = '" & DD.VisitID & "', RowNo = '" & DD.RowNo & "', ItemCode = '" & DD.ItemCode & "', ItemDescription = '" & CSQLQuote(DD.ItemDescription) & "', ")
                .Append("ItemTypeCode = '" & DD.ItemTypeCode & "', Prescription = '" & CSQLQuote(DD.Prescription) & "', Notes = '" & CSQLQuote(DD.Notes) & "', ")
                .Append("UnitPrice = '" & DD.UnitPrice & "', Quantity = '" & DD.Quantity & "', TotalPrice = '" & DD.TotalPrice & "', ")
                .Append("ModifiedBy = '" & DD.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(DD.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbTreatment.AddNewTreatment()")
            Return False
        End Try

        Return True

    End Function




End Class