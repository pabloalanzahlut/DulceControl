namespace DulceControl.Models
{
    internal class Pedido : SistemaPedidos.Pedido
    {
        public new string Nombre { get; set; } = string.Empty;
        public new int CantMembrillo { get; set; }
        public new int CantBatata { get; set; }
        public new int Precio { get; set; }

    }
}