using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Designaciones
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from asignaciones WHERE id_asignacion LIKE '%" + textBox1.Text + "%'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            dataGridView1.Rows.Clear();
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(Convert.ToString(reader.GetInt64(0)), Convert.ToString(reader.GetInt64(1)), Convert.ToString(reader.GetInt64(2)), 
                            Convert.ToString(reader.GetInt64(3)), Convert.ToString(reader.GetDateTime(4)));
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("id_asignacion", "id_asignaciones");
            dataGridView1.Columns.Add("id_cliente", "id_cliente");
            dataGridView1.Columns.Add("id_artefacto", "id_artefacto");
            dataGridView1.Columns.Add("id_usuario", "id_usuario");
            dataGridView1.Columns.Add("fecha", "fecha");



            if (Form1.idioma == "2")
            {
                button1.Text = "Search";
                button2.Text = "Add";
                button4.Text = "Update";
                button3.Text = "Delete";
                button5.Text = "Exit";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //Agregar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "insert into asignaciones values(NULL," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + dateTimePicker1.Value.Date.ToString("yyyMMdd") + ")";
            //+ dateTimePicker1.Value.Year.ToString() + "-"+ dateTimePicker1.Value. + "-" + dateTimePicker1.Value.Day.ToString() + ")";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
           

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                button1_Click(sender, e); //Buscar
            }
            catch(Exception ex)
            {
                MessageBox.Show("El formato no es correcto. \n Por favor ingrese un valor en cada parammetro." + ex.Message, "Mensaje de error.");
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "delete from asignaciones where id_asignacion=" + textBox2.Text;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                button1_Click(sender, e); //Buscar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\nEspecifique el id de quien desea eliminar.", "Mensaje de error.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Modificar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "update asignaciones set id_cliente='"
            + textBox3.Text.Trim() + "', id_artefacto='"
            + textBox4.Text.Trim() + "', id_usuario='"
            + textBox5.Text.Trim() + "', fecha='"
            + dateTimePicker1.Value.Date.ToString("yyyMMdd") + "' where id_asignacion=" + textBox2.Text;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            button1_Click(sender, e); //Buscar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox2.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox2.Text);
                }
                catch (Exception ex) 
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox2.Focus();
                
                }
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox3.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox3.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox3.Focus();

                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox4.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox4.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox4.Focus();

                }
            }
        }
    }
}
