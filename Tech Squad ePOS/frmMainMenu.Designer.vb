<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSystemSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmStationSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLoggedIn = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnManagement = New System.Windows.Forms.Button()
        Me.btnAccounting = New System.Windows.Forms.Button()
        Me.btnPurchasing = New System.Windows.Forms.Button()
        Me.btnEcommerce = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnService = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1405, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSystemSetup, Me.tsmStationSetup, Me.ToolStripSeparator3, Me.tsmExit})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'tsmSystemSetup
        '
        Me.tsmSystemSetup.Image = CType(resources.GetObject("tsmSystemSetup.Image"), System.Drawing.Image)
        Me.tsmSystemSetup.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsmSystemSetup.Name = "tsmSystemSetup"
        Me.tsmSystemSetup.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmSystemSetup.Size = New System.Drawing.Size(188, 22)
        Me.tsmSystemSetup.Text = "System Setup"
        '
        'tsmStationSetup
        '
        Me.tsmStationSetup.Image = CType(resources.GetObject("tsmStationSetup.Image"), System.Drawing.Image)
        Me.tsmStationSetup.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsmStationSetup.Name = "tsmStationSetup"
        Me.tsmStationSetup.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmStationSetup.Size = New System.Drawing.Size(188, 22)
        Me.tsmStationSetup.Text = "Station Setup"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(188, 22)
        Me.tsmExit.Text = "E&xit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripSeparator7})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(39, 20)
        Me.EditMenu.Text = "&Edit"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(57, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(57, 6)
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(48, 20)
        Me.ToolsMenu.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1, Me.tslUser, Me.ToolStripStatusLabel2, Me.tslLoggedIn})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 565)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1405, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "User Name: "
        '
        'tslUser
        '
        Me.tslUser.Name = "tslUser"
        Me.tslUser.Size = New System.Drawing.Size(65, 17)
        Me.tslUser.Text = "User Name"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel2.Text = "Logged In: "
        '
        'tslLoggedIn
        '
        Me.tslLoggedIn.Name = "tslLoggedIn"
        Me.tslLoggedIn.Size = New System.Drawing.Size(60, 17)
        Me.tslLoggedIn.Text = "Logged In"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnMaintenance)
        Me.Panel1.Controls.Add(Me.btnManagement)
        Me.Panel1.Controls.Add(Me.btnAccounting)
        Me.Panel1.Controls.Add(Me.btnPurchasing)
        Me.Panel1.Controls.Add(Me.btnEcommerce)
        Me.Panel1.Controls.Add(Me.btnPayments)
        Me.Panel1.Controls.Add(Me.btnInventory)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.btnService)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.btnSale)
        Me.Panel1.Controls.Add(Me.btnCustomers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1405, 68)
        Me.Panel1.TabIndex = 9
        '
        'btnLogin
        '
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogin.Location = New System.Drawing.Point(1164, 0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(97, 68)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), System.Drawing.Image)
        Me.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMaintenance.Location = New System.Drawing.Point(1067, 0)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(97, 68)
        Me.btnMaintenance.TabIndex = 11
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnManagement
        '
        Me.btnManagement.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagement.Image = CType(resources.GetObject("btnManagement.Image"), System.Drawing.Image)
        Me.btnManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnManagement.Location = New System.Drawing.Point(970, 0)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(97, 68)
        Me.btnManagement.TabIndex = 10
        Me.btnManagement.Text = "Management"
        Me.btnManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManagement.UseVisualStyleBackColor = True
        '
        'btnAccounting
        '
        Me.btnAccounting.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAccounting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounting.Image = CType(resources.GetObject("btnAccounting.Image"), System.Drawing.Image)
        Me.btnAccounting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAccounting.Location = New System.Drawing.Point(873, 0)
        Me.btnAccounting.Name = "btnAccounting"
        Me.btnAccounting.Size = New System.Drawing.Size(97, 68)
        Me.btnAccounting.TabIndex = 9
        Me.btnAccounting.Text = "Test Form"
        Me.btnAccounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAccounting.UseVisualStyleBackColor = True
        '
        'btnPurchasing
        '
        Me.btnPurchasing.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPurchasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchasing.Image = CType(resources.GetObject("btnPurchasing.Image"), System.Drawing.Image)
        Me.btnPurchasing.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPurchasing.Location = New System.Drawing.Point(776, 0)
        Me.btnPurchasing.Name = "btnPurchasing"
        Me.btnPurchasing.Size = New System.Drawing.Size(97, 68)
        Me.btnPurchasing.TabIndex = 8
        Me.btnPurchasing.Text = "Purchasing"
        Me.btnPurchasing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPurchasing.UseVisualStyleBackColor = True
        '
        'btnEcommerce
        '
        Me.btnEcommerce.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEcommerce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEcommerce.Image = CType(resources.GetObject("btnEcommerce.Image"), System.Drawing.Image)
        Me.btnEcommerce.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEcommerce.Location = New System.Drawing.Point(679, 0)
        Me.btnEcommerce.Name = "btnEcommerce"
        Me.btnEcommerce.Size = New System.Drawing.Size(97, 68)
        Me.btnEcommerce.TabIndex = 7
        Me.btnEcommerce.Text = "e-commerce"
        Me.btnEcommerce.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEcommerce.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayments.Image = CType(resources.GetObject("btnPayments.Image"), System.Drawing.Image)
        Me.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPayments.Location = New System.Drawing.Point(582, 0)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(97, 68)
        Me.btnPayments.TabIndex = 6
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInventory.Location = New System.Drawing.Point(485, 0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(97, 68)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Image = CType(resources.GetObject("btnRegister.Image"), System.Drawing.Image)
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegister.Location = New System.Drawing.Point(388, 0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(97, 68)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnService
        '
        Me.btnService.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnService.Image = CType(resources.GetObject("btnService.Image"), System.Drawing.Image)
        Me.btnService.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnService.Location = New System.Drawing.Point(291, 0)
        Me.btnService.Name = "btnService"
        Me.btnService.Size = New System.Drawing.Size(97, 68)
        Me.btnService.TabIndex = 3
        Me.btnService.Text = "Support"
        Me.btnService.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnService.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Image = CType(resources.GetObject("btnReturn.Image"), System.Drawing.Image)
        Me.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReturn.Location = New System.Drawing.Point(194, 0)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(97, 68)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSale
        '
        Me.btnSale.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSale.Image = CType(resources.GetObject("btnSale.Image"), System.Drawing.Image)
        Me.btnSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSale.Location = New System.Drawing.Point(97, 0)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(97, 68)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "Sale"
        Me.btnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.Image = CType(resources.GetObject("btnCustomers.Image"), System.Drawing.Image)
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCustomers.Location = New System.Drawing.Point(0, 0)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(97, 68)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 587)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMainMenu"
        Me.Text = "frmMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSystemSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmStationSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button
    Friend WithEvents btnManagement As System.Windows.Forms.Button
    Friend WithEvents btnAccounting As System.Windows.Forms.Button
    Friend WithEvents btnPurchasing As System.Windows.Forms.Button
    Friend WithEvents btnEcommerce As System.Windows.Forms.Button
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnService As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnSale As System.Windows.Forms.Button
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents tslUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslLoggedIn As System.Windows.Forms.ToolStripStatusLabel

End Class
