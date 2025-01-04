<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class halamanform
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
        btneffect = New Button()
        btnamplifier = New Button()
        btnlespaul = New Button()
        btnsg = New Button()
        btnes = New Button()
        btnakustik = New Button()
        btnclosed = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btneffect)
        Panel1.Controls.Add(btnamplifier)
        Panel1.Controls.Add(btnlespaul)
        Panel1.Controls.Add(btnsg)
        Panel1.Controls.Add(btnes)
        Panel1.Controls.Add(btnakustik)
        Panel1.Controls.Add(btnclosed)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1444, 257)
        Panel1.TabIndex = 0
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
        ' btneffect
        ' 
        btneffect.BackColor = Color.DarkRed
        btneffect.BackgroundImageLayout = ImageLayout.None
        btneffect.Cursor = Cursors.Hand
        btneffect.FlatAppearance.BorderSize = 0
        btneffect.FlatStyle = FlatStyle.Flat
        btneffect.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btneffect.ForeColor = Color.Cyan
        btneffect.Location = New Point(1274, 201)
        btneffect.Name = "btneffect"
        btneffect.Size = New Size(158, 55)
        btneffect.TabIndex = 2
        btneffect.Text = "Effect"
        btneffect.UseVisualStyleBackColor = False
        ' 
        ' btnamplifier
        ' 
        btnamplifier.BackColor = Color.DarkRed
        btnamplifier.Cursor = Cursors.Hand
        btnamplifier.FlatAppearance.BorderSize = 0
        btnamplifier.FlatStyle = FlatStyle.Flat
        btnamplifier.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnamplifier.ForeColor = Color.Cyan
        btnamplifier.Location = New Point(1110, 201)
        btnamplifier.Name = "btnamplifier"
        btnamplifier.Size = New Size(158, 55)
        btnamplifier.TabIndex = 2
        btnamplifier.Text = "Amplifier"
        btnamplifier.UseVisualStyleBackColor = False
        ' 
        ' btnlespaul
        ' 
        btnlespaul.BackColor = Color.DarkRed
        btnlespaul.Cursor = Cursors.Hand
        btnlespaul.FlatAppearance.BorderSize = 0
        btnlespaul.FlatStyle = FlatStyle.Flat
        btnlespaul.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnlespaul.ForeColor = Color.Cyan
        btnlespaul.Location = New Point(946, 201)
        btnlespaul.Name = "btnlespaul"
        btnlespaul.Size = New Size(158, 55)
        btnlespaul.TabIndex = 2
        btnlespaul.Text = "LesPaul"
        btnlespaul.UseVisualStyleBackColor = False
        ' 
        ' btnsg
        ' 
        btnsg.BackColor = Color.DarkRed
        btnsg.Cursor = Cursors.Hand
        btnsg.FlatAppearance.BorderSize = 0
        btnsg.FlatStyle = FlatStyle.Flat
        btnsg.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnsg.ForeColor = Color.Cyan
        btnsg.Location = New Point(782, 201)
        btnsg.Name = "btnsg"
        btnsg.Size = New Size(158, 55)
        btnsg.TabIndex = 2
        btnsg.Text = "SG"
        btnsg.UseVisualStyleBackColor = False
        ' 
        ' btnes
        ' 
        btnes.BackColor = Color.DarkRed
        btnes.Cursor = Cursors.Hand
        btnes.FlatAppearance.BorderSize = 0
        btnes.FlatStyle = FlatStyle.Flat
        btnes.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnes.ForeColor = Color.Cyan
        btnes.Location = New Point(618, 201)
        btnes.Name = "btnes"
        btnes.Size = New Size(158, 55)
        btnes.TabIndex = 2
        btnes.Text = "ES"
        btnes.UseVisualStyleBackColor = False
        ' 
        ' btnakustik
        ' 
        btnakustik.BackColor = Color.DarkRed
        btnakustik.Cursor = Cursors.Hand
        btnakustik.FlatAppearance.BorderSize = 0
        btnakustik.FlatStyle = FlatStyle.Flat
        btnakustik.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnakustik.ForeColor = Color.Cyan
        btnakustik.Location = New Point(454, 201)
        btnakustik.Name = "btnakustik"
        btnakustik.Size = New Size(158, 55)
        btnakustik.TabIndex = 1
        btnakustik.Text = "Akustik"
        btnakustik.UseVisualStyleBackColor = False
        ' 
        ' btnclosed
        ' 
        btnclosed.Cursor = Cursors.Hand
        btnclosed.FlatAppearance.BorderSize = 0
        btnclosed.FlatStyle = FlatStyle.Flat
        btnclosed.ForeColor = Color.Transparent
        btnclosed.Image = My.Resources.Resources.person2
        btnclosed.Location = New Point(1368, 12)
        btnclosed.Name = "btnclosed"
        btnclosed.Size = New Size(64, 74)
        btnclosed.TabIndex = 1
        btnclosed.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = SystemColors.MenuBar
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 257)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1444, 681)
        Panel2.TabIndex = 1
        ' 
        ' halamanform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = SystemColors.MenuBar
        ClientSize = New Size(1444, 938)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "halamanform"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclosed As Button
    Friend WithEvents btnsg As Button
    Friend WithEvents btnes As Button
    Friend WithEvents btnakustik As Button
    Friend WithEvents btnlespaul As Button
    Friend WithEvents btneffect As Button
    Friend WithEvents btnamplifier As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
