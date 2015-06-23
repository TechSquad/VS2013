Imports System.Windows.Forms.Control
Imports Microsoft.Office.Interop
Public Class Form1
    Dim wrdApp As Word.Application
    Dim wrdDoc As Word._Document
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim wrdSelection As Word.Selection
        Dim wrdMailMerge As Word.MailMerge
        Dim wrdMergeFields As Word.MailMergeFields

        Dim StrToAdd As String

        ' Create an instance of Word  and make it visible.
        wrdApp = CreateObject("Word.Application")
        wrdApp.Visible = True

        ' Add a new document.

        wrdDoc = wrdApp.Documents.Add()
        wrdDoc.Select()

        wrdSelection = wrdApp.Selection()
        wrdMailMerge = wrdDoc.MailMerge()

        ' Create MailMerge Data file.
        CreateMailMergeDataFile()

        ' Create a string and insert it in the document.
        StrToAdd = "State University" & vbCr & _
                    "Electrical Engineering Department"
        wrdSelection.ParagraphFormat.Alignment = _
                    Word.WdParagraphAlignment.wdAlignParagraphCenter
        wrdSelection.TypeText(StrToAdd)

        InsertLines(4)

        ' Insert merge data.
        wrdSelection.ParagraphFormat.Alignment = _
                    Word.WdParagraphAlignment.wdAlignParagraphLeft
        wrdMergeFields = wrdMailMerge.Fields()
        wrdMergeFields.Add(wrdSelection.Range, "FirstName")
        wrdSelection.TypeText(" ")
        wrdMergeFields.Add(wrdSelection.Range, "LastName")
        wrdSelection.TypeParagraph()

        wrdMergeFields.Add(wrdSelection.Range, "Address")
        wrdSelection.TypeParagraph()
        wrdMergeFields.Add(wrdSelection.Range, "CityStateZip")

        InsertLines(2)

        ' Right justify the line and insert a date field
        ' with the current date.
        wrdSelection.ParagraphFormat.Alignment = _
               Word.WdParagraphAlignment.wdAlignParagraphRight
        wrdSelection.InsertDateTime( _
              DateTimeFormat:="dddd, MMMM dd, yyyy", _
              InsertAsField:=False)

        InsertLines(2)

        ' Justify the rest of the document.
        wrdSelection.ParagraphFormat.Alignment = _
               Word.WdParagraphAlignment.wdAlignParagraphJustify

        wrdSelection.TypeText("Dear ")
        wrdMergeFields.Add(wrdSelection.Range, "FirstName")
        wrdSelection.TypeText(",")
        InsertLines(2)

        ' Create a string and insert it into the document.
        StrToAdd = "Thank you for your recent request for next " & _
            "semester's class schedule for the Electrical " & _
            "Engineering Department. Enclosed with this " & _
            "letter is a booklet containing all the classes " & _
            "offered next semester at State University.  " & _
            "Several new classes will be offered in the " & _
            "Electrical Engineering Department next semester.  " & _
            "These classes are listed below."
        wrdSelection.TypeText(StrToAdd)

        InsertLines(2)

        ' Insert a new table with 9 rows and 4 columns.
        wrdDoc.Tables.Add(wrdSelection.Range, NumRows:=9, _
             NumColumns:=4)

        With wrdDoc.Tables.Item(1)
            ' Set the column widths.
            .Columns.Item(1).SetWidth(51, Word.WdRulerStyle.wdAdjustNone)
            .Columns.Item(2).SetWidth(170, Word.WdRulerStyle.wdAdjustNone)
            .Columns.Item(3).SetWidth(100, Word.WdRulerStyle.wdAdjustNone)
            .Columns.Item(4).SetWidth(111, Word.WdRulerStyle.wdAdjustNone)
            ' Set the shading on the first row to light gray.
            .Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = _
             Word.WdColorIndex.wdGray25
            ' Bold the first row.
            .Rows.Item(1).Range.Bold = True
            ' Center the text in Cell (1,1).
            .Cell(1, 1).Range.Paragraphs.Alignment = _
                      Word.WdParagraphAlignment.wdAlignParagraphCenter

            ' Fill each row of the table with data.
            FillRow(wrdDoc, 1, "Class Number", "Class Name", "Class Time", _
               "Instructor")
            FillRow(wrdDoc, 2, "EE220", "Introduction to Electronics II", _
                      "1:00-2:00 M,W,F", "Dr. Jensen")
            FillRow(wrdDoc, 3, "EE230", "Electromagnetic Field Theory I", _
                      "10:00-11:30 T,T", "Dr. Crump")
            FillRow(wrdDoc, 4, "EE300", "Feedback Control Systems", _
                      "9:00-10:00 M,W,F", "Dr. Murdy")
            FillRow(wrdDoc, 5, "EE325", "Advanced Digital Design", _
                      "9:00-10:30 T,T", "Dr. Alley")
            FillRow(wrdDoc, 6, "EE350", "Advanced Communication Systems", _
                      "9:00-10:30 T,T", "Dr. Taylor")
            FillRow(wrdDoc, 7, "EE400", "Advanced Microwave Theory", _
                      "1:00-2:30 T,T", "Dr. Lee")
            FillRow(wrdDoc, 8, "EE450", "Plasma Theory", _
                      "1:00-2:00 M,W,F", "Dr. Davis")
            FillRow(wrdDoc, 9, "EE500", "Principles of VLSI Design", _
                      "3:00-4:00 M,W,F", "Dr. Ellison")
        End With

        ' Go to the end of the document.
        wrdApp.Selection.GoTo(Word.WdGoToItem.wdGoToLine, _
                   Word.WdGoToDirection.wdGoToLast)

        InsertLines(2)

        ' Create a string and insert it into the document.
        StrToAdd = "For additional information regarding the " & _
                   "Department of Electrical Engineering, " & _
                   "you can visit our Web site at "
        wrdSelection.TypeText(StrToAdd)
        ' Insert a hyperlink to the Web page.
        wrdSelection.Hyperlinks.Add(Anchor:=wrdSelection.Range, _
           Address:="http://www.ee.stateu.tld")
        ' Create a string and insert it in the document.
        StrToAdd = ".  Thank you for your interest in the classes " & _
                   "offered in the Department of Electrical " & _
                   "Engineering.  If you have any other questions, " & _
                   "please feel free to give us a call at " & _
                   "555-1212." & vbCr & vbCr & _
                   "Sincerely," & vbCr & vbCr & _
                   "Kathryn M. Hinsch" & vbCr & _
                   "Department of Electrical Engineering" & vbCr
        wrdSelection.TypeText(StrToAdd)

        ' Perform mail merge.
        wrdMailMerge.Destination = _
                   Word.WdMailMergeDestination.wdSendToNewDocument
        wrdMailMerge.Execute(False)

        ' Close the original form document.
        wrdDoc.Saved = True
        wrdDoc.Close(False)

        ' Release References.
        wrdSelection = Nothing
        wrdMailMerge = Nothing
        wrdMergeFields = Nothing
        wrdDoc = Nothing
        wrdApp = Nothing

        ' Clean up temp file.
        System.IO.File.Delete("C:\DataDoc.doc")
    End Sub
    Private Sub InsertLines(ByVal LineNum As Integer)
        Dim iCount As Integer

        ' Insert "LineNum" blank lines.
        For iCount = 1 To LineNum
            wrdApp.Selection.TypeParagraph()
        Next iCount
    End Sub

    Private Sub FillRow(ByVal Doc As Word.Document, ByVal Row As Integer, _
    ByVal Text1 As String, ByVal Text2 As String, _
    ByVal Text3 As String, ByVal Text4 As String)

        With Doc.Tables.Item(1)
            ' Insert the data in the specific cell.
            .Cell(Row, 1).Range.InsertAfter(Text1)
            .Cell(Row, 2).Range.InsertAfter(Text2)
            .Cell(Row, 3).Range.InsertAfter(Text3)
            .Cell(Row, 4).Range.InsertAfter(Text4)
        End With
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub CreateMailMergeDataFile()
        Dim wrdDataDoc As Word._Document
        Dim iCount As Integer

        ' Create a data source at C:\DataDoc.doc containing the field data.
        wrdDoc.MailMerge.CreateDataSource(Name:="C:\Users\Office\Documents", HeaderRecord:="FirstName, LastName, Address, CityStateZip")
        ' Open the file to insert data.
        wrdDataDoc = wrdApp.Documents.Open("C:\Users\Office\Documents") ' this line throws a file path error
        For iCount = 1 To 2
            wrdDataDoc.Tables.Item(1).Rows.Add()
        Next iCount
        ' Fill in the data.
        FillRow(wrdDataDoc, 2, "Steve", "DeBroux", _
              "4567 Main Street", "Buffalo, NY  98052")
        FillRow(wrdDataDoc, 3, "Jan", "Miksovsky", _
              "1234 5th Street", "Charlotte, NC  98765")
        FillRow(wrdDataDoc, 4, "Brian", "Valentine", _
              "12348 78th Street  Apt. 214", "Lubbock, TX  25874")
        ' Save and close the file.
        wrdDataDoc.Save()
        wrdDataDoc.Close(False)
    End Sub
End Class
