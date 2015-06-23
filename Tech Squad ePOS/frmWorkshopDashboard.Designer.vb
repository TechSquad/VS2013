<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkshopDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblLocate = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnPartialConvert = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvWorkshop = New System.Windows.Forms.DataGridView()
        Me.lbItemsLeft = New System.Windows.Forms.ListBox()
        Me.btnItemsLeft = New System.Windows.Forms.Button()
        Me.lblItemsLeft = New System.Windows.Forms.Label()
        Me.btnSetStatus = New System.Windows.Forms.Button()
        Me.dgvNotes = New System.Windows.Forms.DataGridView()
        Me.btnMoveLocation = New System.Windows.Forms.Button()
        Me.btnDeleteNote = New System.Windows.Forms.Button()
        Me.btnEditNote = New System.Windows.Forms.Button()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.txtItemLeft = New System.Windows.Forms.TextBox()
        Me.lblAddItemLeft = New System.Windows.Forms.Label()
        Me.cbItem = New System.Windows.Forms.ComboBox()
        Me.lblItemList = New System.Windows.Forms.Label()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lblCustomerLink = New System.Windows.Forms.Label()
        Me.grpContact = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtWork = New System.Windows.Forms.TextBox()
        Me.txtHome = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblWork = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        CType(Me.dgvWorkshop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpContact.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLocate
        '
        Me.lblLocate.AutoSize = True
        Me.lblLocate.Location = New System.Drawing.Point(221, 25)
        Me.lblLocate.Name = "lblLocate"
        Me.lblLocate.Size = New System.Drawing.Size(40, 13)
        Me.lblLocate.TabIndex = 0
        Me.lblLocate.Text = "Locate"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(267, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(717, 12)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(114, 39)
        Me.btnPayment.TabIndex = 2
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnPartialConvert
        '
        Me.btnPartialConvert.Location = New System.Drawing.Point(837, 12)
        Me.btnPartialConvert.Name = "btnPartialConvert"
        Me.btnPartialConvert.Size = New System.Drawing.Size(114, 39)
        Me.btnPartialConvert.TabIndex = 3
        Me.btnPartialConvert.Text = "Partial Convert"
        Me.btnPartialConvert.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(957, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 39)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(1077, 12)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(114, 39)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1197, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvWorkshop
        '
        Me.dgvWorkshop.AllowUserToAddRows = False
        Me.dgvWorkshop.AllowUserToDeleteRows = False
        Me.dgvWorkshop.AllowUserToResizeColumns = False
        Me.dgvWorkshop.AllowUserToResizeRows = False
        Me.dgvWorkshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkshop.Location = New System.Drawing.Point(199, 66)
        Me.dgvWorkshop.MultiSelect = False
        Me.dgvWorkshop.Name = "dgvWorkshop"
        Me.dgvWorkshop.ReadOnly = True
        Me.dgvWorkshop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWorkshop.Size = New System.Drawing.Size(1112, 131)
        Me.dgvWorkshop.TabIndex = 7
        '
        'lbItemsLeft
        '
        Me.lbItemsLeft.FormattingEnabled = True
        Me.lbItemsLeft.Location = New System.Drawing.Point(256, 209)
        Me.lbItemsLeft.Name = "lbItemsLeft"
        Me.lbItemsLeft.Size = New System.Drawing.Size(218, 69)
        Me.lbItemsLeft.TabIndex = 8
        '
        'btnItemsLeft
        '
        Me.btnItemsLeft.Location = New System.Drawing.Point(480, 209)
        Me.btnItemsLeft.Name = "btnItemsLeft"
        Me.btnItemsLeft.Size = New System.Drawing.Size(63, 69)
        Me.btnItemsLeft.TabIndex = 9
        Me.btnItemsLeft.Text = "Add Item"
        Me.btnItemsLeft.UseVisualStyleBackColor = True
        '
        'lblItemsLeft
        '
        Me.lblItemsLeft.AutoSize = True
        Me.lblItemsLeft.Location = New System.Drawing.Point(197, 209)
        Me.lblItemsLeft.Name = "lblItemsLeft"
        Me.lblItemsLeft.Size = New System.Drawing.Size(53, 13)
        Me.lblItemsLeft.TabIndex = 10
        Me.lblItemsLeft.Text = "Items Left"
        '
        'btnSetStatus
        '
        Me.btnSetStatus.Location = New System.Drawing.Point(957, 210)
        Me.btnSetStatus.Name = "btnSetStatus"
        Me.btnSetStatus.Size = New System.Drawing.Size(182, 39)
        Me.btnSetStatus.TabIndex = 11
        Me.btnSetStatus.Text = "Set Status"
        Me.btnSetStatus.UseVisualStyleBackColor = True
        '
        'dgvNotes
        '
        Me.dgvNotes.AllowUserToAddRows = False
        Me.dgvNotes.AllowUserToDeleteRows = False
        Me.dgvNotes.AllowUserToResizeColumns = False
        Me.dgvNotes.AllowUserToResizeRows = False
        Me.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvNotes.Location = New System.Drawing.Point(199, 295)
        Me.dgvNotes.MultiSelect = False
        Me.dgvNotes.Name = "dgvNotes"
        Me.dgvNotes.ReadOnly = True
        Me.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotes.Size = New System.Drawing.Size(1112, 219)
        Me.dgvNotes.TabIndex = 12
        '
        'btnMoveLocation
        '
        Me.btnMoveLocation.Location = New System.Drawing.Point(1155, 210)
        Me.btnMoveLocation.Name = "btnMoveLocation"
        Me.btnMoveLocation.Size = New System.Drawing.Size(156, 39)
        Me.btnMoveLocation.TabIndex = 13
        Me.btnMoveLocation.Text = "Change Location"
        Me.btnMoveLocation.UseVisualStyleBackColor = True
        '
        'btnDeleteNote
        '
        Me.btnDeleteNote.Location = New System.Drawing.Point(1197, 527)
        Me.btnDeleteNote.Name = "btnDeleteNote"
        Me.btnDeleteNote.Size = New System.Drawing.Size(114, 39)
        Me.btnDeleteNote.TabIndex = 14
        Me.btnDeleteNote.Text = "Delete Note"
        Me.btnDeleteNote.UseVisualStyleBackColor = True
        '
        'btnEditNote
        '
        Me.btnEditNote.Location = New System.Drawing.Point(1077, 527)
        Me.btnEditNote.Name = "btnEditNote"
        Me.btnEditNote.Size = New System.Drawing.Size(114, 39)
        Me.btnEditNote.TabIndex = 15
        Me.btnEditNote.Text = "Edit Note"
        Me.btnEditNote.UseVisualStyleBackColor = True
        '
        'btnAddNote
        '
        Me.btnAddNote.Location = New System.Drawing.Point(957, 527)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(114, 39)
        Me.btnAddNote.TabIndex = 16
        Me.btnAddNote.Text = "Add Note"
        Me.btnAddNote.UseVisualStyleBackColor = True
        '
        'txtItemLeft
        '
        Me.txtItemLeft.Location = New System.Drawing.Point(723, 228)
        Me.txtItemLeft.Name = "txtItemLeft"
        Me.txtItemLeft.Size = New System.Drawing.Size(204, 20)
        Me.txtItemLeft.TabIndex = 17
        '
        'lblAddItemLeft
        '
        Me.lblAddItemLeft.AutoSize = True
        Me.lblAddItemLeft.Location = New System.Drawing.Point(723, 209)
        Me.lblAddItemLeft.Name = "lblAddItemLeft"
        Me.lblAddItemLeft.Size = New System.Drawing.Size(81, 13)
        Me.lblAddItemLeft.TabIndex = 18
        Me.lblAddItemLeft.Text = "Item description"
        '
        'cbItem
        '
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(562, 227)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(155, 21)
        Me.cbItem.TabIndex = 19
        '
        'lblItemList
        '
        Me.lblItemList.AutoSize = True
        Me.lblItemList.Location = New System.Drawing.Point(559, 209)
        Me.lblItemList.Name = "lblItemList"
        Me.lblItemList.Size = New System.Drawing.Size(81, 13)
        Me.lblItemList.TabIndex = 20
        Me.lblItemList.Text = "Item description"
        '
        'cbLocation
        '
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Location = New System.Drawing.Point(1155, 255)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(156, 21)
        Me.cbLocation.TabIndex = 21
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(958, 255)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(181, 21)
        Me.cbStatus.TabIndex = 22
        '
        'lblCustomerLink
        '
        Me.lblCustomerLink.AutoSize = True
        Me.lblCustomerLink.Location = New System.Drawing.Point(26, 66)
        Me.lblCustomerLink.Name = "lblCustomerLink"
        Me.lblCustomerLink.Size = New System.Drawing.Size(86, 13)
        Me.lblCustomerLink.TabIndex = 23
        Me.lblCustomerLink.Text = "Customer Details"
        '
        'grpContact
        '
        Me.grpContact.Controls.Add(Me.txtEmail)
        Me.grpContact.Controls.Add(Me.txtFax)
        Me.grpContact.Controls.Add(Me.txtMobile)
        Me.grpContact.Controls.Add(Me.txtWork)
        Me.grpContact.Controls.Add(Me.txtHome)
        Me.grpContact.Controls.Add(Me.lblEmail)
        Me.grpContact.Controls.Add(Me.lblFax)
        Me.grpContact.Controls.Add(Me.lblMobile)
        Me.grpContact.Controls.Add(Me.lblWork)
        Me.grpContact.Controls.Add(Me.lblHome)
        Me.grpContact.Location = New System.Drawing.Point(12, 248)
        Me.grpContact.Name = "grpContact"
        Me.grpContact.Size = New System.Drawing.Size(178, 209)
        Me.grpContact.TabIndex = 24
        Me.grpContact.TabStop = False
        Me.grpContact.Text = "Contact Info"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(6, 173)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(161, 13)
        Me.txtEmail.TabIndex = 9
        '
        'txtFax
        '
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFax.Enabled = False
        Me.txtFax.Location = New System.Drawing.Point(53, 118)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(114, 13)
        Me.txtFax.TabIndex = 8
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMobile.Enabled = False
        Me.txtMobile.Location = New System.Drawing.Point(53, 89)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(114, 13)
        Me.txtMobile.TabIndex = 7
        '
        'txtWork
        '
        Me.txtWork.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWork.Enabled = False
        Me.txtWork.Location = New System.Drawing.Point(53, 57)
        Me.txtWork.Name = "txtWork"
        Me.txtWork.Size = New System.Drawing.Size(114, 13)
        Me.txtWork.TabIndex = 6
        '
        'txtHome
        '
        Me.txtHome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHome.Enabled = False
        Me.txtHome.Location = New System.Drawing.Point(53, 27)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.Size = New System.Drawing.Size(114, 13)
        Me.txtHome.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 157)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "eMail:"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(6, 118)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 3
        Me.lblFax.Text = "Fax:"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(6, 89)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 2
        Me.lblMobile.Text = "Mobile"
        '
        'lblWork
        '
        Me.lblWork.AutoSize = True
        Me.lblWork.Location = New System.Drawing.Point(6, 60)
        Me.lblWork.Name = "lblWork"
        Me.lblWork.Size = New System.Drawing.Size(36, 13)
        Me.lblWork.TabIndex = 1
        Me.lblWork.Text = "Work:"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Location = New System.Drawing.Point(6, 29)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(38, 13)
        Me.lblHome.TabIndex = 0
        Me.lblHome.Text = "Home:"
        '
        'frmWorkshopDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 578)
        Me.Controls.Add(Me.grpContact)
        Me.Controls.Add(Me.lblCustomerLink)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbLocation)
        Me.Controls.Add(Me.lblItemList)
        Me.Controls.Add(Me.cbItem)
        Me.Controls.Add(Me.lblAddItemLeft)
        Me.Controls.Add(Me.txtItemLeft)
        Me.Controls.Add(Me.btnAddNote)
        Me.Controls.Add(Me.btnEditNote)
        Me.Controls.Add(Me.btnDeleteNote)
        Me.Controls.Add(Me.btnMoveLocation)
        Me.Controls.Add(Me.dgvNotes)
        Me.Controls.Add(Me.btnSetStatus)
        Me.Controls.Add(Me.lblItemsLeft)
        Me.Controls.Add(Me.btnItemsLeft)
        Me.Controls.Add(Me.lbItemsLeft)
        Me.Controls.Add(Me.dgvWorkshop)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPartialConvert)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblLocate)
        Me.Name = "frmWorkshopDashboard"
        Me.Text = "Workshop Dashboard"
        CType(Me.dgvWorkshop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpContact.ResumeLayout(False)
        Me.grpContact.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLocate As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents btnPartialConvert As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgvWorkshop As System.Windows.Forms.DataGridView
    Friend WithEvents lbItemsLeft As System.Windows.Forms.ListBox
    Friend WithEvents btnItemsLeft As System.Windows.Forms.Button
    Friend WithEvents lblItemsLeft As System.Windows.Forms.Label
    Friend WithEvents btnSetStatus As System.Windows.Forms.Button
    Friend WithEvents dgvNotes As System.Windows.Forms.DataGridView
    Friend WithEvents btnMoveLocation As System.Windows.Forms.Button
    Friend WithEvents btnDeleteNote As System.Windows.Forms.Button
    Friend WithEvents btnEditNote As System.Windows.Forms.Button
    Friend WithEvents btnAddNote As System.Windows.Forms.Button
    Friend WithEvents txtItemLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblAddItemLeft As System.Windows.Forms.Label
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblItemList As System.Windows.Forms.Label
    Friend WithEvents cbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomerLink As System.Windows.Forms.Label
    Friend WithEvents grpContact As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtWork As System.Windows.Forms.TextBox
    Friend WithEvents txtHome As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblWork As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label
End Class
