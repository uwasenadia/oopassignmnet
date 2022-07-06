Module Module1

    Sub Main()
        Dim stlist As List(Of String) = New List(Of String)
        Dim ooplist As List(Of Decimal) = New List(Of Decimal)
        Dim javalist As List(Of Decimal) = New List(Of Decimal)
        Dim clist As List(Of Decimal) = New List(Of Decimal)
        Dim oopmark As Decimal
        Dim javamark As Decimal
        Dim cmark As Decimal
        Dim names As String
        Dim avg As Decimal
        Dim oopAvg, JavaAvg, cAvg As Decimal
        Do
            Console.Write("enter student name  ")
            names = Console.ReadLine()
            stlist.Add(names)
            If (names <> "break") Then
                Console.Write("enter student oop marks  ")
                oopmark = Console.ReadLine()
                ooplist.Add(oopmark)
                Console.Write("enter student java marks  ")
                javamark = Console.ReadLine()
                javalist.Add(javamark)
                Console.Write("enter student c marks  ")
                cmark = Console.ReadLine()
                clist.Add(cmark)
            End If

        Loop While names <> "break"

        Dim size = (ooplist.Count) - 1
        Console.WriteLine(size)

        For i As Integer = 0 To size
            Dim markstotal = (javalist(i) + ooplist(i) + clist(i))
            avg = markstotal / 3
            Console.WriteLine(stlist(i) & " " & ooplist(i) & " " & javalist(i) & " " & clist(i) & " " & avg)
        Next

        Dim oopTotal = 0
        Dim javaTotal = 0
        Dim cTotal = 0

        For i As Integer = 0 To ooplist.Count - 1
            oopTotal += ooplist(i)
            oopAvg = oopTotal / (ooplist.Count)
            javaTotal += javalist(i)
            JavaAvg = javaTotal / (javalist.Count)
            cTotal += clist(i)
            cAvg = cTotal / (clist.Count)
        Next

        Console.WriteLine("  ")
        Console.WriteLine("oop average: " & oopAvg & " java average: " & JavaAvg & " C average: " & cAvg)
        Console.ReadLine()
    End Sub


End Module
