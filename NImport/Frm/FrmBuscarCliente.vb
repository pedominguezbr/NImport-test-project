Imports NImport.AppInterface
Imports NImport.App
Imports NImport.Dom.Ent

Public Class FrmBuscarCliente
    Private _CLIENEnt As CLIENEnt

    Public Property clienteSelecccionado() As CLIENEnt
        Get
            Return _CLIENEnt
        End Get
        Set(ByVal value As CLIENEnt)
            _CLIENEnt = value
        End Set
    End Property

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not dtgCliente.CurrentRow Is Nothing Then
            Hide()
        Else
            MessageBox.Show("Seleccione un registro", "Busqueda de cliente")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clienteSelecccionado = New CLIENEnt()
        Hide()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim ObjClienteApp As New CLIENApp
        dtgCliente.DataSource = ObjClienteApp.GetAllCLIEN(0, txtBuscar.Text)
    End Sub

    Private Sub FrmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clienteSelecccionado = New CLIENEnt()
    End Sub

    Private Sub dtgCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dtgCliente.SelectionChanged
        seleccionarRegistro()
    End Sub

    Private Sub seleccionarRegistro()
        If Not dtgCliente.CurrentRow Is Nothing Then
            clienteSelecccionado = New CLIENEnt()
            clienteSelecccionado.Cli_id = CStr(dtgCliente.CurrentRow.Cells("Cli_id").Value)
            clienteSelecccionado.CLIENTE = CStr(dtgCliente.CurrentRow.Cells("CLIENTE").Value)
            clienteSelecccionado.TELEFONO = CStr(dtgCliente.CurrentRow.Cells("TELEFONO").Value)
            clienteSelecccionado.RUC = CStr(dtgCliente.CurrentRow.Cells("RUC").Value)
        End If
    End Sub


    Private Sub dtgCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCliente.CellContentClick

    End Sub

    Private Sub dtgCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles dtgCliente.KeyUp
        If (e.KeyData = Keys.Enter) Then
            seleccionarRegistro()
            Hide()
        End If
    End Sub

    Private Sub dtgCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles dtgCliente.KeyDown
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