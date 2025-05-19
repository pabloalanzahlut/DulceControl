using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.Size = new Size(450, 450);

            // Barra superior (rosa pastel)
            Panel barraSuperior = new Panel()
            {
                BackColor = Color.LightPink,
                Size = new Size(this.ClientSize.Width, 50),
                Location = new Point(0, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            Label titulo = new Label()
            {
                Text = "        DulceControl 🍩",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DarkMagenta,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            barraSuperior.Controls.Add(titulo);
            this.Controls.Add(barraSuperior);

            // Crear instancia del control PedidoControl
            PedidoControl pedido1 = new PedidoControl() { Location = new Point(10, barraSuperior.Bottom + 10) };

            this.Controls.Add(pedido1);

            // Agregar botones abajo
            Button btnNuevo = new Button()
            {
                Text = "+ Añadir nuevo pedido",
                Location = new Point(10, 280),
                Width = 400,
                Height = 40,
                BackColor = Color.DeepPink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            Button btnEstadisticas = new Button()
            {
                Text = "📊 Ver estadísticas",
                Location = new Point(10, 330),
                Width = 400,
                Height = 40,
                BackColor = Color.DeepPink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            this.Controls.Add(btnNuevo);
            this.Controls.Add(btnEstadisticas);
        }
    }

    public class PedidoControl : UserControl
    {
        public PedidoControl()
        {
            this.BackColor = Color.LightYellow;
            this.Size = new Size(400, 200);

            Label label = new Label()
            {
                Text = "PedidoControl activo",
                Location = new Point(10, 10),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                AutoSize = true
            };
            this.Controls.Add(label);
        }
    }
}
