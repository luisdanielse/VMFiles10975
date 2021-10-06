Module Module1

    Sub Main()

        ' this statement is legal because the constructor permits access to the
        ' member variables and in the class definition above, you see how the
        ' constructor assigns the values passed in, to the member variables

        Dim personOne As New Person(189, 68, "Asian", "male")

        ' this statement will generate an error in the compiler and Visual Studio
        ' will underline _weight with a red squiggly telling you that _weight is
        ' inaccessible due to its protection level.  This is because the variable 
        ' is declared as private in the class

        personOne._weight = 155

        ' these statements are fine because they are calling the public properties to assign 
        ' and get the values as oppsoed to accessing the member variable directly

        personOne.Weight = 155
        personOne.Height = 69
        Dim ethnicity As String = personOne.Ethnicity
        Dim gender As String = personOne.Gender

    End Sub

End Module
