Module Module1
    Public DPI(6) As Double
    Public NOMBRE(6) As String
    Public VALOR(6) As Double
    Public MESES(6) As String
    Public INTERESES(6) As Double
    Public TOTAL(6) As Double

    Public FILA As Byte = 0
    Sub LIMPIARENTRADAS()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TextBox1.Focus()
    End Sub
    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIDA") = vbYes Then
            Form1.Close()
        Else
            LIMPIARENTRADAS()
            LIMPIARDATA()
        End If
    End Sub
    Function REPETIDO() As Boolean
        Dim ENCONTRADO As Boolean = True
        Dim I As Byte
        I = 0
        REPETIDO = True
        While (I <= 6) And (ENCONTRADO)
            If (DPI(I) <> Nothing) Then
                If (DPI(I) = Val(Form1.TextBox1.Text)) Then
                    REPETIDO = ENCONTRADO = False
                    Return REPETIDO
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (ENCONTRADO) Then
            Return REPETIDO
        End If

    End Function
    Sub LIMPIARDATA()
        Form1.DataGridView1.Rows.Clear()
        FILA = 0
        MsgBox("DATOS ALMACENADOS Y VECTORES BORRADOS EXITOSAMENTE")
    End Sub
End Module
