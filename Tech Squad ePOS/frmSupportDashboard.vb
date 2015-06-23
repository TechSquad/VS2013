'Imports System.Windows.Forms
Public Class frmSupportDashboard
    Private m_TextBoxes() As TextBox = {}
    Public textBoxIndex As Integer = 1
    Dim h, w As Integer
    Dim dgvCellContentChanged As Boolean
    Private m_ChildFormNumber As Integer
    Private m_ticketID As Integer
    Private m_techID As Integer
    Private m_note_text As String
    Private m_note_public As Boolean
    Private m_attachmentID As Integer
    Private m_type As Integer
    Private m_priority As Integer
    Private m_mode As Integer
    Private m_ticket_status As Integer
    Private Enum f_mode
        m_New = 0   ' New Ticket
        m_Add = 1   'Add Note
        m_Edit = 2  'Edit Existing Note
        m_Close = 3 'Close Ticket/Note Detail
    End Enum
    Private form_mode As f_mode
    Private Sub frmSupportDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setup_form_as_dashboard()
        loadDgvData()
        ' setup invisible panel combo boxes
        Dim type_Table As DataTable
        Dim priority_Table As DataTable
        priority_Table = get_support_priority()
        type_Table = get_support_type()
        With cbType
            .DisplayMember = "type_name"
            .ValueMember = "type_id"
            .DataSource = type_Table
        End With
        With cbPriority
            .DisplayMember = "priority_name"
            .ValueMember = "priority_id"
            .DataSource = priority_Table
        End With
        With cbAssignee
            .DisplayMember = "user_name"
            .ValueMember = "user_id"
            .DataSource = get_support_techs()
        End With
    End Sub
    Private Sub setup_form_as_dashboard()
        Dim allOpenTickets As Integer = countSupportTickets(1)
        Dim yourTickets As Integer = countSupportTickets(1, 1)
        Dim groupTickets As Integer = countSupportTickets(1, 0, 1)
        Dim goodTickets As Integer = countSupportTickets(1, 0, 0, "Good")
        Dim badTickets As Integer = countSupportTickets(1, 0, 0, "Bad")
        Dim solvedTickets As Integer = countSupportTickets(4)
        TextBox_my_1.AutoSize = True    'setup textbox for measuring
        Label1.Text = "Open Tickets (current)"
        Label2.Text = "Ticket Statistics (this week)"
        btnYourTickets.Text = yourTickets & Environment.NewLine & "YOU"
        btnGroupTickets.Text = groupTickets & Environment.NewLine & "GROUPS"
        btnGoodTickets.Text = goodTickets & Environment.NewLine & "GOOD"
        buttonBadTickets.Text = badTickets & Environment.NewLine & "BAD"
        btnSolvedTickets.Text = solvedTickets & Environment.NewLine & "SOLVED"
        Label3.Text = "Tickets requiring attention (" & allOpenTickets & ")"
        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = True
        pnlAddTicket1.Visible = False
        pnlAddTicket2.Visible = False
    End Sub
    Private Sub loadDgvData()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        MyTable = getOpenSupportTicket()
        If MyTable.Rows.Count > 0 Then
            DataGridView1.DataSource = MyTable
            'DataGridView1.Refresh()
            With DataGridView1
                .Columns.Item("ID").Width = 30
                .Columns.Item("Subject").Width = 100
                '.Columns.Item("TicketID").HeaderText = "ID"
                '.Columns.Item("TicketStatusID").Width = 150
                '.Columns.Item("TicketStatusID").HeaderText = "Description"
                '.Columns.Item("cust_id").Width = 100
                '.Columns.Item("cust_id").HeaderText = "Customer ID"
                '.Columns.Item("inv_id").Width = 100
                '.Columns.Item("inv_id").HeaderText = "Invoice ID"
                .Refresh()
            End With
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles pbHome.Click
        Dim yourTickets As Integer = 0
        loadDgvData()
        Label3.Text = "Tickets requiring attention (" & countSupportTickets(1) & ")"
        resetPanel(Panel1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnYourTickets.Click
        Dim yourTickets As Integer = 0

        Label3.Text = "Tickets open and assigned to you (" & yourTickets & ")"

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnGroupTickets.Click
        Dim yourTickets As Integer = 0

        Label3.Text = "Tickets open and assigned to your group (" & yourTickets & ")"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnGoodTickets.Click
        Dim yourTickets As Integer = 0

        Label3.Text = "Positively rated tickets this week (" & yourTickets & ")"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles buttonBadTickets.Click
        Dim yourTickets As Integer = 0

        Label3.Text = "Negatively rated tickets this week (" & yourTickets & ")"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles btnSolvedTickets.Click
        Dim yourTickets As Integer = 0

        Label3.Text = "Tickets solved by you this week (" & yourTickets & ")"
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        dgvCellContentChanged = True
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If dgvCellContentChanged Then   'only update if selection changed
            resetPanel(Panel1)
            buildSupportConversation(DataGridView1.SelectedRows.Item(0).Cells("ID").Value)
            dgvCellContentChanged = False
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        ' set form mode to add note as this is an existing ticket
        form_mode = f_mode.m_Add
        setup_form_for_mode()
       
        ' Get data required
        Dim MyTable As New DataTable
        ' place ticket data into variables
        m_ticketID = DataGridView1.SelectedRows(0).Cells(0).Value ' get support ticket ID and store it
        MyTable = getFullSupportTicket(m_ticketID) ' use ID to get full ticket details
        m_techID = MyTable.Rows(0).Item("AssignedTechID")   ' store techID
        m_priority = MyTable.Rows(0).Item("ticket_priority_id")   ' store priority
        m_type = MyTable.Rows(0).Item("ticket_type_id")   ' store type
        ' populate combobox text values
        cbAssignee.SelectedIndex = m_techID - 1
        cbPriority.SelectedIndex = m_priority - 1
        cbType.SelectedIndex = m_type - 1

        txtSubject.Text = MyTable.Rows(0).Item("Subject").ToString
        txtSubject.ReadOnly = True ' read only
        rtxtDescription.Text = MyTable.Rows(0).Item("Description").ToString
        rtxtDescription.ReadOnly = True ' read only
        txtCustomer.Text = getCustomerFullName(DataGridView1.SelectedRows(0).Cells(7).Value.ToString) ' record is only created when the submit button is pressed
        rtxtNote.Text = ""  ' make sure this box is empty
        rtxtNote.Focus()
    End Sub
    Private Sub setup_form_for_mode()
        Select Case form_mode
            Case f_mode.m_Add
                cbSaveAs.Items.Clear()  'Clear old items
                ' Setup combobox items
                cbSaveAs.Items.Add("Submit Ticket as Pending")
                cbSaveAs.Items.Add("Submit Ticket as Open")
                cbSaveAs.Items.Add("Submit Ticket as Closed")
                cbSaveAs.Text = "Submit Ticket as Pending"
                ' Setup form for creating new note
                Me.Text = "Add Note to Ticket"
                rtxtNote.Visible = True
                lblNote.Visible = True
                pnlAddTicket1.Visible = True
                pnlAddTicket1.Location = Panel1.Location
                pnlAddTicket1.BorderStyle = BorderStyle.FixedSingle
                pnlAddTicket1.Size = Panel1.Size
                pnlAddTicket2.Visible = True
                pnlAddTicket2.Location = Panel2.Location
                pnlAddTicket2.Size = Panel2.Size
                Panel1.Visible = False
                Panel2.Visible = False
                Panel3.Visible = False
            Case f_mode.m_Edit
                ' add code here to enable edit mode
            Case f_mode.m_New
                cbSaveAs.Items.Clear()
                cbSaveAs.Items.Add("Create Ticket as Pending")
                cbSaveAs.Items.Add("Create Ticket as Open")
                cbSaveAs.Items.Add("Create Ticket as Closed")
                cbSaveAs.Text = "Create Ticket as Pending"
                cbType.SelectedIndex = 2    ' default to Problem for new tickets
                cbPriority.SelectedIndex = 1 ' default to Normal for new tickets
                ' Setup form for creating new Ticket
                Me.Text = "Create a New Ticket"
                rtxtNote.Visible = False
                lblNote.Visible = False
                pnlAddTicket1.Visible = True
                pnlAddTicket1.Location = Panel1.Location
                pnlAddTicket1.BorderStyle = BorderStyle.FixedSingle
                pnlAddTicket1.Size = Panel1.Size
                pnlAddTicket2.Visible = True
                pnlAddTicket2.Location = Panel2.Location
                pnlAddTicket2.Size = Panel2.Size
                Panel1.Visible = False
                Panel2.Visible = False
                Panel3.Visible = False
            Case f_mode.m_Close
                Me.Text = "Support Dashboard"
                pnlAddTicket1.Visible = False
                pnlAddTicket1.Location = Panel1.Location
                pnlAddTicket1.BorderStyle = BorderStyle.FixedSingle
                pnlAddTicket1.Size = Panel1.Size
                pnlAddTicket2.Visible = False
                pnlAddTicket2.Location = Panel2.Location
                pnlAddTicket2.Size = Panel2.Size
                Panel1.Visible = True
                Panel2.Visible = True
                Panel3.Visible = True
            Case Else
                MsgBox(" The form has no mode setting for this ticket or note, this is a programming error and needs to be looked at by Roger Whitfield. frmSuppportDashboard btnSave_Click")
        End Select

    End Sub
    Private Sub buildSupportConversation(supportTicketId As Integer)
        Dim mySupportTable As New DataTable
        Dim MyNoteTable As New DataTable
        Dim MyConversation As String
        Dim i As Integer = 0
        '**************** Setup subject of conversation **********************
        mySupportTable = getFullSupportTicket(supportTicketId)  'get data from database
        MyConversation = "[" & mySupportTable(0)("DateCreated").ToString & "]" & " <" & mySupportTable(0)("CustomerID").ToString & "> reported:" & vbNewLine
        MyConversation = MyConversation & mySupportTable(0)("Subject").ToString & "; "
        MyConversation = MyConversation & mySupportTable(0)("Description").ToString
        AddTextBox(MyConversation)
        '********************** Setup Tech Notes ***********************
        MyNoteTable = getSupportNote(supportTicketId) 'Get any notes
        Dim Rowcount As Integer = MyNoteTable.Rows.Count
        If Rowcount > 0 Then    'check that rows have data
            For i = 0 To Rowcount - 1  'loop through each row
                MyConversation = "[" & MyNoteTable(i)("DateCreated").ToString & "]" & " <" & MyNoteTable(i)("TechID").ToString & "> said:" & vbNewLine
                MyConversation = MyConversation & MyNoteTable(i)("NoteText").ToString 'read note into variable
                AddTextBox(MyConversation) ' create textbox with text and add to Panel1
            Next
        End If
    End Sub
    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) '*** When you enter text in one of the TextBoxes, the TextBox_TextChanged event
        ' Display the current text.                                                             '*** handler displays the control's name and its current text.
        Dim txt As TextBox = DirectCast(sender, TextBox)
        Debug.WriteLine(txt.Name & ": [" & txt.Text & "]")
    End Sub
    Private Sub AddTextBox(tbText As String, Optional TbHeight As Integer = 0, Optional m_offset As Integer = 1)
        tbText = tbText.Replace("  ", " ")   'strip double spaces from text
        Dim i As Integer = textBoxIndex   ' Get the index for the new control.
        Dim m_height As Integer = MeasureText(tbText)  'Get the new textbox height
        textBoxIndex += 1    'increment index
        ReDim Preserve m_TextBoxes(i)           ' Make room.
        m_TextBoxes(i) = New TextBox            ' Create and initialize the control array.
        With m_TextBoxes(i)
            .Name = "TextBox" & i.ToString()
            .AutoSize = True
            .Multiline = True
            .ForeColor = Color.Blue
            .BackColor = Panel1.BackColor
            .BorderStyle = BorderStyle.FixedSingle
            .MaximumSize = New Size(197, 1000)
            If i = 1 Then ' Position the first one.
                'm_height = MeasureText1(tbText)
                .SetBounds(1, 18, 197, m_height)
            Else ' Position subsequent controls.
                .SetBounds(m_TextBoxes(i - 1).Left, m_TextBoxes(i - 1).Top + m_TextBoxes(i - 1).Height + m_offset, m_TextBoxes(i - 1).Size.Width, m_height)
            End If
            .Tag = i            ' Save the control's index in the Tag property.
            .Text = tbText      ' Put the text in the textbox
        End With
        AddHandler m_TextBoxes(i).TextChanged, AddressOf TextBox_TextChanged    ' Give the control an event handler.
        Panel1.Controls.Add(m_TextBoxes(i)) 'Add the control to Panel1
    End Sub
    Private Sub resetPanel(ByRef m_control As Control)
        ' Dispose of all textboxes on Panel1, loop to make sure they have all gone
        While textBoxIndex > 1
            For Each ctrl As Control In m_control.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    ctrl.Dispose()
                    textBoxIndex -= 1    'reduce index
                End If
            Next
        End While
    End Sub
    Private Function MeasureText(text1 As String)
        Dim SampleText As String = "Hello World"    'for character sizing only
        Dim flags As TextFormatFlags = TextFormatFlags.NoPadding
        Dim proposedSize As Size = New Size(197, 1000)
        Dim m_font As New Font("Microsoft Sans Serif", 8.25F)
        Dim textSize As Size = TextRenderer.MeasureText(text1, m_font, proposedSize, flags)
        Dim NewTextBoxHeight As Integer = 0
        TextBox_my_1.Text = text1           ' put text in textbox1
        NewTextBoxHeight = (TextBox_my_1.Lines.Length * textSize.Height.ToString)
        Return (NewTextBoxHeight)  ' return text box height
    End Function

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles pbTicketInfo.Click
        Dim all_tickets As Integer = countSupportTickets()
        Dim my_support_tickets As Integer = countSupportTickets(0, 1)
        Dim my_live_support_tickets As Integer = countSupportTickets(1, 1)
        Dim live_Support_tickets As Integer = countSupportTickets(1)

        resetPanel(Panel1)
        AddTextBox("All Tickets   " & all_tickets)
        AddTextBox("All Live Tickets  " & live_Support_tickets)
        AddTextBox("Your Tickets  " & my_support_tickets)
        AddTextBox("Your Live Tickets  " & my_live_support_tickets)
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles pbViewSupportCustomers.Click
        ' Display all customers in gridview1
        Dim myTable As DataTable

        resetPanel(Panel1)
        myTable = getAllCustomers(True) ' get only support customers
        With DataGridView1
            .DataSource = myTable
            .Refresh()
        End With
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles pbAddTicket.Click
        ' add ticket
        add_ticket()    ' initiate the add_ticket routine that sets up the forms and opens the customer selector
    End Sub
    Public Sub add_ticket() ' add new ticket
        resetPanel(Panel1)
        form_mode = f_mode.m_New ' set for mode to add new ticket
        setup_form_for_mode()
        Dim mdi_frmCustomer As New frmCustomer  ' Show customer selector

        If Not IsOpen(mdi_frmCustomer) Then    'check to see if mdi_frmCustomer is already open
            With mdi_frmCustomer
                .MdiParent = frmMainMenu
                .Text = "Add Support Customer"
                .Show()
                .Message = "Select"
            End With
            Me.LayoutMdi(MdiLayout.Cascade)
            While mdi_frmCustomer.Complete = False
                Application.DoEvents()  ' Wait for Lookup to Complete but Allow other modules to continue
            End While
            ' Setup form for creating new ticket
            pnlAddTicket1.Visible = True
            pnlAddTicket1.Location = Panel1.Location
            pnlAddTicket1.BorderStyle = BorderStyle.FixedSingle
            pnlAddTicket1.Size = Panel1.Size
            pnlAddTicket2.Visible = True
            pnlAddTicket2.Location = Panel2.Location
            pnlAddTicket2.Size = Panel2.Size
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            ' Do something with the returned data
            txtCustID.Text = mdi_frmCustomer.CustomerId
            txtCustomer.Text = getCustomerFullName(txtCustID.Text)
        Else
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        resetPanel(Panel1)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)
        Dim mdi_frmCustomer As New frmCustomer  ' Show customer selector

        If Not IsOpen(mdi_frmCustomer) Then    'check to see if mdi_frmCustomer is already open
            With mdi_frmCustomer
                .MdiParent = frmMainMenu
                .Text = "Add Support Customer"
                .Show()
                .Message = "Select"
            End With
            Me.LayoutMdi(MdiLayout.Cascade)
            While mdi_frmCustomer.Complete = False
                Application.DoEvents()  ' Wait for Lookup to Complete but Allow other modules to continue
            End While
            ' Setup form for creating new ticket
            pnlAddTicket1.Visible = True
            pnlAddTicket1.Location = Panel1.Location
            pnlAddTicket1.BorderStyle = BorderStyle.FixedSingle
            pnlAddTicket1.Size = Panel1.Size
            pnlAddTicket2.Visible = True
            pnlAddTicket2.Location = Panel2.Location
            pnlAddTicket2.Size = Panel2.Size
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            ' Do something with the returned data
            txtCustID.Text = mdi_frmCustomer.CustomerId
            txtCustomer.Text = getCustomerFullName(txtCustID.Text)
            ' Here we need to create the new ticket for the selected customer
        Else
        End If
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Select Case cbSaveAs.SelectedIndex
            Case 0
                m_ticket_status = 2
            Case 1
                m_ticket_status = 1
            Case 2
                m_ticket_status = 4
        End Select
        Select Case form_mode
            Case f_mode.m_Add   ' add note to existing case
                If rtxtNote.Text <> "" Then createSupportNote(m_ticketID, m_techID, rtxtNote.Text, True) ' only create a note if here is something in the box
                updateSupportTicket(m_ticketID, m_ticket_status, cbType.SelectedIndex + 1, cbPriority.SelectedIndex + 1, cbAssignee.SelectedIndex + 1)
            Case f_mode.m_Edit
                ' if you need to put edit code in here
            Case f_mode.m_New   ' create new ticket for customer
                createSupportTicket(txtCustID.Text, txtSubject.Text, rtxtDescription.Text, cbType.SelectedIndex + 1, cbPriority.SelectedIndex + 1, cbAssignee.SelectedIndex + 1)
            Case Else
                ' shouldn't get here so maybe throw an error
                MsgBox(" The form has no mode setting for this ticket or note, this is a programming error and needs to be looked at by Roger Whitfield. frmSuppportDashboard btnSave_Click")
        End Select
        form_mode = f_mode.m_Close
        setup_form_for_mode()
        resetPanel(Panel1)
        buildSupportConversation(DataGridView1.SelectedRows.Item(0).Cells("ID").Value)
    End Sub
    Private Sub cbSaveAs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbSaveAs.SelectedIndexChanged
        btnSave.Text = cbSaveAs.SelectedItem.ToString
    End Sub
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        form_mode = f_mode.m_Close
        setup_form_for_mode()

    End Sub

    Private Sub pbRemoteSupport_Click(sender As System.Object, e As System.EventArgs) Handles pbRemoteSupport.Click
        ' Launch Remote Support App - Awaiting reply from SimpleHelp as currently auto login is not working as when you pass any arguments nothing launches
        ' bacause of this it will currently only launch to the log-in screen
        Dim p As New System.Diagnostics.Process

        With p
            '.StartInfo.UseShellExecute = False
            .StartInfo.FileName = "c:\Users\Office\Desktop\SimpleHelp Technician-windows32-offline"
            '.StartInfo.Arguments = " JWVAPP SessionUI JW_launchapi=yes JW_serverURL=http://nortechcomputers.co.uk:8008 JW_technician=Roger JW_password=GR8M3ll0nz"
            '.StartInfo.Verb = "open"
            '.StartInfo.CreateNoWindow = False
            '.StartInfo.Password = trpw("password")
            .Start()
        End With
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Convert to workshop job, maybe even to call-out or remote session
        ' 1. Close existing Ticket
        ' 2. Make sure we have customer details
        ' 3. Create workshop job
    End Sub
End Class

