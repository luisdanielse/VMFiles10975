
Public Class Course

    Private _title As String
    Private _creditHours As Integer
    Private _program As String
    Private _instructor As String

    Public Property Title As String
        Get
            Return Me._title
        End Get
        Set(value As String)
            Me._title = value
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

    Public Property Instructor As String
        Get
            Return Me._instructor
        End Get
        Set(value As String)
            Me._instructor = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(title As String, credits As Integer, prog As String, inst As String)

        Me._title = title
        Me._creditHours = credits
        Me._program = prog
        Me._instructor = inst

    End Sub

    Public Function GetTitle() As String

        Return Me._title.ToUpper()

    End Function

End Class
