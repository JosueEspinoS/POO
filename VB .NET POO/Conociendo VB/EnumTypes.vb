Module VBModule
    'Enum Type is a special data type (like Integer or String) that you define
    'yourself, which has an associated a list of values.
    'The syntax to declare an Enum type like this:

    Public Enum Today
        morning
        afternoon
        evening
    End Enum

   ' The syntax to declare an enum variable like this:
    ' Dim t As Today

    Enum Week       'defines an enum type
        sunday       'enum member
        monday       'enum member
        tuesday      'enum member
    End Enum
    
    'By default the first enumerator has the value 0, and the value of each
    'successive enumerator is increased by 1.

    Sub Main()
        Dim t0 As Today     'defines an enum variable t0
        Dim t1 As Today     'defines an enum variable t1
        Dim t2 As Today     'defines an enum variable t2
        t0 = Today.morning      'default value is 0
        t1 = Today.afternoon    'default value is 1
        t2 = Today.evening       'default value is 2
        Console. WriteLine( t0 & " represents morning. ")   '0 represents morning.
        Console. WriteLine( t1 & " represents afternoon. ") '1  represents afternoon.
        Console. WriteLine( t2 & " represents evening. ")   '2 represents evening.
        Console. ReadLine()

    
    End Sub
  
End Module

'Explanation:
'“Enum Today” defines an enum type “Today”.
'“Dim t0 As Today”, “Dim t1 As Today” and “Dim t2 As Today” define
'three enum variables “t0”, “t1” and “t2”.
'“Today. morning” means Today’s morning, its default value is 0.
'“Today. afternoon” means Today’s afternoon, its default value is 1.
'“Today. evening” means Today’s evening, its default value is 2.