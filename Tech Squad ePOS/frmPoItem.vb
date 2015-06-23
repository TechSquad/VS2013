Public Class frmPoItem
    Private _sku As String
    Private _description As String
    Private _barcode As String
    Private _cost As Decimal
    Private _weight As Decimal
    Private _quantity As Decimal
    Private _poitem_id As Integer
    Private _item_id As Integer
    Public Property sku As String
        Get
            Return _sku
        End Get
        Set(ByVal value As String)
            _sku = value
        End Set
    End Property
    Public Property description As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property
    Public Property barcode As String
        Get
            Return _barcode
        End Get
        Set(ByVal value As String)
            _barcode = value
        End Set
    End Property
    Public Property cost As Decimal
        Get
            Return _cost
        End Get
        Set(ByVal value As Decimal)
            _cost = value
        End Set
    End Property
    Public Property weight As Decimal
        Get
            Return _weight
        End Get
        Set(ByVal value As Decimal)
            _weight = value
        End Set
    End Property
    Public Property quantity As Decimal
        Get
            Return _quantity
        End Get
        Set(ByVal value As Decimal)
            _quantity = value
        End Set
    End Property
    Public Property poitem_id As Decimal
        Get
            Return _poitem_id
        End Get
        Set(ByVal value As Decimal)
            _poitem_id = value
        End Set
    End Property
    Public Property item_id As Decimal
        Get
            Return _item_id
        End Get
        Set(ByVal value As Decimal)
            _item_id = value
        End Set
    End Property
    Private Sub frmPoItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSku.Text = _sku
        txtDescription.Text = _description
        txtBarcode.Text = _barcode
        nudQuantity.Value = _quantity
        nudCost.Value = _cost
        nudWeight.Value = _weight
        calcTotals()
    End Sub
    Private Sub calcTotals()
        If IsNumeric(_quantity) And IsNumeric(_cost) Then
            nudTotal.Value = _quantity * _cost
        End If
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudQuantity.ValueChanged
        _quantity = nudQuantity.Value
        calcTotals()
    End Sub

    Private Sub nudCost_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudCost.ValueChanged
        _cost = nudCost.Value
        calcTotals()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        DialogResult = System.Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub btnProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnProcess.Click
        _sku = txtSku.Text
        _description = txtDescription.Text
        _barcode = txtBarcode.Text
        _quantity = nudQuantity.Value
        _cost = nudCost.Value
        _weight = nudWeight.Value
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class