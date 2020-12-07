namespace Tarea1
{
    class Categoria
    {
        public Categoria(string categoriasServicios, string descripcion)
        {
            this.CategoriasServicios = categoriasServicios;
            this.Descripcion = descripcion;
        }

        public string CategoriasServicios { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return string.Format("Categorias de Servicios: {0} Descripcion: {1}",
               CategoriasServicios, Descripcion);
        }
    }
}
