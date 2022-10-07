Module Module1
    Sub Main()
        Dim num As Integer 'Define a variable num
        Dim a As Integer = 10   'Define variables a,b,c
        Dim b As Integer = 20
        Dim c As Integer = 30
        num = a * b * c
        'define a constant RESULT
        Const RESULT As String = "The results is: "
        Console.WriteLine(RESULT & num)
        Console.ReadLine()

    End Sub

End Module