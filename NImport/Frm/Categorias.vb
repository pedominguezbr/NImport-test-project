Imports NImport.AppInterface
Imports NImport.App
Imports NImport.Dom.Ent
Imports NImport.Inf.Rep.Variables
Public Class Categorias
    Private articuloSel As TIENDAEnt
   
    Private Sub cmdsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsal.Click
        Me.Close()

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim ObjArticulosApp As New TIENDAApp
        dtgArticulos.DataSource = ObjArticulosApp.GetAllTIENDA(0, txtBuscar.Text, "")

        If dtgArticulos.RowCount <= 0 Then
            articuloSel = New TIENDAEnt()
            txtDescriptionart.Text = String.Empty
            txtprecio.Text = String.Empty
        End If
    End Sub


    Private Sub dtgArticulos_SelectionChanged(sender As Object, e As EventArgs) Handles dtgArticulos.SelectionChanged
        seleccionarRegistro()
    End Sub
    Private Sub seleccionarRegistro()
        If Not dtgArticulos.CurrentRow Is Nothing Then
            articuloSel = New TIENDAEnt()
            articuloSel.ART_ID = CStr(dtgArticulos.CurrentRow.Cells("ART_ID").Value)
            articuloSel.PRODUCTO = CStr(dtgArticulos.CurrentRow.Cells("PRODUCTO").Value)
            articuloSel.PREVENT = CStr(dtgArticulos.CurrentRow.Cells("PREVENT").Value)

            txtDescriptionart.Text = articuloSel.PRODUCTO
            txtprecio.Text = articuloSel.PREVENT
        Else
            articuloSel = New TIENDAEnt()
            txtDescriptionart.Text = String.Empty
            txtprecio.Text = String.Empty
        End If
    End Sub
    Private Sub dtgArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgArticulos.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgArticulos_KeyUp(sender As Object, e As KeyEventArgs) Handles dtgArticulos.KeyUp
        If (e.KeyData = Keys.Enter) Then
            seleccionarRegistro()
            'Hide()
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            seleccionarRegistro()
            Txtcantidad.Focus()
        End If
    End Sub

    Private Sub cpasa_Click(sender As Object, e As EventArgs) Handles cpasa.Click
        seleccionarRegistro()
        Txtcantidad.Focus()
    End Sub



    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dtgArticulos.AutoGenerateColumns = False
        dtgArticulos.AllowUserToAddRows = True
        dtgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim colProd As DataGridViewColumn = New DataGridViewTextBoxColumn
        colProd.DataPropertyName = "PRODUCTO"
        colProd.ReadOnly = True
        colProd.Name = "PRODUCTO"
        colProd.MinimumWidth = 300

        Dim colPreVent As DataGridViewColumn = New DataGridViewTextBoxColumn
        colPreVent.DataPropertyName = "PREVENT"
        colPreVent.ReadOnly = True
        colPreVent.Name = "PREVENT"
        colPreVent.MinimumWidth = 80

        Dim colStock As DataGridViewColumn = New DataGridViewTextBoxColumn
        colStock.DataPropertyName = "STOCK"
        colStock.ReadOnly = True
        colStock.Name = "STOCK"
        colStock.MinimumWidth = 80

        Dim colPrecio2 As DataGridViewColumn = New DataGridViewTextBoxColumn
        colPrecio2.DataPropertyName = "PRECIO2"
        colPrecio2.ReadOnly = True
        colPrecio2.Name = "PRECIO2"
        colPrecio2.MinimumWidth = 80

        Dim colDescuento As DataGridViewColumn = New DataGridViewTextBoxColumn
        colDescuento.DataPropertyName = "DESCUENTO"
        colDescuento.ReadOnly = True
        colDescuento.Name = "DESCUENTO"
        colDescuento.MinimumWidth = 80

        Dim colLinea As DataGridViewColumn = New DataGridViewTextBoxColumn
        colLinea.DataPropertyName = "LINEA"
        colLinea.ReadOnly = True
        colLinea.Name = "LINEA"
        colLinea.MinimumWidth = 80

        Dim colArtId As DataGridViewColumn = New DataGridViewTextBoxColumn
        colArtId.DataPropertyName = "ART_ID"
        colArtId.ReadOnly = True
        colArtId.Name = "ART_ID"

        colArtId.Visible = False

        dtgArticulos.Columns.Add(colProd)
        dtgArticulos.Columns.Add(colPreVent)
        dtgArticulos.Columns.Add(colStock)
        dtgArticulos.Columns.Add(colPrecio2)
        dtgArticulos.Columns.Add(colDescuento)
        dtgArticulos.Columns.Add(colLinea)
        dtgArticulos.Columns.Add(colArtId)

        'dtgArticulos.Columns(4).DefaultCellStyle.Format = "###0.00"
        'dtgArticulos.Columns(4).Width = 80
        dtgArticulos.Update()

        dtgArticulos.AutoGenerateColumns = False
        dtgArticulos.AllowUserToAddRows = True
        dtgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim colDetProd As DataGridViewColumn = New DataGridViewTextBoxColumn
        colDetProd.DataPropertyName = "Codigo"
        colDetProd.ReadOnly = True
        colDetProd.Name = "PRODUCTO"
        colDetProd.MinimumWidth = 300

        Dim colCantidad As DataGridViewColumn = New DataGridViewTextBoxColumn
        colCantidad.DataPropertyName = "Cantidad"
        colCantidad.ReadOnly = True
        colCantidad.Name = "CANTIDAD"
        colCantidad.HeaderText = "CANTIDAD"
        colCantidad.MinimumWidth = 80

        Dim colPrecio As DataGridViewColumn = New DataGridViewTextBoxColumn
        colPrecio.DataPropertyName = "Precio"
        colPrecio.ReadOnly = True
        colPrecio.Name = "PRECIO"
        colPrecio.MinimumWidth = 80
        colPrecio.DefaultCellStyle.Format = "###0.00"

        Dim colDetDescuento As DataGridViewColumn = New DataGridViewTextBoxColumn
        colDetDescuento.DataPropertyName = "DESCTO"
        colDetDescuento.ReadOnly = True
        colDetDescuento.Name = "DESCTO"
        colDetDescuento.MinimumWidth = 80
        colDetDescuento.DefaultCellStyle.Format = "###0.00"

        Dim colDetPreDescuento As DataGridViewColumn = New DataGridViewTextBoxColumn
        colDetPreDescuento.DataPropertyName = "PreDescto"
        colDetPreDescuento.ReadOnly = True
        colDetPreDescuento.Name = "PREDESCTO"
        colDetPreDescuento.MinimumWidth = 80
        colDetPreDescuento.DefaultCellStyle.Format = "###0.00"

        Dim colImporte As DataGridViewColumn = New DataGridViewTextBoxColumn
        colImporte.DataPropertyName = "Importe"
        colImporte.ReadOnly = True
        colImporte.Name = "IMPORTE"
        colImporte.MinimumWidth = 80
        colImporte.DefaultCellStyle.Format = "###0.00"

        Dim colDetArtId As DataGridViewColumn = New DataGridViewTextBoxColumn
        colDetArtId.DataPropertyName = "ART_ID"
        colDetArtId.ReadOnly = True
        colDetArtId.Name = "ART_ID"

        colDetArtId.Visible = False

        DtgDetalle.Columns.Add(colDetProd)
        DtgDetalle.Columns.Add(colCantidad)
        DtgDetalle.Columns.Add(colPrecio)
        DtgDetalle.Columns.Add(colDetDescuento)
        DtgDetalle.Columns.Add(colDetPreDescuento)
        DtgDetalle.Columns.Add(colImporte)
        DtgDetalle.Columns.Add(colDetArtId)


        DtgDetalle.Update()

        cargarGrillaDeListaTemporal(DtgDetalle)
        calcularTotales()
    End Sub

    Private Sub Txtcantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtprecio.Focus()
        End If
    End Sub

    Private Sub txtprecio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdscto.Focus()
        End If
    End Sub

    Private Sub txtdscto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdscto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdProcesa.Focus()
        End If
    End Sub

    Private Sub cmdProcesa_Click(sender As Object, e As EventArgs) Handles cmdProcesa.Click
        AgregarDetalle()
    End Sub
    Private Sub AgregarDetalle()
        Dim rowNuevo As New DataGridViewRow
        Dim pdescuento As Double
        Dim total As Double
        'Dim rowNuevo As DataGridViewRow = DtgDetalle.Rows(DtgDetalle.NewRowIndex).Clone
        'Dim oNewRow As New DataGridViewRow

        rowNuevo.CreateCells(Me.DtgDetalle)

        If (txtdscto.Text.Trim() = String.Empty) Then
            txtdscto.Text = "0"
        End If
        ProcesarDscto(CDbl(txtprecio.Text), Val(Txtcantidad.Text), CDbl(txtdscto.Text), pdescuento, total)

        rowNuevo.Cells(0).Value = articuloSel.PRODUCTO.ToString
        rowNuevo.Cells(1).Value = Val(Txtcantidad.Text)
        rowNuevo.Cells(2).Value = CDbl(txtprecio.Text)
        rowNuevo.Cells(3).Value = CDbl(txtdscto.Text)
        rowNuevo.Cells(4).Value = pdescuento
        rowNuevo.Cells(5).Value = total
        rowNuevo.Cells(6).Value = articuloSel.ART_ID.ToString


        ' Dim row As String() = New String() {articuloSel.PRODUCTO.ToString, (Txtcantidad.Text), (txtprecio.Text), (txtdscto.Text), pdescuento, total, articuloSel.ART_ID.ToString}

        DtgDetalle.Rows.Add(rowNuevo)
        calcularTotales()

        limpiarDatos()
    End Sub
    Public Sub limpiarDatos()
        Txtcantidad.Text = String.Empty
        txtprecio.Text = String.Empty
        txtdscto.Text = String.Empty
        txtBuscar.Text = String.Empty
        txtBuscar.Focus()
    End Sub
    Private Sub ProcesarDscto(PArticulo As Double, cantidad As Integer, Valordescuento As Double, ByRef Pdescuento As Double, ByRef PTotal As Double)
        Dim descuento As Double

        descuento = Valordescuento / 100

        If descuento > 0.0# Then
            Pdescuento = PArticulo - (PArticulo * descuento)
            PTotal = Pdescuento * cantidad
        Else
            PTotal = PArticulo * cantidad
            Pdescuento = PArticulo

        End If
    End Sub

    Sub ProcesarDsctoAll()
        Dim pdescuento As Double
        Dim total As Double
        For Each row As DataGridViewRow In DtgDetalle.Rows
            pdescuento = 0
            total = 0
            ProcesarDscto(CDbl(row.Cells("PRECIO").Value), Val(row.Cells("CANTIDAD").Value), CDbl(txtDsctoTodo.Text), pdescuento, total)
            row.Cells("DESCTO").Value = CDbl(txtDsctoTodo.Text)
            row.Cells("PREDESCTO").Value = pdescuento
            row.Cells("IMPORTE").Value = total
            DtgDetalle.Update()
        Next
        calcularTotales()
    End Sub
    Sub seleccionarRegistroEditar()
        If Not DtgDetalle.CurrentRow Is Nothing Then
            txtcantModif.Text = CStr(DtgDetalle.CurrentRow.Cells("CANTIDAD").Value)
            txtprecioModif.Text = CStr(DtgDetalle.CurrentRow.Cells("PRECIO").Value)
            txtDsctModif.Text = CStr(DtgDetalle.CurrentRow.Cells("DESCTO").Value)
        Else
            txtcantModif.Text = String.Empty
            txtprecioModif.Text = String.Empty
            txtDsctModif.Text = String.Empty
        End If
    End Sub

    Sub calcularTotales()
        Dim ntotal As Double = 0
        For index As Integer = 0 To DtgDetalle.RowCount - 1
            ntotal += Convert.ToDouble(DtgDetalle.Rows(index).Cells("IMPORTE").Value)
        Next

        txttotal.Text = Format(ntotal, "###0.00")
        txtigv.Text = (Format(ntotal * 0.18, "###0.00"))
        txtimporte.Text = (Format((CDbl(txttotal.Text) + CDbl(txtigv.Text)), "###0.00"))
    End Sub
    'For Each row As DataGridViewRow In dgv.Rows
    '       If row.Cells("PAID").Value = 1 Then
    '             e.CellStyle.BackColor = Color.LightGreen
    '       End If
    '       Next

    Private Sub cmdmodif_Click(sender As Object, e As EventArgs) Handles cmdmodif.Click
        ProcesarDsctoAll()
    End Sub

    Private Sub DtgDetalle_SelectionChanged(sender As Object, e As EventArgs) Handles DtgDetalle.SelectionChanged
        seleccionarRegistroEditar()
    End Sub

    Private Sub DtgDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles DtgDetalle.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DtgDetalle_KeyUp(sender As Object, e As KeyEventArgs) Handles DtgDetalle.KeyUp
        If e.KeyCode = Keys.Enter Then
            seleccionarRegistroEditar()
            txtcantModif.Focus()
        End If
    End Sub

    Private Sub cmdModificarDet_Click(sender As Object, e As EventArgs) Handles cmdModificarDet.Click
        If Not DtgDetalle.CurrentRow Is Nothing Then
            Dim row As DataGridViewRow
            Dim pdescuento As Double
            Dim total As Double
            pdescuento = 0
            total = 0

            row = DtgDetalle.CurrentRow
            ProcesarDscto(CDbl(txtprecioModif.Text), Val(txtcantModif.Text), CDbl(txtDsctModif.Text), pdescuento, total)
            row.Cells("CANTIDAD").Value = Val(txtcantModif.Text)
            row.Cells("PRECIO").Value = CDbl(txtprecioModif.Text)
            row.Cells("DESCTO").Value = CDbl(txtDsctModif.Text)
            row.Cells("PREDESCTO").Value = pdescuento
            row.Cells("IMPORTE").Value = total
            DtgDetalle.Update()
        End If
        calcularTotales()
    End Sub

    Private Sub Categorias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'DtgDetalleVenta.Rows.Add(DtgDetalle.Rows)
        cargarListaTemporal()
    End Sub

    Sub cargarListaTemporal()
        detalleTemporal = New List(Of RESULTADEnt)
        Dim detalleDocumento As RESULTADEnt
        Dim tienda As TIENDAEnt
        For Each row As DataGridViewRow In DtgDetalle.Rows
            detalleDocumento = New RESULTADEnt
            tienda = New TIENDAEnt
            tienda.ART_ID = row.Cells("ART_ID").Value
            tienda.PRODUCTO = row.Cells("PRODUCTO").Value
            detalleDocumento.ART_ID = tienda
            detalleDocumento.CANTIDAD = row.Cells("CANTIDAD").Value
            detalleDocumento.PRECIO = row.Cells("PRECIO").Value
            detalleDocumento.Descuento = row.Cells("DESCTO").Value
            detalleDocumento.Predescto = row.Cells("PREDESCTO").Value
            detalleDocumento.TEM_SUBT = row.Cells("IMPORTE").Value
            detalleTemporal.Add(detalleDocumento)
        Next
    End Sub


End Class