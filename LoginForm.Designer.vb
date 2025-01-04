<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Panel1 = New Panel()
        btnclose = New Button()
        Panel2 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        btnlogin = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(btnclose)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1226, 554)
        Panel1.TabIndex = 0
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnlogin)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(418, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(489, 568)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("TradeGothic LT Extended", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(288, 499)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 28)
        Label5.TabIndex = 8
        Label5.Text = "Register here"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("TradeGothic LT Extended", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(12, 499)
        Label4.Name = "Label4"
        Label4.Size = New Size(270, 25)
        Label4.TabIndex = 6
        Label4.Text = "Don't have an account?"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.Black
        btnlogin.Cursor = Cursors.Hand
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("TradeGothic LT Extended", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.Transparent
        btnlogin.Location = New Point(92, 395)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(308, 71)
        btnlogin.TabIndex = 5
        btnlogin.Text = "SIGN UP"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightGray
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("TradeGothic LT Extended", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.DarkGray
        TextBox2.Location = New Point(48, 319)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "Enter Your Password"
        TextBox2.Size = New Size(404, 43)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightGray
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("TradeGothic LT Extended", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.DarkGray
        TextBox1.Location = New Point(48, 186)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Your Username"
        TextBox1.Size = New Size(404, 43)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("TradeGothic LT", 13.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(48, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 35)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("TradeGothic LT", 13.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(48, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 35)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Matura MT Script Capitals", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(34, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 96)
        Label1.TabIndex = 0
        Label1.Text = "Vys Guitar"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1226, 554)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents Label5 As Label

End Class
