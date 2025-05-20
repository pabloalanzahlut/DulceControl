using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SistemaPedidos
{
    public static class PedidoManager
    {
        private static string ruta = "pedidos.bin";

        public static void GuardarPedidos(List<Pedido> pedidos)
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, pedidos);
            }
        }

        public static List<Pedido> CargarPedidos()
        {
            if (!File.Exists(ruta)) return new List<Pedido>();
            using (FileStream fs = new FileStream(ruta, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Pedido>)formatter.Deserialize(fs);
            }
        }
    }
}
