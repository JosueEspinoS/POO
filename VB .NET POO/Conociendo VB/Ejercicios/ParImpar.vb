Module VBModule
    Sub main()
        Dim a As Integer = 28
        Dim b As Integer = 29

        Dim result1 As String = IIf(a mod 2 <>0, "a es impar","a es par")
        Console.WriteLine("El resultado es: " + result1)

        Dim result1 As String = IIf(b mod 2 <>0, "b es impar","b es par")
        Console.WriteLine("El resultado es: " + result1)
        Console.ReadLine()
    End Sub
End Module