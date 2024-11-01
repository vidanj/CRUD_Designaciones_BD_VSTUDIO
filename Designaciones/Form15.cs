using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designaciones
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        string archivo = Directory.GetCurrentDirectory() + "\\ReporteUsuarios.html";

        private void button1_Click(object sender, EventArgs e)
        {
            //Generar
            StreamWriter arch = new StreamWriter(archivo);
            arch.WriteLine("<html>REPORTE DE USUARIOS<br><br>");
            arch.WriteLine("<table border=1 cellspacing=0>");
            arch.WriteLine("<tr><td>id_usuario</td><td>usuario</td><td>cuenta</td><td>contraseña</td><td>nivel</td><td>idioma</td></tr> ");
            string connectionString =
            "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from usuarios";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arch.WriteLine("<tr><td>"

                        + Convert.ToString(reader.GetInt64(0)) + "</td><td>" + reader.GetString(1) + "</td><td>" + reader.GetString(2) + "</td><td>" + reader.GetString(3) + "</td><td>"
                        + reader.GetString(4) + "</td><td>" + reader.GetString(5));

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
            arch.WriteLine("</table></html>");
            arch.Close();
            //Uri dir = new Uri("ReporteAsignaciones.htm");
            //MessageBox.Show(archivo);
            Uri dir = new Uri(archivo);
            webBrowser1.Url = dir;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Excell
            System.Diagnostics.Process.Start("Excel", "\"" + archivo + "\"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Chrome
            System.Diagnostics.Process.Start("Chrome", "\"" + archivo + "\"");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            if (Form1.idioma == "2")
            {
                button1.Text = "Generate";
                button4.Text = "Exit";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
    }
}
