Module VBModule
    
    Structure Student
        Public id As Integer
        Public name As String
        Public age As Integer
    End Structure
    
    Sub Main()
        Dim Smith As Student
        Smith.id=1001
        Smith.name = "Andy"
        Smith.age =  16
        Console.WriteLine("Smith id is " & Smith.id) 'Smith id is 1001
        Console.WriteLine("Smith name is " & Smith.name) 'Smith name is Andy
        Console.WriteLine("Smith age is " & Smith.age) ' Smith age is 16
        Console.ReadLine()
        
    End Sub
  
End Module