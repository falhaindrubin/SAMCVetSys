Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsPharmacy

    Dim DbPharmacy As New ClsDbPharmacy

#Region "FormProperty"

    Private _RequestID As String
    Public Property RequestID As String
        Get
            Return _RequestID
        End Get
        Set(value As String)
            _RequestID = value
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

    Private _Source As String
    Public Property Source As String
        Get
            Return _Source
        End Get
        Set(value As String)
            _Source = value
        End Set
    End Property

    Private _RequestDate As DateTime
    Public Property RequestDate As DateTime
        Get
            Return _RequestDate
        End Get
        Set(value As DateTime)
            _RequestDate = value
        End Set
    End Property

    Private _RqEmpID As String
    Public Property RqEmpID As String
        Get
            Return _RqEmpID
        End Get
        Set(value As String)
            _RqEmpID = value
        End Set
    End Property

    Private _RqEmpName As String
    Public Property RqEmpName As String
        Get
            Return _RqEmpName
        End Get
        Set(value As String)
            _RqEmpName = value
        End Set
    End Property

    Private _PhEmpID As String
    Public Property PhEmpID As String
        Get
            Return _PhEmpID
        End Get
        Set(value As String)
            _PhEmpID = value
        End Set
    End Property

    Private _PhEmpName As String
    Public Property PhEmpName As String
        Get
            Return _PhEmpName
        End Get
        Set(value As String)
            _PhEmpName = value
        End Set
    End Property

    Private _ApprovalDate As DateTime
    Public Property ApprovalDate As DateTime
        Get
            Return _ApprovalDate
        End Get
        Set(value As DateTime)
            _ApprovalDate = value
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

    'Add pharmacy request into the database
    Public Function AddNewPharmacyRequest(ClsPharmacy As ClsPharmacy, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbPharmacy.AddNewPharmacyRequest(ClsPharmacy, DbConn, DbTrans)
    End Function

    'Get pharmacy header
    Public Function GetPharmacyRequest(ClsPharcmacy As ClsPharmacy) As DataTable
        Return DbPharmacy.GetPharmacyRequest(ClsPharcmacy)
    End Function

    'Get pharmacy detail
    Public Function GetPharmacyRequestDetail(ClsPharcmacy As ClsPharmacy) As DataTable
        Return DbPharmacy.GetPharmacyRequestDetail(ClsPharcmacy)
    End Function

End Class
