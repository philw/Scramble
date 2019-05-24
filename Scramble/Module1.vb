Module Module1

    Sub Main()

        Dim Word As String
        Dim ScrambledWord As String = ""

        Do
            Console.Write("Enter a word: ")
            Word = Console.ReadLine()
            ScrambledWord = ScrambleWord(Word)
            Console.WriteLine("Scrambled word is: " & ScrambledWord)




        Loop



    End Sub

    Function ScrambleWord(Word As String) As String
        Dim ScrambledWord As String = ""
        Dim s As Integer
        Dim t As Integer

        If Word.Length < 4 Then
            Return Word
        End If

        ScrambledWord = Word(0)
        s = 1
        t = Word.Length - 2

        While t > s
            ScrambledWord &= Word(t)
            t -= 1
            ScrambledWord &= Word(s)
            s += 1
        End While

        If s = t Then
            ScrambledWord &= Word(s)
        End If
        ScrambledWord &= Word(Word.Length - 1)

        Return ScrambledWord
    End Function

End Module
