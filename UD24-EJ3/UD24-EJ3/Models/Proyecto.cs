using System.Collections.Generic;

namespace UD24_EJ3.Models
{
    public class Proyecto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Horas { get; set; }

        public IEnumerable<Proyecto> Proyectos { get; set; }

    }
}
