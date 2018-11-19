Public Class ClsSurgeryDischarge

    Dim DbSurgery As New ClsDbSurgery

    Private _CaseID As String
    Public Property CaseID As String
        Get
            Return _CaseID
        End Get
        Set(value As String)
            _CaseID = value
        End Set
    End Property

    Private _SurgeryDate As Date
    Public Property SurgeryDate As Date
        Get
            Return _SurgeryDate
        End Get
        Set(value As Date)
            _SurgeryDate = value
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

    Private _SpecificInstruction As String
    Public Property SpecificInstruction As String
        Get
            Return _SpecificInstruction
        End Get
        Set(value As String)
            _SpecificInstruction = value
        End Set
    End Property

    Private _MedicationPrescribe As String
    Public Property MedicationPrescribe As String
        Get
            Return _MedicationPrescribe
        End Get
        Set(value As String)
            _MedicationPrescribe = value
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

    Private _ItemDescription As String
    Public Property ItemDescription As String
        Get
            Return _ItemDescription
        End Get
        Set(value As String)
            _ItemDescription = value
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

    Private _ReviewDate As Date
    Public Property ReviewDate As Date
        Get
            Return _ReviewDate
        End Get
        Set(value As Date)
            _ReviewDate = value
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

    Public Function AddNewSurgeryDischarge(ClsSurgeryDischarge As ClsSurgeryDischarge, DbConn As OdbcConnection, DbTrans As OdbcTransaction) As Boolean
        Return DbSurgery.AddNewSurgeryDischarge(ClsSurgeryDischarge, DbConn, DbTrans)
    End Function

End Class
