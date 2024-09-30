using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization; // Необходимо для использования CultureInfo 
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace lab2_C
{

    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

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

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void ShowMatrix(Panel outputPanel)
        {
            panelError.ResetText();
            List<Pair<int, int>> listOFErrors = new List<Pair<int, int>>();

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
                        listOFErrors.Add(new Pair<int,int>(i, j));
                    }
                    else if (!double.TryParse(input, NumberStyles.Any, culture, out aij))
                        if (string.IsNullOrWhiteSpace(input))
                        {
                            aij = 0;
                            listOFErrors.Add(new Pair<int, int>(i, j));
                        }
                    else if (!IsDigitsOnly(input))
                        {
                            aij = 0;
                            listOFErrors.Add(new Pair<int, int>(i, j));
                        }
                    // Если неуспех, установите значение по умолчанию
                    // Округление на основе позиции
                    if ((i + j) % 2 == 0)
                        aij = Math.Round(aij) + 1; // Добавляем 1 и округляем
                    else
                        aij = Math.Round(aij); // Округляем без добавления

                    // Создание метки для результата
                    Label label = new Label
                    {
                        Text = aij.ToString(),
                        Width = 40,
                        Height = 20,
                        Location = new Point(j * 40, i * 20)
                    };

                    // Добавляем метку на outputPanel  
                    outputPanel.Controls.Add(label);    }   }


            String message = "Ошибки допущены в элементах: ";
            if (listOFErrors.Count == 0)
            {
                message = "Ошибок при заполнении нет.";
            }
            
            for (int i = 0; i < listOFErrors.Count; i++)
            {
                message += ("(" + (listOFErrors[i].First + ", " + listOFErrors[i].Second + "), "));
            }

            Label labelErr = new Label
            {
                Text = message.ToString(),
                Width = 1000,
                Height = 30,

            };
            panelError.Controls.Clear();
            panelError.Controls.Add(labelErr);
        } }}
