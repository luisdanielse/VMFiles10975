Module Module1

    'Structure Point
    '    Dim x As Integer
    '    Dim y As Integer
    'End Structure
    Sub Main()
        Dim newPoint As New Point()
        Dim objArray = New Object() {"one", 2, newPoint}

        Try
            Dim newString As String = CType(objArray(0), String)
            Dim newInt As Integer = CType(objArray(1), Integer)
            Dim aPoint As Point = objArray(2)
        Catch castEx As InvalidCastException
            Console.WriteLine("Cast failed, {0}", castEx.Message)
        End Try

    End Sub

End Module
