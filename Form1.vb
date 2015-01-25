Imports MathClass.Math
Public Class Form1
#Region "Solver"
    Private Sub btnCalculate_Click() Handles btn_Calculate.Click
        Dim roots As New List(Of Double)
        roots = findroots(str2mat(txt_arr.Text, " "))
        rtxt_result.Clear()
        For i = 0 To roots.Count - 1
            rtxt_result.SelectedText = "Root " & i + 1 & ": " & roots(i) & vbNewLine
        Next
    End Sub
    Private Sub btn_Optimize_Click(sender As Object, e As EventArgs) Handles btn_Optimize.Click
        txt_arr.Text = "1 3 -28 -36 144"
    End Sub
#End Region
#Region "RootsQuadratic"

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        txt_consta.Text = 1
        txt_constb.Text = 1
        txt_constc.Text = 1
    End Sub
#End Region
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim arr() As Double
        arr = str2mat(txt_polyvalarray.Text, " ")
        txt_polyvalresult.Text = polyval(arr, txt_polyvalvalue.Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        txt_Respond.Text = differentiate(txt_User.Text, txt_value.Text)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_User.Clear()
        txt_Respond.Clear()
        txt_value.Clear()
    End Sub
End Class


















































































