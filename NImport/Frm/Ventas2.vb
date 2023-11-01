Imports NImport.AppInterface
Imports NImport.App
Imports NImport.Dom.Ent
Imports NImport.Inf.Rep.Variables
Public Class Ventas2

    Private Sub FrmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbotipodocumento.DisplayMember = "Text"
        cbotipodocumento.Items.Add(New With {.Text = "FACTURA", .Value = 1})
        cbotipodocumento.Items.Add(New With {.Text = "BOLETA", .Value = 2})
        cbotipodocumento.Items.Add(New With {.Text = "VLIBRE", .Value = 3})
        cbotipodocumento.Items.Add(New With {.Text = "PROFORMA", .Value = 4})

        REM fecha
        dtpfecha.Value = Now()

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

        dtgDetalleVenta.Columns.Add(colDetProd)
        dtgDetalleVenta.Columns.Add(colCantidad)
        dtgDetalleVenta.Columns.Add(colPrecio)
        dtgDetalleVenta.Columns.Add(colDetDescuento)
        dtgDetalleVenta.Columns.Add(colDetPreDescuento)
        dtgDetalleVenta.Columns.Add(colImporte)
        dtgDetalleVenta.Columns.Add(colDetArtId)


        dtgDetalleVenta.Update()

        detalleTemporal = New List(Of RESULTADEnt)
    End Sub

    Private Sub btnbuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarCliente.Click
        Dim FrmClibus As New FrmBuscarCliente
        FrmClibus.ShowDialog()
        txtcliente.Text = FrmClibus.clienteSelecccionado.CLIENTE
        txtidcliente.Text = FrmClibus.clienteSelecccionado.Cli_id
        txtruc.Text = FrmClibus.clienteSelecccionado.RUC
    End Sub

    Private Sub Sal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()

    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        Dim objFacturasEnt As New FacturasEnt

        Dim objVLibreEnt As New VLibreEnt
        Dim objDeVLibreEnt As DeVLibreEnt

        Dim objFacturasApp As New FacturasApp
        Dim objResultadApp As New RESULTADApp
        Dim objVLibreApp As New VLibreApp
        Dim objDeVLibreApp As New DeVLibreApp
        Dim IntResult As Integer

        If (ValidacionesGenerales()) Then


            Select Case cbotipodocumento.SelectedItem.Value
                Case 1 'FACTURA
                    objFacturasEnt = New FacturasEnt()
                    objFacturasEnt.Cli_id = New CLIENEnt With {.Cli_id = txtidcliente.Text}
                    objFacturasEnt.Enc_id = TipoDoc()
                    objFacturasEnt.Cod_ven = New VENDEDOREnt With {.Cod_Ven = txtcodVendedor.Text}
                    objFacturasEnt.Vendedor = txtVendedor.Text
                    objFacturasEnt.Fecha = dtpfecha.Value
                    objFacturasEnt.Importe = CDbl(TxtImporte.Text)
                    objFacturasEnt.Igv = CDbl(TxtIgv.Text)
                    objFacturasEnt.Total = CDbl(TxtTotal.Text)

                    IntResult = objFacturasApp.Add(objFacturasEnt, "")
                    For Each item As RESULTADEnt In detalleTemporal
                        item.ENC_ID = New FacturasEnt With {.Enc_id = objFacturasEnt.Enc_id}
                        IntResult = objResultadApp.Add(item, "")
                    Next
                    REM grabar movimiento
                    GrabarMovimiento()

                Case 2 'BOLETA
                    'Do something else
                Case 3 'VLIBRE
                    objVLibreEnt = New VLibreEnt()
                    objVLibreEnt.Cli_id = New CLIENEnt With {.Cli_id = txtidcliente.Text}
                    objVLibreEnt.Enc_id = TipoDoc()
                    objVLibreEnt.Cod_Ven = New VENDEDOREnt With {.Cod_Ven = txtcodVendedor.Text}
                    objVLibreEnt.Vendedor = txtVendedor.Text
                    objVLibreEnt.Fecha = dtpfecha.Value
                    objVLibreEnt.Total = CDbl(TxtTotal.Text)

                    IntResult = objVLibreApp.Add(objVLibreEnt, "")
                    For Each item As RESULTADEnt In detalleTemporal
                        objDeVLibreEnt = New DeVLibreEnt
                        objDeVLibreEnt.ENC_ID = New VLibreEnt With {.Enc_id = objVLibreEnt.Enc_id}
                        objDeVLibreEnt.ART_ID = New TIENDAEnt With {.ART_ID = item.ART_ID.ART_ID}
                        objDeVLibreEnt.CANTIDAD = Val(item.CANTIDAD)
                        objDeVLibreEnt.PRECIO = CDbl(item.PRECIO)
                        objDeVLibreEnt.Descuento = CDbl(item.Descuento)
                        objDeVLibreEnt.Predescto = item.Predescto
                        objDeVLibreEnt.TEM_SUBT = item.TEM_SUBT

                        IntResult = objDeVLibreApp.Add(objDeVLibreEnt, "")
                    Next
                    REM grabar movimiento
                    GrabarMovimiento()

                Case Else
                    'Do the default action
            End Select
            If IntResult > 0 Then
                MsgBox(String.Format("Registro grabado numero de documento {0}", TipoDoc()))
            End If
            bloqueoControles(False)
        End If
    End Sub

    Sub GrabarMovimiento()
        Dim objMovimientoEnt As MovimientoEnt
        Dim objMovimientoApp As New MovimientoApp
        Dim IntResult As Integer

        For Each item As RESULTADEnt In detalleTemporal
            objMovimientoEnt = New MovimientoEnt

            objMovimientoEnt.ART_ID = New TIENDAEnt With {.ART_ID = item.ART_ID.ART_ID}
            objMovimientoEnt.ENC_ID = TipoDoc()
            objMovimientoEnt.CANTIDAD = Val(item.CANTIDAD)
            objMovimientoEnt.FECHA = dtpfecha.Value
            objMovimientoEnt.Cli_Id = New CLIENEnt With {.Cli_id = txtidcliente.Text}
            objMovimientoEnt.Cod_ven = New VENDEDOREnt With {.Cod_Ven = txtcodVendedor.Text}

            IntResult = objMovimientoApp.Add(objMovimientoEnt, "")
        Next
    End Sub

    Sub bloqueoControles(bloqueo As Boolean)
        btnPrint.Enabled = Not bloqueo
        btngrabar.Enabled = bloqueo
        ' Frame2.Enabled = bloqueo
        cmdadiciona.Enabled = bloqueo
        btnelimina.Enabled = bloqueo
    End Sub

    Function ValidacionesGenerales() As Boolean
        Dim validarok As Boolean = False

        If IsNothing(cbotipodocumento.SelectedItem) Then
            MsgBox("Seleccione un tipo de documento")
            cbotipodocumento.Focus()
            Return False
        End If

        If IsNothing(detalleTemporal) Then
            MsgBox(String.Format("No existe detalle para el Documento {0}", TipoDoc()))
            Return False
        End If

        If (detalleTemporal.Count = 0) Then
            MsgBox(String.Format("No existe detalle para el Documento {0}", TipoDoc()))
            Return False
        End If
        Return True
    End Function

    Private Sub btnVendedor_Click(sender As Object, e As EventArgs) Handles btnVendedor.Click
        Dim FrmVendedorbus As New FrmBuscarVendedor
        FrmVendedorbus.ShowDialog()
        txtVendedor.Text = FrmVendedorbus.VendedorSelecccionado.VENDEDOR
        txtcodVendedor.Text = FrmVendedorbus.VendedorSelecccionado.Cod_Ven

    End Sub

    Private Sub cmdadiciona_Click(sender As Object, e As EventArgs) Handles cmdadiciona.Click
        Dim FrmCategoria As New Categorias

        FrmCategoria.ShowDialog()
        REM cargar los detalles a la pantalla principal
        dtgDetalleVenta.Rows.Clear()
        cargarGrillaDeListaTemporal(dtgDetalleVenta)
        calcularTotales()
        btngrabar.Enabled = True
        cmdadiciona.Focus()
    End Sub
    Sub calcularTotales()
        Dim ntotal As Double = 0
        For index As Integer = 0 To dtgDetalleVenta.RowCount - 1
            ntotal += Convert.ToDouble(dtgDetalleVenta.Rows(index).Cells("IMPORTE").Value)
        Next

        TxtTotal.Text = Format(ntotal, "###0.00")
        TxtIgv.Text = (Format(ntotal * 0.18, "###0.00"))
        TxtImporte.Text = (Format((CDbl(TxtTotal.Text) + CDbl(TxtIgv.Text)), "###0.00"))
    End Sub
    Function TipoDoc() As String   'Devuelve FA si es Factura de lo contrario BV datguia de venta
        'If cmbdocumento.ListIndex = 0 Then
        Dim TipoDocLabel As String = String.Empty
        Select Case cbotipodocumento.Text
            Case "FACTURA"
                TipoDocLabel = "F"

            Case "GUIA DE VENTA"
                TipoDocLabel = "G"

            Case "PROFORMA"
                TipoDocLabel = "P"

            Case "VLIBRE"
                TipoDocLabel = "V"

            Case "GUIA_R"
                TipoDocLabel = "R"
        End Select

        TipoDoc = TipoDocLabel + "/" + txtnumdocumento.Text
    End Function

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        LimpiarControles(Me)
        dtgDetalleVenta.Rows.Clear()
        detalleTemporal = New List(Of RESULTADEnt)
    End Sub

    Private Sub CmdLimpi_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LimpiarControles(ByVal frm As Form)
        For Each ctrl As Control In frm.Controls

            For Each ctrlsub As Control In ctrl.Controls

                Select Case ctrlsub.[GetType]().Name
                    Case "TextBox"
                        Dim txt = CType(ctrlsub, TextBox)
                        txt.Text = String.Empty
                        'Case "RadSpinEditor"
                        '    Dim txtspEditor = CType(ctrlsub, RadSpinEditor)
                        '    txtspEditor.Value = 0
                    Case "ComboBox"
                        Dim ddlCombo = CType(ctrlsub, ComboBox)

                        'If ddlCombo.Name.ToString().ToUpper() <> "DDLMINA" AndAlso ddlCombo.Name.ToString().ToUpper() <> "DDLDATUM" AndAlso ddlCombo.Name.ToString().ToUpper() <> "DDLPOSICIONDETALLE" AndAlso ddlCombo.Name.ToString().ToUpper() <> "DDLINSTRUMENTO" Then
                        ddlCombo.Text = String.Empty
                        ddlCombo.SelectedIndex = -1
                        ' End If

                        'Case "RadTextBoxControl"
                        '    Dim txtbox = CType(ctrlsub, RadTextBoxControl)
                        '    txtbox.Text = String.Empty
                        'Case "RadLabel"
                        '    Dim lbl = CType(ctrlsub, RadLabel)
                        '    lbl.Text = String.Empty
                End Select
            Next
        Next
    End Sub
End Class