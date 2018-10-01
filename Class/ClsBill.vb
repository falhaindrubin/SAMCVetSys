Imports Microsoft.VisualBasic
Imports System.Data.Odbc
Imports System

Public Class ClsBill
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

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _InvoiceDate As Date
    Public Property InvoiceDate As Date
        Get
            Return _InvoiceDate
        End Get
        Set(value As Date)
            _InvoiceDate = value
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

    Private _GrossTotal As Decimal
    Public Property GrossTotal As Decimal
        Get
            Return _GrossTotal
        End Get
        Set(value As Decimal)
            _GrossTotal = value
        End Set
    End Property

    Private _Discount As Decimal
    Public Property Discount As Decimal
        Get
            Return _Discount
        End Get
        Set(value As Decimal)
            _Discount = value
        End Set
    End Property

    Private _GrandTotal As Decimal
    Public Property GrandTotal As Decimal
        Get
            Return _GrandTotal
        End Get
        Set(value As Decimal)
            _GrandTotal = value
        End Set
    End Property

    Private _Deposit As Decimal
    Public Property Deposit As Decimal
        Get
            Return _Deposit
        End Get
        Set(value As Decimal)
            _Deposit = value
        End Set
    End Property

    Private _TotalDue As Decimal
    Public Property TotalDue As Decimal
        Get
            Return _TotalDue
        End Get
        Set(value As Decimal)
            _TotalDue = value
        End Set
    End Property

    Private _IsPaymentComplete As String
    Public Property IsPaymentComplete As String
        Get
            Return _IsPaymentComplete
        End Get
        Set(value As String)
            _IsPaymentComplete = value
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

    Public Function AddNewBill(ClsBill As ClsBill, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbBill.AddNewBill(ClsBill, DbConn, DbTrans)
    End Function

    Public Function CheckExistingBill(ClsBill As ClsBill) As DataTable
        Return DbBill.CheckExistingBill(ClsBill)
    End Function

End Class
