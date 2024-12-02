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
    public partial class Form6 : Form
    {
        public string SortCriterion { get; private set; }

        public Form6()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (radioButtonNum.Checked)
                SortCriterion = "Num";
            else if (radioButtonSize.Checked)
                SortCriterion = "Size";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
