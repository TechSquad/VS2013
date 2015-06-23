<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrders))
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.dgvPurchaseOrders = New System.Windows.Forms.DataGridView()
        Me.dgvPoItems = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCreatePo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPoItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AllowUserToResizeColumns = False
        Me.dgvSuppliers.AllowUserToResizeRows = False
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Location = New System.Drawing.Point(9, 78)
        Me.dgvSuppliers.MultiSelect = False
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.ShowCellErrors = False
        Me.dgvSuppliers.ShowCellToolTips = False
        Me.dgvSuppliers.ShowEditingIcon = False
        Me.dgvSuppliers.ShowRowErrors = False
        Me.dgvSuppliers.Size = New System.Drawing.Size(182, 380)
        Me.dgvSuppliers.TabIndex = 0
        '
        'dgvPurchaseOrders
        '
        Me.dgvPurchaseOrders.AllowUserToAddRows = False
        Me.dgvPurchaseOrders.AllowUserToDeleteRows = False
        Me.dgvPurchaseOrders.AllowUserToResizeColumns = False
        Me.dgvPurchaseOrders.AllowUserToResizeRows = False
        Me.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPurchaseOrders.Location = New System.Drawing.Point(201, 78)
        Me.dgvPurchaseOrders.MultiSelect = False
        Me.dgvPurchaseOrders.Name = "dgvPurchaseOrders"
        Me.dgvPurchaseOrders.ReadOnly = True
        Me.dgvPurchaseOrders.RowHeadersVisible = False
        Me.dgvPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPurchaseOrders.ShowCellErrors = False
        Me.dgvPurchaseOrders.ShowCellToolTips = False
        Me.dgvPurchaseOrders.ShowEditingIcon = False
        Me.dgvPurchaseOrders.ShowRowErrors = False
        Me.dgvPurchaseOrders.Size = New System.Drawing.Size(776, 195)
        Me.dgvPurchaseOrders.TabIndex = 1
        '
        'dgvPoItems
        '
        Me.dgvPoItems.AllowUserToAddRows = False
        Me.dgvPoItems.AllowUserToDeleteRows = False
        Me.dgvPoItems.AllowUserToResizeColumns = False
        Me.dgvPoItems.AllowUserToResizeRows = False
        Me.dgvPoItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoItems.Location = New System.Drawing.Point(201, 280)
        Me.dgvPoItems.Name = "dgvPoItems"
        Me.dgvPoItems.RowHeadersVisible = False
        Me.dgvPoItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPoItems.ShowCellErrors = False
        Me.dgvPoItems.ShowCellToolTips = False
        Me.dgvPoItems.ShowEditingIcon = False
        Me.dgvPoItems.ShowRowErrors = False
        Me.dgvPoItems.Size = New System.Drawing.Size(776, 178)
        Me.dgvPoItems.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnVoid)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnCreatePo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(984, 68)
        Me.Panel1.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(887, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 68)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Image = CType(resources.GetObject("btnVoid.Image"), System.Drawing.Image)
        Me.btnVoid.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVoid.Location = New System.Drawing.Point(194, 0)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(97, 68)
        Me.btnVoid.TabIndex = 2
        Me.btnVoid.Text = "Void PO"
        Me.btnVoid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(97, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(97, 68)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit/Send PO"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCreatePo
        '
        Me.btnCreatePo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCreatePo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCreatePo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePo.Image = CType(resources.GetObject("btnCreatePo.Image"), System.Drawing.Image)
        Me.btnCreatePo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreatePo.Location = New System.Drawing.Point(0, 0)
        Me.btnCreatePo.Name = "btnCreatePo"
        Me.btnCreatePo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCreatePo.Size = New System.Drawing.Size(97, 68)
        Me.btnCreatePo.TabIndex = 0
        Me.btnCreatePo.Text = "New PO"
        Me.btnCreatePo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreatePo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmPurchaseOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvPoItems)
        Me.Controls.Add(Me.dgvPurchaseOrders)
        Me.Controls.Add(Me.dgvSuppliers)
        Me.MaximumSize = New System.Drawing.Size(1008, 608)
        Me.Name = "frmPurchaseOrders"
        Me.Text = "Purchase Orders"
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPoItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPurchaseOrders As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPoItems As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCreatePo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
