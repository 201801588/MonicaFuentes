Module Module1
    Public VPLACA(5)
    Public VMARCA(5)
    Public VDIAS(5)
    Public VSUBTOTAL(5)
    Public VDESCUENTO(5)
    Public VRECARGO(5)
    Public VTOTALAPAGAR(5)
    Public INDICE = 0
    Public CALCULODESREC As Decimal = 0
    Public CALCULOSUBTOTAL As Double = 0
    Public CALCULOTOTAL As Decimal = 0
    
    Sub LIMPIARLISTAS()
        Form1.PLACA.Items.Clear()
        Form1.MARCA.Items.Clear()
        Form1.DIASDEALQUILER.Items.Clear()
        Form1.SUBTOTAL.Items.Clear()
        Form1.DESREC.Items.Clear()
        Form1.TOTALAPAGAR.Items.Clear()
        INDICE = 0
        MsgBox("DATOS ALMACENADOS Y VECTORES BORRADOS EXITOSAMENTE")
    End Sub

    Sub LIMPIARENTRADAS()
        Form1.CBMARCA.SelectedIndex = -1
        Form1.CTARJETA.Checked = False
        Form1.CEFECTIVO.Checked = False
        Form1.TBDIAS.Clear()
        Form1.TBEFECTIVO.Clear()
        Form1.TBTARJETA.Clear()
        Form1.TBPLACA.Clear()
        Form1.TBNIT.Clear()
        MsgBox("DATOS BORRADOS EXITOSAMENTE")
    End Sub

    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            End
        Else
            LIMPIARENTRADAS()
            LIMPIARLISTAS()
        End If
    End Sub

    Function CALCULARPARCIAL(ByRef CALCULOSUBTOTAL As Double) As Double
        If Form1.CBMARCA.Text = "HONDA" Then
            CALCULOSUBTOTAL = 250 * Val(Form1.TBDIAS.Text)
        ElseIf Form1.CBMARCA.Text = "MERCEDES BENZ" Then
            CALCULOSUBTOTAL = 450 * Val(Form1.TBDIAS.Text)
        ElseIf Form1.CBMARCA.Text = "TOYOTA" Then
            CALCULOSUBTOTAL = 325 * Val(Form1.TBDIAS.Text)
        ElseIf Form1.CBMARCA.Text = "MAZDA" Then
            CALCULOSUBTOTAL = 300 * Val(Form1.TBDIAS.Text)
        End If
        Return CALCULOSUBTOTAL
    End Function
End Module
