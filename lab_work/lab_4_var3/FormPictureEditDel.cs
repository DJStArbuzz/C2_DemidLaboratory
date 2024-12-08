using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class FormPictureEditDel : Form
    {
        private string pictureName;
        private string pictureAuthor;
        private int picturePrice;
        private int pictureYear;
        private string pictureMaterial;

        public FormPictureEditDel(Picture picture)
        {
            InitializeComponent();
            this.pictureName = picture.GetName().ToString();
            this.pictureAuthor = picture.GetYear().ToString();
            this.picturePrice =  int.Parse(picture.GetPrice().ToString());
            this.pictureYear = int.Parse(picture.GetYear().ToString());
            this.pictureMaterial = picture.GetMaterial().ToString();


            // Заполнение полей
            textBoxName.Text = pictureName;
            textBoxAuthor.Text = pictureAuthor;
            textBoxPrice.Text = picturePrice.ToString();
            textBoxYear.Text = pictureYear.ToString();
            textBoxMaterial.Text = pictureMaterial;

            textBoxName.Enabled = false;
            textBoxAuthor.Enabled = false;
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            bool isDeleting = checkBoxDelete.Checked;

            // Блокируем изменение номера 
            textBoxPrice.Enabled = !isDeleting;
            textBoxYear.Enabled = !isDeleting;
            textBoxMaterial.Enabled = !isDeleting;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked) 
            {
                foreach (var t in FormMain.Pictures)
                {
                    if (t.GetName() == pictureName)
                    {
                        FormMain.Pictures.Remove(t);
                        FormMain.currPictures.Remove(t);
                        MessageBox.Show("Картина удалена из базы.");
                        this.Close();
                        return;
                    }
                }

            }
            else 
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYear.Text) || 
                         string.IsNullOrWhiteSpace(textBoxMaterial.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                int newYear = int.Parse(textBoxYear.Text);
                int newPrice = int.Parse(textBoxPrice.Text);
                string newMaterial = textBoxMaterial.Text;

                    for (int i = 0; i < FormMain.Pictures.Count; i++)
                    {
                        if (FormMain.Pictures[i].GetName() == pictureName)
                        {
                        FormMain.Pictures[i].SetPrice(newPrice);
                        FormMain.Pictures[i].SetMaterial(newMaterial);
                        FormMain.Pictures[i].SetYear(newYear);

                            MessageBox.Show("Запись о картине успешно изменена.");
                            this.Close();
                            return;
                        }
                    }
               
            }
        }
    }
}
