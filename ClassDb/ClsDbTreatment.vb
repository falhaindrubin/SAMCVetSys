Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbTreatment

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewTreatment(T As ClsTreatment, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_treatment ")
                .Append("(VisitID, TreatmentDate, EmployeeID, EmployeeName, CustomerID, CustomerName, TelNo, MobileNo, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & T.VisitID & "', " & CSQLDateTime(T.TreatmentDate) & ", '" & T.EmployeeID & "', '" & T.EmployeeName & "', '" & T.CustomerID & "', '" & T.CustomerName & "', '" & T.TelNo & "', '" & T.MobileNo & "', ")
                .Append("'" & T.Ref.CreatedBy & "', " & CSQLDateTime(T.Ref.DateCreated) & ", '" & T.Ref.ModifiedBy & "', " & CSQLDateTime(T.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ModifiedBy = '" & T.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(T.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbTreatment.AddNewTreatment()")
            Return False
        End Try

        Return True

    End Function

    Public Function AddNewTreatmentDetail(T As ClsTreatmentDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_treatmentdetail ")
                .Append("(VisitID, TreatmentDate, PhRequestID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & T.VisitID & "', " & CSQLDateTime(T.TreatmentDate) & ", '" & T.PhRequestID & "', '" & T.RowNo & "', '" & T.ItemCode & "', '" & CSQLQuote(T.ItemDescription) & "', '" & T.ItemGroup & "', '" & T.ItemTypeCode & "', '" & T.ItemTypeDescription & "', '" & CSQLQuote(T.Prescription) & "', ")
                .Append("'" & T.Notes & "', '" & T.UnitPrice & "', '" & T.Quantity & "', '" & T.TotalPrice & "', ")
                .Append("'" & T.Ref.CreatedBy & "', " & CSQLDateTime(T.Ref.DateCreated) & ", '" & T.Ref.ModifiedBy & "', " & CSQLDateTime(T.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("PhRequestID = '" & T.PhRequestID & "', ItemCode = '" & T.ItemCode & "', ItemDescription = '" & CSQLQuote(T.ItemDescription) & "', ")
                .Append("ItemGroup = '" & T.ItemGroup & "', ItemTypeCode = '" & T.ItemTypeCode & "', ItemTypeDescription = '" & T.ItemTypeDescription & "', Prescription = '" & CSQLQuote(T.Prescription) & "', Notes = '" & CSQLQuote(T.Notes) & "', ")
                .Append("UnitPrice = '" & T.UnitPrice & "', Quantity = '" & T.Quantity & "', TotalPrice = '" & T.TotalPrice & "', ")
                .Append("ModifiedBy = '" & T.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(T.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbTreatment.AddNewTreatmentDetail()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetTreatment(ClsTreatment As ClsTreatment) As DataTable

        Dim DtTreatment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append(" ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtTreatment)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbTreatment.AddNewTreatment()")
        End Try

        Return DtTreatment

    End Function

    Public Function GetTreatmentDetail(T As ClsTreatment) As DataTable

        Dim DtTreatment As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT VisitID, PhRequestID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeDescription, ItemTypeCode, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_treatmentdetail ")
                If T.VisitID <> "" Then
                    .Append("WHERE VisitID = '" & T.VisitID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtTreatment)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbTreatment.GetTreatmentDetail()")
        End Try

        Return DtTreatment

    End Function




End Class
