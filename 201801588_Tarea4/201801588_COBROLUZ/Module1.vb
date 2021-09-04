Imports System.Math
Module Module1
    Public KW As Byte = 0
    Public NOMBRE(11) As String
    Public SERVICIO(11) As String
    Public TARIFA(11) As String
    Public TIPOSERVICIO(11) As String
    Public TIPOTARIFA(11) As String
    Public NIT(11) As Double
    Public SALDOA(11) As Double
    Public CKILO(11) As Double
    Public PARCIAL(11) As Double
    Public TOTAL(11) As Double
    Public RECARGO(11) As Double
    Public DESC1(11) As Double
    Public DESC2(11) As Double
    Public resi1 As Byte = 0.99
    Public resi2 As Byte = 1.2
    Public resi3 As Byte = 3
    Public indus1 As Byte = 1.99
    Public indus2 As Byte = 2.2
    Public indus3 As Byte = 4



    Sub LIMPIAR()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Focus()
        MsgBox("DATOS DE CAJA DE TEXTO BORRADOS EXITOSAMENTE")
    End Sub

    Sub LIMPIARTODO()
        Form1.DataGridView1.Rows.Clear()
        KW = 0
        MsgBox("DATOS ALMACENADOS BORRADOS EXITOSAMENTE")
    End Sub

    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            End
        Else
            LIMPIAR()
            LIMPIARTODO()
        End If
    End Sub

    Sub CALCULAR()
        If (KW < 11) Then
            If (Form1.TextBox1.Text <> "") Then
                NOMBRE(KW) = Form1.TextBox1.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NOMBRE")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox2.Text) And Val(Form1.TextBox2.Text) > 0) Then
                NIT(KW) = Form1.TextBox2.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NUMERO DE NIT")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox3.Text) And Val(Form1.TextBox3.Text) >= 0) Then
                SALDOA(KW) = Form1.TextBox3.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR SU SALDO ANTERIOR")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox4.Text) And Val(Form1.TextBox4.Text) > 0) Then
                CKILO(KW) = Form1.TextBox4.Text
            Else
                MsgBox("PARA CONTINUAR, DEBE COLOCAR SU CONSUMO DE ENERGIA EN kW")
                Form1.TextBox1.Focus() : Exit Sub
            End If

            If (IsNumeric(Form1.TextBox4.Text) And (Val(Form1.TextBox4.Text) > 0 And Val(Form1.TextBox4.Text) <= 100)) Then
                Select Case (Form1.ComboBox1.SelectedIndex)
                    Case 0 : SERVICIO(KW) = Round(CKILO(KW) * resi1, 2)
                    Case 1 : SERVICIO(KW) = Round(CKILO(KW) * indus1, 2)
                    Case Else
                        MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE SERVICIO")
                        Form1.TextBox1.Focus() : Exit Sub
                End Select
            End If
            If (IsNumeric(Form1.TextBox4.Text) And (Val(Form1.TextBox4.Text) > 100 And Val(Form1.TextBox4.Text) <= 300)) Then
                Select Case (Form1.ComboBox1.SelectedIndex)
                    Case 0 : SERVICIO(KW) = Round(CKILO(KW) * resi2, 2)
                    Case 1 : SERVICIO(KW) = Round(CKILO(KW) * indus2, 2)
                    Case Else
                        MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE SERVICIO")
                        Form1.TextBox1.Focus() : Exit Sub
                End Select
            End If
            If (IsNumeric(Form1.TextBox4.Text) And Val(Form1.TextBox4.Text) > 300) Then
                Select Case (Form1.ComboBox1.SelectedIndex)
                    Case 0 : SERVICIO(KW) = Round(CKILO(KW) * resi3, 2)
                    Case 1 : SERVICIO(KW) = Round(CKILO(KW) * indus3, 2)
                    Case Else
                        MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE SERVICIO")
                        Form1.TextBox1.Focus() : Exit Sub
                End Select
            End If

            TIPOSERVICIO(KW) = Form1.ComboBox1.Text

            TARIFA(KW) = Form1.ComboBox2.Text

            PARCIAL(KW) = SALDOA(KW) + SERVICIO(KW)
            TOTAL(KW) = PARCIAL(KW) - TIPOTARIFA(KW) + RECARGO(KW)
            If Val(Form1.TextBox3.Text) > 0 Then
                RECARGO(KW) = Val(Form1.TextBox3.Text) * 0.02
            End If
            Select Case (Form1.ComboBox2.SelectedIndex)
                Case 0 : TIPOTARIFA(KW) = Round((TOTAL(KW) + RECARGO(KW)) * 0.2, 2)
                Case 1 : TIPOTARIFA(KW) = Round(PARCIAL(KW) * 0.1, 2)
                Case Else
                    MsgBox("PARA CONTINUAR, DEBE SELECCIONAR UN TIPO DE TARIFA")
                    Form1.TextBox1.Focus() : Exit Sub
            End Select

            DESC1(KW) = PARCIAL(KW)
            DESC2(KW) = PARCIAL(KW) - TIPOTARIFA(KW) + RECARGO(KW)
            Form1.DataGridView1.Rows.Add(NOMBRE(KW), Str(NIT(KW)), Str(SALDOA(KW)), Str(SERVICIO(KW)), TIPOSERVICIO(KW), TARIFA(KW), DESC1(KW), RECARGO(KW), TIPOTARIFA(KW), DESC2(KW))
            KW = KW + 1
        End If
        If KW = 10 Then
            MsgBox("BORRE TODO, LOS VECTORES ESTAN LLENOS")
        End If
    End Sub
End Module