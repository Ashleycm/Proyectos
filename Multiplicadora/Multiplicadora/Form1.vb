Public Class Form1

    Dim n1 As Integer
    Dim n2 As Integer
    Dim salida As String


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        n1 = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        n2 = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        For i As Integer = 0 To n2
            resultado = n1 * i
            salida = n1 & "x" & i & "=" & resultado
            TextBox3.Text = TextBox3.Text + salida + vbNewLine





        Next




    End Sub
End Class
