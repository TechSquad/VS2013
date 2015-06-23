Module modUsers
    Function isAllowed(user_name As String, password As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        sqlQuery = "SELECT COUNT(*) FROM users WHERE user_name ='" & user_name & "' AND password ='" & password & "'"
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
        Return (result)
    End Function
End Module
