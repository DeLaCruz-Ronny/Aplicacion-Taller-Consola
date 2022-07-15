using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Entities
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public float Total { get; set; }
        public Cliente? IdCliente { get; set; }
        public float MontoSaldado { get; set; }
        public bool Saldada { get; set; }
        public Item? IdItem { get; set; }
    }
}
