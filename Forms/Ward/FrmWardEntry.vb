Public Class FrmWardEntry

#Region "FormProperty"
    Private _WardID As String
    Public Property WardID As String
        Get
            Return _WardID
        End Get
        Set(value As String)
            _WardID = value
        End Set
    End Property

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
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

    Private _ItemGroup As String
    Public Property ItemGroup As String
        Get
            Return _ItemGroup
        End Get
        Set(value As String)
            _ItemGroup = value
        End Set
    End Property

    Private _ItemTypeDescription As String
    Public Property ItemTypeDescription As String
        Get
            Return _ItemTypeDescription
        End Get
        Set(value As String)
            _ItemTypeDescription = value
        End Set
    End Property

    Private _ItemTypeCode As String
    Public Property ItemTypeCode As String
        Get
            Return _ItemTypeCode
        End Get
        Set(value As String)
            _ItemTypeCode = value
        End Set
    End Property

#End Region

    Private Sub FrmWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateDPE()
        PopulateForm(UserCommand)
    End Sub

    Private Sub PopulateForm(UserCommand As String)

        'Dim DtWard As New DataTable
        Dim DtWardDetail As New DataTable
        'Dim DtWardDiagnosis As New DataTable
        Dim DtWardDiagnosisDetail As New DataTable
        Dim DtWardTreatment As New DataTable
        Dim DtWardSummary As New DataTable

        Dim ClsWard As New ClsWard

        Try
            Select Case UserCommand
                Case "POPULATE_CUSTOMER_INFO" 'Add new customer
                    TxtAdmissionDate.Text = Now
                    TxtVisitID.Text = VisitID
                    TxtCustomerID.Text = CustomerID
                    TxtCustomerName.Text = CustomerName
                    TxtPetID.Text = PetID
                    TxtPetName.Text = PetName

                Case "SHOW_WARD_INFO"
                    'DtWardSummary = InitWardSummaryDt()
                    ClsWard.WardID = WardID
                    DtWardDetail = ClsWard.GetWardDetail(ClsWard)
                    If DtWardDetail.Rows.Count > 0 Then
                        TxtVisitID.Text = DtWardDetail.Rows(0).Item("VisitID")
                        TxtWardID.Text = DtWardDetail.Rows(0).Item("WardID")
                        TxtAdmissionDate.Text = DtWardDetail.Rows(0).Item("AdmissionDate")
                        TxtCustomerID.Text = DtWardDetail.Rows(0).Item("CustomerID")
                        TxtCustomerName.Text = DtWardDetail.Rows(0).Item("CustomerName")
                        TxtPetID.Text = DtWardDetail.Rows(0).Item("PetID")
                        TxtPetName.Text = DtWardDetail.Rows(0).Item("PetName")
                        TxtCase.Text = DtWardDetail.Rows(0).Item("PetCase")
                        CbIsDischarged.Checked = IIf(DtWardDetail.Rows(0).Item("IsDischarged") = "1", True, False)

                        'Show items summary; user doubleclick will show previous day entry
                        For i As Integer = 0 To DtWardDetail.Rows.Count - 1
                            With DgvWardSummary
                                .Rows.Add()
                                .Rows(i).Cells("WardDate").Value = CDate(DtWardDetail.Rows(i).Item("WardDate")).Date.ToShortDateString
                                .Rows(i).Cells("DailyNotes").Value = DtWardDetail.Rows(i).Item("DailyNotes")
                                .Rows(i).Cells("Appetite").Value = IIf(DtWardDetail.Rows(i).Item("Appetite") = "1", "POSITIVE", "NEGATIVE")
                                .Rows(i).Cells("Bowel").Value = IIf(DtWardDetail.Rows(i).Item("Bowel") = "1", "POSITIVE", "NEGATIVE")
                                .Rows(i).Cells("Urine").Value = IIf(DtWardDetail.Rows(i).Item("Urine") = "1", "POSITIVE", "NEGATIVE")
                                .Rows(i).Cells("Vomit").Value = IIf(DtWardDetail.Rows(i).Item("Vomit") = "1", "POSITIVE", "NEGATIVE")
                            End With
                        Next

                    End If


            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Function SaveWardToDb()

        Dim ClsWard As New ClsWard
        Dim ClsWardDetail As New ClsWardDetail
        Dim ClsWardDiagnosis As New ClsWardDiagnosis
        Dim ClsWardDiagnosisDetail As New ClsWardDiagnosisDetail
        Dim ClsWardTreatment As New ClsWardTreatment
        Dim ClsVisit As New ClsVisit
        Dim GenWardID As String

        Dim DtWardDetail As New DataTable
        Dim DtWardDiagnosisDetail As New DataTable
        Dim DtWardTreatmentDetail As New DataTable

        Try
            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Create WardID or set existing WardID
            If TxtWardID.Text <> "" Then
                GenWardID = TxtWardID.Text
            Else
                GenWardID = GenerateRunningNo("WD", DbConn, DbTrans)
            End If

            If GenWardID = "" Then
                MsgBox("Failed to create ward ID.", MsgBoxStyle.Critical, "Create Ward ID Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                Return False
            End If

            'Add ward header
            With ClsWard
                .WardID = GenWardID
                .VisitID = VisitID
                .AdmissionDate = CDate(TxtAdmissionDate.Text)
                .CustomerID = CustomerID
                .CustomerName = CustomerName
                .PetID = PetID
                .PetName = PetName
                .PetCase = Trim(TxtCase.Text)
                .IsDischarged = IIf(CbIsDischarged.Checked = True, "1", "0")
                .DischargeDate = IIf(CbIsDischarged.Tag = Nothing, Nothing, CbIsDischarged.Tag)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsWard.AddNewWard(ClsWard, DbConn, DbTrans) Then
                MsgBox("Failed to create ward admission.", MsgBoxStyle.Critical, "Create New Ward Admission Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Add ward detail
            With ClsWardDetail
                .WardID = GenWardID
                .WardDate = DtpWardDate.Value.Date
                '.RowNo = ""
                .Appetite = Trim(DirectCast(CmbAppetite.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .Bowel = Trim(DirectCast(CmbBowel.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .Urine = Trim(DirectCast(CmbUrine.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .Vomit = Trim(DirectCast(CmbVomit.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .Food = Trim(DirectCast(CmbFood.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .IsFasting = Trim(DirectCast(CmbFasting.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .FastingDescription = Trim(TxtFastingDescription.Text)
                .DailyNotes = Trim(TxtDailyNotes.Text)
            End With

            If Not ClsWardDetail.AddNewWardDetail(ClsWardDetail, DbConn, DbTrans) Then
                MsgBox("Failed to create ward admission details.", MsgBoxStyle.Critical, "Create New Ward Admission Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Add ward diagnose
            With ClsWardDiagnosis
                .VisitID = VisitID
                .WardID = GenWardID
                .PetID = PetID
                .PetName = PetName
                .Diagnosis = Trim(TxtDiagnosis.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
            End With

            If Not ClsWardDiagnosis.AddNewWardDiagnosis(ClsWardDiagnosis, DbConn, DbTrans) Then
                MsgBox("Failed to create ward diagnosis.", MsgBoxStyle.Critical, "Create Ward Diagnosis Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Add ward diagnose detail
            For i As Integer = 0 To DgvSelectedTest.Rows.Count - 1
                With ClsWardDiagnosisDetail
                    .WardID = GenWardID
                    .DiagnoseDate = DtpWardDate.Value.Date
                    .RowNo = i + 1
                    .ItemCode = DgvSelectedTest.Rows(i).Cells("TestItemCode").Value
                    .ItemDescription = DgvSelectedTest.Rows(i).Cells("TestItemDescription").Value
                    .ItemGroup = DgvSelectedTest.Rows(i).Cells("TestItemGroup").Value
                    .ItemTypeCode = DgvSelectedTest.Rows(i).Cells("TestItemTypeCode").Value
                    .ItemTypeDescription = DgvSelectedTest.Rows(i).Cells("TestItemTypeDescription").Value
                    .UnitPrice = DgvSelectedTest.Rows(i).Cells("TestUnitPrice").Value
                    .Quantity = DgvSelectedTest.Rows(i).Cells("TestQuantity").Value
                    .TotalPrice = DgvSelectedTest.Rows(i).Cells("TestTotalPrice").Value
                End With

                If Not ClsWardDiagnosisDetail.AddNewWardDiagnosisDetail(ClsWardDiagnosisDetail, DbConn, DbTrans) Then
                    MsgBox("Failed to create ward diagnosis details.", MsgBoxStyle.Critical, "Create Ward Diagnosis Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If
            Next

            'Add ward treatment
            If DgvSelectedTreatment.Rows.Count > 0 Then
                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1
                    With ClsWardTreatment
                        .WardID = GenWardID
                        .VisitID = VisitID
                        .TreatmentDate = DtpWardDate.Value.Date
                        .RowNo = i + 1
                        .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemGroup = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemTypeCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemTypeDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .Prescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .Notes = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now
                    End With

                    If Not ClsWardTreatment.AddNewWardTreatment(ClsWardTreatment, DbConn, DbTrans) Then
                        MsgBox("Failed to create ward diagnosis details.", MsgBoxStyle.Critical, "Create Ward Diagnosis Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Next
            End If

            'Update IsAdmittedToWard status in samc_visit
            'With ClsVisit
            '    .VisitID = Trim(TxtVisitID.Text)
            '    .IsAdmittedToWard = "1"
            '    .Ref.ModifiedBy = CURR_USER
            '    .Ref.DateModified = Now
            '    If Not .UpdateWardAdmission(ClsVisit, DbConn, DbTrans) Then
            '        MsgBox("Failed to update ward admission.", MsgBoxStyle.Critical, "Update Ward Admission Error")
            '        DbTrans.Rollback()
            '        DbTrans.Dispose()
            '        DbTrans = Nothing
            '        Return False
            '    End If
            'End With

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            TxtWardID.Text = GenWardID

            With ClsWard
                If TxtCreatedBy.Text = "" Then
                    TxtCreatedBy.Text = .Ref.CreatedBy
                End If

                If TxtDateModified.Text = "" Then
                    TxtDateCreated.Text = .Ref.DateCreated
                End If

                TxtModifiedBy.Text = .Ref.ModifiedBy
                TxtDateModified.Text = .Ref.DateModified
            End With

            MsgBox("Daily ward progress has been updated!", MsgBoxStyle.Information, "Daily Ward Progress Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveWardToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function UpdateBill() As Boolean
        Return True
    End Function

    Private Function CheckFields() As Boolean
        Return True
    End Function

    Private Sub PopulateDPE()

        Try
            'Appetite
            With CmbAppetite
                Dim CmbSource As New Dictionary(Of String, String) From {
                    {"1", "POSITIVE"},
                    {"0", "NEGATIVE"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

            'Bowel
            With CmbBowel
                Dim CmbSource As New Dictionary(Of String, String) From {
                    {"1", "POSITIVE"},
                    {"0", "NEGATIVE"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

            'Urine
            With CmbUrine
                Dim CmbSource As New Dictionary(Of String, String) From {
                    {"1", "POSITIVE"},
                    {"0", "NEGATIVE"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

            'Vomit
            With CmbVomit
                Dim CmbSource As New Dictionary(Of String, String) From {
                    {"1", "POSITIVE"},
                    {"0", "NEGATIVE"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

            'Food
            With CmbFood
                Dim CmbSource As New Dictionary(Of String, String) From {
                    {"1", "OWNER"},
                    {"0", "CLINIC"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

            'Fasting
            With CmbFasting
                Dim CmbSource As New Dictionary(Of String, String) From {
                    {"1", "YES"},
                    {"0", "NO"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateDPE()")
        End Try

    End Sub

    Private Sub AddTest()

        Dim DtTest As New DataTable

        Try
            DtTest = InitSelectedItemDt()
            If DgvSelectedTest.Rows.Count > 0 Then

                'Loop data grid view
                For i As Integer = 0 To DgvSelectedTest.Rows.Count - 1

                    Dim DgvRow As DataRow = DtTest.NewRow

                    DgvRow("RowNo") = DgvSelectedTest.Rows(i).Cells("TestRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedTest.Rows(i).Cells("TestItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedTest.Rows(i).Cells("TestItemDescription").Value
                    DgvRow("Quantity") = DgvSelectedTest.Rows(i).Cells("TestQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedTest.Rows(i).Cells("TestUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedTest.Rows(i).Cells("TestTotalPrice").Value
                    DgvRow("ItemGroup") = DgvSelectedTest.Rows(i).Cells("TestItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvSelectedTest.Rows(i).Cells("TestItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvSelectedTest.Rows(i).Cells("TestItemTypeDescription").Value

                    DtTest.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtTest.NewRow

            Row("RowNo") = IIf(DtTest.Rows.Count = 0, 1, DtTest.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtTestItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtTestItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtTestUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtTestQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTestTotalPrice.Text) * CDec(TxtTestQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeCode") = ItemTypeCode
            Row("ItemTypeDescription") = ItemTypeDescription

            DtTest.Rows.Add(Row)

            If DtTest.Rows.Count > 0 Then

                DgvSelectedTest.Rows.Clear()

                For i As Integer = 0 To DtTest.Rows.Count - 1
                    With DgvSelectedTest
                        .Rows.Add()
                        .Rows(i).Cells("TestRowNo").Value = DtTest.Rows(i).Item("RowNo")
                        .Rows(i).Cells("TestItemCode").Value = DtTest.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("TestItemDescription").Value = DtTest.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("TestUnitPrice").Value = DtTest.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("TestQuantity").Value = DtTest.Rows(i).Item("Quantity")
                        .Rows(i).Cells("TestTotalPrice").Value = DtTest.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("TestItemGroup").Value = DtTest.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("TestItemTypeCode").Value = DtTest.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("TestItemTypeDescription").Value = DtTest.Rows(i).Item("ItemTypeDescription")
                    End With
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTest()")
        End Try

    End Sub

    Private Sub AddTreatment()

        Dim DtTreatment As New DataTable

        Try
            DtTreatment = InitSelectedItemDt()
            If DgvSelectedTreatment.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    Dim DgvRow As DataRow = DtTreatment.NewRow

                    DgvRow("RowNo") = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                    DgvRow("Prescription") = DgvSelectedTreatment.Rows(i).Cells("Prescription").Value
                    DgvRow("Notes") = DgvSelectedTreatment.Rows(i).Cells("Notes").Value
                    DgvRow("Quantity") = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                    DgvRow("ItemGroup") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value

                    DtTreatment.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtTreatment.NewRow

            Row("RowNo") = IIf(DtTreatment.Rows.Count = 0, 1, DtTreatment.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtTreatmentItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtTreatmentItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtTreatmentUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtTreatmentQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTreatmentTotalPrice.Text) * CDec(TxtTreatmentQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode

            DtTreatment.Rows.Add(Row)

            If DtTreatment.Rows.Count > 0 Then

                DgvSelectedTreatment.Rows.Clear()

                For i As Integer = 0 To DtTreatment.Rows.Count - 1
                    With DgvSelectedTreatment
                        .Rows.Add()
                        .Rows(i).Cells("TreatmentRowNo").Value = DtTreatment.Rows(i).Item("RowNo")
                        .Rows(i).Cells("TreatmentItemCode").Value = DtTreatment.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("TreatmentItemDescription").Value = DtTreatment.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("TreatmentUnitPrice").Value = DtTreatment.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("TreatmentQuantity").Value = DtTreatment.Rows(i).Item("Quantity")
                        .Rows(i).Cells("TreatmentTotalPrice").Value = DtTreatment.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("TreatmentItemGroup").Value = DtTreatment.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("TreatmentItemTypeCode").Value = DtTreatment.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("TreatmentItemTypeDescription").Value = DtTreatment.Rows(i).Item("ItemTypeDescription")
                    End With
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTreatment()")
        End Try

    End Sub

    Private Function InitWardSummaryDt() As DataTable

        Dim DtWardSummary As New DataTable

        Try
            With DtWardSummary
                .Columns.Add("WardDate", GetType(Date))
                .Columns.Add("DailyNotes", GetType(String))
                .Columns.Add("Appetite", GetType(String))
                .Columns.Add("Bowel", GetType(String))
                .Columns.Add("Urine", GetType(String))
                .Columns.Add("Vomit", GetType(String))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitWardSummaryDt()")
        End Try

        Return DtWardSummary

    End Function

    Private Function InitSelectedItemDt() As DataTable

        Dim DtTreatment As New DataTable

        Try
            With DtTreatment
                .Columns.Add("RowNo", GetType(Integer))
                .Columns.Add("ItemCode", GetType(String))
                .Columns.Add("ItemDescription", GetType(String))
                .Columns.Add("ItemGroup", GetType(String))
                .Columns.Add("ItemTypeCode", GetType(String))
                .Columns.Add("ItemTypeDescription", GetType(String))
                .Columns.Add("Prescription", GetType(String))
                .Columns.Add("Notes", GetType(String))
                .Columns.Add("UnitPrice", GetType(Decimal))
                .Columns.Add("Quantity", GetType(Decimal))
                .Columns.Add("TotalPrice", GetType(Decimal))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitTreatmentDt()")
        End Try

        Return DtTreatment

    End Function

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Try
            With FrmSearchVisit
                .Source = "WARD"
                .UserCommand = "ADD_NEW_WARD"
                .ShowDialog()
                VisitID = .VisitID
                CustomerID = .CustomerID
                CustomerName = .CustomerName
                PetID = .PetID
                PetName = .PetName
                UserCommand = .UserCommand
            End With

            PopulateForm(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".BtnSearch_Click")
        End Try

    End Sub

    Private Sub BtnSearchTestItem_Click(sender As Object, e As EventArgs) Handles BtnSearchTestItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtTestItem.Tag = .ItemCode
            TxtTestItem.Text = .ItemDescription
            TxtTestUnitPrice.Text = .UnitPrice
            TxtTestTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTestQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtTreatmentItem.Tag = .ItemCode
            TxtTreatmentItem.Text = .ItemDescription
            TxtTreatmentUnitPrice.Text = .UnitPrice
            TxtTreatmentTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTreatmentQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CheckFields() Then Exit Sub
        If Not SaveWardToDb() Then Exit Sub
        If Not UpdateBill() Then Exit Sub
    End Sub

    Private Sub BtnAddTest_Click(sender As Object, e As EventArgs) Handles BtnAddTest.Click
        AddTest()
    End Sub

    Private Sub BtnTreatmentItem_Click(sender As Object, e As EventArgs) Handles BtnTreatmentItem.Click
        AddTreatment()
    End Sub

    Private Sub BtnClearTest_Click(sender As Object, e As EventArgs) Handles BtnClearTest.Click
        TxtTestItem.Text = ""
        TxtTestItem.Tag = ""
    End Sub

    Private Sub BtnClearTreatment_Click(sender As Object, e As EventArgs) Handles BtnClearTreatment.Click
        TxtTreatmentItem.Text = ""
        TxtTreatmentItem.Tag = ""
    End Sub

    Private Sub CbIsDischarged_Click(sender As Object, e As EventArgs) Handles CbIsDischarged.Click
        If Not DischargePet() Then Exit Sub
    End Sub

    Private Function DischargePet() As Boolean

        Try
            If CbIsDischarged.Checked = True Then
                CbIsDischarged.Tag = Now
            Else
                CbIsDischarged.Tag = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DischargePet()")
            Return False
        End Try

        Return True

    End Function

End Class