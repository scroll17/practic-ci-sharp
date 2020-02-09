using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР08
{
    public partial class Form1 : Form
    {
        List<Сountry> countries = new List<Сountry>();
        public Form1()
        {
            InitializeComponent();
            AllCounties();
        }

        private void AllCounties()
        {
            countries.Add(new Сountry());
            countries.Add(new Сountry("Ukraine", "Zelenskiy", 1200, 125));
            countries.Add(new Сountry("Ukraine2", "Zelenskiy2", 1700, 135));
            countries.Add(new Сountry("Ukraine3", "Zelenskiy3", 2200, 195));
            countries.Add(new Сountry(countries[0]));
        }

        private ListViewItem GetListViewItemFormFlight(Сountry country)
        {
            return new ListViewItem(new string[] {
                country.Name,
                country.President,
                country.Population.ToString(),
                country.Square.ToString(),
                country.Density.ToString()
            });
        }

        private void FillListView(List<Сountry> countries)
        {
            listView1.Items.Clear();
            foreach (Сountry country in countries)
            {
                listView1.Items.Add(GetListViewItemFormFlight(country));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillListView(countries);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Площадь всех стран = " + Сountry.getSumOfAllSquareCountries;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
