Public Class AddEditItemForm
    Public Property selectedId As String

    Private Sub addEditItemBtn_Click(sender As Object, e As EventArgs) Handles addEditItemBtn.Click
        Dim validated As String = validateInputs()

        If validated = "passed" Then
            Dim action As String
            Dim message As String

            Dim iName As String = nameTB.Text

            Dim iPrice As Decimal

            If priceTB.Text = "" Then
                iPrice = 0
            Else
                iPrice = Decimal.Parse(priceTB.Text)
            End If

            Dim iQtt As Integer

            If quantityTB.Text = "" Then
                iQtt = 0
            Else
                iQtt = Integer.Parse(quantityTB.Text)
            End If

            Dim iUnit As String = unitCB.SelectedItem.ToString

            If addEditItemBtn.Text = "Add Item" Then
                action = "ADDED"
                message = Item.addItem(iName, iPrice, iQtt, iUnit)
            Else
                action = "UPDATED"

                Dim item As Item = New Item(selectedId)
                message = item.updateItem(iName, iPrice, iQtt, iUnit)
            End If

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                MsgBox(message, MsgBoxStyle.Information)

                populateItemsDataGridView(ItemsListForm.itemsDGV, Item.all())
                Me.Close()
            End If
        Else
            MsgBox(validated, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateInputs() As String
        Dim message As String = ""

        If nameTB.Text = "" Then
            message &= "Please provide a name for the item." & vbCrLf
        End If

        If priceTB.Text = "" Then
            message &= ""
        Else
            If Not IsNumeric(priceTB.Text) Then
                message &= "Invalid price format." & vbCrLf
            End If
        End If

        If quantityTB.Text = "" Then
            message &= ""
        Else
            If Not IsNumeric(quantityTB.Text) Then
                message &= "Invalid quantity format." & vbCrLf
            End If
        End If

        If message = "" Then
            message = "passed"
        End If

        validateInputs = message
    End Function

    Private Sub backToListBtn_Click(sender As Object, e As EventArgs) Handles backToListBtn.Click
        Me.Close()
    End Sub

    Private Sub AddEditItemForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        addEditItemBtn.Text = ""
        addEditItemGB.Text = ""

        ItemsListForm.Show()
    End Sub
End Class