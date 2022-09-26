Public Class Persona
    'Atributos
    Private _nombres As String
    Private _apellidos As String
    Private _documento As String
    Private _tipo As String

    'propiedades /Encapsulacion 
    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property
    Public Property Nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property
    Public Property _Documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property
    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
End Class