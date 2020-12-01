using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;
            dtpFecha.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RbInsertar.Checked = true;
            Conexion c = new Conexion();
            c.cargarClientes(DgvClientes);

        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtCorreo.Enabled = false;
            txtCelular.Enabled = false;
            dtpFecha.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;
            dtpFecha.Enabled = true;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) == 0)
            {
                MessageBox.Show(c.insertar(txtId.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCorreo.Text, txtCelular.Text));
                txtId.Text = "";
                txtNombre.Text = "";
                txtApellido1.Text = "";
                txtApellido2.Text = "";
                txtCorreo.Text = "";
                txtCelular.Text = "";


            }
            else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
        }

        private void DgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
