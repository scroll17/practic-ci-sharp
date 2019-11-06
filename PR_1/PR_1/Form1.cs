using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int j = 0;
        private string prev;

        private void button1_Click(object sender, EventArgs e)
        {
            string next;
            string[] count = new string[] {"9", "8", "7", "6", "5", "4", "3", "2", "1", "нет"};

            if (j == 9){
                return;
            }

            prev = count[j++];
            prev += " число";

            listBox1.Items.Add(prev);

            next = count[j];
            next += " число";

            textBox1.Text = next;


        }
    }
}
