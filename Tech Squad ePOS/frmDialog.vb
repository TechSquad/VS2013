Public Class frmDialog
    Private _title As String
    Private _message As String
    Private _okOnly As Boolean
    Private _okButtonText As String  ' raises the OK event
    Private _cxlButtonText As String 'raises the abort event

    Public WriteOnly Property title As String
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    Public WriteOnly Property message As String
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public WriteOnly Property okOnly As Boolean
        Set(ByVal value As Boolean)
            _okOnly = value
        End Set
    End Property
    Public WriteOnly Property okButtonText As String
        Set(ByVal value As String)
            _okButtonText = value
        End Set
    End Property
    Public WriteOnly Property cxlButtonText As String
        Set(ByVal value As String)
            _cxlButtonText = value
        End Set
    End Property
    Private Sub frmDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = _title
        txtMessage.Text = _message
        If _okButtonText <> "" Then
            btnOK.Text = _okButtonText
        Else
            btnOK.Text = "OK"
        End If
        If _cxlButtonText <> "" Then
            btnCancel.Text = _cxlButtonText
        Else
            btnCancel.Text = "Cancel"
        End If
        If _okOnly Then
            Dim buttonLocation As System.Drawing.Point

            buttonLocation = btnCancel.Location     'get location of cancel button
            btnCancel.Visible = False
            btnOK.Location = buttonLocation         ' move button to new location
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtMessage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMessage.TextChanged

    End Sub
End Class