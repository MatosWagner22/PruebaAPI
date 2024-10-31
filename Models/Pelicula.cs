

using System.ComponentModel.DataAnnotations;

namespace PruebaAPI
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Descripcion { get; set; }
        public bool EsEstreno { get; set; }
        public string Genero { get; set; }
        public bool EsAnimada { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string UrlVideo { get; set; }
    }
}
