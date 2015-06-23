Module modSqlAddress
    Public Function addCustAddressID(cust_id As Integer, add_id As Integer)
        ' Adds the add_id to the customers record where cust_id matches, returns rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE customer SET add_id ='" & add_id & "' WHERE cust_id ='" & cust_id & "'"
        'classSql.MySQL_Action_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        Return (classSql.rowsAffected)
    End Function
    Public Function getAddress(Optional cust_id As Integer = 0, Optional address_id As Integer = 0)
        ' Gets an address record based on either the cust_id or the add_id, returns a table
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM address WHERE cust_id = '" & cust_id & "' OR address_id ='" & address_id & "'"

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
    Public Function addAddress(cust_id As Integer, add_1 As String, add_2 As String, town As String, city As String, postcode As String, Optional in_use As Boolean = True)
        ' Creates a new address record, returns the number of rows affacted but I think it should really return the last inserted ID?
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO address (cust_id, add_1, add_2, town, city, postcode, in_use) "
        sqlQuery = sqlQuery & "VALUES ('" & cust_id & "','" & add_1 & "','" & add_2 & "','" & town & "','" & city & "','" & postcode & "'," & in_use & ")"
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
        ' Return(classSql.LastInsertedId)
    End Function
    Public Function updateCustAddress(cust_id As Integer, add_1 As String, add_2 As String, town As String, city As String, postcode As String, Optional in_use As Boolean = True)
        ' Updates a customers address based upon cust_id, returns rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE address SET add_1 ='" & add_1 & "', add_2 ='" & add_2 & "', town ='" & town & "', city ='" & city & "', postcode ='" & postcode & "', in_use ='" & in_use & "' WHERE cust_id ='" & cust_id & "'"
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
