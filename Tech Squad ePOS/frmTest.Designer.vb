<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblRowNo = New System.Windows.Forms.Label()
        Me.txtRowNo = New System.Windows.Forms.TextBox()
        Me.btnRowSelect = New System.Windows.Forms.Button()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.txtRowCount = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 38)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(842, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'lblRowNo
        '
        Me.lblRowNo.AutoSize = True
        Me.lblRowNo.Location = New System.Drawing.Point(27, 315)
        Me.lblRowNo.Name = "lblRowNo"
        Me.lblRowNo.Size = New System.Drawing.Size(69, 13)
        Me.lblRowNo.TabIndex = 1
        Me.lblRowNo.Text = "Row Number"
        '
        'txtRowNo
        '
        Me.txtRowNo.Location = New System.Drawing.Point(114, 315)
        Me.txtRowNo.Name = "txtRowNo"
        Me.txtRowNo.Size = New System.Drawing.Size(100, 20)
        Me.txtRowNo.TabIndex = 2
        '
        'btnRowSelect
        '
        Me.btnRowSelect.Location = New System.Drawing.Point(609, 304)
        Me.btnRowSelect.Name = "btnRowSelect"
        Me.btnRowSelect.Size = New System.Drawing.Size(203, 53)
        Me.btnRowSelect.TabIndex = 3
        Me.btnRowSelect.Text = "Select Row"
        Me.btnRowSelect.UseVisualStyleBackColor = True
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Location = New System.Drawing.Point(27, 350)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(60, 13)
        Me.lblRowCount.TabIndex = 4
        Me.lblRowCount.Text = "Row Count"
        '
        'txtRowCount
        '
        Me.txtRowCount.Location = New System.Drawing.Point(114, 350)
        Me.txtRowCount.Name = "txtRowCount"
        Me.txtRowCount.Size = New System.Drawing.Size(100, 20)
        Me.txtRowCount.TabIndex = 5
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 422)
        Me.Controls.Add(Me.txtRowCount)
        Me.Controls.Add(Me.lblRowCount)
        Me.Controls.Add(Me.btnRowSelect)
        Me.Controls.Add(Me.txtRowNo)
        Me.Controls.Add(Me.lblRowNo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblRowNo As System.Windows.Forms.Label
    Friend WithEvents txtRowNo As System.Windows.Forms.TextBox
    Friend WithEvents btnRowSelect As System.Windows.Forms.Button
    Friend WithEvents lblRowCount As System.Windows.Forms.Label
    Friend WithEvents txtRowCount As System.Windows.Forms.TextBox
End Class
