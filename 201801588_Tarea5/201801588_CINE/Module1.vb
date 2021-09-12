Module Module1
    Public VCINE(8)
    Public VFUNCION(8)
    Public VENTRADAS(8)
    Public VSUBTOTAL(8)
    Public VDESCUENTO1(8)
    Public VDESCUENTO2(8)
    Public VTOTALAPAGAR(8)
    Public INDICE = 0
    Public CALCULODESCUENTO1 As Double = 0
    Public CALCULODESCUENTO2 As Double = 0
    Public CALCULOSUBTOTAL As Double = 0
    Public CALCULOTOTAL As Double = 0

    Sub LIMPIARLISTAS()
        Form1.CINE.Items.Clear()
        Form1.FUNCIÓN.Items.Clear()
        Form1.ENTRADAS.Items.Clear()
        Form1.SUBTOTAL.Items.Clear()
        Form1.DESCUENTO1.Items.Clear()
        Form1.DESCUENTO2.Items.Clear()
        Form1.TOTAL.Items.Clear()
        INDICE = 0
        MsgBox("DATOS ALMACENADOS Y VECTORES BORRADOS EXITOSAMENTE")
    End Sub
    Sub LIMPIARENTRADAS()
        Form1.CBCINE.SelectedIndex = -1
        Form1.CBFUNCION.SelectedIndex = -1
        Form1.TBENTRADAS.Clear()
        MsgBox("DATOS BORRADOS EXITOSAMENTE")
    End Sub

    Function CALCULARSUBTOTAL(CINE As String, FUNCION As String) As Double
        Select Case CINE
            Case "A"
                Select Case FUNCION
                    Case "1"
                        CALCULOSUBTOTAL = 30
                    Case "2"
                        CALCULOSUBTOTAL = 35
                    Case "3"
                        CALCULOSUBTOTAL = 40
                    Case Else
                        CALCULOSUBTOTAL = 40
                End Select
            Case "B"
                Select Case FUNCION
                    Case "1"
                        CALCULOSUBTOTAL = 24
                    Case "2"
                        CALCULOSUBTOTAL = 34
                    Case "3"
                        CALCULOSUBTOTAL = 44
                    Case Else
                        CALCULOSUBTOTAL = 44
                End Select
            Case "C"
                Select Case FUNCION
                    Case "1"
                        CALCULOSUBTOTAL = 35
                    Case "2"
                        CALCULOSUBTOTAL = 40
                    Case "3"
                        CALCULOSUBTOTAL = 50
                    Case Else
                        CALCULOSUBTOTAL = 50
                End Select
        End Select
        Return CALCULOSUBTOTAL
    End Function

    Function CALCULARDESCUENTO1(CINE As String, FUNCION As Double) As Double

        If (FUNCION = "3" Or FUNCION = "4") And (CINE = "C" Or CINE = "B") Then
            CALCULODESCUENTO1 = 0.055 * CALCULOSUBTOTAL
        ElseIf (FUNCION = "1") And (CINE = "C" Or CINE = "B") Then
            CALCULODESCUENTO1 = 0.03 * CALCULOSUBTOTAL
        ElseIf (FUNCION = "2") And (CINE = "A") Then
            CALCULODESCUENTO1 = 0.015 * CALCULOSUBTOTAL
        End If
        Return CALCULODESCUENTO1

    End Function

    Function CALCULARDESCUENTO2(VSUBTOTAL) As Double

        If (VSUBTOTAL >= 100) And (VSUBTOTAL <= 300) Then
            CALCULODESCUENTO2 = 0.02
        ElseIf (VSUBTOTAL > 300) And (VSUBTOTAL <= 500) Then
            CALCULODESCUENTO2 = 0.04
        ElseIf (VSUBTOTAL > 500) And (VSUBTOTAL <= 1000) Then
            CALCULODESCUENTO2 = 0.06
        End If
        Return CALCULODESCUENTO2

    End Function
End Module
