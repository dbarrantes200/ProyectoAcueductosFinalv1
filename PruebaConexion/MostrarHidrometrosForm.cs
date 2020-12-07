using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MostrarHidrometrosForm : Form
    {
        public MostrarHidrometrosForm()
        {
            InitializeComponent();
        }

        private void hIDROMETROSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hIDROMETROSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gOTADataSet);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
