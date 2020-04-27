Public Class jugador
    Private id As Integer
    Private manosGanadas As Integer
    Private mano As mano
    Private descartadas As Integer
    Private puntuacion As Integer

    Public Sub jugador(id As Integer)
        Me.id = id
        Me.manosGanadas = 0
        Me.mano = New Mano()
        Me.descartadas = 5
        Me.puntuacion = 0

    End Sub

    Public Function getid() As Integer
        Return Me.id
    End Function

    Public Sub setid(id As Integer)
        Me.id = id
    End Sub

    Public Function getmanosGanadas() As Integer
        Return Me.manosGanadas
    End Function

    Public Sub setManosGanadas()
        Me.manosGanadas += 1
    End Sub

    Public Function getMano() As Integer
        Return Me.mano
    End Function

    Public Sub setMano(Mano As Mano)
        Me.mano = Mano
    End Sub

    Public Sub calcularJugada()
        Me.puntuacion = Me.mano.getValor()
    End Sub

    Public Sub cogerCartas(ArrayList<Carta> cartas)
        If (cartas.size() = 5) Then
            Me.mano.setCartas(cartas)
        Else
            For (carta c : cartas)
                    Me.mano.addCarta(c)
        End If
    End Sub

    Public Sub descartar()
        Me.descartadas = Me.mano.descartar()
    End Sub

    Public Function toString(cadena) As String
        cadena = "jugador["

        cadena += "ID:" + Me.id + ","
        cadena += "ManosGanadas:" + Me.manosGanadas + ","
        cadena += "Descartadas" + Me.descartadas + ","
        cadena += "Puntuación" + Me.puntuacion + ","
        cadena += Me.mano.toString()
        cadena += "]"

        Return cadena
    End Function

    Public Function getDescartadas()
        Return Me.descartadas
    End Function

    Public Sub setDescartadas(descartadas As Integer)
        Me.descartadas = descartadas
    End Sub

    Public Function getPuntuacion()
        Return Me.puntuacion
    End Function

    Public Sub setPuntuacion(puntuacion As Integer)
        Me.puntuacion = puntuacion

    End Sub







End Class
