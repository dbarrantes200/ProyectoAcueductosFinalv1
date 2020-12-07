namespace Tarea1
{
    public abstract class Persona
    {
        private string identificacion;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;

        protected Persona(string identificacion, string nombre, string primerApellido, string segundoApellido)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
        }


        // Constructor  con cuatro parametros


        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }



        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }




        public override string ToString()
        {
            return string.Format("Identificacion: {0} Nombre Completo: {1} {2} {3}",
               Identificacion, Nombre, PrimerApellido, SegundoApellido);
        }

    }
}
