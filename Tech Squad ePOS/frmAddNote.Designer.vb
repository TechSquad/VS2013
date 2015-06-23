<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNote
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
        Me.components = New System.ComponentModel.Container()
        Me.rtbNote = New System.Windows.Forms.RichTextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTech = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.gpNoteType = New System.Windows.Forms.GroupBox()
        Me.rbInternal = New System.Windows.Forms.RadioButton()
        Me.rbTodo = New System.Windows.Forms.RadioButton()
        Me.rbDone = New System.Windows.Forms.RadioButton()
        Me.lblServiceOrder = New System.Windows.Forms.Label()
        Me.txtServiceOrderNumber = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gpNoteType.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbNote
        '
        Me.rtbNote.Location = New System.Drawing.Point(14, 67)
        Me.rtbNote.Name = "rtbNote"
        Me.rtbNote.Size = New System.Drawing.Size(403, 51)
        Me.rtbNote.TabIndex = 0
        Me.rtbNote.Text = ""
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(14, 51)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(30, 13)
        Me.lblNote.TabIndex = 1
        Me.lblNote.Text = "Note"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(167, 16)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Time:"
        '
        'lblTech
        '
        Me.lblTech.AutoSize = True
        Me.lblTech.Location = New System.Drawing.Point(298, 16)
        Me.lblTech.Name = "lblTech"
        Me.lblTech.Size = New System.Drawing.Size(35, 13)
        Me.lblTech.TabIndex = 4
        Me.lblTech.Text = "Tech:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(206, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(339, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(44, 20)
        Me.TextBox3.TabIndex = 7
        '
        'gpNoteType
        '
        Me.gpNoteType.Controls.Add(Me.rbInternal)
        Me.gpNoteType.Controls.Add(Me.rbTodo)
        Me.gpNoteType.Controls.Add(Me.rbDone)
        Me.gpNoteType.Location = New System.Drawing.Point(423, 67)
        Me.gpNoteType.Name = "gpNoteType"
        Me.gpNoteType.Size = New System.Drawing.Size(80, 152)
        Me.gpNoteType.TabIndex = 8
        Me.gpNoteType.TabStop = False
        Me.gpNoteType.Text = "Note Type"
        '
        'rbInternal
        '
        Me.rbInternal.AutoSize = True
        Me.rbInternal.Location = New System.Drawing.Point(15, 108)
        Me.rbInternal.Name = "rbInternal"
        Me.rbInternal.Size = New System.Drawing.Size(60, 17)
        Me.rbInternal.TabIndex = 2
        Me.rbInternal.Text = "Internal"
        Me.rbInternal.UseVisualStyleBackColor = True
        '
        'rbTodo
        '
        Me.rbTodo.AutoSize = True
        Me.rbTodo.Location = New System.Drawing.Point(15, 72)
        Me.rbTodo.Name = "rbTodo"
        Me.rbTodo.Size = New System.Drawing.Size(55, 17)
        Me.rbTodo.TabIndex = 1
        Me.rbTodo.Text = "To Do"
        Me.rbTodo.UseVisualStyleBackColor = True
        '
        'rbDone
        '
        Me.rbDone.AutoSize = True
        Me.rbDone.Checked = True
        Me.rbDone.Location = New System.Drawing.Point(15, 34)
        Me.rbDone.Name = "rbDone"
        Me.rbDone.Size = New System.Drawing.Size(51, 17)
        Me.rbDone.TabIndex = 0
        Me.rbDone.TabStop = True
        Me.rbDone.Text = "Done"
        Me.rbDone.UseVisualStyleBackColor = True
        '
        'lblServiceOrder
        '
        Me.lblServiceOrder.AutoSize = True
        Me.lblServiceOrder.Location = New System.Drawing.Point(14, 232)
        Me.lblServiceOrder.Name = "lblServiceOrder"
        Me.lblServiceOrder.Size = New System.Drawing.Size(115, 13)
        Me.lblServiceOrder.TabIndex = 9
        Me.lblServiceOrder.Text = "Service Order Number:"
        '
        'txtServiceOrderNumber
        '
        Me.txtServiceOrderNumber.Location = New System.Drawing.Point(136, 232)
        Me.txtServiceOrderNumber.Name = "txtServiceOrderNumber"
        Me.txtServiceOrderNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtServiceOrderNumber.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(15, 139)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(402, 20)
        Me.TextBox4.TabIndex = 11
        '
        'frmAddNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 257)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtServiceOrderNumber)
        Me.Controls.Add(Me.lblServiceOrder)
        Me.Controls.Add(Me.gpNoteType)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTech)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.rtbNote)
        Me.Name = "frmAddNote"
        Me.Text = "Service Notes"
        Me.gpNoteType.ResumeLayout(False)
        Me.gpNoteType.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbNote As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblTech As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents gpNoteType As System.Windows.Forms.GroupBox
    Friend WithEvents rbInternal As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
    Friend WithEvents rbDone As System.Windows.Forms.RadioButton
    Friend WithEvents lblServiceOrder As System.Windows.Forms.Label
    Friend WithEvents txtServiceOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
