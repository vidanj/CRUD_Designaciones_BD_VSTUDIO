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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        string archivo = Directory.GetCurrentDirectory() + "\\ReporteClientes.html";

        private void button1_Click(object sender, EventArgs e)
        {
            //Generar 
            StreamWriter arch = new StreamWriter(archivo);
            arch.WriteLine("<html>REPORTE DE CLIENTES<br><br>");
            arch.WriteLine("<table border=1 cellspacing=0>");
            arch.WriteLine("<tr><td>id_Cliente</td><td>Cliente</td><td>Ascencion</td><td>Nivel</td><td>HP</td><td>ATK</td>" +
                           "<td>DEF</td><td>EM</td><td>Energy Recharge</td><td>Crit Rate</td><td>Crit Damage</td><td>Elemental DMG</td></tr> ");
            string connectionString =
            "datasource=localhost;port=3306;username=root;password=;database=designaciones;";
            string query = "Select * from clientes";
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

                        Convert.ToString(reader.GetInt64(0)) + "</td><td>" + reader.GetString(1) + "</td><td>" + reader.GetString(2) + "</td><td>" + Convert.ToString(reader.GetInt64(3)) + "</td><td>" +
                        Convert.ToString(reader.GetInt64(4)) + "</td><td>" + Convert.ToString(reader.GetInt64(5)) + "</td><td>" + Convert.ToString(reader.GetInt64(6)) + "</td><td>" + 
                        Convert.ToString(reader.GetInt64(7)) + "</td><td>" + Convert.ToString(reader.GetInt64(8)) + "</td><td>" + Convert.ToString(reader.GetDecimal(9)) + "</td><td>" + 
                        Convert.ToString(reader.GetDecimal(10)) + "</td><td>" + Convert.ToString(reader.GetDecimal(11)) +
                        
                        "</td></tr>");

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

        private void Form7_Load(object sender, EventArgs e)
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
