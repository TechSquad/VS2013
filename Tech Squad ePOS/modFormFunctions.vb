Module modFormFunctions
    ''' <summary>
    ''' Tells if a child form is open
    ''' </summary>
    ''' <param name="nameForm"></param>
    ''' <returns>True or False</returns>
    ''' <remarks>Taken from http://allthingsdotnet.net/337/check-to-see-if-an-mdi-form-is-open </remarks>
    Public Function IsOpen(ByVal nameForm As Form) As Boolean
        Dim isFound As Boolean = False

        For Each frm As Form In My.Application.OpenForms
            'Console.WriteLine("frm.Name= " & frm.Name & "   name.Form= " & nameForm.Name)
            If frm.Name.Equals(nameForm.Name) Then

                isFound = True
            End If
        Next
        Return isFound
    End Function
    Public Function DialogBox(message As String, Optional title As String = "Information", Optional okOnly As Boolean = True, Optional okButtonText As String = "OK", Optional cxlButtonText As String = "Cancel")
        Dim f As New frmDialog

        With f
            .title = title                  'call the overrided constructor of the child form
            .message = message
            .okOnly = okOnly
            .okButtonText = okButtonText
            .cxlButtonText = cxlButtonText
        End With
        If f.ShowDialog() = DialogResult.OK Then
            Return (DialogResult.OK)
        Else
            Return (DialogResult.Abort)
        End If
    End Function
    Public Sub dgvSelectedRow(ByRef dgvObject As DataGridView, rowNumber As Integer)
        If rowNumber >= 0 And rowNumber <= (dgvObject.Rows.Count - 1) Then    'rows start at 0 but rowcount starts at 1
            With dgvObject
                .ClearSelection()
                .CurrentCell = .Rows(rowNumber).Cells(0)        'set cell on row
                .Rows(rowNumber).Selected = True                'set row
            End With
        End If
    End Sub
    Public Function webDownloadImage(ByVal Url As String, Optional ByVal saveFile As Boolean = False, Optional ByVal location As String = "C:\") As Image
        Dim webClient As New System.Net.WebClient
        Dim bytes() As Byte = webClient.DownloadData(Url)
        Dim stream As New IO.MemoryStream(bytes)
        If saveFile Then My.Computer.FileSystem.WriteAllBytes(location, bytes, False)
        Return (New System.Drawing.Bitmap(stream))
    End Function


End Module
