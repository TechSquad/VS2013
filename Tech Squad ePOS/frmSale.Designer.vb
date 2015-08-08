<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.txtSku = New System.Windows.Forms.TextBox()
        Me.lblSku = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.grpPurchaseOrder = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtOnOrder = New System.Windows.Forms.TextBox()
        Me.txtWebStock = New System.Windows.Forms.TextBox()
        Me.txtStockCount = New System.Windows.Forms.TextBox()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnCheckWebstock = New System.Windows.Forms.Button()
        Me.lblOnOrder = New System.Windows.Forms.Label()
        Me.lblWebstock = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.picItem = New System.Windows.Forms.PictureBox()
        Me.panTotals = New System.Windows.Forms.Panel()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.btnAdjustQuantity = New System.Windows.Forms.Button()
        Me.btnShowCosts = New System.Windows.Forms.Button()
        Me.btnShipTo = New System.Windows.Forms.Button()
        Me.btnAdjustPrice = New System.Windows.Forms.Button()
        Me.btnDiscountInvoice = New System.Windows.Forms.Button()
        Me.btnSimpleCustomer = New System.Windows.Forms.Button()
        Me.btnDiscountItem = New System.Windows.Forms.Button()
        Me.btnAssignCustomer = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalVat = New System.Windows.Forms.TextBox()
        Me.pnlShowCosts = New System.Windows.Forms.Panel()
        Me.txtAvgCost = New System.Windows.Forms.TextBox()
        Me.txtLastPurchased = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblAvgCost = New System.Windows.Forms.Label()
        Me.lblPurchased = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchaseOrder.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTotals.SuspendLayout()
        Me.pnlShowCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnVoid)
        Me.Panel1.Controls.Add(Me.btnLookup)
        Me.Panel1.Controls.Add(Me.txtSku)
        Me.Panel1.Controls.Add(Me.lblSku)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 49)
        Me.Panel1.TabIndex = 3
        '
        'btnVoid
        '
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVoid.Image = CType(resources.GetObject("btnVoid.Image"), System.Drawing.Image)
        Me.btnVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoid.Location = New System.Drawing.Point(928, 0)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(154, 49)
        Me.btnVoid.TabIndex = 2
        Me.btnVoid.Text = "Void Sale"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnLookup
        '
        Me.btnLookup.Image = CType(resources.GetObject("btnLookup.Image"), System.Drawing.Image)
        Me.btnLookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLookup.Location = New System.Drawing.Point(464, 0)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(154, 49)
        Me.btnLookup.TabIndex = 1
        Me.btnLookup.Text = "Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'txtSku
        '
        Me.txtSku.BackColor = System.Drawing.Color.Turquoise
        Me.txtSku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSku.Location = New System.Drawing.Point(41, 11)
        Me.txtSku.Name = "txtSku"
        Me.txtSku.Size = New System.Drawing.Size(389, 26)
        Me.txtSku.TabIndex = 0
        '
        'lblSku
        '
        Me.lblSku.AutoSize = True
        Me.lblSku.Location = New System.Drawing.Point(3, 19)
        Me.lblSku.Name = "lblSku"
        Me.lblSku.Size = New System.Drawing.Size(32, 13)
        Me.lblSku.TabIndex = 7
        Me.lblSku.Text = "SKU:"
        '
        'btnProcess
        '
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcess.Location = New System.Drawing.Point(1008, 519)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(68, 68)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "Tender   [F10]"
        Me.btnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeColumns = False
        Me.dgvItems.AllowUserToResizeRows = False
        Me.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Location = New System.Drawing.Point(9, 56)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvItems.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(1064, 320)
        Me.dgvItems.TabIndex = 4
        '
        'grpPurchaseOrder
        '
        Me.grpPurchaseOrder.Controls.Add(Me.SplitContainer1)
        Me.grpPurchaseOrder.Location = New System.Drawing.Point(12, 388)
        Me.grpPurchaseOrder.Name = "grpPurchaseOrder"
        Me.grpPurchaseOrder.Size = New System.Drawing.Size(506, 199)
        Me.grpPurchaseOrder.TabIndex = 6
        Me.grpPurchaseOrder.TabStop = False
        Me.grpPurchaseOrder.Text = "Item Info"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtOnOrder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtWebStock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtStockCount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnReserve)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCheckWebstock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblOnOrder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblWebstock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblStock)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.picItem)
        Me.SplitContainer1.Size = New System.Drawing.Size(500, 180)
        Me.SplitContainer1.SplitterDistance = 231
        Me.SplitContainer1.TabIndex = 0
        '
        'txtOnOrder
        '
        Me.txtOnOrder.Location = New System.Drawing.Point(93, 68)
        Me.txtOnOrder.Name = "txtOnOrder"
        Me.txtOnOrder.ReadOnly = True
        Me.txtOnOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtOnOrder.TabIndex = 8
        '
        'txtWebStock
        '
        Me.txtWebStock.Location = New System.Drawing.Point(93, 42)
        Me.txtWebStock.Name = "txtWebStock"
        Me.txtWebStock.ReadOnly = True
        Me.txtWebStock.Size = New System.Drawing.Size(100, 20)
        Me.txtWebStock.TabIndex = 7
        '
        'txtStockCount
        '
        Me.txtStockCount.Location = New System.Drawing.Point(93, 15)
        Me.txtStockCount.Name = "txtStockCount"
        Me.txtStockCount.ReadOnly = True
        Me.txtStockCount.Size = New System.Drawing.Size(100, 20)
        Me.txtStockCount.TabIndex = 6
        '
        'btnReserve
        '
        Me.btnReserve.Location = New System.Drawing.Point(159, 108)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(68, 68)
        Me.btnReserve.TabIndex = 5
        Me.btnReserve.Text = "Reserve Web Stock"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'btnCheckWebstock
        '
        Me.btnCheckWebstock.Location = New System.Drawing.Point(92, 108)
        Me.btnCheckWebstock.Name = "btnCheckWebstock"
        Me.btnCheckWebstock.Size = New System.Drawing.Size(68, 68)
        Me.btnCheckWebstock.TabIndex = 3
        Me.btnCheckWebstock.Text = "Check Web Stock"
        Me.btnCheckWebstock.UseVisualStyleBackColor = True
        '
        'lblOnOrder
        '
        Me.lblOnOrder.AutoSize = True
        Me.lblOnOrder.Location = New System.Drawing.Point(14, 73)
        Me.lblOnOrder.Name = "lblOnOrder"
        Me.lblOnOrder.Size = New System.Drawing.Size(50, 13)
        Me.lblOnOrder.TabIndex = 2
        Me.lblOnOrder.Text = "On Order"
        '
        'lblWebstock
        '
        Me.lblWebstock.AutoSize = True
        Me.lblWebstock.Location = New System.Drawing.Point(14, 45)
        Me.lblWebstock.Name = "lblWebstock"
        Me.lblWebstock.Size = New System.Drawing.Size(61, 13)
        Me.lblWebstock.TabIndex = 1
        Me.lblWebstock.Text = "Web Stock"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(14, 19)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(66, 13)
        Me.lblStock.TabIndex = 0
        Me.lblStock.Text = "Stock Count"
        '
        'picItem
        '
        Me.picItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picItem.Location = New System.Drawing.Point(0, 0)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(265, 180)
        Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picItem.TabIndex = 0
        Me.picItem.TabStop = False
        '
        'panTotals
        '
        Me.panTotals.BackColor = System.Drawing.Color.Black
        Me.panTotals.Controls.Add(Me.txtGrandTotal)
        Me.panTotals.Location = New System.Drawing.Point(740, 519)
        Me.panTotals.Name = "panTotals"
        Me.panTotals.Size = New System.Drawing.Size(262, 68)
        Me.panTotals.TabIndex = 9
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.Black
        Me.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGrandTotal.Location = New System.Drawing.Point(10, 6)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(240, 55)
        Me.txtGrandTotal.TabIndex = 110
        Me.txtGrandTotal.TabStop = False
        Me.txtGrandTotal.Text = "0.00"
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAdjustQuantity
        '
        Me.btnAdjustQuantity.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdjustQuantity.Location = New System.Drawing.Point(1008, 382)
        Me.btnAdjustQuantity.Name = "btnAdjustQuantity"
        Me.btnAdjustQuantity.Size = New System.Drawing.Size(68, 68)
        Me.btnAdjustQuantity.TabIndex = 10
        Me.btnAdjustQuantity.Text = "Adjust Quantity"
        Me.btnAdjustQuantity.UseVisualStyleBackColor = True
        '
        'btnShowCosts
        '
        Me.btnShowCosts.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShowCosts.Location = New System.Drawing.Point(1008, 449)
        Me.btnShowCosts.Name = "btnShowCosts"
        Me.btnShowCosts.Size = New System.Drawing.Size(68, 68)
        Me.btnShowCosts.TabIndex = 11
        Me.btnShowCosts.Text = "Show Costs"
        Me.btnShowCosts.UseVisualStyleBackColor = True
        '
        'btnShipTo
        '
        Me.btnShipTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShipTo.Location = New System.Drawing.Point(941, 449)
        Me.btnShipTo.Name = "btnShipTo"
        Me.btnShipTo.Size = New System.Drawing.Size(68, 68)
        Me.btnShipTo.TabIndex = 13
        Me.btnShipTo.Text = "Ship To"
        Me.btnShipTo.UseVisualStyleBackColor = True
        '
        'btnAdjustPrice
        '
        Me.btnAdjustPrice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdjustPrice.Location = New System.Drawing.Point(941, 382)
        Me.btnAdjustPrice.Name = "btnAdjustPrice"
        Me.btnAdjustPrice.Size = New System.Drawing.Size(68, 68)
        Me.btnAdjustPrice.TabIndex = 12
        Me.btnAdjustPrice.Text = "Adjust Price"
        Me.btnAdjustPrice.UseVisualStyleBackColor = True
        '
        'btnDiscountInvoice
        '
        Me.btnDiscountInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDiscountInvoice.Location = New System.Drawing.Point(874, 449)
        Me.btnDiscountInvoice.Name = "btnDiscountInvoice"
        Me.btnDiscountInvoice.Size = New System.Drawing.Size(68, 68)
        Me.btnDiscountInvoice.TabIndex = 15
        Me.btnDiscountInvoice.Text = "Discount Invoice"
        Me.btnDiscountInvoice.UseVisualStyleBackColor = True
        '
        'btnSimpleCustomer
        '
        Me.btnSimpleCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpleCustomer.Location = New System.Drawing.Point(874, 382)
        Me.btnSimpleCustomer.Name = "btnSimpleCustomer"
        Me.btnSimpleCustomer.Size = New System.Drawing.Size(68, 68)
        Me.btnSimpleCustomer.TabIndex = 14
        Me.btnSimpleCustomer.Text = "Add Basic Details"
        Me.btnSimpleCustomer.UseVisualStyleBackColor = True
        '
        'btnDiscountItem
        '
        Me.btnDiscountItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDiscountItem.Location = New System.Drawing.Point(807, 449)
        Me.btnDiscountItem.Name = "btnDiscountItem"
        Me.btnDiscountItem.Size = New System.Drawing.Size(68, 68)
        Me.btnDiscountItem.TabIndex = 17
        Me.btnDiscountItem.Text = "Discount Item"
        Me.btnDiscountItem.UseVisualStyleBackColor = True
        '
        'btnAssignCustomer
        '
        Me.btnAssignCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAssignCustomer.Location = New System.Drawing.Point(807, 382)
        Me.btnAssignCustomer.Name = "btnAssignCustomer"
        Me.btnAssignCustomer.Size = New System.Drawing.Size(68, 68)
        Me.btnAssignCustomer.TabIndex = 16
        Me.btnAssignCustomer.Text = "Add Customer"
        Me.btnAssignCustomer.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(740, 449)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(68, 68)
        Me.btnDown.TabIndex = 19
        Me.btnDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(740, 382)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(68, 68)
        Me.btnUp.TabIndex = 18
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(550, 534)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTotal.TabIndex = 20
        Me.lblSubTotal.Text = "Sub Total"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Location = New System.Drawing.Point(553, 562)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(55, 13)
        Me.lblVat.TabIndex = 21
        Me.lblVat.Text = "Total VAT"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(613, 530)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 22
        '
        'txtTotalVat
        '
        Me.txtTotalVat.Location = New System.Drawing.Point(613, 558)
        Me.txtTotalVat.Name = "txtTotalVat"
        Me.txtTotalVat.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalVat.TabIndex = 23
        '
        'pnlShowCosts
        '
        Me.pnlShowCosts.Controls.Add(Me.txtAvgCost)
        Me.pnlShowCosts.Controls.Add(Me.txtLastPurchased)
        Me.pnlShowCosts.Controls.Add(Me.txtCost)
        Me.pnlShowCosts.Controls.Add(Me.lblAvgCost)
        Me.pnlShowCosts.Controls.Add(Me.lblPurchased)
        Me.pnlShowCosts.Controls.Add(Me.lblCost)
        Me.pnlShowCosts.Location = New System.Drawing.Point(524, 405)
        Me.pnlShowCosts.Name = "pnlShowCosts"
        Me.pnlShowCosts.Size = New System.Drawing.Size(211, 116)
        Me.pnlShowCosts.TabIndex = 24
        Me.pnlShowCosts.Visible = False
        '
        'txtAvgCost
        '
        Me.txtAvgCost.Enabled = False
        Me.txtAvgCost.Location = New System.Drawing.Point(98, 74)
        Me.txtAvgCost.Name = "txtAvgCost"
        Me.txtAvgCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAvgCost.TabIndex = 5
        '
        'txtLastPurchased
        '
        Me.txtLastPurchased.Enabled = False
        Me.txtLastPurchased.Location = New System.Drawing.Point(98, 45)
        Me.txtLastPurchased.Name = "txtLastPurchased"
        Me.txtLastPurchased.Size = New System.Drawing.Size(100, 20)
        Me.txtLastPurchased.TabIndex = 4
        '
        'txtCost
        '
        Me.txtCost.Enabled = False
        Me.txtCost.Location = New System.Drawing.Point(98, 15)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 3
        '
        'lblAvgCost
        '
        Me.lblAvgCost.AutoSize = True
        Me.lblAvgCost.Location = New System.Drawing.Point(12, 77)
        Me.lblAvgCost.Name = "lblAvgCost"
        Me.lblAvgCost.Size = New System.Drawing.Size(71, 13)
        Me.lblAvgCost.TabIndex = 2
        Me.lblAvgCost.Text = "Average Cost"
        '
        'lblPurchased
        '
        Me.lblPurchased.AutoSize = True
        Me.lblPurchased.Location = New System.Drawing.Point(12, 48)
        Me.lblPurchased.Name = "lblPurchased"
        Me.lblPurchased.Size = New System.Drawing.Size(81, 13)
        Me.lblPurchased.TabIndex = 1
        Me.lblPurchased.Text = "Last Purchased"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(12, 18)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "Cost"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 589)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlShowCosts)
        Me.Controls.Add(Me.txtTotalVat)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnDiscountItem)
        Me.Controls.Add(Me.btnAssignCustomer)
        Me.Controls.Add(Me.btnDiscountInvoice)
        Me.Controls.Add(Me.btnSimpleCustomer)
        Me.Controls.Add(Me.btnShipTo)
        Me.Controls.Add(Me.btnAdjustPrice)
        Me.Controls.Add(Me.btnShowCosts)
        Me.Controls.Add(Me.btnAdjustQuantity)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.panTotals)
        Me.Controls.Add(Me.grpPurchaseOrder)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1098, 627)
        Me.MinimumSize = New System.Drawing.Size(1098, 627)
        Me.Name = "frmSale"
        Me.ShowInTaskbar = False
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchaseOrder.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTotals.ResumeLayout(False)
        Me.panTotals.PerformLayout()
        Me.pnlShowCosts.ResumeLayout(False)
        Me.pnlShowCosts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents txtSku As System.Windows.Forms.TextBox
    Friend WithEvents lblSku As System.Windows.Forms.Label
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents grpPurchaseOrder As System.Windows.Forms.GroupBox
    Friend WithEvents panTotals As System.Windows.Forms.Panel
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnAdjustQuantity As System.Windows.Forms.Button
    Friend WithEvents btnShowCosts As System.Windows.Forms.Button
    Friend WithEvents btnShipTo As System.Windows.Forms.Button
    Friend WithEvents btnAdjustPrice As System.Windows.Forms.Button
    Friend WithEvents btnDiscountInvoice As System.Windows.Forms.Button
    Friend WithEvents btnSimpleCustomer As System.Windows.Forms.Button
    Friend WithEvents btnDiscountItem As System.Windows.Forms.Button
    Friend WithEvents btnAssignCustomer As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtOnOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtWebStock As System.Windows.Forms.TextBox
    Friend WithEvents txtStockCount As System.Windows.Forms.TextBox
    Friend WithEvents btnReserve As System.Windows.Forms.Button
    Friend WithEvents btnCheckWebstock As System.Windows.Forms.Button
    Friend WithEvents lblOnOrder As System.Windows.Forms.Label
    Friend WithEvents lblWebstock As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents picItem As System.Windows.Forms.PictureBox
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalVat As System.Windows.Forms.TextBox
    Friend WithEvents pnlShowCosts As System.Windows.Forms.Panel
    Friend WithEvents txtAvgCost As System.Windows.Forms.TextBox
    Friend WithEvents txtLastPurchased As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblAvgCost As System.Windows.Forms.Label
    Friend WithEvents lblPurchased As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
