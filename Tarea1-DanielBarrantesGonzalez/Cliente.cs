namespace Tarea1
{
    public class Cliente : Persona
    {
        private string correoElectronico;
        private string numeroCelular;

        public Cliente(string identificacion, string nombre, string primerApellido, string segundoApellido) : base(identificacion, nombre, primerApellido, segundoApellido)
        {
        }

        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string NumeroCelular { get => numeroCelular; set => numeroCelular = value; }

        public override string ToString()
        {
            // return string.Format("Identificacion: {0} Nombre: {1} {2} {3} Correo Electronico: {4} Numero de Celular: {5} ",
            return string.Format("{0} {1} {2} {3}  {4}  {5} ",
                Identificacion, Nombre, PrimerApellido, SegundoApellido, CorreoElectronico, NumeroCelular);
        }

    }
}
