Public Class ClsProducts

    Dim DbProducts As New ClsDbProducts

    Private _ItemType As String
    Public Property ItemType As String
        Get
            Return _ItemType
        End Get
        Set(value As String)
            _ItemType = value
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

    Private _Price As Decimal
    Public Property Price As Decimal
        Get
            Return _Price
        End Get
        Set(value As Decimal)
            _Price = value
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

    Public Function GetProductTypeList(ClsProducts As ClsProducts) As DataTable
        Return DbProducts.GetProductTypeList(ClsProducts)
    End Function

End Class
