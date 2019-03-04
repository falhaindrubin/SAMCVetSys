Imports System.IO

Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeApplication()
        'FrmMDI.MStripMain.Visible = False
        'SetMsStripToHide()
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

            TxtUserID.Select()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ".InitializeApp()")
        End Try

    End Sub

    Private Function LogInUser() As Boolean

        Dim ClsLogin As New ClsLogin
        Dim ClsUserRole As New ClsUserRole
        Dim UserID As String
        Dim Password As String
        Dim DtUser As New DataTable
        Dim DtUserAccessRight As New DataTable

        Try
            UserID = Trim(TxtUserID.Text)
            Password = Trim(TxtPassword.Text)

            If UserID <> "" And Password <> "" Then

                ClsLogin = New ClsLogin
                With ClsLogin
                    .UserID = UserID
                    .Password = Password
                End With

                If DbConn.State = ConnectionState.Closed Then

                    If Not ConnectToDB() Then
                        Return False
                    End If

                    DbConn.Open()

                End If

                DtUser = ClsLogin.GetUser(ClsLogin, DbConn)
                If DtUser.Rows.Count > 0 Then

                    CURR_USER = Trim(UCase(UserID))
                    CURR_EMPLOYEE_ID = Trim(DtUser.Rows(0).Item("EmployeeID"))
                    CURR_EMPLOYEE_NAME = Trim(DtUser.Rows(0).Item("EmployeeName"))
                    CURR_EMPLOYEE_POS = Trim(DtUser.Rows(0).Item("RoleCode"))

                    If Not SetCurrentUser() Then Return False

                    'Get role and set access to menus
                    ClsUserRole = New ClsUserRole
                    With ClsUserRole

                        .EmployeeID = Trim(DtUser.Rows(0).Item("EmployeeID"))
                        .RoleCode = Trim(DtUser.Rows(0).Item("RoleCode")).ToString
                        DtUserAccessRight = .GetUserAccessRight(ClsUserRole)

                        If DtUserAccessRight.Rows.Count > 0 Then

                            SetMenu(DtUserAccessRight)

                        End If

                    End With

                Else
                    MsgBox("User not found.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Login")
                    TxtUserID.Select()
                    Return False

                End If

            Else

                MsgBox("Please enter your User ID and Password.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Login")
                TxtUserID.Select()
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Login")
            TxtUserID.Select()
            Return False
        End Try

        Return True

    End Function

    Private Function SetCurrentUser() As Boolean

        Try
            Dim UserLogTxt As String = My.Application.Info.DirectoryPath & "\User.txt"

            If Not System.IO.File.Exists(UserLogTxt) Then
                System.IO.File.Create(UserLogTxt).Dispose()
            End If

            'Dim StrCurrentUser As String = File.ReadAllText(UserLogTxt)
            'StrCurrentUser = CURR_USER

            Dim ObjWriter As New System.IO.StreamWriter(UserLogTxt)

            ObjWriter.Write(CURR_USER)
            ObjWriter.Close()

        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim menues As New List(Of ToolStripItem)
    '    For Each t As ToolStripItem In MenuStrip1.Items
    '        GetMenues(t, menues)
    '    Next

    '    Dim msg As String = ""
    '    For Each t As ToolStripItem In menues
    '        msg &= t.Name & vbCrLf
    '    Next
    '    MessageBox.Show(msg)
    'End Sub

    'Public Sub GetMenues(ByVal Current As ToolStripItem, ByRef menues As List(Of ToolStripItem))
    '    menues.Add(Current)
    '    If TypeOf (Current) Is ToolStripMenuItem Then
    '        For Each menu As ToolStripItem In DirectCast(Current, ToolStripMenuItem).DropDownItems
    '            GetMenues(menu, menues)
    '        Next
    '    End If
    'End Sub

    Private Sub SetMsStripToHide()

        'Set all menus to hidden, unhide based on user access right
        Dim MenuStrip As MenuStrip = FrmMDI.MStripMain

        For Each Menus As ToolStripItem In MenuStrip.Items

            If TypeOf (Menus) Is ToolStripMenuItem Then
                Menus.Visible = False
                SetSubMenuToHide(Menus)
            End If

        Next

    End Sub

    Private Sub SetSubMenuToHide(Menus As ToolStripItem)
        If TypeOf (Menus) Is ToolStripMenuItem Then
            For Each SubMenu As ToolStripItem In DirectCast(Menus, ToolStripMenuItem).DropDownItems
                SubMenu.Visible = False
                'MsgBox(SubMenu.Visible.ToString)
                SetSubMenuToHide(SubMenu)
            Next
        End If
    End Sub

#Region "RecursiveMenu"
    'Private Sub SetMenu(AccessTag As String)

    '    Dim MenuStrip As New MenuStrip

    '    MenuStrip = FrmMDI.MStripMain

    '    For Each Menu As ToolStripItem In MenuStrip.Items

    '        If TypeOf (Menu) Is ToolStripMenuItem Then

    '            'SetSubMenu(Menu, AccessTag)
    '            If Menu.Name = AccessTag Then

    '                'Menu.Enabled = True
    '                Menu.Visible = True

    '                SetSubMenu(Menu, AccessTag)

    '            End If

    '        End If

    '    Next

    'End Sub

    'Private Sub SetSubMenu(Menu As ToolStripItem, AccessTag As String)

    '    'If Menu.Name = AccessTag Then
    '    '    Menu.Name = True
    '    'End If

    '    If TypeOf (Menu) Is ToolStripMenuItem Then

    '        For Each SubMenu As ToolStripItem In DirectCast(Menu, ToolStripMenuItem).DropDownItems

    '            'SetSubMenu(SubMenu, AccessTag)

    '            If SubMenu.Name = AccessTag Then

    '                'SubMenu.Enabled = True
    '                SubMenu.Visible = True
    '                'MsgBox(SubMenu.Visible.ToString)
    '                SetSubMenu(SubMenu, AccessTag)

    '            End If

    '        Next

    '    End If

    'End Sub
#End Region

#Region "BasicForLoopMenu"

    Private Sub SetMenu(DtUserAccessRight As DataTable)

        Dim ParentMenu As New ToolStripMenuItem
        Dim MenuStrip As New MenuStrip

        MenuStrip = FrmMDI.MStripMain

        For Each ParentMenu In MenuStrip.Items

            Dim DvParentMenu As New DataView

            DvParentMenu = DtUserAccessRight.DefaultView
            DvParentMenu.RowFilter = "AccessTag = '" & ParentMenu.Name & "'"

            If DvParentMenu.Count > 0 Then
                ParentMenu.Visible = True
            Else
                ParentMenu.Visible = False
            End If

            For Each SubMenu As ToolStripItem In DirectCast(ParentMenu, ToolStripMenuItem).DropDownItems

                Dim DvSubMenu As New DataView

                DvSubMenu = DtUserAccessRight.DefaultView
                DvSubMenu.RowFilter = "AccessTag = '" & SubMenu.Name & "'"

                If DvSubMenu.Count > 0 Then
                    SubMenu.Visible = True
                Else
                    SubMenu.Visible = False
                End If

            Next

        Next

    End Sub

#End Region

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

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If Not LogInUser() Then
            'Me.Close()
        Else
            FrmMDI.Show()
            Me.Hide()
        End If

    End Sub

End Class