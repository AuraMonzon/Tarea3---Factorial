Public Class Form1


    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim texto = TextBoxIngreso.Text 'recoge la opción que ingresó el usuario
        If Not (texto = "") Then 'valida que se ejecute el programa solo cuando el usuario ingresó algo
            Dim opcionInt = Int32.Parse(texto) 'convierte ese texto en un numero
            Dim i, j, n As Integer
                j = 1
                n = opcionInt
            'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n
            For i = 1 To n Step 1
                j = j * i
                resultadoFactorial.Text = j.ToString
            Next
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        TextBoxIngreso.Text = ""
        resultadoFactorial.Text = ""
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MsgBox("Se va a cerrar el programa")
        Me.Close()
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
