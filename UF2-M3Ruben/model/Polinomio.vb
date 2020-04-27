Public Class Polinomio
    Private x0 As Double
    Private x1 As Double
    Private a As Integer
    Private b As Integer
    Private c As Integer

    Public Sub New(a As Integer, b As Integer, c As Integer)
        Me.seta(a)
        Me.setb(b)
        Me.setc(c)
        Me.setx0(x0)
        Me.setx1(x1)
    End Sub

    Public Sub New()

    End Sub

    Public Sub seta(a As Integer)
        Me.a = a
    End Sub

    Public Sub setb(b As Integer)
        Me.b = b
    End Sub

    Public Sub setc(c As Integer)
        Me.c = c
    End Sub

    Public Sub setx0(x0 As Double)
        Me.x0 = x0
    End Sub

    Public Sub setx1(x1 As Double)
        Me.x1 = x1
    End Sub

    Public Function geta() As Integer
        Return Me.a
    End Function

    Public Function getb() As Integer
        Return Me.b
    End Function

    Public Function getc() As Integer
        Return Me.c
    End Function

    Public Function getx0() As Integer
        Return Me.x0
    End Function

    Public Function getx1() As Integer
        Return Me.x1
    End Function


    Public Function sumaPolinomio(poli As Polinomio)
        Return New Polinomio(Me.geta() + poli.geta(), Me.getb() + poli.getb(), Me.getc() + poli.getc())
    End Function

    Public Function igualPolinomio(poli As Polinomio)
        Return Me.geta() = poli.geta() And Me.getb() = poli.getb() And Me.getc() = poli.getc()
    End Function

    Public Function solucionPolinomio() As Double
        Return Me.setx0((-Me.b + Math.Sqrt(Me.b * Me.b - 4 * Me.a * Me.c)) / (2 * Me.a))
    End Function

    ' Me.setx1((-Me.b - Math.Sqrt(Me.b * Me.b - 4 * Me.a * Me.c)) / (2 * Me.a))

End Class
