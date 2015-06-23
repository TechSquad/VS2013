<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagementCentre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagementCentre))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCompany = New System.Windows.Forms.Button()
        Me.btnCategories = New System.Windows.Forms.Button()
        Me.btnDefinitions = New System.Windows.Forms.Button()
        Me.btnMarketing = New System.Windows.Forms.Button()
        Me.btnGiftCards = New System.Windows.Forms.Button()
        Me.btnLoyalty = New System.Windows.Forms.Button()
        Me.btnRefunds = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCompany)
        Me.Panel1.Controls.Add(Me.btnCategories)
        Me.Panel1.Controls.Add(Me.btnDefinitions)
        Me.Panel1.Controls.Add(Me.btnMarketing)
        Me.Panel1.Controls.Add(Me.btnGiftCards)
        Me.Panel1.Controls.Add(Me.btnLoyalty)
        Me.Panel1.Controls.Add(Me.btnRefunds)
        Me.Panel1.Controls.Add(Me.btnEmployees)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 68)
        Me.Panel1.TabIndex = 10
        '
        'btnCompany
        '
        Me.btnCompany.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompany.Image = CType(resources.GetObject("btnCompany.Image"), System.Drawing.Image)
        Me.btnCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCompany.Location = New System.Drawing.Point(776, 0)
        Me.btnCompany.Name = "btnCompany"
        Me.btnCompany.Size = New System.Drawing.Size(97, 68)
        Me.btnCompany.TabIndex = 8
        Me.btnCompany.Text = "Company"
        Me.btnCompany.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCompany.UseVisualStyleBackColor = True
        '
        'btnCategories
        '
        Me.btnCategories.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategories.Image = CType(resources.GetObject("btnCategories.Image"), System.Drawing.Image)
        Me.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCategories.Location = New System.Drawing.Point(679, 0)
        Me.btnCategories.Name = "btnCategories"
        Me.btnCategories.Size = New System.Drawing.Size(97, 68)
        Me.btnCategories.TabIndex = 7
        Me.btnCategories.Text = "Categories"
        Me.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCategories.UseVisualStyleBackColor = True
        '
        'btnDefinitions
        '
        Me.btnDefinitions.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefinitions.Image = CType(resources.GetObject("btnDefinitions.Image"), System.Drawing.Image)
        Me.btnDefinitions.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDefinitions.Location = New System.Drawing.Point(582, 0)
        Me.btnDefinitions.Name = "btnDefinitions"
        Me.btnDefinitions.Size = New System.Drawing.Size(97, 68)
        Me.btnDefinitions.TabIndex = 6
        Me.btnDefinitions.Text = "Definitions"
        Me.btnDefinitions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDefinitions.UseVisualStyleBackColor = True
        '
        'btnMarketing
        '
        Me.btnMarketing.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMarketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarketing.Image = CType(resources.GetObject("btnMarketing.Image"), System.Drawing.Image)
        Me.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMarketing.Location = New System.Drawing.Point(485, 0)
        Me.btnMarketing.Name = "btnMarketing"
        Me.btnMarketing.Size = New System.Drawing.Size(97, 68)
        Me.btnMarketing.TabIndex = 5
        Me.btnMarketing.Text = "Marketing"
        Me.btnMarketing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMarketing.UseVisualStyleBackColor = True
        '
        'btnGiftCards
        '
        Me.btnGiftCards.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGiftCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiftCards.Image = CType(resources.GetObject("btnGiftCards.Image"), System.Drawing.Image)
        Me.btnGiftCards.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGiftCards.Location = New System.Drawing.Point(388, 0)
        Me.btnGiftCards.Name = "btnGiftCards"
        Me.btnGiftCards.Size = New System.Drawing.Size(97, 68)
        Me.btnGiftCards.TabIndex = 4
        Me.btnGiftCards.Text = "Gift Cards"
        Me.btnGiftCards.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGiftCards.UseVisualStyleBackColor = True
        '
        'btnLoyalty
        '
        Me.btnLoyalty.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLoyalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoyalty.Image = CType(resources.GetObject("btnLoyalty.Image"), System.Drawing.Image)
        Me.btnLoyalty.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLoyalty.Location = New System.Drawing.Point(291, 0)
        Me.btnLoyalty.Name = "btnLoyalty"
        Me.btnLoyalty.Size = New System.Drawing.Size(97, 68)
        Me.btnLoyalty.TabIndex = 3
        Me.btnLoyalty.Text = "Loyalty Program"
        Me.btnLoyalty.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLoyalty.UseVisualStyleBackColor = True
        '
        'btnRefunds
        '
        Me.btnRefunds.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefunds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefunds.Image = CType(resources.GetObject("btnRefunds.Image"), System.Drawing.Image)
        Me.btnRefunds.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefunds.Location = New System.Drawing.Point(194, 0)
        Me.btnRefunds.Name = "btnRefunds"
        Me.btnRefunds.Size = New System.Drawing.Size(97, 68)
        Me.btnRefunds.TabIndex = 2
        Me.btnRefunds.Text = "Refunds"
        Me.btnRefunds.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefunds.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployees.Image = CType(resources.GetObject("btnEmployees.Image"), System.Drawing.Image)
        Me.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmployees.Location = New System.Drawing.Point(97, 0)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(97, 68)
        Me.btnEmployees.TabIndex = 1
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(97, 68)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'frmManagementCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 67)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(888, 105)
        Me.Name = "frmManagementCentre"
        Me.Text = "Management Centre"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCompany As System.Windows.Forms.Button
    Friend WithEvents btnCategories As System.Windows.Forms.Button
    Friend WithEvents btnDefinitions As System.Windows.Forms.Button
    Friend WithEvents btnMarketing As System.Windows.Forms.Button
    Friend WithEvents btnGiftCards As System.Windows.Forms.Button
    Friend WithEvents btnLoyalty As System.Windows.Forms.Button
    Friend WithEvents btnRefunds As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
End Class
