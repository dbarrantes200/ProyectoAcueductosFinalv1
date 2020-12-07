using System;
using System.Windows.Forms;

namespace AcueductoCliente.Interfaz
{
    public partial class FrmMontoCancelar : Form
    {
        combobox combo = new combobox();

        public FrmMontoCancelar()
        {
            InitializeComponent();
            combo.seleccionar(cbNumeroNIS);
            combo.cargar_clientes(cbCliente);
        }

        // Este metodo permite que al seleccionar el numero de NIS popule el numero de cliente mas la categoria de la tabla de Hidrometros
        //Ademas trae el cliente, categoria, nombre y apellidos para el cliente asociado al NIS seleccionado
        // por ultimo con base en la categoria domicilario o empresarial define la tarifa correspondientes
        private void cbNumeroNIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String textTarifa = 0;
            //int textMesActual = 0;
            // textTarifa.Text = "0";

            if (cbNumeroNIS.SelectedIndex > 0)
            {
                string[] valores = combo.captar_info(cbNumeroNIS.Text);
                textMesActual.Text = valores[0];
                string[] nombres = combo.captarNIS(cbNumeroNIS.Text);
                textCliente.Text = nombres[2];
                textCategoria.Text = nombres[1];
                string[] datosCliente = combo.captar_nombre(textCliente.Text);
                textNombre.Text = datosCliente[0];
                textApellido1.Text = datosCliente[1];
                textApellido2.Text = datosCliente[2];
                //textConsumo.Text = valores[0] - textMesAnterior;
            }
            // textTarifa.Text = "0";
            //if (textCategoria.Text != null)
            //{
            //   textTarifa.Text = "0";
            // }
            if (textCategoria.Text == "1")
            {
                textTarifa.Text = "1000";

            }
            else if (textCategoria.Text == "2")
            {
                textTarifa.Text = "2000";
            }
            else
                textTarifa.Text = "3000";
        }



        // Metodo para cerrar el formulario
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        // Este Metodo popula el Nombre, Primer y Segundo Apellido con base en el combobox de identidad del cliente
        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex > 0)
            {
                string[] valores = combo.captar_nombre(cbCliente.Text);
                textNombre.Text = valores[0];
                textApellido1.Text = valores[1];
                textApellido2.Text = valores[2];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // int lecActual = Convert.ToInt32(textMesActual);
            int lecActual = Int32.Parse(textMesActual.Text);
            //int lecAnterior = Convert.ToInt32(textMesAnterior);
            int lecAnterior = Int32.Parse(textMesAnterior.Text);
            //int tarifa = Convert.ToInt32(textTarifa);
            int tarifa = Int32.Parse(textTarifa.Text);

            int consumo = lecActual - lecAnterior;
            int subTotal = consumo * tarifa;
            double iva = subTotal * 0.13;
            double total = subTotal * 1.13;

            textConsumo.Text = Convert.ToString(consumo);
            textIVA.Text = Convert.ToString(iva);
            textMontoAntesIVA.Text = Convert.ToString(subTotal);
            textMontoPagar.Text = Convert.ToString(total);



            // MessageBox.Show(combo.montoCancelar(lecAnterior,lecActual, tarifa));
            //MessageBox.Show(combo.montoCancelar(Int32.TryParse(textMesActual.Text), Convert.ToInt32(textMesAnterior), Convert.ToInt32(textTarifa)));
            //MessageBox.Show(combo.montoCancelar.Convert.ToInt32(textMesActual.Text, textMesAnterior.Text, textTarifa.Text));
            // MessageBox.Show(combo.montoCancelar(Convert.ToInt32(textMesActual.Text, textMesAnterior.Text, textTarifa.Text)));
            //textMesActual.Text = "";
            //textMesAnterior.Text = "";
        }
    }
}
