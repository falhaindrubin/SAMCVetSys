Imports System.Data.Odbc
Imports System.Text
Imports SAMCVetSys.ModUtility

Public Class ClsDBCompany

    Dim Sb As StringBuilder
    Dim Cmd As OdbcCommand
    Dim Da As OdbcDataAdapter

    Public Function GetCompanyInformation(COM As ClsCompany) As DataTable

        Dim DtCompanyInformation As New DataTable

        Try
            Sb = New StringBuilder
            With Sb
                .Append("SELECT CompanyCode, CompanyName, AddressLine1, AddressLine2, AddressLine3, AddressLine4, Postcode, City, State, Country, TelNo, FaxNo, Email, ")
                .Append("CreatedBy, DateCreated, ModifiedBy, DateModified ")
                .Append("FROM samc_company ")
            End With

            Cmd = New OdbcCommand(Sb.ToString, DBConn)
            Da = New OdbcDataAdapter(Cmd)
            Da.Fill(DtCompanyInformation)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ClsDBCompany.GetCompanyInformation()")
        End Try

        Return DtCompanyInformation

    End Function

End Class
