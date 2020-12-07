#pragma warning disable CS0246 // The type or namespace name 'AcueductoServidor' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'AcueductoServidor' could not be found (are you missing a using directive or an assembly reference?)
using AcueductoServidor.Entidades;
#pragma warning restore CS0246 // The type or namespace name 'AcueductoServidor' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'AcueductoServidor' could not be found (are you missing a using directive or an assembly reference?)
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace AcueductoCliente.Interfaz
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        /// <summary>
        /// Conecta el cliente tcp con el servidor
        /// </summary>
        /// <param name="pIdentificadorCliente">Identificador o nombre del cliente</param>
        /// <returns>Retorna true si se conecta con el servidor</returns>
        /// 
        public static bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 30000);
                cliente.Connect(serverEndPoint);
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();
            }
            catch (SocketException)
            {

                return false;
            }

            return true;
        }

        public static void Desconectar(string pIdentificadorCliente)
        {
            MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            //Se cierra la conexión del cliente
            cliente.Close();
        }


    }


}
