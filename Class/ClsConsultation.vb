Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsConsultation

    Dim DbConsultation As New ClsDbConsultation

    Private _ConsultationID As String
    Public Property ConsultationID As String
        Get
            Return _ConsultationID
        End Get
        Set(value As String)
            _ConsultationID = value
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

    Private _ConsultationTime As DateTime
    Public Property ConsultationTime As DateTime
        Get
            Return _ConsultationTime
        End Get
        Set(value As DateTime)
            _ConsultationTime = value
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

    'Public Function AddNewAppointment(ByVal ClsAppointment As ClsAppointment, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
    '    Return DBAppointment.AddNewAppointment(ClsAppointment, DBConn, DBTrans)
    'End Function

    'Public Function GetAppointmentListing(ClsAppointment As ClsAppointment) As DataTable
    '    Return DBAppointment.GetAppointmentListing(ClsAppointment)
    'End Function

    'Public Function GetAppointmentDetail(ClsAppointment As ClsAppointment) As DataTable
    '    Return DBAppointment.GetAppointmentDetail(ClsAppointment)
    'End Function

    'Public Function RemovePetAppointment(ClsAppointment As ClsAppointment, ClsAppointmentDetail As ClsAppointmentDetail, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean
    '    Return DBAppointment.RemovePetAppointment(ClsAppointment, ClsAppointmentDetail, DBConn, DBTrans)
    'End Function

    'Public Function GetAppointmentReport(ClsAppointment As ClsAppointment) As DataTable
    '    Return DBAppointment.GetAppointmentReport(ClsAppointment)
    'End Function

    'Public Function GetAppointmentSummary(ByVal ClsAppointment As ClsAppointment, ByRef DBConn As OdbcConnection) As DataTable
    '    Return DBAppointment.GetAppointmentSummary(ClsAppointment, DBConn)
    'End Function

    'Public Function CheckExistingAppointment(ByVal ClsAppointment As ClsAppointment, ByRef DBConn As OdbcConnection) As DataTable
    '    Return DBAppointment.CheckExistingAppointment(ClsAppointment, DBConn)
    'End Function

    'Public Function GetAppointmentHistory(ClsAppointment As ClsAppointment, DBConn As OdbcConnection) As DataTable
    '    Return DBAppointment.GetAppointmentHistory(ClsAppointment, DBConn)
    'End Function

    Public Function GetConsultationDetail(ClsConsultation As ClsConsultation) As DataTable
        Return DbConsultation.GetConsultationDetail(ClsConsultation)
    End Function

End Class
