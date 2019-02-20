Public Class ClsUserRole

    Dim DbUserRole As New ClsDbUserRole

#Region "Property"

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

    Private _RoleCode As String
    Public Property RoleCode As String
        Get
            Return _RoleCode
        End Get
        Set(value As String)
            _RoleCode = value
        End Set
    End Property

    Private _RoleName As String
    Public Property RoleName As String
        Get
            Return _RoleName
        End Get
        Set(value As String)
            _RoleName = value
        End Set
    End Property

    Private _AccessTag As String
    Public Property AccessTag As String
        Get
            Return _AccessTag
        End Get
        Set(value As String)
            _AccessTag = value
        End Set
    End Property

    Private _HasAccess As String
    Public Property HasAccess As String
        Get
            Return _HasAccess
        End Get
        Set(value As String)
            _HasAccess = value
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
    Public Function AddRole(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.AddRole(ClsUserRole, DbConn, DbTrans)
    End Function

    Public Function AddRoleAccessRight(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.AddRoleAccessRight(ClsUserRole, DbConn, DbTrans)
    End Function

    'Add User Access Right
    Public Function AddUserAccessRight(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.AddUserAccessRight(ClsUserRole, DbConn, DbTrans)
    End Function

    'Get User Role
    Public Function GetRole(ClsUserRole As ClsUserRole) As DataTable
        Return DbUserRole.GetRole(ClsUserRole)
    End Function

    Public Function GetRoleAccessRight(ClsUserRole As ClsUserRole) As DataTable
        Return DbUserRole.GetRoleAccessRight(ClsUserRole)
    End Function

    'Get User Access Right
    Public Function GetUserAccessRight(ClsUserRole As ClsUserRole) As DataTable
        Return DbUserRole.GetUserAccessRight(ClsUserRole)
    End Function

    'Delete Role
    Public Function DeleteRole(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.DeleteRole(ClsUserRole, DbConn, DbTrans)
    End Function

    Public Function DeleteAccessRight(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.DeleteAccessRight(ClsUserRole, DbConn, DbTrans)
    End Function

    Public Function DeleteUserAccessRight(ClsUserRole As ClsUserRole, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUserRole.DeleteUserAccessRight(ClsUserRole, DbConn, DbTrans)
    End Function

End Class
