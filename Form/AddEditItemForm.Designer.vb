<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditItemForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addEditItemGB = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addEditItemBtn = New System.Windows.Forms.Button()
        Me.unitCB = New System.Windows.Forms.ComboBox()
        Me.quantityTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.priceTB = New System.Windows.Forms.TextBox()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backToListBtn = New System.Windows.Forms.Button()
        Me.addEditItemGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BULAON Ship Supply and Marine Services"
        '
        'addEditItemGB
        '
        Me.addEditItemGB.Controls.Add(Me.Label5)
        Me.addEditItemGB.Controls.Add(Me.addEditItemBtn)
        Me.addEditItemGB.Controls.Add(Me.unitCB)
        Me.addEditItemGB.Controls.Add(Me.quantityTB)
        Me.addEditItemGB.Controls.Add(Me.Label4)
        Me.addEditItemGB.Controls.Add(Me.priceTB)
        Me.addEditItemGB.Controls.Add(Me.nameTB)
        Me.addEditItemGB.Controls.Add(Me.Label3)
        Me.addEditItemGB.Controls.Add(Me.Label2)
        Me.addEditItemGB.Location = New System.Drawing.Point(15, 59)
        Me.addEditItemGB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addEditItemGB.Name = "addEditItemGB"
        Me.addEditItemGB.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addEditItemGB.Size = New System.Drawing.Size(756, 489)
        Me.addEditItemGB.TabIndex = 2
        Me.addEditItemGB.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 40)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Unit of Measurement:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Default as Piece(s))"
        '
        'addEditItemBtn
        '
        Me.addEditItemBtn.Location = New System.Drawing.Point(618, 442)
        Me.addEditItemBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addEditItemBtn.Name = "addEditItemBtn"
        Me.addEditItemBtn.Size = New System.Drawing.Size(130, 35)
        Me.addEditItemBtn.TabIndex = 4
        Me.addEditItemBtn.UseVisualStyleBackColor = True
        '
        'unitCB
        '
        Me.unitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unitCB.FormattingEnabled = True
        Me.unitCB.Items.AddRange(New Object() {"Piece(s)", "Gram(s)", "Kilogram(s)", "Liter(s)", "Milliliter(s)", "Ounze(s)"})
        Me.unitCB.Location = New System.Drawing.Point(175, 336)
        Me.unitCB.Name = "unitCB"
        Me.unitCB.Size = New System.Drawing.Size(573, 28)
        Me.unitCB.TabIndex = 3
        '
        'quantityTB
        '
        Me.quantityTB.Location = New System.Drawing.Point(175, 232)
        Me.quantityTB.Name = "quantityTB"
        Me.quantityTB.Size = New System.Drawing.Size(574, 26)
        Me.quantityTB.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Item Quantity:"
        '
        'priceTB
        '
        Me.priceTB.Location = New System.Drawing.Point(175, 128)
        Me.priceTB.Name = "priceTB"
        Me.priceTB.Size = New System.Drawing.Size(574, 26)
        Me.priceTB.TabIndex = 1
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(175, 24)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(574, 26)
        Me.nameTB.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Item Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Item Name:"
        '
        'backToListBtn
        '
        Me.backToListBtn.Location = New System.Drawing.Point(641, 14)
        Me.backToListBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.backToListBtn.Name = "backToListBtn"
        Me.backToListBtn.Size = New System.Drawing.Size(130, 35)
        Me.backToListBtn.TabIndex = 5
        Me.backToListBtn.Text = "Back to List"
        Me.backToListBtn.UseVisualStyleBackColor = True
        '
        'AddEditItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.backToListBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addEditItemGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddEditItemForm"
        Me.addEditItemGB.ResumeLayout(False)
        Me.addEditItemGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addEditItemGB As System.Windows.Forms.GroupBox
    Friend WithEvents backToListBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameTB As System.Windows.Forms.TextBox
    Friend WithEvents quantityTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents priceTB As System.Windows.Forms.TextBox
    Friend WithEvents unitCB As System.Windows.Forms.ComboBox
    Friend WithEvents addEditItemBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
