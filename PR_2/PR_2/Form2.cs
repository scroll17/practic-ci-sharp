using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("5", "4", "3", "2", "1");


            dataGridView1[0, 2].Value = "new";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int R = dataGridView1.CurrentCell.RowIndex;
            int C = dataGridView1.CurrentCell.ColumnIndex;

            this.Text = " R = " + R + " C = " + C;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 100;
        }
    }
}
