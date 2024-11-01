using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Designaciones
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "insert into usuarios values(NULL, '" + textBox3.Text + "' , '" + textBox4.Text + "' , MD5('123'),  '"
            + comboBox1.SelectedIndex + "' ,'" + (comboBox2.SelectedIndex + 1) + 
            "')";
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
                MessageBox.Show("El formato no es correcto. \n Por favor ingrese un valor en cada parammetro." + ex.Message, "Mensaje de error.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buscar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from usuarios WHERE usuario LIKE '%" + textBox1.Text + "%'";
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
                        dataGridView1.Rows.Add(
                                               Convert.ToString(reader.GetInt64(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                                               ((reader.GetString(4) == "0") ? "Administrador" : "Operador"), ((reader.GetString(5) == "1") ? "Español" : "Inglés")
                                              );
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

        private void Form11_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("id_usuario", "id_usuario");
            dataGridView1.Columns.Add("usuario", "usuario");
            dataGridView1.Columns.Add("cuenta", "cuenta");
            dataGridView1.Columns.Add("clave", "clave");
            dataGridView1.Columns.Add("nivel", "nivel");
            dataGridView1.Columns.Add("idioma", "idioma");


            if (Form1.idioma == "2")
            {
                button1.Text = "Search";
                button2.Text = "Add";
                button4.Text = "Update";
                button3.Text = "Delete";
                button5.Text = "Exit";
                button6.Text = "Restore Pass";

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBox1.SelectedIndex = (((dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) == "Administrador") ? 0 : 1);
                comboBox2.SelectedIndex = (((dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()) == "Español") ? 0 : 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "delete from usuarios where id_usuario=" + textBox2.Text;
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
                MessageBox.Show("Especifique el id de quien desea eliminar.", "Mensaje de error.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Modificar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "update usuarios set usuario='"
                            + textBox3.Text.Trim() + "', cuenta='"
                            + textBox4.Text.Trim() + "', nivel='"
                            + comboBox1.SelectedIndex + "', idioma='"
                            + (comboBox2.SelectedIndex + 1)
                            + "' where id_usuario=" + textBox2.Text;
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

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "" && textBox4.Text != "")
            {
                //Ingresar
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
                string query = "update usuarios set clave = MD5('" + textBox4.Text + "') where id_usuario = '" + textBox2.Text + "';";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Se restauro correctamente la contraseña.");


                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Los campos de Usuario y cuenta no deben de estar vacios.");
            }
            button1_Click(sender, e); //Buscar
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
