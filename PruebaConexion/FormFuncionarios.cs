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
    public partial class FormFuncionarios : Form
    {
        Conexion c = new Conexion();

        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNombre.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.funcionarioRegistrado(Convert.ToInt32(txtId.Text)) == 0)
            {
                //  MessageBox.Show(c.insertar(Convert.ToInt32(txtId.Text),txtNombre.Text,txtApellido1.Text,dtpFecha.Text));
                MessageBox.Show(c.insertarFuncionario(txtId.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text));
                txtId.Text = "";
                txtNombre.Text = "";
                txtApellido1.Text = "";
                txtApellido2.Text = "";

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
