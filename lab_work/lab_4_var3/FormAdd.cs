using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPicture.Checked)
            {
                radioButtonBook.Checked = false;
                labelMaterial.Visible = true;
                labelNumOfPages.Visible = false;
                labelCirculation.Visible = false;
                textBoxCirculation.Visible = false;
                textBoxCirculation.Text = "0";
                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBook.Checked)
            {
                radioButtonPicture.Checked = false;
                labelMaterial.Visible = false;
                labelNumOfPages.Visible = true;
                labelCirculation.Visible = true;
                textBoxCirculation.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string Author = textBoxAuthor.Text;
            string Price = textBoxPrice.Text;
            string Year = textBoxYear.Text;
            string Material = textBoxMaterial_NumOfPages.Text;
            string Circulation = textBoxCirculation.Text;

            int year, price, material = 0, circulation;
            if (Name == "" || Author == "" || Price == "" || Year == "" || Material == "" || Circulation == "")
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }

            if (radioButtonBook.Checked)
            {
                try
                {
                    material = Convert.ToInt32(Material);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Поля имеют неверный формат");
                    return;
                }
            }
            try//Проверка на валидность полей
            {
                circulation = Convert.ToInt32(Circulation);
                price = Convert.ToInt32(Price);
                year = Convert.ToInt32(Year);
            }
            catch (System.FormatException) {
                MessageBox.Show("Поля имеют неверный формат");
                return;
            }
            if (radioButtonPicture.Checked)
            {
                foreach (var t in FormMain.Pictures)
                {
                    if (t.GetName() == Name && t.GetAuthor() == Author)
                    {
                        MessageBox.Show("Такая картина уже существует");
                        textBoxName.ResetText();
                        textBoxAuthor.ResetText();
                        textBoxPrice.ResetText();
                        textBoxYear.ResetText();
                        textBoxMaterial_NumOfPages.ResetText();
                        return;
                    }
                }
                Picture curr = new Picture(Name, Author, price, year, Material);
                FormMain.Pictures.Add(curr);
                FormMain.currPictures.Add(curr);
            }
            else
            {
                foreach (var t in FormMain.Books)
                {
                    if (t.GetName() == Name && t.GetAuthor() == Author)
                    {
                        MessageBox.Show("Такая книга уже существует");
                        return;
                    }
                }

                Book tmp = new Book(Name, Author, price, year, material, circulation);
                FormMain.Books.Add(tmp);
                FormMain.currBooks.Add(tmp);
            }
            this.Close();
        }
    }
}
