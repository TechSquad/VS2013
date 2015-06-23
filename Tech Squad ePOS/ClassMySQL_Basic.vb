' ***********************************************************************************************************************************
' * ClassMySQL_Basic created by Roger Whitfield on 17/10/2014                                                                       *
' * This class includes basic functions to Select, Edit and Delete Data from MySQL database using SQL Queries                       *
' *                                                                                                                                 *
' * This class is ready to be compiled as a DLL file to be used in any project                                                      *
' * Dim classSql As New ClassMySQL_Basic                                                                                            *
' * Dim MyTable As New DataTable                                                                                                    *
' *                                                                                                                                 *
' * Simple error handling is included in the class so this class will throw a MessageBox with error information                     *
' *                                                                                                                                 *
' * Exposes the following public functions                                                                                          *
' * Public Function DoesDbExist(db_Name, db_Url, db_User, db_Password)                                                              *
' * Public Function CreateDatabase(db_Name, db_Url, db_User, db_Password)                                                           *
' * Public Function CreateTable(db_table_sql, db_Name, db_Url, db_User, db_Password)                                                *
' * MySQL_Select_Query(SqlQuery As String, db_Name As String, db_Url As String, db_User As String, db_Password As String)           *
' * MySQL_get_record_count(SqlQuery As String, db_Name As String, db_Url As String, db_User As String, db_Password As String)       *
' * MySQL_Action_Query(SqlQuery As String, db_Name As String, db_Url As String, db_User As String, db_Password As String)           *
' *                                                                                                                                 *
' * Uses the follwing Private functions/subs                                                                                        *
' * MySQL_get_connection(db_Name As String, db_Url As String, db_User As String, db_Password As String)                             *
' * MySQL_close_connection(CN As MySqlConnection)                                                                                   *
' * Private Sub G_Error(errorMessage As String)                                                                                     *
' ***********************************************************************************************************************************
Imports MySql.Data.MySqlClient   ' Used to access the MySQL database
Imports System.Data.SqlClient
'Remember to add a reference to MYSQLData.net in the project.
Public Class ClassMySQL_Basic
    Private _errorText As String = ""
    Private _success As Boolean = False
    Private _Table As New DataTable
    Private _recCount As Integer = 0
    Private _rowsAffected As Integer = 0
    Private _LastInsertedId As Integer = 0
    Private _db_Url As String
    Private _db_User As String
    Private _db_Password As String
    Private _db_Name As String

    Public ReadOnly Property errorText() As String  'Returns the text of any error
        Get
            Return _errorText
        End Get
    End Property
    Public ReadOnly Property Success() As Boolean   'Returns True if all OK or False if there are problems
        Get
            Return _success
        End Get
    End Property
    Public ReadOnly Property Table() As DataTable   'Returns DataTable
        Get
            Return _Table
        End Get
    End Property
    Public ReadOnly Property RecCount As Integer    'Returns Record Count for SELECT queries
        Get
            Return _recCount
        End Get
    End Property
    Public ReadOnly Property rowsAffected As Integer    'Returns rows affected used for update and insert queries
        Get
            Return _rowsAffected
        End Get
    End Property
    Public ReadOnly Property LastInsertedId As Integer    'Returns rows affected used for update and insert queries
        Get
            Return _LastInsertedId
        End Get
    End Property
    Public Property db_Url As String
        Get
            Return _db_Url
        End Get
        Set(ByVal value As String)
            _db_Url = value
        End Set
    End Property
    Public Property db_User As String
        Get
            Return _db_User
        End Get
        Set(ByVal value As String)
            _db_User = value
        End Set
    End Property
    Public Property db_Password As String
        Get
            Return _db_Password
        End Get
        Set(ByVal value As String)
            _db_Password = value
        End Set
    End Property
    Public Property db_Name As String
        Get
            Return _db_Name
        End Get
        Set(ByVal value As String)
            _db_Name = value
        End Set
    End Property
    Public Sub DoesDbExist() 'db_Name, db_Url, db_User, db_Password)
        'Check the INFORMATION_SCHEMA in MYSQL to see if db_Name exists and return True or False
        'Dim _success As Boolean
        Dim SqlQuery As String = "SELECT COUNT(SCHEMA_NAME) FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '" & _db_Name & "'"
        MySQL_get_record_count(SqlQuery) ', "INFORMATION_SCHEMA") ', _db_Url, _db_User, _db_Password)
    End Sub
    Public Sub CreateDatabase() 'db_Name, db_Url, db_User, db_Password)
        Dim SqlQuery As String = "CREATE DATABASE IF NOT EXISTS" & _db_Name
        MySQL_Action_Query(SqlQuery) ', db_Name, db_Url, db_User, db_Password)   'If not create DB
    End Sub
    Public Sub CreateTable(db_table_sql) ', db_Name, db_Url, db_User, db_Password)
        ' db_table_sql needs to be in the format "CREATE TABLE (column_name data_type(size), column_name data_type(size)...);"
        MySQL_Action_Query(db_table_sql) ', db_Name, db_Url, db_User, db_Password)
    End Sub
    Private Function MySQL_get_connection() 'db_Name As String) ', db_Url As String, db_User As String, db_Password As String)
        'Returns Connection object
        Dim ConnStr As String = "Database=" & _db_Name & "; Data Source=" & _db_Url & "; User Id=" & _db_User & "; Password=" & _db_Password & "; Allow Zero Datetime=true "
        Dim CN As New MySqlConnection(ConnStr)
        Return (CN)
    End Function
    Private Sub MySQL_close_connection(CN As MySqlConnection)
        ' Closes connection object passed to it
        If CN.State = ConnectionState.Open Then
            CN.Close() ' if connection still open, close it
        End If
        CN.Dispose() 'Dispose of Connection
    End Sub
    Public Sub MySQL_Select_Query(SqlQuery As String) ', db_Name As String, db_Url As String, db_User As String, db_Password As String)
        ' Receives a mysql select query and returns a table of the results
        'If My.Settings.mod_debug Then moduleTrace()
        Dim CN As New MySqlConnection
        CN = MySQL_get_connection() 'db_Name) ', db_Url, db_User, db_Password)   'get connection for database
        Dim CMD As New MySqlCommand(SqlQuery, CN)
        Dim Reader As MySqlDataReader

        Try
            CN.Open()   'Open connection to database
            If CN.State = ConnectionState.Open Then     ' check connection state
                Reader = CMD.ExecuteReader()  'Execute sql command to return data
                _Table.Load(Reader)
                _success = True
                _recCount = Table.Rows.Count
            End If
        Catch ex As Exception
            G_Error("Failed to open connection to database due to the following error " & ex.Message)   ' in case it goes wrong
        End Try
        MySQL_close_connection(CN)  ' if connection still open, close it
    End Sub
    Public Sub MySQL_get_record_count(SqlQuery As String) ', databaseName As String) ', db_Url As String, db_User As String, db_Password As String)
        'If My.Settings.mod_debug Then moduleTrace()
        ' Receives an SQL COUNT query and returns the number of records selected
        'SELECT COUNT(*) FROM <table> WHERE <condition is fulfilled>
        Dim CN As New MySqlConnection
        CN = MySQL_get_connection() 'db_Name, db_Url, db_User, db_Password)   'get connection for database
        Dim CMD As New MySqlCommand(SqlQuery, CN)
        'Dim count As Integer = 0

        Try
            CN.Open()   'Open connection to database
            If CN.State = ConnectionState.Open Then     ' check connection state
                _recCount = CMD.ExecuteScalar
                _success = True
            End If
        Catch ex As Exception
            G_Error("modMySQL - MySQL_get_record_count: Failed to open connection to database due to the following error " & vbCrLf & ex.Message)   ' in case it goes wrong
        End Try
        MySQL_close_connection(CN) ' if connection still open, close it
        'Return (count)    'Return number of records selected by query
    End Sub
    Public Sub MySQL_Action_Query(SqlQuery As String) ', db_Name As String, db_Url As String, db_User As String, db_Password As String)
        ' Receives an UPDATE query and returns the number of records affected Can be used for UPDATE/SET, INSERT INTO, and DELETE FROM queries 
        Dim CN As New MySqlConnection
        CN = MySQL_get_connection() 'db_Name) ', db_Url, db_User, db_Password)   'get connection for database
        Dim CMD As New MySqlCommand(SqlQuery, CN)

        Try
            CN.Open()   'Open connection to database
            If CN.State = ConnectionState.Open Then     ' check connection state
                _rowsAffected = CMD.ExecuteNonQuery()   ' Execute update command
                _LastInsertedId = CMD.LastInsertedId
                _success = True
            End If
        Catch ex As Exception
            G_Error("modMySQL - MySQL_update: Failed to open connection to database due to the following error " & vbCrLf & ex.Message)   ' in case it goes wrong
        End Try
        MySQL_close_connection(CN) ' if connection still open, close it
    End Sub

    Private Sub G_Error(errorMessage As String)
        ' Comments: Global Error procedure to handle errors that occur.
        Dim strMsg As String
        Dim formName As String  'To preserve Error Info
        Dim procName As String  'To preserve Error Info
        Dim stackFrame As New Diagnostics.StackFrame(1) 'To access Error Info from stack

        formName = stackFrame.GetMethod.DeclaringType.Name
        procName = stackFrame.GetMethod.Name
        strMsg = "Location: " & formName & vbCrLf & _
                 "Procedure: " & procName & vbCrLf & _
                 "Error: " & errorMessage
        _errorText = strMsg
        _success = False
    End Sub
End Class


