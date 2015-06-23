Module modSqlClient
    Function isCustomer(first_name As String, last_name As String)  'determines if a customer exists based on the first and last names, returns True or False
        ' This can be a problem as it will return True if first and last names match so people with the same name cannot be created
        ' This function should be depreciated
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        sqlQuery = "SELECT COUNT(*) FROM customer WHERE first_name ='" & first_name & "' AND last_name ='" & last_name & "'"
        'classSql.MySQL_get_record_count(sqlQuery) ', My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
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
    Function getCustomer(cust_id As String) 'Gets the customer record based on the cust_id, returns a string
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM customer WHERE cust_id ='" & cust_id & "'"

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
    Function getCustomerFullName(cust_id As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT CONCAT(first_name, ' ', last_name) AS fullname FROM customer WHERE cust_id ='" & cust_id & "'"

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
        Return (MyTable.Rows(0).Item(0).ToString)
    End Function
    Function getAllCustomers(Optional support As Boolean = False)  'Gets all the customer records to populate a DataGridView, returns a Table
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM customer"

        If support = True Then
            sqlQuery &= " WHERE acct_type = 'Support'"
        End If
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
    Public Function addCustomer(membership As String, acct_type As String, cust_title As String, first_name As String, last_name As String, company_name As String, dob As String, Optional is_company As Boolean = False, Optional mailing_list As Boolean = True, Optional vip As Boolean = False, Optional in_use As Boolean = True)
        'Creates a new customer record
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO customer (membership, acct_type, title, first_name, last_name, company_name, date_of_birth, is_company, mailing_list, vip, in_use, date_created) "
        sqlQuery = sqlQuery & "VALUES ('" & membership & "','" & acct_type & "','" & cust_title & "','" & first_name & "','" & last_name & "','" & company_name & "','" & dob & "'," & is_company & "," & mailing_list & "," & vip & "," & in_use & ", CURRENT_TIMESTAMP)"
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
    Public Function updateCustomer(cust_id As String, membership As String, acct_type As String, cust_title As String, first_name As String, last_name As String, company_name As String, dob As String, Optional is_company As Boolean = False, Optional mailing_list As Boolean = True, Optional vip As Boolean = False, Optional in_use As Boolean = True)
        ' Updates an existing customer record, returns number of rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE customer SET membership ='" & membership & "',acct_type='" & acct_type & "',title='" & cust_title & "',first_name='" & first_name & "',last_name='" & last_name & "',company_name='" & company_name & "',date_of_birth='" & dob & "',is_company=" & is_company & ",mailing_list=" & mailing_list & ",vip=" & vip & ",in_use=" & in_use & ",date_changed= CURRENT_TIMESTAMP WHERE cust_id = '" & cust_id & "'"
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
    Function getCustomerID(title As String, first_name As String, last_name As String)
        ' Gets cust_id based upon a search of first and last names, returns first cust_id so will be a problem if people share the same first and last names
        ' This function should not be used because of possible name duplicates, customers should be selected from a picklist
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim cust_id As Integer
        Dim MyTable As New DataTable

        sqlQuery = "SELECT * FROM customer WHERE title ='" & title & "' AND first_name ='" & first_name & "' AND last_name ='" & last_name & "'"
        'classSql.MySQL_Select_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Select_Query(sqlQuery)
        End With
        MyTable = classSql.Table
        frmCustomer.DataGridView1.DataSource = MyTable
        frmCustomer.DataGridView1.Refresh()
        cust_id = classSql.Table.Rows(0).Item("cust_id")
        Return (cust_id)
    End Function
    Public Function getSalutation() ' Gets a list of salutations, returns a table
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM salutation GROUP BY title "
        Dim MyTable As New DataTable

        'classSql.MySQL_Select_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
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
    Public Function getAcctType()   ' gets a list of account types, returns a table
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM account_type GROUP BY type"
        Dim MyTable As New DataTable

        'classSql.MySQL_Select_Query(sqlQuery, My.Settings.db_Name, My.Settings.db_Url, My.Settings.db_User, My.Settings.db_Password)
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
    Public Function getNameAddress(Optional searchString As String = "*")
        ' Gets both name and address records in a single query, returns a table
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM customer LEFT JOIN address ON customer.cust_id = address.cust_id "
        Dim MyTable As New DataTable

        If searchString <> "*" Then
            searchString = "%" & searchString & "%"
            sqlQuery = sqlQuery & "WHERE (customer.first_name LIKE '" & searchString & "' OR customer.last_name LIKE '" & searchString & "')"
        End If
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
    Public Function getCustNameAddress(cust_id As Integer)
        ' Gets the customers address based on cust_id, returns a table
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM customer LEFT JOIN address ON customer.cust_id = address.cust_id WHERE customer.cust_id ='" & cust_id & "'"
        Dim MyTable As New DataTable

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
End Module

