Module Module1

    Sub Main()

        ' Create an array here called grdsArray that will hold 5 grades
        Dim grdsArray() As Single = New Single(4) {}


        ' Call the addGrades method, passing it the grdsArray
        addGrades(grdsArray)


        ' After adding grades to the array, call the displayGrades method
        ' to print out the grades to the console window
        ' Use the For Each construct to iterate over the array

        displayGrades(grdsArray)


        ' Create a new Stack object called myStack
        Dim myStack As New Stack()



        ' Call the pushStack() method passing in the grades array for values
        pushStack(grdsArray, myStack)



        ' Call the popStack() method twice to remove the top two items from stack
        ' The popStack method will display each popped item to the console window
        popStack(myStack)
        popStack(myStack)



        ' Create a new SortedList object called myCourses
        Dim myCourses As New SortedList()



        ' Call the populateList() method
        populateList(myCourses)


        ' display a course in the list by passing a key
        displayList(myCourses, "CS101")


        ' Remove an item from the myCourses list using the key
        removeListItem(myCourses, "CS201")

    End Sub

    Sub addGrades(ByRef grdArray() As Single)

        grdArray(0) = 98
        grdArray(1) = 99
        grdArray(2) = 89
        grdArray(3) = 95
        grdArray(4) = 97

    End Sub

    Sub displayGrades(ByRef grdArray() As Single)

        For Each item As Single In grdArray
            Console.WriteLine(item)
        Next

    End Sub

    Sub pushStack(ByRef grdArray() As Single, ByRef stack As Stack)

        For Each item As Single In grdArray
            stack.Push(item)
        Next

    End Sub

    ' Pop the top item from the stack object passed in
    ' and write the value out to the console window
    Sub popStack(stack As Stack)

        Console.WriteLine("Item removed from the stack: ")
        Dim item As Single = Convert.ToSingle(stack.Pop())
        Console.WriteLine(item)

    End Sub

    Sub populateList(list As SortedList)

        list.Add("CS101", "Introduction to Computer Science")
        list.Add("CS102", "Data Structures and Algorithm Analysis")
        list.Add("CS201", "Introduction to Databases")
        list.Add("CS301", "Introduction to Object-Oriented Programming")

    End Sub

    Sub displayList(list As SortedList, key As String)

        Console.WriteLine(list.Item(key))

    End Sub

    Sub removeListItem(list As SortedList, key As String)

        Dim course As String
        course = list.Item(key)
        list.Remove(key)
        Console.WriteLine(course & " was removed from the list.")

    End Sub

End Module
