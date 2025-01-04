<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
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
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        btntambah = New Button()
        btnedit = New Button()
        btnhapus = New Button()
        GroupBox1 = New GroupBox()
        txtcari = New TextBox()
        rbnama = New RadioButton()
        rbkode = New RadioButton()
        rbsemua = New RadioButton()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnclosed)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1444, 257)
        Panel1.TabIndex = 3
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(23, 380)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1400, 456)
        DataGridView1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("TradeGothic LT CondEighteen", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(7, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(259, 59)
        Label2.TabIndex = 5
        Label2.Text = "DATA BARANG"
        ' 
        ' btntambah
        ' 
        btntambah.BackColor = Color.Maroon
        btntambah.Cursor = Cursors.Hand
        btntambah.FlatStyle = FlatStyle.Flat
        btntambah.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntambah.ForeColor = Color.Red
        btntambah.Location = New Point(23, 861)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(177, 56)
        btntambah.TabIndex = 7
        btntambah.Text = "Tambah"
        btntambah.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.Maroon
        btnedit.Cursor = Cursors.Hand
        btnedit.FlatStyle = FlatStyle.Flat
        btnedit.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnedit.ForeColor = Color.Red
        btnedit.Location = New Point(241, 861)
        btnedit.Name = "btnedit"
        btnedit.RightToLeft = RightToLeft.No
        btnedit.Size = New Size(177, 56)
        btnedit.TabIndex = 8
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btnhapus
        ' 
        btnhapus.BackColor = Color.Maroon
        btnhapus.Cursor = Cursors.Hand
        btnhapus.FlatStyle = FlatStyle.Flat
        btnhapus.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnhapus.ForeColor = Color.Red
        btnhapus.Location = New Point(460, 861)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(177, 56)
        btnhapus.TabIndex = 9
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtcari)
        GroupBox1.Controls.Add(rbnama)
        GroupBox1.Controls.Add(rbkode)
        GroupBox1.Controls.Add(rbsemua)
        GroupBox1.Location = New Point(907, 261)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(487, 113)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filter"
        ' 
        ' txtcari
        ' 
        txtcari.Location = New Point(28, 69)
        txtcari.Name = "txtcari"
        txtcari.Size = New Size(435, 31)
        txtcari.TabIndex = 3
        ' 
        ' rbnama
        ' 
        rbnama.AutoSize = True
        rbnama.Cursor = Cursors.Hand
        rbnama.Location = New Point(319, 30)
        rbnama.Name = "rbnama"
        rbnama.Size = New Size(144, 29)
        rbnama.TabIndex = 2
        rbnama.TabStop = True
        rbnama.Text = "Nama Barang"
        rbnama.UseVisualStyleBackColor = True
        ' 
        ' rbkode
        ' 
        rbkode.AutoSize = True
        rbkode.Cursor = Cursors.Hand
        rbkode.Location = New Point(159, 30)
        rbkode.Name = "rbkode"
        rbkode.Size = New Size(137, 29)
        rbkode.TabIndex = 1
        rbkode.TabStop = True
        rbkode.Text = "kode Barang"
        rbkode.UseVisualStyleBackColor = True
        ' 
        ' rbsemua
        ' 
        rbsemua.AutoSize = True
        rbsemua.Cursor = Cursors.Hand
        rbsemua.Location = New Point(28, 30)
        rbsemua.Name = "rbsemua"
        rbsemua.Size = New Size(91, 29)
        rbsemua.TabIndex = 0
        rbsemua.TabStop = True
        rbsemua.Text = "Semua"
        rbsemua.UseVisualStyleBackColor = True
        ' 
        ' adminform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1444, 938)
        Controls.Add(GroupBox1)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "adminform"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnclosed As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btntambah As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnama As RadioButton
    Friend WithEvents rbkode As RadioButton
    Friend WithEvents rbsemua As RadioButton
    Friend WithEvents txtcari As TextBox
End Class
