Module Module1

    Sub Main()

        '' simple if example
        'Dim age As Integer

        'If age >= 21 Then
        '    Console.Out.WriteLine("Insurance rates should go down")
        'End If


        '***************************************************************************


        '' if-else example
        'Dim isRequired As Boolean = True

        'If isRequired Then
        '    Console.Out.WriteLine("isRequired is true")
        'Else
        '    Console.Out.WriteLine("isRequired is true")
        'End If


        '***************************************************************************


        '' if-else-if example
        'Dim isRequired As Boolean = True
        'Dim isElective As Boolean = False

        'If isRequired Then
        '    Console.Out.WriteLine("isRequired is true")
        'ElseIf isElective Then
        '    Console.Out.WriteLine("isElective is true")
        'Else
        '    Console.Out.WriteLine("Neither value was true")
        'End If


        '***************************************************************************


        '' Nested if example
        'Dim isInProgram As Boolean = True
        'Dim isRequired As Boolean = True
        'Dim isElective As Boolean = False

        'If isInProgram Then
        '    If isRequired Then
        '        Console.Out.WriteLine("isInProgram AND isRequired are true")
        '    ElseIf isElective Then
        '        Console.Out.WriteLine("isInProgram AND isElective are true")
        '    Else
        '        Console.Out.WriteLine("isInProgram is true but isRequired and isElective are false")
        '    End If
        'End If



        '***************************************************************************



        ' Select Case example

        'Dim dayOfWeek As String = "Wednesday"

        'Select Case dayOfWeek
        '    Case "Wednesday"
        '        Console.Out.WriteLine("Discussion Post is Due!")
        '    Case "Friday"
        '        Console.Out.WriteLine("Quiz is due!")
        '    Case "Sunday"
        '        Console.Out.WriteLine("Assignment is due!")
        'End Select



        '***************************************************************************




        ' Select Case with default case

        'Dim dayOfWeek As String = "Wednesday"

        'Select Case dayOfWeek
        '    Case "Wednesday"
        '        Console.WriteLine("Discussion Post is Due!")
        '    Case "Friday"
        '        Console.WriteLine("Quiz is due!")
        '    Case "Sunday"
        '        Console.WriteLine("Assignment is due!")
        '    Case Else
        '        Console.WriteLine(“Go over unit study material”)
        'End Select




        '***************************************************************************



        '' Select Case handling multiple cases

        'Dim dayOfWeek As String = "Tuesday"

        'Select Case dayOfWeek
        '    Case "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
        '        Console.Out.WriteLine("This is a weekday")
        '    Case "Saturday", "Sunday"
        '        Console.Out.WriteLine("The weekend")
        'End Select



    End Sub

End Module
