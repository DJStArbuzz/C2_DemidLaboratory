﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace SimpleSignal
{
    public partial class MainForm : Form
    {
        private StatusStrip statusStrip;
        private List<(double x, double y)> criticalPoints1 = new List<(double, double)>();
        private List<(double x, double y)> zeros1 = new List<(double, double)>();

        private List<(double x, double y)> criticalPoints2 = new List<(double, double)>();
        private List<(double x, double y)> zeros2 = new List<(double, double)>();


        public MainForm()
        {
            InitializeComponent();

            // Создаем StatusStrip
            statusStrip = new StatusStrip();
            this.Controls.Add(statusStrip);

            // Создаем дополнительное поле для отображения точек
            TextBox outputTextBox = new TextBox
            {
                Multiline = true,
                Width = 300,
                Height = 200,
                Dock = DockStyle.Bottom,
                ScrollBars = ScrollBars.Vertical
            };
            this.Controls.Add(outputTextBox);

            DrawGraph(outputTextBox);

            // Подписываемся на событие движения мыши
            zedGraph.MouseMove += new MouseEventHandler(zedGraph_MouseMove);
        }


        private bool AreAlmostEqual(double a, double b, double epsilon = 1e-10)
        {
            return Math.Abs(a - b) < epsilon;
        }

        private double f(double x)
        {
            if(AreAlmostEqual(x, -1) || (AreAlmostEqual(x, 1)))
            {
                criticalPoints1.Add((x, double.NaN));
 
        
                return double.NaN;
            }

            double result = x * 1.0 / ((x + 1.0) * (1 - x) * (1 - x));
            if(AreAlmostEqual(result, 0))
            {
                zeros1.Add((x, result));

            }

            return result;
        }

        private double g(double x)
        {
            if (AreAlmostEqual(x, -1) || (AreAlmostEqual(x, 1)))
            {
                criticalPoints2.Add((x, double.NaN));
                return double.NaN;
            }

            double result = (Math.Pow(1 - x, 2) * (x + 1) - x * (Math.Pow(1 - x, 2) - 2 * (1 - x) * (1 + x))) /
                            (Math.Pow(1 - x, 4) * Math.Pow(x + 1, 4));
            if(AreAlmostEqual(result, 0))
            {
                zeros2.Add((x, result));
            }

            return result;
        }

        private void DrawGraph(TextBox outputTextBox)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();
            double xmin = -10;
            double xmax = 10;

            for (double x = xmin; x <= xmax; x += 0.01)
            {
                double y = f(x);
                if (!double.IsNaN(y)) // Проверка, чтобы избежать добавления NaN значений
                {
                    list.Add(x, y);
                }
                else
                {
                    list.Add(PointPairBase.Missing, PointPairBase.Missing);
                }
            }

            for (double x = xmin; x <= xmax; x += 0.01)
            {
                double y = g(x);
                if (!double.IsNaN(y)) // Проверка, чтобы избежать добавления NaN значений
                {
                    list2.Add(x, y);
                }
                else
                {
                    list2.Add(PointPairBase.Missing, PointPairBase.Missing);
                }
            }

            LineItem myCurve2 = pane.AddCurve("Second", list2, Color.Red, SymbolType.None); // Исправлено использование list2
            LineItem myCurve = pane.AddCurve("Main", list, Color.Blue, SymbolType.None);

            pane.YAxis.Scale.Min = -10;
            pane.YAxis.Scale.Max = 10;

            // Устанавливаем положение осей
            pane.XAxis.MajorTic.IsBetweenLabels = true;
            pane.YAxis.MajorTic.IsBetweenLabels = true;

            pane.XAxis.Title.IsVisible = false; // Скрываем заголовок X
            pane.YAxis.Title.IsVisible = false; // Скрываем заголовок Y

            pane.XAxis.Cross = 0; // Пересечение X-оси по Y
            pane.YAxis.Cross = 0; // Пересечение Y-оси по X

            zedGraph.AxisChange();
            zedGraph.Invalidate();

            // Выводим критические точки и нули
            outputTextBox.Clear();
            outputTextBox.AppendText("Критические точки функции: ");
            foreach (var point in criticalPoints1)
            {
                outputTextBox.AppendText($"({Math.Round(point.x)}, NaN), ");
            }
            outputTextBox.AppendText("\r\nНули функции: ");
            foreach (var zero in zeros1)
            {
                outputTextBox.AppendText($"({Math.Round(zero.x)}, {Math.Round(zero.y)}), ");
            }
            outputTextBox.AppendText("\r\nКритические точки производной: ");
            foreach (var point in criticalPoints2)
            {
                outputTextBox.AppendText($"({Math.Round(point.x, 2)}, NaN), ");
            }
            outputTextBox.AppendText("\r\nНули производной: ");
            foreach (var zero in zeros2)
            {
                outputTextBox.AppendText($"({Math.Round(zero.x, 2)}, {Math.Round(zero.y)}), ");
            }
        }

        private void zedGraph_MouseMove(object sender, MouseEventArgs e)
        {
            // Получаем координаты мыши относительно графика
            GraphPane pane = zedGraph.GraphPane;
            double x, y;

            pane.ReverseTransform(e.Location, out x, out y);

            // Обновляем статусный бар с координатами
            if (x >= -10 && x <= 10 && y >= -10 && y <= 10) // Проверка, что координаты в пределах графика
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add($"X: {x:F2}, Y: {y:F2}");
            }
        }
    }
}
