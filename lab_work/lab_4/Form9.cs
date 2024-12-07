using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab4
{
    public partial class Form9 : Form
    {
        private string trainNumber;
        private string trainYear;
        private string trainSize;
        private string trainType;

        public Form9(FrTrain train)
        {
            InitializeComponent();
            this.trainNumber = train.GetNum().ToString();
            this.trainYear = train.GetYear().ToString();
            this.trainSize = train.GetCap().ToString();
            this.trainType = train.GetType().ToString();


            // Заполнение полей
            textBoxTrainNumber.Text = trainNumber;
            textBoxCapacity.Text = trainSize;
            textBoxYear.Text = trainYear;
            textBoxColor.Text = trainType;

            textBoxTrainNumber.Enabled = false;
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            bool isDeleting = checkBoxDelete.Checked;

            // Блокируем изменение номера 
            textBoxCapacity.Enabled = !isDeleting;
            textBoxYear.Enabled = !isDeleting;
            textBoxColor.Enabled = !isDeleting;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked) // Если выбран режим удаления
            {
                // Удаляем поезд
                foreach (var t in Form1.FrTrains)
                {
                    if (t.GetNum() == int.Parse(trainNumber))
                    {
                        Form1.FrTrains.Remove(t);
                        MessageBox.Show("Пассажирский поезд успешно удален.");
                        this.Close();
                        return;
                    }
                }

            }
            else // Если выбран режим изменения
            {
                // Проверка заполненности полей
                if (string.IsNullOrWhiteSpace(textBoxTrainNumber.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCapacity.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYear.Text) ||
                    string.IsNullOrWhiteSpace(textBoxColor.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                int newTrainNumber = int.Parse(textBoxTrainNumber.Text);
                int newTrainCapacity = int.Parse(textBoxCapacity.Text);
                int newTrainYear = int.Parse(textBoxYear.Text);
                string newColor = textBoxColor.Text; // Предполагается, что это будет год

                // Обработка изменения для пассажирских поездов
                for (int i = 0; i < Form1.FrTrains.Count; i++)
                {
                    if (Form1.FrTrains[i].GetNum() == int.Parse(trainNumber))
                    {
                        Form1.FrTrains[i].SetNum(newTrainNumber);
                        Form1.FrTrains[i].SetCap(newTrainCapacity); // Количество мест
                        Form1.FrTrains[i].SetYear(newTrainYear); // Год выпуска
                        Form1.FrTrains[i].SetType(newColor); // Цвет
                        MessageBox.Show("Запись о пассажирском поезде успешно изменена.");
                        this.Close();
                        return;
                    }
                }

            }
        }
    }
}
