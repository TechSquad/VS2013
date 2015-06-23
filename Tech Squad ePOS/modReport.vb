Module modReport
    Function getPurchaseOrdersReport(po_status As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT DAY(po_date_received) as Date, po_supplier as Supplier, SUM(po_total) as Total FROM purchase_order WHERE po_status = 'complete' GROUP BY Date"
        'Dim sqlQuery As String = "SELECT DATE(po_date_received) as Date, po_supplier as Supplier, SUM(po_total) as Total FROM purchase_order WHERE po_status = 'complete' GROUP BY DATE(po_date_received)"
        'DATE(po_date_received)
        'Get PO's
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
    Function getPoItemsReport()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String ' = "SELECT po_item.line_number, po_item.po_item_id, item.item_stockcode, item.item_barcode, item.item_manufacturer, item.item_description, item.item_price, po_item.po_item_cost, po_item.item_quantity, item.item_weight, item.item_id FROM po_item INNER JOIN item ON po_item.item_id=item.item_id"

        sqlQuery = "SELECT item.item_stockcode as SKU, po_item_cost , SUM(item_quantity) as Quantity FROM po_item INNER JOIN item ON po_item.item_id=item.item_id GROUP BY po_item.item_id"


        'Get PO's
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
End Module
