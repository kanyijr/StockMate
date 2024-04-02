<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchase
    Inherits System.Windows.Forms.Form



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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchase))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtquantity = New TextBox()
        btnsave = New Button()
        btncancel = New Button()
        btnbackpurchase = New Button()
        cbprod = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 52)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 0
        Label1.Text = "Product ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 108)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 1
        Label2.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 160)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 2
        Label3.Text = "Quantity"
        ' 
        ' txtquantity
        ' 
        txtquantity.Location = New Point(140, 171)
        txtquantity.Margin = New Padding(4)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(155, 31)
        txtquantity.TabIndex = 5
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(28, 264)
        btnsave.Margin = New Padding(4)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(118, 36)
        btnsave.TabIndex = 6
        btnsave.Text = "save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' btncancel
        ' 
        btncancel.Location = New Point(179, 264)
        btncancel.Margin = New Padding(4)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(118, 36)
        btncancel.TabIndex = 7
        btncancel.Text = "cancel"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' btnbackpurchase
        ' 
        btnbackpurchase.Location = New Point(853, 23)
        btnbackpurchase.Name = "btnbackpurchase"
        btnbackpurchase.Size = New Size(124, 54)
        btnbackpurchase.TabIndex = 8
        btnbackpurchase.Text = "Dashboard"
        btnbackpurchase.UseVisualStyleBackColor = True
        ' 
        ' cbprod
        ' 
        cbprod.FormattingEnabled = True
        cbprod.Location = New Point(140, 44)
        cbprod.Name = "cbprod"
        cbprod.Size = New Size(182, 33)
        cbprod.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(140, 108)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 10
        ' 
        ' purchase
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(DateTimePicker1)
        Controls.Add(cbprod)
        Controls.Add(btnbackpurchase)
        Controls.Add(btncancel)
        Controls.Add(btnsave)
        Controls.Add(txtquantity)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "purchase"
        Text = "Purchase"
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Private Sub back_purchase(sender As Object, e As EventArgs) Handles btnbackpurchase.Click
        dashboardForm.Show()
        Me.Hide()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnbackpurchase As Button
    Friend WithEvents cbprod As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
