Module Module1

    Sub Main()
        Dim myArray() As Integer = New Integer() {4, 5, 9, 1, 8, 3}

        'BubbleSort(myArray)

        'Fibonacci(10)

    End Sub

    Sub BubbleSort(ByVal myArray() As Integer)

        Dim temp As Integer = 0

        For i As Integer = 0 To myArray.Length - 1
            For j As Integer = 0 To myArray.Length - 2
                If myArray(j + 1) < myArray(j) Then
                    temp = myArray(j)
                    myArray(j) = myArray(j + 1)
                    myArray(j + 1) = temp
                End If
            Next
        Next

        Console.WriteLine()

        For Each number As Integer In myArray
            Console.WriteLine(number)
        Next

    End Sub

    Sub Fibonacci(numberOfValues As Integer)

        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim temp As Integer = 0

        For counter As Integer = 0 To numberOfValues
            temp = a
            a = b
            b = temp + a
            Console.WriteLine(a)
        Next
    End Sub

End Module
