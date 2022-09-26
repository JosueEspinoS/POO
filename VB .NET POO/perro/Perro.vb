Public Class Perro
    'propiedades
    Public nombre As String
    Public raza As String
    Public altura As String
    
    'Constructores
    Public Sub New()
        
    End Sub
    
    Public Sub New(nombre As String, raza As String, altura  As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
    
    Public Sub New(nombre As String, altura  As String)
        Me.nombre = nombre
        Me.altura = altura & "cm"
    End Sub
    
    'Metodos (Procedimientos o funciones)
    Public Sub dormir()
    
    End Sub
    
    Public Sub ladrar()
    
    End Sub
    
    Public Function comer (carne As String) As String
        Return Me.nombre & " mide " & Me.altura &" y comerá" & carne
    End Function
End Class



