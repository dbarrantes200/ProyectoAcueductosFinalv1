namespace Tarea1
{
    public class Hidrometro
    {
        public Hidrometro(string numeroNis, string marca, string numeroSerie, string categoria, string cliente)
        {
            NumeroNis = numeroNis;
            Marca = marca;
            NumeroSerie = numeroSerie;
            Categoria = categoria;
            Cliente = cliente;
        }

        public string NumeroNis { get; set; }
        public string Marca { get; set; }
        public string NumeroSerie { get; set; }
        public string Categoria { get; set; }
        public string Cliente { get; set; }

        public override string ToString()
        {
            return string.Format("Numero NIS: {0} Marca:  {1} Numero de Serie: {2} Categoria:{3} Cliente: {4}",
               NumeroNis, Marca, NumeroSerie, Categoria, Cliente);
        }


    }





}
