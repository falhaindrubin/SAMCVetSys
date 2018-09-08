Public Class FrmEmployeeRecords

    Private Sub FrmEmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAddNewAppointment_Click(sender As Object, e As EventArgs) Handles BtnAddNewAppointment.Click
        FrmEmployeeEntry.ShowDialog()
    End Sub

End Class