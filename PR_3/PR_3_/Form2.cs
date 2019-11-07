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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int printer = 800;
        private string text = "Остаточная цена : ";
        private string skidka = "Скидка : ";

        private void button1_Click(object sender, EventArgs e)
        {
            double monitor = double.Parse(textBox1.Text);

            double sum = monitor + printer;

            if (sum > 2000) {
                label3.Text = skidka + "15%";
                label2.Text = text + Convert.ToString(sum - (sum * 0.15));
            }
            else if (sum >= 1000) {
                label3.Text = skidka + "10%";
                label2.Text = text + Convert.ToString(sum - (sum * 0.10));
            }else
            {
                label3.Text = skidka + "0%";
                label2.Text = text + Convert.ToString(sum);
            }
        }
    }
}
