Public Class ClsLogin

    Dim DBLogin As New ClsDBLogin

    Private _UserID As String
    Public Property UserID As String
        Get
            Return _UserID
        End Get
        Set(value As String)
            _UserID = value
        End Set
    End Property

    Private _Password As String
    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Function GetUser(ByVal ClsLogin As ClsLogin, ByRef DBConn As OdbcConnection) As DataTable
        Return DBLogin.GetUser(ClsLogin, DBConn)
    End Function

End Class
