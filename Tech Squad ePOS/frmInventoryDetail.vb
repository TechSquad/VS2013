Public Class frmInventoryDetail

    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If btnOK.Text = "Save" Then
            tsItem_id.Text = addItem(0, txtCost.Text, txtShortDesc.Text, txtLongDesc.Text, rtbSpecifications.Text, cbManufacturer.Text, "unused", txtPriSku.Text, cbCategory.SelectedValue.ToString, txtWeight.Text, txtBarcode.Text)
            'validatePrices()
            addItemPrice(tsItem_id.Text, txtPrice_1.Text, txtPrice_2.Text, txtPrice_3.Text, txtPrice_4.Text, txtPrice_5.Text, txtTi_Price_1.Text, txtTi_Price_2.Text, txtTi_Price_3.Text, txtTi_Price_4.Text, txtTi_Price_5.Text)
            initialiseMode(tsItem_id.Text, "View")
            btnCancel.Text = "Exit"
        ElseIf btnOK.Text = "Update" Then
            updateItem(tsItem_id.Text, 0, txtCost.Text, txtShortDesc.Text, txtLongDesc.Text, rtbSpecifications.Text, cbManufacturer.Text, "unused", txtPriSku.Text, cbCategory.SelectedValue.ToString, txtWeight.Text, txtBarcode.Text)
            'validatePrices()
            updateItemPrice(tsItem_id.Text, txtPrice_1.Text, txtPrice_2.Text, txtPrice_3.Text, txtPrice_4.Text, txtPrice_5.Text, txtTi_Price_1.Text, txtTi_Price_2.Text, txtTi_Price_3.Text, txtTi_Price_4.Text, txtTi_Price_5.Text)
            initialiseMode(tsItem_id.Text, "View")
            btnCancel.Text = "Exit"
        ElseIf btnOK.Text = "Edit" Then
            initialiseMode(tsItem_id.Text, "Edit")
            btnCancel.Text = "Cancel"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "Exit" Then
            Me.Close()
        ElseIf btnCancel.Text = "Cancel" Then
            initialiseMode(tsItem_id.Text, "View")
        End If
    End Sub
    Private Function withVat(ByVal cost As Decimal, ByVal vat As Decimal)
        vat = vat + 1
        Return (cost * vat)
    End Function
    Private Function calcMarkUp(ByVal cost As Decimal, ByVal price As Decimal)
        Return (((price - cost) / cost) * 100)
    End Function
    Public Sub New(ByVal item_id As Integer, ByVal UserMode As String)
        ' This call is required by the designer.
        InitializeComponent()           ' Add any initialization after the InitializeComponent() call.
        initialiseMode(item_id, UserMode)
    End Sub
    Private Sub initialiseMode(item_id As Integer, UserMode As String)
        Dim MyTable As New DataTable

        tsItem_id.Text = item_id    'Put item_id on form for other routines to access
        Me.Cursor = Cursors.WaitCursor
        'Get Manufacturers for Combo Box
        MyTable = getManufacturer()
        cbManufacturer.Items.Clear() 'clear combobox so as not to duplicate the list on re-entry
        For Each row As DataRow In MyTable.Rows
            If Not IsDBNull(row("manu_name")) Then
                cbManufacturer.Items.Add(row("manu_name"))
            End If
        Next

        'Get Category for Combo Box
        MyTable = getCategory()
        With cbCategory
            '.Items.Clear() 'clear combobox so as not to duplicate the list on re-entry
            .DataSource = MyTable
            .DisplayMember = "category_name"
            .ValueMember = "category_id"
            'For Each row As DataRow In MyTable.Rows
            'If Not IsDBNull(row("category_name")) Then
            'cbCategory.Items.Add(row("category_name"))
            'cbCategory.Items.Ad = row("category_id")

            'End If
            'Next
        End With

        Me.Cursor = Cursors.Arrow
        If UserMode = "Add" Then
            Me.Text = "Add Inventory"
            btnOK.Text = "Save"
            btnCancel.Text = "Exit"
            ctrlsEnabled(True)
        ElseIf UserMode = "Edit" Then
            Me.Text = "Edit Inventory"
            btnOK.Text = "Update"
            btnCancel.Text = "Cancel"
            ctrlsEnabled(True)
            MyTable = getItem(item_id)
            txtCost.Text = MyTable.Rows(0).Item("item_price")
            txtShortDesc.Text = MyTable.Rows(0).Item("item_description")
            txtLongDesc.Text = MyTable.Rows(0).Item("item_longdescription")
            rtbSpecifications.Text = MyTable.Rows(0).Item("item_specifications")
            cbManufacturer.Text = MyTable.Rows(0).Item("item_manufacturer")
            txtPriSku.Text = MyTable.Rows(0).Item("item_stockcode")
            cbCategory.SelectedValue = MyTable.Rows(0).Item("item_cat_id")
            txtWeight.Text = MyTable.Rows(0).Item("item_weight")
            txtBarcode.Text = MyTable.Rows(0).Item("item_barcode")
            MyTable = getItemPrice(item_id)
            txtPrice_1.Text = MyTable.Rows(0).Item("price_1")
            txtPrice_2.Text = MyTable.Rows(0).Item("price_2")
            txtPrice_3.Text = MyTable.Rows(0).Item("price_3")
            txtPrice_4.Text = MyTable.Rows(0).Item("price_4")
            txtPrice_5.Text = MyTable.Rows(0).Item("price_5")
            txtTi_Price_1.Text = MyTable.Rows(0).Item("ti_price_1")
            txtTi_Price_2.Text = MyTable.Rows(0).Item("ti_price_2")
            txtTi_Price_3.Text = MyTable.Rows(0).Item("ti_price_3")
            txtTi_Price_4.Text = MyTable.Rows(0).Item("ti_price_4")
            txtTi_Price_5.Text = MyTable.Rows(0).Item("ti_price_5")
        ElseIf UserMode = "View" Then
            Me.Text = "View Inventory"
            btnOK.Text = "Edit"
            btnCancel.Text = "Exit"
            ctrlsEnabled(False)
            MyTable = getItem(item_id)
            txtCost.Text = MyTable.Rows(0).Item("item_price")
            txtShortDesc.Text = MyTable.Rows(0).Item("item_description")
            txtLongDesc.Text = MyTable.Rows(0).Item("item_longdescription")
            rtbSpecifications.Text = MyTable.Rows(0).Item("item_specifications")
            cbManufacturer.Text = MyTable.Rows(0).Item("item_manufacturer")
            txtPriSku.Text = MyTable.Rows(0).Item("item_stockcode")
            cbCategory.SelectedValue = MyTable.Rows(0).Item("item_cat_id")
            txtWeight.Text = MyTable.Rows(0).Item("item_weight")
            txtBarcode.Text = MyTable.Rows(0).Item("item_barcode")
            MyTable = getItemPrice(item_id)
            txtPrice_1.Text = MyTable.Rows(0).Item("price_1")
            txtPrice_2.Text = MyTable.Rows(0).Item("price_2")
            txtPrice_3.Text = MyTable.Rows(0).Item("price_3")
            txtPrice_4.Text = MyTable.Rows(0).Item("price_4")
            txtPrice_5.Text = MyTable.Rows(0).Item("price_5")
            txtTi_Price_1.Text = MyTable.Rows(0).Item("ti_price_1")
            txtTi_Price_2.Text = MyTable.Rows(0).Item("ti_price_2")
            txtTi_Price_3.Text = MyTable.Rows(0).Item("ti_price_3")
            txtTi_Price_4.Text = MyTable.Rows(0).Item("ti_price_4")
            txtTi_Price_5.Text = MyTable.Rows(0).Item("ti_price_5")
            MyTable = getItemPicture(item_id)
            If MyTable.Rows(0).Item("picture_location").ToString.Substring(0, 4) = "http" Then
                Console.WriteLine("substring = 'http'")
                picItem.Image = webDownloadImage(MyTable.Rows(0).Item("picture_location").ToString)

            ElseIf MyTable.Rows(0).Item("picture_location").ToString.Substring(1, 3) = ":\" Then
                Console.WriteLine("substring = ':\'")
                picItem.Image = Image.FromFile(MyTable.Rows(0).Item("picture_location").ToString)
            End If
        End If

    End Sub
    Private Sub ctrlsEnabled(lockedStatus As Boolean)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Or TypeOf ctrl Is TabControl Then
                ctrl.Enabled = True
            Else
                ctrl.Enabled = lockedStatus
                'rtxtNotes.Enabled = lockedStatus
            End If
        Next
        For Each ctrl As Control In Me.TabPage1.Controls
            ctrl.Enabled = lockedStatus
        Next
        For Each ctrl As Control In Me.TabPage2.Controls
            ctrl.Enabled = lockedStatus
        Next
    End Sub

    Private Sub txtPrice_1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrice_1.TextChanged
        txtTi_Price_1.Text = withVat(Val(txtPrice_1.Text), 0.2)
    End Sub
    Private Sub txtPrice_2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrice_2.TextChanged
        txtTi_Price_2.Text = withVat(Val(txtPrice_2.Text), 0.2)
    End Sub
    Private Sub txtPrice_3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrice_3.TextChanged
        txtTi_Price_3.Text = withVat(Val(txtPrice_3.Text), 0.2)
    End Sub
    Private Sub txtPrice_4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrice_4.TextChanged
        txtTi_Price_4.Text = withVat(Val(txtPrice_4.Text), 0.2)
    End Sub
    Private Sub txtPrice_5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrice_5.TextChanged
        txtTi_Price_5.Text = withVat(Val(txtPrice_5.Text), 0.2)
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCategory.SelectedIndexChanged
        Console.WriteLine("Value Member = " & cbCategory.ValueMember)
        Console.WriteLine("Selected Value = " & cbCategory.SelectedValue.ToString)
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class