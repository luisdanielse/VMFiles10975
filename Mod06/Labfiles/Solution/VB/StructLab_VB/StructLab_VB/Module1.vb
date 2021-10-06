Module Module1
    Structure Course

        Dim title As String
        Dim creditHours As Integer
        Dim program As String
        Dim instructor As String

        Public Sub New(title As String, credits As Integer, prog As String, inst As String)
            Me.title = title
            Me.creditHours = credits
            Me.program = prog
            Me.instructor = inst
        End Sub

        Public Function GetTitle() As String

            Return title.ToUpper()
        End Function

    End Structure

    Sub Main()

        Dim cs101 As New Course("cs101", 6, "Computer Science", "Mr. Smith")

        Dim cs102 As New Course()

        cs102.title = "cs102"
        cs102.creditHours = 6
        cs102.program = "Computer Program"
        cs102.instructor = "Mrs. Smith"

        Console.WriteLine("{0}, {1}, {2}, {3}", cs101.title, cs101.creditHours, cs101.program, cs101.instructor)

        Console.WriteLine()

        Console.WriteLine("{0}, {1}, {2}, {3}", cs102.title, cs102.creditHours, cs102.program, cs102.instructor)

        Console.WriteLine()

        Console.WriteLine(cs101.GetTitle())

        Console.WriteLine()

        Console.WriteLine(cs102.GetTitle())

    End Sub

End Module
