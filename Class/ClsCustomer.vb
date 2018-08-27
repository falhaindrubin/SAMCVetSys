Public Class ClsCustomer

    Dim DBCustomer As New ClsDBCustomer

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(value As String)
            _CustomerID = value
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

    Private _CustomerName As String
    Public Property CustomerName As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
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

    Private _SearchByNRICPassport As String
    Public Property SearchByNRICPassport As String
        Get
            Return _SearchByNRICPassport
        End Get
        Set(value As String)
            _SearchByNRICPassport = value
        End Set
    End Property

    Private _SearchByCustomerName As String
    Public Property SearchByCustomerName As String
        Get
            Return _SearchByCustomerName
        End Get
        Set(value As String)
            _SearchByCustomerName = value
        End Set
    End Property

    Private _SearchByCustomerID As String
    Public Property SearchByCustomerID As String
        Get
            Return _SearchByCustomerID
        End Get
        Set(value As String)
            _SearchByCustomerID = value
        End Set
    End Property

    Private _SearchByPetName As String
    Public Property SearchByPetName As String
        Get
            Return _SearchByPetName
        End Get
        Set(value As String)
            _SearchByPetName = value
        End Set
    End Property

    'Add New Client
    Public Function AddNewCustomer(ByVal ClsCustomer As ClsCustomer, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
        Return DBCustomer.AddNewCustomer(ClsCustomer, DBConn, DBTrans)
    End Function

    'Update Client
    Public Function UpdateCustomer(ByVal ClsCustomer As ClsCustomer, ByRef DBConn As OdbcConnection, ByRef DBTrans As OdbcTransaction) As Boolean
        Return DBCustomer.UpdateCustomer(ClsCustomer, DBConn, DBTrans)
    End Function

    'Check Existing Client
    Public Function CheckExistingCustomer(ByVal ClsCustomer As ClsCustomer) As DataTable
        Return DBCustomer.CheckExistingCustomer(ClsCustomer)
    End Function

    'Get customer listing
    Public Function GetCustomerListing(ByVal ClsCustomer As ClsCustomer) As DataTable
        Return DBCustomer.GetCustomerListing(ClsCustomer)
    End Function

    Public Function GetCustomerInformation(ByVal ClsCustomer As ClsCustomer) As DataTable
        Return DBCustomer.GetCustomerInformation(ClsCustomer)
    End Function

    Public Function GetSalutation(ByVal ClsCustomer As ClsCustomer) As DataTable
        Return DBCustomer.GetSalutation(ClsCustomer)
    End Function

End Class
