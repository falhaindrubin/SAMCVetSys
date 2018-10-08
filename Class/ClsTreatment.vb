﻿Public Class ClsTreatment

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

    Private _RowNo As String
    Public Property RowNo As String
        Get
            Return _RowNo
        End Get
        Set(value As String)
            _RowNo = value
        End Set
    End Property

    Private _ItemCode As String
    Public Property ItemCode As String
        Get
            Return _ItemCode
        End Get
        Set(value As String)
            _ItemCode = value
        End Set
    End Property

    Private _ItemDescription As String
    Public Property ItemDescription As String
        Get
            Return _ItemDescription
        End Get
        Set(value As String)
            _ItemDescription = value
        End Set
    End Property

    Private _ItemTypeCode As String
    Public Property ItemTypeCode As String
        Get
            Return _ItemTypeCode
        End Get
        Set(value As String)
            _ItemTypeCode = value
        End Set
    End Property

    Private _Prescription As String
    Public Property Prescription As String
        Get
            Return _Prescription
        End Get
        Set(value As String)
            _Prescription = value
        End Set
    End Property

    Private _Notes As String
    Public Property Notes As String
        Get
            Return _Notes
        End Get
        Set(value As String)
            _Notes = value
        End Set
    End Property

    Private _UnitPrice As String
    Public Property UnitPrice As String
        Get
            Return _UnitPrice
        End Get
        Set(value As String)
            _UnitPrice = value
        End Set
    End Property

    Private _Quantity As String
    Public Property Quantity As String
        Get
            Return _Quantity
        End Get
        Set(value As String)
            _Quantity = value
        End Set
    End Property

    Private _TotalPrice As String
    Public Property TotalPrice As String
        Get
            Return _TotalPrice
        End Get
        Set(value As String)
            _TotalPrice = value
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

    Public Function AddNewTreatment(ClsTreatment As ClsTreatment, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbTreatment.AddNewTreatment(ClsTreatment, DbConn, DbTrans)
    End Function

End Class