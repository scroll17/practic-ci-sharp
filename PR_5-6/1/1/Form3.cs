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
    public partial class Form3 : Form
    {
        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=center.mdb";
        public int selectrow = -1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            string sql = "SELECT * FROM  Виды_услуг";
            OleDbCommand myCommand = new OleDbCommand(sql, connection);
            connection.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand myCommand;
            string sql;
            string NazvanieKategorii = textBox1.Text.ToString();
            sql = "INSERT INTO Виды_услуг (Название_вида )" +
                "VALUES(" +
                "'" + NazvanieKategorii + "'" +
                ")";
            myCommand = new OleDbCommand(sql, connection);
            connection.ConnectionString = ConnectionString;
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
            connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            sql = "SELECT * FROM Виды_услуг ";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            groupBox1.Visible = false;
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            selectrow = dataGridView1.CurrentCell.RowIndex;
            if (selectrow < (dataGridView1.RowCount - 1))
            {
                textBox2.Text = dataGridView1[0, selectrow].Value.ToString();
                textBox3.Text = dataGridView1[1, selectrow].Value.ToString();
                textBox4.Text = dataGridView1[0, selectrow].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            selectrow = dataGridView1.CurrentCell.RowIndex;
            if (selectrow < (dataGridView1.RowCount - 1))
            {
                textBox2.Text = dataGridView1[0, selectrow].Value.ToString();
                textBox3.Text = dataGridView1[1, selectrow].Value.ToString();
                textBox4.Text = dataGridView1[0, selectrow].Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectrow == -1 || selectrow >= dataGridView1.RowCount-1)
            {
                MessageBox.Show("Выделите в сетке строку для редактирования");
                return;
            }
           
                 OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = ConnectionString;
            OleDbCommand myCommand;
            string sql;
            string Kodkategorii=textBox2.Text.ToString();
            string NazvanieKategorii = textBox3.Text.ToString();
            sql = "UPDATE Виды_услуг SET " +
                "Название_вида = '" + NazvanieKategorii + "'" +
                "WHERE Код_вида = " + Kodkategorii;
            myCommand = new OleDbCommand(sql,connection);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
            connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            sql = "SELECT *FROM Виды_услуг";
            myCommand = new OleDbCommand(sql,connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds,"Результат");
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
            textBox2.Text = "";
            textBox3.Text = "";
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

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
            string Kodkategorii = textBox4.Text.ToString();
            sql = "DELETE * FROM Виды_услуг WHERE Код_вида = " + Kodkategorii;
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
            connection = new OleDbConnection();
            connection.ConnectionString = ConnectionString;
            sql = "SELECT * FROM Виды_услуг ";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
            groupBox3.Visible = false;

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = true;
            
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
            string znachenie = textBox5.Text.ToString();
            sql = "SELECT * FROM Виды_услуг WHERE " +
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
            sql = "SELECT * FROM Виды_услуг";
            myCommand = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(myCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "Результат");
            dataGridView1.DataSource = ds.Tables["Результат"].DefaultView;
            connection.Close();
            groupBox4.Visible = false;


        }

        private void поискДаннихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox5.Text = "";
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
