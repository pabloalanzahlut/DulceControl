namespace PastelitosApp.Models;

[Serializable]
public class Pedido
{
    public string Nombre { get; set; } = string.Empty;

    public int CantidadMembrillo { get; set; } // pastelitos
    public int CantidadBatata { get; set; }    // pastelitos

    public decimal PrecioTotal { get; set; }

    public bool Pagado { get; set; }
    public bool Entregado { get; set; }

    public string Estado => $"{(Pagado ? "Pagado" : "No pagado")} | {(Entregado ? "Entregado" : "Pendiente")}";

    public string Detalle => $"Membrillo: {CantidadMembrillo} - Batata: {CantidadBatata}";

    public string Pastelitos => $"Total Pastelitos: {CantidadMembrillo + CantidadBatata} - Precio: ${PrecioTotal}";
}
