using PastelitosApp.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace PastelitosApp.Services;

public static class PedidoService
{
    private static string FilePath =>
        Path.Combine(FileSystem.AppDataDirectory, "pedidos.bin");

    public static List<Pedido> CargarPedidos()
    {
        if (!File.Exists(FilePath))
            return new List<Pedido>();

        try
        {
            using var fs = new FileStream(FilePath, FileMode.Open);
            var formatter = new BinaryFormatter();
            return (List<Pedido>)formatter.Deserialize(fs);
        }
        catch
        {
            return new List<Pedido>();
        }
    }

    public static void GuardarPedidos(List<Pedido> pedidos)
    {
        try
        {
            using var fs = new FileStream(FilePath, FileMode.Create);
            var formatter = new BinaryFormatter();
            formatter.Serialize(fs, pedidos);
        }
        catch
        {
            // Error al guardar
        }
    }
}
