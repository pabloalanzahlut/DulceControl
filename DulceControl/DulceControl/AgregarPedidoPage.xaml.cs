using PastelitosApp.Models;
using PastelitosApp.Services;

namespace PastelitosApp;

public partial class AgregarPedidoPage : ContentPage
{
    public AgregarPedidoPage()
    {
        InitializeComponent();
    }

    private void OnGuardarPedidoClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NombreEntry.Text) ||
            !int.TryParse(MembrilloEntry.Text, out int membrillo) ||
            !int.TryParse(BatataEntry.Text, out int batata) ||
            !decimal.TryParse(PrecioEntry.Text, out decimal precio))
        {
            DisplayAlert("Error", "Completa todos los campos correctamente", "OK");
            return;
        }

        var nuevoPedido = new Pedido
        {
            Nombre = NombreEntry.Text,
            CantidadMembrillo = membrillo,
            CantidadBatata = batata,
            PrecioTotal = precio,
            Pagado = PagadoCheck.IsChecked,
            Entregado = EntregadoCheck.IsChecked
        };

        var pedidos = PedidoService.CargarPedidos();
        pedidos.Add(nuevoPedido);
        PedidoService.GuardarPedidos(pedidos);

        DisplayAlert("Guardado", "Pedido agregado correctamente", "OK");
        Navigation.PopAsync(); // Volver al MainPage
    }
}