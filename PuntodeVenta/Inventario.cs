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
    public partial class Inventario : Form
    {
        ConexionN cn=new ConexionN();
        public Inventario()
        {
            InitializeComponent();
            dataGridView1.DataSource=cn.ConsultarDTI();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            cn.InsertarProducto(txtProducto.Text, txtCategoria.Text, txtPrecio.Text, txtCantidad.Text);
            dataGridView1.DataSource = cn.ConsultarDTI();
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {

        }
    }
}
