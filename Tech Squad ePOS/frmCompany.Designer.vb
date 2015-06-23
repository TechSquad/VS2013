<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompany))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpCompany = New System.Windows.Forms.GroupBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtTradingName = New System.Windows.Forms.TextBox()
        Me.txtCoName = New System.Windows.Forms.TextBox()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblAdd2 = New System.Windows.Forms.Label()
        Me.lblAdd1 = New System.Windows.Forms.Label()
        Me.lblTradingName = New System.Windows.Forms.Label()
        Me.lblCoName = New System.Windows.Forms.Label()
        Me.tabboxCompanyInfo = New System.Windows.Forms.TabControl()
        Me.tabCompanyInfo = New System.Windows.Forms.TabPage()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.tabTaxInfo = New System.Windows.Forms.TabPage()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.lblVatNo = New System.Windows.Forms.Label()
        Me.tabMerchantInfo = New System.Windows.Forms.TabPage()
        Me.txtTerminal = New System.Windows.Forms.TextBox()
        Me.txtHelpline = New System.Windows.Forms.TextBox()
        Me.txtMerchantNo = New System.Windows.Forms.TextBox()
        Me.lblMerchantNo = New System.Windows.Forms.Label()
        Me.lblHelpPhone = New System.Windows.Forms.Label()
        Me.lblTerminal = New System.Windows.Forms.Label()
        Me.tabReceipt = New System.Windows.Forms.TabPage()
        Me.txtReceiptFooter = New System.Windows.Forms.TextBox()
        Me.txtReceiptHeader = New System.Windows.Forms.TextBox()
        Me.lblReceiptHeader = New System.Windows.Forms.Label()
        Me.lblReceiptFooter = New System.Windows.Forms.Label()
        Me.grpCompany.SuspendLayout()
        Me.tabboxCompanyInfo.SuspendLayout()
        Me.tabCompanyInfo.SuspendLayout()
        Me.tabTaxInfo.SuspendLayout()
        Me.tabMerchantInfo.SuspendLayout()
        Me.tabReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(473, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(383, 13)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(84, 35)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpCompany
        '
        Me.grpCompany.Controls.Add(Me.txtPostcode)
        Me.grpCompany.Controls.Add(Me.txtCity)
        Me.grpCompany.Controls.Add(Me.txtTown)
        Me.grpCompany.Controls.Add(Me.txtAdd2)
        Me.grpCompany.Controls.Add(Me.txtAdd1)
        Me.grpCompany.Controls.Add(Me.txtTradingName)
        Me.grpCompany.Controls.Add(Me.txtCoName)
        Me.grpCompany.Controls.Add(Me.lblPostcode)
        Me.grpCompany.Controls.Add(Me.lblCity)
        Me.grpCompany.Controls.Add(Me.lblTown)
        Me.grpCompany.Controls.Add(Me.lblAdd2)
        Me.grpCompany.Controls.Add(Me.lblAdd1)
        Me.grpCompany.Controls.Add(Me.lblTradingName)
        Me.grpCompany.Controls.Add(Me.lblCoName)
        Me.grpCompany.Location = New System.Drawing.Point(12, 63)
        Me.grpCompany.Name = "grpCompany"
        Me.grpCompany.Size = New System.Drawing.Size(396, 240)
        Me.grpCompany.TabIndex = 2
        Me.grpCompany.TabStop = False
        Me.grpCompany.Text = "Company Details"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(116, 192)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(143, 20)
        Me.txtPostcode.TabIndex = 18
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(116, 164)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(254, 20)
        Me.txtCity.TabIndex = 17
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(116, 136)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(254, 20)
        Me.txtTown.TabIndex = 16
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(116, 109)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(254, 20)
        Me.txtAdd2.TabIndex = 15
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(116, 82)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(254, 20)
        Me.txtAdd1.TabIndex = 14
        '
        'txtTradingName
        '
        Me.txtTradingName.Location = New System.Drawing.Point(116, 56)
        Me.txtTradingName.Name = "txtTradingName"
        Me.txtTradingName.Size = New System.Drawing.Size(254, 20)
        Me.txtTradingName.TabIndex = 13
        '
        'txtCoName
        '
        Me.txtCoName.Location = New System.Drawing.Point(116, 30)
        Me.txtCoName.Name = "txtCoName"
        Me.txtCoName.Size = New System.Drawing.Size(254, 20)
        Me.txtCoName.TabIndex = 12
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(21, 195)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(52, 13)
        Me.lblPostcode.TabIndex = 7
        Me.lblPostcode.Text = "Postcode"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(22, 164)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(21, 136)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(34, 13)
        Me.lblTown.TabIndex = 5
        Me.lblTown.Text = "Town"
        '
        'lblAdd2
        '
        Me.lblAdd2.AutoSize = True
        Me.lblAdd2.Location = New System.Drawing.Point(22, 113)
        Me.lblAdd2.Name = "lblAdd2"
        Me.lblAdd2.Size = New System.Drawing.Size(54, 13)
        Me.lblAdd2.TabIndex = 4
        Me.lblAdd2.Text = "Address 2"
        '
        'lblAdd1
        '
        Me.lblAdd1.AutoSize = True
        Me.lblAdd1.Location = New System.Drawing.Point(22, 87)
        Me.lblAdd1.Name = "lblAdd1"
        Me.lblAdd1.Size = New System.Drawing.Size(54, 13)
        Me.lblAdd1.TabIndex = 3
        Me.lblAdd1.Text = "Address 1"
        '
        'lblTradingName
        '
        Me.lblTradingName.AutoSize = True
        Me.lblTradingName.Location = New System.Drawing.Point(22, 60)
        Me.lblTradingName.Name = "lblTradingName"
        Me.lblTradingName.Size = New System.Drawing.Size(26, 13)
        Me.lblTradingName.TabIndex = 2
        Me.lblTradingName.Text = "T/A"
        '
        'lblCoName
        '
        Me.lblCoName.AutoSize = True
        Me.lblCoName.Location = New System.Drawing.Point(22, 30)
        Me.lblCoName.Name = "lblCoName"
        Me.lblCoName.Size = New System.Drawing.Size(35, 13)
        Me.lblCoName.TabIndex = 1
        Me.lblCoName.Text = "Name"
        '
        'tabboxCompanyInfo
        '
        Me.tabboxCompanyInfo.Controls.Add(Me.tabCompanyInfo)
        Me.tabboxCompanyInfo.Controls.Add(Me.tabTaxInfo)
        Me.tabboxCompanyInfo.Controls.Add(Me.tabMerchantInfo)
        Me.tabboxCompanyInfo.Controls.Add(Me.tabReceipt)
        Me.tabboxCompanyInfo.Location = New System.Drawing.Point(13, 310)
        Me.tabboxCompanyInfo.Name = "tabboxCompanyInfo"
        Me.tabboxCompanyInfo.SelectedIndex = 0
        Me.tabboxCompanyInfo.Size = New System.Drawing.Size(551, 172)
        Me.tabboxCompanyInfo.TabIndex = 3
        '
        'tabCompanyInfo
        '
        Me.tabCompanyInfo.Controls.Add(Me.txtWeb)
        Me.tabCompanyInfo.Controls.Add(Me.txtEmail)
        Me.tabCompanyInfo.Controls.Add(Me.txtPhone)
        Me.tabCompanyInfo.Controls.Add(Me.lblPhone)
        Me.tabCompanyInfo.Controls.Add(Me.lblEmail)
        Me.tabCompanyInfo.Controls.Add(Me.lblWeb)
        Me.tabCompanyInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabCompanyInfo.Name = "tabCompanyInfo"
        Me.tabCompanyInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompanyInfo.Size = New System.Drawing.Size(543, 146)
        Me.tabCompanyInfo.TabIndex = 2
        Me.tabCompanyInfo.Text = "Company Info"
        Me.tabCompanyInfo.UseVisualStyleBackColor = True
        '
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(111, 77)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(163, 20)
        Me.txtWeb.TabIndex = 17
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(111, 51)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(163, 20)
        Me.txtEmail.TabIndex = 16
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(111, 25)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(163, 20)
        Me.txtPhone.TabIndex = 15
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(17, 25)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 55)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Location = New System.Drawing.Point(17, 83)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(71, 13)
        Me.lblWeb.TabIndex = 10
        Me.lblWeb.Text = "Web Address"
        '
        'tabTaxInfo
        '
        Me.tabTaxInfo.Controls.Add(Me.txtVAT)
        Me.tabTaxInfo.Controls.Add(Me.lblVatNo)
        Me.tabTaxInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabTaxInfo.Name = "tabTaxInfo"
        Me.tabTaxInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTaxInfo.Size = New System.Drawing.Size(543, 146)
        Me.tabTaxInfo.TabIndex = 0
        Me.tabTaxInfo.Text = "Tax Info"
        Me.tabTaxInfo.UseVisualStyleBackColor = True
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(96, 23)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(163, 20)
        Me.txtVAT.TabIndex = 13
        '
        'lblVatNo
        '
        Me.lblVatNo.AutoSize = True
        Me.lblVatNo.Location = New System.Drawing.Point(2, 23)
        Me.lblVatNo.Name = "lblVatNo"
        Me.lblVatNo.Size = New System.Drawing.Size(68, 13)
        Me.lblVatNo.TabIndex = 12
        Me.lblVatNo.Text = "VAT Number"
        '
        'tabMerchantInfo
        '
        Me.tabMerchantInfo.Controls.Add(Me.txtTerminal)
        Me.tabMerchantInfo.Controls.Add(Me.txtHelpline)
        Me.tabMerchantInfo.Controls.Add(Me.txtMerchantNo)
        Me.tabMerchantInfo.Controls.Add(Me.lblMerchantNo)
        Me.tabMerchantInfo.Controls.Add(Me.lblHelpPhone)
        Me.tabMerchantInfo.Controls.Add(Me.lblTerminal)
        Me.tabMerchantInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabMerchantInfo.Name = "tabMerchantInfo"
        Me.tabMerchantInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMerchantInfo.Size = New System.Drawing.Size(543, 146)
        Me.tabMerchantInfo.TabIndex = 1
        Me.tabMerchantInfo.Text = "Merchant Info"
        Me.tabMerchantInfo.UseVisualStyleBackColor = True
        '
        'txtTerminal
        '
        Me.txtTerminal.Location = New System.Drawing.Point(111, 80)
        Me.txtTerminal.Name = "txtTerminal"
        Me.txtTerminal.Size = New System.Drawing.Size(163, 20)
        Me.txtTerminal.TabIndex = 23
        '
        'txtHelpline
        '
        Me.txtHelpline.Location = New System.Drawing.Point(111, 54)
        Me.txtHelpline.Name = "txtHelpline"
        Me.txtHelpline.Size = New System.Drawing.Size(163, 20)
        Me.txtHelpline.TabIndex = 22
        '
        'txtMerchantNo
        '
        Me.txtMerchantNo.Location = New System.Drawing.Point(111, 28)
        Me.txtMerchantNo.Name = "txtMerchantNo"
        Me.txtMerchantNo.Size = New System.Drawing.Size(163, 20)
        Me.txtMerchantNo.TabIndex = 21
        '
        'lblMerchantNo
        '
        Me.lblMerchantNo.AutoSize = True
        Me.lblMerchantNo.Location = New System.Drawing.Point(17, 28)
        Me.lblMerchantNo.Name = "lblMerchantNo"
        Me.lblMerchantNo.Size = New System.Drawing.Size(92, 13)
        Me.lblMerchantNo.TabIndex = 18
        Me.lblMerchantNo.Text = "Merchant Number"
        '
        'lblHelpPhone
        '
        Me.lblHelpPhone.AutoSize = True
        Me.lblHelpPhone.Location = New System.Drawing.Point(17, 58)
        Me.lblHelpPhone.Name = "lblHelpPhone"
        Me.lblHelpPhone.Size = New System.Drawing.Size(45, 13)
        Me.lblHelpPhone.TabIndex = 19
        Me.lblHelpPhone.Text = "Helpline"
        '
        'lblTerminal
        '
        Me.lblTerminal.AutoSize = True
        Me.lblTerminal.Location = New System.Drawing.Point(17, 86)
        Me.lblTerminal.Name = "lblTerminal"
        Me.lblTerminal.Size = New System.Drawing.Size(47, 13)
        Me.lblTerminal.TabIndex = 20
        Me.lblTerminal.Text = "Terminal"
        '
        'tabReceipt
        '
        Me.tabReceipt.Controls.Add(Me.txtReceiptFooter)
        Me.tabReceipt.Controls.Add(Me.txtReceiptHeader)
        Me.tabReceipt.Controls.Add(Me.lblReceiptHeader)
        Me.tabReceipt.Controls.Add(Me.lblReceiptFooter)
        Me.tabReceipt.Location = New System.Drawing.Point(4, 22)
        Me.tabReceipt.Name = "tabReceipt"
        Me.tabReceipt.Size = New System.Drawing.Size(543, 146)
        Me.tabReceipt.TabIndex = 3
        Me.tabReceipt.Text = "Receipt"
        Me.tabReceipt.UseVisualStyleBackColor = True
        '
        'txtReceiptFooter
        '
        Me.txtReceiptFooter.Location = New System.Drawing.Point(111, 75)
        Me.txtReceiptFooter.Multiline = True
        Me.txtReceiptFooter.Name = "txtReceiptFooter"
        Me.txtReceiptFooter.Size = New System.Drawing.Size(410, 40)
        Me.txtReceiptFooter.TabIndex = 26
        '
        'txtReceiptHeader
        '
        Me.txtReceiptHeader.Location = New System.Drawing.Point(111, 27)
        Me.txtReceiptHeader.Multiline = True
        Me.txtReceiptHeader.Name = "txtReceiptHeader"
        Me.txtReceiptHeader.Size = New System.Drawing.Size(410, 40)
        Me.txtReceiptHeader.TabIndex = 25
        '
        'lblReceiptHeader
        '
        Me.lblReceiptHeader.AutoSize = True
        Me.lblReceiptHeader.Location = New System.Drawing.Point(17, 27)
        Me.lblReceiptHeader.Name = "lblReceiptHeader"
        Me.lblReceiptHeader.Size = New System.Drawing.Size(82, 13)
        Me.lblReceiptHeader.TabIndex = 23
        Me.lblReceiptHeader.Text = "Receipt Header"
        '
        'lblReceiptFooter
        '
        Me.lblReceiptFooter.AutoSize = True
        Me.lblReceiptFooter.Location = New System.Drawing.Point(17, 79)
        Me.lblReceiptFooter.Name = "lblReceiptFooter"
        Me.lblReceiptFooter.Size = New System.Drawing.Size(77, 13)
        Me.lblReceiptFooter.TabIndex = 24
        Me.lblReceiptFooter.Text = "Receipt Footer"
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 494)
        Me.Controls.Add(Me.tabboxCompanyInfo)
        Me.Controls.Add(Me.grpCompany)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnExit)
        Me.MaximumSize = New System.Drawing.Size(592, 532)
        Me.Name = "frmCompany"
        Me.Text = "frmCompany"
        Me.grpCompany.ResumeLayout(False)
        Me.grpCompany.PerformLayout()
        Me.tabboxCompanyInfo.ResumeLayout(False)
        Me.tabCompanyInfo.ResumeLayout(False)
        Me.tabCompanyInfo.PerformLayout()
        Me.tabTaxInfo.ResumeLayout(False)
        Me.tabTaxInfo.PerformLayout()
        Me.tabMerchantInfo.ResumeLayout(False)
        Me.tabMerchantInfo.PerformLayout()
        Me.tabReceipt.ResumeLayout(False)
        Me.tabReceipt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpCompany As System.Windows.Forms.GroupBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTradingName As System.Windows.Forms.TextBox
    Friend WithEvents txtCoName As System.Windows.Forms.TextBox
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAdd2 As System.Windows.Forms.Label
    Friend WithEvents lblAdd1 As System.Windows.Forms.Label
    Friend WithEvents lblTradingName As System.Windows.Forms.Label
    Friend WithEvents lblCoName As System.Windows.Forms.Label
    Friend WithEvents tabboxCompanyInfo As System.Windows.Forms.TabControl
    Friend WithEvents tabCompanyInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents tabTaxInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents lblVatNo As System.Windows.Forms.Label
    Friend WithEvents tabMerchantInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtTerminal As System.Windows.Forms.TextBox
    Friend WithEvents txtHelpline As System.Windows.Forms.TextBox
    Friend WithEvents txtMerchantNo As System.Windows.Forms.TextBox
    Friend WithEvents lblMerchantNo As System.Windows.Forms.Label
    Friend WithEvents lblHelpPhone As System.Windows.Forms.Label
    Friend WithEvents lblTerminal As System.Windows.Forms.Label
    Friend WithEvents tabReceipt As System.Windows.Forms.TabPage
    Friend WithEvents txtReceiptFooter As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiptHeader As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiptHeader As System.Windows.Forms.Label
    Friend WithEvents lblReceiptFooter As System.Windows.Forms.Label
End Class
