namespace Principio_SRP.Models
{
   public class Persona
    {
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string Direccion { get; private set; }
        public string CorreoElectronico { get; private set; }

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
         {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
         }
    }

}