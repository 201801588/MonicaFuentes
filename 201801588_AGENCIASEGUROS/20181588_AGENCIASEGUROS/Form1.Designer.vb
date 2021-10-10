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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBTALLER = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBMONTO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBCODIGO = New System.Windows.Forms.ComboBox()
        Me.CBGENERO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBEDAD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCALCULAR = New System.Windows.Forms.Button()
        Me.BMOSTRAR = New System.Windows.Forms.Button()
        Me.BLIMPIARV = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBDEDU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BDEDU = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BLIMPIARES = New System.Windows.Forms.Button()
        Me.BESTA = New System.Windows.Forms.Button()
        Me.TBDAÑOS = New System.Windows.Forms.TextBox()
        Me.TB1825 = New System.Windows.Forms.TextBox()
        Me.TBEXT = New System.Windows.Forms.TextBox()
        Me.TBCOND = New System.Windows.Forms.TextBox()
        Me.TBFEM = New System.Windows.Forms.TextBox()
        Me.TB25 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BSALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBTALLER)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBMONTO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBCODIGO)
        Me.GroupBox1.Controls.Add(Me.CBGENERO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBEDAD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos:"
        '
        'CBTALLER
        '
        Me.CBTALLER.FormattingEnabled = True
        Me.CBTALLER.Items.AddRange(New Object() {"TALLER DE CONFIANZA (EXTERNO)", "TALLER DE LA ASEGURADORA"})
        Me.CBTALLER.Location = New System.Drawing.Point(128, 112)
        Me.CBTALLER.Name = "CBTALLER"
        Me.CBTALLER.Size = New System.Drawing.Size(175, 21)
        Me.CBTALLER.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TIPO DE TALLER:"
        '
        'TBMONTO
        '
        Me.TBMONTO.Location = New System.Drawing.Point(193, 84)
        Me.TBMONTO.Name = "TBMONTO"
        Me.TBMONTO.Size = New System.Drawing.Size(110, 20)
        Me.TBMONTO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MONTO DE LOS DAÑOS:      Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CODIGO DE REGISTRO:"
        '
        'CBCODIGO
        '
        Me.CBCODIGO.FormattingEnabled = True
        Me.CBCODIGO.Items.AddRange(New Object() {"1 (GUATEMALTECO)", "0 (EXTRANJERO)"})
        Me.CBCODIGO.Location = New System.Drawing.Point(160, 57)
        Me.CBCODIGO.Name = "CBCODIGO"
        Me.CBCODIGO.Size = New System.Drawing.Size(143, 21)
        Me.CBCODIGO.TabIndex = 4
        '
        'CBGENERO
        '
        Me.CBGENERO.FormattingEnabled = True
        Me.CBGENERO.Items.AddRange(New Object() {"M", "F"})
        Me.CBGENERO.Location = New System.Drawing.Point(252, 31)
        Me.CBGENERO.Name = "CBGENERO"
        Me.CBGENERO.Size = New System.Drawing.Size(51, 21)
        Me.CBGENERO.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GENERO:"
        '
        'TBEDAD
        '
        Me.TBEDAD.Location = New System.Drawing.Point(71, 31)
        Me.TBEDAD.Name = "TBEDAD"
        Me.TBEDAD.Size = New System.Drawing.Size(100, 20)
        Me.TBEDAD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDAD:"
        '
        'BCALCULAR
        '
        Me.BCALCULAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BCALCULAR.Location = New System.Drawing.Point(460, 66)
        Me.BCALCULAR.Name = "BCALCULAR"
        Me.BCALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.BCALCULAR.TabIndex = 1
        Me.BCALCULAR.Text = "CALCULAR"
        Me.BCALCULAR.UseVisualStyleBackColor = False
        '
        'BMOSTRAR
        '
        Me.BMOSTRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BMOSTRAR.Location = New System.Drawing.Point(433, 97)
        Me.BMOSTRAR.Name = "BMOSTRAR"
        Me.BMOSTRAR.Size = New System.Drawing.Size(125, 23)
        Me.BMOSTRAR.TabIndex = 2
        Me.BMOSTRAR.Text = "MOSTRAR"
        Me.BMOSTRAR.UseVisualStyleBackColor = False
        '
        'BLIMPIARV
        '
        Me.BLIMPIARV.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLIMPIARV.Location = New System.Drawing.Point(433, 126)
        Me.BLIMPIARV.Name = "BLIMPIARV"
        Me.BLIMPIARV.Size = New System.Drawing.Size(125, 23)
        Me.BLIMPIARV.TabIndex = 3
        Me.BLIMPIARV.Text = "LIMPIAR VECTORES"
        Me.BLIMPIARV.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(15, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 119)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "EDAD"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "GENERO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODIGO DE REGISTRO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "MONTO DE DAÑOS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TIPO DE TALLER"
        Me.Column5.Name = "Column5"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBDEDU)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BDEDU)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 177)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Almacenados:"
        '
        'TBDEDU
        '
        Me.TBDEDU.Location = New System.Drawing.Point(415, 144)
        Me.TBDEDU.Name = "TBDEDU"
        Me.TBDEDU.Size = New System.Drawing.Size(100, 20)
        Me.TBDEDU.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "TOTAL DEL DEDUCIBLE A PAGAR;"
        '
        'BDEDU
        '
        Me.BDEDU.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BDEDU.Location = New System.Drawing.Point(61, 144)
        Me.BDEDU.Name = "BDEDU"
        Me.BDEDU.Size = New System.Drawing.Size(138, 23)
        Me.BDEDU.TabIndex = 6
        Me.BDEDU.Text = "CALCULAR DEDUCIBLE"
        Me.BDEDU.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BLIMPIARES)
        Me.GroupBox3.Controls.Add(Me.BESTA)
        Me.GroupBox3.Controls.Add(Me.TBDAÑOS)
        Me.GroupBox3.Controls.Add(Me.TB1825)
        Me.GroupBox3.Controls.Add(Me.TBEXT)
        Me.GroupBox3.Controls.Add(Me.TBCOND)
        Me.GroupBox3.Controls.Add(Me.TBFEM)
        Me.GroupBox3.Controls.Add(Me.TB25)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(589, 204)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadísticas:"
        '
        'BLIMPIARES
        '
        Me.BLIMPIARES.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLIMPIARES.Location = New System.Drawing.Point(280, 19)
        Me.BLIMPIARES.Name = "BLIMPIARES"
        Me.BLIMPIARES.Size = New System.Drawing.Size(153, 23)
        Me.BLIMPIARES.TabIndex = 20
        Me.BLIMPIARES.Text = "LIMPIAR ESTADÍSTICAS"
        Me.BLIMPIARES.UseVisualStyleBackColor = False
        '
        'BESTA
        '
        Me.BESTA.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BESTA.Location = New System.Drawing.Point(121, 19)
        Me.BESTA.Name = "BESTA"
        Me.BESTA.Size = New System.Drawing.Size(153, 23)
        Me.BESTA.TabIndex = 19
        Me.BESTA.Text = "MOSTRAR ESTADÍSTICAS"
        Me.BESTA.UseVisualStyleBackColor = False
        '
        'TBDAÑOS
        '
        Me.TBDAÑOS.Location = New System.Drawing.Point(467, 173)
        Me.TBDAÑOS.Name = "TBDAÑOS"
        Me.TBDAÑOS.Size = New System.Drawing.Size(100, 20)
        Me.TBDAÑOS.TabIndex = 18
        '
        'TB1825
        '
        Me.TB1825.Location = New System.Drawing.Point(467, 102)
        Me.TB1825.Name = "TB1825"
        Me.TB1825.Size = New System.Drawing.Size(100, 20)
        Me.TB1825.TabIndex = 17
        '
        'TBEXT
        '
        Me.TBEXT.Location = New System.Drawing.Point(467, 126)
        Me.TBEXT.Name = "TBEXT"
        Me.TBEXT.Size = New System.Drawing.Size(100, 20)
        Me.TBEXT.TabIndex = 16
        '
        'TBCOND
        '
        Me.TBCOND.Location = New System.Drawing.Point(467, 148)
        Me.TBCOND.Name = "TBCOND"
        Me.TBCOND.Size = New System.Drawing.Size(100, 20)
        Me.TBCOND.TabIndex = 15
        '
        'TBFEM
        '
        Me.TBFEM.Location = New System.Drawing.Point(467, 78)
        Me.TBFEM.Name = "TBFEM"
        Me.TBFEM.Size = New System.Drawing.Size(100, 20)
        Me.TBFEM.TabIndex = 14
        '
        'TB25
        '
        Me.TB25.Location = New System.Drawing.Point(467, 55)
        Me.TB25.Name = "TB25"
        Me.TB25.Size = New System.Drawing.Size(100, 20)
        Me.TB25.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(194, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(266, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "TOTAL DEL MONTO (Q) DE DAÑOS OCASIONADOS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "TOTAL DE CONDUCTORES INGRESADOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(300, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "PORCENTAJE DE CONDUCTORES MENORES A 25 AÑOS "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(118, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(342, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PORCENTAJE DE CONDUCTORES CON REGISTRO EXTRANJERO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(152, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(308, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "PORCENTAJE DE CONDUCTORES DE GENERO FEMENINO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(428, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "PORCENTAJE DE CONDUCTORES DE GENERO MASCULINO ENTRE 18 Y 25 AÑOS"
        '
        'BSALIR
        '
        Me.BSALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSALIR.Location = New System.Drawing.Point(460, 155)
        Me.BSALIR.Name = "BSALIR"
        Me.BSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BSALIR.TabIndex = 8
        Me.BSALIR.Text = "SALIR"
        Me.BSALIR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(694, 637)
        Me.Controls.Add(Me.BSALIR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BLIMPIARV)
        Me.Controls.Add(Me.BMOSTRAR)
        Me.Controls.Add(Me.BCALCULAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBCODIGO As System.Windows.Forms.ComboBox
    Friend WithEvents CBGENERO As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBEDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBTALLER As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBMONTO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BCALCULAR As System.Windows.Forms.Button
    Friend WithEvents BMOSTRAR As System.Windows.Forms.Button
    Friend WithEvents BLIMPIARV As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TBDEDU As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BDEDU As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BLIMPIARES As System.Windows.Forms.Button
    Friend WithEvents BESTA As System.Windows.Forms.Button
    Friend WithEvents TBDAÑOS As System.Windows.Forms.TextBox
    Friend WithEvents TB1825 As System.Windows.Forms.TextBox
    Friend WithEvents TBEXT As System.Windows.Forms.TextBox
    Friend WithEvents TBCOND As System.Windows.Forms.TextBox
    Friend WithEvents TBFEM As System.Windows.Forms.TextBox
    Friend WithEvents TB25 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BSALIR As System.Windows.Forms.Button

End Class
