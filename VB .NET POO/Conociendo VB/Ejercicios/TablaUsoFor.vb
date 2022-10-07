Module VBModule1
    Sub Main()
        Dim x As Integer 
        Dim factor As Integer = 9
        For x= 1 to 10
            Console.WriteLine(CStr(x) +"x"+ CStr(factor)+" = "+ CStr(x*factor))
        Next
        Console.ReadLine()


    End Sub

    'Output
        '
        '1x9 = 9
        '2x9 = 18
        '3x9 = 27
        '4x9 = 36
        '5x9 = 45
        '6x9 = 54
        '7x9 = 63
        '8x9 = 72
        '9x9 = 81
        '10x9 = 90

End Module