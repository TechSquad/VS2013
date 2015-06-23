Public Class frmMdi_Child
    Private _message As String

    Public Property Message As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property

    Public Sub DisplayMessageFromParent()

        lblParentMessage.Text = _message
    End Sub
    Private Sub frmMdi_Child_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DisplayMessageFromParent()
    End Sub

    Private Sub btnMessageParent_Click(sender As System.Object, e As System.EventArgs) Handles btnMessageParent.Click
        _message = txtMessageToParent.Text
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

End Class