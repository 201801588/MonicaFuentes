Module Module1
    Public INDICE As Byte = 0
    Public EDAD(6)
    Public GENERO(6)
    Public CODIGO(6)
    Public MONTO(6)
    Public TALLER(6)
    Public TOTALPARCIAL = 0
    Sub INICIO()
        Form1.TBEDAD.Clear()
        Form1.TBMONTO.Clear()
        Form1.TBDEDU.Clear()
        Form1.CBCODIGO.Text = ""
        Form1.CBGENERO.Text = ""
        Form1.CBTALLER.Text = ""
    End Sub
    Sub LIMPIARE()
        Form1.TB1825.Clear()
        Form1.TB25.Clear()
        Form1.TBEXT.Clear()
        Form1.TBFEM.Clear()
        Form1.TBCOND.Clear()
        Form1.TBDAÑOS.Clear()
    End Sub
    Sub SALIR()
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            End
        Else
            INICIO()
            LIMPIARE()
        End If
    End Sub
End Module
