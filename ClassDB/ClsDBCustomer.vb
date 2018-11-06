Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDBCustomer

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewCustomer(ByVal CUST As ClsCustomer, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            sb = New StringBuilder
            With sb
                .Append("INSERT INTO samc_customer ")
                .Append("(CustomerID, SaluteCode, SaluteName, CustomerName, NRICPassportNo, AddressLine1, AddressLine2, AddressLine3, AddressLine4, ")
                .Append("TelNo, MobileNo, Email, Postcode, City, State, Country, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & CUST.CustomerID & "', '" & CUST.SaluteCode & "', '" & CUST.SaluteName & "', '" & CUST.CustomerName & "', '" & CUST.NRICPassportNo & "', ")
                .Append("'" & CUST.AddressLine1 & "', '" & CUST.AddressLine2 & "', '" & CUST.AddressLine3 & "', '" & CUST.AddressLine4 & "', '" & CUST.TelNo & "', '" & CUST.MobileNo & "', '" & CUST.Email & "', ")
                .Append("'" & CUST.Postcode & "', '" & CUST.City & "', '" & CUST.State & "', '" & CUST.Country & "', ")
                .Append("'" & CUST.Ref.CreatedBy & "', " & CSQLDateTime(CUST.Ref.DateCreated) & ", '" & CUST.Ref.ModifiedBy & "', " & CSQLDateTime(CUST.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("SaluteCode = '" & CUST.SaluteCode & "', SaluteName = '" & CUST.SaluteName & "', CustomerName = '" & CUST.CustomerName & "', ")
                .Append("AddressLine1 = '" & CUST.AddressLine1 & "', AddressLine2 = '" & CUST.AddressLine2 & "', AddressLine3 = '" & CUST.AddressLine3 & "', AddressLine4 = '" & CUST.AddressLine4 & "', ")
                .Append("TelNo = '" & CUST.TelNo & "', MobileNo = '" & CUST.MobileNo & "', Email = '" & CUST.Email & "', Postcode = '" & CUST.Postcode & "', City = '" & CUST.City & "', State = '" & CUST.State & "', Country = '" & CUST.Country & "', ")
                .Append("ModifiedBy = '" & CUST.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(CUST.Ref.DateModified) & " ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ClsDBCustomer.AddNewCustomer()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function UpdateCustomer(ByVal CUST As ClsCustomer, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Try
            sb = New StringBuilder
            With sb
                .Append("UPDATE samc_customer ")
                .Append("SET SaluteCode = '" & CUST.SaluteCode & "', SaluteName = '" & CUST.SaluteName & "', CustomerName = '" & CUST.CustomerName & "', NRICPassportNo = '" & CUST.NRICPassportNo & "', ")
                .Append("AddressLine1 = '" & CUST.AddressLine1 & "', AddressLine2 = '" & CUST.AddressLine2 & "', AddressLine3 = '" & CUST.AddressLine3 & "', AddressLine4 = '" & CUST.AddressLine4 & "', ")
                .Append("TelNo = '" & CUST.TelNo & "', MobileNo = '" & CUST.MobileNo & "', DateModified = " & CSQLDateTime(CUST.Ref.DateModified) & ", ModifiedBy = '" & CUST.Ref.ModifiedBy & "' ")
                .Append("WHERE NRICPassportNo = '" & CUST.NRICPassportNo & "' ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn, DBTrans)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBCustomer.UpdateCustomer()")
            Return False
        End Try

        Return True

    End Function

    Public Function CheckExistingCustomer(ByVal CUSTOMER As ClsCustomer) As DataTable

        Dim DtCustomer As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT CustomerName, NRICPassportNo ")
                .Append("FROM samc_customer ")
                .Append("WHERE NRICPassportNo = '" & CUSTOMER.NRICPassportNo & "' ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtCustomer)

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ClsDBCustomer.CheckExistingCustomer()")
        End Try

        Return DtCustomer

    End Function

    Public Function GetCustomerListing(ByVal CUST As ClsCustomer) As DataTable

        Dim DtCustomerListing As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT CustomerID, SaluteCode, SaluteName, CustomerName, NRICPassportNo, AddressLine1, AddressLine2, AddressLine3, AddressLine4, TelNo, MobileNo, Email, ")
                .Append("Postcode, City, State, Country, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_customer ")

                If CUST.SQLQueryCondition <> "" Then
                    '.Append("WHERE CustomerID = '" & CUSTOMER.CustomerID & "' ")
                    .Append("" & CUST.SQLQueryCondition & " ")
                End If

            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtCustomerListing)

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ClsDBCustomer.GetCustomerListing()")
        End Try

        Return DtCustomerListing

    End Function

    Public Function GetCustomerInformation(ByVal CUST As ClsCustomer) As DataTable

        Dim DtCustomerInformation As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT CustomerID, SaluteCode, SaluteName, CustomerName, NRICPassportNo, AddressLine1, AddressLine2, AddressLine3, AddressLine4, TelNo, MobileNo, Email, ")
                .Append("Postcode, City, State, Country, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_customer ")

                If CUST.CustomerID <> "" Then
                    .Append("WHERE CustomerID = '" & CUST.CustomerID & "' ")
                End If

                'If CUST.SQLQueryCondition <> "" Then
                '    '.Append("WHERE CustomerID = '" & CUSTOMER.CustomerID & "' ")
                '    .Append("" & CUST.SQLQueryCondition & " ")
                'End If

            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtCustomerInformation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "ClsDBCustomer.GetCustomerInformation()")
        End Try

        Return DtCustomerInformation

    End Function

    Public Function GetSalutation(ByVal CUST As ClsCustomer) As DataTable

        Dim DtSalute As New DataTable

        Try
            sb = New StringBuilder
            With sb
                .Append("SELECT SaluteCode, SaluteName ")
                .Append("FROM samc_salutation ")
            End With

            cmd = New OdbcCommand(sb.ToString, DBConn)
            da = New OdbcDataAdapter(cmd)
            da.Fill(DtSalute)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBCustomer.GetSalutation()")
        End Try

        Return DtSalute

    End Function

End Class
