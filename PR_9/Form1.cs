using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ПР9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChangeControlState(false);
        }

        private void ChangeControlState(bool state)
        {
            saveAsToolStripMenuItem.Enabled = state;
            closeToolStripMenuItem.Enabled = state;
            stretchImageSizeToolStripMenuItem.Enabled = state;
            normalToolStripMenuItem.Enabled = state;
            autoSizeToolStripMenuItem.Enabled = state;
            centerImageToolStripMenuItem.Enabled = state;
            zoomToolStripMenuItem.Enabled = state;
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBarToolStripMenuItem.Checked = !toolBarToolStripMenuItem.Checked;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                ChangeControlState(true);
            }
        }

        private void HandleToolStripMenuItem_Button_CheckedChanged(object sender, EventArgs e)
        {
            List<ToolStripMenuItem> toolStripMenuItems = new List<ToolStripMenuItem>(new ToolStripMenuItem[]{
                stretchImageSizeToolStripMenuItem,
                autoSizeToolStripMenuItem,
                zoomToolStripMenuItem,
                normalToolStripMenuItem,
                centerImageToolStripMenuItem,
            });

            string itemName = (sender as ToolStripButton).Name.Replace("_button", "");

            switch (itemName)
            {
                case "stretchImageSizeToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "autoSizeToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "zoomToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "normalToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "centerImageToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }

            toolStripMenuItems
                .FindAll(x => x.Name != itemName)
                .ForEach(x => x.Checked = false);

            toolStripMenuItems.Find(x => x.Name == itemName).Checked = true;
        }

        private void HandleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            List<ToolStripMenuItem> toolStripMenuItems = new List<ToolStripMenuItem>(new ToolStripMenuItem[]{
                stretchImageSizeToolStripMenuItem,
                autoSizeToolStripMenuItem,
                zoomToolStripMenuItem,
                normalToolStripMenuItem,
                centerImageToolStripMenuItem,
            });

            string itemName = (sender as ToolStripMenuItem).Name.Replace("_context", "").Replace("_button", "");

            switch (itemName)
            {
                case "stretchImageSizeToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "autoSizeToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "zoomToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "normalToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "centerImageToolStripMenuItem":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }

            toolStripMenuItems
                .FindAll(x => x.Name != itemName)
                .ForEach(x => x.Checked = false);

            toolStripMenuItems.Find(x => x.Name == itemName).Checked = true;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click(sender, e);
            stretchImageSizeToolStripMenuItem_button.Enabled = true;
            centerImageToolStripMenuItem_button.Enabled = true;
            zoomToolStripMenuItem_button.Enabled = true;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            stretchImageSizeToolStripMenuItem.Checked = false;
            autoSizeToolStripMenuItem.Checked = false;
            zoomToolStripMenuItem.Checked = false;
            centerImageToolStripMenuItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
