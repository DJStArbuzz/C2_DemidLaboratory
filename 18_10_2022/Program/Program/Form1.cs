using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        private float minx, maxx, miny, maxy, W, H, W1, H1, dx, dy, h;

        //координаты
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            double x = (e.X - W1) / dx;
            double y = (H1 - e.Y) / dy;
            string text = string.Format("X: {0};    Y: {1}", x, y);
            label1.Text = text;
        }

        //исходная функция
        public double F1(double x)
        {
            return (Math.Pow(x, 2) + 2 * x - 4);
            //return (5 * x + 1);
            //return (Math.Abs(x));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //рисуем оси
            e.Graphics.DrawLine(Pens.Black, W1, 0, W1, H);
            e.Graphics.DrawLine(Pens.Black, 0, H1, W, H1);

            //подпись осей
            Font Fon = new Font("Arial", 9, FontStyle.Regular);
            Brush Br = Brushes.Black;
            e.Graphics.DrawString("X", Fon, Br, W - 15, H1 + 10);
            e.Graphics.DrawString("Y", Fon, Br, W1 - 20, 10);

            //стрелки
            e.Graphics.DrawLine(Pens.Black, W - 10, H1 - 3, W, H1);
            e.Graphics.DrawLine(Pens.Black, W - 10, H1 + 3, W, H1);
            e.Graphics.DrawLine(Pens.Black, W1, 0, W1 - 3, 10);
            e.Graphics.DrawLine(Pens.Black, W1, 0, W1 + 3, 10);

            //линейка
            Font Fon1 = new Font("Arial", 6, FontStyle.Regular);
            for (int i = (int)miny; i < maxy; i++)
            {
                e.Graphics.DrawLine(Pens.Black, W1 - 1, H1 + dy * i, W1 + 1, H1 + dy * i);
                e.Graphics.DrawString((-(float)(i)).ToString(), Fon1, Br, W1 - 15, H1 + dy * i);
            }
            for (int i = (int)minx; i < maxx; i++)
            {
                e.Graphics.DrawLine(Pens.Black, W1 + dx * i, H1 + 1, W1 + dx * i, H1 - 1);
                if (i != 0)
                    e.Graphics.DrawString(i.ToString(), Fon1, Br, W1 + dx * i - 10, H1 + 10);
            }


            //строим график
            float ixPrev = minx, iyPrev = (float)F1(ixPrev);              // координаты предыдущей точки функции f
            float x1, y1;                                                  // координаты текущей точки при построении функции f

            // проходим по всем точкам на форме, вычисляем x1 и значение функции в точке х1
            for (float ix = ixPrev + h; ix < maxx; ix += h)
            {
                x1 = ix;                //х1, y1 - координаты следующей точки, h - шаг
                y1 = (float)F1(x1);
                e.Graphics.DrawLine(Pens.Green, W1 - dx * ixPrev, H1 - dy * iyPrev, W1 - dx * x1, H1 - dy * y1);    // строим линию, соединяющую 2 точки
                iyPrev = y1;
                ixPrev = x1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            W = pictureBox1.Width;
            H = pictureBox1.Height;
            W1 = W / 2;
            H1 = H / 2;
            miny = -10;
            maxy = 10;
            minx = -10;
            maxx = 10;
            h = 0.2f;
            dx = W / (maxx - minx);
            dy = H / (maxy - miny);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
