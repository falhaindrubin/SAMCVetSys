Public Class FrmConsultationRecords

    Private Sub BtnAddNewConsultation_Click(sender As Object, e As EventArgs) Handles BtnAddNewConsultation.Click
        With FrmConsultationEntry
            .UserCommand = "ADD_NEW_CONSULTATION"
        End With

        FrmConsultationEntry.ShowDialog()
    End Sub

    Private Sub FrmConsultationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class