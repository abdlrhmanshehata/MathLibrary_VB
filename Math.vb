Imports System.Math

Public Class Math
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
    Public Shared Function solvemymethod(a, b, c, acc, inc) As Double 'Solving by my method'
        Dim x, left, diff, accuracy, increment As Double
        left = a * (x ^ 2) + b * x
        diff = left - c
        accuracy = 10 ^ (-acc)
        increment = 10 ^ (-inc)
        If diff < 0 Then
            Do While diff <> accuracy
                x = x + diff * increment
                left = a * (x ^ 2) + b * x
                diff = left - c
            Loop
        ElseIf diff > 0 Then
            Do While diff >= accuracy
                x = x + diff * increment
                left = a * (x ^ 2) + b * x
                diff = left - c
            Loop
        End If
        Return x - diff / 10
    End Function
    Public Shared Function solve(a, b, c, d) As Double
        Dim xnext, xo, fx, fxdrev, delta As Double
        xo = 0
        'power=arr.length-1
        'for i=0 to power
        'fx+=arr(i).x0^(power-i)
        'next

        fx = a * xo ^ 3 + b * xo ^ 2 + c * xo + d
        fxdrev = 3 * a * xo ^ 2 + 2 * b * xo + c
        If fxdrev = 0 Then
            Do While fxdrev = 0
                xo += 1
                fxdrev = 2 * a * xo + b
            Loop
        End If
        xnext = xo - fx / fxdrev
        delta = xo - xnext

        Do While Abs(delta) > 0.00001
            xo = xnext
            fx = a * xo ^ 3 + b * xo ^ 2 + c * xo + d
            fxdrev = 3 * a * xo ^ 2 + 2 * b * xo + c
            xnext = xo - fx / fxdrev
            delta = xo - xnext
        Loop

        Return xnext
    End Function
    
End Class
