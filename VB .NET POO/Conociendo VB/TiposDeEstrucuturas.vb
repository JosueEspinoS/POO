'Un tipo de estructura es un tipo de valor que normalmente se usa para encapsular pequeños 
'grupos de variables relacionadas. La estructura es muy útil para estructuras de datos que tienen
'semántica de valor.

Module VBModule
 
    Sub Main()
        Public Structure Student '“Público” es un modificador de acceso. “Estudiante” es un tipo de estructura.
            Public id As Integer    '“id, nombre, edad” son tres campos de estructura.
            Public nombre As String
            Public edad As Integer
        End Structure       

        'La sintaxis para declarar una variable de estructura
        Dim Smith As Student

        
        'La sintaxis de acceso al campo de estructura:
        'StructureVariable.field
        'Ejemplo 
        '“Smith.id” significa el id de Smith.
        '“Smith.nombre” significa el nombre de Smith.
        '“Smith.edad” significa el edad de Smith.

        Public Structure Car      ' defines a structure type
            Public price As Integer     ' structure field
            Public size As String        ' structure field
            Public color As String       ' structure field
        End Structure

        Dim Ford As Car    'Car is a structure type . Ford is a structure variable
        
        'The syntax of access the structure field:

        '“Ford. price” means Ford’s price.
        '“Ford. size” means Ford’s size.
        '“Ford. color” means Ford’s color.



    End Sub
  
End Module