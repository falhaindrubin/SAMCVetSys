Public Class ClsEmployee

    Dim DbEmployee As New ClsDbEmployee

#Region "Property"

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

    Private _SaluteCode As String
    Public Property SaluteCode As String
        Get
            Return _SaluteCode
        End Get
        Set(value As String)
            _SaluteCode = value
        End Set
    End Property

    Private _SaluteName As String
    Public Property SaluteName As String
        Get
            Return _SaluteName
        End Get
        Set(value As String)
            _SaluteName = value
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

    Private _EmployeeDOB As Date
    Public Property EmployeeDOB As Date
        Get
            Return _EmployeeDOB
        End Get
        Set(value As Date)
            _EmployeeDOB = value
        End Set
    End Property

    Private _EmployeePOB As String
    Public Property EmployeePOB As String
        Get
            Return _EmployeePOB
        End Get
        Set(value As String)
            _EmployeePOB = value
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

    Private _MobileNo As String
    Public Property MobileNo As String
        Get
            Return _MobileNo
        End Get
        Set(value As String)
            _MobileNo = value
        End Set
    End Property

    Private _TelNo As String
    Public Property TelNo As String
        Get
            Return _TelNo
        End Get
        Set(value As String)
            _TelNo = value
        End Set
    End Property

    Private _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
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

    Private _Postcode As String
    Public Property Postcode As String
        Get
            Return _Postcode
        End Get
        Set(value As String)
            _Postcode = value
        End Set
    End Property

    Private _City As String
    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    Private _State As String
    Public Property State As String
        Get
            Return _State
        End Get
        Set(value As String)
            _State = value
        End Set
    End Property

    Private _Country As String
    Public Property Country As String
        Get
            Return _Country
        End Get
        Set(value As String)
            _Country = value
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

    Private _Qualification As String
    Public Property Qualification As String
        Get
            Return _Qualification
        End Get
        Set(value As String)
            _Qualification = value
        End Set
    End Property

    Private _Institution As String
    Public Property Institution As String
        Get
            Return _Institution
        End Get
        Set(value As String)
            _Institution = value
        End Set
    End Property

    Private _IsActive As String
    Public Property IsActive As String
        Get
            Return _IsActive
        End Get
        Set(value As String)
            _IsActive = value
        End Set
    End Property

    Private _MaritalStatusCode As String
    Public Property MaritalStatusCode As String
        Get
            Return _MaritalStatusCode
        End Get
        Set(value As String)
            _MaritalStatusCode = value
        End Set
    End Property

    Private _MaritalStatusName As String
    Public Property MaritalStatusName As String
        Get
            Return _MaritalStatusName
        End Get
        Set(value As String)
            _MaritalStatusName = value
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

#End Region

    Public Function AddNewEmployee(ClsEmployee As ClsEmployee, DBConn As OdbcConnection, DBTrans As OdbcTransaction) As Boolean
        Return DbEmployee.AddNewEmployee(ClsEmployee, DBConn, DBTrans)
    End Function

    Public Function GetEmployee(ClsEmployee As ClsEmployee) As DataTable
        Return DbEmployee.GetEmployee(ClsEmployee)
    End Function

    'Get Vet
    Public Function GetVet(ByVal ClsEmployee As ClsEmployee) As DataTable
        Return DbEmployee.GetVet(ClsEmployee)
    End Function

    Public Function GetPosition(ClsEmployee As ClsEmployee) As DataTable
        Return DbEmployee.GetPosition(ClsEmployee)
    End Function

    'Get Marital Status
    Public Function GetMaritalStatus(ClsEmployee As ClsEmployee) As DataTable
        Return DbEmployee.GetMaritalStatus(ClsEmployee)
    End Function

    'Get Sex
    Public Function GetSex(ClsEmployee As ClsEmployee) As DataTable
        Return DbEmployee.GetSex(ClsEmployee)
    End Function

End Class
