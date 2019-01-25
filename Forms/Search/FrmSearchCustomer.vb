Imports System.Text

Public Class FrmSearchCustomer

    Private _Source As String
    Public Property Source As String
        Get
            Return _Source
        End Get
        Set(value As String)
            _Source = value
        End Set
    End Property

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
        End Set
    End Property

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private _AppointmentID As String
    Public Property AppointmentID As String
        Get
            Return _AppointmentID
        End Get
        Set(value As String)
            _AppointmentID = value
        End Set
    End Property

    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateCustomerListing(Source)
        TxtSearchText.Select()
    End Sub

    Private Sub PopulateCustomerListing(Source As String)

        Dim DtCustomer As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim StrOp As String = "WHERE"

        Try
            ClsCustomer.SQLQueryCondition = FilterSQL(StrOp)
            DtCustomer = ClsCustomer.GetCustomerListing(ClsCustomer)

            If DtCustomer.Rows.Count > 0 Then

                With DgvCustomerList
                    .Rows.Clear()
                    For i As Integer = 0 To DtCustomer.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("DgvCustomerID").Value = DtCustomer.Rows(i).Item("CustomerID")
                        .Rows(i).Cells("DgvCustomerName").Value = DtCustomer.Rows(i).Item("CustomerName")
                        .Rows(i).Cells("DgvNRICPassportNo").Value = DtCustomer.Rows(i).Item("NRICPassportNo")
                    Next
                End With

                'DgvSearchResult.DataSource = DtCustomer
                'DgvSearchResult.Columns("SaluteCode").Visible = False
                'DgvSearchResult.Show()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ShowCustomerRecords()")
        End Try

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        SearchQuery()
    End Sub

    Private Sub SearchQuery()

        Dim ClsCustomer As New ClsCustomer
        Dim DtSearchResult As New DataTable
        Dim StrOp As String = "WHERE"

        Try
            'Use search text to search customer first then improvise/enhance it to search appointment/pet/vet
            If TxtSearchText.Text <> "" Then

                ClsCustomer.SQLQueryCondition = FilterSQL(StrOp)
                DtSearchResult = ClsCustomer.GetCustomerListing(ClsCustomer)
                If DtSearchResult.Rows.Count > 0 Then

                    DgvCustomerList.DataSource = DtSearchResult
                    DgvCustomerList.Show()

                End If

            Else
                MsgBox("Please enter search criteria (e.g. NRIC/Passport number, Customer ID, Customer Name).", MsgBoxStyle.Exclamation, "Enter Search Criteria")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SearchQuery()")
        End Try

    End Sub

    Private Function FilterSQL(ByVal strOP As String) As String

        Dim SQLCondition As String = ""
        Dim sb As New StringBuilder
        Dim SearchQuery As String

        Try
            sb = New StringBuilder
            With sb

                SearchQuery = Trim(TxtSearchText.Text)

                If Trim(TxtSearchText.Text) <> "" Then

                    .Append("" & GetOP(strOP) & " NRICPassportNo LIKE '%" & SearchQuery & "%' OR CustomerName LIKE '%" & SearchQuery & "%' OR CustomerID LIKE '%" & SearchQuery & "%' ")

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".FilterSQLCondition()")
        End Try

        SQLCondition = sb.ToString
        Return SQLCondition

    End Function

    Private Function GetOP(ByRef strOP As String) As String

        If strOP = "WHERE" Then
            strOP = "AND"
            GetOP = "WHERE"
        Else
            GetOP = strOP
        End If

    End Function

    Private Sub TxtSearchText_KeyDown(sender As Object, e As EventArgs) Handles TxtSearchText.KeyDown

        Dim EnterKey As System.Windows.Forms.KeyEventArgs = e

        Try
            If EnterKey.KeyCode = Keys.Enter Then
                EnterKey.SuppressKeyPress = True
                SearchQuery()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TxtSearchText_KeyDown()")
        End Try

    End Sub

    Private Sub DgvSearchResult_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomerList.CellDoubleClick

        Try
            Select Case Source
                Case "APPOINTMENT"
                    CustomerID = DgvCustomerList.Rows(e.RowIndex).Cells("DgvCustomerID").Value
                    UserCommand = "POPULATE_CUSTOMER_INFO"

                Case "CONSULTATION"
                    CustomerID = DgvCustomerList.Rows(e.RowIndex).Cells("DgvCustomerID").Value
                    UserCommand = "POPULATE_CUSTOMER_INFO"

            End Select

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSearchResult_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class