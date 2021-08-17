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
        Me.TIPO = New System.Windows.Forms.Label()
        Me.METODO = New System.Windows.Forms.Label()
        Me.MONTO = New System.Windows.Forms.Label()
        Me.CHECKCHEQUEPROPIO = New System.Windows.Forms.CheckBox()
        Me.CHECKOTROBANCO = New System.Windows.Forms.CheckBox()
        Me.CHECKEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.BUTTONMONETARIOS = New System.Windows.Forms.RadioButton()
        Me.BUTTONMONETARIOPREMIER = New System.Windows.Forms.RadioButton()
        Me.BUTTONAHORRO = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TEXTCHEQUEPROPIO = New System.Windows.Forms.TextBox()
        Me.TEXTCHEQUEOTRO = New System.Windows.Forms.TextBox()
        Me.TEXTEFECTIVO = New System.Windows.Forms.TextBox()
        Me.SALDOANTERIOR = New System.Windows.Forms.Label()
        Me.TEXTSALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.INTERES = New System.Windows.Forms.Label()
        Me.TEXTINTERES = New System.Windows.Forms.TextBox()
        Me.NUEVOSALDO = New System.Windows.Forms.Label()
        Me.TEXTNUEVOSALDO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TEXTMONTOTOTAL = New System.Windows.Forms.TextBox()
        Me.BLIMPIAR = New System.Windows.Forms.Button()
        Me.BCALCULAR = New System.Windows.Forms.Button()
        Me.BSALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TIPO
        '
        Me.TIPO.AutoSize = True
        Me.TIPO.Location = New System.Drawing.Point(23, 13)
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Size = New System.Drawing.Size(108, 13)
        Me.TIPO.TabIndex = 0
        Me.TIPO.Text = "TIPO DE DEPÓSITO"
        '
        'METODO
        '
        Me.METODO.AutoSize = True
        Me.METODO.Location = New System.Drawing.Point(203, 13)
        Me.METODO.Name = "METODO"
        Me.METODO.Size = New System.Drawing.Size(130, 13)
        Me.METODO.TabIndex = 1
        Me.METODO.Text = "MÉTODO DE DEPÓSITO"
        '
        'MONTO
        '
        Me.MONTO.AutoSize = True
        Me.MONTO.Location = New System.Drawing.Point(384, 13)
        Me.MONTO.Name = "MONTO"
        Me.MONTO.Size = New System.Drawing.Size(47, 13)
        Me.MONTO.TabIndex = 2
        Me.MONTO.Text = "MONTO"
        '
        'CHECKCHEQUEPROPIO
        '
        Me.CHECKCHEQUEPROPIO.AutoSize = True
        Me.CHECKCHEQUEPROPIO.Location = New System.Drawing.Point(197, 38)
        Me.CHECKCHEQUEPROPIO.Name = "CHECKCHEQUEPROPIO"
        Me.CHECKCHEQUEPROPIO.Size = New System.Drawing.Size(115, 17)
        Me.CHECKCHEQUEPROPIO.TabIndex = 3
        Me.CHECKCHEQUEPROPIO.Text = "CHEQUE PROPIO"
        Me.CHECKCHEQUEPROPIO.UseVisualStyleBackColor = True
        '
        'CHECKOTROBANCO
        '
        Me.CHECKOTROBANCO.AutoSize = True
        Me.CHECKOTROBANCO.Location = New System.Drawing.Point(197, 71)
        Me.CHECKOTROBANCO.Name = "CHECKOTROBANCO"
        Me.CHECKOTROBANCO.Size = New System.Drawing.Size(145, 17)
        Me.CHECKOTROBANCO.TabIndex = 4
        Me.CHECKOTROBANCO.Text = "CHEQUE OTRO BANCO"
        Me.CHECKOTROBANCO.UseVisualStyleBackColor = True
        '
        'CHECKEFECTIVO
        '
        Me.CHECKEFECTIVO.AutoSize = True
        Me.CHECKEFECTIVO.Location = New System.Drawing.Point(197, 105)
        Me.CHECKEFECTIVO.Name = "CHECKEFECTIVO"
        Me.CHECKEFECTIVO.Size = New System.Drawing.Size(78, 17)
        Me.CHECKEFECTIVO.TabIndex = 5
        Me.CHECKEFECTIVO.Text = "EFECTIVO"
        Me.CHECKEFECTIVO.UseVisualStyleBackColor = True
        '
        'BUTTONMONETARIOS
        '
        Me.BUTTONMONETARIOS.AutoSize = True
        Me.BUTTONMONETARIOS.Location = New System.Drawing.Point(16, 37)
        Me.BUTTONMONETARIOS.Name = "BUTTONMONETARIOS"
        Me.BUTTONMONETARIOS.Size = New System.Drawing.Size(90, 17)
        Me.BUTTONMONETARIOS.TabIndex = 6
        Me.BUTTONMONETARIOS.TabStop = True
        Me.BUTTONMONETARIOS.Text = "MONETARIO"
        Me.BUTTONMONETARIOS.UseVisualStyleBackColor = True
        '
        'BUTTONMONETARIOPREMIER
        '
        Me.BUTTONMONETARIOPREMIER.AutoSize = True
        Me.BUTTONMONETARIOPREMIER.Location = New System.Drawing.Point(16, 70)
        Me.BUTTONMONETARIOPREMIER.Name = "BUTTONMONETARIOPREMIER"
        Me.BUTTONMONETARIOPREMIER.Size = New System.Drawing.Size(142, 17)
        Me.BUTTONMONETARIOPREMIER.TabIndex = 7
        Me.BUTTONMONETARIOPREMIER.TabStop = True
        Me.BUTTONMONETARIOPREMIER.Text = "MONETARIO PREMIER"
        Me.BUTTONMONETARIOPREMIER.UseVisualStyleBackColor = True
        '
        'BUTTONAHORRO
        '
        Me.BUTTONAHORRO.AutoSize = True
        Me.BUTTONAHORRO.Location = New System.Drawing.Point(16, 104)
        Me.BUTTONAHORRO.Name = "BUTTONAHORRO"
        Me.BUTTONAHORRO.Size = New System.Drawing.Size(72, 17)
        Me.BUTTONAHORRO.TabIndex = 8
        Me.BUTTONAHORRO.TabStop = True
        Me.BUTTONAHORRO.Text = "AHORRO"
        Me.BUTTONAHORRO.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Q"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Q"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Q"
        '
        'TEXTCHEQUEPROPIO
        '
        Me.TEXTCHEQUEPROPIO.Location = New System.Drawing.Point(405, 38)
        Me.TEXTCHEQUEPROPIO.Name = "TEXTCHEQUEPROPIO"
        Me.TEXTCHEQUEPROPIO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTCHEQUEPROPIO.TabIndex = 12
        Me.TEXTCHEQUEPROPIO.Visible = False
        '
        'TEXTCHEQUEOTRO
        '
        Me.TEXTCHEQUEOTRO.Location = New System.Drawing.Point(405, 71)
        Me.TEXTCHEQUEOTRO.Name = "TEXTCHEQUEOTRO"
        Me.TEXTCHEQUEOTRO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTCHEQUEOTRO.TabIndex = 13
        Me.TEXTCHEQUEOTRO.Visible = False
        '
        'TEXTEFECTIVO
        '
        Me.TEXTEFECTIVO.Location = New System.Drawing.Point(405, 105)
        Me.TEXTEFECTIVO.Name = "TEXTEFECTIVO"
        Me.TEXTEFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTEFECTIVO.TabIndex = 14
        Me.TEXTEFECTIVO.Visible = False
        '
        'SALDOANTERIOR
        '
        Me.SALDOANTERIOR.AutoSize = True
        Me.SALDOANTERIOR.Location = New System.Drawing.Point(13, 141)
        Me.SALDOANTERIOR.Name = "SALDOANTERIOR"
        Me.SALDOANTERIOR.Size = New System.Drawing.Size(156, 13)
        Me.SALDOANTERIOR.TabIndex = 15
        Me.SALDOANTERIOR.Text = "INGRESE SALDO ANTERIOR:"
        '
        'TEXTSALDOANTERIOR
        '
        Me.TEXTSALDOANTERIOR.Location = New System.Drawing.Point(167, 157)
        Me.TEXTSALDOANTERIOR.Name = "TEXTSALDOANTERIOR"
        Me.TEXTSALDOANTERIOR.Size = New System.Drawing.Size(100, 20)
        Me.TEXTSALDOANTERIOR.TabIndex = 16
        '
        'INTERES
        '
        Me.INTERES.AutoSize = True
        Me.INTERES.Location = New System.Drawing.Point(278, 141)
        Me.INTERES.Name = "INTERES"
        Me.INTERES.Size = New System.Drawing.Size(121, 13)
        Me.INTERES.TabIndex = 17
        Me.INTERES.Text = "INTERES GENERADO:"
        '
        'TEXTINTERES
        '
        Me.TEXTINTERES.Location = New System.Drawing.Point(405, 157)
        Me.TEXTINTERES.Name = "TEXTINTERES"
        Me.TEXTINTERES.Size = New System.Drawing.Size(100, 20)
        Me.TEXTINTERES.TabIndex = 18
        '
        'NUEVOSALDO
        '
        Me.NUEVOSALDO.AutoSize = True
        Me.NUEVOSALDO.Location = New System.Drawing.Point(82, 194)
        Me.NUEVOSALDO.Name = "NUEVOSALDO"
        Me.NUEVOSALDO.Size = New System.Drawing.Size(87, 13)
        Me.NUEVOSALDO.TabIndex = 19
        Me.NUEVOSALDO.Text = "NUEVO SALDO:"
        '
        'TEXTNUEVOSALDO
        '
        Me.TEXTNUEVOSALDO.Location = New System.Drawing.Point(167, 210)
        Me.TEXTNUEVOSALDO.Name = "TEXTNUEVOSALDO"
        Me.TEXTNUEVOSALDO.Size = New System.Drawing.Size(100, 20)
        Me.TEXTNUEVOSALDO.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "MONTO TOTAL:"
        '
        'TEXTMONTOTOTAL
        '
        Me.TEXTMONTOTOTAL.Location = New System.Drawing.Point(405, 210)
        Me.TEXTMONTOTOTAL.Name = "TEXTMONTOTOTAL"
        Me.TEXTMONTOTOTAL.Size = New System.Drawing.Size(100, 20)
        Me.TEXTMONTOTOTAL.TabIndex = 22
        '
        'BLIMPIAR
        '
        Me.BLIMPIAR.Location = New System.Drawing.Point(130, 267)
        Me.BLIMPIAR.Name = "BLIMPIAR"
        Me.BLIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.BLIMPIAR.TabIndex = 23
        Me.BLIMPIAR.Text = "LIMPIAR"
        Me.BLIMPIAR.UseVisualStyleBackColor = True
        '
        'BCALCULAR
        '
        Me.BCALCULAR.Location = New System.Drawing.Point(239, 267)
        Me.BCALCULAR.Name = "BCALCULAR"
        Me.BCALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.BCALCULAR.TabIndex = 24
        Me.BCALCULAR.Text = "CALCULAR"
        Me.BCALCULAR.UseVisualStyleBackColor = True
        '
        'BSALIR
        '
        Me.BSALIR.Location = New System.Drawing.Point(343, 267)
        Me.BSALIR.Name = "BSALIR"
        Me.BSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BSALIR.TabIndex = 25
        Me.BSALIR.Text = "SALIR"
        Me.BSALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(546, 318)
        Me.Controls.Add(Me.BSALIR)
        Me.Controls.Add(Me.BCALCULAR)
        Me.Controls.Add(Me.BLIMPIAR)
        Me.Controls.Add(Me.TEXTMONTOTOTAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TEXTNUEVOSALDO)
        Me.Controls.Add(Me.NUEVOSALDO)
        Me.Controls.Add(Me.TEXTINTERES)
        Me.Controls.Add(Me.INTERES)
        Me.Controls.Add(Me.TEXTSALDOANTERIOR)
        Me.Controls.Add(Me.SALDOANTERIOR)
        Me.Controls.Add(Me.TEXTEFECTIVO)
        Me.Controls.Add(Me.TEXTCHEQUEOTRO)
        Me.Controls.Add(Me.TEXTCHEQUEPROPIO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BUTTONAHORRO)
        Me.Controls.Add(Me.BUTTONMONETARIOPREMIER)
        Me.Controls.Add(Me.BUTTONMONETARIOS)
        Me.Controls.Add(Me.CHECKEFECTIVO)
        Me.Controls.Add(Me.CHECKOTROBANCO)
        Me.Controls.Add(Me.CHECKCHEQUEPROPIO)
        Me.Controls.Add(Me.MONTO)
        Me.Controls.Add(Me.METODO)
        Me.Controls.Add(Me.TIPO)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TIPO As System.Windows.Forms.Label
    Friend WithEvents METODO As System.Windows.Forms.Label
    Friend WithEvents MONTO As System.Windows.Forms.Label
    Friend WithEvents CHECKCHEQUEPROPIO As System.Windows.Forms.CheckBox
    Friend WithEvents CHECKOTROBANCO As System.Windows.Forms.CheckBox
    Friend WithEvents CHECKEFECTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents BUTTONMONETARIOS As System.Windows.Forms.RadioButton
    Friend WithEvents BUTTONMONETARIOPREMIER As System.Windows.Forms.RadioButton
    Friend WithEvents BUTTONAHORRO As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TEXTCHEQUEPROPIO As System.Windows.Forms.TextBox
    Friend WithEvents TEXTCHEQUEOTRO As System.Windows.Forms.TextBox
    Friend WithEvents TEXTEFECTIVO As System.Windows.Forms.TextBox
    Friend WithEvents SALDOANTERIOR As System.Windows.Forms.Label
    Friend WithEvents TEXTSALDOANTERIOR As System.Windows.Forms.TextBox
    Friend WithEvents INTERES As System.Windows.Forms.Label
    Friend WithEvents TEXTINTERES As System.Windows.Forms.TextBox
    Friend WithEvents NUEVOSALDO As System.Windows.Forms.Label
    Friend WithEvents TEXTNUEVOSALDO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TEXTMONTOTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents BLIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BCALCULAR As System.Windows.Forms.Button
    Friend WithEvents BSALIR As System.Windows.Forms.Button

End Class
