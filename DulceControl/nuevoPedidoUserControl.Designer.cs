namespace Pastelitos
{
    partial class nuevoPedidoUserControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoPedidoUserControl));
            Titulo = new Label();
            Cliente = new TextBox();
            cliente_label = new Label();
            membrillo_label = new Label();
            membrillo = new NumericUpDown();
            batata_label = new Label();
            batata = new NumericUpDown();
            Agregar = new Button();
            toolTip1 = new ToolTip(components);
            backButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)membrillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)batata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.BackColor = Color.FromArgb(203, 155, 74);
            Titulo.Cursor = Cursors.IBeam;
            Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(144, 12);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(416, 97);
            Titulo.TabIndex = 33;
            Titulo.Text = "🍩 DulceControl";
            // 
            // Cliente
            // 
            Cliente.BackColor = Color.FromArgb(255, 192, 128);
            Cliente.HideSelection = false;
            Cliente.Location = new Point(300, 157);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(183, 23);
            Cliente.TabIndex = 34;
            // 
            // cliente_label
            // 
            cliente_label.AutoSize = true;
            cliente_label.BackColor = Color.FromArgb(203, 155, 74);
            cliente_label.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cliente_label.ForeColor = Color.White;
            cliente_label.Location = new Point(181, 146);
            cliente_label.Name = "cliente_label";
            cliente_label.Size = new Size(114, 37);
            cliente_label.TabIndex = 35;
            cliente_label.Text = "Cliente:";
            // 
            // membrillo_label
            // 
            membrillo_label.AutoSize = true;
            membrillo_label.BackColor = Color.Transparent;
            membrillo_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            membrillo_label.ForeColor = Color.White;
            membrillo_label.Location = new Point(180, 219);
            membrillo_label.Name = "membrillo_label";
            membrillo_label.Size = new Size(109, 25);
            membrillo_label.TabIndex = 40;
            membrillo_label.Text = "Membrillo:";
            // 
            // membrillo
            // 
            membrillo.Location = new Point(321, 223);
            membrillo.Name = "membrillo";
            membrillo.Size = new Size(41, 23);
            membrillo.TabIndex = 38;
            // 
            // batata_label
            // 
            batata_label.AutoSize = true;
            batata_label.BackColor = Color.Transparent;
            batata_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batata_label.ForeColor = Color.White;
            batata_label.Location = new Point(215, 268);
            batata_label.Name = "batata_label";
            batata_label.Size = new Size(73, 25);
            batata_label.TabIndex = 41;
            batata_label.Text = "Batata:";
            // 
            // batata
            // 
            batata.Location = new Point(321, 272);
            batata.Name = "batata";
            batata.Size = new Size(41, 23);
            batata.TabIndex = 39;
            // 
            // Agregar
            // 
            Agregar.AutoSize = true;
            Agregar.BackColor = Color.FromArgb(100, 100, 100);
            Agregar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Agregar.ForeColor = Color.White;
            Agregar.Location = new Point(279, 385);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(174, 59);
            Agregar.TabIndex = 42;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            Agregar.MouseEnter += Agregarbutton_MouseEnter;
            Agregar.MouseLeave += Agregarbutton_MouseLeave;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Gray;
            backButton.BackgroundImage = (Image)resources.GetObject("backButton.BackgroundImage");
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(34, 32);
            backButton.TabIndex = 43;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // nuevoPedidoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(Agregar);
            Controls.Add(batata);
            Controls.Add(membrillo);
            Controls.Add(batata_label);
            Controls.Add(membrillo_label);
            Controls.Add(cliente_label);
            Controls.Add(Cliente);
            Controls.Add(Titulo);
            Controls.Add(backButton);
            Name = "nuevoPedidoUserControl";
            Size = new Size(765, 568);
            ((System.ComponentModel.ISupportInitialize)membrillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)batata).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label Titulo;
        private TextBox Cliente;
        private Label cliente_label;
        private Label membrillo_label;
        private NumericUpDown membrillo;
        private Label batata_label;
        private NumericUpDown batata;
        private Button Agregar;
        private ToolTip toolTip1;
        private PictureBox backButton;
    }
}
