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
        Me.CBFUNCION = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBENTRADAS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBCINE = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BSALIR = New System.Windows.Forms.Button()
        Me.BLIMPIARLISTAS = New System.Windows.Forms.Button()
        Me.BLIMPIAR = New System.Windows.Forms.Button()
        Me.BACEPTAR = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.ListBox()
        Me.DESCUENTO2 = New System.Windows.Forms.ListBox()
        Me.DESCUENTO1 = New System.Windows.Forms.ListBox()
        Me.SUBTOTAL = New System.Windows.Forms.ListBox()
        Me.ENTRADAS = New System.Windows.Forms.ListBox()
        Me.FUNCIÓN = New System.Windows.Forms.ListBox()
        Me.CINE = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBFUNCION
        '
        Me.CBFUNCION.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CBFUNCION.Location = New System.Drawing.Point(121, 105)
        Me.CBFUNCION.Name = "CBFUNCION"
        Me.CBFUNCION.Size = New System.Drawing.Size(121, 21)
        Me.CBFUNCION.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(118, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FUNCIÓN:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBENTRADAS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBCINE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBFUNCION)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Location = New System.Drawing.Point(35, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 142)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE E INGRESE"
        '
        'TBENTRADAS
        '
        Me.TBENTRADAS.Location = New System.Drawing.Point(269, 86)
        Me.TBENTRADAS.Name = "TBENTRADAS"
        Me.TBENTRADAS.Size = New System.Drawing.Size(115, 20)
        Me.TBENTRADAS.TabIndex = 6
        Me.TBENTRADAS.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(266, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NO. DE ENTRADAS:"
        '
        'CBCINE
        '
        Me.CBCINE.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CBCINE.Location = New System.Drawing.Point(121, 50)
        Me.CBCINE.Name = "CBCINE"
        Me.CBCINE.Size = New System.Drawing.Size(121, 21)
        Me.CBCINE.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(118, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CINE:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BSALIR)
        Me.GroupBox2.Controls.Add(Me.BLIMPIARLISTAS)
        Me.GroupBox2.Controls.Add(Me.BLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.BACEPTAR)
        Me.GroupBox2.Location = New System.Drawing.Point(452, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 142)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'BSALIR
        '
        Me.BSALIR.BackColor = System.Drawing.Color.DarkRed
        Me.BSALIR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BSALIR.Location = New System.Drawing.Point(59, 107)
        Me.BSALIR.Name = "BSALIR"
        Me.BSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BSALIR.TabIndex = 3
        Me.BSALIR.Text = "SALIR"
        Me.BSALIR.UseVisualStyleBackColor = False
        '
        'BLIMPIARLISTAS
        '
        Me.BLIMPIARLISTAS.BackColor = System.Drawing.Color.DarkRed
        Me.BLIMPIARLISTAS.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BLIMPIARLISTAS.Location = New System.Drawing.Point(29, 48)
        Me.BLIMPIARLISTAS.Name = "BLIMPIARLISTAS"
        Me.BLIMPIARLISTAS.Size = New System.Drawing.Size(139, 23)
        Me.BLIMPIARLISTAS.TabIndex = 2
        Me.BLIMPIARLISTAS.Text = "LIMPIAR LISTAS "
        Me.BLIMPIARLISTAS.UseVisualStyleBackColor = False
        '
        'BLIMPIAR
        '
        Me.BLIMPIAR.BackColor = System.Drawing.Color.DarkRed
        Me.BLIMPIAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BLIMPIAR.Location = New System.Drawing.Point(29, 79)
        Me.BLIMPIAR.Name = "BLIMPIAR"
        Me.BLIMPIAR.Size = New System.Drawing.Size(139, 23)
        Me.BLIMPIAR.TabIndex = 1
        Me.BLIMPIAR.Text = "LIMPIAR ENTRADAS"
        Me.BLIMPIAR.UseVisualStyleBackColor = False
        '
        'BACEPTAR
        '
        Me.BACEPTAR.BackColor = System.Drawing.Color.DarkRed
        Me.BACEPTAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BACEPTAR.Location = New System.Drawing.Point(59, 19)
        Me.BACEPTAR.Name = "BACEPTAR"
        Me.BACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BACEPTAR.TabIndex = 0
        Me.BACEPTAR.Text = "ACEPTAR"
        Me.BACEPTAR.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TOTAL)
        Me.GroupBox3.Controls.Add(Me.DESCUENTO2)
        Me.GroupBox3.Controls.Add(Me.DESCUENTO1)
        Me.GroupBox3.Controls.Add(Me.SUBTOTAL)
        Me.GroupBox3.Controls.Add(Me.ENTRADAS)
        Me.GroupBox3.Controls.Add(Me.FUNCIÓN)
        Me.GroupBox3.Controls.Add(Me.CINE)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Location = New System.Drawing.Point(35, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 174)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PRECIOS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(499, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "TOTAL A PAGAR:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "DESCUENTO 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(306, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "DESCUENTO 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "SUBTOTAL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "#ENTRADAS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FUNCIÓN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CINE:"
        '
        'TOTAL
        '
        Me.TOTAL.FormattingEnabled = True
        Me.TOTAL.Location = New System.Drawing.Point(502, 40)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(93, 121)
        Me.TOTAL.TabIndex = 6
        '
        'DESCUENTO2
        '
        Me.DESCUENTO2.FormattingEnabled = True
        Me.DESCUENTO2.Location = New System.Drawing.Point(408, 40)
        Me.DESCUENTO2.Name = "DESCUENTO2"
        Me.DESCUENTO2.Size = New System.Drawing.Size(89, 121)
        Me.DESCUENTO2.TabIndex = 5
        '
        'DESCUENTO1
        '
        Me.DESCUENTO1.FormattingEnabled = True
        Me.DESCUENTO1.Location = New System.Drawing.Point(309, 40)
        Me.DESCUENTO1.Name = "DESCUENTO1"
        Me.DESCUENTO1.Size = New System.Drawing.Size(93, 121)
        Me.DESCUENTO1.TabIndex = 4
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.FormattingEnabled = True
        Me.SUBTOTAL.Location = New System.Drawing.Point(218, 40)
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.Size = New System.Drawing.Size(85, 121)
        Me.SUBTOTAL.TabIndex = 3
        '
        'ENTRADAS
        '
        Me.ENTRADAS.FormattingEnabled = True
        Me.ENTRADAS.Location = New System.Drawing.Point(140, 40)
        Me.ENTRADAS.Name = "ENTRADAS"
        Me.ENTRADAS.Size = New System.Drawing.Size(71, 121)
        Me.ENTRADAS.TabIndex = 2
        '
        'FUNCIÓN
        '
        Me.FUNCIÓN.FormattingEnabled = True
        Me.FUNCIÓN.Location = New System.Drawing.Point(75, 40)
        Me.FUNCIÓN.Name = "FUNCIÓN"
        Me.FUNCIÓN.Size = New System.Drawing.Size(59, 121)
        Me.FUNCIÓN.TabIndex = 1
        '
        'CINE
        '
        Me.CINE.FormattingEnabled = True
        Me.CINE.Location = New System.Drawing.Point(27, 40)
        Me.CINE.Name = "CINE"
        Me.CINE.Size = New System.Drawing.Size(42, 121)
        Me.CINE.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 370)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBFUNCION As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBENTRADAS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBCINE As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BSALIR As System.Windows.Forms.Button
    Friend WithEvents BLIMPIARLISTAS As System.Windows.Forms.Button
    Friend WithEvents BLIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BACEPTAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TOTAL As System.Windows.Forms.ListBox
    Friend WithEvents DESCUENTO2 As System.Windows.Forms.ListBox
    Friend WithEvents DESCUENTO1 As System.Windows.Forms.ListBox
    Friend WithEvents SUBTOTAL As System.Windows.Forms.ListBox
    Friend WithEvents ENTRADAS As System.Windows.Forms.ListBox
    Friend WithEvents FUNCIÓN As System.Windows.Forms.ListBox
    Friend WithEvents CINE As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
