<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDOANTERIOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSUMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIFA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECARGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BCALCULAR = New System.Windows.Forms.Button()
        Me.BLIMPIAR = New System.Windows.Forms.Button()
        Me.BLIMPIARTODO = New System.Windows.Forms.Button()
        Me.BSALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(142, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CONSUMO (kW)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SALDO ANTERIOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(168, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(168, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(168, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(546, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONE:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"SOCIAL", "NO SOCIAL"})
        Me.ComboBox2.Location = New System.Drawing.Point(153, 74)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RESIDENCIAL", "INDUSTRIAL"})
        Me.ComboBox1.Location = New System.Drawing.Point(153, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "TIPO DE TARIFA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TIPO DE SERVICIOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.NIT, Me.SALDOANTERIOR, Me.CONSUMO, Me.SERVICIO, Me.TARIFA, Me.PARCIAL, Me.RECARGO, Me.DESCUENTO, Me.TOTAL})
        Me.DataGridView1.Location = New System.Drawing.Point(1, 216)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1040, 102)
        Me.DataGridView1.TabIndex = 2
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'NIT
        '
        Me.NIT.HeaderText = "NIT"
        Me.NIT.Name = "NIT"
        '
        'SALDOANTERIOR
        '
        Me.SALDOANTERIOR.HeaderText = "SALDO ANTERIOR"
        Me.SALDOANTERIOR.Name = "SALDOANTERIOR"
        '
        'CONSUMO
        '
        Me.CONSUMO.HeaderText = "CONSUMO (kW)"
        Me.CONSUMO.Name = "CONSUMO"
        '
        'SERVICIO
        '
        Me.SERVICIO.HeaderText = "TIPO DE SERVICIO"
        Me.SERVICIO.Name = "SERVICIO"
        '
        'TARIFA
        '
        Me.TARIFA.HeaderText = "TIPO DE TARIFA"
        Me.TARIFA.Name = "TARIFA"
        '
        'PARCIAL
        '
        Me.PARCIAL.HeaderText = "PAGO PARCIAL"
        Me.PARCIAL.Name = "PARCIAL"
        '
        'RECARGO
        '
        Me.RECARGO.HeaderText = "RECARGO"
        Me.RECARGO.Name = "RECARGO"
        '
        'DESCUENTO
        '
        Me.DESCUENTO.HeaderText = "DESCUENTO"
        Me.DESCUENTO.Name = "DESCUENTO"
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "PAGO TOTAL"
        Me.TOTAL.Name = "TOTAL"
        '
        'BCALCULAR
        '
        Me.BCALCULAR.Location = New System.Drawing.Point(319, 187)
        Me.BCALCULAR.Name = "BCALCULAR"
        Me.BCALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.BCALCULAR.TabIndex = 3
        Me.BCALCULAR.Text = "CALCULAR"
        Me.BCALCULAR.UseVisualStyleBackColor = True
        '
        'BLIMPIAR
        '
        Me.BLIMPIAR.Location = New System.Drawing.Point(419, 187)
        Me.BLIMPIAR.Name = "BLIMPIAR"
        Me.BLIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.BLIMPIAR.TabIndex = 4
        Me.BLIMPIAR.Text = "LIMPIAR"
        Me.BLIMPIAR.UseVisualStyleBackColor = True
        '
        'BLIMPIARTODO
        '
        Me.BLIMPIARTODO.Location = New System.Drawing.Point(520, 187)
        Me.BLIMPIARTODO.Name = "BLIMPIARTODO"
        Me.BLIMPIARTODO.Size = New System.Drawing.Size(98, 23)
        Me.BLIMPIARTODO.TabIndex = 5
        Me.BLIMPIARTODO.Text = "LIMPIAR DATOS"
        Me.BLIMPIARTODO.UseVisualStyleBackColor = True
        '
        'BSALIR
        '
        Me.BSALIR.Location = New System.Drawing.Point(634, 187)
        Me.BSALIR.Name = "BSALIR"
        Me.BSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BSALIR.TabIndex = 6
        Me.BSALIR.Text = "SALIR"
        Me.BSALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1042, 330)
        Me.Controls.Add(Me.BSALIR)
        Me.Controls.Add(Me.BLIMPIARTODO)
        Me.Controls.Add(Me.BLIMPIAR)
        Me.Controls.Add(Me.BCALCULAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDOANTERIOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSUMO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECARGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BCALCULAR As System.Windows.Forms.Button
    Friend WithEvents BLIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BLIMPIARTODO As System.Windows.Forms.Button
    Friend WithEvents BSALIR As System.Windows.Forms.Button

End Class
