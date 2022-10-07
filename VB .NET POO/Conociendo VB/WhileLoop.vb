Module VBModule1


    Sub Main()
        Dim counter As Integer = 0
        While (counter<8)
            Console.Write("Hello World! ")
            counter+=1
            Console.WriteLine(counter)
        End While
        Console.WriteLine("Contador Final = " & counter)
    End Sub

    'Output
        '
        'Hello World! 1
        'Hello World! 2
        'Hello World! 3
        'Hello World! 4
        'Hello World! 5
        'Hello World! 6
        'Hello World! 7
        'Hello World! 8
        'Contador Final = 8

End Module