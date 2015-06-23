Module modSqlService
    Public Function getOpenSupportTicket(Optional ticket_id As Integer = 0)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT SupportTicket.TicketID as ID, SupportTicket.Subject, customer.last_name AS Surname, customer.first_name AS First, DateCreated AS Requested, DateUpdated AS Updated, GroupID, CustomerID FROM SupportTicket join customer on customer.cust_id=CustomerID"
        sqlQuery = sqlQuery & " WHERE TicketStatusID <> 4" ' ignore the closed tickets

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
    Public Function countSupportTickets(Optional ticket_status As Integer = 0, Optional assigned_tech_id As Integer = 0, Optional group_id As Integer = 0, Optional outcome As String = "")
        Dim classSql As New ClassMySQL_Basic
        Dim m_recCount As Integer = 0
        Dim m_where As Boolean = False
        Dim sqlQuery As String = "SELECT Count(*) FROM SupportTicket"

        If ticket_status > 0 Then
            sqlQuery = sqlQuery & " WHERE TicketStatusID = '" & ticket_status & "'"
            m_where = True
        End If
        If assigned_tech_id > 0 Then
            If m_where = True Then
                sqlQuery = sqlQuery & " AND AssignedTechID = '" & assigned_tech_id & "'"
            Else
                sqlQuery = sqlQuery & " WHERE AssignedTechID = '" & assigned_tech_id & "'"
                m_where = True
            End If
        End If
        If group_id > 0 Then
            If m_where = True Then
                sqlQuery = sqlQuery & " AND GroupID = '" & group_id & "'"
            Else
                sqlQuery = sqlQuery & " WHERE GroupID = '" & group_id & "'"
                m_where = True
            End If
        End If
        If outcome <> "" Then
            If m_where = True Then
                sqlQuery = sqlQuery & " AND outcome = '" & outcome & "'"
            Else
                sqlQuery = sqlQuery & " WHERE outcome = '" & outcome & "'"
                m_where = True
            End If
        End If

        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_get_record_count(sqlQuery)
            If .Success = True Then
                m_recCount = .RecCount
            End If
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        Return (m_recCount)
    End Function
    Public Function getFullSupportTicket(TicketID As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM SupportTicket WHERE TicketID=" & TicketID
        Dim MyTable As New DataTable

        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Select_Query(sqlQuery)
            '.MySQL_get_record_count(sqlQuery)
        End With
        MyTable = classSql.Table
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        Return (MyTable)
    End Function
    Public Function getSupportNote(TicketID As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM SupportNote WHERE SupportTicketID = " & TicketID
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
    Public Function createSupportTicket(cust_id As Integer, subject As String, description As String, ticket_type_id As Integer, ticket_priority_id As Integer, assignedtech As Integer, Optional ticketstatusID As Integer = 1, Optional groupID As Integer = 1)  'Status 1 = Opened
        'Creates a new Support Ticket, requires a customer ID to assign it to and returns TicketID
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO SupportTicket (TicketStatusID, CustomerID, GroupID, Subject, Description, AssignedTechID, ticket_type_id, ticket_priority_id) "
        sqlQuery = sqlQuery & "VALUES ('" & ticketstatusID & "','" & cust_id & "','" & groupID & "','" & subject & "','" & description & "','" & assignedtech & "','" & ticket_type_id & "','" & ticket_priority_id & "')"
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
    Public Function updateSupportTicket(ticket_id As Integer, TicketStatusID As Integer, ticket_type_id As Integer, ticket_priority_id As Integer, AssignedTechID As Integer)
        ' Updates an existing customer record, returns number of rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE SupportTicket SET TicketStatusID ='" & TicketStatusID & "', ticket_type_id='" & ticket_type_id & "',ticket_priority_id='" & ticket_priority_id & "',AssignedTechID='" & AssignedTechID & "', DateUpdated= CURRENT_TIMESTAMP WHERE TicketID = '" & ticket_id & "'"
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
    Public Function createSupportNote(support_ticket_id As Integer, tech_id As Integer, note_text As String, note_public As Boolean, Optional attachment_id As Integer = 0)
        'Creates a new Support Ticket, requires a customer ID to assign it to and returns TicketID
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO SupportNote (SupportTicketID, TechID, AttachmentID, NoteText, NotePublic) "
        sqlQuery = sqlQuery & "VALUES ('" & support_ticket_id & "','" & tech_id & "','" & attachment_id & "','" & note_text & "','" & note_public & "')"
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
    Public Function get_support_type()
        ' Gets a table of the type messages
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM support_type"
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
    Public Function get_support_priority()
        ' Gets a table of the priority messages
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM support_priority"
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
    Public Function get_support_techs()
        ' Gets a table of the priority messages
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM users WHERE is_tech = True"
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
    Public Function convert_support_ticket(TicketID As Integer, service_id As Integer)
        ' Updates an existing customer record, returns number of rows affected
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE SupportTicket SET service_id ='" & service_id & ", TicketStstusID = '4', DateUpdated= CURRENT_TIMESTAMP WHERE TicketID = '" & TicketID & "'"
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
