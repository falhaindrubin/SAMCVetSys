Imports SAMCVetSys.ModUtility

Public Class FrmWardInformation

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
        Dim DtWardTreatmentDetail As New DataTable
        Dim DtWardSummary As New DataTable
        Dim DtInvoice As New DataTable

        Dim ClsWard As New ClsWard
        Dim ClsBill As New ClsBill
        Dim ClsWardDiagnosis As New ClsWardDiagnosis
        Dim ClsWardTreatment As New ClsWardTreatment

        Try
            Select Case UserCommand
                Case "ADD_NEW_WARD" 'Add new ward
                    'Check if visit is already warded
                    ClsWard.VisitID = VisitID
                    DtWardDetail = ClsWard.GetWardDetail(ClsWard)

                    If DtWardDetail.Rows.Count > 0 Then
                        MsgBox("Selected visit has been registered into ward. Please select another customer visit.", MsgBoxStyle.Exclamation, "Ward Record Found")
                        GoTo ShowWardInfo
                    End If

                    TxtAdmissionDate.Text = Now
                    TxtVisitID.Text = VisitID
                    TxtCustomerID.Text = CustomerID
                    TxtCustomerName.Text = CustomerName
                    TxtPetID.Text = PetID
                    TxtPetName.Text = PetName
                    TxtWardDate.Text = Now.Date

                Case "SHOW_WARD_INFO"
