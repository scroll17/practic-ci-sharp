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
    public partial class Form1 : Form    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EnableCommands(bool estate)
        {
            saveAsItem.Enabled = estate;
            closeToolItem.Enabled = estate;
            halfSizeItem.Enabled = estate;
            normalSizeItem.Enabled = estate;
            doubleSizeItem.Enabled = estate;
            popDoubleSizeItem.Enabled = estate;
            popNormalSizeItem.Enabled = estate;
            popHalfSizeItem.Enabled = estate;
            saveBtn.Enabled = estate;
            halfBtn.Enabled = estate;
            normalBtn.Enabled = estate;
            doubleBtn.Enabled = estate;

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You exit...");
            
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBarToolStripMenuItem.Checked = !toolBarToolStripMenuItem.Checked;
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void halfSizeItem_Click(object sender, EventArgs e)
        {
            halfSizeItem.Checked = true;
            normalSizeItem.Checked = false;
            doubleSizeItem.Checked = false;
            popHalfSizeItem.Checked = true;
            popNormalSizeItem.Checked = false;
            popDoubleSizeItem.Checked = false;
            pictureBox1.Height /= 2;
            pictureBox1.Width /= 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void normalSizeItem_Click(object sender, EventArgs e)
        {
            halfSizeItem.Checked = false;
            normalSizeItem.Checked = true;
            doubleSizeItem.Checked = false;
            popHalfSizeItem.Checked = false;
            popNormalSizeItem.Checked = true;
            popDoubleSizeItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void doubleSizeItem_Click(object sender, EventArgs e)
        {
            halfSizeItem.Checked = false;
            normalSizeItem.Checked = false;
            doubleSizeItem.Checked = true;
            popHalfSizeItem.Checked = false;
            popNormalSizeItem.Checked = false;
            popDoubleSizeItem.Checked = true;
            pictureBox1.Height *= 2;
            pictureBox1.Width *= 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void openToolItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                EnableCommands(true);
                normalSizeItem.PerformClick();
            }
            
        }

        private void closeToolItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Height = 0;
            pictureBox1.Width = 0;
            normalSizeItem.PerformClick();
            EnableCommands(false);
        }

        private void halfSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            halfSizeItem.Checked = true;
            normalSizeItem.Checked = false;
            doubleSizeItem.Checked = false;
            popHalfSizeItem.Checked = true;
            popNormalSizeItem.Checked = false;
            popDoubleSizeItem.Checked = false;
            pictureBox1.Height /= 2;
            pictureBox1.Width /= 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void popNormalSizeItem_Click(object sender, EventArgs e)
        {
            halfSizeItem.Checked = false;
            normalSizeItem.Checked = true;
            doubleSizeItem.Checked = false;
            popHalfSizeItem.Checked = false;
            popNormalSizeItem.Checked = true;
            popDoubleSizeItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void popDoubleSizeItem_Click(object sender, EventArgs e)
        {
            halfSizeItem.Checked = false;
            normalSizeItem.Checked = false;
            doubleSizeItem.Checked = true;
            popHalfSizeItem.Checked = false;
            popNormalSizeItem.Checked = false;
            popDoubleSizeItem.Checked = true;
            pictureBox1.Height *= 2;
            pictureBox1.Width *= 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            openToolItem.PerformClick();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveAsItem.PerformClick();
        }

        private void halfBtn_Click(object sender, EventArgs e)
        {
            halfBtn.Checked = true;
            normalBtn.Checked = false;
            doubleBtn.Checked = false;
            halfSizeItem.PerformClick();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            halfBtn.Checked = false;
            normalBtn.Checked = true;
            doubleBtn.Checked = false;
            normalSizeItem.PerformClick();
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            halfBtn.Checked = false;
            normalBtn.Checked = false;
            doubleBtn.Checked = true;
            doubleSizeItem.PerformClick();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void formNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FormName;
            FormName = toolStripTextBox1.Text;
            this.Text = FormName;
            toolStripTextBox1.Text = "";
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            AboutForm form2 = new AboutForm();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[5];
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                string ar = Microsoft.VisualBasic.Interaction.InputBox("vvod", "win", "");
                a[i] = Convert.ToInt16(ar);
                s = s + a[i];
            }
            textBox5.Text = Convert.ToString(s);
        }

        private void newDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
