
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
        Dim cust_id As Integer
        Dim result As Boolean
        If Me.Text = "Add Customer" Or Me.Text = "Add Skeleton Customer" Then
            'Add New Customer Mode
            If txtEmail.Text <> "" Then chkMailing.Checked = True
            result = checkBoxes(Me.Text)    ' check to see if all the required fields have been completed
            If result <> True Then Exit Sub
            ' create customer record and get cust_id
            cust_id = addCustomer(txtMemberNo.Text, cbAcctType.Text, cbSalutation.Text, txtFName.Text, txtSurName.Text, txtCoName.Text, txtDob.Text, rb_isCompany.Checked, chkMailing.Checked, chkVIP.Checked, True)
            'MsgBox("Cust ID: " & cust_id)
            If cust_id > 0 Then ' if cust_id has been issued then create address, contact, note and terms
                If addAddress(cust_id, txtAdd1.Text, txtAdd2.Text, txtTown.Text, txtCity.Text, txtPostCode.Text) Then
                    If addContact(cust_id, txtHomePhone.Text, txtWorkPhone.Text, txtMobilePhone.Text, txtEmail.Text, txtFax.Text) Then
                        If addNote(cust_id, rtxtNotes.Text) Then
                            If addTerms(cust_id, rbCash.Checked, rbExchange.Checked, rbCredit.Checked, chkStatements.Checked, txtDaysCredit.Text) Then
                            Else
                                MsgBox("Terms Creation Failed")
                            End If
                        Else
                            MsgBox("Note Creation Failed")
                        End If
                    Else
                        MsgBox("Contact Creation Failed")
                    End If
                Else
                    MsgBox("Address Creation Failed")
                End If
            Else
                MsgBox("No Customer ID Issued")
            End If
            initialiseEdit(cust_id, "View") 'This re-shows the new record in the form but locked for editing
        Else
            btnCancel.Text = "Cancel"   ' make sure cancel button text is correct
            'Edit existing Customer Mode
            If btnEdit.Text = "Save" Then
                'Already in edit mode so save data
                cust_id = txtAcctNo.Text
                updateCustomer(txtAcctNo.Text.ToString, txtMemberNo.Text.ToString, cbAcctType.Text.ToString, cbSalutation.Text.ToString, txtFName.Text.ToString, txtSurName.Text.ToString, txtCoName.Text.ToString, txtDob.Text.ToString, rb_isCompany.Checked, chkMailing.Checked, chkVIP.Checked, True)
                updateCustAddress(txtAcctNo.Text, txtAdd1.Text.ToString, txtAdd2.Text.ToString, txtTown.Text.ToString, txtCity.Text.ToString, txtPostCode.Text.ToString)
                updateContact(txtAcctNo.Text, txtHomePhone.Text.ToString, txtWorkPhone.Text.ToString, txtMobilePhone.Text.ToString, txtEmail.Text.ToString, txtFax.Text.ToString)
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
        'Get account type for combobox
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
        MyTable = getCustomer(cust_id)
        If MyTable.Rows.Count > 0 Then
            txtAcctNo.Text = MyTable.Rows(0).Item("cust_id")
            txtCoName.Text = MyTable.Rows(0).Item("company_name")
            txtMemberNo.Text = MyTable.Rows(0).Item("membership")
            cbAcctType.Text = MyTable.Rows(0).Item("acct_type")
            rb_isCompany.Checked = MyTable.Rows(0).Item("is_company")
            rb_isIndividual.Checked = Not MyTable.Rows(0).Item("is_company")
            cbSalutation.Text = MyTable.Rows(0).Item("title")
            txtFName.Text = MyTable.Rows(0).Item("first_name")
            txtSurName.Text = MyTable.Rows(0).Item("last_name")
            txtDob.Text = MyTable.Rows(0).Item("date_of_birth")
            chkVIP.Checked = MyTable.Rows(0).Item("vip")
            chkMailing.Checked = MyTable.Rows(0).Item("mailing_list")
        End If

        'Get address detail
        MyTable = getAddress(cust_id)
        If MyTable.Rows.Count > 0 Then
            txtAdd1.Text = MyTable.Rows(0).Item("add_1")
            txtAdd2.Text = MyTable.Rows(0).Item("add_2")
            txtTown.Text = MyTable.Rows(0).Item("town")
            txtCity.Text = MyTable.Rows(0).Item("city")
            txtPostCode.Text = MyTable.Rows(0).Item("postcode")
        End If
        'get contact detail
        MyTable = getContact(cust_id)
        If MyTable.Rows.Count > 0 Then
            txtHomePhone.Text = MyTable.Rows(0).Item("home_tel")
            txtWorkPhone.Text = MyTable.Rows(0).Item("work_tel")
            txtMobilePhone.Text = MyTable.Rows(0).Item("mobile_tel")
            txtEmail.Text = MyTable.Rows(0).Item("email")
            txtFax.Text = MyTable.Rows(0).Item("fax")
        End If
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

        frmPostcodeLookupNew.Show() 'Display the form
        While frmPostcodeLookupNew.Complete = False ' Loop until the form has completed its task
            Application.DoEvents()  ' Allow other modules to continue
        End While
        If frmPostcodeLookupNew.abort = True Then

        Else
            ' Receive return data from formClass
            Dim m_place As String = frmPostcodeLookupNew.Place
            Dim m_StreetAddress As String = frmPostcodeLookupNew.StreetAddress
            Dim m_address() As String   ' to receive comma delimited string

            m_address = m_StreetAddress.Split(",")  ' Split into seperate strings at each comma
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
