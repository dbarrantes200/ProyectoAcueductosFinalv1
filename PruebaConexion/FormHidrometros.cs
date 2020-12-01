using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormHidrometros : Form
    {
        Conexion c = new Conexion();
        public FormHidrometros()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rBRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMarca.Enabled = true;
            txtSerie.Enabled = true;
            txtCategoria.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void rRModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMarca.Enabled = true;
            txtSerie.Enabled = true;
            txtCategoria.Enabled = true;
            txtCliente.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = true;
        }

        private void rBEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMarca.Enabled = false;
            txtSerie.Enabled = false;
            txtCategoria.Enabled = false;
            txtCliente.Enabled = false;
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.hidrometroRegistrado(Convert.ToInt32(txtNIS.Text)) == 0)
            {
                MessageBox.Show(c.insertarHidrometro(Convert.ToInt32(txtNIS.Text), txtMarca.Text, Convert.ToInt32(txtSerie.Text), txtCategoria.Text, txtCliente.Text));
                txtNIS.Text = "";
                txtMarca.Text = "";
                txtSerie.Text = "";
                txtCategoria.Text = "";
                txtCliente.Text = "";
           
            }
            else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
        }

        private void FormHidrometros_Load(object sender, EventArgs e)
        {
            c.llenarCategorias(cbCategoria);
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
           // c.obtenerCodCategoria(cbCategoria);
        }
    }
}
