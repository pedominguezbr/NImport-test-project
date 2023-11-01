<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatComp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.TxtIgv = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.cmdeli = New System.Windows.Forms.Button
        Me.Yap = New System.Windows.Forms.Button
        Me.Labcont2 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.DtG3 = New System.Windows.Forms.DataGridView
        Me.cpasa = New System.Windows.Forms.Button
        Me.Txtdscto2 = New System.Windows.Forms.TextBox
        Me.Txtprecio2 = New System.Windows.Forms.TextBox
        Me.Txtcanti2 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdmodi = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GrBox3 = New System.Windows.Forms.GroupBox
        Me.Txtdscto = New System.Windows.Forms.TextBox
        Me.cmdver = New System.Windows.Forms.Button
        Me.Txtprecio = New System.Windows.Forms.TextBox
        Me.Txtcanti = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GBox2 = New System.Windows.Forms.GroupBox
        Me.cmdsal = New System.Windows.Forms.Button
        Me.cmdcancela = New System.Windows.Forms.Button
        Me.cmdacepta = New System.Windows.Forms.Button
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDescrip = New System.Windows.Forms.TextBox
        Me.Buca = New System.Windows.Forms.TextBox
        Me.DtG2 = New System.Windows.Forms.DataGridView
        Me.Cbo1 = New System.Windows.Forms.ComboBox
        Me.cmdtien = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtG3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GrBox3.SuspendLayout()
        Me.GBox2.SuspendLayout()
        Me.GBox1.SuspendLayout()
        CType(Me.DtG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtImporte)
        Me.GroupBox1.Controls.Add(Me.TxtIgv)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(353, 494)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 111)
        Me.GroupBox1.TabIndex = 33
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
        'TxtImporte
        '
        Me.TxtImporte.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImporte.ForeColor = System.Drawing.Color.Navy
        Me.TxtImporte.Location = New System.Drawing.Point(95, 74)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(115, 22)
        Me.TxtImporte.TabIndex = 23
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIgv
        '
        Me.TxtIgv.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIgv.ForeColor = System.Drawing.Color.Navy
        Me.TxtIgv.Location = New System.Drawing.Point(95, 43)
        Me.TxtIgv.Name = "TxtIgv"
        Me.TxtIgv.Size = New System.Drawing.Size(116, 22)
        Me.TxtIgv.TabIndex = 22
        Me.TxtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Navy
        Me.TxtTotal.Location = New System.Drawing.Point(95, 13)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(119, 22)
        Me.TxtTotal.TabIndex = 21
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdeli
        '
        Me.cmdeli.Location = New System.Drawing.Point(198, 19)
        Me.cmdeli.Name = "cmdeli"
        Me.cmdeli.Size = New System.Drawing.Size(64, 19)
        Me.cmdeli.TabIndex = 3
        Me.cmdeli.Text = "Elimina"
        Me.cmdeli.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdeli.UseVisualStyleBackColor = True
        '
        'Yap
        '
        Me.Yap.Location = New System.Drawing.Point(265, 503)
        Me.Yap.Name = "Yap"
        Me.Yap.Size = New System.Drawing.Size(70, 22)
        Me.Yap.TabIndex = 32
        Me.Yap.Text = "Acepta"
        Me.Yap.UseVisualStyleBackColor = True
        '
        'Labcont2
        '
        Me.Labcont2.Location = New System.Drawing.Point(37, 501)
        Me.Labcont2.Name = "Labcont2"
        Me.Labcont2.Size = New System.Drawing.Size(190, 20)
        Me.Labcont2.TabIndex = 31
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
        'DtG3
        '
        Me.DtG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtG3.Location = New System.Drawing.Point(17, 352)
        Me.DtG3.Name = "DtG3"
        Me.DtG3.Size = New System.Drawing.Size(556, 136)
        Me.DtG3.TabIndex = 30
        '
        'cpasa
        '
        Me.cpasa.Location = New System.Drawing.Point(36, 240)
        Me.cpasa.Name = "cpasa"
        Me.cpasa.Size = New System.Drawing.Size(63, 26)
        Me.cpasa.TabIndex = 29
        Me.cpasa.Text = "Acepta"
        Me.cpasa.UseVisualStyleBackColor = True
        '
        'Txtdscto2
        '
        Me.Txtdscto2.Location = New System.Drawing.Point(141, 33)
        Me.Txtdscto2.Name = "Txtdscto2"
        Me.Txtdscto2.Size = New System.Drawing.Size(42, 20)
        Me.Txtdscto2.TabIndex = 2
        Me.Txtdscto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtprecio2
        '
        Me.Txtprecio2.Location = New System.Drawing.Point(72, 33)
        Me.Txtprecio2.Name = "Txtprecio2"
        Me.Txtprecio2.Size = New System.Drawing.Size(63, 20)
        Me.Txtprecio2.TabIndex = 1
        Me.Txtprecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtcanti2
        '
        Me.Txtcanti2.Location = New System.Drawing.Point(6, 32)
        Me.Txtcanti2.Name = "Txtcanti2"
        Me.Txtcanti2.Size = New System.Drawing.Size(53, 20)
        Me.Txtcanti2.TabIndex = 0
        Me.Txtcanti2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdmodi)
        Me.GroupBox2.Controls.Add(Me.cmdeli)
        Me.GroupBox2.Controls.Add(Me.Txtdscto2)
        Me.GroupBox2.Controls.Add(Me.Txtprecio2)
        Me.GroupBox2.Controls.Add(Me.Txtcanti2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 537)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 77)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar Datos"
        '
        'cmdmodi
        '
        Me.cmdmodi.Location = New System.Drawing.Point(198, 47)
        Me.cmdmodi.Name = "cmdmodi"
        Me.cmdmodi.Size = New System.Drawing.Size(64, 21)
        Me.cmdmodi.TabIndex = 4
        Me.cmdmodi.Text = "Modifica"
        Me.cmdmodi.UseVisualStyleBackColor = True
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
        'GrBox3
        '
        Me.GrBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrBox3.Controls.Add(Me.RadioButton2)
        Me.GrBox3.Controls.Add(Me.RadioButton1)
        Me.GrBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrBox3.Location = New System.Drawing.Point(516, 12)
        Me.GrBox3.Name = "GrBox3"
        Me.GrBox3.Size = New System.Drawing.Size(165, 56)
        Me.GrBox3.TabIndex = 28
        Me.GrBox3.TabStop = False
        Me.GrBox3.Text = "Buscar Por"
        '
        'Txtdscto
        '
        Me.Txtdscto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtdscto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdscto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtdscto.Location = New System.Drawing.Point(185, 29)
        Me.Txtdscto.Name = "Txtdscto"
        Me.Txtdscto.Size = New System.Drawing.Size(47, 22)
        Me.Txtdscto.TabIndex = 2
        '
        'cmdver
        '
        Me.cmdver.AutoEllipsis = True
        Me.cmdver.Location = New System.Drawing.Point(423, 17)
        Me.cmdver.Name = "cmdver"
        Me.cmdver.Size = New System.Drawing.Size(66, 25)
        Me.cmdver.TabIndex = 27
        Me.cmdver.Text = "Ver Todos"
        Me.cmdver.UseVisualStyleBackColor = True
        '
        'Txtprecio
        '
        Me.Txtprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtprecio.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtprecio.Location = New System.Drawing.Point(94, 29)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(73, 22)
        Me.Txtprecio.TabIndex = 1
        '
        'Txtcanti
        '
        Me.Txtcanti.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtcanti.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcanti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtcanti.Location = New System.Drawing.Point(22, 29)
        Me.Txtcanti.Name = "Txtcanti"
        Me.Txtcanti.Size = New System.Drawing.Size(57, 22)
        Me.Txtcanti.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Busca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Seleccione Categoría"
        '
        'GBox2
        '
        Me.GBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBox2.Controls.Add(Me.cmdsal)
        Me.GBox2.Controls.Add(Me.cmdcancela)
        Me.GBox2.Controls.Add(Me.cmdacepta)
        Me.GBox2.Location = New System.Drawing.Point(347, 272)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(215, 74)
        Me.GBox2.TabIndex = 24
        Me.GBox2.TabStop = False
        Me.GBox2.Text = "Controles"
        '
        'cmdsal
        '
        ' Me.cmdsal.Image = Global.PrueFact.My.Resources.Resources.salir_chico
        Me.cmdsal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdsal.Location = New System.Drawing.Point(157, 10)
        Me.cmdsal.Name = "cmdsal"
        Me.cmdsal.Size = New System.Drawing.Size(43, 55)
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
        'cmdacepta
        '
        Me.cmdacepta.Location = New System.Drawing.Point(6, 22)
        Me.cmdacepta.Name = "cmdacepta"
        Me.cmdacepta.Size = New System.Drawing.Size(59, 27)
        Me.cmdacepta.TabIndex = 0
        Me.cmdacepta.Text = "Procesa"
        Me.cmdacepta.UseVisualStyleBackColor = True
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBox1.Controls.Add(Me.Label3)
        Me.GBox1.Controls.Add(Me.Label2)
        Me.GBox1.Controls.Add(Me.Label1)
        Me.GBox1.Controls.Add(Me.Txtdscto)
        Me.GBox1.Controls.Add(Me.Txtprecio)
        Me.GBox1.Controls.Add(Me.Txtcanti)
        Me.GBox1.Location = New System.Drawing.Point(21, 272)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(268, 65)
        Me.GBox1.TabIndex = 23
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
        'TxtDescrip
        '
        Me.TxtDescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDescrip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDescrip.Location = New System.Drawing.Point(72, 49)
        Me.TxtDescrip.Name = "TxtDescrip"
        Me.TxtDescrip.Size = New System.Drawing.Size(217, 20)
        Me.TxtDescrip.TabIndex = 21
        '
        'Buca
        '
        Me.Buca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Buca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Buca.Location = New System.Drawing.Point(73, 23)
        Me.Buca.Name = "Buca"
        Me.Buca.Size = New System.Drawing.Size(155, 20)
        Me.Buca.TabIndex = 20
        '
        'DtG2
        '
        Me.DtG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtG2.Location = New System.Drawing.Point(12, 85)
        Me.DtG2.Name = "DtG2"
        Me.DtG2.Size = New System.Drawing.Size(561, 143)
        Me.DtG2.TabIndex = 22
        '
        'Cbo1
        '
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Location = New System.Drawing.Point(266, 22)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(131, 21)
        Me.Cbo1.TabIndex = 19
        '
        'cmdtien
        '
        Me.cmdtien.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtien.ForeColor = System.Drawing.Color.Navy
        Me.cmdtien.Location = New System.Drawing.Point(600, 328)
        Me.cmdtien.Name = "cmdtien"
        Me.cmdtien.Size = New System.Drawing.Size(63, 24)
        Me.cmdtien.TabIndex = 35
        Me.cmdtien.Text = "Tienda"
        Me.cmdtien.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdtien.UseVisualStyleBackColor = True
        '
        'CatComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 628)
        Me.Controls.Add(Me.cmdtien)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Yap)
        Me.Controls.Add(Me.Labcont2)
        Me.Controls.Add(Me.DtG3)
        Me.Controls.Add(Me.cpasa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrBox3)
        Me.Controls.Add(Me.cmdver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.TxtDescrip)
        Me.Controls.Add(Me.Buca)
        Me.Controls.Add(Me.DtG2)
        Me.Controls.Add(Me.Cbo1)
        Me.Name = "CatComp"
        Me.Text = "CatCompras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DtG3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrBox3.ResumeLayout(False)
        Me.GrBox3.PerformLayout()
        Me.GBox2.ResumeLayout(False)
        Me.GBox1.ResumeLayout(False)
        Me.GBox1.PerformLayout()
        CType(Me.DtG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents TxtIgv As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdeli As System.Windows.Forms.Button
    Friend WithEvents Yap As System.Windows.Forms.Button
    Friend WithEvents Labcont2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DtG3 As System.Windows.Forms.DataGridView
    Friend WithEvents cpasa As System.Windows.Forms.Button
    Friend WithEvents Txtdscto2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtprecio2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtcanti2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdmodi As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GrBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtdscto As System.Windows.Forms.TextBox
    Friend WithEvents cmdver As System.Windows.Forms.Button
    Friend WithEvents Txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Txtcanti As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsal As System.Windows.Forms.Button
    Friend WithEvents cmdcancela As System.Windows.Forms.Button
    Friend WithEvents cmdacepta As System.Windows.Forms.Button
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Buca As System.Windows.Forms.TextBox
    Friend WithEvents DtG2 As System.Windows.Forms.DataGridView
    Friend WithEvents Cbo1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmdtien As System.Windows.Forms.Button
End Class
