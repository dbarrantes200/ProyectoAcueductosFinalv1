using ProyectoFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcueductoCliente.Interfaz
{
    public partial class frmCliente : Form
    {
        bool clienteConectado = false;
        public frmCliente()
        {
            InitializeComponent();
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
        }

       // public object ClienteTCP { get; private set; }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!(txtIdentificador.Text.Equals(string.Empty)))
            {
                if (ClienteTCP.Conectar(txtIdentificador.Text))
                {
                    lblEstado.Text = "Conectado al servidor... en (127.0.0.1, 30000)";
                    lblEstado.ForeColor = Color.Green;
                    clienteConectado = true;
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    txtIdentificador.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Verifique que el servidor esté escuchando clientes...", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el identificador del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            FormMenu frm2 = new FormMenu();
            frm2.ShowDialog();
        }
    }
}
