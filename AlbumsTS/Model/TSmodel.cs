using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsTS.Model
{
    public class TSmodel
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public int? NumeroCanciones { get; set; }
        public string? Genero { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string? ImagenURL { get; set; }

    }
}
