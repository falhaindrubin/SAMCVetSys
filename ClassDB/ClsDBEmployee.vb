Imports System.Text

Public Class ClsDBEmployee

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function GetVet(ByVal EMP As ClsEmployee) As DataTable

        Dim DtVet As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT * ")
                .Append("FROM samc_employee ")
                .Append("WHERE PositionCode = '01' ")
                .Append("ORDER BY EmpName ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtVet)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBEmployee.GetVet()")
        End Try

        Return DtVet

    End Function

End Class
