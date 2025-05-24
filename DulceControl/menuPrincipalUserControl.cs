using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelitos
{
    public partial class menuPrincipalUserControl : UserControl
    {
        public menuPrincipalUserControl()
        {
            InitializeComponent();
        }

        public void nuevoPedido_Click(object sender, EventArgs e)
        {
            Form1? principal = this.FindForm() as Form1;
            if (principal != null)
            {
                principal.MostrarControl(new nuevoPedidoUserControl());
            }
        }

        private void estadisticas_Click(object sender, EventArgs e)
        {
            /*Form1? principal = this.FindForm() as Form1;
            if (principal != null)
            {
                principal.MostrarControl(new estadisticasUserControl());
            }*/
        }

        private void listaPedidos_Click(object sender, EventArgs e)
        {
            /*Form1? principal = this.FindForm() as Form1;
            if (principal != null)
            {
                principal.MostrarControl(new listaPedidosUserControl());
            }*/
        }

        private void general_MouseEnter(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn == null) return;

            if (btn == nuevoPedido)
            {
                nuevoPedido.BackColor = Color.FromArgb(255, 192, 255);
                nuevoPedido.ForeColor = Color.WhiteSmoke;
            }

            if (btn == Estadisticas)
            {
                Estadisticas.BackColor = Color.FromArgb(255, 192, 255);
                Estadisticas.ForeColor = Color.WhiteSmoke;
            }

            if (btn == listaPedidos)
            {
                listaPedidos.BackColor = Color.FromArgb(255, 192, 255);
                listaPedidos.ForeColor = Color.WhiteSmoke;
            }
        }

        private void general_MouseLeave(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn == null) return;

            if (btn == nuevoPedido)
            {
                nuevoPedido.BackColor = Color.HotPink;
                nuevoPedido.ForeColor = Color.White;
            }

            if (btn == Estadisticas)
            {
                Estadisticas.BackColor = Color.HotPink;
                Estadisticas.ForeColor = Color.White;
            }

            if (btn == listaPedidos)
            {
                listaPedidos.BackColor = Color.HotPink;
                listaPedidos.ForeColor = Color.White;
            }
        }
    }
}
