Public Class ClsWardHourly

    Dim DbWard As New ClsDbWard

#Region "FormProperty"
    Private _WardID As String
    Public Property WardID As String
        Get
            Return _WardID
        End Get
        Set(value As String)
            _WardID = value
        End Set
    End Property

    Private _RowNo As Integer
    Public Property RowNo As Integer
        Get
            Return _RowNo
        End Get
        Set(value As Integer)
            _RowNo = value
        End Set
    End Property

    Private _WardDate As DateTime
    Public Property WardDate As DateTime
        Get
            Return _WardDate
        End Get
        Set(value As DateTime)
            _WardDate = value
        End Set
    End Property

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

    Private _HourlyNotes As String
    Public Property HourlyNotes As String
        Get
            Return _HourlyNotes
        End Get
        Set(value As String)
            _HourlyNotes = value
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

    Public Function AddNewWardHourly(ClsWardHourly As ClsWardHourly, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.AddNewWardHourly(ClsWardHourly, DbConn, DbTrans)
    End Function

    Public Function GetWardHourly(ClsWardHourly) As DataTable
        Return DbWard.GetWardHourly(ClsWardHourly)
    End Function

End Class
