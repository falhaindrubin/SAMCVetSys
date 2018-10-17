Public Class ClsPEFindings

    Dim DbPEFindings As New ClsDbPEFindings

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _PetID As String
    Public Property PetID As String
        Get
            Return _PetID
        End Get
        Set(value As String)
            _PetID = value
        End Set
    End Property

    Private _PetName As String
    Public Property PetName As String
        Get
            Return _PetName
        End Get
        Set(value As String)
            _PetName = value
        End Set
    End Property

    Private _Temperature As String
    Public Property Temperature As String
        Get
            Return _Temperature
        End Get
        Set(value As String)
            _Temperature = value
        End Set
    End Property

    Private _TemperamentCode As String
    Public Property TemperamentCode As String
        Get
            Return _TemperamentCode
        End Get
        Set(value As String)
            _TemperamentCode = value
        End Set
    End Property

    Private _TemperamentName As String
    Public Property TemperamentName As String
        Get
            Return _TemperamentName
        End Get
        Set(value As String)
            _TemperamentName = value
        End Set
    End Property

    Private _BodyScoreCode As String
    Public Property BodyScoreCode As String
        Get
            Return _BodyScoreCode
        End Get
        Set(value As String)
            _BodyScoreCode = value
        End Set
    End Property

    Private _BodyScoreName As String
    Public Property BodyScoreName As String
        Get
            Return _BodyScoreName
        End Get
        Set(value As String)
            _BodyScoreName = value
        End Set
    End Property

    Private _BodyWeight As String
    Public Property BodyWeight As String
        Get
            Return _BodyWeight
        End Get
        Set(value As String)
            _BodyWeight = value
        End Set
    End Property

    Private _PEFindings As String
    Public Property PEFindings As String
        Get
            Return _PEFindings
        End Get
        Set(value As String)
            _PEFindings = value
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

    Public Function AddNewPEFindings(ClsPEFindings As ClsPEFindings, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbPEFindings.AddNewFindings(ClsPEFindings, DbConn, DbTrans)
    End Function

    Public Function GetPEFindings(ClsPEFindings As ClsPEFindings) As DataTable
        Return DbPEFindings.GetPEFindings(ClsPEFindings)
    End Function

End Class
