
Public Class ClassInvoice
    Private _inv_number As Integer
    Private _cust_id As Integer
    Private _inv_date As MySql.Data.Types.MySqlDateTime
    Private _address_id As Integer
    Private _total_tax As Double
    Private _user_id As Integer
    Private _items As New List(Of ClassInvoiceItems)
    Private _success As Boolean = False
    Private _error_message As String = ""

    Sub New()
        inv_number = 0
        address_id = 0
        cust_id = 0
        inv_date = Nothing ' not implemented yet
        total_tax = 0.0
        user_id = 0
    End Sub

    Public Property inv_number As Integer
        Get
            Return _inv_number
        End Get
        Set(value As Integer)
            _inv_number = value
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

    Public Property cust_id As Integer
        Get
            Return _cust_id
        End Get
        Set(value As Integer)
            _cust_id = value
        End Set
    End Property

    Public Property inv_date As MySql.Data.Types.MySqlDateTime
        Get
            Return _inv_date
        End Get
        Set(value As MySql.Data.Types.MySqlDateTime)
            _inv_date = value
        End Set
    End Property

    Public Property total_tax As Integer
        Get
            Return _total_tax
        End Get
        Set(value As Integer)
            _total_tax = value
        End Set
    End Property

    Public Property user_id As Integer
        Get
            Return _user_id
        End Get
        Set(value As Integer)
            _user_id = value
        End Set
    End Property

    Public Property items As List(Of ClassInvoiceItems)
        Get
            Return _items
        End Get
        Set(value As List(Of ClassInvoiceItems))
            _items = value
        End Set
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

    Public Sub get_from_db()
        Dim classSqlInvoice As New ClassMySQL_Basic
        Dim classSqlItems As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim MyItemsTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM invoice WHERE inv_number ='" & _inv_number & "'"

        With classSqlInvoice
            If _inv_number > 0 Then
                _success = False
                'Get Invoice
                .db_Url = My.Settings.db_Url
                .db_User = My.Settings.db_User
                .db_Password = My.Settings.db_Password
                .db_Name = My.Settings.db_Name
                .MySQL_Select_Query(sqlQuery)

                MyTable = .Table
                If .errorText <> "" Then            ' Check classSql for an error
                    _error_message = .errorText.ToString
                    _success = False
                ElseIf .RecCount > 0 Then           ' check that at least one record was returned
                    'read table data into fields
                    _inv_number = MyTable.Rows(0).Item("inv_number")
                    _cust_id = MyTable.Rows(0).Item("cust_id")
                    _inv_date = MyTable.Rows(0).Item("inv_date")
                    _address_id = MyTable.Rows(0).Item("address_id")
                    _total_tax = MyTable.Rows(0).Item("total_tax")
                    _user_id = MyTable.Rows(0).Item("user_id")
                    _success = True
                Else
                    _error_message = "No Records Returned"
                    _success = False
                End If
            Else
                _error_message = "you must supply an inv_number to look up an invoice"
                _success = False
            End If
        End With

        With classSqlItems
            If success = True Then ' if lookup was successful then read the line items
                sqlQuery = "SELECT * FROM invoice_item WHERE inv_number = " & _inv_number

                .db_Url = My.Settings.db_Url
                .db_User = My.Settings.db_User
                .db_Password = My.Settings.db_Password
                .db_Name = My.Settings.db_Name
                .MySQL_Select_Query(sqlQuery)

                MyItemsTable = .Table
                If .errorText <> "" Then            ' Check classSql for an error
                    _error_message = .errorText.ToString
                    _success = False
                ElseIf .RecCount > 0 Then           ' check that at least one record was returned
                    'read table data into fields
                    For Each row As DataRow In MyItemsTable.Rows
                        _items.Add(New ClassInvoiceItems(row.Item("inv_item_id"), row.Item("inv_number"), row.Item("item_id"), row.Item("quantity"), row.Item("line_number"), row.Item("price_sold")))
                    Next
                    _success = True
                End If
            Else
                _error_message = "you must supply an inv_number to look up an invoice"
                _success = False
            End If
        End With
    End Sub

    Public Sub save_to_db()
        If _existing_invoice() Then
            'update record
            _update_invoice()
        Else
            'create new record
            _add_invoice()
        End If
    End Sub

    Private Sub _add_invoice()
        'Creates a new invoice record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO invoice (cust_id, address_id, total_tax, user_id) "
        sqlQuery = sqlQuery & "VALUES ('" & _cust_id & "','" & _address_id & "','" & _total_tax & "','" & _user_id & "')"
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
            _inv_number = classSql.LastInsertedId
            _success = True
        End If
        For Each item In _items
            'insert to database
            item.inv_number = _inv_number
            item.save_to_db()
            If Not item.success Then
                MsgBox(item.error_message)
            End If
        Next
    End Sub

    Private Function _existing_invoice() As Boolean
        'determines if an invoice already exists, returns True or False
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result
        If _inv_number > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM invoice WHERE inv_number ='" & _inv_number & "'"
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
        _existing_invoice = result
    End Function

    Private Sub _update_invoice()
        ' Updates an existing contact record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _inv_number > 0 Then ' make sure you have a valid _company_id first (sanity check)
            sqlQuery = "UPDATE invoice SET cust_id ='" & _cust_id & "',address_id='" & _address_id & "',total_tax='" & _total_tax & "',user_id='" & _user_id & "' WHERE inv_number = '" & _inv_number & "'"
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
        For Each item In _items
            item.save_to_db()
            If Not item.success Then
                MsgBox(item.error_message)
            End If
        Next
    End Sub

End Class
