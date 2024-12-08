using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab4
{
    public partial class FormBookEditDel : Form
    {

        private string bookName;
        private string bookAuthor;
        private int bookPrice;
        private int bookYear;
        private int bookNumOfPages;
        private int bookCirculation;

        public FormBookEditDel(Book book)
        {
            InitializeComponent();

            this.bookName = book.GetName();
            this.bookAuthor = book.GetAuthor();
            this.bookPrice = book.GetPrice();
            this.bookYear = book.GetYear();
            this.bookNumOfPages = book.GetNumOfPages();
            this.bookCirculation = book.GetCirculation();

            // Заполнение полей
            textBoxName.Text = bookName;
            textBoxAuthor.Text = bookAuthor;
            textBoxPrice.Text = bookPrice.ToString();
            textBoxYear.Text = bookYear.ToString();
            textBoxNumOfPages.Text = bookNumOfPages.ToString();
            textBoxCirculation.Text = bookCirculation.ToString();

            textBoxName.Enabled = false;
            textBoxAuthor.Enabled = false;
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            bool isDeleting = checkBoxDelete.Checked;
            textBoxPrice.Enabled = !isDeleting;
            textBoxYear.Enabled = !isDeleting;
            textBoxNumOfPages.Enabled = !isDeleting;
            textBoxCirculation.Enabled = !isDeleting;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked) 
            {
                foreach (var t in FormMain.Books)
                {
                    if (t.GetName() == bookName)
                    {
                        FormMain.Books.Remove(t);
                        FormMain.currBooks.Remove(t);
                        MessageBox.Show("Книга удалена из базы.");
                        this.Close();
                        return;
                    }
                }

            }
            else 
            {
                if (string.IsNullOrWhiteSpace(textBoxYear.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNumOfPages.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCirculation.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                int newYear = int.Parse(textBoxYear.Text);
                int newPrice = int.Parse(textBoxPrice.Text);
                int newNumOfPages = int.Parse(textBoxNumOfPages.Text);
                int newCirculation = int.Parse(textBoxCirculation.Text);

                for (int i = 0; i < FormMain.Books.Count; i++)
                {
                    if (FormMain.Books[i].GetName() == bookName)
                    {
                        FormMain.Books[i].SetYear(newYear);
                        FormMain.Books[i].SetPrice(newPrice);
                        FormMain.Books[i].SetNumOfPages(newNumOfPages);
                        FormMain.Books[i].SetCirculation(newCirculation);
                        MessageBox.Show("Запись о книге успешно изменена.");
                        this.Close();
                        return;
                    }
                }

            }
        }
    }
}
