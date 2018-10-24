Public Class ClsCalcBill

    Public Function AddItemToBill() As DataTable

        Dim DtInvoice As New DataTable

        Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsCalcBill.AddItemToBill()")
        End Try

        Return DtInvoice

    End Function

End Class
