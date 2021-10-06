Module Module1

    Sub Main()
        SetInstructorName("John Smith")
        SetCourseTitle("CS 101")
        addClass("CS 101", True, True, False)
        DisplayReminders("Wednesday")
        CalculateAverage()
        CalculateAverageWithWhile()
    End Sub

    Sub SetInstructorName(newName As String)
        Dim instructorName As String = newName
        Console.Out.WriteLine("Instructor name is " & instructorName)
    End Sub

    Sub SetCourseTitle(newTitle As String)
        Dim result As Boolean = ValidateCourseTitleLength(newTitle)

        If result Then
            Dim courseTitle As String = newTitle
            Console.Out.WriteLine("Course title is " & courseTitle)
        Else
            Console.Out.WriteLine("Class name exceeds 50 characters, please shorten.")
        End If
    End Sub

    Function ValidateCourseTitleLength(title As String) As Boolean

        If title.Length <= 50 Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub addClass(title As String, isInProgram As Boolean, isRequired As Boolean, isElective As Boolean)

        If (isInProgram) Then
            If (isRequired) Then
                Console.Out.WriteLine(title + " is in the program and is a required course.")
            ElseIf (isElective) Then
                Console.Out.WriteLine(title + " is in the program and is an elective course.")
            Else
                Console.Out.WriteLine(title + " is in the program and is an extra credit course.")
            End If
        Else
            Console.Out.WriteLine(title + " is not in the Program.")
        End If

    End Sub

    Sub DisplayReminders(day As String)


        Select Case day
            Case "Wednesday"
                Console.Out.WriteLine("Discussion post is due today!")
            Case "Friday"
                Console.Out.WriteLine("Quiz is due today!")
            Case "Sunday"
                Console.Out.WriteLine("Assignment is due today!")
            Case Else
                Console.Out.WriteLine("Study new material, nothing due today.")
        End Select
    End Sub

    Sub CalculateAverage()

        Dim grades = New Double() {89, 98, 99, 90, 95}
        Dim average As Double = 0.0
        Dim total As Double = 0.0
        
        For gradeCounter As Integer = 0 To grades.Length - 1
            total = total + grades(gradeCounter)
        Next
        average = total / 5
        Console.Out.WriteLine("Grade average is " & average)
    End Sub

    Sub CalculateAverageWithWhile()

        Dim grade As Double
        Dim total As Double
        Dim average As Double
        Dim gradeCounter As Integer

        Console.Out.WriteLine("Enter first grade")
        grade = Double.Parse(Console.ReadLine())


        While (grade <> 200)
            total = total + grade
            gradeCounter = gradeCounter + 1
            Console.Out.WriteLine("Enter another grade or enter 200 to end.")
            grade = Double.Parse(Console.ReadLine())
        End While

        average = total / gradeCounter
        Console.Out.WriteLine("Grade average is: " & average)

    End Sub


End Module
