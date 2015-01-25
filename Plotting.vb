Imports System.Windows.Forms.DataVisualization.Charting
Imports MathClass.Math
Public Class Plotting
    Public Overloads Shared Sub plot(ByVal chart As Chart, SeriesName As String, X As Double(), Y As Double())
        Dim NewSeries As Series
        chart.Series.Clear()
        NewSeries = chart.Series.Add(SeriesName)
        Try
            For i = 0 To X.Length - 1
                NewSeries.Points.AddXY(X(i), Y(i))
            Next
        Catch ex As Exception

        End Try
      
        NewSeries.ChartType = SeriesChartType.Line
    End Sub
    Public Overloads Shared Sub plot(ByVal chart As Chart, SeriesName As String, X As Double(), Equation As String)
        Dim NewSeries As Series
        chart.Series.Clear()
        NewSeries = chart.Series.Add(SeriesName)
        NewSeries.ChartType = SeriesChartType.Line

        Dim Y As New List(Of Double)
        For i = 0 To X.Length - 1
            Y.Add(polyval(Equation, "x", X(i)))
        Next

        For i = 0 To X.Length - 1
            NewSeries.Points.AddXY(X(i), Y.Item(i))
        Next
    End Sub
End Class
