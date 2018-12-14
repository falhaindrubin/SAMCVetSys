Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDbManagement

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function AddNewSurgeryMaterialMgmt(SX As ClsSurgeryMaterial, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb
                .Append("INSERT INTO samc_sx_materials ")
                .Append("(RowNo, ItemCode, ItemDescription, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified) ")
                .Append("VALUES ")
                .Append("('" & SX.RowNo & "', '" & SX.ItemCode & "', '" & CSQLQuote(SX.ItemDescription) & "', '" & SX.ItemGroup & "', '" & SX.ItemTypeCode & "', '" & CSQLQuote(SX.ItemTypeDescription) & "', '" & SX.UnitPrice & "', ")
                .Append("'" & SX.Quantity & "', '" & SX.TotalPrice & "', ")
                .Append("'" & SX.Ref.CreatedBy & "', " & CSQLDateTime(SX.Ref.DateCreated) & ", '" & SX.Ref.ModifiedBy & "', " & CSQLDateTime(SX.Ref.DateModified) & ") ")
                .Append("ON DUPLICATE KEY UPDATE ")
                .Append("ModifiedBy = '" & SX.Ref.ModifiedBy & "', DateModified = " & CSQLDateTime(SX.Ref.DateModified) & " ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbManagement.AddNewSurgeryMaterial()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

    Public Function GetSurgeryMaterialsMgmt(SX As ClsSurgeryMaterial) As DataTable

        Dim DtSx As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT RowNo, ItemCode, ItemDescription, Prescription, Notes, ItemGroup, ItemTypeCode, ItemTypeDescription, UnitPrice, Quantity, TotalPrice, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_sx_materials ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtSx)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbManagement.GetSurgeryMaterials()")
        End Try

        Return DtSx

    End Function

    Public Function DeleteSurgeryItem(SX As ClsSurgeryMaterial, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            Sb = New StringBuilder
            With Sb
                .Append("DELETE FROM samc_sx_materials ")
                .Append("WHERE RowNo = '" & SX.RowNo & "' ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbManagement.DeleteSurgeryItem()")
            Return False
        End Try

        Return True

    End Function

End Class

