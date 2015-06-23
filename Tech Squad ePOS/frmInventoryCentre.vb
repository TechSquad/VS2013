Public Class frmInventoryCentre

    Private Sub btnCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnAllInventory.Click

        Dim mdi_frmInventoryList As New frmInventoryList

        If Not IsOpen(mdi_frmInventoryList) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmInventoryList
                .MdiParent = frmMainMenu
                .Show()
                Me.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnCreateReceivePO_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        Dim mdi_frmXMLImport As New frmXmlImport

        If Not IsOpen(mdi_frmXMLImport) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmXMLImport
                .MdiParent = frmMainMenu
                .Show()
                Me.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnReceiveWoPO_Click(sender As System.Object, e As System.EventArgs) Handles btnPricing.Click
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnOnOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnPackage.Click

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
        Dim mdi_frmCategoryMenu As New frmCategoryMenu

        If Not IsOpen(mdi_frmCategoryMenu) Then    'check to see if mdi_frmCompany is already open
            With mdi_frmCategoryMenu
                .MdiParent = frmMainMenu
                .Text = "Category Details"
                .Show()
            End With
        End If
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

    Private Sub frmInventoryCentre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class