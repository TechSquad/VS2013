Imports MySQL.Data.MySqlClient   ' Used to access the MySQL database
'Remember to add a reference to MYSQLData.net in the project.
Public Class MySQL_Basic
    Private Function MySQL_get_connection(db_Name As String, db_Url As String, db_User As String, db_Password As String)
        'If My.Settings.mod_debug Then moduleTrace()
        'Returns Connection object
        Dim ConnStr As String = "Database=" & db_Name & "; Data Source=" & db_Url & "; User Id=" & db_User & "; Password=" & db_Password & "; Allow Zero Datetime=true "
        Dim CN As New MySqlConnection(ConnStr)
        Return (CN)
    End Function
    Private Sub MySQL_close_connection(CN As MySqlConnection)
        'If My.Settings.mod_debug Then moduleTrace()
        ' Closes connection object passed to it
        If CN.State = ConnectionState.Open Then
            CN.Close() ' if connection still open, close it
        End If
        CN.Dispose() 'Dispose of Connection
    End Sub
    Public Function MySQL_Select_Query(SqlQuery As String, db_Name As String, db_Url As String, db_User As String, db_Password As String)
        ' Receives a mysql select query and returns a table of the results
        'If My.Settings.mod_debug Then moduleTrace()

        Dim CN As New MySqlConnection
        CN = MySQL_get_connection(db_Name, db_Url, db_User, db_Password)   'get connection for database
        Dim CMD As New MySqlCommand(SqlQuery, CN)
        Dim Reader As MySqlDataReader
        Dim table As New DataTable()

        Try
            CN.Open()   'Open connection to database
            If CN.State = ConnectionState.Open Then     ' check connection state
                Reader = CMD.ExecuteReader()  'Execute sql command to return data
                table.Load(Reader)
            End If
        Catch ex As Exception
            'G_Error("Failed to open connection to database due to the following error " & ex.Message)   ' in case it goes wrong
        End Try
        MySQL_close_connection(CN)  ' if connection still open, close it
        Return (table)    'Return the entire table
    End Function
    Public Function MySQL_get_record_count(SqlQuery As String, db_Name As String, db_Url As String, db_User As String, db_Password As String)
        'If My.Settings.mod_debug Then moduleTrace()
        ' Receives an SQL COUNT query and returns the number of records selected
        Dim CN As New MySqlConnection
        CN = MySQL_get_connection(db_Name, db_Url, db_User, db_Password)   'get connection for database
        Dim CMD As New MySqlCommand(SqlQuery, CN)
        Dim count As Integer = 0

        Try
            CN.Open()   'Open connection to database
            If CN.State = ConnectionState.Open Then     ' check connection state
                count = CMD.ExecuteScalar
            End If
        Catch ex As Exception
            'MsgBox("modMySQL - MySQL_get_record_count: Failed to open connection to database due to the following error " & vbCrLf & ex.Message)   ' in case it goes wrong
        End Try
        MySQL_close_connection(CN) ' if connection still open, close it
        Return (count)    'Return number of records selected by query
    End Function
End Class
