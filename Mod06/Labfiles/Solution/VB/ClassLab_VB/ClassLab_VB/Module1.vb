Module Module1

    Sub Main()

        Dim cs101 As New Course("cs101", 6, "Computer Science", "Mr. Smith")

        Dim cs102 As New Course()

        cs102.Title = "cs102"
        cs102.CreditHours = 6
        cs102.Program = "Computer Program"
        cs102.Instructor = "Mrs. Smith"

        Console.WriteLine("{0}, {1}, {2}, {3}", cs101.Title, cs101.CreditHours, cs101.Program, cs101.Instructor)

        Console.WriteLine()

        Console.WriteLine("{0}, {1}, {2}, {3}", cs102.Title, cs102.CreditHours, cs102.Program, cs102.Instructor)

        Console.WriteLine()

        Console.WriteLine(cs101.GetTitle())

        Console.WriteLine()

        Console.WriteLine(cs102.GetTitle())


    End Sub

End Module
