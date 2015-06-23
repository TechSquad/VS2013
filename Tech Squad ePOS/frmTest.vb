Public Class frmTest
    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RemoveHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
        loadDgvData()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
        updateDgv()
    End Sub

    Private Sub loadDgvData()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM po_item"

        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Select_Query(sqlQuery)
        End With
        MyTable = classSql.Table
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        DataGridView1.DataSource = MyTable
    End Sub
    Private Sub updateDgv()
        Dim rowNo As Integer

        With DataGridView1
            If .SelectedRows.Count > 0 Then
                rowNo = .SelectedRows(0).Index
                txtRowNo.Text = rowNo
                txtRowCount.Text = DataGridView1.Rows.Count
            End If
        End With
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        updateDgv()
    End Sub

    Private Sub btnRowSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnRowSelect.Click
        RemoveHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
        Dim rowNo As Integer
        rowNo = Convert.ToInt16(txtRowNo.Text)
        dgvSelectedRow(DataGridView1, rowNo)
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
    End Sub
End Class