Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1 As Integer = 0
        Dim num2 As Integer = 0

        Dim resultadopar As Integer
        Dim resultadoinpar As Integer


        While num1 <> -1 Or num2 <> -1
            num1 = InputBox("par")
            num2 = InputBox("inpar")

            resultadopar = resultadopar + num1
            resultadoinpar = resultadoinpar + num2


        End While
        MsgBox("Resultado=" & resultadopar - resultadoinpar)

    End Sub
End Class
