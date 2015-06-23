Public Class frmSupportCentre
    Private Sub btnCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btnSupportDashboard.Click
        Dim mdi_frmSupportDashboard As New frmSupportDashboard

        If Not IsOpen(mdi_frmSupportDashboard) Then    'check to see if mdi_SupportCentre is already open
            With mdi_frmSupportDashboard
                .MdiParent = frmMainMenu
                .Show()
                Me.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnCreateReceivePO_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        ' add ticket
        Dim mdi_frmSupportDashboard As New frmSupportDashboard  ' Create Support Dashboard

        If Not IsOpen(mdi_frmSupportDashboard) Then    'check to see if mdi_frmSupportDashboard is already open
            With mdi_frmSupportDashboard
                .MdiParent = frmMainMenu
                .Text = "Add Support Customer"
                .Show()
                .add_ticket()
            End With
        End If
        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub btnReceiveWoPO_Click(sender As System.Object, e As System.EventArgs) Handles btnWorkshop.Click
        Dim mdi_frmWorkshopDashboard As New frmWorkshopDashboard(0, "0")

        If Not IsOpen(mdi_frmWorkshopDashboard) Then    'check to see if mdi_SupportCentre is already open
            With mdi_frmWorkshopDashboard
                .MdiParent = frmMainMenu
                .Show()
                Me.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
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
                .Text = "Company Details"
                .Show()
            End With
        End If
        frmMainMenu.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub frmInventoryCentre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class