Public Class Form1


    Dim num1 As Integer = 1
    Dim num2 As Integer = 1
    Dim caja As Integer
    Dim i As Integer = 3
    Dim variable As Integer = 0



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Integer
        caja = CInt(TextBox1.Text)


        ' If caja = 1 Then
        'TextBox2.Text = 1
        'ElseIf caja = 2 Then
        'TextBox2.Text = 1 & vbNewLine & 1

        'End If
        TextBox2.Text = num1 & vbNewLine & num2 & vbNewLine

        While i <= caja
            resultado = num1 + num2
            num2 = num1
            num1 = resultado
            TextBox2.Text = TextBox2.Text & resultado & vbNewLine
            i += 1

        End While





    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As Integer
        TextBox2.Clear()
        caja = CInt(TextBox1.Text)
        For variable = 0 To caja - 1
            TextBox2.Text = TextBox2.Text & m & vbNewLine
            m = m + 2

        Next



    End Sub
End Class
