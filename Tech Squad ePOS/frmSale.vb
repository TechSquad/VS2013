Public Class frmSale
    Private _mode As String
    Private _InvNumber As Integer
    Private _backgroundWorkerQueue As Integer = 0
    Public Property Mode As String
        Get
            Return _mode
        End Get
        Set(ByVal value As String)
            _mode = value
        End Set
    End Property
    Public Property InvNumber As Integer
        Get
            Return _InvNumber
        End Get
        Set(ByVal value As Integer)
            _InvNumber = value
        End Set
    End Property
    Private Sub frmSale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim MyTable As DataTable

        ' there is no mode setting for new PO's
        RemoveHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
        Select Case _mode
            Case "new"
                Me.Text = "Sales Invoice Number: "
                btnVoid.Text = "Void Invoice"
                btnProcess.Text = "Tender   [F10]"
                _InvNumber = addInvoice()       'Add new invoice and get the number
                Me.Text = Me.Text & " " & _InvNumber
            Case "view"
                Me.Text = "Sales Invoice (View)"
                btnVoid.Visible = False
                txtSku.Visible = False
                btnLookup.Visible = False
                lblSku.Visible = False
                'Fill dgv with items from inv number
                setupDgvItems() 'set columns width and viewed
        End Select
        AddHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
        txtGrandTotal.Text = FormatCurrency(0.0)
        txtSku.Focus()
    End Sub
    Private Sub setupDgvItems()
        With dgvItems
            .Columns("item_description").Width = 300
            .Columns("in_stock").Visible = False
            .Columns("supplier_stock").Visible = False
            .Columns("picture_location").Visible = False
            .Columns("item_stockcode").HeaderText = "SKU"
            .Columns("item_description").HeaderText = "Description"
        End With
    End Sub
    Private Sub skuLookup()
        Dim MyTable As New DataTable
        Dim line_number As Integer
        Dim f As New frmInventoryList
        Dim item_id As Integer
        Dim quantity As Double = 1
        Dim SendData As String = txtSku.Text

        RemoveHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
        item_id = getItem(SendData, SendData, True) 'Lookup item_id by sku or barcode
        If item_id > 0 Then                             'if a single item matches
            'If dgvItems.Rows.Count > 0 Then
            line_number = (dgvItems.RowCount + 1)
            addInvoiceItem(_InvNumber, item_id, quantity, (dgvItems.RowCount + 1)) 'Create a new record
            updateInvoiceItems()
            setupDgvItems()     ' ensure columns are correctly set
            'updateInvoiceItems()
            dgvItems.CurrentCell = dgvItems(1, (dgvItems.RowCount - 1))
            'End If
        Else                                            'If no exact match open frmInventoryList in Lookup Mode
            If Not IsOpen(f) Then                       'if child form is already open set focus to the form
                'alter the form to allow an item to be selected
                f.Message = "lookup"                  'call the overridden constructor of the child form
                f.sku = SendData                      'Send the SKU for matching
                If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                    item_id = f.Message            ' Receive back the item_id
                    line_number = (dgvItems.RowCount + 1)
                    addInvoiceItem(_InvNumber, item_id, quantity, (dgvItems.RowCount + 1)) 'Create a new record
                    updateInvoiceItems()
                    setupDgvItems()     ' ensure columns are correctly set
                    'updateInvoiceItems()
                    dgvItems.CurrentCell = dgvItems(1, (dgvItems.RowCount - 1))
                End If
            End If
        End If
        'setupDgvItems()     ' ensure columns are correctly set
        ReCalculate()
        txtSku.SelectAll()
        txtSku.Focus()

        AddHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
        selectionChanged()
    End Sub
    Private Sub btnLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnLookup.Click
        skuLookup()
    End Sub
    Private Sub ReCalculate()
        Dim total, totalExVat, totalVat As Decimal
        Dim GrandTotal As Decimal = 0.0

        For Each r As DataGridViewRow In dgvItems.Rows
            If dgvItems.Rows(0).Cells(0).Value <> "" Then       'If SKU code in cell 0, this misses out any blank line
                total = total + r.Cells("ti_price_1").Value
                totalExVat = totalExVat + r.Cells("price_1").Value
            End If
        Next
        totalVat = total - totalExVat
        txtSubTotal.Text = FormatCurrency(totalExVat)
        txtTotalVat.Text = FormatCurrency(totalVat)
        txtGrandTotal.Text = FormatCurrency(total)
    End Sub
    Private Sub selectionChanged()
        Dim item_id As Integer
        Dim MyTable As DataTable

        If dgvItems.SelectedRows.Count > 0 Then
            txtStockCount.Text = dgvItems.SelectedRows(0).Cells("in_stock").Value.ToString
            txtWebStock.Text = dgvItems.SelectedRows(0).Cells("supplier_stock").Value.ToString
            ' Get costs for selected item
            item_id = getItem(dgvItems.SelectedRows(0).Cells("item_stockcode").Value, , True)
            MyTable = getItemCosts(item_id)
            txtCost.Text = MyTable.Rows(0).Item("po_item_cost").ToString
            txtLastPurchased.Text = MyTable.Rows(0).Item("date_created").ToString
            txtAvgCost.Text = MyTable.Rows(0).Item("average").ToString

            'RemoveHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
            'BackgroundWorker1.RunWorkerAsync()
            startBackgroundWorker()
        End If
    End Sub
    Private Sub dgvItems_SelectionChanged(sender As Object, e As System.EventArgs) Handles dgvItems.SelectionChanged
        selectionChanged()
    End Sub
    Private Sub updateInvoiceItems()
        Dim MyItemsTable As DataTable

        'RemoveHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
        MyItemsTable = getInvoiceItemsLine(_InvNumber)
        dgvItems.DataSource = MyItemsTable
        dgvItems.Refresh()
        'dgvSelectedRow(dgvItems, dgvItems.Rows.Count - 1)
        txtStockCount.Text = dgvItems.SelectedRows(0).Cells("in_stock").Value.ToString
        txtWebStock.Text = dgvItems.SelectedRows(0).Cells("supplier_stock").Value.ToString
        'If dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString.Substring(0, 4) = "http" Then
        'Console.WriteLine("substring = 'http'")
        'BackgroundWorker1.RunWorkerAsync()
        'picItem.Image = webDownloadImage(dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString)

        'ElseIf dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString.Substring(1, 3) = ":\" Then
        'Console.WriteLine("substring = ':\'")
        'picItem.Image = Image.FromFile(dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString)
        'End If

    End Sub
    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function
    Private Sub txtmCarriage_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If TrapKey(Asc(e.KeyChar)) Then
            e.KeyChar = ""  'cancel the keypress
        End If
    End Sub

    Private Sub txtSku_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSku.KeyDown
        'detect the enter key and process the code in the lookup button
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True  'suppress the keypress this will stop the beep
            skuLookup() 'btnLookup_Click(btnLookup, Nothing)
        End If
    End Sub
    Private Sub btnVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnVoid.Click
        'Remove all the items from the PO and then remove the PO record
        Dim f As New frmDialog
        If _mode = "view" Then
            'deal with print request
            MsgBox("You cannot delete a completed invoice")
        Else
            If Not IsOpen(f) Then                            'if child form is already open set focus to the form
                f.title = "Confirm"                  'call the overrided constructor of the child form
                f.message = "You are about to Void this Sale, this change is permanent. Click OK to delete or cancel to abort the change"
                f.okOnly = False
                f.okButtonText = "OK"
                If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                    deleteInvoiceItems(_InvNumber)          ' delete all items
                    deleteInvoice(_InvNumber)               ' delete invoice
                    Me.Close()                                  ' close the form
                Else
                    'MsgBox("You didn't press OK")
                End If
            End If
            f.Focus()
        End If
    End Sub
    Private Sub btnProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnProcess.Click
        'open Tender Form
    End Sub
    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs)
    End Sub
    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs)
    End Sub


    Private Sub btnShowCosts_Click(sender As System.Object, e As System.EventArgs) Handles btnShowCosts.Click
        If btnShowCosts.Text = "Show Costs" Then
            pnlShowCosts.Visible = True
            btnShowCosts.Text = "Hide Costs"
        Else
            pnlShowCosts.Visible = False
            btnShowCosts.Text = "Show Costs"
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim stringStart As String
        Dim count As Integer
        Dim MyImage As System.Drawing.Image

        count = Me.dgvItems.Rows.Count
        stringStart = dgvItems.SelectedRows(0).Cells("picture_location").Value.Substring(0, 3)
        If dgvItems.SelectedRows(0).Cells("picture_location").Value.Substring(0, 3) = stringStart Then
            MyImage = webDownloadImage(dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString)
            e.Result = MyImage
            'picItem.Image = webDownloadImage(dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString)
        ElseIf dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString.Substring(1, 3) = stringStart Then
            'Console.WriteLine("substring = ':\'")
            MyImage = Image.FromFile(dgvItems.SelectedRows(0).Cells("picture_location").Value.ToString)
            e.Result = MyImage
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        picItem.Image = e.Result
        'AddHandler dgvItems.SelectionChanged, AddressOf dgvItems_SelectionChanged
        'dgvSelectedRow(dgvItems, dgvItems.Rows.Count - 1)
        Beep()
    End Sub
    Private Sub startBackgroundWorker()

        Timer1.Interval = 250   'set timer interval 1/4 second
        If BackgroundWorker1.IsBusy Then    'if background worker is busy queue it up
            _backgroundWorkerQueue += 1
            Timer1.Enabled = True
        Else
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If _backgroundWorkerQueue > 0 Then
            If BackgroundWorker1.IsBusy Then
                'do nothing
            Else
                BackgroundWorker1.RunWorkerAsync()
                _backgroundWorkerQueue -= 1
            End If
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnAssignCustomer_Click(sender As Object, e As EventArgs) Handles btnAssignCustomer.Click

    End Sub

    Private Sub btnSimpleCustomer_Click(sender As Object, e As EventArgs) Handles btnSimpleCustomer.Click

    End Sub

    Private Sub btnAdjustPrice_Click(sender As Object, e As EventArgs) Handles btnAdjustPrice.Click

    End Sub

    Private Sub btnAdjustQuantity_Click(sender As Object, e As EventArgs) Handles btnAdjustQuantity.Click

    End Sub

    Private Sub btnDiscountItem_Click(sender As Object, e As EventArgs) Handles btnDiscountItem.Click

    End Sub

    Private Sub txtSku_TextChanged(sender As Object, e As EventArgs) Handles txtSku.TextChanged

    End Sub
End Class