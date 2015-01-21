Imports System.Math
Public Class Math
    Public Shared Function factorial(number As Integer) As Integer
        Dim c, fact As Integer
        fact = 1
        For c = 1 To number
            fact = fact * c
        Next
        Return fact
    End Function
    Public Shared Function epsilon() As Double
        Dim eps As Double
        eps = 1
        Do While eps + 1 > 1
            eps = eps / 2
        Loop
        Return eps
    End Function
    Public Shared Function invert(text As String) As String
        Dim invertedtext As New List(Of String)
        For Each bit As Char In text
            invertedtext.Add(bit)
        Next
        invertedtext.Reverse()
        text = ""
        For Each bit As Char In invertedtext
            text += bit
        Next
        Return text
    End Function
    Public Shared Function extract(Formula As String, oper As String) As String
        Dim positions As New List(Of Double)
        Dim start, length As Integer
        Dim operindex As Integer = Formula.IndexOf(oper)
        Dim lefthand, righthand, extracted As String

        For i = 0 To formula.Length - 1
            Dim bit As String = formula.Chars(i)
            If bit = "+" Or bit = "-" Or bit = "*" Or bit = "/" Or bit = "^" Then
                positions.Add(i)
            End If
        Next
         
        '1.Right Hand Side
        start = operindex + 1
        Try
            length = positions(positions.IndexOf(operindex) + 1) - start
        Catch ex As ArgumentOutOfRangeException
            length = Formula.Length - start
        End Try
        righthand = Formula.Substring(start, length)


        '2.Left Hand Side
        start = operindex - 1
        Try
            length = start - positions(positions.IndexOf(operindex) - 1)
        Catch ex As ArgumentOutOfRangeException
            length = operindex
        End Try
        lefthand = Formula.Substring(start - length + 1, length)

        '3.Extracted
        extracted = lefthand & oper & righthand
        MsgBox(extracted)
        Return extracted
    End Function


    Public Shared Function EvaluateSimple(formula As String) As Double
        Dim value As Double
        Dim array() As Double
        Dim operation As String = ""
        For Each bit As Char In formula
            If bit = "*" Or bit = "/" Or bit = "^" Or bit = "+" Or bit = "-" Then
                operation = bit
                Exit For
            End If
        Next
        Select Case operation

            Case "+-"
                Dim positions As New List(Of Double)

                'Make every Bit has a leading sign +6+5-2
                If IsNumeric(formula.Chars(0)) Then
                    formula = formula.Insert(0, "+")
                End If
                'Get positions of the operators
                For i = 0 To formula.Length - 1
                    If formula.Chars(i) = "+" Or formula.Chars(i) = "-" Then
                        positions.Add(i)
                    End If
                Next
                'Select term to add it to the value
                For i = 0 To positions.Count - 1
                    Dim term As String
                    Dim start, length As Integer
                    start = positions(i)
                    If i = positions.Count - 1 Then
                        length = formula.Length - positions(i)
                    Else
                        length = positions(i + 1) - positions(i)
                    End If
                    term = formula.Substring(start, length)
                    Try
                        value += Double.Parse(term)
                    Catch ex As Exception
                        MsgBox("Syntax Error")
                    End Try
                Next
                '================================================================================================================='
            Case "*"
                array = str2mat(formula, operation)
                value = 1
                For n = 0 To array.Length - 1
                    value = value * array(n)
                Next
            Case "/"
                array = str2mat(formula, operation)
                value = array(0)
                For n = 0 To array.Length - 2
                    value = value / array(n + 1)
                Next
            Case "^"
                array = str2mat(formula, operation)
                value = array(0)
                For n = 0 To array.Length - 2
                    value = value ^ array(n + 1)
                Next
        End Select
        MsgBox(value)
        Return value
    End Function
    Public Shared Function EvaluateAdvanced(Equation As String, value As Double) As Double
        Dim Result As Double
        Equation = Equation.Replace("x", value.ToString)

        Dim calculate = Sub(oper As Char)
                            Do While Equation.Contains(oper)
                                Dim extractedstring As String = extract(Equation, oper)
                                Dim extractedvalue As String = EvaluateSimple(extractedstring).ToString
                                Equation = Equation.Replace(extractedstring, extractedvalue)
                            Loop
                        End Sub

        MsgBox(Equation)
        calculate("^")
        MsgBox(Equation)
        calculate("*")
        MsgBox(Equation)
        calculate("/")
        MsgBox(Equation)
        If Not IsNumeric(Equation) Then
            Result = EvaluateSimple(Equation)
        Else
            Result = Double.Parse(Equation)
        End If
        Return Result
    End Function

    Public Shared Function str2mat(str As String, separator As String) As Double()
        Dim n As Integer
        Dim positions As New List(Of Integer)
        'get positions and number of separators
        For i = 0 To str.Length - 1
            If str.Chars(i) = separator Then
                n += 1
                positions.Add(i)
            End If
        Next
        'add elements to the array
        Dim mat(n) As Double
        For i = 0 To mat.Length - 1
            Dim start, length As Integer
            If i = 0 Then
                start = 0
                length = positions(0)
                mat(0) = Double.Parse(str.Substring(start, length))
            Else
                start = positions(i - 1) + 1
                If i = mat.Length - 1 Then
                    mat(i) = Double.Parse(str.Substring(start))
                Else
                    length = positions(i) - positions(i - 1) - 1
                    mat(i) = Double.Parse(str.Substring(start, length))
                End If
            End If
        Next
        Return mat
    End Function

    Public Overloads Shared Function separateterms(str As String, sep As String) As String()
        Dim n As Integer
        Dim positions As New List(Of Integer)
        'get positions and number of separators
        For i = 0 To str.Length - 1
            If str.Chars(i) = sep Then
                n += 1
                positions.Add(i)
            End If
        Next
        'add terms to the array
        Dim terms(n) As String
        For i = 0 To terms.Length - 1
            Dim start, length As Integer
            If i = 0 Then
                start = 0
                length = positions(0)
                terms(0) = str.Substring(start, length)
            Else
                start = positions(i - 1) + 1
                If i = terms.Length - 1 Then
                    terms(i) = str.Substring(start)
                Else
                    length = positions(i) - positions(i - 1) - 1
                    terms(i) = str.Substring(start, length)
                End If
            End If
        Next
        Return terms
    End Function

    
    Public Overloads Shared Function polyval(arr As Double(), value As Double) As Double
        Dim power, fx, xo As Double
        xo = value
        power = arr.Length - 1
        For i = 0 To power
            fx += arr(i) * (xo ^ (power - i))
        Next
        Return fx
    End Function

    Public Shared Function rootsquadratic(a As Double, b As Double, c As Double) As List(Of String)
        Dim real, imag, g As Double
        Dim root1, root2 As String
        Dim theroots As New List(Of String)
        root1 = ""
        root2 = ""
        g = b ^ 2 - 4 * a * c
        real = -b / (2 * a)
        If g < 0 Then
            imag = Sqrt(Abs(g)) / (2 * a)
            root1 = real.ToString & " +" & imag.ToString & " i"
            root2 = real.ToString & " -" & imag.ToString & " i"
        ElseIf g >= 0 Then
            imag = Sqrt(g) / (2 * a)
            root1 = (real + imag).ToString
            root2 = (real + imag).ToString
        End If
        theroots.Add(root1)
        theroots.Add(root2)
        Return theroots
    End Function
    Public Shared Function findroots(arr() As Double) As List(Of Double)
        Dim roots As New List(Of Double)
        Dim currentroot As Double
        For i = -1 To 1 Step 0.01
            currentroot = Round(solveall(arr, i), 8)
            If Not roots.Contains(currentroot) Then
                roots.Add(currentroot)
            End If
        Next
        Return roots
    End Function
    Public Shared Function solveall(arr As Double(), xo As Double) As Double
        Dim xnext, fx, fxdrev, delta, power As Double
        power = arr.Length - 1

        Dim define = Sub()
                         fx = 0
                         fxdrev = 0
                         For i = 0 To power
                             fx += arr(i) * (xo ^ (power - i))
                             If i = power Then
                                 fxdrev += 0
                             Else
                                 fxdrev += (power - i) * arr(i) * (xo ^ (power - i - 1))
                             End If
                         Next
                     End Sub
        define()
        If fxdrev = 0 Then
            Do While fxdrev = 0
                xo += 1
                define()
            Loop
        End If
        xnext = xo - fx / fxdrev
        delta = xo - xnext
        Do While Abs(delta) > epsilon()
            xo = xnext
            define()
            xnext = xo - fx / fxdrev
            delta = xo - xnext
        Loop
        Return xnext
    End Function

    Public Overloads Shared Function differentiate(array As Double(), value As Double) As Double
        Dim power, fxdrev, fx, xo As Double
        xo = value
        power = array.Length - 1
        For i = 0 To power
            fx += array(i) * (xo ^ (power - i))
            fxdrev += (power - i) * array(i) * (xo ^ (power - i - 1))
        Next
        Return fxdrev
    End Function
    Public Overloads Shared Function differentiate(formula As String, value As Double) As Double
        Dim x, fx, x_h, fx_h, h, result As Double
        x = value

        MsgBox(fx)

        h = x * 10 ^ -6
        x_h = x + h
        MsgBox(x_h)

        MsgBox(fx_h)

        result = (fx_h - fx) / h
        Return result
    End Function
    
End Class
'Public Shared Function str2mat2(str As String) As Double()
'    'calculate matrix length
'    Dim n As Integer
'    For Each element As Char In str
'        If IsNumeric(element) Then
'            n += 1
'        End If
'    Next
'    'Convert "x;y;z" to "xyz"
'    Dim mat(n - 1) As Double
'    Dim convrtdstr As String = ""

'    For Each element As Char In str
'        If IsNumeric(element) Or element = "-" Then
'            convrtdstr += element
'        End If
'    Next
'    'Add items to array
'    For i = 0 To mat.Length - 1
'        If convrtdstr(i) = "-" Then
'            mat(i) = Double.Parse(convrtdstr(i) + convrtdstr(i + 1))
'            Exit For
'        Else
'            mat(i) = Double.Parse(convrtdstr(i))
'        End If
'    Next
'    Return mat
'End Function
 
 