namespace Pastelitos
{
    partial class menuPrincipalUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipalUserControl));
            Titulo = new Label();
            nuevoPedido = new Button();
            Estadisticas = new Button();
            listaPedidos = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.BackColor = Color.FromArgb(203, 155, 74);
            Titulo.Cursor = Cursors.IBeam;
            Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(150, 2);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(416, 97);
            Titulo.TabIndex = 33;
            Titulo.Text = "🍩 DulceControl";
            // 
            // nuevoPedido
            // 
            nuevoPedido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nuevoPedido.BackColor = Color.HotPink;
            nuevoPedido.FlatStyle = FlatStyle.Popup;
            nuevoPedido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nuevoPedido.ForeColor = Color.White;
            nuevoPedido.Location = new Point(171, 203);
            nuevoPedido.Name = "nuevoPedido";
            nuevoPedido.Size = new Size(395, 55);
            nuevoPedido.TabIndex = 34;
            nuevoPedido.Text = "Agregar pedido nuevo";
            nuevoPedido.UseVisualStyleBackColor = false;
            nuevoPedido.Click += nuevoPedido_Click;
            nuevoPedido.MouseEnter += general_MouseEnter;
            nuevoPedido.MouseLeave += general_MouseLeave;
            // 
            // Estadisticas
            // 
            Estadisticas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Estadisticas.BackColor = Color.HotPink;
            Estadisticas.FlatStyle = FlatStyle.Popup;
            Estadisticas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Estadisticas.ForeColor = Color.White;
            Estadisticas.Location = new Point(171, 285);
            Estadisticas.Name = "Estadisticas";
            Estadisticas.Size = new Size(395, 55);
            Estadisticas.TabIndex = 35;
            Estadisticas.Text = "Estadisticas";
            Estadisticas.UseVisualStyleBackColor = false;
            Estadisticas.Click += nuevoPedido_Click;
            Estadisticas.MouseEnter += general_MouseEnter;
            Estadisticas.MouseLeave += general_MouseLeave;
            // 
            // listaPedidos
            // 
            listaPedidos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            listaPedidos.BackColor = Color.HotPink;
            listaPedidos.FlatStyle = FlatStyle.Popup;
            listaPedidos.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listaPedidos.ForeColor = Color.White;
            listaPedidos.Location = new Point(171, 365);
            listaPedidos.Name = "listaPedidos";
            listaPedidos.Size = new Size(395, 55);
            listaPedidos.TabIndex = 36;
            listaPedidos.Text = "Lista de pedidos";
            listaPedidos.UseVisualStyleBackColor = false;
            listaPedidos.Click += nuevoPedido_Click;
            listaPedidos.MouseEnter += general_MouseEnter;
            listaPedidos.MouseLeave += general_MouseLeave;
            // 
            // menuPrincipalUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 155, 74);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(listaPedidos);
            Controls.Add(Estadisticas);
            Controls.Add(nuevoPedido);
            Controls.Add(Titulo);
            Name = "menuPrincipalUserControl";
            Size = new Size(765, 568);
            ResumeLayout(false);
        }

        private void NuevoPedido_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Label Titulo;
        private Button nuevoPedido;
        private Button Estadisticas;
        private Button listaPedidos;
    }
}
