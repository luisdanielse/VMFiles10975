Module Module1

    Sub Main()
        Dim courseID As Integer
        Dim lengthInWeeks As Integer
        Dim myGPA As Double
        Dim courseTitle As String
        Dim courseDescription As String
        Dim instructorName As String
        Dim doesExist As Boolean
        Dim passingGrade As Boolean
        Dim isEnrolled As Boolean

        courseID = 101
        lengthInWeeks = 10
        myGPA = 0.0

        Console.Out.WriteLine(courseID)
        Console.Out.WriteLine(lengthInWeeks)
        Console.Out.WriteLine(myGPA)

        courseTitle = "CS101"
        courseDescription = "This course teaches introductory programming topics"
        instructorName = "MCT Instructor"

        Console.Out.WriteLine(courseTitle)
        Console.Out.WriteLine(courseDescription)
        Console.Out.WriteLine(instructorName)

        doesExist = True
        passingGrade = True
        isEnrolled = False

        Console.Out.WriteLine(doesExist)
        Console.Out.WriteLine(passingGrade)
        Console.Out.WriteLine(isEnrolled)

    End Sub

End Module
