Public Class ClsUser

    Dim DbUser As New ClsDBUser

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
    Public Function AddNewUser(ClsUser As ClsUser, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUser.AddNewUser(ClsUser, DbConn, DbTrans)
    End Function

    'Get User
    Public Function GetUser(ClsUser As ClsUser) As DataTable
        Return DbUser.GetUser(ClsUser)
    End Function

    'Get User information
    Public Function GetUserInformation(ClsUser As ClsUser) As DataTable
        Return DbUser.GetUserInformation(ClsUser)
    End Function

End Class
