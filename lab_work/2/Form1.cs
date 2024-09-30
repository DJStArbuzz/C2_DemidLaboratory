using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization; // Необходимо для использования CultureInfo 


namespace lab2_C
{
    public partial class Form1 : Form
    {
        private TextBox[,] matrixTextBoxes;
        private int rows = 3; // Количество строк
        private int cols = 3; // Количество столбцов

        public Form1()
        {
            InitializeComponent();
            InitializeMatrixInputPanel(); // Инициализируем панели
        }

        private void WidthTrackBar_Scroll(object sender, EventArgs e)
        {
            cols = widthTrackBar.Value;
            InitializeMatrixInputPanel(); // Обновить панель ввода
        }

        private void HeightTrackBar_Scroll(object sender, EventArgs e)
        {
            rows = heightTrackBar.Value;
            InitializeMatrixInputPanel(); // Обновить панель ввода
        }

        private void InitializeMatrixInputPanel()
        {
            inputPanel.Controls.Clear(); // Очистить старые текстбоксы
            matrixTextBoxes = new TextBox[rows, cols];
            int textBoxWidth = 40;
            int textBoxHeight = 20;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixTextBoxes[i, j] = new TextBox
                    {
                        Width = textBoxWidth,
                        Height = textBoxHeight,
                        Location = new Point(j * textBoxWidth, i * textBoxHeight)
                    };
                    inputPanel.Controls.Add(matrixTextBoxes[i, j]);
                }
            }
        }


        private void showMatrixButton_Click(object sender, EventArgs e) // Обработчик для кнопки
        {
            ShowMatrix(outputPanel);
        }


        private void ShowMatrix(Panel outputPanel)
        {
            bool flag = false;
            outputPanel.Controls.Clear(); // Очистить предыдущее содержимое

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double aij;
                    string input = matrixTextBoxes[i, j].Text.Trim();
                    input = input.Replace(',', '.');

                    CultureInfo culture = CultureInfo.InvariantCulture; // Используем инвариантную культуру


                    // Если текст пустой, использовать "0" как значение по умолчанию
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        aij = 0;
                    }
                    else if (!double.TryParse(input, NumberStyles.Any, culture, out aij))
                    {
                        // Если неуспех, установите значение по умолчанию
                        aij = 0;
                        flag = true;
                    }

                    // Округление на основе позиции
                    if ((i + j) % 2 == 0)
                    {
                        aij = Math.Round(aij) + 1; // Добавляем 1 и округляем
                    }
                    else
                    {
                        aij = Math.Round(aij); // Округляем без добавления
                    }

                    // Создание метки для результата
                    Label label = new Label
                    {
                        Text = aij.ToString(),
                        Width = 40,
                        Height = 20,
                        Location = new Point(j * 40, i * 20)
                    };

                    outputPanel.Controls.Add(label); // Добавляем метку на outputPanel
                }
            }
        }

    }
}
