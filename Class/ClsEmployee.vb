﻿Public Class ClsEmployee

    Dim DBEmployee As New ClsDBEmployee

    Private _EmpID As String
    Public Property EmpID As String
        Get
            Return _EmpID
        End Get
        Set(value As String)
            _EmpID = value
        End Set
    End Property

    Private _EmpName As String
    Public Property EmpName As String
        Get
            Return _EmpName
        End Get
        Set(value As String)
            _EmpName = value
        End Set
    End Property

    'Get Vet
    Public Function GetVet(ByVal ClsEmployee As ClsEmployee) As DataTable
        Return DBEmployee.GetVet(ClsEmployee)
    End Function

End Class
