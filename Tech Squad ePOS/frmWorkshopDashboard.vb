Public Class frmWorkshopDashboard
    ' ***** Create Properties *****
    Private _message As String
    Private _customerId As Integer
    Private _complete As Boolean = False
    '***** Initialise Properties *****
    Public Property Message As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public Property CustomerId As Integer
        Get
            Return _customerId
        End Get
        Set(ByVal value As Integer)
            _customerId = value
        End Set
    End Property
    Public ReadOnly Property Complete As Boolean
        Get
            Return Me._complete
        End Get
    End Property
    ' ***** Initialise Form *****
    Public Sub New(ByVal cust_id As Integer, ByVal UserMode As String)
        InitializeComponent()           ' This call is required by the designer. Add any initialization after the InitializeComponent() call or in form_load.
        ' To close the form place any data required into Properties
        '_message = "Message Text"
        ' Then set _complete = True and close the form
        '_complete = True
        ' Make sure the creating form issues a frmObjectName.Dispose() to release the resources 
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim my_table As DataTable
        Dim item_Table As DataTable
        Dim item_left_table As DataTable
        Dim ServiceLocation As DataTable
        Dim ServiceStatus As DataTable
        Dim my_support_ticket As Integer = 0

        item_Table = get_item_type()             ' fill the combo-box's
        With cbItem
            .DisplayMember = "item_type"
            .ValueMember = "item_id"
            .DataSource = item_Table
        End With
        ServiceLocation = get_location_list()
        With cbLocation
            .DisplayMember = "LocationName"
            .ValueMember = "LocationID"
            .DataSource = ServiceLocation
        End With
        ServiceStatus = get_status_list()
        With cbStatus
            .DisplayMember = "Status"
            .ValueMember = "StatusID"
            .DataSource = ServiceStatus
        End With

        my_table = getFormattedServiceHistory() ' get service details for top data grid view box
        If my_table.Rows.Count > 0 Then ' only update if there is data in the table - If there is no data then you should probably throw an error as something has gone wrong.
            dgvWorkshop.DataSource = my_table
            With dgvWorkshop ' setup column sizes, headings, hidden columns etc
                '.Columns.Item("ID").Width = 30
                '.Columns.Item("Subject").Width = 100
                '.Columns.Item("TicketID").HeaderText = "ID"
                '.Columns.Item("TicketStatusID").Width = 150
                '.Columns.Item("TicketStatusID").HeaderText = "Description"
                '.Columns.Item("cust_id").Width = 100
                '.Columns.Item("cust_id").HeaderText = "Customer ID"
                '.Columns.Item("inv_id").Width = 100
                '.Columns.Item("inv_id").HeaderText = "Invoice ID"
                .Refresh()
            End With
            my_table = getWorkshopSupportTicket(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value) ' Check for existing assigned SupportTicket. get SupportTicket.TicketID by sending workshop_service_id
            If my_table.Rows.Count > 0 Then
                my_support_ticket = my_table.Rows(0).Item("TicketID")
            End If
            my_table = getWorkshopNotes(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value, my_support_ticket) ' Get notes for WorkshopService and for Support Ticket by specifying both parameters
            If my_table.Rows.Count > 0 Then
                dgvNotes.DataSource = my_table  'display notes
                With dgvNotes    ' setup column sizes, headings, hidden columns etc
                    .Columns.Item("NoteText").Width = 300
                    '.Columns.Item("Subject").Width = 100
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
            cbLocation.SelectedIndex = cbLocation.FindStringExact(dgvWorkshop.SelectedRows(0).Cells("LocationName").Value.ToString) ' set value in combo box
            cbStatus.SelectedIndex = cbStatus.FindStringExact(dgvWorkshop.SelectedRows(0).Cells("Status").Value.ToString) ' set value in combo box
            CustomerId = get_custId_from_serviceId(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value) ' set CustomerId from data grid view
            item_left_table = get_service_item_left(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value) 'get items left
            For Each row As DataRow In item_left_table.Rows ' add each item to the list-box
                lbItemsLeft.Items.Add(get_item_type_desc(row("serviceItems_id")) & ": " & row("description"))
            Next
            updateContact() ' display customer contact info
        End If
    End Sub
    Private Sub updateContact()
        Dim m_contact As DataTable = getContact(CustomerId)
        txtEmail.Text = m_contact.Rows(0).Item("email")
        txtFax.Text = m_contact.Rows(0).Item("fax")
        txtHome.Text = m_contact.Rows(0).Item("home_tel")
        txtMobile.Text = m_contact.Rows(0).Item("mobile_tel")
        txtWork.Text = m_contact.Rows(0).Item("work_tel")
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub lblLocate_Click(sender As System.Object, e As System.EventArgs) Handles lblLocate.Click

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub dgvWorkshop_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorkshop.CellClick
        'load notes when you click on a cell
        Dim my_table As DataTable
        Dim item_left_table As DataTable
        Dim my_support_ticket As Integer = 0
        ' add code to check that row has changed to reduce calls to database?

        my_table = getWorkshopSupportTicket(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value) ' Check for existing assigned SupportTicket. get SupportTicket.TicketID by sending workshop_service_id
        If my_table.Rows.Count > 0 Then
            my_support_ticket = my_table.Rows(0).Item("TicketID")
        End If

        my_table = getWorkshopNotes(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value, my_support_ticket) ' Get notes for WorkshopService and for Support Ticket by specifying both parameters

        If my_table.Rows.Count > 0 Then
            dgvNotes.DataSource = my_table  'display notes
            With dgvNotes    ' setup column sizes, headings, hidden columns etc
                .Columns.Item("NoteText").Width = 300
                '.Columns.Item("Subject").Width = 100
                '.Columns.Item("TicketID").HeaderText = "ID"
                '.Columns.Item("TicketStatusID").Width = 150
                '.Columns.Item("TicketStatusID").HeaderText = "Description"
                '.Columns.Item("cust_id").Width = 100
                '.Columns.Item("cust_id").HeaderText = "Customer ID"
                '.Columns.Item("inv_id").Width = 100
                '.Columns.Item("inv_id").HeaderText = "Invoice ID"
                .Refresh()
            End With
        Else
            ' If there are no notes I need to make sure the last customers notes do not show
            dgvNotes.DataSource = Nothing
        End If
        CustomerId = get_custId_from_serviceId(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value)  'Update CustomerId
        item_left_table = get_service_item_left(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value) ' get items left
        lbItemsLeft.Items.Clear()   'Clear list box before changing customer
        For Each row As DataRow In item_left_table.Rows     ' read in all items left for this customers service
            lbItemsLeft.Items.Add(get_item_type_desc(row("serviceItems_id")) & ": " & row("description"))
        Next
        cbLocation.SelectedIndex = cbLocation.FindStringExact(dgvWorkshop.SelectedRows(0).Cells("LocationName").Value.ToString) ' set value in combo box
        cbStatus.SelectedIndex = cbStatus.FindStringExact(dgvWorkshop.SelectedRows(0).Cells("Status").Value.ToString) ' set value in combo box
        updateContact()
    End Sub
    Private Sub btnItemsLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnItemsLeft.Click
        Dim item_left_table As DataTable

        ' add the item into the database
        create_service_item_left(cbItem.SelectedIndex, dgvWorkshop.SelectedRows(0).Cells("serv_id").Value, txtItemLeft.Text)
        item_left_table = get_service_item_left(dgvWorkshop.SelectedRows(0).Cells("serv_id").Value)
        lbItemsLeft.Items.Clear()   'Clear list box before refreshing list
        For Each row As DataRow In item_left_table.Rows     ' read in all items left for this customers service
            lbItemsLeft.Items.Add(get_item_type_desc(row("serviceItems_id")) & ": " & row("description"))
        Next
        txtItemLeft.Text = ""   ' clear text-box
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCustomerLink.Click
        Dim mdi_frmCustomer As New frmCustomer

        Dim frmCustDetail As New frmCustomerDetail(CustomerId, "View")
        frmCustDetail.Show()
    End Sub

    Private Sub lblCustomerLink_MouseEnter(sender As Object, e As EventArgs) Handles lblCustomerLink.MouseEnter
        Dim m_font As Font
        m_font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Underline)
        lblCustomerLink.Font = m_font
    End Sub
    Private Sub lblCustomerLink_MouseLeave(sender As Object, e As EventArgs) Handles lblCustomerLink.MouseLeave
        Dim m_font As Font
        m_font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        lblCustomerLink.Font = m_font
    End Sub
End Class