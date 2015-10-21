Imports System.Data.OleDb

Public Class Item
    Public Property id As Integer
    Public Property name As String
    Public Property price As Decimal
    Public Property quantity As Integer
    Public Property unitOfMeasurement As String

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "items"
        Dim fields As String = "[item_name], [price], [quantity], [unit_of_measurement]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.name = recordReader.Item("item_name")
            Me.price = Decimal.Parse(recordReader.Item("price"))
            Me.quantity = Integer.Parse(recordReader.Item("quantity"))
            Me.unitOfMeasurement = recordReader.Item("unit_of_measurement")
        End While

        recordReader.Close()
    End Sub

    ' self methods
    Public Shared Function all() As Item()
        all = getItems("1")
    End Function

    Public Shared Function search(ByVal _condition As String) As Item()
        search = getItems(_condition)
    End Function

    Public Shared Function addItem(ByVal _itemName As String, ByVal _itemPrice As Decimal, ByVal _itemQuantity As Integer, ByVal _itemUnit As String) As String
        Dim table As String = "items"
        Dim fields As String = "[item_name], [price], [quantity], [unit_of_measurement]"
        Dim values As String = "'" & _itemName & "', " & _itemPrice & ", " & _itemQuantity & ", '" & _itemUnit & "'"

        If addQuery(table, fields, values) Then
            addItem = "Item ADDED: " & _itemName
        Else
            addItem = "Error Adding Item"
        End If
    End Function

    ' private self methods
    Private Shared Function getItems(ByVal _condition As String) As Item()
        Dim table As String = "items"
        Dim fields As String = "[id]"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, _condition)

        Dim item As Item
        Dim items As List(Of Item) = New List(Of Item)

        While recordReader.Read() = True
            item = New Item(recordReader.Item("id"))
            items.Add(item)
        End While

        getItems = items.ToArray

        recordReader.Close()
    End Function

    ' instance methods
    Public Function updateItem(ByVal _itemName As String, ByVal _itemPrice As Decimal, ByVal _itemQuantity As Integer, ByVal _itemUnit As String) As String
        Dim table As String = "items"
        Dim fields As String() = {"item_name", "price", "quantity", "unit_of_measurement"}
        Dim values As String() = {"'" & _itemName & "'", _itemPrice.ToString, _itemQuantity.ToString, "'" & _itemUnit & "'"}
        Dim condition As String = "[id]=" & Me.id

        If updateQuery(table, fields, values, condition) Then
            updateItem = "Item UPDATED: " & Me.name
        Else
            updateItem = "Error Updating Item"
        End If
    End Function

    Public Function deleteItem() As String
        Dim table As String = "items"
        Dim condition As String = "[id]=" & Me.id

        If deleteQuery(table, condition) Then
            deleteItem = "Item DELETED: " & Me.name
        Else
            deleteItem = "Error Deleting Item"
        End If
    End Function
End Class
