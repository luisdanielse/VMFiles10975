Public Class Person

    Private _height As Single
    Private _weight As Single
    Private _gender As String
    Private _age As Integer
    Private _firstName As String
    Private _lastName As String

    Public Property Height As Single
        Get
            Return Me._height
        End Get
        Set(value As Single)
            Me._height = value
        End Set
    End Property

    Public Property Weight As Single
        Get
            Return Me._weight
        End Get
        Set(value As Single)
            Me._weight = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return Me._age
        End Get
        Set(value As Integer)
            Me._age = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return Me._gender
        End Get
        Set(value As String)
            Me._gender = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return Me._firstName
        End Get
        Set(value As String)
            Me._firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return Me._lastName
        End Get
        Set(value As String)
            Me._lastName = value
        End Set
    End Property

    Public Overridable Sub eat()

    End Sub

    Public Sub sleep()

    End Sub

    Public Overridable Sub move()

    End Sub

    Public Sub communicate()

    End Sub

End Class
