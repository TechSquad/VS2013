Public Class frmCompany

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_company(1)  ' there is only one company for this software
    End Sub
    Private Sub get_company(id As Integer)
        Dim my_company As New company
        Dim receipt_info As New receipt
        Dim my_address As New address
        Dim my_contact As New contact
        Dim my_merchant As New merchant
        Dim my_terminal As New terminal

        my_company.company_id = id
        my_company.get_from_db()
        If my_company.success Then
            With my_company
                'txtID.Text = .company_id
                txtCoName.Text = .company_name
                txtTradingName.Text = .trading_name
                txtVAT.Text = .vat_number
                txtAdd1.Text = .address_id
                txtEmail.Text = .contact_id
                txtMerchantNo.Text = .merchant_id
                txtReceiptHeader.Text = .receipt_id
                If .vat_registered Then txtVAT.Text = .vat_number
            End With
        Else
            MsgBox(my_company.error_message)
        End If
        receipt_info.receipt_id = my_company.receipt_id
        receipt_info.get_from_db()
        If receipt_info.success Then
            With receipt_info
                txtReceiptHeader.Text = .receipt_header
                txtReceiptFooter.Text = .receipt_footer
            End With
        End If
        my_address.address_id = my_company.address_id
        my_address.get_from_db()
        If my_address.success Then
            With my_address
                txtAdd1.Text = .add_1
                txtAdd2.Text = .add_2
                txtTown.Text = .town
                txtCity.Text = .city
                txtPostcode.Text = .postcode
            End With
        End If
        my_contact.contact_id = my_company.contact_id
        my_contact.get_from_db()
        If my_contact.success Then
            With my_contact
                txtEmail.Text = .email
                txtPhone.Text = .home_tel
            End With
        End If
        my_merchant.merchant_id = my_company.merchant_id
        my_merchant.get_from_db()
        If my_merchant.success Then
            With my_merchant
                txtHelpline.Text = .merchant_phone
            End With
        End If
        my_terminal.merchant_id = my_merchant.merchant_id
        my_terminal.get_from_db()
        If my_terminal.success Then
            With my_terminal
                txtMerchantNo.Text = .merchant_number
                txtTerminal.Text = .terminal_make & " " & .terminal_model
            End With
        End If
    End Sub
    Private Sub save_company()  ' this is not required here but it is an example of how to save the company details so it will come in useful somewhere
        Dim my_company As New company
        Dim my_chk_box As Integer = 0

        With my_company
            'If Not Integer.TryParse(txtID.Text, .company_id) Then ' if result is false - cannot parse text to number then
            '.company_id = 0 ' make sure company id has a number in it
            'Else
            ' .company_id = txtID.Text
            'End If
            .company_name = txtCoName.Text
            .vat_number = txtVAT.Text
            .address_id = txtAdd1.Text
            .contact_id = txtEmail.Text
            .merchant_id = txtMerchantNo.Text
            .receipt_id = txtReceiptHeader.Text
            .vat_registered = txtVAT.Text
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
End Class