using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCategorias : Form
    {
        Conexion c = new Conexion();
        public FormCategorias()
        {
            InitializeComponent();
            c.cargarCategorias(DgvCategorias);
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            RbInsertar.Checked = true;
            c.cargarCategorias(DgvCategorias);

        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
            txtDescripcion.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
            txtDescripcion.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            txtCategoria.Enabled = true;
            txtDescripcion.Enabled = true;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.categoriaRegistrada(Convert.ToInt32(txtCategoria.Text)) == 0)
            {
                MessageBox.Show(c.insertarCategoria(txtCategoria.Text, txtDescripcion.Text));
                txtCategoria.Text = "";
                txtDescripcion.Text = "";

            }
            else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
