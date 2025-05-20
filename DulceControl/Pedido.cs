using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos
{
    [Serializable]
    public class Pedido
    {
        public string Nombre { get; set; }
        public int CantMembrillo { get; set; }
        public int CantBatata { get; set; }
        public int Precio { get; set; }
    }
}