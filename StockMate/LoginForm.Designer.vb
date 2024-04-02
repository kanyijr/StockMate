Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form
    Private signupForm As signup
    Private Dashboard As dashboardForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        txtUserName = New TextBox()
        txtPass = New TextBox()
        lnklbl = New LinkLabel()
        btnLogin = New Button()
        btnSignUp = New Button()
        grpUserName = New GroupBox()
        grpPass = New GroupBox()
        grpUserName.SuspendLayout()
        grpPass.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUserName
        ' 
        txtUserName.ForeColor = Color.Black
        txtUserName.Location = New Point(9, 32)
        txtUserName.Margin = New Padding(4, 4, 4, 4)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(354, 31)
        txtUserName.TabIndex = 0
        txtUserName.WordWrap = False
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(8, 36)
        txtPass.Margin = New Padding(4, 4, 4, 4)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(354, 31)
        txtPass.TabIndex = 1
        ' 
        ' lnklbl
        ' 
        lnklbl.AutoSize = True
        lnklbl.BackColor = Color.Transparent
        lnklbl.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnklbl.LinkColor = Color.White
        lnklbl.Location = New Point(426, 384)
        lnklbl.Margin = New Padding(4, 0, 4, 0)
        lnklbl.Name = "lnklbl"
        lnklbl.Size = New Size(150, 22)
        lnklbl.TabIndex = 2
        lnklbl.TabStop = True
        lnklbl.Text = "Forgot Password?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.ForestGreen
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderColor = Color.Lime
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(425, 301)
        btnLogin.Margin = New Padding(4, 4, 4, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(155, 55)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.Green
        btnSignUp.Cursor = Cursors.Hand
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(855, 31)
        btnSignUp.Margin = New Padding(4, 4, 4, 4)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(114, 48)
        btnSignUp.TabIndex = 4
        btnSignUp.Text = "SIGN UP"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' grpUserName
        ' 
        grpUserName.BackColor = Color.Transparent
        grpUserName.Controls.Add(txtUserName)
        grpUserName.ForeColor = SystemColors.Control
        grpUserName.Location = New Point(258, 124)
        grpUserName.Margin = New Padding(4, 4, 4, 4)
        grpUserName.Name = "grpUserName"
        grpUserName.Padding = New Padding(4, 4, 4, 4)
        grpUserName.Size = New Size(432, 82)
        grpUserName.TabIndex = 5
        grpUserName.TabStop = False
        grpUserName.Text = "Username"
        ' 
        ' grpPass
        ' 
        grpPass.BackColor = Color.Transparent
        grpPass.Controls.Add(txtPass)
        grpPass.ForeColor = SystemColors.Control
        grpPass.Location = New Point(259, 214)
        grpPass.Margin = New Padding(4, 4, 4, 4)
        grpPass.Name = "grpPass"
        grpPass.Padding = New Padding(4, 4, 4, 4)
        grpPass.Size = New Size(431, 80)
        grpPass.TabIndex = 1
        grpPass.TabStop = False
        grpPass.Text = "Password"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1000, 562)
        Controls.Add(grpPass)
        Controls.Add(grpUserName)
        Controls.Add(btnSignUp)
        Controls.Add(btnLogin)
        Controls.Add(lnklbl)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 4, 4, 4)
        Name = "LoginForm"
        Text = "LoginForm"
        grpUserName.ResumeLayout(False)
        grpUserName.PerformLayout()
        grpPass.ResumeLayout(False)
        grpPass.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub Form1_Load() Handles Me.Click
        ' Maximize the form
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub signup_click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        If signupForm Is Nothing Then

            signupForm = New signup()

        End If

        signupForm.Show()
        Me.Visible = False



    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim username As String
        Dim password As String
        Dim query As String
        Dim found As Boolean
        Dim connString As String
        connString = "server=4.tcp.eu.ngrok.io;port=13058;user=root;password='';database=stocksasadb;"
        conn = New MySqlConnection(connString)
        conn.Open()
        username = txtUserName.Text.Trim
        password = txtPass.Text.Trim
        query = "SELECT * FROM registered_users WHERE username = '" & username & "' AND password = '" & password & "'"
        cmd = New MySqlCommand(query, conn)
        reader = cmd.ExecuteReader
        found = False
        While reader.Read
            found = True
        End While
        If found = True Then
            Dashboard = New dashboardForm()

            Dashboard.Show()
            Me.Visible = False
        Else
            MsgBox("Login Failed")
        End If
        conn.Close() '


    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lnklbl As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents grpUserName As GroupBox
    Friend WithEvents grpPass As GroupBox

End Class
