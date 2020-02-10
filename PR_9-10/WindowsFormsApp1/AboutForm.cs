using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutForm : Form
    {
        Form1 f1 = new Form1();
        double sum = 0;
        double kol = 3;
        double sr;
        public AboutForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add('1', "Математика", 2);
            dataGridView1.Rows.Add('2', "Биология", 2);
            dataGridView1.Rows.Add('3', "Физика", 4);
            for(int i = 0; i < 3; i++)
            {
                 sum += Convert.ToInt32(dataGridView1[2, i].Value);
         
            }
           sr = sum / kol;
            textBox11.Text = Convert.ToString(sr);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Гордеев";
            textBox2.Text = "Данил";
            textBox3.Text = "Андреевич";
            textBox4.Text = "20 сентября 2001";
            textBox5.Text = "69112";
            textBox6.Text = "Запорожье";
            textBox7.Text = "Алексеева";
            textBox8.Text = "92";
            textBox9.Text = "2";
            textBox10.Text = "Мама, папа";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            f1.textBox1.Text = this.textBox1.Text;
            f1.textBox2.Text = this.textBox2.Text;
            f1.textBox3.Text = this.textBox3.Text;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rang;
            if (sr > 4.75)
            {
                rang = "Відмінник";
            }
            else if ((sr < 4.75) && (sr > 3.75))
            {
                rang = "Хорошист";
            }
            else
            {
                rang = "Трієчник";
            }

            f1.textBox4.Text = rang;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
