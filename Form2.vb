Imports MathClass.Plotting
Imports MathClass.Math
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Plot.Click, btn_Plot.Click
        Dim x(), y() As Double
        x = str2mat(txt_Xvalues.Text, ",")
        y = str2mat(txt_Yvalues.Text, ",")
        plot(Chart1, "Test", x, y)
    End Sub
    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Chart1.Series.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x() As Double = str2mat(TextBox1.Text, ",")
        Dim Formula As String = TextBox2.Text
        plot(Chart2, "Test", x, Formula)
    End Sub
End Class