<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtVAT_Number = New System.Windows.Forms.TextBox()
        Me.txtAddressID = New System.Windows.Forms.TextBox()
        Me.txtContactID = New System.Windows.Forms.TextBox()
        Me.txtMerchantID = New System.Windows.Forms.TextBox()
        Me.txtReceiptID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkVAT = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Company Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Class Customer Testing"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(128, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(125, 20)
        Me.txtID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Company ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(438, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Create new or update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 93)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(416, 20)
        Me.txtName.TabIndex = 6
        '
        'txtVAT_Number
        '
        Me.txtVAT_Number.Location = New System.Drawing.Point(128, 119)
        Me.txtVAT_Number.Name = "txtVAT_Number"
        Me.txtVAT_Number.Size = New System.Drawing.Size(190, 20)
        Me.txtVAT_Number.TabIndex = 7
        '
        'txtAddressID
        '
        Me.txtAddressID.Location = New System.Drawing.Point(128, 145)
        Me.txtAddressID.Name = "txtAddressID"
        Me.txtAddressID.Size = New System.Drawing.Size(65, 20)
        Me.txtAddressID.TabIndex = 8
        '
        'txtContactID
        '
        Me.txtContactID.Location = New System.Drawing.Point(128, 171)
        Me.txtContactID.Name = "txtContactID"
        Me.txtContactID.Size = New System.Drawing.Size(65, 20)
        Me.txtContactID.TabIndex = 9
        '
        'txtMerchantID
        '
        Me.txtMerchantID.Location = New System.Drawing.Point(128, 197)
        Me.txtMerchantID.Name = "txtMerchantID"
        Me.txtMerchantID.Size = New System.Drawing.Size(65, 20)
        Me.txtMerchantID.TabIndex = 10
        '
        'txtReceiptID
        '
        Me.txtReceiptID.Location = New System.Drawing.Point(128, 223)
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Size = New System.Drawing.Size(65, 20)
        Me.txtReceiptID.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Company Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "VAT Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Address ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Contact ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Merchant ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Receipt ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "VAT Registered"
        '
        'chkVAT
        '
        Me.chkVAT.AutoSize = True
        Me.chkVAT.Location = New System.Drawing.Point(128, 256)
        Me.chkVAT.Name = "chkVAT"
        Me.chkVAT.Size = New System.Drawing.Size(15, 14)
        Me.chkVAT.TabIndex = 20
        Me.chkVAT.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 387)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 33)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Test Invoice class"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(290, 188)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(267, 173)
        Me.ListBox1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 441)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chkVAT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReceiptID)
        Me.Controls.Add(Me.txtMerchantID)
        Me.Controls.Add(Me.txtContactID)
        Me.Controls.Add(Me.txtAddressID)
        Me.Controls.Add(Me.txtVAT_Number)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Test Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT_Number As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressID As System.Windows.Forms.TextBox
    Friend WithEvents txtContactID As System.Windows.Forms.TextBox
    Friend WithEvents txtMerchantID As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiptID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkVAT As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
