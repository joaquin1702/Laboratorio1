Module Module1
    Sub Main()
        Dim Elementos(10) As Integer
        Dim suma As Integer = 0

        For i = 0 To 9 Step 1
            Console.WriteLine("Inserte un número " & i + 1 & ": ")
            Elementos(i) = Console.ReadLine()
            suma += Elementos(i)

        Next

        For j = 0 To 9 Step 1
            Console.WriteLine("Valor " & j + 1 & ":" & Elementos(j))
        Next

        Console.WriteLine("La suma es: " & suma)
        Console.ReadLine()
    End Sub

End Module
