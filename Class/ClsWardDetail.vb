Public Class ClsWardDetail

    Dim DbWard As New ClsDbWard

    Private _WardID As String
    Public Property WardID As String
        Get
            Return _WardID
        End Get
        Set(value As String)
            _WardID = value
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

    Private _WardDate As Date
    Public Property WardDate As Date
        Get
            Return _WardDate
        End Get
        Set(value As Date)
            _WardDate = value
        End Set
    End Property

    Private _IsFasting As String
    Public Property IsFasting As String
        Get
            Return _IsFasting
        End Get
        Set(value As String)
            _IsFasting = value
        End Set
    End Property

    Private _FastingDescription As String
    Public Property FastingDescription As String
        Get
            Return _FastingDescription
        End Get
        Set(value As String)
            _FastingDescription = value
        End Set
    End Property

    Private _Appetite As String
    Public Property Appetite As String
        Get
            Return _Appetite
        End Get
        Set(value As String)
            _Appetite = value
        End Set
    End Property

    Private _AppetiteDescription As String
    Public Property AppetiteDescription As String
        Get
            Return _AppetiteDescription
        End Get
        Set(value As String)
            _AppetiteDescription = value
        End Set
    End Property

    Private _Bowel As String
    Public Property Bowel As String
        Get
            Return _Bowel
        End Get
        Set(value As String)
            _Bowel = value
        End Set
    End Property

    Private _BowelDescription As String
    Public Property BowelDescription As String
        Get
            Return _BowelDescription
        End Get
        Set(value As String)
            _BowelDescription = value
        End Set
    End Property

    Private _Urine As String
    Public Property Urine As String
        Get
            Return _Urine
        End Get
        Set(value As String)
            _Urine = value
        End Set
    End Property

    Private _UrineDescription As String
    Public Property UrineDescription As String
        Get
            Return _UrineDescription
        End Get
        Set(value As String)
            _UrineDescription = value
        End Set
    End Property

    Private _Vomit As String
    Public Property Vomit As String
        Get
            Return _Vomit
        End Get
        Set(value As String)
            _Vomit = value
        End Set
    End Property

    Private _VomitDescription As String
    Public Property VomitDescription As String
        Get
            Return _VomitDescription
        End Get
        Set(value As String)
            _VomitDescription = value
        End Set
    End Property

    Private _Food As String
    Public Property Food As String
        Get
            Return _Food
        End Get
        Set(value As String)
            _Food = value
        End Set
    End Property

    Private _Diagnosis As String
    Public Property Diagnosis As String
        Get
            Return _Diagnosis
        End Get
        Set(value As String)
            _Diagnosis = value
        End Set
    End Property

    Private _DailyNotes As String
    Public Property DailyNotes As String
        Get
            Return _DailyNotes
        End Get
        Set(value As String)
            _DailyNotes = value
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

    Public Function AddNewWardDetail(ClsWardDetail As ClsWardDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.AddNewWardDetail(ClsWardDetail, DbConn, DbTrans)
    End Function

End Class
