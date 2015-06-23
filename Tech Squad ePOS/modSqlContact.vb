Module modSqlContact
    Public Function getContact(Cust_id As Integer)
        ' Gets the contact details for a customer based on cust_id, returns a table
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM contact WHERE cust_id = '" & Cust_id & "'"

        'Get Address Detail
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
    Public Function addContact(cust_id As Integer, home_tel As String, work_tel As String, mobile_tel As String, email As String, fax As String, Optional in_use As Boolean = True)
        ' Adds new contact details record, returns rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO contact (cust_id, home_tel, work_tel, mobile_tel, email, fax, in_use) "
        sqlQuery = sqlQuery & "VALUES ('" & cust_id & "','" & home_tel & "','" & work_tel & "','" & mobile_tel & "','" & email & "','" & fax & "'," & in_use & ")"
        'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.rowsAffected)
    End Function
    Public Function updateContact(cust_id As Integer, home_tel As String, work_tel As String, mobile_tel As String, email As String, fax As String, Optional in_use As Boolean = True)
        ' Updates contact details based on cust_id and contact details that are in_use, returns rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE contact SET home_tel ='" & home_tel & "', work_tel ='" & work_tel & "', mobile_tel ='" & mobile_tel & "', email ='" & email & "', fax ='" & fax & "', in_use ='" & in_use & "' WHERE cust_id ='" & cust_id & "'"
        'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        Return (classSql.rowsAffected)
    End Function
End Module
