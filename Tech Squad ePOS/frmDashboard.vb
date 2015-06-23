Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim MyTable As DataTable

        'MyTable = getPoItemsReport()
        MyTable = getPurchaseOrdersReport("complete")

        Chart1.DataSource = MyTable
        dgvItems.DataSource = MyTable

        With Chart1.ChartAreas(0)
            .Area3DStyle.Enable3D = True
            .AxisY.Interval = 250
        End With
        With Chart1.Series(0)
            '.Name = "Purchase Orders"
            '.Font = New Font("Arial", 8, FontStyle.Italic)
            '.BackGradientStyle = GradientStyle.TopBottom
            '.Color = Color.Purple
            '.BackSecondaryColor = Color.Magenta
            '.IsValueShownAsLabel = True
            '.LabelBackColor = Color.LightYellow
            '.LabelForeColor = Color.Blue
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            '.XValueType = DataVisualization.Charting.ChartValueType.Date
            '.YValueType = DataVisualization.Charting.ChartValueType.Double
            '.XValueMember = "Supplier"
            .XValueMember = "Date"
            .YValueMembers = "Total"

            '.Points.DataBind(MyTable.DefaultView, "Supplier", "Total", Nothing)
        End With
        'Chart1.DataBindTable(MyTable)
    End Sub
End Class