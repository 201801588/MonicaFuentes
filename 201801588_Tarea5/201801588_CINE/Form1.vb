Public Class Form1

    Private Sub BLIMPIAR_Click(sender As Object, e As EventArgs) Handles BLIMPIAR.Click
        LIMPIARENTRADAS()
    End Sub

    Private Sub BLIMPIARLISTAS_Click(sender As Object, e As EventArgs) Handles BLIMPIARLISTAS.Click
        LIMPIARLISTAS()
    End Sub

    Private Sub BSALIR_Click(sender As Object, e As EventArgs) Handles BSALIR.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            End
        Else
            Limpiarentradas()
            Limpiarlistas()
        End If
    End Sub

    Private Sub BACEPTAR_Click(sender As Object, e As EventArgs) Handles BACEPTAR.Click
        If INDICE < 9 Then
            VFUNCION(INDICE) = CBFUNCION.SelectedItem
            VCINE(INDICE) = CBCINE.SelectedItem
            VENTRADAS(INDICE) = TBENTRADAS.Text
            VSUBTOTAL(INDICE) = CALCULARSUBTOTAL(VCINE(INDICE), VFUNCION(INDICE)) * Val(TBENTRADAS.Text)
            VDESCUENTO1(INDICE) = CALCULARDESCUENTO1(VCINE(INDICE), VFUNCION(INDICE)) * Val(TBENTRADAS.Text)
            VDESCUENTO2(INDICE) = CALCULARDESCUENTO2(VSUBTOTAL(INDICE)) * VSUBTOTAL(INDICE)
            VTOTALAPAGAR(INDICE) = VSUBTOTAL(INDICE) - VDESCUENTO1(INDICE) - VDESCUENTO2(INDICE)


            CINE.Items.Add(VCINE(INDICE))
            FUNCIÓN.Items.Add(VFUNCION(INDICE))
            ENTRADAS.Items.Add(VENTRADAS(INDICE))
            SUBTOTAL.Items.Add(VSUBTOTAL(INDICE))
            DESCUENTO1.Items.Add(VDESCUENTO1(INDICE))
            DESCUENTO2.Items.Add(VDESCUENTO2(INDICE))
            TOTAL.Items.Add(VTOTALAPAGAR(INDICE))
            INDICE = INDICE + 1
        ElseIf INDICE >= 9 Then
            MsgBox("LÍMITE DE DATOS SOBREPASADO")
        End If
    End Sub
End Class
