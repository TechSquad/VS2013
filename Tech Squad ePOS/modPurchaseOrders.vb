Module modPurchaseOrders
    Function getPurchaseOrders(po_status As String, Optional po_id As Integer = 0)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM purchase_order WHERE po_status = '" & po_status & "'"
        If po_id > 0 Then sqlQuery = "SELECT * FROM purchase_order WHERE po_id ='" & po_id & "' AND po_status = '" & po_status & "'"
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
    Function getSuppliers()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT supplier_id AS 'id', supplier_name FROM supplier"

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
    Function getPoItems(po_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT po_item.line_number, po_item.po_item_id, item.item_stockcode, item.item_barcode, item.item_manufacturer, item.item_description, item.item_price, po_item.po_item_cost, po_item.item_quantity, item.item_weight, item.item_id FROM po_item INNER JOIN item ON po_item.item_id=item.item_id WHERE po_item.po_id = '" & po_id & "' ORDER BY po_item.line_number "
        'WHERE po_id = '" & po_id & "' ORDER BY line_number 

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
    Function getPoTerms()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT po_terms FROM po_terms"

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
    Function getPoShipping()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT ship_type FROM po_shipping"

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
    Function getSupplierAddressId(supplier_name As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT address_id FROM supplier WHERE supplier_name = '" & supplier_name & "'"
        Dim address_id As Integer = 0

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
        If classSql.RecCount > 0 Then address_id = MyTable.Rows(0).Item("address_id")
        Return (address_id)
    End Function
    Public Function addPO(po_supplier As String, po_status As String, po_shipping As String, po_terms As String, po_shipto As String, po_note As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO purchase_order (po_supplier , po_status , po_shipping , po_terms , po_shipto , po_note) "
        sqlQuery = sqlQuery & "VALUES ('" & po_supplier & "','" & po_status & "','" & po_shipping & "','" & po_terms & "','" & po_shipto & "','" & po_note & "')"
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
    Public Function addPOItem(item_id As Integer, po_item_cost As Double, po_id As Integer, item_quantity As Double, line_number As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO po_item (item_id , po_item_cost , po_id , item_quantity , line_number) "
        sqlQuery = sqlQuery & "VALUES ('" & item_id & "','" & po_item_cost & "','" & po_id & "','" & item_quantity & "','" & line_number & "')"
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
    Public Function updatePoItemCostQuantity(po_item_id As Integer, item_cost As Double, item_quantity As Double)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE po_item SET po_item_cost='" & item_cost & "', item_quantity='" & item_quantity & "' WHERE po_item_id='" & po_item_id & "'"
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
        Return (classSql.rowsAffected)
    End Function
    Public Function updatePoStatus(po_id As Integer, po_status As String, po_shipping As String, po_terms As String, po_shipto As String, po_note As String, po_date_expected As Date, po_carriage As String, po_carriage_tax As String, po_total As String, po_tax As String, Optional po_date_received As Date = Nothing)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim dte As String = ""
        Dim dtr As String = ""

        dte = po_date_expected.ToString 'Format(po_date_expected, "mm-dd-yyyy hh:mm:ss").ToString
        If po_date_received <> Nothing Then dtr = po_date_received.ToString

        If po_status = "ordered" Then
            sqlQuery = "UPDATE purchase_order SET po_status='" & po_status & "', po_shipping='" & po_shipping & "', po_terms='" & po_terms & "', po_shipto='" & po_shipto & "', po_note='" & po_note & "', po_date_expected=STR_TO_DATE('" & dte & "','%d/%m/%Y %T')" & ", po_carriage='" & po_carriage & "', po_carriage_tax='" & po_carriage_tax & "', po_total='" & po_total & "', po_tax='" & po_tax & "', po_date_ordered=NOW() WHERE po_id='" & po_id & "'"
        ElseIf po_status = "pending" Then
            sqlQuery = "UPDATE purchase_order SET po_status='" & po_status & "', po_shipping='" & po_shipping & "', po_terms='" & po_terms & "', po_shipto='" & po_shipto & "', po_note='" & po_note & "', po_date_expected=STR_TO_DATE('" & dte & "','%d/%m/%Y %T')" & ", po_carriage='" & po_carriage & "', po_carriage_tax='" & po_carriage_tax & "', po_total='" & po_total & "', po_tax='" & po_tax & "' WHERE po_id='" & po_id & "'"
        Else 'If po_status = "completed" Then
            sqlQuery = "UPDATE purchase_order SET po_status='" & po_status & "', po_shipping='" & po_shipping & "', po_terms='" & po_terms & "', po_shipto='" & po_shipto & "', po_note='" & po_note & "', po_date_expected=STR_TO_DATE('" & dte & "','%d/%m/%Y %T')" & ", po_carriage='" & po_carriage & "', po_carriage_tax='" & po_carriage_tax & "', po_total='" & po_total & "', po_tax='" & po_tax & "', po_date_received=STR_TO_DATE('" & dtr & "','%d/%m/%Y %T') WHERE po_id='" & po_id & "'"
        End If
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
        Return (classSql.rowsAffected)
    End Function
    Public Function updateItemStock(item_id As Integer, item_quantity As Double)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE item_stock SET in_stock=in_stock +'" & item_quantity & "' WHERE item_id='" & item_id & "'"
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
        Return (classSql.rowsAffected)
    End Function
    Public Function deletePurchaseOrder(po_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "DELETE FROM purchase_order WHERE po_id='" & po_id & "'"
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
        deletePurchaseOrder = classSql.rowsAffected
    End Function
    Public Function deletePoItems(po_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "DELETE FROM po_item WHERE po_id='" & po_id & "'"
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
        deletePoItems = classSql.rowsAffected
    End Function
    Public Function updateLineNumber(po_item_id As Integer, oldLine As Integer, newLine As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "update po_item SET line_number ='" & newLine & "' WHERE po_item_id='" & po_item_id & "' AND line_number = '" & oldLine & "'"
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
        updateLineNumber = classSql.rowsAffected
    End Function
    Public Function deleteLineNumber(po_item_id As Integer, lineNumber As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "DELETE FROM po_item WHERE po_item_id='" & po_item_id & "' AND line_number = '" & lineNumber & "'"
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
        deleteLineNumber = classSql.rowsAffected
    End Function
    Function getPoItemId(po_id As Integer, line_number As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT po_item_id FROM po_item where po_id ='" & po_id & "' AND line_number ='" & line_number & "'"

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
        Return (MyTable.Rows(0).Item("po_item_id"))
    End Function
    
End Module
