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

    Private _RequestID As String
    Public Property RequestID As String
        Get
            Return _RequestID
        End Get
        Set(value As String)
            _RequestID = value
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
        FORM_SOURCE = "WARD"
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateDPE()
        PopulateForm(UserCommand)
    End Sub

    Private Sub PopulateForm(Optional UserCommand As String = "")

        Dim DtWardDetail As New DataTable
        Dim DtWardDiagnosis As New DataTable
        Dim DtWardDiagnosisDetail As New DataTable
        Dim DtWardTreatmentDetail As New DataTable
        Dim DtWardSummary As New DataTable
        Dim DtInvoice As New DataTable

        Dim ClsWard As New ClsWard
        Dim ClsBill As New ClsBill
        Dim ClsWardDiagnosis As New ClsWardDiagnosis
        Dim ClsWardTreatment As New ClsWardTreatment

        Try
            TxtWardHourlyTime.Text = Now
            TxtVet.Tag = CURR_EMPLOYEE_ID
            TxtVet.Text = CURR_EMPLOYEE_NAME

            If WardID <> "" Then

                'Get ward summary; daily
                With ClsWard
                    .WardID = WardID
                    DtWardSummary = .GetWardDetail(ClsWard)
                End With

                'Get current day entry for ward; populate if any
                With ClsWard
                    .WardID = WardID
                    DtWardDetail = .GetWardDetail(ClsWard)
                End With

                'Get ward diagnosis header/diagnosis recorded
                With ClsWardDiagnosis
                    .WardDate = Now.Date
                    .WardID = WardID
                    DtWardDiagnosis = .GetWardDiagnosis(ClsWardDiagnosis)
                End With

                'Get ward diagnosis item
                With ClsWardDiagnosis
                    .WardDate = Now.Date
                    .WardID = WardID
                    DtWardDiagnosisDetail = .GetWardDiagnosisDetail(ClsWardDiagnosis)
                End With

                'Get ward treatment items
                With ClsWardTreatment
                    .WardID = WardID
                    .WardDate = Now.Date
                    DtWardTreatmentDetail = .GetWardTreatmentDetail(ClsWardTreatment)
                End With
                'Get current day entry for ward; populate if any-END

                If DtWardDetail.Rows.Count > 0 Then

                    'TxtVisitID.Text = DtWardDetail.Rows(0).Item("VisitID")
                    TxtWardID.Text = DtWardDetail.Rows(0).Item("WardID")
                    TxtAdmissionDate.Text = DtWardDetail.Rows(0).Item("AdmissionDate")
                    'TxtCustomerID.Text = DtWardDetail.Rows(0).Item("CustomerID")
                    TxtCustomerName.Text = DtWardDetail.Rows(0).Item("CustomerName")
                    'TxtPetID.Text = DtWardDetail.Rows(0).Item("PetID")
                    TxtPetName.Text = DtWardDetail.Rows(0).Item("PetName")
                    TxtCase.Text = DtWardDetail.Rows(0).Item("PetCase")
                    CbIsDischarged.Checked = IIf(DtWardDetail.Rows(0).Item("IsDischarged") = "1", True, False)
                    CbIsDischarged.Enabled = IIf(DtWardDetail.Rows(0).Item("IsDischarged") = "1", False, True)
                    TxtDischargeDate.Text = IIf(DtWardDetail.Rows(0).Item("IsDischarged") = "1", CDate(DtWardDetail.Rows(0).Item("DischargeDate")), "")
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
                        TxtDiagnosis.Text = CStrNull(DvWardDetail(0)("Diagnosis"))

                        If DtWardDiagnosisDetail.Rows.Count > 0 Then

                            'Diagnosis/test
                            If DgvSelectedTest.Rows.Count > 0 Then
                                DgvSelectedTest.Rows.Clear()
                            End If

                            For i As Integer = 0 To DvWardDetail.Count - 1
                                With DgvSelectedTest
                                    .Rows.Add()
                                    .Rows(i).Cells("TestRowNo").Value = DtWardDiagnosisDetail.Rows(i).Item("RowNo")
                                    .Rows(i).Cells("TestItemCode").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemCode")
                                    .Rows(i).Cells("TestItemDescription").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemDescription")
                                    .Rows(i).Cells("TestUnitPrice").Value = DtWardDiagnosisDetail.Rows(i).Item("UnitPrice")
                                    .Rows(i).Cells("TestQuantity").Value = DtWardDiagnosisDetail.Rows(i).Item("Quantity")
                                    .Rows(i).Cells("TestTotalPrice").Value = DtWardDiagnosisDetail.Rows(i).Item("TotalPrice")
                                    .Rows(i).Cells("TestItemGroup").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemGroup")
                                    .Rows(i).Cells("TestItemTypeCode").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemTypeCode")
                                    .Rows(i).Cells("TestItemTypeDescription").Value = DtWardDiagnosisDetail.Rows(i).Item("ItemTypeDescription")
                                End With
                            Next

                            'TxtDiagnosis.Text = DtWardDiagnosisDetail.Rows(0).Item("Diagnosis")

                        Else
                            'TxtDiagnosis.Text = ""

                        End If

                        'Treatment/medication
                        If DtWardTreatmentDetail.Rows.Count > 0 Then

                            If DgvSelectedTreatment.Rows.Count > 0 Then
                                DgvSelectedTreatment.Rows.Clear()
                            End If

                            For i As Integer = 0 To DtWardTreatmentDetail.Rows.Count - 1
                                With DgvSelectedTreatment
                                    .Rows.Add()
                                    .Rows(i).Cells("TreatmentPhRequestID").Value = DtWardTreatmentDetail.Rows(i).Item("PhRequestID")
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

                    'Show ward hourly
                    'Get ward hourly updates
                    Dim DtWardHourly As New DataTable
                    Dim ClsWardHourly As New ClsWardHourly
                    With ClsWardHourly
                        .WardID = WardID
                        DtWardHourly = .GetWardHourly(ClsWardHourly)
                        If DtWardHourly.Rows.Count > 0 Then

                            DgvHourlyList.Rows.Clear()

                            For i As Integer = 0 To DtWardHourly.Rows.Count - 1

                                With DgvHourlyList
                                    .Rows.Add()
                                    .Rows(i).Cells("HourlyWardID").Value = DtWardHourly.Rows(i).Item("WardID")
                                    .Rows(i).Cells("HourlyEmployeeID").Value = DtWardHourly.Rows(i).Item("EmployeeID")
                                    .Rows(i).Cells("HourlyWardTime").Value = DtWardHourly.Rows(i).Item("WardDate")
                                    .Rows(i).Cells("HourlyEmployeeName").Value = DtWardHourly.Rows(i).Item("EmployeeName")
                                    .Rows(i).Cells("HourlyHourlyNotes").Value = DtWardHourly.Rows(i).Item("HourlyNotes")
                                    .Rows(i).Cells("HourlyCreatedBy").Value = DtWardHourly.Rows(i).Item("CreatedBy")
                                    .Rows(i).Cells("HourlyDateCreated").Value = DtWardHourly.Rows(i).Item("DateCreated")
                                    .Rows(i).Cells("HourlyModifiedBy").Value = DtWardHourly.Rows(i).Item("ModifiedBy")
                                    .Rows(i).Cells("HourlyDateModified").Value = DtWardHourly.Rows(i).Item("DateModified")
                                End With

                            Next

                        End If
                    End With

                    'Show discharge details if any
                    If DtWardDetail.Rows.Count > 0 Then
                        'If DtWardDetail.Rows(0).Item("IsDischarged") = "1" Then

                        Dim ClsWardDischarge As New ClsWardDischarge
                        Dim ClsWardDiscMed As New ClsWardDischargeDetail
                        Dim DtWardDischarge As New DataTable
                        Dim DtWardDiscMed As New DataTable

                        With ClsWardDischarge
                            .WardID = WardID
                            DtWardDischarge = .GetWardDischarge(ClsWardDischarge)

                            If DtWardDischarge.Rows.Count > 0 Then

                                TxtDischargeDate.Text = DtWardDischarge.Rows(0).Item("DischargeDate")
                                TxtAdmitIssue.Text = DtWardDischarge.Rows(0).Item("AdmitIssue")
                                TxtAdmitDiagnosis.Text = DtWardDischarge.Rows(0).Item("AdmitDiagnosis")
                                TxtDischargeCondition.Text = DtWardDischarge.Rows(0).Item("DischargeCondition")
                                TxtDischargeReason.Text = DtWardDischarge.Rows(0).Item("DischargeReason")
                                TxtPossibleComplications.Text = DtWardDischarge.Rows(0).Item("PossibleComplications")
                                TxtAdditionalInstructions.Text = DtWardDischarge.Rows(0).Item("AdditionalInstruction")
                                'Add test/diagnosis/treatment/medication summary here

                            End If

                        End With

                        With ClsWardDiscMed
                            .WardID = WardID
                            DtWardDiscMed = .GetWardDischargeMedication(ClsWardDiscMed)
                            If DtWardDiscMed.Rows.Count > 0 Then

                                DgvDischargeMedication.Rows.Clear()

                                For i As Integer = 0 To DtWardDiscMed.Rows.Count - 1
                                    With DgvDischargeMedication
                                        .Rows.Add()
                                        .Rows(i).Cells("DiscMedPhRequestID").Value = DtWardDiscMed.Rows(i).Item("PhRequestID")
                                        .Rows(i).Cells("DiscMedRowNo").Value = DtWardDiscMed.Rows(i).Item("RowNo")
                                        .Rows(i).Cells("DiscMedItemCode").Value = DtWardDiscMed.Rows(i).Item("ItemCode")
                                        .Rows(i).Cells("DiscMedItemDescription").Value = DtWardDiscMed.Rows(i).Item("ItemDescription")
                                        .Rows(i).Cells("DiscMedUnitPrice").Value = DtWardDiscMed.Rows(i).Item("UnitPrice")
                                        .Rows(i).Cells("DiscMedQuantity").Value = DtWardDiscMed.Rows(i).Item("Quantity")
                                        .Rows(i).Cells("DiscMedTotalPrice").Value = DtWardDiscMed.Rows(i).Item("TotalPrice")
                                        .Rows(i).Cells("DiscMedItemGroup").Value = DtWardDiscMed.Rows(i).Item("ItemGroup")
                                        .Rows(i).Cells("DiscMedItemTypeCode").Value = DtWardDiscMed.Rows(i).Item("ItemTypeCode")
                                        .Rows(i).Cells("DiscMedItemTypeDescription").Value = DtWardDiscMed.Rows(i).Item("ItemTypeDescription")
                                    End With
                                Next

                            End If

                        End With

                    End If

                End If

                Else

                TxtAdmissionDate.Text = Now
                TxtCustomerName.Text = CustomerName
                TxtCustomerName.Tag = CustomerID
                TxtPetName.Text = PetName
                TxtPetName.Tag = PetID
                TxtWardDate.Text = Now.Date
                TxtWardHourlyTime.Text = Now

                Dim DtUser As New DataTable
                Dim ClsUser As New ClsUser
                With ClsUser
                    .UserID = CURR_USER
                    DtUser = .GetUserInformation(ClsUser)
                    If DtUser.Rows.Count > 0 Then
                        TxtVet.Tag = CStrNull(DtUser.Rows(0).Item("EmployeeID"))
                        TxtVet.Text = CStrNull(DtUser.Rows(0).Item("EmployeeName"))
                    End If

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Function SaveWardToDb() As Boolean

        Dim ClsWard As New ClsWard
        Dim ClsWardDetail As New ClsWardDetail
        Dim ClsWardDiagnosis As New ClsWardDiagnosis
        Dim ClsWardDiagnosisDetail As New ClsWardDiagnosisDetail
        Dim ClsWardTreatment As New ClsWardTreatment
        Dim DtWardDetail As New DataTable
        Dim DtWardDiagnosisDetail As New DataTable
        Dim DtWardTreatmentDetail As New DataTable

        Try
            Dim ClsVisit As New ClsVisit
            Dim DtVisit As New DataTable

            'Get pet information from current visit
            With ClsVisit
                .VisitID = WardID
                DtVisit = .GetVisitDetail(ClsVisit)
            End With

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Add ward header
            With ClsWard
                .WardID = IIf(WardID <> "", WardID, Trim(TxtWardID.Text))
                .AdmissionDate = TxtAdmissionDate.Text
                .CustomerID = TxtCustomerName.Tag
                .CustomerName = TxtCustomerName.Text
                .PetID = TxtPetName.Tag
                .PetName = TxtPetName.Text
                .TelNo = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("TelNo")), "")
                .MobileNo = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("MobileNo")), "")
                .SexCode = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("SexCode")), "")
                .SexName = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("SexName")), "")
                .AnimalTypeCode = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("AnimalTypeCode")), "")
                .AnimalTypeName = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("AnimalTypeName")), "")
                .BreedCode = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("BreedCode")), "")
                .BreedName = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("BreedName")), "")
                .IsNeutered = IIf(DtVisit.Rows.Count > 0, CStrNull(DtVisit.Rows(0).Item("NeuterCode")), "")
                .PetCase = UCase(Trim(TxtCase.Text))
                .IsDischarged = IIf(CbIsDischarged.Checked = True, "1", "0")
                .DischargeDate = IIf(TxtDischargeDate.Text <> "", TxtDischargeDate.Text, Nothing) 'IIf(CbIsDischarged.Tag = Nothing, Nothing, CbIsDischarged.Tag)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewWard(ClsWard, DbConn, DbTrans) Then
                    MsgBox("Failed to create ward admission.", MsgBoxStyle.Critical, "Create New Ward Admission Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            'Add ward detail
            With ClsWardDetail
                .WardID = IIf(WardID <> "", WardID, Trim(TxtWardID.Text))
                .WardDate = CDate(TxtWardDate.Text)
                .EmployeeID = Trim(TxtVet.Tag)
                .EmployeeName = Trim(TxtVet.Text)
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
                .Diagnosis = Trim(TxtDiagnosis.Text)
                .DailyNotes = Trim(TxtDailyNotes.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewWardDetail(ClsWardDetail, DbConn, DbTrans) Then
                    MsgBox("Failed to create ward admission details.", MsgBoxStyle.Critical, "Create New Ward Admission Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            'Add ward diagnose -- Disabled on 08/12/2018
            'With ClsWardDiagnosis
            '    .WardID = IIf(WardID <> "", WardID, Trim(TxtWardID.Text))
            '    .WardDate = CDate(TxtWardDate.Text)
            '    .PetID = PetID
            '    .PetName = PetName
            '    .Diagnosis = Trim(TxtDiagnosis.Text)
            '    .Ref.CreatedBy = CURR_USER
            '    .Ref.DateCreated = Now
            '    .Ref.ModifiedBy = CURR_USER
            '    .Ref.DateModified = Now
            'End With

            'If Not ClsWardDiagnosis.AddNewWardDiagnosis(ClsWardDiagnosis, DbConn, DbTrans) Then
            '    MsgBox("Failed to create ward diagnosis.", MsgBoxStyle.Critical, "Create Ward Diagnosis Error")
            '    DbTrans.Rollback()
            '    DbTrans.Dispose()
            '    DbTrans = Nothing
            '    Return False
            'End If

            'Add ward diagnose detail
            If DgvSelectedTest.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedTest.Rows.Count - 1

                    With ClsWardDiagnosisDetail
                        .WardID = IIf(WardID <> "", WardID, Trim(TxtWardID.Text))
                        .WardDate = CDate(TxtWardDate.Text)
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

                        If Not .AddNewWardDiagnosisDetail(ClsWardDiagnosisDetail, DbConn, DbTrans) Then
                            MsgBox("Failed to create ward diagnosis details.", MsgBoxStyle.Critical, "Create Ward Diagnosis Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

            End If

            'Add ward treatment
            If DgvSelectedTreatment.Rows.Count > 0 Then

                'Dim PhRequestID As String = ""
                'PhRequestID = IIf(CStrNull(DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value) <> "",
                '                  CStrNull(DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value),
                '                  GenerateRunningNo("RQ", DbConn, DbTrans, ""))

                'If PhRequestID = "" Then
                '    MsgBox("Failed to create pharmacy request ID .", MsgBoxStyle.Critical, "Pharmacy Request ID Error")
                '    DbTrans.Rollback()
                '    DbTrans.Dispose()
                '    DbTrans = Nothing
                '    Return False
                'End If

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    With ClsWardTreatment
                        .WardID = IIf(WardID <> "", WardID, Trim(TxtWardID.Text))
                        .WardDate = CDate(TxtWardDate.Text)
                        .PhRequestID = DgvSelectedTreatment.Rows(i).Cells("TreatmentPhRequestID").Value '"" 'PhRequestID
                        .RowNo = i + 1
                        .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                        .ItemGroup = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                        .ItemTypeCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value
                        .Prescription = CStrNull(DgvSelectedTreatment.Rows(i).Cells("TreatmentPrescription").Value)
                        .Notes = CStrNull(DgvSelectedTreatment.Rows(i).Cells("TreatmentNotes").Value)
                        .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                        .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                        .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewWardTreatment(ClsWardTreatment, DbConn, DbTrans) Then
                            MsgBox("Failed to create ward diagnosis details.", MsgBoxStyle.Critical, "Create Ward Diagnosis Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

                'If pharmacy request ID already exists; dont update request
                'If Not SendRequestToPharmacyWardTx(PhRequestID, "TX") Then
                '    MsgBox("Failed to create pharmacy request.", MsgBoxStyle.Critical, "Ward Treatment Pharmacy Request Error")
                '    DbTrans.Rollback()
                '    DbTrans.Dispose()
                '    DbTrans = Nothing
                '    Return False
                'End If

            End If

            'Add ward hourly checking and medication
            Dim ClsWardHourly As New ClsWardHourly
            If DgvHourlyList.Rows.Count > 0 Then

                For i As Integer = 0 To DgvHourlyList.Rows.Count - 1

                    With ClsWardHourly
                        .WardID = IIf(WardID <> "", WardID, Trim(TxtWardID.Text))
                        .RowNo = i + 1
                        .WardDate = DgvHourlyList.Rows(i).Cells("HourlyWardTime").Value
                        .EmployeeID = DgvHourlyList.Rows(i).Cells("HourlyEmployeeID").Value
                        .EmployeeName = DgvHourlyList.Rows(i).Cells("HourlyEmployeeName").Value
                        .HourlyNotes = DgvHourlyList.Rows(i).Cells("HourlyHourlyNotes").Value
                        .Ref.CreatedBy = DgvHourlyList.Rows(i).Cells("HourlyCreatedBy").Value
                        .Ref.DateCreated = DgvHourlyList.Rows(i).Cells("HourlyDateCreated").Value
                        .Ref.ModifiedBy = DgvHourlyList.Rows(i).Cells("HourlyModifiedBy").Value
                        .Ref.DateModified = DgvHourlyList.Rows(i).Cells("HourlyDateModified").Value

                        If Not .AddNewWardHourly(ClsWardHourly, DbConn, DbTrans) Then
                            MsgBox("Failed to update ward hourly details.", MsgBoxStyle.Critical, "Ward Hourly Update Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

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

            MsgBox("Ward progress has been updated!", MsgBoxStyle.Information, "Ward Progress Updated")
            PopulateForm()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveWardToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function DischargePet() As Boolean

        Dim UserResponse As MsgBoxResult

        Try
            UserResponse = MsgBox("Are sure you want to discharge this pet? Your action cannot be undone.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Discharge Pet?")
            If UserResponse = MsgBoxResult.Yes Then

                If DbTrans IsNot Nothing Then
                    DbTrans = Nothing
                End If

                DbTrans = DbConn.BeginTransaction

                'Calculate ward duration and update to ward header
                If Not CalculateWardDuration(DbConn, DbTrans) Then
                    MsgBox("Failed to update discharge status and ward duration.", MsgBoxStyle.Critical, "Discharge Status Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

                'Check and calculate ward duration, insert data to ward_discharge, ward_dischargemedication
                Dim ClsWardDischarge As New ClsWardDischarge
                Dim ClsWardDischargeMedication As New ClsWardDischargeDetail

                With ClsWardDischarge
                    .WardID = TxtWardID.Text
                    .DischargeDate = Now
                    .AdmitIssue = Trim(TxtAdmitIssue.Text)
                    .AdmitDiagnosis = Trim(TxtAdmitDiagnosis.Text)
                    .TreatmentSummary = Trim(TxtTreatmentSummary.Text)
                    .DischargeCondition = Trim(TxtDischargeCondition.Text)
                    .DischargeReason = Trim(TxtDischargeReason.Text)
                    .PossibleComplications = Trim(TxtPossibleComplications.Text)
                    .AdditionalInstruction = Trim(TxtAdditionalInstructions.Text)
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now

                    If Not .AddNewWardDischarge(ClsWardDischarge, DbConn, DbTrans) Then
                        MsgBox("Failed to update ward discharge details.", MsgBoxStyle.Critical, "Ward Discharge Update Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                End With

                If DgvDischargeMedication.Rows.Count > 0 Then

                    Dim PhRequestID As String = ""
                    PhRequestID = IIf(CStrNull(DgvDischargeMedication.Rows(0).Cells("DiscMedPhRequestID").Value) <> "",
                                  DgvDischargeMedication.Rows(0).Cells("DiscMedPhRequestID").Value,
                                  GenerateRunningNo("RQ", DbConn, DbTrans, ""))

                    If PhRequestID = "" Then
                        MsgBox("Failed to create pharmacy request ID .", MsgBoxStyle.Critical, "Pharmacy Request ID Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                    For i As Integer = 0 To DgvDischargeMedication.Rows.Count - 1

                        ClsWardDischargeMedication = New ClsWardDischargeDetail
                        With ClsWardDischargeMedication
                            .WardID = TxtWardID.Text
                            .DischargeDate = Now
                            .PhRequestID = PhRequestID
                            .RowNo = DgvDischargeMedication.Rows(i).Cells("DiscMedRowNo").Value
                            .ItemCode = DgvDischargeMedication.Rows(i).Cells("DiscMedItemCode").Value
                            .ItemDescription = DgvDischargeMedication.Rows(i).Cells("DiscMedItemDescription").Value
                            .ItemGroup = DgvDischargeMedication.Rows(i).Cells("DiscMedItemGroup").Value
                            .ItemTypeCode = DgvDischargeMedication.Rows(i).Cells("DiscMedItemTypeCode").Value
                            .ItemTypeDescription = DgvDischargeMedication.Rows(i).Cells("DiscMedItemTypeDescription").Value
                            .Prescription = DgvDischargeMedication.Rows(i).Cells("DiscMedPrescription").Value
                            .Notes = DgvDischargeMedication.Rows(i).Cells("DiscMedNotes").Value
                            .UnitPrice = DgvDischargeMedication.Rows(i).Cells("DiscMedUnitPrice").Value
                            .Quantity = DgvDischargeMedication.Rows(i).Cells("DiscMedQuantity").Value
                            .TotalPrice = DgvDischargeMedication.Rows(i).Cells("DiscMedTotalPrice").Value
                            .Ref.CreatedBy = CURR_USER
                            .Ref.DateCreated = Now
                            .Ref.ModifiedBy = CURR_USER
                            .Ref.DateModified = Now

                            If Not .AddNewWardDischargeMedication(ClsWardDischargeMedication, DbConn, DbTrans) Then
                                MsgBox("Failed to update ward discharge medication.", MsgBoxStyle.Critical, "Ward Discharge Medication Update Error")
                                DbTrans.Rollback()
                                DbTrans.Dispose()
                                DbTrans = Nothing
                                Return False
                            End If

                        End With

                    Next

                    'If pharmacy request ID already exists; dont update request
                    'If Not SendRequestToPharmacyWardDc(PhRequestID, "DC") Then
                    '    MsgBox("Failed to update pharmacy request.", MsgBoxStyle.Critical, "Ward Discharge Pharmacy Request Error")
                    '    DbTrans.Rollback()
                    '    DbTrans.Dispose()
                    '    DbTrans = Nothing
                    '    Return False
                    'End If

                End If

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            ' MsgBox("Admission Date : " & ActualAD & Environment.NewLine &
            '"Discharge Date : " & ActualDD & Environment.NewLine &
            '"Ward Duration : " & WardDuration)

            CbIsDischarged.Checked = True
            CbIsDischarged.Enabled = False
            MsgBox("Your selected pet has been successfully discharged!", MsgBoxStyle.Information, "Pet Discharge Completed")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DischargePet()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function CalculateWardDuration(DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean

        Try
            'Set fixed AdmissionDate & DischargeDate
            Dim StrFixedAD As String = CDate(TxtAdmissionDate.Text).Date.ToShortDateString & " 12:00:00"
            Dim StrFixedDD As String = Now.Date.ToShortDateString & " 12:00:00"
            Dim FixedAD As Date = CDate(StrFixedAD)
            Dim FixedDD As Date = CDate(StrFixedDD)
            Dim FixDuration As TimeSpan

            'Get actual admission date & actual discharge date
            Dim ActualAD As Date = CDate(TxtAdmissionDate.Text)
            Dim ActualDD As Date = IIf(TxtDischargeDate.Text <> "", TxtDischargeDate.Text, Now)

            FixDuration = FixedDD - FixedAD
            Dim WardDuration As Integer = FixDuration.Days

            If ActualDD > FixedDD Then
                WardDuration = WardDuration + 1
            End If

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
                    Return False
                End If

            End With

            TxtDischargeDate.Text = ActualDD

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CalculateWardDuration()")
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
            'ClsBill.VisitID = Trim(TxtVisitID.Text)
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
            'ClsWardDiagnosis.VisitID = Trim(TxtVisitID.Text)
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
            'ClsWardTreatment.VisitID = Trim(TxtVisitID.Text)
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
                    .VisitID = WardID
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

        Try
            If TxtWardID.Text = "" Then
                MsgBox("Please select customer visit to save ward information.", MsgBoxStyle.Exclamation, "Ward ID Missing")
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

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
                    {"0", "NO"},
                    {"1", "YES"}
                }
                .DataSource = New BindingSource(CmbSource, Nothing)
                .DisplayMember = "Value"
                .ValueMember = "Key"
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateDPE()")
        End Try

    End Sub

    Private Function AddTest() As Boolean

        Dim DtTest As New DataTable

        Try
            If TxtTestItem.Tag = "" Then
                Return False
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
            Return False
        End Try

        Return True

    End Function

    Private Function AddTreatment() As Boolean

        Dim DtTreatment As New DataTable

        Try
            'Check user input
            If TxtTreatmentItem.Tag = "" Then
                Return False
            End If

            If DgvSelectedTreatment.Rows.Count > 0 Then
                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1
                    If TxtTreatmentItem.Tag = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value Then
                        MsgBox("You are trying to add same item into the list.", MsgBoxStyle.Exclamation, "Duplicate Entry")
                        Return False
                    End If
                Next
            End If

            DtTreatment = InitSelectedItemDt()
            If DgvSelectedTreatment.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    Dim DgvRow As DataRow = DtTreatment.NewRow

                    DgvRow("PhRequestID") = DgvSelectedTreatment.Rows(i).Cells("TreatmentPhRequestID").Value
                    DgvRow("RowNo") = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                    DgvRow("Prescription") = DgvSelectedTreatment.Rows(i).Cells("TreatmentPrescription").Value
                    DgvRow("Notes") = DgvSelectedTreatment.Rows(i).Cells("TreatmentNotes").Value
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

            Row("Prescription") = Trim(TxtTreatmentPrescription.Text)
            Row("Notes") = Trim(TxtTreatmentNotes.Text)

            Row("UnitPrice") = UCase(Trim(TxtTreatmentUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtTreatmentQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtTreatmentTotalPrice.Text) * CDec(TxtTreatmentQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode

            Row("PhRequestID") = DtTreatment.Rows(0).Item("PhRequestID")

            DtTreatment.Rows.Add(Row)

            If DtTreatment.Rows.Count > 0 Then

                DgvSelectedTreatment.Rows.Clear()

                For i As Integer = 0 To DtTreatment.Rows.Count - 1
                    With DgvSelectedTreatment
                        .Rows.Add()
                        .Rows(i).Cells("TreatmentPhRequestID").Value = DtTreatment.Rows(i).Item("PhRequestID")
                        .Rows(i).Cells("TreatmentRowNo").Value = DtTreatment.Rows(i).Item("RowNo")
                        .Rows(i).Cells("TreatmentItemCode").Value = DtTreatment.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("TreatmentItemDescription").Value = DtTreatment.Rows(i).Item("ItemDescription")

                        .Rows(i).Cells("TreatmentPrescription").Value = DtTreatment.Rows(i).Item("Prescription")
                        .Rows(i).Cells("TreatmentNotes").Value = DtTreatment.Rows(i).Item("Notes")

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
            TxtTreatmentPrescription.Text = ""
            TxtTreatmentNotes.Text = ""
            TxtTreatmentUnitPrice.Text = "0.00"
            TxtTreatmentQuantity.Text = "1.00"
            TxtTreatmentTotalPrice.Text = "0.00"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddTreatment()")
            Return False
        End Try

        Return True

    End Function

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
                .Columns.Add("PhRequestID", GetType(String))
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
                WardID = .VisitID
                CustomerID = .CustomerID
                CustomerName = .CustomerName
                PetID = .PetID
                PetName = .PetName
                UserCommand = IIf(.VisitID <> "", "ADD_NEW_WARD", "")

                TxtWardID.Text = WardID
                TxtWardID.Tag = WardID
                TxtCustomerName.Text = CustomerName
                TxtCustomerName.Tag = CustomerID
                TxtPetName.Text = PetName
                TxtPetName.Tag = PetID
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
    End Sub

    Private Sub BtnAddTest_Click(sender As Object, e As EventArgs) Handles BtnAddTest.Click
        If Not AddTest() Then Exit Sub
    End Sub

    Private Sub BtnTreatmentItem_Click(sender As Object, e As EventArgs) Handles BtnTreatmentItem.Click
        If BtnTreatmentItem.Tag = "UPDATE" Then
            If Not UpdateTreatment() Then Exit Sub
        Else
            If Not AddTreatment() Then Exit Sub
        End If
    End Sub

    Private Sub BtnClearTest_Click(sender As Object, e As EventArgs) Handles BtnClearTest.Click
        TxtTestItem.Text = ""
        TxtTestItem.Tag = ""
    End Sub

    Private Sub BtnClearTreatment_Click(sender As Object, e As EventArgs) Handles BtnClearTreatment.Click
        TxtTreatmentItem.Text = ""
        TxtTreatmentItem.Tag = ""
    End Sub

    'Private Sub CbIsDischarged_Click(sender As Object, e As EventArgs)
    '    'If Not DischargePet() Then Exit Sub
    'End Sub

    Private Sub DgvWardSummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvWardSummary.CellDoubleClick

        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Exit Sub
            Else
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    Dim Frm As New FrmWardSummary With {
                        .WardID = TxtWardID.Text,
                        .CustomerID = TxtCustomerName.Tag,
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Try
        '    'Set fixed AdmissionDate & DischargeDate
        '    Dim StrFixedAD As String = CDate(TxtAD.Text).Date.ToShortDateString & " 12:00:00"
        '    Dim StrFixedDD As String = CDate(TxtDD.Text).Date.ToShortDateString & " 12:00:00"

        '    Dim FixedAD As Date = CDate(StrFixedAD)
        '    Dim FixedDD As Date = CDate(StrFixedDD)

        '    Dim FixDuration As TimeSpan

        '    'Get actual admission date & actual discharge date
        '    Dim ActualAD As Date = CDate(TxtAD.Text) '"19/10/2018 13:00:00"
        '    Dim ActualDD As Date = CDate(TxtDD.Text) '"20/10/2018 12:01:00"

        '    FixDuration = FixedDD - FixedAD
        '    Dim WardDuration As Integer = FixDuration.Days

        '    If ActualDD > FixedDD Then
        '        WardDuration = WardDuration + 1
        '    End If

        '    MsgBox("Admission Date : " & ActualAD & Environment.NewLine &
        '           "Discharge Date : " & ActualDD & Environment.NewLine &
        '           "Ward Duration : " & WardDuration)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub BtnBillPayment_Click(sender As Object, e As EventArgs)
        'With FrmPaymentInformation
        '    .InvoiceNo = BtnBillPayment.Tag
        '    .UserCommand = "SHOW_BILLING_INFO"
        '    .ShowDialog()
        'End With
    End Sub

    Private Sub BtnAddHourlyNotes_Click(sender As Object, e As EventArgs) Handles BtnAddHourlyNotes.Click
        If Not AddHourlyCheck() Then Exit Sub
    End Sub

    Private Function AddHourlyCheck() As Boolean

        Try
            Dim DtHourly As New DataTable

            'Check if user trying to spam entry
            If DgvHourlyList.Rows.Count > 0 Then
                For i As Integer = 0 To DgvHourlyList.Rows.Count - 1
                    If TxtWardHourlyTime.Text = DgvHourlyList.Rows(i).Cells("HourlyWardTime").Value Then
                        Return False
                    End If
                Next
            End If

            DtHourly = InitWardHourlyDt()

            If DgvHourlyList.Rows.Count > 0 Then

                For i As Integer = 0 To DgvHourlyList.Rows.Count - 1

                    Dim Row As DataRow = DtHourly.NewRow

                    Row("WardID") = DgvHourlyList.Rows(i).Cells("HourlyWardID").Value
                    Row("WardTime") = DgvHourlyList.Rows(i).Cells("HourlyWardTime").Value
                    Row("EmployeeID") = DgvHourlyList.Rows(i).Cells("HourlyEmployeeID").Value
                    Row("EmployeeName") = DgvHourlyList.Rows(i).Cells("HourlyEmployeeName").Value
                    Row("HourlyNotes") = DgvHourlyList.Rows(i).Cells("HourlyHourlyNotes").Value
                    Row("CreatedBy") = DgvHourlyList.Rows(i).Cells("HourlyCreatedBy").Value
                    Row("DateCreated") = DgvHourlyList.Rows(i).Cells("HourlyDateCreated").Value
                    Row("ModifiedBy") = DgvHourlyList.Rows(i).Cells("HourlyModifiedBy").Value
                    Row("DateModified") = DgvHourlyList.Rows(i).Cells("HourlyDateModified").Value

                    DtHourly.Rows.Add(Row)

                Next

            End If

            Dim NewRow As DataRow = DtHourly.NewRow

            NewRow("WardID") = "" 'TxtVisitID.Text
            NewRow("WardTime") = CDate(TxtWardHourlyTime.Text)
            NewRow("EmployeeID") = UCase(Trim(TxtVet.Tag))
            NewRow("EmployeeName") = UCase(Trim(TxtVet.Text))
            NewRow("HourlyNotes") = Trim(TxtHourlyNotes.Text)
            NewRow("CreatedBy") = CURR_USER
            NewRow("DateCreated") = Now
            NewRow("ModifiedBy") = CURR_USER
            NewRow("DateModified") = Now

            DtHourly.Rows.Add(NewRow)

            If DtHourly.Rows.Count > 0 Then

                DgvHourlyList.Rows.Clear()

                For i As Integer = 0 To DtHourly.Rows.Count - 1

                    With DgvHourlyList
                        .Rows.Add()
                        .Rows(i).Cells("HourlyWardID").Value = DtHourly.Rows(i).Item("WardID")
                        .Rows(i).Cells("HourlyWardTime").Value = DtHourly.Rows(i).Item("WardTime")
                        .Rows(i).Cells("HourlyEmployeeID").Value = DtHourly.Rows(i).Item("EmployeeID")
                        .Rows(i).Cells("HourlyEmployeeName").Value = DtHourly.Rows(i).Item("EmployeeName")
                        .Rows(i).Cells("HourlyHourlyNotes").Value = DtHourly.Rows(i).Item("HourlyNotes")
                        .Rows(i).Cells("HourlyCreatedBy").Value = DtHourly.Rows(i).Item("CreatedBy")
                        .Rows(i).Cells("HourlyDateCreated").Value = DtHourly.Rows(i).Item("DateCreated")
                        .Rows(i).Cells("HourlyModifiedBy").Value = DtHourly.Rows(i).Item("ModifiedBy")
                        .Rows(i).Cells("HourlyDateModified").Value = DtHourly.Rows(i).Item("DateModified")
                    End With

                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddHourlyCheck()")
            Return False
        End Try

        Return True

    End Function

    Private Function InitWardHourlyDt() As DataTable

        Dim DtHourly As New DataTable

        Try
            With DtHourly
                .Columns.Add("WardID", GetType(String))
                .Columns.Add("WardTime", GetType(DateTime))
                .Columns.Add("EmployeeID", GetType(String))
                .Columns.Add("EmployeeName", GetType(String))
                .Columns.Add("HourlyNotes", GetType(String))
                .Columns.Add("CreatedBy", GetType(String))
                .Columns.Add("DateCreated", GetType(DateTime))
                .Columns.Add("ModifiedBy", GetType(String))
                .Columns.Add("DateModified", GetType(DateTime))
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitWardHourlyDt()")
        End Try

        Return DtHourly

    End Function

    Private Sub BtnSearchDiscMediItem_Click(sender As Object, e As EventArgs) Handles BtnSearchDiscMediItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtDischargeItem.Tag = .ItemCode
            TxtDischargeItem.Text = .ItemDescription
            TxtDischargeUnitPrice.Text = .UnitPrice
            TxtDischargeTotalPrice.Text = FormatNumber(.UnitPrice * CDec(TxtTreatmentQuantity.Text), 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnAddDischargeItem_Click(sender As Object, e As EventArgs) Handles BtnAddDischargeItem.Click
        'AddDischargeMedication()
        If BtnAddDischargeItem.Tag = "UPDATE" Then
            If Not UpdateDischargeMedication() Then Exit Sub
        Else
            If Not AddDischargeMedication() Then Exit Sub
        End If
    End Sub

    Private Function CheckFields(FieldSource As String) As Boolean

        Try
            Select Case FieldSource
                Case "DISCMED"
                    If TxtWardID.Text = "" Then
                        MsgBox("Please select customer visit.", MsgBoxStyle.Exclamation, "No Customer Visit Selected")
                        Return False
                    End If

                    If TxtDischargeItem.Tag = "" Then
                        Return False
                    End If

                    If DgvDischargeMedication.Rows.Count > 0 Then
                        For i As Integer = 0 To DgvDischargeMedication.Rows.Count - 1

                            If TxtTreatmentItem.Tag = DgvDischargeMedication.Rows(i).Cells("DiscMedItemCode").Value Then
                                MsgBox("You are trying to add same item(s) to the list. Update selected item quantity's instead.", MsgBoxStyle.Exclamation, "Duplicate Item")
                                Return False
                            End If
                        Next
                    End If

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckFields()")
            Return False
        End Try

        Return True

    End Function

    Private Function AddDischargeMedication() As Boolean

        Dim DtMedication As New DataTable

        Try
            If Not CheckFields() Then Return False

            DtMedication = InitSelectedItemDt()
            If DgvDischargeMedication.Rows.Count > 0 Then

                For i As Integer = 0 To DgvDischargeMedication.Rows.Count - 1

                    Dim DgvRow As DataRow = DtMedication.NewRow

                    DgvRow("PhRequestID") = DgvDischargeMedication.Rows(i).Cells("DiscMedPhRequestID").Value
                    DgvRow("RowNo") = DgvDischargeMedication.Rows(i).Cells("DiscMedRowNo").Value
                    DgvRow("ItemCode") = DgvDischargeMedication.Rows(i).Cells("DiscMedItemCode").Value
                    DgvRow("ItemDescription") = DgvDischargeMedication.Rows(i).Cells("DiscMedItemDescription").Value
                    DgvRow("Prescription") = DgvDischargeMedication.Rows(i).Cells("DiscMedPrescription").Value
                    DgvRow("Notes") = DgvDischargeMedication.Rows(i).Cells("DiscMedNotes").Value
                    DgvRow("Quantity") = DgvDischargeMedication.Rows(i).Cells("DiscMedQuantity").Value
                    DgvRow("UnitPrice") = DgvDischargeMedication.Rows(i).Cells("DiscMedUnitPrice").Value
                    DgvRow("TotalPrice") = DgvDischargeMedication.Rows(i).Cells("DiscMedTotalPrice").Value
                    DgvRow("ItemGroup") = DgvDischargeMedication.Rows(i).Cells("DiscMedItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvDischargeMedication.Rows(i).Cells("DiscMedItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvDischargeMedication.Rows(i).Cells("DiscMedItemTypeDescription").Value

                    DtMedication.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtMedication.NewRow

            Row("RowNo") = IIf(DtMedication.Rows.Count = 0, 1, DtMedication.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtDischargeItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtDischargeItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtDischargeUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtDischargeQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtDischargeTotalPrice.Text) * CDec(TxtDischargeQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode

            DtMedication.Rows.Add(Row)

            If DtMedication.Rows.Count > 0 Then

                DgvDischargeMedication.Rows.Clear()

                For i As Integer = 0 To DtMedication.Rows.Count - 1
                    With DgvDischargeMedication
                        .Rows.Add()
                        .Rows(i).Cells("DiscMedPhRequestID").Value = DtMedication.Rows(i).Item("PhRequestID")
                        .Rows(i).Cells("DiscMedRowNo").Value = DtMedication.Rows(i).Item("RowNo")
                        .Rows(i).Cells("DiscMedItemCode").Value = DtMedication.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("DiscMedItemDescription").Value = DtMedication.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("DiscMedUnitPrice").Value = DtMedication.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("DiscMedQuantity").Value = DtMedication.Rows(i).Item("Quantity")
                        .Rows(i).Cells("DiscMedTotalPrice").Value = DtMedication.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("DiscMedItemGroup").Value = DtMedication.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("DiscMedItemTypeCode").Value = DtMedication.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("DiscMedItemTypeDescription").Value = DtMedication.Rows(i).Item("ItemTypeDescription")
                    End With
                Next

            End If

            TxtDischargeItem.Text = ""
            TxtDischargeItem.Tag = ""
            TxtDischargePrescription.Text = ""
            TxtDischargeNotes.Text = ""
            TxtDischargeUnitPrice.Text = "0.00"
            TxtDischargeQuantity.Text = "1.00"
            TxtDischargeTotalPrice.Text = "0.00"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddDischargeMedication()")
            Return False
        End Try

        Return True

    End Function

    Private Function UpdateDischargeMedication() As Boolean

        Try
            Dim RowIndex As Integer = CInt(LblDiscMedRowNo.Text)

            With DgvDischargeMedication
                .Rows(RowIndex).Cells("DiscMedItemCode").Value = Trim(TxtDischargeItem.Tag)
                .Rows(RowIndex).Cells("DiscMedItemDescription").Value = Trim(TxtDischargeItem.Text)
                .Rows(RowIndex).Cells("DiscMedPrescription").Value = Trim(TxtDischargePrescription.Text)
                .Rows(RowIndex).Cells("DiscMedNotes").Value = Trim(TxtDischargeNotes.Text)
                .Rows(RowIndex).Cells("DiscMedUnitPrice").Value = Trim(TxtDischargeUnitPrice.Text)
                .Rows(RowIndex).Cells("DiscMedQuantity").Value = Trim(TxtDischargeQuantity.Text)
                .Rows(RowIndex).Cells("DiscMedTotalPrice").Value = Trim(TxtDischargeTotalPrice.Text)
            End With

            TxtDischargeItem.Text = ""
            TxtDischargeItem.Tag = ""
            TxtDischargePrescription.Text = ""
            TxtDischargeNotes.Text = ""
            TxtDischargeUnitPrice.Text = ""
            TxtDischargeQuantity.Text = ""
            TxtDischargeTotalPrice.Text = ""

            BtnAddDischargeItem.Text = "Add Item"
            BtnAddDischargeItem.Tag = ""

            MsgBox("Selected item has been updated!", MsgBoxStyle.Information, "Item Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateDischargeMedication()")
            Return False
        End Try

        Return True

    End Function

    Private Sub DgvSelectedTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedTest.CellContentClick

        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                UserResponse = MsgBox("Are sure you want to delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Item?")
                If UserResponse = MsgBoxResult.Yes Then

                    With DgvSelectedTest

                        .Rows.RemoveAt(e.RowIndex)

                        TxtTestItem.Tag = ""
                        TxtTestItem.Text = ""
                        TxtTestUnitPrice.Text = "0.00"
                        TxtTestQuantity.Text = "1.00"
                        TxtTestTotalPrice.Text = "0.00"

                    End With

                Else
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvBillListing_CellContentClick()")
        End Try

    End Sub

    Private Sub DgvSelectedTreatment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedTreatment.CellContentClick

        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Item?")
                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvSelectedTreatment

                            .Rows.RemoveAt(e.RowIndex)

                            TxtTreatmentItem.Text = ""
                            TxtTreatmentItem.Tag = ""
                            TxtTreatmentPrescription.Text = ""
                            TxtTreatmentNotes.Text = ""
                            TxtTreatmentUnitPrice.Text = "0.00"
                            TxtTreatmentQuantity.Text = "1.00"
                            TxtTreatmentTotalPrice.Text = "0.00"

                        End With

                    Else
                        Exit Sub
                    End If

                ElseIf e.ColumnIndex = 1 Then

                    With DgvSelectedTreatment

                        BtnTreatmentItem.Tag = "UPDATE"
                        BtnTreatmentItem.Text = "Update Item"
                        LblTreatmentRowNo.Text = e.RowIndex

                        TxtTreatmentItem.Text = .Rows(e.RowIndex).Cells("TreatmentItemDescription").Value
                        TxtTreatmentItem.Tag = .Rows(e.RowIndex).Cells("TreatmentItemCode").Value
                        TxtTreatmentPrescription.Text = .Rows(e.RowIndex).Cells("TreatmentPrescription").Value
                        TxtTreatmentNotes.Text = .Rows(e.RowIndex).Cells("TreatmentNotes").Value
                        TxtTreatmentUnitPrice.Text = .Rows(e.RowIndex).Cells("TreatmentUnitPrice").Value
                        TxtTreatmentQuantity.Text = .Rows(e.RowIndex).Cells("TreatmentQuantity").Value
                        TxtTreatmentTotalPrice.Text = .Rows(e.RowIndex).Cells("TreatmentTotalPrice").Value

                    End With

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvBillListing_CellContentClick()")
        End Try

    End Sub

    Private Function UpdateTreatment() As Boolean

        Try
            With DgvSelectedTreatment
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentItemCode").Value = TxtTreatmentItem.Tag
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentItemDescription").Value = TxtTreatmentItem.Text
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentPrescription").Value = TxtTreatmentPrescription.Text
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentNotes").Value = TxtTreatmentNotes.Text
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentUnitPrice").Value = TxtTreatmentUnitPrice.Text
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentQuantity").Value = TxtTreatmentQuantity.Text
                .Rows(CInt(LblTreatmentRowNo.Text)).Cells("TreatmentTotalPrice").Value = TxtTreatmentTotalPrice.Text
            End With

            BtnTreatmentItem.Tag = ""
            BtnTreatmentItem.Text = "Add Item"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateTreatment()")
            Return False
        End Try

        Return True

    End Function



    Private Sub BtnNewWardTime_Click(sender As Object, e As EventArgs) Handles BtnNewWardTime.Click
        TxtWardHourlyTime.Text = Now
        TxtVet.Tag = CURR_EMPLOYEE_ID
        TxtVet.Text = CURR_EMPLOYEE_NAME
        TxtHourlyNotes.Text = ""
    End Sub

    Private Sub DgvHourlyList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHourlyList.CellClick

        Try
            If e.RowIndex > -1 Then
                With DgvHourlyList
                    TxtWardHourlyTime.Text = .Rows(e.RowIndex).Cells("HourlyWardTime").Value
                    TxtVet.Text = .Rows(e.RowIndex).Cells("HourlyEmployeeName").Value
                    TxtVet.Tag = .Rows(e.RowIndex).Cells("HourlyEmployeeID").Value
                    TxtHourlyNotes.Text = .Rows(e.RowIndex).Cells("HourlyHourlyNotes").Value
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvHourlyList_CellClick()")
        End Try

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintWard()
    End Sub

    Private Sub PrintWard()

        Try
            If TxtWardID.Text = "" Then
                MsgBox("Please select your ward to print.", MsgBoxStyle.Critical, "No Ward Loaded")
                Exit Sub
            End If

            Process.Start(My.Application.Info.DirectoryPath & "/WardReport.exe", Trim(TxtWardID.Text))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PrintWard")
        End Try

    End Sub

    Private Sub BtnSendToPharmacyWardTx_Click(sender As Object, e As EventArgs) Handles BtnSendToPharmacyWardTx.Click
        If Not SendRequestToPharmacy("TX") Then Exit Sub
    End Sub

    Private Sub BtnSendToPharmacyWardDisc_Click(sender As Object, e As EventArgs) Handles BtnSendToPharmacyWardDc.Click
        If Not SendRequestToPharmacy("DC") Then Exit Sub
    End Sub

    Private Function SendRequestToPharmacy(Source As String) As Boolean

        Try
            Dim UserResponse As MsgBoxResult
            UserResponse = MsgBox("Are sure you want to send request to pharmacy?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Send Request To Pharmacy?")

            If UserResponse = MsgBoxResult.Yes Then

                Select Case Source

                    Case "TX"  'WARD-TX -- WARD TREATMENT

                        If Not SendRequestToPharmacyWardTx(Source) Then Return False

                    Case "DC" 'WARD-DISC -- WARD DISCHARGE

                        If Not SendRequestToPharmacyWardDc(Source) Then Return False

                End Select

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SendRequestToPharmacy()")
            Return False
        End Try

        Return True

    End Function

    Private Function SendRequestToPharmacyWardTx(Src As String) As Boolean

        Try
            Dim PhRequestID As String

            If Not ValidatePharmacyRequestUpdate() Then Return True
            'If Not SaveWardToDb() Then Return False

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            PhRequestID = IIf(CStrNull(DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value) <> "",
                              CStrNull(DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value),
                              GenerateRunningNo("RQ", DbConn, DbTrans, ""))

            If PhRequestID = "" Then
                MsgBox("Failed to create pharmacy request ID .", MsgBoxStyle.Critical, "Pharmacy Request ID Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            Dim ClsPharmacy As New ClsPharmacy
            With ClsPharmacy
                .RequestID = PhRequestID
                .VisitID = TxtWardID.Text
                .RequestDate = Now
                .Source = FORM_SOURCE & Src
                .RqEmpID = CURR_EMPLOYEE_ID
                .RqEmpName = CURR_EMPLOYEE_NAME
                .PhEmpID = ""
                .PhEmpName = ""
                .ApprovalDate = Nothing
                .IsCompleted = IIf(CStrNull(DgvSelectedTreatment.Rows(0).Cells("TreatmentPhRequestID").Value) <> "", "1", "0")
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewPharmacyRequest(ClsPharmacy, DbConn, DbTrans) Then
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            'Ward Treatment
            Dim ClsPharmacyDetail As New ClsPharmacyDetail
            If DgvSelectedTreatment.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedTreatment.Rows.Count - 1

                    ClsPharmacyDetail = New ClsPharmacyDetail
                    With ClsPharmacyDetail
                        .RequestID = PhRequestID
                        .VisitID = TxtWardID.Text
                        .RowNo = DgvSelectedTreatment.Rows(i).Cells("TreatmentRowNo").Value
                        .ItemCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemCode").Value
                        .ItemDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemDescription").Value
                        .ItemGroup = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemGroup").Value
                        .ItemTypeCode = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedTreatment.Rows(i).Cells("TreatmentItemTypeDescription").Value
                        .Prescription = CStrNull(DgvSelectedTreatment.Rows(i).Cells("TreatmentPrescription").Value)
                        .Notes = CStrNull(DgvSelectedTreatment.Rows(i).Cells("TreatmentNotes").Value)
                        .UnitPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentUnitPrice").Value
                        .Quantity = DgvSelectedTreatment.Rows(i).Cells("TreatmentQuantity").Value
                        .TotalPrice = DgvSelectedTreatment.Rows(i).Cells("TreatmentTotalPrice").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewPharmacyRequestDetail(ClsPharmacyDetail, DbConn, DbTrans) Then
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            With DgvSelectedTreatment

                For i As Integer = 0 To .Rows.Count - 1

                    .Rows(i).Cells("TreatmentPhRequestID").Value = PhRequestID

                Next

            End With

            MsgBox("Your pharmacy request has been successfully sent!", MsgBoxStyle.Information, "Pharmacy Request Sent")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SendRequestToPharmacyWardTx()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function SendRequestToPharmacyWardDc(Src As String) As Boolean

        Try
            Dim PhRequestID As String

            If Not ValidatePharmacyRequestUpdate("DC") Then Return True

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            PhRequestID = IIf(CStrNull(DgvDischargeMedication.Rows(0).Cells("DiscMedPhRequestID").Value) <> "",
                              CStrNull(DgvDischargeMedication.Rows(0).Cells("DiscMedPhRequestID").Value),
                              GenerateRunningNo("RQ", DbConn, DbTrans, ""))

            If PhRequestID = "" Then
                MsgBox("Failed to create pharmacy request ID .", MsgBoxStyle.Critical, "Pharmacy Request ID Error")
                DbTrans.Rollback()
                DbTrans.Dispose()
                DbTrans = Nothing
                Return False
            End If

            'Ward Treatment
            Dim ClsPharmacy As New ClsPharmacy
            Dim ClsPharmacyDetail As New ClsPharmacyDetail

            If DgvDischargeMedication.Rows.Count > 0 Then

                With ClsPharmacy
                    .RequestID = PhRequestID
                    .VisitID = TxtWardID.Text
                    .RequestDate = Now
                    .Source = FORM_SOURCE & Src
                    .RqEmpID = CURR_EMPLOYEE_ID
                    .RqEmpName = CURR_EMPLOYEE_NAME
                    .PhEmpID = ""
                    .PhEmpName = ""
                    .ApprovalDate = Nothing
                    .IsCompleted = "0"
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now

                    If Not .AddNewPharmacyRequest(ClsPharmacy, DbConn, DbTrans) Then
                        MsgBox("Failed to update pharmacy request.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                End With

                For i As Integer = 0 To DgvDischargeMedication.Rows.Count - 1

                    ClsPharmacyDetail = New ClsPharmacyDetail
                    With ClsPharmacyDetail
                        .RequestID = PhRequestID
                        .VisitID = TxtWardID.Text
                        .RowNo = DgvDischargeMedication.Rows(i).Cells("DiscMedRowNo").Value
                        .ItemCode = DgvDischargeMedication.Rows(i).Cells("DiscMedItemCode").Value
                        .ItemDescription = DgvDischargeMedication.Rows(i).Cells("DiscMedItemDescription").Value
                        .ItemGroup = DgvDischargeMedication.Rows(i).Cells("DiscMedItemGroup").Value
                        .ItemTypeCode = DgvDischargeMedication.Rows(i).Cells("DiscMedItemTypeCode").Value
                        .ItemTypeDescription = DgvDischargeMedication.Rows(i).Cells("DiscMedItemTypeDescription").Value
                        .Prescription = DgvDischargeMedication.Rows(i).Cells("DiscMedPrescription").Value
                        .Notes = DgvDischargeMedication.Rows(i).Cells("DiscMedNotes").Value
                        .UnitPrice = DgvDischargeMedication.Rows(i).Cells("DiscMedUnitPrice").Value
                        .Quantity = DgvDischargeMedication.Rows(i).Cells("DiscMedQuantity").Value
                        .TotalPrice = DgvDischargeMedication.Rows(i).Cells("DiscMedTotalPrice").Value
                        .Ref.CreatedBy = CURR_USER
                        .Ref.DateCreated = Now
                        .Ref.ModifiedBy = CURR_USER
                        .Ref.DateModified = Now

                        If Not .AddNewPharmacyRequestDetail(ClsPharmacyDetail, DbConn, DbTrans) Then
                            MsgBox("Failed to update pharmacy request details.", MsgBoxStyle.Critical, "Pharmacy Request Update Error")
                            DbTrans.Rollback()
                            DbTrans.Dispose()
                            DbTrans = Nothing
                            Return False
                        End If

                    End With

                Next

            End If

            BtnSendToPharmacyWardDc.Tag = PhRequestID
            RequestID = PhRequestID

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            MsgBox("Your pharmacy request has been successfully sent!", MsgBoxStyle.Information, "Pharmacy Request Sent")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SendRequestToPharmacyWardDc()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function ValidatePharmacyRequestUpdate(Optional Src As String = "") As Boolean

        Try
            Select Case Src

                Case "TX"

                    If DgvSelectedTreatment.Rows.Count > 0 Then

                        With DgvSelectedTreatment

                            'Check if request has been made by checking request id in the record,
                            'if any one row of record not having request id then need to update request
                            For i As Integer = 0 To .Rows.Count - 1

                                If CStrNull(.Rows(i).Cells("TreatmentPhRequestID").Value) = "" Then

                                    'Keep looping records to check if any records that has not been requested
                                    'If found any then add/update to database
                                    Return True
                                Else
                                    'Use Return True to exit function; to bypass updating pharmacy request information
                                    Continue For
                                End If

                            Next

                            'Return False to disable from updating existing pharmacy information; means all item has been requested
                            Return False

                        End With

                    End If

                Case "DC"

                    'Check fields and request if already has been done
                    'If DgvDischargeMedication.Rows.Count = 0 Then
                    '    MsgBox("Please complete your medication list before requesting.", MsgBoxStyle.Exclamation, "No Medication Request Specified")
                    '    Return False
                    'End If

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".ValidatePharmacyRequestUpdate()")
            Return False
        End Try

        Return True

    End Function

    Private Sub DgvDischargeMedication_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDischargeMedication.CellContentClick

        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 0 Then

                    UserResponse = MsgBox("Are sure you want to update this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Item?")
                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvDischargeMedication

                            If .Rows(e.RowIndex).Cells("IsDiscMedDb").Value = "0" Or .Rows(e.RowIndex).Cells("IsDiscMedDb").Value = "" Then
                                .Rows.RemoveAt(e.RowIndex)
                            Else
                                MsgBox("Unable to delete item that has been saved into the database.", MsgBoxStyle.Exclamation, "Read-Only Item")
                            End If

                        End With

                    End If

                ElseIf e.ColumnIndex = 1 Then

                    'UserResponse = MsgBox("Are sure you want to update this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Item?")
                    'If UserResponse = MsgBoxResult.Yes Then

                    With DgvDischargeMedication

                        TxtDischargeItem.Text = .Rows(e.RowIndex).Cells("DiscMedItemDescription").Value
                        TxtDischargeItem.Tag = .Rows(e.RowIndex).Cells("DiscMedItemCode").Value
                        TxtDischargePrescription.Text = CStrNull(.Rows(e.RowIndex).Cells("DiscMedPrescription").Value)
                        TxtDischargeNotes.Text = CStrNull(.Rows(e.RowIndex).Cells("DiscMedNotes").Value)
                        TxtDischargeUnitPrice.Text = .Rows(e.RowIndex).Cells("DiscMedUnitPrice").Value
                        TxtDischargeQuantity.Text = .Rows(e.RowIndex).Cells("DiscMedQuantity").Value
                        TxtDischargeTotalPrice.Text = .Rows(e.RowIndex).Cells("DiscMedTotalPrice").Value

                    End With

                    BtnAddDischargeItem.Text = "Update Item"
                    BtnAddDischargeItem.Tag = "UPDATE"
                    LblDiscMedRowNo.Text = e.RowIndex

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvDischargeMedication_CellContentClick()")
        End Try

    End Sub

    Private Sub BtnDischargePet_Click(sender As Object, e As EventArgs) Handles BtnDischargePet.Click
        If Not DischargePet() Then Exit Sub
    End Sub

End Class