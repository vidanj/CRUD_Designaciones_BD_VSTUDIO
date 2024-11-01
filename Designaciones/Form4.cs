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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("id_Cliente", "id_Cliente");
            dataGridView1.Columns.Add("Cliente", "Cliente");
            dataGridView1.Columns.Add("Ascencion", "Ascencion");
            dataGridView1.Columns.Add("Nivel", "Nivel");
            dataGridView1.Columns.Add("HP", "HP");
            dataGridView1.Columns.Add("ATK", "ATK");
            dataGridView1.Columns.Add("DEF", "DEF");
            dataGridView1.Columns.Add("EM", "EM");
            dataGridView1.Columns.Add("Energy_Recharge", "Energy_Recharge");
            dataGridView1.Columns.Add("Crit_Rate", "Crit_Rate");
            dataGridView1.Columns.Add("Crit_Damage", "Crit_Damage");
            dataGridView1.Columns.Add("Elemental_Damage", "Elemental_Damage");

            if (Form1.idioma == "2")
            {
                button1.Text = "Search";
                button2.Text = "Add";
                button4.Text = "Update";
                button3.Text = "Delete";
                button5.Text = "Exit";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from clientes WHERE cliente LIKE '%" + textBox1.Text + "%'";
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
                                            Convert.ToString(reader.GetInt64(0)), reader.GetString(1), reader.GetString(2), Convert.ToString(reader.GetInt64(3)), 
                                            Convert.ToString(reader.GetInt64(4)), Convert.ToString(reader.GetInt64(5)), Convert.ToString(reader.GetInt64(6)), Convert.ToString(reader.GetInt64(7)), 
                                            Convert.ToString(reader.GetInt64(8)), Convert.ToString(reader.GetDecimal(9)), Convert.ToString(reader.GetDecimal(10)), Convert.ToString(reader.GetDecimal(11))
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
            string query = "delete from clientes where id_cliente=" + textBox2.Text;
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
                MessageBox.Show(ex + "Especifique el id de quien desea eliminar.", "Mensaje de error.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "insert into clientes values(NULL, '" +
                             textBox3.Text + "','" + textBox4.Text +"'," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + "," +
                             textBox8.Text + "," + textBox9.Text + "," + textBox10.Text + "," + textBox11.Text + "," + textBox12.Text + "," + textBox13.Text +
                             ")";
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
            string query = "update clientes set cliente='"
                            + textBox3.Text.Trim() + "', ASCENCION='"
                            + textBox4.Text.Trim() + "', LVL='"
                            + textBox5.Text.Trim() + "', HP='"
                            + textBox6.Text.Trim() + "', ATK='"
                            + textBox7.Text.Trim() + "', DEF='"
                            + textBox8.Text.Trim() + "', EM='"
                            + textBox9.Text.Trim() + "', ENERGY_RECHARGE='"
                            + textBox10.Text.Trim() + "', CRIT_RATE='"
                            + textBox11.Text.Trim() + "', CRIT_DAMAGE='"
                            + textBox12.Text.Trim() + "', ELEMENTAL_DMG='"
                            + textBox13.Text.Trim() 
                            + "' where id_cliente=" + textBox2.Text;
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

        private void textBox5_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox5.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox5.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox5.Focus();

                }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox6.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox6.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox6.Focus();

                }
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox7.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox7.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox7.Focus();

                }
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox8.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox8.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox8.Focus();

                }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            Int64 n;

            if (textBox9.Text != "")
            {
                try
                {
                    n = Convert.ToInt64(textBox9.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox9.Focus();

                }
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            Double n;

            if (textBox10.Text != "")
            {
                try
                {
                    n = Convert.ToDouble(textBox10.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox10.Focus();

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

        private void textBox12_Leave(object sender, EventArgs e)
        {
            Double n;

            if (textBox12.Text != "")
            {
                try
                {
                    n = Convert.ToDouble(textBox12.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("El formato no es correcto. \n Se aceptan solo digitos." + ex.Message, "Mensaje de erro.");

                    textBox12.Focus();

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
    }
}
