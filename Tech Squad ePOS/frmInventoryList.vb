Public Class frmInventoryList
    Private _message As String
    Private _sku As String

    Public Property Message As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public Property sku As String
        Get
            Return _sku
        End Get
        Set(ByVal value As String)
            _sku = value
        End Set
    End Property
    Private Sub selectItem()
        _message = dgvInventory.SelectedRows(0).Cells(0).Value
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If _message = "lookup" Then
            selectItem()
        Else
            'instruction to view record
            Dim frmInvDetail As New frmInventoryDetail(Convert.ToInt32(dgvInventory.SelectedRows(0).Cells(0).Value), "View")
            frmInvDetail.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Cancel" Then
            DialogResult = System.Windows.Forms.DialogResult.Abort
        Else
            'instruction to edit record
            Dim frmInvDetail As New frmInventoryDetail(Convert.ToInt32(dgvInventory.SelectedRows(0).Cells(0).Value), "Edit")
            frmInvDetail.Show()
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'instruction to add new record
        Dim frmInvDetail As New frmInventoryDetail(0, "Add")
        frmInvDetail.Show()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvInventory.DoubleClick
        If _message = "lookup" Then
            selectItem()
        Else
            'instruction to view record
            Dim mdi_frmInventoryList As New frmInventoryDetail(Convert.ToInt32(dgvInventory.SelectedRows(0).Cells(0).Value), "View")

            With mdi_frmInventoryList
                .MdiParent = frmMainMenu
                .Show()
            End With
        End If
    End Sub

    Private Sub frmInventoryList_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Dim MyTable As DataTable

        If _sku = Nothing Then     'if _sku is unassigned then list everything
            MyTable = getAllItems()
            If MyTable.Rows.Count > 0 Then
                dgvInventory.DataSource = MyTable
                dgvInventory.Refresh()
            Else
                ToolStripStatusLabel1.Visible = True
                ToolStripStatusLabel1.Text = "No records in the table"
            End If
        Else        'if _sku has a value list closest matches on SKU and Barcode
            MyTable = getItem(_sku, sku)
            If MyTable.Rows.Count > 0 Then
                dgvInventory.DataSource = MyTable
                dgvInventory.Refresh()
            Else
                ToolStripStatusLabel1.Visible = True
                ToolStripStatusLabel1.Text = "No records in the table"
            End If
        End If
        
    End Sub

    Private Sub frmInventoryList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim MyTable As DataTable

        If _message = "lookup" Then         'either lookup mode or just show all items
            lookupMode()
        Else
            MyTable = getAllItems()
            If MyTable.Rows.Count > 0 Then
                dgvInventory.DataSource = MyTable
                dgvInventory.Refresh()
            Else
                ToolStripStatusLabel1.Visible = True
                ToolStripStatusLabel1.Text = "No records in the table"
            End If
        End If
        

    End Sub
    Private Sub lookupMode()
        btnAdd.Visible = False
        btnDelete.Visible = False
        btnSelect.Location = btnEdit.Location
        btnEdit.Text = "Cancel"
        btnEdit.Location = btnDelete.Location
    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub txtLocate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLocate.TextChanged
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        MyTable = getItem(txtLocate.Text, txtLocate.Text)
        If MyTable.Rows.Count > 0 Then
            dgvInventory.DataSource = MyTable
            dgvInventory.Refresh()
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
End Class