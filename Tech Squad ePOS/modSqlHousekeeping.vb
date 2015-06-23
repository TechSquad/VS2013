Module modSqlHousekeeping
    ''' <summary>
    ''' Checks to see if the database can be accessed
    ''' </summary>
    ''' <returns></returns>
    ''' True or False
    ''' <remarks></remarks>
    Public Function is_Database()
        Dim classSql As New ClassMySQL_Basic

        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .DoesDbExist()
            'MessageBox.Show("Success = " & .Success & " : Record Count = " & .RecCount)
            Return (.Success)
        End With

    End Function
    ''' <summary>
    ''' Deletes all trhe records in a table
    ''' </summary>
    ''' <param name="table_name"></param>
    ''' <remarks></remarks>
    Public Sub emptyTable(table_name As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "TRUNCATE TABLE "

        sqlQuery = sqlQuery & table_name
        'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
    End Sub
    ''' <summary>
    ''' Gets a list of all tables in the database
    ''' </summary>
    ''' <returns></returns>
    ''' A table of all the table names
    ''' <remarks></remarks>
    Public Function showTables()
        Dim sqlQuery As String = "SHOW TABLES"
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        'classSql.MySQL_Select_Query(sqlCmd, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Select_Query(sqlQuery)
        End With
        MyTable = classSql.Table
        Return (MyTable)
    End Function

End Module
