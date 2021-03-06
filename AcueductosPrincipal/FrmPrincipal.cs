﻿//using AcueductoCliente.Interfaz;
using AcueductoCliente.Interfaz;
using AcuedutoServidor.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAcueductosFinal
{
    public partial class FrmPrincipal : Form
    {
        frmServidor servidor;
        public FrmPrincipal()
        {
            InitializeComponent();
            //Se accesa la propiedad estatica para modificarla y poder indicar que en el inicio el servidor no esta iniciado            
            frmServidor.IndicarFormularioServidorIniciado = false;
        }
                 

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (!frmServidor.IndicarFormularioServidorIniciado)
            {
                MessageBox.Show("Primero debe iniciar el servidor");
            }
            else
            {
               // frmCliente cliente = new frmCliente();
              //  cliente.Show();
            }

        }

        private void btnServidor_Click_1(object sender, EventArgs e)
        {
            //De esta forma se controla que solo un servidor este iniciado
            //Se implemento de esta forma debido a una pregunta de un estudiante en la tercer sesion de dudas
            //Para mas detalle, ver el video de la tercer sesion de dudas del 17/11/2020 Tutor Henry Mendez
            if (frmServidor.IndicarFormularioServidorIniciado)
            {
                MessageBox.Show("Servidor ya se encuentra iniciado");
            }
            else
            {
                frmServidor.IndicarFormularioServidorIniciado = true;
                servidor = new frmServidor();
                servidor.Show();
            }
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            if (!frmServidor.IndicarFormularioServidorIniciado)
            {
                MessageBox.Show("Primero debe iniciar el servidor");
            }
            else
            {
                AcueductoCliente.Interfaz.frmCliente cliente = new frmCliente();
                 cliente.Show();
            }
        }
    }
}
