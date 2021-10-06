Option Strict On
Module Module1


    Structure course
        Dim courseName As String
        Dim creditHours As Integer
        Dim gradePoints As Integer
    End Structure
    Sub Main()

        Dim courseList() As course = PopulateTranscript()
        Dim GPA As Double = GetGPA(courseList)
        Console.WriteLine("Your GPA is currently: " & GPA)

    End Sub

    Function PopulateTranscript() As course()

        Dim courseList() As course = New course(4) {}

        For counter As Integer = 0 To courseList.Length - 1
            Dim newCourse As course = New course()
            Console.WriteLine("Enter a course name")

            newCourse.courseName = Console.ReadLine()
            Console.WriteLine("Enter the credit hours for this course")

            Try
                newCourse.creditHours = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("Enter your grade points for this course")

                newCourse.gradePoints = Convert.ToInt32(Console.ReadLine())
                courseList(counter) = newCourse
            Catch ex As FormatException
                Console.WriteLine(ex.Message)
            Finally
                GC.Collect()
            End Try

        Next

        Return courseList

    End Function

    Function GetGPA(courseList As course()) As Double

        Dim result As Double = 0.0
        Dim totalCreditHours As Integer = 0
        Dim totalGradePoints As Integer = 0

        For Each currentCourse As course In courseList
            totalCreditHours += currentCourse.creditHours
            totalGradePoints += currentCourse.gradePoints
        Next

        result = totalGradePoints / totalCreditHours

        Return result

    End Function

End Module
