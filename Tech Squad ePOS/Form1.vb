Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim my_id As Integer

        If Integer.TryParse(txtID.Text, my_id) Then
            get_company(my_id)
        Else
            MsgBox("You must enter a company Id to look up a company")
        End If
    End Sub

    Private Sub get_company(id As Integer)
        Dim my_company As New company
        
        my_company.company_id = id
        my_company.get_from_db()
        If my_company.success Then
            With my_company
                txtID.Text = .company_id
                txtName.Text = .company_name
                txtVAT_Number.Text = .vat_number
                txtAddressID.Text = .address_id
                txtContactID.Text = .contact_id
                txtMerchantID.Text = .merchant_id
                txtReceiptID.Text = .receipt_id
                chkVAT.Checked = .vat_registered
            End With
        Else
            MsgBox(my_company.error_message)
        End If
        
    End Sub
    Private Sub save_company()
        Dim my_company As New company
        Dim my_chk_box As Integer = 0

        With my_company
            If Not Integer.TryParse(txtID.Text, .company_id) Then ' if result is false - cannot parse text to number then
                .company_id = 0 ' make sure company id has a number in it
            Else
                .company_id = txtID.Text
            End If
            .company_name = txtName.Text
            .vat_number = txtVAT_Number.Text
            .address_id = txtAddressID.Text
            .contact_id = txtContactID.Text
            .merchant_id = txtMerchantID.Text
            .receipt_id = txtReceiptID.Text
            If chkVAT.Checked Then my_chk_box = 1
            .vat_registered = my_chk_box
            If .company_name <> "" Then
                .save_to_db()
            Else
                MsgBox("You must enter a Company Name")
            End If
            If .success Then
                get_company(.company_id)    ' get saved details back and re-display to confirm
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        save_company()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim my_invoice As New ClassInvoice

        'With my_invoice
        '    .inv_number = 23
        '    .get_from_db()
        '    If Not .success Then
        '        MsgBox("Invoice lookup failed: " * .error_message)
        '    Else
        '        txtID.Text = .inv_number
        '        txtName.Text = .cust_id
        '        txtVAT_Number.Text = .inv_date
        '        txtAddressID.Text = .address_id
        '        txtContactID.Text = .total_tax
        '        txtMerchantID.Text = .user_id
        '        For Each item In .items
        '            ListBox1.Items.Add(item.inv_item_id & ", " & item.inv_number & ", " & item.item_id & ", " & item.quantity & ", " & item.line_number)
        '        Next

        '    End If
        'End With
        'my_invoice = newInvoice()     'temporary function to create an invoice and return it
        my_invoice = getInvoice(112)    ' example of getting an invoice from database
        ' this is a LINQ query against a list of objects
        Dim query = From invoice_items As ClassInvoiceItems In my_invoice.items
                    Where invoice_items.line_number = 8
                    Select invoice_items
                    Order By invoice_items.price_sold Descending
        For Each invoice_items As ClassInvoiceItems In query
            invoice_items.price_sold = 99.99
            my_invoice.save_to_db()
            If Not my_invoice.success Then
                MsgBox(my_invoice.error_message)
            Else
                ListBox1.Items.Add("Inv No:- " & invoice_items.inv_number & " | Line No:- " & invoice_items.line_number & " | £ " & invoice_items.price_sold)
            End If
        Next
    End Sub
    Private Function newInvoice() As ClassInvoice
        Dim my_invoice As New ClassInvoice

        With my_invoice ' create and save new invoice with items
            .cust_id = 2
            .address_id = 2
            .total_tax = 0.0
            .user_id = 1
            .items.Add(New ClassInvoiceItems(, , , 1, 1, 1.01))  ' add line item - inv_number not required as it is a new invoice so the class will issue and insert into database
            .items.Add(New ClassInvoiceItems(, , , 1, 2, 1.12))  ' inv_item_id, inv_number, item_id, quantity, line_number, price_sold
            .items.Add(New ClassInvoiceItems(, , , 1, 3, 1.23))  ' add line item
            .items.Add(New ClassInvoiceItems(, , , 1, 4, 1.34))  ' add line item
            .items.Add(New ClassInvoiceItems(, , , 1, 5, 1.45))  ' add line item
            .items.Add(New ClassInvoiceItems(, , , 1, 6, 1.56))  ' add line item
            .items.Add(New ClassInvoiceItems(, , , 1, 7, 1.67))  ' add line item
            .items.Add(New ClassInvoiceItems(, , , 1, 8, 1999999.7888))  ' add line item
            .save_to_db()   ' save invoice with line items
            If Not .success Then
                MsgBox(.error_message)
            End If
        End With
        Return my_invoice
    End Function
    Private Function getInvoice(inv_number As Integer) As ClassInvoice
        Dim my_invoice As New ClassInvoice

        With my_invoice
            .inv_number = inv_number
            .get_from_db()
        End With
        Return my_invoice
    End Function
End Class
