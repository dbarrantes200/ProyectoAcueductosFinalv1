using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormMenu : Form
    {
        // Conexion c = new Conexion();
        // SqlConnection cn;
        // SqlCommand cmd;
        // SqlDataReader dr;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            //ShowDialog.Form1();
            //Form1.ShowDialog;
            //Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFuncionarios frm2 = new FormFuncionarios();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHidrometros frm3 = new FormHidrometros();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCategorias frm4 = new FormCategorias();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Conexion c = new Conexion();
            //Form1 frm1 = new Form1();
            MostrarClientesForm frm1 = new MostrarClientesForm();
            frm1.ShowDialog();

            //leerClientes();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarFuncionariosForm frm1 = new MostrarFuncionariosForm();
            frm1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarHidrometrosForm frm1 = new MostrarHidrometrosForm();
            frm1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MostrarCategoriasForm frm1 = new MostrarCategoriasForm();
            frm1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HistorialConsumoForm hcfrm = new HistorialConsumoForm();
            hcfrm.ShowDialog();
        }
    }
}
