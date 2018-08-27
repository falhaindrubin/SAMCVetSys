Public Class ClsCompany

    Dim DBCompany As New ClsDBCompany

    Private _CompanyCode As String
    Public Property CompanyCode As String
        Get
            Return _CompanyCode
        End Get
        Set(value As String)
            _CompanyCode = value
        End Set
    End Property

    Private _CompanyName As String
    Public Property CompanyName As String
        Get
            Return _CompanyName
        End Get
        Set(value As String)
            _CompanyName = value
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

    Private _TelNo As String
    Public Property TelNo As String
        Get
            Return _TelNo
        End Get
        Set(value As String)
            _TelNo = value
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

    Private _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
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

    Private _SQLQueryCondition As String
    Public Property SQLQueryCondition As String
        Get
            Return _SQLQueryCondition
        End Get
        Set(value As String)
            _SQLQueryCondition = value
        End Set
    End Property

    'Add New Client
    Public Function GetCompanyInformation(ByVal ClsCompany As ClsCompany) As DataTable
        Return DBCompany.GetCompanyInformation(ClsCompany)
    End Function

    ''Update Client
    'Public Function UpdateCustomer(ByVal ClsCustomer As ClsCustomer, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
    '    Return DBCustomer.UpdateCustomer(ClsCustomer, DBConn, DBTrans)
    'End Function

    ''Check Existing Client
    'Public Function CheckExistingCustomer(ByVal ClsCustomer As ClsCustomer) As DataTable
    '    Return DBCustomer.CheckExistingCustomer(ClsCustomer)
    'End Function

    ''Get customer listing
    'Public Function GetCustomerListing(ByVal ClsCustomer As ClsCustomer) As DataTable
    '    Return DBCustomer.GetCustomerListing(ClsCustomer)
    'End Function

    'Public Function GetCustomerInformation(ByVal ClsCustomer As ClsCustomer) As DataTable
    '    Return DBCustomer.GetCustomerInformation(ClsCustomer)
    'End Function

    'Public Function GetSalutation(ByVal ClsCustomer As ClsCustomer) As DataTable
    '    Return DBCustomer.GetSalutation(ClsCustomer)
    'End Function

End Class
