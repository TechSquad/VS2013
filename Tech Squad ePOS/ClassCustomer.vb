Imports MySql.Data.Types
Public Class ClassCustomer
    Private _cust_id As Integer = 0
    Private _address_id As Integer = 0
    Private _contact_id As Integer = 0
    Private _membership As String = ""
    Private _acct_type As String = ""
    Private _title As String = ""
    Private _first_name As String = ""
    Private _last_name As String = ""
    Private _company_name As String = ""
    Private _date_of_birth As String = ""
    Private _is_company As Boolean = False
    Private _mailing_list As Boolean = True
    Private _vip As Boolean = False
    Private _in_use As Boolean = True
    Private _date_created As MySqlDateTime
    Private _date_changed As MySqlDateTime
    Private _success As Boolean
    Private _error_message As String

    Sub New()
        ' setup a blank customer
        cust_id = 0
        address_id = 0
        contact_id = 0
        _membership = ""
        acct_type = ""
        title = ""
        first_name = ""
        last_name = ""
        company_name = ""
        date_of_birth = ""
        is_company = False
    End Sub

    ''' <value>""</value>
    Public Property acct_type As String
        Get
            Return _acct_type
        End Get
        Set(value As String)
            _acct_type = value
        End Set
    End Property

    ''' <value>0</value>
    Public Property address_id As Integer
        Get
            Return _address_id
        End Get
        Set(value As Integer)
            _address_id = value
        End Set
    End Property

    ''' <value>""</value>
    Public Property company_name As String
        Get
            Return _company_name
        End Get
        Set(value As String)
            _company_name = value
        End Set
    End Property

    ''' <value>0</value>
    Public Property contact_id As Integer
        Get
            Return _contact_id
        End Get
        Set(value As Integer)
            _contact_id = value
        End Set
    End Property

    Public Property cust_id As Integer
        Get
            Return _cust_id
        End Get
        Set(value As Integer)
            _cust_id = value
        End Set
    End Property

    Public ReadOnly Property date_changed As MySqlDateTime
        Get
            Return _date_changed
        End Get
    End Property

    Public ReadOnly Property date_created As MySqlDateTime
        Get
            Return _date_created
        End Get
    End Property

    Public Property date_of_birth As String
        Get
            Return _date_of_birth
        End Get
        Set(value As String)
            _date_of_birth = value
        End Set
    End Property

    Public Property is_company As Boolean
        Get
            Return _is_company
        End Get
        Set(value As Boolean)
            _is_company = value
        End Set
    End Property

    Public Property first_name As String
        Get
            Return _first_name
        End Get
        Set(value As String)
            _first_name = value
        End Set
    End Property

    Public Property last_name As String
        Get
            Return _last_name
        End Get
        Set(value As String)
            _last_name = value
        End Set
    End Property

    Public Property title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property


    Public ReadOnly Property VIP As Boolean
        Get
            Return _vip
        End Get
    End Property
