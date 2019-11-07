using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public double[] array = new double[5];
        public int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(index >= 4)
            {
                button1.Enabled = false;
            }

            double el = double.Parse(textBox1.Text);

            array[index++] = el;

            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double max = 0;
            double min = array[0];

            for(int i=0; i<array.Length; i++)
            { 

                if (array[i] > max)
                {
                    max = array[i] ;
                }

                if(array[i] < min)
                {
                    min = array[i];
                }
            }

            label1.Text += Convert.ToString(max);
            label2.Text += Convert.ToString(min);
            label3.Text += Convert.ToString(max + min);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[,] array = new int[3, 3];

            double sum = 0;
            int countSum = 0;

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    int randomValue = rand.Next(-8, 8);

                    if(randomValue >= 5 && randomValue <= 15)
                    {
                        sum += randomValue;
                        countSum++;
                    }

                    array[i, j] = randomValue;

                    listBox1.Items.Add("[" + i + "," + j + "]" + " = " + randomValue);
                }
            }

            label4.Text += Convert.ToString(sum / countSum);
        }
    }
}
