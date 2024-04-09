
'Math Toolkit V1.0 | LAB 4 (CPEPROG 2) - BSCPE 1A
'Using VB Console App.


Imports System.Linq.Expressions

Module Module1

    'WELCOME SCREEN
    Sub Main()
        Dim A As New Choice


        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Clear()
        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("            (c) COPYRIGHT 2023 | V 1.0   ")
        Console.WriteLine("             _     _     ___    ______   _    _     ______    ___     ___    _    _     _  _  ______  ")
        Console.WriteLine("            {{{   {{{   {{{{{  {{{{{{{  {{   {{    {{{{{{{   {{{{{   {{{{{  {{    {{   {{ {{ {{{{{{{  ")
        Console.WriteLine("            }}}}_}}}}  }}___}}    }}    }}___}}       }}    }}   }} }}   }} }}    }}__}}  }}    }}    ")
        Console.WriteLine("            {{ {{{ {{  {{{{{{{    {{    {{{{{{{       {{    {{   {{ {{   {{ {{    {{{{{   {{    {{    ")
        Console.WriteLine("            }}     }}  }}   }}    }}    }}   {{       }}    }}___}} }}___}} }}___ }}  }}  }}    }}    ")
        Console.WriteLine("            {{     {{  {{   {{    {{    {{   }}       {{     {{{{{   {{{{{  {{{{{ {{   {{ {{    {{    ")
        Console.WriteLine()
        Console.WriteLine("                    V I S U A L   B A S I C . N E T   C O N S O L E   A P P L I C A T I O N             ")
        Console.WriteLine()
        Console.WriteLine("                                       ___________________________________                            ")
        Console.WriteLine("                                      (      PRESS ANY KEY TO PROCEED     )                           ")
        Console.WriteLine("                                       ```````````````````````````````````                            ")
        Console.WriteLine()
        Console.WriteLine("                       Fibonacci Sequence, Prime Numbers, & Decimal to Binary Converter    ")
        Console.WriteLine("                                        BSCPE 1A | CPEPROG 2 | LAB 4    ")
        Console.ReadKey()


        A.Slct()


    End Sub

End Module


