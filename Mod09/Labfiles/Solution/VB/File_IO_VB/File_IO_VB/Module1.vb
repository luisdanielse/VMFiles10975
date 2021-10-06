Imports System.IO

Module Module1

    Sub Main()
        Console.WriteLine("Do you want to create a:")

        Console.WriteLine()
        Console.WriteLine("S - Student")

        Console.WriteLine()
        Console.WriteLine("I - Instructor")

        Console.WriteLine()
        Console.WriteLine("Q - Quit")

        Console.WriteLine()

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

        SaveToFile(newStudent)


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

        SaveToFile(newInstructor)

    End Sub

    Private Sub SaveToFile(ByRef person As Person)

        Dim fileName As String
        Dim header As String

        If TypeOf person Is Student Then
            fileName = "Students.txt"
            header = "Students"
            WriteContents(header, fileName, person)
        Else
            fileName = "Instructors.txt"
            header = "Instructors"
            WriteContents(header, fileName, person)
        End If

    End Sub

    Private Sub WriteContents(ByVal header As String, ByVal fileName As String, ByRef person As Person)
        If Not File.Exists(fileName) Then
            Dim writer As New StreamWriter(fileName)
            writer.WriteLine(header)
            writer.Write(person.FirstName + ", ")
            writer.Write(person.LastName + ", ")
            writer.Write(person.Gender + ", ")
            writer.Write(person.Age)
            writer.Close()
        Else
            Dim writer As StreamWriter = File.AppendText(fileName)
            writer.WriteLine()
            writer.WriteLine("{0}, {1}, {2}, {3}", person.FirstName, person.LastName, person.Gender, person.Age)
            writer.Close()
        End If

        ReadFile(fileName)

    End Sub

    Private Sub ReadFile(ByVal fileName As String)
        Console.WriteLine("The file was saved with the following content:")
        Dim reader As New StreamReader(fileName)
        Console.WriteLine()
        Console.WriteLine(reader.ReadToEnd())
    End Sub

End Module
