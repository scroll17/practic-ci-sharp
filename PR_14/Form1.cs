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

namespace ПР10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FunctionDrawer functionDrawer = new FunctionDrawer(pictureBox1.Width, pictureBox1.Height);
            functionDrawer.FuncColor = Color.Blue;
            pictureBox1.Image = functionDrawer.DrawFunction(-10, 10, Math.Sin, true);

            functionDrawer = new FunctionDrawer(pictureBox2.Width, pictureBox2.Height);
            functionDrawer.FuncColor = Color.Red;
            pictureBox2.Image = functionDrawer.DrawFunction(-10, 10, x => (x > 3) ? Math.Pow(x - 3, 2) - 1 : (2 - x), true);

            functionDrawer = new FunctionDrawer(pictureBox3.Width, pictureBox3.Height);
            functionDrawer.FuncColor = Color.CadetBlue;
            pictureBox3.Image = functionDrawer.DrawFunction(-10, 10, x => 3*x + 1, true);

            functionDrawer = new FunctionDrawer(pictureBox4.Width, pictureBox4.Height);
            functionDrawer.FuncColor = Color.Green;
            pictureBox4.Image = functionDrawer.DrawFunction(-11, 11, x => -x*x - x, true);

            DrawDiagram();
        }
        public void DrawDiagram()
        {
            StreamReader streamReader = new StreamReader("diagram.txt");

            string title = streamReader.ReadLine();
            int N = Convert.ToInt32(streamReader.ReadLine());

            string[] labels = new string[N];
            int[] counts = new int[N];
            double[] percents = new double[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                labels[i] = streamReader.ReadLine();
                counts[i] = Convert.ToInt32(streamReader.ReadLine());
                sum += counts[i];
            }

            for (int i = 0; i < N; i++)
            {
                percents[i] = (double)counts[i] / sum;
                Console.WriteLine($"{counts[i]} {percents[i]} {sum}");
            }

            Bitmap bitmap = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            Graphics g = Graphics.FromImage(bitmap);

            Font hFont = new Font("Tahoma", 12);
            int w = (int)g.MeasureString(title, hFont).Width;
            int x = (pictureBox6.Width - w) / 2;
            g.DrawString(title, hFont, Brushes.Black, x, 10);

            Font lFont = new Font("Tahoma", 9);

            int d = pictureBox6.Height - 70;
            int x0 = 30;
            int y0 = (pictureBox6.Height) / 2 - 130;

            int lx = 60 + d;
            int ly = y0 + (d - N * 20 + 10) / 2;

            int swe;
            Brush fBrush = Brushes.White;

            int sta = -90;

            Brush[] colors = new Brush[] {
                Brushes.YellowGreen,
                Brushes.Gold,
                Brushes.Pink,
                Brushes.Fuchsia,
                Brushes.OrangeRed,
                Brushes.RoyalBlue,
            };

            for (int i = 0; i < N; i++)
            {
                swe = (int)(360*percents[i]);
                fBrush = colors[i];

                if (i == N - 1)
                {
                    swe = 270 - sta;
                }

                g.FillPie(fBrush, x0, y0, d, d, sta, swe);
                g.DrawPie(Pens.Black, x0, y0, d, d, sta, swe);
                g.FillRectangle(fBrush, lx, ly + i * 20, 20, 10);
                g.DrawRectangle(Pens.Black, lx, ly + i * 20, 20, 10);
                g.DrawString(labels[i] + "-" + percents[i].ToString("P"), lFont, Brushes.Black, lx + 24, ly + i * 20 - 3);
                sta += swe;
            }

            pictureBox6.Image = bitmap;
        }
    }
}
