
Module Module1

    Sub Main()

        Dim errorMessage As String
        Dim numerator As Integer
        Dim denominator As Integer
        Dim result As Integer

        Console.WriteLine("Enter the numerator")
        numerator = Int32.Parse(Console.ReadLine())
        Console.WriteLine()

        Console.WriteLine("Enter the denominator")
        denominator = Int32.Parse(Console.ReadLine())


        Try
            result = numerator \ denominator
            Console.Write("The result is: ")
            Console.WriteLine(result.ToString())
        Catch ofEx As OverflowException
            errorMessage = ofEx.Message
            Console.WriteLine(errorMessage)
            'Catch dEx As DivideByZeroException
            '    errorMessage = dEx.Message
            '    Console.WriteLine(errorMessage)
            'Catch Ex As Exception
            '    errorMessage = Ex.Message
            '    Console.WriteLine(errorMessage)
        End Try
    End Sub

End Module
