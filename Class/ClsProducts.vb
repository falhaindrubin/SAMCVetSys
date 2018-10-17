Public Class ClsProducts

    Dim DbProducts As New ClsDbProducts

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

    Private _UnitPrice As Decimal
    Public Property UnitPrice As Decimal
        Get
            Return _UnitPrice
        End Get
        Set(value As Decimal)
            _UnitPrice = value
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

    Public Function AddNewProduct(ClsProducts As ClsProducts, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbProducts.AddNewProduct(ClsProducts, DbConn, DbTrans)
    End Function

    Public Function GetProductInformation(ClsProducts As ClsProducts) As DataTable
        Return DbProducts.GetProductInformation(ClsProducts)
    End Function

    Public Function GetProductTypeList(ClsProducts As ClsProducts) As DataTable
        Return DbProducts.GetProductTypeList(ClsProducts)
    End Function

    Public Function GetProductList(ClsProducts As ClsProducts) As DataTable
        Return DbProducts.GetProductList(ClsProducts)
    End Function

End Class
