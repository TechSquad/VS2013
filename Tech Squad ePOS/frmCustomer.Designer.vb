<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtLocate = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grpPurchases = New System.Windows.Forms.GroupBox()
        Me.dgvPurchases = New System.Windows.Forms.DataGridView()
        Me.grpService = New System.Windows.Forms.GroupBox()
        Me.dgvService = New System.Windows.Forms.DataGridView()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPurchases.SuspendLayout()
        CType(Me.dgvPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpService.SuspendLayout()
        CType(Me.dgvService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 47)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(969, 199)
        Me.DataGridView1.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(687, 252)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(144, 52)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(537, 253)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 52)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtLocate
        '
        Me.txtLocate.Location = New System.Drawing.Point(93, 11)
        Me.txtLocate.Name = "txtLocate"
        Me.txtLocate.Size = New System.Drawing.Size(291, 20)
        Me.txtLocate.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(837, 253)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(144, 51)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'grpPurchases
        '
        Me.grpPurchases.Controls.Add(Me.dgvPurchases)
        Me.grpPurchases.Location = New System.Drawing.Point(13, 311)
        Me.grpPurchases.Name = "grpPurchases"
        Me.grpPurchases.Size = New System.Drawing.Size(466, 143)
        Me.grpPurchases.TabIndex = 10
        Me.grpPurchases.TabStop = False
        Me.grpPurchases.Text = "Purchases"
        '
        'dgvPurchases
        '
        Me.dgvPurchases.AllowUserToAddRows = False
        Me.dgvPurchases.AllowUserToDeleteRows = False
        Me.dgvPurchases.AllowUserToResizeColumns = False
        Me.dgvPurchases.AllowUserToResizeRows = False
        Me.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPurchases.ColumnHeadersVisible = False
        Me.dgvPurchases.Location = New System.Drawing.Point(7, 20)
        Me.dgvPurchases.MultiSelect = False
        Me.dgvPurchases.Name = "dgvPurchases"
        Me.dgvPurchases.ReadOnly = True
        Me.dgvPurchases.RowHeadersVisible = False
        Me.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPurchases.Size = New System.Drawing.Size(453, 110)
        Me.dgvPurchases.TabIndex = 0
        '
        'grpService
        '
        Me.grpService.Controls.Add(Me.dgvService)
        Me.grpService.Location = New System.Drawing.Point(501, 311)
        Me.grpService.Name = "grpService"
        Me.grpService.Size = New System.Drawing.Size(480, 143)
        Me.grpService.TabIndex = 11
        Me.grpService.TabStop = False
        Me.grpService.Text = "Service"
        '
        'dgvService
        '
        Me.dgvService.AllowUserToAddRows = False
        Me.dgvService.AllowUserToDeleteRows = False
        Me.dgvService.AllowUserToResizeColumns = False
        Me.dgvService.AllowUserToResizeRows = False
        Me.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvService.ColumnHeadersVisible = False
        Me.dgvService.Location = New System.Drawing.Point(7, 20)
        Me.dgvService.MultiSelect = False
        Me.dgvService.Name = "dgvService"
        Me.dgvService.ReadOnly = True
        Me.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvService.Size = New System.Drawing.Size(467, 110)
        Me.dgvService.TabIndex = 0
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(387, 252)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(144, 52)
        Me.btnHistory.TabIndex = 12
        Me.btnHistory.Text = "Show Transactions"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Locate"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.grpService)
        Me.Controls.Add(Me.grpPurchases)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtLocate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomer"
        Me.Text = "Customer Centre"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPurchases.ResumeLayout(False)
        CType(Me.dgvPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpService.ResumeLayout(False)
        CType(Me.dgvService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtLocate As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents grpPurchases As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPurchases As System.Windows.Forms.DataGridView
    Friend WithEvents grpService As System.Windows.Forms.GroupBox
    Friend WithEvents dgvService As System.Windows.Forms.DataGridView
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
