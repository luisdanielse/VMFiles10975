Module Module1
    Public Structure name
        Dim firstName As String
        Dim middleName As String
        Dim lastName As String
        Dim suffix As String

        Public Sub New(first As String, middle As String, last As String, suff As String)
            firstName = first
            middleName = middle
            lastName = last
            suffix = suff
        End Sub

        Public Function getFullName() As String
            Return firstName & " " & middleName & " " & lastName & " " & suffix
        End Function

    End Structure
    Sub Main()
        Dim newName As New name()
        Dim newName2 As New name("Tom", "Green", "Thumb", "Jr.")

        newName.firstName = "Mark"
        newName.middleName = ""
        newName.lastName = "Twain"
        newName.suffix = ""

        Console.WriteLine(newName.firstName)
        Console.WriteLine(newName2.firstName)

    End Sub

    

End Module
