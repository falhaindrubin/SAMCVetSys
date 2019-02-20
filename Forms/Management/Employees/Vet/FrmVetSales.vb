Public Class FrmVetSales

    Private Sub FrmVetSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateYear(Now.AddYears(-1), Now.AddYears(0), CmbYear)
    End Sub



End Class