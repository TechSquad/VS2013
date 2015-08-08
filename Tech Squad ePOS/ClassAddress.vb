
Public Class address
    Private _add_1 As String = ""
    Private _add_2 As String = ""
    Private _address_id As Integer = 0
    Private _city As String = ""
    Private _cust_id As Integer = 0
    Private _in_use As Boolean = False
    Private _postcode As String = ""
    Private _town As String = ""
    Private _success As Boolean = False
    Private _error_message As String = ""

    Sub New()
        add_1 = ""
        add_2 = ""
        address_id = 0
        city = ""
        cust_id = 0
        in_use = False
        postcode = ""
        town = ""
        success = False
        error_message = ""
    End Sub

    Public Property address_id As Integer
        Get
            Return _address_id
        End Get
        Set(value As Integer)
            _address_id = value
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

    Public Property add_1 As String
        Get
            Return _add_1
        End Get
        Set(value As String)
            _add_1 = value
        End Set
    End Property

    Public Property add_2 As String
        Get
            Return _add_2
        End Get
        Set(value As String)
            _add_2 = value
        End Set
    End Property

    Public Property town As String
        Get
            Return _town
        End Get
        Set(value As String)
            _town = value
        End Set
    End Property

    Public Property city As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property postcode As String
        Get
            Return _postcode
        End Get
        Set(value As String)
            _postcode = value
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

    Public Sub get_from_db()
        If _address_id > 0 Then
            Dim classSql As New ClassMySQL_Basic
            Dim MyTable As New DataTable
            Dim sqlQuery As String = "SELECT * FROM address WHERE address_id ='" & _address_id & "'"

            _success = False
            'Get address Detail
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
                _cust_id = MyTable.Rows(0).Item("cust_id")
                _add_1 = MyTable.Rows(0).Item("add_1")
                _add_2 = MyTable.Rows(0).Item("add_2")
                _town = MyTable.Rows(0).Item("town")
                _city = MyTable.Rows(0).Item("city")
                _postcode = MyTable.Rows(0).Item("postcode")
                _in_use = MyTable.Rows(0).Item("in_use")
                _success = True
            Else
                _error_message = "No Records Returned"
                _success = False
            End If
        Else
            _error_message = "you must supply an address_id to look up an address"
            _success = False
        End If
    End Sub

    Public Sub save_to_db()
        If _existing_address() Then
            'update record
            _update_address()
        Else
            'create new record
            _add_address()
        End If
    End Sub

    Private Sub _add_address()
        'Creates a new address record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO address (cust_id, add_1, add_2, town, city, postcode, in_use) "
        sqlQuery = sqlQuery & "VALUES ('" & cust_id & "','" & add_1 & "','" & add_2 & "','" & town & "','" & city & "','" & postcode & "'," & in_use & ")"
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
            _address_id = classSql.LastInsertedId
            _success = True
        End If
    End Sub

    Private Function _existing_address()
        'determines if an address already exists, returns True or False
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result

        If _address_id > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM address WHERE address_id ='" & _address_id & "'"
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

    Private Sub _update_address()
        ' Updates an existing address record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _address_id > 0 Then ' make sure you have a valid _company_id first (sanity check)
            sqlQuery = "UPDATE address SET cust_id ='" & _cust_id & "',add_1='" & _add_1 & "',add_2='" & _add_2 & "',town='" & _town & "',city='" & _city & "',postcode='" & _postcode & "',in_use='" & _in_use & "' WHERE address_id = '" & _address_id & "'"
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
End Class
