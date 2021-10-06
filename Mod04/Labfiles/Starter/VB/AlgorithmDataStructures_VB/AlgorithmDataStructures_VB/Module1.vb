Module Module1

    Sub Main()

        ' Create an array here called grdsArray that will hold 5 grades


        ' Call the addGrades method, passing it the grdsArray


        ' After adding grades to the array, call the displayGrades method
        ' to print out the grades to the console window
        ' Use the For Each construct to iterate over the array


        ' Create a new Stack object called myStack




        ' Call the pushStack() method passing in the grades array for values




        ' Call the popStack() method twice to remove the top two items from stack
        ' The popStack method will display each popped item to the console window




        ' Create a new SortedList object called myCourses




        ' Call the populateList() method




        ' display a course in the list by passing a key



        ' remove an item from the myCourses list using the key

    End Sub

    Sub addGrades(ByRef grdArray() As Single)


    End Sub

    Sub displayGrades(ByRef grdArray() As Single)


    End Sub

    Sub pushStack(ByRef grdArray() As Single, ByRef stack As Stack)

    End Sub

    ' Pop the top item from the stack object passed in
    ' and write the value out to the console window
    Sub popStack(stack As Stack)

        Console.WriteLine("Item removed from the stack: ")

    End Sub

    Sub populateList(list As SortedList)

    End Sub

    Sub displayList(list As SortedList, key As String)

    End Sub

    Sub removeListItem(key As String, key As String)

    End Sub

End Module
