
Public Class receipt
    Private _receipt_footer As String = ""
    Private _receipt_header As String = ""
    Private _receipt_id As Integer = 0
    Private _success As Boolean = False
    Private _error_message As String = ""

    Sub New()
        receipt_id = 0
        receipt_footer = ""
        receipt_header = ""
        success = False
        error_message = ""
    End Sub

    Public Property receipt_id As Integer
        Get
            Return _receipt_id
        End Get
        Set(value As Integer)
            _receipt_id = value
        End Set
    End Property

    Public Property receipt_header As String
        Get
            Return _receipt_header
        End Get
        Set(value As String)
            _receipt_header = value
        End Set
    End Property

    Public Property receipt_footer As String
        Get
            Return _receipt_footer
        End Get
        Set(value As String)
            _receipt_footer = value
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
        If _receipt_id > 0 Then
            Dim classSql As New ClassMySQL_Basic
            Dim MyTable As New DataTable
            Dim sqlQuery As String = "SELECT * FROM receipt_info WHERE receipt_id ='" & _receipt_id & "'"

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
                _receipt_header = MyTable.Rows(0).Item("receipt_header")
                _receipt_footer = MyTable.Rows(0).Item("receipt_footer")
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

    Public Sub save_to_db()
        If _existing_receipt() Then
            'update record
            _update_receipt()
        Else
            'create new record
            _addReceipt()
        End If
    End Sub

    Private Sub _addReceipt()
        'Creates a new receipt record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False
        sqlQuery = "INSERT INTO receipt_info (receipt_header, receipt_footer) "
        sqlQuery = sqlQuery & "VALUES ('" & _receipt_header & "','" & _receipt_footer & ")"
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
            _receipt_id = classSql.LastInsertedId
            _success = True
        End If
    End Sub

    Private Function _existing_receipt()
        ' Check to see if receipt record already exists
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        _success = result

        If _receipt_id > 0 Then
            sqlQuery = "SELECT COUNT(*) FROM receipt_info WHERE receipt_id ='" & _receipt_id & "'"
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

    Private Sub _update_receipt()
        ' Updates an existing receipt record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        _success = False    ' always set to false before starting any process
        If _receipt_id > 0 Then ' make sure you have a valid _receipt_id first (sanity check)
            sqlQuery = "UPDATE receipt_info SET receipt_header='" & _receipt_header & "',receipt_footer='" & _receipt_footer & "' WHERE receipt_id = '" & _receipt_id & "'"
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
