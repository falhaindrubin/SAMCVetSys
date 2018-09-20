Public Class FrmPaymentRecords
    Private Sub FrmPaymentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulatePaymentListing()
        Application.DoEvents()
    End Sub

    Private Sub PopulatePaymentListing()

        Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulatePaymentListing()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        FrmPaymentEntry.ShowDialog()
    End Sub

End Class