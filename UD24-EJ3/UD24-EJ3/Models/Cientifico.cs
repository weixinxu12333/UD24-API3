using System.Collections.Generic;

namespace UD24_EJ3.Models
{
    public class Cientifico
    {
        public string Dni { get; set; }
        public string NomApels { get; set; }

        public IEnumerable<Cientifico> Cientificos { get; set; }
    }
}
