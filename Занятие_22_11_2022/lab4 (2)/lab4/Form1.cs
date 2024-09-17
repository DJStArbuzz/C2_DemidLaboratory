using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace lab4
{
    public partial class Form1 : Form
    {
        public static List<PassTrain> PassTrains = new List<PassTrain>();//список пассажирских поездов
        public static List<FrTrain> FrTrains = new List<FrTrain>();//список грузовых поездов
        public Form1()
        {
            InitializeComponent();
        }

        private void update()//Обновляет данные в dataGridView1 и dataGridView2
        {
            dataGridView1.Rows.Clear();
            int n = PassTrains.Count;
            if(n > 0)
                dataGridView1.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                dataGridView1.Rows[i].Cells["Num"].Value = PassTrains[i].GetNum();
                dataGridView1.Rows[i].Cells["Size"].Value = PassTrains[i].GetKolm();
                dataGridView1.Rows[i].Cells["Year"].Value = PassTrains[i].GetYear();
                dataGridView1.Rows[i].Cells["Color"].Value = PassTrains[i].GetColor();
            }
            dataGridView2.Rows.Clear();
            n = FrTrains.Count;
            if(n > 0)
                dataGridView2.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                dataGridView2.Rows[i].Cells["Num"].Value = FrTrains[i].GetNum();
                dataGridView2.Rows[i].Cells["Size"].Value = FrTrains[i].Cap;
                dataGridView2.Rows[i].Cells["Year"].Value = FrTrains[i].GetYear();
                dataGridView2.Rows[i].Cells["Type"].Value = FrTrains[i].Type;
            }
        }

        private void Form1_Load(object sender, EventArgs e)//Происходит при запуске приложения
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            //dataGridView1.AutoResizeColumns();
            dataGridView1.Columns.Add("Num", "Номер");
            dataGridView1.Columns.Add("Size", "Кол-во мест");
            dataGridView1.Columns.Add("Year", "Год выпуска");
            dataGridView1.Columns.Add("Color", "Цвет");
            //dataGridView1.RowCount = 1;

            dataGridView2.Columns.Clear();
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            //dataGridView2.AutoResizeColumns();
            dataGridView2.Columns.Add("Num", "Номер");
            dataGridView2.Columns.Add("Size", "Вместимость");
            dataGridView2.Columns.Add("Year", "Год выпуска");
            dataGridView2.Columns.Add("Type", "Тип груза");
            //dataGridView2.RowCount = 1;

            // начальный набор данных    
            PassTrains.Add(new PassTrain("100", 2010, 200, "зеленый"));
            PassTrains.Add(new PassTrain("004", 1990, 300, "синий"));
            PassTrains.Add(new PassTrain("010", 2015, 1000, "красный"));
            FrTrains.Add(new FrTrain("961", 1980, 2000, "опасный"));
            FrTrains.Add(new FrTrain("765", 1991, 1020, "жидкий"));
            PassTrains.Sort();
            FrTrains.Sort();
            update();
        }

        private void button1_Click(object sender, EventArgs e)//Обработка кнопки ДОБАВИТЬ
        {
            //Создание нового окна
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
            //Обновление данных в dataGridView1 и dataGridView2
            update();
        }

        private void button3_Click(object sender, EventArgs e)//Обработка кнопки УДАЛИТЬ
        {
            //Создание нового окна
            Form4 f = new Form4();
            f.Owner = this;
            f.ShowDialog();
            //Обновление данных в dataGridView1 и dataGridView2
            update();
        }

        private void button4_Click(object sender, EventArgs e)//Обработка кнопки ПОИСК
        {
            //Создание нового окна
            Form5 f = new Form5();
            f.Owner = this;
            f.ShowDialog();
        }
    }

    public class Train : IComparable// класс Поезда
    {
        private string num;//  номер
        private int year;//  год выпуска

        // доступ к полям
        public string GetNum()
        { return num; }
        // доступ к полям
        public void SetNum(string value)
        { num = value; }
        // доступ к полям
        public int GetYear()
        { return year; }
        // доступ к полям
        public void SetYear(int value)
        { year = value; }

        public Train(string _num, int _year)    // конструктор с параметрами
        {
            num = _num;
            year = _year;
        }

        public int CompareTo(object o)
        {
            Train p = o as Train;
            if (p != null)
                return this.num.CompareTo(p.num);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    // класс PassTrain (Пассажирские поезда) наследуется от класса Train 
    public class PassTrain : Train
    {
        private int kolm;// количество мест
        private string color;// цвет

        // доступ к полям
        public int GetKolm()
        { return kolm; }
        // доступ к полям
        public void SetKolm(int value)
        { kolm = value; }
        // доступ к полям
        public string GetColor()
        { return color; }
        // доступ к полям
        public void SetColor(string value)
        { color = value; }

        // конструктор с параметрами
        public PassTrain(string _num, int _year, int _kolm, string _color)
            : base(_num, _year)
        {
            kolm = _kolm;// количество мест
            color = _color;// цвет 
        }
    }

    // класс FrTrain (Грузовые поезда) наследуется от класса Train 
    public class FrTrain : Train
    {
        private int cap;// вместимость
        private string type;// тип груза

        // доступ к полям
        public int Cap { get { return cap; } set { Cap = cap; } }
        public string Type { get { return type; } set { Type = type; } }

        // конструктор с параметрами
        public FrTrain(string _num, int _year, int _cap, string _type)
            : base(_num, _year)
        {
            cap = _cap;
            type = _type;
        }
    }
}

