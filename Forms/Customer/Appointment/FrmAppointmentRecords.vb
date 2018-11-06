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

        Try
            DtAppointment = ClsAppointment.GetAppointmentListing(ClsAppointment)
            If DtAppointment.Rows.Count > 0 Then
                DgvAppoinmentListing.DataSource = DtAppointment
                DgvAppoinmentListing.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateCustomerListing()")
        End Try

    End Sub

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
                        .UserCommand = "ADD_NEW_APPOINTMENT"
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
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmAppointmentInformation With {
                        .UserCommand = "SHOW_CUSTOMER_APPOINTMENT",
                        .CustomerID = DgvAppoinmentListing.Rows(e.RowIndex).Cells("CustomerID").Value,
                        .AppointmentID = DgvAppoinmentListing.Rows(e.RowIndex).Cells("AppointmentID").Value
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

End Class