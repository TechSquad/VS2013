<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMySqlTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMySqlTools))
        Me.dgvTableContent = New System.Windows.Forms.DataGridView()
        Me.dgvTableList = New System.Windows.Forms.DataGridView()
        Me.btnEmptyTable = New System.Windows.Forms.Button()
        CType(Me.dgvTableContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTableList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTableContent
        '
        Me.dgvTableContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTableContent.Location = New System.Drawing.Point(297, 5)
        Me.dgvTableContent.Name = "dgvTableContent"
        Me.dgvTableContent.Size = New System.Drawing.Size(1094, 392)
        Me.dgvTableContent.TabIndex = 0
        '
        'dgvTableList
        '
        Me.dgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTableList.Location = New System.Drawing.Point(12, 5)
        Me.dgvTableList.Name = "dgvTableList"
        Me.dgvTableList.Size = New System.Drawing.Size(265, 447)
        Me.dgvTableList.TabIndex = 3
        '
        'btnEmptyTable
        '
        Me.btnEmptyTable.Image = CType(resources.GetObject("btnEmptyTable.Image"), System.Drawing.Image)
        Me.btnEmptyTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmptyTable.Location = New System.Drawing.Point(1183, 403)
        Me.btnEmptyTable.Name = "btnEmptyTable"
        Me.btnEmptyTable.Size = New System.Drawing.Size(208, 49)
        Me.btnEmptyTable.TabIndex = 5
        Me.btnEmptyTable.Text = "Flush Records from Table"
        Me.btnEmptyTable.UseVisualStyleBackColor = True
        '
        'frmMySqlTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1403, 464)
        Me.Controls.Add(Me.btnEmptyTable)
        Me.Controls.Add(Me.dgvTableList)
        Me.Controls.Add(Me.dgvTableContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMySqlTools"
        Me.Text = "frmMySqlTools"
        CType(Me.dgvTableContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTableList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvTableContent As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTableList As System.Windows.Forms.DataGridView
    Friend WithEvents btnEmptyTable As System.Windows.Forms.Button
End Class
