Public Class ClsWardDiagnosisDetail

    Dim DbWard As New ClsDbWard

    Private _WardID As String
    Public Property WardID As String
        Get
            Return _WardID
        End Get
        Set(value As String)
            _WardID = value
        End Set
    End Property

    Private _DiagnoseDate As Date
    Public Property DiagnoseDate As Date
        Get
            Return _DiagnoseDate
        End Get
        Set(value As Date)
            _DiagnoseDate = value
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

    Private _ItemGroup As String
    Public Property ItemGroup As String
        Get
            Return _ItemGroup
        End Get
        Set(value As String)
            _ItemGroup = value
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

    Private _ItemTypeDescription As String
    Public Property ItemTypeDescription As String
        Get
            Return _ItemTypeDescription
        End Get
        Set(value As String)
            _ItemTypeDescription = value
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

    Private _Quantity As Decimal
    Public Property Quantity As Decimal
        Get
            Return _Quantity
        End Get
        Set(value As Decimal)
            _Quantity = value
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

    Public Function AddNewWardDiagnosisDetail(ClsWardDiagnosisDetail As ClsWardDiagnosisDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.AddNewWardDiagnosisDetail(ClsWardDiagnosisDetail, DbConn, DbTrans)
    End Function

End Class
