Public Class FrmLogin

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If Not CheckUserLogin() Then
            'Me.Close()
        Else
            FrmMDI.Show()
            Me.Hide()
        End If

    End Sub

    Private Function CheckUserLogin() As Boolean

        Dim ClsLogin As ClsLogin
        Dim UserID As String
        Dim Password As String
        Dim DtUser As New DataTable

        Try
            UserID = Trim(TxtUserID.Text)
            Password = Trim(TxtPassword.Text)

            If UserID <> "" And Password <> "" Then

                ClsLogin = New ClsLogin
                With ClsLogin
                    .UserID = UserID
                    .Password = Password
                End With

                If DBConn.State = ConnectionState.Closed Then

                    If Not ConnectToDB() Then
                        Return False
                    End If

                    DBConn.Open()

                End If

                DtUser = ClsLogin.GetUser(ClsLogin, DbConn)
                If DtUser.Rows.Count > 0 Then
                    CURR_USER = Trim(UCase(UserID))
                    CURR_EMPLOYEE_ID = Trim(DtUser.Rows(0).Item("EmployeeID"))
                    CURR_EMPLOYEE_NAME = Trim(DtUser.Rows(0).Item("EmployeeName"))
                Else
                    MsgBox("User not found.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Login")
                    Return False
                End If

            Else

                MsgBox("Please enter your User ID and Password.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Login")
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Login")
        End Try

        Return True

    End Function

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeApplication()
    End Sub

    Private Sub InitializeApplication()

        Try
            SOFTWARE_VERSION = System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString
            Me.Text = "SAMC Animals Centre Vet Management System" & SOFTWARE_VERSION
            If Not ConnectToDB() Then

                MsgBox("Unable to connect to database.", MsgBoxStyle.Critical, "FrmLogin.InitializeApplication()")
                Me.Close()
                Exit Sub
            Else
                TxtUserID.Select()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ".InitializeApp()")
        End Try

    End Sub


    Private Sub TxtPassword_KeyDown(sender As Object, e As EventArgs) Handles TxtPassword.KeyDown

        Dim EnterKey As System.Windows.Forms.KeyEventArgs = e

        Try
            If EnterKey.KeyCode = Keys.Enter Then
                'MsgBox("Enter key is pressed!")
                EnterKey.SuppressKeyPress = True
                BtnLogin_Click(sender, e)
                TxtUserID.Text = ""
                TxtPassword.Text = ""
            End If

        Catch ex As Exception

        End Try

    End Sub


End Class