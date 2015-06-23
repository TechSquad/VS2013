<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryDetail))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsItem_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtPriSku = New System.Windows.Forms.TextBox()
        Me.txtShortDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMU_5 = New System.Windows.Forms.TextBox()
        Me.txtTi_Price_5 = New System.Windows.Forms.TextBox()
        Me.txtPrice_5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbPlatform = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbAge = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMU_4 = New System.Windows.Forms.TextBox()
        Me.txtTi_Price_4 = New System.Windows.Forms.TextBox()
        Me.txtPrice_4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMU_3 = New System.Windows.Forms.TextBox()
        Me.txtMU_2 = New System.Windows.Forms.TextBox()
        Me.txtMU_1 = New System.Windows.Forms.TextBox()
        Me.txtTi_Price_3 = New System.Windows.Forms.TextBox()
        Me.txtTi_Price_2 = New System.Windows.Forms.TextBox()
        Me.txtTi_Price_1 = New System.Windows.Forms.TextBox()
        Me.txtPrice_3 = New System.Windows.Forms.TextBox()
        Me.txtPrice_2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice_1 = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLongDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCategoryId = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.cbManufacturer = New System.Windows.Forms.ComboBox()
        Me.grpSpecifications = New System.Windows.Forms.GroupBox()
        Me.rtbSpecifications = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpWebsite = New System.Windows.Forms.GroupBox()
        Me.grpOrdering = New System.Windows.Forms.GroupBox()
        Me.picItem = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpSpecifications.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 30)
        Me.Panel1.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(567, 412)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 60
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(648, 412)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsItem_id})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 438)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(737, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(152, 17)
        Me.ToolStripStatusLabel1.Text = "Inter Form Communication"
        Me.ToolStripStatusLabel1.Visible = False
        '
        'tsItem_id
        '
        Me.tsItem_id.Name = "tsItem_id"
        Me.tsItem_id.Size = New System.Drawing.Size(55, 17)
        Me.tsItem_id.Text = "tsItem_id"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtBarcode)
        Me.Panel2.Controls.Add(Me.txtPriSku)
        Me.Panel2.Controls.Add(Me.txtShortDesc)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 41)
        Me.Panel2.TabIndex = 8
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(513, 11)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(191, 20)
        Me.txtBarcode.TabIndex = 12
        '
        'txtPriSku
        '
        Me.txtPriSku.Location = New System.Drawing.Point(388, 11)
        Me.txtPriSku.Name = "txtPriSku"
        Me.txtPriSku.Size = New System.Drawing.Size(115, 20)
        Me.txtPriSku.TabIndex = 11
        '
        'txtShortDesc
        '
        Me.txtShortDesc.Location = New System.Drawing.Point(81, 11)
        Me.txtShortDesc.Name = "txtShortDesc"
        Me.txtShortDesc.Size = New System.Drawing.Size(229, 20)
        Me.txtShortDesc.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Primary SKU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 84)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(713, 322)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(705, 296)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMU_5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTi_Price_5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrice_5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbPlatform)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbAge)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMU_4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTi_Price_4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrice_4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMU_3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMU_2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMU_1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTi_Price_3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTi_Price_2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTi_Price_1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrice_3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrice_2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPrice_1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCost)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtLongDesc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCategoryId)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtWeight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblWeight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCategory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbCategory)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblManufacturer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbManufacturer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpSpecifications)
        Me.SplitContainer1.Size = New System.Drawing.Size(699, 290)
        Me.SplitContainer1.SplitterDistance = 340
        Me.SplitContainer1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 1001
        Me.Label14.Text = "Price_5"
        '
        'txtMU_5
        '
        Me.txtMU_5.Enabled = False
        Me.txtMU_5.Location = New System.Drawing.Point(234, 168)
        Me.txtMU_5.Name = "txtMU_5"
        Me.txtMU_5.Size = New System.Drawing.Size(63, 20)
        Me.txtMU_5.TabIndex = 1000
        Me.txtMU_5.TabStop = False
        '
        'txtTi_Price_5
        '
        Me.txtTi_Price_5.Enabled = False
        Me.txtTi_Price_5.Location = New System.Drawing.Point(165, 168)
        Me.txtTi_Price_5.Name = "txtTi_Price_5"
        Me.txtTi_Price_5.Size = New System.Drawing.Size(63, 20)
        Me.txtTi_Price_5.TabIndex = 1003
        '
        'txtPrice_5
        '
        Me.txtPrice_5.Location = New System.Drawing.Point(96, 168)
        Me.txtPrice_5.Name = "txtPrice_5"
        Me.txtPrice_5.Size = New System.Drawing.Size(63, 20)
        Me.txtPrice_5.TabIndex = 1002
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Platform"
        '
        'cbPlatform
        '
        Me.cbPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlatform.FormattingEnabled = True
        Me.cbPlatform.Location = New System.Drawing.Point(218, 204)
        Me.cbPlatform.Name = "cbPlatform"
        Me.cbPlatform.Size = New System.Drawing.Size(107, 21)
        Me.cbPlatform.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Age Rating"
        '
        'cbAge
        '
        Me.cbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAge.FormattingEnabled = True
        Me.cbAge.Location = New System.Drawing.Point(96, 204)
        Me.cbAge.Name = "cbAge"
        Me.cbAge.Size = New System.Drawing.Size(63, 21)
        Me.cbAge.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 999
        Me.Label11.Text = "Transaction Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Mark up %"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(176, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "with Tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Price_4"
        '
        'txtMU_4
        '
        Me.txtMU_4.Enabled = False
        Me.txtMU_4.Location = New System.Drawing.Point(234, 144)
        Me.txtMU_4.Name = "txtMU_4"
        Me.txtMU_4.Size = New System.Drawing.Size(63, 20)
        Me.txtMU_4.TabIndex = 20
        Me.txtMU_4.TabStop = False
        '
        'txtTi_Price_4
        '
        Me.txtTi_Price_4.Enabled = False
        Me.txtTi_Price_4.Location = New System.Drawing.Point(165, 144)
        Me.txtTi_Price_4.Name = "txtTi_Price_4"
        Me.txtTi_Price_4.Size = New System.Drawing.Size(63, 20)
        Me.txtTi_Price_4.TabIndex = 30
        '
        'txtPrice_4
        '
        Me.txtPrice_4.Location = New System.Drawing.Point(96, 144)
        Me.txtPrice_4.Name = "txtPrice_4"
        Me.txtPrice_4.Size = New System.Drawing.Size(63, 20)
        Me.txtPrice_4.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Price_3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Price_2"
        '
        'txtMU_3
        '
        Me.txtMU_3.Enabled = False
        Me.txtMU_3.Location = New System.Drawing.Point(234, 121)
        Me.txtMU_3.Name = "txtMU_3"
        Me.txtMU_3.Size = New System.Drawing.Size(63, 20)
        Me.txtMU_3.TabIndex = 15
        Me.txtMU_3.TabStop = False
        '
        'txtMU_2
        '
        Me.txtMU_2.Enabled = False
        Me.txtMU_2.Location = New System.Drawing.Point(234, 98)
        Me.txtMU_2.Name = "txtMU_2"
        Me.txtMU_2.Size = New System.Drawing.Size(63, 20)
        Me.txtMU_2.TabIndex = 14
        Me.txtMU_2.TabStop = False
        '
        'txtMU_1
        '
        Me.txtMU_1.Enabled = False
        Me.txtMU_1.Location = New System.Drawing.Point(234, 75)
        Me.txtMU_1.Name = "txtMU_1"
        Me.txtMU_1.Size = New System.Drawing.Size(63, 20)
        Me.txtMU_1.TabIndex = 13
        Me.txtMU_1.TabStop = False
        '
        'txtTi_Price_3
        '
        Me.txtTi_Price_3.Enabled = False
        Me.txtTi_Price_3.Location = New System.Drawing.Point(165, 121)
        Me.txtTi_Price_3.Name = "txtTi_Price_3"
        Me.txtTi_Price_3.Size = New System.Drawing.Size(63, 20)
        Me.txtTi_Price_3.TabIndex = 28
        '
        'txtTi_Price_2
        '
        Me.txtTi_Price_2.Enabled = False
        Me.txtTi_Price_2.Location = New System.Drawing.Point(165, 98)
        Me.txtTi_Price_2.Name = "txtTi_Price_2"
        Me.txtTi_Price_2.Size = New System.Drawing.Size(63, 20)
        Me.txtTi_Price_2.TabIndex = 26
        '
        'txtTi_Price_1
        '
        Me.txtTi_Price_1.Enabled = False
        Me.txtTi_Price_1.Location = New System.Drawing.Point(165, 75)
        Me.txtTi_Price_1.Name = "txtTi_Price_1"
        Me.txtTi_Price_1.Size = New System.Drawing.Size(63, 20)
        Me.txtTi_Price_1.TabIndex = 24
        '
        'txtPrice_3
        '
        Me.txtPrice_3.Location = New System.Drawing.Point(96, 121)
        Me.txtPrice_3.Name = "txtPrice_3"
        Me.txtPrice_3.Size = New System.Drawing.Size(63, 20)
        Me.txtPrice_3.TabIndex = 27
        '
        'txtPrice_2
        '
        Me.txtPrice_2.Location = New System.Drawing.Point(96, 98)
        Me.txtPrice_2.Name = "txtPrice_2"
        Me.txtPrice_2.Size = New System.Drawing.Size(63, 20)
        Me.txtPrice_2.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price_1"
        '
        'txtPrice_1
        '
        Me.txtPrice_1.Location = New System.Drawing.Point(96, 75)
        Me.txtPrice_1.Name = "txtPrice_1"
        Me.txtPrice_1.Size = New System.Drawing.Size(63, 20)
        Me.txtPrice_1.TabIndex = 23
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(96, 35)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(63, 20)
        Me.txtCost.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Order Cost"
        '
        'txtLongDesc
        '
        Me.txtLongDesc.Location = New System.Drawing.Point(96, 11)
        Me.txtLongDesc.Name = "txtLongDesc"
        Me.txtLongDesc.Size = New System.Drawing.Size(229, 20)
        Me.txtLongDesc.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Long Description"
        '
        'lblCategoryId
        '
        Me.lblCategoryId.AutoSize = True
        Me.lblCategoryId.Location = New System.Drawing.Point(73, 177)
        Me.lblCategoryId.Name = "lblCategoryId"
        Me.lblCategoryId.Size = New System.Drawing.Size(68, 13)
        Me.lblCategoryId.TabIndex = 7
        Me.lblCategoryId.Text = "lblCategoryId"
        Me.lblCategoryId.Visible = False
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(120, 204)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 6
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(18, 207)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 5
        Me.lblWeight.Text = "Weight"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(18, 177)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Category"
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(120, 174)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(226, 21)
        Me.cbCategory.TabIndex = 3
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(18, 150)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 13)
        Me.lblManufacturer.TabIndex = 2
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'cbManufacturer
        '
        Me.cbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbManufacturer.FormattingEnabled = True
        Me.cbManufacturer.Location = New System.Drawing.Point(120, 147)
        Me.cbManufacturer.Name = "cbManufacturer"
        Me.cbManufacturer.Size = New System.Drawing.Size(226, 21)
        Me.cbManufacturer.TabIndex = 1
        '
        'grpSpecifications
        '
        Me.grpSpecifications.Controls.Add(Me.rtbSpecifications)
        Me.grpSpecifications.Location = New System.Drawing.Point(3, 3)
        Me.grpSpecifications.Name = "grpSpecifications"
        Me.grpSpecifications.Size = New System.Drawing.Size(349, 134)
        Me.grpSpecifications.TabIndex = 0
        Me.grpSpecifications.TabStop = False
        Me.grpSpecifications.Text = "Specifications"
        '
        'rtbSpecifications
        '
        Me.rtbSpecifications.Location = New System.Drawing.Point(7, 20)
        Me.rtbSpecifications.Name = "rtbSpecifications"
        Me.rtbSpecifications.Size = New System.Drawing.Size(336, 95)
        Me.rtbSpecifications.TabIndex = 0
        Me.rtbSpecifications.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpWebsite)
        Me.TabPage2.Controls.Add(Me.grpOrdering)
        Me.TabPage2.Controls.Add(Me.picItem)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(705, 296)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Properties"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpWebsite
        '
        Me.grpWebsite.Location = New System.Drawing.Point(6, 147)
        Me.grpWebsite.Name = "grpWebsite"
        Me.grpWebsite.Size = New System.Drawing.Size(373, 143)
        Me.grpWebsite.TabIndex = 2
        Me.grpWebsite.TabStop = False
        Me.grpWebsite.Text = "Website Publishing"
        '
        'grpOrdering
        '
        Me.grpOrdering.Location = New System.Drawing.Point(7, 7)
        Me.grpOrdering.Name = "grpOrdering"
        Me.grpOrdering.Size = New System.Drawing.Size(373, 134)
        Me.grpOrdering.TabIndex = 1
        Me.grpOrdering.TabStop = False
        Me.grpOrdering.Text = "Automatic Ordering"
        '
        'picItem
        '
        Me.picItem.Location = New System.Drawing.Point(386, 6)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(313, 284)
        Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picItem.TabIndex = 0
        Me.picItem.TabStop = False
        '
        'frmInventoryDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 460)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventoryDetail"
        Me.Text = "Inventory Detail"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpSpecifications.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPriSku As System.Windows.Forms.TextBox
    Friend WithEvents txtShortDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbPlatform As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbAge As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMU_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTi_Price_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice_4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMU_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMU_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMU_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTi_Price_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTi_Price_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTi_Price_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice_3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice_1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLongDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMU_5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTi_Price_5 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice_5 As System.Windows.Forms.TextBox
    Friend WithEvents grpSpecifications As System.Windows.Forms.GroupBox
    Friend WithEvents rtbSpecifications As System.Windows.Forms.RichTextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents cbManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents tsItem_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCategoryId As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpWebsite As System.Windows.Forms.GroupBox
    Friend WithEvents grpOrdering As System.Windows.Forms.GroupBox
    Friend WithEvents picItem As System.Windows.Forms.PictureBox
End Class
