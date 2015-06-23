<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefinitions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefinitions))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvDefinitions = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblDefinition = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnPoTerms = New System.Windows.Forms.Button()
        Me.btnSalutation = New System.Windows.Forms.Button()
        Me.btnAccountType = New System.Windows.Forms.Button()
        Me.btnPoShipping = New System.Windows.Forms.Button()
        CType(Me.dgvDefinitions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(581, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(109, 46)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(465, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvDefinitions
        '
        Me.dgvDefinitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDefinitions.Location = New System.Drawing.Point(12, 53)
        Me.dgvDefinitions.Name = "dgvDefinitions"
        Me.dgvDefinitions.Size = New System.Drawing.Size(666, 242)
        Me.dgvDefinitions.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(587, 313)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(393, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 34)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(490, 312)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 34)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblDefinition
        '
        Me.lblDefinition.AutoSize = True
        Me.lblDefinition.Location = New System.Drawing.Point(11, 324)
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(85, 13)
        Me.lblDefinition.TabIndex = 13
        Me.lblDefinition.Text = "Definition to Add"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 321)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 14
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnAccountType)
        Me.pnlButtons.Controls.Add(Me.btnPoShipping)
        Me.pnlButtons.Controls.Add(Me.btnPoTerms)
        Me.pnlButtons.Controls.Add(Me.btnSalutation)
        Me.pnlButtons.Controls.Add(Me.btnExit)
        Me.pnlButtons.Controls.Add(Me.btnOk)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 0)
        Me.pnlButtons.MaximumSize = New System.Drawing.Size(690, 46)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(690, 46)
        Me.pnlButtons.TabIndex = 15
        '
        'btnPoTerms
        '
        Me.btnPoTerms.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPoTerms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPoTerms.Location = New System.Drawing.Point(84, 0)
        Me.btnPoTerms.Name = "btnPoTerms"
        Me.btnPoTerms.Size = New System.Drawing.Size(91, 46)
        Me.btnPoTerms.TabIndex = 4
        Me.btnPoTerms.Text = "PO Terms"
        Me.btnPoTerms.UseVisualStyleBackColor = True
        '
        'btnSalutation
        '
        Me.btnSalutation.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalutation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalutation.Location = New System.Drawing.Point(0, 0)
        Me.btnSalutation.Name = "btnSalutation"
        Me.btnSalutation.Size = New System.Drawing.Size(84, 46)
        Me.btnSalutation.TabIndex = 5
        Me.btnSalutation.Text = "Salutation"
        Me.btnSalutation.UseVisualStyleBackColor = True
        '
        'btnAccountType
        '
        Me.btnAccountType.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAccountType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountType.Location = New System.Drawing.Point(259, 0)
        Me.btnAccountType.Name = "btnAccountType"
        Me.btnAccountType.Size = New System.Drawing.Size(91, 46)
        Me.btnAccountType.TabIndex = 6
        Me.btnAccountType.Text = "Account Type"
        Me.btnAccountType.UseVisualStyleBackColor = True
        '
        'btnPoShipping
        '
        Me.btnPoShipping.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPoShipping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPoShipping.Location = New System.Drawing.Point(175, 0)
        Me.btnPoShipping.Name = "btnPoShipping"
        Me.btnPoShipping.Size = New System.Drawing.Size(84, 46)
        Me.btnPoShipping.TabIndex = 7
        Me.btnPoShipping.Text = "PO Shipping"
        Me.btnPoShipping.UseVisualStyleBackColor = True
        '
        'frmDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 360)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblDefinition)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvDefinitions)
        Me.MaximumSize = New System.Drawing.Size(706, 398)
        Me.Name = "frmDefinitions"
        Me.Text = "frmDefinitions"
        CType(Me.dgvDefinitions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgvDefinitions As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblDefinition As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnAccountType As System.Windows.Forms.Button
    Friend WithEvents btnPoShipping As System.Windows.Forms.Button
    Friend WithEvents btnPoTerms As System.Windows.Forms.Button
    Friend WithEvents btnSalutation As System.Windows.Forms.Button
End Class
