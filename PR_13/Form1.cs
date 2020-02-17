using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР13
{
    public partial class Form1 : Form
    {
        bool allowToContinue = true;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("1.txt");
            await streamWriter.WriteLineAsync($"{textBox1.Text} возрастом {textBox2.Text} лет");
            await streamWriter.WriteLineAsync($"Специальность: {textBox3.Text}");
            await streamWriter.WriteLineAsync($"Группа: {textBox4.Text}");
            await streamWriter.WriteLineAsync($"Бал: {textBox5.Text}");
            streamWriter.Close();
            streamWriter.Dispose();
            foreach (var item in new[] { textBox1, textBox2, textBox3, textBox4, textBox5 })
            {
                item.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fin = new FileStream("1.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter("2.txt");
            StreamReader streamReader = new StreamReader(fin);
            string buffer = streamReader.ReadToEnd();
            streamWriter.Write(buffer);
            streamReader.Close();
            streamReader.Dispose();
            streamWriter.Close();
            streamWriter.Dispose();
            richTextBox1.Text = buffer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            BinaryWriter binaryWriter = new BinaryWriter(File.Open("1.txt", FileMode.Create, FileAccess.Write));
            for (int i = 0; i < 12; i++)
            {
                binaryWriter.Write(random.Next(-10, 10));
            }
            binaryWriter.Close();
            binaryWriter.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Copy("1.txt", "2.txt", true);
            BinaryReader binaryReader = new BinaryReader(File.Open("2.txt", FileMode.OpenOrCreate));
            List<int> array = new List<int>();
            try
            {
                while (true)
                {
                    array.Add(binaryReader.ReadInt32());
                }
            }
            catch
            {
                richTextBox1.Text = "";
                for (int i = 0; i < array.Count; i++)
                {
                    richTextBox1.Text += array[i].ToString();
                    if (i != array.Count - 1)
                    {
                        richTextBox1.Text += ", ";
                    }
                }
                binaryReader.Close();
                binaryReader.Dispose();
            }
        }
    }
}
