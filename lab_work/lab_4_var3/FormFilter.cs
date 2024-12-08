using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class FormFilter : Form
    {
        public FormFilter()
        {
            InitializeComponent();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text.Trim();

            bool isFiltering = false;

            if (checkBoxBooks.Checked || checkBoxPictures.Checked)
            {
                if (checkBoxBooks.Checked)
                {
                    FormMain.currBooks.Clear();
                    isFiltering = true;
                    FilterBooks(input);
                }

                if (checkBoxPictures.Checked)
                {
                    FormMain.currPictures.Clear();
                    isFiltering = true;
                    FilterPictures(input);
                }
            }
            else
            {
                MessageBox.Show("Выберите хотя бы один тип произведения.");
                return;
            }

            if (!isFiltering)
            {
                MessageBox.Show("Не выбрано никаких критериев для фильтрации.");
            }
            else
            {
                this.Close(); // Закрываем форму после фильтрации
            }
        }

        private void FilterBooks(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите значение для фильтрации.");
                return;
            }

            if (radioButtonByName.Checked)
            {
                foreach (Book curr in FormMain.Books)
                {
                    if (curr.GetName().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        FormMain.currBooks.Add(curr);
                    }
                }
            }
            else if (radioButtonByAuthor.Checked)
            {
                foreach (Book curr in FormMain.Books)
                {
                    if (curr.GetAuthor().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        FormMain.currBooks.Add(curr);
                    }
                }
            }
            else
            {
                FormMain.currBooks = FormMain.Books;
                return;
            }
        }

        private void FilterPictures(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите значение для фильтрации.");
                return;
            }

            if (radioButtonByName.Checked)
            {
                foreach (Picture curr in FormMain.Pictures)
                {
                    if (curr.GetName().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        FormMain.currPictures.Add(curr);
                    }
                }
            }
            else if (radioButtonByAuthor.Checked)
            {
                foreach (Picture curr in FormMain.Pictures)
                {
                    if (curr.GetAuthor().Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        FormMain.currPictures.Add(curr);
                    }
                }
            }
            else
            {
                FormMain.currPictures = FormMain.Pictures;
                return;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (checkBoxBooks.Checked)
            {
                FormMain.currBooks.Clear();
                FormMain.currBooks.AddRange(FormMain.Books);
            }
            if (checkBoxPictures.Checked)
            {
                FormMain.currPictures.Clear();
                FormMain.currPictures.AddRange(FormMain.Pictures);
            }
            this.Close();
        }
    }
}
