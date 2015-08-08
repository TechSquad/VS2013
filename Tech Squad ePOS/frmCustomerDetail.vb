
Public Class frmCustomerDetail
    Private _Complete As Boolean = False
    Public ReadOnly Property Complete As Boolean
        Get
            Return Me._complete
        End Get
    End Property

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        _Complete = True
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim my_customer As New ClassCustomer
        Dim my_address As New address
        Dim my_contact As New contact
        Dim cust_id As Integer
        Dim result As Boolean

        If Me.Text = "Add Customer" Or Me.Text = "Add Skeleton Customer" Then
            'Add New Customer Mode
            If txtEmail.Text <> "" Then chkMailing.Checked = True
            result = checkBoxes(Me.Text)    ' check to see if all the required fields have been completed
            If result <> True Then Exit Sub
            ' create customer record and get cust_id
            With my_customer    ' customer class create new customer
                .membership = txtMemberNo.Text
                .acct_type = cbAcctType.Text.ToString
                .title = cbSalutation.Text.ToString
                .first_name = txtFName.Text
                .last_name = txtSurName.Text
                .company_name = txtCoName.Text
                .date_of_birth = txtDob.Text
                If rb_isCompany.Checked Then .is_company = 1 Else .is_company = 0
                If chkMailing.Checked Then .addToMailingList() Else .removeFromMailingList()
                If chkVIP.Checked Then .makeVIP() Else .removeVIP()
                .save_to_db()
                If Not .success Then
                    MsgBox("Customer creation failed: " & .error_message) ' failed to save data to database
                Else
                    cust_id = .cust_id  ' retrieve and store customer ID for use in address etc
                    txtAcctNo.Text = .cust_id
                End If
            End With
            If cust_id > 0 Then ' if cust_id has been issued then create address, contact, note and terms
                ' use address class here
                With my_address
                    .cust_id = cust_id
                    .add_1 = txtAdd1.Text
                    .add_2 = txtAdd2.Text
                    .town = txtTown.Text
                    .city = txtCity.Text
                    .postcode = txtPostCode.Text
                    .save_to_db()
                    If Not .success Then
                        MsgBox("Address Creation Failed: " & .error_message) ' failed to save data to database
                    Else
                        my_customer.address_id = .address_id    ' put new address id into my_customer
                        my_customer.save_to_db()                ' save customer updated with address id
                    End If
                End With
                ' use class contact here
                With my_contact
                    .cust_id = cust_id
                    .email = txtEmail.Text
                    .fax = txtFax.Text
                    .home_tel = txtHomePhone.Text
                    .mobile_tel = txtMobilePhone.Text
                    .work_tel = txtWorkPhone.Text
                    .in_use = True
                    .save_to_db()
                    If .success Then
                        my_customer.contact_id = .contact_id
                        my_customer.save_to_db()  ' update customer with contact id
                    Else
                        MsgBox("Contact creation failed: " & .error_message)
                    End If
                End With
                'If addContact(cust_id, txtHomePhone.Text, txtWorkPhone.Text, txtMobilePhone.Text, txtEmail.Text, txtFax.Text) Then
                If addNote(cust_id, rtxtNotes.Text) Then
                    If addTerms(cust_id, rbCash.Checked, rbExchange.Checked, rbCredit.Checked, chkStatements.Checked, txtDaysCredit.Text) Then
                    Else
                        MsgBox("Terms Creation Failed")
                    End If
                Else
                    MsgBox("Note Creation Failed")
                End If
                'Else
                '   MsgBox("Contact Creation Failed")
                'End If
                'Else
                '   MsgBox("Address Creation Failed")
                'End If
            Else
                MsgBox("No Customer ID Issued")
            End If
            initialiseEdit(cust_id, "View") 'This re-shows the new record in the form but locked for editing
        Else
            btnCancel.Text = "Cancel"   ' make sure cancel button text is correct
            'Edit existing Customer Mode
            If btnEdit.Text = "Save" Then
                'Already in edit mode so save data
                With my_customer    ' customer class 
                    .cust_id = txtAcctNo.Text
                    .get_from_db() ' gets all the customer details from DB prior to update
                    If Not .success Then
                        MsgBox(.error_message) ' failed to get data from database
                    Else
                        .membership = txtMemberNo.Text
                        .acct_type = cbAcctType.Text.ToString
                        .title = cbSalutation.Text.ToString
                        .first_name = txtFName.Text
                        .last_name = txtSurName.Text
                        .company_name = txtCoName.Text
                        .date_of_birth = txtDob.Text
                        If rb_isCompany.Checked Then .is_company = 1 Else .is_company = 0
                        If chkMailing.Checked Then .addToMailingList() Else .removeFromMailingList()
                        If chkVIP.Checked Then .makeVIP() Else .removeVIP()
                        .save_to_db()
                        If Not .success Then MsgBox(.error_message) ' failed to save data to database
                    End If
                End With
                With my_address
                    .address_id = my_customer.address_id
                    .get_from_db()    ' get all details from DB prior to update
                    If Not .success Then
                        MsgBox(.error_message)  ' failed to get data from database
                    Else
                        .cust_id = txtAcctNo.Text
                        .add_1 = txtAdd1.Text
                        .add_2 = txtAdd2.Text
                        .town = txtTown.Text
                        .city = txtCity.Text
                        .postcode = txtPostCode.Text
                        .save_to_db()
                        If Not .success Then MsgBox(.error_message) ' failed to save data to database
                    End If
                End With
                cust_id = txtAcctNo.Text
                ' use class contact here
                With my_contact
                    .contact_id = my_customer.contact_id
                    .get_from_db()
                    If Not .success Then
                        MsgBox("Contact retrieval failed: " & .error_message)
                    Else
                        .contact_id = my_customer.contact_id
                        .email = txtEmail.Text
                        .fax = txtFax.Text
                        .home_tel = txtHomePhone.Text
                        .mobile_tel = txtMobilePhone.Text
                        .work_tel = txtWorkPhone.Text
                        .in_use = True
                        .save_to_db()
                        If Not .success Then
                            MsgBox("Contact update failed: " & .error_message)
                        End If
                    End If
                End With
                updateNote(cust_id, rtxtNotes.Text)
                updateTerms(cust_id, rbCash.Checked, rbExchange.Checked, rbCredit.Checked, chkStatements.Checked, txtDaysCredit.Text)
                ctrlsEnabled(False)
                btnEdit.Text = "Edit"
                Me.Text = "View Customer"
            Else
                'Enter edit mode
                Me.Text = "Edit Customer"
                btnEdit.Text = "Save"
                ctrlsEnabled(True)
            End If
            btnCancel.Text = "Exit" ' once edit mode has completed make sure cancel button shows as Exit button
        End If
    End Sub
    Private Function checkBoxes(checkMode As String)
        Dim testResult As Boolean = True

        Select Case checkMode
            Case "Add Skeleton Customer"
                If txtFName.Text = "" Then
                    testResult = False
                    txtFName.BackColor = Color.LightPink
                End If
                If txtSurName.Text = "" Then
                    testResult = False
                    txtSurName.BackColor = Color.LightPink
                End If

                If txtPostCode.Text = "" Then
                    testResult = False
                    txtPostCode.BackColor = Color.LightPink
                End If
            Case "Add Customer"
                If txtFName.Text = "" Then
                    testResult = False
                    txtFName.BackColor = Color.LightPink
                End If
                If txtSurName.Text = "" Then
                    testResult = False
                    txtSurName.BackColor = Color.LightPink
                End If
                If txtAdd1.Text = "" Then
                    testResult = False
                    txtAdd1.BackColor = Color.LightPink
                End If
                If txtPostCode.Text = "" Then
                    testResult = False
                    txtPostCode.BackColor = Color.LightPink
                End If

                If txtEmail.Text = "" Then
                    testResult = False
                    txtEmail.BackColor = Color.LightPink
                End If
        End Select
        Return (testResult)
    End Function
    Private Sub ctrlsEnabled(lockedStatus As Boolean)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Or TypeOf ctrl Is TabControl Then
                ctrl.Enabled = True
            Else
                ctrl.Enabled = lockedStatus
                'rtxtNotes.Enabled = lockedStatus
            End If
        Next
        For Each ctrl As Control In Me.TabPage1.Controls
            ctrl.Enabled = lockedStatus
        Next
        For Each ctrl As Control In Me.TabPage2.Controls
            ctrl.Enabled = lockedStatus
        Next
    End Sub

    Public Sub New(ByVal cust_id As Integer, ByVal UserMode As String)

        ' This call is required by the designer.
        InitializeComponent()           ' Add any initialization after the InitializeComponent() call.
        Select Case UserMode
            Case "Add"
                If cust_id = 0 Then
                    initialiseAdd()
                End If
            Case "Edit"
                If cust_id > 0 Then
                    initialiseEdit(cust_id, UserMode)
                End If
            Case "View"
                If cust_id > 0 Then
                    initialiseEdit(cust_id, UserMode)
                End If
            Case "skeleton"
                If cust_id = 0 Then
                    initialiseAddSkeleton()
                End If
        End Select
    End Sub
    Private Sub initialiseEdit(cust_id As Integer, UserMode As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim my_customer As New ClassCustomer
        Dim my_contact As New contact

        If UserMode = "Edit" Then
            Me.Text = "Edit Customer"
            ctrlsEnabled(True)
            btnEdit.Text = "Save"
        Else
            Me.Text = "View Customer"
            ctrlsEnabled(False)
            btnEdit.Text = "Edit"
            btnCancel.Text = "Exit"
        End If
        Me.Cursor = Cursors.WaitCursor
        'Get account type for combo box
        Me.Cursor = Cursors.WaitCursor
        MyTable = getAcctType()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("type")) Then
                cbAcctType.Items.Add(row("type"))
            End If
        Next
        'Get Salutation for Combo Box
        MyTable = getSalutation()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("title")) Then
                cbSalutation.Items.Add(row("title"))
            End If
        Next
        With my_customer        'Class Customer implemented
            .cust_id = cust_id
            .get_from_db()
            If .success Then
                txtAcctNo.Text = cust_id
                txtMemberNo.Text = .membership
                txtCoName.Text = .company_name
                cbAcctType.Text = .acct_type
                If .is_company Then rb_isCompany.Checked = True Else rb_isIndividual.Checked = True
                cbSalutation.Text = .title
                txtFName.Text = .first_name
                txtSurName.Text = .last_name
                txtDob.Text = .date_of_birth
                If .VIP Then chkVIP.Checked = True Else chkVIP.Checked = False
                If .mailing_list Then chkMailing.Checked = True Else chkMailing.Checked = False
            Else
                MsgBox(.error_message)
            End If

        End With
        'Get address detail
        Dim my_address As New address

        With my_address     ' class address implemented
            .address_id = my_customer.address_id
            .get_from_db()  ' load address details from database
            If .success Then
                txtAdd1.Text = .add_1
                txtAdd2.Text = .add_2
                txtTown.Text = .town
                txtCity.Text = .city
                txtPostCode.Text = .postcode
            Else
                MsgBox(.error_message)
            End If
        End With
        'get contact detail
        With my_contact
            .contact_id = my_customer.contact_id
            .get_from_db()
            If Not .success Then
                MsgBox("Contact retrieval failed: " & .error_message)
            Else
                txtEmail.Text = .email
                txtFax.Text = .fax
                txtHomePhone.Text = .home_tel
                txtMobilePhone.Text = .mobile_tel
                txtWorkPhone.Text = .work_tel
            End If
        End With
        'get notes
        MyTable = getNotes(cust_id)
        If MyTable.Rows.Count > 0 Then
            rtxtNotes.Text = MyTable.Rows(0).Item("note")
        End If
        'get terms
        MyTable = getTerms(cust_id)
        If MyTable.Rows.Count > 0 Then
            rbCash.Checked = MyTable.Rows(0).Item("cash")
            rbExchange.Checked = MyTable.Rows(0).Item("exchange")
            rbCredit.Checked = MyTable.Rows(0).Item("account")
            chkStatements.Checked = MyTable.Rows(0).Item("statements")
            txtDaysCredit.Text = MyTable.Rows(0).Item("days_credit")
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub initialiseAdd()
        Dim classSql As New ClassMySQL_Basic
        Dim classSql2 As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        'Get Account Type for Combo Box
        MyTable = getAcctType()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("type")) Then
                cbAcctType.Items.Add(row("type"))
            End If
        Next
        'Get Salutation for Combo Box
        MyTable = getSalutation()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("title")) Then
                cbSalutation.Items.Add(row("title"))
            End If
        Next
        Me.Cursor = Cursors.Arrow
        Me.Text = "Add Customer"
        btnEdit.Text = "Save"
        ctrlsEnabled(True)
    End Sub
    Private Sub initialiseAddSkeleton()
        Dim classSql As New ClassMySQL_Basic
        Dim classSql2 As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        'Get Account Type for Combo Box
        MyTable = getAcctType()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("type")) Then
                cbAcctType.Items.Add(row("type"))
            End If
        Next
        'Get Salutation for Combo Box
        MyTable = getSalutation()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("title")) Then
                cbSalutation.Items.Add(row("title"))
            End If
        Next
        Me.Cursor = Cursors.Arrow
        Me.Text = "Add Customer"
        btnEdit.Text = "Save"
        ctrlsEnabled(True)
        ' ************** Initialise fields *****************
        Me.Text = "Add Skeleton Customer"
        rb_isIndividual.Checked = True
        txtCoName.BackColor = Color.LightGray
        txtDob.BackColor = Color.LightGray
        txtAdd2.BackColor = Color.LightGray
        txtAdd2.BackColor = Color.LightGray
        txtTown.BackColor = Color.LightGray
        txtCity.BackColor = Color.LightGray
        rtxtNotes.BackColor = Color.LightGray
        cbAcctType.SelectedItem = "Support"
    End Sub
    Private Sub txtMemberNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMemberNo.Validating
        If txtMemberNo.Text = "" Then
            'OK to have a blank number if not a member
            'MsgBox("Blank Membership Number")
        ElseIf IsNumeric(txtMemberNo.Text) Then
            'True membership number must be numeric
            'MsgBox("Number Entered")
        Else
            'If not blank or numeric then it is wrong and needs to be re-input or blanked
            'MsgBox("Incorrect Membership Number Entered")
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
            txtMemberNo.SelectionStart = 0
            txtMemberNo.SelectionLength = txtMemberNo.Text.Length
            txtMemberNo.Refresh()
            txtMemberNo.Focus()
            'txtMemberNo.Text = txtMemberNo.Text
        End If

    End Sub
    Private Sub validateInput()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                Replace(ctrl.Text, "'", "''")
            End If
        Next
    End Sub
    Private Sub btnPostcodeLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnPostcodeLookup.Click
        ' Open postcode lookup form
        Dim frmPostcodeLookupNew As New frmPostcodeLookup(txtPostCode.Text) ' Create instance of the formClass
        If frmPostcodeLookupNew.abort = False Then  ' Check to see if form creation has aborted the lookup
            frmPostcodeLookupNew.Show() 'Display the form
            While frmPostcodeLookupNew.Complete = False ' Loop until the form has completed its task
                Application.DoEvents()  ' Allow other modules to continue otherwise the new form won't show
            End While
        End If
        If frmPostcodeLookupNew.abort = True Then
            frmPostcodeLookupNew.Dispose()  ' If form has aborted then dispose of it, otherwise process returned address data
        Else
            ' Receive return data from formClass
            Dim m_place As String = frmPostcodeLookupNew.Place
            Dim m_StreetAddress As String = frmPostcodeLookupNew.StreetAddress
            Dim m_address() As String   ' to receive comma delimited string

            m_address = m_StreetAddress.Split(",")  ' Split into separate strings at each comma
            ' Display according to the length of the address
            If m_address.Length = 5 Then
                txtPostCode.Text = m_address(0)
                txtAdd1.Text = m_address(1)
                txtAdd2.Text = m_address(2)
                txtTown.Text = m_address(3)
                txtCity.Text = m_address(4)
            ElseIf m_address.Length = 6 Then
                txtPostCode.Text = m_address(0)
                txtAdd1.Text = m_address(1)
                txtAdd2.Text = m_address(2) & " " & m_address(3)
                txtTown.Text = m_address(4)
                txtCity.Text = m_address(5)
            ElseIf m_address.Length = 7 Then
                txtPostCode.Text = m_address(0)
                txtAdd1.Text = m_address(1) & "," & m_address(2) & " " & m_address(3)
                txtAdd2.Text = m_address(4)
                txtTown.Text = m_address(5)
                txtCity.Text = m_address(6)
            End If
        End If
        frmPostcodeLookupNew.Dispose()  ' tidy up form now we have finished with it

    End Sub

    Private Sub frmCustomerDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
