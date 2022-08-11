Public Class frmWelcomePage
    Dim username As String
    Dim password As String

    'Login infomation
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        username = txtUsername.Text()
        password = txtPassword.Text()
        If username = ("admin") And password = ("admin") Then
            MsgBox("Login successful!")
            Me.Hide()
            frmFoodPage.Show()
        Else
            MsgBox("Error,Please try again.")
        End If
    End Sub

    Private Sub frmWelcomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
    End Sub
End Class
