<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsListForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.itemsDGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.addItemBtn = New System.Windows.Forms.Button()
        Me.deleteItemBtn = New System.Windows.Forms.Button()
        Me.editItemBtn = New System.Windows.Forms.Button()
        Me.itemIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemQuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemUnitCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.itemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BULAON Ship Supply and Marine Services"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.itemsDGV)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 94)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(753, 454)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items list"
        '
        'itemsDGV
        '
        Me.itemsDGV.AllowUserToAddRows = False
        Me.itemsDGV.AllowUserToDeleteRows = False
        Me.itemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemIDCol, Me.itemNameCol, Me.itemPriceCol, Me.itemQuantityCol, Me.itemUnitCol})
        Me.itemsDGV.Location = New System.Drawing.Point(9, 29)
        Me.itemsDGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.itemsDGV.Name = "itemsDGV"
        Me.itemsDGV.ReadOnly = True
        Me.itemsDGV.RowHeadersVisible = False
        Me.itemsDGV.Size = New System.Drawing.Size(736, 415)
        Me.itemsDGV.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search:"
        '
        'searchTB
        '
        Me.searchTB.Location = New System.Drawing.Point(86, 53)
        Me.searchTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchTB.Name = "searchTB"
        Me.searchTB.Size = New System.Drawing.Size(271, 26)
        Me.searchTB.TabIndex = 3
        '
        'addItemBtn
        '
        Me.addItemBtn.Location = New System.Drawing.Point(365, 49)
        Me.addItemBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addItemBtn.Name = "addItemBtn"
        Me.addItemBtn.Size = New System.Drawing.Size(130, 35)
        Me.addItemBtn.TabIndex = 4
        Me.addItemBtn.Text = "Add Item"
        Me.addItemBtn.UseVisualStyleBackColor = True
        '
        'deleteItemBtn
        '
        Me.deleteItemBtn.Location = New System.Drawing.Point(641, 49)
        Me.deleteItemBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteItemBtn.Name = "deleteItemBtn"
        Me.deleteItemBtn.Size = New System.Drawing.Size(130, 35)
        Me.deleteItemBtn.TabIndex = 5
        Me.deleteItemBtn.Text = "Delete Item"
        Me.deleteItemBtn.UseVisualStyleBackColor = True
        '
        'editItemBtn
        '
        Me.editItemBtn.Location = New System.Drawing.Point(503, 49)
        Me.editItemBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.editItemBtn.Name = "editItemBtn"
        Me.editItemBtn.Size = New System.Drawing.Size(130, 35)
        Me.editItemBtn.TabIndex = 6
        Me.editItemBtn.Text = "Edit Item"
        Me.editItemBtn.UseVisualStyleBackColor = True
        '
        'itemIDCol
        '
        Me.itemIDCol.HeaderText = "ID"
        Me.itemIDCol.Name = "itemIDCol"
        Me.itemIDCol.ReadOnly = True
        Me.itemIDCol.Visible = False
        '
        'itemNameCol
        '
        Me.itemNameCol.HeaderText = "Name"
        Me.itemNameCol.Name = "itemNameCol"
        Me.itemNameCol.ReadOnly = True
        Me.itemNameCol.Width = 184
        '
        'itemPriceCol
        '
        Me.itemPriceCol.HeaderText = "Price"
        Me.itemPriceCol.Name = "itemPriceCol"
        Me.itemPriceCol.ReadOnly = True
        Me.itemPriceCol.Width = 184
        '
        'itemQuantityCol
        '
        Me.itemQuantityCol.HeaderText = "Quantity"
        Me.itemQuantityCol.Name = "itemQuantityCol"
        Me.itemQuantityCol.ReadOnly = True
        Me.itemQuantityCol.Width = 182
        '
        'itemUnitCol
        '
        Me.itemUnitCol.HeaderText = "Unit of Measurement"
        Me.itemUnitCol.Name = "itemUnitCol"
        Me.itemUnitCol.ReadOnly = True
        Me.itemUnitCol.Width = 182
        '
        'ItemsListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.editItemBtn)
        Me.Controls.Add(Me.deleteItemBtn)
        Me.Controls.Add(Me.addItemBtn)
        Me.Controls.Add(Me.searchTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ItemsListForm"
        Me.Text = "Items List"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.itemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents searchTB As System.Windows.Forms.TextBox
    Friend WithEvents addItemBtn As System.Windows.Forms.Button
    Friend WithEvents deleteItemBtn As System.Windows.Forms.Button
    Friend WithEvents editItemBtn As System.Windows.Forms.Button
    Friend WithEvents itemsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents itemIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemPriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemQuantityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemUnitCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
