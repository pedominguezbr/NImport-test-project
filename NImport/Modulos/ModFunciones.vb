Imports NImport.Dom.Ent
Imports NImport.Inf.Rep.Variables
Module ModFunciones
    Public Sub cargarGrillaDeListaTemporal(DtgDetalle As DataGridView)

        If Not IsNothing(detalleTemporal) Then
            Dim rowNuevo As DataGridViewRow
            For Each item As RESULTADEnt In detalleTemporal
                rowNuevo = New DataGridViewRow
                rowNuevo.CreateCells(DtgDetalle)
                rowNuevo.Cells(0).Value = item.ART_ID.PRODUCTO
                rowNuevo.Cells(1).Value = Val(item.CANTIDAD)
                rowNuevo.Cells(2).Value = CDbl(item.PRECIO)
                rowNuevo.Cells(3).Value = CDbl(item.Descuento)
                rowNuevo.Cells(4).Value = item.Predescto
                rowNuevo.Cells(5).Value = item.TEM_SUBT
                rowNuevo.Cells(6).Value = item.ART_ID.ART_ID.ToString
                DtgDetalle.Rows.Add(rowNuevo)
            Next
        End If

    End Sub
End Module
