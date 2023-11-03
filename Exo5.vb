Imports System

Module Exo5
    Dim names As New ArrayList()

    'Starting the main
    Sub Main()

        ' Adding 5 names in the array     
        names.Add("Louis")
        names.Add("Marie")
        names.Add("Victor")
        names.Add("Magalie")
        names.Add("Jean-Philippe")

        ' Initialization steps
        InitConsole()

        ' Main loop for application
        Dim appRunning As Boolean = True
        While appRunning
            DisplayMenu()
            Dim userChoice As String = Console.ReadLine()
            Console.Clear()

            Select Case userChoice
                Case "1"
                    Console.WriteLine()
                    Console.WriteLine("Please enter a name:")
                    Dim newName As String = Console.ReadLine()
                    AddName(newName)

                Case "2"
                    Console.WriteLine()
                    Console.WriteLine("Enter a name to delete:")
                    Dim nameToRemove As String = Console.ReadLine()
                    DeleteName(nameToRemove)

                Case "3"
                    CountNames()
                Case "4"
                    DisplayLongestNames()
                Case "5"
                    DisplayNames()
                Case "0"
                    ExitApplication()
                Case Else
                    Console.WriteLine("Invalid option, please try again.")
            End Select
        End While
        ' Ending the main
    End Sub

    Sub InitConsole()
        ' Background and foreground color
        Console.BackgroundColor = ConsoleColor.Cyan
        Console.ForegroundColor = ConsoleColor.Black
        Console.Clear()

        ' Show the header and loading text
        DisplayHeader()

        ' Loading sequence
        ' Show the loading text with delays
        Console.WriteLine("----------> Loading the program")
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        ' Show the loading text with delays
        Console.WriteLine("----------> Booting the system")
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine("----------> Starting the engine")
        System.Threading.Thread.Sleep(500) ' Pause for 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine("...")
        System.Threading.Thread.Sleep(500) ' Pause for another 200 ms
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Please wait...")
        System.Threading.Thread.Sleep(1000) ' Final pause for 800 ms

        ' Now clear the console after the loading sequence
        Console.Clear()
    End Sub

    Sub DisplayHeader()
        Console.WriteLine("*************************************************************")
        Console.WriteLine("************************* EXO4 ******************************")
        Console.WriteLine("*************************************************************")
        Console.WriteLine(vbNewLine)
    End Sub



    Sub DisplayMenu()
        Threading.Thread.Sleep(800)
        DisplayHeader()
        Console.WriteLine("Choose an option:")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Delete")
        Console.WriteLine("3. Count")
        Console.WriteLine("4. Count the longest name in the list")
        Console.WriteLine("5. Display List")
        Console.WriteLine("0. Exit")
        Console.WriteLine()
    End Sub

    ''' <summary>
    ''' Adds a new name to the list.
    ''' </summary>
    ''' <param name="newName">The name to be added to the list.</param>
    Sub AddName(ByVal newName As String)
        If String.IsNullOrEmpty(newName) Then
            Console.WriteLine("The name cannot be empty" & vbNewLine)
        Else
            names.Add(newName)
            Console.WriteLine($"{newName} was added to the list." & vbNewLine)
        End If
    End Sub





    ''' <summary>
    ''' Deletes a name from the list if it exists.
    ''' </summary>
    ''' <param name="nameToRemove">The name to be removed from the list.</param>
    Sub DeleteName(ByVal nameToRemove As String)
        If names.Contains(nameToRemove) Then
            names.Remove(nameToRemove)
            Console.WriteLine($"{nameToRemove} was deleted from the list." & vbNewLine)
        Else
            Console.WriteLine("Name not found." & vbNewLine)
        End If
    End Sub



    Sub CountNames()
        Console.WriteLine(vbNewLine & "******* COUNTING NAMES ************")
        Console.WriteLine($"There are {names.Count} names in the list." & vbNewLine)
    End Sub

    Sub DisplayLongestNames()
        Console.WriteLine(vbNewLine & "******* LONGEST NAMES ************")

        ' First, determine the length of the longest name
        Dim maxLength As Integer = names.Cast(Of String)().Max(Function(n) n.Length)

        ' Then, find all names that have this maximum length
        Dim longestNames = names.Cast(Of String)().Where(Function(n) n.Length = maxLength)

        ' Check if there are any longest names found
        If longestNames.Any() Then
            For Each name In longestNames
                Console.WriteLine($"One of the longest names is {name} with {name.Length} characters.")
            Next
            Console.WriteLine()
        Else
            Console.WriteLine("The list is empty." & vbNewLine)
        End If
    End Sub


    Sub DisplayNames()
        Console.WriteLine(vbNewLine & "******* DISPLAY THE NAMES ************")
        If names.Count > 0 Then
            Dim count As Integer = 1
            For Each name As String In names
                Console.WriteLine($"{count}. {name}")
                count += 1
            Next
        Else
            Console.WriteLine("The list is empty.")
        End If
        Console.WriteLine(vbNewLine)
    End Sub

    Sub ExitApplication()
        Console.WriteLine()
        Console.WriteLine("                               *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        Console.WriteLine("                                Thanks for using EXO4, a Major Software")
        Console.WriteLine("                               *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        Console.WriteLine(vbNewLine)
        Threading.Thread.Sleep(2000)
        Console.Clear()
    End Sub
End Module
