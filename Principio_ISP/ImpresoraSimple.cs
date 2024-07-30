namespace Principio_ISP
{
    public class ImpresoraSimple : IImprimir
    {
        public void Imprimir(Documento documento)
        {
            // Implementación de impresión
            Console.WriteLine($"Imprimiendo documento: {documento.Nombre}");
        }
    }

    public class ImpresoraMultifuncion : IImprimir, IEscanear
    {
        public void Imprimir(Documento documento)
        {
            // Implementación de impresión
            Console.WriteLine($"Imprimiendo documento: {documento.Nombre}");
        }

        public void Escanear(Documento documento)
        {
            // Implementación de escaneo
            Console.WriteLine($"Escaneando documento: {documento.Nombre}");
        }
    }

}