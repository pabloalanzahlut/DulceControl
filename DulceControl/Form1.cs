namespace Pastelitos
{
    public partial class Form1 : Form
    {
        public void MostrarControl(UserControl control)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        public Form1()
        {
            InitializeComponent();
            MostrarControl(new menuPrincipalUserControl());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
