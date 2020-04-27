Public Class EjercicioPunto
    Dim p1 As New Punto()
    Dim p2 As New Punto()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p1.setX(CInt(TextBox1.Text))
        p1.setY(CInt(TextBox2.Text))
        p2.setX(CInt(TextBox3.Text))
        p2.setY(CInt(TextBox4.Text))

        p1.desplazar(p2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        p1.setX(CInt(TextBox1.Text))
        p1.setY(CInt(TextBox2.Text))
        p2.setX(CInt(TextBox3.Text))
        p2.setY(CInt(TextBox4.Text))

        TextBox5.Text = p1.distancia(p2)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        p1.setX(CInt(TextBox1.Text))
        p1.setY(CInt(TextBox2.Text))
        p2.setX(CInt(TextBox3.Text))
        p2.setY(CInt(TextBox4.Text))

        If p1.Iguales(p2) Then
            TextBox5.Text = "Los numeros son iguales"
        Else
            TextBox5.Text = "Los numeros no son iguales"
        End If

    End Sub
End Class
