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

    public partial class Form1 : Form
    {
        //Connstantes usuarios
        public static string cuenta = "";
        public static string usuario = "";
        public static string nivel = "0";
        public static string idioma = "1";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void artefactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void reportesDeAsignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void reporteDeArtefactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void reporteDeAsignacionesPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void reporteDeAsignacionesPorArtefactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if(nivel == "0")
            {
                label1.Text = "Usuario:" + usuario + "(Administrador)";
            }
            else
            {
                label1.Text = "Usuario:" + usuario + "(Operador)";

                usuariosToolStripMenuItem.Enabled = false;
                reporteDeUsuariosToolStripMenuItem.Enabled = false;
                reporteDeAsignacionesPorUsuarioToolStripMenuItem.Enabled = false;

            }

            if(idioma == "2")
            {
                archivoToolStripMenuItem.Text = "File";
                reportesToolStripMenuItem.Text = "Reports";
                preferenciasToolStripMenuItem.Text = "Preferences";

                asignacionesToolStripMenuItem.Text = "Assignments";
                usuariosToolStripMenuItem.Text = "Users";
                clientesToolStripMenuItem.Text = "Customers";
                artefactosToolStripMenuItem.Text = "Artifacts";

                reporteDeArtefactosToolStripMenuItem.Text = "Artifacts Report";
                reportesDeAsignacionesToolStripMenuItem.Text = "Assignments Report";
                reporteDeClientesToolStripMenuItem.Text = "Customers Report";
                reporteDeUsuariosToolStripMenuItem.Text = "Users Report";

                reporteDeAsignacionesPorClienteToolStripMenuItem.Text = "Assignments by Customers Report";
                reporteDeAsignacionesPorArtefactoToolStripMenuItem.Text = "Assignments by Artifacts Report";
                reporteDeAsignacionesPorUsuarioToolStripMenuItem.Text = "Assignments by Users Report";

                cambiarContraseñaToolStripMenuItem.Text = "Change Password";
                cambiarDeToolStripMenuItem.Text = "Change Language";
                acerdaDeToolStripMenuItem.Text = "About...";


            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Left = this.Width/2 - (pictureBox1.Width / 2);
            pictureBox1.Top = this.Height/2 - (pictureBox1.Height / 2);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void cambiarDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f14 = new Form14();
            f14.Show();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f15 = new Form15();
            f15.Show();
        }

        private void reporteDeAsignacionesPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f16 = new Form16();
            f16.Show();
        }
    }
}
