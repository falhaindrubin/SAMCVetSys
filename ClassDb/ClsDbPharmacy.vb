Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbPharmacy

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewPharmacyRequest(ByVal P As ClsPharmacy, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_pharmacy_req ")
                .Append("(RequestID, VisitID, Source, RequestDate, RqEmpID, RqEmpName, PhEmpID, PhEmpName, ApprovalDate, IsCompleted, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & P.RequestID & "', '" & P.VisitID & "', '" & P.Source & "', " & CSQLDateTime(P.RequestDate) & ", '" & P.RqEmpID & "', '" & P.RqEmpName & "', '" & P.PhEmpID & "', '" & P.PhEmpName & "', " & CSQLDateTime(P.ApprovalDate) & ", '" & P.IsCompleted & "', ")
                .Append("'" & P.Ref.CreatedBy & "', " & CSQLDateTime(P.Ref.DateCreated) & ", '" & P.Ref.ModifiedBy & "', " & CSQLDateTime(P.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("PhEmpID = '" & P.PhEmpID & "', PhEmpName = '" & P.PhEmpName & "', ApprovalDate = " & CSQLDateTime(P.ApprovalDate) & ", IsCompleted = '" & P.IsCompleted & "', ")
                .Append("ModifiedBy = '" & P.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(P.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn, DBTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbPharmacy.AddNewPharmacyRequest()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function AddNewPharmacyRequestDetail(P As ClsPharmacyDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_pharmacy_reqdetail ")
                .Append("(RequestID, VisitID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & P.RequestID & "', '" & P.VisitID & "', '" & P.RowNo & "', '" & P.ItemCode & "', '" & CSQLQuote(P.ItemDescription) & "', '" & P.ItemGroup & "', '" & P.ItemTypeCode & "', '" & P.ItemTypeDescription & "', '" & CSQLQuote(P.Prescription) & "', ")
                .Append("'" & P.Notes & "', '" & P.UnitPrice & "', '" & P.Quantity & "', '" & P.TotalPrice & "', ")
                .Append("'" & P.Ref.CreatedBy & "', " & CSQLDateTime(P.Ref.DateCreated) & ", '" & P.Ref.ModifiedBy & "', " & CSQLDateTime(P.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & P.ItemCode & "', ItemDescription = '" & CSQLQuote(P.ItemDescription) & "', ")
                .Append("ItemGroup = '" & P.ItemGroup & "', ItemTypeCode = '" & P.ItemTypeCode & "', ItemTypeDescription = '" & P.ItemTypeDescription & "', ")
                .Append("Prescription = '" & CSQLQuote(P.Prescription) & "', Notes = '" & CSQLQuote(P.Notes) & "', ")
                .Append("UnitPrice = '" & P.UnitPrice & "', Quantity = '" & P.Quantity & "', TotalPrice = '" & P.TotalPrice & "', ")
                .Append("ModifiedBy = '" & P.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(P.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbPharmacy.AddNewPharmacyRequestDetail()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetPharmacyRequest(P As ClsPharmacy) As DataTable

        Dim DtPharmacy As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT RequestID, VisitID, RequestDate, RqEmpID, RqEmpName, PhEmpID, PhEmpName, ApprovalDate, IsCompleted, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_pharmacy_req ")
                If P.RequestID <> "" Then
                    .Append("WHERE RequestID = '" & P.RequestID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtPharmacy)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbPharmacy.GetPharmacyRequest()")
        End Try

        Return DtPharmacy

    End Function

    Public Function GetPharmacyRequestDetail(P As ClsPharmacy) As DataTable

        Dim DtPharmacy As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT RequestID, VisitID, RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, Prescription, Notes, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_pharmacy_reqdetail ")
                If P.RequestID <> "" Then
                    .Append("WHERE RequestID = '" & P.RequestID & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtPharmacy)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbPharmacy.GetPharmacyRequestDetail()")
        End Try

        Return DtPharmacy

    End Function

End Class
