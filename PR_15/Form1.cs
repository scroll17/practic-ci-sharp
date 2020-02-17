using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР15
{
    public partial class Form1 : MetroForm
    {
        PrintDocument documentToPrint = new PrintDocument();
        public Form1()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager;
        }

        private void btnAlingLeft_Click(object sender, EventArgs e)
        {
            textArea.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnAlingConter_Click(object sender, EventArgs e)
        {
            textArea.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnAlingRight_Click(object sender, EventArgs e)
        {
            textArea.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(File.Open(openFileDialog1.FileName, FileMode.Open));
                textArea.Text = stream.ReadToEnd();
                stream.Close();
                stream.Dispose();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(File.Open(saveFileDialog1.FileName, FileMode.Create));
                stream.Write(textArea.Text);
                stream.Close();
                stream.Dispose();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textArea.ForeColor = colorDialog1.Color;
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textArea.Font = fontDialog1.Font;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = "";
                if (!String.IsNullOrEmpty(openFileDialog1.FileName))
                    s = openFileDialog1.FileName;
                if (!String.IsNullOrEmpty(saveFileDialog1.FileName))
                    s = openFileDialog1.FileName;

                PrintDocument pd = new PrintDocument();
                pd.DocumentName = s;
                pd.Print();
            }
        }
    }
}
