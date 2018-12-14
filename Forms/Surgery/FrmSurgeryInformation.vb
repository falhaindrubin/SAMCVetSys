Imports SAMCVetSys.ModUtility

Public Class FrmSurgeryInformation

#Region "FormProperty"
    Private _CaseID As String
    Public Property CaseID As String
        Get
            Return _CaseID
        End Get
        Set(value As String)
            _CaseID = value
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

    Private Sub FrmSurgeryInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_NAME = Me.Name
        PnlActionBar.BackColor = ColorTranslator.FromHtml("#00B386")
        'PopulateSalutation()
        'PopulateAnimalType()
        'PopulateBreed()
        'PopulatePetStatus()
        'PopulatePetSex()
        PopulateVetSurgeon()
        PopulateTemperament()
        PopulateBodyScore()
        PopulateSurgeryMaterials()
        PopulateSurgeryDiagnosis()
        PopulateForm(UserCommand)
    End Sub

#Region "POPULATE"

    Private Sub PopulateForm(UserCommand As String)

        Try
            TxtEvaluationDate.Text = Now.Date

            If CaseID <> "" Then

                TxtVisitID.Text = CaseID

                'Populate customer information and pet information
                Dim DtCustomer As New DataTable
                Dim ClsCustomer As New ClsCustomer
                With ClsCustomer
                    .CustomerID = CustomerID

                    DtCustomer = .GetCustomerInformation(ClsCustomer)
                    If DtCustomer.Rows.Count > 0 Then

                        TxtCustomerID.Text = DtCustomer.Rows(0).Item("CustomerID")
                        TxtSalutation.Tag = DtCustomer.Rows(0).Item("SaluteCode")
                        TxtSalutation.Text = DtCustomer.Rows(0).Item("SaluteName")
                        TxtCustomerName.Text = DtCustomer.Rows(0).Item("CustomerName")
                        TxtNRICPassportNo.Text = DtCustomer.Rows(0).Item("NRICPassportNo")
                        TxtTelNo.Text = DtCustomer.Rows(0).Item("TelNo")
                        TxtMobileNo.Text = DtCustomer.Rows(0).Item("MobileNo")
                        TxtEmail.Text = DtCustomer.Rows(0).Item("Email")
                        TxtAddress1.Text = DtCustomer.Rows(0).Item("AddressLine1")
                        TxtAddress2.Text = DtCustomer.Rows(0).Item("AddressLine2")
                        TxtAddress3.Text = DtCustomer.Rows(0).Item("AddressLine3")
                        TxtAddress4.Text = DtCustomer.Rows(0).Item("AddressLine4")
                        TxtPostcode.Text = DtCustomer.Rows(0).Item("Postcode")
                        TxtCity.Text = DtCustomer.Rows(0).Item("City")
                        TxtState.Text = DtCustomer.Rows(0).Item("State")
                        TxtCountry.Text = DtCustomer.Rows(0).Item("Country")

                    End If

                End With

                Dim DtPet As New DataTable
                Dim ClsPet As New ClsPet
                With ClsPet
                    .CustomerID = CustomerID

                    DtPet = .GetPetListing(ClsPet)
                    If DtPet.Rows.Count > 0 Then

                        With DgvPetListing

                            If .Rows.Count > 0 Then
                                .Rows.Clear()
                            End If

                            For i As Integer = 0 To DtPet.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells("PetID").Value = DtPet.Rows(i).Item("PetID")
                                .Rows(i).Cells("PetName").Value = DtPet.Rows(i).Item("PetName")
                                .Rows(i).Cells("PetDOB").Value = DtPet.Rows(i).Item("PetDOB")
                                .Rows(i).Cells("AnimalTypeCode").Value = DtPet.Rows(i).Item("AnimalTypeCode")
                                .Rows(i).Cells("AnimalTypeName").Value = DtPet.Rows(i).Item("AnimalTypeName")
                                .Rows(i).Cells("BreedCode").Value = DtPet.Rows(i).Item("BreedCode")
                                .Rows(i).Cells("BreedName").Value = DtPet.Rows(i).Item("BreedName")
                                .Rows(i).Cells("SexCode").Value = DtPet.Rows(i).Item("SexCode")
                                .Rows(i).Cells("SexName").Value = DtPet.Rows(i).Item("SexName")
                                .Rows(i).Cells("NeuterCode").Value = DtPet.Rows(i).Item("NeuterCode")
                                .Rows(i).Cells("NeuterName").Value = DtPet.Rows(i).Item("NeuterName")
                            Next

                        End With

                    End If
                End With

                'Populate customer visit information
                Dim DtVisit As New DataTable
                Dim ClsVisit As New ClsVisit
                With ClsVisit
                    .VisitID = CaseID

                    DtVisit = .GetVisitDetail(ClsVisit)
                    If DtVisit.Rows.Count > 0 Then

                        DtpVisitDate.Value = CDate(DtVisit.Rows(0).Item("VisitTime"))
                        DtpVisitTime.Value = CDate(DtVisit.Rows(0).Item("VisitTime"))
                        'CmbVet.SelectedValue = DtVisit.Rows(0).Item("EmployeeID")
                        TxtVet.Tag = DtVisit.Rows(0).Item("EmployeeID")
                        TxtVet.Text = DtVisit.Rows(0).Item("EmployeeName")
                        TxtVisitDescription.Text = DtVisit.Rows(0).Item("VisitDescription")

                        With DgvSelectedPet

                            If .Rows.Count > 0 Then
                                .Rows.Clear()
                            End If

                            For i As Integer = 0 To DtVisit.Rows.Count - 1

                                .Rows.Add()
                                .Rows(i).Cells("SelectedPetID").Value = DtVisit.Rows(i).Item("PetID")
                                .Rows(i).Cells("SelectedPetName").Value = DtVisit.Rows(i).Item("PetName")
                                .Rows(i).Cells("SelectedPetDOB").Value = DtVisit.Rows(i).Item("PetDOB")
                                .Rows(i).Cells("SelectedAnimalTypeCode").Value = DtVisit.Rows(i).Item("AnimalTypeCode")
                                .Rows(i).Cells("SelectedAnimalTypeName").Value = DtVisit.Rows(i).Item("AnimalTypeName")
                                .Rows(i).Cells("SelectedBreedCode").Value = DtVisit.Rows(i).Item("BreedCode")
                                .Rows(i).Cells("SelectedBreedName").Value = DtVisit.Rows(i).Item("BreedName")
                                .Rows(i).Cells("SelectedSexCode").Value = DtVisit.Rows(i).Item("SexCode")
                                .Rows(i).Cells("SelectedSexName").Value = DtVisit.Rows(i).Item("SexName")
                                .Rows(i).Cells("SelectedNeuterCode").Value = DtVisit.Rows(i).Item("NeuterCode")
                                .Rows(i).Cells("SelectedNeuterName").Value = DtVisit.Rows(i).Item("NeuterName")

                            Next

                        End With

                    End If

                End With

                'Populate surgery header, diagnosis
                Dim DtSxHeader As New DataTable
                Dim DtSxDx As New DataTable
                Dim ClsSurgery As New ClsSurgery
                With ClsSurgery
                    .CaseID = CaseID

                    'Populate surgery header
                    DtSxHeader = .GetSurgeryHeader(ClsSurgery)
                    If DtSxHeader.Rows.Count > 0 Then

                        'Surgery status
                        RbIsCompleted.Checked = IIf(CStrNull(DtSxHeader.Rows(0).Item("IsCompleted")) = "1", True, False)
                        RbIsCancelled.Checked = IIf(CStrNull(DtSxHeader.Rows(0).Item("IsCancelled")) = "1", True, False)
                        RbIsDelayed.Checked = IIf(CStrNull(DtSxHeader.Rows(0).Item("IsDelayed")) = "1", True, False)
                        RbIsOnGoing.Checked = IIf(CStrNull(DtSxHeader.Rows(0).Item("IsOnGoing")) = "1", True, False)

                    End If

                    'Populate surgery detail
                    DtSxDx = .GetSurgeryDetail(ClsSurgery)
                    If DtSxDx.Rows.Count > 0 Then

                        'Check if today's date is already has entry; get date value
                        Dim TodayWardDate As Date
                        For i As Integer = 0 To DtSxDx.Rows.Count - 1
                            If Now.Date = CDate(DtSxDx.Rows(i).Item("EvaluationDate")) Then
                                TodayWardDate = CDate(DtSxDx.Rows(i).Item("EvaluationDate"))
                                Exit For
                            Else
                                TodayWardDate = CDate(DtSxDx.Rows(i).Item("EvaluationDate")) 'Nothing
                            End If
                        Next

                        If TodayWardDate <> Nothing Then

                            'Filter datatable using dataview to get intended surgery evaluation date
                            Dim DvSxDx As New DataView
                            DvSxDx = DtSxDx.DefaultView
                            DvSxDx.RowFilter = "EvaluationDate = '" & TodayWardDate & "'"

                            'Date of Evaluation
                            TxtEvaluationDate.Text = TodayWardDate

                            'Surgeon
                            'TxtSurgeon.Tag = CStrNull(DvSxDx(0)("EmployeeID"))
                            'TxtSurgeon.Text = CStrNull(DvSxDx(0)("EmployeeName"))
                            CmbSurgeon.SelectedValue = CStrNull(DvSxDx(0)("EmployeeID"))

                            'Physical examination
                            TxtTemperature.Text = DvSxDx(0)("Temperature") 'DtSxDx.Rows(0).Item("Temperature")
                            TxtPulse.Text = DvSxDx(0)("Pulse") 'DtSxDx.Rows(0).Item("Pulse")
                            TxtRespiratoryRate.Text = DvSxDx(0)("RespiratoryRate") 'DtSxDx.Rows(0).Item("RespiratoryRate")
                            CmbTemperament.SelectedValue = DvSxDx(0)("TemperamentCode") 'DtSxDx.Rows(0).Item("TemperamentCode")
                            CmbBodyScore.SelectedValue = DvSxDx(0)("BodyScoreCode") 'DtSxDx.Rows(0).Item("BodyScoreCode")
                            TxtBodyWeight.Text = DvSxDx(0)("BodyWeight") 'DtSxDx.Rows(0).Item("BodyWeight")

                            'Diagnosis
                            TxtSurgeryDiagnosis.Text = DvSxDx(0)("SurgeryDiagnosis") 'DtSxDx.Rows(0).Item("SurgeryDiagnosis")

                            'Other findings
                            TxtOtherFindings.Text = DvSxDx(0)("OtherFindings") 'DtSxDx.Rows(0).Item("OtherFindings")

                            'Level of risk
                            CmbLevelOfRisk.SelectedValue = DvSxDx(0)("LevelOfRisk") 'DtSxDx.Rows(0).Item("LevelOfRisk")

                            'Surgeon's comment
                            TxtSurgeonComments.Text = DvSxDx(0)("SurgeonComments") 'DtSxDx.Rows(0).Item("SurgeonComments")

                            'Surgical plan
                            TxtSurgicalPlan.Text = DvSxDx(0)("SurgicalPlan") 'DtSxDx.Rows(0).Item("SurgicalPlan")

                            'Surgery diagnosis
                            CmbFasting.SelectedValue = DvSxDx(0)("IsFasting") 'DtSxDx.Rows(0).Item("IsFasting")
                            CmbVaccine.SelectedValue = DvSxDx(0)("IsVaccine") 'DtSxDx.Rows(0).Item("IsVaccine")
                            CbVaccineDueDate.Checked = IIf(DvSxDx(0)("HasVaccineDueDate") = "1", True, False) 'IIf(CStrNull(DtSxDx.Rows(0).Item("HasVaccineDueDate")) = "1", True, False)
                            DtpVaccineDueDate.Value = IIf(CbVaccineDueDate.Checked = True, DvSxDx(0)("VaccineNextDueDate"), Now) 'IIf(CbVaccineDueDate.Checked = True, DtSxDx.Rows(0).Item("VaccineNextDueDate"), Now)
                            CmbGeneralAppearance.SelectedValue = DvSxDx(0)("GeneralAppearance") 'DtSxDx.Rows(0).Item("GeneralAppearance")
                            CmbHydration.SelectedValue = DvSxDx(0)("Hydration") 'DtSxDx.Rows(0).Item("Hydration")
                            CmbMucousMembrane.SelectedValue = DvSxDx(0)("MucousMembrane") 'DtSxDx.Rows(0).Item("MucousMembrane")
                            CmbCapillaryRefillTime.SelectedValue = DvSxDx(0)("Capillary") 'DtSxDx.Rows(0).Item("Capillary")
                            CmbRespiratory.SelectedValue = DvSxDx(0)("Respiratory") 'DtSxDx.Rows(0).Item("Respiratory")
                            CmbLungSound.SelectedValue = DvSxDx(0)("LungSound") 'DtSxDx.Rows(0).Item("LungSound")
                            CmbHeartRate.SelectedValue = DvSxDx(0)("HeartRate") 'DtSxDx.Rows(0).Item("HeartRate")
                            TxtHeartRateReading.Text = DvSxDx(0)("HeartRateReading") 'DtSxDx.Rows(0).Item("HeartRateReading")
                            CmbHeartRhythm.SelectedValue = DvSxDx(0)("HeartRhythm") 'DtSxDx.Rows(0).Item("HeartRhythm")
                            CmbHeartSound.SelectedValue = DvSxDx(0)("HeartSound") 'DtSxDx.Rows(0).Item("HeartSound")

                        End If

                    End If

                End With

                'Populate surgery materials
                Dim DtSxMaterials As New DataTable
                Dim ClsSurgeryMaterial As New ClsSurgeryMaterial
                With ClsSurgeryMaterial

                    .CaseID = CaseID
                    DtSxMaterials = .GetSurgeryMaterials(ClsSurgeryMaterial)
                    If DtSxMaterials.Rows.Count > 0 Then

                        With DgvSelectedItem

                            If .Rows.Count > 0 Then
                                .Rows.Clear()
                            End If

                            For i As Integer = 0 To DtSxMaterials.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells("MaterialRowNo").Value = DtSxMaterials.Rows(i).Item("RowNo")
                                .Rows(i).Cells("MaterialItemCode").Value = DtSxMaterials.Rows(i).Item("ItemCode")
                                .Rows(i).Cells("MaterialItemDescription").Value = DtSxMaterials.Rows(i).Item("ItemDescription")
                                .Rows(i).Cells("MaterialItemGroup").Value = DtSxMaterials.Rows(i).Item("ItemGroup")
                                .Rows(i).Cells("MaterialItemTypeCode").Value = DtSxMaterials.Rows(i).Item("ItemTypeCode")
                                .Rows(i).Cells("MaterialItemTypeDescription").Value = DtSxMaterials.Rows(i).Item("ItemTypeDescription")
                                .Rows(i).Cells("MaterialUnitPrice").Value = DtSxMaterials.Rows(i).Item("UnitPrice")
                                .Rows(i).Cells("MaterialQuantity").Value = DtSxMaterials.Rows(i).Item("Quantity")
                                .Rows(i).Cells("MaterialTotalPrice").Value = DtSxMaterials.Rows(i).Item("TotalPrice")
                            Next

                        End With

                    End If
                End With

                'Populate surgery dischare information
                Dim DtSxDischarge As New DataTable
                ClsSurgery = New ClsSurgery
                With ClsSurgery
                    .CaseID = CaseID
                    DtSxDischarge = .GetSurgeryDischarge(ClsSurgery)
                    If DtSxDischarge.Rows.Count > 0 Then

                        TxtSpecificInstruction.Text = CStrNull(DtSxDischarge.Rows(0).Item("SpecificInstruction"))
                        TxtMedicationPrescribe.Text = CStrNull(DtSxDischarge.Rows(0).Item("MedicationPrescribe"))

                        CbHasReviewDate.Checked = IIf(CStrNull(DtSxDischarge.Rows(0).Item("HasReviewDate") = "1"), True, False)
                        DtpReviewDate.Enabled = IIf(CStrNull(DtSxDischarge.Rows(0).Item("HasReviewDate") = "1"), True, False)
                        DtpReviewDate.Value = DtSxDischarge.Rows(0).Item("ReviewDate")

                        With DgvSelectedSurgery

                            If .Rows.Count > 0 Then
                                .Rows.Clear()
                            End If

                            For i As Integer = 0 To DtSxDischarge.Rows.Count - 1
                                .Rows.Add()
                                .Rows(i).Cells("SurgeryRowNo").Value = "" 'DtSxDischarge.Rows(i).Item("RowNo")
                                .Rows(i).Cells("SurgeryItemCode").Value = DtSxDischarge.Rows(i).Item("ItemCode")
                                .Rows(i).Cells("SurgeryItemDescription").Value = DtSxDischarge.Rows(i).Item("ItemDescription")
                                .Rows(i).Cells("SurgeryItemGroup").Value = DtSxDischarge.Rows(i).Item("ItemGroup")
                                .Rows(i).Cells("SurgeryItemTypeCode").Value = DtSxDischarge.Rows(i).Item("ItemTypeCode")
                                .Rows(i).Cells("SurgeryItemTypeDescription").Value = DtSxDischarge.Rows(i).Item("ItemTypeDescription")
                                .Rows(i).Cells("SurgeryUnitPrice").Value = DtSxDischarge.Rows(i).Item("UnitPrice")
                                .Rows(i).Cells("SurgeryQuantity").Value = DtSxDischarge.Rows(i).Item("Quantity")
                                .Rows(i).Cells("SurgeryTotalPrice").Value = DtSxDischarge.Rows(i).Item("TotalPrice")
                            Next

                        End With

                    End If

                End With

            Else

                'Check login user, if vet, automatically set surgeon as current login user.
                Dim ClsUser As New ClsUser
                Dim DtUser As New DataTable
                With ClsUser
                    .UserID = CURR_USER
                    DtUser = .GetUserInformation(ClsUser)

                    If DtUser.Rows.Count > 0 Then
                        'TxtSurgeon.Tag = DtUser.Rows(0).Item("EmployeeID")
                        'TxtSurgeon.Text = DtUser.Rows(0).Item("EmployeeName")
                        CmbSurgeon.SelectedValue = DtUser.Rows(0).Item("EmployeeID")
                    End If

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateForm()")
        End Try

    End Sub

    Private Sub PopulateSurgeryDiagnosis()

        Try
            Dim ClsSurgery As New ClsSurgery

            With ClsSurgery
                'Get Fasting status
                Dim DtFasting As New DataTable
                DtFasting = .GetFastingStatus(ClsSurgery)
                If DtFasting.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtFasting.Rows.Count - 1
                        CmbSource.Add(DtFasting.Rows(i).Item("StatusCode"), DtFasting.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbFasting.Items.Count > 0 Then
                        CmbFasting.DataSource = Nothing
                        CmbFasting.Items.Clear()
                    End If

                    CmbFasting.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbFasting.DisplayMember = "Value"
                    CmbFasting.ValueMember = "Key"

                End If

                'Get vaccination status
                Dim DtVaccine As New DataTable
                DtVaccine = .GetVaccineStatus(ClsSurgery)
                If DtVaccine.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtVaccine.Rows.Count - 1
                        CmbSource.Add(DtVaccine.Rows(i).Item("StatusCode"), DtVaccine.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbVaccine.Items.Count > 0 Then
                        CmbVaccine.DataSource = Nothing
                        CmbVaccine.Items.Clear()
                    End If

                    CmbVaccine.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbVaccine.DisplayMember = "Value"
                    CmbVaccine.ValueMember = "Key"

                End If

                'Get general appearance status
                Dim DtGeneralAppearance As New DataTable
                DtGeneralAppearance = .GetGeneralAppearanceStatus(ClsSurgery)
                If DtGeneralAppearance.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtGeneralAppearance.Rows.Count - 1
                        CmbSource.Add(DtGeneralAppearance.Rows(i).Item("StatusCode"), DtGeneralAppearance.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbGeneralAppearance.Items.Count > 0 Then
                        CmbGeneralAppearance.DataSource = Nothing
                        CmbGeneralAppearance.Items.Clear()
                    End If

                    CmbGeneralAppearance.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbGeneralAppearance.DisplayMember = "Value"
                    CmbGeneralAppearance.ValueMember = "Key"

                End If

                'Get hydration status
                Dim DtHydration As New DataTable
                DtHydration = .GetHydrationStatus(ClsSurgery)
                If DtHydration.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtHydration.Rows.Count - 1
                        CmbSource.Add(DtHydration.Rows(i).Item("StatusCode"), DtHydration.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbHydration.Items.Count > 0 Then
                        CmbHydration.DataSource = Nothing
                        CmbHydration.Items.Clear()
                    End If

                    CmbHydration.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbHydration.DisplayMember = "Value"
                    CmbHydration.ValueMember = "Key"

                End If

                'Get mucous membrane status
                Dim DtMucous As New DataTable
                DtMucous = .GetMucousMembraneStatus(ClsSurgery)
                If DtMucous.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtMucous.Rows.Count - 1
                        CmbSource.Add(DtMucous.Rows(i).Item("StatusCode"), DtMucous.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbMucousMembrane.Items.Count > 0 Then
                        CmbMucousMembrane.DataSource = Nothing
                        CmbMucousMembrane.Items.Clear()
                    End If

                    CmbMucousMembrane.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbMucousMembrane.DisplayMember = "Value"
                    CmbMucousMembrane.ValueMember = "Key"

                End If

                'Get capillary status
                Dim DtCapillary As New DataTable
                DtCapillary = .GetCapillaryStatus(ClsSurgery)
                If DtCapillary.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtCapillary.Rows.Count - 1
                        CmbSource.Add(DtCapillary.Rows(i).Item("StatusCode"), DtCapillary.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbCapillaryRefillTime.Items.Count > 0 Then
                        CmbCapillaryRefillTime.DataSource = Nothing
                        CmbCapillaryRefillTime.Items.Clear()
                    End If

                    CmbCapillaryRefillTime.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbCapillaryRefillTime.DisplayMember = "Value"
                    CmbCapillaryRefillTime.ValueMember = "Key"

                End If

                'Get respiratory status
                Dim DtRespiratory As New DataTable
                DtRespiratory = .GetRespiratoryStatus(ClsSurgery)
                If DtRespiratory.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtRespiratory.Rows.Count - 1
                        CmbSource.Add(DtRespiratory.Rows(i).Item("StatusCode"), DtRespiratory.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbRespiratory.Items.Count > 0 Then
                        CmbRespiratory.DataSource = Nothing
                        CmbRespiratory.Items.Clear()
                    End If

                    CmbRespiratory.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbRespiratory.DisplayMember = "Value"
                    CmbRespiratory.ValueMember = "Key"

                End If

                'Get lung sound status
                Dim DtLungSound As New DataTable
                DtLungSound = .GetLungSoundStatus(ClsSurgery)
                If DtLungSound.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtLungSound.Rows.Count - 1
                        CmbSource.Add(DtLungSound.Rows(i).Item("StatusCode"), DtLungSound.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbLungSound.Items.Count > 0 Then
                        CmbLungSound.DataSource = Nothing
                        CmbLungSound.Items.Clear()
                    End If

                    CmbLungSound.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbLungSound.DisplayMember = "Value"
                    CmbLungSound.ValueMember = "Key"

                End If

                'Get heart rate status
                Dim DtHeartRate As New DataTable
                DtHeartRate = .GetHeartRateStatus(ClsSurgery)
                If DtHeartRate.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtHeartRate.Rows.Count - 1
                        CmbSource.Add(DtHeartRate.Rows(i).Item("StatusCode"), DtHeartRate.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbHeartRate.Items.Count > 0 Then
                        CmbHeartRate.DataSource = Nothing
                        CmbHeartRate.Items.Clear()
                    End If

                    CmbHeartRate.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbHeartRate.DisplayMember = "Value"
                    CmbHeartRate.ValueMember = "Key"

                End If

                'Get heart rhythm status
                Dim DtHeartRyhthm As New DataTable
                DtHeartRyhthm = .GetHeartRhythmStatus(ClsSurgery)
                If DtHeartRyhthm.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtHeartRyhthm.Rows.Count - 1
                        CmbSource.Add(DtHeartRyhthm.Rows(i).Item("StatusCode"), DtHeartRyhthm.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbHeartRhythm.Items.Count > 0 Then
                        CmbHeartRhythm.DataSource = Nothing
                        CmbHeartRhythm.Items.Clear()
                    End If

                    CmbHeartRhythm.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbHeartRhythm.DisplayMember = "Value"
                    CmbHeartRhythm.ValueMember = "Key"

                End If

                'Get heart sound status
                Dim DtHeartSound As New DataTable
                DtHeartSound = .GetHeartSoundStatus(ClsSurgery)
                If DtHeartSound.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtHeartSound.Rows.Count - 1
                        CmbSource.Add(DtHeartSound.Rows(i).Item("StatusCode"), DtHeartSound.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbHeartSound.Items.Count > 0 Then
                        CmbHeartSound.DataSource = Nothing
                        CmbHeartSound.Items.Clear()
                    End If

                    CmbHeartSound.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbHeartSound.DisplayMember = "Value"
                    CmbHeartSound.ValueMember = "Key"

                End If

                'Get Level Of Risk
                Dim DtLevelOfRisk As New DataTable
                DtLevelOfRisk = .GetLevelOfRisk(ClsSurgery)
                If DtLevelOfRisk.Rows.Count > 0 Then

                    Dim CmbSource As New Dictionary(Of String, String)
                    For i As Integer = 0 To DtLevelOfRisk.Rows.Count - 1
                        CmbSource.Add(DtLevelOfRisk.Rows(i).Item("StatusCode"), DtLevelOfRisk.Rows(i).Item("StatusDescription"))
                    Next

                    If CmbLevelOfRisk.Items.Count > 0 Then
                        CmbLevelOfRisk.DataSource = Nothing
                        CmbLevelOfRisk.Items.Clear()
                    End If

                    CmbLevelOfRisk.DataSource = New BindingSource(CmbSource, Nothing)
                    CmbLevelOfRisk.DisplayMember = "Value"
                    CmbLevelOfRisk.ValueMember = "Key"

                End If


            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateSurgeryDiagnosis()")
        End Try

    End Sub

    Private Sub PopulateVisit()

        Try
            With FrmSearchVisit
                .Source = "TREATMENT"
                .UserCommand = "ADD_NEW_TREATMENT"
                .ShowDialog()

                CaseID = .VisitID
                CustomerID = .CustomerID
                'CustomerName = .CustomerName
                'PetID = .PetID
                'PetName = .PetName
                UserCommand = .UserCommand
            End With

            PopulateForm(UserCommand)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateVisit()")
        End Try

    End Sub

    'Private Sub PopulateSalutation()

    '    Dim DtSalute As New DataTable
    '    Dim ClsCustomer As New ClsCustomer
    '    Dim CmbSource As New Dictionary(Of String, String)

    '    Try
    '        DtSalute = ClsCustomer.GetSalutation(ClsCustomer)
    '        If DtSalute.Rows.Count > 0 Then

    '            For i As Integer = 0 To DtSalute.Rows.Count - 1
    '                CmbSource.Add(DtSalute.Rows(i).Item("SaluteCode"), DtSalute.Rows(i).Item("SaluteName"))
    '            Next

    '            If CmbSalutation.Items.Count > 0 Then
    '                CmbSalutation.DataSource = Nothing
    '                CmbSalutation.Items.Clear()
    '            End If

    '            CmbSalutation.DataSource = New BindingSource(CmbSource, Nothing)
    '            CmbSalutation.DisplayMember = "Value"
    '            CmbSalutation.ValueMember = "Key"

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmCustomerEntry.PopulateSalutation()")
    '    End Try

    'End Sub

    Private Sub PopulateBodyScore()

        Dim DtBodyScore As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtBodyScore = ClsPet.GetPetBodyScore(ClsPet)
            If DtBodyScore.Rows.Count > 0 Then

                For i As Integer = 0 To DtBodyScore.Rows.Count - 1
                    CmbSource.Add(DtBodyScore.Rows(i).Item("BodyScoreCode"), DtBodyScore.Rows(i).Item("BodyScoreCode") & " - " & DtBodyScore.Rows(i).Item("BodyScoreName"))
                Next

                If CmbBodyScore.Items.Count > 0 Then
                    CmbBodyScore.DataSource = Nothing
                    CmbBodyScore.Items.Clear()
                End If

                CmbBodyScore.DataSource = New BindingSource(CmbSource, Nothing)
                CmbBodyScore.DisplayMember = "Value"
                CmbBodyScore.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateBodyScore()")
        End Try

    End Sub

    Private Sub PopulateTemperament()

        Dim DtTemperament As New DataTable
        Dim ClsPet As New ClsPet
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtTemperament = ClsPet.GetPetTemperament(ClsPet)
            If DtTemperament.Rows.Count > 0 Then

                For i As Integer = 0 To DtTemperament.Rows.Count - 1
                    CmbSource.Add(DtTemperament.Rows(i).Item("TemperamentCode"), DtTemperament.Rows(i).Item("TemperamentCode") & " - " & DtTemperament.Rows(i).Item("TemperamentName"))
                Next

                If CmbTemperament.Items.Count > 0 Then
                    CmbTemperament.DataSource = Nothing
                    CmbTemperament.Items.Clear()
                End If

                CmbTemperament.DataSource = New BindingSource(CmbSource, Nothing)
                CmbTemperament.DisplayMember = "Value"
                CmbTemperament.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateTemperament()")
        End Try

    End Sub

    Private Sub PopulateVetSurgeon()

        Dim DtVet As New DataTable
        Dim ClsEmployee As New ClsEmployee
        Dim CmbSource As New Dictionary(Of String, String)

        Try
            DtVet = ClsEmployee.GetVet(ClsEmployee)
            If DtVet.Rows.Count > 0 Then

                For i As Integer = 0 To DtVet.Rows.Count - 1
                    CmbSource.Add(DtVet.Rows(i).Item("EmployeeID"), DtVet.Rows(i).Item("EmployeeName"))
                Next

                'If CmbVet.Items.Count > 0 Then
                '    CmbVet.DataSource = Nothing
                '    CmbVet.Items.Clear()
                'End If

                'CmbVet.DataSource = New BindingSource(CmbSource, Nothing)
                'CmbVet.DisplayMember = "Value"
                'CmbVet.ValueMember = "Key"

                'Populate vet surgeon
                If CmbSurgeon.Items.Count > 0 Then
                    CmbSurgeon.DataSource = Nothing
                    CmbSurgeon.Items.Clear()
                End If

                CmbSurgeon.DataSource = New BindingSource(CmbSource, Nothing)
                CmbSurgeon.DisplayMember = "Value"
                CmbSurgeon.ValueMember = "Key"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".PopulateVet()")
        End Try

    End Sub

    Private Sub PopulateSurgeryMaterials()

        Try
            Dim ClsSurgeryMaterial As New ClsSurgeryMaterial
            Dim DtSxMaterials As New DataTable
            Dim DtSelectedSxMaterials As New DataTable

            With ClsSurgeryMaterial

                .CaseID = CaseID

                DtSxMaterials = .GetSurgeryMaterialsMgmt(ClsSurgeryMaterial)

                If CaseID <> "" Then
                    DtSelectedSxMaterials = .GetSurgeryMaterials(ClsSurgeryMaterial)
                End If

                If DtSxMaterials.Rows.Count > 0 Then

                    For i As Integer = 0 To DtSxMaterials.Rows.Count - 1

                        With DgvFixedSxMaterials
                            .Rows.Add()
                            .Rows(i).Cells("SxMaterialsRowNo").Value = DtSxMaterials.Rows(i).Item("RowNo")
                            .Rows(i).Cells("SxMaterialsItemCode").Value = DtSxMaterials.Rows(i).Item("ItemCode")
                            .Rows(i).Cells("SxMaterialsItemDescription").Value = DtSxMaterials.Rows(i).Item("ItemDescription")
                            .Rows(i).Cells("SxMaterialsUnitPrice").Value = DtSxMaterials.Rows(i).Item("UnitPrice")
                            .Rows(i).Cells("SxMaterialsQuantity").Value = DtSxMaterials.Rows(i).Item("Quantity")
                            .Rows(i).Cells("SxMaterialsTotalPrice").Value = DtSxMaterials.Rows(i).Item("TotalPrice")
                            .Rows(i).Cells("SxMaterialsItemGroup").Value = DtSxMaterials.Rows(i).Item("ItemGroup")
                            .Rows(i).Cells("SxMaterialsItemTypeCode").Value = DtSxMaterials.Rows(i).Item("ItemTypeCode")
                            .Rows(i).Cells("SxMaterialsItemTypeDescription").Value = DtSxMaterials.Rows(i).Item("ItemTypeDescription")
                            .Rows(i).Cells("SxMaterialsPrescription").Value = DtSxMaterials.Rows(i).Item("Prescription")
                            .Rows(i).Cells("SxMaterialsNotes").Value = DtSxMaterials.Rows(i).Item("Notes")
                        End With

                    Next

                End If

                'Check previously selected surgery materials
                If DtSelectedSxMaterials.Rows.Count > 0 Then

                    For i As Integer = 0 To DtSelectedSxMaterials.Rows.Count - 1

                        For j As Integer = 0 To DgvFixedSxMaterials.Rows.Count - 1

                            If DtSelectedSxMaterials.Rows(i).Item("ItemCode") = DgvFixedSxMaterials.Rows(j).Cells("SxMaterialsItemCode").Value Then

                                DgvFixedSxMaterials.Rows(j).Cells("DgvCbSelectItem").Value = True
                                Exit For

                            End If

                        Next

                    Next
                Else
                    For i As Integer = 0 To DgvFixedSxMaterials.Rows.Count - 1
                        DgvFixedSxMaterials.Rows(i).Cells("DgvCbSelectItem").Value = False
                    Next

                End If

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Function CheckFields(Optional FieldSource As String = "") As Boolean

        Try
            Select Case FieldSource
                Case "ADD_SURGERY_ITEM"
                    If TxtMaterialItem.Text = "" Then
                        MsgBox("Please select item.", MsgBoxStyle.Exclamation, "No Item Selected")
                        Return False
                    End If

                    For i As Integer = 0 To DgvSelectedItem.Rows.Count - 1

                        If TxtMaterialItem.Tag = DgvSelectedItem.Rows(i).Cells("SurgeryItemCode").Value Then
                            MsgBox("You are trying to add same item(s) to the list. Update selected item quantity's instead.", MsgBoxStyle.Exclamation, "Duplicate Item")
                            Return False
                        End If

                    Next

                Case "SAVE_TO_DB"

                    If CaseID = "" Then
                        If Trim(TxtVisitID.Text) <> "" Then
                            CaseID = TxtVisitID.Text
                        Else
                            MsgBox("No visit has been selected.", MsgBoxStyle.Critical, "Visit ID Missing")
                            Return False
                        End If
                    End If

                    'If DgvSelectedItem.Rows.Count = 0 Then
                    '    MsgBox("Please select surgery materials.", MsgBoxStyle.Critical, "No Surgery Materials Specified")
                    '    Return False
                    'End If

            End Select


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CheckFields()")
            Return False
        End Try

        Return True

    End Function

#End Region

#Region "FUNCTIONS"

    Private Function SaveSurgeryToDb() As Boolean

        Try
            'Check if VisitID is not exist
            If Not CheckFields("SAVE_TO_DB") Then Return False

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            'Use VisitID as SurgeryID
            Dim ClsSurgery As New ClsSurgery
            Dim ClsSurgeryDetail As New ClsSurgeryDetail

            With ClsSurgery
                .CaseID = IIf(CaseID <> "", CaseID, Trim(TxtVisitID.Text))
                '.SurgeryDate = Now
                .CustomerID = IIf(TxtCustomerID.Text <> "", TxtCustomerID.Text, CustomerID)
                .CustomerName = Trim(TxtCustomerName.Text)
                '.EmployeeID = ""
                '.EmployeeName = ""
                .NRICPassportNo = Trim(TxtNRICPassportNo.Text)
                .TelNo = TxtTelNo.Text
                .MobileNo = TxtMobileNo.Text
                .PetID = DgvSelectedPet.Rows(0).Cells("SelectedPetID").Value
                .PetName = DgvSelectedPet.Rows(0).Cells("SelectedPetName").Value
                .SexCode = DgvSelectedPet.Rows(0).Cells("SelectedSexCode").Value
                .SexName = DgvSelectedPet.Rows(0).Cells("SelectedSexName").Value
                .AnimalTypeCode = DgvSelectedPet.Rows(0).Cells("SelectedAnimalTypeCode").Value
                .AnimalTypeName = DgvSelectedPet.Rows(0).Cells("SelectedAnimalTypeName").Value
                .BreedCode = DgvSelectedPet.Rows(0).Cells("SelectedBreedCode").Value
                .BreedName = DgvSelectedPet.Rows(0).Cells("SelectedBreedName").Value
                .NeuterCode = DgvSelectedPet.Rows(0).Cells("SelectedNeuterCode").Value
                .NeuterName = DgvSelectedPet.Rows(0).Cells("SelectedNeuterName").Value
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewSurgery(ClsSurgery, DbConn, DbTrans) Then
                    MsgBox("Failed to add new surgery.", MsgBoxStyle.Critical, "Add New Surgery Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If

            End With

            With ClsSurgeryDetail

                'Trim TemperamentName and BodyScoreName
                Dim StrTemperamentName As String = DirectCast(CmbTemperament.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                Dim StrBodyScoreName As String = DirectCast(CmbBodyScore.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                Dim TemperamentName As String = Trim(StrTemperamentName.Replace(StrTemperamentName.Substring(0, 4), ""))
                Dim BodyScoreName As String = Trim(StrBodyScoreName.Replace(StrBodyScoreName.Substring(0, 4), ""))

                .CaseID = CaseID
                .EvaluationDate = CDate(TxtEvaluationDate.Text)
                .EmployeeID = DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Key.ToString 'Trim(TxtSurgeon.Tag)
                .EmployeeName = DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Value.ToString 'Trim(TxtSurgeon.Tag) 'Trim(TxtSurgeon.Text)
                .BodyWeight = IIf(Trim(TxtBodyWeight.Text) = "", 0, Trim(TxtBodyWeight.Text))
                .BodyScoreCode = DirectCast(CmbBodyScore.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .BodyScoreName = BodyScoreName
                .Temperature = IIf(Trim(TxtTemperature.Text) = "", 0, Trim(TxtTemperature.Text))
                .TemperamentCode = DirectCast(CmbTemperament.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .TemperamentName = TemperamentName
                .Pulse = IIf(Trim(TxtPulse.Text) = "", 0, Trim(TxtPulse.Text))
                .RespiratoryRate = IIf(Trim(TxtRespiratoryRate.Text) = "", 0, Trim(TxtRespiratoryRate.Text))
                .SurgeryDiagnosis = Trim(TxtSurgeryDiagnosis.Text)
                .IsFasting = DirectCast(CmbFasting.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .FastingDescription = DirectCast(CmbFasting.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .IsVaccine = DirectCast(CmbVaccine.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .VaccineDescription = DirectCast(CmbVaccine.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .HasVaccineDueDate = IIf(CbVaccineDueDate.Checked = True, "1", "0")
                .VaccineNextDueDate = IIf(CbVaccineDueDate.Checked = True, DtpVaccineDueDate.Value, Nothing)
                .GeneralAppearance = DirectCast(CmbGeneralAppearance.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .GeneralAppearanceDescription = DirectCast(CmbGeneralAppearance.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .Hydration = DirectCast(CmbHydration.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .HydrationDescription = DirectCast(CmbHydration.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .MucousMembrane = DirectCast(CmbMucousMembrane.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .MucousMembraneDescription = DirectCast(CmbMucousMembrane.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .Capillary = DirectCast(CmbCapillaryRefillTime.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .CapillaryDescription = DirectCast(CmbCapillaryRefillTime.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .Respiratory = DirectCast(CmbRespiratory.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .RespiratoryDescription = DirectCast(CmbRespiratory.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .LungSound = DirectCast(CmbLungSound.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .LungSoundDescription = DirectCast(CmbLungSound.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .HeartRate = DirectCast(CmbHeartRate.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .HeartRateDescription = DirectCast(CmbHeartRate.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .HeartRateReading = IIf(Trim(TxtHeartRateReading.Text) = "", 0.0, Trim(TxtHeartRateReading.Text))
                .HeartRhythm = DirectCast(CmbHeartRhythm.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .HeartRhythmDescription = DirectCast(CmbHeartRhythm.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .HeartSound = DirectCast(CmbHeartSound.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .HeartSoundDescription = DirectCast(CmbHeartSound.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .OtherFindings = Trim(TxtOtherFindings.Text)
                .LevelOfRisk = DirectCast(CmbLevelOfRisk.SelectedItem, KeyValuePair(Of String, String)).Key.ToString
                .LevelOfRiskDescription = DirectCast(CmbLevelOfRisk.SelectedItem, KeyValuePair(Of String, String)).Value.ToString
                .SurgeonComments = Trim(TxtSurgeonComments.Text)
                .SurgicalPlan = Trim(TxtSurgicalPlan.Text)
                .Ref.CreatedBy = CURR_USER
                .Ref.DateCreated = Now
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .AddNewSurgeryDetail(ClsSurgeryDetail, DbConn, DbTrans) Then
                    MsgBox("Failed to add new surgery detail.", MsgBoxStyle.Critical, "Add New Surgery Detail Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If
            End With

            'Add surgery materials
            Dim ClsSurgeryMaterial As New ClsSurgeryMaterial
            If DgvFixedSxMaterials.Rows.Count > 0 Then

                For i As Integer = 0 To DgvFixedSxMaterials.Rows.Count - 1

                    'ctype(dgvChooseQs.Rows(0).findcontrol("whateverYourCheckBoxIsNamed"), checkbox).checked
                    'CBool(DirectCast(TheGrid.Rows(i).Cells("CheckOut"), DataGridViewCheckBoxCell).Value) = True
                    If CBool(DirectCast(DgvFixedSxMaterials.Rows(i).Cells("DgvCbSelectItem"), DataGridViewCheckBoxCell).Value) = True Then

                        With ClsSurgeryMaterial
                            .CaseID = CaseID
                            .SurgeryDate = Now
                            .EmployeeID = DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Key.ToString 'Trim(TxtSurgeon.Tag) 'Trim(TxtSurgeon.Tag)
                            .EmployeeName = DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Value.ToString 'Trim(TxtSurgeon.Tag) 'Trim(TxtSurgeon.Text)
                            .RowNo = i + 1 'DgvSelectedItem.Rows(i).Cells("MaterialRowNo").Value
                            .ItemCode = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemCode").Value
                            .ItemDescription = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemDescription").Value
                            .ItemGroup = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemGroup").Value
                            .ItemTypeCode = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemTypeCode").Value
                            .ItemTypeDescription = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsItemTypeDescription").Value
                            .UnitPrice = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsUnitPrice").Value
                            .Quantity = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsQuantity").Value
                            .TotalPrice = DgvFixedSxMaterials.Rows(i).Cells("SxMaterialsTotalPrice").Value
                            .Ref.CreatedBy = CURR_USER
                            .Ref.DateCreated = Now
                            .Ref.ModifiedBy = CURR_USER
                            .Ref.DateModified = Now

                            If Not .AddNewSurgeryMaterial(ClsSurgeryMaterial, DbConn, DbTrans) Then
                                MsgBox("Failed to add surgery materials information.", MsgBoxStyle.Critical, "Add Surgery Materials Error")
                                DbTrans.Rollback()
                                DbTrans.Dispose()
                                DbTrans = Nothing
                                Return False
                            End If

                        End With

                    End If

                Next

            End If

            'Post surgery and discharge information update.
            'If surgery is completed then save surgery discharge information; else
            'update surgery status; 
            Dim ClsSurgeryDischarge As New ClsSurgeryDischarge
            With ClsSurgery
                .IsCompleted = IIf(RbIsCompleted.Checked = True, "1", "0")
                .IsDelayed = IIf(RbIsDelayed.Checked = True, "1", "0")
                .IsCancelled = IIf(RbIsCancelled.Checked = True, "1", "0")
                .IsOnGoing = IIf(RbIsOnGoing.Checked = True, "1", "0")
                .Ref.ModifiedBy = CURR_USER
                .Ref.DateModified = Now

                If Not .UpdateSurgeryStatus(ClsSurgery, DbConn, DbTrans) Then
                    MsgBox("Failed to update surgery status.", MsgBoxStyle.Critical, "Surgery Status Update Error")
                    DbTrans.Rollback()
                    DbTrans.Dispose()
                    DbTrans = Nothing
                    Return False
                End If
            End With

            If RbIsCompleted.Checked = True Then

                If DgvSelectedSurgery.Rows.Count > 0 Then

                    'Update type of operation used in surgery
                    With ClsSurgery
                        .CaseID = CaseID
                        .ItemCode = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemCode").Value
                        .ItemDescription = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemDescription").Value
                        .ItemGroup = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemGroup").Value
                        .ItemTypeCode = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemTypeCode").Value
                        .ItemTypeDescription = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemTypeDescription").Value
                        .UnitPrice = DgvSelectedSurgery.Rows(0).Cells("SurgeryUnitPrice").Value
                        .Quantity = DgvSelectedSurgery.Rows(0).Cells("SurgeryQuantity").Value
                        .TotalPrice = DgvSelectedSurgery.Rows(0).Cells("SurgeryTotalPrice").Value

                        'If Not .UpdateSurgeryOperation(ClsSurgery, DbConn, DbTrans) Then
                        '    MsgBox("Failed to update surgery operation information.", MsgBoxStyle.Critical, "Surgery Operation Update Error")
                        '    DbTrans.Rollback()
                        '    DbTrans.Dispose()
                        '    DbTrans = Nothing
                        '    Return False
                        'End If
                    End With

                End If

                With ClsSurgeryDischarge
                    .CaseID = CaseID
                    .SurgeryDate = Now
                    .EmployeeID = DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Key.ToString 'Trim(TxtSurgeon.Tag) 'TxtSurgeon.Tag
                    .EmployeeName = DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Value.ToString 'Trim(TxtSurgeon.Tag) 'TxtSurgeon.Text
                    .SpecificInstruction = Trim(TxtSpecificInstruction.Text)
                    .MedicationPrescribe = Trim(TxtMedicationPrescribe.Text)
                    .ItemCode = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemCode").Value
                    .ItemDescription = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemDescription").Value
                    .ItemGroup = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemGroup").Value
                    .ItemTypeCode = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemTypeCode").Value
                    .ItemTypeDescription = DgvSelectedSurgery.Rows(0).Cells("SurgeryItemTypeDescription").Value
                    .UnitPrice = DgvSelectedSurgery.Rows(0).Cells("SurgeryUnitPrice").Value
                    .Quantity = DgvSelectedSurgery.Rows(0).Cells("SurgeryQuantity").Value
                    .TotalPrice = DgvSelectedSurgery.Rows(0).Cells("SurgeryTotalPrice").Value
                    .DischargeDate = Now
                    .ReviewDate = DtpReviewDate.Value
                    .Ref.CreatedBy = CURR_USER
                    .Ref.DateCreated = Now
                    .Ref.ModifiedBy = CURR_USER
                    .Ref.DateModified = Now

                    If Not .AddNewSurgeryDischarge(ClsSurgeryDischarge, DbConn, DbTrans) Then
                        MsgBox("Failed to update surgery discharge details.", MsgBoxStyle.Critical, "Surgery Discharge Update Error")
                        DbTrans.Rollback()
                        DbTrans.Dispose()
                        DbTrans = Nothing
                        Return False
                    End If

                End With

            End If

            DbTrans.Commit()
            DbTrans.Dispose()
            DbTrans = Nothing

            MsgBox("Surgery information has been successfully added.", MsgBoxStyle.Information, "Surgery Information Added")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".SaveSurgeryToDb()")
            DbTrans.Rollback()
            DbTrans.Dispose()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

    Private Function DeleteSurgeryItem(CaseID As String, RowNo As Integer) As Boolean

        Dim ClsSurgeryMaterial As New ClsSurgeryMaterial

        Try
            With ClsSurgeryMaterial
                .CaseID = CaseID
                .RowNo = RowNo
            End With

            If DbTrans IsNot Nothing Then
                DbTrans = Nothing
            End If

            DbTrans = DbConn.BeginTransaction

            If Not ClsSurgeryMaterial.DeleteSurgeryItem(ClsSurgeryMaterial, DbConn, DbTrans) Then
                DbTrans.Rollback()
                DbTrans = Nothing
                Return False
            End If

            DbTrans.Commit()
            DbTrans = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DeleteSurgeryItem()")
            DbTrans.Rollback()
            DbTrans = Nothing
            Return False
        End Try

        Return True

    End Function

#End Region

#Region "SUBS"

    Private Function InitSurgeryItemDt() As DataTable

        Dim DtItem As New DataTable

        Try
            With DtItem
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".InitSurgeryItemDt()")
        End Try

        Return DtItem

    End Function

    Private Sub UpdateMaterialItem()

        Try
            Dim RowIndex As Integer = CInt(LblRowNo.Text)

            With DgvSelectedItem
                .Rows(RowIndex).Cells("MaterialItemCode").Value = Trim(TxtMaterialItem.Tag)
                .Rows(RowIndex).Cells("MaterialItemDescription").Value = Trim(TxtMaterialItem.Text)
                .Rows(RowIndex).Cells("MaterialPrescription").Value = Trim(TxtMaterialPrescription.Text)
                .Rows(RowIndex).Cells("MaterialNotes").Value = Trim(TxtMaterialNotes.Text)
                .Rows(RowIndex).Cells("MaterialUnitPrice").Value = Trim(TxtMaterialUnitPrice.Text)
                .Rows(RowIndex).Cells("MaterialQuantity").Value = Trim(TxtMaterialQuantity.Text)
                .Rows(RowIndex).Cells("MaterialTotalPrice").Value = Trim(TxtMaterialTotalPrice.Text)
            End With

            TxtMaterialItem.Text = ""
            TxtMaterialItem.Tag = ""
            TxtMaterialPrescription.Text = ""
            TxtMaterialNotes.Text = ""
            TxtMaterialUnitPrice.Text = "0.00"
            TxtMaterialQuantity.Text = "1.00"
            TxtMaterialTotalPrice.Text = "0.00"

            BtnAddMaterialItem.Text = "Add Item"
            BtnAddMaterialItem.Tag = ""

            MsgBox("Selected item has been updated!", MsgBoxStyle.Information, "Item Updated")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".UpdateSurgeryItem()")
        End Try

    End Sub

    Private Sub AddMaterialItem()

        Dim DtSurgeryItem As New DataTable

        Try
            'Check user input; fields validity
            If Not CheckFields("ADD_SURGERY_ITEM") Then Exit Sub

            DtSurgeryItem = InitSurgeryItemDt()
            If DgvSelectedItem.Rows.Count > 0 Then

                For i As Integer = 0 To DgvSelectedItem.Rows.Count - 1

                    Dim DgvRow As DataRow = DtSurgeryItem.NewRow

                    DgvRow("RowNo") = DgvSelectedItem.Rows(i).Cells("MaterialRowNo").Value
                    DgvRow("ItemCode") = DgvSelectedItem.Rows(i).Cells("MaterialItemCode").Value
                    DgvRow("ItemDescription") = DgvSelectedItem.Rows(i).Cells("MaterialItemDescription").Value
                    DgvRow("Prescription") = DgvSelectedItem.Rows(i).Cells("MaterialPrescription").Value
                    DgvRow("Notes") = DgvSelectedItem.Rows(i).Cells("MaterialNotes").Value
                    DgvRow("Quantity") = DgvSelectedItem.Rows(i).Cells("MaterialQuantity").Value
                    DgvRow("UnitPrice") = DgvSelectedItem.Rows(i).Cells("MaterialUnitPrice").Value
                    DgvRow("TotalPrice") = DgvSelectedItem.Rows(i).Cells("MaterialTotalPrice").Value
                    DgvRow("ItemGroup") = DgvSelectedItem.Rows(i).Cells("MaterialItemGroup").Value
                    DgvRow("ItemTypeCode") = DgvSelectedItem.Rows(i).Cells("MaterialItemTypeCode").Value
                    DgvRow("ItemTypeDescription") = DgvSelectedItem.Rows(i).Cells("MaterialItemTypeDescription").Value

                    DtSurgeryItem.Rows.Add(DgvRow)

                Next

            End If

            Dim Row As DataRow = DtSurgeryItem.NewRow

            Row("RowNo") = IIf(DtSurgeryItem.Rows.Count = 0, 1, DtSurgeryItem.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtMaterialItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtMaterialItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtMaterialUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtMaterialQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtMaterialTotalPrice.Text) * CDec(TxtMaterialQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode
            Row("Prescription") = Trim(TxtMaterialPrescription.Text)
            Row("Notes") = Trim(TxtMaterialNotes.Text)

            DtSurgeryItem.Rows.Add(Row)

            If DtSurgeryItem.Rows.Count > 0 Then

                DgvSelectedItem.Rows.Clear()

                For i As Integer = 0 To DtSurgeryItem.Rows.Count - 1
                    With DgvSelectedItem
                        .Rows.Add()
                        .Rows(i).Cells("MaterialRowNo").Value = DtSurgeryItem.Rows(i).Item("RowNo")
                        .Rows(i).Cells("MaterialItemCode").Value = DtSurgeryItem.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("MaterialItemDescription").Value = DtSurgeryItem.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("MaterialUnitPrice").Value = DtSurgeryItem.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("MaterialQuantity").Value = DtSurgeryItem.Rows(i).Item("Quantity")
                        .Rows(i).Cells("MaterialTotalPrice").Value = DtSurgeryItem.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("MaterialItemGroup").Value = DtSurgeryItem.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("MaterialItemTypeCode").Value = DtSurgeryItem.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("MaterialItemTypeDescription").Value = DtSurgeryItem.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("MaterialPrescription").Value = DtSurgeryItem.Rows(i).Item("Prescription")
                        .Rows(i).Cells("MaterialNotes").Value = DtSurgeryItem.Rows(i).Item("Notes")
                    End With
                Next

            End If

            TxtMaterialItem.Tag = ""
            TxtMaterialItem.Text = ""
            TxtMaterialUnitPrice.Text = FormatNumber("0.00", 2)
            TxtMaterialQuantity.Text = FormatNumber("1.00", 2)
            TxtMaterialTotalPrice.Text = FormatNumber("0.00", 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddSurgeryItem()")
        End Try

    End Sub

    Private Sub AddSurgeryItem()

        Dim DtOperation As New DataTable

        Try
            'Check user input; fields validity
            'If Not CheckFields("ADD_SURGERY_ITEM") Then Exit Sub

            DtOperation = InitSurgeryItemDt()
            If DgvSelectedSurgery.Rows.Count > 0 Then

                DgvSelectedSurgery.Rows.Clear()

                'For i As Integer = 0 To DgvSelectedSurgery.Rows.Count - 1

                '    Dim DgvRow As DataRow = DtOperation.NewRow

                '    DgvRow("RowNo") = DgvSelectedSurgery.Rows(i).Cells("SurgeryRowNo").Value
                '    DgvRow("ItemCode") = DgvSelectedSurgery.Rows(i).Cells("SurgeryItemCode").Value
                '    DgvRow("ItemDescription") = DgvSelectedSurgery.Rows(i).Cells("SurgeryItemDescription").Value
                '    DgvRow("Prescription") = DgvSelectedSurgery.Rows(i).Cells("SurgeryPrescription").Value
                '    DgvRow("Notes") = DgvSelectedSurgery.Rows(i).Cells("SurgeryNotes").Value
                '    DgvRow("Quantity") = DgvSelectedSurgery.Rows(i).Cells("SurgeryQuantity").Value
                '    DgvRow("UnitPrice") = DgvSelectedSurgery.Rows(i).Cells("SurgeryUnitPrice").Value
                '    DgvRow("TotalPrice") = DgvSelectedSurgery.Rows(i).Cells("SurgeryTotalPrice").Value
                '    DgvRow("ItemGroup") = DgvSelectedSurgery.Rows(i).Cells("SurgeryItemGroup").Value
                '    DgvRow("ItemTypeCode") = DgvSelectedSurgery.Rows(i).Cells("SurgeryItemTypeCode").Value
                '    DgvRow("ItemTypeDescription") = DgvSelectedSurgery.Rows(i).Cells("SurgeryItemTypeDescription").Value

                '    DtOperation.Rows.Add(DgvRow)

                'Next

            End If

            Dim Row As DataRow = DtOperation.NewRow

            Row("RowNo") = IIf(DtOperation.Rows.Count = 0, 1, DtOperation.Rows.Count + 1)
            Row("ItemCode") = UCase(Trim(TxtSurgeryItem.Tag))
            Row("ItemDescription") = UCase(Trim(TxtSurgeryItem.Text))
            Row("UnitPrice") = UCase(Trim(TxtSurgeryUnitPrice.Text))
            Row("Quantity") = UCase(Trim(TxtSurgeryQuantity.Text))
            Row("TotalPrice") = FormatNumber(CDec(TxtSurgeryTotalPrice.Text) * CDec(TxtSurgeryQuantity.Text), 2)
            Row("ItemGroup") = ItemGroup
            Row("ItemTypeDescription") = ItemTypeDescription
            Row("ItemTypeCode") = ItemTypeCode
            Row("Prescription") = Trim(TxtSurgeryPrescription.Text)
            Row("Notes") = Trim(TxtSurgeryNotes.Text)

            DtOperation.Rows.Add(Row)

            If DtOperation.Rows.Count > 0 Then

                DgvSelectedSurgery.Rows.Clear()

                For i As Integer = 0 To DtOperation.Rows.Count - 1
                    With DgvSelectedSurgery
                        .Rows.Add()
                        .Rows(i).Cells("SurgeryRowNo").Value = DtOperation.Rows(i).Item("RowNo")
                        .Rows(i).Cells("SurgeryItemCode").Value = DtOperation.Rows(i).Item("ItemCode")
                        .Rows(i).Cells("SurgeryItemDescription").Value = DtOperation.Rows(i).Item("ItemDescription")
                        .Rows(i).Cells("SurgeryUnitPrice").Value = DtOperation.Rows(i).Item("UnitPrice")
                        .Rows(i).Cells("SurgeryQuantity").Value = DtOperation.Rows(i).Item("Quantity")
                        .Rows(i).Cells("SurgeryTotalPrice").Value = DtOperation.Rows(i).Item("TotalPrice")
                        .Rows(i).Cells("SurgeryItemGroup").Value = DtOperation.Rows(i).Item("ItemGroup")
                        .Rows(i).Cells("SurgeryItemTypeCode").Value = DtOperation.Rows(i).Item("ItemTypeCode")
                        .Rows(i).Cells("SurgeryItemTypeDescription").Value = DtOperation.Rows(i).Item("ItemTypeDescription")
                        .Rows(i).Cells("SurgeryPrescription").Value = DtOperation.Rows(i).Item("Prescription")
                        .Rows(i).Cells("SurgeryNotes").Value = DtOperation.Rows(i).Item("Notes")
                    End With
                Next

            End If

            TxtSurgeryItem.Tag = ""
            TxtSurgeryItem.Text = ""
            TxtSurgeryUnitPrice.Text = FormatNumber("0.00", 2)
            TxtSurgeryQuantity.Text = FormatNumber("1.00", 2)
            TxtSurgeryTotalPrice.Text = FormatNumber("0.00", 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".AddSurgeryItem()")
        End Try

    End Sub

#End Region

#Region "CONTROLS"

    Private Sub BtnSearchItem_Click(sender As Object, e As EventArgs) Handles BtnSearchItem.Click
        With FrmSearchItem
            .ShowDialog()
            TxtMaterialItem.Tag = .ItemCode
            TxtMaterialItem.Text = .ItemDescription
            TxtMaterialUnitPrice.Text = .UnitPrice
            TxtMaterialTotalPrice.Text = FormatNumber(.UnitPrice * TxtMaterialQuantity.Text, 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        PopulateVisit()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not SaveSurgeryToDb() Then Exit Sub
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddMaterialItem.Click
        If BtnAddMaterialItem.Tag = "" Then
            AddMaterialItem()
        ElseIf BtnAddMaterialItem.Tag = "UPDATE" Then
            UpdateMaterialItem()
        End If
    End Sub

    Private Sub DgvSelectedItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSelectedItem.CellContentClick

        'Dim BtnDeletePet As New DataGridViewButtonColumn
        'Dim BtnEditPet As New DataGridViewButtonColumn
        Dim UserResponse As MsgBoxResult

        Try
            Dim SenderGrid = DirectCast(sender, DataGridView)

            If TypeOf SenderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

                'Data grid view Pet Listing 'Select' button
                If e.ColumnIndex = 0 Then

                    'UserResponse = MsgBox("Are sure you want to update this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Update Item?")
                    'If UserResponse = MsgBoxResult.Yes Then

                    UserResponse = MsgBox("Are sure you want to delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Item?")
                    If UserResponse = MsgBoxResult.Yes Then

                        With DgvSelectedItem

                            For Each Row As DataGridViewRow In .SelectedRows

                                If Not DeleteSurgeryItem(CaseID, DgvSelectedItem.Rows(e.RowIndex).Cells("MaterialRowNo").Value) Then
                                    MsgBox("Failed to delete surgery item.", MsgBoxStyle.Critical, "Delete Item Surgery Error")
                                    Exit For
                                End If

                                .Rows.Remove(Row)

                            Next

                            'If .Rows.Count = 0 Then
                            '    .DataSource = Nothing
                            '    .Columns.Clear()
                            '    .Show()
                            'End If

                        End With

                    End If

                ElseIf e.ColumnIndex = 1 Then

                    With DgvSelectedItem

                        TxtMaterialItem.Text = .Rows(e.RowIndex).Cells("MaterialItemDescription").Value
                        TxtMaterialItem.Tag = .Rows(e.RowIndex).Cells("MaterialItemCode").Value
                        TxtMaterialPrescription.Text = .Rows(e.RowIndex).Cells("MaterialPrescription").Value
                        TxtMaterialNotes.Text = .Rows(e.RowIndex).Cells("MaterialNotes").Value
                        TxtMaterialUnitPrice.Text = .Rows(e.RowIndex).Cells("MaterialUnitPrice").Value
                        TxtMaterialQuantity.Text = .Rows(e.RowIndex).Cells("MaterialQuantity").Value
                        TxtMaterialTotalPrice.Text = .Rows(e.RowIndex).Cells("MaterialTotalPrice").Value

                    End With

                    BtnAddMaterialItem.Text = "Update Item"
                    BtnAddMaterialItem.Tag = "UPDATE"
                    LblRowNo.Text = e.RowIndex

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".DgvSelectedItem_CellContentClick()")
        End Try
    End Sub

    Private Sub BtnSearchPostSurgery_Click(sender As Object, e As EventArgs) Handles BtnSearchPostSurgery.Click
        With FrmSearchItem
            .ShowDialog()
            TxtSurgeryItem.Tag = .ItemCode
            TxtSurgeryItem.Text = .ItemDescription
            TxtSurgeryUnitPrice.Text = .UnitPrice
            TxtSurgeryTotalPrice.Text = FormatNumber(.UnitPrice * TxtSurgeryQuantity.Text, 2)
            ItemGroup = .ItemGroup
            ItemTypeDescription = .ItemTypeDescription
            ItemTypeCode = .ItemTypeCode
        End With
    End Sub

    Private Sub BtnAddSurgery_Click(sender As Object, e As EventArgs) Handles BtnAddSurgery.Click
        If BtnAddSurgery.Tag = "" Then
            AddSurgeryItem()
            'ElseIf BtnAddSurgery.Tag = "UPDATE" Then
            'UpdateMaterialItem()
        End If
    End Sub

    Private Sub BtnCreateNewEvaluation_Click(sender As Object, e As EventArgs) Handles BtnCreateNewEvaluation.Click
        CreateNewEvaluation()
    End Sub

    Private Sub CreateNewEvaluation()

        Try
            'Date of evaluation
            TxtEvaluationDate.Text = Now.Date

            'Surgeon
            Dim ClsUser As New ClsUser
            Dim DtUser As New DataTable
            With ClsUser
                .UserID = CURR_USER
                DtUser = .GetUserInformation(ClsUser)
                If DtUser.Rows.Count > 0 Then
                    'TxtSurgeon.Text = DtUser.Rows(0).Item("EmployeeName")
                    'TxtSurgeon.Tag = DtUser.Rows(0).Item("EmployeeID")
                    'DirectCast(CmbSurgeon.SelectedItem, KeyValuePair(Of String, String)).Key.ToString 'Trim(TxtSurgeon.Tag)
                    CmbSurgeon.SelectedValue = DtUser.Rows(0).Item("EmployeeID")
                End If
            End With

            'Level of risk
            CmbLevelOfRisk.SelectedIndex = 0

            'Physical examination
            TxtTemperature.Text = 0.00
            TxtPulse.Text = 0.00
            TxtRespiratoryRate.Text = 0.00
            CmbTemperament.SelectedIndex = 0
            CmbBodyScore.SelectedIndex = 0
            TxtBodyWeight.Text = 0.00

            'Surgery diagnosis
            CmbFasting.SelectedIndex = 0
            CmbVaccine.SelectedIndex = 0
            CbVaccineDueDate.Checked = False
            DtpVaccineDueDate.Value = Now
            DtpVaccineDueDate.Enabled = IIf(CbVaccineDueDate.Checked = True, True, False)
            CmbGeneralAppearance.SelectedIndex = 0
            CmbHydration.SelectedIndex = 0
            CmbMucousMembrane.SelectedIndex = 0
            CmbCapillaryRefillTime.SelectedIndex = 0
            CmbRespiratory.SelectedIndex = 0
            CmbLungSound.SelectedIndex = 0
            CmbHeartRate.SelectedIndex = 0
            TxtHeartRateReading.Text = 0.00
            CmbHeartRhythm.SelectedIndex = 0
            CmbHeartSound.SelectedIndex = 0
            TxtSurgeryDiagnosis.Text = ""
            TxtOtherFindings.Text = ""
            TxtSurgeonComments.Text = ""
            TxtSurgicalPlan.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, FORM_NAME & ".CreateNewEvaluation()")
        End Try

    End Sub

#End Region

End Class