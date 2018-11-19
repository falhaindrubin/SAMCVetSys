Public Class FrmItemInformation

    Private _UserCommand As String
    Public Property UserCommand As String
        Get
            Return _UserCommand
        End Get
        Set(value As String)
            _UserCommand = value
        End Set
    End Property

    Private _ItemGroup As String
    Public Property ItemGroup As String
        Get
            Return _ItemGroup
        End Get
        Set(value As String)
            _ItemGroup = value
        End Set
    End Property

    Private _ItemCode As String
    Public Property ItemCode As String
        Get
            Return _ItemCode
        End Get
        Set(value As String)
            _ItemCode = value
        End Set
    End Property

    Private Sub FrmItemEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateItemType()
        PopulateForm(UserCommand)
    End Sub

    Private Sub PopulateForm(UserCommand As String)

        Dim DtServices As New DataTable
        Dim DtProducts As New DataTable
        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts

        Try
            If UserCommand <> "" Then

                If UserCommand = "SHOW_ITEM_INFO" Then

                    Select Case ItemGroup
                        Case "SVC"

                            ClsServices.ItemCode = ItemCode
                            DtServices = ClsServices.GetServiceInformation(ClsServices)
                            If DtServices.Rows.Count > 0 Then
                                RbServices.Checked = True
                                CmbItemTypeCode.SelectedValue = DtServices.Rows(0).Item("ItemTypeCode")
                                TxtItemCode.Text = DtServices.Rows(0).Item("ItemCode")
                                TxtItemDescription.Text = DtServices.Rows(0).Item("ItemDescription")
                                TxtUnitPrice.Text = DtServices.Rows(0).Item("UnitPrice")
                                TxtCreatedBy.Text = DtServices.Rows(0).Item("CreatedBy")
                                TxtDateCreated.Text = DtServices.Rows(0).Item("DateCreated")
                                TxtModifiedBy.Text = DtServices.Rows(0).Item("ModifiedBy")
                                TxtDateModified.Text = DtServices.Rows(0).Item("DateModified")
                            End If

                        Case "PRD"

                            ClsProducts.ItemCode = ItemCode
                            DtProducts = ClsProducts.GetProductInformation(ClsProducts)
                            If DtProducts.Rows.Count > 0 Then
                                RbProducts.Checked = True
                                CmbItemTypeCode.SelectedValue = DtProducts.Rows(0).Item("ItemTypeCode")
                                TxtItemCode.Text = DtProducts.Rows(0).Item("ItemCode")
                                TxtItemDescription.Text = DtProducts.Rows(0).Item("ItemDescription")
                                TxtUnitPrice.Text = DtProducts.Rows(0).Item("UnitPrice")
                                TxtCreatedBy.Text = DtProducts.Rows(0).Item("CreatedBy")
                                TxtDateCreated.Text = DtProducts.Rows(0).Item("DateCreated")
                                TxtModifiedBy.Text = DtProducts.Rows(0).Item("ModifiedBy")
                                TxtDateModified.Text = DtProducts.Rows(0).Item("DateModified")
                            End If

                    End Select

                    SetFields(UserCommand)

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub SetFields(UserCommand As String)

        Try
            Select Case UserCommand
                Case "SHOW_ITEM_INFO"
                    RbServices.Enabled = False
                    RbProducts.Enabled = False
                    CmbItemTypeCode.Enabled = False
                    TxtItemDescription.ReadOnly = True
                    TxtUnitPrice.ReadOnly = True

                Case "EDIT_ITEM"
                    TxtItemDescription.ReadOnly = False
                    TxtUnitPrice.ReadOnly = False

                Case "CANCEL_EDIT_ITEM", "ITEM_SAVED"
                    TxtItemDescription.ReadOnly = True
                    TxtUnitPrice.ReadOnly = True

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SetFields()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveItemToDb()
    End Sub

    Private Sub SaveItemToDb()

        Try
            If Not CheckUserInput(UserCommand) Then Exit Sub
            If Not AddNewItem() Then Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveItemToDb()")
        End Try

    End Sub

    Private Function CheckUserInput(UserCommand As String) As Boolean

        Try

        Catch ex As Exception

        End Try

        Return True

    End Function

    Private Function AddNewItem() As Boolean

        Dim ItemTypeCode As String
        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts
        Dim GenItemCode As String

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If RbServices.Checked = True Then
                ItemGroup = "SVC"
            ElseIf RbProducts.Checked = True Then
                ItemGroup = "PRD"
            End If

            ItemTypeCode = DirectCast(CmbItemTypeCode.SelectedItem, KeyValuePair(Of String, String)).Key.ToString

            If Trim(TxtItemCode.Text) <> "" Then
                GenItemCode = Trim(TxtItemCode.Text) 'IIf(Trim(TxtItemCode.Text) <> "", ItemCode, Trim(TxtItemCode.Text))
            Else
                GenItemCode = GenerateItemRunningNo(ItemTypeCode, ItemGroup, DbConn, DbTrans)
            End If

            If GenItemCode = "" Then
                MsgBox("Failed to generated item code.", MsgBoxStyle.Critical, FORM_NAME & ".AddNewItem()")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            Select Case ItemGroup
                Case "SVC"
                    If Not AddNewService(ItemGroup, ItemTypeCode, GenItemCode, DbConn, DbTrans) Then
                        MsgBox("Failed to add new service.", MsgBoxStyle.Critical, "Add New Service Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                    MsgBox("New service has been successfully added!", MsgBoxStyle.Information, "New Service Added")

                Case "PRD"
                    If Not AddNewProduct(ItemGroup, ItemTypeCode, GenItemCode, DbConn, DbTrans) Then
                        MsgBox("Failed to add new product.", MsgBoxStyle.Critical, "Add New Product Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                    MsgBox("New product has been successfully added!", MsgBoxStyle.Information, "New Product Added")

            End Select

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewItem()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function AddNewService(ItemGroup As String, ItemTypeCode As String, GenItemCode As String, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim ClsServices As New ClsServices

        Try
            ClsServices = New ClsServices
            With ClsServices
                .ItemCode = GenItemCode
                .ItemDescription = UCase(Trim(TxtItemDescription.Text))
                .ItemGroup = ItemGroup
                .ItemTypeCode = ItemTypeCode
                .ItemTypeDescription = DirectCast(CmbItemTypeCode.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .UnitPrice = IIf(Trim(TxtUnitPrice.Text) <> "", TxtUnitPrice.Text, "0")
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsServices.AddNewService(ClsServices, DbConn, DbTrans) Then Return False

            With ClsServices
                CmbItemTypeCode.SelectedValue = .ItemTypeCode
                TxtItemCode.Text = .ItemCode
                TxtItemDescription.Text = .ItemDescription
                TxtUnitPrice.Text = .UnitPrice

                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            UserCommand = "ITEM_SAVED"
            SetFields(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddNewService()")
            Return False
        End Try

        Return True

    End Function

    Private Function AddNewProduct(ItemGroup As String, ItemTypeCode As String, GenItemCode As String, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Dim ClsProducts As New ClsProducts

        Try
            ClsProducts = New ClsProducts
            With ClsProducts
                .ItemCode = GenItemCode
                .ItemDescription = UCase(Trim(TxtItemDescription.Text))
                .ItemGroup = ItemGroup
                .ItemTypeCode = ItemTypeCode
                .ItemTypeDescription = DirectCast(CmbItemTypeCode.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .UnitPrice = IIf(Trim(TxtUnitPrice.Text) <> "", TxtUnitPrice.Text, "0")
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsProducts.AddNewProduct(ClsProducts, DbConn, DbTrans) Then Return False

            With ClsProducts
                CmbItemTypeCode.SelectedValue = .ItemTypeCode
                TxtItemCode.Text = .ItemCode
                TxtItemDescription.Text = .ItemDescription
                TxtUnitPrice.Text = .UnitPrice

                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            UserCommand = "ITEM_SAVED"
            SetFields(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ClsProducts()")
            Return False
        End Try

        Return True

    End Function

    Private Sub PopulateItemType()

        Dim ClsServices As New ClsServices
        Dim ClsProducts As New ClsProducts
        Dim DtItem As New DataTable
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbServices.Checked = True Then
                DtItem = ClsServices.GetServiceTypeList(ClsServices)

            ElseIf RbProducts.Checked = True Then
                DtItem = ClsProducts.GetProductTypeList(ClsProducts)

            End If

            If DtItem.Rows.Count > 0 Then
                For i As Integer = 0 To DtItem.Rows.Count - 1
                    CmbSource.Add(DtItem.Rows(i).Item("ItemTypeCode"), DtItem.Rows(i).Item("ItemTypeDescription"))
                Next
            End If

            If CmbItemTypeCode.Items.Count > 0 Then
                CmbItemTypeCode.DataSource = Nothing
                CmbItemTypeCode.Items.Clear()
            End If

            CmbItemTypeCode.DataSource = New BindingSource(CmbSource, Nothing)
            CmbItemTypeCode.DisplayMember = "Value"
            CmbItemTypeCode.ValueMember = "Key"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateItemType()")
        End Try

    End Sub

    Private Sub RbServices_Click(sender As Object, e As EventArgs) Handles RbServices.Click

        Dim ClsServices As New ClsServices
        Dim DtItem As New DataTable
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbServices.Checked = True Then

                DtItem = ClsServices.GetServiceTypeList(ClsServices)
                If DtItem.Rows.Count > 0 Then
                    For i As Integer = 0 To DtItem.Rows.Count - 1
                        CmbSource.Add(DtItem.Rows(i).Item("ItemTypeCode"), DtItem.Rows(i).Item("ItemTypeDescription"))
                    Next
                End If

                If CmbItemTypeCode.Items.Count > 0 Then
                    CmbItemTypeCode.DataSource = Nothing
                    CmbItemTypeCode.Items.Clear()
                End If

                CmbItemTypeCode.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemTypeCode.DisplayMember = "Value"
                CmbItemTypeCode.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".RbServices_Click()")
        End Try

    End Sub

    Private Sub RbProducts_Click(sender As Object, e As EventArgs) Handles RbProducts.Click

        Dim ClsProducts As New ClsProducts
        Dim DtItem As New DataTable
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            If RbProducts.Checked = True Then

                DtItem = ClsProducts.GetProductTypeList(ClsProducts)
                If DtItem.Rows.Count > 0 Then
                    For i As Integer = 0 To DtItem.Rows.Count - 1
                        CmbSource.Add(DtItem.Rows(i).Item("ItemTypeCode"), DtItem.Rows(i).Item("ItemTypeDescription"))
                    Next
                End If

                If CmbItemTypeCode.Items.Count > 0 Then
                    CmbItemTypeCode.DataSource = Nothing
                    CmbItemTypeCode.Items.Clear()
                End If

                CmbItemTypeCode.DataSource = New BindingSource(CmbSource, Nothing)
                CmbItemTypeCode.DisplayMember = "Value"
                CmbItemTypeCode.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".RbProducts_Click()")
        End Try

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        UserCommand = "EDIT_ITEM"
        SetFields(UserCommand)
    End Sub

    Private Sub BtnCancelEdit_Click(sender As Object, e As EventArgs) Handles BtnCancelEdit.Click
        UserCommand = "CANCEL_EDIT_ITEM"
        SetFields(UserCommand)
    End Sub

    Private Sub RbProducts_CheckedChanged(sender As Object, e As EventArgs) Handles RbProducts.CheckedChanged
        PopulateItemType()
    End Sub

    Private Sub RbServices_CheckedChanged(sender As Object, e As EventArgs) Handles RbServices.CheckedChanged
        PopulateItemType()
    End Sub

    Private Sub BtnAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAddNewItem.Click
        ClearItem()
    End Sub

    Private Sub ClearItem()

        Try
            TxtItemCode.Text = ""
            TxtItemDescription.Text = ""
            TxtUnitPrice.Text = "0.00"
            TxtCreatedBy.Text = ""
            TxtDateCreated.Text = ""
            TxtModifiedBy.Text = ""
            TxtDateModified.Text = ""

            'TxtItemCode.ReadOnly = False
            TxtItemDescription.ReadOnly = False
            TxtUnitPrice.ReadOnly = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ClearItem()")
        End Try

    End Sub

End Class