using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Designaciones
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string nuevoIdioma = Convert.ToString(comboBox1.SelectedIndex + 1);
                //Ingresar
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
                string query = "update usuarios set idioma = '" + nuevoIdioma + "' where cuenta = '" + Form1.cuenta + "' AND clave = MD5('" + textBox1.Text + "');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                int reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteNonQuery();
                    //MessageBox.Show(reader.ToString());

                    if (reader!=0)
                    {
                        MessageBox.Show("Se modifico correctamente el idioma.\nSe requiere reiniciar el programa para ver los cambios.");
                        databaseConnection.Close();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                        textBox1.Clear();
                    }
           
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe proporcionar la clave de la cuenta.");
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Convert.ToInt32(Form1.idioma) - 1;

            if (Form1.idioma == "2")
            {
                button1.Text = "Accept";
                button2.Text = "Exit";

                label1.Text = "Enter Password";
                label2.Text = "Select Language";
            }

            
        }
    }
}
