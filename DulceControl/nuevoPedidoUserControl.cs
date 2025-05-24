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
    public partial class nuevoPedidoUserControl : UserControl
    {
        public nuevoPedidoUserControl()
        {
            InitializeComponent();
        }

        private void Agregarbutton_MouseEnter(object sender, EventArgs e)
        {
            Agregar.BackColor = Color.FromArgb(50, 50, 50);
            Agregar.ForeColor = Color.FromArgb(20, 20, 20);
        }

        private void Agregarbutton_MouseLeave(object sender, EventArgs e)
        {
            Agregar.BackColor = Color.FromArgb(100, 100, 100);
            Agregar.ForeColor = Color.White;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido
            {
                Nombre = Cliente.Text,
                Membrillo = (int)membrillo.Value,
                Batata = (int)batata.Value
            };

            // Ruta válida y siempre accesible
            // C:\Users\User\Documents\Pastelitos\DatosPedidos
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pastelitos", "DatosPedidos");
            Directory.CreateDirectory(carpeta); // crea todo el árbol de carpetas si no existe

            string archivo = Path.Combine(carpeta, "pedidos1.bin");

            using (FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(pedido.Nombre);
                writer.Write(pedido.Membrillo);
                writer.Write(pedido.Batata);
            }

            MessageBox.Show("✅ Pedido guardado correctamente en:\n" + archivo);

            // Reset campos
            membrillo.Value = 0;
            batata.Value = 0;
            Cliente.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1? principal = this.FindForm() as Form1;
            if (principal != null)
            {
                principal.MostrarControl(new menuPrincipalUserControl());
            }
        }
    }
}
