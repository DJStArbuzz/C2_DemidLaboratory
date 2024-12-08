using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class FormSort : Form
    {
        public string SortCriterion { get; private set; }

        public FormSort()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (radioButtonName.Checked)
                SortCriterion = "Name";
            else if (radioButtonAuthor.Checked)
                SortCriterion = "Author";
            else if (radioButtonPrice.Checked)
                SortCriterion = "Price";

            else if (radioButtonYear.Checked)
                SortCriterion = "Year";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
