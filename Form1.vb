Imports MathClass.Math
Public Class Form1
#Region "Solver"
    Private Sub btnCalculate_Click() Handles btn_Calculate.Click
        Dim x As Double()
        x = str2mat(txt_arr.Text)
        txt_result.Text = solveall(x)
    End Sub
    Private Sub btn_Optimize_Click(sender As Object, e As EventArgs) Handles btn_Optimize.Click
        txt_arr.Text = "1 1 -1 2"
    End Sub
#End Region
#Region "RootsQuadratic"
    Private Sub btn_Roots_Click(sender As Object, e As EventArgs) Handles btn_Roots.Click
        Dim theroots As List(Of String)
        theroots = rootsquadratic(txt_consta.Text, txt_constb.Text, txt_constc.Text)
        txt_root1.Text = theroots(0)
        txt_root2.Text = theroots(1)
    End Sub
    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        txt_consta.Text = 1
        txt_constb.Text = 1
        txt_constc.Text = 1
    End Sub
#End Region
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String = "1;2;2.3"   
    End Sub
End Class


















































































