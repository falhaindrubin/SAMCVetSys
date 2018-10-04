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

        Return True
        'Return IIf(Ret = 0, False, True)

    End Function

    Public Function CheckExistingBill(BL As ClsBill) As DataTable

        Dim DtBill As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName ")
                .Append("FROM samc_billing a ")
                .Append("INNER JOIN samc_billingdetail b ON a.InvoiceNo = b.InvoiceNo ")
                If BL.VisitID <> "" Then
                    .Append(" WHERE a.VisitID = '" & BL.VisitID & "' ")
                End If
                .Append("GROUP BY a.VisitID ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtBill)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.CheckExistingBill()")
        End Try

        Return DtBill

    End Function

    Public Function GetBillingInfo(BL As ClsBill) As DataTable

        Dim DtBill As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.InvoiceNo, a.VisitID, InvoiceDate, CustomerID, CustomerName, GrossTotal, Discount, GrandTotal, Deposit, TotalDue, IsPaymentComplete, CreatedBy, DateCreated, ModifiedBy, DateModified, ")
                .Append("RowNo, ItemCode, ItemDescription, ItemTypeCode, Prescription, Notes, Quantity, UnitPrice, ItemDiscount, TotalPrice ")
                .Append("FROM samc_billing a ")
                .Append("INNER JOIN samc_billingdetail b ON a.InvoiceNo = b.InvoiceNo ")
                If BL.VisitID <> "" Then
                    .Append("WHERE a.VisitID = '" & BL.VisitID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtBill)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.GetBillingInfo()")
        End Try

        Return DtBill

    End Function

    Public Function DeleteBillItems(BL As ClsBillDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_billingdetail ")
                .Append("WHERE InvoiceNo = '" & BL.InvoiceNo & "' AND RowNo = '" & BL.RowNo & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.DeleteBillItems()")
            Return False
        End Try

        Return True

    End Function

    Public Function UpdateBillRowNo(BL As ClsBillDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            If BL.RowNo <> BL.NewRowNo Then
                Sb = New StringBuilder
                With Sb
                    .Append("UPDATE samc_billingdetail ")
                    .Append("SET RowNo = '" & BL.NewRowNo & "' ")
                    .Append("WHERE InvoiceNo = '" & BL.InvoiceNo & "' AND RowNo = '" & BL.RowNo & "' ")
                End With
                Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
                Cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.UpdateBillRowNo()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetPendingInvoiceList(BL As ClsBill) As DataTable

        Dim DtBill As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT a.InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName, GrossTotal, Discount, GrandTotal, Deposit, TotalDue, IsPaymentComplete, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_billing a ")
                .Append("INNER Join samc_billingdetail b ON a.InvoiceNo = b.InvoiceNo ")
                .Append("WHERE IsPaymentComplete = '0' ")
                .Append("GROUP BY a.InvoiceNo ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtBill)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.GetinvoiceList()")
        End Try

        Return DtBill

    End Function

End Class
