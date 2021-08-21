<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUBRECAMASPREMIUM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CUBRECAMASPREMIUM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QUEEN = New System.Windows.Forms.RadioButton()
        Me.KING = New System.Windows.Forms.RadioButton()
        Me.MATRIMONIAL = New System.Windows.Forms.RadioButton()
        Me.IMPERIAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.HILOCRUDO = New System.Windows.Forms.CheckBox()
        Me.CHECKSEDA = New System.Windows.Forms.CheckBox()
        Me.ALGODÓN = New System.Windows.Forms.CheckBox()
        Me.LINO = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TEXTHILOCRUDO = New System.Windows.Forms.TextBox()
        Me.TEXTSEDA = New System.Windows.Forms.TextBox()
        Me.TEXTALGODÓN = New System.Windows.Forms.TextBox()
        Me.TEXTLINO = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TEXTPRECIO = New System.Windows.Forms.TextBox()
        Me.TEXTCOSTO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TEXTMATERIALES = New System.Windows.Forms.TextBox()
        Me.TEXTMANODEOBRA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.QUEEN)
        Me.GroupBox1.Controls.Add(Me.KING)
        Me.GroupBox1.Controls.Add(Me.MATRIMONIAL)
        Me.GroupBox1.Controls.Add(Me.IMPERIAL)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO DE CUBRECAMA"
        '
        'QUEEN
        '
        Me.QUEEN.AutoSize = True
        Me.QUEEN.Location = New System.Drawing.Point(36, 68)
        Me.QUEEN.Name = "QUEEN"
        Me.QUEEN.Size = New System.Drawing.Size(57, 17)
        Me.QUEEN.TabIndex = 3
        Me.QUEEN.TabStop = True
        Me.QUEEN.Text = "Queen"
        Me.QUEEN.UseVisualStyleBackColor = True
        '
        'KING
        '
        Me.KING.AutoSize = True
        Me.KING.Location = New System.Drawing.Point(36, 91)
        Me.KING.Name = "KING"
        Me.KING.Size = New System.Drawing.Size(46, 17)
        Me.KING.TabIndex = 2
        Me.KING.TabStop = True
        Me.KING.Text = "King"
        Me.KING.UseVisualStyleBackColor = True
        '
        'MATRIMONIAL
        '
        Me.MATRIMONIAL.AutoSize = True
        Me.MATRIMONIAL.Location = New System.Drawing.Point(36, 45)
        Me.MATRIMONIAL.Name = "MATRIMONIAL"
        Me.MATRIMONIAL.Size = New System.Drawing.Size(78, 17)
        Me.MATRIMONIAL.TabIndex = 1
        Me.MATRIMONIAL.TabStop = True
        Me.MATRIMONIAL.Text = "Matrimonial"
        Me.MATRIMONIAL.UseVisualStyleBackColor = True
        '
        'IMPERIAL
        '
        Me.IMPERIAL.AutoSize = True
        Me.IMPERIAL.Location = New System.Drawing.Point(36, 20)
        Me.IMPERIAL.Name = "IMPERIAL"
        Me.IMPERIAL.Size = New System.Drawing.Size(61, 17)
        Me.IMPERIAL.TabIndex = 0
        Me.IMPERIAL.TabStop = True
        Me.IMPERIAL.Text = "Imperial"
        Me.IMPERIAL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.HILOCRUDO)
        Me.GroupBox2.Controls.Add(Me.CHECKSEDA)
        Me.GroupBox2.Controls.Add(Me.ALGODÓN)
        Me.GroupBox2.Controls.Add(Me.LINO)
        Me.GroupBox2.Location = New System.Drawing.Point(192, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIAL DEL CUBRECAMA"
        '
        'HILOCRUDO
        '
        Me.HILOCRUDO.AutoSize = True
        Me.HILOCRUDO.Location = New System.Drawing.Point(45, 91)
        Me.HILOCRUDO.Name = "HILOCRUDO"
        Me.HILOCRUDO.Size = New System.Drawing.Size(75, 17)
        Me.HILOCRUDO.TabIndex = 3
        Me.HILOCRUDO.Text = "Hilo Crudo"
        Me.HILOCRUDO.UseVisualStyleBackColor = True
        '
        'CHECKSEDA
        '
        Me.CHECKSEDA.AutoSize = True
        Me.CHECKSEDA.Location = New System.Drawing.Point(45, 68)
        Me.CHECKSEDA.Name = "CHECKSEDA"
        Me.CHECKSEDA.Size = New System.Drawing.Size(51, 17)
        Me.CHECKSEDA.TabIndex = 2
        Me.CHECKSEDA.Text = "Seda"
        Me.CHECKSEDA.UseVisualStyleBackColor = True
        '
        'ALGODÓN
        '
        Me.ALGODÓN.AutoSize = True
        Me.ALGODÓN.Location = New System.Drawing.Point(45, 45)
        Me.ALGODÓN.Name = "ALGODÓN"
        Me.ALGODÓN.Size = New System.Drawing.Size(65, 17)
        Me.ALGODÓN.TabIndex = 1
        Me.ALGODÓN.Text = "Algodón"
        Me.ALGODÓN.UseVisualStyleBackColor = True
        '
        'LINO
        '
        Me.LINO.AutoSize = True
        Me.LINO.Location = New System.Drawing.Point(45, 20)
        Me.LINO.Name = "LINO"
        Me.LINO.Size = New System.Drawing.Size(46, 17)
        Me.LINO.TabIndex = 0
        Me.LINO.Text = "Lino"
        Me.LINO.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TEXTHILOCRUDO)
        Me.GroupBox3.Controls.Add(Me.TEXTSEDA)
        Me.GroupBox3.Controls.Add(Me.TEXTALGODÓN)
        Me.GroupBox3.Controls.Add(Me.TEXTLINO)
        Me.GroupBox3.Location = New System.Drawing.Point(383, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(147, 119)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NÚMERO DE YARDAS"
        '
        'TEXTHILOCRUDO
        '
        Me.TEXTHILOCRUDO.Location = New System.Drawing.Point(24, 91)
        Me.TEXTHILOCRUDO.Name = "TEXTHILOCRUDO"
        Me.TEXTHILOCRUDO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTHILOCRUDO.TabIndex = 3
        Me.TEXTHILOCRUDO.Visible = False
        '
        'TEXTSEDA
        '
        Me.TEXTSEDA.Location = New System.Drawing.Point(24, 68)
        Me.TEXTSEDA.Name = "TEXTSEDA"
        Me.TEXTSEDA.Size = New System.Drawing.Size(100, 20)
        Me.TEXTSEDA.TabIndex = 2
        Me.TEXTSEDA.Visible = False
        '
        'TEXTALGODÓN
        '
        Me.TEXTALGODÓN.Location = New System.Drawing.Point(24, 43)
        Me.TEXTALGODÓN.Name = "TEXTALGODÓN"
        Me.TEXTALGODÓN.Size = New System.Drawing.Size(100, 20)
        Me.TEXTALGODÓN.TabIndex = 1
        Me.TEXTALGODÓN.Visible = False
        '
        'TEXTLINO
        '
        Me.TEXTLINO.Location = New System.Drawing.Point(24, 20)
        Me.TEXTLINO.Name = "TEXTLINO"
        Me.TEXTLINO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTLINO.TabIndex = 0
        Me.TEXTLINO.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TEXTPRECIO)
        Me.GroupBox4.Controls.Add(Me.TEXTCOSTO)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TEXTMATERIALES)
        Me.GroupBox4.Controls.Add(Me.TEXTMANODEOBRA)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(63, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(408, 112)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESULTADOS"
        '
        'TEXTPRECIO
        '
        Me.TEXTPRECIO.Location = New System.Drawing.Point(212, 80)
        Me.TEXTPRECIO.Name = "TEXTPRECIO"
        Me.TEXTPRECIO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTPRECIO.TabIndex = 7
        '
        'TEXTCOSTO
        '
        Me.TEXTCOSTO.Location = New System.Drawing.Point(59, 80)
        Me.TEXTCOSTO.Name = "TEXTCOSTO"
        Me.TEXTCOSTO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTCOSTO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio de Venta/ Total a pagar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio de costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total de materiales seleccionados:"
        '
        'TEXTMATERIALES
        '
        Me.TEXTMATERIALES.Location = New System.Drawing.Point(212, 36)
        Me.TEXTMATERIALES.Name = "TEXTMATERIALES"
        Me.TEXTMATERIALES.Size = New System.Drawing.Size(100, 20)
        Me.TEXTMATERIALES.TabIndex = 2
        '
        'TEXTMANODEOBRA
        '
        Me.TEXTMANODEOBRA.Location = New System.Drawing.Point(59, 36)
        Me.TEXTMANODEOBRA.Name = "TEXTMANODEOBRA"
        Me.TEXTMANODEOBRA.Size = New System.Drawing.Size(100, 20)
        Me.TEXTMANODEOBRA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mano de Obra:"
        '
        'CALCULAR
        '
        Me.CALCULAR.Location = New System.Drawing.Point(122, 317)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.CALCULAR.TabIndex = 4
        Me.CALCULAR.Text = "CALCULAR"
        Me.CALCULAR.UseVisualStyleBackColor = True
        '
        'LIMPIAR
        '
        Me.LIMPIAR.Location = New System.Drawing.Point(225, 316)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.LIMPIAR.TabIndex = 5
        Me.LIMPIAR.Text = "LIMPIAR"
        Me.LIMPIAR.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(330, 317)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(75, 23)
        Me.SALIR.TabIndex = 6
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(542, 359)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.LIMPIAR)
        Me.Controls.Add(Me.CALCULAR)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents QUEEN As System.Windows.Forms.RadioButton
    Friend WithEvents KING As System.Windows.Forms.RadioButton
    Friend WithEvents MATRIMONIAL As System.Windows.Forms.RadioButton
    Friend WithEvents IMPERIAL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents HILOCRUDO As System.Windows.Forms.CheckBox
    Friend WithEvents CHECKSEDA As System.Windows.Forms.CheckBox
    Friend WithEvents ALGODÓN As System.Windows.Forms.CheckBox
    Friend WithEvents LINO As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TEXTHILOCRUDO As System.Windows.Forms.TextBox
    Friend WithEvents TEXTSEDA As System.Windows.Forms.TextBox
    Friend WithEvents TEXTALGODÓN As System.Windows.Forms.TextBox
    Friend WithEvents TEXTLINO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CALCULAR As System.Windows.Forms.Button
    Friend WithEvents LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents SALIR As System.Windows.Forms.Button
    Friend WithEvents TEXTPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents TEXTCOSTO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TEXTMATERIALES As System.Windows.Forms.TextBox
    Friend WithEvents TEXTMANODEOBRA As System.Windows.Forms.TextBox

End Class
