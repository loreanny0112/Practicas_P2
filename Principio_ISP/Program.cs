namespace Principio_ISP {
public class Programa
{
    public static void Main(string[] args)
    {
        Documento doc = new Documento { Nombre = "Documento de Prueba", Descripcion = "Un documento para pruebas" };

        IImprimir impresoraSimple = new ImpresoraSimple();
        impresoraSimple.Imprimir(doc);

        ImpresoraMultifuncion impresoraMultifuncion = new ImpresoraMultifuncion();
        impresoraMultifuncion.Imprimir(doc);
        impresoraMultifuncion.Escanear(doc);

        Console.WriteLine("Impresión y escaneo completados exitosamente.");
    }
}
}