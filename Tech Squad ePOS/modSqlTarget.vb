Module modSqlTarget
    Function TargetCatCodeExist(CatCode)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        sqlQuery = "SELECT COUNT(*) FROM TargetCategories WHERE CatCode ='" & CatCode & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_get_record_count(sqlQuery)
        End With
        If classSql.RecCount > 0 Then
            result = True
        End If
        Return (result)
    End Function
    Public Function TargetCategoryAdd(CatCode As String, CatName As String, CatPath As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO TargetCategories (CatCode, CatName, CatPath) "
        sqlQuery = sqlQuery & "VALUES ('" & CatCode & "','" & CatName & "','" & CatPath & "')"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.LastInsertedId)
    End Function
    Public Function TargetCategoryUpdate(CatCode As String, CatName As String, CatPath As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "UPDATE TargetCategories SET CatName ='" & CatName & "',CatPath='" & CatPath & "' WHERE CatCode = '" & CatCode & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.LastInsertedId)
    End Function
    Function getTargetCategories()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM TargetCategories"

        'Get Customer Detail
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
    Public Function TargetCatPathAdd(CatCode As String, catName As String, result() As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery, sqlQuery2 As String
        Dim i As Integer

        sqlQuery = "INSERT INTO TargetCatPath (CatCode, CatName, "
        sqlQuery2 = " VALUES ('" & CatCode & "','" & CatName & "','"
        For i = 0 To (result.Length - 2)    ' Must remove 1 as array starts at 0 but must also remove another as last entry is always "<z>" this is why it is -2
            If i < (result.Length - 2) Then
                sqlQuery = sqlQuery & "Level" & (i + 1) & ", "
                sqlQuery2 = sqlQuery2 & result(i) & "','"
            Else
                sqlQuery = sqlQuery & "Level" & (i + 1) & ")"
                sqlQuery2 = sqlQuery2 & result(i) & "')"
            End If
        Next
        sqlQuery = sqlQuery & sqlQuery2
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.LastInsertedId)
    End Function
    Function getTargetCatPath()
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM TargetCatPath"

        'Get Customer Detail
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
    Function TargetImportItemExists(StockCode As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String
        Dim result As Boolean = False

        sqlQuery = "SELECT COUNT(*) FROM TargetImport WHERE StockCode ='" & StockCode & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_get_record_count(sqlQuery)
        End With
        If classSql.RecCount > 0 Then
            result = True
        End If
        Return (result)
    End Function
    Function targetAddItem(CatCode As String, CatName As String, CatPath As String, Cost As String, Price As String, Delivery As String, DescLong As String, DescShort As String, DescUpdated As String, DueWhen As String, EANCode As String, ImageLargeURL As String, ImageThumbnailURL As String, ImageUrl As String, ImagePackFilename As String, Manufacturer As String, ManufacturerCode As String, Overview As String, ProductCondition As String, ProductStatus As String, StockLevel As String, StockCode As String, UKVATRate As String, Weight As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        sqlQuery = "INSERT INTO TargetImport (CatCode, CatName, CatPath, Cost, Price, Delivery, DescLong, DescShort, DescUpdated, DueWhen, EANCode, ImageLargeURL, ImageThumbnailURL, ImageURL, ImagePackFilename, Manufacturer, ManufacturerCode, Overview, ProductCondition, ProductStatus, StockLevel, StockCode, UKVATRate, Weight) "
        sqlQuery = sqlQuery & "VALUES ('" & CatCode & "','" & CatName & "','" & CatPath & "','" & Cost & "','" & Price & "','" & Delivery & "','" & DescLong & "','" & DescShort & "','" & DescUpdated & "','" & DueWhen & "','" & EANCode & "','" & ImageLargeURL & "','" & ImageThumbnailURL & "','" & ImageUrl & "','" & ImagePackFilename & "','" & Manufacturer & "','" & ManufacturerCode & "','" & Overview & "','" & ProductCondition & "','" & ProductStatus & "','" & StockLevel & "','" & StockCode & "','" & UKVATRate & "','" & Weight & "')"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.LastInsertedId)
    End Function
    Function targetUpdateItem(CatCode As String, CatName As String, CatPath As String, Cost As String, Price As String, Delivery As String, DescLong As String, DescShort As String, DescUpdated As String, DueWhen As String, EANCode As String, ImageLargeURL As String, ImageThumbnailURL As String, ImageUrl As String, ImagePackFilename As String, Manufacturer As String, ManufacturerCode As String, Overview As String, ProductCondition As String, ProductStatus As String, StockLevel As String, StockCode As String, UKVATRate As String, Weight As String)
        Dim classSql As New ClassMySQL_Basic
        Dim sqlQuery As String

        'sqlQuery = "INSERT INTO TargetImport (CatCode, CatName, CatPath, Cost, Price, Delivery, DescLong, DescShort, DescUpdated, DueWhen, EANCode, ImageLargeURL, ImageThumbnailURL, ImageURL, ImagePackFilename, Manufacturer, ManufacturerCode, Overview, ProductCondition, ProductStatus, StockLevel, StockCode, UKVATRate, Weight) "
        'sqlQuery = sqlQuery & "VALUES ('" & CatCode & "','" & CatName & "','" & CatPath & "','" & Cost & "','" & Price & "','" & Delivery & "','" & DescLong & "','" & DescShort & "','" & DescUpdated & "','" & DueWhen & "','" & EANCode & "','" & ImageLargeURL & "','" & ImageThumbnailURL & "','" & ImageUrl & "','" & ImagePackFilename & "','" & Manufacturer & "','" & ManufacturerCode & "','" & Overview & "','" & ProductCondition & "','" & ProductStatus & "','" & StockLevel & "','" & StockCode & "','" & UKVATRate & "','" & Weight & "')"
        sqlQuery = "UPDATE TargetImport SET CatCode = '" & CatCode & "' ,CatName ='" & CatName & "',CatPath='" & CatPath & "' ,Cost='" & Cost & "' ,Price='" & Price & "' ,Delivery='" & Delivery & "' ,DescLong='" & DescLong & "' ,DescShort='" & DescShort & "' ,DescUpdated='" & DescUpdated & "' ,DueWhen='" & DueWhen & "' ,EANCode='" & EANCode & "' ,ImageLargeURL='" & ImageLargeURL & "' ,ImageThumbnailURL='" & ImageThumbnailURL & "' ,ImageURL='" & ImageUrl & "' ,ImagePackFilename='" & ImagePackFilename & "' ,Manufacturer='" & Manufacturer & "' ,ManufacturerCode='" & ManufacturerCode & "' ,Overview='" & Overview & "' ,ProductCondition='" & ProductCondition & "' ,ProductStatus='" & ProductStatus & "' ,StockLevel='" & StockLevel & "' ,UKVATRate='" & UKVATRate & "' ,Weight='" & Weight & "' WHERE StockCode='" & StockCode & "'"
        With classSql
            .db_Url = My.Settings.db_Url
            .db_User = My.Settings.db_User
            .db_Password = My.Settings.db_Password
            .db_Name = My.Settings.db_Name
            .MySQL_Action_Query(sqlQuery)
        End With
        If classSql.errorText <> "" Then            ' Check class for an error
            MessageBox.Show(classSql.errorText)     ' Display error
        Else
            'MessageBox.Show("Success = " & classSql.Success & " Record Count = " & classSql.rowsAffected)
        End If
        Return (classSql.rowsAffected)
    End Function
End Module
