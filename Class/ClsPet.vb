Public Class ClsPet

    Dim DbPet As New ClsDBPet

    Private _PetID As String
    Public Property PetID As String
        Get
            Return _PetID
        End Get
        Set(value As String)
            _PetID = value
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

    Private _PetName As String
    Public Property PetName As String
        Get
            Return _PetName
        End Get
        Set(value As String)
            _PetName = value
        End Set
    End Property

    Private _PetDOB As Date
    Public Property PetDOB As Date
        Get
            Return _PetDOB
        End Get
        Set(value As Date)
            _PetDOB = value
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

    Private _Ref As New ClsReference
    Property Ref() As ClsReference
        Get
            Return _Ref
        End Get
        Set(ByVal value As ClsReference)
            _Ref = value
        End Set
    End Property

    Public Function AddNewPet(ByVal ClsPet As ClsPet, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
        Return DBPet.AddNewPet(ClsPet, DBConn, DBTrans)
    End Function

    Public Function UpdatePet(ByVal ClsPet As ClsPet, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
        Return DBPet.UpdatePet(ClsPet, DBConn, DBTrans)
    End Function

    Public Function GetPetListing(ByVal ClsPet As ClsPet) As DataTable
        Return DBPet.GetPetListing(ClsPet)
    End Function

    Public Function GetAnimalType(ByVal ClsPet As ClsPet) As DataTable
        Return DBPet.GetAnimalType(ClsPet)
    End Function

    Public Function GetPetBreed(ByVal ClsPet As ClsPet) As DataTable
        Return DBPet.GetPetBreed(ClsPet)
    End Function

    Public Function GetNeuterStatus(ClsPet As ClsPet) As DataTable
        Return DbPet.GetNeuterStatus(ClsPet)
    End Function

    Public Function GetPetSex(ClsPet As ClsPet) As DataTable
        Return DBPet.GetPetSex(ClsPet)
    End Function

    Public Function GetPetTemperament(ClsPet As ClsPet) As DataTable
        Return DbPet.GetPetTemperament(ClsPet)
    End Function

    Public Function GetPetBodyScore(ClsPet As ClsPet) As DataTable
        Return DbPet.GetPetBodyScore(ClsPet)
    End Function

End Class
