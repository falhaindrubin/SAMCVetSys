Imports SAMCVetSys.ModUtility

Public Class FrmWardSummary
#Region "FormProperty"
    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _WardID As String
    Public Property WardID As String
        Get
            Return _WardID
        End Get
        Set(value As String)
            _WardID = value
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

    Private _WardDate As Date
    Public Property WardDate As Date
        Get
            Return _WardDate
        End Get
        Set(value As Date)
            _WardDate = value
        End Set
    End Property

    Private _FormTitle As String
    Public Property FormTitle As String
        Get
            Return _FormTitle
        End Get
        Set(value As String)
            _FormTitle = value
        End Set
    End Property
#End Region

    Private Sub FrmWardSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        Me.Text = IIf(FormTitle <> "", FormTitle, Me.Text)
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        PopulateForm()
    End Sub

    Private Sub PopulateForm()

        Dim DtVisitDetail As New DataTable
        Dim DtWardDetail As New DataTable
        Dim DtWardDiagnosisDetail As New DataTable
        Dim DtWardTreatmentDetail As New DataTable

        Dim ClsVisit As New ClsVisit
        Dim ClsWard As New ClsWard
        Dim ClsWardDiagnosis As New ClsWardDiagnosis
        Dim ClsWardTreatment As New ClsWardTreatment

        Try
            With ClsVisit
                .VisitID = VisitID
                DtVisitDetail = .GetVisitDetail(ClsVisit)
            End With

            With ClsWard
                .WardID = WardID
                DtWardDetail = ClsWard.GetWardDetail(ClsWard)
            End With

            With ClsWardDiagnosis
                .WardID = WardID
                .DiagnoseDate = WardDate
                DtWardDiagnosisDetail = ClsWardDiagnosis.GetWardDiagnosisDetail(ClsWardDiagnosis)
            End With

            With ClsWardTreatment
                .WardID = WardID
                .TreatmentDate = WardDate
                DtWardTreatmentDetail = ClsWardTreatment.GetWardTreatmentDetail(ClsWardTreatment)
            End With

            LblCurrentWardDate.Text = WardDate 'DtWardDetail.Rows(0).Item("WardDate")
            LblVisitID.Text = VisitID
            LblVisitTime.Text = DtVisitDetail.Rows(0).Item("VisitTime")
            LblAssignedVet.Text = "DR. " & DtVisitDetail.Rows(0).Item("EmployeeName")
            LblWardID.Text = WardID
            LblAdmissionDate.Text = DtWardDetail.Rows(0).Item("AdmissionDate")
            LblCustomerID.Text = CustomerID
            LblCustomerName.Text = DtVisitDetail.Rows(0).Item("CustomerName")
            LblPetID.Text = DtVisitDetail.Rows(0).Item("PetID")
            LblPetName.Text = DtVisitDetail.Rows(0).Item("PetName")
            LblPetCase.Text = DtWardDetail.Rows(0).Item("PetCase")

            LblAppetite.Text = IIf(DtWardDetail.Rows(0).Item("Appetite") = "1", "POSITIVE", "NEGATIVE")
            LblBowel.Text = IIf(DtWardDetail.Rows(0).Item("Bowel") = "1", "POSITIVE", "NEGATIVE")
            LblUrine.Text = IIf(DtWardDetail.Rows(0).Item("Urine") = "1", "POSITIVE", "NEGATIVE")
            LblVomit.Text = IIf(DtWardDetail.Rows(0).Item("Vomit") = "1", "POSITIVE", "NEGATIVE")
            LblFood.Text = IIf(DtWardDetail.Rows(0).Item("Food") = "1", "OWNER", "CLINIC")
            LblIsFasting.Text = IIf(DtWardDetail.Rows(0).Item("IsFasting") = "1", "YES", "NO")
            LblFastingDescription.Text = IIf(DtWardDetail.Rows(0).Item("IsFasting") = "1", DtWardDetail.Rows(0).Item("FastingDescription"), "")
            TxtDailyNotes.Text = DtWardDetail.Rows(0).Item("DailyNotes")

            If DtWardDiagnosisDetail.Rows.Count > 0 Then
                TxtDiagnosis.Text = DtWardDiagnosisDetail.Rows(0).Item("Diagnosis")
                For i As Integer = 0 To DtWardDiagnosisDetail.Rows.Count - 1
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
            End If

            If DtWardTreatmentDetail.Rows.Count > 0 Then
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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class