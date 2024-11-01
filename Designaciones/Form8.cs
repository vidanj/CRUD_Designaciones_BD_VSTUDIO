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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        string archivo = Directory.GetCurrentDirectory() + "\\ReporteArtefactos.html";
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Generar
            StreamWriter arch = new StreamWriter(archivo);
            arch.WriteLine("<html>REPORTE DE ARTEFACTOS<br><br>");
            arch.WriteLine("<table border=1 cellspacing=0>");
            arch.WriteLine("<tr><td>id_Artefacto</td><td>Artefacto</td><td>Parte</td><td>Atributo Main</td><td>Atributo 1</td><td>Valor 1</td>" +
                           "<td>Atributo 2</td><td>Valor 2</td><td>Atributo 3</td><td>Valor 3</td><td>Atributo 4</td><td>Valor 4</td></tr> ");
            string connectionString =
            "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from artefactos";
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
                        arch.WriteLine("<tr><td>" +
                            Convert.ToString(reader.GetInt64(0)) + "</td><td>" + reader.GetString(1) + "</td><td>" + reader.GetString(2) + "</td><td>" + reader.GetString(3) + "</td><td>" +
                            reader.GetString(4) + "</td><td>" + Convert.ToString(reader.GetDecimal(5)) + "</td><td>" + reader.GetString(6) + "</td><td>" + Convert.ToString(reader.GetDecimal(7)) + "</td><td>" + 
                            reader.GetString(8) + "</td><td>" + Convert.ToString(reader.GetDecimal(9)) + "</td><td>" + reader.GetString(10) + "</td><td>" + Convert.ToString(reader.GetDecimal(11))
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

        private void Form8_Load(object sender, EventArgs e)
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
