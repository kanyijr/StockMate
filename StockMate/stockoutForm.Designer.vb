<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stockoutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockoutForm))
        Me.lblprodid = New Label()
        Me.lblquantity = New Label()
        Me.lbldateout = New Label()
        Me.txtquantity = New TextBox()
        Me.btnadd = New Button()
        Me.btnbackstockout = New Button()
        Me.DateTimePicker1 = New DateTimePicker()
        Me.cbprodid = New ComboBox()
        SuspendLayout()
        ' 
        ' lblprodid
        ' 
        Me.lblprodid.AutoSize = True
        Me.lblprodid.Location = New Point(28, 115)
        Me.lblprodid.Name = "lblprodid"
        Me.lblprodid.Size = New Size(101, 25)
        Me.lblprodid.TabIndex = 0
        Me.lblprodid.Text = "Product ID:"
        ' 
        ' lblquantity
        ' 
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Location = New Point(28, 220)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New Size(84, 25)
        Me.lblquantity.TabIndex = 1
        Me.lblquantity.Text = "Quantity:"
        ' 
        ' lbldateout
        ' 
        Me.lbldateout.AutoSize = True
        Me.lbldateout.Location = New Point(28, 345)
        Me.lbldateout.Name = "lbldateout"
        Me.lbldateout.Size = New Size(93, 25)
        Me.lbldateout.TabIndex = 2
        Me.lbldateout.Text = "Date OUT:"
        ' 
        ' txtquantity
        ' 
        Me.txtquantity.Location = New Point(127, 214)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New Size(163, 31)
        Me.txtquantity.TabIndex = 4
        ' 
        ' btnadd
        ' 
        Me.btnadd.Location = New Point(132, 470)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New Size(161, 52)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnbackstockout
        ' 
        Me.btnbackstockout.Location = New Point(660, 470)
        Me.btnbackstockout.Name = "btnbackstockout"
        Me.btnbackstockout.Size = New Size(161, 52)
        Me.btnbackstockout.TabIndex = 7
        Me.btnbackstockout.Text = "DASHBOARD"
        Me.btnbackstockout.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        Me.DateTimePicker1.Location = New Point(127, 345)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New Size(300, 31)
        Me.DateTimePicker1.TabIndex = 8
        ' 
        ' cbprodid
        ' 
        Me.cbprodid.FormattingEnabled = True
        Me.cbprodid.Location = New Point(127, 115)
        Me.cbprodid.Name = "cbprodid"
        Me.cbprodid.Size = New Size(182, 33)
        Me.cbprodid.TabIndex = 10
        ' 
        ' stockoutForm
        ' 
        Me.AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(1000, 562)
        Me.Controls.Add(cbprodid)
        Me.Controls.Add(DateTimePicker1)
        Me.Controls.Add(btnbackstockout)
        Me.Controls.Add(btnadd)
        Me.Controls.Add(txtquantity)
        Me.Controls.Add(lbldateout)
        Me.Controls.Add(lblquantity)
        Me.Controls.Add(lblprodid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Margin = New Padding(4)
        Me.Name = "stockoutForm"
        Me.Text = "Stock out"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles btnbackstockout.Click
        dashboardForm.Show()
        Me.Hide()


    End Sub

    Friend WithEvents lblprodid As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lbldateout As Label

    Friend WithEvents txtquantity As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnbackstockout As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker

    Friend WithEvents cbprodid As ComboBox
End Class
