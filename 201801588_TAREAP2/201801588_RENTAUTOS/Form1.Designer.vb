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
        Me.CBMARCA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPLACA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNIT = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBDIAS = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBTARJETA = New System.Windows.Forms.TextBox()
        Me.TBEFECTIVO = New System.Windows.Forms.TextBox()
        Me.CTARJETA = New System.Windows.Forms.CheckBox()
        Me.CEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.DIASDEALQUILER = New System.Windows.Forms.ListBox()
        Me.TOTALAPAGAR = New System.Windows.Forms.ListBox()
        Me.SUBTOTAL = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DESREC = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MARCA = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PLACA = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROCESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARLISTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBMARCA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBPLACA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBNIT)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(48, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'CBMARCA
        '
        Me.CBMARCA.FormattingEnabled = True
        Me.CBMARCA.Items.AddRange(New Object() {"HONDA", "MERCEDES BENZ", "TOYOTA", "MAZDA"})
        Me.CBMARCA.Location = New System.Drawing.Point(65, 119)
        Me.CBMARCA.Name = "CBMARCA"
        Me.CBMARCA.Size = New System.Drawing.Size(100, 21)
        Me.CBMARCA.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MARCA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PLACA:"
        '
        'TBPLACA
        '
        Me.TBPLACA.Location = New System.Drawing.Point(65, 74)
        Me.TBPLACA.Name = "TBPLACA"
        Me.TBPLACA.Size = New System.Drawing.Size(100, 20)
        Me.TBPLACA.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIT:"
        '
        'TBNIT
        '
        Me.TBNIT.Location = New System.Drawing.Point(65, 33)
        Me.TBNIT.Name = "TBNIT"
        Me.TBNIT.Size = New System.Drawing.Size(100, 20)
        Me.TBNIT.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TBDIAS)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox2.Location = New System.Drawing.Point(254, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 167)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INGRESE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "* MAZDA Q 300.00 / DIA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "* HONDA = Q 250.00 / DÍA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "* MERDEDES BENZ Q 450.00 / DÍA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "* TOYOTA Q 325.00 / DIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CANTIDAD DE DIAS A ALQUILAR:"
        '
        'TBDIAS
        '
        Me.TBDIAS.Location = New System.Drawing.Point(153, 48)
        Me.TBDIAS.Name = "TBDIAS"
        Me.TBDIAS.Size = New System.Drawing.Size(100, 20)
        Me.TBDIAS.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TBTARJETA)
        Me.GroupBox3.Controls.Add(Me.TBEFECTIVO)
        Me.GroupBox3.Controls.Add(Me.CTARJETA)
        Me.GroupBox3.Controls.Add(Me.CEFECTIVO)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox3.Location = New System.Drawing.Point(520, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 167)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OPCIONES DE PAGO"
        '
        'TBTARJETA
        '
        Me.TBTARJETA.Location = New System.Drawing.Point(121, 93)
        Me.TBTARJETA.Name = "TBTARJETA"
        Me.TBTARJETA.Size = New System.Drawing.Size(100, 20)
        Me.TBTARJETA.TabIndex = 3
        Me.TBTARJETA.Visible = False
        '
        'TBEFECTIVO
        '
        Me.TBEFECTIVO.Location = New System.Drawing.Point(121, 57)
        Me.TBEFECTIVO.Name = "TBEFECTIVO"
        Me.TBEFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TBEFECTIVO.TabIndex = 2
        Me.TBEFECTIVO.Visible = False
        '
        'CTARJETA
        '
        Me.CTARJETA.AutoSize = True
        Me.CTARJETA.Location = New System.Drawing.Point(26, 93)
        Me.CTARJETA.Name = "CTARJETA"
        Me.CTARJETA.Size = New System.Drawing.Size(74, 17)
        Me.CTARJETA.TabIndex = 1
        Me.CTARJETA.Text = "TARJETA"
        Me.CTARJETA.UseVisualStyleBackColor = True
        '
        'CEFECTIVO
        '
        Me.CEFECTIVO.AutoSize = True
        Me.CEFECTIVO.Location = New System.Drawing.Point(26, 61)
        Me.CEFECTIVO.Name = "CEFECTIVO"
        Me.CEFECTIVO.Size = New System.Drawing.Size(78, 17)
        Me.CEFECTIVO.TabIndex = 0
        Me.CEFECTIVO.Text = "EFECTIVO"
        Me.CEFECTIVO.UseVisualStyleBackColor = True
        '
        'DIASDEALQUILER
        '
        Me.DIASDEALQUILER.FormattingEnabled = True
        Me.DIASDEALQUILER.Location = New System.Drawing.Point(229, 32)
        Me.DIASDEALQUILER.Name = "DIASDEALQUILER"
        Me.DIASDEALQUILER.Size = New System.Drawing.Size(80, 95)
        Me.DIASDEALQUILER.TabIndex = 13
        '
        'TOTALAPAGAR
        '
        Me.TOTALAPAGAR.FormattingEnabled = True
        Me.TOTALAPAGAR.Location = New System.Drawing.Point(563, 32)
        Me.TOTALAPAGAR.Name = "TOTALAPAGAR"
        Me.TOTALAPAGAR.Size = New System.Drawing.Size(104, 95)
        Me.TOTALAPAGAR.TabIndex = 14
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.FormattingEnabled = True
        Me.SUBTOTAL.Location = New System.Drawing.Point(315, 32)
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.Size = New System.Drawing.Size(104, 95)
        Me.SUBTOTAL.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "SUBTOTAL:"
        '
        'DESREC
        '
        Me.DESREC.FormattingEnabled = True
        Me.DESREC.Location = New System.Drawing.Point(425, 32)
        Me.DESREC.Name = "DESREC"
        Me.DESREC.Size = New System.Drawing.Size(132, 95)
        Me.DESREC.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DESCUENTO/RECARGO:"
        '
        'MARCA
        '
        Me.MARCA.FormattingEnabled = True
        Me.MARCA.Location = New System.Drawing.Point(112, 32)
        Me.MARCA.Name = "MARCA"
        Me.MARCA.Size = New System.Drawing.Size(111, 95)
        Me.MARCA.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(560, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "TOTAL A PAGAR:"
        '
        'PLACA
        '
        Me.PLACA.FormattingEnabled = True
        Me.PLACA.Location = New System.Drawing.Point(19, 32)
        Me.PLACA.Name = "PLACA"
        Me.PLACA.Size = New System.Drawing.Size(87, 95)
        Me.PLACA.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(226, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "DIAS:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(109, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "MARCA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "PLACA:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.PLACA)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.MARCA)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.DESREC)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.SUBTOTAL)
        Me.GroupBox4.Controls.Add(Me.TOTALAPAGAR)
        Me.GroupBox4.Controls.Add(Me.DIASDEALQUILER)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(68, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(684, 133)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROCESOSToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARLISTASToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(796, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROCESOSToolStripMenuItem
        '
        Me.PROCESOSToolStripMenuItem.Name = "PROCESOSToolStripMenuItem"
        Me.PROCESOSToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PROCESOSToolStripMenuItem.Text = "PROCESOS"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARLISTASToolStripMenuItem
        '
        Me.LIMPIARLISTASToolStripMenuItem.Name = "LIMPIARLISTASToolStripMenuItem"
        Me.LIMPIARLISTASToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.LIMPIARLISTASToolStripMenuItem.Text = "LIMPIAR LISTAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 378)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBMARCA As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBPLACA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNIT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBDIAS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TBTARJETA As System.Windows.Forms.TextBox
    Friend WithEvents TBEFECTIVO As System.Windows.Forms.TextBox
    Friend WithEvents CTARJETA As System.Windows.Forms.CheckBox
    Friend WithEvents CEFECTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents DIASDEALQUILER As System.Windows.Forms.ListBox
    Friend WithEvents TOTALAPAGAR As System.Windows.Forms.ListBox
    Friend WithEvents SUBTOTAL As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DESREC As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MARCA As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PLACA As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PROCESOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARLISTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
