using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcueductoCliente.Interfaz
{
    class combobox
    {
        //Conexion con = new ProyectoFinal.Conexion();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=GOTA;Integrated Security=True");


        // Cargar los NIS para crear la lista de valores de la lista del Historial de Consumos
        public void seleccionar(ComboBox cb)
        {
            // Conexion con = new ProyectoFinal.Conexion();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=GOTA;Integrated Security=True");
            cb.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from HISTORIALCONSUMO", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "--- Seleccione un item ---");
            cb.SelectedIndex = 0;
        }

        // Metodo para mapear la lectura de hidrometros

        public string[] captar_info(string nis)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from HISTORIALCONSUMO where NIS='" + nis + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                };
                resultado = valores;
            }
            con.Close();
            return resultado;
        }



        // metodo para cargar clientes en un combbox
        public void cargar_clientes(ComboBox clientes)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select IDENTIFICACION, NOMBRE from CLIENTES", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["IDENTIFICACION"] = "Selecciona un Cliente";
            dt.Rows.InsertAt(fila, 0);


            clientes.ValueMember = "IDENTIFICACION";
            clientes.DisplayMember = "IDENTIFICACION";
            clientes.DataSource = dt;

        }

        public string[] captar_nombre(string identificacion)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from CLIENTES where IDENTIFICACION='" + identificacion + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                };
                resultado = valores;
            }
            con.Close();
            return resultado;
        }

        internal string montoCancelar(bool v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        // metodo para cargar categorias en el combo box
        public string[] captarNIS(string nis)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from HIDROMETROS where NIS='" + nis + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString()
                };
                resultado = valores;
            }
            con.Close();
            return resultado;
        }


        // Metodo para calcular monto a pagar
        public int montoCancelar(int lecturaAnterior, int lecturaActual, int tarifa)
        {
            int montoAdeudado = (lecturaActual - lecturaAnterior) * tarifa;

            return (montoAdeudado);

        }



    }
}

