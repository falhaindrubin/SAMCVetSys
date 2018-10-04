Public Class ClsServices

    Dim DbServices As New ClsDbServices

    Private _ItemType As String
    Public Property ItemType As String
        Get
            Return _ItemType
        End Get
        Set(value As String)
            _ItemType = value
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

    Public Function AddNewService(ClsServices As ClsServices, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbServices.AddNewService(ClsServices, DbConn, DbTrans)
    End Function

    Public Function GetServiceList(ClsServices As ClsServices) As DataTable
        Return DbServices.GetServiceList(ClsServices)
    End Function

    Public Function GetServiceInformation(ClsServices) As DataTable
        Return DbServices.GetServiceInformation(ClsServices)
    End Function

    Public Function GetServiceTypeList(ClsServices As ClsServices) As DataTable
        Return DbServices.GetServiceTypeList(ClsServices)
    End Function

    Public Function GetTestTypeServices(ClsServices As ClsServices) As DataTable
        Return DbServices.GetTestType(ClsServices)
    End Function

End Class
