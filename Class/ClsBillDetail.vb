Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsBillDetail
    ReadOnly DbBill As New ClsDbBill

    Private _InvoiceNo As String
    Public Property InvoiceNo As String
        Get
            Return _InvoiceNo
        End Get
        Set(value As String)
            _InvoiceNo = value
        End Set
    End Property

    Private _RowNo As Integer
    Public Property RowNo As Integer
        Get
            Return _RowNo
        End Get
        Set(value As Integer)
            _RowNo = value
        End Set
    End Property

    Private _NewRowNo As Integer
    Public Property NewRowNo As Integer
        Get
            Return _NewRowNo
        End Get
        Set(value As Integer)
            _NewRowNo = value
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

    Private _Quantity As Decimal
    Public Property Quantity As Decimal
        Get
            Return _Quantity
        End Get
        Set(value As Decimal)
            _Quantity = value
        End Set
    End Property

    Private _UnitPrice As Decimal
    Public Property UnitPrice As Decimal
        Get
            Return _UnitPrice
        End Get
        Set(value As Decimal)
            _UnitPrice = value
        End Set
    End Property

    Private _ItemDiscount As Decimal
    Public Property ItemDiscount As Decimal
        Get
            Return _ItemDiscount
        End Get
        Set(value As Decimal)
            _ItemDiscount = value
        End Set
    End Property

    Private _TotalPrice As Decimal
    Public Property TotalPrice As Decimal
        Get
            Return _TotalPrice
        End Get
        Set(value As Decimal)
            _TotalPrice = value
        End Set
    End Property

    Public Function AddNewBillDetail(ClsBillDetail As ClsBillDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbBill.AddNewBillDetail(ClsBillDetail, DbConn, DbTrans)
    End Function

    Public Function DeleteBillItems(ClsBillDetail As ClsBillDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbBill.DeleteBillItems(ClsBillDetail, DbConn, DbTrans)
    End Function

    Public Function UpdateBillRowNo(ClsBillDetail As ClsBillDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbBill.UpdateBillRowNo(ClsBillDetail, DbConn, DbTrans)
    End Function

End Class
