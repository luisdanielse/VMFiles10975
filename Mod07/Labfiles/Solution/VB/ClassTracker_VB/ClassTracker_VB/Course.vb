Public Class Course

    Private _courseTitle As String
    Private _creditHours As Integer
    Private _program As String

    Public Property CourseTitle As String
        Get
            Return Me._courseTitle
        End Get
        Set(value As String)
            Me._courseTitle = value
        End Set
    End Property

    Public Property CreditHours As Integer
        Get
            Return Me._creditHours
        End Get
        Set(value As Integer)
            Me._creditHours = value
        End Set
    End Property

    Public Property Program As String
        Get
            Return Me._program
        End Get
        Set(value As String)
            Me._program = value
        End Set
    End Property

    Public Sub EnrollStudent(studentName As String)

    End Sub

    Public Overridable Function CalculateAverage(arrGrades() As Single) As Single
        Dim avg As Single = 0.0

        Return avg
    End Function

End Class
