<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrTienda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rdbvendedor = New System.Windows.Forms.RadioButton
        Me.btnmostrar = New System.Windows.Forms.Button
        Me.rdbcodigo = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Pri3 = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btnmodifica = New System.Windows.Forms.Button
        Me.btnelimina = New System.Windows.Forms.Button
        Me.txtdescrip = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.T5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.T4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.T3 = New System.Windows.Forms.TextBox
        Me.DGVVendedor = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.T2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.T1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbvendedor
        '
        Me.rdbvendedor.AutoSize = True
        Me.rdbvendedor.Location = New System.Drawing.Point(162, 25)
        Me.rdbvendedor.Name = "rdbvendedor"
        Me.rdbvendedor.Size = New System.Drawing.Size(81, 17)
        Me.rdbvendedor.TabIndex = 2
        Me.rdbvendedor.TabStop = True
        Me.rdbvendedor.Text = "Descripción"
        Me.rdbvendedor.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmostrar.Location = New System.Drawing.Point(15, 14)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(96, 27)
        Me.btnmostrar.TabIndex = 27
        Me.btnmostrar.Text = "Mostrar Todo"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'rdbcodigo
        '
        Me.rdbcodigo.AutoSize = True
        Me.rdbcodigo.Location = New System.Drawing.Point(50, 25)
        Me.rdbcodigo.Name = "rdbcodigo"
        Me.rdbcodigo.Size = New System.Drawing.Size(68, 17)
        Me.rdbcodigo.TabIndex = 1
        Me.rdbcodigo.TabStop = True
        Me.rdbcodigo.Text = "Producto"
        Me.rdbcodigo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Pri3)
        Me.GroupBox3.Controls.Add(Me.btngrabar)
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Controls.Add(Me.btnmodifica)
        Me.GroupBox3.Controls.Add(Me.btnmostrar)
        Me.GroupBox3.Controls.Add(Me.btnelimina)
        Me.GroupBox3.Location = New System.Drawing.Point(572, -9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 369)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Pri3
        '
        Me.Pri3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pri3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.Pri3.Image = Global.PrueFact.My.Resources.Resources.PRINT
        Me.Pri3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Pri3.Location = New System.Drawing.Point(48, 246)
        Me.Pri3.Name = "Pri3"
        Me.Pri3.Size = New System.Drawing.Size(45, 48)
        Me.Pri3.TabIndex = 30
        Me.Pri3.Text = "Print"
        Me.Pri3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Pri3.UseVisualStyleBackColor = True
        '
        'btngrabar
        '
        Me.btngrabar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngrabar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.btngrabar.Image = Global.PrueFact.My.Resources.Resources.SAVE
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(34, 108)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(59, 42)
        Me.btngrabar.TabIndex = 29
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        ' Me.btnnuevo.Image = Global.PrueFact.My.Resources.Resources._New
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(34, 47)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(63, 43)
        Me.btnnuevo.TabIndex = 25
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnmodifica
        '
        Me.btnmodifica.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodifica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmodifica.Location = New System.Drawing.Point(28, 163)
        Me.btnmodifica.Name = "btnmodifica"
        Me.btnmodifica.Size = New System.Drawing.Size(79, 27)
        Me.btnmodifica.TabIndex = 28
        Me.btnmodifica.Text = "Modificar"
        Me.btnmodifica.UseVisualStyleBackColor = True
        '
        'btnelimina
        '
        Me.btnelimina.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnelimina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.btnelimina.Image = Global.PrueFact.My.Resources.Resources.DELETE
        Me.btnelimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnelimina.Location = New System.Drawing.Point(34, 198)
        Me.btnelimina.Name = "btnelimina"
        Me.btnelimina.Size = New System.Drawing.Size(63, 42)
        Me.btnelimina.TabIndex = 26
        Me.btnelimina.Text = "Eliminar"
        Me.btnelimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnelimina.UseVisualStyleBackColor = True
        '
        'txtdescrip
        '
        Me.txtdescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdescrip.Location = New System.Drawing.Point(50, 52)
        Me.txtdescrip.Name = "txtdescrip"
        Me.txtdescrip.Size = New System.Drawing.Size(387, 20)
        Me.txtdescrip.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbvendedor)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.rdbcodigo)
        Me.GroupBox2.Controls.Add(Me.txtdescrip)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(59, -15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 500)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripción para Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.T5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.T4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.T3)
        Me.GroupBox1.Controls.Add(Me.DGVVendedor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.T2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcod)
        Me.GroupBox1.Controls.Add(Me.T1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 632)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'T5
        '
        Me.T5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T5.Location = New System.Drawing.Point(115, 149)
        Me.T5.Name = "T5"
        Me.T5.Size = New System.Drawing.Size(87, 20)
        Me.T5.TabIndex = 10
        Me.T5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio Compra"
        '
        'T4
        '
        Me.T4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T4.Location = New System.Drawing.Point(115, 123)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(87, 20)
        Me.T4.TabIndex = 8
        Me.T4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stock"
        '
        'T3
        '
        Me.T3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T3.Location = New System.Drawing.Point(115, 97)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(87, 20)
        Me.T3.TabIndex = 6
        Me.T3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DGVVendedor
        '
        Me.DGVVendedor.AllowUserToAddRows = False
        Me.DGVVendedor.AllowUserToDeleteRows = False
        Me.DGVVendedor.AllowUserToOrderColumns = True
        Me.DGVVendedor.AllowUserToResizeRows = False
        Me.DGVVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVendedor.Location = New System.Drawing.Point(7, 215)
        Me.DGVVendedor.Name = "DGVVendedor"
        Me.DGVVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVendedor.Size = New System.Drawing.Size(456, 201)
        Me.DGVVendedor.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio Venta"
        '
        'T2
        '
        Me.T2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T2.Location = New System.Drawing.Point(115, 68)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(310, 20)
        Me.T2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cod Producto"
        '
        'txtcod
        '
        Me.txtcod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcod.Location = New System.Drawing.Point(115, 16)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(129, 20)
        Me.txtcod.TabIndex = 0
        '
        'T1
        '
        Me.T1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T1.Location = New System.Drawing.Point(115, 42)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(310, 20)
        Me.T1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Producto"
        '
        'Button1
        '
        ' Me.Button1.Image = Global.PrueFact.My.Resources.Resources.salir_chico
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(47, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 52)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 526)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrTienda"
        Me.Text = "Tienda"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdbvendedor As System.Windows.Forms.RadioButton
    Friend WithEvents btnmostrar As System.Windows.Forms.Button
    Friend WithEvents rdbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Pri3 As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnmodifica As System.Windows.Forms.Button
    Friend WithEvents btnelimina As System.Windows.Forms.Button
    Friend WithEvents txtdescrip As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents DGVVendedor As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
