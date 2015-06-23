<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchasingCentre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchasingCentre))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLabels = New System.Windows.Forms.Button()
        Me.btnOtherReturns = New System.Windows.Forms.Button()
        Me.btnRMA = New System.Windows.Forms.Button()
        Me.btnCustomerReturns = New System.Windows.Forms.Button()
        Me.btnPoHistory = New System.Windows.Forms.Button()
        Me.btnOnOrder = New System.Windows.Forms.Button()
        Me.btnReceiveWoPO = New System.Windows.Forms.Button()
        Me.btnCreateReceivePO = New System.Windows.Forms.Button()
        Me.btnOrderList = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLabels)
        Me.Panel1.Controls.Add(Me.btnOtherReturns)
        Me.Panel1.Controls.Add(Me.btnRMA)
        Me.Panel1.Controls.Add(Me.btnCustomerReturns)
        Me.Panel1.Controls.Add(Me.btnPoHistory)
        Me.Panel1.Controls.Add(Me.btnOnOrder)
        Me.Panel1.Controls.Add(Me.btnReceiveWoPO)
        Me.Panel1.Controls.Add(Me.btnCreateReceivePO)
        Me.Panel1.Controls.Add(Me.btnOrderList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 68)
        Me.Panel1.TabIndex = 10
        '
        'btnLabels
        '
        Me.btnLabels.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLabels.Enabled = False
        Me.btnLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabels.Image = CType(resources.GetObject("btnLabels.Image"), System.Drawing.Image)
        Me.btnLabels.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLabels.Location = New System.Drawing.Point(776, 0)
        Me.btnLabels.Name = "btnLabels"
        Me.btnLabels.Size = New System.Drawing.Size(97, 68)
        Me.btnLabels.TabIndex = 8
        Me.btnLabels.Text = "Print Labels"
        Me.btnLabels.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLabels.UseVisualStyleBackColor = True
        '
        'btnOtherReturns
        '
        Me.btnOtherReturns.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOtherReturns.Enabled = False
        Me.btnOtherReturns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtherReturns.Image = CType(resources.GetObject("btnOtherReturns.Image"), System.Drawing.Image)
        Me.btnOtherReturns.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOtherReturns.Location = New System.Drawing.Point(679, 0)
        Me.btnOtherReturns.Name = "btnOtherReturns"
        Me.btnOtherReturns.Size = New System.Drawing.Size(97, 68)
        Me.btnOtherReturns.TabIndex = 7
        Me.btnOtherReturns.Text = "Other Returns"
        Me.btnOtherReturns.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOtherReturns.UseVisualStyleBackColor = True
        '
        'btnRMA
        '
        Me.btnRMA.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRMA.Enabled = False
        Me.btnRMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRMA.Image = CType(resources.GetObject("btnRMA.Image"), System.Drawing.Image)
        Me.btnRMA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRMA.Location = New System.Drawing.Point(582, 0)
        Me.btnRMA.Name = "btnRMA"
        Me.btnRMA.Size = New System.Drawing.Size(97, 68)
        Me.btnRMA.TabIndex = 6
        Me.btnRMA.Text = "RMA's"
        Me.btnRMA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRMA.UseVisualStyleBackColor = True
        '
        'btnCustomerReturns
        '
        Me.btnCustomerReturns.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCustomerReturns.Enabled = False
        Me.btnCustomerReturns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerReturns.Image = CType(resources.GetObject("btnCustomerReturns.Image"), System.Drawing.Image)
        Me.btnCustomerReturns.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCustomerReturns.Location = New System.Drawing.Point(485, 0)
        Me.btnCustomerReturns.Name = "btnCustomerReturns"
        Me.btnCustomerReturns.Size = New System.Drawing.Size(97, 68)
        Me.btnCustomerReturns.TabIndex = 5
        Me.btnCustomerReturns.Text = "Customer Returns"
        Me.btnCustomerReturns.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomerReturns.UseVisualStyleBackColor = True
        '
        'btnPoHistory
        '
        Me.btnPoHistory.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPoHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoHistory.Image = CType(resources.GetObject("btnPoHistory.Image"), System.Drawing.Image)
        Me.btnPoHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPoHistory.Location = New System.Drawing.Point(388, 0)
        Me.btnPoHistory.Name = "btnPoHistory"
        Me.btnPoHistory.Size = New System.Drawing.Size(97, 68)
        Me.btnPoHistory.TabIndex = 4
        Me.btnPoHistory.Text = "PO History"
        Me.btnPoHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPoHistory.UseVisualStyleBackColor = True
        '
        'btnOnOrder
        '
        Me.btnOnOrder.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOrder.Image = CType(resources.GetObject("btnOnOrder.Image"), System.Drawing.Image)
        Me.btnOnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOnOrder.Location = New System.Drawing.Point(291, 0)
        Me.btnOnOrder.Name = "btnOnOrder"
        Me.btnOnOrder.Size = New System.Drawing.Size(97, 68)
        Me.btnOnOrder.TabIndex = 3
        Me.btnOnOrder.Text = "Receive PO"
        Me.btnOnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOnOrder.UseVisualStyleBackColor = True
        '
        'btnReceiveWoPO
        '
        Me.btnReceiveWoPO.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReceiveWoPO.Enabled = False
        Me.btnReceiveWoPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveWoPO.Image = CType(resources.GetObject("btnReceiveWoPO.Image"), System.Drawing.Image)
        Me.btnReceiveWoPO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReceiveWoPO.Location = New System.Drawing.Point(194, 0)
        Me.btnReceiveWoPO.Name = "btnReceiveWoPO"
        Me.btnReceiveWoPO.Size = New System.Drawing.Size(97, 68)
        Me.btnReceiveWoPO.TabIndex = 2
        Me.btnReceiveWoPO.Text = "Receive without PO"
        Me.btnReceiveWoPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReceiveWoPO.UseVisualStyleBackColor = True
        '
        'btnCreateReceivePO
        '
        Me.btnCreateReceivePO.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCreateReceivePO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateReceivePO.Image = CType(resources.GetObject("btnCreateReceivePO.Image"), System.Drawing.Image)
        Me.btnCreateReceivePO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreateReceivePO.Location = New System.Drawing.Point(97, 0)
        Me.btnCreateReceivePO.Name = "btnCreateReceivePO"
        Me.btnCreateReceivePO.Size = New System.Drawing.Size(97, 68)
        Me.btnCreateReceivePO.TabIndex = 1
        Me.btnCreateReceivePO.Text = "Create / Process PO"
        Me.btnCreateReceivePO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCreateReceivePO.UseVisualStyleBackColor = True
        '
        'btnOrderList
        '
        Me.btnOrderList.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOrderList.Enabled = False
        Me.btnOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderList.Image = CType(resources.GetObject("btnOrderList.Image"), System.Drawing.Image)
        Me.btnOrderList.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrderList.Location = New System.Drawing.Point(0, 0)
        Me.btnOrderList.Name = "btnOrderList"
        Me.btnOrderList.Size = New System.Drawing.Size(97, 68)
        Me.btnOrderList.TabIndex = 0
        Me.btnOrderList.Text = "Order List"
        Me.btnOrderList.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrderList.UseVisualStyleBackColor = True
        '
        'frmPurchasingCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 67)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(888, 105)
        Me.Name = "frmPurchasingCentre"
        Me.Text = "Purchasing Centre"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLabels As System.Windows.Forms.Button
    Friend WithEvents btnOtherReturns As System.Windows.Forms.Button
    Friend WithEvents btnRMA As System.Windows.Forms.Button
    Friend WithEvents btnCustomerReturns As System.Windows.Forms.Button
    Friend WithEvents btnPoHistory As System.Windows.Forms.Button
    Friend WithEvents btnOnOrder As System.Windows.Forms.Button
    Friend WithEvents btnReceiveWoPO As System.Windows.Forms.Button
    Friend WithEvents btnCreateReceivePO As System.Windows.Forms.Button
    Friend WithEvents btnOrderList As System.Windows.Forms.Button
End Class
