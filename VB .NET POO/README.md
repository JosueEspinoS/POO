# Guía Rápida Visual Basic
####  Primer programa con VB
 ```
Module VBModule 
 
    Sub Main() 
        Console.WriteLine("Hello World! desde VB")  
        Console.ReadLine()  
    End Sub 
  
End Module
 ```
###### Explicación:

> **Module VBModule**: Le dice a la computadora que esta parte del programa VB es llamdo VBModule.
 
> **Sub Main()**: Define una función principal que se ejecuta primero. Este es un método principal que es el punto de entrada para ejecutar el programa Visual Basic.

> **Console.WriteLine()** : Este es un método para mostrar el resultado de salida.

> **Console.ReadLine()**: Este es un método para pausar la pantalla y se asegura de
ver el resultado de salida. De lo contrario, el resultado de salida se omitirá.

> **End Sub** define el final de la sección de código principal.

> **End Module** define el final de este programa VB.

> Los comentarios se establecen utilizando **'** 


#### Crear un objeto(Instanciación de objetos)

```
Private identificador As tipo = new tipo()
```

Ejemplo 
 ```
 perrito As Perro = New Perro()
 ```

#### Constructor se ejecuta al instanciar la clase
```
Public Sub New(nombre As String, raza As String, altura  As String)
    Me.nombre = nombre
    Me.raza = raza
    Me.altura = altura
End Sub
```


#### Métodos habituales 
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

#### Creación Clase Persona
```
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
```
#### Clase Cliente heredando de SuperClase Persona
```
Public Class Cliente
    Inherits Persona
    'Atributos
    Private _categoria As String
    Private _codigo As String

    'propiedades
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    'operaciones o métodos
    Public Sub generarCodigo()
        Me.Codigo="C"&Me.Apellidos.Substring(0,3)&"16"
    End Sub
End Class
```

#### Tipo de Datos
VB tiene dos categorías de tipos de datos:
- Tipos de valores: enteros, números, decimales, caracteres, booleanos
- Tipos de referencia: objeto, cadena

![Tipos de datos](/images/dataType.png)



#### Variables
Una variable es un contenedor que contiene valores que se utilizan en un programa de VB, una
variable representa una ubicación de almacenamiento escrita.
```
Dim variable As dataType = value
```

“**Dim** variable **As** dataType = value” se utiliza para definir una variable y su valor.

**Ejemplo**:
```
Dim name As String = Smith
Dim age As Integer = 16
Dim b As Boolean = true
```
