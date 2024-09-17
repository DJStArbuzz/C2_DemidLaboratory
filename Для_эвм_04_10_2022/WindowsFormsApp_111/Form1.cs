using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_111
{
    public partial class Form1 : Form
    {
        int n;
        double[] X;
        double[] Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            n = (int)numericUpDown1.Value;
            dataGridView1.AutoResizeColumns();
            for (int i = 1; i < n + 1; i++)
            {
                dataGridView1.Columns.Add("New", "Y" + i.ToString());
            }
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            X = new double[n];
            Y = new double[n];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            dataGridView2.ReadOnly = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            //n = (int)numericUpDown1.Value;
            dataGridView2.AutoResizeColumns();
            for (int i = 0; i < n; i++)
            {
                dataGridView2.Columns.Add("New", "Y" + (i + 1).ToString());
            }
            dataGridView2.ColumnCount = n;
            dataGridView2.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    X[j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                var sortedRow = from u in X
                                orderby u ascending
                                select u;
                int k = 0;
                foreach (double u in sortedRow)
                {
                    dataGridView2.Rows[i].Cells[k].Value = u;
                    k++;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
