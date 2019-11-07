using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PR_3_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            for(int i=0; i<15; i++)
            {
                if(i == 5 || i == 10)
                {
                    dataGridView2.Rows.Add("Fruct " + i, Convert.ToString(i* 10));
                }else
                {
                    dataGridView1.Rows.Add("Fruct " + i, Convert.ToString(i * 10));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double size = double.Parse(textBox2.Text);

            if (size == 50 || size == 100)
            {
                dataGridView2.Rows.Add(name, Convert.ToString(size));
            }
            else
            {
                dataGridView1.Rows.Add(name, Convert.ToString(size));
            }

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
