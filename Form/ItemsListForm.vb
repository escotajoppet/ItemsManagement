Public Class ItemsListForm
    Private rowIndex As Integer
    Private selectedId As String
    Private selectedName As String

    Private Sub ItemsListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateItemsDataGridView(itemsDGV, Item.all())

        rowIndex = -1
    End Sub

    Private Sub addItemBtn_Click(sender As Object, e As EventArgs) Handles addItemBtn.Click
        Me.Hide()
        AddEditItemForm.Show()
        AddEditItemForm.addEditItemGB.Text = "Add New Item"
        AddEditItemForm.addEditItemBtn.Text = "Add Item"
        AddEditItemForm.unitCB.SelectedItem = "Piece(s)"
    End Sub

    Private Sub editItemBtn_Click(sender As Object, e As EventArgs) Handles editItemBtn.Click
        If rowIndex > -1 Then
            Dim item As Item = New Item(selectedId)

            AddEditItemForm.selectedId = selectedId
            AddEditItemForm.nameTB.Text = item.name
            AddEditItemForm.priceTB.Text = item.price
            AddEditItemForm.quantityTB.Text = item.quantity
            AddEditItemForm.unitCB.SelectedItem = item.unitOfMeasurement

            Me.Hide()
            AddEditItemForm.Show()
            AddEditItemForm.addEditItemGB.Text = "Update Item: " & selectedName
            AddEditItemForm.addEditItemBtn.Text = "Update Item"
        Else
            MsgBox("Please select an Item to update", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub itemsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles itemsDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = itemsDGV.Item("itemIDCol", rowIndex).Value
            selectedName = itemsDGV.Item("itemNameCol", rowIndex).Value
        End If
    End Sub

    Private Sub deleteItemBtn_Click(sender As Object, e As EventArgs) Handles deleteItemBtn.Click
        If rowIndex > -1 Then
            AddEditItemForm.selectedId = selectedId
            Dim records As Item()

            Dim aytem As Item = New Item(selectedId)
            Dim message = aytem.deleteItem()

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                rowIndex = rIndex(itemsDGV, rowIndex)
                MsgBox(message, MsgBoxStyle.Information)

                Dim keyword As String = searchTB.Text

                If keyword <> "" Or keyword.Length <= 2 Then
                    records = Item.all()
                Else
                    records = Item.search("[item_name] LIKE '%" & keyword & "%'")
                End If

                populateItemsDataGridView(itemsDGV, records)
            End If
        Else
            MsgBox("Please select an Item to delete", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub searchTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchTB.KeyUp
        Dim keyword As String = searchTB.Text
        Dim condition As String

        If keyword.Length > 2 Then
            condition = "[item_name] LIKE '%" & keyword & "%'"
        Else
            condition = "1"
        End If

        populateItemsDataGridView(itemsDGV, Item.search(condition))
    End Sub
End Class