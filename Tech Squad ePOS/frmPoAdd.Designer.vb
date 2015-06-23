<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoAdd))
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtSupplierInfo = New System.Windows.Forms.TextBox()
        Me.grpPurchaseOrder = New System.Windows.Forms.GroupBox()
        Me.lblShipToId = New System.Windows.Forms.Label()
        Me.btnChangeShipTo = New System.Windows.Forms.Button()
        Me.lblShipTo = New System.Windows.Forms.Label()
        Me.txtShipTo = New System.Windows.Forms.TextBox()
        Me.cbTerms = New System.Windows.Forms.ComboBox()
        Me.cbShipping = New System.Windows.Forms.ComboBox()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblPoNumber = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpPurchaseOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbSupplier
        '
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(94, 16)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(151, 21)
        Me.cbSupplier.TabIndex = 0
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(13, 19)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(78, 13)
        Me.lblSupplier.TabIndex = 1
        Me.lblSupplier.Text = "Select Supplier"
        '
        'txtSupplierInfo
        '
        Me.txtSupplierInfo.Enabled = False
        Me.txtSupplierInfo.Location = New System.Drawing.Point(279, 19)
        Me.txtSupplierInfo.Multiline = True
        Me.txtSupplierInfo.Name = "txtSupplierInfo"
        Me.txtSupplierInfo.Size = New System.Drawing.Size(312, 101)
        Me.txtSupplierInfo.TabIndex = 2
        '
        'grpPurchaseOrder
        '
        Me.grpPurchaseOrder.Controls.Add(Me.lblShipToId)
        Me.grpPurchaseOrder.Controls.Add(Me.btnChangeShipTo)
        Me.grpPurchaseOrder.Controls.Add(Me.lblShipTo)
        Me.grpPurchaseOrder.Controls.Add(Me.txtShipTo)
        Me.grpPurchaseOrder.Controls.Add(Me.cbTerms)
        Me.grpPurchaseOrder.Controls.Add(Me.cbShipping)
        Me.grpPurchaseOrder.Controls.Add(Me.txtPoNo)
        Me.grpPurchaseOrder.Controls.Add(Me.lblTerms)
        Me.grpPurchaseOrder.Controls.Add(Me.lblShipping)
        Me.grpPurchaseOrder.Controls.Add(Me.lblPoNumber)
        Me.grpPurchaseOrder.Location = New System.Drawing.Point(13, 138)
        Me.grpPurchaseOrder.Name = "grpPurchaseOrder"
        Me.grpPurchaseOrder.Size = New System.Drawing.Size(609, 230)
        Me.grpPurchaseOrder.TabIndex = 3
        Me.grpPurchaseOrder.TabStop = False
        Me.grpPurchaseOrder.Text = "Purchase Order"
        '
        'lblShipToId
        '
        Me.lblShipToId.AutoSize = True
        Me.lblShipToId.Location = New System.Drawing.Point(17, 141)
        Me.lblShipToId.Name = "lblShipToId"
        Me.lblShipToId.Size = New System.Drawing.Size(60, 13)
        Me.lblShipToId.TabIndex = 18
        Me.lblShipToId.Text = "lblShipToId"
        Me.lblShipToId.Visible = False
        '
        'btnChangeShipTo
        '
        Me.btnChangeShipTo.Location = New System.Drawing.Point(436, 179)
        Me.btnChangeShipTo.Name = "btnChangeShipTo"
        Me.btnChangeShipTo.Size = New System.Drawing.Size(126, 40)
        Me.btnChangeShipTo.TabIndex = 17
        Me.btnChangeShipTo.Text = "Change Ship To"
        Me.btnChangeShipTo.UseVisualStyleBackColor = True
        '
        'lblShipTo
        '
        Me.lblShipTo.AutoSize = True
        Me.lblShipTo.Location = New System.Drawing.Point(14, 124)
        Me.lblShipTo.Name = "lblShipTo"
        Me.lblShipTo.Size = New System.Drawing.Size(44, 13)
        Me.lblShipTo.TabIndex = 16
        Me.lblShipTo.Text = "Ship To"
        '
        'txtShipTo
        '
        Me.txtShipTo.Enabled = False
        Me.txtShipTo.Location = New System.Drawing.Point(106, 118)
        Me.txtShipTo.Multiline = True
        Me.txtShipTo.Name = "txtShipTo"
        Me.txtShipTo.Size = New System.Drawing.Size(312, 101)
        Me.txtShipTo.TabIndex = 15
        '
        'cbTerms
        '
        Me.cbTerms.FormattingEnabled = True
        Me.cbTerms.Location = New System.Drawing.Point(106, 91)
        Me.cbTerms.Name = "cbTerms"
        Me.cbTerms.Size = New System.Drawing.Size(165, 21)
        Me.cbTerms.TabIndex = 14
        '
        'cbShipping
        '
        Me.cbShipping.FormattingEnabled = True
        Me.cbShipping.Location = New System.Drawing.Point(106, 61)
        Me.cbShipping.Name = "cbShipping"
        Me.cbShipping.Size = New System.Drawing.Size(165, 21)
        Me.cbShipping.TabIndex = 13
        '
        'txtPoNo
        '
        Me.txtPoNo.Location = New System.Drawing.Point(106, 35)
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(165, 20)
        Me.txtPoNo.TabIndex = 12
        '
        'lblTerms
        '
        Me.lblTerms.AutoSize = True
        Me.lblTerms.Location = New System.Drawing.Point(14, 94)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(36, 13)
        Me.lblTerms.TabIndex = 11
        Me.lblTerms.Text = "Terms"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(14, 61)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(48, 13)
        Me.lblShipping.TabIndex = 10
        Me.lblShipping.Text = "Shipping"
        '
        'lblPoNumber
        '
        Me.lblPoNumber.AutoSize = True
        Me.lblPoNumber.Location = New System.Drawing.Point(14, 35)
        Me.lblPoNumber.Name = "lblPoNumber"
        Me.lblPoNumber.Size = New System.Drawing.Size(62, 13)
        Me.lblPoNumber.TabIndex = 9
        Me.lblPoNumber.Text = "PO Number"
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(364, 382)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(126, 40)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(496, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 40)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 434)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpPurchaseOrder)
        Me.Controls.Add(Me.txtSupplierInfo)
        Me.Controls.Add(Me.lblSupplier)
        Me.Controls.Add(Me.cbSupplier)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(650, 472)
        Me.Name = "frmPoAdd"
        Me.Text = "Add New Purchase Order"
        Me.grpPurchaseOrder.ResumeLayout(False)
        Me.grpPurchaseOrder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSupplierInfo As System.Windows.Forms.TextBox
    Friend WithEvents grpPurchaseOrder As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangeShipTo As System.Windows.Forms.Button
    Friend WithEvents lblShipTo As System.Windows.Forms.Label
    Friend WithEvents txtShipTo As System.Windows.Forms.TextBox
    Friend WithEvents cbTerms As System.Windows.Forms.ComboBox
    Friend WithEvents cbShipping As System.Windows.Forms.ComboBox
    Friend WithEvents txtPoNo As System.Windows.Forms.TextBox
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblPoNumber As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblShipToId As System.Windows.Forms.Label
End Class
