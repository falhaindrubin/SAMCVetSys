Public Class ClsVetSales

    Dim DbVetSales As New ClsDbVetSales

#Region "Property"

    Private _SalesDate As Date
    Public Property SalesDate As Date
        Get
            Return _SalesDate
        End Get
        Set(value As Date)
            _SalesDate = value
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

    Private _PositionCode As String
    Public Property PositionCode As String
        Get
            Return _PositionCode
        End Get
        Set(value As String)
            _PositionCode = value
        End Set
    End Property

    Private _ChSource As Integer
    Public Property ChSource As Integer
        Get
            Return _ChSource
        End Get
        Set(value As Integer)
            _ChSource = value
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

    Public Function AddVetSales(ClsVetSales As ClsVetSales, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbVetSales.AddVetSales(ClsVetSales, DbConn, DbTrans)
    End Function

    'Public Function AddNewProduct(ClsProducts As ClsProducts, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
    '    Return DbProducts.AddNewProduct(ClsProducts, DbConn, DbTrans)
    'End Function

    'Public Function GetProductInformation(ClsProducts As ClsProducts) As DataTable
    '    Return DbProducts.GetProductInformation(ClsProducts)
    'End Function

    'Public Function GetProductTypeList(ClsProducts As ClsProducts) As DataTable
    '    Return DbProducts.GetProductTypeList(ClsProducts)
    'End Function

    'Public Function GetProductList(ClsProducts As ClsProducts) As DataTable
    '    Return DbProducts.GetProductList(ClsProducts)
    'End Function

End Class
