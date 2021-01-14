'Laura Riley
'RCET0265
'Spring2021
'Operators
'https://github.com/rilelaur/Operators.git


Option Compare Binary
Module OperatorsExample

    Sub Main()

        'Addition
        Console.WriteLine(2 + 2)

        'Subtraction
        Console.WriteLine(8 - 2)

        'Multiplication
        Console.WriteLine(5 * 5)

        'Division as Double (decimal number)
        Console.WriteLine(1 / 2)
        'Division as Integer (whole number)
        Console.WriteLine(1 \ 2)
        'Division gives only the remainder
        Console.WriteLine(1 Mod 2)

        'Concatination
        Console.WriteLine("Hello" & " World")


        'Comparisons

        'Boolean throws a true or false (here it is false)
        Console.WriteLine(3 > 4)
        'Boolean throws a true
        Console.WriteLine(3 < 4)
        'Boolean throws a false (3 is not equal to 4)
        Console.WriteLine(3 = 4)
        'Boolean throws a true (3 is not equal to 4)
        Console.WriteLine(3 <> 4)
        'Here it is comparing the ascii value of the strings
        Console.WriteLine("A" > "B")
        'It looks at the characters from left to right and evaluates them. It doesn't add or multiply them
        Console.WriteLine("AAA" < "ABA")
        Console.WriteLine("abc" > "ABC")

        Console.Read()

    End Sub

End Module
