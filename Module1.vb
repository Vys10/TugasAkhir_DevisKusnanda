Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public str As String
    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=; database=db_xyz"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("Koneksi sukses")
            Else
                MessageBox.Show("Koneksi gagal")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
