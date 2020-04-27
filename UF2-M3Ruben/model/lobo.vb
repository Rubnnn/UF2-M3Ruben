Public Class lobo
    Private lobof As String

    Public Sub New()
        Me.setlobof(0)
        Me.setlobof(0)
    End Sub

    Public Sub setlobof(lobof As String)
        Me.lobof = lobof
    End Sub


    Public Function getlobof() As String
        Return Me.lobof
    End Function


    Public Sub mover(lobof As lobo)
        Me.setlobof(lobof.getlobof())
    End Sub

    Public Function soplar(lobof As lobo)
        Return "(" & Me.getlobof() & ")"
    End Function

    Public Function morir(lobof As lobo)
        Return "(" & Me.getlobof() & ")"
    End Function

End Class
