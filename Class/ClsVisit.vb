Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsVisit

    Dim DbVisit As New ClsDbVisit

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
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

    Private _VisitTime As DateTime
    Public Property VisitTime As DateTime
        Get
            Return _VisitTime
        End Get
        Set(value As DateTime)
            _VisitTime = value
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

    Public Function GetVisitListing(ClsVisit As ClsVisit) As DataTable
        Return DbVisit.GetVisitListing(ClsVisit)
    End Function

    Public Function AddNewConsultation(ClsConsultation As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.AddNewVisit(ClsConsultation, DbConn, DbTrans)
    End Function

    Public Function GetConsultationDetail(ClsConsultation As ClsVisit) As DataTable
        Return DbVisit.GetVisitDetail(ClsConsultation)
    End Function

    Public Function UpdateIsCompleted(ClsConsultation As ClsVisit, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVisit.UpdateIsCompleted(ClsConsultation, DbConn, DbTrans)
    End Function

End Class
