Public Class frmXmlImport
    Dim working As Boolean = False
    Dim bgwqueue As Integer = 0
    Dim row() As DataRow
    Dim WithEvents worker As New System.ComponentModel.BackgroundWorker
    Dim WithEvents worker1 As New System.ComponentModel.BackgroundWorker
    Dim WithEvents worker2 As New System.ComponentModel.BackgroundWorker
    Dim WithEvents worker3 As New System.ComponentModel.BackgroundWorker
    Dim WithEvents worker4 As New System.ComponentModel.BackgroundWorker
       

    Private Sub btmReadXml_Click(sender As System.Object, e As System.EventArgs) Handles btmReadXml.Click
        btmReadXml.Enabled = False          ' Stop button from beind pressed again while background task is in progress
        queueBackgroundWorker()
        'BackgroundWorker1.RunWorkerAsync()  ' This process may take some time so it will run in the backbround
        ' Program execution will continue here immediately so don't rely on the background task to have completed
    End Sub
    Private Sub queueBackgroundWorker()
        Dim MyTable As New DataTable
        Dim MyDataSet As New DataSet
        Dim filePath As String = "e:\Users\Roger\Desktop\NOR00017-Target_EP.xml" '"e:\Users\Roger\Desktop\target.xml"

        MyDataSet.ReadXml(filePath)
        MyTable = MyDataSet.Tables(1)   ' using 1 as 0 is the import stats
        DataGridView1.DataSource = MyTable
        For Each Row As DataRow In MyTable.Rows    'Walk through the datatable one record at a time
            If Not worker1.IsBusy Then
                worker1.RunWorkerAsync(Row)
            ElseIf Not worker2.IsBusy Then
                working = True
                worker2.RunWorkerAsync(Row)
            ElseIf Not worker3.IsBusy Then
                working = True
                worker3.RunWorkerAsync(Row)
            ElseIf Not worker4.IsBusy Then
                working = True
                worker4.RunWorkerAsync(Row)
            End If
            While worker1.IsBusy And worker2.IsBusy And worker3.IsBusy And worker4.IsBusy
                Application.DoEvents()
            End While
        Next
    End Sub
    Private Sub worker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Dim filePath As String = "e:\Users\Roger\Desktop\NOR00017-Target_EP.xml" '"e:\Users\Roger\Desktop\target.xml"
        Dim CatCode, CatName, CatPath, Cost, Price, Delivery, DescLong, DescShort, DescUpdated, DueWhen As String
        Dim EANCode, ImageLargeURL, ImageThumbnailURL, ImageUrl, ImagePackFilename, Manufacturer As String
        Dim ManufacturerCode, Overview, ProductCondition, ProductStatus, StockLevel, StockCode As String
        Dim UKVATRate, Weight As String
        'Dim MyTable As New DataTable
        'Dim MyDataSet As New DataSet
        Dim countProgress As Double = 0.0
        Dim currentRow As Integer = 0
        Dim categoriesUpdated, categoriesNew, itemsUpdated, itemsAdded As Integer
        Dim results() As Integer
        Dim row As DataRow = e.Argument
        'MyDataSet.ReadXml(filePath)
        'MyTable = MyDataSet.Tables(1)   ' using 1 as 0 is the import stats
        'For Each Row As DataRow In MyTable.Rows    'Walk through the datatable one record at a time
        CatCode = row("CatCode").ToString
        CatName = row("CatName").ToString
        CatPath = row("CatPath").ToString
        Cost = row("Cost").ToString
        Price = row("Price").ToString
        Delivery = row("Delivery").ToString
        DescLong = Replace(row("DescLong").ToString, "'", "''")
        DescShort = Replace(row("DescShort").ToString, "'", "''")
        DescUpdated = row("DescUpdated").ToString
        DueWhen = row("DueWhen").ToString
        EANCode = (row("EANCode").ToString)
        ImageLargeURL = row("ImageLargeURL").ToString
        ImageThumbnailURL = row("ImageThumbnailURL").ToString
        ImageUrl = row("ImageURL").ToString
        ImagePackFilename = row("ImagePackFilename").ToString
        Manufacturer = row("Manufacturer").ToString
        ManufacturerCode = row("ManufacturerCode").ToString
        Overview = Replace(row("Overview").ToString, "'", "''")
        ProductCondition = row("ProductCondition").ToString
        ProductStatus = row("ProductStatus").ToString
        StockLevel = row("StockLevel").ToString
        StockCode = row("StockCode").ToString
        UKVATRate = row("UKVATRate").ToString
        Weight = row("Weight").ToString

        'add categories to Database
        If TargetCatCodeExist(CatCode) Then                 'Check to see if the category exists in the TargetCategories
            TargetCategoryUpdate(CatCode, CatName, CatPath) 'Then update it
            categoriesUpdated = 1
        Else
            TargetCategoryAdd(CatCode, CatName, CatPath)    'If no category then add it
            categoriesNew = 1
        End If
        If TargetImportItemExists(StockCode) Then 'Check to see if the item exists in the TargetImport
            'If it does exist then update it
            If targetUpdateItem(CatCode, CatName, CatPath, Cost, Price, Delivery, DescLong, DescShort, DescUpdated, DueWhen, EANCode, ImageLargeURL, ImageThumbnailURL, ImageUrl, ImagePackFilename, Manufacturer, ManufacturerCode, Overview, ProductCondition, ProductStatus, StockLevel, StockCode, UKVATRate, Weight) > 0 Then
                itemsUpdated = 1
            End If
        Else
            'If it does not exist then add it
            If targetAddItem(CatCode, CatName, CatPath, Cost, Price, Delivery, DescLong, DescShort, DescUpdated, DueWhen, EANCode, ImageLargeURL, ImageThumbnailURL, ImageUrl, ImagePackFilename, Manufacturer, ManufacturerCode, Overview, ProductCondition, ProductStatus, StockLevel, StockCode, UKVATRate, Weight) > 0 Then
                itemsAdded = 1
            End If
        End If
        currentRow += 1
        results = {categoriesUpdated, categoriesNew, itemsUpdated, itemsAdded}
        worker.ReportProgress(currentRow, results)
        results = {0, 0, 0, 0} 'clear results for next row
    End Sub
    Private Sub worker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Dim results() As Integer
        Dim result1, result2, result3, result4 As Int32
        'Beep()
        ToolStripStatusLabel2.Text = e.ProgressPercentage & " Records Processed"
        results = e.UserState
        result1 = results(0)
        result2 = results(1)
        result3 = results(2)
        result4 = results(3)

        ToolStripStatusLabel3.Text = Convert.ToInt32(ToolStripStatusLabel3.Text) + result1
        ToolStripStatusLabel4.Text = Convert.ToInt32(ToolStripStatusLabel4.Text) + result2
        ToolStripStatusLabel5.Text = Convert.ToInt32(ToolStripStatusLabel5.Text) + result3
        ToolStripStatusLabel6.Text = Convert.ToInt32(ToolStripStatusLabel6.Text) + result4
    End Sub

    Private Sub worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'DataGridView1.DataSource = e.Result
        'DataGridView1.Refresh()
        'Beep()
        ToolStripStatusLabel1.Text = (DataGridView1.RowCount - 1) & " Records Read"
        btmReadXml.Enabled = True
    End Sub

    Private Sub btnCategories_Click(sender As System.Object, e As System.EventArgs) Handles btnCategories.Click
        Dim MyTable As DataTable
        Dim CatCode, CatName, CatPath As String
        Dim StringSeparators() As String = {"<n>"}
        Dim result() As String

        MyTable = getTargetCategories()
        For Each Row As DataRow In MyTable.Rows    'Walk through the datatable one record at a time
            CatCode = Row("CatCode").ToString
            CatName = Row("CatName").ToString
            CatPath = Row("CatPath").ToString
            If CatPath <> "" Then     'If CatPath is not empty
                result = CatPath.Split(StringSeparators, StringSplitOptions.None)
                'Write entries to database
                TargetCatPathAdd(CatCode, CatName, result)
            End If
        Next
    End Sub

    Private Sub frmXmlImport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = True
        worker1.WorkerReportsProgress = True
        worker1.WorkerSupportsCancellation = True
        worker2.WorkerReportsProgress = True
        worker2.WorkerSupportsCancellation = True
        worker3.WorkerReportsProgress = True
        worker3.WorkerSupportsCancellation = True
        worker4.WorkerReportsProgress = True
        worker4.WorkerSupportsCancellation = True

        AddHandler worker1.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler worker1.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler worker1.DoWork, AddressOf worker_DoWork
        AddHandler worker2.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler worker2.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler worker2.DoWork, AddressOf worker_DoWork
        AddHandler worker3.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler worker3.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler worker3.DoWork, AddressOf worker_DoWork
        AddHandler worker4.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler worker4.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler worker4.DoWork, AddressOf worker_DoWork

        AddHandler BackgroundWorker1.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler BackgroundWorker1.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler BackgroundWorker1.DoWork, AddressOf worker_DoWork
        AddHandler BackgroundWorker2.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler BackgroundWorker2.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler BackgroundWorker2.DoWork, AddressOf worker_DoWork
        AddHandler BackgroundWorker3.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler BackgroundWorker3.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler BackgroundWorker3.DoWork, AddressOf worker_DoWork
        AddHandler BackgroundWorker4.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted
        AddHandler BackgroundWorker4.ProgressChanged, AddressOf worker_ProgressChanged
        AddHandler BackgroundWorker4.DoWork, AddressOf worker_DoWork
    End Sub
End Class