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

namespace Designaciones
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Los datos requeridos no estan completos.");
            } 
            else
            {
                if(textBox2.Text == textBox3.Text)
                {
                    //Ingresar
                    string connectionString = "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
                    string query = "update usuarios set clave = MD5('" + textBox2.Text + "') where cuenta = '" + Form1.cuenta + "' AND clave = MD5('" +textBox1.Text + "');" ;
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    int reader;
                    try
                    {
                        databaseConnection.Open();
                        reader = commandDatabase.ExecuteNonQuery();

                        if (reader != 0)
                        {

                            MessageBox.Show("Se modifico correctamente la contrasña.");
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
                    MessageBox.Show("La nueva contrasña y su repeticion no son iguales.");
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void Form12_Load(object sender, EventArgs e)
        {

            if (Form1.idioma == "2")
            {
                button1.Text = "Accept";
                button2.Text = "Exit";

                label1.Text = "Enter current password:";
                label2.Text = "Enter new password:";
                label3.Text = "Repeat new password:";
            }
        }
    }
}
