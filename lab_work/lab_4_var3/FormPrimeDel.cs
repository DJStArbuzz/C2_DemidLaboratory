using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class FormPrimeDel : Form
    {
        public FormPrimeDel()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPicture.Checked)
                radioButtonBook.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBook.Checked)
                radioButtonPicture.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonPicture.Checked)
            {
                string Name = textBoxName.Text;
                string Author = textBoxAuthor.Text;

                foreach (var t in FormMain.Pictures)
                {
                    if (t.GetName() == Name && t.GetAuthor() == Author)
                    {
                        FormMain.Pictures.Remove(t);
                        FormMain.currPictures.Remove(t);
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                string Name = textBoxName.Text;
                string Author = textBoxAuthor.Text;

                foreach (var t in FormMain.Books)
                {
                    if (t.GetName() == Name && t.GetAuthor() == Author)
                    {
                        FormMain.Books.Remove(t);
                        FormMain.currBooks.Remove(t);
                        this.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("Не найден указанное произведение");
        }
    }
}
