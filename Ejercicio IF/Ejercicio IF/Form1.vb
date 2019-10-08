Public Class Form1

    Dim caja1 As Integer
    Dim caja2 As Integer
    Dim caja3 As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        entrada()


        If caja1 > caja2 And caja1 > caja3 Then
            TextBox4.Text = caja1.ToString

        End If
        If caja1 > caja2 And caja1 < caja3 Then
            TextBox5.Text = caja1.ToString

        End If
        If caja1 < caja2 And caja1 > caja3 Then
            TextBox5.Text = caja1.ToString

        End If
        If caja1 < caja2 And caja1 < caja3 Then
            TextBox6.Text = caja1.ToString

        End If
        If caja2 > caja1 And caja2 > caja3 Then
            TextBox4.Text = caja2.ToString

        End If
        If caja2 > caja1 And caja2 < caja3 Then
            TextBox5.Text = caja2.ToString

        End If
        If caja2 < caja1 And caja2 > caja3 Then
            TextBox5.Text = caja2.ToString

        End If
        If caja2 < caja1 And caja2 < caja3 Then
            TextBox6.Text = caja2.ToString

        End If
        If caja3 > caja1 And caja3 > caja2 Then
            TextBox4.Text = caja3.ToString

        End If
        If caja3 > caja1 And caja3 < caja2 Then
            TextBox5.Text = caja3.ToString

        End If
        If caja3 < caja1 And caja3 > caja2 Then
            TextBox5.Text = caja3.ToString

        End If
        If caja3 < caja1 And caja3 < caja2 Then
            TextBox6.Text = caja3.ToString

        End If



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub entrada()
        caja1 = CInt(TextBox1.Text)
        caja2 = CInt(TextBox2.Text)
        caja3 = CInt(TextBox3.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If 
                n1 > n2 And n1 > n3 Then
            caja1 = n1
            If
                n2 > n3 Then
                caja2 = n2
                caja3 = n3
            Else


                ElseIf n2 > n1 And n2 > n3 Then
            Else


            End If







    End Sub
End Class
