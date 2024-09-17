

using System;
using System.Drawing;
using System.Windows.Forms;

using ZedGraph; //добавляем ZedGraph

namespace Program1
{
    public partial class Form1 : Form
    {
        private readonly double min = -10, max = 10, h = 0.2f; //начальные параметры, min - минимальное значение х, max - максимальное, h - шаг

        //функция
        public double F1(double x)
        {
            return (Math.Pow(x, 2) + 2 * x - 4);
           // return (5 * x + 1);
            //return (Math.Abs(x));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl1); //прорисовка графика
            SetSize(); //установление размера ZedGraphControl (заполняет всю форму)
            this.label1.Location = new Point(0, this.Height - this.label1.Height - 40);
        }

        public Form1()
        {
            InitializeComponent();
        }

        //размер ZedGraphControl подстраивается под изменение размера формы
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
            this.label1.Location = new Point(0, this.Height - this.label1.Height - 40);
        }

        //координаты
        private void zedGraphControl1_MouseMove(object sender, MouseEventArgs e)
        {
            double x, y;
            zedGraphControl1.GraphPane.ReverseTransform(e.Location, out x, out y);
            string text = string.Format("X: {0};    Y: {1}", x, y);
            label1.Text = text;
        }

        private void CreateGraph(ZedGraphControl zgc)
        {
            //получим панель для рисования
            GraphPane myPane = zgc.GraphPane;

            //заголовок и подписи осей
            myPane.Title.Text = "График";
            myPane.XAxis.Title.Text = "X";
            myPane.YAxis.Title.Text = "Y";

            double x, y;  //точки, по которым будет рисоваться график
            PointPairList list1 = new PointPairList(); //список точек

            //заполнение списка
            for (double i = min; i < max; i++)
            {
                x = i + h;
                y = F1(x);
                list1.Add(x, y);
            }

            LineItem myCurve = myPane.AddCurve("Функция", list1, Color.Blue, SymbolType.Star); //прорисовка графика по списку точек

            zgc.AxisChange(); //обновляем данные об осях, иначе на рисунке будет показана только та часть графика, которая умещается в интервалы по осям, установленные по умолчанию
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20,
                                    ClientRectangle.Height - 20);
        }
    }
}
