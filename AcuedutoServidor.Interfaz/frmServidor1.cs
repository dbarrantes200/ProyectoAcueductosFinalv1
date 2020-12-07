using AcueductoServidor.Entidades;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace AcuedutoServidor.Interfaz
{
    public partial class frmServidor : Form
    {
        // public static bool IndicarFormularioServidorIniciado;
        TcpListener tcpListener;
        Thread subprocesoEscuchaClientes;
        EscribirEnTextboxDelegado modificarTextotxtBitacora;
        ModoficarListBoxDelegado modificarListBoxClientes;
        // DatosBiblioteca accesoDatos;
        bool servidorIniciado;
        public static bool IndicarFormularioServidorIniciado;


        public frmServidor()
        {
            InitializeComponent();
            modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);
            lblEstado.ForeColor = Color.Red;
            btnDetener.Enabled = false;
        }

        //Delegado, necesario para modificar controles de la interfaz gráfica desde un subproceso
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void EscribirEnTextbox(string texto)
        {
            txtBitacora.AppendText(DateTime.Now.ToString() + " - " + texto);
            txtBitacora.AppendText(Environment.NewLine);
        }

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                lstClientesConectados.Items.Add(texto);
            }
            else
            {
                lstClientesConectados.Items.Remove(texto);
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 30000);
            servidorIniciado = true;

            subprocesoEscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
            subprocesoEscuchaClientes.Start();
            subprocesoEscuchaClientes.IsBackground = true;
            lblEstado.Text = "Escuchando clientes... en (127.0.0.1, 30000)";
            lblEstado.ForeColor = Color.Green;
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;

            txtBitacora.Text = "Servidor iniciado... en (127.0.0.1, 30000)";
            txtBitacora.AppendText(Environment.NewLine);
        }

        private void EscucharClientes()
        {

            try
            {
                tcpListener.Start();
                while (servidorIniciado)
                {
                    //Se bloquea hasta que un cliente se haya conectado al servidor 
                    TcpClient client = tcpListener.AcceptTcpClient();
                    /*Se crea un nuevo hilo para manejar la comunicación con los clientes que se conectan al servidor*/
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(client);
                    clientThread.IsBackground = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }


        }

        private void ComunicacionCliente(object cliente)
        {
            TcpClient tcCliente = (TcpClient)cliente;
            StreamReader reader = new StreamReader(tcCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());//El StreamWriter debe ser único por subproceso y por cliente por eso se pasa por referencia

            while (servidorIniciado)
            {

                try
                {
                    /*Esta sección se bloquea hasta que el cliente envíe unmensaje*/
                    var mensaje = reader.ReadLine();
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje);//Se deserializa el objeto recibido mediante json
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception)
                {
                    //Ocurrió un error en el socket 
                    break;
                }
            }

            tcCliente.Close();
        }

        public void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad);
                    break;
                case "CalcularPago":
                    // MensajeSocket<Autor> mensajeCalcularPago = JsonConvert.DeserializeObject<MensajeSocket<Cliente>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    // CalcularPago(mensajeFrmMontoCancelar.Entidad);
                    break;
                case "Desconectar":
                    MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                    break;
                default:
                    break;
            }

        }

        private void Desconectar(string pIdentificadorCliente)
        {
            txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { pIdentificadorCliente + " se ha desconectado!" });
            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente, false });
        }

        private void Conectar(string pIdentificadorCliente)
        {
            txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { pIdentificadorCliente + " se ha conectado..." });
            lstClientesConectados.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente, true });

        }

        private void frmServidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Este evento se dispara cuando el formulario se cierra, de esta forma podemos indicar que el servidor ya no esta iniciado
            IndicarFormularioServidorIniciado = false;
        }


        private void btnDetener_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();
            subprocesoEscuchaClientes.Abort();
            lblEstado.ForeColor = Color.Red;
            lblEstado.Text = "Sin iniciar";
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
        }
    }
}
