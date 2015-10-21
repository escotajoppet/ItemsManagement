Imports System.Security.Cryptography
Imports System.Text

Module Tools
    Public Function rIndex(ByVal _dgv As DataGridView, ByVal _i As Integer) As Integer
        If _dgv.Rows.Count > 1 Then
            If _i = 0 Then
                rIndex = 0
            Else
                rIndex -= 1
            End If
        Else
            rIndex = -1
        End If
    End Function

    Public Sub populateItemsDataGridView(ByVal _dgv As DataGridView, ByVal _records As Item())
        Dim columns As String() = {"itemIDCol", "itemNameCol", "itemPriceCol", "itemQuantityCol", "itemUnitCol"}
        Dim items As String() = {"id", "in", "ip", "iq", "iu"}
        Dim record As Hashtable
        Dim records As List(Of Hashtable) = New List(Of Hashtable)

        For Each rec In _records
            record = New Hashtable
            
            record.Add("id", rec.id)
            record.Add("in", rec.name)
            record.Add("ip", rec.price)
            record.Add("iq", rec.quantity)
            record.Add("iu", rec.unitOfMeasurement)

            records.Add(record)
        Next

        populateDGV(_dgv, columns, items, records.ToArray)
    End Sub

    Public Sub populateDGV(ByVal _dgv As DataGridView, ByVal _columns As String(), ByVal _items As String(), ByVal _records As Hashtable())
        Dim index As Integer = 0

        _dgv.Rows.Clear()
        _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each record In _records
            index = _dgv.Rows.Add

            For i As Integer = 0 To _columns.Length - 1
                _dgv.Item(_columns(i), index).Value = record.Item(_items(i))
            Next
        Next

        If _dgv.Rows.Count > 0 Then
            _dgv.CurrentCell.Selected = False
        End If
    End Sub
End Module
