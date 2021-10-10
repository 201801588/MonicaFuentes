Imports System.Math
Public Class Form1
    Private Sub BCALCULAR_Click(sender As Object, e As EventArgs) Handles BCALCULAR.Click
        If CBCODIGO.Text = "" Or CBGENERO.Text = "" Or CBTALLER.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS DISPONIBLES")
            TBEDAD.Focus()
        ElseIf TBEDAD.Text = "" Or TBMONTO.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS DISPONIBLES")
            TBEDAD.Focus()
        ElseIf (INDICE <= 6) Then
            EDAD(INDICE) = Val(TBEDAD.Text)
            GENERO(INDICE) = CBGENERO.Text
            CODIGO(INDICE) = CBCODIGO.Text
            MONTO(INDICE) = Val(TBMONTO.Text)
            TALLER(INDICE) = CBTALLER.Text
            INDICE = INDICE + 1
            INICIO()
        End If
        If (INDICE >= 7) Then
            MsgBox("REGISTRO COMPLETO")
        End If
    End Sub

    Private Sub BMOSTRAR_Click(sender As Object, e As EventArgs) Handles BMOSTRAR.Click
        Dim VIEW As Byte
        DataGridView1.Rows.Clear()
        For VIEW = 0 To 6
            If EDAD(VIEW) <> Nothing Then
                DataGridView1.Rows.Add(EDAD(VIEW), GENERO(VIEW), CODIGO(VIEW), MONTO(VIEW), TALLER(VIEW))
            Else
                Exit For
            End If
        Next VIEW
    End Sub

    Private Sub BLIMPIARV_Click(sender As Object, e As EventArgs) Handles BLIMPIARV.Click
        Dim LIMPIAR As Byte
        For LIMPIAR = 0 To 6
            EDAD(LIMPIAR) = Nothing
            GENERO(LIMPIAR) = Nothing
            CODIGO(LIMPIAR) = Nothing
            MONTO(LIMPIAR) = Nothing
            TALLER(LIMPIAR) = Nothing
        Next LIMPIAR
        MsgBox("VECTORES BORRADOS EXITOSAMENTE")
        DataGridView1.Rows.Clear()
        TBDEDU.Clear()
        INDICE = 0
        INICIO()
    End Sub
    Private Sub BSALIR_Click(sender As Object, e As EventArgs) Handles BSALIR.Click
        SALIR()
    End Sub

    Private Sub BDEDU_Click(sender As Object, e As EventArgs) Handles BDEDU.Click
        Dim TOTALDED As Integer
        For TOTALDED = 0 To DataGridView1.Rows.Count - 2
            TOTALPARCIAL = TOTALPARCIAL + Val(DataGridView1.Rows(TOTALDED).Cells(3).Value)

        Next TOTALDED
        TBDEDU.Text = Str(TOTALPARCIAL) * 0.06
    End Sub

    Private Sub BESTA_Click(sender As Object, e As EventArgs) Handles BESTA.Click
        Dim MEN As Byte
        Dim FEM As Byte = 0
        Dim MAS As Byte = 0
        Dim EXT As Byte = 0
        Dim TOTALY As Byte = 0
        For MEN = 0 To 6
            If (EDAD(MEN) > 0 And EDAD(MEN) > 24) Then
                MEN = (MEN + 1)
            End If
            If (GENERO(MEN) = "F") Then
                FEM = (FEM + 1)
            End If
            If (GENERO(MEN) = "M") And (EDAD(MEN) >= 18 And EDAD(MEN) <= 25) Then
                MAS = (MAS + 1)
            End If
            If (CODIGO(MEN) = "0 (EXTRANJERO)") Then
                EXT = (EXT + 1)
            End If
        Next MEN
        TB25.Text = Str(MEN) / INDICE
        TBFEM.Text = Str(FEM) / INDICE
        TB1825.Text = Str(MAS) / INDICE
        TBEXT.Text = Str(EXT) / INDICE
        TBCOND.Text = INDICE
        TBDAÑOS.Text = TOTALPARCIAL
    End Sub

    Private Sub BLIMPIARES_Click(sender As Object, e As EventArgs) Handles BLIMPIARES.Click
        LIMPIARE()
        MsgBox("CAMPOS BORRADOS EXITOSAMENTE")
    End Sub
End Class
