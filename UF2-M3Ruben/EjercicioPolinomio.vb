Public Class EjercicioPolinomio
    Dim poli0 As New Polinomio()
    Dim poli1 As New Polinomio()
    Dim poli2 As New Polinomio()
    Dim x0 As Double
    Dim x1 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        poli0.seta(CInt(TextBox1.Text))
        poli0.setb(CInt(TextBox2.Text))
        poli0.setc(CInt(TextBox3.Text))
        poli1.seta(CInt(TextBox4.Text))
        poli1.setb(CInt(TextBox5.Text))
        poli1.setc(CInt(TextBox6.Text))

        poli2 = poli0.sumaPolinomio(poli1)
        TextBox7.Text = poli2.geta()
        TextBox8.Text = poli2.getb()
        TextBox9.Text = poli2.getc()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        poli0.seta(CInt(TextBox1.Text))
        poli0.setb(CInt(TextBox2.Text))
        poli0.setc(CInt(TextBox3.Text))
        poli1.seta(CInt(TextBox4.Text))
        poli1.setb(CInt(TextBox5.Text))
        poli1.setc(CInt(TextBox6.Text))


        If poli0.igualPolinomio(poli1) Then
            TextBox10.Text = "Si son iguales"
        Else
            TextBox10.Text = "No son iguales"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        poli0.seta(CInt(TextBox1.Text))
        poli0.setb(CInt(TextBox2.Text))
        poli0.setc(CInt(TextBox3.Text))

        Me.x0 = poli0.solucionPolinomio()

        TextBox11.Text = Me.x0
    End Sub
End Class