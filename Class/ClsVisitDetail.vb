Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsVisitDetail
    ReadOnly DbVisit As New ClsDbVisit

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
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

    Private _StatusCode As String
    Public Property StatusCode As String
        Get
            Return _StatusCode
        End Get
        Set(value As String)
            _StatusCode = value
        End Set
    End Property

    Private _StatusName As String
    Public Property StatusName As String
        Get
            Return _StatusName
        End Get
        Set(value As String)
            _StatusName = value
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

    Private _VisitDescription As String
    Public Property VisitDescription As String
        Get
            Return _VisitDescription
        End Get
        Set(value As String)
            _VisitDescription = value
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

    Private _BodyWeight As Decimal
    Public Property BodyWeight As Decimal
        Get
            Return _BodyWeight
        End Get
        Set(value As Decimal)
            _BodyWeight = value
        End Set
    End Property

    Private _PEFindings As String
    Public Property PEFindings As String
        Get
            Return _PEFindings
        End Get
        Set(value As String)
            _PEFindings = value
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

    Public Function AddNewVisitDetail(ClsVisitDetail As ClsVisitDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.AddNewVisitDetail(ClsVisitDetail, DbConn, DbTrans)
    End Function

End Class
