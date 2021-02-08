using System.Collections.Generic;

namespace UD24_EJ3.Models
{
    public class Asignado_a
    {
        public int Id { get; set; }
        public string Cientifico { get; set; }
        public string Proyecto { get; set; }

        public IEnumerable<Asignado_a> Asignados_a { get; set; }
    }
}
