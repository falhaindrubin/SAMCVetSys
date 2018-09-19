Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsConsultationDetail
    ReadOnly DbConsultation As New ClsDbConsultation

    Private _ConsultationID As String
    Public Property ConsultationID As String
        Get
            Return _ConsultationID
        End Get
        Set(value As String)
            _ConsultationID = value
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

    Private _ConsultationDesc As String
    Public Property ConsultationDesc As String
        Get
            Return _ConsultationDesc
        End Get
        Set(value As String)
            _ConsultationDesc = value
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

    Public Function AddNewConsultationDetail(ClsConsultationDetail As ClsConsultationDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbConsultation.AddNewConsultationDetail(ClsConsultationDetail, DbConn, DbTrans)
    End Function

End Class
