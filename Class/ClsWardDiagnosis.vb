Public Class ClsWardDiagnosis

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

    Private _Diagnosis As String
    Public Property Diagnosis As String
        Get
            Return _Diagnosis
        End Get
        Set(value As String)
            _Diagnosis = value
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

    Public Function AddNewWardDiagnosis(ClsWardDiagnosis As ClsWardDiagnosis, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.AddNewWardDiagnosis(ClsWardDiagnosis, DbConn, DbTrans)
    End Function

    Public Function GetWardDiagnosis(ClsWardDiagnosis As ClsWardDiagnosis) As DataTable
        Return DbWard.GetWardDiagnosis(ClsWardDiagnosis)
    End Function

    Public Function GetWardDiagnosisDetail(ClsWardDiagnosis As ClsWardDiagnosis) As DataTable
        Return DbWard.GetWardDiagnosisDetail(ClsWardDiagnosis)
    End Function

End Class