Class Choice
    Protected N As Integer


    'DASHBOARD
    Sub Slct()
        Dim a As String

        Console.Beep()
        Console.Beep()
        Console.Beep()
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("            (c) COPYRIGHT 2023 | V 1.0                                                                     ")
        Console.WriteLine("             _     _     ___    ______   _    _     ______    ___     ___    _    _     _  _  ______       ")
        Console.WriteLine("            {{{   {{{   {{{{{  {{{{{{{  {{   {{    {{{{{{{   {{{{{   {{{{{  {{    {{   {{ {{ {{{{{{{       ")
        Console.WriteLine("            }}}}_}}}}  }}___}}    }}    }}___}}       }}    }}   }} }}   }} }}    }}__}}  }}    }}         ")
        Console.WriteLine("            {{ {{{ {{  {{{{{{{    {{    {{{{{{{       {{    {{   {{ {{   {{ {{    {{{{{   {{    {{         ")
        Console.WriteLine("            }}     }}  }}   }}    }}    }}   {{       }}    }}___}} }}___}} }}___ }}  }}  }}    }}         ")
        Console.WriteLine("            {{     {{  {{   {{    {{    {{   }}       {{     {{{{{   {{{{{  {{{{{ {{   {{ {{    {{         ")
        Console.WriteLine()
        Console.WriteLine("            V I S U A L   B A S I C . N E T   C O N S O L E   A P P L I C A T I O N                        ")
        Console.WriteLine("          _______________________________________________________________________________________________  ")
        Console.WriteLine()
        Console.WriteLine("                ___________         W E L C O M E !                                                        ")
        Console.WriteLine("               |  _______  |          PLEASE SELECT OPTIONS DOWN BELOW!                                    ")
        Console.WriteLine("               | |      0| |                                                                               ")
        Console.WriteLine("               |  ```````  |          ___________________________     ___________________________          ")
        Console.WriteLine("               | [0][+][=] |         | #1 ) FIBONACCI SEQUENCE   |   | #2 ) PRIME NUMBERS        |         ")
        Console.WriteLine("               | [7][8][9] |          ````````````````````````````    ````````````````````````````         ")
        Console.WriteLine("               | [4][5][6] |          ___________________________     ___________________________          ")
        Console.WriteLine("               | [1][2][3] |         | #3 ) DECIMAL TO BINARY    |   | #0 ) EXIT PROGRAM         |         ")
        Console.WriteLine("               |         . |          ````````````````````````````    ````````````````````````````         ")
        Console.WriteLine("                ```````````                                                                                ")
        Console.WriteLine("          _______________________________________________________________________________________________  ")
        Console.WriteLine()
        Console.Write("              >> PLEASE ENTER YOUR CHOICE HERE: ")



        a = Console.ReadLine()
        Select Case a
            Case "1"
                Console.Clear()
                Fib()
            Case "2"
                Console.Clear()
                PRM()
            Case "3"
                Console.Clear()
                Bnry()
            Case "0"
                Console.Clear()
                Console.Beep()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("              (c) COPYRIGHT 2023 | V 1.0                                                                     ")
                Console.WriteLine("               _     _     ___    ______   _    _     ______    ___     ___    _    _     _  _  ______       ")
                Console.WriteLine("              {{{   {{{   {{{{{  {{{{{{{  {{   {{    {{{{{{{   {{{{{   {{{{{  {{    {{   {{ {{ {{{{{{{       ")
                Console.WriteLine("              }}}}_}}}}  }}___}}    }}    }}___}}       }}    }}   }} }}   }} }}    }}__}}  }}    }}         ")
                Console.WriteLine("              {{ {{{ {{  {{{{{{{    {{    {{{{{{{       {{    {{   {{ {{   {{ {{    {{{{{   {{    {{         ")
                Console.WriteLine("              }}     }}  }}   }}    }}    }}   {{       }}    }}___}} }}___}} }}___ }}  }}  }}    }}         ")
                Console.WriteLine("              {{     {{  {{   {{    {{    {{   }}       {{     {{{{{   {{{{{  {{{{{ {{   {{ {{    {{         ")
                Console.WriteLine()
                Console.WriteLine("                       V I S U A L   B A S I C . N E T   C O N S O L E   A P P L I C A T I O N               ")
                Console.WriteLine("                                                                                                             ")
                Console.WriteLine("                         ...................................................................                 ")
                Console.WriteLine("                        :  T H A N K   Y O U   F O R   U S I N G   O U R   P R O G R A M !  :                ")
                Console.WriteLine("                         ```````````````````````````````````````````````````````````````````                 ")
                Console.WriteLine("                                                                                                             ")
                Console.WriteLine("                          * Fibonacci Sequence * Prime Numbers * Decimal to Binary Converter *               ")
                Console.WriteLine("                                     A.Y. 2022- 2023 | BSCPE 1A | CPEPROG 2 | LAB 4                          ")

                Threading.Thread.Sleep("2500")

                End
            Case Else
                Console.Beep()
                Console.Beep()
                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("                              _______________________________________________________                      ")
                Console.WriteLine("                             |///////////////////////////////////////////////////////|                     ")
                Console.WriteLine("                             |```````````````````````````````````````````````````````|                     ")
                Console.WriteLine("                             |                                                       |                     ")
                Console.WriteLine("                             |      1011/`\       USER INPUT ERROR!                  |                     ")
                Console.WriteLine("                             |       01/ | \??      Please check your input          |                     ")
                Console.WriteLine("                             |        /  .  \???    and try again. Thank you.        |                     ")
                Console.WriteLine("                             |        ```````                                        |                     ")
                Console.WriteLine("                              ```````````````````````````````````````````````````````                      ")
                Threading.Thread.Sleep("2500")

                Slct()
        End Select
    End Sub


    'FIBONACCI
    Sub Fib()
        Dim i, b, c As Integer

        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("             (c) COPYRIGHT 2023 | V 1.0                                                                     ")
        Console.WriteLine("              _     _     ___    ______   _    _     ______    ___     ___    _    _     _  _  ______       ")
        Console.WriteLine("             {{{   {{{   {{{{{  {{{{{{{  {{   {{    {{{{{{{   {{{{{   {{{{{  {{    {{   {{ {{ {{{{{{{       ")
        Console.WriteLine("             }}}}_}}}}  }}___}}    }}    }}___}}       }}    }}   }} }}   }} }}    }}__}}  }}    }}         ")
        Console.WriteLine("             {{ {{{ {{  {{{{{{{    {{    {{{{{{{       {{    {{   {{ {{   {{ {{    {{{{{   {{    {{         ")
        Console.WriteLine("             }}     }}  }}   }}    }}    }}   {{       }}    }}___}} }}___}} }}___ }}  }}  }}    }}         ")
        Console.WriteLine("             {{     {{  {{   {{    {{    {{   }}       {{     {{{{{   {{{{{  {{{{{ {{   {{ {{    {{         ")
        Console.WriteLine()
        Console.WriteLine("                      V I S U A L   B A S I C . N E T   C O N S O L E   A P P L I C A T I O N               ")
        Console.WriteLine("             ___________________________________________________________________________________________    ")
        Console.WriteLine()
        Console.WriteLine("                This will show you the numbers in a fibonacci sequence in order                             ")
        Console.WriteLine("                with their placement until it reaches the limit you type in.                                ")
        Console.WriteLine()
        Console.Write("                    >> How many numbers in the fibonacci sequence do you want to see: ")

        N = Console.ReadLine()
        b = 0
        c = 1
        i = 1
        'Console.Clear()
        N += 1

        Do Until i >= N
            Console.Beep()
            Console.WriteLine()
            Console.WriteLine("                " & b & ", {0} (number in fibonacci sequence)", i)
            b = b + c
            c = b - c
            i += 1
        Loop

        Console.Beep()
        Console.WriteLine()
        Console.WriteLine("             ___________________________________________________________________________________________    ")
        Console.WriteLine("                PRESS ANY KEY TO RETURN TO DASHBOARD...")
        Console.ReadKey()
        Console.Clear()
        Slct()

    End Sub


    'PRIME NUM
    Sub PRM()
        Dim c, d, e, f As Integer
        Const b As Integer = 0

        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              (c) COPYRIGHT 2023 | V 1.0                                                                     ")
        Console.WriteLine("               _     _     ___    ______   _    _     ______    ___     ___    _    _     _  _  ______       ")
        Console.WriteLine("              {{{   {{{   {{{{{  {{{{{{{  {{   {{    {{{{{{{   {{{{{   {{{{{  {{    {{   {{ {{ {{{{{{{       ")
        Console.WriteLine("              }}}}_}}}}  }}___}}    }}    }}___}}       }}    }}   }} }}   }} }}    }}__}}  }}    }}         ")
        Console.WriteLine("              {{ {{{ {{  {{{{{{{    {{    {{{{{{{       {{    {{   {{ {{   {{ {{    {{{{{   {{    {{         ")
        Console.WriteLine("              }}     }}  }}   }}    }}    }}   {{       }}    }}___}} }}___}} }}___ }}  }}  }}    }}         ")
        Console.WriteLine("              {{     {{  {{   {{    {{    {{   }}       {{     {{{{{   {{{{{  {{{{{ {{   {{ {{    {{         ")
        Console.WriteLine()
        Console.WriteLine("                       V I S U A L   B A S I C . N E T   C O N S O L E   A P P L I C A T I O N               ")
        Console.WriteLine("              ___________________________________________________________________________________________    ")
        Console.WriteLine()
        Console.WriteLine("                 This will show you what are the prime numbers and what are not,                             ")
        Console.WriteLine("                 until it reaches the limit you put in.                                                      ")
        Console.WriteLine("                                                                                                             ")
        Console.Write("                     >> How many numbers do you want to see? ")

        N = Console.ReadLine()
        N += 1
        Dim g As Integer = 1
        'Console.Clear()
        Do Until g = N
            c = g Mod 2
            d = g Mod 3
            e = g Mod 5
            f = g Mod 7
            If g = 2 Or g = 3 Or g = 5 Or g = 7 Then
                Console.Beep()
                Console.WriteLine()
                Console.WriteLine("                {0} is a Prime number", g)
                g += 1

            ElseIf g = 1 Or c = b Or d = b Or e = b Or f = b Then
                Console.Beep()
                Console.WriteLine()
                Console.WriteLine("                {0} is NOT a Prime number", g)
                g += 1

            Else
                Console.Beep()
                Console.WriteLine()
                Console.WriteLine("                {0} is a Prime number", g)
                g += 1

            End If

        Loop
        Console.WriteLine()
        Console.WriteLine("             ___________________________________________________________________________________________    ")
        Console.WriteLine("                PRESS ANY KEY TO RETURN TO DASHBOARD...")
        Console.ReadKey()
        Console.Clear()
        Slct()
    End Sub


    'DEC TO BIN
    Sub Bnry()
        Dim a, c, d As Integer
        Const b As Integer = 2
        Dim e, f As String

        Console.Beep()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("              (c) COPYRIGHT 2023 | V 1.0                                                                     ")
        Console.WriteLine("               _     _     ___    ______   _    _     ______    ___     ___    _    _     _  _  ______       ")
        Console.WriteLine("              {{{   {{{   {{{{{  {{{{{{{  {{   {{    {{{{{{{   {{{{{   {{{{{  {{    {{   {{ {{ {{{{{{{       ")
        Console.WriteLine("              }}}}_}}}}  }}___}}    }}    }}___}}       }}    }}   }} }}   }} }}    }}__}}  }}    }}         ")
        Console.WriteLine("              {{ {{{ {{  {{{{{{{    {{    {{{{{{{       {{    {{   {{ {{   {{ {{    {{{{{   {{    {{         ")
        Console.WriteLine("              }}     }}  }}   }}    }}    }}   {{       }}    }}___}} }}___}} }}___ }}  }}  }}    }}         ")
        Console.WriteLine("              {{     {{  {{   {{    {{    {{   }}       {{     {{{{{   {{{{{  {{{{{ {{   {{ {{    {{         ")
        Console.WriteLine()
        Console.WriteLine("                       V I S U A L   B A S I C . N E T   C O N S O L E   A P P L I C A T I O N               ")
        Console.WriteLine("              ___________________________________________________________________________________________    ")
        Console.WriteLine()
        Console.WriteLine("                 This will show you the binary conversion of the decimal number,                             ")
        Console.WriteLine("                                                                                                             ")
        Console.Write("                     >> What number do you want to convert to Binary? ")

        a = Console.ReadLine()
        'Console.Clear()
        Do Until a <= 0
            d = a Mod b
            e = e & d
            a = a \ b
        Loop
        f = StrReverse(e)
        Console.Beep()
        Console.WriteLine()
        Console.WriteLine("                 Binary: " & f)
        Console.WriteLine()
        Console.WriteLine("             ___________________________________________________________________________________________    ")
        Console.WriteLine("                PRESS ANY KEY TO RETURN TO DASHBOARD...")
        Console.ReadKey()
        Console.Clear()
        Slct()
    End Sub


End Class