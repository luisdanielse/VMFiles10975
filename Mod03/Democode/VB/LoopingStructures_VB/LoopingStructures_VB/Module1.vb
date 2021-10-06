Module Module1

    Sub Main()


        '' simple For loop
        'Dim total As Double = 0

        'For loopCounter As Integer = 0 To 9
        '    Console.Out.WriteLine("loopCounter is at: " & loopCounter)
        '    total = total + loopCounter
        'Next

        'Console.Out.WriteLine("Total of values is: " & total)
        'Console.Out.WriteLine("Average is: " & total / 10)


        '*******************************************************************************************

        '' nested For loop
        'Dim students = New String() {"Tom", "Jerry", "Fred", "George"}
        'Dim grades = New Double() {91, 89, 95, 82}
        'Dim totalAGrades As Integer
        'Dim totalBGrades As Integer

        'For studentCounter As Integer = 0 To students.Length - 1
        '    For gradesCounter As Integer = 0 To grades.Length - 1
        '        If grades(gradesCounter) >= 90 Then
        '            totalAGrades = totalAGrades + 1
        '        ElseIf grades(gradesCounter) >= 80 And grades(gradesCounter) < 90 Then
        '            totalBGrades = totalBGrades + 1
        '        End If
        '    Next
        'Next

        'Console.Out.WriteLine("A Grades = " & totalAGrades)
        'Console.Out.WriteLine("B Grades = " & totalBGrades)

        '*******************************************************************************************


        '' For Each loop
        'Dim students = New String() {"Tom", "Jerry", "Fred", "George"}
        'Dim grades = New Double() {91, 89, 95, 82}
        'Dim totalAGrades As Integer
        'Dim totalBGrades As Integer

        'For Each student As String In students
        '    For Each grade As Double In grades
        '        If grade >= 90 Then
        '            totalAGrades = totalAGrades + 1
        '        ElseIf grade >= 80 And grade < 90 Then
        '            totalBGrades = totalBGrades + 1
        '        End If
        '    Next
        'Next

        'Console.Out.WriteLine("A Grades = " & totalAGrades)
        'Console.Out.WriteLine("B Grades = " & totalBGrades)

        '*******************************************************************************************


        '' While loop
        'Dim loopCounter As Integer = 0

        'While loopCounter < 4
        '    Console.Out.WriteLine(loopCounter)
        '    loopCounter = loopCounter + 1
        'End While


        '*******************************************************************************************


        '' Do While loop
        'Dim loopCounter As Integer = 0

        'Do While loopCounter < 4
        '    Console.Out.WriteLine(loopCounter)
        '    loopCounter = loopCounter + 1
        'Loop


        '*******************************************************************************************



        '' Do Until loop
        'Dim loopCounter As Integer = 0

        'Do
        '    Console.Out.WriteLine(loopCounter)
        '    loopCounter = loopCounter + 1
        'Loop Until loopCounter >= 4


        '*******************************************************************************************


        '' recursion example
        'Dim value As Long
        'value = factorial(10)
        'Console.Out.WriteLine(value)



    End Sub

    '' Recursive Function
    'Function factorial(ByVal n As Integer) As Integer
    '    If n = 0 Then
    '        Return 1
    '    Else
    '        Return factorial(n - 1) * n
    '    End If
    'End Function


End Module
