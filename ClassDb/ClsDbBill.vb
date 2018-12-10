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
                .Append("(InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName, MobileNo, Email, PetID, PetName, ")
                .Append("GrandTotal, Deposit, Discount, TotalDue, IsPaymentComplete, IsCash, IsDebitCreditCard, IsCheque, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & BL.InvoiceNo & "', '" & BL.VisitID & "', " & CSQLDate(BL.InvoiceDate) & ", '" & BL.CustomerID & "', '" & BL.CustomerName & "', '" & BL.MobileNo & "', '" & BL.Email & "', '" & BL.PetID & "', '" & BL.PetName & "', ")
                .Append("'" & BL.GrandTotal & "', '" & BL.Deposit & "', '" & BL.Discount & "', '" & BL.TotalDue & "', ")
                .Append("'" & BL.IsPaymentComplete & "', '" & BL.IsCash & "', '" & BL.IsDebitCreditCard & "', '" & BL.IsCheque & "', ")
                .Append("'" & BL.Ref.CreatedBy & "', " & CSQLDateTime(BL.Ref.DateCreated) & ", '" & BL.Ref.ModifiedBy & "', " & CSQLDateTime(BL.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("GrandTotal = '" & BL.GrandTotal & "', Deposit = '" & BL.Deposit & "', Discount = '" & BL.Discount & "', TotalDue = '" & BL.TotalDue & "', ")
                .Append("IsPaymentComplete = '" & BL.IsPaymentComplete & "', ")
                .Append("IsCash = '" & BL.IsCash & "', IsDebitCreditCard = '" & BL.IsDebitCreditCard & "', IsCheque = '" & BL.IsCheque & "', ")
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
                .Append("(InvoiceNo, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, Quantity, UnitPrice, TotalPrice) ")
                .Append("VALUES ")
                .Append("('" & BL.InvoiceNo & "', '" & BL.RowNo & "', '" & BL.ItemCode & "', '" & CSQLQuote(BL.ItemDescription) & "', '" & BL.ItemGroup & "', '" & BL.ItemTypeCode & "', '" & BL.ItemTypeDescription & "', '" & CSQLQuote(BL.Prescription) & "', ")
                .Append("'" & BL.Notes & "', '" & BL.Quantity & "', '" & BL.UnitPrice & "', '" & BL.TotalPrice & "') ")
                .Append("ON DUPLICATE KEY UPDATE ")
                '.Append("ItemCode = '" & BL.ItemCode & "', ItemDescription = '" & CSQLQuote(BL.ItemDescription) & "', ItemGroup = '" & BL.ItemGroup & "', ItemTypeCode = '" & BL.ItemTypeCode & "', ItemTypeDescription = '" & BL.ItemTypeDescription & "', ")
                .Append("Prescription = '" & CSQLQuote(BL.Prescription) & "', Notes = '" & CSQLQuote(BL.Notes) & "', Quantity = '" & BL.Quantity & "', UnitPrice = '" & BL.UnitPrice & "', ")
                .Append("TotalPrice = '" & BL.TotalPrice & "' ")
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
                .Append("SELECT a.InvoiceNo, a.VisitID, InvoiceDate, CustomerID, CustomerName, PetID, PetName, Discount, GrandTotal, Deposit, TotalDue, ")
                .Append("IsPaymentComplete, IsCash, IsDebitCreditCard, IsCheque, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified, ")
                .Append("RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, Quantity, UnitPrice, TotalPrice ")
                .Append("FROM samc_billing a ")
                .Append("INNER JOIN samc_billingdetail b ON a.InvoiceNo = b.InvoiceNo ")
                If BL.InvoiceNo <> "" Then
                    .Append("WHERE a.InvoiceNo = '" & BL.InvoiceNo & "' ")
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
                .Append("SELECT a.InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName, Discount, GrandTotal, Deposit, TotalDue, IsPaymentComplete, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_billing a ")
                .Append("INNER Join samc_billingdetail b ON a.InvoiceNo = b.InvoiceNo ")
                '.Append("WHERE IsPaymentComplete = '0' ")
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

    Public Function GetBillHeader(B As ClsBill) As DataTable

        Dim DtBillHeader As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName, Discount, GrandTotal, Deposit, TotalDue, IsPaymentComplete, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_billing ")
                If B.VisitID <> "" Then
                    .Append("WHERE VisitID = '" & B.VisitID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtBillHeader)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.GetBillHeader()")
        End Try

        Return DtBillHeader

    End Function

    Public Function GetBillDetail(B As ClsBill) As DataTable

        Dim DtBillDetail As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT InvoiceNo, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeDescription, ItemTypeCode, Prescription, Notes, Quantity, UnitPrice, TotalPrice ")
                .Append("FROM samc_billingdetail ")
                If B.InvoiceNo <> "" Then
                    .Append("WHERE InvoiceNo = '" & B.InvoiceNo & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtBillDetail)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.GetBillDetail()")
        End Try

        Return DtBillDetail

    End Function

    Public Function DeleteBill(B As ClsBill, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_billing ")
                .Append("WHERE InvoiceNo = '" & B.InvoiceNo & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_billingdetail ")
                .Append("WHERE InvoiceNo = '" & B.InvoiceNo & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery() + Ret

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.DeleteBill()")
            Return False
        End Try

        Return True
        'Return IIf(Ret = 0, False, True)

    End Function

    Public Function UpdateBillingAmount(B As ClsBill, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("UPDATE samc_billing ")
                .Append("SET GrandTotal = '" & B.GrandTotal & "', Deposit = '" & B.Deposit & "', Discount = '" & B.Discount & "', TotalDue = '" & B.TotalDue & "' ")
                .Append("WHERE InvoiceNo = '" & B.InvoiceNo & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.UpdateBillingAmount()")
            Return False
        End Try

        Return True

    End Function

    Public Function GetInvoiceByVisitID(B As ClsBill) As DataTable

        Dim DtInvoiceNo As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT InvoiceNo, VisitID, InvoiceDate, CustomerID, CustomerName, MobileNo, Email, PetID, PetName, GrandTotal, Deposit, Discount, TotalDue, IsPaymentComplete, IsCash, IsDebitCreditCard, IsCheque, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_billing ")
                .Append("WHERE VisitID = '" & B.VisitID & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtInvoiceNo)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbBill.GetInvoiceByVisitID()")
        End Try

        Return DtInvoiceNo

    End Function

End Class
