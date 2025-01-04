<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnclose1 = New Button()
        effect_btn = New Button()
        amplifier_btn = New Button()
        holobody_btn = New Button()
        lespaul_btn = New Button()
        sg_btn = New Button()
        akustik_btn = New Button()
        Label1 = New Label()
        show_panel = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnclose1)
        Panel1.Controls.Add(effect_btn)
        Panel1.Controls.Add(amplifier_btn)
        Panel1.Controls.Add(holobody_btn)
        Panel1.Controls.Add(lespaul_btn)
        Panel1.Controls.Add(sg_btn)
        Panel1.Controls.Add(akustik_btn)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1465, 168)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(375, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 153)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' btnclose1
        ' 
        btnclose1.BackColor = Color.Transparent
        btnclose1.Cursor = Cursors.Hand
        btnclose1.FlatAppearance.BorderSize = 0
        btnclose1.FlatStyle = FlatStyle.Flat
        btnclose1.ForeColor = Color.Transparent
        btnclose1.Image = CType(resources.GetObject("btnclose1.Image"), Image)
        btnclose1.Location = New Point(1384, 12)
        btnclose1.Name = "btnclose1"
        btnclose1.Size = New Size(49, 61)
        btnclose1.TabIndex = 6
        btnclose1.UseVisualStyleBackColor = False
        ' 
        ' effect_btn
        ' 
        effect_btn.BackColor = Color.Transparent
        effect_btn.Cursor = Cursors.Hand
        effect_btn.FlatAppearance.BorderSize = 0
        effect_btn.FlatStyle = FlatStyle.Flat
        effect_btn.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        effect_btn.ForeColor = Color.Transparent
        effect_btn.Location = New Point(1300, 125)
        effect_btn.Name = "effect_btn"
        effect_btn.Size = New Size(112, 44)
        effect_btn.TabIndex = 5
        effect_btn.Text = "Effect"
        effect_btn.UseVisualStyleBackColor = False
        ' 
        ' amplifier_btn
        ' 
        amplifier_btn.BackColor = Color.Transparent
        amplifier_btn.Cursor = Cursors.Hand
        amplifier_btn.FlatAppearance.BorderSize = 0
        amplifier_btn.FlatStyle = FlatStyle.Flat
        amplifier_btn.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        amplifier_btn.ForeColor = Color.Transparent
        amplifier_btn.Location = New Point(1147, 125)
        amplifier_btn.Name = "amplifier_btn"
        amplifier_btn.Size = New Size(152, 44)
        amplifier_btn.TabIndex = 4
        amplifier_btn.Text = "Amplifier"
        amplifier_btn.UseVisualStyleBackColor = False
        ' 
        ' holobody_btn
        ' 
        holobody_btn.BackColor = Color.Transparent
        holobody_btn.Cursor = Cursors.Hand
        holobody_btn.FlatAppearance.BorderSize = 0
        holobody_btn.FlatStyle = FlatStyle.Flat
        holobody_btn.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        holobody_btn.ForeColor = Color.Transparent
        holobody_btn.Location = New Point(973, 125)
        holobody_btn.Name = "holobody_btn"
        holobody_btn.Size = New Size(172, 44)
        holobody_btn.TabIndex = 3
        holobody_btn.Text = "Holo Body"
        holobody_btn.UseVisualStyleBackColor = False
        ' 
        ' lespaul_btn
        ' 
        lespaul_btn.BackColor = Color.Transparent
        lespaul_btn.Cursor = Cursors.Hand
        lespaul_btn.FlatAppearance.BorderSize = 0
        lespaul_btn.FlatStyle = FlatStyle.Flat
        lespaul_btn.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lespaul_btn.ForeColor = Color.Transparent
        lespaul_btn.Location = New Point(731, 125)
        lespaul_btn.Name = "lespaul_btn"
        lespaul_btn.Size = New Size(130, 44)
        lespaul_btn.TabIndex = 1
        lespaul_btn.Text = "LesPaul"
        lespaul_btn.UseVisualStyleBackColor = False
        ' 
        ' sg_btn
        ' 
        sg_btn.BackColor = Color.Transparent
        sg_btn.Cursor = Cursors.Hand
        sg_btn.FlatAppearance.BorderSize = 0
        sg_btn.FlatStyle = FlatStyle.Flat
        sg_btn.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        sg_btn.ForeColor = Color.Transparent
        sg_btn.Location = New Point(856, 125)
        sg_btn.Name = "sg_btn"
        sg_btn.Size = New Size(112, 44)
        sg_btn.TabIndex = 2
        sg_btn.Text = "SG"
        sg_btn.UseVisualStyleBackColor = False
        ' 
        ' akustik_btn
        ' 
        akustik_btn.BackColor = Color.Transparent
        akustik_btn.Cursor = Cursors.Hand
        akustik_btn.FlatAppearance.BorderSize = 0
        akustik_btn.FlatStyle = FlatStyle.Flat
        akustik_btn.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        akustik_btn.ForeColor = Color.Transparent
        akustik_btn.Location = New Point(581, 125)
        akustik_btn.Name = "akustik_btn"
        akustik_btn.Size = New Size(135, 44)
        akustik_btn.TabIndex = 1
        akustik_btn.Text = "Akustik"
        akustik_btn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Matura MT Script Capitals", 28F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(22, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 75)
        Label1.TabIndex = 0
        Label1.Text = "Vys Guitar"
        ' 
        ' show_panel
        ' 
        show_panel.AutoScroll = True
        show_panel.BackColor = Color.White
        show_panel.Dock = DockStyle.Fill
        show_panel.Location = New Point(0, 168)
        show_panel.Name = "show_panel"
        show_panel.Size = New Size(1465, 656)
        show_panel.TabIndex = 1
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1465, 824)
        Controls.Add(show_panel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "HomeForm"
        Text = "HomeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lespaul_btn As Button
    Friend WithEvents sg_btn As Button
    Friend WithEvents akustik_btn As Button
    Friend WithEvents amplifier_btn As Button
    Friend WithEvents holobody_btn As Button
    Friend WithEvents effect_btn As Button
    Friend WithEvents btnclose1 As Button
    Friend WithEvents show_panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
