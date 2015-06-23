<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoItem))
        Me.grpItem = New System.Windows.Forms.GroupBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSku = New System.Windows.Forms.TextBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblSku = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.nudWeight = New System.Windows.Forms.NumericUpDown()
        Me.nudTotal = New System.Windows.Forms.NumericUpDown()
        Me.nudCost = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpItem.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpItem
        '
        Me.grpItem.Controls.Add(Me.txtBarcode)
        Me.grpItem.Controls.Add(Me.txtDescription)
        Me.grpItem.Controls.Add(Me.txtSku)
        Me.grpItem.Controls.Add(Me.lblBarcode)
        Me.grpItem.Controls.Add(Me.lblDescription)
        Me.grpItem.Controls.Add(Me.lblSku)
        Me.grpItem.Location = New System.Drawing.Point(13, 13)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(645, 120)
        Me.grpItem.TabIndex = 0
        Me.grpItem.TabStop = False
        Me.grpItem.Text = "Item"
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Location = New System.Drawing.Point(130, 79)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(494, 20)
        Me.txtBarcode.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(130, 50)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(494, 20)
        Me.txtDescription.TabIndex = 4
        '
        'txtSku
        '
        Me.txtSku.Enabled = False
        Me.txtSku.Location = New System.Drawing.Point(130, 20)
        Me.txtSku.Name = "txtSku"
        Me.txtSku.Size = New System.Drawing.Size(494, 20)
        Me.txtSku.TabIndex = 3
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Location = New System.Drawing.Point(7, 82)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(47, 13)
        Me.lblBarcode.TabIndex = 2
        Me.lblBarcode.Text = "Barcode"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(7, 50)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description"
        '
        'lblSku
        '
        Me.lblSku.AutoSize = True
        Me.lblSku.Location = New System.Drawing.Point(7, 20)
        Me.lblSku.Name = "lblSku"
        Me.lblSku.Size = New System.Drawing.Size(29, 13)
        Me.lblSku.TabIndex = 0
        Me.lblSku.Text = "SKU"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.lblWeight)
        Me.grpInfo.Controls.Add(Me.lblTotal)
        Me.grpInfo.Controls.Add(Me.lblCost)
        Me.grpInfo.Controls.Add(Me.nudWeight)
        Me.grpInfo.Controls.Add(Me.nudTotal)
        Me.grpInfo.Controls.Add(Me.nudCost)
        Me.grpInfo.Controls.Add(Me.lblQuantity)
        Me.grpInfo.Controls.Add(Me.nudQuantity)
        Me.grpInfo.Location = New System.Drawing.Point(13, 139)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(645, 100)
        Me.grpInfo.TabIndex = 1
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Order Info"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(537, 31)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(81, 13)
        Me.lblWeight.TabIndex = 7
        Me.lblWeight.Text = "Weight per item"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(413, 31)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(294, 31)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Cost"
        '
        'nudWeight
        '
        Me.nudWeight.DecimalPlaces = 2
        Me.nudWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudWeight.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudWeight.Location = New System.Drawing.Point(505, 52)
        Me.nudWeight.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudWeight.Name = "nudWeight"
        Me.nudWeight.Size = New System.Drawing.Size(120, 29)
        Me.nudWeight.TabIndex = 4
        Me.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudWeight.ThousandsSeparator = True
        '
        'nudTotal
        '
        Me.nudTotal.DecimalPlaces = 2
        Me.nudTotal.Enabled = False
        Me.nudTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTotal.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudTotal.Location = New System.Drawing.Point(379, 52)
        Me.nudTotal.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudTotal.Name = "nudTotal"
        Me.nudTotal.Size = New System.Drawing.Size(120, 29)
        Me.nudTotal.TabIndex = 3
        Me.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTotal.ThousandsSeparator = True
        '
        'nudCost
        '
        Me.nudCost.DecimalPlaces = 2
        Me.nudCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCost.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudCost.Location = New System.Drawing.Point(253, 52)
        Me.nudCost.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudCost.Name = "nudCost"
        Me.nudCost.Size = New System.Drawing.Size(120, 29)
        Me.nudCost.TabIndex = 2
        Me.nudCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCost.ThousandsSeparator = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(43, 31)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        '
        'nudQuantity
        '
        Me.nudQuantity.DecimalPlaces = 2
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(11, 52)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 29)
        Me.nudQuantity.TabIndex = 0
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudQuantity.ThousandsSeparator = True
        '
        'btnProcess
        '
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcess.Location = New System.Drawing.Point(350, 248)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(154, 49)
        Me.btnProcess.TabIndex = 6
        Me.btnProcess.Text = "OK"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(504, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 49)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 304)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpItem)
        Me.Name = "frmPoItem"
        Me.Text = "Add Items to Order"
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpItem As System.Windows.Forms.GroupBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSku As System.Windows.Forms.TextBox
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblSku As System.Windows.Forms.Label
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents nudWeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudTotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
