using PastelitosApp.Models;
using PastelitosApp.Services;
using System.Collections.ObjectModel;

namespace PastelitosApp;

public partial class MainPage : ContentPage
{
    private ObservableCollection<Pedido> _pedidos;

    public MainPage()
    {
        InitializeComponent();
        _pedidos = new ObservableCollection<Pedido>();
        PedidosCollectionView.ItemsSource = _pedidos;

        CargarPedidos();
    }

    private void CargarPedidos()
    {
        var pedidos = PedidoService.CargarPedidos();

        _pedidos.Clear();
        foreach (var pedido in pedidos)
        {
            _pedidos.Add(pedido);
        }
    }
}
