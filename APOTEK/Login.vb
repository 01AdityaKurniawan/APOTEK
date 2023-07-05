Imports System.Data.SqlClient
Imports System.Windows

Public Class Login
    Dim connectionString As String = "Data Source=ADITYA-PC\ADITSQLSERVER; " &
                "user id=sa; password=123456; Integrated Security=True; " & "database=Apotek"
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM Tabel_Admin WHERE Username = @Username AND Password = @Password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            connection.Open()
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login sukses!")
                ' Menutup form login
                Me.Hide()

                ' Membuka form menu
                Dim menuForm As New Menu()
                menuForm.ShowDialog()

                ' Setelah form menu ditutup, tampilkan kembali form login
                Me.Show()
            Else
                MessageBox.Show("Username atau password salah!")
            End If
        End Using
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class