Imports NImport.AppInterface
Imports NImport.App
Imports NImport.Dom.Ent

Public Class FrmVendedor


    Private Sub btnmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrar.Click
        Dim ObjVENDEDORApp As New VENDEDORApp
        'Dim LitaVendedor As List(Of VENDEDOREnt)
        'LitaVendedor = ObjVENDEDORApp.GetAllVENDEDOR("%", "")

        DGVVendedor.DataSource = ObjVENDEDORApp.GetAllVENDEDOR("%", "")

    End Sub


    Private Sub DGVVendedor_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVVendedor.SelectionChanged
        If Not DGVVendedor.CurrentRow Is Nothing Then
            txtcodigovendedor.Text = CStr(DGVVendedor.CurrentRow.Cells("Cod_ven").Value)
            txtvendedor.Text = CStr(DGVVendedor.CurrentRow.Cells("VENDEDOR").Value)
            txttelefono.Text = CStr(DGVVendedor.CurrentRow.Cells("TELEFONO").Value)
            txtdni.Text = CStr(DGVVendedor.CurrentRow.Cells("RUC").Value)
            txtdireccion.Text = CStr(DGVVendedor.CurrentRow.Cells("DIRECCION").Value)
            txtdistrito.Text = CStr(DGVVendedor.CurrentRow.Cells("DISTRITO").Value)
        End If

    End Sub

    Sub LimpiarCajasTexto()
        txtcodigovendedor.Text = ""
        txtvendedor.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        txtdireccion.Text = ""
        txtdistrito.Text = ""


        'Dim ctrl As Integer
        'Dim controlsel As Object
        'For ctrl = 0 To (frmx.Controls.Count - 1)
        '    controlsel = frmx.Controls(ctrl)
        '    If TypeOf controlsel Is TextBox Then
        '        controlsel.Text = ""
        '    End If
        '    If TypeOf controlsel Is ComboBox Then
        '        controlsel.Text = ""
        '    End If
        '    'If TypeOf controlsel Is MaskEdBox Then
        '    ' controlsel.Text = "___-____"
        '    'End If
        'Next ctrl
    End Sub


    Function Bloquear(ByVal Bloqueo As Boolean)
        txtcodigovendedor.Enabled = Bloqueo
        txtvendedor.Enabled = Bloqueo
        txttelefono.Enabled = Bloqueo
        txtdni.Enabled = Bloqueo
        txtdireccion.Enabled = Bloqueo
        txtdistrito.Enabled = Bloqueo
    End Function

    Private Sub FrmVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Bloquear(False)
    End Sub


    Private Sub txtdescrip_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescrip.TextChanged
        If rdbcodigo.Checked = True Then
            Dim ObjVENDEDORApp As New VENDEDORApp
            DGVVendedor.DataSource = ObjVENDEDORApp.GetAllVENDEDOR(txtdescrip.Text & "%", "")
        ElseIf rdbvendedor.Checked = True Then
            Dim ObjVENDEDORApp As New VENDEDORApp
            DGVVendedor.DataSource = ObjVENDEDORApp.GetAllVENDEDOR("", txtdescrip.Text & "%")
        Else
            MsgBox(" no selecciono ningun valor de busqueda")
        End If

        If DGVVendedor.RowCount = 0 Then
            LimpiarCajasTexto()
        End If
    End Sub


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        LimpiarCajasTexto()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim ObjVENDEDORApp As New VENDEDORApp
        Dim objVendedorEnt As VENDEDOREnt
        Dim IntResult As Integer
        'objVendedorEnt = New VENDEDOREnt(txtcodigovendedor.Text, txtvendedor.Text, txttelefono.Text, txtdni.Text, txtdireccion.Text, "", txtdistrito.Text, "", "")
        objVendedorEnt = New VENDEDOREnt()
        objVendedorEnt.VENDEDOR = txtvendedor.Text
        objVendedorEnt.TELEFONO = txttelefono.Text
        objVendedorEnt.RUC = txtdni.Text
        objVendedorEnt.DIRECCION = txtdireccion.Text
        objVendedorEnt.DISTRITO = txtdistrito.Text
        objVendedorEnt.Cod_Ven = txtcodigovendedor.Text

        IntResult = ObjVENDEDORApp.Add(objVendedorEnt, "")

        If IntResult > 0 Then
            MsgBox("Registro grabado")
            DGVVendedor.DataSource = ObjVENDEDORApp.GetAllVENDEDOR("%", "")
        End If
    End Sub

    Private Sub Btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim ObjVENDEDORApp As New VENDEDORApp
        Dim objVendedorEnt As New VENDEDOREnt
        Dim IntResult As Integer
        If MsgBox("Desea eliminar el registro actual", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Mensaje") = MsgBoxResult.Yes Then
            objVendedorEnt.Cod_Ven = txtcodigovendedor.Text
            IntResult = ObjVENDEDORApp.Delete(objVendedorEnt, "")
            MsgBox("registro eliminado")
            DGVVendedor.DataSource = ObjVENDEDORApp.GetAllVENDEDOR("%", "")

        End If

    End Sub


    Private Sub Btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmodificar.Click
        Dim ObjVENDEDORApp As New VENDEDORApp
        Dim objVendedorEnt As VENDEDOREnt
        Dim IntResult As Integer
        'objVendedorEnt = New VENDEDOREnt(txtcodigovendedor.Text, txtvendedor.Text, txttelefono.Text,"", txtdni.Text txtdireccion.Text, "", txtdistrito.Text, "", "")

        objVendedorEnt = New VENDEDOREnt()
        objVendedorEnt.VENDEDOR = txtvendedor.Text
        objVendedorEnt.TELEFONO = txttelefono.Text
        objVendedorEnt.RUC = txtdni.Text
        objVendedorEnt.DIRECCION = txtdireccion.Text
        objVendedorEnt.DISTRITO = txtdistrito.Text
        objVendedorEnt.Cod_Ven = txtcodigovendedor.Text

        IntResult = ObjVENDEDORApp.Save(objVendedorEnt, "")

        If IntResult > 0 Then
            MsgBox("Registro Actualizado")
            DGVVendedor.DataSource = ObjVENDEDORApp.GetAllVENDEDOR("%", "")
        End If
        ' Bloquear(False)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End

    End Sub
End Class