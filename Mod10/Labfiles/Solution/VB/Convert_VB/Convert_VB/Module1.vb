Module Module1

    Sub Main()

        Dim myArray(5) As Object
        Dim myInt As Integer = 5
        Dim myString As String = "Hello"
        Dim myChar As Char = "A"

        myArray(0) = myInt
        myArray(1) = myString
        myArray(2) = myChar

        Dim myDouble As Double
        myDouble = myInt
        myInt = CType(myDouble, Integer)

        myInt = CInt(myArray(0))
        myString = CStr(myArray(1))
        myChar = CChar(myArray(2))

    End Sub

End Module
