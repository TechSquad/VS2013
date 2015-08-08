
Public Class ClassInvoiceItems
    Private _inv_item_id As Integer
    Private _inv_number As Integer
    Private _item_id As Integer
    Private _quantity As Integer
    Private _line_number As Integer
    Private _success As Boolean = False
    Private _error_message As String = ""
    Private _price_sold As Decimal = 0.0

    Sub New(Optional inv_item_id As Integer = 0, Optional inv_number As Integer = 0, Optional item_id As Integer = 0, Optional quantity As Integer = 0, Optional line_number As Integer = 0, Optional price_sold As Decimal = 0.0)
        ' Constructor will create an invoice item with all values zeroed unless the values are supplied 
        _inv_item_id = inv_item_id
        _inv_number = inv_number
        _item_id = item_id
        _quantity = quantity
        _line_number = line_number
        _price_sold = price_sold
    End Sub

    Public Property inv_item_id As Integer
        Get
            Return _inv_item_id
        End Get
        Set(value As Integer)
            _inv_item_id = value
        End Set
    End Property

    Public Property inv_number As Integer
        Get
            Return _inv_number
        End Get
        Set(value As Integer)
            _inv_number = value
        End Set
    End Property

    Public Property item_id As Integer
        Get
            Return _item_id
        End Get
        Set(value As Integer)
            _item_id = value
        End Set
    End Property

    Public Property line_number As Integer
        Get
            Return _line_number
        End Get
        Set(value As Integer)
            _line_number = value
        End Set
    End Property

    Public Property quantity As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            _quantity = value
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

    Public Property price_sold As Decimal
        Get
            Return _price_sold
        End Get
        Set(value As Decimal)
            _price_sold = value
        End Set
    End Property

    Public Sub save_to_db()
        If _existing_item() Then
            'update record
            _update_item()
        Else
            'create new record
            _add_item()
        End If
    End Sub

    Public Sub get_from_db()
        Dim classSqlItems As New ClassMySQL_Basic
        Dim MyItemsTable As New DataTable
        Dim sqlQuery = "SELECT * FROM invoice_item WHERE inv_number = " & _inv_number

        With classSqlItems
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
                With MyItemsTable.Rows(0)
                    _inv_item_id = .Item("inv_item_id")
                    _inv_number = .Item("inv_number")
                    _item_id = .Item("item_id")
                    _quantity = .Item("quantity")
                    _line_number = .Item("line_number")
                    _price_sold = .Item("price_sold")
                End With
                _success = True
            End If
        End With
    End Sub

    Private Sub _add_item()
        'Creates a new invoice_item record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO invoice_item (inv_number, item_id, quantity, line_number, price_sold) "
        sqlQuery = sqlQuery & "VALUES ('" & _inv_number & "','" & _item_id & "','" & _quantity & "','" & _line_number & "','" & _price_sold & "')"
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
            _inv_item_id = classSql.LastInsertedId
            _success = True
        End If
    End Sub

    Private Function _existing_item() As Boolean
        'determines if an invoice already exists, returns True or False
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result
        If _inv_item_id > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM invoice_item WHERE inv_item_id ='" & _inv_item_id & "'"
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
        _existing_item = result
    End Function

    Private Sub _update_item()
        ' Updates an existing invoice_item record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _inv_item_id > 0 Then ' make sure you have a valid id first (sanity check)
            sqlQuery = "UPDATE invoice_item SET inv_number ='" & _inv_number & "',item_id='" & _item_id & "',quantity='" & _quantity & "',line_number='" & _line_number & "', price_sold='" & _price_sold & "' WHERE inv_item_id = '" & _inv_item_id & "'"
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
