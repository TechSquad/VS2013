Imports System.Windows.Forms

Public Class frmMainMenu

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles tsmSystemSetup.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles tsmStationSetup.Click
        
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomers.Click
        Dim mdi_frmCustomer As New frmCustomer

        If Not IsOpen(mdi_frmCustomer) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmCustomer
                .MdiParent = Me
                .Show()
            End With
            Me.LayoutMdi(MdiLayout.Cascade)
        Else
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles btnInventory.Click
        Dim mdi_frmInventoryCentre As New frmInventoryCentre

        If Not IsOpen(mdi_frmInventoryCentre) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmInventoryCentre
                .MdiParent = Me
                .Show()
                Me.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
        
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles btnMaintenance.Click
        Dim mdi_frmMySqlTools As New frmMySqlTools

        With mdi_frmMySqlTools
            .MdiParent = Me
            .Show()
            Me.LayoutMdi(MdiLayout.Cascade)
        End With
    End Sub

    Private Sub frmMainMenu_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Dim mdi_frmLogin As New frmLogin

        If Not IsOpen(mdi_frmLogin) Then    'check to see if Login form is already open
            If tslLoggedIn.Text = "True" Then
                btnLogin.Text = "Log Out"
                'Console.WriteLine("Logged In")
                For Each ctrl As Control In Me.Panel1.Controls
                    If TypeOf ctrl Is Button And ctrl.Text <> "Log In" Then
                        '.WriteLine("Button Enabled")
                        If My.Settings.dev_security Then
                            ctrl.Enabled = True
                        End If
                    End If
                Next
            Else
                'Console.WriteLine("Not Logged In")
                For Each ctrl As Control In Me.Panel1.Controls
                    If TypeOf ctrl Is Button And ctrl.Text <> "Log In" Then
                        'Console.WriteLine("Button Disabled")
                        If My.Settings.dev_security Then
                            ctrl.Enabled = False
                        End If
                    End If
                Next
                If My.Settings.dev_security Then
                    With mdi_frmLogin
                        .MdiParent = Me
                        .StartPosition = FormStartPosition.CenterScreen
                        .Show()
                    End With
                End If
            End If
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAboutBox.Show()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim mdi_frmLogin As New frmLogin

        If Not IsOpen(mdi_frmLogin) Then    'check to see if Login form is already open
            If btnLogin.Text = "Log In" Then
                With mdi_frmLogin
                    .MdiParent = Me
                    .StartPosition = FormStartPosition.CenterScreen
                    .Show()
                End With
            ElseIf btnLogin.Text = "Log Out" Then
                For Each frm As Form In Me.MdiChildren
                    frm.Close()
                Next
                tslLoggedIn.Text = "False"
                tslUser.Text = ""
                If My.Settings.dev_security Then
                    With mdi_frmLogin
                        .MdiParent = Me
                        .StartPosition = FormStartPosition.CenterScreen
                        .Show()
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub tslLoggedIn_Click(sender As System.Object, e As System.EventArgs) Handles tslLoggedIn.Click

    End Sub

    Private Sub tslLoggedIn_TextChanged(sender As Object, e As System.EventArgs) Handles tslLoggedIn.TextChanged
        If tslLoggedIn.Text = "True" Then
            btnLogin.Text = "Log Out"
            'Console.WriteLine("Logged In")
            For Each ctrl As Control In Me.Panel1.Controls
                If TypeOf ctrl Is Button And ctrl.Text <> "Log In" Then
                    'Console.WriteLine("Button Enabled")
                    If My.Settings.dev_security Then
                        Select Case ctrl.Text
                            Case "Sale"
                                ctrl.Enabled = False
                            Case "Return"
                                ctrl.Enabled = False
                            Case "Service"
                                ctrl.Enabled = False
                            Case "Register"
                                ctrl.Enabled = False
                            Case "Payments"
                                ctrl.Enabled = False
                            Case "e-commerce"
                                ctrl.Enabled = False
                            Case "Purchasing"
                                ctrl.Enabled = True
                            Case "Accounting"
                                ctrl.Enabled = False
                            Case "Management"
                                ctrl.Enabled = True
                            Case Else
                                ctrl.Enabled = True
                        End Select
                    End If
                End If
            Next
        Else
            'Console.WriteLine("Not Logged In")
            btnLogin.Text = "Log In"
            For Each ctrl As Control In Me.Panel1.Controls
                If TypeOf ctrl Is Button And ctrl.Text <> "Log In" Then
                    If My.Settings.dev_security Then
                        'Console.WriteLine("Button Disabled")
                        ctrl.Enabled = False
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnPurchasing_Click(sender As System.Object, e As System.EventArgs) Handles btnPurchasing.Click
        Dim mdi_frmPurchasingCentre As New frmPurchasingCentre

        If Not IsOpen(mdi_frmPurchasingCentre) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmPurchasingCentre
                .MdiParent = Me
                .Show()
            End With
        End If
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If My.Settings.dev_security Then
            If Not is_Database() Then
                MsgBox("Database Not Accessible")
            End If
        End If
    End Sub

    Private Sub btnSale_Click(sender As System.Object, e As System.EventArgs) Handles btnSale.Click
        Dim mdi_frmSale As New frmSale

        If Not IsOpen(mdi_frmSale) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmSale
                .MdiParent = Me
                .Mode = "new"       ' New invoice mode
                .InvNumber = 0      ' No invoice number
                .Show()
            End With
        End If
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnService_Click(sender As System.Object, e As System.EventArgs) Handles btnService.Click
        Dim mdi_frmSupport As New frmSupportCentre

        If Not IsOpen(mdi_frmSupport) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmSupport
                .MdiParent = Me
                '.Mode = "new"       ' New invoice mode
                '.InvNumber = 0      ' No invoice number
                .Show()
            End With
        End If
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnPayments_Click(sender As System.Object, e As System.EventArgs) Handles btnPayments.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnAccounting_Click(sender As System.Object, e As System.EventArgs) Handles btnAccounting.Click
        Me.LayoutMdi(MdiLayout.Cascade)
        Form1.Show()
    End Sub

    Private Sub btnManagement_Click(sender As System.Object, e As System.EventArgs) Handles btnManagement.Click
        Dim mdi_frmManagementCentre As New frmManagementCentre

        If Not IsOpen(mdi_frmManagementCentre) Then    'check to see if mdi_frmPurchasingCentre is already open
            With mdi_frmManagementCentre
                .MdiParent = Me
                .Show()
                Me.LayoutMdi(MdiLayout.Cascade)
            End With
        End If
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
