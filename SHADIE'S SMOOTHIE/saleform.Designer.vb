<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saleform
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MakeSale = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtBoxS_Price = New System.Windows.Forms.TextBox()
        Me.TxtBoxQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBxPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtQtyRem = New System.Windows.Forms.TextBox()
        Me.TxtBox_name = New System.Windows.Forms.TextBox()
        Me.TxtBox_contacts = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'MakeSale
        '
        Me.MakeSale.Location = New System.Drawing.Point(229, 320)
        Me.MakeSale.Name = "MakeSale"
        Me.MakeSale.Size = New System.Drawing.Size(121, 23)
        Me.MakeSale.TabIndex = 2
        Me.MakeSale.Text = "sell"
        Me.MakeSale.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(439, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtBoxS_Price
        '
        Me.TxtBoxS_Price.Location = New System.Drawing.Point(263, 60)
        Me.TxtBoxS_Price.Name = "TxtBoxS_Price"
        Me.TxtBoxS_Price.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxS_Price.TabIndex = 4
        '
        'TxtBoxQty
        '
        Me.TxtBoxQty.Location = New System.Drawing.Point(479, 60)
        Me.TxtBoxQty.Name = "TxtBoxQty"
        Me.TxtBoxQty.Size = New System.Drawing.Size(116, 20)
        Me.TxtBoxQty.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "S_Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(476, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price"
        '
        'TxtBxPrice
        '
        Me.TxtBxPrice.Location = New System.Drawing.Point(12, 134)
        Me.TxtBxPrice.Name = "TxtBxPrice"
        Me.TxtBxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtBxPrice.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(666, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total"
        '
        'TxtBoxTotal
        '
        Me.TxtBoxTotal.Location = New System.Drawing.Point(669, 60)
        Me.TxtBoxTotal.Name = "TxtBoxTotal"
        Me.TxtBoxTotal.Size = New System.Drawing.Size(119, 20)
        Me.TxtBoxTotal.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "QtyRem"
        '
        'TxtQtyRem
        '
        Me.TxtQtyRem.Location = New System.Drawing.Point(131, 134)
        Me.TxtQtyRem.Name = "TxtQtyRem"
        Me.TxtQtyRem.Size = New System.Drawing.Size(100, 20)
        Me.TxtQtyRem.TabIndex = 13
        '
        'TxtBox_name
        '
        Me.TxtBox_name.Location = New System.Drawing.Point(59, 238)
        Me.TxtBox_name.Name = "TxtBox_name"
        Me.TxtBox_name.Size = New System.Drawing.Size(219, 20)
        Me.TxtBox_name.TabIndex = 15
        '
        'TxtBox_contacts
        '
        Me.TxtBox_contacts.Location = New System.Drawing.Point(475, 238)
        Me.TxtBox_contacts.Name = "TxtBox_contacts"
        Me.TxtBox_contacts.Size = New System.Drawing.Size(208, 20)
        Me.TxtBox_contacts.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Customer Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(564, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Contacts"
        '
        'saleform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SHADIE_S_SMOOTHIE.My.Resources.Resources.bkrndpic
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBox_contacts)
        Me.Controls.Add(Me.TxtBox_name)
        Me.Controls.Add(Me.TxtQtyRem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBoxTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBxPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxQty)
        Me.Controls.Add(Me.TxtBoxS_Price)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MakeSale)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "saleform"
        Me.Text = "saleform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MakeSale As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtBoxS_Price As TextBox
    Friend WithEvents TxtBoxQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBxPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtQtyRem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBox_name As TextBox
    Friend WithEvents TxtBox_address As TextBox
    Friend WithEvents TxtBox_contacts As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Btn_AddCustomer As Button
End Class
