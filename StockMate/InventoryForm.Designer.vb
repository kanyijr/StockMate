<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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

    Private Function GetAutoScaleMode() As AutoScaleMode
        Return AutoScaleMode
    End Function

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        btnUpdate = New Button()
        btnAdd = New Button()
        btnDelete = New Button()
        btnbackinventory = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 106)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 192)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 1
        Label2.Text = "QUANTITY:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 271)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 2
        Label3.Text = "PRICE:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 352)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 3
        Label4.Text = "DATE:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 101)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(275, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(146, 344)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(275, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 262)
        TextBox3.Margin = New Padding(4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(275, 31)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(146, 189)
        TextBox4.Margin = New Padding(4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(275, 31)
        TextBox4.TabIndex = 7
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(701, 459)
        btnUpdate.Margin = New Padding(4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(220, 76)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(15, 459)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(224, 76)
        btnAdd.TabIndex = 9
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(412, 461)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(182, 74)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnbackinventory
        ' 
        btnbackinventory.Location = New Point(819, 50)
        btnbackinventory.Name = "btnbackinventory"
        btnbackinventory.Size = New Size(137, 68)
        btnbackinventory.TabIndex = 11
        btnbackinventory.Text = "Dashboard"
        btnbackinventory.UseVisualStyleBackColor = True
        ' 
        ' InventoryForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1000, 562)
        Controls.Add(btnbackinventory)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(btnUpdate)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "InventoryForm"
        Text = "INVENTORY"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub back(sender As Object, e As EventArgs) Handles btnbackinventory.Click
        dashboardForm.Show()
        Me.Hide()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnbackinventory As Button
End Class
