Public Class Form1

    Dim resultado As Double
    Dim num1 As Double
    Dim num2 As Double
    Dim op1 As Integer



    'Si pones num como "9" son letras y a la salida Cint para que sean nume y sumarlos



    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "0"
        Else TextBox1.Text = 0

        End If


        ' TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text = TextBox1.Text + "1"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox1.Text = TextBox1.Text + "2"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        num1 = CDbl(TextBox1.Text)
        op1 = 1

        TextBox1.Clear()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num1 = CDbl(TextBox1.Text)
        op1 = 2
        TextBox1.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num1 = CDbl(TextBox1.Text)
        op1 = 3
        TextBox1.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num1 = CDbl(TextBox1.Text)
        op1 = 4
        TextBox1.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        num2 = CDbl(TextBox1.Text)
        If op1 = 1 Then
            resultado = num1 + num2
        ElseIf op1 = 2 Then
            resultado = num1 - num2
        ElseIf op1 = 3 Then
            resultado = num1 * num2
        ElseIf op1 = 4 Then
            resultado = num1 / num2
        End If


        '   resultado = num1 + num2
        TextBox1.Text = resultado

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text >= 0 Then

            TextBox1.Text = TextBox1.Text + ","

        End If

    End Sub
End Class
