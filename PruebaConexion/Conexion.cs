using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        // Metodo Conexion para conectarse a la base de datos
        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=GOTA;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado a la Base de Datos");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la Base de Datos: " + ex.ToString());
            }
        }

        public string insertar(string id, string nombre, string apellido1, string apellido2, string correo, string telefono)
        {
            string salida = "El Cliente se agregó exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into CLIENTES(IDENTIFICACION,NOMBRE,APELLIDO1,APELLIDO2,CORREOELECTRONICO,NUMCELULAR) values(" + id + ",'" + nombre + "','" + apellido1 + "','" + apellido2 + "','" + correo + "','" + telefono + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se logró conectar con la Base de Datos: " + ex.ToString();
            }
            return salida;
        }



        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from CLIENTES where IDENTIFICACION=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró consultar: " + ex.ToString());
            }
            return contador;
        }

        public string insertarFuncionario(string id, string nombre, string apellido1, string apellido2)
        {
            string salida = "El Funcionario se agregó exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into FUNCIONARIOS(IDENTIFICACION,NOMBRE,APELLIDO1,APELLIDO2) values(" + id + ",'" + nombre + "','" + apellido1 + "','" + apellido2 + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se logró conectar con la Base de Datos: " + ex.ToString();
            }
            return salida;
        }
        public int funcionarioRegistrado(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from FUNCIONARIOS where IDENTIFICACION=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró consultar: " + ex.ToString());
            }
            return contador;
        }

        public string insertarCategoria(string categoria, string descripcion)
        {
            string salida = "La Categoria se agregó exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into CATEGORIAS(CODCATEGORIA,DESCRIPCION) values(" + categoria + ",'" + descripcion + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se logró conectar con la Base de Datos: " + ex.ToString();
            }
            return salida;
        }

        public int categoriaRegistrada(int categoria)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from CATEGORIAS where CODCATEGORIA=" + categoria + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró consultar: " + ex.ToString());
            }
            return contador;
        }

        public string insertarHidrometro(int NIS, string marca, int serie, string categoria, string cliente)
        {
            string salida = "El Hidrometro se agregó exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into HIDROMETROS(NIS,MARCA,NUMSERIE,CODCATEGORIA,IDENTIFICACION) values(" + NIS + ",'" + marca + "','" + serie + "','" + categoria + "', '" + cliente + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se logró conectar con la Base de Datos: " + ex.ToString();
            }
            return salida;
        }

        public int hidrometroRegistrado(int NIS)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from HIDROMETROS where NIS=" + NIS + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró consultar: " + ex.ToString());
            }
            return contador;
        }

        public string insertarLectura(int NIS, int Mes, string fechalectura, int lectura)
        {
            string salida = "La lectura se inserto exitosamente";
            try
            {
                cmd = new SqlCommand("Insert into HISTORIALCONSUMO(NIS,MES,FECHALECTURA,LECTURA) values(" + NIS + ",'" + Mes + "','" + fechalectura + "','" + lectura + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto con la base de datos: " + ex.ToString();
            }
            return salida;
        }


        public int lecturaRegistrada(int NIS)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from HISTORIALCONSUMO where NIS =" + NIS + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró consultar: " + ex.ToString());
            }
            return contador;
        }



        public void leerClientes()
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from CLIENTES", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró consultar: " + ex.ToString());
            }
            // return contador;
        }

        //Metodo para llenar la tabla cuando se crea un cliente en el formulario CapturaClientes
        public void cargarClientes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from CLIENTES", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }



        //Metodo para llenar la tabla cuando se crea una categoria en el formulario Categorias
        public void cargarCategorias(DataGridView dgv1)
        {
            try
            {
                da = new SqlDataAdapter("Select * from CATEGORIAS", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }


        //Metodo para llenar la tabla cuando se crea una categoria en el formulario Registro de Hidrometros
        public void cargarHidrometros(DataGridView dgv1)
        {
            try
            {
                da = new SqlDataAdapter("Select * from HIDROMETROS", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }


        //Metodo para llenar la tabla cuando se crea una categoria en el formulario Registro de Funcionarios
        public void cargarFuncionarios(DataGridView dgv1)
        {
            try
            {
                da = new SqlDataAdapter("Select * from FUNCIONARIOS", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }



        public void llenarCategorias(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select DESCRIPCION from CATEGORIAS", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["DESCRIPCION"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }

        }

        public void ObtenerCodCategoria(string descripcion)
        {
            try
            {
                cmd = new SqlCommand("Select CODCATEGORIA from CATEGORIAS where  = " + descripcion + "", cn);
                dr = cmd.ExecuteReader();
                MessageBox.Show("La descripcion:" + descripcion);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }

        }

        public string[] AsociarCategoria(string desc)
        {
            string[] res = null;
            try
            {
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from CATEGORIAS where DESCRIPCION='" + desc + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string[] cat =
                    {
                    dr[0].ToString(),
                    dr[1].ToString()
                    };
                    res = cat;
                }
                cn.Close();
                cn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la categoria o la conexion: " + ex.ToString());
            }
            return res;


        }


        // metodo para cargar clientes en un combbox
        public void cargar_clientes(ComboBox clientes)
        {

            try
            {
                //cn.Close();
                //cn.Open();
                SqlCommand cmd = new SqlCommand("select IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2 from CLIENTES", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //cn.Close();

                DataRow fila = dt.NewRow();
                fila["IDENTIFICACION"] = "Selecciona un Cliente";
                dt.Rows.InsertAt(fila, 0);


                clientes.ValueMember = "IDENTIFICACION";
                clientes.DisplayMember = "IDENTIFICACION";
                clientes.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro cargar el combo box: " + ex.ToString());
            }


        }

        public string[] obtener_nombre(string identificacion)
        {
            string[] resultado = null;
            try
            {
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from CLIENTES where IDENTIFICACION='" + identificacion + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                //string[] resultado = null;
                while (dr.Read())
                {
                    string[] valores =
                    {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                };
                    resultado = valores;
                }
                cn.Close();
                cn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro cargar el combo box: " + ex.ToString());
            }

            return resultado;
        }



        // metodo para cargar lista de NIS en un combobox
        public void CargarNIS(ComboBox ListaNIS)
        {

            try
            {
                //cn.Close();
                //cn.Open();
                SqlCommand cmd = new SqlCommand("select * from HIDROMETROS", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //cn.Close();

                DataRow fila = dt.NewRow();
                fila["MARCA"] = "Selecciona un NIS";
                dt.Rows.InsertAt(fila, 0);


                ListaNIS.ValueMember = "NIS";
                ListaNIS.DisplayMember = "NIS";
                ListaNIS.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro cargar el combo box: " + ex.ToString());
            }


        }

        public int[] Obtener_NIS(int NIS)
        {
            int[] resultado = null;
            try
            {
                cn.Close();
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from HIDROMETROS where NIS='" + NIS + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                //string[] resultado = null;
                while (dr.Read())
                {
                    int[] valores =
                    {
                    (int)dr[0],
                    (int)dr[1],
                    (int)dr[2],
                    (int)dr[3]
                };
                    resultado = valores;
                }
                cn.Close();
                cn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro cargar el combo box: " + ex.ToString());
            }

            return resultado;
        }

    }


}



