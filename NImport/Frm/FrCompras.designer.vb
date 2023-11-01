<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCompras
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
        Me.btnbuscarCliente = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtidcliente = New System.Windows.Forms.TextBox
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.txtcliente = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbocombo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbotipodocumento = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtddetalleVenta = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.TxtIgv = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmgui = New System.Windows.Forms.Button
        Me.Pri3 = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.CmdLimpi = New System.Windows.Forms.Button
        Me.btnelimina = New System.Windows.Forms.Button
        Me.cmdadiciona = New System.Windows.Forms.Button
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Labcont = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtddetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbuscarCliente
        '
        Me.btnbuscarCliente.Location = New System.Drawing.Point(505, 23)
        Me.btnbuscarCliente.Name = "btnbuscarCliente"
        Me.btnbuscarCliente.Size = New System.Drawing.Size(23, 23)
        Me.btnbuscarCliente.TabIndex = 13
        Me.btnbuscarCliente.Text = "..."
        Me.btnbuscarCliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbocombo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbotipodocumento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 138)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Importantes"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(427, 48)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(51, 20)
        Me.txtidcliente.TabIndex = 12
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(321, 48)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(100, 20)
        Me.txtruc.TabIndex = 11
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(321, 25)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(187, 20)
        Me.txtcliente.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "R.U.C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Proveedor"
        '
        'cbocombo
        '
        Me.cbocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocombo.FormattingEnabled = True
        Me.cbocombo.Location = New System.Drawing.Point(98, 106)
        Me.cbocombo.Name = "cbocombo"
        Me.cbocombo.Size = New System.Drawing.Size(160, 21)
        Me.cbocombo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vendedor"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(98, 80)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpfecha.TabIndex = 5
        Me.dtpfecha.Value = New Date(2010, 5, 22, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° Documento"
        '
        'cbotipodocumento
        '
        Me.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipodocumento.FormattingEnabled = True
        Me.cbotipodocumento.Location = New System.Drawing.Point(98, 25)
        Me.cbotipodocumento.Name = "cbotipodocumento"
        Me.cbotipodocumento.Size = New System.Drawing.Size(121, 21)
        Me.cbotipodocumento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento"
        '
        'dtddetalleVenta
        '
        Me.dtddetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtddetalleVenta.Location = New System.Drawing.Point(12, 172)
        Me.dtddetalleVenta.Name = "dtddetalleVenta"
        Me.dtddetalleVenta.Size = New System.Drawing.Size(621, 192)
        Me.dtddetalleVenta.TabIndex = 6
        '
        'PictureBox1
        '
        'Me.PictureBox1.Image = Global.PrueFact.My.Resources.Resources.COMPUMAN
        Me.PictureBox1.Location = New System.Drawing.Point(654, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 107)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtImporte)
        Me.GroupBox2.Controls.Add(Me.TxtIgv)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Location = New System.Drawing.Point(425, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 111)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
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
        Me.Label7.Location = New System.Drawing.Point(7, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "IGV          S/."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Sub Total S/."
        '
        'TxtImporte
        '
        Me.TxtImporte.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporte.ForeColor = System.Drawing.Color.Navy
        Me.TxtImporte.Location = New System.Drawing.Point(86, 75)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(115, 22)
        Me.TxtImporte.TabIndex = 23
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIgv
        '
        Me.TxtIgv.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIgv.ForeColor = System.Drawing.Color.Navy
        Me.TxtIgv.Location = New System.Drawing.Point(86, 44)
        Me.TxtIgv.Name = "TxtIgv"
        Me.TxtIgv.Size = New System.Drawing.Size(116, 22)
        Me.TxtIgv.TabIndex = 22
        Me.TxtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Navy
        Me.TxtTotal.Location = New System.Drawing.Point(83, 11)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(119, 22)
        Me.TxtTotal.TabIndex = 21
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmgui)
        Me.GroupBox3.Controls.Add(Me.Pri3)
        Me.GroupBox3.Controls.Add(Me.btngrabar)
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Controls.Add(Me.CmdLimpi)
        Me.GroupBox3.Controls.Add(Me.btnelimina)
        Me.GroupBox3.Location = New System.Drawing.Point(739, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(90, 406)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        ' Me.Button1.Image = Global.PrueFact.My.Resources.Resources.salir_chico
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(31, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 51)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmgui
        '
        Me.cmgui.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmgui.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        ' Me.cmgui.Image = Global.PrueFact.My.Resources.Resources.PRINT
        Me.cmgui.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmgui.Location = New System.Drawing.Point(29, 297)
        Me.cmgui.Name = "cmgui"
        Me.cmgui.Size = New System.Drawing.Size(48, 46)
        Me.cmgui.TabIndex = 31
        Me.cmgui.Text = "Guía"
        Me.cmgui.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmgui.UseVisualStyleBackColor = True
        '
        'Pri3
        '
        Me.Pri3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pri3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        ' Me.Pri3.Image = Global.PrueFact.My.Resources.Resources.PRINT
        Me.Pri3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Pri3.Location = New System.Drawing.Point(29, 234)
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
        ' Me.btngrabar.Image = Global.PrueFact.My.Resources.Resources.SAVE
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(19, 68)
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
        Me.btnnuevo.Location = New System.Drawing.Point(15, 19)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(63, 43)
        Me.btnnuevo.TabIndex = 25
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'CmdLimpi
        '
        Me.CmdLimpi.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLimpi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.CmdLimpi.Image = Global.PrueFact.My.Resources.Resources.Barrer
        Me.CmdLimpi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdLimpi.Location = New System.Drawing.Point(15, 172)
        Me.CmdLimpi.Name = "CmdLimpi"
        Me.CmdLimpi.Size = New System.Drawing.Size(59, 56)
        Me.CmdLimpi.TabIndex = 28
        Me.CmdLimpi.Text = "Limpiar"
        Me.CmdLimpi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdLimpi.UseVisualStyleBackColor = True
        '
        'btnelimina
        '
        Me.btnelimina.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnelimina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        ' Me.btnelimina.Image = Global.PrueFact.My.Resources.Resources.DELETE
        Me.btnelimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnelimina.Location = New System.Drawing.Point(15, 116)
        Me.btnelimina.Name = "btnelimina"
        Me.btnelimina.Size = New System.Drawing.Size(63, 42)
        Me.btnelimina.TabIndex = 26
        Me.btnelimina.Text = "Eliminar"
        Me.btnelimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnelimina.UseVisualStyleBackColor = True
        '
        'cmdadiciona
        '
        Me.cmdadiciona.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadiciona.ForeColor = System.Drawing.Color.Navy
        Me.cmdadiciona.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdadiciona.Location = New System.Drawing.Point(658, 172)
        Me.cmdadiciona.Name = "cmdadiciona"
        Me.cmdadiciona.Size = New System.Drawing.Size(75, 28)
        Me.cmdadiciona.TabIndex = 31
        Me.cmdadiciona.Text = "Adiciona"
        Me.cmdadiciona.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdadiciona.UseVisualStyleBackColor = True
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Text3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Text3.Location = New System.Drawing.Point(41, 421)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(349, 20)
        Me.Text3.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-2, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Son:"
        '
        'Labcont
        '
        Me.Labcont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Labcont.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labcont.ForeColor = System.Drawing.Color.Navy
        Me.Labcont.Location = New System.Drawing.Point(11, 379)
        Me.Labcont.Name = "Labcont"
        Me.Labcont.Size = New System.Drawing.Size(259, 22)
        Me.Labcont.TabIndex = 32
        '
        'FrCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 533)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Labcont)
        Me.Controls.Add(Me.cmdadiciona)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtddetalleVenta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrCompras"
        Me.Text = "Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtddetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbuscarCliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbocombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbotipodocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtddetalleVenta As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents TxtIgv As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmgui As System.Windows.Forms.Button
    Friend WithEvents Pri3 As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents CmdLimpi As System.Windows.Forms.Button
    Friend WithEvents btnelimina As System.Windows.Forms.Button
    Friend WithEvents cmdadiciona As System.Windows.Forms.Button
    Friend WithEvents Text3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Labcont As System.Windows.Forms.TextBox
End Class
