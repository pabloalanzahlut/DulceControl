namespace Pastelitos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Pedido = new CheckedListBox();
            Entregado = new CheckedListBox();
            Pagado = new CheckedListBox();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 255);
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(219, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "  🍩 DulceControl ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 113);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 36);
            textBox2.TabIndex = 1;
            // 
            // Pedido
            // 
            Pedido.FormattingEnabled = true;
            Pedido.Location = new Point(219, 248);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(120, 22);
            Pedido.TabIndex = 2;
            // 
            // Entregado
            // 
            Entregado.FormattingEnabled = true;
            Entregado.Location = new Point(369, 248);
            Entregado.Name = "Entregado";
            Entregado.Size = new Size(120, 22);
            Entregado.TabIndex = 3;
            // 
            // Pagado
            // 
            Pagado.FormattingEnabled = true;
            Pagado.Location = new Point(219, 297);
            Pagado.Name = "Pagado";
            Pagado.Size = new Size(120, 22);
            Pagado.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-reiniciar-64.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 116);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Cliente: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 167);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Pedido: Media Docena";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 167);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "Entregadas";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(477, 165);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(285, 165);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(69, 23);
            numericUpDown2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 208);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Monto: $";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 201);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 29);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 248);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Monto: $";
            // 
            // button1
            // 
            button1.Location = new Point(219, 358);
            button1.Name = "button1";
            button1.Size = new Size(102, 31);
            button1.TabIndex = 13;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(345, 358);
            button2.Name = "button2";
            button2.Size = new Size(102, 31);
            button2.TabIndex = 14;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(467, 358);
            button3.Name = "button3";
            button3.Size = new Size(102, 31);
            button3.TabIndex = 15;
            button3.Text = "Ver Historial";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(219, 436);
            button4.Name = "button4";
            button4.Size = new Size(350, 31);
            button4.TabIndex = 16;
            button4.Text = "+ Añadir nuevo pedido";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(219, 494);
            button5.Name = "button5";
            button5.Size = new Size(350, 31);
            button5.TabIndex = 17;
            button5.Text = "Ver estadisticas";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(765, 568);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Pagado);
            Controls.Add(Entregado);
            Controls.Add(Pedido);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private CheckedListBox Pedido;
        private CheckedListBox Entregado;
        private CheckedListBox Pagado;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
