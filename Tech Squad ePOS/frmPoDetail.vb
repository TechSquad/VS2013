Public Class frmPoDetail
    Private _mode As String
    Private _PoNumber As Integer
    Public Property Mode As String
        Get
            Return _mode
        End Get
        Set(ByVal value As String)
            _mode = value
        End Set
    End Property
    Public Property PoNumber As Integer
        Get
            Return _PoNumber
        End Get
        Set(ByVal value As Integer)
            _PoNumber = value
        End Set
    End Property
    Private Sub frmPoDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim MyTable As DataTable

        ' there is no mode setting for new PO's
        RemoveHandler dgvItems.RowsAdded, AddressOf dgvItems_RowsAdded
        Select Case _mode
            Case "pending"
                dtpReceived.Enabled = False
                lblPoNum.Text = _PoNumber
                lblPoStat.Text = _mode
                txtmCarriage.Text = "0.00"
                txtmCarriageTax.Text = "0.00"
            Case "ordered"
                dtpReceived.Enabled = True
                dtpExpected.Enabled = False
                lblPoNum.Text = _PoNumber
                lblPoStat.Text = _mode
            Case "complete"
                Me.Text = "Order"
                lblSku.Visible = False
                txtSku.Visible = False
                btnLookup.Visible = False
                btnVoid.Text = "Print/Email Order"
                btnProcess.Text = "Exit"
                btnUp.Visible = False
                btnDown.Visible = False
                btnEdit.Visible = False
                btnDelete.Visible = False
                txtPoNo.Enabled = False
                cbShipping.Enabled = False
                cbTerms.Enabled = False
                txtNote.Enabled = False
                txtShipTo.Enabled = False
                dtpReceived.Enabled = False
                dtpExpected.Enabled = False
                txtmCarriage.Enabled = False
                txtmCarriageTax.Enabled = False
                txtPoTotal.Enabled = False
                txtGrandTotal.Enabled = False
                lblPoNum.Text = _PoNumber
                lblPoStat.Text = _mode
            Case "New"       ' new PO
                dtpReceived.Enabled = False
                lblPoNum.Text = _PoNumber
                lblPoStat.Text = _mode
                txtmCarriage.Text = "0.00"
                txtmCarriageTax.Text = "0.00"
        End Select

        updatePurchaseOrders()

        If lblShipToId.Text <> "Nortech Computers" Then
            MyTable = getCustNameAddress(lblShipToId.Text)  ' I Think the calling form AddPo needs to set the label ID to fix this problem
            If MyTable.Rows.Count > 0 Then
                With MyTable
                    txtShipTo.Text = .Rows(0).Item("title") & " " & .Rows(0).Item("first_name") & " " & .Rows(0).Item("last_name") & vbCrLf
                    txtShipTo.Text = txtShipTo.Text & .Rows(0).Item("add_1") & vbCrLf & .Rows(0).Item("add_2") & vbCrLf & .Rows(0).Item("town") & vbCrLf & .Rows(0).Item("city") & vbCrLf & .Rows(0).Item("postcode")
                End With
            End If
        End If
        updatePoItems()
        ReCalculate()       're-calculate totals
        Me.Cursor = Cursors.WaitCursor
        'Get Terms for Combo Box
        MyTable = getPoTerms()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("po_terms")) Then
                cbTerms.Items.Add(row("po_terms"))
            End If
        Next
        'Get Shipping for Combo Box
        MyTable = getPoShipping()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("ship_type")) Then
                cbShipping.Items.Add(row("ship_type"))
            End If
        Next
        Me.Cursor = Cursors.Arrow
        AddHandler dgvItems.RowsAdded, AddressOf dgvItems_RowsAdded
        txtSku.Focus()
    End Sub
    Private Sub skuLookup()
        Dim MyTable As New DataTable
        Dim line_number As Integer
        Dim f As New frmInventoryList
        Dim item_id As Integer
        Dim SendData As String = txtSku.Text

        item_id = getItem(SendData, SendData, True) 'Lookup item_id by sku or barcode
        If item_id > 0 Then                             'if a single item matches
            line_number = (dgvItems.RowCount + 1)
            addPOItem(item_id, 0.0, _PoNumber, 1.0, (dgvItems.RowCount + 1)) 'Create a new record
            updatePoItems()
            dgvItems.CurrentCell = dgvItems(1, (dgvItems.RowCount - 1))
            itemDetails()
        Else                                            'If no exact match open frmInventoryList in Lookup Mode
            If Not IsOpen(f) Then                       'if child form is already open set focus to the form
                'alter the form to allow an item to be selected
                f.Message = "lookup"                  'call the overrided constructor of the child form
                f.sku = SendData                      'Send the SKU for matching
                If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                    item_id = f.Message            ' Receive back the item_id
                    line_number = (dgvItems.RowCount + 1)
                    addPOItem(item_id, 0.0, _PoNumber, 1.0, (dgvItems.RowCount + 1)) 'Create a new record
                    updatePoItems()
                    dgvItems.CurrentCell = dgvItems(1, (dgvItems.RowCount - 1))
                    itemDetails()
                End If
            End If
        End If
        txtSku.SelectAll()
        txtSku.Focus()
    End Sub
    Private Sub btnLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnLookup.Click
        skuLookup()
    End Sub
    Private Sub dgvItems_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvItems.RowsAdded
        ReCalculate()
    End Sub
    Private Sub ReCalculate()
        Dim total As Decimal = 0.0
        Dim carriage As Decimal '= Convert.ToDecimal(txtmCarriage.Text)
        Dim taxonorder As Decimal = 0.0
        Dim taxoncarriage As Decimal '= Convert.ToDecimal(txtmCarriageTax.Text)
        Dim GrandTotal As Decimal = 0.0

        If txtmCarriage.Text <> "" Then carriage = Convert.ToDecimal(txtmCarriage.Text)
        If txtmCarriageTax.Text <> "" Then taxoncarriage = Convert.ToDecimal(txtmCarriageTax.Text)
        For Each r As DataGridViewRow In dgvItems.Rows
            If dgvItems.Rows(0).Cells(0).Value > 0 Then
                total = total + r.Cells("po_item_cost").Value
            End If
        Next
        taxonorder = total * 0.2
        txtTaxOnOrder.Text = taxonorder 'Format(taxonorder, "decimal")
        taxoncarriage = carriage * 0.2
        txtmCarriageTax.Text = taxoncarriage 'Format(taxoncarriage, "Decimal")
        total = total + carriage
        txtPoTotal.Text = Format(total, "0.00")
        GrandTotal = total + taxonorder + taxoncarriage
        txtGrandTotal.Text = Format(GrandTotal, "Currency")
    End Sub
    Private Sub updatePoItems()
        Dim MyItemsTable As DataTable

        MyItemsTable = getPoItems(_PoNumber)
        dgvItems.DataSource = MyItemsTable
        'dgvItems.Refresh()
        dgvSelectedRow(dgvItems, dgvItems.Rows.Count - 1)
    End Sub
    Private Sub updatePurchaseOrders()
        Dim MyTable As DataTable

        MyTable = getPurchaseOrders(_mode, _PoNumber)
        If MyTable.Rows.Count > 0 Then
            With MyTable
                txtPoNo.Text = .Rows(0).Item("po_id").ToString
                lblPoSupplier.Text = .Rows(0).Item("po_supplier").ToString
                Me.Text = Me.Text & " - " & lblPoSupplier.Text
                cbShipping.Text = .Rows(0).Item("po_shipping").ToString
                cbTerms.Text = .Rows(0).Item("po_terms").ToString
                txtNote.Text = .Rows(0).Item("po_note").ToString
                lblShipToId.Text = .Rows(0).Item("po_shipto").ToString
                dtpExpected.Text = .Rows(0).Item("po_date_expected").ToString
                txtmCarriage.Text = .Rows(0).Item("po_carriage").ToString
                txtmCarriageTax.Text = .Rows(0).Item("po_carriage_tax").ToString
            End With
        End If
    End Sub
    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

  
    Private Sub txtmCarriage_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmCarriageTax.KeyPress, txtmCarriage.KeyPress
        If TrapKey(Asc(e.KeyChar)) Then
            e.KeyChar = ""  'cancel the keypress
        End If
    End Sub
    Private Sub itemDetails()
        Dim f As New frmPoItem
        Dim ReturnData As String = ""

        If Not IsOpen(f) Then                            'if child form is already open set focus to the form
            If dgvItems.RowCount > 0 Then               ' if there are items in the grid
                With dgvItems
                    f.poitem_id = .SelectedRows(0).Cells("po_item_id").Value    'call the overrided constructor of the child form
                    f.item_id = .SelectedRows(0).Cells("item_id").Value
                    f.sku = .SelectedRows(0).Cells("item_stockcode").Value
                    f.description = .SelectedRows(0).Cells("item_description").Value
                    f.barcode = .SelectedRows(0).Cells("item_barcode").Value
                    f.quantity = .SelectedRows(0).Cells("item_quantity").Value
                    f.cost = .SelectedRows(0).Cells("item_price").Value
                    f.weight = .SelectedRows(0).Cells("item_weight").Value
                End With
            End If
            If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                updatePoItemCostQuantity(f.poitem_id, f.cost, f.quantity)   'update po_item cost and quantity
                updateItemWeight(f.item_id, f.weight)       'update item weight
                updatePoItems()     ' update display
                ReCalculate()       're-calculate totals
            End If
        End If
        f.Focus()
    End Sub
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        itemDetails()
    End Sub

    Private Sub txtSku_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSku.KeyPress
        'detect the enter key and process the code in the lookup button
        If Asc(e.KeyChar) = 13 Then
            'MsgBox("You hit the return key")
            e.KeyChar = ""   'cancel the keypress
            skuLookup() 'btnLookup_Click(btnLookup, Nothing)

        End If

        'btnLookup_Click(Me, btnLookup.Click)
    End Sub

    Private Sub btnVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnVoid.Click
        'Remove all the items from the PO and then remove the PO record
        Dim f As New frmDialog
        If _mode = "complete" Then
            'deal with print request
            MsgBox("Print or email")
        Else
            If Not IsOpen(f) Then                            'if child form is already open set focus to the form
                f.title = "Confirm"                  'call the overrided constructor of the child form
                f.message = "You are about to totally delete the Purchase Order, this change is permenant. Click OK to delete or cancel to abort the change"
                f.okOnly = False
                f.okButtonText = "OK"
                If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                    deletePoItems(_PoNumber)                    ' delete all items
                    deletePurchaseOrder(_PoNumber)              ' delete PO
                    Me.Close()                                  ' close the form
                Else
                    'MsgBox("You didn't press OK")
                End If
            End If
            f.Focus()
        End If
    End Sub

    Private Sub btnProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnProcess.Click
        'save additional data changes and update prices
        Dim f As New frmDialog
        Dim MyItemsTable As DataTable

        If Not IsOpen(f) Then                            'if child form is already open set focus to the form

            Select Case _mode
                Case "pending"
                    f.title = "Save or Process"                  'call the overrided constructor of the child form
                    f.message = "Please select Save to send the order later or Process to submit the order"
                    f.okOnly = False
                    f.okButtonText = "Save"
                    f.cxlButtonText = "Process"
                    If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                        'remain as pending
                        updatePoStatus(_PoNumber, _mode, cbShipping.Text, cbTerms.Text, lblShipToId.Text, txtNote.Text, dtpExpected.Value, txtmCarriage.Text, txtmCarriageTax.Text, txtPoTotal.Text, txtTaxOnOrder.Text)
                        Me.Close()                                  ' close the form
                    Else
                        'Save as order
                        updatePoStatus(_PoNumber, "ordered", cbShipping.Text, cbTerms.Text, lblShipToId.Text, txtNote.Text, dtpExpected.Value, txtmCarriage.Text, txtmCarriageTax.Text, txtPoTotal.Text, txtTaxOnOrder.Text)
                        MsgBox("Ordered")
                        Me.Close()
                    End If
                Case "new"
                    f.title = "Save or Process"                  'call the overrided constructor of the child form
                    f.message = "Please select Save to send the order later or Process to submit the order"
                    f.okOnly = False
                    f.okButtonText = "Save"
                    f.cxlButtonText = "Process"
                    If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                        'remain as or convert to pending
                        updatePoStatus(_PoNumber, "pending", cbShipping.Text, cbTerms.Text, lblShipToId.Text, txtNote.Text, dtpExpected.Value, txtmCarriage.Text, txtmCarriageTax.Text, txtPoTotal.Text, txtTaxOnOrder.Text)
                        Me.Close()                                  ' close the form
                    Else
                        'Save as order
                        updatePoStatus(_PoNumber, "ordered", cbShipping.Text, cbTerms.Text, lblShipToId.Text, txtNote.Text, dtpExpected.Value, txtmCarriage.Text, txtmCarriageTax.Text, txtPoTotal.Text, txtTaxOnOrder.Text)
                        MsgBox("Ordered")
                        Me.Close()
                    End If
                Case "ordered"
                    f.title = "Save or Receive"                  'call the overrided constructor of the child form
                    f.message = "Please select Save to receive the goods later or Receive to receive the goods into stock"
                    f.okOnly = False
                    f.okButtonText = "Save"
                    f.cxlButtonText = "Receive"
                    If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                        'remain as ordered
                        updatePoStatus(_PoNumber, _mode, cbShipping.Text, cbTerms.Text, lblShipToId.Text, txtNote.Text, dtpExpected.Value, txtmCarriage.Text, txtmCarriageTax.Text, txtPoTotal.Text, txtTaxOnOrder.Text)
                        MsgBox("Saved to receive later")
                        Me.Close()                                  ' close the form
                    Else
                        'Save as completed
                        updatePoStatus(_PoNumber, "complete", cbShipping.Text, cbTerms.Text, lblShipToId.Text, txtNote.Text, dtpExpected.Value, txtmCarriage.Text, txtmCarriageTax.Text, txtPoTotal.Text, txtTaxOnOrder.Text, dtpReceived.Value)
                        'insert code here to receive the items into stock


                        Dim item_id As Integer
                        Dim item_quantity As Double

                        MyItemsTable = getPoItems(_PoNumber)                    ' 1. Get a table of all the items in the order
                        For Each row As DataRow In MyItemsTable.Rows            ' 2. for each item update the record in item_stock 
                            item_id = row.Item("item_id")
                            item_quantity = row.Item("item_quantity")
                            updateItemStock(item_id, item_quantity)             ' 3. add items to in_stock
                        Next
                        DialogBox("Received into Stock")
                        Me.Close()
                    End If

            End Select

            
        End If
        f.Focus()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtmCarriage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmCarriage.TextChanged
        If IsNumeric(txtmCarriage.Text) Then ReCalculate()
    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        Dim oldLine As Integer
        Dim newLine As Integer
        Dim po_item_id, po_item_id_2 As Integer

        If dgvItems.Rows.Count > 1 Then     'cant reorder lines if you have less than 2 lines
            If dgvItems.SelectedRows(0).Cells("line_number").Value > 1 And dgvItems.SelectedRows(0).Cells("line_number").Value <= dgvItems.Rows.Count Then
                oldLine = dgvItems.SelectedRows(0).Cells("line_number").Value
                po_item_id = dgvItems.SelectedRows(0).Cells("po_item_id").Value
                newLine = oldLine - 1
                po_item_id_2 = getPoItemId(_PoNumber, newLine) 'get id for second line to be moved
                updateLineNumber(po_item_id, oldLine, newLine) 'Update 1st line
                updateLineNumber(po_item_id_2, newLine, oldLine) 'Update 2nd line
                updatePoItems()     ' update display
                dgvSelectedRow(dgvItems, newLine)
            End If
        End If
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        Dim oldLine As Integer
        Dim newLine As Integer
        Dim po_item_id, po_item_id_2 As Integer

        If dgvItems.Rows.Count > 1 Then     'cant reorder lines if you have less than 2 lines
            If dgvItems.SelectedRows(0).Cells("line_number").Value > 0 And dgvItems.SelectedRows(0).Cells("line_number").Value < dgvItems.Rows.Count Then
                oldLine = dgvItems.SelectedRows(0).Cells("line_number").Value
                po_item_id = dgvItems.SelectedRows(0).Cells("po_item_id").Value
                newLine = oldLine + 1
                po_item_id_2 = getPoItemId(_PoNumber, newLine) 'get id for second line to be moved
                updateLineNumber(po_item_id, oldLine, newLine) 'Update 1st line
                updateLineNumber(po_item_id_2, newLine, oldLine) 'Update 2nd line
                updatePoItems()     ' update display
                dgvSelectedRow(dgvItems, newLine)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim oldLine As Integer
        Dim newLine As Integer
        Dim po_item_id As Integer
        Dim MyItemsTable As DataTable

        If dgvItems.Rows.Count > 0 Then
            oldLine = dgvItems.SelectedRows(0).Cells("line_number").Value
            po_item_id = dgvItems.SelectedRows(0).Cells("po_item_id").Value

            MyItemsTable = getPoItems(_PoNumber)                    ' 1. Get a table of all the items in the order, ordered by line number
            For Each row As DataRow In MyItemsTable.Rows            ' 2. for each item  
                If row.Item("line_number") = oldLine Then           ' 3. If line is selected row then delete line
                    deleteLineNumber(po_item_id, oldLine) 'delete oldline
                ElseIf row.Item("line_number") > oldLine Then       ' 4. If line number is higher than deleted line
                    newLine = row.Item("line_number")               ' 5. Get newLine number
                    po_item_id = row.Item("po_item_id")             ' 5. Get po_item_id
                    updateLineNumber(po_item_id, newLine, oldLine)    ' 6. Change line number (newLine) to that of the deleted line (oldLine)
                    oldLine += 1    'increment line number
                End If
            Next
            updatePoItems()                                   ' 7. update list
            dgvSelectedRow(dgvItems, newLine)                 ' 8. Set selected row
        End If
    End Sub


End Class