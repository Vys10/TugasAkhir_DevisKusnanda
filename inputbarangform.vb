Imports System.Net
Imports MySql.Data.MySqlClient
Public Class inputbarangform
    Public aksi As String
    Private Sub inputbarangform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If aksi = "edit" Then
            ' Pastikan harga diset dengan benar saat edit
            ' Hilangkan pemisah ribuan pada harga
            txtharga.Text = txtharga.Text.Replace(",", "")

            ' Set nilai kontrol untuk kode, nama, stok
            ' Data ini sudah dikirim dari adminform
        End If
    End Sub



    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Sub clear()
        txtkode.Text = ""
        txtnama.Text = ""
        txtstok.Text = ""
        txtharga.Text = ""
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        ' Validasi input
        If String.IsNullOrWhiteSpace(txtkode.Text) Or String.IsNullOrWhiteSpace(txtnama.Text) Or
       String.IsNullOrWhiteSpace(txtstok.Text) Or String.IsNullOrWhiteSpace(txtharga.Text) Then
            MessageBox.Show("Lengkapi data terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connectionString As String = "server=localhost;userid=root;password=;database=e_commerce"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            Dim query As String
            If aksi = "entry" Then
                ' Query untuk menyimpan data baru
                query = "INSERT INTO tbl_barang (kd_barang, nm_barang, qty, harga_jual) VALUES (@kd_barang, @nm_barang, @qty, @harga_jual)"
            ElseIf aksi = "edit" Then
                ' Query untuk memperbarui data
                query = "UPDATE tbl_barang SET nm_barang = @nm_barang, qty = @qty, harga_jual = @harga_jual WHERE kd_barang = @kd_barang"
            Else
                MessageBox.Show("Aksi tidak valid. Harap periksa kode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Persiapan harga sebelum disimpan
            Dim hargaBersih As Decimal = Decimal.Parse(txtharga.Text.Replace(",", "")) ' Hapus pemisah ribuan
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@kd_barang", txtkode.Text)
            command.Parameters.AddWithValue("@nm_barang", txtnama.Text)
            command.Parameters.AddWithValue("@qty", Convert.ToInt32(txtstok.Text))
            command.Parameters.AddWithValue("@harga_jual", hargaBersih)

            ' Eksekusi query
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tidak ada data yang diubah. Periksa kode barang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Reset form setelah simpan
            clear()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub



    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        If Not String.IsNullOrEmpty(txtharga.Text) Then
            Dim angka As Double
            If Double.TryParse(txtharga.Text.Replace(".", ""), angka) Then
                ' Hindari pemformatan berulang kali
                Dim tempText As String = angka.ToString("N0")
                If txtharga.Text <> tempText Then
                    txtharga.Text = tempText
                    txtharga.SelectionStart = txtharga.Text.Length ' Pindahkan kursor ke akhir
                End If
            End If
        End If

    End Sub

End Class