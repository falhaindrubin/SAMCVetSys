Public Class FrmEmployeeRecords

    Private Sub FrmEmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
    End Sub

    Private Sub BtnAddNewAppointment_Click(sender As Object, e As EventArgs) Handles BtnAddNewAppointment.Click
        FrmEmployeeEntry.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class