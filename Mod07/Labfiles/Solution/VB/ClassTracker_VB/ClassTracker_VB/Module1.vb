Module Module1

    Sub Main()
        Dim credCourse As New CreditCourse()

        credCourse.CourseTitle = "CS101"
        credCourse.CreditHours = 6
        credCourse.Program = "Computer Science"
        credCourse.EnrollStudent("Tom Thumb")

        Dim GPA As Single = credCourse.CalculateGPA(98.5F)
        Console.WriteLine("Tom Thumb has a GPA of {0} in course {1}.", GPA, credCourse.CourseTitle)

        Dim nonCredCrse As New NonCreditCourse()
        nonCredCrse.CourseTitle = "Introduction to Excel"

        Dim grade As Char = nonCredCrse.CalculateGrade(87.0F)

        Console.WriteLine("Tom also received a {0} in {1}", grade, nonCredCrse.CourseTitle)

        Dim newCredCourse As New CreditCourse()
        Console.WriteLine(newCredCourse.CourseTitle)

        Dim newCredCourseTwo As New CreditCourse("CS102", 6, "Computer Science")
        Console.WriteLine(newCredCourseTwo.CourseTitle)

    End Sub

End Module
