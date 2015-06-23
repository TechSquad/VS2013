Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmCustomer
    Private _message As String
    Private _customerId As Integer
    Private _complete As Boolean
    Public Property Message As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public Property CustomerId As Integer
        Get
            Return _customerId
        End Get
        Set(ByVal value As Integer)
            _customerId = value
        End Set
    End Property
    Public ReadOnly Property Complete As Boolean
        Get
            Return Me._complete
        End Get
    End Property
    Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtLocate.Text = ""
        txtLocate.Focus()
        loadDgvData()
    End Sub
    Private Sub refreshForm()
        dgvService.Visible = False
        dgvPurchases.Visible = False
        loadDgvData()
        With DataGridView1
            .Columns.Item("address_id").Visible = False
            .Columns.Item("contact_id").Visible = False
            .Columns.Item("membership").Visible = False
            .Columns.Item("acct_type").Visible = False
            .Columns.Item("date_of_birth").Visible = False
            .Columns.Item("is_company").Visible = False
            .Columns.Item("mailing_list").Visible = False
            .Columns.Item("vip").Visible = False
            .Columns.Item("in_use").Visible = False
            .Columns.Item("date_created").Visible = False
            .Columns.Item("date_changed").Visible = False
            .Columns.Item("address_id1").Visible = False
            .Columns.Item("cust_id1").Visible = False
            '.Columns.Item("add_2").Visible = False
            .Columns.Item("town").Visible = False
            .Columns.Item("city").Visible = False
            .Columns.Item("in_use1").Visible = False
            .Columns.Item("title").Width = 50
            .Columns.Item("title").HeaderText = "Title"
            .Columns.Item("cust_id").Width = 50
            .Columns.Item("cust_id").HeaderText = ""
            .Columns.Item("first_name").Width = 150
            .Columns.Item("first_name").HeaderText = "First Name"
            .Columns.Item("last_name").Width = 150
            .Columns.Item("last_name").HeaderText = "Surname"
            .Columns.Item("company_name").Width = 200
            .Columns.Item("company_name").HeaderText = "Company"
            .Columns.Item("add_1").Width = 200
            .Columns.Item("add_1").HeaderText = "Address 1"
            .Columns.Item("add_2").HeaderText = "Address 2"
        End With
        If dgvService.Visible Then updateSubTables()
        Select Case _message
            Case "pick_customer"
                btnHistory.Enabled = False
                btnAdd.Enabled = False
                btnEdit.Text = "Select"
                btnDelete.Text = "Exit"
            Case Else

        End Select

    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refreshForm()
    End Sub
    Private Sub loadDgvData()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        Me.Cursor = Cursors.WaitCursor
        MyTable = getNameAddress()
        If MyTable.Rows.Count > 0 Then
            DataGridView1.DataSource = MyTable
            DataGridView1.Refresh()
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            Dim frmCustDetail As New frmCustomerDetail(Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value), "Edit") ' create formClass and pass cust_id and form Mode
            frmCustDetail.Show()    ' show the form
            While frmCustDetail.Complete = False
                Application.DoEvents()  ' wait for form to close
            End While
            refreshForm()   ' refresh customer data on form
            frmCustDetail.Dispose() ' dispose of form now task is complete
        ElseIf btnEdit.Text = "Select" Then
            _message = DataGridView1.SelectedRows(0).Cells(0).Value
            DialogResult = System.Windows.Forms.DialogResult.OK 'Exits form with OK result
        End If
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim frmCustDetail As New frmCustomerDetail(0, "Add")
        Dim frmCustDetailSkeleton As New frmCustomerDetail(0, "skeleton")

        If Me.Text = "Add Support Customer" Then
            'show skeleton form
            frmCustDetailSkeleton.Show()
        Else
            ' show full form
            frmCustDetail.Show()
        End If
    End Sub
    Private Sub txtLocate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLocate.TextChanged
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable

        txtLocate.Enabled = True
        dgvService.Visible = False
        dgvPurchases.Visible = False
        btnHistory.Text = "Show Transactions"
        Me.Cursor = Cursors.WaitCursor
        MyTable = getNameAddress(txtLocate.Text.ToString)
        If MyTable.Rows.Count > 0 Then
            DataGridView1.DataSource = MyTable
            DataGridView1.Refresh()
        End If
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub updateSubTables()
        Dim MyTable As New DataTable
        Dim cust_id As Integer
        If DataGridView1.RowCount > 0 Then
            cust_id = DataGridView1.CurrentRow.Cells(0).Value
            MyTable = getServiceHistory(cust_id)
            dgvService.DataSource = MyTable
            dgvService.Refresh()
            cust_id = DataGridView1.CurrentRow.Cells(0).Value
            MyTable = getInvoiceHistory(cust_id)
            dgvPurchases.DataSource = MyTable
            dgvPurchases.Refresh()
        End If
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtLocate.Enabled = True
        dgvService.Visible = False
        dgvPurchases.Visible = False
        btnHistory.Text = "Show Transactions"
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If dgvService.Visible Then updateSubTables()
    End Sub

    Private Sub btnHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnHistory.Click
        If btnHistory.Text = "Show Transactions" Then
            'DataGridView1.Enabled = False
            'txtLocate.Enabled = False
            dgvService.Visible = True
            dgvPurchases.Visible = True
            updateSubTables()
            btnHistory.Text = "Hide Transactions"
        Else
            'DataGridView1.Enabled = True
            'txtLocate.Enabled = True
            dgvService.Visible = False
            dgvPurchases.Visible = False
            btnHistory.Text = "Show Transactions"
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BrowseDatabaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmMySqlTools.Show()
    End Sub

    Private Sub TestConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim success As Boolean

        success = is_Database()
        MessageBox.Show("Success = " & success)
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        ' Here we select the customer for viewing but we will need to actually select the customer for use in other modules
        If _message = "Select" Then
            _customerId = DataGridView1.SelectedRows(0).Cells(0).Value
            _complete = True
            Me.Close()
        Else
            Dim frmCustDetail As New frmCustomerDetail(Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value), "View")
            frmCustDetail.Show()
        End If
       
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            'run delete routine
        ElseIf btnDelete.Text = "Exit" Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
