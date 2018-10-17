Public Class ClsDiagnosisDetail

    Dim DbDiagnosis As New ClsDbDiagnosis

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _RowNo As String
    Public Property RowNo As String
        Get
            Return _RowNo
        End Get
        Set(value As String)
            _RowNo = value
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

    Private _ItemDescription As String
    Public Property ItemDescription As String
        Get
            Return _ItemDescription
        End Get
        Set(value As String)
            _ItemDescription = value
        End Set
    End Property

    Private _UnitPrice As String
    Public Property UnitPrice As String
        Get
            Return _UnitPrice
        End Get
        Set(value As String)
            _UnitPrice = value
        End Set
    End Property

    Private _Quantity As String
    Public Property Quantity As String
        Get
            Return _Quantity
        End Get
        Set(value As String)
            _Quantity = value
        End Set
    End Property

    Private _TotalPrice As String
    Public Property TotalPrice As String
        Get
            Return _TotalPrice
        End Get
        Set(value As String)
            _TotalPrice = value
        End Set
    End Property

    Public Function AddNewDiagnosisDetail(ClsDiagnosisDetail As ClsDiagnosisDetail, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbDiagnosis.AddNewDiagnosisDetail(ClsDiagnosisDetail, DbConn, DbTrans)
    End Function

End Class
