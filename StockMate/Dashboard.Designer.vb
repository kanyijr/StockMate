Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboardForm
    Inherits System.Windows.Forms.Form
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Public username As String
    Public password As String
    Public query As String
    Public found As Boolean
    Public connString As String
    Public test1 As String

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboardForm))
        Panel1 = New Panel()
        Button1 = New Button()
        signOutBtn = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        settingsBtn = New Button()
        reportsComboBox = New ComboBox()
        formsComboBox = New ComboBox()
        Panel3 = New Panel()
        lblcurrentsale = New Label()
        lblsalelabel = New Label()
        conn = New MySqlConnection()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(signOutBtn)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 42)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(765, 4)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 34)
        Button1.TabIndex = 2
        Button1.Text = "Notifications"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' signOutBtn
        ' 
        signOutBtn.BackColor = SystemColors.AppWorkspace
        signOutBtn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signOutBtn.Location = New Point(904, 6)
        signOutBtn.Margin = New Padding(4)
        signOutBtn.Name = "signOutBtn"
        signOutBtn.Size = New Size(92, 32)
        signOutBtn.TabIndex = 1
        signOutBtn.Text = "Sign out"
        signOutBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 4)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 30)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(settingsBtn)
        Panel2.Controls.Add(reportsComboBox)
        Panel2.Controls.Add(formsComboBox)
        Panel2.Location = New Point(-1, 36)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(196, 559)
        Panel2.TabIndex = 1
        ' 
        ' settingsBtn
        ' 
        settingsBtn.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        settingsBtn.Location = New Point(44, 499)
        settingsBtn.Margin = New Padding(4)
        settingsBtn.Name = "settingsBtn"
        settingsBtn.Size = New Size(105, 42)
        settingsBtn.TabIndex = 2
        settingsBtn.Text = "Settings"
        settingsBtn.UseVisualStyleBackColor = True
        ' 
        ' reportsComboBox
        ' 
        reportsComboBox.BackColor = Color.Silver
        reportsComboBox.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        reportsComboBox.FormattingEnabled = True
        reportsComboBox.Items.AddRange(New Object() {"Financial Report"})
        reportsComboBox.Location = New Point(4, 56)
        reportsComboBox.Margin = New Padding(4)
        reportsComboBox.Name = "reportsComboBox"
        reportsComboBox.Size = New Size(188, 33)
        reportsComboBox.TabIndex = 1
        reportsComboBox.Text = "Reports"
        ' 
        ' formsComboBox
        ' 
        formsComboBox.BackColor = Color.Silver
        formsComboBox.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        formsComboBox.FormattingEnabled = True
        formsComboBox.Items.AddRange(New Object() {"INVENTORY", "SALES", "STOCK OUT", "PURCHASE"})
        formsComboBox.Location = New Point(4, 14)
        formsComboBox.Margin = New Padding(4)
        formsComboBox.Name = "formsComboBox"
        formsComboBox.Size = New Size(188, 33)
        formsComboBox.TabIndex = 0
        formsComboBox.Text = "Forms"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(lblcurrentsale)
        Panel3.Controls.Add(lblsalelabel)
        Panel3.Location = New Point(190, 40)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(809, 555)
        Panel3.TabIndex = 2
        ' 
        ' lblcurrentsale
        ' 
        lblcurrentsale.AutoSize = True
        lblcurrentsale.BackColor = Color.Transparent
        lblcurrentsale.Location = New Point(78, 501)
        lblcurrentsale.Margin = New Padding(4, 0, 4, 0)
        lblcurrentsale.Name = "lblcurrentsale"
        lblcurrentsale.Size = New Size(86, 25)
        lblcurrentsale.TabIndex = 1
        lblcurrentsale.Text = "KSH. O.O"
        ' 
        ' lblsalelabel
        ' 
        lblsalelabel.AutoSize = True
        lblsalelabel.BackColor = Color.MediumSeaGreen
        lblsalelabel.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsalelabel.Location = New Point(78, 474)
        lblsalelabel.Margin = New Padding(4, 0, 4, 0)
        lblsalelabel.Name = "lblsalelabel"
        lblsalelabel.Size = New Size(108, 22)
        lblsalelabel.TabIndex = 0
        lblsalelabel.Text = "LIVE SALE"
        ' 
        ' conn
        ' 
        conn.ConnectionString = "server=0.tcp.in.ngrok.io;port=19427;user id=root;database=stocksasadb"
        ' 
        ' dashboardForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 592)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(4)
        Name = "dashboardForm"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private Sub dashboard_load() Handles Me.Load
        lblcurrentsale.Text = "KSH. 4000"
    End Sub

    Private Sub form_change(sender As Object, e As EventArgs) Handles formsComboBox.SelectedIndexChanged
        Dim selected As String = formsComboBox.SelectedItem.ToString().ToLower()
        Select Case selected
            Case "inventory"
                Dim inventoryForm As InventoryForm = New InventoryForm()
                inventoryForm.Show()
                Me.Hide()

            Case "sales"
                Dim salesForm As SaleForm = New SaleForm()
                SaleForm.Show()
                Me.Hide()

            Case "stock out"
                stockoutForm.Show()
                Me.Hide()

            Case "purchase"
                purchase.Show()
                Me.Hide()


            Case Else

        End Select
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents signOutBtn As Button
    Friend WithEvents formsComboBox As ComboBox
    Friend WithEvents settingsBtn As Button
    Friend WithEvents reportsComboBox As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblcurrentsale As Label
    Friend WithEvents lblsalelabel As Label

End Class
