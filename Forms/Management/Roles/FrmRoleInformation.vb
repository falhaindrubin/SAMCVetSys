Public Class FrmRoleInformation

#Region "FormProperty"

    Private _FormTitle As String
    Public Property FormTitle As String
        Get
            Return _FormTitle
        End Get
        Set(value As String)
            _FormTitle = value
        End Set
    End Property

    Private _RoleCode As String
    Public Property RoleCode As String
        Get
            Return _RoleCode
        End Get
        Set(value As String)
            _RoleCode = value
        End Set
    End Property

#End Region

    Private Sub FrmRoleInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        Me.Text = IIf(FormTitle <> "", FormTitle, Me.Text)
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateForm()
    End Sub

    Private Sub PopulateForm()

        Try
            Dim ClsUserRole As New ClsUserRole
            Dim DtRole As New DataTable
            Dim DtRoleAccessRight As New DataTable

            TvUserAccess.ExpandAll()

            If RoleCode <> "" Then

                ClsUserRole = New ClsUserRole
                With ClsUserRole

                    .RoleCode = RoleCode
                    DtRole = .GetRole(ClsUserRole)
                    DtRoleAccessRight = .GetRoleAccessRight(ClsUserRole)

                    If DtRole.Rows.Count > 0 Then

                        TxtRoleCode.Text = DtRole.Rows(0).Item("RoleCode")
                        TxtRoleName.Text = DtRole.Rows(0).Item("RoleName")

                    End If

                    If DtRole.Rows.Count > 0 Then

                        'SetAccessRightTreeView(DtRoleAccessRight)
                        For i As Integer = 0 To DtRoleAccessRight.Rows.Count - 1
                            SetChildren(TvUserAccess, DtRoleAccessRight.Rows(i).Item("AccessTag"))
                        Next

                    End If

                End With

                SetFields("SHOW")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub SetFields(UserCommand As String)

        Select Case UserCommand

            Case "SHOW", "CANCEL"
                TxtRoleCode.ReadOnly = True
                TxtRoleName.ReadOnly = True
                TxtRoleCode.BackColor = Color.Beige
                TxtRoleName.BackColor = Color.Beige
                TvUserAccess.Enabled = False

            Case "EDIT"
                TxtRoleCode.ReadOnly = False
                TxtRoleName.ReadOnly = False
                TxtRoleCode.BackColor = Color.White
                TxtRoleName.BackColor = Color.White
                TvUserAccess.Enabled = True

        End Select

    End Sub

    Private Function SaveUserRoleToDb() As Boolean

        Try
            Dim ClsUserRole As New ClsUserRole
            Dim AccessTagList As New List(Of String)
            Dim ParentNode As TreeNode = Nothing

            AccessTagList = GetChildren(TvUserAccess)

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Remove existing selected access right
            ClsUserRole = New ClsUserRole
            With ClsUserRole

                .RoleCode = UCase(Trim(TxtRoleCode.Text))

                If Not .DeleteAccessRight(ClsUserRole, DbConn, DbTrans) Then
                    MsgBox("Failed to update user access right.", MsgBoxStyle.Critical, "User Role Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            For i As Integer = 0 To AccessTagList.Count - 1

                ClsUserRole = New ClsUserRole
                With ClsUserRole
                    .RoleCode = UCase(Trim(TxtRoleCode.Text))
                    .RoleName = UCase(Trim(TxtRoleName.Text))
                    .AccessTag = AccessTagList(i).ToString
                    .HasAccess = "1"
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now

                    If Not .AddRoleAccessRight(ClsUserRole, DbConn, DbTrans) Then
                        MsgBox("Failed to update user access rights.", MsgBoxStyle.Critical, "User Access Right Update Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                End With

            Next

            ClsUserRole = New ClsUserRole
            With ClsUserRole
                .RoleCode = UCase(Trim(TxtRoleCode.Text))
                .RoleName = UCase(Trim(TxtRoleName.Text))
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not ClsUserRole.AddRole(ClsUserRole, DbConn, DbTrans) Then
                    MsgBox("Failed to update user role", MsgBoxStyle.Critical, "User Role Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            SetFields("CANCEL")
            MsgBox("Your user role and access right has been updated!", MsgBoxStyle.Information, "User Role Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveUserRoleToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Sub SetChildren(ObjTree As TreeView, AccessTag As String)
        For Each ParentNode As TreeNode In ObjTree.Nodes
            If ParentNode.Tag = AccessTag Then
                If AccessTag = "MnuManagement" Then
                    AccessTag = AccessTag
                End If
                ParentNode.Checked = True
            End If
            SetAllChildren(ParentNode, AccessTag)
        Next
    End Sub

    Private Sub SetAllChildren(ParentNode As TreeNode, AccessTag As String)
        For Each ChildNode As TreeNode In ParentNode.Nodes
            If ChildNode.Tag = AccessTag Then
                ChildNode.Checked = True
            End If
            SetAllChildren(ChildNode, AccessTag)
        Next
    End Sub

    Private Function GetChildren(ObjTree As TreeView) As List(Of String)
        Dim Nodes As List(Of String) = New List(Of String)
        For Each ParentNode As TreeNode In ObjTree.Nodes
            If ParentNode.Checked = True Then
                Nodes.Add(ParentNode.Tag)
            End If
            GetAllChildren(ParentNode, Nodes)
        Next
        Return Nodes
    End Function

    Private Sub GetAllChildren(ParentNode As TreeNode, Nodes As List(Of String))
        For Each ChildNode As TreeNode In ParentNode.Nodes
            If ChildNode.Checked = True Then
                Nodes.Add(ChildNode.Tag)
            End If
            GetAllChildren(ChildNode, Nodes)
        Next
    End Sub

    Private Sub TvUserAccess_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TvUserAccess.AfterCheck
        RemoveHandler TvUserAccess.AfterCheck, AddressOf TvUserAccess_AfterCheck

        Try
            For Each Nd As TreeNode In e.Node.Nodes
                Nd.Checked = e.Node.Checked
            Next

            If e.Node.Checked Then

                If e.Node.Parent Is Nothing = False Then

                    Dim AllChecked As Boolean = True

                    For Each Nd As TreeNode In e.Node.Parent.Nodes
                        If Not Nd.Checked Then
                            AllChecked = False
                        Else
                            AllChecked = Nd.Checked
                            Exit For
                        End If
                    Next

                    If AllChecked Then
                        e.Node.Parent.Checked = AllChecked 'True
                    End If

                    'New
                    'e.Node.Parent.Checked = AllChecked

                End If

            Else
                If e.Node.Parent Is Nothing = False Then

                    Dim AllChecked As Boolean = True

                    For Each Nd As TreeNode In e.Node.Parent.Nodes
                        If Not Nd.Checked Then
                            If Nd.Index = 0 Then
                                AllChecked = Nd.Checked
                            Else
                                AllChecked = False
                            End If

                            'Exit For
                        Else
                            AllChecked = Nd.Checked
                            Exit For
                        End If
                    Next

                    If AllChecked Then
                        e.Node.Parent.Checked = AllChecked 'True
                    End If

                    'New
                    e.Node.Parent.Checked = AllChecked

                End If

                If e.Node.Parent Is Nothing = False Then
                    'e.Node.Parent.Checked = False
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".TvUserAccess_AfterCheck()")
        End Try

        AddHandler TvUserAccess.AfterCheck, AddressOf TvUserAccess_AfterCheck

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not SaveUserRoleToDb() Then Exit Sub
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        SetFields("CANCEL")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        SetFields("EDIT")
    End Sub

End Class