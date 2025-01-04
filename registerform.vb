Imports MySql.Data.MySqlClient
Public Class registerform
    Dim connection As MySqlConnection
    Private Sub registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi koneksi
        connection = New MySqlConnection("server=localhost;userid=root;password=;database=e_commerce;")


    End Sub
    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Try
            ' Koneksi ke database
            Dim connectionString As String = "server=localhost;userid=root;password=;database=e_commerce;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query untuk memasukkan data ke tabel users
                Dim query As String = "INSERT INTO users (username, password) VALUES (@username, @password)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", txtusername.Text)
                    command.Parameters.AddWithValue("@password", txtpassword.Text) ' Gunakan hashing pada password di dunia nyata

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registrasi berhasil! Silakan login.")

                        ' Menampilkan FormLogin dan menyembunyikan FormRegister
                        Dim LoginForm As New LoginForm()
                        LoginForm.Show()
                        Me.Close() ' Menyembunyikan FormRegister
                    Else
                        MessageBox.Show("Registrasi gagal. Silakan coba lagi.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class
