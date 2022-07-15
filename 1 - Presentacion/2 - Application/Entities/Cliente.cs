using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public float MontoDeuda { get; set; }
        public int Facturaciones { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
