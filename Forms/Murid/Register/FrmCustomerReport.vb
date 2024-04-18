Imports CrystalDecisions.CrystalReports.Engine
Imports SAMCVetSys.ModUtility

Public Class FrmCustomerReport

    Dim RptCustomerInformation As New RptCustomerInformation

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
        End Set
    End Property

    Private Sub FrmCustomerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        GetCustomerReport()
    End Sub

    Private Sub GetCustomerReport()

        Dim DtCustomerInformation As New DataTable
        Dim DtCompanyInformation As New DataTable
        Dim DtPetInformation As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim ClsCompany As New ClsCompany
        Dim ClsPet As New ClsPet

        Try
            ClsCustomer.CustomerID = CustomerID
            ClsPet.CustomerID = CustomerID
            DtCustomerInformation = ClsCustomer.GetCustomerInformation(ClsCustomer)
            DtPetInformation = ClsPet.GetPetListing(ClsPet)
            DtCompanyInformation = ClsCompany.GetCompanyInformation(ClsCompany)
            
            If DtCustomerInformation.Rows.Count > 0 Then

            End If

            'RptCustomerInformation.SetDataSource(DtCustomerInformation)
            RptCustomerInformation.Database.Tables.Item("CustomerInformation").SetDataSource(DtCustomerInformation)
            RptCustomerInformation.Database.Tables.Item("PetInformation").SetDataSource(DtPetInformation)

            With RptCustomerInformation
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
                .SetParameterValue("FaxNo", cstrnull(DtCompanyInformation.Rows(0).Item("FaxNo")))
                .SetParameterValue("Email", DtCompanyInformation.Rows(0).Item("Email"))
            End With

            With CrvCustomerInformation
                .ReportSource = RptCustomerInformation
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerReport.GetCustomerReport()")
        End Try

    End Sub

End Class