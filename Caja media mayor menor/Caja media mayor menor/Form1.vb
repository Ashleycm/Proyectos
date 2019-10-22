Public Class Form1


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As Integer
        Dim suma As Integer
        Dim total As Integer
        Dim media As Integer
        Dim menor As Integer = 999
        Dim mayor As Integer




        While n <> -1
            n = InputBox("Introduce nº")

            suma = suma + n
            total = total + 1
            media = suma / total

            If n > mayor Then
                mayor = n
            End If
            If n < menor Then
                menor = n
            End If


            MsgBox("Media:" & media & vbNewLine & "Menor:" & menor & vbNewLine & "Mayor:" & mayor)



        End While






    End Sub
End Class
