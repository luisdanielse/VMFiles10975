Public Class Student
    Inherits Person

    Private _school As String
    Private _program As String

    Public Property School As String
        Get
            Return Me._school
        End Get
        Set(value As String)
            Me._school = value
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

    Public Sub sleep()

    End Sub

    Public Sub study()

    End Sub

    Public Overrides Sub move()
        Console.WriteLine("Moving")
    End Sub


End Class
