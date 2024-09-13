using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class FormUsers : Form
    {
        ConexionN cn = new ConexionN();
        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultarDT();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoU_Click(object sender, EventArgs e)
        {
            cn.InsertarUsuario(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtTelefono.Text, txtUsuario.Text, txtContrasena.Text);

            dataGridView1.DataSource = cn.ConsultarDT();
        }

        private void btnEditarU_Click(object sender, EventArgs e)
        {
            cn.ModificarUsuario(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtTelefono.Text, txtUsuario.Text, txtContrasena.Text);
            dataGridView1.DataSource = cn.ConsultarDT();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ConsultarDT();
        }
    }
}
