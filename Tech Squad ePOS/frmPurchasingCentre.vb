Public Class frmPurchasingCentre

    Private Sub btnCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnOrderList.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnCreateReceivePO_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateReceivePO.Click
        Dim mdi_frmPurchaseOrders As New frmPurchaseOrders

        If Not IsOpen(mdi_frmPurchaseOrders) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmPurchaseOrders
                .MdiParent = frmMainMenu
                .Show()
                frmMainMenu.LayoutMdi(MdiLayout.Cascade)

            End With
        End If
    End Sub

    Private Sub btnReceiveWoPO_Click(sender As System.Object, e As System.EventArgs) Handles btnReceiveWoPO.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnOnOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnOnOrder.Click
        Dim mdi_frmPurchaseOrders As New frmPurchaseOrders

        If Not IsOpen(mdi_frmPurchaseOrders) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmPurchaseOrders
                .MdiParent = frmMainMenu
                .Text = "Receive Orders"
                .Show()
                frmMainMenu.LayoutMdi(MdiLayout.Cascade)

            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnPoHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnPoHistory.Click
        Dim mdi_frmPurchaseOrders As New frmPurchaseOrders

        If Not IsOpen(mdi_frmPurchaseOrders) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmPurchaseOrders
                .MdiParent = frmMainMenu
                .Text = "Order History"
                .Show()
                frmMainMenu.LayoutMdi(MdiLayout.Cascade)

            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnCustomerReturns_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomerReturns.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnRMA_Click(sender As System.Object, e As System.EventArgs) Handles btnRMA.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnOtherReturns_Click(sender As System.Object, e As System.EventArgs) Handles btnOtherReturns.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnLabels_Click(sender As System.Object, e As System.EventArgs) Handles btnLabels.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class