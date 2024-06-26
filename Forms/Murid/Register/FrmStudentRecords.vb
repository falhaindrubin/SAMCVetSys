﻿Imports System.Text

Public Class FrmStudentRecords

    Private Sub FrmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        ShowCustomerRecords()
        Application.DoEvents()
    End Sub

    Private Sub ShowCustomerRecords()

        Dim DtCustomer As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim StrOp As String = "WHERE"

        Try
            ClsCustomer = New ClsCustomer
            With ClsCustomer
                .SQLQueryCondition = FilterSQL(StrOp)
                DtCustomer = .GetCustomerListing(ClsCustomer)
            End With

            If DtCustomer.Rows.Count > 0 Then

                With DgvCustomerListing

                    If .Rows.Count > 0 Then
                        .Rows.Clear()
                    End If

                    For i As Integer = 0 To DtCustomer.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("CustomerID").Value = DtCustomer.Rows(i).Item("CustomerID")
                        .Rows(i).Cells("NRICPassportNo").Value = DtCustomer.Rows(i).Item("NRICPassportNo")
                        .Rows(i).Cells("CustomerName").Value = DtCustomer.Rows(i).Item("CustomerName")
                        .Rows(i).Cells("CreatedBy").Value = DtCustomer.Rows(i).Item("CreatedBy")
                        .Rows(i).Cells("DateCreated").Value = DtCustomer.Rows(i).Item("DateCreated")
                    Next
                End With
            Else
                MsgBox("No record found. Please specify your search criteria.", MsgBoxStyle.Exclamation, "Record Not Found")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ShowCustomerRecords()")
        End Try

    End Sub

    Private Sub BtnNewClient_Click(sender As Object, e As EventArgs)
        Me.ShowDialog()
    End Sub

    Private Sub DgvCustomerListing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomerListing.CellDoubleClick

        Dim CustomerID As String

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    CustomerID = DgvCustomerListing.Rows(e.RowIndex).Cells("CustomerID").Value
                    Dim frm As New FrmStudentInformation With {
                        .UserCommand = "SHOW_CUSTOMER_INFO",
                        .CustomerID = CustomerID,
                        .AddPetOnly = True
                    }
                    frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvCustomerListing_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnSearchCustomer_Click(sender As Object, e As EventArgs) Handles BtnSearchCustomer.Click
        'SearchCustomer()
        ShowCustomerRecords()
    End Sub

    Private Sub SearchCustomer()

        Dim StrOp As String = "WHERE"
        Dim DtCustomer As New DataTable
        Dim ClsCustomer As New ClsCustomer

        Try
            ClsCustomer.SQLQueryCondition = FilterSQL(StrOp)
            DtCustomer = ClsCustomer.GetCustomerListing(ClsCustomer)

            If DtCustomer.Rows.Count > 0 Then
                DgvCustomerListing.DataSource = DtCustomer
                DgvCustomerListing.Show()
                MsgBox("" & DtCustomer.Rows.Count & " record found.", MsgBoxStyle.Information, "Record Found.")
            Else
                MsgBox("No record found. Please specify your search criteria.", MsgBoxStyle.Exclamation, "Record Not Found")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SearchCustomer()")
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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddNewCustomer.Click
        With FrmAppointmentInformation
            .UserCommand = "ADD_NEW_CUSTOMER"
        End With
        FrmStudentInformation.ShowDialog()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        ShowCustomerRecords()
    End Sub

    Private Sub TxtSearchText_KeyDown(sender As Object, e As EventArgs) Handles TxtSearchText.KeyDown

        Dim EnterKey As System.Windows.Forms.KeyEventArgs = e

        Try
            If EnterKey.KeyCode = Keys.Enter Then
                EnterKey.SuppressKeyPress = True
                ShowCustomerRecords()
            End If

        Catch ex As Exception

        End Try

    End Sub


End Class