ShowWardInfo:
                    BtnSearch.Visible = False

                    'DtWardSummary = InitWardSummaryDt()
                    ClsBill.VisitID = VisitID
                    DtInvoice = ClsBill.GetBillHeader(ClsBill)
                    If DtInvoice.Rows.Count > 0 Then
                        BtnBillPayment.Text = CStr(DtInvoice.Rows(0).Item("InvoiceNo"))
                        BtnBillPayment.Tag = CStr(DtInvoice.Rows(0).Item("InvoiceNo"))
                    End If

                    'Get ward summary; daily
                    ClsWard.WardID = WardID
                    ClsWard.VisitID = VisitID
                    DtWardSummary = ClsWard.GetWardDetail(ClsWard)

                    'Get current day entry for ward; populate if any
                    ClsWard.WardID = WardID
                    ClsWard.VisitID = VisitID
                    'ClsWard.WardDate = Now.Date
                    DtWardDetail = ClsWard.GetWardDetail(ClsWard)

                    ClsWardDiagnosis.WardDate = Now.Date 'CDate(TxtWardDate.Text)
                    ClsWardDiagnosis.WardID = WardID
                    DtWardDiagnosisDetail = ClsWardDiagnosis.GetWardDiagnosisDetail(ClsWardDiagnosis)

                    ClsWardTreatment.WardID = WardID
                    ClsWardTreatment.WardDate = Now.Date 'CDate(TxtWardDate.Text)
                    DtWardTreatmentDetail = ClsWardTreatment.GetWardTreatmentDetail(ClsWardTreatment)
                    'Get current day entry for ward; populate if any-END

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
                        TxtWardDate.Text = Now.Date

                        'Populate current day daily physical examination
                        'Check if today's date is already has entry; get date value
                        Dim TodayWardDate As Date
                        For i As Integer = 0 To DtWardDetail.Rows.Count - 1
                            If Now.Date = CDate(DtWardDetail.Rows(i).Item("WardDate")) Then
                                TodayWardDate = CDate(DtWardDetail.Rows(i).Item("WardDate"))
                                Exit For
                            Else
                                TodayWardDate = Nothing
                            End If
                        Next

                        If TodayWardDate <> Nothing Then

                            'Filter datatable using dataview to get intended ward date
                            'Filter current day treatment if any
                            Dim DvWardDetail As New DataView
                            DvWardDetail = DtWardDetail.DefaultView
                            DvWardDetail.RowFilter = "WardDate = '" & TodayWardDate & "'"

                            'Daily Physical Examination
                            CmbAppetite.SelectedValue = DvWardDetail(0)("Appetite")
                            TxtAppetiteDescription.Text = DvWardDetail(0)("AppetiteDescription")
                            CmbBowel.SelectedValue = DvWardDetail(0)("Bowel")
                            TxtBowelDescription.Text = DvWardDetail(0)("BowelDescription")
                            CmbUrine.SelectedValue = DvWardDetail(0)("Urine")
                            TxtUrineDescription.Text = DvWardDetail(0)("UrineDescription")
                            CmbVomit.SelectedValue = DvWardDetail(0)("Vomit")
                            TxtVomitDescription.Text = DvWardDetail(0)("VomitDescription")
                            CmbFood.SelectedValue = DvWardDetail(0)("Food")
                            CmbFasting.SelectedValue = DvWardDetail(0)("IsFasting")
                            TxtFastingDescription.Text = DvWardDetail(0)("FastingDescription")
                            TxtDailyNotes.Text = DvWardDetail(0)("DailyNotes")

                            If DtWardDiagnosisDetail.Rows.Count > 0 Then

                                'Diagnosis/test
                                If DgvSelectedTest.Rows.Count > 0 Then
                                    DgvSelectedTest.Rows.Clear()
                                End If

                                For i As Integer = 0 To DvWardDetail.Count - 1
                                    With DgvSelectedTest
                                        .Rows.Add()
                                        .Rows(i).Cells("TestRowNo").Value = DtWardDiagnosisDetail.Rows(i).Item("RowNo") ' DvWardDetail(i)("DailyNotes")
                                        .Rows(i).Cells("TestItemCode").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemCode") 'DvWardDetail(i)("DailyNotes")
                                        .Rows(i).Cells("TestItemDescription").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemDescription") 'DvWardDetail(i)("DailyNotes")
                                        .Rows(i).Cells("TestUnitPrice").Value = DtWardDiagnosisDetail.Rows(i).Item("UnitPrice") 'DvWardDetail(i)("DailyNotes") 'DtWardDiagnosisDetail.Rows(i).Item("UnitPrice")
                                        .Rows(i).Cells("TestQuantity").Value = DtWardDiagnosisDetail.Rows(i).Item("Quantity") 'DvWardDetail(i)("DailyNotes") 'DtWardDiagnosisDetail.Rows(i).Item("Quantity")
                                        .Rows(i).Cells("TestTotalPrice").Value = DtWardDiagnosisDetail.Rows(i).Item("TotalPrice") 'DvWardDetail(i)("DailyNotes") 'DtWardDiagnosisDetail.Rows(i).Item("TotalPrice")
                                        .Rows(i).Cells("TestItemGroup").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemGroup") 'DvWardDetail(i)("DailyNotes") 'DtWardDiagnosisDetail.Rows(i).Item("ItemGroup")
                                        .Rows(i).Cells("TestItemTypeCode").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemTypeCode") 'DvWardDetail(i)("DailyNotes") 'DtWardDiagnosisDetail.Rows(i).Item("ItemTypeCode")
                                        .Rows(i).Cells("TestItemTypeDescription").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemTypeDescription") 'DvWardDetail(i)("DailyNotes") 'DtWardDiagnosisDetail.Rows(i).Item("ItemTypeDescription")
                                    End With
                                Next

                                TxtDiagnosis.Text = DtWardDiagnosisDetail.Rows(0).Item("Diagnosis") 'IIf(DtWardDiagnosisDetail.Rows.Count > 0, DtWardDiagnosisDetail.Rows(0).Item("Diagnosis"), "")

                            Else
                                TxtDiagnosis.Text = ""

                            End If

                            'Treatment/medication
                            If DtWardTreatmentDetail.Rows.Count > 0 Then

                                If DgvSelectedTreatment.Rows.Count > 0 Then
                                    DgvSelectedTreatment.Rows.Clear()
                                End If

                                For i As Integer = 0 To DtWardTreatmentDetail.Rows.Count - 1
                                    With DgvSelectedTreatment
                                        .Rows.Add()
                                        .Rows(i).Cells("TreatmentRowNo").Value = DtWardTreatmentDetail.Rows(i).Item("RowNo")
                                        .Rows(i).Cells("TreatmentItemCode").Value = DtWardTreatmentDetail.Rows(i).Item("ItemCode")
                                        .Rows(i).Cells("TreatmentItemDescription").Value = DtWardTreatmentDetail.Rows(i).Item("ItemDescription")
                                        .Rows(i).Cells("TreatmentUnitPrice").Value = DtWardTreatmentDetail.Rows(i).Item("UnitPrice")
                                        .Rows(i).Cells("TreatmentQuantity").Value = DtWardTreatmentDetail.Rows(i).Item("Quantity")
                                        .Rows(i).Cells("TreatmentTotalPrice").Value = DtWardTreatmentDetail.Rows(i).Item("TotalPrice")
                                        .Rows(i).Cells("TreatmentItemGroup").Value = DtWardTreatmentDetail.Rows(i).Item("ItemGroup")
                                        .Rows(i).Cells("TreatmentItemTypeCode").Value = DtWardTreatmentDetail.Rows(i).Item("ItemTypeCode")
                                        .Rows(i).Cells("TreatmentItemTypeDescription").Value = DtWardTreatmentDetail.Rows(i).Item("ItemTypeDescription")
                                    End With
                                Next

                            End If

                        End If

                        'Show items summary; user doubleclick will show previous day entry
                        If DtWardSummary.Rows.Count > 0 Then

                            If DgvWardSummary.Rows.Count > 0 Then
                                DgvWardSummary.Rows.Clear()
                            End If

                            For i As Integer = 0 To DtWardSummary.Rows.Count - 1
                                With DgvWardSummary
                                    .Rows.Add()
                                    .Rows(i).Cells("WardDate").Value = CDate(DtWardSummary.Rows(i).Item("WardDate")).Date.ToShortDateString
                                    .Rows(i).Cells("DailyNotes").Value = DtWardSummary.Rows(i).Item("DailyNotes")
                                    .Rows(i).Cells("Appetite").Value = IIf(DtWardSummary.Rows(i).Item("Appetite") = "1", "POSITIVE", "NEGATIVE")
                                    .Rows(i).Cells("Bowel").Value = IIf(DtWardSummary.Rows(i).Item("Bowel") = "1", "POSITIVE", "NEGATIVE")
                                    .Rows(i).Cells("Urine").Value = IIf(DtWardSummary.Rows(i).Item("Urine") = "1", "POSITIVE", "NEGATIVE")
                                    .Rows(i).Cells("Vomit").Value = IIf(DtWardSummary.Rows(i).Item("Vomit") = "1", "POSITIVE", "NEGATIVE")
                                End With
                            Next

                            TxtCreatedBy.Text = DtWardDetail.Rows(0).Item("CreatedBy")
                            TxtDateCreated.Text = DtWardDetail.Rows(0).Item("DateCreated")
                            TxtModifiedBy.Text = DtWardDetail.Rows(0).Item("ModifiedBy")
                            TxtDateModified.Text = DtWardDetail.Rows(0).Item("DateModified")

                        End If

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
                .AdmissionDate = TxtAdmissionDate.Text
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
                .WardDate = CDate(TxtWardDate.Text) 'DtpWardDate.Value.Date
                '.RowNo = ""
                .Appetite = Trim(DirectCast(CmbAppetite.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .AppetiteDescription = Trim(TxtAppetiteDescription.Text)
                .Bowel = Trim(DirectCast(CmbBowel.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .BowelDescription = Trim(TxtBowelDescription.Text)
                .Urine = Trim(DirectCast(CmbUrine.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .UrineDescription = Trim(TxtUrineDescription.Text)
                .Vomit = Trim(DirectCast(CmbVomit.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .VomitDescription = Trim(TxtVomitDescription.Text)
                .Food = Trim(DirectCast(CmbFood.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .IsFasting = Trim(DirectCast(CmbFasting.SelectedItem, KeyValuePair(Of String, String)).Key.ToString)
                .FastingDescription = Trim(TxtFastingDescription.Text)
                .DailyNotes = Trim(TxtDailyNotes.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now
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
                    .WardDate = CDate(TxtWardDate.Text) 'DtpWardDate.Value.Date
                    .RowNo = i + 1
                    .ItemCode = DgvSelectedTest.Rows(i).Cells("TestItemCode").Value
                    .ItemDescription = DgvSelectedTest.Rows(i).Cells("TestItemDescription").Value
                    .ItemGroup = DgvSelectedTest.Rows(i).Cells("TestItemGroup").Value
                    .ItemTypeCode = DgvSelectedTest.Rows(i).Cells("TestItemTypeCode").Value
                    .ItemTypeDescription = DgvSelectedTest.Rows(i).Cells("TestItemTypeDescription").Value
                    .UnitPrice = DgvSelectedTest.Rows(i).Cells("TestUnitPrice").Value
                    .Quantity = DgvSelectedTest.Rows(i).Cells("TestQuantity").Value
                    .TotalPrice = DgvSelectedTest.Rows(i).Cells("TestTotalPrice").Value
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
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
                        .WardDate = CDate(TxtWardDate.Text) 'DtpWardDate.Value.Date
                        .RowNo = i + 1
                        .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                        .ItemGroup = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                        .ItemTypeCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value
                        .Prescription = DgvSelectedTreatment.Rows(i).Cells("Prescription").Value
                        .Notes = DgvSelectedTreatment.Rows(i).Cells("Notes").Value
                        .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                        .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                        .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
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

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            TxtWardID.Text = GenWardID
            TxtWardID.Tag = GenWardID
            WardID = GenWardID

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

        Dim DtBillHeader As New DataTable
        Dim DtBillDetail As New DataTable
        Dim DtWardDiagnosis As New DataTable
        Dim DtWardTreatment As New DataTable
        Dim DtPayment As New DataTable
        Dim DtUpdateBill As New DataTable
        Dim ClsWardDiagnosis As New ClsWardDiagnosis
        Dim ClsWardTreatment As New ClsWardTreatment
        Dim ClsBill As New ClsBill
        Dim ClsBillDetail As New ClsBillDetail

        Try
            DtPayment = InitBillItemDt()

            'Retrieve existing item from bill detail;
            ClsBill.VisitID = Trim(TxtVisitID.Text)
            DtBillHeader = ClsBill.GetBillHeader(ClsBill)
            If DtBillHeader.Rows.Count > 0 Then
                ClsBill.InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                DtBillDetail = ClsBill.GetBillDetail(ClsBill)
                If DtBillDetail.Rows.Count > 0 Then
                    For i As Integer = 0 To DtBillDetail.Rows.Count - 1
                        Dim Row As DataRow = DtPayment.NewRow
                        Row("RowNo") = DtBillDetail.Rows(i).Item("RowNo")
                        Row("ItemCode") = DtBillDetail.Rows(i).Item("ItemCode")
                        Row("ItemDescription") = DtBillDetail.Rows(i).Item("ItemDescription")
                        Row("ItemGroup") = DtBillDetail.Rows(i).Item("ItemGroup")
                        Row("ItemTypeCode") = DtBillDetail.Rows(i).Item("ItemTypeCode")
                        Row("ItemTypeDescription") = DtBillDetail.Rows(i).Item("ItemTypeDescription")
                        Row("Prescription") = DtBillDetail.Rows(i).Item("Prescription")
                        Row("Notes") = DtBillDetail.Rows(i).Item("Notes")
                        Row("UnitPrice") = DtBillDetail.Rows(i).Item("UnitPrice")
                        Row("Quantity") = DtBillDetail.Rows(i).Item("Quantity")
                        Row("TotalPrice") = DtBillDetail.Rows(i).Item("TotalPrice")
                        DtPayment.Rows.Add(Row)
                    Next
                    'Else
                    '    Return False
                End If
            Else
                'Create new invoice
                MsgBox("Please create invoice for the selected ward admission in Customer > Visit > Billing & Payment.", MsgBoxStyle.Exclamation, "Invoice Not Created")
                Return False
            End If

            'Retrieve items from diagnosis
            ClsWardDiagnosis.VisitID = Trim(TxtVisitID.Text)
            DtWardDiagnosis = ClsWardDiagnosis.GetWardDiagnosisDetail(ClsWardDiagnosis)
            If DtWardDiagnosis.Rows.Count > 0 Then
                For i As Integer = 0 To DtWardDiagnosis.Rows.Count - 1

                    If AddItemToBill(DtPayment, DtWardDiagnosis.Rows(i).Item("ItemCode"), DtWardDiagnosis.Rows(i).Item("WardDate")) = True Then

                        Dim Row As DataRow = DtPayment.NewRow
                        Row("RowNo") = DtWardDiagnosis.Rows(i).Item("RowNo")
                        Row("ItemCode") = DtWardDiagnosis.Rows(i).Item("ItemCode")
                        Row("ItemDescription") = DtWardDiagnosis.Rows(i).Item("ItemDescription")
                        Row("ItemGroup") = DtWardDiagnosis.Rows(i).Item("ItemGroup")
                        Row("ItemTypeCode") = DtWardDiagnosis.Rows(i).Item("ItemTypeCode")
                        Row("ItemTypeDescription") = DtWardDiagnosis.Rows(i).Item("ItemTypeDescription")
                        Row("Prescription") = ""
                        Row("Notes") = ""
                        Row("UnitPrice") = DtWardDiagnosis.Rows(i).Item("UnitPrice")
                        Row("Quantity") = DtWardDiagnosis.Rows(i).Item("Quantity")
                        Row("TotalPrice") = DtWardDiagnosis.Rows(i).Item("TotalPrice")

                        DtPayment.Rows.Add(Row)

                    End If

                Next
                'Else
                '    Return False
            End If

            'Retrieve items from treatment
            ClsWardTreatment.VisitID = Trim(TxtVisitID.Text)
            DtWardTreatment = ClsWardTreatment.GetWardTreatmentDetail(ClsWardTreatment)
            If DtWardTreatment.Rows.Count > 0 Then
                For i As Integer = 0 To DtWardTreatment.Rows.Count - 1

                    If AddItemToBill(DtPayment, DtWardTreatment.Rows(i).Item("ItemCode"), DtWardTreatment.Rows(i).Item("WardDate")) = True Then

                        Dim Row As DataRow = DtPayment.NewRow
                        Row("RowNo") = DtWardTreatment.Rows(i).Item("RowNo")
                        Row("ItemCode") = DtWardTreatment.Rows(i).Item("ItemCode")
                        Row("ItemDescription") = DtWardTreatment.Rows(i).Item("ItemDescription")
                        Row("ItemGroup") = DtWardTreatment.Rows(i).Item("ItemGroup")
                        Row("ItemTypeCode") = DtWardTreatment.Rows(i).Item("ItemTypeCode")
                        Row("ItemTypeDescription") = DtWardTreatment.Rows(i).Item("ItemTypeDescription")
                        Row("Prescription") = DtWardTreatment.Rows(i).Item("Prescription")
                        Row("Notes") = DtWardTreatment.Rows(i).Item("Notes")
                        Row("UnitPrice") = DtWardTreatment.Rows(i).Item("UnitPrice")
                        Row("Quantity") = DtWardTreatment.Rows(i).Item("Quantity")
                        Row("TotalPrice") = DtWardTreatment.Rows(i).Item("TotalPrice")
                        DtPayment.Rows.Add(Row)

                    End If

                Next
                'Else
                '    Return False
            End If

            If DtPayment.Rows.Count > 0 Then

                Dim GrossTotal As Decimal

                If DbTrans IsNot Nothing Then
                    DbTrans = Nothing
                End If

                DbTrans = DbConn.BeginTransaction

                'Update RowNo for each item and total price
                For i As Integer = 0 To DtPayment.Rows.Count - 1
                    DtPayment.Rows(i).Item("RowNo") = i + 1
                    GrossTotal = GrossTotal + DtPayment.Rows(i).Item("TotalPrice")
                Next

                'Check if bill is already created during register consultation/visit
                If DtBillHeader.Rows.Count = 0 Then
                    MsgBox("Billing has not been created. Please create customer biling in Customer > Visit.", MsgBoxStyle.Critical, "Billing & Payment Update Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Delete previous items in the bill; insert new billing
                ClsBill.InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                If Not ClsBill.DeleteBill(ClsBill, DbConn, DbTrans) Then
                    MsgBox("Failed to update billing details.", MsgBoxStyle.Critical, "Bill Update Reset Details Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                ClsBill = New ClsBill
                With ClsBill
                    .InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                    .VisitID = VisitID
                    .InvoiceDate = Now
                    .CustomerID = CustomerID
                    .CustomerName = CustomerName
                    .GrossTotal = GrossTotal
                    .Discount = DtBillHeader.Rows(0).Item("Discount")
                    .GrandTotal = GrossTotal - DtBillHeader.Rows(0).Item("Discount")
                    .Deposit = DtBillHeader.Rows(0).Item("Deposit")
                    .TotalDue = .GrandTotal - .Deposit
                    .IsPaymentComplete = DtBillHeader.Rows(0).Item("IsPaymentComplete")
                    .Ref.CreatedBy = DtBillHeader.Rows(0).Item("CreatedBy")
                    .Ref.DateCreated = DtBillHeader.Rows(0).Item("DateCreated")
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now
                End With

                If Not ClsBill.AddNewBill(ClsBill, DbConn, DbTrans) Then
                    MsgBox("Failed to create bill header.", MsgBoxStyle.Critical, "Create Bill Failed")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Create bill details
                For i As Integer = 0 To DtPayment.Rows.Count - 1

                    ClsBillDetail = New ClsBillDetail
                    With ClsBillDetail
                        .InvoiceNo = DtBillHeader.Rows(0).Item("InvoiceNo")
                        .RowNo = DtPayment.Rows(i).Item("RowNo")
                        .ItemCode = DtPayment.Rows(i).Item("ItemCode")
                        .ItemDescription = DtPayment.Rows(i).Item("ItemDescription")
                        .ItemGroup = CStrNull(DtPayment.Rows(i).Item("ItemGroup"))
                        .ItemTypeCode = CStrNull(DtPayment.Rows(i).Item("ItemTypeCode"))
                        .ItemTypeDescription = CStrNull(DtPayment.Rows(i).Item("ItemTypeDescription"))
                        .Prescription = DtPayment.Rows(i).Item("Prescription")
                        .Notes = DtPayment.Rows(i).Item("Notes")
                        .UnitPrice = DtPayment.Rows(i).Item("UnitPrice")
                        .Quantity = DtPayment.Rows(i).Item("Quantity")
                        .TotalPrice = DtPayment.Rows(i).Item("TotalPrice")
                    End With

                    If Not ClsBillDetail.AddNewBillDetail(ClsBillDetail, DbConn, DbTrans) Then
                        MsgBox("Failed to create billing details.", MsgBoxStyle.Critical, "Create Bill Details Failed")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                Next

                DbTrans.Commit()
                DbTrans.Dispose()
                DbTrans = Nothing

                MsgBox("Customer billing and payment has been successfully updated!", MsgBoxStyle.Information, "Billing & Payment Updated")
            Else
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateBill()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function AddItemToBill(DtPayment As DataTable, ItemCode As String, ItemDate As Date) As Boolean

        Try
            If DtPayment.Rows.Count > 0 Then
                For i As Integer = 0 To DtPayment.Rows.Count - 1
                    If ItemCode = DtPayment.Rows(i).Item("ItemCode") Then
                        Return False
                    End If
                Next
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddItemToBill()")
            Return False
        End Try

        Return True

    End Function

    Private Function InitBillItemDt() As DataTable

        Dim DtBill As New DataTable

        Try
            With DtBill
                .Columns.Add("InvoiceNo", GetType(String))
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitBillItemDt()")
        End Try

        Return DtBill

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
            If TxtTestItem.Tag = "" Then
                Exit Sub
            End If

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

            TxtTestItem.Text = ""
            TxtTestItem.Tag = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTest()")
        End Try

    End Sub

    Private Sub AddTreatment()

        Dim DtTreatment As New DataTable

        Try
            If TxtTreatmentItem.Tag = "" Then
                Exit Sub
            End If

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

            TxtTreatmentItem.Text = ""
            TxtTreatmentItem.Tag = ""

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

    Private Function DischargePet() As Boolean

        Dim UserResponse As MsgBoxResult

        Try
            If CbIsDischarged.Checked = True Then

                UserResponse = MsgBox("Are sure you want to discharge this pet? Your action cannot be undone.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Discharge Pet?")
                If UserResponse = MsgBoxResult.Yes Then

                    'Set fixed AdmissionDate & DischargeDate
                    Dim StrFixedAD As String = CDate(TxtAdmissionDate.Text).Date.ToShortDateString & " 12:00:00"
                    Dim StrFixedDD As String = Now.Date.ToShortDateString & " 12:00:00"
                    Dim FixedAD As Date = CDate(StrFixedAD)
                    Dim FixedDD As Date = CDate(StrFixedDD)
                    Dim FixDuration As TimeSpan

                    'Get actual admission date & actual discharge date
                    Dim ActualAD As Date = CDate(TxtAdmissionDate.Text)
                    Dim ActualDD As Date = Now

                    FixDuration = FixedDD - FixedAD
                    Dim WardDuration As Integer = FixDuration.Days

                    If ActualDD > FixedDD Then
                        WardDuration = WardDuration + 1
                    End If

                    'Update IsDischarge, DischargeDate
                    If DbTrans IsNot Nothing Then
                        DbTrans = Nothing
                    End If

                    DbTrans = DbConn.BeginTransaction

                    Dim ClsWard As New ClsWard
                    With ClsWard
                        .WardID = Trim(TxtWardID.Text)
                        .IsDischarged = "1"
                        .DischargeDate = ActualDD
                        .WardDuration = WardDuration
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .DischargePet(ClsWard, DbConn, DbTrans) Then
                            CbIsDischarged.Checked = False
                            MsgBox("Failed to update discharge status.", MsgBoxStyle.Critical, "Discharge Status Update Error")
                            DbTrans.Rollback()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                    DbTrans.Commit()
                    DbTrans.Dispose()
                    DbTrans = Nothing

                    MsgBox("Admission Date : " & ActualAD & Environment.NewLine &
                   "Discharge Date : " & ActualDD & Environment.NewLine &
                   "Ward Duration : " & WardDuration)

                    MsgBox("Your selected pet has been successfully discharged!", MsgBoxStyle.Information, "Pet Discharge Completed")
                Else
                    CbIsDischarged.Checked = False

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DischargePet()")
            Return False
        End Try

        Return True

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
                UserCommand = IIf(.VisitID <> "", "ADD_NEW_WARD", "")
            End With

            If UserCommand = "" Then
                Exit Sub
            Else
                PopulateForm(UserCommand)
            End If

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
        'If Not UpdateBill() Then Exit Sub
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

    Private Sub DgvWardSummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvWardSummary.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmWardSummary With {
                        .WardID = TxtWardID.Text,
                        .VisitID = TxtVisitID.Text,
                        .CustomerID = TxtCustomerID.Text,
                        .WardDate = DgvWardSummary.Rows(e.RowIndex).Cells("WardDate").Value
                    }
                    Frm.ShowDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvWardSummary_CellDoubleClick()")
        End Try

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        PopulateForm("SHOW_WARD_INFO")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            'Set fixed AdmissionDate & DischargeDate
            Dim StrFixedAD As String = CDate(TxtAD.Text).Date.ToShortDateString & " 12:00:00"
            Dim StrFixedDD As String = CDate(TxtDD.Text).Date.ToShortDateString & " 12:00:00"

            Dim FixedAD As Date = CDate(StrFixedAD)
            Dim FixedDD As Date = CDate(StrFixedDD)

            Dim FixDuration As TimeSpan

            'Get actual admission date & actual discharge date
            Dim ActualAD As Date = CDate(TxtAD.Text) '"19/10/2018 13:00:00"
            Dim ActualDD As Date = CDate(TxtDD.Text) '"20/10/2018 12:01:00"

            FixDuration = FixedDD - FixedAD
            Dim WardDuration As Integer = FixDuration.Days

            If ActualDD > FixedDD Then
                WardDuration = WardDuration + 1
            End If

            MsgBox("Admission Date : " & ActualAD & Environment.NewLine &
                   "Discharge Date : " & ActualDD & Environment.NewLine &
                   "Ward Duration : " & WardDuration)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnBillPayment_Click(sender As Object, e As EventArgs) Handles BtnBillPayment.Click
        With FrmPaymentInformation
            .InvoiceNo = BtnBillPayment.Tag
            .UserCommand = "SHOW_BILLING_INFO"
            .ShowDialog()
        End With
    End Sub

End Class