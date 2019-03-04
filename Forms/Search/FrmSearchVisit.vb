Imports System.Text

Public Class FrmSearchVisit

#Region "FormProperty"
    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _InvoiceNo As String
    Public Property InvoiceNo As String
        Get
            Return _InvoiceNo
        End Get
        Set(value As String)
            _InvoiceNo = value
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

    Private _CustomerName As String
    Public Property CustomerName As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
        End Set
    End Property

    Private _PetID As String
    Public Property PetID As String
        Get
            Return _PetID
        End Get
        Set(value As String)
            _PetID = value
        End Set
    End Property

    Private _PetName As String
    Public Property PetName As String
        Get
            Return _PetName
        End Get
        Set(value As String)
            _PetName = value
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

    Private _Source As String
    Public Property Source As String
        Get
            Return _Source
        End Get
        Set(value As String)
            _Source = value
        End Set
    End Property
#End Region

    Private Sub FrmSearchVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateVisit()
    End Sub

    Private Sub PopulateVisit()

        Dim DtVisit As New DataTable

        Try
            DtVisit = GetVisit()

            If DtVisit.Rows.Count > 0 Then

                With DgvVisit

                    .Rows.Clear()

                    For i As Integer = 0 To DtVisit.Rows.Count - 1
                        .Rows.Add()
                        .Rows(i).Cells("DgvSearchVisitID").Value = DtVisit.Rows(i).Item("VisitID")
                        .Rows(i).Cells("DgvSearchVisitTime").Value = DtVisit.Rows(i).Item("VisitTime")
                        .Rows(i).Cells("DgvSearchEmployeeID").Value = DtVisit.Rows(i).Item("EmployeeID")
                        .Rows(i).Cells("DgvSearchEmployeeName").Value = "DR. " & DtVisit.Rows(i).Item("EmployeeName")
                        .Rows(i).Cells("DgvSearchCustomerID").Value = DtVisit.Rows(i).Item("CustomerID")
                        .Rows(i).Cells("DgvSearchCustomerName").Value = DtVisit.Rows(i).Item("CustomerName")
                        .Rows(i).Cells("DgvSearchPetName").Value = DtVisit.Rows(i).Item("PetName")
                        .Rows(i).Cells("DgvSearchIsCompleted").Value = IIf(DtVisit.Rows(i).Item("IsCompleted") = "1", "COMPLETED", "ON-GOING")
                        .Rows(i).Cells("DgvSearchIsWarded").Value = IIf(DtVisit.Rows(i).Item("IsWarded") = "1", "WARDED", "NOT WARDED")
                        .Rows(i).Cells("DgvSearchDateCreated").Value = DtVisit.Rows(i).Item("DateCreated")
                        .Rows(i).Cells("DgvSearchCreatedBy").Value = DtVisit.Rows(i).Item("CreatedBy")
                    Next

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateVisitListing()")
        End Try

    End Sub

    Private Function GetVisit() As DataTable

        Dim DtVisit As New DataTable
        Dim ClsVisit As New ClsVisit
        Dim StrOp As String = "WHERE"

        Try
            Select Case Source

                Case "TREATMENT", ""

                    ClsVisit = New ClsVisit
                    With ClsVisit
                        DtVisit = .GetVisitListing(ClsVisit)
                    End With

                Case "WARD"

                    ClsVisit = New ClsVisit
                    With ClsVisit
                        .SQLQueryCondition = FilterSQL(StrOp)
                        '.IsWarded = IIf(CbIsWarded.Checked = True, "1", "0")
                        '.IsCompleted = IIf(CbIsVisitCompleted.Checked = True, "1", "0")
                        'DtVisit = .GetAdmittedToWardVisit(ClsVisit)
                        DtVisit = .GetVisitListing(ClsVisit)
                    End With

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
        End Try

        Return DtVisit

    End Function

    Private Function FilterSQL(ByVal strOP As String) As String

        Dim SQLCondition As String = ""
        Dim sb As New StringBuilder
        Dim SearchQuery As String

        Try
            sb = New StringBuilder
            With sb

                SearchQuery = Trim(TxtSearchText.Text)

                If CbIsVisitCompleted.Checked = True Then
                    .Append("" & GetOP(strOP) & " IsCompleted = '1' ")
                Else
                    '.Append("" & GetOP(strOP) & " IsCompleted = '0' ")
                End If

                If CbIsWarded.Checked = True Then
                    .Append("" & GetOP(strOP) & " IsWarded = '1' ")
                Else
                    '.Append("" & GetOP(strOP) & " IsWarded = '0' ")
                End If

                If Trim(TxtSearchText.Text) <> "" Then
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

    Private Sub DgvVisit_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVisit.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    VisitID = DgvVisit.Rows(e.RowIndex).Cells("VisitID").Value
                    InvoiceNo = ""
                    CustomerID = DgvVisit.Rows(e.RowIndex).Cells("CustomerID").Value
                    CustomerName = DgvVisit.Rows(e.RowIndex).Cells("CustomerName").Value
                    PetID = DgvVisit.Rows(e.RowIndex).Cells("PetID").Value
                    PetName = DgvVisit.Rows(e.RowIndex).Cells("PetName").Value
                    UserCommand = "POPULATE_CUSTOMER_INFO"
                End If
            End If

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvVisit_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        PopulateVisit()
    End Sub

End Class