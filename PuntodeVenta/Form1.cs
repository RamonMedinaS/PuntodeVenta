using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace PuntodeVenta
{
    public partial class Form1 : Form
    {
        ConexionN cn = new ConexionN();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txtUsuario.Text, txtContrasena.Text) == 1)
            {
                MessageBox.Show("El usuario a sido encontrado");
                this.Hide();
                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("No se encontro el usuario");
            }
        }
    }
}
