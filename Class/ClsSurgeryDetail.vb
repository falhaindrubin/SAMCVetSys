Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsSurgeryDetail

    Dim DbSurgery As New ClsDbSurgery

#Region "Property"

    Private _CaseID As String
    Public Property CaseID As String
        Get
            Return _CaseID
        End Get
        Set(value As String)
            _CaseID = value
        End Set
    End Property

    Private _EvaluationDate As DateTime
    Public Property EvaluationDate As DateTime
        Get
            Return _EvaluationDate
        End Get
        Set(value As DateTime)
            _EvaluationDate = value
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

    Private _EmployeeName As String
    Public Property EmployeeName As String
        Get
            Return _EmployeeName
        End Get
        Set(value As String)
            _EmployeeName = value
        End Set
    End Property

    Private _BodyWeight As Decimal
    Public Property BodyWeight As Decimal
        Get
            Return _BodyWeight
        End Get
        Set(value As Decimal)
            _BodyWeight = value
        End Set
    End Property

    Private _BodyScoreCode As String
    Public Property BodyScoreCode As String
        Get
            Return _BodyScoreCode
        End Get
        Set(value As String)
            _BodyScoreCode = value
        End Set
    End Property

    Private _BodyScoreName As String
    Public Property BodyScoreName As String
        Get
            Return _BodyScoreName
        End Get
        Set(value As String)
            _BodyScoreName = value
        End Set
    End Property

    Private _Temperature As Decimal
    Public Property Temperature As Decimal
        Get
            Return _Temperature
        End Get
        Set(value As Decimal)
            _Temperature = value
        End Set
    End Property

    Private _TemperamentCode As String
    Public Property TemperamentCode As String
        Get
            Return _TemperamentCode
        End Get
        Set(value As String)
            _TemperamentCode = value
        End Set
    End Property

    Private _TemperamentName As String
    Public Property TemperamentName As String
        Get
            Return _TemperamentName
        End Get
        Set(value As String)
            _TemperamentName = value
        End Set
    End Property

    Private _Pulse As Decimal
    Public Property Pulse As Decimal
        Get
            Return _Pulse
        End Get
        Set(value As Decimal)
            _Pulse = value
        End Set
    End Property

    Private _RespiratoryRate As Decimal
    Public Property RespiratoryRate As Decimal
        Get
            Return _RespiratoryRate
        End Get
        Set(value As Decimal)
            _RespiratoryRate = value
        End Set
    End Property

    Private _SurgeryDiagnosis As String
    Public Property SurgeryDiagnosis As String
        Get
            Return _SurgeryDiagnosis
        End Get
        Set(value As String)
            _SurgeryDiagnosis = value
        End Set
    End Property

    Private _IsFasting As String
    Public Property IsFasting As String
        Get
            Return _IsFasting
        End Get
        Set(value As String)
            _IsFasting = value
        End Set
    End Property

    Private _FastingDescription As String
    Public Property FastingDescription As String
        Get
            Return _FastingDescription
        End Get
        Set(value As String)
            _FastingDescription = value
        End Set
    End Property

    Private _IsVaccine As String
    Public Property IsVaccine As String
        Get
            Return _IsVaccine
        End Get
        Set(value As String)
            _IsVaccine = value
        End Set
    End Property

    Private _VaccineDescription As String
    Public Property VaccineDescription As String
        Get
            Return _VaccineDescription
        End Get
        Set(value As String)
            _VaccineDescription = value
        End Set
    End Property

    Private _HasVaccineDueDate As String
    Public Property HasVaccineDueDate As String
        Get
            Return _HasVaccineDueDate
        End Get
        Set(value As String)
            _HasVaccineDueDate = value
        End Set
    End Property

    Private _VaccineNextDueDate As Date
    Public Property VaccineNextDueDate As Date
        Get
            Return _VaccineNextDueDate
        End Get
        Set(value As Date)
            _VaccineNextDueDate = value
        End Set
    End Property

    Private _GeneralAppearance As String
    Public Property GeneralAppearance As String
        Get
            Return _GeneralAppearance
        End Get
        Set(value As String)
            _GeneralAppearance = value
        End Set
    End Property

    Private _GeneralAppearanceDescription As String
    Public Property GeneralAppearanceDescription As String
        Get
            Return _GeneralAppearanceDescription
        End Get
        Set(value As String)
            _GeneralAppearanceDescription = value
        End Set
    End Property

    Private _Hydration As String
    Public Property Hydration As String
        Get
            Return _Hydration
        End Get
        Set(value As String)
            _Hydration = value
        End Set
    End Property

    Private _HydrationDescription As String
    Public Property HydrationDescription As String
        Get
            Return _HydrationDescription
        End Get
        Set(value As String)
            _HydrationDescription = value
        End Set
    End Property

    Private _MucousMembrane As String
    Public Property MucousMembrane As String
        Get
            Return _MucousMembrane
        End Get
        Set(value As String)
            _MucousMembrane = value
        End Set
    End Property

    Private _MucousMembraneDescription As String
    Public Property MucousMembraneDescription As String
        Get
            Return _MucousMembraneDescription
        End Get
        Set(value As String)
            _MucousMembraneDescription = value
        End Set
    End Property

    Private _Capillary As String
    Public Property Capillary As String
        Get
            Return _Capillary
        End Get
        Set(value As String)
            _Capillary = value
        End Set
    End Property

    Private _CapillaryDescription As String
    Public Property CapillaryDescription As String
        Get
            Return _CapillaryDescription
        End Get
        Set(value As String)
            _CapillaryDescription = value
        End Set
    End Property

    Private _Respiratory As String
    Public Property Respiratory As String
        Get
            Return _Respiratory
        End Get
        Set(value As String)
            _Respiratory = value
        End Set
    End Property

    Private _RespiratoryDescription As String
    Public Property RespiratoryDescription As String
        Get
            Return _RespiratoryDescription
        End Get
        Set(value As String)
            _RespiratoryDescription = value
        End Set
    End Property

    Private _LungSound As String
    Public Property LungSound As String
        Get
            Return _LungSound
        End Get
        Set(value As String)
            _LungSound = value
        End Set
    End Property

    Private _LungSoundDescription As String
    Public Property LungSoundDescription As String
        Get
            Return _LungSoundDescription
        End Get
        Set(value As String)
            _LungSoundDescription = value
        End Set
    End Property

    Private _HeartRate As String
    Public Property HeartRate As String
        Get
            Return _HeartRate
        End Get
        Set(value As String)
            _HeartRate = value
        End Set
    End Property

    Private _HeartRateDescription As String
    Public Property HeartRateDescription As String
        Get
            Return _HeartRateDescription
        End Get
        Set(value As String)
            _HeartRateDescription = value
        End Set
    End Property

    Private _HeartRateReading As String
    Public Property HeartRateReading As String
        Get
            Return _HeartRateReading
        End Get
        Set(value As String)
            _HeartRateReading = value
        End Set
    End Property

    Private _HeartRhythm As String
    Public Property HeartRhythm As String
        Get
            Return _HeartRhythm
        End Get
        Set(value As String)
            _HeartRhythm = value
        End Set
    End Property

    Private _HeartRhythmDescription As String
    Public Property HeartRhythmDescription As String
        Get
            Return _HeartRhythmDescription
        End Get
        Set(value As String)
            _HeartRhythmDescription = value
        End Set
    End Property

    Private _HeartSound As String
    Public Property HeartSound As String
        Get
            Return _HeartSound
        End Get
        Set(value As String)
            _HeartSound = value
        End Set
    End Property

    Private _HeartSoundDescription As String
    Public Property HeartSoundDescription As String
        Get
            Return _HeartSoundDescription
        End Get
        Set(value As String)
            _HeartSoundDescription = value
        End Set
    End Property

    Private _OtherFindings As String
    Public Property OtherFindings As String
        Get
            Return _OtherFindings
        End Get
        Set(value As String)
            _OtherFindings = value
        End Set
    End Property

    Private _LevelOfRisk As String
    Public Property LevelOfRisk As String
        Get
            Return _LevelOfRisk
        End Get
        Set(value As String)
            _LevelOfRisk = value
        End Set
    End Property

    Private _LevelOfRiskDescription As String
    Public Property LevelOfRiskDescription As String
        Get
            Return _LevelOfRiskDescription
        End Get
        Set(value As String)
            _LevelOfRiskDescription = value
        End Set
    End Property

    Private _SurgeonComments As String
    Public Property SurgeonComments As String
        Get
            Return _SurgeonComments
        End Get
        Set(value As String)
            _SurgeonComments = value
        End Set
    End Property

    Private _SurgicalPlan As String
    Public Property SurgicalPlan As String
        Get
            Return _SurgicalPlan
        End Get
        Set(value As String)
            _SurgicalPlan = value
        End Set
    End Property

    Private _Ref As New ClsReference
    Property Ref() As ClsReference
        Get
            Return _Ref
        End Get
        Set(ByVal value As ClsReference)
            _Ref = value
        End Set
    End Property

