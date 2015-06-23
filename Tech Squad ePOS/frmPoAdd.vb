Public Class frmPoAdd

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewPO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim MyTable As DataTable

        Me.Cursor = Cursors.WaitCursor
        'Get Supplier for Combo Box
        MyTable = getSuppliers()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("supplier_name")) Then
                cbSupplier.Items.Add(row("supplier_name"))
            End If
        Next
        'Get Terms for Combo Box
        MyTable = getPoTerms()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("po_terms")) Then
                cbTerms.Items.Add(row("po_terms"))
            End If
        Next
        cbTerms.Text = cbTerms.Items(0)     'set default setting
        'Get Shipping for Combo Box
        MyTable = getPoShipping()
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("ship_type")) Then
                cbShipping.Items.Add(row("ship_type"))
            End If
        Next
        cbShipping.Text = cbShipping.Items(0)   'set default setting
        lblShipToId.Text = "0"
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cbSupplier_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbSupplier.SelectedIndexChanged
        'Update supplier info box
        Dim MyTable As DataTable
        Dim address_id As Integer = getSupplierAddressId(cbSupplier.Text.ToString)

        MyTable = getAddress(, address_id)
        If address_id > 0 Then
            txtSupplierInfo.Text = MyTable.Rows(0).Item("add_1") & vbCrLf & MyTable.Rows(0).Item("add_2") & vbCrLf & MyTable.Rows(0).Item("town") & vbCrLf & MyTable.Rows(0).Item("city") & vbCrLf & MyTable.Rows(0).Item("postcode")
            txtShipTo.Text = "Nortech Computers"
        Else
            txtSupplierInfo.Text = ""
            txtShipTo.Text = "Nortech Computers"
        End If
    End Sub

    Private Sub btnChangeShipTo_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeShipTo.Click
        Dim f As New frmCustomer
        Dim ReturnData As Integer = 0
        Dim MyTable As DataTable

        If Not IsOpen(f) Then                            'if child form is already open set focus to the form
            f.Message = "pick_customer"                  'call the overrided constructor of the child form
            If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                ReturnData = f.Message
            End If
        End If
        f.Focus()
        'txtMessage.Text = ReturnData                        'Do something with the returned data
        If ReturnData > 0 Then
            MyTable = getCustomer(ReturnData)
            txtShipTo.Text = MyTable.Rows(0).Item("title") & " " & MyTable.Rows(0).Item("first_name") & " " & MyTable.Rows(0).Item("last_name") & vbCrLf
            MyTable = getAddress(ReturnData)
            txtShipTo.Text = txtShipTo.Text & MyTable.Rows(0).Item("add_1") & vbCrLf & MyTable.Rows(0).Item("add_2") & vbCrLf & MyTable.Rows(0).Item("town") & vbCrLf & MyTable.Rows(0).Item("city") & vbCrLf & MyTable.Rows(0).Item("postcode")
            lblShipToId.Text = MyTable.Rows(0).Item("cust_id")
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmPoDetail
        Dim ReturnData As String = ""
        Dim result As Integer

        'Write record to database
        If validate_input() Then
            result = addPO(cbSupplier.Text, "new", cbShipping.Text, cbTerms.Text, lblShipToId.Text, "")   ' create new PO record
            'Open PO Detail Form and wait for result
            If Not IsOpen(f) Then                            'if child form is already open set focus to the form
                f.PoNumber = result                            'call the overrided constructor of the child form and pass PO NUmber
                f.Mode = "new"
                If f.ShowDialog() = DialogResult.OK Then     'Open as dialog to wait for return value
                    ReturnData = f.Mode
                    Me.Close()
                End If
            End If
            f.Focus()
            'txtMessage.Text = ReturnData                        'Do something with the returned data

        End If
    End Sub
    Private Function validate_input()
        Dim success As Boolean = False
        Dim count As Integer = 0

        For Each ctrl As Control In Me.Controls
            If ctrl.Text = "" Then
                If ctrl.Name <> "txtSupplierInfo" Then      'Exclude supplier info as its read only
                    ctrl.BackColor = Color.Red
                    ctrl.Refresh()
                    count += 1
                End If

            End If
        Next
        For Each ctrl As Control In Me.grpPurchaseOrder.Controls
            If ctrl.Text = "" Then
                ctrl.BackColor = Color.Red
                ctrl.Refresh()
                count += 1
            Else
                ctrl.BackColor = Color.White
            End If
        Next
        If count = 0 Then success = True
        Return (success)
    End Function

End Class