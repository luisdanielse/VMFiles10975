Module Module1

    Sub Main()

        Console.Write("This is using the Console.Write() method with a string.")
        Console.Write(" And this does the same, but is a separate call to show the text starting on the same line")

        ' This call to Console.WriteLine() is intended to provide a blank line
        Console.WriteLine()

        Console.WriteLine("This is using the Console.WriteLine() method with a string.")
        Console.WriteLine(" And this does the same, but is a separate call to show the text starting on a new line")

        ' declare a Boolean variable for output to the console window
        Dim result As Boolean = True

        ' show that this overload for WriteLine() will output the Boolean value
        Console.WriteLine(result)

        ' Create a new Person object to pass to the WriteLine() method
        Dim newPerson As New Person()
        Console.WriteLine(newPerson)

        ' Read() and Readline() methods
        'Dim first As Char
        'Dim second As Char

        'first = Convert.ToChar(Console.Read())
        'second = Convert.ToChar(Console.Read())

        'Console.WriteLine("First: {0}, Second: {1}", first, second)

        'Dim input As String = Console.ReadLine()
        'Console.WriteLine(input)

    End Sub

End Module
