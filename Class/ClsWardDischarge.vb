Public Class ClsWardDischarge

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

    Private _DischargeDate As Date
    Public Property DischargeDate As Date
        Get
            Return _DischargeDate
        End Get
        Set(value As Date)
            _DischargeDate = value
        End Set
    End Property

    Private _AdmitIssue As String
    Public Property AdmitIssue As String
        Get
            Return _AdmitIssue
        End Get
        Set(value As String)
            _AdmitIssue = value
        End Set
    End Property

    Private _AdmitDiagnosis As String
    Public Property AdmitDiagnosis As String
        Get
            Return _AdmitDiagnosis
        End Get
        Set(value As String)
            _AdmitDiagnosis = value
        End Set
    End Property

    Private _DischargeCondition As String
    Public Property DischargeCondition As String
        Get
            Return _DischargeCondition
        End Get
        Set(value As String)
            _DischargeCondition = value
        End Set
    End Property

    Private _DischargeReason As String
    Public Property DischargeReason As String
        Get
            Return _DischargeReason
        End Get
        Set(value As String)
            _DischargeReason = value
        End Set
    End Property

    Private _PossibleComplications As String
    Public Property PossibleComplications As String
        Get
            Return _PossibleComplications
        End Get
        Set(value As String)
            _PossibleComplications = value
        End Set
    End Property

    Private _AdditionalInstruction As String
    Public Property AdditionalInstruction As String
        Get
            Return _AdditionalInstruction
        End Get
        Set(value As String)
            _AdditionalInstruction = value
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

    Public Function AddNewWardDischarge(ClsWardDischarge As ClsWardDischarge, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbWard.AddNewWardDischarge(ClsWardDischarge, DbConn, DbTrans)
    End Function

End Class
