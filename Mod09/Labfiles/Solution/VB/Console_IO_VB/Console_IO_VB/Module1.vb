Module Module1

    Sub Main()
        Console.WriteLine("Do you want to create a:")

        Console.WriteLine()
        Console.WriteLine("S - Student")

        Console.WriteLine()
        Console.WriteLine("I - Instructor")

        Console.WriteLine()
        Console.WriteLine("Q - Quit")

        Dim response As Char

        response = Convert.ToChar(Console.Read())

    End Sub

End Module
