using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Entities
{
    public class Item
    {
        public int IdItem { get; set; }
        public Servicio? IdServicio { get; set; }
        public int Cantidad { get; set; }
        public Personal? IdPersonal { get; set; }
    }
}
