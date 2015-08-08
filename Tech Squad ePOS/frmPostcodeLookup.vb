Public Class frmPostcodeLookup
    ' ******************** Construct properties ***********************
    Private m_sender As Object
    Private _StreetAddress As String 'returns the first part of the address
    Private _Place As String 'returns the first part of the address
    Private _complete As Boolean = False    ' changes when lookup has finished
    Private _abort As Boolean = False   ' used to exit without finding address
    Private _m_postcode As String ' Accepts the postcode
    Public WriteOnly Property m_postcode
        Set(value)
            _m_postcode = value
        End Set
    End Property
    Public ReadOnly Property StreetAddress As String
        Get
            Return Me._StreetAddress
        End Get
    End Property
    Public ReadOnly Property Place As String
        Get
            Return Me._Place
        End Get
    End Property
    Public ReadOnly Property Complete As Boolean
        Get
            Return Me._complete
        End Get
    End Property
    Public ReadOnly Property abort As Boolean
        Get
            Return Me._abort
        End Get
    End Property
    ' **************** End construct properties ************************

    ' ******* Sub New is called as soon as the instance is created *****
    Public Sub New(ByVal postcode As String)
        InitializeComponent()           ' This call is required by the designer. Add any initialization after this.
        _m_postcode = postcode ' set 
        PostcodeLookup(_m_postcode) 'UserMode)
    End Sub
    Private Sub PostcodeLookup(m_postcode As String)
        'Get Address from Postcode
        Dim myTable As DataTable

        'myTable = PostcodeAnywhere_Interactive_Find_v1_10(m_postcode)    'Get address data from Postcode Anywhere
        myTable = CapturePlus_Interactive_Find_v2_10(m_postcode)    'Get address data from Capture Plus
        'Look for errors
        If myTable.Columns.Item(0).ColumnName = "Error" Then
            Dim my_error As String = "Postcode Lookup Error No: " & myTable.Rows(0).Item(0).ToString & vbCrLf & myTable.Rows(0).Item(1).ToString & vbCrLf & myTable.Rows(0).Item(2).ToString & vbCrLf & "Reported in frmPostcodeLookup Sub PostcodeLookup"
            MsgBox(my_error)    ' Display Error Message
            Me.Hide()          ' Hide Form
            _abort = True
        Else
            With DataGridView1  'Populate Grid with addresses
                .DataSource = myTable
                .Columns.Item("Id").Visible = False ' Hide the unused ID column
                .Refresh()
            End With
        End If
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        With DataGridView1
            Dim selected_rows As Integer = .SelectedRows(0).Index
            _StreetAddress = .Rows(selected_rows).Cells(1).Value.ToString
            _Place = .Rows(selected_rows).Cells(2).Value.ToString
            _complete = True
            Me.Close()
        End With

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Return to manual entry
        _abort = True
        _complete = True
        Me.Close() 'Close form and return nothing
    End Sub
End Class