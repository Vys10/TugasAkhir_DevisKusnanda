Imports MySql.Data.MySqlClient
Public Class adminform
    Private connectionString As String = "server=localhost;userid=root;password=;database=e_commerce"
    Private conn As MySqlConnection
    Private Sub btnclosed_Click(sender As Object, e As EventArgs) Handles btnclosed.Click
        Application.Exit()
    End Sub

    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Optional: Muat data langsung saat form dibuka
        LoadDataToDataGridView()
    End Sub

    Public Sub LoadDataToDataGridView()
        Dim query As String = "SELECT kd_barang AS 'Kode Barang', nm_barang AS 'Nama Barang', qty AS 'Jumlah', harga_jual AS 'Harga', diskon AS 'Diskon' FROM tbl_barang"
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Tambahkan kolom Total ke DataTable jika belum ada
            If Not table.Columns.Contains("Total") Then
                table.Columns.Add("Total", GetType(Decimal))
            End If

            ' Hitung Total untuk setiap baris
            For Each row As DataRow In table.Rows
                Dim harga As Decimal = Convert.ToDecimal(row("Harga"))
                Dim qty As Integer = Convert.ToInt32(row("Jumlah"))
                Dim diskon As Decimal = If(IsDBNull(row("Diskon")), 0, Convert.ToDecimal(row("Diskon")))
                Dim subtotal As Decimal = (harga * qty) - ((harga * qty) * diskon / 100)
                row("Total") = subtotal
            Next

            ' Tampilkan data di DataGridView
            DataGridView1.DataSource = table

            ' Format kolom untuk tampil dengan ribuan
            With DataGridView1
                If .Columns.Contains("Harga") Then .Columns("Harga").DefaultCellStyle.Format = "N0"
                If .Columns.Contains("Diskon") Then .Columns("Diskon").DefaultCellStyle.Format = "N0"
                If .Columns.Contains("Total") Then .Columns("Total").DefaultCellStyle.Format = "N0"
            End With
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btnloaddata_Click(sender As Object, e As EventArgs)
        LoadDataToDataGridView()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        ' Membuka form input untuk tambah barang
        Dim inputForm As New inputbarangform()
        inputForm.aksi = "entry" ' Set aksi ke "entry" untuk menambah data baru
        inputForm.ShowDialog()

        ' Memuat ulang data setelah form ditutup
        LoadDataToDataGridView()
    End Sub


    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim kodeBarang As String = selectedRow.Cells("Kode Barang").Value.ToString()

        Dim result = MessageBox.Show($"Apakah Anda yakin ingin menghapus data dengan Kode Barang: {kodeBarang}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM tbl_barang WHERE kd_barang = @kd_barang"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kd_barang", kodeBarang)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadDataToDataGridView()
                    Else
                        MessageBox.Show("Data tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub




    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        ' Pastikan ada teks yang dimasukkan
        Dim searchKeyword As String = txtcari.Text.Trim()
        If String.IsNullOrWhiteSpace(searchKeyword) Then
            LoadDataToDataGridView() ' Muat data jika tidak ada pencarian
            Return
        End If

        ' Tentukan kriteria pencarian berdasarkan RadioButton yang aktif
        Dim query As String = "SELECT * FROM tbl_barang WHERE "
        If rbkode.Checked Then
            query &= "kd_barang LIKE @keyword"
        ElseIf rbnama.Checked Then
            query &= "nm_barang LIKE @keyword"
        ElseIf rbsemua.Checked Then
            query &= "(kd_barang LIKE @keyword OR nm_barang LIKE @keyword OR harga_jual LIKE @keyword OR qty LIKE @keyword)"
        End If

        ' Tambahkan pengurutan berdasarkan nama barang (A-Z)
        query &= " ORDER BY nm_barang ASC"

        ' Koneksi ke database
        Dim connectionString As String = "server=localhost;userid=root;password=;database=e_commerce"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@keyword", "%" & searchKeyword & "%") ' Menambahkan wildcard untuk pencarian

            ' Menampilkan hasil pencarian di DataGridView
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)


            ' Menghitung diskon dan subtotal untuk setiap baris
            For Each row As DataRow In table.Rows
                Dim harga As Decimal = Convert.ToDecimal(row("harga_jual"))
                Dim qty As Integer = Convert.ToInt32(row("qty"))

                ' Contoh diskon 10%, bisa diubah sesuai kebutuhan
                Dim diskon As Decimal = harga * 0.1D
                row("diskon") = diskon

                ' Hitung subtotal setelah diskon
                Dim subtotal As Decimal = (harga - diskon) * qty
                row("subtotal") = subtotal
            Next

            DataGridView1.DataSource = table

            ' Jika tidak ada data yang ditemukan
            If table.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data yang ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Pilih data yang akan diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim inputForm As New inputbarangform()
            inputForm.txtkode.Text = selectedRow.Cells("Kode Barang").Value.ToString()
            inputForm.txtnama.Text = selectedRow.Cells("Nama Barang").Value.ToString()
            inputForm.txtstok.Text = selectedRow.Cells("Jumlah").Value.ToString()
            inputForm.txtharga.Text = Convert.ToDecimal(selectedRow.Cells("Harga").Value).ToString("N0")

            inputForm.aksi = "edit"
            inputForm.ShowDialog()

            LoadDataToDataGridView()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class