using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Обработка выбора типа поезда
        {
            if (radioButton1.Checked)
                radioButton2.Checked = false;//Убрать выбор поезда другого типа
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Обработка выбора типа поезда
        {
            if (radioButton2.Checked)
                radioButton1.Checked = false;//Убрать выбор поезда другого типа
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//Если выбран пассажирский поезд
            {
                string Num = textBox1.Text;
                for (int i = 0; i < Num.Length; i++)
                {
                    if (!Char.IsDigit(Num[i]))
                    {
                        MessageBox.Show("Выражение не число: " + Num + '\n');
                        return;
                    }
                }

                foreach (var t in Form1.PassTrains)//Поиск информации о поезде по его номеру
                {
                    for (int i = 0; i < Num.Length; i++)
                    {
                        if (!Char.IsDigit(Num[i]))
                        {
                            MessageBox.Show("Выражение не число: " + Num + '\n');
                            return;
                        }
                    }

                    if (t.GetNum() == int.Parse(Num))
                    {
                        MessageBox.Show("Найден поезд " + Num + '\n' + " Информация о нем: " + " Кол-во мест: " + t.GetKolm() + " Год выпуска: " + t.GetYear() + " Цвет: " + t.GetColor());
                        return;
                    }
                }
                MessageBox.Show("Не найден пассажирский поезд " + Num + '\n');
            }
            else//Если выбран грузовой поезд
            {
                string Num = textBox1.Text;
                foreach (var t in Form1.FrTrains)//Поиск информации о поезде по его номеру
                {
                    for (int i = 0; i < Num.Length; i++)
                    {
                        if (!Char.IsDigit(Num[i]))
                        {
                            MessageBox.Show("Выражение не число: " + Num + '\n');
                            return;
                        }
                    }

                    if (t.GetNum() == int.Parse(Num))
                    {
                        MessageBox.Show("Найден поезд " + Num + '\n' + " Информация о нем: " + " Вместимость: " + t.Cap + " Год выпуска: " + t.GetYear() + " Тип груза: " + t.Type);
                        return;
                    }
                }
                MessageBox.Show("Не найден грузовой поезд " + Num + '\n');
            }
        }
    }
}
