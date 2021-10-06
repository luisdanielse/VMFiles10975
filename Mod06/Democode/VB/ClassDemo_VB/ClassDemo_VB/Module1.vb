Module Module1

    Sub Main()

        Dim aStudent As New Person()

        aStudent._height = 5.5
        aStudent._gender = "male"
        aStudent.Walk()
        aStudent.Speak()

        Dim newStudent As New Person(6.2F, 195.0F, "Caucasian", "female")

    End Sub

    Public Class Person

        Public _height As Single
        Public _weight As Single
        Public _ethnicity As String
        Public _gender As String

        Public Sub New()
            _height = 5.7
            _weight = 198.6
            _ethnicity = "Doesn't matter"
            _gender = "male"
        End Sub

        Public Sub New(ByVal height As Single, ByVal weight As Single, race As String, gender As String)
            _height = height
            _weight = weight
            _ethnicity = race
            _gender = gender
        End Sub


        Public Sub Walk()

        End Sub

        Public Sub Run()

        End Sub

        Public Sub Eat()

        End Sub

        Public Sub Sit()

        End Sub

        Public Sub Speak()

        End Sub


    End Class

End Module
