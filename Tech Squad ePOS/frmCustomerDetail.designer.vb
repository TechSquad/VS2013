<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerDetail))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbAcctType = New System.Windows.Forms.ComboBox()
        Me.txtMemberNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAcctNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPostcodeLookup = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDob = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCoName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSalutation = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_isIndividual = New System.Windows.Forms.RadioButton()
        Me.rb_isCompany = New System.Windows.Forms.RadioButton()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.txtWorkPhone = New System.Windows.Forms.TextBox()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtSurName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rtxtNotes = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDaysCredit = New System.Windows.Forms.TextBox()
        Me.chkStatements = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.rbExchange = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkMailing = New System.Windows.Forms.CheckBox()
        Me.chkVIP = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbAcctType)
        Me.Panel1.Controls.Add(Me.txtMemberNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtAcctNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 30)
        Me.Panel1.TabIndex = 17
        '
        'cbAcctType
        '
        Me.cbAcctType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAcctType.FormattingEnabled = True
        Me.cbAcctType.Location = New System.Drawing.Point(611, 4)
        Me.cbAcctType.Name = "cbAcctType"
        Me.cbAcctType.Size = New System.Drawing.Size(111, 21)
        Me.cbAcctType.TabIndex = 10
        '
        'txtMemberNo
        '
        Me.txtMemberNo.Location = New System.Drawing.Point(342, 5)
        Me.txtMemberNo.Name = "txtMemberNo"
        Me.txtMemberNo.Size = New System.Drawing.Size(162, 20)
        Me.txtMemberNo.TabIndex = 310
        Me.txtMemberNo.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(233, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Membership Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(535, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Account Type"
        '
        'txtAcctNo
        '
        Me.txtAcctNo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtAcctNo.Location = New System.Drawing.Point(105, 4)
        Me.txtAcctNo.Name = "txtAcctNo"
        Me.txtAcctNo.ReadOnly = True
        Me.txtAcctNo.ShortcutsEnabled = False
        Me.txtAcctNo.Size = New System.Drawing.Size(100, 20)
        Me.txtAcctNo.TabIndex = 1
        Me.txtAcctNo.TabStop = False
        Me.txtAcctNo.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Number"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnPostcodeLookup)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.txtDob)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txtFax)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtCity)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtCoName)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbSalutation)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtMobilePhone)
        Me.Panel2.Controls.Add(Me.txtWorkPhone)
        Me.Panel2.Controls.Add(Me.txtHomePhone)
        Me.Panel2.Controls.Add(Me.txtPostCode)
        Me.Panel2.Controls.Add(Me.txtTown)
        Me.Panel2.Controls.Add(Me.txtAdd2)
        Me.Panel2.Controls.Add(Me.txtAdd1)
        Me.Panel2.Controls.Add(Me.txtSurName)
        Me.Panel2.Controls.Add(Me.txtFName)
        Me.Panel2.Location = New System.Drawing.Point(12, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 219)
        Me.Panel2.TabIndex = 27
        '
        'btnPostcodeLookup
        '
        Me.btnPostcodeLookup.Location = New System.Drawing.Point(198, 183)
        Me.btnPostcodeLookup.Name = "btnPostcodeLookup"
        Me.btnPostcodeLookup.Size = New System.Drawing.Size(127, 23)
        Me.btnPostcodeLookup.TabIndex = 291
        Me.btnPostcodeLookup.Text = "Get Address"
        Me.btnPostcodeLookup.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(507, 160)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(189, 20)
        Me.txtEmail.TabIndex = 170
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(507, 36)
        Me.txtDob.Mask = "00/00/0000"
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(90, 20)
        Me.txtDob.TabIndex = 130
        Me.txtDob.ValidatingType = GetType(Date)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(435, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Date of Birth"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(450, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 13)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Fax"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(450, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "e-Mail"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(506, 186)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(190, 20)
        Me.txtFax.TabIndex = 180
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(249, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Town"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Postcode"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(287, 158)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 20)
        Me.txtCity.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(450, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Mobile"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(445, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Tel Work"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Tel Home"
        '
        'txtCoName
        '
        Me.txtCoName.Location = New System.Drawing.Point(223, 35)
        Me.txtCoName.Name = "txtCoName"
        Me.txtCoName.Size = New System.Drawing.Size(196, 20)
        Me.txtCoName.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Company Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Salutation"
        '
        'cbSalutation
        '
        Me.cbSalutation.AllowDrop = True
        Me.cbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSalutation.FormattingEnabled = True
        Me.cbSalutation.Location = New System.Drawing.Point(18, 82)
        Me.cbSalutation.Name = "cbSalutation"
        Me.cbSalutation.Size = New System.Drawing.Size(59, 21)
        Me.cbSalutation.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_isIndividual)
        Me.GroupBox1.Controls.Add(Me.rb_isCompany)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 44)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Type"
        '
        'rb_isIndividual
        '
        Me.rb_isIndividual.AutoSize = True
        Me.rb_isIndividual.Location = New System.Drawing.Point(36, 16)
        Me.rb_isIndividual.Name = "rb_isIndividual"
        Me.rb_isIndividual.Size = New System.Drawing.Size(70, 17)
        Me.rb_isIndividual.TabIndex = 20
        Me.rb_isIndividual.TabStop = True
        Me.rb_isIndividual.Text = "Individual"
        Me.rb_isIndividual.UseVisualStyleBackColor = True
        '
        'rb_isCompany
        '
        Me.rb_isCompany.AutoSize = True
        Me.rb_isCompany.Location = New System.Drawing.Point(112, 16)
        Me.rb_isCompany.Name = "rb_isCompany"
        Me.rb_isCompany.Size = New System.Drawing.Size(69, 17)
        Me.rb_isCompany.TabIndex = 30
        Me.rb_isCompany.TabStop = True
        Me.rb_isCompany.Text = "Company"
        Me.rb_isCompany.UseVisualStyleBackColor = True
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Location = New System.Drawing.Point(506, 134)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(190, 20)
        Me.txtMobilePhone.TabIndex = 160
        '
        'txtWorkPhone
        '
        Me.txtWorkPhone.Location = New System.Drawing.Point(506, 108)
        Me.txtWorkPhone.Name = "txtWorkPhone"
        Me.txtWorkPhone.Size = New System.Drawing.Size(190, 20)
        Me.txtWorkPhone.TabIndex = 150
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Location = New System.Drawing.Point(506, 82)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(190, 20)
        Me.txtHomePhone.TabIndex = 140
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(83, 183)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(83, 20)
        Me.txtPostCode.TabIndex = 120
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(83, 158)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(132, 20)
        Me.txtTown.TabIndex = 100
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(83, 133)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(336, 20)
        Me.txtAdd2.TabIndex = 90
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(83, 108)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(336, 20)
        Me.txtAdd1.TabIndex = 80
        '
        'txtSurName
        '
        Me.txtSurName.Location = New System.Drawing.Point(221, 82)
        Me.txtSurName.Name = "txtSurName"
        Me.txtSurName.Size = New System.Drawing.Size(198, 20)
        Me.txtSurName.TabIndex = 70
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(83, 82)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(132, 20)
        Me.txtFName.TabIndex = 60
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 264)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(494, 176)
        Me.TabControl1.TabIndex = 210
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rtxtNotes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(486, 150)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rtxtNotes
        '
        Me.rtxtNotes.Location = New System.Drawing.Point(0, 0)
        Me.rtxtNotes.Name = "rtxtNotes"
        Me.rtxtNotes.Size = New System.Drawing.Size(486, 150)
        Me.rtxtNotes.TabIndex = 220
        Me.rtxtNotes.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtDaysCredit)
        Me.TabPage2.Controls.Add(Me.chkStatements)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(486, 150)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Terms"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(289, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Days Credit"
        '
        'txtDaysCredit
        '
        Me.txtDaysCredit.Location = New System.Drawing.Point(253, 53)
        Me.txtDaysCredit.Name = "txtDaysCredit"
        Me.txtDaysCredit.Size = New System.Drawing.Size(30, 20)
        Me.txtDaysCredit.TabIndex = 270
        '
        'chkStatements
        '
        Me.chkStatements.AutoSize = True
        Me.chkStatements.Location = New System.Drawing.Point(253, 27)
        Me.chkStatements.Name = "chkStatements"
        Me.chkStatements.Size = New System.Drawing.Size(103, 17)
        Me.chkStatements.TabIndex = 260
        Me.chkStatements.Text = "Print Statements"
        Me.chkStatements.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCredit)
        Me.GroupBox2.Controls.Add(Me.rbExchange)
        Me.GroupBox2.Controls.Add(Me.rbCash)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Type"
        '
        'rbCredit
        '
        Me.rbCredit.AutoSize = True
        Me.rbCredit.Location = New System.Drawing.Point(26, 72)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(95, 17)
        Me.rbCredit.TabIndex = 250
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "Credit Account"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'rbExchange
        '
        Me.rbExchange.AutoSize = True
        Me.rbExchange.Location = New System.Drawing.Point(25, 47)
        Me.rbExchange.Name = "rbExchange"
        Me.rbExchange.Size = New System.Drawing.Size(145, 17)
        Me.rbExchange.TabIndex = 240
        Me.rbExchange.TabStop = True
        Me.rbExchange.Text = "Game exchange account"
        Me.rbExchange.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Location = New System.Drawing.Point(25, 21)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(98, 17)
        Me.rbCash.TabIndex = 230
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash with order"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(567, 417)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 290
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(648, 417)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 300
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkMailing)
        Me.GroupBox3.Controls.Add(Me.chkVIP)
        Me.GroupBox3.Location = New System.Drawing.Point(539, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(182, 81)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'chkMailing
        '
        Me.chkMailing.AutoSize = True
        Me.chkMailing.Location = New System.Drawing.Point(28, 42)
        Me.chkMailing.Name = "chkMailing"
        Me.chkMailing.Size = New System.Drawing.Size(78, 17)
        Me.chkMailing.TabIndex = 200
        Me.chkMailing.Text = "Mailing List"
        Me.chkMailing.UseVisualStyleBackColor = True
        '
        'chkVIP
        '
        Me.chkVIP.AutoSize = True
        Me.chkVIP.Location = New System.Drawing.Point(28, 19)
        Me.chkVIP.Name = "chkVIP"
        Me.chkVIP.Size = New System.Drawing.Size(43, 17)
        Me.chkVIP.TabIndex = 190
        Me.chkVIP.Text = "VIP"
        Me.chkVIP.UseVisualStyleBackColor = True
        '
        'frmCustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 460)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerDetail"
        Me.Text = "Customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAcctNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCoName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSalutation As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_isIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents txtMobilePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSurName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents rtxtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rb_isCompany As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMemberNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDaysCredit As System.Windows.Forms.TextBox
    Friend WithEvents chkStatements As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCredit As System.Windows.Forms.RadioButton
    Friend WithEvents rbExchange As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents cbAcctType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMailing As System.Windows.Forms.CheckBox
    Friend WithEvents chkVIP As System.Windows.Forms.CheckBox
    Friend WithEvents txtDob As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnPostcodeLookup As System.Windows.Forms.Button

End Class
