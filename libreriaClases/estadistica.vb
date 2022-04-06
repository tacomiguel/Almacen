Imports System
Imports dotnetCHARTING.WinForms
Public Class estadistica
    Sub CreateChart(ByRef Chart1 As Chart)
        'set global properties
        'Chart1.DefaultSeries.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;user id=admin;password=;data source=d:\database\chartsample.mdb"
        'Chart1.Title = "sales"
        'Chart1.XAxis.Label.Text = "Days"
        'Chart1.TempDirectory = "temp"
        'Chart1.Type = ChartType.Scatter
        'Chart1.Debug = True
        'Chart1.LegendBox.Template = "%icon%name"

        ''set Axis timeInterval
        'Chart1.XAxis.TimeInterval = dotnetCHARTING.WinForms.TimeInterval.Days
        'Chart1.XAxis.Scale = Scale.Time
        ''Add a series
        'Chart1.Series.Name = "Items"
        'Chart1.Series.Type = SeriesType.Spline
        'Chart1.Series.StartDate = New System.DateTime(2002, 1, 1, 0, 0, 0)
        'Chart1.Series.EndDate = New System.DateTime(2002, 1, 5, 23, 59, 59)
        'Chart1.Series.SqlStatement = "SELECT OrderDate,Sum(Total) FROM Orders  WHERE OrderDate >= #STARTDATE# AND OrderDate <= #ENDDATE#  GROUP BY Orders.OrderDate ORDER BY Orders.OrderDate"
        'Chart1.SeriesCollection.Add()
    End Sub
End Class