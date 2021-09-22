Public Class Form1

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIARENTRADAS()
    End Sub

    Private Sub LIMPIARLISTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARLISTASToolStripMenuItem.Click
        LIMPIARLISTAS()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        SALIR()
    End Sub

    Private Sub CEFECTIVO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEFECTIVO.CheckedChanged
        If (CEFECTIVO.Checked) Then
            TBEFECTIVO.Visible = True
            TBEFECTIVO.Focus()
        Else
            TBEFECTIVO.Clear()
            TBEFECTIVO.Visible = False
        End If
    End Sub

    Private Sub CTARJETA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTARJETA.CheckedChanged
        If (CTARJETA.Checked) Then
            TBTARJETA.Visible = True
            TBTARJETA.Focus()
        Else
            TBTARJETA.Clear()
            TBTARJETA.Visible = False
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESOSToolStripMenuItem.Click
        If INDICE < 5 Then
            If TBNIT.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NIT")
                TBNIT.Focus() : Exit Sub
            End If
            If TBPLACA.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NUMERO DE PLACA")
                TBPLACA.Focus() : Exit Sub
            End If
            If CBMARCA.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UNA MARCA DE AUTO")
                CBMARCA.Focus() : Exit Sub
            End If
            If TBDIAS.Text = "" Then
                MsgBox("PARA CONTINUAR, DEBE COLOCAR UN NUMERO DE DIAS A ALQUILAR")
                TBDIAS.Focus() : Exit Sub
            End If
            If (CEFECTIVO.Checked = False) And (CTARJETA.Checked = False) Then
                MsgBox("DEBE SELECCIONAR UN METODO DE PAGO")
                Exit Sub
            Else
                If (CEFECTIVO.Checked = True And CTARJETA.Checked = True) And ((Val(TBEFECTIVO.Text) + Val(TBTARJETA.Text) = CALCULOSUBTOTAL)) Then
                    CALCULODESREC = 0
                    CALCULOTOTAL = CALCULARPARCIAL(VSUBTOTAL(INDICE)) + CALCULODESREC
                ElseIf (CEFECTIVO.Checked = True And (Val(TBEFECTIVO.Text) = CALCULARPARCIAL(CALCULOSUBTOTAL))) Then
                    CALCULODESREC = CALCULARPARCIAL(VSUBTOTAL(INDICE)) * 0.05
                    CALCULOTOTAL = CALCULARPARCIAL(VSUBTOTAL(INDICE)) - CALCULODESREC
                ElseIf (CTARJETA.Checked = True And (Val(TBTARJETA.Text) = CALCULARPARCIAL(CALCULOSUBTOTAL))) Then
                    CALCULODESREC = CALCULARPARCIAL(VSUBTOTAL(INDICE)) * 0.025
                    CALCULOTOTAL = CALCULARPARCIAL(VSUBTOTAL(INDICE)) + CALCULODESREC
                Else
                    MsgBox("DEBE SUMAR EL 100% DEL PRECIO TOTAL ENTRE AMBOS MÉTODOS DE PAGO O UTILICE SOLO METODO DE PAGO")
                    TBEFECTIVO.Text = ""
                    TBTARJETA.Text = ""
                    Exit Sub
                End If
            End If

            VPLACA(INDICE) = TBPLACA.Text
            VMARCA(INDICE) = CBMARCA.SelectedItem
            VSUBTOTAL(INDICE) = CALCULARPARCIAL(VSUBTOTAL(INDICE))
            VTOTALAPAGAR(INDICE) = CALCULOTOTAL
            VDESCUENTO(INDICE) = CALCULODESREC
            VDIAS(INDICE) = TBDIAS.Text
        End If

            PLACA.Items.Add(VPLACA(INDICE))
            MARCA.Items.Add(VMARCA(INDICE))
            DIASDEALQUILER.Items.Add(VDIAS(INDICE))
            SUBTOTAL.Items.Add(VSUBTOTAL(INDICE))
        DESREC.Items.Add(VDESCUENTO(INDICE))
            TOTALAPAGAR.Items.Add(VTOTALAPAGAR(INDICE))
            INDICE = INDICE + 1
            If INDICE >= 5 Then
                MsgBox("LÍMITE DE DATOS SOBREPASADO")
            End If
    End Sub
End Class