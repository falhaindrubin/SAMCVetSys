﻿Public Class ClsUser

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

    'Add New User
    Public Function AddNewUser(ClsUser As ClsUser, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbUser.AddNewUser(ClsUser, DbConn, DbTrans)
    End Function

End Class
