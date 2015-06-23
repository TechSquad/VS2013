Module modPostcodeAnywhere

    Function PostcodeAnywhere_Interactive_Find_v1_10(SearchTerm As String, Optional Key As String = "NJ26-UT56-KM82-XU91", Optional PreferredLanguage As String = "English", Optional UserName As String = "")
        ' Looks up an address for a postcode, returns a list of addresses in a table
        Dim strUrl
        Dim rst
        Dim addressTable As DataTable = New DataTable("Addresses")
        Dim objDataAdapter As New OleDb.OleDbDataAdapter()

        'Build the url
        strUrl = "http://services.postcodeanywhere.co.uk/PostcodeAnywhere/Interactive/Find/v1.10/recordset.ws?"
        strUrl = strUrl & "&Key=" & (Key)
        strUrl = strUrl & "&SearchTerm=" & (SearchTerm)
        strUrl = strUrl & "&PreferredLanguage=" & (PreferredLanguage)
        strUrl = strUrl & "&Filter=" 'Filters not used
        strUrl = strUrl & "&UserName=" & (UserName)


        'Create the recordset bacause this is how PostcodeAnywhere supplied the sample code
        rst = CreateObject("ADODB.Recordset")
        rst.Open(strUrl)

        'Check for an error
        If rst.Fields.Count = 4 Then
            If rst.Fields(0).Name = "Error" Then
                'Err.Raise(rst.Fields(0), "Webservice Error", rst.Fields(1))
                'Return (addressTable(LookupError(rst.Fields(1))))
            End If
        End If

        'Populate the DataTable bacause all other code uses datatables
        objDataAdapter.Fill(addressTable, rst)  'Fill DataTable with recordset by using DataAdapter
        'Return the Datatable
        PostcodeAnywhere_Interactive_Find_v1_10 = addressTable
        
        'FYI: The datatable returns the following columns:
        'Id, StreetAddress, Place
    End Function
    Function CapturePlus_Interactive_Find_v2_10(SearchTerm As String, Optional Key As String = "NJ26-UT56-KM82-XU91", Optional LastId As String = "", Optional SearchFor As String = "PostalCodes", Optional Country As String = "GBR", Optional LanguagePreference As String = "EN", Optional MaxSuggestions As Integer = 7, Optional MaxResults As Integer = 100)
        Dim strUrl
        Dim rst
        Dim addressTable As DataTable = New DataTable("Addresses")
        Dim objDataAdapter As New OleDb.OleDbDataAdapter()

        'Build the url
        strUrl = "http://services.postcodeanywhere.co.uk/CapturePlus/Interactive/Find/v2.10/recordset.ws?"
        strUrl = strUrl & "&Key=" & (Key)
        strUrl = strUrl & "&SearchTerm=" & (SearchTerm)
        strUrl = strUrl & "&LastId=" & (LastId)
        strUrl = strUrl & "&SearchFor=" & (SearchFor)
        strUrl = strUrl & "&Country=" & (Country)
        strUrl = strUrl & "&LanguagePreference=" & (LanguagePreference)
        strUrl = strUrl & "&MaxSuggestions=" & (MaxSuggestions)
        strUrl = strUrl & "&MaxResults=" & (MaxResults)

        'Create the recordset
        rst = CreateObject("ADODB.Recordset")
        rst.Open(strUrl)

        'Check for an error
        If rst.Fields.Count = 4 Then
            If rst.Fields(0).Name = "Error" Then
                Err.Raise(rst.Fields(0), "Webservice Error", rst.Fields(1))
            End If
        End If

        'Populate the DataTable bacause all other code uses datatables
        objDataAdapter.Fill(addressTable, rst)  'Fill DataTable with recordset by using DataAdapter
        'Return the Datatable
        CapturePlus_Interactive_Find_v2_10 = addressTable
        'Return the recordset
        'CapturePlus_Interactive_Find_v2_10 = rst

        'FYI: The recordset returns the following columns:
        'Id
        'Text
        'Highlight
        'Cursor
        'Description
        'Next
    End Function

    Private Function LookupError(error_code As Integer)
        ' Get error data from Code
        Dim classSql As New ClassMySQL_Basic
        Dim MyTable As New DataTable
        Dim sqlQuery As String = "SELECT * FROM PostcodeAnywhereErrors WHERE error_code ='" & error_code & "'"

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
