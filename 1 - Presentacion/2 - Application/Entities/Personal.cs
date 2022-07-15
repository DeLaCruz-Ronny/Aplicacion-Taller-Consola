using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Entities
{
    public class Personal
    {
        public int IdPersonal { get; set; }
        public string? Especialidad { get; set; }
        public bool Disponibilidad { get; set; }
        public Persona? IdPersona { get; set; }
    }
}
