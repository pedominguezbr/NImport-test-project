<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintFact
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
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.Pri2 = New System.Windows.Forms.Button
        Me.Sal = New System.Windows.Forms.Button
        Me.GB2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(30, 12)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(106, 20)
        Me.DTP1.TabIndex = 0
        '
        'DTP2
        '
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(185, 12)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(102, 20)
        Me.DTP2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(518, 146)
        Me.DataGridView1.TabIndex = 2
        '
        'GB1
        '
        Me.GB1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GB1.Controls.Add(Me.Pri2)
        Me.GB1.Controls.Add(Me.Sal)
        Me.GB1.Location = New System.Drawing.Point(262, 211)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(125, 79)
        Me.GB1.TabIndex = 9
        Me.GB1.TabStop = False
        '
        'Pri2
        '
        Me.Pri2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pri2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.Pri2.Image = Global.PrueFact.My.Resources.Resources.PRINT
        Me.Pri2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Pri2.Location = New System.Drawing.Point(6, 20)
        Me.Pri2.Name = "Pri2"
        Me.Pri2.Size = New System.Drawing.Size(45, 50)
        Me.Pri2.TabIndex = 10
        Me.Pri2.Text = "Print"
        Me.Pri2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Pri2.UseVisualStyleBackColor = True
        '
        'Sal
        '
        Me.Sal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.Sal.Image = Global.PrueFact.My.Resources.Resources.salir_chico
        Me.Sal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Sal.Location = New System.Drawing.Point(68, 19)
        Me.Sal.Name = "Sal"
        Me.Sal.Size = New System.Drawing.Size(47, 51)
        Me.Sal.TabIndex = 9
        Me.Sal.Text = "Salir"
        Me.Sal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Sal.UseVisualStyleBackColor = True
        '
        'GB2
        '
        Me.GB2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GB2.Controls.Add(Me.Label2)
        Me.GB2.Controls.Add(Me.Label1)
        Me.GB2.Controls.Add(Me.TextBox2)
        Me.GB2.Controls.Add(Me.TextBox1)
        Me.GB2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GB2.Location = New System.Drawing.Point(12, 200)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(221, 92)
        Me.GB2.TabIndex = 10
        Me.GB2.TabStop = False
        Me.GB2.Text = "Buscadores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "N. Doc."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cliente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(61, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 24)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 24)
        Me.TextBox1.TabIndex = 7
        '
        'PrintFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 303)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DTP2)
        Me.Controls.Add(Me.DTP1)
        Me.Name = "PrintFact"
        Me.Text = "Imprime Facturas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Pri2 As System.Windows.Forms.Button
    Friend WithEvents Sal As System.Windows.Forms.Button
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
