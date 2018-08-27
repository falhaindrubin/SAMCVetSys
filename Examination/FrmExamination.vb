Public Class FrmExamination

    Private Sub FrmExamination_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub

End Class