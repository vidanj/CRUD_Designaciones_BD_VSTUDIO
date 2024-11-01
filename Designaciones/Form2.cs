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
using System.IO;

namespace Designaciones
{
    public partial class Form2 : Form
    {
        int intentos = 0;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ingresar
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "select nivel, idioma, usuario, cuenta from usuarios where cuenta= '" + textBox1.Text + "' and clave = md5('" + textBox2.Text + "');";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Form1.cuenta = reader.GetString(3);
                    Form1.usuario = reader.GetString(2); 
                    //Form1.usuario = textBox1.Text; 
                    //MessageBox.Show(textBox1.Text);
                    Form1.nivel = reader.GetString(0);
                    // MessageBox.Show(reader.GetString(0));
                    Form1.idioma = reader.GetString(1);

                    Close();

                }
                else
                {
                    MessageBox.Show("Cuenta o contraseña incorrecta.");
                    intentos++;
                    if(intentos >= 3)
                    {
                        Application.Exit();
                    }

                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1.usuario == "")
            {
                Application.Exit();
            }
        }
    }
}
