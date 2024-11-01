using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Designaciones
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buscar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from artefactos WHERE artefacto LIKE '%" + textBox1.Text + "%'";
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
                                               Convert.ToString(reader.GetInt64(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                               Convert.ToString(reader.GetDecimal(5)), reader.GetString(6), Convert.ToString(reader.GetDecimal(7)), reader.GetString(8),
                                               Convert.ToString(reader.GetDecimal(9)), reader.GetString(10), Convert.ToString(reader.GetDecimal(11))
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Eliminar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "delete from artefactos where id_artefacto=" + textBox2.Text;
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
                MessageBox.Show( ex + "Especifique el id de quien desea eliminar.", "Mensaje de error.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "insert into artefactos values(NULL, '" + textBox3.Text + "' , '" + textBox4.Text + "' , '"
            + textBox5.Text + "' ,'" + textBox6.Text + "' ,'" + textBox7.Text + "' ,'" + textBox8.Text + "' ,'" + textBox9.Text + "' , '"
            + textBox10.Text + "' ,'" + textBox11.Text + "' ,'" + textBox12.Text + "' ,'" + textBox13.Text +
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Modificar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "update artefactos set artefacto='"
            + textBox3.Text.Trim() + "', parte='"
            + textBox4.Text.Trim() + "', atributoMain='"
            + textBox5.Text.Trim() + "', atributo1='"
            + textBox6.Text.Trim() + "', valor1='"
            + textBox7.Text.Trim() + "', atributo2='"
            + textBox8.Text.Trim() + "', valor2='"
            + textBox9.Text.Trim() + "', atributo3='"
            + textBox10.Text.Trim() + "', valor3='"
            + textBox11.Text.Trim() + "', atributo4='"
            + textBox12.Text.Trim() + "', valor4='"
            + textBox13.Text.Trim() 
            + "' where id_artefacto=" + textBox2.Text;
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

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("id_Artefacto", "id_Artefacto");
            dataGridView1.Columns.Add("Artefacto", "Artefacto");
            dataGridView1.Columns.Add("Parte", "Parte");
            dataGridView1.Columns.Add("Atributo Main", "Atributo Main");
            dataGridView1.Columns.Add("Atributo 1", "Atributo 1");
            dataGridView1.Columns.Add("Valor 1", "Valor 1");
            dataGridView1.Columns.Add("Atributo 2", "Atributo 2");
            dataGridView1.Columns.Add("Valor 2", "Valor 2");
            dataGridView1.Columns.Add("Atributo 3", "Atributo 3");
            dataGridView1.Columns.Add("Valor 3", "Valor 3");
            dataGridView1.Columns.Add("Atributo 4", "Atributo 4");
            dataGridView1.Columns.Add("Valor 4", "Valor 4");

            if (Form1.idioma == "2")
            {
                button1.Text = "Search";
                button2.Text = "Add";
                button4.Text = "Update";
                button3.Text = "Delete";
                button5.Text = "Exit";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            Int64 n;
            label13.Text = "Mensaje";
            label13.ForeColor = Color.Black;
            if (textBox2.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox2.Text);
                    label13.Text = "Mensaje";
                    label13.ForeColor = Color.Black;
                }
                catch (Exception)
                {
                    textBox2.Focus();
                    label13.ForeColor = Color.Red;
                    label13.Text = "Mensaje: El formato numerico no es correcto. Mensaje de error.";
                    //MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                   

                }
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            Double n;

            if (textBox7.Text != "")
            {
                try
                {
                    n = Convert.ToDouble(textBox7.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox7.Focus();

                }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            Double n;

            if (textBox9.Text != "")
            {
                try
                {
                    n = Convert.ToDouble(textBox9.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox9.Focus();

                }
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            Double n;

            if (textBox11.Text != "")
            {
                try
                {
                    n = Convert.ToDouble(textBox11.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox11.Focus();

                }
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            Double n;

            if (textBox13.Text != "")
            {
                try
                {
                    n = Convert.ToDouble(textBox13.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox13.Focus();

                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label13.Text = "Mensaje: Introduce la palabra de lo que desea buscar.";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label13.Text = "Mensaje: Introduce el numero de parte";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label13.Text = "Mensaje";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
           if(!(textBox4.Text == "1" || textBox4.Text == "2" || textBox4.Text == "3" || textBox4.Text == "4" || textBox4.Text == "5"))
            {
                SoundPlayer audio = new SoundPlayer("nope.wav");
                audio.Play();
                textBox4.Focus();
            }
            label13.Text = "Mensaje";
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(label13.ForeColor != Color.Red)
                label13.Text = "Mensaje: Introduce el numero identificador del artefacto.";
            
            
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer("ok.wav");
            audio.Play();
        }
    }
}
