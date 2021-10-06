Module Module1

    Sub Main()

        '*************************************************************************
        ' Array Demo
        '*************************************************************************


        '' declaration of array, initialized with 10 elements, values are supplied
        '' memory set aside to hold ten integers
        'Dim myArray() As Integer = New Integer() {1, 4, 5, 6, 3, 10, 12, 500, 90, 1000}

        'For Each element As Integer In myArray
        '    Console.WriteLine(element)
        'Next

        'Console.WriteLine()
        'Console.WriteLine("The element at index position 3 is: " & myArray(3))
        'Console.WriteLine()

        '' Change the value at position 5 then print out the array again
        'myArray(4) = 50

        'For Each element As Integer In myArray
        '    Console.WriteLine(element)
        'Next



        '*************************************************************************
        ' Stack Demo
        '*************************************************************************

        'Dim newArray() As Integer = New Integer() {}
        'Dim myStack As New Stack()
        'myStack.Push("Hello")
        'myStack.Push(2)
        'myStack.Push(newArray)
        'myStack.Push("This is on top")

        'Console.WriteLine(myStack.Peek())

        'myStack.Pop()

        'Console.WriteLine(myStack.Peek())


        '**************************************************************************
        ' SortedList Demo
        '**************************************************************************

        'Dim sortList As SortedList = New SortedList()
        'sortList.Add(2, "Number 2")
        'sortList.Add(3, "Number 3")
        'sortList.Add(1, "Number 1")

        '' output the text value for the key 2
        'Console.WriteLine("The value represented by the key '2' is: " + sortList.GetByIndex(1))


        '**************************************************************************
        ' Queue Demo
        '**************************************************************************

        'Dim myQueue As Queue = New Queue()
        'myQueue.Enqueue("First Item")
        'myQueue.Enqueue("Second Item")
        'myQueue.Enqueue("Third Item")
        'myQueue.Enqueue("Last Item")

        'Console.WriteLine("The queue contains: ")
        'For Each element As String In myQueue
        '    Console.WriteLine(element)
        'Next

        'Console.WriteLine()
        'Console.Write("The item at the beginning of the queue is: ")
        'Console.WriteLine(myQueue.Peek())
        'Console.WriteLine()

        '' check to see if an element exists called Third Item
        'Dim exists As Boolean = myQueue.Contains("Third Item")
        'Console.Write("Does the queue contain 'Third Item'? ")
        'Console.WriteLine(exists)
        'Console.WriteLine()

        '' Remove the first item and print out the new first item in the queue
        'myQueue.Dequeue()
        'Console.WriteLine("The item 'First Item' was removed using Dequeue and now the first item is: ")
        'Console.WriteLine(myQueue.Peek())
        'Console.WriteLine()


        '**************************************************************************
        ' Dictionary Demo
        '**************************************************************************

        'Dim myDictionary As New Dictionary(Of String, String)
        'myDictionary.Add("Tree", "A perennial plant with an elongated stem, or trunk, supporting leaves or branches")
        'myDictionary.Add("One", "A text value used to represent the number 1.")
        'Console.WriteLine()

        '**************************************************************************
        ' SortedDictionary Demo
        '**************************************************************************

        'Dim srtDictionary As New SortedDictionary(Of String, String)
        'srtDictionary.Add("Tree", "A perennial plant with an elongated stem, or trunk, supporting leaves or branches")
        'srtDictionary.Add("One", "A text value used to represent the number 1.")
        'Console.WriteLine()


    End Sub

End Module
