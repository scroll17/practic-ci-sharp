using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР12
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            listView1.Items.Add(new ListViewItem(new string[] { "0", "0", "0", "0", "0" }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton3.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                if (radioButton1.Checked)
                {
                    listView1.Items[0].SubItems[0].Text = "1";
                }
                else
                {
                    listView1.Items[0].SubItems[0].Text = "0";
                }
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                if (radioButton8.Checked)
                {
                    listView1.Items[0].SubItems[1].Text = "1";
                }
                else
                {
                    listView1.Items[0].SubItems[1].Text = "0";
                }
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked || radioButton10.Checked || radioButton11.Checked || radioButton12.Checked)
            {
                if (radioButton12.Checked)
                {
                    listView1.Items[0].SubItems[2].Text = "1";
                }
                else
                {
                    listView1.Items[0].SubItems[2].Text = "0";
                }
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 31)
            {
                listView1.Items[0].SubItems[3].Text = "1";
            }
            else
            {
                listView1.Items[0].SubItems[3].Text = "0";
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox3.Checked && !checkBox2.Checked && checkBox4.Checked)
            {
                listView1.Items[0].SubItems[4].Text = "1";
            }
            else
            {
                listView1.Items[0].SubItems[4].Text = "0";
            }
            button5.Enabled = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
