Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbProducts

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewProduct(PD As ClsProducts, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_products ")
                .Append("(ItemCode, ItemDescription, ItemType, ItemTypeCode, Price, CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & PD.ItemCode & "', '" & CSQLQuote(PD.ItemDescription) & "', '" & PD.ItemType & "', '" & PD.ItemTypeCode & "', '" & PD.Price & "', ")
                .Append("'" & PD.Ref.CreatedBy & "', " & CSQLDateTime(PD.Ref.DateCreated) & ", '" & PD.Ref.ModifiedBy & "', " & CSQLDateTime(PD.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ItemCode = '" & PD.ItemCode & "', ItemDescription = '" & CSQLQuote(PD.ItemDescription) & "', Price = '" & PD.Price & "', ")
                .Append("ModifiedBy = '" & PD.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(PD.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbProducts.AddNewProuduct()")
            Return False
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetProductList(PD As ClsProducts) As DataTable

        Dim DtProduct As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemCode, ItemDescription, ItemType, ItemTypeCode, Price, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_products ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtProduct)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbProducts.GetProductList()")
        End Try

        Return DtProduct

    End Function

    Public Function GetProductInformation(PD As ClsProducts) As DataTable

        Dim DtProducts As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemCode, ItemDescription, ItemType, ItemTypeCode, Price, CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_products ")
                If PD.ItemCode <> "" Then
                    .Append("WHERE ItemCode = '" & PD.ItemCode & "' ")
                End If
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtProducts)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbProducts.GetProductInformation()")
        End Try

        Return DtProducts

    End Function

    Public Function GetProductTypeList(PD As ClsProducts) As DataTable

        Dim DtProducts As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT ItemTypeCode, ItemTypeDescription ")
                .Append("FROM samc_producttype ")
                .Append("ORDER BY ItemTypeDescription ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtProducts)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbProducts.GetProductTypeList()")
        End Try

        Return DtProducts

    End Function


End Class
