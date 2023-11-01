<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Me.Cbo1 = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtDescriptionart = New System.Windows.Forms.TextBox()
        Me.dtgArticulos = New System.Windows.Forms.DataGridView()
        Me.GBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdscto = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.GBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdsal = New System.Windows.Forms.Button()
        Me.cmdcancela = New System.Windows.Forms.Button()
        Me.cmdProcesa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdver = New System.Windows.Forms.Button()
        Me.GrBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cpasa = New System.Windows.Forms.Button()
        Me.DtgDetalle = New System.Windows.Forms.DataGridView()
        Me.Labcont2 = New System.Windows.Forms.TextBox()
        Me.Yap = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.txtigv = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdModificarDet = New System.Windows.Forms.Button()
        Me.cmdEliminarDet = New System.Windows.Forms.Button()
        Me.txtDsctModif = New System.Windows.Forms.TextBox()
        Me.txtprecioModif = New System.Windows.Forms.TextBox()
        Me.txtcantModif = New System.Windows.Forms.TextBox()
        Me.Tien = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdmodif = New System.Windows.Forms.Button()
        Me.txtDsctoTodo = New System.Windows.Forms.TextBox()
        CType(Me.dtgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBox1.SuspendLayout()
        Me.GBox2.SuspendLayout()
        Me.GrBox3.SuspendLayout()
        CType(Me.DtgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cbo1
        '
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Location = New System.Drawing.Point(286, 29)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(131, 21)
        Me.Cbo1.TabIndex = 6
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(73, 31)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(207, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'txtDescriptionart
        '
        Me.txtDescriptionart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescriptionart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescriptionart.Location = New System.Drawing.Point(72, 57)
        Me.txtDescriptionart.Name = "txtDescriptionart"
        Me.txtDescriptionart.Size = New System.Drawing.Size(208, 20)
        Me.txtDescriptionart.TabIndex = 2
        '
        'dtgArticulos
        '
        Me.dtgArticulos.AllowUserToAddRows = False
        Me.dtgArticulos.AllowUserToDeleteRows = False
        Me.dtgArticulos.AllowUserToOrderColumns = True
        Me.dtgArticulos.AllowUserToResizeRows = False
        Me.dtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgArticulos.Location = New System.Drawing.Point(12, 83)
        Me.dtgArticulos.Name = "dtgArticulos"
        Me.dtgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgArticulos.Size = New System.Drawing.Size(661, 153)
        Me.dtgArticulos.TabIndex = 3
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBox1.Controls.Add(Me.Label3)
        Me.GBox1.Controls.Add(Me.Label2)
        Me.GBox1.Controls.Add(Me.Label1)
        Me.GBox1.Controls.Add(Me.txtdscto)
        Me.GBox1.Controls.Add(Me.txtprecio)
        Me.GBox1.Controls.Add(Me.Txtcantidad)
        Me.GBox1.Location = New System.Drawing.Point(12, 280)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(268, 65)
        Me.GBox1.TabIndex = 4
        Me.GBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dscto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad"
        '
        'txtdscto
        '
        Me.txtdscto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdscto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdscto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdscto.Location = New System.Drawing.Point(185, 29)
        Me.txtdscto.Name = "txtdscto"
        Me.txtdscto.Size = New System.Drawing.Size(47, 22)
        Me.txtdscto.TabIndex = 2
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprecio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprecio.Location = New System.Drawing.Point(94, 29)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(73, 22)
        Me.txtprecio.TabIndex = 1
        '
        'Txtcantidad
        '
        Me.Txtcantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtcantidad.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtcantidad.Location = New System.Drawing.Point(22, 29)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(57, 22)
        Me.Txtcantidad.TabIndex = 0
        '
        'GBox2
        '
        Me.GBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBox2.Controls.Add(Me.cmdsal)
        Me.GBox2.Controls.Add(Me.cmdcancela)
        Me.GBox2.Controls.Add(Me.cmdProcesa)
        Me.GBox2.Location = New System.Drawing.Point(347, 280)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(215, 65)
        Me.GBox2.TabIndex = 5
        Me.GBox2.TabStop = False
        Me.GBox2.Text = "Controles"
        '
        'cmdsal
        '
        Me.cmdsal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdsal.Location = New System.Drawing.Point(153, 19)
        Me.cmdsal.Name = "cmdsal"
        Me.cmdsal.Size = New System.Drawing.Size(43, 38)
        Me.cmdsal.TabIndex = 2
        Me.cmdsal.Text = "Salir"
        Me.cmdsal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsal.UseVisualStyleBackColor = True
        '
        'cmdcancela
        '
        Me.cmdcancela.Location = New System.Drawing.Point(71, 22)
        Me.cmdcancela.Name = "cmdcancela"
        Me.cmdcancela.Size = New System.Drawing.Size(62, 26)
        Me.cmdcancela.TabIndex = 1
        Me.cmdcancela.Text = "Cancela"
        Me.cmdcancela.UseVisualStyleBackColor = True
        '
        'cmdProcesa
        '
        Me.cmdProcesa.Location = New System.Drawing.Point(6, 22)
        Me.cmdProcesa.Name = "cmdProcesa"
        Me.cmdProcesa.Size = New System.Drawing.Size(59, 27)
        Me.cmdProcesa.TabIndex = 0
        Me.cmdProcesa.Text = "Procesa"
        Me.cmdProcesa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Busca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Seleccione Categoría"
        '
        'cmdver
        '
        Me.cmdver.AutoEllipsis = True
        Me.cmdver.Location = New System.Drawing.Point(423, 25)
        Me.cmdver.Name = "cmdver"
        Me.cmdver.Size = New System.Drawing.Size(66, 25)
        Me.cmdver.TabIndex = 8
        Me.cmdver.Text = "Ver Todos"
        Me.cmdver.UseVisualStyleBackColor = True
        '
        'GrBox3
        '
        Me.GrBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrBox3.Controls.Add(Me.RadioButton2)
        Me.GrBox3.Controls.Add(Me.RadioButton1)
        Me.GrBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrBox3.Location = New System.Drawing.Point(641, 21)
        Me.GrBox3.Name = "GrBox3"
        Me.GrBox3.Size = New System.Drawing.Size(165, 56)
        Me.GrBox3.TabIndex = 9
        Me.GrBox3.TabStop = False
        Me.GrBox3.Text = "Buscar Por"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(84, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ubicación"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Codigo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cpasa
        '
        Me.cpasa.Location = New System.Drawing.Point(12, 242)
        Me.cpasa.Name = "cpasa"
        Me.cpasa.Size = New System.Drawing.Size(63, 26)
        Me.cpasa.TabIndex = 10
        Me.cpasa.Text = "Acepta"
        Me.cpasa.UseVisualStyleBackColor = True
        '
        'DtgDetalle
        '
        Me.DtgDetalle.AllowUserToAddRows = False
        Me.DtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgDetalle.Location = New System.Drawing.Point(12, 360)
        Me.DtgDetalle.Name = "DtgDetalle"
        Me.DtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgDetalle.Size = New System.Drawing.Size(656, 136)
        Me.DtgDetalle.TabIndex = 11
        '
        'Labcont2
        '
        Me.Labcont2.Location = New System.Drawing.Point(17, 508)
        Me.Labcont2.Name = "Labcont2"
        Me.Labcont2.Size = New System.Drawing.Size(190, 20)
        Me.Labcont2.TabIndex = 12
        '
        'Yap
        '
        Me.Yap.Location = New System.Drawing.Point(219, 506)
        Me.Yap.Name = "Yap"
        Me.Yap.Size = New System.Drawing.Size(70, 22)
        Me.Yap.TabIndex = 13
        Me.Yap.Text = "Acepta"
        Me.Yap.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtimporte)
        Me.GroupBox1.Controls.Add(Me.txtigv)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Location = New System.Drawing.Point(465, 502)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 120)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total       S/.   "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "IGV          S/."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Sub Total S/."
        '
        'txtimporte
        '
        Me.txtimporte.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.Color.Navy
        Me.txtimporte.Location = New System.Drawing.Point(86, 75)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(115, 22)
        Me.txtimporte.TabIndex = 23
        Me.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtigv
        '
        Me.txtigv.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv.ForeColor = System.Drawing.Color.Navy
        Me.txtigv.Location = New System.Drawing.Point(86, 44)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(116, 22)
        Me.txtigv.TabIndex = 22
        Me.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Navy
        Me.txttotal.Location = New System.Drawing.Point(83, 11)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(119, 22)
        Me.txttotal.TabIndex = 21
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdModificarDet)
        Me.GroupBox2.Controls.Add(Me.cmdEliminarDet)
        Me.GroupBox2.Controls.Add(Me.txtDsctModif)
        Me.GroupBox2.Controls.Add(Me.txtprecioModif)
        Me.GroupBox2.Controls.Add(Me.txtcantModif)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 546)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 77)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar Datos"
        '
        'cmdModificarDet
        '
        Me.cmdModificarDet.Location = New System.Drawing.Point(198, 47)
        Me.cmdModificarDet.Name = "cmdModificarDet"
        Me.cmdModificarDet.Size = New System.Drawing.Size(64, 21)
        Me.cmdModificarDet.TabIndex = 4
        Me.cmdModificarDet.Text = "Modifica"
        Me.cmdModificarDet.UseVisualStyleBackColor = True
        '
        'cmdEliminarDet
        '
        Me.cmdEliminarDet.Location = New System.Drawing.Point(198, 19)
        Me.cmdEliminarDet.Name = "cmdEliminarDet"
        Me.cmdEliminarDet.Size = New System.Drawing.Size(64, 19)
        Me.cmdEliminarDet.TabIndex = 3
        Me.cmdEliminarDet.Text = "Elimina"
        Me.cmdEliminarDet.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEliminarDet.UseVisualStyleBackColor = True
        '
        'txtDsctModif
        '
        Me.txtDsctModif.Location = New System.Drawing.Point(141, 33)
        Me.txtDsctModif.Name = "txtDsctModif"
        Me.txtDsctModif.Size = New System.Drawing.Size(42, 20)
        Me.txtDsctModif.TabIndex = 2
        Me.txtDsctModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprecioModif
        '
        Me.txtprecioModif.Location = New System.Drawing.Point(72, 33)
        Me.txtprecioModif.Name = "txtprecioModif"
        Me.txtprecioModif.Size = New System.Drawing.Size(63, 20)
        Me.txtprecioModif.TabIndex = 1
        Me.txtprecioModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcantModif
        '
        Me.txtcantModif.Location = New System.Drawing.Point(6, 32)
        Me.txtcantModif.Name = "txtcantModif"
        Me.txtcantModif.Size = New System.Drawing.Size(53, 20)
        Me.txtcantModif.TabIndex = 0
        Me.txtcantModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tien
        '
        Me.Tien.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tien.ForeColor = System.Drawing.Color.Navy
        Me.Tien.Location = New System.Drawing.Point(718, 229)
        Me.Tien.Name = "Tien"
        Me.Tien.Size = New System.Drawing.Size(74, 24)
        Me.Tien.TabIndex = 19
        Me.Tien.Text = "Tienda"
        Me.Tien.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Tien.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cmdmodif)
        Me.GroupBox3.Controls.Add(Me.txtDsctoTodo)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(705, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(101, 125)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cambia Todo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Dscto."
        '
        'cmdmodif
        '
        Me.cmdmodif.Location = New System.Drawing.Point(20, 87)
        Me.cmdmodif.Name = "cmdmodif"
        Me.cmdmodif.Size = New System.Drawing.Size(67, 32)
        Me.cmdmodif.TabIndex = 1
        Me.cmdmodif.Text = "Modifica"
        Me.cmdmodif.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdmodif.UseVisualStyleBackColor = True
        '
        'txtDsctoTodo
        '
        Me.txtDsctoTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDsctoTodo.ForeColor = System.Drawing.Color.Navy
        Me.txtDsctoTodo.Location = New System.Drawing.Point(30, 41)
        Me.txtDsctoTodo.Name = "txtDsctoTodo"
        Me.txtDsctoTodo.Size = New System.Drawing.Size(45, 24)
        Me.txtDsctoTodo.TabIndex = 0
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 658)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Tien)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Yap)
        Me.Controls.Add(Me.Labcont2)
        Me.Controls.Add(Me.DtgDetalle)
        Me.Controls.Add(Me.cpasa)
        Me.Controls.Add(Me.GrBox3)
        Me.Controls.Add(Me.cmdver)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.dtgArticulos)
        Me.Controls.Add(Me.txtDescriptionart)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Cbo1)
        Me.Name = "Categorias"
        Me.Text = "Categorias"
        CType(Me.dtgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBox1.ResumeLayout(False)
        Me.GBox1.PerformLayout()
        Me.GBox2.ResumeLayout(False)
        Me.GrBox3.ResumeLayout(False)
        Me.GrBox3.PerformLayout()
        CType(Me.DtgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbo1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtDescriptionart As System.Windows.Forms.TextBox
    Friend WithEvents dtgArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdscto As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdsal As System.Windows.Forms.Button
    Friend WithEvents cmdcancela As System.Windows.Forms.Button
    Friend WithEvents cmdProcesa As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdver As System.Windows.Forms.Button
    Friend WithEvents GrBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cpasa As System.Windows.Forms.Button
    Friend WithEvents DtgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Labcont2 As System.Windows.Forms.TextBox
    Friend WithEvents Yap As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDsctModif As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioModif As System.Windows.Forms.TextBox
    Friend WithEvents txtcantModif As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificarDet As System.Windows.Forms.Button
    Friend WithEvents cmdEliminarDet As System.Windows.Forms.Button
    Friend WithEvents Tien As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdmodif As System.Windows.Forms.Button
    Friend WithEvents txtDsctoTodo As System.Windows.Forms.TextBox
End Class