#End Region

    Public Function AddNewSurgeryDetail(ClsSurgeryDetail As ClsSurgeryDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbSurgery.AddNewSurgeryDetail(ClsSurgeryDetail, DbConn, DbTrans)
    End Function

#Region "SurgeryDiagnosis"

    Public Function GetFastingStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetFastingStatus(ClsSurgery)
    End Function

    Public Function GetVaccineStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetVaccineStatus(ClsSurgery)
    End Function

    Public Function GetGeneralAppearanceStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetGeneralAppearanceStatus(ClsSurgery)
    End Function

    Public Function GetHydrationStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetHydrationStatus(ClsSurgery)
    End Function

    Public Function GetMucousMembraneStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetMucousMembraneStatus(ClsSurgery)
    End Function

    Public Function GetCapillaryStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetCapillaryStatus(ClsSurgery)
    End Function

    Public Function GetRespiratoryStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetRespiratoryStatus(ClsSurgery)
    End Function

    Public Function GetLungSoundStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetLungSoundStatus(ClsSurgery)
    End Function

    Public Function GetHeartRateStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetHeartRateStatus(ClsSurgery)
    End Function

    Public Function GetHeartRhythmStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetHeartRhythmStatus(ClsSurgery)
    End Function

    Public Function GetHeartSoundStatus(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetHeartSoundStatus(ClsSurgery)
    End Function


#End Region

End Class
