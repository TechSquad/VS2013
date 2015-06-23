Module modSqlInvoice
    ''' <summary>
    ''' Gets all invoices for a customer id
    ''' </summary>
    ''' <param name="cust_id"></param>
    ''' <returns></returns>
    ''' A table of results
    ''' <remarks></remarks>
    Public Function getInvoiceHistory(cust_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String = "SELECT * FROM invoice WHERE cust_id = '" & cust_id & "'"
        Dim MyTable As New DataTable

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
        Return (MyTable)
    End Function
    Function getInvoiceItems(inv_number As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT invoice_item.inv_item_id, item.item_stockcode, item.item_barcode, item.item_manufacturer, item.item_description, item.item_price, invoice_item.quantity, item.item_weight, item.item_id FROM invoice_item INNER JOIN item ON invoice_item.item_id=item.item_id WHERE invoice_item.inv_number = '" & inv_number & "'"
        ' " ORDER BY inv_item_id" = display in ordered entered 

        'Get Invoice Items
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
        Return (MyTable)
    End Function
    Function getInvoiceItemsLine(inv_number As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim vat_rate As Double = 0.2
        Dim sqlQuery As String = "SELECT item.item_stockcode, item.item_description, invoice_item.quantity, item_price.price_1, item_price.ti_price_1 - item_price.price_1 as VAT, item_price.ti_price_1, (item_price.ti_price_1 * invoice_item.quantity) AS Total, item_stock.in_stock, item_stock.supplier_stock, item_picture.picture_location FROM invoice_item  INNER JOIN item ON invoice_item.item_id = item.item_id  INNER JOIN item_price ON invoice_item.item_id = item_price.item_id INNER JOIN item_stock ON invoice_item.item_id = item_stock.item_id INNER JOIN item_picture ON invoice_item.item_id = item_picture.item_id WHERE invoice_item.inv_number = '" & inv_number & "'"

        'Get Invoice Item in single line
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
        Return (MyTable)
    End Function
    Public Function addInvoice(Optional cust_id As Integer = 0, Optional address_id As Integer = 0, Optional total_tax As Double = 0.0)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO invoice (cust_id , address_id , total_tax) "
        sqlQuery = sqlQuery & "VALUES ('" & cust_id & "','" & address_id & "','" & total_tax & "')"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        Return (classSql.LastInsertedId)
    End Function
    Public Function addInvoiceItem(inv_number As Integer, item_id As Integer, quantity As Double, line_number As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO invoice_item (inv_number , item_id , quantity , line_number) "
        sqlQuery = sqlQuery & "VALUES ('" & inv_number & "','" & item_id & "','" & quantity & "','" & line_number & "')"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        Return (classSql.LastInsertedId)
    End Function
    Public Function deleteInvoiceItems(_InvNumber)                    ' delete all items
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "DELETE FROM invoice_item WHERE inv_number='" & _InvNumber & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        deleteInvoiceItems = classSql.rowsAffected
    End Function

    Public Function deleteInvoice(_InvNumber)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "DELETE FROM invoice WHERE inv_number='" & _InvNumber & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        End If
        deleteInvoice = classSql.rowsAffected
    End Function
End Module
