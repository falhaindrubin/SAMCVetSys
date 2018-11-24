Public Class FrmSearchEmployee

#Region "FormProperty"

    Private _EmployeeID As String
    Public Property EmployeeID As String
        Get
            Return _EmployeeID
        End Get
        Set(value As String)
            _EmployeeID = value
        End Set
    End Property

    Private _EmployeeName As String
    Public Property EmployeeName As String
        Get
            Return _EmployeeName
        End Get
        Set(value As String)
            _EmployeeName = value
        End Set
    End Property

    Private _PositionCode As String
    Public Property PositionCode As String
        Get
            Return _PositionCode
        End Get
        Set(value As String)
            _PositionCode = value
        End Set
    End Property

    Private _PositionName As String
    Public Property PositionName As String
        Get
            Return _PositionName
        End Get
        Set(value As String)
            _PositionName = value
        End Set
    End Property

#End Region

    Private Sub PopulateEmployee()

        Try
            Dim DtEmp As New DataTable
            Dim ClsEmployee As New ClsEmployee
            With ClsEmployee
                .EmployeeID = ""
                DtEmp = .GetEmployee(ClsEmployee)
                If DtEmp.Rows.Count > 0 Then
                    DgvSearchResult.DataSource = DtEmp
                    DgvSearchResult.Show()
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateEmployee()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmSearchEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateEmployee()
    End Sub

    Private Sub DgvSearchResult_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSearchResult.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    EmployeeID = DgvSearchResult.Rows(e.RowIndex).Cells("EmployeeID").Value
                    EmployeeName = DgvSearchResult.Rows(e.RowIndex).Cells("EmployeeName").Value
                    PositionCode = DgvSearchResult.Rows(e.RowIndex).Cells("PositionCode").Value
                    PositionName = DgvSearchResult.Rows(e.RowIndex).Cells("PositionName").Value
                End If
            End If

            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSearchResult_CellDoubleClick()")
        End Try

    End Sub
End Class