<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrClien
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
        Me.txtdistrito = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DGVVendedor = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcodigovendedor = New System.Windows.Forms.TextBox
        Me.txtvendedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdbvendedor = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdescrip = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Pri3 = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btnmodifica = New System.Windows.Forms.Button
        Me.btnmostrar = New System.Windows.Forms.Button
        Me.btnelimina = New System.Windows.Forms.Button
        Me.sa2 = New System.Windows.Forms.Button
        CType(Me.DGVVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdistrito
        '
        Me.txtdistrito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdistrito.Location = New System.Drawing.Point(115, 185)
        Me.txtdistrito.Name = "txtdistrito"
        Me.txtdistrito.Size = New System.Drawing.Size(310, 21)
        Me.txtdistrito.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Distrito"
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdireccion.Location = New System.Drawing.Point(115, 155)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(310, 21)
        Me.txtdireccion.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dirección"
        '
        'txtdni
        '
        Me.txtdni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdni.Location = New System.Drawing.Point(115, 125)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(129, 21)
        Me.txtdni.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dni"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdistrito)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.DGVVendedor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigovendedor)
        Me.GroupBox1.Controls.Add(Me.txtvendedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 632)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttelefono.Location = New System.Drawing.Point(115, 95)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(310, 21)
        Me.txttelefono.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cod Cliente"
        '
        'txtcodigovendedor
        '
        Me.txtcodigovendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcodigovendedor.Location = New System.Drawing.Point(115, 30)
        Me.txtcodigovendedor.Name = "txtcodigovendedor"
        Me.txtcodigovendedor.Size = New System.Drawing.Size(129, 21)
        Me.txtcodigovendedor.TabIndex = 0
        '
        'txtvendedor
        '
        Me.txtvendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvendedor.Location = New System.Drawing.Point(115, 65)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(310, 21)
        Me.txtvendedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'rdbvendedor
        '
        Me.rdbvendedor.AutoSize = True
        Me.rdbvendedor.Location = New System.Drawing.Point(162, 25)
        Me.rdbvendedor.Name = "rdbvendedor"
        Me.rdbvendedor.Size = New System.Drawing.Size(63, 19)
        Me.rdbvendedor.TabIndex = 2
        Me.rdbvendedor.TabStop = True
        Me.rdbvendedor.Text = "Cliente"
        Me.rdbvendedor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbvendedor)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.rdbcodigo)
        Me.GroupBox2.Controls.Add(Me.txtdescrip)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 500)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripción para Buscar"
        '
        'rdbcodigo
        '
        Me.rdbcodigo.AutoSize = True
        Me.rdbcodigo.Location = New System.Drawing.Point(50, 25)
        Me.rdbcodigo.Name = "rdbcodigo"
        Me.rdbcodigo.Size = New System.Drawing.Size(64, 19)
        Me.rdbcodigo.TabIndex = 1
        Me.rdbcodigo.TabStop = True
        Me.rdbcodigo.Text = "Codigo"
        Me.rdbcodigo.UseVisualStyleBackColor = True
        '
        'txtdescrip
        '
        Me.txtdescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdescrip.Location = New System.Drawing.Point(50, 52)
        Me.txtdescrip.Name = "txtdescrip"
        Me.txtdescrip.Size = New System.Drawing.Size(387, 21)
        Me.txtdescrip.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.sa2)
        Me.GroupBox3.Controls.Add(Me.Pri3)
        Me.GroupBox3.Controls.Add(Me.btngrabar)
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Controls.Add(Me.btnmodifica)
        Me.GroupBox3.Controls.Add(Me.btnmostrar)
        Me.GroupBox3.Controls.Add(Me.btnelimina)
        Me.GroupBox3.Location = New System.Drawing.Point(527, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 376)
        Me.GroupBox3.TabIndex = 25
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
        'sa2
        '
        'Me.sa2.Image = Global.PrueFact.My.Resources.Resources.salir_chico
        Me.sa2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.sa2.Location = New System.Drawing.Point(44, 300)
        Me.sa2.Name = "sa2"
        Me.sa2.Size = New System.Drawing.Size(49, 51)
        Me.sa2.TabIndex = 31
        Me.sa2.Text = "Salir"
        Me.sa2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sa2.UseVisualStyleBackColor = True
        '
        'FrClien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 543)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrClien"
        Me.Text = "Clientes"
        CType(Me.DGVVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtdistrito As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGVVendedor As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigovendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtvendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbvendedor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdescrip As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Pri3 As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnmodifica As System.Windows.Forms.Button
    Friend WithEvents btnmostrar As System.Windows.Forms.Button
    Friend WithEvents btnelimina As System.Windows.Forms.Button
    Friend WithEvents sa2 As System.Windows.Forms.Button
End Class
