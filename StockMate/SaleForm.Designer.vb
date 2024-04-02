Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleForm))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        txtquantity = New TextBox()
        btnsubmit = New Button()
        btnbacksale = New Button()
        DateTimePicker1 = New DateTimePicker()
        cbproduct = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label1.Location = New Point(30, 82)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 0
        Label1.Text = "TYPE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label2.Location = New Point(30, 162)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 1
        Label2.Text = "QUANTITY:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label4.Location = New Point(30, 346)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 3
        Label4.Text = "DATE:"
        ' 
        ' txtquantity
        ' 
        txtquantity.Location = New Point(158, 154)
        txtquantity.Margin = New Padding(4)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(199, 31)
        txtquantity.TabIndex = 9
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = SystemColors.MenuBar
        btnsubmit.Location = New Point(739, 466)
        btnsubmit.Margin = New Padding(4)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(192, 59)
        btnsubmit.TabIndex = 10
        btnsubmit.Text = "SUBMIT"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' btnbacksale
        ' 
        btnbacksale.Location = New Point(32, 466)
        btnbacksale.Name = "btnbacksale"
        btnbacksale.Size = New Size(208, 59)
        btnbacksale.TabIndex = 11
        btnbacksale.Text = "Back to Dashboard"
        btnbacksale.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(112, 346)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 12
        ' 
        ' cbproduct
        ' 
        cbproduct.FormattingEnabled = True
        cbproduct.Location = New Point(158, 74)
        cbproduct.Name = "cbproduct"
        cbproduct.Size = New Size(182, 33)
        cbproduct.TabIndex = 14
        ' 
        ' SaleForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1000, 562)
        Controls.Add(cbproduct)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnbacksale)
        Controls.Add(btnsubmit)
        Controls.Add(txtquantity)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "SaleForm"
        Text = "SALES "
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private Sub sale_load() Handles Me.Load
        Dim connection As Connection = New Connection()
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader

        Dim query As String = " SELECT productName FROM inventory"
        connection.conn.Open()
        cmd = New MySqlCommand(query, connection.conn)

        reader = cmd.ExecuteReader()

        If reader.HasRows() Then
            While reader.Read
                cbproduct.Items.Add(reader("productName").ToString())
            End While
        End If

        connection.conn.Close()


    End Sub

    Private Sub submit_click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim connection As Connection = New Connection()
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim amount As Double
        Dim inventory_quantity
        Dim product_id

        Dim quantity As Integer = CInt(Int(txtquantity.Text.Trim))
        Dim product_name As String = cbproduct.SelectedItem.ToString().Trim
        Dim read_query As String = "SELECT unitprice, quantity, productID FROM inventory WHERE productName='" & product_name & "'"

        connection.conn.Open()
        cmd = New MySqlCommand(read_query, connection.conn)

        reader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim unit_price = reader("unitprice")
            inventory_quantity = reader("quantity")
            product_id = reader("productID")
            amount = quantity * unit_price
            inventory_quantity -= quantity
            reader.Close()

        End If

        Dim live_date = CStr(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

        Dim write_query = "INSERT INTO sales (productID, quantity, amount, saleDate) VALUES('" & product_id & "', '" & quantity.ToString() & "', '" & amount & "', '" & live_date & "')"
        Console.WriteLine(write_query)
        Dim update_query = "UPDATE inventory SET quantity= " & inventory_quantity & " WHERE productName= '" & product_name & "';"

        cmd = New MySqlCommand(write_query, connection.conn)
        reader = cmd.ExecuteReader()
        reader.Close()
        cmd = New MySqlCommand(update_query, connection.conn)
        reader = cmd.ExecuteReader()
        reader.Close()

        connection.conn.Close()





    End Sub

    Private Sub back(sender As Object, e As EventArgs) Handles btnbacksale.Click
        dashboardForm.Show()
        Me.Hide()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnbacksale As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbproduct As ComboBox
End Class
