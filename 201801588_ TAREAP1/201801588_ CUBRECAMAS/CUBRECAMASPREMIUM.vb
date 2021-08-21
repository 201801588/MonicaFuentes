Public Class CUBRECAMASPREMIUM
    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        Else
            Limpiarentradas()
        End If
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        Limpiarentradas()
    End Sub

    Private Sub LINO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LINO.CheckedChanged
        If (LINO.Checked) Then
            TEXTLINO.Visible = True
            TEXTLINO.Focus()
        Else
            TEXTLINO.Clear()
            TEXTLINO.Visible = False
        End If
    End Sub

    Private Sub ALGODÓN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALGODÓN.CheckedChanged
        If (ALGODÓN.Checked) Then
            TEXTALGODÓN.Visible = True
            TEXTALGODÓN.Focus()
        Else
            TEXTALGODÓN.Clear()
            TEXTALGODÓN.Visible = False
        End If
    End Sub

    Private Sub CHECKSEDA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHECKSEDA.CheckedChanged
        If (CHECKSEDA.Checked) Then
            TEXTSEDA.Visible = True
            TEXTSEDA.Focus()
        Else
            TEXTSEDA.Clear()
            TEXTSEDA.Visible = False
        End If
    End Sub

    Private Sub HILOCRUDO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HILOCRUDO.CheckedChanged
        If (HILOCRUDO.Checked) Then
            TEXTHILOCRUDO.Visible = True
            TEXTHILOCRUDO.Focus()
        Else
            TEXTHILOCRUDO.Clear()
            TEXTHILOCRUDO.Visible = False
        End If
    End Sub
    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click
        TOTALMATERIALES = Val(TEXTLINO.Text) + Val(TEXTALGODÓN.Text) + Val(TEXTSEDA.Text) + Val(TEXTHILOCRUDO.Text)
        If IMPERIAL.Checked Then
            If TOTALMATERIALES <= 3 Then
                SUMA = CUBRECAMAI + (Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO)
                TEXTMANODEOBRA.Text = Val(IMPERIAL)
                TEXTMATERIALES.Text = Math.Round((Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO), 2)
                TEXTCOSTO.Text = Math.Round(Val(SUMA) + Val(TEXTMANODEOBRA.Text), 2)
                TEXTPRECIO.Text = Math.Round(Val(TEXTCOSTO.Text) * 0.65 + Val(TEXTCOSTO.Text), 2)
            Else
                MsgBox("SOLO SE PUEDEN UTILIZAR 3 YARDAS DE LAS TELAS SELECCIONADAS PARA CUBRECAMA IMPERIAL")
                TEXTLINO.Text = ""
                TEXTALGODÓN.Text = ""
                TEXTSEDA.Text = ""
                TEXTHILOCRUDO.Text = ""
                TEXTMANODEOBRA.Text = ""
                TEXTCOSTO.Text = ""
                TEXTPRECIO.Text = ""
                TEXTMATERIALES.Text = ""
                LINO.Checked = False
                ALGODÓN.Checked = False
                CHECKSEDA.Checked = False
                HILOCRUDO.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

        If MATRIMONIAL.Checked Then
            If TOTALMATERIALES <= 5 Then
                SUMA = CUBRECAMAM + (Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO)
                TEXTMANODEOBRA.Text = Val(CUBRECAMAI)
                TEXTMATERIALES.Text = Math.Round((Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO), 2)
                TEXTCOSTO.Text = Math.Round(Val(SUMA) + Val(TEXTMANODEOBRA.Text), 2)
                TEXTPRECIO.Text = Math.Round(Val(TEXTCOSTO.Text) * 0.65 + Val(TEXTCOSTO.Text), 2)
            Else
                MsgBox("SOLO SE PUEDEN UTILIZAR 5 YARDAS DE LAS TELAS SELECCIONADAS PARA CUBRECAMA MATRIMONIAL")
                TEXTLINO.Text = ""
                TEXTALGODÓN.Text = ""
                TEXTSEDA.Text = ""
                TEXTHILOCRUDO.Text = ""
                TEXTMANODEOBRA.Text = ""
                TEXTCOSTO.Text = ""
                TEXTPRECIO.Text = ""
                TEXTMATERIALES.Text = ""
                LINO.Checked = False
                ALGODÓN.Checked = False
                CHECKSEDA.Checked = False
                HILOCRUDO.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

        If QUEEN.Checked Then
            If TOTALMATERIALES <= 6 Then
                SUMA = CUBRECAMAQ + (Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO)
                TEXTMANODEOBRA.Text = Val(CUBRECAMAQ)
                TEXTMATERIALES.Text = Math.Round((Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO), 2)
                TEXTCOSTO.Text = Math.Round(Val(SUMA) + Val(TEXTMANODEOBRA.Text), 2)
                TEXTPRECIO.Text = Math.Round(Val(TEXTCOSTO.Text) * 0.65 + Val(TEXTCOSTO.Text), 2)
            Else
                MsgBox("SOLO SE PUEDEN UTILIZAR 6 YARDAS DE LAS TELAS SELECCIONADAS PARA CUBRECAMA QUEEN")
                TEXTLINO.Text = ""
                TEXTALGODÓN.Text = ""
                TEXTSEDA.Text = ""
                TEXTHILOCRUDO.Text = ""
                TEXTMANODEOBRA.Text = ""
                TEXTCOSTO.Text = ""
                TEXTPRECIO.Text = ""
                TEXTMATERIALES.Text = ""
                LINO.Checked = False
                ALGODÓN.Checked = False
                CHECKSEDA.Checked = False
                HILOCRUDO.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

        If KING.Checked Then
            If TOTALMATERIALES <= 7 Then
                SUMA = CUBRECAMAK + (Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO)
                TEXTMANODEOBRA.Text = Val(CUBRECAMAK)
                TEXTMATERIALES.Text = Math.Round((Val(TEXTLINO.Text) * MATLINO) + (Val(TEXTALGODÓN.Text) * MATALGODON) + (Val(TEXTSEDA.Text) * MATSEDA) + (Val(TEXTHILOCRUDO.Text) * MATHILOCRUDO), 2)
                TEXTCOSTO.Text = Math.Round(Val(SUMA) + Val(TEXTMANODEOBRA.Text), 2)
                TEXTPRECIO.Text = Math.Round(Val(TEXTCOSTO.Text) * 0.65 + Val(TEXTCOSTO.Text), 2)
            Else
                MsgBox("SOLO SE PUEDEN UTILIZAR 7 YARDAS DE LAS TELAS SELECCIONADAS PARA CUBRECAMA KING")
                TEXTLINO.Text = ""
                TEXTALGODÓN.Text = ""
                TEXTSEDA.Text = ""
                TEXTHILOCRUDO.Text = ""
                TEXTMANODEOBRA.Text = ""
                TEXTCOSTO.Text = ""
                TEXTPRECIO.Text = ""
                TEXTMATERIALES.Text = ""
                LINO.Checked = False
                ALGODÓN.Checked = False
                CHECKSEDA.Checked = False
                HILOCRUDO.Checked = False

                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If
    End Sub
End Class
