Imports SAMCVetSys.ModUtility

Public Class FrmUserInformation

#Region "FormProperty"
    Private _UserID As String
    Public Property UserID As String
        Get
            Return _UserID
        End Get
        Set(value As String)
            _UserID = value
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
#End Region

    Private Sub PopulateForm()

        Try
            If UserID <> "" Then

                Dim ClsEmployee As New ClsEmployee
                Dim DtEmployee As New DataTable

                With ClsEmployee
                    .EmployeeID = EmployeeID

                    DtEmployee = .GetEmployee(ClsEmployee)
                    If DtEmployee.Rows.Count > 0 Then
                        TxtPosition.Tag = CStrNull(DtEmployee.Rows(0).Item("PositionCode"))
                        TxtPosition.Text = CStrNull(DtEmployee.Rows(0).Item("PositionName"))
                    End If

                End With

                Dim ClsUser As New ClsUser
                Dim DtUser As New DataTable

                With ClsUser
                    .UserID = UserID

                    DtUser = .GetUser(ClsUser)
                    If DtUser.Rows.Count > 0 Then
                        TxtEmployeeName.Text = CStrNull(DtUser.Rows(0).Item("EmployeeName"))
                        TxtEmployeeName.Tag = CStrNull(DtUser.Rows(0).Item("EmployeeID"))
                        TxtUserID.Text = CStrNull(DtUser.Rows(0).Item("UserID"))
                        TxtUserPassword.Text = CStrNull(DtUser.Rows(0).Item("UserPassword"))
                        TxtCreatedBy.Text = CStrNull(DtUser.Rows(0).Item("CreatedBy"))
                        TxtDateCreated.Text = CStrNull(DtUser.Rows(0).Item("DateCreated"))
                        TxtModifiedBy.Text = CStrNull(DtUser.Rows(0).Item("ModifiedBy"))
                        TxtDateModified.Text = CStrNull(DtUser.Rows(0).Item("DateModified"))
                    End If

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Function SaveUserToDb() As Boolean

        Try
            Dim UserID As String

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If TxtUserID.Text <> "" Then
                UserID = TxtUserID.Text
            Else
                UserID = GenerateRunningNo("EMP", DbConn, DbTrans)
            End If

            Dim ClsUser As New ClsUser
            With ClsUser
                .UserID = UserID 'UCase(Trim(TxtUserID.Text))
                .EmployeeID = UCase(Trim(TxtEmployeeName.Tag))
                .EmployeeName = UCase(Trim(TxtEmployeeName.Text))
                .UserPassword = Trim(TxtUserPassword.Text)
                .UserRole = UCase(Trim(DirectCast(CmbUserRole.SelectedItem, KeyValuePair(Of String, String)).Key.ToString))
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewUser(ClsUser, DbConn, DbTrans) Then
                    MsgBox("Failed to save user information.", MsgBoxStyle.Critical, "User Information Save Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            TxtUserID.Text = UserID
            With ClsUser
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            MsgBox("User access credentials has been successfully saved.", MsgBoxStyle.Information, "User Credentials Saved")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveUserToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub PopulateUserRoles()

        Try
            Dim CmbSource As New Dictionary(Of String, String)

            Dim DtRoles As New DataTable
            Dim ClsUserRole As New ClsUserRole
            With ClsUserRole
                DtRoles = .GetUserRole(ClsUserRole)

                If DtRoles.Rows.Count > 0 Then

                    For i As Integer = 0 To DtRoles.Rows.Count - 1
                        CmbSource.Add(DtRoles.Rows(i).Item("UserRole"), DtRoles.Rows(i).Item("UserRoleDescription"))
                    Next

                    If CmbUserRole.Items.Count > 0 Then
                        CmbUserRole.DataSource = Nothing
                        CmbUserRole.Items.Clear()
                    End If

                    CmbUserRole.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbUserRole.DisplayMember = "Value"
                    CmbUserRole.ValueMember = "Key"

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateUserRoles()")
        End Try

    End Sub

    Private Function ValidateInput() As Boolean

        Try
            If TxtEmployeeName.Tag = "" Then
                MsgBox("Please select employee that you want to create User ID", MsgBoxStyle.Exclamation, "No Employee Selected")
                Return False
            End If

            If TxtUserID.Text = "" Then
                MsgBox("Please enter User ID.", MsgBoxStyle.Exclamation, "Input Validation")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ValidateInput()")
            Return False
        End Try

        Return True

    End Function

    Private Sub FrmUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateUserRoles()
        PopulateForm()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not ValidateInput() Then Exit Sub
        If Not SaveUserToDb() Then Exit Sub
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSearchEmployee_Click(sender As Object, e As EventArgs) Handles BtnSearchEmployee.Click
        With FrmSearchEmployee
            .ShowDialog()
            TxtEmployeeName.Tag = .EmployeeID
            TxtEmployeeName.Text = .EmployeeName
            TxtPosition.Tag = .PositionCode
            TxtPosition.Text = .PositionName
        End With
    End Sub

End Class