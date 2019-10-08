Public Class Form1

    Dim resultado As Integer
    Dim num1 As Integer
    Dim num2 As Integer
    Dim op1 As String







    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text = 1

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox1.Text = 2

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If num1 >= 0 Then
            num2 = TextBox1.Text
        Else num1 = TextBox1.Text

        End If
        op1 = "+"
        TextBox1.Clear()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        resultado = num1 + op1 + num2
        TextBox1.Text = resultado

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
