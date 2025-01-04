Imports System.Runtime.Intrinsics.Arm
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
Public Class LoginForm
    Dim connection As MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi koneksi
        connection = New MySqlConnection("server=localhost;userid=root;password=;database=e_commerce;")
    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read() ' Membaca baris pertama hasil query
                MessageBox.Show("Login successful!")

                ' Cek status pengguna
                If reader("status").ToString() = "admin" Then
                    Me.Hide()
                    adminform.Show()
                Else
                    Me.Hide()
                    halamanform.Show()
                End If
            Else
                MessageBox.Show("Invalid username or password.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Function rd(v As String) As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        registerform.Show()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
