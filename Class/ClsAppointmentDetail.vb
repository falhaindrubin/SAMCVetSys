Public Class ClsAppointmentDetail

    Dim DBAppointment As New ClsDBAppointment

    Private _AppointmentID As String
    Public Property AppointmentID As String
        Get
            Return _AppointmentID
        End Get
        Set(value As String)
            _AppointmentID = value
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

    Private _AppointmentDescription As String
    Public Property AppointmentDescription As String
        Get
            Return _AppointmentDescription
        End Get
        Set(value As String)
            _AppointmentDescription = value
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

    Public Function AddNewAppointmentDetail(ByVal ClsAppointmentDetail As ClsAppointmentDetail, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
        Return DBAppointment.AddNewAppointmentDetail(ClsAppointmentDetail, DBConn, DBTrans)
    End Function

End Class
