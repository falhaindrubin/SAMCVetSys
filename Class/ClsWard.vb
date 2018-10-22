Public Class ClsWard

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

    Private _VisitID As String
    Public Property VisitID As String
        Get
            Return _VisitID
        End Get
        Set(value As String)
            _VisitID = value
        End Set
    End Property

    Private _AdmissionDate As DateTime
    Public Property AdmissionDate As DateTime
        Get
            Return _AdmissionDate
        End Get
        Set(value As DateTime)
            _AdmissionDate = value
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

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
        End Set
    End Property

    Private _CustomerName As String
    Public Property CustomerName As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
        End Set
    End Property

    Private _PetCase As String
    Public Property PetCase As String
        Get
            Return _PetCase
        End Get
        Set(value As String)
            _PetCase = value
        End Set
    End Property

    Private _IsDischarged As String
    Public Property IsDischarged As String
        Get
            Return _IsDischarged
        End Get
        Set(value As String)
            _IsDischarged = value
        End Set
    End Property

    Private _GetTodayVet As String
    Public Property GetTodayVet As String
        Get
            Return _GetTodayVet
        End Get
        Set(value As String)
            _GetTodayVet = value
        End Set
    End Property

    Private _DischargeDate As DateTime
    Public Property DischargeDate As DateTime
        Get
            Return _DischargeDate
        End Get
        Set(value As DateTime)
            _DischargeDate = value
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

    Public Function AddNewWard(ClsWard As ClsWard, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.AddNewWard(ClsWard, DbConn, DbTrans)
    End Function

    Public Function GetWardDetail(ClsWard) As DataTable
        Return DbWard.GetWardDetail(ClsWard)
    End Function

    Public Function GetWardListing(ClsWard) As DataTable
        Return DbWard.GetWardListing(ClsWard)
    End Function

    Public Function DischargePet(ClsWard As ClsWard, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.DischargePet(ClsWard, DbConn, DbTrans)
    End Function

End Class
