using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace pr7
{
    public partial class Form2 : Form
    {
        double baseprice = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 739000;
            textBox1.Text = baseprice.ToString("C");
            Bitmap image1 = new Bitmap("lexus.jpg");
            pictureBox1.Image = image1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 132500;
            textBox1.Text = baseprice.ToString("C");
            Bitmap image1 = new Bitmap("chery.jpg");
            pictureBox1.Image = image1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 536500;
            textBox1.Text = baseprice.ToString("C");
            Bitmap image1 = new Bitmap("audi.jpg");
            pictureBox1.Image = image1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 634000;
            textBox1.Text = baseprice.ToString("C");
            Bitmap image1 = new Bitmap("chevrolet.jpg");
            pictureBox1.Image = image1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 837800;
            textBox1.Text = baseprice.ToString("C");
            Bitmap image1 = new Bitmap("mersedes.jpg");
            pictureBox1.Image = image1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            sum += baseprice;
            if (checkBox1.Checked) sum += 15000;
            if (checkBox2.Checked) sum += 2300;

            switch (comboBox1.SelectedIndex)
            {
                case 0: sum -= sum * 0; break;
                case 1: sum -= sum * 0.05; break;
                case 2: sum -= sum * 0.1; break;
                case 3: sum -= sum * 0.2; break;
            }
            textBox2.Text = sum.ToString("C");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            { listBox1.Items.Add(checkedListBox1.CheckedItems[i]); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
                Process.Start("https://www.google.com.ua/");
            else if (radioButton2.Checked)
                Process.Start("https://www.google.com.ua/");
            else if (radioButton3.Checked)
                Process.Start("https://www.google.com.ua/");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("EROR", maskedTextBox1, maskedTextBox1.Location, 1000);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
