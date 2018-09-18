Imports System.Text

Public Class ClsDBUser

    Dim Sb As New StringBuilder
    Dim Cmd As New OdbcCommand
    Dim Da As New OdbcDataAdapter

    Public Function AddNewUser(USER As ClsUser, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim Ret As Integer

        Try
            Sb = New StringBuilder
            With Sb

            End With

            Cmd = New OdbcCommand(Sb.ToString, DbConn, DbTrans)
            Ret = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDbUser.AddNewUser()")
        End Try

        Return IIf(Ret = 0, False, True)

    End Function

End Class
