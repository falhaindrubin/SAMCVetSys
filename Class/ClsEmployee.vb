Public Class ClsEmployee

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

    Private _SaluteCode As String
    Public Property SaluteCode As String
        Get
            Return _SaluteCode
        End Get
        Set(value As String)
            _SaluteCode = value
        End Set
    End Property

    Private _NRICPassportNo As String
    Public Property NRICPassportNo As String
        Get
            Return _NRICPassportNo
        End Get
        Set(value As String)
            _NRICPassportNo = value
        End Set
    End Property

    Private _EmpDOB As Date
    Public Property EmpDOB As Date
        Get
            Return _EmpDOB
        End Get
        Set(value As Date)
            _EmpDOB = value
        End Set
    End Property

    Private _EmpPOB As String
    Public Property EmpPOB As String
        Get
            Return _EmpPOB
        End Get
        Set(value As String)
            _EmpPOB = value
        End Set
    End Property

    Private _Nationality As String
    Public Property Nationality As String
        Get
            Return _Nationality
        End Get
        Set(value As String)
            _Nationality = value
        End Set
    End Property

    Private _AddressLine1 As String
    Public Property AddressLine1 As String
        Get
            Return _AddressLine1
        End Get
        Set(value As String)
            _AddressLine1 = value
        End Set
    End Property

    Private _AddressLine2 As String
    Public Property AddressLine2 As String
        Get
            Return _AddressLine2
        End Get
        Set(value As String)
            _AddressLine2 = value
        End Set
    End Property

    Private _AddressLine3 As String
    Public Property AddressLine3 As String
        Get
            Return _AddressLine3
        End Get
        Set(value As String)
            _AddressLine3 = value
        End Set
    End Property

    Private _AddressLine4 As String
    Public Property AddressLine4 As String
        Get
            Return _AddressLine4
        End Get
        Set(value As String)
            _AddressLine4 = value
        End Set
    End Property

    Private _SexCode As String
    Public Property SexCode As String
        Get
            Return _SexCode
        End Get
        Set(value As String)
            _SexCode = value
        End Set
    End Property

    Private _SexName As String
    Public Property SexName As String
        Get
            Return _SexName
        End Get
        Set(value As String)
            _SexName = value
        End Set
    End Property

    Private _Race As String
    Public Property Race As String
        Get
            Return _Race
        End Get
        Set(value As String)
            _Race = value
        End Set
    End Property

    Private _Religion As String
    Public Property Religion As String
        Get
            Return _Religion
        End Get
        Set(value As String)
            _Religion = value
        End Set
    End Property

    Private _MaritalStatus As String
    Public Property MaritalStatus As String
        Get
            Return _MaritalStatus
        End Get
        Set(value As String)
            _MaritalStatus = value
        End Set
    End Property

    Private _PositionCode As String
    Public Property PositionCode As String
        Get
            Return _PositionCode
        End Get
        Set(value As String)
            _PositionCode = value
        End Set
    End Property

    Private _PositionName As String
    Public Property PositionName As String
        Get
            Return _PositionName
        End Get
        Set(value As String)
            _PositionName = value
        End Set
    End Property

    Private _Ref As New ClsReference
    Property Ref() As ClsReference
        Get
            Return _Ref
        End Get
        Set(value As ClsReference)
            _Ref = value
        End Set
    End Property

    'Get Vet
    Public Function GetVet(ByVal ClsEmployee As ClsEmployee) As DataTable
        Return DBEmployee.GetVet(ClsEmployee)
    End Function

End Class
