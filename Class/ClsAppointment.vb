﻿Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsAppointment

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

    Private _EmpID As String
    Public Property EmpID As String
        Get
            Return _EmpID
        End Get
        Set(value As String)
            _EmpID = value
        End Set
    End Property

    Private _EmpName As String
    Public Property EmpName As String
        Get
            Return _EmpName
        End Get
        Set(value As String)
            _EmpName = value
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

    Private _AppointmentTime As DateTime
    Public Property AppointmentTime As DateTime
        Get
            Return _AppointmentTime
        End Get
        Set(value As DateTime)
            _AppointmentTime = value
        End Set
    End Property

    Private _AppointmentDesc As String
    Public Property AppointmentDesc As String
        Get
            Return _AppointmentDesc
        End Get
        Set(value As String)
            _AppointmentDesc = value
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

    Public Function AddNewAppointment(ByVal ClsAppointment As ClsAppointment, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
        Return DBAppointment.AddNewAppointment(ClsAppointment, DBConn, DBTrans)
    End Function

    Public Function GetAppointmentListing(ClsAppointment As ClsAppointment) As DataTable
        Return DBAppointment.GetAppointmentListing(ClsAppointment)
    End Function

    Public Function GetAppointmentDetail(ClsAppointment As ClsAppointment) As DataTable
        Return DBAppointment.GetAppointmentDetail(ClsAppointment)
    End Function

    Public Function RemovePetAppointment(ClsAppointment As ClsAppointment, ClsAppointmentDetail As ClsAppointmentDetail, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean
        Return DBAppointment.RemovePetAppointment(ClsAppointment, ClsAppointmentDetail, DBConn, DBTrans)
    End Function

    Public Function GetAppointmentReport(ClsAppointment As ClsAppointment) As DataTable
        Return DBAppointment.GetAppointmentReport(ClsAppointment)
    End Function

End Class
