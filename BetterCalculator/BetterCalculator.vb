'Jessica McArthur
'RCET0265
'Spring 2020
'Better Calculator
'https://g

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()
        'Variables declared
        Dim userResponse As String
        Dim firstNumber As Integer
        Dim firstCheck As Boolean = False
        Dim secondNumber As Integer
        Dim secondCheck As Boolean = False
        Dim optionChosen As Boolean = False
        Dim menu As String
        Dim operation As String
        Dim result As Integer
        Dim keepPlaying As Boolean = True

        'The calculator runs continuously until prompted to end
        Do While keepPlaying

            'Prompt user for a number. User is prompted until a integer is entered.
            Console.WriteLine("Please enter two numbers. Enter " & Chr(34) & "Q" & Chr(34) & " at any time to quit.")

            Do Until firstCheck = True

                Console.WriteLine("Choose a number:")
                userResponse = Console.ReadLine()

                'The users' responses are validated. If Q is pressed the program ends
                If userResponse = "Q" Then
                    keepPlaying = False
                    Exit Do
                Else

                    Try
                        firstNumber = CInt(userResponse)
                        firstCheck = True
                    Catch ex As Exception
                        Console.WriteLine("You entered " & Chr(34) & userResponse & Chr(34) & " , please enter a whole number")
                        firstCheck = False

                    End Try

                End If

            Loop

            'Q is pressed the the program ends.
            If userResponse = "Q" Then
                keepPlaying = False
                Exit Do
            End If

            Console.WriteLine("You entered " & Chr(34) & CStr(firstNumber) & Chr(34))

            'Prompt user for another number. User is prompted until a integer is entered.
            Do Until secondCheck = True

                Console.WriteLine("Choose a number:")
                userResponse = Console.ReadLine()


                'The users responses are validated. If Q is pressed the program ends
                If userResponse = "Q" Then
                    keepPlaying = False
                    Exit Do
                Else
                    Try
                        secondNumber = CInt(userResponse)
                        secondCheck = True
                    Catch ex As Exception
                        Console.WriteLine("You entered " & Chr(34) & userResponse & Chr(34) & " , please enter a whole number")
                        secondCheck = False
                    End Try

                End If
            Loop

            'Q is pressed the the program ends.
            If userResponse = "Q" Then
                keepPlaying = False
                Exit Do
            End If

            Console.WriteLine($"You entered " & Chr(34) & CStr(secondNumber) & Chr(34))


            'user is prompted to select an operation
            If userResponse = "Q" Then
                keepPlaying = False
                Exit Do
            Else
                Do
                    Console.WriteLine("Choose one of the following options")
                    Console.Write($" 1. Add {vbNewLine} 2.Subtract {vbNewLine} 3. Multiply {vbNewLine} 4. Divide {vbNewLine}")
                    menu = Console.ReadLine()

                    optionChosen = True
                    'Users response is validated and the operation completed or promted for an other response.
                    Select Case menu
                        Case = "q"
                            keepPlaying = False
                            Exit Do
                        Case = "1"
                            operation = "+"
                            result = firstNumber + secondNumber
                        Case = "2"
                            operation = "-"
                            result = firstNumber - secondNumber
                        Case = "3"
                            operation = "*"
                            result = firstNumber * secondNumber
                        Case = "4"
                            operation = "\"
                            result = firstNumber \ secondNumber
                        Case Else
                            optionChosen = False
                    End Select

                Loop Until optionChosen = True
            End If
            If keepPlaying = False Then
                Exit Do
            End If
            'optionChosen will be a boolean for ending the loop



            'The choosen numbers operation and results are displayed to the user
            Console.WriteLine($" {firstNumber} {operation} {secondNumber} = {result}")
            firstCheck = False
            secondCheck = False


        Loop

        'User is greeted with closing sentiments and directions when exiting the program.
        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")
        Console.ReadLine()

    End Sub

End Module
