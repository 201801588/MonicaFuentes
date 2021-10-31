﻿Public Class Form1
    Dim R As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("ETAPA1")
        ComboBox1.Items.Add("ETAPA2")
        ComboBox1.Items.Add("ETAPA3")
        ComboBox1.Items.Add("ETAPA4")
        ComboBox1.Items.Add("ETAPA5")
        ComboBox1.Items.Add("ETAPA6")
        ComboBox1.Items.Add("ETAPA7")
        ComboBox1.Items.Add("ETAPA8")
        ComboBox1.Items.Add("ETAPA9")
        ComboBox1.Items.Add("ETAPA10")
        ComboBox1.Items.Add("ETAPA11")
        ComboBox1.Items.Add("ETAPA12")
        ComboBox2.Items.Add("SKY")
        ComboBox2.Items.Add("MOVISTAR")
        ComboBox2.Items.Add("PRO CYCLING")
        ComboBox2.Items.Add("PRO TEAM")
        ComboBox3.Items.Add("GUATEMALTECO")
        ComboBox3.Items.Add("EXTRANJERO")
        ComboBox4.Items.Add("ETAPA1")
        ComboBox4.Items.Add("ETAPA2")
        ComboBox4.Items.Add("ETAPA3")
        ComboBox4.Items.Add("ETAPA4")
        ComboBox4.Items.Add("ETAPA5")
        ComboBox4.Items.Add("ETAPA6")
        ComboBox4.Items.Add("ETAPA7")
        ComboBox4.Items.Add("ETAPA8")
        ComboBox4.Items.Add("ETAPA9")
        ComboBox4.Items.Add("ETAPA10")
        ComboBox4.Items.Add("ETAPA11")
        ComboBox4.Items.Add("ETAPA12")
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FILA <= 11) Then
            ETAPA(FILA) = ComboBox1.Text
            EQUIPO(FILA) = ComboBox2.Text
            RECORRIDO(FILA) = TextBox1.Text
            TIEMPO(FILA) = TextBox2.Text
            NACIONALIDAD(FILA) = ComboBox3.Text
            If (TIEMPO(FILA) > 120) And (TIEMPO(FILA) <= 140) Then
                R = 30

            ElseIf (TIEMPO(FILA) > 140) And (TIEMPO(FILA) <= 160) Then
                R = 40

            ElseIf (TIEMPO(FILA) > 160) Then
                R = 50
            ElseIf (TIEMPO(FILA) < 85) And (EQUIPO(FILA) = "MOVISTAR") Then
                R = -15

            ElseIf (TIEMPO(FILA) < 85) And (EQUIPO(FILA) = "PRO TEAM") Then
                R = -10
            Else
                R = 0
            End If
            PEN_RED(FILA) = R
            TIEMPOTOTAL(FILA) = TIEMPO(FILA) + PEN_RED(FILA)
            FILA = FILA + 1
            LIMPIAR_ENTRADAS()
        End If
        If (FILA = 12) Then
            MsgBox("VECTORES LLENOS")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MOSTRAR()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim existe As Boolean = True

        I = 0
        While (I <= 11) And (existe)
            If (ETAPA(I) = ComboBox4.Text) Then
                existe = False
            Else
                I = I + 1
            End If
        End While
        If (existe) Then
            MsgBox("ETAPA NO ENCONTRADA")
            ComboBox1.Focus()
        Else
            MsgBox("REGISTRO ENCONTRADO EXITOSAMENTE")
            TextBox1.Text = RECORRIDO(I)
            TextBox2.Text = TIEMPO(I)
            ComboBox1.Text = ETAPA(I)
            ComboBox2.Text = EQUIPO(I)
            ComboBox3.Text = NACIONALIDAD(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(ETAPA(I), EQUIPO(I), RECORRIDO(I), TIEMPO(I), NACIONALIDAD(I), PEN_RED(I), TIEMPOTOTAL(I))
            FILA = I
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ETAPA(FILA) = ComboBox1.Text
        EQUIPO(FILA) = ComboBox2.Text
        RECORRIDO(FILA) = TextBox1.Text
        TIEMPO(FILA) = TextBox2.Text
        NACIONALIDAD(FILA) = ComboBox3.Text
        If (TIEMPO(FILA) > 120) And (TIEMPO(FILA) <= 140) Then
            R = 30

        ElseIf (TIEMPO(FILA) > 140) And (TIEMPO(FILA) <= 160) Then
            R = 40

        ElseIf (TIEMPO(FILA) > 160) Then
            R = 50
        ElseIf (TIEMPO(FILA) < 85) And (EQUIPO(FILA) = "MOVISTAR") Then
            R = -15

        ElseIf (TIEMPO(FILA) < 85) And (EQUIPO(FILA) = "PRO TEAM") Then
            R = -10
        Else
            R = 0
        End If
        PEN_RED(FILA) = R
        TIEMPOTOTAL(FILA) = TIEMPO(FILA) + PEN_RED(FILA)
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(ETAPA(I), EQUIPO(I), RECORRIDO(I), TIEMPO(I), NACIONALIDAD(I), PEN_RED(I), TIEMPOTOTAL(I))
        FILA = 12
        MsgBox("REGISTRO ACTUALIZADO EXITOSAMENTE")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ETAPA(FILA) = Nothing
        EQUIPO(FILA) = Nothing
        RECORRIDO(FILA) = Nothing
        TIEMPO(FILA) = Nothing
        NACIONALIDAD(FILA) = Nothing
        PEN_RED(FILA) = Nothing
        TIEMPOTOTAL(FILA) = Nothing

        For I = FILA To 10
            ETAPA(I) = ETAPA(I + 1)
            EQUIPO(I) = EQUIPO(I + 1)
            RECORRIDO(I) = RECORRIDO(I + 1)
            TIEMPO(I) = TIEMPO(I + 1)
            NACIONALIDAD(I) = NACIONALIDAD(I + 1)
            PEN_RED(I) = PEN_RED(I + 1)
            TIEMPOTOTAL(I) = TIEMPOTOTAL(I + 1)
        Next I
        MsgBox("REGISTRO ELIMINADO EXITOSAMENTE")
        ETAPA(I) = Nothing
        EQUIPO(I) = Nothing
        RECORRIDO(I) = Nothing
        TIEMPO(I) = Nothing
        NACIONALIDAD(I) = Nothing
        PEN_RED(I) = Nothing
        TIEMPOTOTAL(I) = Nothing
        FILA = I
        LIMPIAR_ENTRADAS()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SALIR()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.DataGridView1.Sort(Column1, System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim R1 As Integer = 0
        Dim R2 As Integer = 0
        Dim R3 As Integer = 0
        Dim R4 As Integer = 0
        Dim R5 As Integer = 0
        Dim R6 As Integer = 0
        Dim R7 As Integer = 0
        Dim R8 As Integer = 0
        Dim R9 As Integer = 0
        For I = 0 To 11
            If (ETAPA(I) <> Nothing) Then
                Select Case NACIONALIDAD(I)
                    Case "GUATEMALTECO"
                        Select Case RECORRIDO(I)
                            Case Is > 45
                                R1 = R1 + 1
                        End Select
                End Select
                Select Case EQUIPO(I)
                    Case "SKY"
                        R2 = R2 + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "MOVISTAR"
                        R3 = R3 + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "PRO CYCLING"
                        R4 = R4 + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "PRO TEAM"
                        R5 = R5 + Val(DataGridView1.Rows(I).Cells(2).Value)
                End Select
                Select Case EQUIPO(I)
                    Case "SKY"
                        R6 = R6 + Val(DataGridView1.Rows(I).Cells(6).Value)
                    Case "MOVISTAR"
                        R7 = R7 + Val(DataGridView1.Rows(I).Cells(6).Value)
                    Case "PRO CYCLING"
                        R8 = R8 + Val(DataGridView1.Rows(I).Cells(6).Value)
                    Case "PRO TEAM"
                        R9 = R9 + Val(DataGridView1.Rows(I).Cells(6).Value)
                End Select
            Else
                Exit For
            End If
        Next I
        TextBox3.Text = Str(R1)
        TextBox4.Text = Str(R2)
        TextBox5.Text = Str(R4)
        TextBox6.Text = Str(R3)
        TextBox7.Text = Str(R5)
        TextBox8.Text = Str(R6) / 60
        TextBox9.Text = Str(R7) / 60
        TextBox10.Text = Str(R9) / 60
        TextBox11.Text = Str(R8) / 60
    End Sub
End Class