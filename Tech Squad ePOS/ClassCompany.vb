
Public Class company
    Private _address_id As Integer = 0
    Private _company_id As Integer = 0
    Private _company_name As String = ""
    Private _trading_name As String = ""
    Private _contact_id As Integer = 0
    Private _error_message As String = ""
    Private _merchant_id As Integer = 0
    Private _receipt_id As Integer = 0
    Private _vat_number As String = ""
    Private _vat_registered As Integer = 0
    Private _success As Boolean = False
    
    ''' <summary>
    ''' Creates an empty class object with default values
    ''' </summary>
    Sub New()
        ' initialise properties with default values when instance is created
        receipt_id = 0
        company_id = 0
        company_name = ""
        trading_name = ""
        address_id = 0
        vat_registered = 0
        vat_number = ""
        merchant_id = 0
        contact_id = 0
        receipt_id = 0
    End Sub
    Public Property company_id As Integer
        Get
            Return _company_id
        End Get
        Set(value As Integer)
            _company_id = value
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
    Public Property trading_name As String
        Get
            Return _trading_name
        End Get
        Set(value As String)
            _trading_name = value
        End Set
    End Property

    Public Property address_id As Integer
        Get
            Return _address_id
        End Get
        Set(value As Integer)
            _address_id = value
        End Set
    End Property

    ''' <value>false</value>
    Public Property vat_registered As Integer
        Get
            Return _vat_registered
        End Get
        Set(value As Integer)
            _vat_registered = value
        End Set
    End Property

    ''' <value>""</value>
    Public Property vat_number As String
        Get
            Return _vat_number
        End Get
        Set(value As String)
            _vat_number = value
        End Set
    End Property

    ''' <value>0</value>
    Public Property merchant_id As Integer
        Get
            Return _merchant_id
        End Get
        Set(value As Integer)
            _merchant_id = value
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

    ''' <value>0</value>
    Public Property receipt_id As Integer
        Get
            Return _receipt_id
        End Get
        Set(value As Integer)
            _receipt_id = value
        End Set
    End Property

    ''' <remarks>Holds any error message</remarks>
    ''' <value>""</value>
    Public ReadOnly Property error_message As String
        Get
            Return _error_message
        End Get
    End Property

    ''' <value>False</value>
    Public ReadOnly Property success As Boolean
        Get
            Return _success
        End Get
    End Property

    ''' <remarks>Saves record to DB</remarks>
    Public Sub save_to_db()
        If _existingCompany() Then
            'update record
            _updateCompany()
        Else
            'create new record
            _addCompany()
        End If
    End Sub

    Private Sub _updateCompany()
        ' Updates an existing company record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _company_id > 0 Then ' make sure you have a valid _company_id first (sanity check)
            sqlQuery = "UPDATE company SET address_id ='" & _address_id & "',company_name='" & _company_name & "',trading_name'" & trading_name & "',contact_id='" & _contact_id & "',merchant_id='" & _merchant_id & "',receipt_id='" & _receipt_id & "',vat_number='" & _vat_number & "',vat_registered='" & _vat_registered & "' WHERE id = '" & _company_id & "'"
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

    Private Sub _addCompany()
        'Creates a new company record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO company (address_id, company_name, trading_name, contact_id, merchant_id, receipt_id, vat_number, vat_registered) "
        sqlQuery = sqlQuery & "VALUES ('" & _address_id & "','" & _company_name & "','" & _trading_name & "','" & _contact_id & "','" & _merchant_id & "','" & _receipt_id & "','" & _vat_number & "'," & _vat_registered & ")"
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
            _company_id = classSql.LastInsertedId
            _success = True
        End If
    End Sub

    Private Function _existingCompany()
        'determines if a company already exists, returns True or False
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result

        If _company_id > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM company WHERE id ='" & _company_id & "'"
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

    Public Sub get_from_db()
        If _company_id > 0 Then
            Dim classSql As New ClassMySQL_Basic
            Dim MyTable As New DataTable
            Dim sqlQuery As String = "SELECT * FROM company WHERE id ='" & _company_id & "'"

            _success = False
            'Get Company Detail
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
                _address_id = MyTable.Rows(0).Item("address_id")
                _company_id = MyTable.Rows(0).Item("id")
                _company_name = MyTable.Rows(0).Item("company_name")
                _trading_name = MyTable.Rows(0).Item("trading_name")
                _contact_id = MyTable.Rows(0).Item("contact_id")
                _merchant_id = MyTable.Rows(0).Item("merchant_id")
                _receipt_id = MyTable.Rows(0).Item("receipt_id")
                _vat_number = MyTable.Rows(0).Item("vat_number")
                _vat_registered = MyTable.Rows(0).Item("vat_registered")
                _success = True
            Else
                _error_message = "No Records Returned"
                _success = False
            End If
        Else
            _error_message = "you must supply a company_id to look up a company"
            _success = False
        End If
    End Sub



End Class
