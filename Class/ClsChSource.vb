Public Class ClsChSource

    Dim DbChSource As New ClsDbChSource

#Region "Property"

    Private _ChSource As String
    Public Property ChSource As String
        Get
            Return _ChSource
        End Get
        Set(value As String)
            _ChSource = value
        End Set
    End Property

    Private _ChSourceName As String
    Public Property ChSourceName As String
        Get
            Return _ChSourceName
        End Get
        Set(value As String)
            _ChSourceName = value
        End Set
    End Property

    Private _ChSourceDescription As String
    Public Property ChSourceDescription As String
        Get
            Return _ChSourceDescription
        End Get
        Set(value As String)
            _ChSourceDescription = value
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

    'Add New User
    Public Function AddNewUser(ClsUser As ClsUser, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbChSource.AddNewUser(ClsUser, DbConn, DbTrans)
    End Function

    'Get User
    Public Function GetUser(ClsUser As ClsUser) As DataTable
        Return DbChSource.GetUser(ClsUser)
    End Function

    'Get User information
    Public Function GetChSource(ClsChSource As ClsChSource) As DataTable
        Return DbChSource.GetChSource(ClsChSource)
    End Function

End Class
