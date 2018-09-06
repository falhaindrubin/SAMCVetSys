Public Class FrmUserRecords

    Private Sub FrmEmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAddNewAppointment_Click(sender As Object, e As EventArgs) Handles BtnAddNewAppointment.Click
        FrmUserEntry.ShowDialog()
    End Sub

End Class