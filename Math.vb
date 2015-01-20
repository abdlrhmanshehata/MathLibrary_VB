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

    Public Shared Function evaluate(formula As String, operation As String) As Double
        Dim value As Double
        Dim array() As Double
        array = str2mat(formula, operation)

        Select Case operation
            Case "+"
                For n = 0 To array.Length - 1
                    value += array(n)
                Next
            Case "-"
                For n = 0 To array.Length - 1
                    value -= array(n)
                Next
            Case "*"
                value = 1
                For n = 0 To array.Length - 1
                    value = value * array(n)
                Next
            Case "/"
                value = array(0)
                For n = 0 To array.Length - 2
                    value = value / array(n + 1)
                Next
            Case "^"
                value = array(0)
                For n = 0 To array.Length - 2
                    value = value ^ array(n + 1)
                Next
        End Select

        Return value
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

    Private Overloads Shared Function separateterms(str As String, sep As String, sep2 As String) As String()
        Dim n As Integer
        Dim positions As New List(Of Integer)
        'get positions and number of separators
        For i = 0 To str.Length - 1
            If str.Chars(i) = sep Or str.Chars(i) = sep2 Then
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
    Private Overloads Shared Function separateterms(str As String, sep As String) As String()
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

    Public Overloads Shared Function polyval(Equation As String, value As Double) As Double
        Equation = Equation.Replace("x", value.ToString)
        Dim searchfor = Sub(oper As String)
                            Do While Equation.Contains(oper)
                                Dim substring As String
                                Dim i As Integer
                                i = Equation.IndexOf(oper)
                                substring = Equation.Chars(i - 1) & Equation.Chars(i) & Equation.Chars(i + 1)
                                Equation = Equation.Replace(substring, evaluate(substring, oper).ToString)
                            Loop
                        End Sub
        searchfor("^")
        searchfor("*")
        searchfor("/")
        searchfor("+")
        Dim Result As Double
        Result = Double.Parse(Equation)
        Return Result
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
        Dim fx, fxx As Double
        fx = polyval(formula, value)
        MsgBox(fx)
        fxx = polyval(formula, value + 0.0001)
        MsgBox(fxx)
        Return (fxx - fx) / 10 ^ -6
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
 
 