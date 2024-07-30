namespace Principio_ISP
{
    public interface IImprimir
    {
        void Imprimir(Documento documento);
    }

    public interface IEscanear
    {
        void Escanear(Documento documento);
    }



}