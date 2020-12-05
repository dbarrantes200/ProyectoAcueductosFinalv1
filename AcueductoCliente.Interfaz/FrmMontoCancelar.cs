using System;
using System.IO;
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
    }
}