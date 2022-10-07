Module VBModule
    Sub Main()
        Dim x As Boolean = True
        Dim y As Boolean = False
        Dim a As Boolean = x And y
        Console.WriteLine(a)    'output false

        Dim b As Boolean = x Or y
        Console.WriteLine(b)    'output true

        Dim c As Boolean = Not x
        Console.WriteLine(c)    'output false
    End Sub
End Module
