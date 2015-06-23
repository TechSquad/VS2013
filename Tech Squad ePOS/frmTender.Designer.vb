<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTender
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
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstPayments = New System.Windows.Forms.ListBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.txtTotalDue = New System.Windows.Forms.TextBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblPaymentsBreakdown = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtBalanceDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceDue.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtBalanceDue.Location = New System.Drawing.Point(357, 103)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBalanceDue.Size = New System.Drawing.Size(232, 49)
        Me.txtBalanceDue.TabIndex = 0
        Me.txtBalanceDue.Text = "0.00"
        '
        'lblBalanceDue
        '
        Me.lblBalanceDue.AutoSize = True
        Me.lblBalanceDue.Location = New System.Drawing.Point(354, 87)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(69, 13)
        Me.lblBalanceDue.TabIndex = 1
        Me.lblBalanceDue.Text = "Balance Due"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(25, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 431)
        Me.Panel1.TabIndex = 8
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(3, 298)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 53)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Amex"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(3, 239)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 53)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Mastercard"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(3, 180)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 53)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Visa Credit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 53)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Visa Debit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 53)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cheque"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cash"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstPayments
        '
        Me.lstPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPayments.FormattingEnabled = True
        Me.lstPayments.ItemHeight = 24
        Me.lstPayments.Location = New System.Drawing.Point(357, 243)
        Me.lstPayments.Name = "lstPayments"
        Me.lstPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstPayments.Size = New System.Drawing.Size(232, 172)
        Me.lstPayments.TabIndex = 5
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(354, 453)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(54, 13)
        Me.lblTotalDue.TabIndex = 10
        Me.lblTotalDue.Text = "Total Due"
        '
        'txtTotalDue
        '
        Me.txtTotalDue.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtTotalDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDue.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtTotalDue.Location = New System.Drawing.Point(357, 469)
        Me.txtTotalDue.Name = "txtTotalDue"
        Me.txtTotalDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalDue.Size = New System.Drawing.Size(232, 49)
        Me.txtTotalDue.TabIndex = 9
        Me.txtTotalDue.Text = "0.00"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(354, 157)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(76, 13)
        Me.lblPayment.TabIndex = 12
        Me.lblPayment.Text = "Enter Payment"
        Me.lblPayment.Visible = False
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtPayment.Location = New System.Drawing.Point(357, 173)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPayment.Size = New System.Drawing.Size(232, 49)
        Me.txtPayment.TabIndex = 11
        Me.txtPayment.Text = "0.00"
        Me.txtPayment.Visible = False
        '
        'lblPaymentsBreakdown
        '
        Me.lblPaymentsBreakdown.AutoSize = True
        Me.lblPaymentsBreakdown.Location = New System.Drawing.Point(354, 228)
        Me.lblPaymentsBreakdown.Name = "lblPaymentsBreakdown"
        Me.lblPaymentsBreakdown.Size = New System.Drawing.Size(105, 13)
        Me.lblPaymentsBreakdown.TabIndex = 13
        Me.lblPaymentsBreakdown.Text = "Payment Breakdown"
        '
        'frmTender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 543)
        Me.Controls.Add(Me.lblPaymentsBreakdown)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.txtTotalDue)
        Me.Controls.Add(Me.lstPayments)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblBalanceDue)
        Me.Controls.Add(Me.txtBalanceDue)
        Me.Name = "frmTender"
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBalanceDue As System.Windows.Forms.TextBox
    Friend WithEvents lblBalanceDue As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstPayments As System.Windows.Forms.ListBox
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents txtTotalDue As System.Windows.Forms.TextBox
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentsBreakdown As System.Windows.Forms.Label
End Class
