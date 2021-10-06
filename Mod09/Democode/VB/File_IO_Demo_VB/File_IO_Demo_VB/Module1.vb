Imports System.IO
Module Module1

    Sub Main()

        Dim stringToRead As String = "This is a plain text string"
        Dim sr As New StringReader(stringToRead)

        Dim input As String = sr.ReadToEnd()
        Console.WriteLine(input)

        ' *************************************
        ' Region StringReader

        'Try
        '    ' reader1 uses the close method to close the file after reading it
        '    ' you should always release your file resources by issuing the close statement
        '    Dim reader1 As New StreamReader("C:\Users\gerryo\Documents\TextFile.txt")
        '    Dim contents As String = reader1.ReadToEnd()
        '    reader1.Close()
        '    Console.WriteLine(contents)

        'Catch e As Exception

        '    ' Let the user know what went wrong.
        '    Console.WriteLine("The file could not be read:")
        '    Console.WriteLine(e.Message)

        'End Try

        ' End Region


        ' *************************************
        ' Region Writing Text Files

        'Dim textToWrite As String = "This is text that will be written to a new text file"

        'Try
        '    Dim writer1 As New StreamWriter("C:\Users\gerryo\Documents\NewTextFile.txt")
        '    writer1.Write(textToWrite)
        '    writer1.Close()
        'Catch e As Exception
        '    ' Let the user know what went wrong
        '    Console.WriteLine("The file could not be written:")
        '    Console.WriteLine(e.Message)
        'End Try

        '**************************************
        ' End Region


        ' *************************************
        ' Region Appending Text

        'Dim moreText As String = "We will add this line of text to an existing file."

        'Try
        '    Dim writer1 As StreamWriter = File.AppendText("C:\Users\gerryo\Documents\NewTextFile.txt")
        '    writer1.WriteLine()
        '    writer1.WriteLine(moreText)
        '    writer1.Close()
        'Catch e As Exception
        '    ' Let the user know what went wrong
        '    Console.WriteLine("The file could not be written:")
        '    Console.WriteLine(e.Message)
        'End Try

        ' *************************************
        'End Region

    End Sub

End Module
