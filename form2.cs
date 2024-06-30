using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vetApp
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sesion = new Form1();
            sesion.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registroMascota registromas = new registroMascota();
            registromas.Show();
            this.Hide();
        }
    }
}
