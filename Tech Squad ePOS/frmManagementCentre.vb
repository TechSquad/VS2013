Public Class frmManagementCentre

    Private Sub btnCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click

        Dim mdi_frmDashboard As New frmDashboard

        If Not IsOpen(mdi_frmDashboard) Then    'check to see if mdi_frmCompany is already open
            With mdi_frmDashboard
                .MdiParent = frmMainMenu
                .Text = "Dashboard"
                .Show()
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnCreateReceivePO_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployees.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnReceiveWoPO_Click(sender As System.Object, e As System.EventArgs) Handles btnRefunds.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnOnOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnLoyalty.Click
        
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnPoHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnGiftCards.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnCustomerReturns_Click(sender As System.Object, e As System.EventArgs) Handles btnMarketing.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnRMA_Click(sender As System.Object, e As System.EventArgs) Handles btnDefinitions.Click
        Dim mdi_frmDefinitions As New frmDefinitions

        If Not IsOpen(mdi_frmDefinitions) Then    'check to see if mdi_frmCompany is already open
            With mdi_frmDefinitions
                .MdiParent = frmMainMenu
                .Text = "Definitions"
                .Show()
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnOtherReturns_Click(sender As System.Object, e As System.EventArgs) Handles btnCategories.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnLabels_Click(sender As System.Object, e As System.EventArgs) Handles btnCompany.Click
        Dim mdi_frmCompany As New frmCompany

        If Not IsOpen(mdi_frmCompany) Then    'check to see if mdi_frmCompany is already open
            With mdi_frmCompany
                .MdiParent = frmMainMenu
                .Text = "Comapny Details"
                .Show()
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class