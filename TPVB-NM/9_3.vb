Module test
    Sub Main()
        Dim n As Integer
        Do
            Console.Write("Veuillez saisir un nombre:")
            n = CInt(Console.ReadLine())
        Loop While n <= 0

        Console.WriteLine("Les {0} premiers nombres pairs supérieur à 0 sont :", n)
        For i As Integer = 1 To n
            Console.WriteLine(i * 2)
        Next

        Console.WriteLine("Appuyer sur une touche pour continuer")
        Console.ReadKey()


    End Sub
End Module