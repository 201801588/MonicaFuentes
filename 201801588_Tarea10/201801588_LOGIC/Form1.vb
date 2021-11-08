Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("0-12 MESES")
        ComboBox1.Items.Add("12-24 MESES")
        ComboBox1.Items.Add("24-36 MESES")
        ComboBox1.Items.Add("36 O MAS MESES")
    End Sub
    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If (FILA <= 6) Then
            If (Not (REPETIDO())) Then
                MsgBox("Número de DPI repetido no se puede ingresar el dato")
                TextBox1.Focus()
            Else
                DPI(FILA) = Val(TextBox1.Text)
                NOMBRE(FILA) = TextBox2.Text
                VALOR(FILA) = Val(TextBox3.Text)
                MESES(FILA) = ComboBox1.Text
                Select Case ComboBox1.SelectedIndex
                    Case 0 : INTERESES(FILA) = 0.03
                    Case 1 : INTERESES(FILA) = 0.045
                    Case 2 : INTERESES(FILA) = 0.055
                    Case 3 : INTERESES(FILA) = 0.062
                End Select
                If (ComboBox1.Text = "0-12 MESES") And (TextBox3.Text >= 8000) Then
                    INTERESES(FILA) = 0.02
                End If
                TOTAL(FILA) = VALOR(FILA) + (VALOR(FILA) * INTERESES(FILA))
                FILA = FILA + 1
            End If
            If (FILA = 7) Then
                MsgBox("VECTORES LLENOS")
            End If
        End If
        LIMPIARENTRADAS()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Dim I As Byte
        DataGridView1.Rows.Clear()
        For I = 0 To 6
            If DPI(I) <> Nothing Then
                DataGridView1.Rows.Add(Str(DPI(I)), NOMBRE(I), VALOR(I), MESES(I), INTERESES(I), Str(TOTAL(I)))
            Else
                Exit For
            End If
        Next I
        LIMPIARENTRADAS()
    End Sub

    Private Sub CONSULTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem.Click
        Dim I As Byte = 0
        Dim EXISTE As Boolean = True

        While (I <= 6) And (EXISTE)
            If (DPI(I) <> Nothing) Then
                If (DPI(I) = Val(TextBox4.Text)) Then
                    EXISTE = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (EXISTE) Then
            MsgBox("Número de DPI no encontrado")
        Else
            MsgBox("Número de DPI encontrado exitosamente")
            TextBox1.Text = DPI(I)
            TextBox2.Text = NOMBRE(I)
            TextBox3.Text = VALOR(I)
            ComboBox1.Text = MESES(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(DPI(I)), NOMBRE(I), VALOR(I), MESES(I), INTERESES(I), Str(TOTAL(I)))

            FILA = I
            TextBox4.Clear()
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        DPI(FILA) = Val(TextBox1.Text)
        NOMBRE(FILA) = TextBox2.Text
        VALOR(FILA) = Val(TextBox3.Text)
        MESES(FILA) = ComboBox1.Text
        Select Case ComboBox1.SelectedIndex
            Case 0 : INTERESES(FILA) = 0.03
            Case 1 : INTERESES(FILA) = 0.045
            Case 2 : INTERESES(FILA) = 0.055
            Case 3 : INTERESES(FILA) = 0.062
        End Select
        If (ComboBox1.Text = "0-12 MESES") And (TextBox3.Text >= 8000) Then
            INTERESES(FILA) = 0.02
        End If
        FILA = 0
        While DPI(FILA) <> Nothing
            FILA = FILA + 1
        End While
        LIMPIARENTRADAS()
        MsgBox("Vuelva a mostrar los datos para actualizar la tabla")
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim I As Byte

        If (MsgBox("DESEA ELIMINAR EL REGISTRO SELECCIONADO", vbQuestion + vbYesNo, "MENSAJE DE VERIFICACIÓN DE ELIMINACIÓN") = vbYes) Then
            DPI(FILA) = Nothing
            NOMBRE(FILA) = Nothing
            VALOR(FILA) = Nothing
            MESES(FILA) = Nothing
            INTERESES(FILA) = Nothing
            TOTAL(FILA) = Nothing
            For I = FILA To 5
                DPI(I) = DPI(I + 1)
                NOMBRE(I) = NOMBRE(I + 1)
                VALOR(I) = VALOR(I + 1)
                MESES(I) = MESES(I + 1)
                INTERESES(I) = INTERESES(I + 1)
                TOTAL(I) = TOTAL(I + 1)
            Next I
            FILA = 0
            While (DPI(FILA) <> Nothing)
                FILA = FILA + 1
            End While
            DPI(I) = Nothing
            NOMBRE(I) = Nothing
            VALOR(I) = Nothing
            MESES(I) = Nothing
            INTERESES(I) = Nothing
            TOTAL(I) = Nothing
        End If
        LIMPIARENTRADAS()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DESCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCENDENTEToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As String
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As String
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6
                If (DPI(j) <> Nothing) Then
                    If (DPI(i) < DPI(j)) Then

                        temp1 = DPI(i)
                        DPI(i) = DPI(j)
                        DPI(j) = temp1

                        temp2 = NOMBRE(i)
                        NOMBRE(i) = NOMBRE(j)
                        NOMBRE(j) = temp2

                        temp3 = VALOR(i)
                        VALOR(i) = VALOR(j)
                        VALOR(j) = temp3

                        temp4 = MESES(i)
                        MESES(i) = MESES(j)
                        MESES(j) = temp4

                        temp5 = INTERESES(i)
                        INTERESES(i) = INTERESES(j)
                        INTERESES(j) = temp5

                        temp6 = TOTAL(i)
                        TOTAL(i) = TOTAL(j)
                        TOTAL(j) = temp5
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub

    Private Sub ASCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASCENDENTEToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As String
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As String
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6
                If (DPI(j) <> Nothing) Then
                    If (DPI(i) > DPI(j)) Then

                        temp1 = DPI(i)
                        DPI(i) = DPI(j)
                        DPI(j) = temp1

                        temp2 = NOMBRE(i)
                        NOMBRE(i) = NOMBRE(j)
                        NOMBRE(j) = temp2

                        temp3 = VALOR(i)
                        VALOR(i) = VALOR(j)
                        VALOR(j) = temp3

                        temp4 = MESES(i)
                        MESES(i) = MESES(j)
                        MESES(j) = temp4

                        temp5 = INTERESES(i)
                        INTERESES(i) = INTERESES(j)
                        INTERESES(j) = temp5

                        temp6 = TOTAL(i)
                        TOTAL(i) = TOTAL(j)
                        TOTAL(j) = temp5
                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub
    
    Private Sub ENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADASToolStripMenuItem.Click
        LIMPIARENTRADAS()
    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        LIMPIARDATA()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        SALIR()
    End Sub
End Class
