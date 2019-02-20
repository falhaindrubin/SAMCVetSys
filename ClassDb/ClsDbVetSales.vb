Imports SAMCVetSys.ModUtility
Imports System.Text

Public Class ClsDbVetSales

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddVetSales(S As ClsVetSales, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_vetsales ")
                .Append("(SalesDate, VisitID, EmployeeID, EmployeeName, PositionCode, ChSource, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("(" & CSQLDateTime(S.SalesDate) & ", '" & S.VisitID & "', '" & S.EmployeeID & "', '" & S.EmployeeName & "', '" & S.PositionCode & "', '" & S.ChSource & "', ")
                .Append("'" & S.ItemCode & "', '" & CSQLQuote(S.ItemDescription) & "', '" & S.ItemGroup & "', '" & S.ItemTypeCode & "', '" & CSQLQuote(S.ItemTypeDescription) & "', ")
                .Append("'" & S.UnitPrice & "', '" & S.Quantity & "', '" & S.TotalPrice & "', ")
                .Append("'" & S.Ref.CreatedBy & "', " & CSQLDateTime(S.Ref.DateCreated) & ", '" & S.Ref.ModifiedBy & "', " & CSQLDateTime(S.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ChSource = '" & S.ChSource & "', ItemCode = '" & S.ItemCode & "', ItemDescription = '" & S.ItemDescription & "', ItemGroup = '" & S.ItemGroup & "', ItemTypeCode = '" & S.ItemTypeCode & "', ")
                .Append("ItemTypeDescription = '" & CSQLQuote(S.ItemTypeDescription) & "', UnitPrice = '" & S.UnitPrice & "', Quantity = '" & S.Quantity & "', TotalPrice = '" & S.TotalPrice & "', ")
                .Append("ModifiedBy = '" & S.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(S.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbVetSales.AddVetSales()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

End Class
