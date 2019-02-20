Public Class ClsDiagnosis

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

    Private _DiagnosisDate As DateTime
    Public Property DiagnosisDate As DateTime
        Get
            Return _DiagnosisDate
        End Get
        Set(value As DateTime)
            _DiagnosisDate = value
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

    Private _Diagnosis As String
    Public Property Diagnosis As String
        Get
            Return _Diagnosis
        End Get
        Set(value As String)
            _Diagnosis = value
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

    Public Function AddNewDiagnosis(ClsDiagnosis As ClsDiagnosis, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbDiagnosis.AddNewDiagnosis(ClsDiagnosis, DbConn, DbTrans)
    End Function

    Public Function GetDiagnosisDetail(ClsDiagnosis As ClsDiagnosis) As DataTable
        Return DbDiagnosis.GetDiagnosisDetail(ClsDiagnosis)
    End Function

End Class
