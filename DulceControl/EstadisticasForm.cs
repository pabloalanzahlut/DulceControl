using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPedidos
{
    public class EstadisticasForm : Form
    {
        public EstadisticasForm(List<Pedido> pedidos)
        {
            this.Text = "Estadísticas";
            this.Size = new Size(400, 300);
            this.BackColor = Color.WhiteSmoke;

            int totalMembrillo = pedidos.Sum(p => p.CantMembrillo);
            int totalBatata = pedidos.Sum(p => p.CantBatata);
            int totalPastelitos = totalMembrillo + totalBatata;
            int docenas = totalPastelitos / 6;
            int sueltos = totalPastelitos % 6;
            int totalRecaudado = pedidos.Sum(p => p.Precio);
            int tapas = totalPastelitos * 2;
            int ganancia = totalRecaudado - tapas * 300;

            Label lbl = new Label()
            {
                Text = $"Total Membrillo: {totalMembrillo}\n" +
                       $"Total Batata: {totalBatata}\n" +
                       $"Docenas: {docenas} {(sueltos > 0 ? "y " + sueltos + " sueltos" : "")}\n" +
                       $"Total tapas: {tapas}\n" +
                       $"Recaudado: ${totalRecaudado}\n" +
                       $"Ganancia: ${ganancia}",
                Location = new Point(20, 20),
                Size = new Size(350, 200),
                Font = new Font("Segoe UI", 10)
            };

            this.Controls.Add(lbl);
        }
    }
}
