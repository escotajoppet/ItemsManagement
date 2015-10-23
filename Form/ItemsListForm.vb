Imports System.IO

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
        Dim selectedItems As DataGridViewSelectedRowCollection = itemsDGV.SelectedRows
        Dim message As String = ""
        Dim items As List(Of String) = New List(Of String)

        If selectedItems.Count > 0 Then
            For Each selectedItem As DataGridViewRow In selectedItems
                Dim id As String = itemsDGV.Item("itemIDCol", selectedItem.Index).Value()

                items.Add(itemsDGV.Item("itemNameCol", selectedItem.Index).Value())

                Dim aytem As Item = New Item(id)
                message = aytem.deleteItem()
            Next
        Else
            MsgBox("Please select an Item to delete", MsgBoxStyle.Critical)
        End If

        If Not message.ToLower.Contains("error") Then
            Dim keyword As String = searchTB.Text
            Dim records As Item()

            If keyword <> "" Or keyword.Length <= 2 Then
                records = Item.all()
            Else
                records = Item.search("[item_name] LIKE '%" & keyword & "%'")
            End If

            populateItemsDataGridView(itemsDGV, records)

            rowIndex = -1
            MsgBox("Items Deleted: " & Join(items.ToArray, ", "), MsgBoxStyle.Information)
        Else
            MsgBox(message, MsgBoxStyle.Critical)
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

    Private Sub saveListToFileBtn_Click(sender As Object, e As EventArgs) Handles saveListToFileBtn.Click
        Dim selectedItems As DataGridViewSelectedRowCollection = itemsDGV.SelectedRows

        If selectedItems.Count > 0 Then
            Dim dateNow As Date = Date.Now
            Dim saveFileDialog As New SaveFileDialog()

            Dim filters As String() = {
                "Text Documents (*.txt)|*.txt",
                "Portable Document Format (*.pdf)|*.pdf",
                "All files (*.*)|*.*"
            }

            saveFileDialog.Filter = Join(filters, "|")
            saveFileDialog.FilterIndex = 1
            saveFileDialog.RestoreDirectory = True
            saveFileDialog.Title = "Save Items List File As"

            Dim fileName As String = "ITEMS_"
            fileName &= dateNow.ToString("yyyymmdd") & "_"
            fileName &= dateNow.ToString("HHmmss") & "_"
            fileName &= "LIST.txt"

            saveFileDialog.FileName = fileName

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sw As StreamWriter = New StreamWriter(saveFileDialog.OpenFile())

                If (sw IsNot Nothing) Then
                    sw.WriteLine("{0, 5}", "ITEMS")
                    sw.WriteLine()

                    For Each selectedItem As DataGridViewRow In selectedItems
                        Dim id As String = itemsDGV.Item("itemIDCol", selectedItem.Index).Value()

                        Dim aytem As Item = New Item(id)

                        sw.WriteLine("{0, 5}", aytem.name)
                    Next

                    sw.Close()
                End If
            End If
        Else
            MsgBox("No selected Items", MsgBoxStyle.Critical)
        End If
    End Sub
End Class