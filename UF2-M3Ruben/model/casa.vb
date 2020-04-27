Public Class casa
    Private paja As String
    Private madera As String
    Private ladrillo As String

    Public Sub New()
        Me.setpaja(0)
        Me.setmadera(0)
        Me.setladrillo(0)
    End Sub

    Public Sub setpaja(paja As String)
        Me.paja = paja
    End Sub

    Public Sub setmadera(madera As String)
        Me.madera = madera
    End Sub

    Public Sub setladrillo(madera As String)
        Me.ladrillo = ladrillo
    End Sub
    Public Function getpaja() As String
        Return Me.paja
    End Function

    Public Function getmadera() As String
        Return Me.madera
    End Function

    Public Function getladrillo() As String
        Return Me.ladrillo
    End Function

    Public Function destruir() As String
        Return "(" & Me.getpaja() & " " & Me.getmadera() & ")"
    End Function
End Class
