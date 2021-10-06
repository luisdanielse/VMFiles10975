Public Class CreditCourse
    Inherits Course

    Public Sub New()
        Me.CourseTitle = ""
        Me.CreditHours = 0
        Me.Program = ""
    End Sub

    Public Sub New(ByVal title As String, ByRef credits As Integer, ByVal program As String)
        Me.CourseTitle = title
        Me.CreditHours = credits
        Me.Program = program
    End Sub



    Public Overrides Function CalculateAverage(arrGrades() As Single) As Single

        Dim avg As Single = 0
        Dim sum As Single = 0
        Dim numGrades As Integer = arrGrades.Count()

        For Each grade As Single In arrGrades
            sum = sum + grade
        Next

        avg = sum / numGrades

        Return avg

    End Function

    Public Function CalculateGPA(grade As Single) As Single

        Dim letterGrade As Char
        Dim gradePoints As Single = 0.0

        If grade >= 90 Then
            letterGrade = "A"c
        ElseIf (grade >= 80 And grade <= 89) Then
            letterGrade = "B"c
        ElseIf (grade >= 70 And grade <= 79) Then
            letterGrade = "C"c
        ElseIf (grade >= 66 And grade <= 69) Then
            letterGrade = "D"c
        Else
            letterGrade = "F"c
        End If


        Select Case letterGrade

            Case "A"
                gradePoints = 4.0

            Case "B"
                gradePoints = 3.0

            Case "C"
                gradePoints = 2.0

            Case "D"
                gradePoints = 1.0

        End Select

        Return gradePoints

    End Function
End Class
