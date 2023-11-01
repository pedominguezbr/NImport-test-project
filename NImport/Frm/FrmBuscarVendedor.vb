Imports NImport.AppInterface
Imports NImport.App
Imports NImport.Dom.Ent

Public Class FrmBuscarVendedor
    Private _VENDEDOREnt As VENDEDOREnt

    Public Property VendedorSelecccionado() As VENDEDOREnt
        Get
            Return _VENDEDOREnt
        End Get
        Set(ByVal value As VENDEDOREnt)
            _VENDEDOREnt = value
        End Set
    End Property

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not dtgVendedor.CurrentRow Is Nothing Then
            Hide()
        Else
            MessageBox.Show("Seleccione un registro", "Busqueda de Vendedor")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        VendedorSelecccionado = New VENDEDOREnt()
        Hide()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim ObjVendedorApp As New VENDEDORApp
        dtgVendedor.DataSource = ObjVendedorApp.GetAllVENDEDOR(0, txtBuscar.Text)
    End Sub

    Private Sub FrmBuscarVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VendedorSelecccionado = New VENDEDOREnt()
    End Sub

    Private Sub dtgVendedor_SelectionChanged(sender As Object, e As EventArgs) Handles dtgVendedor.SelectionChanged
        seleccionarRegistro()
    End Sub

    Private Sub seleccionarRegistro()
        If Not dtgVendedor.CurrentRow Is Nothing Then
            VendedorSelecccionado = New VENDEDOREnt()
            VendedorSelecccionado.Cod_Ven = CStr(dtgVendedor.CurrentRow.Cells("Cod_Ven").Value)
            VendedorSelecccionado.VENDEDOR = CStr(dtgVendedor.CurrentRow.Cells("VENDEDOR").Value)
            VendedorSelecccionado.TELEFONO = CStr(dtgVendedor.CurrentRow.Cells("TELEFONO").Value)
            VendedorSelecccionado.RUC = CStr(dtgVendedor.CurrentRow.Cells("RUC").Value)
        End If
    End Sub


    Private Sub dtgVendedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVendedor.CellContentClick

    End Sub

    Private Sub dtgVendedor_KeyUp(sender As Object, e As KeyEventArgs) Handles dtgVendedor.KeyUp
        If (e.KeyData = Keys.Enter) Then
            seleccionarRegistro()
            Hide()
        End If
    End Sub

    Private Sub dtgVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgVendedor.KeyDown
        If (e.KeyData = Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            seleccionarRegistro()
            Hide()
        End If
    End Sub
End Class