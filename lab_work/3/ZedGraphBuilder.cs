using System;
using System.Windows.Forms;
using ZedGraph;

public class ZedGraphBuilder
{
    private readonly ZedGraphControl zedGraphControl;
    private readonly TextBox outputTextBox;

    public ZedGraphBuilder(Panel panel, TextBox textBox)
    {
        outputTextBox = textBox;
        zedGraphControl = new ZedGraphControl { Dock = DockStyle.Fill };
        panel.Controls.Add(zedGraphControl);
    }

    public void DrawGraph()
    {
        zedGraphControl.MouseMove += ZedGraphControl_MouseMove;
        BuildGraph();
    }

    private void BuildGraph()
    {
        GraphPane myPane = zedGraphControl.GraphPane;
        myPane.Title.Text = "График функции и её производной";
        myPane.XAxis.Title.Text = "X";
        myPane.YAxis.Title.Text = "Y";

        PointPairList functionPoints = new PointPairList();
        PointPairList derivativePoints = new PointPairList();

        for (double x = -2; x <= 2; x += 0.01)
        {
            double y = Function(x);
            double dy = Derivative(x);
            functionPoints.Add(x, y);
            derivativePoints.Add(x, dy);
        }

        LineItem functionCurve = myPane.AddCurve("y = f(x)", functionPoints, System.Drawing.Color.Blue, SymbolType.None);
        LineItem derivativeCurve = myPane.AddCurve("y' = f'(x)", derivativePoints, System.Drawing.Color.Red, SymbolType.None);

        zedGraphControl.AxisChange();
        zedGraphControl.Invalidate();
    }

    private double Function(double x)
    {
        if (x != 1 && x != -1)
        {
            return x / ((1 + x) * (1 - x) * (1 - x));
        }

        return 0;
    }

    private double Derivative(double x)
    {
        // Здесь вы должны реализовать вычисление производной функции.
        // Упрощенная формула производной для y = x / ((1+x)(1-x)^2) например:
        return x / ((1 + x) * (1 - x) * (1 - x));
    }

    private void ZedGraphControl_MouseMove(object sender, MouseEventArgs e)
    {
        // Логика отображения координат при наведении мыши
    }
}
