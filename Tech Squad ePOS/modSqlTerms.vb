Module modSqlTerms
    Function getTerms(cust_id As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM terms WHERE cust_id ='" & cust_id & "'"

        'Get Customer Detail
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Select_Query(sqlQuery)
        End With
        MyTable = classSql.Table
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        Return (MyTable)
    End Function
    Public Function addTerms(cust_id As Integer, Optional cash As Boolean = True, Optional exchange As Boolean = False, Optional account As Boolean = False, Optional statements As Boolean = False, Optional days_credit As String = "")
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO terms (cust_id, cash, exchange, account, statements, days_credit) "
        sqlQuery = sqlQuery & "VALUES ('" & cust_id & "','" & cash & "','" & exchange & "','" & account & "','" & statements & "','" & days_credit & "')"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.LastInsertedId)
    End Function
    Public Function updateTerms(cust_id As Integer, Optional cash As Boolean = True, Optional exchange As Boolean = False, Optional account As Boolean = False, Optional statements As Boolean = False, Optional days_credit As String = "")
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE terms SET cash=" & cash & ",exchange=" & exchange & ",account=" & account & ",statements=" & statements & ",days_credit='" & days_credit & "' WHERE cust_id='" & cust_id & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.rowsAffected)
    End Function
End Module
