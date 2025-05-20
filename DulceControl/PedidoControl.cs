using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPedidos
{
    public class PedidoControl : UserControl
    {
        public TextBox txtNombre;
        public NumericUpDown nudMembrillo;
        public NumericUpDown nudBatata;

        public PedidoControl()
        {
            this.BackColor = Color.LightYellow;
            this.Size = new Size(400, 100);

            Label lblNombre = new Label { Text = "Nombre:", Location = new Point(10, 10) };
            txtNombre = new TextBox { Location = new Point(70, 10), Width = 300 };

            Label lblMem = new Label { Text = "Membrillo:", Location = new Point(10, 40) };
            nudMembrillo = new NumericUpDown { Location = new Point(80, 40), Width = 50 };

            Label lblBat = new Label { Text = "Batata:", Location = new Point(150, 40) };
            nudBatata = new NumericUpDown { Location = new Point(210, 40), Width = 50 };

            this.Controls.AddRange(new Control[] { lblNombre, txtNombre, lblMem, nudMembrillo, lblBat, nudBatata });
        }

        public Pedido ObtenerPedido()
        {
            int total = (int)(nudMembrillo.Value + nudBatata.Value);
            int docenas = total / 6;
            int sueltos = total % 6;
            int precio = 0;
            const int PRECIO_MEDIA = 2400, PRECIO_DOCENA = 4500, PRECIO_DOS_DOCENA = 8000;

            while (docenas > 0)
            {
                if (docenas >= 4) { precio += PRECIO_DOS_DOCENA; docenas -= 4; }
                else if (docenas >= 2) { precio += PRECIO_DOCENA; docenas -= 2; }
                else { precio += PRECIO_MEDIA; docenas--; }
            }
            precio += sueltos * 400;

            return new Pedido
            {
                Nombre = txtNombre.Text,
                CantMembrillo = (int)nudMembrillo.Value,
                CantBatata = (int)nudBatata.Value,
                Precio = precio
            };
        }
    }
}