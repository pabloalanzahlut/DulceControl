[Serializable]
public class Pedido
{
    public required string Nombre { get; set; }
    public int Membrillo { get; set; }
    public int Batata { get; set; }

    public int Total => Membrillo + Batata;

    public int Precio
    {
        get
        {
            int total = Total;
            int docenas = total / 6;
            int sueltos = total % 6;
            int precio = 0;
            const int PRECIO_MEDIA = 2400, PRECIO_DOCENA = 4500, PRECIO_DOS_DOCENA = 8000;

            while (docenas > 0)
            {
                if (docenas >= 4) { precio += PRECIO_DOS_DOCENA; docenas -= 4; }
                else if (docenas >= 2) { precio += PRECIO_DOCENA; docenas -= 2; }
                else { precio += PRECIO_MEDIA; docenas--; }
            }

            precio += sueltos * 400;
            return precio;
        }
    }
}
