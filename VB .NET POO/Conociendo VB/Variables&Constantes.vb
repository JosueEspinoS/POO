Module VBModule
 
    Sub Main()
        Console.WriteLine("Hello, world!")
        'Salto de linea "vbCrLf"
        'Una variable es un contenedor que contiene valores que se utilizan en un programa VB; un variable representa una ubicación de almacenamiento con tipo.

        
        Dim name As String = "Pablo"
        Dim apMaterno As String = "Mostalac"
        Dim apPaterno As String = "Torres"
        Dim edad As Integer=30
        Console.WriteLine("Me llamo: "+name+" "+ apPaterno +" " + apMaterno + vbCrLf+"Tengo "+ CStr(edad)+ " Años" )
        ' 2 formas de definir una variable
        Dim x, y As Decimal 'define x, y
        y = 1.23456
        x = 50
        Dim suma1 As Decimal 
        suma1=x+y
        ' CStr() conversion  a String
        Console.WriteLine("La suma de: "+ CStr(x) + " + " + CStr(y) +"= "+ CStr(suma1))
        'CInt() Conversion a Integer
        Console.WriteLine("La suma de: "+ CStr(x) + " + " + CStr(y) +"= "+ CStr(CInt(suma1)))
        
        'Algunos símbolos pueden representar el tipo de datos de la variable, que es la buena de manera frecuentemente utilizada por programadores experimentados de VB.

        Dim num1 As Integer = 10
        Dim num2% = 5 'Simbolo que representa Integer "%"
        Dim suma2 As Integer = num1 + num2
        
        Console.WriteLine("La suma de: " + CStr(num1) + "+" + CStr(num2) + "=" + CStr(suma2))
        
        Dim i% = 100        'dim i as integer
        Dim s$ = "OK!"      'dim s as string
        Dim d@ = 100.123    'dim d as decimal
        Console.WriteLine(i)
        Console.WriteLine(s)
        Console.WriteLine(d)
        
        Dim b As Boolean = true
        Console.WriteLine(b)
        
        'Constante es un valor que nunca se puede cambiar
        'El nombre constante siempre se escribe en mayúsculas
        Const PI = 3.14159265
        Const BOOK As string = "Programando en VB"
        Console.WriteLine(PI)
        Console.WriteLine(BOOK)
    End Sub
  
End Module