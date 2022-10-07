Module VBModule1

    Public Structure Car
        Public price As Integer
        Public size As String
        Public color As String
    End Structure

    Sub Main()
        Dim Ford As Car
        Ford.price = 90000
        Ford.size = "Big"
        Ford.color = "Black"
        Console.WriteLine("Ford's Price is $" & Ford.price)
        Console.WriteLine("Ford's size is " & Ford.size)
        Console.WriteLine("Ford's color is " & Ford.color)
        Console.ReadLine()
    End Sub

    'Output
        'Ford’s price is $90000
        'Ford’s size is big
        'Ford’s color is black   
    

End Module