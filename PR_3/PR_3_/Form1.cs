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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double m = -13.10457;
        private double n = 83.34577;


        private void button1_Click(object sender, EventArgs e)
        {
            double Y;

            Y = ( Math.Pow(m, 2) - Math.Sqrt(n - 1)) / ( (1 / Math.Pow(m, 3)) - 3*m*n );

            label1.Text = Convert.ToString(Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double E;

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            E = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);

            label2.Text = Convert.ToString(E);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
