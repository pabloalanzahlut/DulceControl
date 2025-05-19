using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace PastelitosApp
{
    public partial class MainPage : ContentPage
    {
        // Colección observable para la lista de pedidos
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Inicializar lista de pedidos con datos de ejemplo
            Pedidos = new ObservableCollection<Pedido>
            {
                new Pedido { Nombre = "Fer Di Ioro", Detalle = "4 / 2 $2400", Estado = "Pedido", Pastelitos = "Membrillo: 95, Batata: 92", Pagado = false, Entregado = false },
                // Agrega más pedidos aquí...
            };

            // Asignar la lista al CollectionView
            PedidosCollectionView.ItemsSource = Pedidos;
        }

        private void OnGuardarCambiosClicked(object sender, EventArgs e)
        {
            // Aquí pondrás la lógica para guardar cambios, por ejemplo a archivo binario
        }
    }

    // Clase para representar un pedido
    public class Pedido
    {
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string Pastelitos { get; set; }
        public bool Pagado { get; set; }
        public bool Entregado { get; set; }
    }
}
