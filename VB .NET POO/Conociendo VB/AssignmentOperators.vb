Module VBModule
    Sub Main()
        
        Dim x As Integer = 200
        Dim y As Integer = 100
        x += y
        Console.WriteLine(x)       'output 300

        x /= y
        Console.WriteLine(x)       'output 3

        x -= y
        Console.WriteLine(x)      'output -97
        
        Dim m As String = "abc"
        Dim n As String = "de"
        m &= n
        Console.WriteLine(m)      'output abcde
        Console.ReadLine()
           
    End Sub
End Module