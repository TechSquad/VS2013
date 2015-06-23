Public Class frmMySqlTools
    Public PRM As Boolean
    Private Sub frmPrmTools_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sqlQuery As String = "SHOW TABLES"
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        MyTable = showTables()
        dgvTableList.DataSource = MyTable
        dgvTableList.Refresh()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As System.EventArgs) Handles dgvTableList.SelectionChanged
        Dim table As New DataTable
        Dim sqlQuery As String = "SELECT * FROM "
        Dim dataBaseName As String = ""
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        sqlQuery = sqlQuery & dgvTableList.CurrentRow.Cells(0).Value
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
            dgvTableContent.DataSource = MyTable      ' and update table
            dgvTableContent.Refresh()
        Else
            dgvTableContent.DataSource = MyTable      ' If no error then update table
            dgvTableContent.Refresh()
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub OSCommerceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnEmptyTable_Click(sender As System.Object, e As System.EventArgs) Handles btnEmptyTable.Click
        Dim tableName As String = dgvTableList.CurrentRow.Cells(0).Value.ToString
        emptyTable(tableName)
        dgvTableContent.Refresh()
    End Sub
End Class