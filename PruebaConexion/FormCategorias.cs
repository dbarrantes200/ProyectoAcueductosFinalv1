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
    public partial class FormCategorias : Form
    {
        Conexion c = new Conexion();
        public FormCategorias()
        {
            InitializeComponent();
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
