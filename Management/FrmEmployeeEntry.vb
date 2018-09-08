Public Class FrmEmployeeEntry

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private Sub FrmUserEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateSalutation()
        PopulateSex()
        PopulateMaritalStatus()
        PopulatePosition()
        PopulateForm(UserCommand)
        Application.DoEvents()
    End Sub

    Private Sub PopulateForm(UserCommand)

    End Sub

    Private Function AddNewEmployee() As Boolean

        Dim EmployeeID As String
        Dim ClsEmployee As New ClsEmployee

        Try
            If DBTrans IsNot Nothing Then
                DBTrans = Nothing
            End If

            DBTrans = DBConn.BeginTransaction

            EmployeeID = GenerateRunningNo("EMP", DBConn, DBTrans)

            If EmployeeID = "" Then
                MsgBox("Employee ID is failed to generate.", MsgBoxStyle.Critical, "ID Not Generated")
                DBTrans.Rollback()
                DBTrans.Dispose()
                DBTrans = Nothing
                Return False
            End If

            ClsEmployee = New ClsEmployee
            With ClsEmployee
                .EmployeeID = EmployeeID
                .EmployeeName = UCase(Trim(TxtEmployeeID.Text))
                .SaluteCode = UCase(Trim(DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .SaluteName = UCase(Trim(DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Value.ToString))
                .NRICPassportNo = UCase(Trim(TxtNRICPassportNo.Text))
                .SexCode = UCase(Trim(DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .SexName = UCase(Trim(DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Value.ToString))
                .EmployeeDOB = DtpEmployeeDOB.Value.Date
                .EmployeePOB = UCase(Trim(TxtEmployeePOB.Text))
                .Nationality = UCase(Trim(TxtNationality.Text))
                .AddressLine1 = UCase(Trim(TxtAddressLine1.Text))
                .AddressLine2 = UCase(Trim(TxtAddressLine2.Text))
                .AddressLine3 = UCase(Trim(TxtAddressLine3.Text))
                .AddressLine4 = UCase(Trim(TxtAddressLine4.Text))
                .Race = UCase(Trim(TxtRace.Text))
                .Religion = UCase(Trim(TxtReligion.Text))
                .MaritalStatusCode = UCase(Trim(DirectCast(CmbMaritalStatus.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .MaritalStatusName = UCase(Trim(DirectCast(CmbMaritalStatus.SelectedItem, KeyValuePair(Of String, String)).Value.ToString))
                .PositionCode = UCase(Trim(DirectCast(CmbPosition.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .PositionName = UCase(Trim(DirectCast(CmbPosition.SelectedItem, KeyValuePair(Of String, String)).Value.ToString))
                .Qualification = UCase(Trim(TxtQualification.Text))
                .Institution = UCase(Trim(TxtInstitution.Text))
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsEmployee.AddNewEmployee(ClsEmployee, DBConn, DBTrans) Then
                MsgBox("Failed to add new employee. Please try again.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewEmployee()")
                DBTrans.Rollback()
                DBTrans.Dispose()
                DBTrans = Nothing
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewEmployee()")
            Return False
        End Try

        Return True

    End Function

    Private Function AddNewUser() As Boolean

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewUser()")
            Return False
        End Try

        Return True

    End Function

    Private Sub SaveEmployeeToDb()

        Try
            If Not CheckUserInput(UserCommand) Then Exit Sub
            If Not AddNewEmployee() Then Exit Sub
            If Not AddNewUser() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveEmployeeToDb()")
        End Try

    End Sub

    Private Function CheckUserInput(UserCommand As String) As Boolean

        Try


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Sub PopulatePosition()

        Dim DtPosition As New DataTable
        Dim ClsEmployee As New ClsEmployee
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtPosition = ClsEmployee.GetPosition(ClsEmployee)
            If DtPosition.Rows.Count > 0 Then

                For i As Integer = 0 To DtPosition.Rows.Count - 1
                    CmbSource.Add(DtPosition.Rows(i).Item("PositionCode"), DtPosition.Rows(i).Item("PositionName"))
                Next

                If CmbPosition.Items.Count > 0 Then
                    CmbPosition.DataSource = Nothing
                    CmbPosition.Items.Clear()
                End If

                CmbPosition.DataSource = New BindingSource(CmbSource, Nothing)
                CmbPosition.DisplayMember = "Value"
                CmbPosition.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulatePosition()")
        End Try

    End Sub

    Private Sub PopulateMaritalStatus()

        Dim DtMaritalStatus As New DataTable
        Dim ClsEmployee As New ClsEmployee
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtMaritalStatus = ClsEmployee.GetMaritalStatus(ClsEmployee)
            If DtMaritalStatus.Rows.Count > 0 Then

                For i As Integer = 0 To DtMaritalStatus.Rows.Count - 1
                    CmbSource.Add(DtMaritalStatus.Rows(i).Item("MaritalStatusCode"), DtMaritalStatus.Rows(i).Item("MaritalStatusName"))
                Next

                If CmbMaritalStatus.Items.Count > 0 Then
                    CmbMaritalStatus.DataSource = Nothing
                    CmbMaritalStatus.Items.Clear()
                End If

                CmbMaritalStatus.DataSource = New BindingSource(CmbSource, Nothing)
                CmbMaritalStatus.DisplayMember = "Value"
                CmbMaritalStatus.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulateMaritalStatus()")
        End Try

    End Sub

    Private Sub PopulateSalutation()

        Dim DtSalute As New DataTable
        Dim ClsCustomer As New ClsCustomer
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtSalute = ClsCustomer.GetSalutation(ClsCustomer)
            If DtSalute.Rows.Count > 0 Then

                For i As Integer = 0 To DtSalute.Rows.Count - 1
                    CmbSource.Add(DtSalute.Rows(i).Item("SaluteCode"), DtSalute.Rows(i).Item("SaluteName"))
                Next

                If CmbSalutation.Items.Count > 0 Then
                    CmbSalutation.DataSource = Nothing
                    CmbSalutation.Items.Clear()
                End If

                CmbSalutation.DataSource = New BindingSource(CmbSource, Nothing)
                CmbSalutation.DisplayMember = "Value"
                CmbSalutation.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulateSalutation()")
        End Try

    End Sub

    Private Sub PopulateSex()

        Dim DtSex As New DataTable
        Dim ClsEmployee As New ClsEmployee
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtSex = ClsEmployee.GetSex(ClsEmployee)
            If DtSex.Rows.Count > 0 Then

                For i As Integer = 0 To DtSex.Rows.Count - 1
                    CmbSource.Add(DtSex.Rows(i).Item("SexCode"), DtSex.Rows(i).Item("SexName"))
                Next

                If CmbSex.Items.Count > 0 Then
                    CmbSex.DataSource = Nothing
                    CmbSex.Items.Clear()
                End If

                CmbSex.DataSource = New BindingSource(CmbSource, Nothing)
                CmbSex.DisplayMember = "Value"
                CmbSex.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulatePetSex()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveEmployeeToDb()
    End Sub


End Class