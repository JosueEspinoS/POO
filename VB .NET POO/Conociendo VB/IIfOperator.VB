Module VBModule
 
    Sub Main()
        ' IIf(test-expression , if-true-do-this , if-false-do-this)
        Dim a As Integer = 100
        Dim b As Integer = 200
        Dim result1 As String = IIf(a < b, "apple","banana")
        Console.WriteLine("result1 is: " + result1)
        
        Dim result2 As String = IIf(a > b, "apple","banana")
        Console.WriteLine("result2 is: " + result2)
        Console.ReadLine()
    End Sub
  
End Module