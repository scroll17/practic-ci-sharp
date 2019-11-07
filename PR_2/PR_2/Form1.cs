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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a = 12;
        private int b = 20;

        private void button2_Click(object sender, EventArgs e)
        {
            string task1 = "" + (a + b);
            string task2 = "" + (a - b);

            label1.Text = task1;
            label2.Text = task2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.Show();
        }
    }
}
