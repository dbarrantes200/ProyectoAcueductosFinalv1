﻿using System;
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
    public partial class HistorialConsumoForm : Form
    {
        Conexion c = new Conexion();
        public HistorialConsumoForm()
        {
            InitializeComponent();
        }

     //   private void HistorialConsumoForm_Load(object sender, EventArgs e)
       // {

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMes.Enabled = true;
            txtLectura.Enabled = true;
            dtpFecha.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;

        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMes.Enabled = false;
            txtLectura.Enabled = false;
            dtpFecha.Enabled = false;
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnModificar.Enabled = false;
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtNIS.Enabled = true;
            txtMes.Enabled = true;
            txtLectura.Enabled = true;
            dtpFecha.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (c.lecturaRegistrada(Convert.ToInt32(txtNIS.Text)) == 0)
            {
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string dt = dtpFecha.Text;
                DateTime newDt = DateTime.Parse(dt);

                MessageBox.Show(c.insertarLectura(Convert.ToInt32(txtNIS.Text), Convert.ToInt32(txtMes.Text), newDt.ToString(), Convert.ToInt32(txtLectura.Text)));
                txtNIS.Text = "";
                txtMes.Text = "";
                //dtpFecha.Text = "";
                txtLectura.Text = "";
                

            }
            else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
        }
    }
}
