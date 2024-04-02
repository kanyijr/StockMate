Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
    Inherits System.Windows.Forms.Form
    Dim loginForm As LoginForm
    Dim dashboard As dashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signup))
        Me.lblsignusername = New System.Windows.Forms.Label()
        Me.txtsignusername = New System.Windows.Forms.TextBox()
        Me.lblsignemail = New System.Windows.Forms.Label()
        Me.txtsignemail = New System.Windows.Forms.TextBox()
        Me.lblsignpass = New System.Windows.Forms.Label()
        Me.txtsignpassword = New System.Windows.Forms.TextBox()
        Me.lblsignconfirmpass = New System.Windows.Forms.Label()
        Me.txtsignconfirmpass = New System.Windows.Forms.TextBox()
        Me.redirectsign = New System.Windows.Forms.LinkLabel()
        Me.btnsignsignup = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblsignusername
        '
        Me.lblsignusername.AutoSize = True
        Me.lblsignusername.BackColor = System.Drawing.Color.Transparent
        Me.lblsignusername.ForeColor = System.Drawing.Color.White
        Me.lblsignusername.Location = New System.Drawing.Point(124, 34)
        Me.lblsignusername.Name = "lblsignusername"
        Me.lblsignusername.Size = New System.Drawing.Size(80, 20)
        Me.lblsignusername.TabIndex = 0
        Me.lblsignusername.Text = "username"
        '
        'txtsignusername
        '
        Me.txtsignusername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtsignusername.Location = New System.Drawing.Point(238, 34)
        Me.txtsignusername.Name = "txtsignusername"
        Me.txtsignusername.Size = New System.Drawing.Size(165, 26)
        Me.txtsignusername.TabIndex = 1
        '
        'lblsignemail
        '
        Me.lblsignemail.AutoSize = True
        Me.lblsignemail.BackColor = System.Drawing.Color.Transparent
        Me.lblsignemail.ForeColor = System.Drawing.Color.Transparent
        Me.lblsignemail.Location = New System.Drawing.Point(128, 79)
        Me.lblsignemail.Name = "lblsignemail"
        Me.lblsignemail.Size = New System.Drawing.Size(46, 20)
        Me.lblsignemail.TabIndex = 2
        Me.lblsignemail.Text = "email"
        '
        'txtsignemail
        '
        Me.txtsignemail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtsignemail.Location = New System.Drawing.Point(238, 79)
        Me.txtsignemail.Name = "txtsignemail"
        Me.txtsignemail.Size = New System.Drawing.Size(165, 26)
        Me.txtsignemail.TabIndex = 3
        '
        'lblsignpass
        '
        Me.lblsignpass.AutoSize = True
        Me.lblsignpass.BackColor = System.Drawing.Color.Transparent
        Me.lblsignpass.ForeColor = System.Drawing.Color.Transparent
        Me.lblsignpass.Location = New System.Drawing.Point(132, 129)
        Me.lblsignpass.Name = "lblsignpass"
        Me.lblsignpass.Size = New System.Drawing.Size(77, 20)
        Me.lblsignpass.TabIndex = 4
        Me.lblsignpass.Text = "password"
        '
        'txtsignpassword
        '
        Me.txtsignpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtsignpassword.Location = New System.Drawing.Point(238, 129)
        Me.txtsignpassword.Name = "txtsignpassword"
        Me.txtsignpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsignpassword.Size = New System.Drawing.Size(165, 26)
        Me.txtsignpassword.TabIndex = 5
        '
        'lblsignconfirmpass
        '
        Me.lblsignconfirmpass.AutoSize = True
        Me.lblsignconfirmpass.BackColor = System.Drawing.Color.Transparent
        Me.lblsignconfirmpass.ForeColor = System.Drawing.Color.Transparent
        Me.lblsignconfirmpass.Location = New System.Drawing.Point(132, 184)
        Me.lblsignconfirmpass.Name = "lblsignconfirmpass"
        Me.lblsignconfirmpass.Size = New System.Drawing.Size(61, 20)
        Me.lblsignconfirmpass.TabIndex = 6
        Me.lblsignconfirmpass.Text = "confirm"
        '
        'txtsignconfirmpass
        '
        Me.txtsignconfirmpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtsignconfirmpass.Location = New System.Drawing.Point(238, 184)
        Me.txtsignconfirmpass.Name = "txtsignconfirmpass"
        Me.txtsignconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsignconfirmpass.Size = New System.Drawing.Size(165, 26)
        Me.txtsignconfirmpass.TabIndex = 7
        '
        'redirectsign
        '
        Me.redirectsign.ActiveLinkColor = System.Drawing.Color.Purple
        Me.redirectsign.AutoSize = True
        Me.redirectsign.BackColor = System.Drawing.Color.Transparent
        Me.redirectsign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.redirectsign.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.redirectsign.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.redirectsign.LinkColor = System.Drawing.Color.White
        Me.redirectsign.Location = New System.Drawing.Point(553, 23)
        Me.redirectsign.Name = "redirectsign"
        Me.redirectsign.Size = New System.Drawing.Size(235, 20)
        Me.redirectsign.TabIndex = 8
        Me.redirectsign.TabStop = True
        Me.redirectsign.Text = "Already have an account? Login"
        '
        'btnsignsignup
        '
        Me.btnsignsignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsignsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignsignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsignsignup.Location = New System.Drawing.Point(132, 253)
        Me.btnsignsignup.Name = "btnsignsignup"
        Me.btnsignsignup.Size = New System.Drawing.Size(275, 35)
        Me.btnsignsignup.TabIndex = 9
        Me.btnsignsignup.Text = "Signup"
        Me.btnsignsignup.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(136, 230)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 20)
        Me.lblError.TabIndex = 10
        Me.lblError.Visible = False
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnsignsignup)
        Me.Controls.Add(Me.redirectsign)
        Me.Controls.Add(Me.txtsignconfirmpass)
        Me.Controls.Add(Me.lblsignconfirmpass)
        Me.Controls.Add(Me.txtsignpassword)
        Me.Controls.Add(Me.lblsignpass)
        Me.Controls.Add(Me.txtsignemail)
        Me.Controls.Add(Me.lblsignemail)
        Me.Controls.Add(Me.txtsignusername)
        Me.Controls.Add(Me.lblsignusername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "signup"
        Me.Text = "signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub login(sender As Object, e As EventArgs) Handles redirectsign.Click


        loginForm = New LoginForm()
        loginForm.Show()
        Me.Visible = False
    End Sub


    Private Sub signup(sender As Object, e As EventArgs) Handles btnsignsignup.Click
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim username As String
        Dim email As String
        Dim password As String
        Dim query As String
        Dim found As Boolean
        Dim connString As String
        connString = "host=4.tcp.eu.ngrok.io;port=13058;user=root;password='';database=stocksasadb;"
        conn = New MySqlConnection(connString)
        conn.Open()
        found = False
        username = txtsignusername.Text.Trim.ToLower
        email = txtsignemail.Text.Trim.ToLower
        password = txtsignpassword.Text.Trim

        If password = txtsignconfirmpass.Text.Trim Then

            lblError.Text = ""
            lblError.Visible = False

        Else
            lblError.Text = "both passwords should match"
            lblError.Visible = True
            Return

        End If

        query = "INSERT INTO 
                registered_users(username, email, password) 
                VALUES ('" & username & "','" & email & "', '" & password & "')"


        cmd = New MySqlCommand(query, conn)
        found = True

        If found Then
            dashboardForm.Show()
            Me.Hide()
        Else
            MsgBox("feilya!")
        End If




        Me.Hide()





        conn.Close() '


    End Sub

    Friend WithEvents lblsignusername As Label
    Friend WithEvents txtsignusername As TextBox
    Friend WithEvents lblsignemail As Label
    Friend WithEvents txtsignemail As TextBox
    Friend WithEvents lblsignpass As Label
    Friend WithEvents txtsignpassword As TextBox
    Friend WithEvents lblsignconfirmpass As Label
    Friend WithEvents txtsignconfirmpass As TextBox
    Friend WithEvents redirectsign As LinkLabel
    Friend WithEvents btnsignsignup As Button
    Friend WithEvents lblError As Label
End Class
