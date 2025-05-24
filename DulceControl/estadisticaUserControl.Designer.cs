namespace Pastelitos
{
    partial class estadisticaUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estadisticaUserControl));
            Titulo = new Label();
            docena_label = new Label();
            membrillo_label = new Label();
            batata_label = new Label();
            docenas = new Label();
            membrillo = new Label();
            batata = new Label();
            recaudo_label = new Label();
            recaudo = new Label();
            ganancia_label = new Label();
            ganancia = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.BackColor = Color.FromArgb(203, 155, 74);
            Titulo.Cursor = Cursors.IBeam;
            Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(148, 1);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(416, 97);
            Titulo.TabIndex = 33;
            Titulo.Text = "🍩 DulceControl";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // docena_label
            // 
            docena_label.AutoSize = true;
            docena_label.BackColor = Color.Transparent;
            docena_label.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            docena_label.ForeColor = Color.White;
            docena_label.Location = new Point(176, 144);
            docena_label.Name = "docena_label";
            docena_label.Size = new Size(106, 30);
            docena_label.TabIndex = 34;
            docena_label.Text = "Docenas:";
            // 
            // membrillo_label
            // 
            membrillo_label.AutoSize = true;
            membrillo_label.BackColor = Color.Transparent;
            membrillo_label.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            membrillo_label.ForeColor = Color.White;
            membrillo_label.Location = new Point(176, 211);
            membrillo_label.Name = "membrillo_label";
            membrillo_label.Size = new Size(126, 30);
            membrillo_label.TabIndex = 35;
            membrillo_label.Text = "Membrillo:";
            // 
            // batata_label
            // 
            batata_label.AutoSize = true;
            batata_label.BackColor = Color.Transparent;
            batata_label.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            batata_label.ForeColor = Color.White;
            batata_label.Location = new Point(176, 274);
            batata_label.Name = "batata_label";
            batata_label.Size = new Size(89, 30);
            batata_label.TabIndex = 35;
            batata_label.Text = "Batata:";
            // 
            // docenas
            // 
            docenas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            docenas.BackColor = Color.Gainsboro;
            docenas.ForeColor = Color.Black;
            docenas.Location = new Point(328, 144);
            docenas.Name = "docenas";
            docenas.Size = new Size(196, 27);
            docenas.TabIndex = 40;
            docenas.Text = "docenas";
            docenas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // membrillo
            // 
            membrillo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            membrillo.BackColor = Color.Gainsboro;
            membrillo.ForeColor = Color.Black;
            membrillo.Location = new Point(328, 214);
            membrillo.Name = "membrillo";
            membrillo.Size = new Size(196, 27);
            membrillo.TabIndex = 41;
            membrillo.Text = "membrillo";
            membrillo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batata
            // 
            batata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            batata.BackColor = Color.Gainsboro;
            batata.ForeColor = Color.Black;
            batata.Location = new Point(328, 277);
            batata.Name = "batata";
            batata.Size = new Size(196, 27);
            batata.TabIndex = 42;
            batata.Text = "batata";
            batata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recaudo_label
            // 
            recaudo_label.AutoSize = true;
            recaudo_label.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            recaudo_label.BackColor = Color.Transparent;
            recaudo_label.Location = new Point(176, 338);
            recaudo_label.Name = "recaudo_label";
            recaudo_label.Size = new Size(132, 30);
            recaudo_label.TabIndex = 43;
            recaudo_label.Text = "Recaudado:";
            // 
            // recaudo
            // 
            recaudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recaudo.BackColor = Color.Gainsboro;
            recaudo.ForeColor = Color.Black;
            recaudo.Location = new Point(328, 341);
            recaudo.Name = "recaudo";
            recaudo.Size = new Size(196, 27);
            recaudo.TabIndex = 44;
            recaudo.Text = "recaudo";
            recaudo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ganancia_label
            // 
            ganancia_label.AutoSize = true;
            ganancia_label.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            ganancia_label.BackColor = Color.Transparent;
            ganancia_label.Location = new Point(176, 403);
            ganancia_label.Name = "ganancia_label";
            ganancia_label.Size = new Size(113, 30);
            ganancia_label.TabIndex = 45;
            ganancia_label.Text = "Ganancia:";
            // 
            // ganancia
            // 
            ganancia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ganancia.BackColor = Color.Gainsboro;
            ganancia.ForeColor = Color.Black;
            ganancia.Location = new Point(328, 406);
            ganancia.Name = "ganancia";
            ganancia.Size = new Size(196, 27);
            ganancia.TabIndex = 46;
            ganancia.Text = "ganancia";
            ganancia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // estadisticaUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 155, 74);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(ganancia);
            Controls.Add(ganancia_label);
            Controls.Add(recaudo);
            Controls.Add(recaudo_label);
            Controls.Add(batata);
            Controls.Add(membrillo);
            Controls.Add(docenas);
            Controls.Add(batata_label);
            Controls.Add(membrillo_label);
            Controls.Add(docena_label);
            Controls.Add(Titulo);
            ForeColor = Color.White;
            Name = "estadisticaUserControl";
            Size = new Size(765, 568);
            Load += estadisticaUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label docena_label;
        private Label membrillo_label;
        private Label batata_label;
        private Label docenas;
        private Label membrillo;
        private Label batata;
        private Label recaudo_label;
        private Label recaudo;
        private Label ganancia_label;
        private Label ganancia;
    }
}
