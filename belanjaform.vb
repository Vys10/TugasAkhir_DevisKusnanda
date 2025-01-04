Public Class belanjaform
    ' Connection string dan koneksi database
    Dim connectionString As String = "server=localhost;userid=root;password=;database=e_commerce"
    Dim conn As New MySqlConnection(connectionString)

    Dim barangData As New Dictionary(Of String, (Kode As String, Harga As Decimal)) From {
        {"Akustik 00- Natural", ("AK001", 4800000D)},
        {"Akustik Antique Natural", ("AK002", 4800000D)},
        {"Akustik Vintage", ("AK003", 4800000D)},
        {"Akustik Sunburst", ("AK004", 4800000D)},
        {"Amplifier Orange Bronco", ("AM001", 48783000D)},
        {"Amplifier California Tweed", ("AM002", 29066000D)},
        {"Amplifier Black Bronco", ("AM003", 43863000D)},
        {"Amplifier Red King", ("AM004", 61286000D)},
        {"Amplifier Black Retro", ("AM005", 23213540D)},
        {"Amplifier TripleCrown Black", ("AM006", 30959000D)},
        {"Effect Discoverer Delay", ("EF001", 2565600D)},
        {"Effect Invader Distorsion", ("EF002", 2565600D)},
        {"Effect Fuzz Tone", ("EF003", 2403910D)},
        {"Effect Ranger Overdrive", ("EF004", 2565600D)},
        {"Effect Orbit Pasher", ("EF005", 2403910D)},
        {"Effect Mariner Tremolo", ("EF006", 2565600D)},
        {"ES Cherry", ("ES001", 56446000D)},
        {"ES Dark Purple", ("ES002", 56446000D)},
        {"ES Supreme Ebony", ("ES003", 69354000D)},
        {"Es Vintage", ("ES004", 48380000D)},
        {"ES Walmut", ("ES005", 161130540D)},
        {"ES Red Wine", ("ES006", 62899000D)},
        {"Lespaul 50s", ("LP001", 45000000D)},
        {"Lespaul 60s", ("LP002", 45000000D)},
        {"Lespaul Purple", ("LP003", 45000000D)},
        {"Lespaul Cobalt Bursh", ("LP004", 32000000D)},
        {"Lespaul Classic White", ("LP005", 133960000D)},
        {"Lespaul Ebony", ("LP006", 117860000D)},
        {"SG Modern Dark Purple", ("SG001", 403100000D)},
        {"SG Double Neck", ("SG002", 120900000D)},
        {"SG Lespaul", ("SG003", 120900000D)},
        {"SG Lespaul Standard", ("SG004", 100320000D)},
        {"SG Supreme Burst", ("SG005", 54960000D)},
        {"SG Trans Black Fade", ("SG006", 40314000D)}
    }


    Private Sub belanjaform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tambahkan nama barang ke ComboBox
        For Each barang In barangData.Keys
            cmbbarang.Items.Add(barang)
        Next
    End Sub

    Private Sub cmbbarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbarang.SelectedIndexChanged
        ' Ambil data barang berdasarkan pilihan di ComboBox
        Dim namaBarang As String = cmbbarang.Text
        If barangData.ContainsKey(namaBarang) Then
            ' Ambil data dari dictionary
            Dim data = barangData(namaBarang)

            ' Isi teks pada TextBox
            txtkodebarang.Text = data.Kode
            txthargabarang.Text = data.Harga.ToString("N0") ' Format harga ke format ribuan

            ' Tampilkan gambar

        End If
    End Sub

    ' Fungsi untuk menghitung subtotal dan total
    Private Sub HitungTotal()
        Try
            Dim jumlah As Integer = If(String.IsNullOrWhiteSpace(txtjumlah.Text), 0, Convert.ToInt32(txtjumlah.Text))
            Dim harga As Decimal = If(String.IsNullOrWhiteSpace(txthargabarang.Text), 0, Decimal.Parse(txthargabarang.Text.Replace(".", "")))

            ' Subtotal tanpa diskon
            Dim subtotal As Decimal = jumlah * harga
            txtsubtotal.Text = subtotal.ToString("N0") ' Format subtotal dengan ribuan

            ' Diskon
            Dim diskon As Decimal = If(String.IsNullOrWhiteSpace(txtdiskon.Text), 0, Convert.ToDecimal(txtdiskon.Text))

            ' Subtotal setelah diskon
            Dim subtotalDiskon As Decimal = subtotal - (subtotal * diskon / 100)
            txtsubtotal.Text = subtotalDiskon.ToString("N0")

            ' Hitung total (harga setelah diskon)
            txttotal.Text = subtotalDiskon.ToString("N0")

            ' Panggil HitungKembalian setiap kali total berubah
            HitungKembalian()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Hitung Total", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi untuk menghitung kembalian
    Private Sub HitungKembalian()
        Try
            ' Mengambil total dan harga yang dibayar (dengan format titik)
            Dim total As Decimal = If(String.IsNullOrWhiteSpace(txttotal.Text), 0, Decimal.Parse(txttotal.Text.Replace(".", "")))
            Dim dibayar As Decimal = If(String.IsNullOrWhiteSpace(txtdibayar.Text), 0, Decimal.Parse(txtdibayar.Text.Replace(".", "")))

            ' Menghitung kembalian
            Dim kembalian As Decimal = dibayar - total
            txtkembalian.Text = kembalian.ToString("N0") ' Menampilkan kembalian dengan format ribuan
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Hitung Kembalian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Ketika jumlah atau diskon berubah
    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged, txtdiskon.TextChanged
        HitungTotal()
    End Sub

    ' Ketika harga yang dibayar diubah
    Private Sub txtdibayar_TextChanged(sender As Object, e As EventArgs) Handles txtdibayar.TextChanged
        Try
            ' Mengambil nilai dari txtdibayar tanpa titik
            Dim dibayar As Decimal
            If Decimal.TryParse(txtdibayar.Text.Replace(".", ""), dibayar) Then
                ' Menampilkan kembali dengan format titik (ribuan) setelah konversi
                txtdibayar.Text = dibayar.ToString("N0")
                ' Posisi kursor tetap di akhir text box
                txtdibayar.SelectionStart = txtdibayar.Text.Length
            Else
                ' Jika input tidak valid, set harga dibayar ke 0
                txtdibayar.Text = "0"
            End If

            ' Panggil fungsi HitungKembalian setelah validasi input
            HitungKembalian()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tombol untuk menyimpan transaksi
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        ' Mengambil data dari form
        Dim kodeBarang As String = txtkodebarang.Text
            Dim namaBarang As String = cmbbarang.Text
            Dim jumlah As Integer = Integer.Parse(txtjumlah.Text)
            Dim hargaBarang As Decimal = Decimal.Parse(txthargabarang.Text.Replace(".", ""))
            Dim subtotal As Decimal = hargaBarang * jumlah
            Dim diskon As Decimal = If(String.IsNullOrWhiteSpace(txtdiskon.Text), 0, Decimal.Parse(txtdiskon.Text))
            Dim total As Decimal = subtotal - (subtotal * diskon / 100)

            ' Periksa apakah barang sudah ada di DataGridView
            Dim barangAda As Boolean = False
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("kd_barang").Value IsNot Nothing AndAlso row.Cells("kd_barang").Value.ToString() = kodeBarang Then
                    ' Ambil data lama dari DataGridView
                    Dim jumlahLama As Integer = Convert.ToInt32(row.Cells("qty").Value)
                    Dim subtotalLama As Decimal = Convert.ToDecimal(row.Cells("subtotal").Value.ToString().Replace(".", "").Replace(",", ""))

                    ' Hitung jumlah baru, subtotal baru, dan total baru
                    Dim jumlahBaru As Integer = jumlahLama + jumlah
                    Dim subtotalBaru As Decimal = jumlahBaru * hargaBarang
                    Dim totalBaru As Decimal = subtotalBaru - (subtotalBaru * diskon / 100)

                    ' Perbarui nilai di DataGridView
                    row.Cells("qty").Value = jumlahBaru.ToString()
                    row.Cells("subtotal").Value = subtotalBaru.ToString("N0") ' Format dengan pemisah ribuan
                    row.Cells("total").Value = totalBaru.ToString("N0")
                    barangAda = True
                    Exit For
                End If
            Next



            If Not barangAda Then
                ' Tambahkan barang baru jika belum ada
                Dim row As String() = New String() {
                kodeBarang,
                namaBarang,
                jumlah.ToString(),
                hargaBarang.ToString("N0"),
                subtotal.ToString("N0"),
                diskon.ToString(),
                total.ToString("N0")
            }
                DataGridView1.Rows.Add(row)
            End If

            ' Simpan ke database MySQL
            Dim query As String

            If barangAda Then
                ' Update database jika barang sudah ada
                query = "UPDATE tbl_barang " &
                        "SET qty = qty + @qty, " &
                        "subtotal = subtotal + @subtotal, " &
                        "total = total + @total " &
                        "WHERE kd_barang = @kd_barang"
            Else
                ' Insert ke database jika barang baru
                query = "INSERT INTO tbl_barang (kd_barang, nm_barang, qty, harga_jual, subtotal, diskon, total) " &
                        "VALUES (@kd_barang, @nm_barang, @qty, @harga_jual, @subtotal, @diskon, @total)"
            End If

            Try
                ' Pastikan koneksi database terbuka
                Using cmd As New MySqlCommand(query, conn)
                    ' Hapus pemisah ribuan (jika ada) sebelum menyimpan angka ke database
                    cmd.Parameters.AddWithValue("@kd_barang", kodeBarang)
                    cmd.Parameters.AddWithValue("@nm_barang", namaBarang)
                    cmd.Parameters.AddWithValue("@qty", jumlah)
                    cmd.Parameters.AddWithValue("@harga_jual", Decimal.Parse(hargaBarang.ToString().Replace(".", "").Replace(",", "")))
                    cmd.Parameters.AddWithValue("@subtotal", Decimal.Parse(subtotal.ToString().Replace(".", "").Replace(",", "")))
                    cmd.Parameters.AddWithValue("@diskon", diskon)
                    cmd.Parameters.AddWithValue("@total", Decimal.Parse(total.ToString().Replace(".", "").Replace(",", "")))

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try


            ' Refresh data di adminform
            Dim adminForm As New adminform()
            adminForm.LoadDataToDataGridView()

    End Sub


    Private Sub btnclosed_Click(sender As Object, e As EventArgs) Handles btnclosed.Click
        Application.Exit()
    End Sub
End Class
