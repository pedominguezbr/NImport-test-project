﻿Public Class System2

    Private Sub System2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub NotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaToolStripMenuItem.Click
        Dim frmVenta As New Ventas2
        frmVenta.Show()
    End Sub
End Class