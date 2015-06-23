Public Class frmLogin
    Public Event LogonCompleted(ByVal UserName As String)
    Public Event LogonFailed()

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If isAllowed(txtUser.Text, txtPassword.Text) Then
            frmMainMenu.tslUser.Text = txtUser.Text
            frmMainMenu.tslLoggedIn.Text = "True"
            RaiseEvent LogonCompleted(txtUser.Text)
            Me.Close()
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
            txtPassword.Text = ""
            lblMessage.Visible = True
            Timer1.Enabled = True
            frmMainMenu.tslUser.Text = "invalid username or password"
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        RaiseEvent LogonFailed()
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If lblMessage.Visible Then
            lblMessage.Visible = False
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
End Class
