Public Class Instructor
    Inherits Person

    Public Sub New(ByVal first As String, ByVal last As String, ByVal gender As String, ByVal age As Integer)

        Me.FirstName = first
        Me.LastName = last
        Me.Gender = gender
        Me.Age = age

    End Sub
    Public Overrides Sub move()

    End Sub
End Class
