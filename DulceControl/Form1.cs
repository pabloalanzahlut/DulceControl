using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPedidos
{
    public partial class Form1 : Form
    {
        private List<Pedido> pedidos = new List<Pedido>();
        private FlowLayoutPanel pedidosPanel;

        public Form1()
        {
            InitializeComponent();
            pedidos = PedidoManager.CargarPedidos();

            this.Text = "DulceControl";
            this.BackColor = Color.White;
            this.Size = new Size(450, 500);

            Panel barraSuperior = new Panel()
            {
                BackColor = Color.LightPink,
                Size = new Size(this.ClientSize.Width, 50),
                Dock = DockStyle.Top
            };

            Label titulo = new Label()
            {
                Text = "        DulceControl 🍩",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkMagenta,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            barraSuperior.Controls.Add(titulo);
            this.Controls.Add(barraSuperior);

            pedidosPanel = new FlowLayoutPanel()
            {
                Location = new Point(10, 60),
                Size = new Size(410, 300),
                AutoScroll = true
            };
            this.Controls.Add(pedidosPanel);

            Button btnNuevo = new Button()
            {
                Text = "+ Añadir nuevo pedido",
                Location = new Point(10, 370),
                Size = new Size(400, 40),
                BackColor = Color.DeepPink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnNuevo.Click += (s, e) => AñadirPedido();

            Button btnEstadisticas = new Button()
            {
                Text = "📊 Ver estadísticas",
                Location = new Point(10, 420),
                Size = new Size(400, 40),
                BackColor = Color.DeepPink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnEstadisticas.Click += (s, e) => new EstadisticasForm(pedidos).ShowDialog();

            this.Controls.Add(btnNuevo);
            this.Controls.Add(btnEstadisticas);

            AñadirPedido();
        }

        private void AñadirPedido()
        {
            PedidoControl control = new PedidoControl();
            pedidosPanel.Controls.Add(control);

            Button btnConfirmar = new Button()
            {
                Text = "✅ Confirmar",
                Width = 100,
                Location = new Point(290, control.Bottom + 5)
            };
            btnConfirmar.Click += (s, e) =>
            {
                Pedido pedido = control.ObtenerPedido();
                pedidos.Add(pedido);
                PedidoManager.GuardarPedidos(pedidos);
                btnConfirmar.Enabled = false;
            };
            control.Controls.Add(btnConfirmar);
        }
    }
}