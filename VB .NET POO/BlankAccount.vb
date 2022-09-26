'Declaracion clase BlankAccount
Class BlankAccount
    'Hacemos privada
    Private AccountNumber As String
    Private AccountBalance As Decimal
    'metodo publico para calcular balance 
    Public Sub UpdateBalance()

    End Sub

    ReadOnly Property Balance() As Decimal
        Get
            Return AccountBalance
        End Get
    End Property
End Class