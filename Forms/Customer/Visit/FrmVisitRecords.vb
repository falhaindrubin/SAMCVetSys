Public Class FrmVisitRecords

    Private Sub BtnAddNewConsultation_Click(sender As Object, e As EventArgs) Handles BtnAddNewConsultation.Click
        With FrmVisitInformation
            .UserCommand = "ADD_NEW_CONSULTATION"
        End With

        FrmVisitInformation.ShowDialog()
    End Sub

    Private Sub FrmConsultationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateVisitListing()
    End Sub

    Protected Sub PopulateVisitListing()

        Dim DtConsultation As New DataTable
        Dim ClsConsultation As New ClsVisit

        Try
            DtConsultation = ClsConsultation.GetVisitListing(ClsConsultation)
            If DtConsultation.Rows.Count > 0 Then
                DgvConsultationListing.DataSource = DtConsultation
                DgvConsultationListing.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateConsultationListing()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DgvConsultationListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsultationListing.CellDoubleClick

        Dim CustomerID As String
        Dim VisitID As String

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    CustomerID = DgvConsultationListing.Rows(e.RowIndex).Cells("CustomerID").Value
                    VisitID = DgvConsultationListing.Rows(e.RowIndex).Cells("VisitID").Value
                    Dim Frm As New FrmVisitInformation With {
                        .UserCommand = "SHOW_CUSTOMER_CONSULTATION",
                        .VisitID = VisitID,
                        .CustomerID = CustomerID
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvConsultationListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateVisitListing()
    End Sub

End Class