Public ReadOnly Property mailing_list as Boolean
        Get
            Return _mailing_list
        End Get
    End Property
    Public ReadOnly Property success As Boolean
        Get
            Return _success
        End Get
    End Property
    Public ReadOnly Property error_message As String
        Get
            Return _error_message
        End Get
    End Property

    Public Property membership As String
        Get
            Return _membership
        End Get
        Set(value As String)
            _membership = value
        End Set
    End Property
    Public Sub makeVIP()
        _vip = True
    End Sub

    Public Sub removeVIP()
        _vip = False
    End Sub

    Public Sub addToMailingList()
        _mailing_list = True
    End Sub

    Public Sub removeFromMailingList()
        _mailing_list = False
    End Sub

    Public Sub delete()
        _in_use = False
    End Sub

    Public Sub undelete()
        _in_use = True
    End Sub

    Private Sub _addCustomer()
        'Creates a new customer record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO customer (address_id, contact_id, membership, acct_type, title, first_name, last_name, company_name, date_of_birth, is_company, mailing_list, vip, in_use, date_created) "
        sqlQuery = sqlQuery & "VALUES ('" & _address_id & "','" & _contact_id & "','" & _membership & "','" & _acct_type & "','" & _title & "','" & _first_name & "','" & _last_name & "','" & _company_name & "','" & _date_of_birth & "','" & BoolToMySql(_is_company) & "','" & BoolToMySql(_mailing_list) & "','" & BoolToMySql(_vip) & "','" & BoolToMySql(_in_use) & "', Now())"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            _error_message = classSql.errorText     ' Display error
            _success = False
        Else
            _cust_id = classSql.LastInsertedId      ' retrieve and store new customer ID
            _success = True
        End If
    End Sub

    ''' <remarks>Determines if a customer exists, returns true or false</remarks>
    Private Function _existingCustomer() As Boolean
        'determines if an customer already exists, returns True or False
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result

        If _cust_id > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM customer WHERE cust_id ='" & _cust_id & "'"
            With classSql
                .db_Url = My.Settings.db_Url
                .db_User = My.Settings.db_User
                .db_Password = My.Settings.db_Password
                .db_Name = My.Settings.db_Name
                .MySQL_get_record_count(sqlQuery)
            End With
            If classSql.RecCount > 0 Then
                result = True
            End If
        End If
        Return (result)
    End Function

    Private Sub _updateCustomer()
        ' Updates an existing customer record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _cust_id > 0 Then ' make sure you have a valid _cust_id first (sanity check)
            sqlQuery = "UPDATE customer SET address_id ='" & _address_id & "',contact_id='" & _contact_id & "',membership='" & _membership & "',acct_type='" & _acct_type & "',title='" & _title & "',first_name='" & _first_name & "',last_name='" & _last_name & "',company_name='" & _company_name & "',date_of_birth='" & _date_of_birth & "',is_company='" & BoolToMySql(_is_company) & "',mailing_list='" & BoolToMySql(_mailing_list) & "',vip='" & BoolToMySql(_vip) & "',in_use='" & BoolToMySql(_in_use) & "',date_changed=Now()" & " WHERE cust_id = '" & _cust_id & "'"
            With classSql
                .db_Url = My.Settings.db_Url
                .db_User = My.Settings.db_User
                .db_Password = My.Settings.db_Password
                .db_Name = My.Settings.db_Name
                .MySQL_Action_Query(sqlQuery)
            End With
            'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
            If classSql.errorText <> "" Then            ' Check class for an error
                _error_message = classSql.errorText     ' Display error
                _success = False
            Else
                _success = True
            End If
        End If
    End Sub

    Public Sub get_from_db()
        If _cust_id > 0 Then
            Dim classSql As New ClassMySQL_Basic
            Dim MyTable As New DataTable
            Dim sqlQuery As String = "SELECT * FROM customer WHERE cust_id ='" & _cust_id & "'"

            _success = False
            'Get customer Detail
            With classSql
                .db_Url = My.Settings.db_Url
                .db_User = My.Settings.db_User
                .db_Password = My.Settings.db_Password
                .db_Name = My.Settings.db_Name
                .MySQL_Select_Query(sqlQuery)
            End With
            MyTable = classSql.Table
            If classSql.errorText <> "" Then            ' Check classSql for an error
                _error_message = classSql.errorText.ToString
                _success = False
            ElseIf classSql.RecCount > 0 Then           ' check that at least one record was returned
                'read table data into fields
                _cust_id = MyTable.Rows(0).Item("cust_id")
                _address_id = MyTable.Rows(0).Item("address_id")
                _contact_id = MyTable.Rows(0).Item("contact_id")
                _membership = MyTable.Rows(0).Item("membership")
                _acct_type = MyTable.Rows(0).Item("acct_type")
                _title = MyTable.Rows(0).Item("title")
                _first_name = MyTable.Rows(0).Item("first_name")
                _last_name = MyTable.Rows(0).Item("last_name")
                _company_name = MyTable.Rows(0).Item("company_name")
                _date_of_birth = MyTable.Rows(0).Item("date_of_birth")
                _is_company = MyTable.Rows(0).Item("is_company")
                _mailing_list = MyTable.Rows(0).Item("mailing_list")
                _vip = MyTable.Rows(0).Item("vip")
                _in_use = MyTable.Rows(0).Item("in_use")
                _date_created = MyTable.Rows(0).Item("date_created")
                _date_changed = MyTable.Rows(0).Item("date_changed")
                _success = True
            Else
                _error_message = "No Records Returned"
                _success = False
            End If
        Else
            _error_message = "you must supply a customer_id to look up a customer [ClassCustomer] [get_from_db]"
            _success = False
        End If
    End Sub

    Public Sub save_to_db()
        If _existingCustomer() Then
            'update record
            _updateCustomer()
        Else
            'create new record
            _addCustomer()
        End If
    End Sub

End Class
