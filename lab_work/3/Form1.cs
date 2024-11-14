using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace SimpleSignal
{
    public partial class Form1 : Form
    {
        private HashSet<(double x, double y)> zeros3 = new();
        private HashSet<(double x, double y)> criticalPoints3 = new();
        private HashSet<(double x, double y)> zeros4 = new();
        private HashSet<(double x, double y)> criticalPoints4 = new();

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Blue);
            Pen pen2 = new Pen(Color.Red);
            Pen axisPen = new Pen(Color.Black);

            g.Clear(Color.White);

            g.DrawLine(axisPen, 0, 200, 400, 200);
            g.DrawLine(axisPen, 200, 0, 200, 400);

            double xmin = -10;
            double xmax = 10;
            float previousX1 = float.NaN, previousY1 = float.NaN;
            float previousX2 = float.NaN, previousY2 = float.NaN;

            for (double x = xmin; x <= xmax; x += 0.01)
            {
                double y = f(x);
                if (!double.IsNaN(y))
                {
                    float currentX = (float)(x * 20 + 200);
                    float currentY = (float)(-y * 20 + 200);

                    // Draw the line for function f(x)
                    if (!float.IsNaN(previousX1) && !float.IsNaN(previousY1))
                    {
                        g.DrawLine(pen1, previousX1, previousY1, currentX, currentY);
                    }

                    previousX1 = currentX;
                    previousY1 = currentY;
                }
                else
                {
                    previousX1 = float.NaN;
                    previousY1 = float.NaN;  // Reset if there's a discontinuity
                }
            }

            for (double x = xmin; x <= xmax; x += 0.01)
            {
                double y2 = g2(x);
                if (!double.IsNaN(y2))
                {
                    float currentX = (float)(x * 20 + 200);
                    float currentY = (float)(-y2 * 20 + 200);

                    // Draw the line for function g2(x)
                    if (!float.IsNaN(previousX2) && !float.IsNaN(previousY2))
                    {
                        g.DrawLine(pen2, previousX2, previousY2, currentX, currentY);
                    }

                    previousX2 = currentX;
                    previousY2 = currentY;
                }
                else
                {
                    previousX2 = float.NaN;
                    previousY2 = float.NaN;  // Reset if there's a discontinuity
                }
            }

            outputTextBox.Clear();
            outputTextBox.AppendText("Критические точки функции: ");
            foreach (var point in criticalPoints3)
            {
                outputTextBox.AppendText($"({Math.Round(point.x, 2)}, NaN), ");
            }
            outputTextBox.AppendText("\r\nНули функции: ");
            foreach (var zero in zeros3)
            {
                outputTextBox.AppendText($"({Math.Round(zero.x, 2)}, {Math.Round(zero.y, 2)}), ");
            }
            outputTextBox.AppendText("\r\nКритические точки производной: ");
            foreach (var point in criticalPoints4)
            {
                outputTextBox.AppendText($"({Math.Round(point.x, 2)}, NaN), ");
            }
            outputTextBox.AppendText("\r\nНули производной: ");
            foreach (var zero in zeros4)
            {
                outputTextBox.AppendText($"({Math.Round(zero.x, 2)}, {Math.Round(zero.y, 2)}), ");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double x = (e.X - 200) / 20.0; 
            double y = (200 - e.Y) / 20.0;
            if (x >= -10 && x <= 10 && y >= -10 && y <= 10)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add($"X: {x:F2}, Y: {y:F2}");
            }
        }

        private double f(double x)
        {
            if (AreAlmostEqual(x, -1) || AreAlmostEqual(x, 1))
            {
                criticalPoints3.Add((x, double.NaN));
                return double.NaN;
            }

            double result = x * 1.0 / ((x + 1.0) * (1 - x) * (1 - x));
            if (AreAlmostEqual(result, 0))
                zeros3.Add((x, result));
            return result;
        }

        private double g2(double x)
        {
            if (AreAlmostEqual(x, -1) || AreAlmostEqual(x, 1))
            {
                criticalPoints4.Add((x, double.NaN));
                return double.NaN;
            }

            double result = (Math.Pow(1 - x, 2) * (x + 1) - x * (Math.Pow(1 - x, 2) - 2 * (1 - x) * (1 + x))) /
                            (Math.Pow(1 - x, 4) * Math.Pow(x + 1, 4));
            if (AreAlmostEqual(result, 0))
                zeros4.Add((x, result));

            return result;
        }

        private bool AreAlmostEqual(double a, double b)
        {
            return Math.Abs(a - b) < 1e-10;
        }
    }
}
