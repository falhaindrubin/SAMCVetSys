Imports System.Text

Public Class FrmAppointmentRecords

    Private Sub FrmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateAppointmentListing()
    End Sub

    Private Sub PopulateAppointmentListing()

        Dim DtAppointment As New DataTable
        Dim ClsAppointment As New ClsAppointment
        Dim StrOp As String = "WHERE"

        Try
            ClsAppointment = New ClsAppointment
            With ClsAppointment
                .SQLQueryCondition = FilterSQL(StrOp)
                DtAppointment = .GetAppointmentListing(ClsAppointment)
            End With

            If DtAppointment.Rows.Count > 0 Then

                With DgvAppoinmentListing
                    .Rows.Clear()
                    For i As Integer = 0 To DtAppointment.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("AppointmentID").Value = DtAppointment.Rows(i).Item("AppointmentID")
                        .Rows(i).Cells("AppointmentTime").Value = DtAppointment.Rows(i).Item("AppointmentTime")
                        .Rows(i).Cells("EmployeeID").Value = DtAppointment.Rows(i).Item("EmployeeID")
                        .Rows(i).Cells("EmployeeName").Value = "DR. " & DtAppointment.Rows(i).Item("EmployeeName")
                        .Rows(i).Cells("CustomerID").Value = DtAppointment.Rows(i).Item("CustomerID")
                        .Rows(i).Cells("CustomerName").Value = DtAppointment.Rows(i).Item("CustomerName")
                        .Rows(i).Cells("CreatedBy").Value = DtAppointment.Rows(i).Item("CreatedBy")
                        .Rows(i).Cells("DateCreated").Value = DtAppointment.Rows(i).Item("DateCreated")
                    Next

                End With
            Else
                MsgBox("No record found. Please specify your search criteria.", MsgBoxStyle.Exclamation, "Record Not Found")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateCustomerListing()")
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

                    '.Append("" & GetOP(strOP) & " NRICPassportNo LIKE '%" & SearchQuery & "%' OR CustomerName LIKE '%" & SearchQuery & "%' OR CustomerID LIKE '%" & SearchQuery & "%' ")
                    .Append("" & GetOP(strOP) & " CustomerName LIKE '%" & SearchQuery & "%' OR CustomerID LIKE '%" & SearchQuery & "%' ")

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

    Private Sub TxtSearchCustomer_TextChanged(sender As Object, e As EventArgs)

        Try
            'DgvSearchAppointment.Show()
            'DgvSearchAppointment.BringToFront()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "FrmAppointment.TxtSearchCustomer_TextChanged()")
        End Try

    End Sub

    Private Sub TxtSearchCustomer_GotFocus(sender As Object, e As EventArgs)

        Try
            'DgvSearchAppointment.Show()
            'DgvSearchAppointment.BringToFront()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "FrmAppointment.TxtSearchCustomer_TextChanged()")
        End Try

    End Sub

    Private Sub BtnAddNewAppointment_Click(sender As Object, e As EventArgs) Handles BtnAddNewAppointment.Click

        Try
            Dim Frm As New FrmAppointmentInformation With {
                        .FormTitle = "Create New Appointment",
                        .UserCommand = "ADD_NEW_APPOINTMENT",
                        .IsShowBtnSearch = True
            }

            'MsgBox("Please select registered customer first before creating an appointment.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Search Customer")
            'Dim Frm As New FrmSearch With {
            '.Source = "APPOINTMENT"
            '}

            Frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnAddNewAppointment_Click()")
        End Try

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateAppointmentListing()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub DgvAppoinmentListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAppoinmentListing.CellDoubleClick

        Try
            'Dim BtnSearch As Button
            'BtnSearch = FrmAppointmentInformation.BtnSearch
            'BtnSearch.Visible = False

            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmAppointmentInformation With {
                        .UserCommand = "SHOW_CUSTOMER_APPOINTMENT",
                        .CustomerID = DgvAppoinmentListing.Rows(e.RowIndex).Cells("CustomerID").Value,
                        .AppointmentID = DgvAppoinmentListing.Rows(e.RowIndex).Cells("AppointmentID").Value,
                        .IsShowBtnSearch = False
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvCustomerListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub ShowCustomerAppointment()

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ShowCustomerAppointment()")
        End Try

    End Sub

    Private Sub BtnSearchAppointment_Click(sender As Object, e As EventArgs) Handles BtnSearchAppointment.Click
        PopulateAppointmentListing()
    End Sub

    Private Sub TxtSearchText_KeyDown(sender As Object, e As EventArgs) Handles TxtSearchText.KeyDown

        Dim EnterKey As System.Windows.Forms.KeyEventArgs = e

        Try
            If EnterKey.KeyCode = Keys.Enter Then
                EnterKey.SuppressKeyPress = True
                PopulateAppointmentListing()
            End If

        Catch ex As Exception

        End Try

    End Sub

End Class