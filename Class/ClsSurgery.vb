Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsSurgery

    Dim DbSurgery As New ClsDbSurgery

#Region "PROPERTY"
    Private _CaseID As String
    Public Property CaseID As String
        Get
            Return _CaseID
        End Get
        Set(value As String)
            _CaseID = value
        End Set
    End Property

    Private _EvaluationDate As Date
    Public Property EvaluationDate As Date
        Get
            Return _EvaluationDate
        End Get
        Set(value As Date)
            _EvaluationDate = value
        End Set
    End Property

    Private _SurgeryDate As Date
    Public Property SurgeryDate As Date
        Get
            Return _SurgeryDate
        End Get
        Set(value As Date)
            _SurgeryDate = value
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

    Private _NRICPassportNo As String
    Public Property NRICPassportNo As String
        Get
            Return _NRICPassportNo
        End Get
        Set(value As String)
            _NRICPassportNo = value
        End Set
    End Property

    Private _TelNo As String
    Public Property TelNo As String
        Get
            Return _TelNo
        End Get
        Set(value As String)
            _TelNo = value
        End Set
    End Property

    Private _MobileNo As String
    Public Property MobileNo As String
        Get
            Return _MobileNo
        End Get
        Set(value As String)
            _MobileNo = value
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

    Private _PetAge As Integer
    Public Property PetAge As Integer
        Get
            Return _PetAge
        End Get
        Set(value As Integer)
            _PetAge = value
        End Set
    End Property

    Private _SexCode As String
    Public Property SexCode As String
        Get
            Return _SexCode
        End Get
        Set(value As String)
            _SexCode = value
        End Set
    End Property

    Private _SexName As String
    Public Property SexName As String
        Get
            Return _SexName
        End Get
        Set(value As String)
            _SexName = value
        End Set
    End Property

    Private _AnimalTypeCode As String
    Public Property AnimalTypeCode As String
        Get
            Return _AnimalTypeCode
        End Get
        Set(value As String)
            _AnimalTypeCode = value
        End Set
    End Property

    Private _AnimalTypeName As String
    Public Property AnimalTypeName As String
        Get
            Return _AnimalTypeName
        End Get
        Set(value As String)
            _AnimalTypeName = value
        End Set
    End Property

    Private _BreedCode As String
    Public Property BreedCode As String
        Get
            Return _BreedCode
        End Get
        Set(value As String)
            _BreedCode = value
        End Set
    End Property

    Private _BreedName As String
    Public Property BreedName As String
        Get
            Return _BreedName
        End Get
        Set(value As String)
            _BreedName = value
        End Set
    End Property

    Private _NeuterCode As String
    Public Property NeuterCode As String
        Get
            Return _NeuterCode
        End Get
        Set(value As String)
            _NeuterCode = value
        End Set
    End Property

    Private _NeuterName As String
    Public Property NeuterName As String
        Get
            Return _NeuterName
        End Get
        Set(value As String)
            _NeuterName = value
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

    Private _ItemDescription As String
    Public Property ItemDescription As String
        Get
            Return _ItemDescription
        End Get
        Set(value As String)
            _ItemDescription = value
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

    Private _ItemTypeCode As String
    Public Property ItemTypeCode As String
        Get
            Return _ItemTypeCode
        End Get
        Set(value As String)
            _ItemTypeCode = value
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

    Private _UnitPrice As String
    Public Property UnitPrice As String
        Get
            Return _UnitPrice
        End Get
        Set(value As String)
            _UnitPrice = value
        End Set
    End Property

    Private _Quantity As String
    Public Property Quantity As String
        Get
            Return _Quantity
        End Get
        Set(value As String)
            _Quantity = value
        End Set
    End Property

    Private _TotalPrice As String
    Public Property TotalPrice As String
        Get
            Return _TotalPrice
        End Get
        Set(value As String)
            _TotalPrice = value
        End Set
    End Property

    Private _IsCompleted As String
    Public Property IsCompleted As String
        Get
            Return _IsCompleted
        End Get
        Set(value As String)
            _IsCompleted = value
        End Set
    End Property

    Private _IsDelayed As String
    Public Property IsDelayed As String
        Get
            Return _IsDelayed
        End Get
        Set(value As String)
            _IsDelayed = value
        End Set
    End Property

    Private _IsCancelled As String
    Public Property IsCancelled As String
        Get
            Return _IsCancelled
        End Get
        Set(value As String)
            _IsCancelled = value
        End Set
    End Property

    Private _IsOnGoing As String
    Public Property IsOnGoing As String
        Get
            Return _IsOnGoing
        End Get
        Set(value As String)
            _IsOnGoing = value
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

    Public Function AddNewSurgery(ClsSurgery As ClsSurgery, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbSurgery.AddNewSurgery(ClsSurgery, DbConn, DbTrans)
    End Function

    Public Function GetSurgeryListing(ClsSurgery) As DataTable
        Return DbSurgery.GetSurgeryListing(ClsSurgery)
    End Function

    Public Function GetSurgeryHeader(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetSurgeryHeader(ClsSurgery)
    End Function

    Public Function GetSurgeryDetail(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetSurgeryDetail(ClsSurgery)
    End Function

    Public Function GetSurgeryMaterials(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetSurgeryMaterials(ClsSurgery)
    End Function

    Public Function UpdateSurgeryStatus(ClsSurgery As ClsSurgery, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbSurgery.UpdateSurgeryStatus(ClsSurgery, DbConn, DbTrans)
    End Function

    Public Function UpdateSurgeryOperation(ClsSurgery As ClsSurgery, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbSurgery.UpdateSurgeryOperation(ClsSurgery, DbConn, DbTrans)
    End Function

    Public Function GetSurgeryDischarge(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetSurgeryDischarge(ClsSurgery)
    End Function

#Region "GetSurgeryDiagnosis"

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

    Public Function GetLevelOfRisk(ClsSurgery As ClsSurgery) As DataTable
        Return DbSurgery.GetLevelOfRisk(ClsSurgery)
    End Function

#End Region

End Class
