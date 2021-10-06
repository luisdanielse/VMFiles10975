Public Class NonCreditCourse
    Inherits Course

    Public Function CalculateGrade(grade As Single) As Char

        Dim letterGrade As Char

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

        Return letterGrade

    End Function

End Class
