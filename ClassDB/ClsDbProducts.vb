Imports System.Text

Public Class ClsDbProducts

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

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
