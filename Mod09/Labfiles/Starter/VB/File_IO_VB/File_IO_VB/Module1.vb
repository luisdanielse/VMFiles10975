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

        Select Case response
            Case "s", "S"
                CreateStudent()
            Case "i", "I"
                CreateInstructor()
            Case "q", "Q"
                Environment.Exit(0)
        End Select

    End Sub

    Public Sub CreateStudent()

        Dim first As String
        Dim last As String
        Dim gender As String
        Dim age As Integer

        Console.ReadLine()

        Console.WriteLine("Enter the student's first name.")
        first = Console.ReadLine()

        Console.WriteLine("Enter the student's last name.")
        last = Console.ReadLine()

        Console.WriteLine("Enter the student's gender.")
        gender = Console.ReadLine()

        Console.WriteLine("Enter the student's age.")
        age = Convert.ToInt32(Console.ReadLine())

        Dim newStudent As New Student(first, last, gender, age)



    End Sub

    Public Sub CreateInstructor()

        Dim first As String
        Dim last As String
        Dim gender As String
        Dim age As Integer

        Console.ReadLine()

        Console.WriteLine("Enter the instructor's first name.")
        first = Console.ReadLine()

        Console.WriteLine("Enter the instructor's last name.")
        last = Console.ReadLine()

        Console.WriteLine("Enter the instructor's gender.")
        gender = Console.ReadLine()

        Console.WriteLine("Enter the instructor's age.")
        age = Convert.ToInt32(Console.ReadLine())

        Dim newInstructor As New Instructor(first, last, gender, age)

    End Sub

    Private Sub SaveToFile(ByRef person As Person)

    End Sub

    Private Sub WriteContents(ByVal header As String, ByVal fileName As String, ByRef person As Person)
        If Not File.Exists(fileName) Then
            'TODO: Enter code here to write a new file
        Else
            'TODO: Enter code here to append to an existing file
        End If
    End Sub
End Module
