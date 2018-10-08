Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbServices

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewService(SVC As ClsServices, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_services ")
                .Append("(ItemCode, ItemDescription, ItemType, ItemTypeCode, Price, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & SVC.ItemCode & "', '" & CSQLQuote(SVC.ItemDescription) & "', '" & SVC.ItemType & "', '" & SVC.ItemTypeCode & "', '" & SVC.Price & "', ")
                .Append("'" & SVC.Ref.CreatedBy & "', " & CSQLDateTime(SVC.Ref.DateCreated) & ", '" & SVC.Ref.ModifiedBy & "', " & CSQLDateTime(SVC.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & SVC.ItemCode & "', ItemDescription = '" & CSQLQuote(SVC.ItemDescription) & "', Price = '" & SVC.Price & "', ")
                .Append("ModifiedBy = '" & SVC.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SVC.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbServices.GetServiceTypeList()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetServiceList(SVC As ClsServices) As DataTable

        Dim DtServices As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemCode, ItemDescription, ItemType, ItemTypeCode, Price, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_services ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtServices)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbServices.GetServiceList()")
        End Try

        Return DtServices

    End Function

    Public Function GetServiceTypeList(SVC As ClsServices) As DataTable

        Dim DtServices As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemTypeCode, ItemTypeDescription ")
                .Append("FROM samc_servicetype ")
                .Append("ORDER BY ItemTypeDescription ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtServices)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbServices.GetServiceTypeList()")
        End Try

        Return DtServices

    End Function

    Public Function GetServiceInformation(SVC As ClsServices) As DataTable

        Dim DtServices As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemCode, ItemDescription, ItemType, ItemTypeCode, Price, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_services ")
                If SVC.ItemCode <> "" Then
                    .Append("WHERE ItemCode = '" & SVC.ItemCode & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtServices)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbServices.GetServiceInformation()")
        End Try

        Return DtServices

    End Function

    Public Function GetTestType(SV As ClsServices) As DataTable

        Dim DtTest As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemTypeCode, ItemTypeDescription ")
                .Append("FROM samc_servicetype ")
                .Append("WHERE ItemTypeCode IN ('02','03','17','18','22') ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtTest)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbServices.GetTestType()")
        End Try

        Return DtTest

    End Function

    Public Function GetTestTypeName(SV As ClsServices) As DataTable

        Dim DtTest As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemCode, ItemDescription, ItemTypeCode ")
                .Append("FROM samc_services ")
                If SV.ItemTypeCode <> "" Then
                    .Append("WHERE ItemTypeCode = '" & SV.ItemTypeCode & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtTest)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbServices.GetTestTypeName()")
        End Try

        Return DtTest

    End Function

End Class
