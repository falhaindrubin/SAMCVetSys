Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsTreatment

#Region "Property"

    Dim DbTreatment As New ClsDbTreatment

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _TreatmentDate As DateTime
    Public Property TreatmentDate As DateTime
        Get
            Return _TreatmentDate
        End Get
        Set(value As DateTime)
            _TreatmentDate = value
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

    Private _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
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

    Private _IsVisitCompleted As String
    Public Property IsVisitCompleted As String
        Get
            Return _IsVisitCompleted
        End Get
        Set(value As String)
            _IsVisitCompleted = value
        End Set
    End Property

    Private _IsOngoingTreatment As String
    Public Property IsOngoingTreatment As String
        Get
            Return _IsOngoingTreatment
        End Get
        Set(value As String)
            _IsOngoingTreatment = value
        End Set
    End Property

    Private _IsAdmittedToWard As String
    Public Property IsAdmittedToWard As String
        Get
            Return _IsAdmittedToWard
        End Get
        Set(value As String)
            _IsAdmittedToWard = value
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

    Public Function AddNewTreatment(ClsTreatment As ClsTreatment, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbTreatment.AddNewTreatment(ClsTreatment, DbConn, DbTrans)
    End Function

    Public Function GetTreatment(ClsTreatment As ClsTreatment) As DataTable
        Return DbTreatment.GetTreatment(ClsTreatment)
    End Function

    Public Function GetTreatmentDetail(ClsTreatment As ClsTreatment) As DataTable
        Return DbTreatment.GetTreatmentDetail(ClsTreatment)
    End Function

End Class
