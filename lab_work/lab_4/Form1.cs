using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public static List<PassTrain> PassTrains = new List<PassTrain>();//список пассажирских поездов
        public static List<FrTrain> FrTrains = new List<FrTrain>();//список грузовых поездов
        public Form1()
        {
            InitializeComponent();
            passengerTrainsTable.CellClick += dataGridView1_CellClick; // Привязка события
            FreightTrainsTable.CellClick += dataGridView2_CellClick; // Привязка события
        }

        private void update()//Обновляет данные в dataGridView1 и dataGridView2
        {
            passengerTrainsTable.Rows.Clear();
            FreightTrainsTable.Rows.Clear();
            int n = PassTrains.Count;
            if(n > 0)
                passengerTrainsTable.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                passengerTrainsTable.Rows[i].Cells["Num"].Value = PassTrains[i].GetNum();
                passengerTrainsTable.Rows[i].Cells["Size"].Value = PassTrains[i].GetKolm();
                passengerTrainsTable.Rows[i].Cells["Year"].Value = PassTrains[i].GetYear();
                passengerTrainsTable.Rows[i].Cells["Color"].Value = PassTrains[i].GetColor();
            }
            n = FrTrains.Count;
            if(n > 0)
                FreightTrainsTable.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                FreightTrainsTable.Rows[i].Cells["Num"].Value = FrTrains[i].GetNum();
                FreightTrainsTable.Rows[i].Cells["Size"].Value = FrTrains[i].GetCap();
                FreightTrainsTable.Rows[i].Cells["Year"].Value = FrTrains[i].GetYear();
                FreightTrainsTable.Rows[i].Cells["Type"].Value = FrTrains[i].GetType();
            }
        }

        private void Form1_Load(object sender, EventArgs e)//Происходит при запуске приложения
        {
            passengerTrainsTable.Columns.Clear();
            passengerTrainsTable.ReadOnly = true;
            passengerTrainsTable.AllowUserToAddRows = false;
            passengerTrainsTable.AllowUserToDeleteRows = false;
            //dataGridView1.AutoResizeColumns();
            passengerTrainsTable.Columns.Add("Num", "Номер");
            passengerTrainsTable.Columns.Add("Size", "Кол-во мест");
            passengerTrainsTable.Columns.Add("Year", "Год выпуска");
            passengerTrainsTable.Columns.Add("Color", "Цвет");
            //dataGridView1.RowCount = 1;

            FreightTrainsTable.Columns.Clear();
            FreightTrainsTable.ReadOnly = true;
            FreightTrainsTable.AllowUserToAddRows = false;
            FreightTrainsTable.AllowUserToDeleteRows = false;
            //dataGridView2.AutoResizeColumns();
            FreightTrainsTable.Columns.Add("Num", "Номер");
            FreightTrainsTable.Columns.Add("Size", "Вместимость");
            FreightTrainsTable.Columns.Add("Year", "Год выпуска");
            FreightTrainsTable.Columns.Add("Type", "Тип груза");
            //dataGridView2.RowCount = 1;

            // начальный набор данных    
            PassTrains.Add(new PassTrain(100, 2010, 200, "зеленый"));
            PassTrains.Add(new PassTrain(4, 1990, 300, "синий"));
            PassTrains.Add(new PassTrain(10, 2015, 1000, "красный"));
            FrTrains.Add(new FrTrain(961, 1980, 2000, "опасный"));
            FrTrains.Add(new FrTrain(765, 1991, 1020, "жидкий"));
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что клик был по строке
            if (e.RowIndex >= 0)
            {
                // Получаем данные о поезде из выбранной строки
                string trainNumber = passengerTrainsTable.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Создаем новое окно формы изменения/удаления
                Form7 f = new Form7(trainNumber);
                f.Owner = this;
                f.ShowDialog();

                // Обновление данных в DataGridView после закрытия диалога
                update();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что клик был по строке
            if (e.RowIndex >= 0)
            {
                // Получаем данные о поезде из выбранной строки
                string trainNumber = FreightTrainsTable.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Создаем новое окно формы изменения/удаления
                Form9 f = new Form9(trainNumber);
                f.Owner = this;
                f.ShowDialog();

                // Обновление данных в DataGridView после закрытия диалога
                update();
            }
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

        private void button5_Click(object sender, EventArgs e)//Обработка кнопки ФИЛЬТР
        {
            using (Form6 form6 = new Form6())
            {
                if (form6.ShowDialog() == DialogResult.OK)
                {
                    string sortCriterion = form6.SortCriterion;
                    SortData(sortCriterion);
                    update();
                }
            }
        }

        private void SortData(string sortCriterion)
        {
            if (sortCriterion == "Num")
            {
                PassTrains = PassTrains.OrderBy(train => train.GetNum()).ToList();
                FrTrains = FrTrains.OrderBy(train => train.GetNum()).ToList();
            }
            else if (sortCriterion == "Size")
            {
                PassTrains = PassTrains.OrderBy(train => train.GetKolm()).ToList();
                FrTrains = FrTrains.OrderBy(train => train.GetCap()).ToList();
            }
        }
    }

    public class Train : IComparable// класс Поезда
    {
        private int num;//  номер
        private int year;//  год выпуска

        // доступ к полям
        public int GetNum()
        { return num; }
        // доступ к полям
        public void SetNum(int value)
        { num = value; }
        // доступ к полям
        public int GetYear()
        { return year; }
        // доступ к полям
        public void SetYear(int value)
        { year = value; }


        public Train(int _num, int _year)    // конструктор с параметрами
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

        public int GetSeats()
        { return kolm; }
        // доступ к полям

        public void SetSeats(int value)
        { kolm = value; }

        // конструктор с параметрами
        public PassTrain(int _num, int _year, int _kolm, string _color)
            : base(_num, _year)
        {
            kolm = _kolm;// количество мест
            color = _color;// цвет 
        }
    }

    // класс FrTrain (Грузовые поезда) наследуется от класса Train 
    public class FrTrain : Train
    {
        private int capacity;// вместимость
        private string type;// тип груза

        // доступ к полям
        public int Cap { get { return capacity; } set { Cap = capacity; } }
        public string Type { get { return type; } set { Type = type; } }

        public int GetCap()
        { return capacity; }
        // доступ к полям

        public void SetCap(int value)
        { capacity = value; }

        public string GetType()
        { return Type; }
        // доступ к полям

        public void SetType(string value)
        { type = value; }

        // конструктор с параметрами
        public FrTrain(int _num, int _year, int _cap, string _type)
            : base(_num, _year)
        {
            capacity = _cap;
            type = _type;
        }
    }
}

