using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _1
{
    public partial class Form2 : Form
    {
        public int selectrow = -1;
        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=center.mdb";
        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
           
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            string sql = "SELECT * FROM Услуги";
            OleDbCommand myCommand = new OleDbCommand(sql, connection);
            connection.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

            selectrow = dataGridView1.CurrentCell.RowIndex;
            if (selectrow < (dataGridView1.RowCount - 1))
            {
                textBox1.Text = dataGridView1[0, selectrow].Value.ToString();
                textBox7.Text = dataGridView1[1, selectrow].Value.ToString();
                textBox8.Text = dataGridView1[2, selectrow].Value.ToString();
                textBox9.Text = dataGridView1[3, selectrow].Value.ToString();
                textBox10.Text = dataGridView1[4, selectrow].Value.ToString();
                textBox11.Text = dataGridView1[5, selectrow].Value.ToString();
                textBox12.Text = dataGridView1[5, selectrow].Value.ToString();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }


        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;

            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            OleDbCommand myCommand;
            string sql;
            string Nazva = textBox2.Text.ToString();
            string KodKategorii = textBox3.Text.ToString();
            string Cinaod = textBox4.Text.ToString();
            string Opis = textBox5.Text.ToString();
            string KodKraini = textBox6.Text.ToString();
            sql = "INSERT INTO Услуги " +
                "(Код_вида,Формат,Количество,Единицы_измерения,Стоимость) " +
                "VALUES(" 
                 + Nazva + ",'" +
                KodKategorii + " '," +
                Cinaod + ",' " +
                 Opis + "' ," +
                KodKraini +
                " )";
            // MessageBox.Show(sql);

            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
            connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            sql = "SELECT * FROM Услуги";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            selectrow = dataGridView1.CurrentCell.RowIndex;
            if (selectrow < (dataGridView1.RowCount - 1))
            {
                textBox1.Text = dataGridView1[0, selectrow].Value.ToString();
                textBox7.Text = dataGridView1[1, selectrow].Value.ToString();
                textBox8.Text = dataGridView1[2, selectrow].Value.ToString();
                textBox9.Text = dataGridView1[3, selectrow].Value.ToString();
                textBox10.Text = dataGridView1[4, selectrow].Value.ToString();
                textBox11.Text = dataGridView1[5, selectrow].Value.ToString();
                textBox12.Text = dataGridView1[0, selectrow].Value.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectrow == -1 || selectrow >= dataGridView1.RowCount - 1)
            {
                MessageBox.Show("Выделите в сетке строку для редактирования");
                return;
            }
          
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            OleDbCommand myCommand;
            string sql;
            //Код_вида,Формат,Количество,Единицы_измерения,Стоимость
            string Kodtovara = textBox1.Text.ToString();
            string Nazva = textBox7.Text.ToString();
            string KodKategorii = textBox8.Text.ToString();
            string Cinaod = textBox9.Text.ToString();
            string Opis = textBox10.Text.ToString();
            string KodKraini = textBox11.Text.ToString();
            sql = "UPDATE Услуги SET " +

                "Код_вида = ' " + Nazva + "' , " +
                "Формат ='" + KodKategorii + "'" + "," +
                "Количество = " + Cinaod + "," +
                "Единицы_измерения = '" + Opis + "'" + "," +
                "Стоимость = '" + KodKraini + "'" +
                "Where Код_услуги = " + Kodtovara;
            //MessageBox.Show(sql);
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
            connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            sql = "SELECT * From Услуги";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
            groupBox2.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (selectrow == -1 || selectrow >= dataGridView1.RowCount - 1)
            {
                MessageBox.Show("Выделите в сетке строку для удаления");
                return;

            }
       
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            OleDbCommand myCommand;
            string sql;
            string Kodtovara = textBox12.Text.ToString();
            sql = "DELETE * FROM Услуги WHERE Код_услуги = " + Kodtovara;
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
            connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            sql = "SELECT *FROM Услуги";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
            groupBox3.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите критерий поиска");
                return;
            }
          
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            OleDbCommand myCommand;
            string sql;
            string kriteriy = comboBox1.SelectedItem.ToString();
            string znachenie = textBox13.Text.ToString();
            sql = "SELECT * FROM Услуги WHERE " +
                kriteriy + " Like " + " '" + znachenie + "' ";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            OleDbCommand myCommand;
            string sql;
            sql = "SELECT * FROM Услуги";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
            groupBox4.Visible = false;
        }

        private void поискДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox13.Text = "";
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
