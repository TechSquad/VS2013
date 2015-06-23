Module modSqlWorkshop
    Public Function getServiceHistory(Optional cust_id As Integer = 0)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM service"
        If cust_id > 0 Then
            sqlQuery = sqlQuery & " WHERE cust_id = '" & cust_id & "'"
        End If
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
    Public Function getFormattedServiceHistory(Optional cust_id As Integer = 0)
        Dim classSql As New ClassMySQL_Basic

        'Dim sqlQuery As String = "SELECT SupportTicket.TicketID as ID, SupportTicket.Subject, customer.last_name AS Surname, customer.first_name AS First, DateCreated AS Requested, DateUpdated AS Updated, GroupID, CustomerID FROM SupportTicket join customer on customer.cust_id=CustomerID"
        'sqlQuery = sqlQuery & " WHERE TicketStatusID <> 4" ' ignore the closed tickets

        Dim sqlQuery As String = "SELECT serv_id, customer.first_name, customer.last_name, customer.company_name, date_entered, date_due, users.nick_name, ServiceStatus.Status, serv_desc, ServiceLocation.LocationName FROM service JOIN customer ON customer.cust_id=service.cust_id JOIN users ON tech_id = user_id JOIN ServiceStatus ON ServiceStatus.StatusID = service.status_id JOIN ServiceLocation ON ServiceLocation.LocationID = service.location_id"
        If cust_id > 0 Then
            sqlQuery = sqlQuery & " WHERE cust_id = '" & cust_id & "'"
        End If
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
    Public Function getWorkshopNotes(Optional service_id As Integer = 0, Optional support_ticket_id As Integer = 0)   ' actually gets from SupportNote
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT SupportTicketID, service_id, users.nick_name AS TechID, users2.nick_name AS EditedTechID, AttachmentID, NoteText, NotePublic, DateCreated, DateEdited FROM SupportNote LEFT JOIN users ON SupportNote.TechID = users.user_id LEFT JOIN users AS users2 ON SupportNote.EditedTechID = users2.user_id"
        If service_id > 0 Then
            sqlQuery &= " WHERE service_id = " & service_id
            If support_ticket_id > 0 Then
                sqlQuery &= " OR SupportTicketID = " & support_ticket_id
            End If
        ElseIf support_ticket_id > 0 Then
            sqlQuery &= " WHERE SupportTicketID = " & support_ticket_id
        End If
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
    Public Function getWorkshopSupportTicket(Optional workshop_service_id As Integer = 0)   ' retrieve any SupportTicket for this job
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM SupportTicket"
        If workshop_service_id > 0 Then
            sqlQuery &= " WHERE service_id = " & workshop_service_id
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
    Public Function get_item_type(Optional item_id As Integer = 0) As DataTable
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM serviceItems"

        If item_id > 0 Then sqlQuery &= " WHERE item_id = " & item_id

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
    Public Function get_item_type_desc(item_id As Integer) As String
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM serviceItems  WHERE item_id = " & item_id

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
        get_item_type_desc = MyTable.Rows(0).Item("item_type").ToString
    End Function
    Public Function get_custId_from_serviceId(service_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT cust_id FROM service WHERE serv_id = " & service_id

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
        Return (MyTable.Rows(0).Item("cust_id"))
    End Function
    Public Function get_service_item_left(service_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM serviceItemLeft WHERE service_id = " & service_id

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
    Public Function create_service_item_left(serviceItems_id, service_id, description) As Integer
        'Creates a new Support Ticket, requires a customer ID to assign it to and returns TicketID
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO serviceItemLeft (serviceItems_id, service_id, description) "
        sqlQuery = sqlQuery & "VALUES ('" & serviceItems_id & "','" & service_id & "','" & description & "')"
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
    Public Function get_location_list() As DataTable
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM ServiceLocation"

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
    Public Function get_status_list() As DataTable
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM ServiceStatus"

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
    Public Function create_new_service(cust_id As Integer, serv_desc As String, status_id As Integer, tech_id As Integer, Optional location_id As Integer = 0)
        'Creates a new Support Ticket, requires a customer ID to assign it to and returns TicketID
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO service (cust_id, serv_desc, status_id, tech_id, location_id ) "
        sqlQuery = sqlQuery & "VALUES ('" & cust_id & "','" & serv_desc & "','" & status_id & "','" & tech_id & "','" & location_id & "')"
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
End Module
