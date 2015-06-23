<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoDetail))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPoSupplier = New System.Windows.Forms.Label()
        Me.lblPoStat = New System.Windows.Forms.Label()
        Me.lblPoNum = New System.Windows.Forms.Label()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.txtSku = New System.Windows.Forms.TextBox()
        Me.lblSku = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.grpPurchaseOrder = New System.Windows.Forms.GroupBox()
        Me.lblShipToId = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblShipTo = New System.Windows.Forms.Label()
        Me.txtShipTo = New System.Windows.Forms.TextBox()
        Me.cbTerms = New System.Windows.Forms.ComboBox()
        Me.cbShipping = New System.Windows.Forms.ComboBox()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblPoNumber = New System.Windows.Forms.Label()
        Me.grpCharges = New System.Windows.Forms.GroupBox()
        Me.txtmCarriageTax = New System.Windows.Forms.TextBox()
        Me.txtmCarriage = New System.Windows.Forms.TextBox()
        Me.txtTaxOnOrder = New System.Windows.Forms.TextBox()
        Me.lblCarriageTax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblCarriage = New System.Windows.Forms.Label()
        Me.panTotals = New System.Windows.Forms.Panel()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtPoTotal = New System.Windows.Forms.TextBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblPoTotal = New System.Windows.Forms.Label()
        Me.grpDates = New System.Windows.Forms.GroupBox()
        Me.lblDateReceived = New System.Windows.Forms.Label()
        Me.dtpReceived = New System.Windows.Forms.DateTimePicker()
        Me.lblDateExpected = New System.Windows.Forms.Label()
        Me.dtpExpected = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchaseOrder.SuspendLayout()
        Me.grpCharges.SuspendLayout()
        Me.panTotals.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPoSupplier)
        Me.Panel1.Controls.Add(Me.lblPoStat)
        Me.Panel1.Controls.Add(Me.lblPoNum)
        Me.Panel1.Controls.Add(Me.btnVoid)
        Me.Panel1.Controls.Add(Me.btnProcess)
        Me.Panel1.Controls.Add(Me.btnLookup)
        Me.Panel1.Controls.Add(Me.txtSku)
        Me.Panel1.Controls.Add(Me.lblSku)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 49)
        Me.Panel1.TabIndex = 3
        '
        'lblPoSupplier
        '
        Me.lblPoSupplier.AutoSize = True
        Me.lblPoSupplier.Location = New System.Drawing.Point(704, 11)
        Me.lblPoSupplier.Name = "lblPoSupplier"
        Me.lblPoSupplier.Size = New System.Drawing.Size(68, 13)
        Me.lblPoSupplier.TabIndex = 10
        Me.lblPoSupplier.Text = "lblPoSupplier"
        Me.lblPoSupplier.Visible = False
        '
        'lblPoStat
        '
        Me.lblPoStat.AutoSize = True
        Me.lblPoStat.Location = New System.Drawing.Point(632, 30)
        Me.lblPoStat.Name = "lblPoStat"
        Me.lblPoStat.Size = New System.Drawing.Size(49, 13)
        Me.lblPoStat.TabIndex = 9
        Me.lblPoStat.Text = "lblPoStat"
        '
        'lblPoNum
        '
        Me.lblPoNum.AutoSize = True
        Me.lblPoNum.Location = New System.Drawing.Point(632, 11)
        Me.lblPoNum.Name = "lblPoNum"
        Me.lblPoNum.Size = New System.Drawing.Size(52, 13)
        Me.lblPoNum.TabIndex = 8
        Me.lblPoNum.Text = "lblPoNum"
        '
        'btnVoid
        '
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVoid.Image = CType(resources.GetObject("btnVoid.Image"), System.Drawing.Image)
        Me.btnVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoid.Location = New System.Drawing.Point(774, 0)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(154, 49)
        Me.btnVoid.TabIndex = 2
        Me.btnVoid.Text = "Void PO"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcess.Location = New System.Drawing.Point(928, 0)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(154, 49)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "Save / Process"
        Me.btnProcess.UseVisualStyleBackColor = True
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
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(1064, 272)
        Me.dgvItems.TabIndex = 4
        '
        'grpPurchaseOrder
        '
        Me.grpPurchaseOrder.Controls.Add(Me.lblShipToId)
        Me.grpPurchaseOrder.Controls.Add(Me.txtNote)
        Me.grpPurchaseOrder.Controls.Add(Me.lblNote)
        Me.grpPurchaseOrder.Controls.Add(Me.lblShipTo)
        Me.grpPurchaseOrder.Controls.Add(Me.txtShipTo)
        Me.grpPurchaseOrder.Controls.Add(Me.cbTerms)
        Me.grpPurchaseOrder.Controls.Add(Me.cbShipping)
        Me.grpPurchaseOrder.Controls.Add(Me.txtPoNo)
        Me.grpPurchaseOrder.Controls.Add(Me.lblTerms)
        Me.grpPurchaseOrder.Controls.Add(Me.lblShipping)
        Me.grpPurchaseOrder.Controls.Add(Me.lblPoNumber)
        Me.grpPurchaseOrder.Location = New System.Drawing.Point(12, 388)
        Me.grpPurchaseOrder.Name = "grpPurchaseOrder"
        Me.grpPurchaseOrder.Size = New System.Drawing.Size(506, 199)
        Me.grpPurchaseOrder.TabIndex = 6
        Me.grpPurchaseOrder.TabStop = False
        Me.grpPurchaseOrder.Text = "Purchase Order"
        '
        'lblShipToId
        '
        Me.lblShipToId.AutoSize = True
        Me.lblShipToId.Location = New System.Drawing.Point(278, 68)
        Me.lblShipToId.Name = "lblShipToId"
        Me.lblShipToId.Size = New System.Drawing.Size(60, 13)
        Me.lblShipToId.TabIndex = 18
        Me.lblShipToId.Text = "lblShipToId"
        Me.lblShipToId.Visible = False
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(106, 140)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(386, 49)
        Me.txtNote.TabIndex = 13
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(14, 143)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(30, 13)
        Me.lblNote.TabIndex = 17
        Me.lblNote.Text = "Note"
        '
        'lblShipTo
        '
        Me.lblShipTo.AutoSize = True
        Me.lblShipTo.Location = New System.Drawing.Point(277, 38)
        Me.lblShipTo.Name = "lblShipTo"
        Me.lblShipTo.Size = New System.Drawing.Size(44, 13)
        Me.lblShipTo.TabIndex = 16
        Me.lblShipTo.Text = "Ship To"
        '
        'txtShipTo
        '
        Me.txtShipTo.Enabled = False
        Me.txtShipTo.Location = New System.Drawing.Point(327, 32)
        Me.txtShipTo.Multiline = True
        Me.txtShipTo.Name = "txtShipTo"
        Me.txtShipTo.Size = New System.Drawing.Size(165, 96)
        Me.txtShipTo.TabIndex = 14
        '
        'cbTerms
        '
        Me.cbTerms.FormattingEnabled = True
        Me.cbTerms.Location = New System.Drawing.Point(106, 91)
        Me.cbTerms.Name = "cbTerms"
        Me.cbTerms.Size = New System.Drawing.Size(165, 21)
        Me.cbTerms.TabIndex = 12
        '
        'cbShipping
        '
        Me.cbShipping.FormattingEnabled = True
        Me.cbShipping.Location = New System.Drawing.Point(106, 61)
        Me.cbShipping.Name = "cbShipping"
        Me.cbShipping.Size = New System.Drawing.Size(165, 21)
        Me.cbShipping.TabIndex = 11
        '
        'txtPoNo
        '
        Me.txtPoNo.Location = New System.Drawing.Point(106, 35)
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(165, 20)
        Me.txtPoNo.TabIndex = 10
        '
        'lblTerms
        '
        Me.lblTerms.AutoSize = True
        Me.lblTerms.Location = New System.Drawing.Point(14, 94)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(36, 13)
        Me.lblTerms.TabIndex = 11
        Me.lblTerms.Text = "Terms"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(14, 61)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(48, 13)
        Me.lblShipping.TabIndex = 10
        Me.lblShipping.Text = "Shipping"
        '
        'lblPoNumber
        '
        Me.lblPoNumber.AutoSize = True
        Me.lblPoNumber.Location = New System.Drawing.Point(14, 35)
        Me.lblPoNumber.Name = "lblPoNumber"
        Me.lblPoNumber.Size = New System.Drawing.Size(62, 13)
        Me.lblPoNumber.TabIndex = 9
        Me.lblPoNumber.Text = "PO Number"
        '
        'grpCharges
        '
        Me.grpCharges.Controls.Add(Me.txtmCarriageTax)
        Me.grpCharges.Controls.Add(Me.txtmCarriage)
        Me.grpCharges.Controls.Add(Me.txtTaxOnOrder)
        Me.grpCharges.Controls.Add(Me.lblCarriageTax)
        Me.grpCharges.Controls.Add(Me.lblTax)
        Me.grpCharges.Controls.Add(Me.lblCarriage)
        Me.grpCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCharges.Location = New System.Drawing.Point(791, 389)
        Me.grpCharges.Name = "grpCharges"
        Me.grpCharges.Size = New System.Drawing.Size(279, 106)
        Me.grpCharges.TabIndex = 7
        Me.grpCharges.TabStop = False
        Me.grpCharges.Text = "Additional Charges"
        '
        'txtmCarriageTax
        '
        Me.txtmCarriageTax.Location = New System.Drawing.Point(121, 78)
        Me.txtmCarriageTax.Name = "txtmCarriageTax"
        Me.txtmCarriageTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmCarriageTax.Size = New System.Drawing.Size(152, 21)
        Me.txtmCarriageTax.TabIndex = 24
        '
        'txtmCarriage
        '
        Me.txtmCarriage.Location = New System.Drawing.Point(121, 23)
        Me.txtmCarriage.Name = "txtmCarriage"
        Me.txtmCarriage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtmCarriage.Size = New System.Drawing.Size(152, 21)
        Me.txtmCarriage.TabIndex = 23
        '
        'txtTaxOnOrder
        '
        Me.txtTaxOnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxOnOrder.Location = New System.Drawing.Point(121, 51)
        Me.txtTaxOnOrder.Name = "txtTaxOnOrder"
        Me.txtTaxOnOrder.ReadOnly = True
        Me.txtTaxOnOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaxOnOrder.Size = New System.Drawing.Size(152, 22)
        Me.txtTaxOnOrder.TabIndex = 21
        '
        'lblCarriageTax
        '
        Me.lblCarriageTax.AutoSize = True
        Me.lblCarriageTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarriageTax.Location = New System.Drawing.Point(7, 78)
        Me.lblCarriageTax.Name = "lblCarriageTax"
        Me.lblCarriageTax.Size = New System.Drawing.Size(104, 16)
        Me.lblCarriageTax.TabIndex = 2
        Me.lblCarriageTax.Text = "Tax on Carriage"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(7, 51)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(86, 16)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax on Order"
        '
        'lblCarriage
        '
        Me.lblCarriage.AutoSize = True
        Me.lblCarriage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarriage.Location = New System.Drawing.Point(7, 27)
        Me.lblCarriage.Name = "lblCarriage"
        Me.lblCarriage.Size = New System.Drawing.Size(60, 16)
        Me.lblCarriage.TabIndex = 0
        Me.lblCarriage.Text = "Carriage"
        '
        'panTotals
        '
        Me.panTotals.BackColor = System.Drawing.Color.Black
        Me.panTotals.Controls.Add(Me.txtGrandTotal)
        Me.panTotals.Controls.Add(Me.txtPoTotal)
        Me.panTotals.Controls.Add(Me.lblGrandTotal)
        Me.panTotals.Controls.Add(Me.lblPoTotal)
        Me.panTotals.Location = New System.Drawing.Point(791, 501)
        Me.panTotals.Name = "panTotals"
        Me.panTotals.Size = New System.Drawing.Size(279, 86)
        Me.panTotals.TabIndex = 9
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.Black
        Me.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGrandTotal.Location = New System.Drawing.Point(143, 50)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(127, 24)
        Me.txtGrandTotal.TabIndex = 110
        Me.txtGrandTotal.TabStop = False
        Me.txtGrandTotal.Text = "0.00"
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPoTotal
        '
        Me.txtPoTotal.BackColor = System.Drawing.Color.Black
        Me.txtPoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPoTotal.Location = New System.Drawing.Point(143, 11)
        Me.txtPoTotal.Name = "txtPoTotal"
        Me.txtPoTotal.ReadOnly = True
        Me.txtPoTotal.Size = New System.Drawing.Size(127, 24)
        Me.txtPoTotal.TabIndex = 100
        Me.txtPoTotal.TabStop = False
        Me.txtPoTotal.Text = "0.00"
        Me.txtPoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.White
        Me.lblGrandTotal.Location = New System.Drawing.Point(3, 51)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(143, 25)
        Me.lblGrandTotal.TabIndex = 3
        Me.lblGrandTotal.Text = "Grand Total:"
        '
        'lblPoTotal
        '
        Me.lblPoTotal.AutoSize = True
        Me.lblPoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoTotal.ForeColor = System.Drawing.Color.White
        Me.lblPoTotal.Location = New System.Drawing.Point(3, 13)
        Me.lblPoTotal.Name = "lblPoTotal"
        Me.lblPoTotal.Size = New System.Drawing.Size(111, 25)
        Me.lblPoTotal.TabIndex = 2
        Me.lblPoTotal.Text = "PO Total:"
        '
        'grpDates
        '
        Me.grpDates.Controls.Add(Me.lblDateReceived)
        Me.grpDates.Controls.Add(Me.dtpReceived)
        Me.grpDates.Controls.Add(Me.lblDateExpected)
        Me.grpDates.Controls.Add(Me.dtpExpected)
        Me.grpDates.Location = New System.Drawing.Point(525, 389)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(260, 106)
        Me.grpDates.TabIndex = 10
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Dates"
        '
        'lblDateReceived
        '
        Me.lblDateReceived.AutoSize = True
        Me.lblDateReceived.Location = New System.Drawing.Point(15, 67)
        Me.lblDateReceived.Name = "lblDateReceived"
        Me.lblDateReceived.Size = New System.Drawing.Size(79, 13)
        Me.lblDateReceived.TabIndex = 3
        Me.lblDateReceived.Text = "Date Received"
        '
        'dtpReceived
        '
        Me.dtpReceived.Location = New System.Drawing.Point(110, 66)
        Me.dtpReceived.Name = "dtpReceived"
        Me.dtpReceived.Size = New System.Drawing.Size(144, 20)
        Me.dtpReceived.TabIndex = 2
        '
        'lblDateExpected
        '
        Me.lblDateExpected.AutoSize = True
        Me.lblDateExpected.Location = New System.Drawing.Point(15, 35)
        Me.lblDateExpected.Name = "lblDateExpected"
        Me.lblDateExpected.Size = New System.Drawing.Size(78, 13)
        Me.lblDateExpected.TabIndex = 1
        Me.lblDateExpected.Text = "Date Expected"
        '
        'dtpExpected
        '
        Me.dtpExpected.Location = New System.Drawing.Point(110, 34)
        Me.dtpExpected.Name = "dtpExpected"
        Me.dtpExpected.Size = New System.Drawing.Size(144, 20)
        Me.dtpExpected.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDown)
        Me.Panel2.Controls.Add(Me.btnUp)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(1, 332)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1082, 49)
        Me.Panel2.TabIndex = 4
        '
        'btnDown
        '
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDown.Location = New System.Drawing.Point(73, 0)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(73, 49)
        Me.btnDown.TabIndex = 7
        Me.btnDown.Text = "Down"
        Me.btnDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUp.Location = New System.Drawing.Point(0, 0)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(73, 49)
        Me.btnUp.TabIndex = 6
        Me.btnUp.Text = "Up"
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(774, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(154, 49)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(928, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(154, 49)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmPoDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 589)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.panTotals)
        Me.Controls.Add(Me.grpCharges)
        Me.Controls.Add(Me.grpPurchaseOrder)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPoDetail"
        Me.Text = "Purchase Order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchaseOrder.ResumeLayout(False)
        Me.grpPurchaseOrder.PerformLayout()
        Me.grpCharges.ResumeLayout(False)
        Me.grpCharges.PerformLayout()
        Me.panTotals.ResumeLayout(False)
        Me.panTotals.PerformLayout()
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents txtSku As System.Windows.Forms.TextBox
    Friend WithEvents lblSku As System.Windows.Forms.Label
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents grpPurchaseOrder As System.Windows.Forms.GroupBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblShipTo As System.Windows.Forms.Label
    Friend WithEvents txtShipTo As System.Windows.Forms.TextBox
    Friend WithEvents cbTerms As System.Windows.Forms.ComboBox
    Friend WithEvents cbShipping As System.Windows.Forms.ComboBox
    Friend WithEvents txtPoNo As System.Windows.Forms.TextBox
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblPoNumber As System.Windows.Forms.Label
    Friend WithEvents grpCharges As System.Windows.Forms.GroupBox
    Friend WithEvents txtTaxOnOrder As System.Windows.Forms.TextBox
    Friend WithEvents lblCarriageTax As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblCarriage As System.Windows.Forms.Label
    Friend WithEvents panTotals As System.Windows.Forms.Panel
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPoTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblPoTotal As System.Windows.Forms.Label
    Friend WithEvents grpDates As System.Windows.Forms.GroupBox
    Friend WithEvents lblDateReceived As System.Windows.Forms.Label
    Friend WithEvents dtpReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateExpected As System.Windows.Forms.Label
    Friend WithEvents dtpExpected As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblPoStat As System.Windows.Forms.Label
    Friend WithEvents lblPoNum As System.Windows.Forms.Label
    Friend WithEvents lblShipToId As System.Windows.Forms.Label
    Friend WithEvents txtmCarriageTax As System.Windows.Forms.TextBox
    Friend WithEvents txtmCarriage As System.Windows.Forms.TextBox
    Friend WithEvents lblPoSupplier As System.Windows.Forms.Label
End Class
