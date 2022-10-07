Module VBModule1

    Public Enum Today
        morning
        afternoon
        evening
    End enum

    Sub Main()
        Dim t0 As String = Today.morning.ToString 't0 is converted to string type
        Dim t1 As String = Today.afternoon.ToString 't3 is converted to string type
        Dim t2 As String = Today.evening.ToString 't2 is converted to string type

        ' t0 = "morning"
        ' t1 = "afternoon"
        ' t2 = "evening" 
        Console. WriteLine("Have a breakfast in " & t0)
        Console. WriteLine("Have a lunch in " & t1)
        Console. WriteLine("Hava a supper in " & t2)
        Console. ReadLine() 
    End Sub

    'Output
        'Have a breakfast in morning
        'Have a lunch in afternoon
        'Hava a supper in evening

End Module