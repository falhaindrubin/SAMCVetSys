Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbDiagnosis

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
#Disable Warning IDE0044 ' Add readonly modifier
    Dim Da As OdbcDataAdapter
#Enable Warning IDE0044 ' Add readonly modifier

    Public Function AddNewDiagnosis(DG As ClsDiagnosis, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_diagnosis ")
                .Append("(VisitID, PetID, PetName, Diagnosis, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & DG.VisitID & "', '" & DG.PetID & "', '" & DG.PetName & "', '" & CSQLQuote(DG.Diagnosis) & "', ")
                .Append("'" & DG.Ref.CreatedBy & "', " & CSQLDateTime(DG.Ref.DateCreated) & ", '" & CSQLQuote(DG.Ref.ModifiedBy) & "', " & CSQLDateTime(DG.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("VisitID = '" & DG.VisitID & "', Diagnosis = '" & CSQLQuote(DG.Diagnosis) & "', ModifiedBy = '" & DG.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(DG.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbDiagnosis.AddNewDiagnosis()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewDiagnosisDetail(DG As ClsDiagnosisDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_diagnosisdetail ")
                .Append("(VisitID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice) ")
                .Append("VALUES ")
                .Append("('" & DG.VisitID & "', '" & DG.RowNo & "', '" & DG.ItemCode & "', '" & DG.ItemDescription & "', '" & DG.ItemGroup & "', '" & DG.ItemTypeCode & "', '" & DG.ItemTypeDescription & "', ")
                .Append("'" & DG.UnitPrice & "', '" & DG.Quantity & "', '" & DG.TotalPrice & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("VisitID = '" & DG.VisitID & "', RowNo = '" & DG.RowNo & "', ItemCode = '" & DG.ItemCode & "', ItemDescription = '" & DG.ItemDescription & "', UnitPrice = '" & DG.UnitPrice & "', ")
                .Append("ItemGroup = '" & DG.ItemGroup & "', ItemTypeCode = '" & DG.ItemTypeCode & "', ItemTypeDescription = '" & DG.ItemTypeDescription & "', ")
                .Append("Quantity = '" & DG.Quantity & "', TotalPrice = '" & DG.TotalPrice & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbDiagnosis.AddNewDiagnosisDetail()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetDiagnosisDetail(D As ClsDiagnosis) As DataTable

        Dim DtDiagnosis As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.VisitID, PetID, PetName, Diagnosis,  ")
                .Append("RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_diagnosis a ")
                .Append("INNER JOIN samc_diagnosisdetail b ON a.VisitID = b.VisitID ")
                If D.VisitID <> "" Then
                    .Append("WHERE a.VisitID = '" & D.VisitID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtDiagnosis)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbDiagnosis.GetVisitDiagnosis()")
        End Try

        Return DtDiagnosis

    End Function

End Class
