Public Class FrmTreatmentRecords

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        With FrmTreatmentEntry
            .UserCommand = "ADD_NEW_TREATMENT"
            .ShowDialog()
        End With
    End Sub

    Private Sub FrmTreatmentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
    End Sub

    Private Sub PopulateIncompleteVisit()

        Dim DtTreatment As New DataTable

        Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateIncompleteVisit()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

End Class