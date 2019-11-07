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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int col = int.Parse(textBox1.Text);

            for(int i=1; i <= col; i++)
            {
                listBox1.Items.Add("Золотаренко : 18 : 4.8");
            }
        }
    }
}
