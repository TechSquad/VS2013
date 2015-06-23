Imports System
Imports System.Windows

Public Class frmAddNote
    ' ***** Create Properties *****
    Private _message As String
    Private _customerId As Integer
    Private _complete As Boolean = False
    '***** Initialise Properties *****
    Public Property Message As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property
    Public Property CustomerId As Integer
        Get
            Return _customerId
        End Get
        Set(ByVal value As Integer)
            _customerId = value
        End Set
    End Property
    Public ReadOnly Property Complete As Boolean
        Get
            Return Me._complete
        End Get
    End Property
    ' ***** Initialise Form *****
    Public Sub New(ByVal cust_id As Integer, ByVal UserMode As String)
        InitializeComponent()           ' This call is required by the designer. Add any initialization after the InitializeComponent() call or in form_load.
        ' To close the form place any data required into Properties
        '_message = "Message Text"
        ' Then set _complete = True and close the form
        '_complete = True
        ' Make sure the creating form issues a frmObjectName.Dispose() to release the resources 
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim m_textbox As New TextBox
        m_textbox.Width = 200
    End Sub
End Class