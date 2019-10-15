Public Class Form1

    Dim n1 As Integer
    Dim n2 As Integer
    Dim salida As String


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Integer
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        For i As Integer = 0 To n2
            resultado = n1 * i
            salida = n1 & "x" & i & "=" & resultado
            TextBox3.Text = TextBox3.Text + salida + vbNewLine





        Next




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resultado As Integer
        Dim i As Integer = 0
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        While i <= n2
            resultado = n1 * i
            salida = n1 & "x" & i & "=" & resultado
            TextBox3.Text = TextBox3.Text + salida + vbNewLine
            i += 1

        End While


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim resultado As Integer
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        Dim i As Integer = 0
        Do
            resultado = n1 * i
            salida = n1 & "x" & i & "=" & resultado
            TextBox3.Text = TextBox3.Text + salida + vbNewLine
            i += 1

        Loop While i <= n2





    End Sub
End Class
