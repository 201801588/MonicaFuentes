Module Module1
    Sub Limpiarentradas()
        Form1.TEXTCHEQUEOTRO.Clear()
        Form1.TEXTCHEQUEPROPIO.Clear()
        Form1.TEXTEFECTIVO.Clear()
        Form1.TEXTINTERES.Clear()
        Form1.TEXTMONTOTOTAL.Clear()
        Form1.TEXTNUEVOSALDO.Clear()
        Form1.TEXTSALDOANTERIOR.Clear()
        Form1.BUTTONAHORRO.Checked = False
        Form1.BUTTONMONETARIOPREMIER.Checked = False
        Form1.BUTTONMONETARIOS.Checked = False
        Form1.CHECKCHEQUEPROPIO.Checked = False
        Form1.CHECKEFECTIVO.Checked = False
        Form1.CHECKOTROBANCO.Checked = False
    End Sub
    Public CHEQUEPROPIO As Byte, OTROBANCO As Byte, AHORRO As Byte
    Public MONETARIO As Double, MONETARIOPREMIER As Double, EFECTIVO As Double
    Public INTERESGENERADO As Double, INTERESANTERIOR As Double
    Public SALDONUEVO As Double
End Module
