using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Entities
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string? Descripcion { get; set; }
        public float Costo { get; set; }
        public bool Disponibilidad { get; set; }

    }
}
