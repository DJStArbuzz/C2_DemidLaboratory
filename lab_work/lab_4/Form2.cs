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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Обработка выбора типа поезда
        {
            if (radioButton1.Checked)//Если выбран пассажирский поезд
            {
                radioButton2.Checked = false;//Убрать выбор грузового поезда
                //Вывести соответствующие текстовые поля(тип груза и вместимость скрыть, кол-во мест и цвет показать)
                label2.Visible = true;
                label3.Visible = false;
                label5.Visible = true;
                label6.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Обработка выбора типа поезда
        {
            if (radioButton2.Checked)//Если выбран грузовой поезд
            {
                radioButton1.Checked = false;//Убрать выбор пассажирского поезда
                //Вывести соответствующие текстовые поля(тип груза и вместимость показать, кол-во мест и цвет скрыть)
                label3.Visible = true;
                label2.Visible = false;
                label6.Visible = true;
                label5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)//Обработка кнопки ДОБАВИТЬ
        {
            string Num = textBoxNum.Text;
            string size = textBoxCap_Size.Text;
            string year = textBoxYear.Text;
            string Type = textBoxType.Text;
            int Size;
            int Year;
            if(Num == "" || size == "" || year == "" || Type == "")//Проверка на заполненность всех полей
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }
            try//Проверка на валидность полей
            {
                Size = Convert.ToInt32(size);
                Year = Convert.ToInt32(year);
            }
            catch (System.FormatException) {
                MessageBox.Show("Поля имеют неверный формат");
                return;
            }
            if (radioButton1.Checked)//Если добавляем пассажирский поезд
            {
                foreach (var t in Form1.PassTrains)//Проверка на уникальность пассажирского поезда по номеру
                {
                    if (t.GetNum() == int.Parse(Num))
                    {
                        MessageBox.Show("Такой номер пассажирского поезда уже существует");
                        textBoxNum.ResetText();
                        textBoxCap_Size.ResetText();
                        textBoxYear.ResetText();
                        textBoxType.ResetText();
                        return;
                    }
                }
                Form1.PassTrains.Add(new PassTrain(int.Parse(Num), Size, Year, Type));//Добавление поезда
                Form1.PassTrains.Sort();
            }
            else//Если добавляем грузовой поезд
            {
                foreach (var t in Form1.FrTrains)//Проверка на уникальность грузового поезда по номеру
                {
                    if (t.GetNum() == int.Parse(Num))
                    {
                        MessageBox.Show("Такой номер грузового поезда уже существует");
                        return;
                    }
                }
                Form1.FrTrains.Add(new FrTrain(int.Parse(Num), Size, Year, Type));//Добавление поезда
                Form1.FrTrains.Sort();
            }
            this.Close();
        }
    }
}
