namespace Tarea1
{
    class Funcionario : Persona
    {
        public Funcionario(string identificacion, string nombre, string primerApellido, string segundoApellido) : base(identificacion, nombre, primerApellido, segundoApellido)
        {
        }

        public override string ToString()
        {
            return string.Format("Identificacion: {0} Nombre {1}, {2} {3})",
               Identificacion, Nombre, PrimerApellido, SegundoApellido);
        }
    }


}
