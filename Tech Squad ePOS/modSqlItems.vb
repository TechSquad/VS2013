Module modSqlItems
    ''' <summary>
    ''' Gets item records based on item_id or item_stockcode or item_barcode
    ''' </summary>
    ''' <param name="item_stockcode"></param>
    ''' <param name="item_barcode"></param>
    ''' <returns>A table of results</returns>
    ''' <remarks>
    ''' All arguments are optional but if you leave them all blank you will get an empty table, you should normally only select one argument to return one record
    ''' each argument should be unique to one record but beware barcode may relate to more than one record if product barcodes are issued incorrectly as is sometimes
    ''' the way things are done in China
    '''</remarks>
    Function getItem(Optional item_stockcode As String = "", Optional item_barcode As String = "", Optional exact As Boolean = False)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM item WHERE item_stockcode LIKE '%" & item_stockcode & "%' OR item_barcode LIKE '%" & item_barcode & "%' ORDER BY item_stockcode"

        If exact Then sqlQuery = "SELECT * FROM item WHERE item_stockcode ='" & item_stockcode & "' OR item_barcode ='" & item_barcode & "'"
        'Get item Detail
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
        If exact Then
            If MyTable.Rows.Count > 0 Then
                Return (MyTable.Rows(0).Item("item_id"))
            End If
        Else
            Return (MyTable)
        End If
        Return (False)
    End Function
    ''' <summary>
    ''' Gets all records in the items table
    ''' </summary>
    ''' <returns>Table if items</returns>
    ''' <remarks>Used to populate a datagridview of all inventory items</remarks>
    Function getAllItems()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM item"

        'Get item Detail
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
    Function getItemCosts(item_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT po_item_cost, DATE(date_created) as date_created, AVG(po_item_cost) AS average FROM po_item WHERE item_id= '" & item_id & "' GROUP BY item_id"

        'Get item costs
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
    ''' <summary>
    ''' Adds a record to the items database
    ''' </summary>
    ''' <param name="item_desc"></param>
    ''' <param name="item_price"></param>
    ''' <param name="item_description"></param>
    ''' <param name="item_longdescription"></param>
    ''' <param name="item_specifications"></param>
    ''' <param name="item_manufacturer"></param>
    ''' <param name="item_model"></param>
    ''' <param name="item_stockcode"></param>
    ''' <param name="item_cat_id"></param>
    ''' <param name="item_weight"></param>
    ''' <param name="item_barcode"></param>
    ''' <returns>ID of record inserted</returns>
    ''' <remarks></remarks>
    Public Function addItem(item_desc As Integer, item_price As Double, item_description As String, item_longdescription As String, item_specifications As String, item_manufacturer As String, item_model As String, item_stockcode As String, item_cat_id As Integer, item_weight As Double, Optional item_barcode As String = "")
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO item (item_desc, item_price, item_description, item_longdescription, item_specifications, item_manufacturer, item_model, item_stockcode, item_cat_id, item_weight, item_barcode) "
        sqlQuery = sqlQuery & "VALUES ('" & item_desc & "','" & item_price & "','" & item_description & "','" & item_longdescription & "','" & item_specifications & "','" & item_manufacturer & "','" & item_model & "','" & item_stockcode & "','" & item_cat_id & "','" & item_weight & "','" & item_barcode & "')"
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
    ''' <summary>
    ''' Updates a record in items located by item_id
    ''' </summary>
    ''' <param name="item_id"></param>
    ''' <param name="item_desc"></param>
    ''' <param name="item_price"></param>
    ''' <param name="item_description"></param>
    ''' <param name="item_longdescription"></param>
    ''' <param name="item_specifications"></param>
    ''' <param name="item_manufacturer"></param>
    ''' <param name="item_model"></param>
    ''' <param name="item_stockcode"></param>
    ''' <param name="item_cat_id"></param>
    ''' <param name="item_weight"></param>
    ''' <param name="item_barcode"></param>
    ''' <returns>Number of rows affected</returns>
    ''' <remarks></remarks>
    Public Function updateItem(item_id As Integer, item_desc As Integer, item_price As Double, item_description As String, item_longdescription As String, item_specifications As String, item_manufacturer As String, item_model As String, item_stockcode As String, item_cat_id As Integer, item_weight As Double, item_barcode As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE item SET item_desc='" & item_desc & "', item_price='" & item_price & "', item_description='" & item_description & "', item_longdescription='" & item_longdescription & "', item_specifications='" & item_specifications & "', item_manufacturer='" & item_manufacturer & "', item_model='" & item_model & "', item_stockcode='" & item_stockcode & "', item_cat_id='" & item_cat_id & "', item_weight='" & item_weight & "', item_barcode='" & item_barcode & "' WHERE item_id='" & item_id & "'"
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
    Public Function updateItemWeight(item_id As Integer, item_weight As Double)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE item SET item_weight='" & item_weight & "' WHERE item_id='" & item_id & "'"
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
    ''' <summary>
    ''' Adds stock record for a specific item_id
    ''' </summary>
    ''' <param name="item_id"></param>
    ''' <param name="in_stock"></param>
    ''' <returns>The id of the stock record created</returns>
    ''' <remarks>Can be used to create a blank record if just item_id is sent</remarks>
    Public Function addItemStock(item_id As Integer, Optional in_stock As Integer = 0)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO item_stock (item_id, in_stock) VALUES ('" & item_id & "','" & in_stock & "')"
        With classSql
            .db_Url = My.Settings.db_Url 'My.Settings.db_Url
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
    ''' <summary>
    ''' Creates a price record for a specific item_id
    ''' </summary>
    ''' <param name="item_id"></param>
    ''' <param name="price_1"></param>
    ''' <param name="price_2"></param>
    ''' <param name="price_3"></param>
    ''' <param name="price_4"></param>
    ''' <param name="price_5"></param>
    ''' <param name="ti_price_1"></param>
    ''' <param name="ti_price_2"></param>
    ''' <param name="ti_price_3"></param>
    ''' <param name="ti_price_4"></param>
    ''' <param name="ti_price_5"></param>
    ''' <returns>The id of the record created</returns>
    ''' <remarks>If only item_id is passed then it creates a record where all the prices are 0.00</remarks>
    Public Function addItemPrice(item_id As Integer, Optional price_1 As Double = 0.0, Optional price_2 As Double = 0.0, Optional price_3 As Double = 0.0, Optional price_4 As Double = 0.0, Optional price_5 As Double = 0.0, Optional ti_price_1 As Double = 0.0, Optional ti_price_2 As Double = 0.0, Optional ti_price_3 As Double = 0.0, Optional ti_price_4 As Double = 0.0, Optional ti_price_5 As Double = 0.0)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO item_price (item_id, price_1, price_2, price_3, price_4, price_5, ti_price_1, ti_price_2, ti_price_3, ti_price_4, ti_price_5, date_created) "
        sqlQuery = sqlQuery & "VALUES ('" & item_id & "','" & price_1 & "','" & price_2 & "','" & price_3 & "','" & price_4 & "','" & price_5 & "','" & ti_price_1 & "','" & ti_price_2 & "','" & ti_price_3 & "','" & ti_price_4 & "','" & ti_price_5 & "')"
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
    Public Function updateItemPrice(item_id As Integer, Optional price_1 As Double = 0.0, Optional price_2 As Double = 0.0, Optional price_3 As Double = 0.0, Optional price_4 As Double = 0.0, Optional price_5 As Double = 0.0, Optional ti_price_1 As Double = 0.0, Optional ti_price_2 As Double = 0.0, Optional ti_price_3 As Double = 0.0, Optional ti_price_4 As Double = 0.0, Optional ti_price_5 As Double = 0.0)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE item_price SET price_1='" & price_1 & "', price_2='" & price_2 & "', price_3='" & price_3 & "', price_4='" & price_4 & "', price_5='" & price_5 & "', ti_price_1='" & ti_price_1 & "', ti_price_2='" & ti_price_2 & "', ti_price_3='" & ti_price_3 & "', ti_price_4='" & ti_price_4 & "', ti_price_5='" & ti_price_5 & "' WHERE item_id ='" & item_id & "'"
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
    Function getItemPrice(item_id As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM item_price WHERE item_id ='" & item_id & "'"

        'Get item Detail
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
    Function getItemPicture(item_id As String)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM item_picture WHERE item_id ='" & item_id & "'"

        'Get item Detail
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
    Function getManufacturer()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM manufacturer"

        'Get item Detail
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
    Function getCategory()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM category"

        'Get item Detail
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
    Function getCategoryName(cat_id As Integer)
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT category_name FROM category WHERE category_id = '" & cat_id & "'"

        'Get item Detail
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
        Return (MyTable.Rows(0).Item(0))
    End Function
End Module
