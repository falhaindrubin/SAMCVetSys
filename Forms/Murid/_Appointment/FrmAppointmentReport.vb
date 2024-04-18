Imports SAMCVetSys.ModUtility

Public Class FrmAppointmentReport

    Private _AppointmentID As String
    Public Property AppointmentID As String
        Get
            Return _AppointmentID
        End Get
        Set(value As String)
            _AppointmentID = value
        End Set
    End Property

    Dim RptAppointment As New RptAppointment

    Private Sub FrmAppointmentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateAppointment()
    End Sub

    Private Sub PopulateAppointment()

        Dim DtAppointment As New DataTable
        Dim DtCompanyInformation As New DataTable
        Dim ClsAppointment As New ClsAppointment
        Dim ClsCompany As New ClsCompany

        Try
            With ClsAppointment
                .AppointmentID = AppointmentID
            End With

            DtAppointment = ClsAppointment.GetAppointmentReport(ClsAppointment)
            DtCompanyInformation = ClsCompany.GetCompanyInformation(ClsCompany)

            If DtAppointment.Rows.Count > 0 Then

                RptAppointment.SetDataSource(DtAppointment)
                With RptAppointment
                    .SetParameterValue("CompanyCode", CStr(DtCompanyInformation.Rows(0).Item("CompanyCode")))
                    .SetParameterValue("CompanyName", DtCompanyInformation.Rows(0).Item("CompanyName"))
                    .SetParameterValue("AddressLine1", DtCompanyInformation.Rows(0).Item("AddressLine1"))
                    .SetParameterValue("AddressLine2", DtCompanyInformation.Rows(0).Item("AddressLine2"))
                    .SetParameterValue("AddressLine3", DtCompanyInformation.Rows(0).Item("AddressLine3"))
                    .SetParameterValue("AddressLine4", DtCompanyInformation.Rows(0).Item("AddressLine4"))
                    .SetParameterValue("Postcode", DtCompanyInformation.Rows(0).Item("Postcode"))
                    .SetParameterValue("City", DtCompanyInformation.Rows(0).Item("City"))
                    .SetParameterValue("State", DtCompanyInformation.Rows(0).Item("State"))
                    .SetParameterValue("Country", DtCompanyInformation.Rows(0).Item("Country"))
                    .SetParameterValue("TelNo", DtCompanyInformation.Rows(0).Item("TelNo"))
                    .SetParameterValue("FaxNo", Cstrnull(DtCompanyInformation.Rows(0).Item("FaxNo")))
                    .SetParameterValue("Email", DtCompanyInformation.Rows(0).Item("Email"))
                End With

                With CrvAppointment
                    .ReportSource = RptAppointment
                    .Show()
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmAppointmentReport.PopulateAppointment()")
        End Try

    End Sub

End Class