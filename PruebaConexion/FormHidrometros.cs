using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormHidrometros : Form
    {

        Conexion c = new Conexion();
        public FormHidrometros()
        {
            InitializeComponent();
            c.cargar_clientes(cbCliente);
            c.cargarHidrometros(DgvHidrometros);
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
            txtCat.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void rRModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMarca.Enabled = true;
            txtSerie.Enabled = true;
            txtCat.Enabled = true;
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
            txtCat.Enabled = false;
            txtCliente.Enabled = false;
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.hidrometroRegistrado(Convert.ToInt32(txtNIS.Text)) == 0)
            {
                MessageBox.Show(c.insertarHidrometro(Convert.ToInt32(txtNIS.Text), txtMarca.Text, Convert.ToInt32(txtSerie.Text), txtCat.Text, txtCliente.Text));
                txtNIS.Text = "";
                txtMarca.Text = "";
                txtSerie.Text = "";
                txtCat.Text = "";
                txtCliente.Text = "";

            }
            else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
        }

        private void FormHidrometros_Load(object sender, EventArgs e)
        {
            c.llenarCategorias(cbCat);
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            // c.obtenerCodCategoria(cbCategoria);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat.SelectedIndex > 0)
            {
                string[] cat = c.AsociarCategoria(cbCat.Text);
                txtCat.Text = cat[0];
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex > 0)
            {
                string[] cat = c.obtener_nombre(cbCliente.Text); ;
                txtCliente.Text = cat[0];
                textNom.Text = cat[1];
                textApe1.Text = cat[2];
                textApe2.Text = cat[3];
            }
        }
    }
}
