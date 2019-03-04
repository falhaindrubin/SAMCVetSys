Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsVisit

    Dim DbVisit As New ClsDbVisit

#Region "Property"

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

    Private _VisitTime As DateTime
    Public Property VisitTime As DateTime
        Get
            Return _VisitTime
        End Get
        Set(value As DateTime)
            _VisitTime = value
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

    Private _IsCompleted As String
    Public Property IsCompleted As String
        Get
            Return _IsCompleted
        End Get
        Set(value As String)
            _IsCompleted = value
        End Set
    End Property

    Private _IsWarded As String
    Public Property IsWarded As String
        Get
            Return _IsWarded
        End Get
        Set(value As String)
            _IsWarded = value
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

    Private _SQLQueryCondition As String
    Public Property SQLQueryCondition As String
        Get
            Return _SQLQueryCondition
        End Get
        Set(value As String)
            _SQLQueryCondition = value
        End Set
    End Property

#End Region

    Public Function GetVisitListing(ClsVisit As ClsVisit) As DataTable
        Return DbVisit.GetVisitListing(ClsVisit)
    End Function

    Public Function GetUnassignedVisitListing(ClsVisit As ClsVisit) As DataTable
        Return DbVisit.GetUnassignedVisitListing(ClsVisit)
    End Function

    Public Function AddNewVisit(ClsConsultation As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.AddNewVisit(ClsConsultation, DbConn, DbTrans)
    End Function

    Public Function GetVisit(ClsVisit As ClsVisit) As DataTable
        Return DbVisit.GetVisit(ClsVisit)
    End Function

    Public Function GetVisitDetail(ClsVisit As ClsVisit) As DataTable
        Return DbVisit.GetVisitDetail(ClsVisit)
    End Function

    Public Function UpdateIsVisitCompleted(ClsVisit As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.UpdateIsVisitCompleted(ClsVisit, DbConn, DbTrans)
    End Function

    Public Function UpdateTreatmentStatus(ClsVisit As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.UpdateTreatmentStatus(ClsVisit, DbConn, DbTrans)
    End Function

    Public Function GetIncompleteVisitListing(ClsVisit As ClsVisit) As DataTable
        Return DbVisit.GetIncompleteVisitListing(ClsVisit)
    End Function

    Public Function UpdateWardAdmission(ClsVisit As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.UpdateWardAdmission(ClsVisit, DbConn, DbTrans)
    End Function

    Public Function GetAdmittedToWardVisit(ClsVisit) As DataTable
        Return DbVisit.GetAdmittedToWardVisit(ClsVisit)
    End Function

End Class
