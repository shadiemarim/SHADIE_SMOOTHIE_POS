Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles login.Click
        If Len(Trim(UserName.Text)) = 0 Then
            MessageBox.Show("Please Enter UserName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Focus()
            Exit Sub

        End If

        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
            Exit Sub
        End If

        Dim MySQLConnection As New MySqlConnection("host=127.0.0.1; user=root; database=vbnet_users_db")
        Dim myCommand As MySqlCommand
        myCommand = New MySqlCommand("SELECT  `Username`, `Password` FROM `users` WHERE `UserName`=@Username and `Password`=@Password", MySQLConnection)
        myCommand.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = UserName.Text
        myCommand.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password.Text
        myCommand.Connection.Open()
        Dim myReader As MySqlDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
        Dim Login As Object = 0
        If myReader.HasRows Then
            myReader.Read()
            Login = myReader(Login)
        End If
        If Login = Nothing Then
            MsgBox("Login Failed...Try Again!", MsgBoxStyle.Critical, "Login Denied")
            UserName.Clear()
            Password.Clear()
            UserName.Focus()
        Else
            ProgressBar1.Visible = True
            ProgressBar1.Maximum = 5000
            ProgressBar1.Minimum = 0
            ProgressBar1.Value = 4
            ProgressBar1.Step = 1
            For i = 0 To 5000
                ProgressBar1.PerformStep()
            Next
            FrmMain.show()
        End If
        'Try
        '    MySqlConnection.Open()

        '    MessageBox.Show("success")
        'Catch ex As Exception

        '    Dim ex_Message As String = Nothing
        '    MessageBox.Show("I am thebbug" + ex_Message)

        'End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class