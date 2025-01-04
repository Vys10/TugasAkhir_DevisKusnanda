<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerform))
        Panel1 = New Panel()
        btnclose = New Button()
        Panel2 = New Panel()
        txtusername = New TextBox()
        Label6 = New Label()
        lbllogin = New Label()
        Label5 = New Label()
        txtpassword = New TextBox()
        Label1 = New Label()
        btnregister = New Button()
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
        Panel1.TabIndex = 1
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
        btnclose.Text = "w"
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txtusername)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(lbllogin)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtpassword)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btnregister)
        Panel2.Location = New Point(418, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(489, 568)
        Panel2.TabIndex = 0
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.LightGray
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.Font = New Font("TradeGothic LT Extended", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtusername.ForeColor = Color.DarkGray
        txtusername.Location = New Point(83, 120)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Enter Your Username"
        txtusername.Size = New Size(353, 43)
        txtusername.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("TradeGothic LT", 13.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(93, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 35)
        Label6.TabIndex = 14
        Label6.Text = "Username"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbllogin
        ' 
        lbllogin.AutoSize = True
        lbllogin.Cursor = Cursors.Hand
        lbllogin.Font = New Font("TradeGothic LT Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbllogin.ForeColor = SystemColors.Highlight
        lbllogin.Location = New Point(309, 447)
        lbllogin.Name = "lbllogin"
        lbllogin.Size = New Size(153, 30)
        lbllogin.TabIndex = 13
        lbllogin.Text = "Login here"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("TradeGothic LT Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(37, 447)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 30)
        Label5.TabIndex = 12
        Label5.Text = "All ready user?"
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.LightGray
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Font = New Font("TradeGothic LT Extended", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpassword.ForeColor = Color.DarkGray
        txtpassword.Location = New Point(83, 246)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.PlaceholderText = "Enter Your Password"
        txtpassword.Size = New Size(353, 43)
        txtpassword.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("TradeGothic LT", 13.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(93, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 35)
        Label1.TabIndex = 8
        Label1.Text = "Password"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnregister
        ' 
        btnregister.BackColor = Color.Black
        btnregister.Cursor = Cursors.Hand
        btnregister.FlatStyle = FlatStyle.Flat
        btnregister.Font = New Font("TradeGothic LT Extended", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnregister.ForeColor = Color.Transparent
        btnregister.Location = New Point(83, 331)
        btnregister.Name = "btnregister"
        btnregister.Size = New Size(308, 79)
        btnregister.TabIndex = 5
        btnregister.Text = "Register"
        btnregister.UseVisualStyleBackColor = False
        ' 
        ' registerform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1226, 554)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "registerform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registerform"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnregister As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbllogin As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label6 As Label
End Class
