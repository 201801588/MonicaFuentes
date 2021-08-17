Public Class Form1
    Private Sub BSALIR_Click(sender As Object, e As EventArgs) Handles BSALIR.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        Else
            Limpiarentradas()
        End If
    End Sub
    Private Sub BCALCULAR_Click(sender As Object, e As EventArgs) Handles BCALCULAR.Click
        If (TEXTSALDOANTERIOR.Text = "") Then
            MsgBox("DEBE INGRESAR EL MONTO DE SU SALDO ANTERIOR PARA PODER AVANZAR")
            TEXTSALDOANTERIOR.Focus()
        End If
        If BUTTONMONETARIOS.Checked = True Then
            SALDONUEVO = Val(TEXTCHEQUEOTRO.Text) + Val(TEXTCHEQUEPROPIO.Text) + Val(TEXTEFECTIVO.Text)
            TEXTNUEVOSALDO.Text = Val(SALDONUEVO) + Val(TEXTSALDOANTERIOR.Text)
            TEXTMONTOTOTAL.Text = Val(TEXTNUEVOSALDO.Text)
            TEXTINTERES.Text = "0"
        End If
        If BUTTONAHORRO.Checked = True Then
            TEXTNUEVOSALDO.Text = Val(TEXTCHEQUEOTRO.Text) + Val(TEXTCHEQUEPROPIO.Text) + Val(TEXTEFECTIVO.Text) + Val(TEXTSALDOANTERIOR.Text)
            Select Case Val(TEXTNUEVOSALDO.Text)
                Case 1 To 1000.99
                    INTERESANTERIOR = 1.5 / 100
                Case 1001 To 5000.99
                    INTERESANTERIOR = 2.5 / 100
                Case 5001 To 15000.99
                    INTERESANTERIOR = 7.5 / 100
                Case Is >= 15001
                    INTERESANTERIOR = 10 / 100
            End Select
            SALDONUEVO = (Val(TEXTCHEQUEOTRO.Text) + Val(TEXTCHEQUEPROPIO.Text) + Val(TEXTEFECTIVO.Text) + Val(TEXTSALDOANTERIOR.Text)) * INTERESANTERIOR
            TEXTINTERES.Text = Val(TEXTNUEVOSALDO.Text) * INTERESANTERIOR
            TEXTMONTOTOTAL.Text = Val(TEXTNUEVOSALDO.Text) + SALDONUEVO
        End If
        If BUTTONMONETARIOPREMIER.Checked = True Then
            Select Case Val(TEXTSALDOANTERIOR.Text)
                Case 1 To 10000.99
                    INTERESGENERADO = 2.5 / 100
                Case 10001 To 15000.99
                    INTERESGENERADO = 3 / 100
                Case Is >= 15001
                    INTERESGENERADO = 4.5 / 100
            End Select
            SALDONUEVO = Val(TEXTCHEQUEOTRO.Text) + Val(TEXTCHEQUEPROPIO.Text) + Val(TEXTEFECTIVO.Text) + Val(TEXTSALDOANTERIOR.Text) * INTERESGENERADO
            TEXTINTERES.Text = Val(TEXTSALDOANTERIOR.Text) * INTERESGENERADO
            TEXTNUEVOSALDO.Text = Val(SALDONUEVO)
            TEXTMONTOTOTAL.Text = Val(TEXTSALDOANTERIOR.Text) + Val(TEXTNUEVOSALDO.Text)
        End If
    End Sub

    Private Sub CHECKCHEQUEPROPIO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHECKCHEQUEPROPIO.CheckedChanged
        If (CHECKCHEQUEPROPIO.Checked) Then
            TEXTCHEQUEPROPIO.Visible = True
            TEXTCHEQUEPROPIO.Focus()
        Else
            TEXTCHEQUEPROPIO.Clear()
            TEXTCHEQUEPROPIO.Visible = False
        End If
    End Sub
    Private Sub CHECKOTROBANCO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHECKOTROBANCO.CheckedChanged
        If (CHECKOTROBANCO.Checked) Then
            TEXTCHEQUEOTRO.Visible = True
            TEXTCHEQUEOTRO.Focus()
        Else
            TEXTCHEQUEOTRO.Clear()
            TEXTCHEQUEOTRO.Visible = False
        End If
    End Sub
    Private Sub CHECKEFECTIVO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHECKEFECTIVO.CheckedChanged
        If (CHECKEFECTIVO.Checked) Then
            TEXTEFECTIVO.Visible = True
            TEXTEFECTIVO.Focus()
        Else
            TEXTEFECTIVO.Clear()
            TEXTEFECTIVO.Visible = False
        End If
    End Sub

    Private Sub BLIMPIAR_Click(sender As Object, e As EventArgs) Handles BLIMPIAR.Click
        Limpiarentradas()
    End Sub
End Class