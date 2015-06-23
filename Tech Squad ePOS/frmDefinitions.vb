Public Class frmDefinitions

    Private Sub btnSalutation_Click(sender As System.Object, e As System.EventArgs) Handles btnSalutation.Click
        Dim MyTable As DataTable

        MyTable = getSalutation()
        dgvDefinitions.DataSource = MyTable

    End Sub

    Private Sub btnPoTerms_Click(sender As System.Object, e As System.EventArgs) Handles btnPoTerms.Click
        Dim MyTable As DataTable

        MyTable = getPoTerms()
        dgvDefinitions.DataSource = MyTable
    End Sub

    Private Sub btnPoShipping_Click(sender As System.Object, e As System.EventArgs) Handles btnPoShipping.Click
        Dim MyTable As DataTable

        MyTable = getPoShipping()
        dgvDefinitions.DataSource = MyTable
    End Sub

    Private Sub btnAccountType_Click(sender As System.Object, e As System.EventArgs) Handles btnAccountType.Click
        Dim MyTable As DataTable

        MyTable = getAcctType()
        dgvDefinitions.DataSource = MyTable
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class