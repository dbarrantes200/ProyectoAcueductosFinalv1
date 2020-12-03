using ProyectoFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcueductoCliente.Interfaz
{
    public partial class frmCliente : Form
    {
        Conexion c = new ProyectoFinal.Conexion();
        //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=GOTA;Integrated Security=True");
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
            if (clienteConectado)
            {
                FormMenu frm2 = new FormMenu();
                frm2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Debe conectarse primero con el servidor", "No es posible realizar la acción solicitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(txtIdentificador.Text);

            lblEstado.Text = "Desconectado";
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            clienteConectado = false;
            txtIdentificador.ReadOnly = false;
        }

        private void btnConsultaMonto_Click(object sender, EventArgs e)
        {
            if (clienteConectado)
            {
                FrmMontoCancelar frm2 = new FrmMontoCancelar();
                frm2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Debe conectarse primero con el servidor", "No es posible realizar la acción solicitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {
            // Validar que el cliente existe
            if (c.personaRegistrada(Convert.ToInt32(txtIdentificador.Text)) != 0)
            {
                //MessageBox.Show(c.insertar(txtId.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtCorreo.Text, txtCelular.Text));
                // txtId.Text = "";
                MessageBox.Show("Imposible if, El registro ya existe");

            }
            else
            {
                MessageBox.Show("Imposible de registrar else, El registro ya existe");
            }
        }
    }
}
