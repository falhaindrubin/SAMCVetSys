Public Class FrmPaymentRecords
    Private Sub FrmPaymentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulatePaymentListing()
        Application.DoEvents()
    End Sub

    Private Sub PopulatePaymentListing()

        Dim DtPendingBill As New DataTable
        Dim ClsBill As New ClsBill

        Try
            DtPendingBill = ClsBill.GetPendingInvoiceList(ClsBill)
            If DtPendingBill.Rows.Count > 0 Then
                DgvPaymentListing.DataSource = DtPendingBill
                DgvPaymentListing.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulatePaymentListing()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        FrmPaymentInformation.ShowDialog()
    End Sub

    Private Sub DgvPaymentListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaymentListing.CellDoubleClick

        Dim CustomerID As String
        Dim VisitID As String

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    CustomerID = DgvPaymentListing.Rows(e.RowIndex).Cells("CustomerID").Value
                    VisitID = DgvPaymentListing.Rows(e.RowIndex).Cells("VisitID").Value
                    Dim Frm As New FrmPaymentInformation With {
                        .UserCommand = "SHOW_BILLING_INFO",
                        .VisitID = VisitID,
                        .InvoiceNo = DgvPaymentListing.Rows(e.RowIndex).Cells("InvoiceNo").Value,
                        .CustomerID = CustomerID
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvPaymentListing_CellDoubleClick()")
        End Try

    End Sub

End Class