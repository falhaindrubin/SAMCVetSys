Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbBill
    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewBill(BL As ClsBill, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_billing ")
                .Append("(InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName, GrossTotal, Discount, GrandTotal, Deposit, TotalDue, IsPaymentComplete, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & BL.InvoiceNo & "', '" & BL.VisitID & "', " & CSQLDate(BL.InvoiceDate) & ", '" & BL.CustomerID & "', '" & BL.CustomerName & "', '" & BL.GrossTotal & "', '" & BL.Discount & "', ")
                .Append("'" & BL.GrandTotal & "', '" & BL.Deposit & "', '" & BL.TotalDue & "', '" & BL.IsPaymentComplete & "', ")
                .Append("'" & BL.Ref.CreatedBy & "', " & CSQLDateTime(BL.Ref.DateCreated) & ", '" & BL.Ref.ModifiedBy & "', " & CSQLDateTime(BL.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("GrossTotal = '" & BL.GrossTotal & "', Discount = '" & BL.Discount & "', GrandTotal = '" & BL.GrandTotal & "', Deposit = '" & BL.Deposit & "', TotalDue = '" & BL.TotalDue & "', ")
                .Append("ModifiedBy = '" & BL.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(BL.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.AddNewBill()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewBillDetail(BL As ClsBillDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_billingdetail ")
                .Append("(InvoiceNo, RowNo, ItemCode, ItemDescription, ItemTypeCode, Prescription, Notes, Quantity, UnitPrice, ItemDiscount, TotalPrice) ")
                .Append("VALUES ")
                .Append("('" & BL.InvoiceNo & "', '" & BL.RowNo & "', '" & BL.ItemCode & "', '" & CSQLQuote(BL.ItemDescription) & "', '" & BL.ItemTypeCode & "', '" & CSQLQuote(BL.Prescription) & "', ")
                .Append("'" & BL.Notes & "', '" & BL.Quantity & "', '" & BL.UnitPrice & "', '" & BL.ItemDiscount & "', '" & BL.TotalPrice & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("RowNo = '" & BL.RowNo & "', ItemCode = '" & BL.ItemCode & "', ItemDescription = '" & CSQLQuote(BL.ItemDescription) & "', ItemTypeCode = '" & BL.ItemTypeCode & "', ")
                .Append("Prescription = '" & CSQLQuote(BL.Prescription) & "', Notes = '" & CSQLQuote(BL.Notes) & "', Quantity = '" & BL.Quantity & "', UnitPrice = '" & BL.UnitPrice & "', ")
                .Append("ItemDiscount = '" & BL.ItemDiscount & "', TotalPrice = '" & BL.TotalPrice & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.AddNewBillDetail()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function CheckExistingBill(ClsBill) As DataTable

        Dim DtBill As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append(" ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtBill)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.AddNewBillDetail()")
        End Try

        Return DtBill

    End Function

End Class
