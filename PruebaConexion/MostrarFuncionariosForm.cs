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
    public partial class MostrarFuncionariosForm : Form
    {
        public MostrarFuncionariosForm()
        {
            InitializeComponent();
        }

        private void fUNCIONARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fUNCIONARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gOTADataSet);

        }

        private void MostrarFuncionariosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOTADataSet.FUNCIONARIOS' table. You can move, or remove it, as needed.
            this.fUNCIONARIOSTableAdapter.Fill(this.gOTADataSet.FUNCIONARIOS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
