Public Class carta
    Private palo As Integer
    Private numero As Integer

    Public Sub carta(palo As Integer, numero As Integer)
        Me.palo = palo
        Me.numero = numero
    End Sub

    Public Function getpalo() As Integer
        Return Me.palo
    End Function

    Public Sub setpalo(palo As Integer)
        Me.palo = palo
    End Sub

    Public Function getnumero() As Integer
        Return Me.numero
    End Function

    Public Sub setnumero(numero As Integer)
        Me.numero = numero
    End Sub

    Public Function mismonumero(carta) As Boolean
        If (Me.numero = carta.getnumero()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function toString(cadena As String) As String
        cadena = "Carta[palo=" + Me.palo + ", numero=" + Me.numero + "]"
        Return cadena
    End Function

    Public Function Valor() As Integer
        Select Case Me.numero
            Case 1 : Return 1
            Case 2 : Return 2
            Case 3 : Return 4
            Case 4 : Return 8
            Case 5 : Return 16
            Case 6 : Return 32
            Case 7 : Return 63
            Case 8 : Return 124
            Case 9 : Return 244
            Case 10 : Return 480
            Case 11 : Return 944
            Case 12 : Return 1856
                'En Default no encontre ninguna solucion asique coloque "Case 0"
            Case 0 : Return 3649
        End Select
    End Function
End Class
