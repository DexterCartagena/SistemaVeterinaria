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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuario, contrasena;
            usuario = txt_usuario.Text;
            contrasena = txt_pass.Text;
            if (usuario == "Admin" && contrasena=="1234a")
            {
                form2 principal = new form2();
                principal.Show();
                this.Hide();
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Usuario no valido", "Datos erroneo", MessageBoxButtons.RetryCancel, 
                    MessageBoxIcon.Error);
                if (respuesta == DialogResult.Retry)
                {
                    contador++;
                    txt_usuario.Clear();
                    txt_pass.Clear();
                    if (contador==2)
                    {
                        MessageBox.Show("Agotaste los intentos permitidos");
                        Application.Exit();
                    }
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
