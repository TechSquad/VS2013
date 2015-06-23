Public Class frmPurchaseOrders
    Private po_status As String
    Private Sub frmPurchaseOrders_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        updatePorders()
        updateItems()
    End Sub
    Private Sub frmPurchaseOrders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Purchase Orders" Then
            po_status = "pending"
        ElseIf Me.Text = "Receive Orders" Then
            po_status = "ordered"
            btnCreatePo.Visible = False
            btnEdit.Text = "Receive Goods"
            btnVoid.Text = "Void Order"
        ElseIf Me.Text = "Order History" Then
            btnCreatePo.Visible = False
            btnVoid.Visible = False
            btnEdit.Text = "View Order"
            po_status = "complete"
        End If
        updateSuppliers()
        With dgvSuppliers
            .Columns("id").Width = 25
            .Columns("supplier_name").Width = 250
        End With
        updatePorders()
        updateItems()
    End Sub
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub btnCreatePo_Click(sender As System.Object, e As System.EventArgs) Handles btnCreatePo.Click
        Dim mdi_frmAddNewPO As New frmPoAdd

        If Not IsOpen(mdi_frmAddNewPO) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmAddNewPO
                .MdiParent = frmMainMenu
                .Show()
                ' pass over _mode
                ' No po_number to pass as this is a new record
                frmMainMenu.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
    End Sub
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
        Dim f As New frmPoDetail
        Dim ReturnData As String = dgvPurchaseOrders.CurrentRow.Cells(0).Value

        If Not IsOpen(f) Then                           ' if form is not open 
            f.PoNumber = ReturnData                            'call the overrided constructor of the child form
            f.Mode = po_status                                 ' set form to PO mode
                If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                    updatePorders()
                    updateItems()
                End If
            End If
            f.Focus()       'if child form is already open set focus to the form
    End Sub

    Private Sub btnVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnVoid.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
        'Remove all the items from the PO and then remove the PO record
        Dim f As New frmDialog

        If Not IsOpen(f) Then                            'if child form is already open set focus to the form
            f.title = "Confirm"                  'call the overrided constructor of the child form
            f.message = "You are about to totally delete the Purchase Order, this change is permenant. Click OK to delete or cancel to abort the change"
            f.okOnly = False
            f.okButtonText = "OK"
            If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                deletePoItems(dgvPurchaseOrders.CurrentRow.Cells(0).Value)                    ' delete all items
                deletePurchaseOrder(dgvPurchaseOrders.CurrentRow.Cells(0).Value)              ' delete PO
                'MsgBox("po_id = " & dgvPurchaseOrders.CurrentRow.Cells(0).Value)
                updatePorders()
                updateItems()
            Else
                'MsgBox("You didn't press OK")
            End If
        End If
        f.Focus()
    End Sub
    Private Sub dgvPurchaseOrders_SelectionChanged(sender As Object, e As System.EventArgs) Handles dgvPurchaseOrders.SelectionChanged
        updateItems()
    End Sub
    Private Sub updateItems()
        Dim MyItemsTable As DataTable
        If dgvPurchaseOrders.SelectedRows(0).Cells("po_id").Value > 0 Then
            MyItemsTable = getPoItems(dgvPurchaseOrders.SelectedRows(0).Cells("po_id").Value)
            dgvPoItems.DataSource = MyItemsTable
            dgvPoItems.Refresh()
            'Timer1.Enabled = True
        End If
    End Sub
    Sub updatePorders()
        Dim MyTable As DataTable
        RemoveHandler dgvPurchaseOrders.SelectionChanged, AddressOf dgvPurchaseOrders_SelectionChanged  'stop events firing during data fill
        MyTable = getPurchaseOrders(po_status)
        If MyTable.Rows.Count > 0 Then
            dgvPurchaseOrders.DataSource = MyTable
            dgvPurchaseOrders.Refresh()
        End If
        AddHandler dgvPurchaseOrders.SelectionChanged, AddressOf dgvPurchaseOrders_SelectionChanged 're-instate events
    End Sub
    Sub updateSuppliers()
        Dim MySuppliersTable As DataTable

        MySuppliersTable = getSuppliers()
        If MySuppliersTable.Rows.Count > 0 Then
            dgvSuppliers.DataSource = MySuppliersTable
            dgvSuppliers.Refresh()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'Timer delays the handler to give time for the dgv to be completed
        'AddHandler dgvPurchaseOrders.SelectionChanged, AddressOf dgvPurchaseOrders_SelectionChanged 're-instate events
        Timer1.Enabled = False
    End Sub
End Class