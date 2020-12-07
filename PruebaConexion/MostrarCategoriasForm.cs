using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MostrarCategoriasForm : Form
    {
        public MostrarCategoriasForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cATEGORIASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORIASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gOTADataSet);

        }

        private void MostrarCategoriasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOTADataSet.CATEGORIAS' table. You can move, or remove it, as needed.
            this.cATEGORIASTableAdapter.Fill(this.gOTADataSet.CATEGORIAS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
