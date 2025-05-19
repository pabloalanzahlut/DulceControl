using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPedidos
{
    public class PedidoForm : Form
    {
        public PedidoForm()
        {
            // Tamaño y título
            this.Text = "Gestión de Pedido";
            this.Size = new Size(450, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Fuente base
            Font defaultFont = new Font("Segoe UI", 10);

            // Cliente
            Label lblCliente = new Label()
            {
                Text = "Cliente:",
                Location = new Point(20, 20),
                AutoSize = true,
                Font = defaultFont
            };
            TextBox txtCliente = new TextBox()
            {
                Location = new Point(100, 18),
                Width = 300,
                Font = defaultFont
            };

            // Pedido
            Label lblPedido = new Label()
            {
                Text = "Pedido: Docenas",
                Location = new Point(20, 60),
                AutoSize = true,
                Font = defaultFont
            };
            NumericUpDown numDocenas = new NumericUpDown()
            {
                Location = new Point(150, 58),
                Width = 60,
                Value = 12,
                Font = defaultFont
            };
            Label lblEntregadas = new Label()
            {
                Text = "Entregadas",
                Location = new Point(230, 60),
                AutoSize = true,
                Font = defaultFont
            };
            NumericUpDown numEntregadas = new NumericUpDown()
            {
                Location = new Point(320, 58),
                Width = 60,
                Value = 6,
                Font = defaultFont
            };

            // Monto
            Label lblMonto = new Label()
            {
                Text = "Monto: $",
                Location = new Point(20, 100),
                AutoSize = true,
                Font = defaultFont
            };
            TextBox txtMonto = new TextBox()
            {
                Location = new Point(100, 98),
                Width = 100,
                Text = "4500",
                Font = defaultFont
            };

            // Estado
            Label lblEstado = new Label()
            {
                Text = "Estado:",
                Location = new Point(20, 140),
                AutoSize = true,
                Font = defaultFont
            };
            CheckBox chkPedido = new CheckBox()
            {
                Text = "Pedido",
                Location = new Point(100, 138),
                Checked = true,
                Font = defaultFont
            };
            CheckBox chkEntregado = new CheckBox()
            {
                Text = "Entregado",
                Location = new Point(200, 138),
                Font = defaultFont
            };
            CheckBox chkPagado = new CheckBox()
            {
                Text = "Pagado",
                Location = new Point(100, 170),
                Checked = true,
                Font = defaultFont
            };

            // Línea separadora
            Panel separator = new Panel()
            {
                BorderStyle = BorderStyle.Fixed3D,
                Size = new Size(400, 2),
                Location = new Point(20, 210)
            };

            // Botones de acción
            Button btnEditar = new Button()
            {
                Text = "Editar",
                Location = new Point(30, 230),
                Width = 100,
                Font = defaultFont
            };
            Button btnEliminar = new Button()
            {
                Text = "Eliminar",
                Location = new Point(140, 230),
                Width = 100,
                Font = defaultFont
            };
            Button btnHistorial = new Button()
            {
                Text = "Ver historial",
                Location = new Point(250, 230),
                Width = 120,
                Font = defaultFont
            };

            // Línea separadora 2
            Panel separator2 = new Panel()
            {
                BorderStyle = BorderStyle.Fixed3D,
                Size = new Size(400, 2),
                Location = new Point(20, 270)
            };

            // Botón: Añadir nuevo pedido
            Button btnNuevoPedido = new Button()
            {
                Text = "+ Añadir nuevo pedido",
                Location = new Point(20, 290),
                Width = 380,
                Height = 40,
                BackColor = Color.DeepPink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Botón: Ver estadísticas
            Button btnEstadisticas = new Button()
            {
                Text = "📊 Ver estadísticas",
                Location = new Point(20, 340),
                Width = 380,
                Height = 40,
                BackColor = Color.DeepPink,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Añadir todos los controles al formulario
            this.Controls.Add(lblCliente);
            this.Controls.Add(txtCliente);
            this.Controls.Add(lblPedido);
            this.Controls.Add(numDocenas);
            this.Controls.Add(lblEntregadas);
            this.Controls.Add(numEntregadas);
            this.Controls.Add(lblMonto);
            this.Controls.Add(txtMonto);
            this.Controls.Add(lblEstado);
            this.Controls.Add(chkPedido);
            this.Controls.Add(chkEntregado);
            this.Controls.Add(chkPagado);
            this.Controls.Add(separator);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnHistorial);
            this.Controls.Add(separator2);
            this.Controls.Add(btnNuevoPedido);
            this.Controls.Add(btnEstadisticas);
        }
    }
}
