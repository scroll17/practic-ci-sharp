using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pr7
{
    public partial class Form1 : Form
    {
        public double kurs_usd = 23.98;
        public double kurs_rub = 2.15;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double usd;
            double grn;
            try
            {
                if (comboBox1.Text == "USD-UAH")
                {
                    usd = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = kurs_usd.ToString();
                    grn = usd * kurs_usd;
                    label3.Text = "Сумма = " + grn.ToString();
                }
                if (comboBox1.Text == "UAH-RUB")
                {
                    usd = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = kurs_rub.ToString();
                    grn = usd * kurs_rub;
                    label3.Text = "Сумма = " + grn.ToString();
                }
                if (comboBox1.Text == "UAH-USD")
                {
                    grn = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = (1 / kurs_usd).ToString();
                    grn = grn / kurs_usd;
                    label3.Text = "Сумма = " + grn.ToString();
                }
            }
            catch {
                label3.Text = "Ошибка";
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    textBox2.Focus();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "USD-UAH")
            {
                textBox2.Text = kurs_usd.ToString();
            }
            if (comboBox1.Text == "UAH-RUB")
            {
                textBox2.Text = kurs_rub.ToString();
            }
            if (comboBox1.Text == "UAH-USD")
            {
                textBox2.Text = (1 / kurs_usd).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

    }
}
