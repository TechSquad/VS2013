<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupportDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupportDashboard))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbAddTicket = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pbViewSupportCustomers = New System.Windows.Forms.PictureBox()
        Me.pbTicketInfo = New System.Windows.Forms.PictureBox()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSolvedTickets = New System.Windows.Forms.Button()
        Me.buttonBadTickets = New System.Windows.Forms.Button()
        Me.btnGoodTickets = New System.Windows.Forms.Button()
        Me.btnGroupTickets = New System.Windows.Forms.Button()
        Me.btnYourTickets = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.cbPriority = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.cbAssignee = New System.Windows.Forms.ComboBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.cbSaveAs = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rtxtNote = New System.Windows.Forms.RichTextBox()
        Me.pbRemoteSupport = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlAddTicket1 = New System.Windows.Forms.Panel()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblAsignee = New System.Windows.Forms.Label()
        Me.lblRequester = New System.Windows.Forms.Label()
        Me.pnlAddTicket2 = New System.Windows.Forms.Panel()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.TextBox_my_1 = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        CType(Me.pbAddTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbViewSupportCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTicketInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRemoteSupport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlAddTicket1.SuspendLayout()
        Me.pnlAddTicket2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbAddTicket
        '
        Me.pbAddTicket.ErrorImage = Nothing
        Me.pbAddTicket.Image = CType(resources.GetObject("pbAddTicket.Image"), System.Drawing.Image)
        Me.pbAddTicket.Location = New System.Drawing.Point(12, 167)
        Me.pbAddTicket.Name = "pbAddTicket"
        Me.pbAddTicket.Size = New System.Drawing.Size(33, 36)
        Me.pbAddTicket.TabIndex = 4
        Me.pbAddTicket.TabStop = False
        Me.ToolTip.SetToolTip(Me.pbAddTicket, "Start New Ticket")
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = CType(resources.GetObject("PictureBox4.ErrorImage"), System.Drawing.Image)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 221)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox4, "To be assigned later")
        '
        'pbViewSupportCustomers
        '
        Me.pbViewSupportCustomers.ErrorImage = Nothing
        Me.pbViewSupportCustomers.Image = CType(resources.GetObject("pbViewSupportCustomers.Image"), System.Drawing.Image)
        Me.pbViewSupportCustomers.Location = New System.Drawing.Point(12, 116)
        Me.pbViewSupportCustomers.Name = "pbViewSupportCustomers"
        Me.pbViewSupportCustomers.Size = New System.Drawing.Size(33, 35)
        Me.pbViewSupportCustomers.TabIndex = 2
        Me.pbViewSupportCustomers.TabStop = False
        Me.ToolTip.SetToolTip(Me.pbViewSupportCustomers, "View all support only customers")
        '
        'pbTicketInfo
        '
        Me.pbTicketInfo.ErrorImage = Nothing
        Me.pbTicketInfo.Image = CType(resources.GetObject("pbTicketInfo.Image"), System.Drawing.Image)
        Me.pbTicketInfo.Location = New System.Drawing.Point(12, 64)
        Me.pbTicketInfo.Name = "pbTicketInfo"
        Me.pbTicketInfo.Size = New System.Drawing.Size(33, 36)
        Me.pbTicketInfo.TabIndex = 1
        Me.pbTicketInfo.TabStop = False
        Me.ToolTip.SetToolTip(Me.pbTicketInfo, "Display information on tickets")
        '
        'pbHome
        '
        Me.pbHome.ErrorImage = CType(resources.GetObject("pbHome.ErrorImage"), System.Drawing.Image)
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(12, 13)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(33, 36)
        Me.pbHome.TabIndex = 0
        Me.pbHome.TabStop = False
        Me.ToolTip.SetToolTip(Me.pbHome, "Reset view")
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CausesValidation = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(3, 196)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(926, 358)
        Me.DataGridView1.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.DataGridView1, "Click to Select and Double Click to Add Note")
        '
        'btnSolvedTickets
        '
        Me.btnSolvedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSolvedTickets.Location = New System.Drawing.Point(332, 50)
        Me.btnSolvedTickets.Name = "btnSolvedTickets"
        Me.btnSolvedTickets.Size = New System.Drawing.Size(75, 50)
        Me.btnSolvedTickets.TabIndex = 5
        Me.btnSolvedTickets.Text = "Button5"
        Me.ToolTip.SetToolTip(Me.btnSolvedTickets, "All Solved Tickets")
        Me.btnSolvedTickets.UseVisualStyleBackColor = True
        '
        'buttonBadTickets
        '
        Me.buttonBadTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonBadTickets.Location = New System.Drawing.Point(258, 50)
        Me.buttonBadTickets.Name = "buttonBadTickets"
        Me.buttonBadTickets.Size = New System.Drawing.Size(75, 50)
        Me.buttonBadTickets.TabIndex = 4
        Me.buttonBadTickets.Text = "Button4"
        Me.ToolTip.SetToolTip(Me.buttonBadTickets, "All Tickets Rated as Bad by Customers")
        Me.buttonBadTickets.UseVisualStyleBackColor = True
        '
        'btnGoodTickets
        '
        Me.btnGoodTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoodTickets.Location = New System.Drawing.Point(186, 50)
        Me.btnGoodTickets.Name = "btnGoodTickets"
        Me.btnGoodTickets.Size = New System.Drawing.Size(75, 50)
        Me.btnGoodTickets.TabIndex = 3
        Me.btnGoodTickets.Text = "Button3"
        Me.ToolTip.SetToolTip(Me.btnGoodTickets, "All Tickets Rated as Good by Customers")
        Me.btnGoodTickets.UseVisualStyleBackColor = True
        '
        'btnGroupTickets
        '
        Me.btnGroupTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGroupTickets.Location = New System.Drawing.Point(93, 50)
        Me.btnGroupTickets.Name = "btnGroupTickets"
        Me.btnGroupTickets.Size = New System.Drawing.Size(75, 50)
        Me.btnGroupTickets.TabIndex = 2
        Me.btnGroupTickets.Text = "Button2"
        Me.ToolTip.SetToolTip(Me.btnGroupTickets, "Your Groups Open Tickets")
        Me.btnGroupTickets.UseVisualStyleBackColor = True
        '
        'btnYourTickets
        '
        Me.btnYourTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnYourTickets.Location = New System.Drawing.Point(19, 50)
        Me.btnYourTickets.Name = "btnYourTickets"
        Me.btnYourTickets.Size = New System.Drawing.Size(75, 50)
        Me.btnYourTickets.TabIndex = 0
        Me.btnYourTickets.Text = "      0      YOU"
        Me.ToolTip.SetToolTip(Me.btnYourTickets, "Your Open Tickets")
        Me.btnYourTickets.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 227)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(204, 271)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        Me.ToolTip.SetToolTip(Me.RichTextBox1, "Tags (please seperate with a comma)")
        '
        'cbPriority
        '
        Me.cbPriority.FormattingEnabled = True
        Me.cbPriority.Location = New System.Drawing.Point(143, 160)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(78, 21)
        Me.cbPriority.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.cbPriority, "Priority of Ticket")
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(20, 160)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(78, 21)
        Me.cbType.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.cbType, "Type of Ticket")
        '
        'cbAssignee
        '
        Me.cbAssignee.FormattingEnabled = True
        Me.cbAssignee.Location = New System.Drawing.Point(20, 78)
        Me.cbAssignee.Name = "cbAssignee"
        Me.cbAssignee.Size = New System.Drawing.Size(201, 21)
        Me.cbAssignee.TabIndex = 3
        Me.cbAssignee.Text = "Roger Whitfield"
        Me.ToolTip.SetToolTip(Me.cbAssignee, "Tech Assigned To")
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(46, 28)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(175, 20)
        Me.txtCustomer.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.txtCustomer, "Customers Name")
        '
        'cbSaveAs
        '
        Me.cbSaveAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSaveAs.ForeColor = System.Drawing.Color.Blue
        Me.cbSaveAs.FormattingEnabled = True
        Me.cbSaveAs.Items.AddRange(New Object() {"Submit as Open", "Submit as Pending", "Submit as Solved"})
        Me.cbSaveAs.Location = New System.Drawing.Point(592, 341)
        Me.cbSaveAs.Name = "cbSaveAs"
        Me.cbSaveAs.Size = New System.Drawing.Size(207, 23)
        Me.cbSaveAs.TabIndex = 20
        Me.cbSaveAs.Text = "Submit as Open"
        Me.ToolTip.SetToolTip(Me.cbSaveAs, "Select Status")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(592, 370)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(207, 59)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Submit as Open"
        Me.ToolTip.SetToolTip(Me.btnSave, "Submit Note/Ticket")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.Location = New System.Drawing.Point(724, 308)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(75, 23)
        Me.btnAttach.TabIndex = 16
        Me.btnAttach.Text = "Attach File"
        Me.ToolTip.SetToolTip(Me.btnAttach, "Attach external file to Note")
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'rtxtDescription
        '
        Me.rtxtDescription.Location = New System.Drawing.Point(45, 97)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.Size = New System.Drawing.Size(754, 82)
        Me.rtxtDescription.TabIndex = 15
        Me.rtxtDescription.Text = ""
        Me.ToolTip.SetToolTip(Me.rtxtDescription, "Customers problem description")
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(42, 53)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(757, 20)
        Me.txtSubject.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.txtSubject, "Customers Problem Subject")
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(592, 435)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(207, 59)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel and Exit"
        Me.ToolTip.SetToolTip(Me.btnCancel, "Exit")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rtxtNote
        '
        Me.rtxtNote.Location = New System.Drawing.Point(45, 201)
        Me.rtxtNote.Name = "rtxtNote"
        Me.rtxtNote.Size = New System.Drawing.Size(754, 101)
        Me.rtxtNote.TabIndex = 22
        Me.rtxtNote.Text = ""
        Me.ToolTip.SetToolTip(Me.rtxtNote, "Your comments ge in here")
        '
        'pbRemoteSupport
        '
        Me.pbRemoteSupport.ErrorImage = CType(resources.GetObject("pbRemoteSupport.ErrorImage"), System.Drawing.Image)
        Me.pbRemoteSupport.Image = CType(resources.GetObject("pbRemoteSupport.Image"), System.Drawing.Image)
        Me.pbRemoteSupport.Location = New System.Drawing.Point(4, 504)
        Me.pbRemoteSupport.Name = "pbRemoteSupport"
        Me.pbRemoteSupport.Size = New System.Drawing.Size(52, 52)
        Me.pbRemoteSupport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRemoteSupport.TabIndex = 5
        Me.pbRemoteSupport.TabStop = False
        Me.ToolTip.SetToolTip(Me.pbRemoteSupport, "Launch Remote Support")
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(61, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 560)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnConvert)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnSolvedTickets)
        Me.Panel2.Controls.Add(Me.buttonBadTickets)
        Me.Panel2.Controls.Add(Me.btnGoodTickets)
        Me.Panel2.Controls.Add(Me.btnGroupTickets)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnYourTickets)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(332, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(941, 560)
        Me.Panel2.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(633, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Group"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(490, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Updated"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Requested"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Open Tickets (current)"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(941, 560)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 722
        Me.LineShape3.Y1 = 192
        Me.LineShape3.Y2 = 192
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 722
        Me.LineShape2.Y1 = 161
        Me.LineShape2.Y2 = 161
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 723
        Me.LineShape1.Y1 = 125
        Me.LineShape1.Y2 = 125
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pbRemoteSupport)
        Me.Panel3.Controls.Add(Me.pbAddTicket)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.pbViewSupportCustomers)
        Me.Panel3.Controls.Add(Me.pbTicketInfo)
        Me.Panel3.Controls.Add(Me.pbHome)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(60, 560)
        Me.Panel3.TabIndex = 11
        '
        'pnlAddTicket1
        '
        Me.pnlAddTicket1.AutoScroll = True
        Me.pnlAddTicket1.Controls.Add(Me.txtCustID)
        Me.pnlAddTicket1.Controls.Add(Me.RichTextBox1)
        Me.pnlAddTicket1.Controls.Add(Me.lblTags)
        Me.pnlAddTicket1.Controls.Add(Me.cbPriority)
        Me.pnlAddTicket1.Controls.Add(Me.cbType)
        Me.pnlAddTicket1.Controls.Add(Me.lblPriority)
        Me.pnlAddTicket1.Controls.Add(Me.lblType)
        Me.pnlAddTicket1.Controls.Add(Me.cbAssignee)
        Me.pnlAddTicket1.Controls.Add(Me.lblAsignee)
        Me.pnlAddTicket1.Controls.Add(Me.txtCustomer)
        Me.pnlAddTicket1.Controls.Add(Me.lblRequester)
        Me.pnlAddTicket1.Location = New System.Drawing.Point(1246, 13)
        Me.pnlAddTicket1.Name = "pnlAddTicket1"
        Me.pnlAddTicket1.Size = New System.Drawing.Size(246, 541)
        Me.pnlAddTicket1.TabIndex = 10
        Me.pnlAddTicket1.Visible = False
        '
        'txtCustID
        '
        Me.txtCustID.BackColor = System.Drawing.SystemColors.Menu
        Me.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustID.Enabled = False
        Me.txtCustID.Location = New System.Drawing.Point(19, 31)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(23, 13)
        Me.txtCustID.TabIndex = 10
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Location = New System.Drawing.Point(17, 197)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(31, 13)
        Me.lblTags.TabIndex = 8
        Me.lblTags.Text = "Tags"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(150, 125)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(38, 13)
        Me.lblPriority.TabIndex = 5
        Me.lblPriority.Text = "Priority"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(17, 125)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Type"
        '
        'lblAsignee
        '
        Me.lblAsignee.AutoSize = True
        Me.lblAsignee.Location = New System.Drawing.Point(17, 61)
        Me.lblAsignee.Name = "lblAsignee"
        Me.lblAsignee.Size = New System.Drawing.Size(50, 13)
        Me.lblAsignee.TabIndex = 2
        Me.lblAsignee.Text = "Assignee"
        '
        'lblRequester
        '
        Me.lblRequester.AutoSize = True
        Me.lblRequester.Location = New System.Drawing.Point(14, 11)
        Me.lblRequester.Name = "lblRequester"
        Me.lblRequester.Size = New System.Drawing.Size(56, 13)
        Me.lblRequester.TabIndex = 0
        Me.lblRequester.Text = "Requester"
        '
        'pnlAddTicket2
        '
        Me.pnlAddTicket2.AllowDrop = True
        Me.pnlAddTicket2.Controls.Add(Me.lblNote)
        Me.pnlAddTicket2.Controls.Add(Me.rtxtNote)
        Me.pnlAddTicket2.Controls.Add(Me.btnCancel)
        Me.pnlAddTicket2.Controls.Add(Me.cbSaveAs)
        Me.pnlAddTicket2.Controls.Add(Me.btnSave)
        Me.pnlAddTicket2.Controls.Add(Me.btnAttach)
        Me.pnlAddTicket2.Controls.Add(Me.rtxtDescription)
        Me.pnlAddTicket2.Controls.Add(Me.lblDescription)
        Me.pnlAddTicket2.Controls.Add(Me.txtSubject)
        Me.pnlAddTicket2.Controls.Add(Me.lblSubject)
        Me.pnlAddTicket2.Location = New System.Drawing.Point(1222, 352)
        Me.pnlAddTicket2.Name = "pnlAddTicket2"
        Me.pnlAddTicket2.Size = New System.Drawing.Size(876, 500)
        Me.pnlAddTicket2.TabIndex = 17
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(42, 185)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(55, 13)
        Me.lblNote.TabIndex = 23
        Me.lblNote.Text = "Your Note"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(42, 80)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 14
        Me.lblDescription.Text = "Description"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(39, 24)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 12
        Me.lblSubject.Text = "Subject"
        '
        'TextBox_my_1
        '
        Me.TextBox_my_1.Location = New System.Drawing.Point(309, 537)
        Me.TextBox_my_1.Multiline = True
        Me.TextBox_my_1.Name = "TextBox_my_1"
        Me.TextBox_my_1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox_my_1.TabIndex = 0
        Me.TextBox_my_1.Text = "Used to measure text"
        Me.TextBox_my_1.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(739, 47)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(123, 44)
        Me.btnConvert.TabIndex = 16
        Me.btnConvert.Text = "Convert to Workshop"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'frmSupportDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 562)
        Me.Controls.Add(Me.TextBox_my_1)
        Me.Controls.Add(Me.pnlAddTicket1)
        Me.Controls.Add(Me.pnlAddTicket2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSupportDashboard"
        Me.Text = "Support Dashboard"
        CType(Me.pbAddTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbViewSupportCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTicketInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRemoteSupport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlAddTicket1.ResumeLayout(False)
        Me.pnlAddTicket1.PerformLayout()
        Me.pnlAddTicket2.ResumeLayout(False)
        Me.pnlAddTicket2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSolvedTickets As System.Windows.Forms.Button
    Friend WithEvents buttonBadTickets As System.Windows.Forms.Button
    Friend WithEvents btnGoodTickets As System.Windows.Forms.Button
    Friend WithEvents btnGroupTickets As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnYourTickets As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pbAddTicket As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbViewSupportCustomers As System.Windows.Forms.PictureBox
    Friend WithEvents pbTicketInfo As System.Windows.Forms.PictureBox
    Friend WithEvents pbHome As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnlAddTicket1 As System.Windows.Forms.Panel
    Friend WithEvents lblTags As System.Windows.Forms.Label
    Friend WithEvents cbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cbAssignee As System.Windows.Forms.ComboBox
    Friend WithEvents lblAsignee As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblRequester As System.Windows.Forms.Label
    Friend WithEvents pnlAddTicket2 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents btnAttach As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents cbSaveAs As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents rtxtNote As System.Windows.Forms.RichTextBox
    Friend WithEvents pbRemoteSupport As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_my_1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
