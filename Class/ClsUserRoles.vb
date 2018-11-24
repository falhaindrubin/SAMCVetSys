Public Class ClsUserRole

    Dim DbUserRole As New ClsDBUserRole

    Private _EmployeeID As String
    Public Property EmployeeID As String
        Get
            Return _EmployeeID
        End Get
        Set(value As String)
            _EmployeeID = value
        End Set
    End Property

    Private _UserID As String
    Public Property UserID As String
        Get
            Return _UserID
        End Get
        Set(value As String)
            _UserID = value
        End Set
    End Property

    Private _UserPassword As String
    Public Property UserPassword As String
        Get
            Return _UserPassword
        End Get
        Set(value As String)
            _UserPassword = value
        End Set
    End Property

    Private _UserRole As String
    Public Property UserRole As String
        Get
            Return _UserRole
        End Get
        Set(value As String)
            _UserRole = value
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

    'Add New User
    Public Function AddNewRole(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.AddNewRole(ClsUserRole, DbConn, DbTrans)
        'GetUserRoles(ClsUserRoles)
    End Function

    'Get User information
    Public Function GetUserRole(ClsUserRole As ClsUserRole) As DataTable
        Return DbUserRole.GetUserRole(ClsUserRole)
    End Function

End Class
