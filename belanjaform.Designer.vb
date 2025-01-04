<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class belanjaform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        btnclosed = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cmbbarang = New ComboBox()
        txtkodebarang = New TextBox()
        txtjumlah = New TextBox()
        txthargabarang = New TextBox()
        DataGridView1 = New DataGridView()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtsubtotal = New TextBox()
        txtdiskon = New TextBox()
        txtdibayar = New TextBox()
        txtkembalian = New TextBox()
        txttotal = New TextBox()
        btnsimpan = New Button()
        kd_barang = New DataGridViewTextBoxColumn()
        nm_barang = New DataGridViewTextBoxColumn()
        qty = New DataGridViewTextBoxColumn()
        harga_jual = New DataGridViewTextBoxColumn()
        subtotal = New DataGridViewTextBoxColumn()
        diskon = New DataGridViewTextBoxColumn()
        total = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnclosed)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1450, 257)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(-11, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(465, 96)
        Label1.TabIndex = 1
        Label1.Text = "Vys Guitars"
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.WaitCursor
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = My.Resources.Resources.logo1
        Button1.Location = New Point(460, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 156)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnclosed
        ' 
        btnclosed.Cursor = Cursors.Hand
        btnclosed.FlatAppearance.BorderSize = 0
        btnclosed.FlatStyle = FlatStyle.Flat
        btnclosed.ForeColor = Color.Transparent
        btnclosed.Image = My.Resources.Resources.person2
        btnclosed.Location = New Point(1374, 12)
        btnclosed.Name = "btnclosed"
        btnclosed.Size = New Size(64, 74)
        btnclosed.TabIndex = 1
        btnclosed.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.MenuBar
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("TradeGothic LT Extended", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(12, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 40)
        Label2.TabIndex = 3
        Label2.Text = "Kode Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.MenuBar
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("TradeGothic LT Extended", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(351, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(261, 40)
        Label3.TabIndex = 4
        Label3.Text = "Nama Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.MenuBar
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("TradeGothic LT Extended", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(710, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 40)
        Label4.TabIndex = 5
        Label4.Text = "Jumlah"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.MenuBar
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("TradeGothic LT Extended", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(974, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 40)
        Label5.TabIndex = 6
        Label5.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.MenuBar
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("TradeGothic LT Extended", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(1223, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 40)
        Label6.TabIndex = 7
        Label6.Text = "Total"
        ' 
        ' cmbbarang
        ' 
        cmbbarang.FormattingEnabled = True
        cmbbarang.Location = New Point(351, 328)
        cmbbarang.Name = "cmbbarang"
        cmbbarang.Size = New Size(250, 33)
        cmbbarang.TabIndex = 8
        ' 
        ' txtkodebarang
        ' 
        txtkodebarang.Location = New Point(12, 328)
        txtkodebarang.Name = "txtkodebarang"
        txtkodebarang.Size = New Size(250, 31)
        txtkodebarang.TabIndex = 9
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(710, 330)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(141, 31)
        txtjumlah.TabIndex = 10
        ' 
        ' txthargabarang
        ' 
        txthargabarang.Location = New Point(935, 330)
        txthargabarang.Name = "txthargabarang"
        txthargabarang.Size = New Size(184, 31)
        txthargabarang.TabIndex = 11
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {kd_barang, nm_barang, qty, harga_jual, subtotal, diskon, total})
        DataGridView1.Location = New Point(12, 382)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1420, 310)
        DataGridView1.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.MenuBar
        Label8.FlatStyle = FlatStyle.Flat
        Label8.Font = New Font("TradeGothic LT", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(12, 701)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 30)
        Label8.TabIndex = 14
        Label8.Text = "Sub Total"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.MenuBar
        Label9.FlatStyle = FlatStyle.Flat
        Label9.Font = New Font("TradeGothic LT", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(12, 750)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 30)
        Label9.TabIndex = 15
        Label9.Text = "Diskon"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.MenuBar
        Label10.FlatStyle = FlatStyle.Flat
        Label10.Font = New Font("TradeGothic LT", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(12, 797)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 30)
        Label10.TabIndex = 16
        Label10.Text = "Di Bayar"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.MenuBar
        Label11.FlatStyle = FlatStyle.Flat
        Label11.Font = New Font("TradeGothic LT", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(12, 847)
        Label11.Name = "Label11"
        Label11.Size = New Size(125, 30)
        Label11.TabIndex = 17
        Label11.Text = "Kembalian"
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Location = New Point(155, 700)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.Size = New Size(220, 31)
        txtsubtotal.TabIndex = 18
        ' 
        ' txtdiskon
        ' 
        txtdiskon.Location = New Point(155, 749)
        txtdiskon.Name = "txtdiskon"
        txtdiskon.Size = New Size(220, 31)
        txtdiskon.TabIndex = 19
        ' 
        ' txtdibayar
        ' 
        txtdibayar.Location = New Point(155, 796)
        txtdibayar.Name = "txtdibayar"
        txtdibayar.Size = New Size(220, 31)
        txtdibayar.TabIndex = 20
        ' 
        ' txtkembalian
        ' 
        txtkembalian.Location = New Point(155, 846)
        txtkembalian.Name = "txtkembalian"
        txtkembalian.Size = New Size(220, 31)
        txtkembalian.TabIndex = 21
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(1184, 328)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(215, 31)
        txttotal.TabIndex = 22
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(209, 892)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(112, 34)
        btnsimpan.TabIndex = 23
        btnsimpan.Text = "Simpan"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' kd_barang
        ' 
        kd_barang.HeaderText = "Kode Barang"
        kd_barang.MinimumWidth = 8
        kd_barang.Name = "kd_barang"
        kd_barang.Width = 150
        ' 
        ' nm_barang
        ' 
        nm_barang.HeaderText = "Nama Barang"
        nm_barang.MinimumWidth = 8
        nm_barang.Name = "nm_barang"
        nm_barang.Width = 200
        ' 
        ' qty
        ' 
        qty.HeaderText = "Jumlah"
        qty.MinimumWidth = 8
        qty.Name = "qty"
        qty.Width = 150
        ' 
        ' harga_jual
        ' 
        harga_jual.HeaderText = "Harga Barang"
        harga_jual.MinimumWidth = 8
        harga_jual.Name = "harga_jual"
        harga_jual.Width = 150
        ' 
        ' subtotal
        ' 
        subtotal.HeaderText = "Sub Total"
        subtotal.MinimumWidth = 8
        subtotal.Name = "subtotal"
        subtotal.Width = 150
        ' 
        ' diskon
        ' 
        diskon.HeaderText = "Diskon"
        diskon.MinimumWidth = 8
        diskon.Name = "diskon"
        diskon.Width = 150
        ' 
        ' total
        ' 
        total.HeaderText = "Total"
        total.MinimumWidth = 8
        total.Name = "total"
        total.Width = 150
        ' 
        ' belanjaform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1444, 938)
        Controls.Add(btnsimpan)
        Controls.Add(txttotal)
        Controls.Add(txtkembalian)
        Controls.Add(txtdibayar)
        Controls.Add(txtdiskon)
        Controls.Add(txtsubtotal)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(DataGridView1)
        Controls.Add(txthargabarang)
        Controls.Add(txtjumlah)
        Controls.Add(txtkodebarang)
        Controls.Add(cmbbarang)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "belanjaform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "belanjaform"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnclosed As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbbarang As ComboBox
    Friend WithEvents txtkodebarang As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txthargabarang As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents txtdibayar As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnsimpan As Button
    Friend WithEvents kd_barang As DataGridViewTextBoxColumn
    Friend WithEvents nm_barang As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
