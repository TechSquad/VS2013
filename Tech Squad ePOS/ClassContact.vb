
Public Class contact
    Private _contact_id As Integer = 0
    Private _cust_id As Integer = 0
    Private _email As String = ""
    Private _fax As String = ""
    Private _home_tel As String = ""
    Private _in_use As Boolean = False
    Private _mobile_tel As String = ""
    Private _work_tel As String = ""
    Private _success As Boolean = False
    Private _error_message As String = ""

    Sub New()
        contact_id = 0
        cust_id = 0
        email = ""
        fax = ""
        home_tel = ""
        in_use = False
        mobile_tel = ""
        work_tel = ""
        success = False
        error_message = ""
    End Sub

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

    Public Property home_tel As String
        Get
            Return _home_tel
        End Get
        Set(value As String)
            _home_tel = value
        End Set
    End Property

    Public Property work_tel As String
        Get
            Return _work_tel
        End Get
        Set(value As String)
            _work_tel = value
        End Set
    End Property

    Public Property mobile_tel As String
        Get
            Return _mobile_tel
        End Get
        Set(value As String)
            _mobile_tel = value
        End Set
    End Property

    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property fax As String
        Get
            Return _fax
        End Get
        Set(value As String)
            _fax = value
        End Set
    End Property

    Public Property in_use As Boolean
        Get
            Return _in_use
        End Get
        Set(value As Boolean)
            _in_use = value
        End Set
    End Property

    Public Property success As Boolean
        Get
            Return _success
        End Get
        Set(value As Boolean)
            _success = value
        End Set
    End Property

    Public Property error_message As String
        Get
            Return _error_message
        End Get
        Set(value As String)
            _error_message = value
        End Set
    End Property

    Private Sub _addContact()
        'Creates a new contact record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO contact (cust_id, home_tel, work_tel, mobile_tel, email, fax, in_use) "
        sqlQuery = sqlQuery & "VALUES ('" & _cust_id & "','" & _home_tel & "','" & _work_tel & "','" & _mobile_tel & "','" & _email & "','" & _fax & "'," & BoolToMySql(_in_use) & ")"
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
            _contact_id = classSql.LastInsertedId
            _success = True
        End If
    End Sub

    Private Function _existingContact()
        'determines if a contact already exists, returns True or False
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result

        If _contact_id > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM contact WHERE contact_id ='" & _contact_id & "'"
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

    Private Sub _updateContact()
        ' Updates an existing contact record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _contact_id > 0 Then ' make sure you have a valid _company_id first (sanity check)
            sqlQuery = "UPDATE contact SET cust_id ='" & _cust_id & "',home_tel='" & _home_tel & "',work_tel='" & _work_tel & "',mobile_tel='" & _mobile_tel & "',email='" & _email & "',fax='" & _fax & "',in_use='" & BoolToMySql(_in_use) & "' WHERE contact_id = '" & _contact_id & "'"
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
        If _contact_id > 0 Then
            Dim classSql As New ClassMySQL_Basic
            Dim MyTable As New DataTable
            Dim sqlQuery As String = "SELECT * FROM contact WHERE contact_id ='" & _contact_id & "'"

            _success = False
            'Get contact Detail
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
                _contact_id = MyTable.Rows(0).Item("contact_id")
                _cust_id = MyTable.Rows(0).Item("cust_id")
                _home_tel = MyTable.Rows(0).Item("home_tel")
                _work_tel = MyTable.Rows(0).Item("work_tel")
                _mobile_tel = MyTable.Rows(0).Item("mobile_tel")
                _email = MyTable.Rows(0).Item("email")
                _fax = MyTable.Rows(0).Item("fax")
                _in_use = MyTable.Rows(0).Item("in_use")
                _success = True
            Else
                _error_message = "No Records Returned"
                _success = False
            End If
        Else
            _error_message = "you must supply a contact_id to look up a contact"
            _success = False
        End If
    End Sub

    Public Sub save_to_db()
        If _existingContact() Then
            'update record
            _updateContact()
        Else
            'create new record
            _addContact()
        End If
    End Sub

End Class
