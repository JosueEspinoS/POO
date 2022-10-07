Module VBModule
 
    Sub Main()
        'Boxing
        Dim var1 As Integer = 100
        Dim var2 As Object = CObj(var1)  'boxing
        Console.WriteLine("The data type of var2 is object type now. ")
        Console.ReadLine()
        'Unboxing
        Dim var1 As Integer = 100
        Dim var2 As Object = CObj(var1)    'boxing
        Dim var3 As Integer = CInt(var2)     'unboxing
        Console.WriteLine("The data type of var3 is integer type now. ")
        Console.ReadLine()
    End Sub
  
End Module