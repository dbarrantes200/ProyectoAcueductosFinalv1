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
    public partial class MostrarClientesForm : Form
    {
        public MostrarClientesForm()
        {
            InitializeComponent();
        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gOTADataSet);

        }

        private void MostrarTablaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOTADataSet.CLIENTES' table. You can move, or remove it, as needed.
            this.cLIENTESTableAdapter.Fill(this.gOTADataSet.CLIENTES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
