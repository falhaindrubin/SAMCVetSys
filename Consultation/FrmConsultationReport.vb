Public Class FrmConsultationReport

    Private _ConsultationID As String
    Public Property ConsultationID As String
        Get
            Return _ConsultationID
        End Get
        Set(value As String)
            _ConsultationID = value
        End Set
    End Property

    Private Sub FrmConsultationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class