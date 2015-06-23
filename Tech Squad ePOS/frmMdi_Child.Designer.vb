<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdi_Child
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
        Me.lblParentMessage = New System.Windows.Forms.Label()
        Me.txtMessageToParent = New System.Windows.Forms.TextBox()
        Me.btnMessageParent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblParentMessage
        '
        Me.lblParentMessage.AutoSize = True
        Me.lblParentMessage.Location = New System.Drawing.Point(13, 24)
        Me.lblParentMessage.Name = "lblParentMessage"
        Me.lblParentMessage.Size = New System.Drawing.Size(39, 13)
        Me.lblParentMessage.TabIndex = 0
        Me.lblParentMessage.Text = "Label1"
        '
        'txtMessageToParent
        '
        Me.txtMessageToParent.Location = New System.Drawing.Point(16, 64)
        Me.txtMessageToParent.Name = "txtMessageToParent"
        Me.txtMessageToParent.Size = New System.Drawing.Size(256, 20)
        Me.txtMessageToParent.TabIndex = 1
        '
        'btnMessageParent
        '
        Me.btnMessageParent.Location = New System.Drawing.Point(16, 107)
        Me.btnMessageParent.Name = "btnMessageParent"
        Me.btnMessageParent.Size = New System.Drawing.Size(256, 55)
        Me.btnMessageParent.TabIndex = 2
        Me.btnMessageParent.Text = "Send Message to Parent"
        Me.btnMessageParent.UseVisualStyleBackColor = True
        '
        'frmMdi_Child
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMessageParent)
        Me.Controls.Add(Me.txtMessageToParent)
        Me.Controls.Add(Me.lblParentMessage)
        Me.Name = "frmMdi_Child"
        Me.Text = "frmMdi_Child"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblParentMessage As System.Windows.Forms.Label
    Friend WithEvents txtMessageToParent As System.Windows.Forms.TextBox
    Friend WithEvents btnMessageParent As System.Windows.Forms.Button
End Class
