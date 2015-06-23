Public Class frmTender
    Public paymentType As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click
        lblPayment.Visible = True
        txtPayment.Visible = True
        txtPayment.Focus()
        paymentType = Replace(sender.ToString, "System.Windows.Forms.Button, Text:", "")
    End Sub

    Private Sub txtPayment_Validated(sender As Object, e As System.EventArgs) Handles txtPayment.Validated
        lstPayments.Items.Add(txtPayment.Text & vbTab & paymentType)
        lblPayment.Visible = False
        txtPayment.Visible = False
        txtPayment.Text = "0.00"
    End Sub
End Class