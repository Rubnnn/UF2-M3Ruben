Public Class cerdo
    'Propiedas De los cerdos
    Private mayor As String
    Private mediano As String
    Private menor As String


    Public Sub New()
        Me.setmayor(0)
        Me.setmediano(0)
        Me.setmenor(0)
    End Sub

    Public Sub setmayor(mayor As String)
        Me.mayor = mayor
    End Sub

    Public Sub setmediano(mediano As String)
        Me.mediano = mediano
    End Sub

    Public Sub setmenor(menor As String)
        Me.menor = menor
    End Sub

    Public Sub New(setmayor As String, setmediano As String, setmenor As String)
        Me.setmayor(mayor)
        Me.setmediano(mediano)
        Me.setmenor(menor)
    End Sub

    Public Function getmayor() As String
        Return Me.mayor
    End Function

    Public Function getmediano() As String
        Return Me.mediano
    End Function

    Public Function getmenor() As String
        Return Me.menor
    End Function

    Public Sub mover(c As cerdo)
        Me.setmayor(c.getmayor())
        Me.setmediano(c.getmediano())
        Me.setmenor(c.getmenor())
    End Sub

    Public Function construir(casa1 As casa, casa2 As casa, casa3 As casa) As String
        Return "(" & Me.getmenor() & "," & Me.getmediano() & "," & Me.getmayor() & ")"
    End Function

End Class
