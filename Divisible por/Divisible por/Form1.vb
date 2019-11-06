Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Decimal
        Dim n As Decimal
        Dim m As Decimal
        Dim cantidad As Decimal

        n = InputBox("Que nº quieres dividir")
        m = InputBox("Por cuanto quieres dividirlo")
        resultado = n

        While resultado >= m

            resultado = resultado / m
            cantidad = cantidad + 1


        End While

        MsgBox(cantidad)





    End Sub
End Class
