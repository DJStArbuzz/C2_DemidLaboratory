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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Обработка выбора типа поезда
        {
            if (radioButton1.Checked)//Убрать выбор поезда другого типа
                radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Обработка выбора типа поезда
        {
            if (radioButton2.Checked)//Убрать выбор поезда другого типа
                radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//Если выбран пассажирский поезд 
            {
                string Num = textBox1.Text;
                foreach (var t in Form1.PassTrains)//Поиск поезда по его номеру
                {
                    if (t.GetNum() == Num)
                    {
                        Form1.PassTrains.Remove(t);//Удаление поезда из списка
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                string Num = textBox1.Text;
                foreach (var t in Form1.FrTrains)//Поиск поезда по его номеру
                {
                    if (t.GetNum() == Num)
                    {
                        Form1.FrTrains.Remove(t);//Удаление поезда из списка
                        this.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("Не найден указанный поезд");
        }

    }
}
