<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputbarangform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inputbarangform))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnclose = New Button()
        Panel3 = New Panel()
        txtharga = New TextBox()
        txtstok = New TextBox()
        txtnama = New TextBox()
        txtkode = New TextBox()
        btnsimpan = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1226, 554)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(btnclose)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1226, 554)
        Panel2.TabIndex = 1
        ' 
        ' btnclose
        ' 
        btnclose.BackColor = Color.Transparent
        btnclose.FlatAppearance.BorderSize = 0
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.ForeColor = Color.Transparent
        btnclose.Image = CType(resources.GetObject("btnclose.Image"), Image)
        btnclose.Location = New Point(1162, 12)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(52, 65)
        btnclose.TabIndex = 1
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txtharga)
        Panel3.Controls.Add(txtstok)
        Panel3.Controls.Add(txtnama)
        Panel3.Controls.Add(txtkode)
        Panel3.Controls.Add(btnsimpan)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(418, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(489, 568)
        Panel3.TabIndex = 0
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(229, 363)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(216, 31)
        txtharga.TabIndex = 9
        ' 
        ' txtstok
        ' 
        txtstok.Location = New Point(229, 287)
        txtstok.Name = "txtstok"
        txtstok.Size = New Size(216, 31)
        txtstok.TabIndex = 8
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(229, 216)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(216, 31)
        txtnama.TabIndex = 7
        ' 
        ' txtkode
        ' 
        txtkode.Location = New Point(229, 147)
        txtkode.Name = "txtkode"
        txtkode.Size = New Size(216, 31)
        txtkode.TabIndex = 6
        ' 
        ' btnsimpan
        ' 
        btnsimpan.BackColor = Color.Black
        btnsimpan.Cursor = Cursors.Hand
        btnsimpan.FlatStyle = FlatStyle.Flat
        btnsimpan.Font = New Font("TradeGothic LT Extended", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsimpan.ForeColor = Color.White
        btnsimpan.Location = New Point(135, 441)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(186, 65)
        btnsimpan.TabIndex = 5
        btnsimpan.Text = "Simpan"
        btnsimpan.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("TradeGothic LT CondEighteen", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(32, 355)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 39)
        Label5.TabIndex = 4
        Label5.Text = "Harga Jual"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("TradeGothic LT CondEighteen", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(32, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 39)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("TradeGothic LT CondEighteen", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(32, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 39)
        Label3.TabIndex = 2
        Label3.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("TradeGothic LT CondEighteen", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 39)
        Label2.TabIndex = 1
        Label2.Text = "Kode Barang"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("TradeGothic LT Extended", 28F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(20, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(434, 71)
        Label1.TabIndex = 0
        Label1.Text = "Input Barang"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' inputbarangform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1226, 554)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "inputbarangform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "inputbarangform"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtkode As TextBox
    Friend WithEvents btnsimpan As Button
End Class
