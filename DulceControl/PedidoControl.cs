using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPedidos
{
    public class PedidoControl : UserControl
    {
        public TextBox txtNombre;
        public NumericUpDown nudMembrillo;
        public NumericUpDown nudBatata;
        private Label lblPrecio;

        public PedidoControl()
        {
            this.BackColor = Color.LightYellow;
            this.Size = new Size(400, 130);

            Label lblNombre = new Label { Text = "Nombre:", Location = new Point(10, 10), AutoSize = true };
            txtNombre = new TextBox { Location = new Point(70, 10), Width = 300 };

            Label lblMem = new Label { Text = "Membrillo:", Location = new Point(10, 40), AutoSize = true };
            nudMembrillo = new NumericUpDown { Location = new Point(80, 40), Width = 50, Minimum = 0 };
            nudMembrillo.ValueChanged += ActualizarPrecio;

            Label lblBat = new Label { Text = "Batata:", Location = new Point(150, 40), AutoSize = true };
            nudBatata = new NumericUpDown { Location = new Point(210, 40), Width = 50, Minimum = 0 };
            nudBatata.ValueChanged += ActualizarPrecio;

            lblPrecio = new Label
            {
                Text = "Precio: $0",
                Location = new Point(10, 80),
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                AutoSize = true
            };

            this.Controls.AddRange(new Control[] { lblNombre, txtNombre, lblMem, nudMembrillo, lblBat, nudBatata, lblPrecio });

            // Inicializa precio al principio
            ActualizarPrecio(null, null);
        }

        private void ActualizarPrecio(object? sender, EventArgs? e)
        {
            try
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

                lblPrecio.Text = $"Precio: ${precio}";
            }
            catch
            {
                lblPrecio.Text = "Precio: $0";
            }
        }

        public Pedido ObtenerPedido()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                throw new InvalidOperationException("El nombre no puede estar vacío.");

            int total = (int)(nudMembrillo.Value + nudBatata.Value);
            if (total == 0)
                throw new InvalidOperationException("Debe ingresar al menos un pastelito.");

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

            return new DulceControl.Models.Pedido
            {
                Nombre = txtNombre.Text,
                CantMembrillo = (int)nudMembrillo.Value,
                CantBatata = (int)nudBatata.Value,
                Precio = precio
            };


        }
    }

    public class Pedido
    {
        public string Nombre { get; set; } = string.Empty;
        public int CantMembrillo { get; set; }
        public int CantBatata { get; set; }
        public int Precio { get; set; }
    }

}
