<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryMenu
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.btnFindNode = New System.Windows.Forms.Button()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(320, 583)
        Me.TreeView1.TabIndex = 0
        '
        'dgvCategories
        '
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.Location = New System.Drawing.Point(339, 13)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.Size = New System.Drawing.Size(1006, 582)
        Me.dgvCategories.TabIndex = 1
        '
        'btnFindNode
        '
        Me.btnFindNode.Location = New System.Drawing.Point(381, 611)
        Me.btnFindNode.Name = "btnFindNode"
        Me.btnFindNode.Size = New System.Drawing.Size(75, 23)
        Me.btnFindNode.TabIndex = 2
        Me.btnFindNode.Text = "Find Node"
        Me.btnFindNode.UseVisualStyleBackColor = True
        '
        'frmCategoryMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 646)
        Me.Controls.Add(Me.btnFindNode)
        Me.Controls.Add(Me.dgvCategories)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frmCategoryMenu"
        Me.Text = "frmCategoryMenu"
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents dgvCategories As System.Windows.Forms.DataGridView
    Friend WithEvents btnFindNode As System.Windows.Forms.Button
End Class
