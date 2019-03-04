Public Class ClsServices

    Dim DbServices As New ClsDbServices

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

    Private _SQLQueryCondition As String
    Public Property SQLQueryCondition As String
        Get
            Return _SQLQueryCondition
        End Get
        Set(value As String)
            _SQLQueryCondition = value
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

    Public Function GetTestType(ClsServices As ClsServices) As DataTable
        Return DbServices.GetTestType(ClsServices)
    End Function

    Public Function GetTestTypeName(ClsServices As ClsServices) As DataTable
        Return DbServices.GetTestTypeName(ClsServices)
    End Function

    'Public Function GetServicesType(ClsServices As ClsServices) As DataTable
    '    Return DbServices.GetServiceTypeList(ClsServices)
    'End Function

End Class
