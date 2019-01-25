Imports SAMCVetSys.ModUtility

Public Class FrmEmployeeInformation

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private _EmployeeID As String
    Public Property EmployeeID As String
        Get
            Return _EmployeeID
        End Get
        Set(value As String)
            _EmployeeID = value
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

        Try
            Dim DtEmployee As New DataTable
            Dim ClsEmployee As New ClsEmployee

            If EmployeeID <> "" Then

                With ClsEmployee
                    .EmployeeID = EmployeeID
                    DtEmployee = .GetEmployee(ClsEmployee)

                    If DtEmployee.Rows.Count > 0 Then

                        'Employee information
                        TxtEmployeeID.Text = CStrNull(DtEmployee.Rows(0).Item("EmployeeID"))
                        CmbSalutation.SelectedValue = DtEmployee.Rows(0).Item("SaluteCode")
                        TxtEmployeeName.Text = DtEmployee.Rows(0).Item("EmployeeName")
                        CmbSex.SelectedValue = DtEmployee.Rows(0).Item("SexCode")
                        TxtNRICPassportNo.Text = DtEmployee.Rows(0).Item("NRICPassportNo")
                        DtpEmployeeDOB.Value = CStrNull(DtEmployee.Rows(0).Item("EmployeeDOB"))
                        TxtEmployeePOB.Text = DtEmployee.Rows(0).Item("EmployeePOB")
                        TxtNationality.Text = DtEmployee.Rows(0).Item("Nationality")

                        TxtMobileNo.Text = CStrNull(DtEmployee.Rows(0).Item("MobileNo"))
                        TxtTelNo.Text = CStrNull(DtEmployee.Rows(0).Item("TelNo"))
                        TxtEmail.Text = CStrNull(DtEmployee.Rows(0).Item("Email"))
                        TxtAddressLine1.Text = CStrNull(DtEmployee.Rows(0).Item("AddressLine1"))
                        TxtAddressLine2.Text = CStrNull(DtEmployee.Rows(0).Item("AddressLine2"))
                        TxtAddressLine3.Text = CStrNull(DtEmployee.Rows(0).Item("AddressLine3"))
                        TxtAddressLine4.Text = CStrNull(DtEmployee.Rows(0).Item("AddressLine4"))
                        TxtPostcode.Text = CStrNull(DtEmployee.Rows(0).Item("Postcode"))
                        TxtCity.Text = CStrNull(DtEmployee.Rows(0).Item("City"))
                        TxtState.Text = CStrNull(DtEmployee.Rows(0).Item("State"))
                        TxtCountry.Text = CStrNull(DtEmployee.Rows(0).Item("Country"))

                        CmbPosition.SelectedValue = DtEmployee.Rows(0).Item("PositionCode")
                        TxtQualification.Text = CStrNull(DtEmployee.Rows(0).Item("Qualification"))
                        TxtInstitution.Text = CStrNull(DtEmployee.Rows(0).Item("Institution"))
                        TxtRace.Text = CStrNull(DtEmployee.Rows(0).Item("Race"))
                        TxtReligion.Text = CStrNull(DtEmployee.Rows(0).Item("Religion"))
                        CmbMaritalStatus.SelectedValue = DtEmployee.Rows(0).Item("MaritalStatusCode")

                        TxtCreatedBy.Text = DtEmployee.Rows(0).Item("CreatedBy")
                        TxtDateCreated.Text = DtEmployee.Rows(0).Item("DateCreated")
                        TxtModifiedBy.Text = DtEmployee.Rows(0).Item("ModifiedBy")
                        TxtDateModified.Text = DtEmployee.Rows(0).Item("DateModified")

                    End If

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewEmployee()")
        End Try

    End Sub

    Private Function AddNewEmployee() As Boolean

        Dim GenEmployeeID As String
        Dim ClsEmployee As New ClsEmployee
        Dim ClsUser As New ClsUser

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If TxtEmployeeID.Text <> "" Then
                GenEmployeeID = IIf(TxtEmployeeID.Text <> "", TxtEmployeeID.Text, EmployeeID)
            Else
                GenEmployeeID = GenerateRunningNo("EMP", DbConn, DbTrans)
            End If

            If GenEmployeeID = "" Then
                MsgBox("Failed to generate employee ID.", MsgBoxStyle.Critical, "Employee ID Not Generated")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            ClsEmployee = New ClsEmployee
            With ClsEmployee
                .EmployeeID = GenEmployeeID
                .EmployeeName = UCase(Trim(TxtEmployeeName.Text))
                .SaluteCode = UCase(Trim(DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .SaluteName = UCase(Trim(DirectCast(CmbSalutation.SelectedItem, KeyValuePair(Of String, String)).Value.ToString))
                .NRICPassportNo = UCase(Trim(TxtNRICPassportNo.Text))
                .SexCode = UCase(Trim(DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .SexName = UCase(Trim(DirectCast(CmbSex.SelectedItem, KeyValuePair(Of String, String)).Value.ToString))
                .EmployeeDOB = DtpEmployeeDOB.Value.Date
                .EmployeePOB = UCase(Trim(TxtEmployeePOB.Text))
                .Nationality = UCase(Trim(TxtNationality.Text))
                .MobileNo = Trim(TxtMobileNo.Text)
                .TelNo = Trim(TxtTelNo.Text)
                .Email = Trim(TxtEmail.Text)
                .AddressLine1 = UCase(Trim(TxtAddressLine1.Text))
                .AddressLine2 = UCase(Trim(TxtAddressLine2.Text))
                .AddressLine3 = UCase(Trim(TxtAddressLine3.Text))
                .AddressLine4 = UCase(Trim(TxtAddressLine4.Text))
                .Postcode = Trim(TxtPostcode.Text)
                .City = UCase(Trim(TxtCity.Text))
                .State = UCase(Trim(TxtState.Text))
                .Country = UCase(Trim(TxtCountry.Text))
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

            If Not ClsEmployee.AddNewEmployee(ClsEmployee, DbConn, DbTrans) Then
                MsgBox("Failed to add new employee. Please try again.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewEmployee()")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            'Set EmployeeID, Ref to be displayed right after data entry has been saved
            TxtEmployeeID.Text = GenEmployeeID
            With ClsEmployee
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            MsgBox("Employee information has been successfully saved.", MsgBoxStyle.Information, "Employee Information Saved")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewEmployee()")
            Return False
        End Try

        Return True

    End Function

    Private Sub SaveEmployeeToDb()

        Try
            If Not CheckUserInput(UserCommand) Then Exit Sub
            If Not AddNewEmployee() Then Exit Sub
            'If Not AddNewUser() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveEmployeeToDb()")
        End Try

    End Sub

    Private Function CheckUserInput(UserCommand As String) As Boolean

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckUserInput()")
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

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

End Class