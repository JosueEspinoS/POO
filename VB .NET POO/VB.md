### Crear un objeto(Instanciación de objetos)

Private identificador As tipo = new tipo()

Ejemplo 
 ```perrito As Perro = New Perro()```

#### Constructor se ejecuta al instanciar la clase
```
Public Sub New(nombre As String, raza As String, altura  As String)
    Me.nombre = nombre
    Me.raza = raza
    Me.altura = altura
End Sub
```


##### Métodos habituales
```
Public Property Numero1 As Integer
    Get
        Return _numero1
    End GET
    Set(value)
        _numero1=value
    End Set
EndProperty
```