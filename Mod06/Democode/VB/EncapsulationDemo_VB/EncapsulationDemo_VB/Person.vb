Public Class Person

    Private _weight As Single
    Private _height As Single
    Private _ethnicity As String
    Private _gender As String

    Public Property Weight As Single

        Get
            Return Me._weight
        End Get

        Set(value As Single)
            If value > 0 Then
                Me._weight = value
            End If
        End Set

    End Property

    Public Property Height As Single
        Get
            Return Me._height
        End Get
        Set(value As Single)
            If value > 0 Then
                Me._height = value
            End If
        End Set

    End Property

    Public Property Ethnicity As String
        Get
            Return Me._ethnicity
        End Get
        Set(value As String)
            Me._ethnicity = value
        End Set

    End Property

    Public Property Gender As String
        Get
            Return Me._gender
        End Get
        Set(value As String)
            If value = "male" Or value = "female" Then
                Me._gender = value
            End If
        End Set

    End Property

    Public Sub New(ByVal weight As Single, ByVal height As Single, ByVal race As String, ByVal gender As String)

        Me._weight = weight
        Me._height = height
        Me._ethnicity = race
        Me._gender = gender

    End Sub

End Class
